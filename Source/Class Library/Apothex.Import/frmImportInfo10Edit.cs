using System;
using System.Data;
using System.Windows.Forms;
using Apothex.Windows.Forms;
using DevExpress.XtraEditors;

using Apothex.DataManagment.Dictionary;
using Apothex.DataType;
using DevExpress.XtraGrid.Views.Base;
using Zek.Core;
using Apothex.Common;
using Zek.Data;
using Zek.Extensions;
using Zek.Extensions.DevEx;
using Zek.Windows.Forms.DevEx;

namespace Apothex.Import
{
    public partial class frmImportInfo10Edit : frmEditBrowse
    {
        public frmImportInfo10Edit()
        {
            InitializeComponent();

            saveFileDialog.Filter = XtraGridHelper.GetSaveFileDialogFilter();
            XtraGridHelper.InitGrid(gridImport);
            XtraGridHelper.InitGrid(gridImportedPurchase);
            XtraGridHelper.InitGrid(gridExcelSales);
            XtraGridHelper.InitGrid(gridSaledSalesOrderDetail);
            XtraGridHelper.InitGrid(gridReInitedSalesOrderDetail);
            viewImport.SetCustomDrawRowIndicator();
            viewImportedPurchaseOrderHeader.SetCustomDrawRowIndicator();
            viewImportedSalesOrderHeader.SetCustomDrawRowIndicator();
            viewSaledSalesOrderDetail.SetCustomDrawRowIndicator();
            viewReInitedSalesOrderDetail.SetCustomDrawRowIndicator();

            _ViewSP_GetPurchaseOrderHeader = ds_ImportedPurchasing.SP_GetPurchaseOrderHeader.DefaultView;
            _ViewSP_GetPurchaseOrderHeader.Sort = ds_ImportedPurchasing.SP_GetPurchaseOrderHeader.PurchaseOrderIDColumn.ColumnName;

            _ViewSP_GetSalesOrderHeader = ds_ImportedSales.SP_GetSalesOrderHeader.DefaultView;
            _ViewSP_GetSalesOrderHeader.Sort = ds_ImportedSales.SP_GetSalesOrderHeader.SalesOrderIDColumn.ColumnName;
        }

        #region Fields
        public string CurrencyCode1
        {
            get { return ConvertHelper.ToString(lookCurrency1.EditValue); }
            set { lookCurrency1.EditValue = value; }
        }
        public string CurrencyCode2
        {
            get { return ConvertHelper.ToString(lookCurrency2.EditValue); }
            set { lookCurrency2.EditValue = value; }
        }
        public decimal CurrencyRate1
        {
            get { return ConvertHelper.ToDecimal(lookCurrency1.GetColumnValue("Code")); }
        }
        public decimal CurrencyRate2
        {
            get { return ConvertHelper.ToDecimal(lookCurrency2.GetColumnValue("Code")); }
        }
        public decimal CrossRate1
        {
            get { return CurrencyRate1 / CurrencyRate2; }
        }
        public decimal CrossRate2
        {
            //get { return GlobalVariable.MyCompanyConditionalUnitCurrencyRate / CurrencyRate2; }
            get { throw new NotImplementedException("GlobalVariable.MyCompanyConditionalUnitCurrencyRate გაუქმებულია."); }
        }
        public int BranchID
        {
            get { return ConvertHelper.ToInt32(lookBranch.EditValue); }
        }
        public string BranchName
        {
            get { return lookBranch.Text; }
        }
        private DataView _ViewSP_GetPurchaseOrderHeader;
        private DataView _ViewSP_GetSalesOrderHeader;
        #endregion

        #region Bindings
        protected override void BindControls()
        {
            bsBranch.DataSource = DictionaryManager.GetDictionary(ObjectNames.Branch);
            bsCurrency1.DataSource = DictionaryManager.GetDictionary(ObjectNames.CurrencyWithLastRate);
            bsCurrency2.DataSource = DictionaryManager.GetDictionary(ObjectNames.CurrencyWithLastRate);
            CurrencyCode1 = GlobalVariable.MyCompanyDefaultTradingCurrencyCode;
            CurrencyCode2 = GlobalVariable.MyCompanyDefaultTradingCurrencyCode;
        }
        protected override void BindData()
        {
        }
        #endregion

        #region Validations
        public bool IsValidBranch()
        {
            if (BranchID == 0)
            {
                dxErrorProvider.SetError(lookBranch, "!");
                return false;
            }

            return true;
        }
        public bool IsValidGrid()
        {
            var flag = true;
            foreach (var row in ds_Import.T_Info10)
            {
                if (row.RowState == DataRowState.Deleted || row.RowState == DataRowState.Detached) continue;
                row.ClearErrors();

                if (row.OperationType.Trim().ToUpper() != "P" && row.OperationType.Trim().ToUpper() != "S")
                    row.SetColumnError(ds_Import.T_Info10.OperationTypeColumn, "მიუთითეთ მნიშვნელობა P ან S.");
                if (row.IsOrderNumberNull())
                    row.SetColumnError(ds_Import.T_Info10.OrderNumberColumn, "მიუთითეთ მნიშვნელობა.");
                if (row.IsOrderDateNull())
                    row.SetColumnError(ds_Import.T_Info10.OrderDateColumn, "მიუთითეთ მნიშვნელობა.");
                if (row.MedicamentName.Trim().Length == 0)
                    row.SetColumnError(ds_Import.T_Info10.MedicamentNameColumn, "მიუთითეთ მნიშვნელობა.");
                if (row.OperationQty <= 0m)
                    row.SetColumnError(ds_Import.T_Info10.OperationQtyColumn, "მნიშვნელობა უნდა აღემატებოდეს 0-ს.");
                if (row.StandardCost < 0m)
                    row.SetColumnError(ds_Import.T_Info10.StandardCostColumn, "მნიშვნელობა არ შეიძლება იყოს უარყოფითი.");
                if (row.ListPrice < 0m)
                    row.SetColumnError(ds_Import.T_Info10.ListPriceColumn, "მნიშვნელობა არ შეიძლება იყოს უარყოფითი.");
                if (row.DiscountPct < 0m || row.DiscountPct > 100m)
                    row.SetColumnError(ds_Import.T_Info10.DiscountPctColumn, "მნიშვნელობა უნდა იყოს 0-100 შუალედში.");
                if (row.TaxRate < 0m || row.TaxRate > 100m)
                    row.SetColumnError(ds_Import.T_Info10.TaxRateColumn, "მნიშვნელობა უნდა იყოს 0-100 შუალედში.");

                row.ErrorFlag = row.HasErrors;
                if (row.ErrorFlag)
                    flag = false;
            }

            return flag;
        }
        protected override bool IsValidForm()
        {
            var flag = true;
            if (!IsValidBranch()) flag = false;
            if (!IsValidGrid()) flag = false;
            return flag;
        }
        #endregion

        #region Methods
        public void AddPurchaseOrderHeader(int id)
        {
            var row = ds_ImportedPurchasing.SP_GetPurchaseOrderHeader.NewSP_GetPurchaseOrderHeaderRow();
            row.PurchaseOrderID = id;
            row.rowguid = Guid.NewGuid();
            row.BranchID = BranchID;
            row.BranchName = BranchName;
            row.OrderDate = DateTimeHelper.MinDate;
            row.SubTotal = 0m;
            row.TaxAmt = 0m;
            row.Freight = 0m;
            row.TotalDue = 0m;
            row.CurrencyCode = CurrencyCode2;
            row.RevisionNumber = 0;
            row.Status = (byte)DatabaseStatus.Approved;
            row.ModifiedUserID = BaseGlobalVariable.UserID;
            row.ModifiedDate = BaseGlobalVariable.ServerDateTime;
            ds_ImportedPurchasing.SP_GetPurchaseOrderHeader.AddSP_GetPurchaseOrderHeaderRow(row);
        }
        public void AddSalesOrderHeader(int id)
        {
            var row = ds_ImportedSales.SP_GetSalesOrderHeader.NewSP_GetSalesOrderHeaderRow();
            row.SalesOrderID = id;
            row.rowguid = Guid.NewGuid();
            row.BranchID = BranchID;
            row.BranchName = BranchName;
            row.OrderDate = DateTimeHelper.MinDate;
            row.SubTotal = 0m;
            row.TaxAmt = 0m;
            row.Freight = 0m;
            row.TotalDue = 0m;
            row.CurrencyCode = CurrencyCode2;
            row.RevisionNumber = 0;
            row.Status = (byte)DatabaseStatus.Approved;
            row.ModifiedUserID = BaseGlobalVariable.UserID;
            row.ModifiedDate = BaseGlobalVariable.ServerDateTime;
            ds_ImportedSales.SP_GetSalesOrderHeader.AddSP_GetSalesOrderHeaderRow(row);
        }
        public void ImportMedicament()
        {
            var table = new DS_Medicament.SP_GetMedicamentDataTable();
            table.SetAllowDBNull(true);
            foreach (var row in ds_Import.T_Info10)
            {
                if (row.IsMedicamentNameNull() || row.MedicamentName.Trim().Length == 0) continue;
                //ზედმეტ ასოებს აშორებს.
                row.MedicamentName = row.MedicamentName.Replace("\n", string.Empty).Replace("\t", string.Empty).Trim();

                var newRow = table.NewSP_GetMedicamentRow();
                newRow.Name = row.MedicamentName;
                table.AddSP_GetMedicamentRow(newRow);
            }


            table.PrimaryKey = null;
            table.RemoveColumns(table.MedicamentIDColumn,
                                        table.StandardCostColumn,
                                        table.ListPriceColumn,
                                        table.DealerPriceColumn,
                                        table.DiscountPctColumn,
                                        table.TaxRateColumn,
                                        table.ValidDateColumn,
                                        table.CountryCodeColumn,
                                        table.BrandIDColumn,
                                        table.SerieColumn,
                                        table.StatusColumn,
                                        table.ModifiedUserIDColumn,
                                        table.ModifiedDateColumn,
                                        table.ApproverUserIDColumn);

            var newTable = table.SelectDistinct(true, table.Columns, table.NameColumn);
            var xmlTable = newTable.PackAlternationTypedDataTable(dataRowState: DataRowState.Added, addActionColumn: true);
            ImportManager.ImportDataTable(ObjectNames.Medicament, xmlTable);
            ImportManager.InitID(ds_Import.T_Info10, ObjectNames.Medicament, ds_Import.T_Info10.MedicamentIDColumn.ColumnName, false, null, ds_Import.T_Info10.MedicamentNameColumn.ColumnName);
        }
        public void InitImportedSales()
        {
            //if (!IsValid) return;
            //try
            //{
            //    Application.DoEvents();
            //    Cursor = Cursors.WaitCursor;
                
            //    ds_ImportedSales.Clear();
            //    int branchID = BranchID;
            //    decimal rate1 = CrossRate1;
            //    decimal rate2 = CrossRate2;
            //    int recordIndex;

            //    DS_Purchasing.SP_GetPurchaseOrderDetailRow purchaseOrderDetailRow;
            //    DataView view = new DataView(ds_ResidualPurchasing.SP_GetPurchaseOrderDetail);
            //    string findKey = grpFindRowBy.Text;
            //    view.Sort = findKey;
            //    DataRowView[] rowViews;

            //    DS_Sales.SP_GetSalesOrderDetailRow newSalesOrderDetailRow;
            //    DS_Sales.SP_GetSalesOrderHeaderRow newSalesOrderHeaderRow;
            //    DS_Import.T_Info10Row tmpDistributeInfo10Row, info10Row;
            //    bool errorFlag;

            //    int i = 0;
            //    while (i < ds_Import.T_Info10.Count)
            //    {
            //        info10Row = ds_Import.T_Info10[i];
            //        i++;
            //        if (info10Row.RowState == DataRowState.Deleted || info10Row.OperationType.ToUpper() != "S")
            //            continue;

            //        newSalesOrderDetailRow = ds_ImportedSales.SP_GetSalesOrderDetail.NewSP_GetSalesOrderDetailRow();
            //        newSalesOrderDetailRow.SalesOrderDetailID = Guid.NewGuid();
            //        newSalesOrderDetailRow.SalesOrderID = info10Row.OrderNumber;
            //        newSalesOrderDetailRow.ProductLocationID = 0;
            //        newSalesOrderDetailRow.MedicamentName = info10Row.MedicamentName;

            //        newSalesOrderDetailRow.SaleQty = Math.Round(info10Row.OperationQty, 4);
            //        newSalesOrderDetailRow.ProductNumber = StringHelper.TrimString(info10Row.ProductNumber, 25);
            //        rowViews = view.FindRows(newSalesOrderDetailRow[findKey].ToString());
            //        if (rowViews.Length == 0)
            //        {
            //            info10Row.ErrorFlag = true;
            //            info10Row.SetColumnError(ds_Import.T_Info10.ProductNumberColumn, "ამ პროდუქტის ნომრით ვერ ვიპოვე ვერცერთი შესყიდვა");
            //            continue;
            //        }


            //        errorFlag = true;
            //        foreach (DataRowView rowView in rowViews)
            //        {
            //            purchaseOrderDetailRow = (DS_Purchasing.SP_GetPurchaseOrderDetailRow)rowView.Row;
            //            if (purchaseOrderDetailRow.ReceivedQty <= 0m) continue;

            //            errorFlag = false;
            //            newSalesOrderDetailRow.PurchaseOrderDetailID = purchaseOrderDetailRow.PurchaseOrderDetailID;
            //            if (purchaseOrderDetailRow.ReceivedQty >= newSalesOrderDetailRow.SaleQty)
            //            {
            //                purchaseOrderDetailRow.ReceivedQty -= newSalesOrderDetailRow.SaleQty;
            //                info10Row.OperationQty = 0m;
            //                break;
            //            }
            //            else
            //            {
            //                //უნდა დაუმატოთ ახალი ჩანაწერი და ეს ფენდინგინ უნდა ჩავსვათ
            //                tmpDistributeInfo10Row = ds_Import.T_Info10.NewT_Info10Row();
            //                tmpDistributeInfo10Row.ItemArray = info10Row.ItemArray;
            //                tmpDistributeInfo10Row.OperationQty = newSalesOrderDetailRow.SaleQty - purchaseOrderDetailRow.ReceivedQty;
            //                ds_Import.T_Info10.AddT_Info10Row(tmpDistributeInfo10Row);
                            
            //                newSalesOrderDetailRow.SaleQty = purchaseOrderDetailRow.ReceivedQty;

            //                purchaseOrderDetailRow.ReceivedQty = 0m;
            //                info10Row.OperationQty = 0m;
            //            }
            //        }
            //        if (errorFlag)
            //        {
            //            info10Row.ErrorFlag = true;
            //            info10Row.SetColumnError(ds_Import.T_Info10.OperationQtyColumn, "გაყიდული რაოდენობა აჭარბებს შესყიდულს");
            //            continue;
            //        }


            //        newSalesOrderDetailRow.UnitPrice = Math.Round(info10Row.ListPrice * rate1, 4);
            //        newSalesOrderDetailRow.DiscountPct = info10Row.DiscountPct / 100m;
            //        newSalesOrderDetailRow.UnitPriceDiscount = newSalesOrderDetailRow.DiscountPct;
            //        newSalesOrderDetailRow.LineTotal = Math.Round((newSalesOrderDetailRow.UnitPrice * (1m - newSalesOrderDetailRow.UnitPriceDiscount) * newSalesOrderDetailRow.SaleQty), 4);
            //        newSalesOrderDetailRow.OrdinalNumber = 1;
            //        newSalesOrderDetailRow.ProductID = 0;
            //        newSalesOrderDetailRow.BranchID = branchID;
            //        //rowDetail.PurchaseOrderDetailID = ქვემოთ არის ჩატანილი

            //        newSalesOrderDetailRow.MedicamentID = info10Row.MedicamentID;
            //        //salesOrderDetailRow.ProductNumber = ConvertHelper.TrimString(info10Row.ProductNumber, 25);ზემოთ ავიტანე
            //        //salesOrderDetailRow.MedicamentName = info10Row.MedicamentName;//ზემოთ ავიტანე
            //        newSalesOrderDetailRow.Quantity = 0m;
            //        newSalesOrderDetailRow.StandardCost = Math.Round((info10Row.StandardCost * rate1) / rate2, 4);
            //        newSalesOrderDetailRow.ListPrice = Math.Round((info10Row.ListPrice * rate1) / rate2, 4);
            //        newSalesOrderDetailRow.DealerPrice = 0m;
            //        //rowDetail.DiscountPct = rowInfo10.DiscountPct / 100m;ზეოთაა ატანილი
            //        newSalesOrderDetailRow.TaxRate = info10Row.TaxRate / 100m;
            //        if (!info10Row.IsCountryCodeNull())
            //            newSalesOrderDetailRow.CountryCode = info10Row.CountryCode;
            //        if (!info10Row.IsCountryNameNull())
            //            newSalesOrderDetailRow.CountryName = info10Row.CountryName;
            //        if (!info10Row.IsBrandIDNull())
            //            newSalesOrderDetailRow.BrandID = info10Row.BrandID;
            //        if (!info10Row.IsBrandNameNull())
            //            newSalesOrderDetailRow.BrandName = info10Row.BrandName;
            //        if (!info10Row.IsSerieNull())
            //            newSalesOrderDetailRow.Serie = info10Row.Serie;
            //        newSalesOrderDetailRow.UnitsInStock = 1000;

            //        newSalesOrderDetailRow.ModifiedUserID = GlobalVariable.UserID;
            //        newSalesOrderDetailRow.ModifiedDate = GlobalVariable.ServerDateTime;

            //        newSalesOrderDetailRow._ResidualQty = 0m;
            //        newSalesOrderDetailRow._SaleUnitQty = 0;

            //        ds_ImportedSales.SP_GetSalesOrderDetail.AddSP_GetSalesOrderDetailRow(newSalesOrderDetailRow);




            //        recordIndex = _ViewSP_GetSalesOrderHeader.Find(info10Row.OrderNumber);
            //        if (recordIndex == -1)
            //        {
            //            AddSalesOrderHeader(info10Row.OrderNumber);
            //            recordIndex = _ViewSP_GetSalesOrderHeader.Find(info10Row.OrderNumber);
            //        }
            //        newSalesOrderHeaderRow = (DS_Sales.SP_GetSalesOrderHeaderRow)_ViewSP_GetSalesOrderHeader[recordIndex].Row;
            //        if (newSalesOrderHeaderRow.OrderDate == DateTimeHelper.MinDate && !info10Row.IsOrderDateNull())
            //            newSalesOrderHeaderRow.OrderDate = info10Row.OrderDate;
            //        if (newSalesOrderHeaderRow.IsCustomerIDNull() && !info10Row.IsCompanyIDNull())
            //            newSalesOrderHeaderRow.CustomerID = info10Row.CompanyID;
            //        if (newSalesOrderHeaderRow.IsCustomerNameNull() && !info10Row.IsCompanyNameNull())
            //            newSalesOrderHeaderRow.CustomerName = info10Row.CompanyName;
            //        newSalesOrderHeaderRow.SubTotal += newSalesOrderDetailRow.LineTotal;
            //        newSalesOrderHeaderRow.TaxAmt += Math.Round(newSalesOrderDetailRow.LineTotal * newSalesOrderDetailRow.TaxRate, 4);
            //        newSalesOrderHeaderRow.TotalDue = newSalesOrderHeaderRow.SubTotal + newSalesOrderHeaderRow.TaxAmt + newSalesOrderHeaderRow.Freight;

            //        if (info10Row.OperationQty == 0)
            //        {
            //            info10Row.Delete();
            //            i--;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show(this, string.Format("შეცდომა ინიციალიზაციის დროს.\n{0}", ex.Message), "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    Cursor = Cursors.Default;
            //}
        }
        /// <summary>
        /// მონაცემთა ბაზიდან გადმოტანილი ჩანაწერები
        /// </summary>
        public void InitSaledSales()
        {
            //if (!IsValid) return;
            //try
            //{
            //    Application.DoEvents();
            //    Cursor = Cursors.WaitCursor;

            //    ds_ReInitedSales.Clear();
            //    DS_Purchasing.SP_GetPurchaseOrderDetailRow purchaseOrderDetailRow;
            //    DataView view = new DataView(ds_ResidualPurchasing.SP_GetPurchaseOrderDetail);
            //    view.Sort = ds_ResidualPurchasing.SP_GetPurchaseOrderDetail.MedicamentNameColumn.ColumnName;
            //    DataRowView[] rowViews;

            //    DS_Sales.SP_GetSalesOrderDetailRow salesOrderDetailRow, newSalesOrderDetailRow, tmpDistributeSalesOrderDetailRow;
            //    bool errorFlag;

            //    int i = 0;
            //    while (i < ds_SaledSales.SP_GetSalesOrderDetail.Count)
            //    {
            //        salesOrderDetailRow = ds_SaledSales.SP_GetSalesOrderDetail[i];
            //        i++;
            //        if (salesOrderDetailRow.RowState == DataRowState.Deleted) continue;

            //        rowViews = view.FindRows(salesOrderDetailRow.MedicamentName);
            //        if (rowViews.Length == 0)
            //        {
            //            salesOrderDetailRow.SetColumnError(ds_SaledSales.SP_GetSalesOrderDetail.MedicamentNameColumn, "ამ დასახელებით ვერ ვიპოვე ვერცერთი შესყიდვა");
            //            continue;
            //        }

                    
            //        newSalesOrderDetailRow = ds_ReInitedSales.SP_GetSalesOrderDetail.NewSP_GetSalesOrderDetailRow();
            //        newSalesOrderDetailRow.ItemArray = salesOrderDetailRow.ItemArray;
            //        newSalesOrderDetailRow.SalesOrderDetailID = Guid.NewGuid();
            //        errorFlag = true;
            //        foreach (DataRowView rowView in rowViews)
            //        {
            //            purchaseOrderDetailRow = (DS_Purchasing.SP_GetPurchaseOrderDetailRow)rowView.Row;
            //            if (purchaseOrderDetailRow.ReceivedQty <= 0m) continue;

            //            newSalesOrderDetailRow.PurchaseOrderDetailID = purchaseOrderDetailRow.PurchaseOrderDetailID;
            //            errorFlag = false;

            //            if (purchaseOrderDetailRow.ReceivedQty >= salesOrderDetailRow.SaleQty)
            //            {
            //                purchaseOrderDetailRow.ReceivedQty -= newSalesOrderDetailRow.SaleQty;
            //                salesOrderDetailRow.SaleQty = 0m;
            //                break;
            //            }
            //            else
            //            {
            //                //უნდა დაუმატოთ ახალი ჩანაწერი და ეს ფენდინგინ უნდა ჩავსვათ
            //                tmpDistributeSalesOrderDetailRow = ds_SaledSales.SP_GetSalesOrderDetail.NewSP_GetSalesOrderDetailRow();
            //                tmpDistributeSalesOrderDetailRow.ItemArray = salesOrderDetailRow.ItemArray;
            //                tmpDistributeSalesOrderDetailRow.SalesOrderDetailID = Guid.NewGuid();
            //                tmpDistributeSalesOrderDetailRow.SaleQty = salesOrderDetailRow.SaleQty - purchaseOrderDetailRow.ReceivedQty;
            //                ds_SaledSales.SP_GetSalesOrderDetail.AddSP_GetSalesOrderDetailRow(tmpDistributeSalesOrderDetailRow);
                            
            //                newSalesOrderDetailRow.SaleQty = purchaseOrderDetailRow.ReceivedQty;

            //                purchaseOrderDetailRow.ReceivedQty = 0m;
            //                salesOrderDetailRow.SaleQty = 0m;

            //            }
            //        }

            //        if (errorFlag)
            //        {
            //            salesOrderDetailRow.SetColumnError(ds_SaledSales.SP_GetSalesOrderDetail.SaleQtyColumn, "გაყიდული რაოდენობა აჭარბებს შესყიდულს");
            //            continue;
            //        }

            //        ds_ReInitedSales.SP_GetSalesOrderDetail.AddSP_GetSalesOrderDetailRow(newSalesOrderDetailRow);


            //        if (salesOrderDetailRow.SaleQty == 0m)
            //            salesOrderDetailRow.Delete();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show(this, string.Format("შეცდომა ინიციალიზაციის დროს.\n{0}", ex.Message), "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    Cursor = Cursors.Default;
            //}
        }
        //protected override bool SaveData()
        //{
        //    DataSet ds = new DataSet("root");

        //    DS_Purchasing.SP_GetPurchaseOrderHeaderDataTable sp_GetPurchaseOrderHeader = DataSetHelper.PackAlternationTypedDataTable<DS_Purchasing.SP_GetPurchaseOrderHeaderDataTable>(ds_ImportedPurchasing.SP_GetPurchaseOrderHeader);
        //    DataSetHelper.RemoveColumns(sp_GetPurchaseOrderHeader, true,
        //                                                    sp_GetPurchaseOrderHeader.PurchaseOrderIDColumn,
        //                                                    sp_GetPurchaseOrderHeader.BranchIDColumn,
        //                                                    sp_GetPurchaseOrderHeader.OrderDateColumn,
        //                                                    sp_GetPurchaseOrderHeader.VendorIDColumn,
        //                                                    sp_GetPurchaseOrderHeader.SubTotalColumn,
        //                                                    sp_GetPurchaseOrderHeader.TaxAmtColumn,
        //                                                    sp_GetPurchaseOrderHeader.FreightColumn,
        //                                                    sp_GetPurchaseOrderHeader.CurrencyCodeColumn,
        //                                                    sp_GetPurchaseOrderHeader.rowguidColumn
        //                                                    );

        //    DS_Purchasing.SP_GetPurchaseOrderDetailDataTable sp_GetPurchaseOrderDetail = DataSetHelper.PackAlternationTypedDataTable<DS_Purchasing.SP_GetPurchaseOrderDetailDataTable>(ds_ImportedPurchasing.SP_GetPurchaseOrderDetail);
        //    DataSetHelper.RemoveColumns(sp_GetPurchaseOrderDetail, true,
        //                                             sp_GetPurchaseOrderDetail.PurchaseOrderDetailIDColumn,
        //                                             sp_GetPurchaseOrderDetail.PurchaseOrderIDColumn,
        //                                             sp_GetPurchaseOrderDetail.ReceivedQtyColumn,
        //                                             sp_GetPurchaseOrderDetail.UnitPriceColumn,
        //                                             sp_GetPurchaseOrderDetail.MedicamentIDColumn,
        //                                             sp_GetPurchaseOrderDetail.StandardCostColumn,
        //                                             sp_GetPurchaseOrderDetail.ListPriceColumn,
        //        //sp_GetPurchaseOrderDetail.DealerPriceColumn,
        //                                             sp_GetPurchaseOrderDetail.DiscountPctColumn,
        //                                             sp_GetPurchaseOrderDetail.TaxRateColumn,
        //                                             sp_GetPurchaseOrderDetail.ValidDateColumn,
        //                                             sp_GetPurchaseOrderDetail.CountryCodeColumn,
        //                                             sp_GetPurchaseOrderDetail.BrandIDColumn,
        //                                             sp_GetPurchaseOrderDetail.SerieColumn,
        //        //sp_GetPurchaseOrderDetail.OrdinalNumberColumn,
        //                                             sp_GetPurchaseOrderDetail.ActionColumn
        //                                             );





        //    DS_Sales.SP_GetSalesOrderHeaderDataTable sp_GetSalesOrderHeader = DataSetHelper.PackAlternationTypedDataTable<DS_Sales.SP_GetSalesOrderHeaderDataTable>(ds_ImportedSales.SP_GetSalesOrderHeader);
        //    DataSetHelper.RemoveColumns(sp_GetSalesOrderHeader, true,
        //                                                    sp_GetSalesOrderHeader.SalesOrderIDColumn,
        //                                                    sp_GetSalesOrderHeader.BranchIDColumn,
        //                                                    sp_GetSalesOrderHeader.OrderDateColumn,
        //                                                    sp_GetSalesOrderHeader.CustomerIDColumn,
        //                                                    sp_GetSalesOrderHeader.SubTotalColumn,
        //                                                    sp_GetSalesOrderHeader.TaxAmtColumn,
        //                                                    sp_GetSalesOrderHeader.FreightColumn,
        //                                                    sp_GetSalesOrderHeader.CurrencyCodeColumn,
        //                                                    sp_GetSalesOrderHeader.rowguidColumn
        //                                                    );



        //    DS_Sales.SP_GetSalesOrderDetailDataTable sp_GetSalesOrderDetail = DataSetHelper.PackAlternationTypedDataTable<DS_Sales.SP_GetSalesOrderDetailDataTable>(ds_ImportedSales.SP_GetSalesOrderDetail);
        //    DataSetHelper.RemoveColumns(sp_GetSalesOrderDetail, true,
        //                                            sp_GetSalesOrderDetail.SalesOrderDetailIDColumn,
        //                                            sp_GetSalesOrderDetail.SalesOrderIDColumn,
        //                                            sp_GetSalesOrderDetail.SaleQtyColumn,
        //                                            sp_GetSalesOrderDetail.UnitPriceColumn,
        //                                            sp_GetSalesOrderDetail.UnitPriceDiscountColumn,
        //        //sp_GetSalesOrderDetail.OrdinalNumberColumn,
        //                                            sp_GetSalesOrderDetail.PurchaseOrderDetailIDColumn,
        //                                            sp_GetSalesOrderDetail.ActionColumn
        //                                            );



        //    DS_Purchasing.SP_GetPurchaseOrderHeaderDataTable sp_GetRePurchaseOrderHeader = PurchasingManager.GetPurchaseOrderHeader(ConvertHelper.ToInt32(bbPurchaseOrderHeader.RecordValue));
        //    DataSetHelper.SetColumnMappingType(sp_GetRePurchaseOrderHeader);
        //    sp_GetRePurchaseOrderHeader.TableName += "ReInit";

        //    DS_Sales.SP_GetSalesOrderDetailDataTable sp_GetReInitSalesOrderDetail = DataSetHelper.PackAlternationTypedDataTable<DS_Sales.SP_GetSalesOrderDetailDataTable>(ds_ReInitedSales.SP_GetSalesOrderDetail);
        //    DataSetHelper.RemoveColumns(sp_GetReInitSalesOrderDetail, true,
        //                                            sp_GetReInitSalesOrderDetail.SalesOrderDetailIDColumn,
        //                                            sp_GetReInitSalesOrderDetail.SalesOrderIDColumn,
        //                                            sp_GetReInitSalesOrderDetail.SaleQtyColumn,
        //                                            sp_GetReInitSalesOrderDetail.UnitPriceColumn,
        //                                            sp_GetReInitSalesOrderDetail.UnitPriceDiscountColumn,
        //        //sp_GetReInitSalesOrderDetail.OrdinalNumberColumn,
        //                                            sp_GetReInitSalesOrderDetail.PurchaseOrderDetailIDColumn,
        //                                            sp_GetReInitSalesOrderDetail.ActionColumn
        //                                            );
        //    sp_GetReInitSalesOrderDetail.TableName += "ReInit";



        //    ds.Tables.Add(sp_GetPurchaseOrderHeader);
        //    ds.Tables.Add(sp_GetPurchaseOrderDetail);
        //    ds.Tables.Add(sp_GetSalesOrderHeader);
        //    ds.Tables.Add(sp_GetSalesOrderDetail);
        //    ds.Tables.Add(sp_GetRePurchaseOrderHeader);
        //    ds.Tables.Add(sp_GetReInitSalesOrderDetail);


        //    string xml = DataSetHelper.InnerXmlData(ds);
        //    int id = DictionaryManager.Import(TableName, GlobalVariable.UserID, DataSetHelper.Compress(DataSetHelper.StringToUTF8Array(xml)));
        //    return (id > 0);
        //}
        #endregion

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) != DialogResult.OK) return;

            var i = 0;
            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                var table = ExcelHelper.GetDataTable(openFileDialog.FileName, "*", "Sheet1");
                ds_Import.T_Info10.Clear();


                DS_Import.T_Info10Row newRow;
                foreach (DataRow row in table.Rows)
                {
                    if (row[ds_Import.T_Info10.OperationTypeColumn.ColumnName].ToString().Trim().Length == 0 ||
                        row[ds_Import.T_Info10.OrderNumberColumn.ColumnName].ToString().Trim().Length == 0
                        )
                        continue;
                    newRow = ds_Import.T_Info10.NewT_Info10Row();

                    newRow.OperationType = row[ds_Import.T_Info10.OperationTypeColumn.ColumnName].ToString().Trim();
                    if (row[ds_Import.T_Info10.OrderNumberColumn.ColumnName] != DBNull.Value)
                        newRow.OrderNumber = int.Parse(row[ds_Import.T_Info10.OrderNumberColumn.ColumnName].ToString());
                    if (row[ds_Import.T_Info10.OrderDateColumn.ColumnName] != DBNull.Value)
                        newRow.OrderDate = DateTime.Parse(row[ds_Import.T_Info10.OrderDateColumn.ColumnName].ToString());
                    if (row[ds_Import.T_Info10.CompanyNameColumn.ColumnName] != DBNull.Value)
                        newRow.CompanyName = row[ds_Import.T_Info10.CompanyNameColumn.ColumnName].ToString().Trim();
                    newRow.MedicamentName = row[ds_Import.T_Info10.MedicamentNameColumn.ColumnName].ToString().Trim();
                    newRow.OperationQty = decimal.Parse(row[ds_Import.T_Info10.OperationQtyColumn.ColumnName].ToString());
                    newRow.StandardCost = decimal.Parse(row[ds_Import.T_Info10.StandardCostColumn.ColumnName].ToString());
                    newRow.ListPrice = decimal.Parse(row[ds_Import.T_Info10.ListPriceColumn.ColumnName].ToString());
                    if (row[ds_Import.T_Info10.DiscountPctColumn.ColumnName] != DBNull.Value)
                        newRow.DiscountPct = decimal.Parse(row[ds_Import.T_Info10.DiscountPctColumn.ColumnName].ToString());
                    else
                        newRow.DiscountPct = 0m;
                    if (row[ds_Import.T_Info10.TaxRateColumn.ColumnName] != DBNull.Value)
                        newRow.TaxRate = decimal.Parse(row[ds_Import.T_Info10.TaxRateColumn.ColumnName].ToString());
                    else
                        newRow.TaxRate = 0m;


                    if (row[ds_Import.T_Info10.ValidDateColumn.ColumnName] != DBNull.Value)
                        newRow.ValidDate = row[ds_Import.T_Info10.ValidDateColumn.ColumnName].ToString().Trim();
                    if (row[ds_Import.T_Info10.CountryNameColumn.ColumnName] != DBNull.Value)
                        newRow.CountryName = row[ds_Import.T_Info10.CountryNameColumn.ColumnName].ToString().Trim();
                    if (row[ds_Import.T_Info10.BrandNameColumn.ColumnName] != DBNull.Value)
                        newRow.BrandName = row[ds_Import.T_Info10.BrandNameColumn.ColumnName].ToString().Trim();
                    if (row[ds_Import.T_Info10.SerieColumn.ColumnName] != DBNull.Value)
                        newRow.Serie = row[ds_Import.T_Info10.SerieColumn.ColumnName].ToString().Trim();
                    newRow.ProductNumber = row[ds_Import.T_Info10.ProductNumberColumn.ColumnName].ToString().Trim();
                    newRow.ErrorFlag = false;
                    ds_Import.T_Info10.AddT_Info10Row(newRow);


                    //ds_Import.T_Info10.ImportRow(row);
                    //ds_Import.T_Info10[i].OperationType = ds_Import.T_Info10[i].OperationType.Trim();

                    //if (!ds_Import.T_Info10[i].IsCompanyNameNull())
                    //    ds_Import.T_Info10[i].CompanyName = ds_Import.T_Info10[i].CompanyName.Trim();
                    //ds_Import.T_Info10[i].SetMedicamentIDNull();
                    //ds_Import.T_Info10[i].MedicamentName = ds_Import.T_Info10[i].MedicamentName.Trim();
                    //if (!ds_Import.T_Info10[i].IsValidDateNull())
                    //    ds_Import.T_Info10[i].ValidDate = ds_Import.T_Info10[i].ValidDate.Trim();
                    //ds_Import.T_Info10[i].SetCountryCodeNull();
                    //if (!ds_Import.T_Info10[i].IsCountryNameNull())
                    //    ds_Import.T_Info10[i].CountryName = ds_Import.T_Info10[i].CountryName.Trim();
                    //ds_Import.T_Info10[i].SetBrandIDNull();
                    //if (!ds_Import.T_Info10[i].IsBrandNameNull())
                    //    ds_Import.T_Info10[i].BrandName = ds_Import.T_Info10[i].BrandName.Trim();
                    //if (!ds_Import.T_Info10[i].IsSerieNull())
                    //    ds_Import.T_Info10[i].Serie = ds_Import.T_Info10[i].Serie.Trim();
                    //ds_Import.T_Info10[i].ProductNumber = ds_Import.T_Info10[i].ProductNumber.Trim();

                    //ds_Import.T_Info10[i].ErrorFlag = false;
                    i++;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, string.Format("შეცდომა იმპორტირების დროს. ჩანაწერი ნომერი {0}.\n{1}", i + 1, ex.Message), "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                IsValidGrid();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, string.Format("შეცდომა ვალიდაციის დროს.\n{0}", ex.Message), "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void viewImport_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var row = ((DS_Import.T_Info10Row)viewImport.GetDataRow(e.RowHandle));
            if (ds_Import.T_Info10.Columns.Contains(e.Column.FieldName))
                row.SetColumnError(e.Column.FieldName, string.Empty);
        }

        private void btnInitID_Click(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                ImportManager.SynchronizeDictionary(ds_Import.T_Info10, ObjectNames.Company, ds_Import.T_Info10.CompanyIDColumn.ColumnName, false, null, ds_Import.T_Info10.CompanyNameColumn.ColumnName);
                ImportManager.SynchronizeDictionary(ds_Import.T_Info10, ObjectNames.Brand, ds_Import.T_Info10.BrandIDColumn.ColumnName, false, null, ds_Import.T_Info10.BrandNameColumn.ColumnName);
                ImportManager.SynchronizeDictionary(ds_Import.T_Info10, ObjectNames.Country, ds_Import.T_Info10.CountryCodeColumn.ColumnName, false, null, ds_Import.T_Info10.CountryNameColumn.ColumnName);
                ImportMedicament();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, string.Format("შეცდომა ინიციალიზაციის დროს.\n{0}", ex.Message), "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnInitPurchase_Click(object sender, EventArgs e)
        {
            if (!IsValid) return;
            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                var rate1 = CrossRate1;
                var rate2 = CrossRate2;
                int recordIndex;
                ds_ImportedPurchasing.Clear();
                DS_Purchasing.SP_GetPurchaseOrderDetailRow purchaseOrderDetailRow;
                DS_Purchasing.SP_GetPurchaseOrderHeaderRow purchaseOrderHeaderRow;
                DS_Import.T_Info10Row info10Row;
                var i = 0;
                while (i < ds_Import.T_Info10.Count)
                {
                    info10Row = ds_Import.T_Info10[i];
                    
                    if (info10Row.RowState == DataRowState.Deleted || info10Row.OperationType.ToUpper() != "P")
                    {
                        i++;
                        continue;
                    }

                    purchaseOrderDetailRow = ds_ImportedPurchasing.SP_GetPurchaseOrderDetail.NewSP_GetPurchaseOrderDetailRow();
                    purchaseOrderDetailRow.PurchaseOrderDetailID = Guid.NewGuid();
                    purchaseOrderDetailRow.PurchaseOrderID = info10Row.OrderNumber;
                    purchaseOrderDetailRow.ReceivedQty = Math.Round(info10Row.OperationQty, 4);
                    purchaseOrderDetailRow.UnitPrice = Math.Round(info10Row.StandardCost * rate1, 4);
                    purchaseOrderDetailRow.LineTotal = Math.Round(purchaseOrderDetailRow.UnitPrice * purchaseOrderDetailRow.ReceivedQty, 4);
                    purchaseOrderDetailRow.OrdinalNumber = 1;
                    purchaseOrderDetailRow.ProductID = 0;
                    purchaseOrderDetailRow.MedicamentID = info10Row.MedicamentID;
                    purchaseOrderDetailRow.ProductNumber = info10Row.ProductNumber.SafeSubstring(0, 25);
                    purchaseOrderDetailRow.MedicamentName = info10Row.MedicamentName;
                    purchaseOrderDetailRow.StandardCost = Math.Round((info10Row.StandardCost * rate1) / rate2, 4);
                    purchaseOrderDetailRow.ListPrice = Math.Round((info10Row.ListPrice * rate1) / rate2, 4);
                    purchaseOrderDetailRow.DealerPrice = 0m;
                    purchaseOrderDetailRow.DiscountPct = info10Row.DiscountPct / 100m;
                    purchaseOrderDetailRow.TaxRate = info10Row.TaxRate / 100m;
                    if (!info10Row.IsCountryCodeNull())
                        purchaseOrderDetailRow.CountryCode = info10Row.CountryCode;
                    if (!info10Row.IsCountryNameNull())
                        purchaseOrderDetailRow.CountryName = info10Row.CountryName;
                    if (!info10Row.IsBrandIDNull())
                        purchaseOrderDetailRow.BrandID = info10Row.BrandID;
                    if (!info10Row.IsBrandNameNull())
                        purchaseOrderDetailRow.BrandName = info10Row.BrandName;
                    if (!info10Row.IsSerieNull())
                        purchaseOrderDetailRow.Serie = info10Row.Serie;
                    purchaseOrderDetailRow.UnitsInStock = 1000;


                    purchaseOrderDetailRow._TaxAmt = Math.Round(purchaseOrderDetailRow.LineTotal * purchaseOrderDetailRow.TaxRate, 4);
                    purchaseOrderDetailRow._LineTotal = purchaseOrderDetailRow.LineTotal + purchaseOrderDetailRow._TaxAmt;
                    purchaseOrderDetailRow._ListPrice = Math.Round(purchaseOrderDetailRow.ListPrice * rate2, 4);
                    purchaseOrderDetailRow._DealerPrice = Math.Round(purchaseOrderDetailRow.DealerPrice * rate2, 4);
                    ds_ImportedPurchasing.SP_GetPurchaseOrderDetail.AddSP_GetPurchaseOrderDetailRow(purchaseOrderDetailRow);



                    recordIndex = _ViewSP_GetPurchaseOrderHeader.Find(info10Row.OrderNumber);
                    if (recordIndex == -1)
                    {
                        AddPurchaseOrderHeader(info10Row.OrderNumber);
                        recordIndex = _ViewSP_GetPurchaseOrderHeader.Find(info10Row.OrderNumber);
                    }
                    purchaseOrderHeaderRow = (DS_Purchasing.SP_GetPurchaseOrderHeaderRow)_ViewSP_GetPurchaseOrderHeader[recordIndex].Row;
                    if (purchaseOrderHeaderRow.OrderDate == DateTimeHelper.MinDate && !info10Row.IsOrderDateNull())
                        purchaseOrderHeaderRow.OrderDate = info10Row.OrderDate;
                    if (purchaseOrderHeaderRow.IsVendorIDNull() && !info10Row.IsCompanyIDNull())
                        purchaseOrderHeaderRow.VendorID = info10Row.CompanyID;
                    if (purchaseOrderHeaderRow.IsVendorNameNull() && !info10Row.IsCompanyNameNull())
                        purchaseOrderHeaderRow.VendorName = info10Row.CompanyName;
                    purchaseOrderHeaderRow.SubTotal += purchaseOrderDetailRow.LineTotal;
                    purchaseOrderHeaderRow.TaxAmt += Math.Round(purchaseOrderDetailRow.LineTotal * purchaseOrderDetailRow.TaxRate, 4);
                    purchaseOrderHeaderRow.TotalDue = purchaseOrderHeaderRow.SubTotal + purchaseOrderHeaderRow.TaxAmt + purchaseOrderHeaderRow.Freight;
                    info10Row.Delete();
                }
                ds_ResidualPurchasing.SP_GetPurchaseOrderDetail.Clear();
                ds_ResidualPurchasing.SP_GetPurchaseOrderDetail.Merge(ds_ImportedPurchasing.SP_GetPurchaseOrderDetail);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, string.Format("შეცდომა ინიციალიზაციის დროს.\n{0}", ex.Message), "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnInitSales_Click(object sender, EventArgs e)
        {
            InitImportedSales();
            InitSaledSales();
        }

        private void lookBranch_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(lookBranch, string.Empty);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog(this) != DialogResult.OK) return;

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                XtraGridHelper.Export(viewImport, saveFileDialog.FileName, true);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, string.Format("შეცდომა ექსპორტირების დროს.\n{0}", ex.Message), "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void bbPurchaseOrderHeader_PrimaryKeyChanged(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                //ds_SaledSales.Clear();
                //ds_SaledSales.SP_GetSalesOrderDetail.Merge(SalesManager.GetSalesOrderDetailByPurchaseOrderID(ConvertHelper.ToInt32(bbPurchaseOrderHeader.RecordValue)));
                //ds_ReInitedSales.Clear();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, string.Format("შეცდომა მონაცემის ამოღებისას.\n{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}