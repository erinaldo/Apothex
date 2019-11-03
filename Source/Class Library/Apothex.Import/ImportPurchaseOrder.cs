using System.Data;
using Apothex.DataType;
using Zek.Core;
using Zek.Data;
using Apothex.Common;

namespace Apothex.Import
{
    public enum ImportFileTypes
    {
        Excel,
        PSP,
        Aversi,
        GPC,
        KalinaGeorgia
    }

    public class ImportPurchaseOrder
    {

        public ImportPurchaseOrder(string file, ImportFileTypes importFileTypes, decimal unitPricePct, decimal taxRate, decimal discount)
        {
            _file = file;
            _importFileType = importFileTypes;
            _unitPricePct = unitPricePct;
            _taxRate = taxRate;
            _discount = discount;
        }

        private string _file;
        private ImportFileTypes _importFileType;
        DS_Import ds_Import = new DS_Import();
        private decimal _unitPricePct;
        private decimal _taxRate;
        private decimal _discount;

        public DS_Import.PurchaseOrderDetailDataTable Import()
        {
            BindData();
            InitImportDataTable();
            SynchronizeDictionary(ds_Import.PurchaseOrderDetail, ObjectNames.Brand, ds_Import.PurchaseOrderDetail.BrandIDColumn.ColumnName, false, null, ds_Import.PurchaseOrderDetail.BrandNameColumn.ColumnName);
            SynchronizeDictionary(ds_Import.PurchaseOrderDetail, ObjectNames.Country, ds_Import.PurchaseOrderDetail.CountryCodeColumn.ColumnName, true, null, ds_Import.PurchaseOrderDetail.CountryNameColumn.ColumnName);
            SynchronizeDictionary(ds_Import.PurchaseOrderDetail, ObjectNames.MedicamentCategory, ds_Import.PurchaseOrderDetail.MedicamentCategoryIDColumn.ColumnName, false, null, ds_Import.PurchaseOrderDetail.MedicamentCategoryNameColumn.ColumnName);
            SynchronizeDictionary(ds_Import.PurchaseOrderDetail, ObjectNames.MedicamentSubcategory, ds_Import.PurchaseOrderDetail.MedicamentSubcategoryIDColumn.ColumnName, false, ds_Import.PurchaseOrderDetail.MedicamentCategoryNameColumn.ColumnName, ds_Import.PurchaseOrderDetail.MedicamentSubcategoryNameColumn.ColumnName);
            SynchronizeDictionary(ds_Import.PurchaseOrderDetail, ObjectNames.UnitMeasure, ds_Import.PurchaseOrderDetail.SizeUnitMeasureCodeColumn.ColumnName, true, null, ds_Import.PurchaseOrderDetail.SizeUnitMeasureNameColumn.ColumnName);
            SynchronizeDictionary(ds_Import.PurchaseOrderDetail, ObjectNames.UnitMeasure, ds_Import.PurchaseOrderDetail.WeightUnitMeasureCodeColumn.ColumnName, true, null, ds_Import.PurchaseOrderDetail.WeightUnitMeasureNameColumn.ColumnName);
            ImportMedicament();

            return ds_Import.PurchaseOrderDetail;
        }
        private void InitImportDataTable()
        {
            if (_discount == 0m) return;
            foreach (var row in ds_Import.PurchaseOrderDetail)
            {
                if (row.IsDataRowDeleted()) continue;

                //Iif([_ListPrice] != 0m,  (1m-[UnitPrice]/[_ListPrice]), 1m)
                row.DiscountPct = row.ListPrice != 0 ? (1m - (row.UnitPrice / row.ListPrice)) - (_discount / 100m) : 0m;
            }
        }

        private void BindData()
        {
            switch (_importFileType)
            {
                case ImportFileTypes.Excel:
                    BindExcelData();
                    break;

                case ImportFileTypes.PSP:
                    BindPSPData();
                    break;

                case ImportFileTypes.Aversi:
                    BindAversiData();
                    break;

                case ImportFileTypes.GPC:
                    BindGPCData();
                    break;

                case ImportFileTypes.KalinaGeorgia:
                    BindKalinaGeorgiaData();
                    break;
            }
        }
        private void BindPSPData()
        {
            var helper = new PSPHelper(_file, _unitPricePct, _taxRate);
            var table = new DS_PSP.T_DBFDataTable();
            helper.Fill(table);

            foreach (var row in table)
            {
                if (row.IsNAME_GEONull() || row.NAME_GEO.Trim().Length == 0) continue;
                var newRow = ds_Import.PurchaseOrderDetail.NewPurchaseOrderDetailRow();


                newRow.ReceivedQty = row.RAOD;
                newRow.UnitPrice = row._UNIT_PRICE_GEL;
                newRow.TaxRate = _taxRate / 100m;
                newRow.ListPrice = row.SUM_LAR_D;
                newRow.ProductCurrencyCode = GlobalVariable.MyCompanyConditionalUnitCurrencyCode;

                if (!row.IsSERIANull()) newRow.Serie = row.SERIA;
                if (!row.Is_VADANull()) newRow.ValidDate = row._VADA;
                if (!row.IsMANUFNull()) newRow.BrandName = row.NAME_MANUF;
                if (!row.IsCOUNTRYNull()) newRow.CountryName = row.COUNTRY;

                newRow.MedicamentName = row.NAME_GEO.Trim();

                ds_Import.PurchaseOrderDetail.AddPurchaseOrderDetailRow(newRow);
            }
        }
        private void BindAversiData()
        {
            var helper = new AversiHelper(_file, _unitPricePct, _taxRate);
            var table = new DS_Aversi.T_ImportDataTable();
            helper.Fill(table);

            foreach (var row in table)
            {
                if (row.IsNAM_MATNull() || row.NAM_MAT.Trim().Length == 0) continue;
                var newRow = ds_Import.PurchaseOrderDetail.NewPurchaseOrderDetailRow();

                newRow.ReceivedQty = row.NUM_KRIT;
                newRow.UnitPrice = row.ZAK_PRI;
                newRow.TaxRate = _taxRate / 100m;
                newRow.ListPrice = MathHelper.AddPct(row.PRICE, _taxRate);//გასარკვევია შედის თუ არა პსპ-ში დღგ...
                newRow.ProductCurrencyCode = GlobalVariable.MyCompanyConditionalUnitCurrencyCode;

                if (!row.IsSERIANull()) newRow.Serie = row.SERIA;
                if (!row.IsDAT_GOODNull()) newRow.ValidDate = row.DAT_GOOD;
                if (!row.IsPRONAMENull()) newRow.BrandName = row.PRONAME;
                if (!row.IsNAM_CONGNull()) newRow.CountryName = row.NAM_CONG;

                newRow.MedicamentName = row.NAM_MAT.Trim();

                ds_Import.PurchaseOrderDetail.AddPurchaseOrderDetailRow(newRow);
            }
        }
        private void BindGPCData()
        {
            var helper = new GPCHelper(_file, _unitPricePct, _taxRate);
            var table = new DS_GPC.T_GPCDataTable();
            helper.Fill(table);

            foreach (var row in table)
            {
                if (row.IsnameNull() || row.name.Trim().Length == 0) continue;
                var newRow = ds_Import.PurchaseOrderDetail.NewPurchaseOrderDetailRow();

                newRow.ReceivedQty = row.sum_quanti;
                newRow.UnitPrice = row._UnitPriceGEL;
                newRow.TaxRate = _taxRate / 100m;
                newRow.ListPrice = row._SalePriceGEL;
                newRow.ProductCurrencyCode = GlobalVariable.MyCompanyConditionalUnitCurrencyCode;

                if (!row.Isexp_21Null()) newRow.Serie = row.exp_21;
                if (!row.IsgoodNull()) newRow.ValidDate = row.good;
                if (!row.IscountryNull()) newRow.BrandName = row.country;
                if (!row.Isexp_35Null()) newRow.CountryName = row.exp_35;

                newRow.MedicamentName = row.name.Trim();

                ds_Import.PurchaseOrderDetail.AddPurchaseOrderDetailRow(newRow);
            }
        }
        private void BindExcelData()
        {
            var table = ExcelHelper.GetDataTable(_file, "*", "Sheet1");
            ds_Import.PurchaseOrderDetail.Clear();
            int i;
            foreach (DataRow row in table.Rows)
            {
                ds_Import.PurchaseOrderDetail.ImportRow(row);
                i = ds_Import.PurchaseOrderDetail.Count - 1;

                ds_Import.PurchaseOrderDetail[i].DiscountPct = ds_Import.PurchaseOrderDetail[i].IsDiscountPctNull() ? 0m : ds_Import.PurchaseOrderDetail[i].DiscountPct / 100m;
                ds_Import.PurchaseOrderDetail[i].TaxRate = ds_Import.PurchaseOrderDetail[i].IsTaxRateNull() ? 0m : ds_Import.PurchaseOrderDetail[i].TaxRate / 100m;
            }
        }
        private void BindKalinaGeorgiaData()
        {
            var table = new DS_KalinaGeorgia.T_ImportDataTable();
            var tmp = ExcelHelper.GetDataTable(_file, "*", "TDSheet");
            tmp.Replace("დღგ-ს %", "%", "");
            tmp.AcceptChanges();

            table.ImportRows(tmp);


            foreach (var row in table)
            {
                if (row.ნომენკლატურა.Trim().Length == 0) continue;
                var newRow = ds_Import.PurchaseOrderDetail.NewPurchaseOrderDetailRow();

                newRow.ReceivedQty = row.რაოდენობა;
                newRow.UnitPrice = MathHelper.RemoveAddedPct(MathHelper.RemovePct(row.ფასი, row.___ავტ__ფასდ_), row._დღგ_ს__);
                newRow.TaxRate = row._დღგ_ს__ / 100m;
                newRow.ListPrice = row.ფასი;
                newRow.ProductCurrencyCode = "GEL";

                newRow.MedicamentName = row.ნომენკლატურა.Trim();
                ds_Import.PurchaseOrderDetail.AddPurchaseOrderDetailRow(newRow);
            }
        }

        private static void SynchronizeDictionary(DataTable table, ObjectNames objectName, string fieldID, bool chekByID, string fieldParentName, string fieldName)
        {
            ImportManager.SynchronizeDictionary(table, objectName, fieldID, chekByID, fieldParentName, fieldName);
        }
        private void ImportMedicament()
        {
            var table = new DS_Medicament.SP_GetMedicamentDataTable();
            table.SetAllowDBNull(true);
            foreach (var row in ds_Import.PurchaseOrderDetail)
            {
                if (row.IsMedicamentNameNull() || row.MedicamentName.Trim().Length == 0) continue;
                //ზედმეტ ასოებს აშორებს.
                row.MedicamentName = row.MedicamentName.Replace("\n", string.Empty).Replace("\t", string.Empty).Trim();

                var newRow = table.NewSP_GetMedicamentRow();
                if (!row.IsMedicamentSubcategoryIDNull())
                    newRow.MedicamentSubcategoryID = row.MedicamentSubcategoryID;
                if (!row.IsMedicamentNameNull())
                    newRow.Name = row.MedicamentName;
                if (!row.IsProductNumberNull())
                    newRow.ProductNumber = row.ProductNumber;
                if (!row.IsMakeFlagNull())
                    newRow.MakeFlag = row.MakeFlag;
                if (!row.IsFinishedGoodsFlagNull())
                    newRow.FinishedGoodsFlag = row.FinishedGoodsFlag;
                if (!row.IsColorNull())
                    newRow.Color = row.Color;
                if (!row.IsSafetyStockLevelNull())
                    newRow.SafetyStockLevel = row.SafetyStockLevel;
                if (!row.IsReorderPointNull())
                    newRow.ReorderPoint = row.ReorderPoint;
                if (!row.IsStandardCostNull())
                    newRow.StandardCost = row.StandardCost;
                if (!row.IsListPriceNull())
                    newRow.ListPrice = row.ListPrice;
                if (!row.IsDealerPriceNull())
                    newRow.DealerPrice = row.DealerPrice;
                if (!row.IsDiscountPctNull())
                    newRow.DiscountPct = row.DiscountPct;
                if (!row.IsTaxRateNull())
                    newRow.TaxRate = row.TaxRate;
                if (!row.IsSizeNull())
                    newRow.Size = row.Size;
                if (!row.IsSizeRangeNull())
                    newRow.SizeRange = row.SizeRange;
                if (!row.IsSizeUnitMeasureCodeNull())
                    newRow.SizeUnitMeasureCode = row.SizeUnitMeasureCode;
                if (!row.IsWeightNull())
                    newRow.Weight = row.Weight;
                if (!row.IsWeightUnitMeasureCodeNull())
                    newRow.WeightUnitMeasureCode = row.WeightUnitMeasureCode;
                if (!row.IsDaysToManufactureNull())
                    newRow.DaysToManufacture = row.DaysToManufacture;
                if (!row.IsProductLineNull())
                    newRow.ProductLine = row.ProductLine;
                if (!row.IsClassNull())
                    newRow.Class = row.Class;
                if (!row.IsStyleNull())
                    newRow.Style = row.Style;
                if (!row.IsProductModelIDNull())
                    newRow.ProductModelID = row.ProductModelID;
                if (!row.IsSellStartDateNull())
                    newRow.SellStartDate = row.SellStartDate;
                if (!row.IsSellEndDateNull())
                    newRow.SellEndDate = row.SellEndDate;
                if (!row.IsDiscontinuedDateNull())
                    newRow.DiscontinuedDate = row.DiscontinuedDate;
                if (!row.IsUnitsInStockNull())
                    newRow.UnitsInStock = row.UnitsInStock;
                //if (!row.IsValidDateNull())
                //    newRow.ValidDate = row.ValidDate;
                //if (!row.IsCountryCodeNull())
                //    newRow.CountryCode = row.CountryCode;
                //if (!row.IsBrandIDNull())
                //    newRow.BrandID = row.BrandID;
                //if (!row.IsSerieNull())
                //    newRow.Serie = row.Serie;

                //newRow.Status = (byte)Statuses.Pending;
                //newRow.ModifiedUserID = GlobalVariable.UserID;
                //newRow.ModifiedDate = GlobalVariable.ServerDateTime;

                table.AddSP_GetMedicamentRow(newRow);
            }


            table.PrimaryKey = null;
            table.RemoveColumns(table.MedicamentIDColumn,
                //table.StandardCostColumn,
                //table.ListPriceColumn,
                //table.DealerPriceColumn,
                //table.DiscountPctColumn,
                //table.TaxRateColumn,
                                        table.ValidDateColumn,
                                        table.CountryCodeColumn,
                                        table.BrandIDColumn,
                                        table.SerieColumn,
                                        table.StatusColumn,
                                        table.ModifiedUserIDColumn,
                                        table.ModifiedDateColumn,
                                        table.ApproverUserIDColumn);

            var newTable = table.SelectDistinct(true, table.Columns, table.NameColumn);
            var xmlTable = newTable.PackAlternationTypedDataTable<DataTable>(dataRowState: DataRowState.Added, addActionColumn: true);
            ImportManager.ImportDataTable(ObjectNames.Medicament, xmlTable);
            ImportManager.InitID(ds_Import.PurchaseOrderDetail, ObjectNames.Medicament, ds_Import.PurchaseOrderDetail.MedicamentIDColumn.ColumnName, false, null, ds_Import.PurchaseOrderDetail.MedicamentNameColumn.ColumnName);
        }
    }
}
