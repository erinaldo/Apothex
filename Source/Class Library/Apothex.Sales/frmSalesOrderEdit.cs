using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Apothex.Configuration;
using Apothex.DataManagment.Hedgehog;
using Apothex.DataManagment.Purchasing;
using Apothex.Production;
using Apothex.Reporting;
using Apothex.Sales.Properties;
using Apothex.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

using Apothex.DataType;
using Apothex.Common;
using Apothex.DataManagment.Sales;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using Zek.Core;
using Zek.Windows.Forms;
using Zek.Data;
using Apothex.DataManagment.Dictionary;
using Apothex.DataManagment.Production;
using Apothex.Card;
using Apothex.DataManagment.Card;
using Zek.Windows.Forms.DevEx;
using Apothex.DataManagment.Person;
using Apothex.DataManagment.ProductLocation;
using Apothex.DataManagment.Branch;

namespace Apothex.Sales
{
    public partial class frmSalesOrderEdit : frmEditBrowse
    {
        public frmSalesOrderEdit()
        {
            InitializeComponent();
            InitMenu();

            IsOnline = ConfigurationManagerEx.IsOnline;
            bbModifier.IsOnline = !ConfigurationManagerEx.OfflineMode;
            bbApprover.IsOnline = !ConfigurationManagerEx.OfflineMode;
            bbBranch.IsOnline = !ConfigurationManagerEx.OfflineMode;

            XtraGridHelper.InitGrid(grid, true);
            XtraGridHelper.BestFitColumns(view);
        }

        #region Fields
        private int _purchaseOrderID;

        public int SalesOrderID
        {
            get { return ConvertHelper.ToInt32(PrimaryKey); }
            set
            {
                PrimaryKey = value;
                txtSalesOrderID.Text = txtID.Text = value.ToString();
                Text = OptionsBaseForm.Text + (value > 0 ? " №" + value.ToString() : string.Empty);
            }
        }
        public DateTime OrderDate
        {
            get { return DateTimeHelper.GetStartOfSecond(dateOrderDate.EditValue); }
            set { dateOrderDate.EditValue = value; }
        }
        public int BranchID
        {
            get { return ConvertHelper.ToInt32(bbBranch.RecordValue); }
            set { bbBranch.RecordValue = value; }
        }

        public decimal DiscountPct
        {
            get { return spinDiscountPct.Value; }
        }

        public int CustomerID
        {
            get { return ConvertHelper.ToInt32(bbCustomer.RecordValue); }
            set { bbCustomer.RecordValue = value; }
        }
        public string CustomerName
        {
            get { return bbCustomer.Text; }
        }
        public string OverheadNumber
        {
            get { return txtOverheadNumber.Text.Trim(); }
            set { txtOverheadNumber.Text = value.Trim(); }
        }

        public decimal SubTotal
        {
            get
            {
                var value = 0m;
                foreach (var row in ds_Sales.SP_GetSalesOrderDetail)
                {
                    if (DataSetHelper.IsDataRowDeleted(row)) continue;
                    value += row.LineTotal;
                }
                return Math.Round(value, 4) - TaxAmt;
            }
            set { spinSubTotal.EditValue = value; }
        }
        public decimal TaxAmt
        {
            get
            {
                if (!GlobalVariable.VATPayerFlag) return 0m;
                var value = 0m;
                foreach (var row in ds_Sales.SP_GetSalesOrderDetail)
                {
                    if (DataSetHelper.IsDataRowDeleted(row)) continue;
                    value += row.LineTotal - MathHelper.RemoveAddedPct(row.LineTotal, row.TaxRate * 100m);
                }
                return Math.Round(value, 4);
            }
            set { spinTaxAmt.EditValue = value; }
        }
        public decimal Freight
        {
            get { return ConvertHelper.ToDecimal(spinFreight.EditValue); }
            set { spinFreight.EditValue = value; }
        }
        public decimal TotalDue
        {
            get { return Math.Round(SubTotal + TaxAmt + Freight, 4); }
            set { spinTotalDue.EditValue = value; }
        }
        public int CurrencyRateID
        {
            get { return 0; }
            set { }
        }
        public string CurrencyCode
        {
            get { return ConvertHelper.ToString(lookCurrency.EditValue); }
            set { lookCurrency.EditValue = value; }
        }
        public decimal CurrencyRate
        {
            get { return Convert.ToDecimal(lookCurrency.GetColumnValue("Code")); }
        }

        public int PaymentMethodID
        {
            get { return Convert.ToInt32(lookPaymentMethod.EditValue); }
            set { lookPaymentMethod.EditValue = value; }
        }
        public string PaymentMethodName
        {
            get { return ConvertHelper.ToString(lookPaymentMethod.GetColumnValue("Caption")); }
        }
        public byte RevisionNumber
        {
            get { return ConvertHelper.ToByte(spinRevisionNumber.EditValue); }
            set { spinRevisionNumber.EditValue = value; }
        }
        public string Comment
        {
            get { return memoComment.Text.Trim(); }
            set { memoComment.Text = value.Trim(); }
        }
        public bool SaleStandardCost
        {
            get { return chkSaleStandardCost.Checked; }
            set { chkSaleStandardCost.Checked = value; }
        }

        private bool _IsSavedHedgehog;
        public bool Hedgehog
        {
            get { return chkHedgehog.Checked; }
            set { chkHedgehog.Checked = value; }
        }
        public string HedgehogCardNumber
        {
            get { return txtHedgehog.Text.Replace("%", string.Empty).Replace(";", string.Empty).Replace("?", string.Empty).Trim(); }
            set { txtHedgehog.Text = value; }
        }

        public string CardNumber
        {
            get { return beCard.Text.Trim(); }
            set { beCard.Text = value; }
        }

        public int ModifiedUserID
        {
            get { return ConvertHelper.ToInt32(bbModifier.RecordValue); }
            set { bbModifier.RecordValue = value; }
        }
        public string Modifier
        {
            get { return bbModifier.Text.Trim(); }
        }
        public DateTime ModifiedDate
        {
            get { return ConvertHelper.ToDateTime(dateModifiedDate.EditValue); }
            set { dateModifiedDate.EditValue = value; }
        }
        public int ApproverUserID
        {
            get { return ConvertHelper.ToInt32(bbApprover.RecordValue); }
            set { bbApprover.RecordValue = value; }
        }
        public string Approver
        {
            get { return bbApprover.Text.Trim(); }
        }

        //private byte OperationTypeID
        //{
        //    get { return ConvertHelper.ToByte(lookOperationType.EditValue); }
        //    set { lookOperationType.EditValue = (int)value; }
        //}


        private bool _DoBindPrint = true;
        protected override void OnIsChangedChanged()
        {
            base.OnIsChangedChanged();

            if (IsChanged)
                _DoBindPrint = true;
        }

        public bool _IsAllowedZeroDiscountedProductDiscount = false;
        public bool _IsAllowedAnyProductDiscount = false;
        public bool _IsAllowedAnyDate = false;
        public bool _IsAllowedFewDate = false;
        public bool _IsAllowedSaleStandardCost = false;
        public bool _IsAllowedSaleAnyPrice = false;
        public bool _IsAllowedSalesOrderHeaderAnyModifier = false;

        public frmProductLocationBrowse _frmpl;
        #endregion

        #region Menu
        private BarButtonItem miCardHandleItem;
        private void InitMenu()
        {
            var subMenu = XtraBarHelper.MoveIntoBarSubItem(miPrint, "ამობეჭვდა", miPrint.Glyph, BarItemPaintStyle.CaptionInMenu);
            miPrint.Glyph = null;
            XtraBarHelper.AddBarButtonItem(barTools, "ამობეჭვდა თერმულ პრინტერზე", Resources.Printer_24x24, miPrintThermal_ItemClick);
            //XtraBarHelper.AddSubItem(subMenu, "ამობეჭვდა შემავალი ფასით", null, miPrintPurchasePrice_ItemClick);
            XtraBarHelper.AddBarButtonItem(subMenu, "ამობეჭვდა სასაქონლო ზედნადების", null, miPrintInvoice_ItemClick);
            XtraBarHelper.AddBarButtonItem(subMenu, "ამობეჭვდა დანართი №4", null, miPrintEnclosure4_ItemClick);
            XtraBarHelper.AddBarButtonItem(subMenu, "ამობეჭვდა დანართი №7", null, miEnclosure7_ItemClick);
            XtraBarHelper.AddBarButtonItem(subMenu, "ამობეჭვდა გასავლის ზედდებულის", null, miEnclosureInCountry_ItemClick);
            XtraBarHelper.AddBarButtonItem(subMenu, "ამობეჭვდა თერმულ პრინტერზე (ნაშთით)", null, miPrintReceipt_ItemClick);
            miCardHandleItem = XtraBarHelper.AddBarButtonItem(barTools, "ბარათის გატარება", null, Keys.F5, miCardHandleItemClick);
            miCardHandleItem.Links[0].BeginGroup = true;



            var subExport = XtraBarHelper.AddBarSubItem(barTools, "ექსპოსტი", Zek.Properties.Resources.export_24x24);
            subExport.Links[0].BeginGroup = true;
            XtraBarHelper.AddBarButtonItem(subExport, "ნეო ფარმა", null, miExportNP_ItemClick);
            XtraBarHelper.AddBarButtonItem(subExport, "ავერსი", null, miExportAversi_ItemClick);
        }
        private void miPrintThermal_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!OptionsBaseForm.IsPrintable || !IsValidPrint())
                return;
            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                var pageHeight = 25 + 5 + 12 * view.RowCount + 26;
                Zek.Report.ReportHelper.Print(Reports.ReportName.Receipt, PreInitTradeOrderDataSet(), -1, pageHeight);
            }
            catch (Exception ex)
            {
                ExceptionHelper.Show(this, ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private void miPrintPurchasePrice_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!OptionsBaseForm.IsPrintable || !IsValidPrint())
                return;
            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                ReportFactory.Show(MdiParent, OptionsBaseForm.Text, ObjectNames.SalesOrderDetailPurchasePrice, ds_Sales);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, "შეცდომა ამობეჭვდისას.\n" + ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private void miPrintInvoice_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!OptionsBaseForm.IsPrintable || !IsValidPrint() || !IsOnline)
                return;

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                Zek.Report.ReportHelper.Show(MdiParent, Text, Reports.ReportName.VATOrder, GetTradeOrderDataSet());
            }
            catch (Exception ex)
            {
                ExceptionHelper.Show(this, ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private void miPrintEnclosure4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Print(Reports.ReportName.Enclosure4);
        }
        private void miEnclosure7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Print(Reports.ReportName.Enclosure7);
        }
        private void miEnclosureInCountry_ItemClick(object sender, ItemClickEventArgs e)
        {
            Print(Reports.ReportName.EnclosureInCountry);
        }
        private void miPrintReceipt_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!OptionsBaseForm.IsPrintable || !IsValidPrint())
                return;

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;


                var pageHeight = 25 + 5 + 12 * view.RowCount + 26;
                var variables = new Dictionary<string, object>();
                variables.Add("EnableStockedQty", true);
                Zek.Report.ReportHelper.Print(Reports.ReportName.Receipt, GetTradeOrderDataSet(), -1, pageHeight, variables);
            }
            catch (Exception ex)
            {
                ExceptionHelper.Show(this, ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private void miExportNP_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (!IsOnline) return;

            var dlg = new SaveFileDialog() { Filter = "Xml Files|*.xml|All Files|*.*", FileName = "SO" + txtID.Text };
            if (dlg.ShowDialog() != DialogResult.OK) return;
            
            var usdRate = DictionaryManager.GetCurrencyRate("USD", OrderDate);
            var rate = CurrencyRate != 0 ? CurrencyRate : 1m;
            var ds = new DS_Neopharmi();
            foreach (var row in ds_Sales.SP_GetSalesOrderDetail)
            {
                if (DataSetHelper.IsDataRowDeleted(row)) continue;

                var newrow = (DS_Neopharmi.T_NeopharmiRow)DataSetHelper.AddEmptyRow(ds.T_Neopharmi);

                newrow.productsid = row.ProductID.ToString();
                newrow.products_n = StringHelper.Trim(GeoConvertHelper.Convert(row.MedicamentName, GeoConvertHelper.UnicodeGeo, GeoConvertHelper.StandardGeo), 100);
                newrow.producer_n = StringHelper.Trim(GeoConvertHelper.Convert(row.BrandName, GeoConvertHelper.UnicodeGeo, GeoConvertHelper.StandardGeo), 40);
                newrow.country_n = StringHelper.Trim(GeoConvertHelper.Convert(row.CountryName, GeoConvertHelper.UnicodeGeo, GeoConvertHelper.StandardGeo), 20);
                newrow.icount = row.SaleQty;
                newrow.priceg = row.UnitPrice * rate;
                newrow.priceu = newrow.priceg / usdRate;
                newrow.svg = row.SaleQty * newrow.priceg;
                newrow.svu = row.SaleQty * newrow.priceu;
                newrow.discount = row.DiscountPct * 100m;
                newrow.vg = 0;
                newrow.vu = 0;

                if (!row.IsValidDateNull())
                    newrow.lifedate = row.ValidDate;
            }

            ds.Namespace = " ";
            ds.DataSetName = "VFPData";
            ds.T_Neopharmi.TableName = "row";
            DataSetHelper.SetColumnMappingType(ds);
            ds.WriteXml(dlg.FileName, XmlWriteMode.WriteSchema);
        }
        private void miExportAversi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!IsOnline) return;

            var dlg = new SaveFileDialog();
            dlg.Filter = "dBase Files (*.dbf)|*.dbf|All Files|*.*";
            dlg.FileName = "SO" + txtID.Text;

            
            if (dlg.ShowDialog() != DialogResult.OK) return;

            
//            System.IO.File.WriteAllBytes(dlg.FileName, Properties.Resources.NeoPharm);
            var ds = new DS_Aversi();
            foreach (var row in ds_Sales.SP_GetSalesOrderDetail)
            {
                if (DataSetHelper.IsDataRowDeleted(row)) continue;

                var newrow = (DS_Aversi.T_ExportRow)DataSetHelper.AddEmptyRow(ds.T_Export);

                newrow.COD_MAT = row.ProductID;
                newrow.NAM_MAT = row.MedicamentName;
                newrow.DAT_GOOD = row.ValidDate;
                newrow.PRICE = row.UnitPrice - MathHelper.RemoveAddedPct(row.UnitPrice, row.TaxRate * 100m);
                newrow.NUM_OP = row.SaleQty;
                newrow.SERIA = row.Serie;
                newrow.PRODUCER = row.BrandName;
                newrow.COUNTRY = row.CountryName;
                newrow.VAT = row.TaxRate > 0m;

            //    newrow.products_n = StringHelper.Trim(GeoConvertHelper.Convert(row.MedicamentName, GeoConvertHelper.UnicodeGeo, GeoConvertHelper.StandardGeo), 100);

            }

            //ds.WriteXml(dlg.FileName, XmlWriteMode.WriteSchema);
        }

        private DS_TradeOrder PreInitTradeOrderDataSet()
        {
            var ds = new Zek.DataModel.DS_TradeOrder();
            DataSetHelper.AddEmptyRow(ds.T_Header);
            var hrow = ds.T_Header[0];


            hrow.HeaderID = SalesOrderID;
            hrow.OrderNumber = SalesOrderID.ToString();
            hrow.OrderDate = OrderDate;
            hrow.SubTotal = SubTotal;
            hrow.VATAmt = TaxAmt;
            hrow.Freight = Freight;
            hrow.TotalDue = TotalDue;
            hrow.CurrencyCode = CurrencyCode;
            hrow.CurrencyName = NumToStrHelper.ToCurrencyName(CurrencyCode);
            hrow.CurrencyCoin = NumToStrHelper.ToCurrencyCoin(CurrencyCode);
            //hrow.VendorBranchNumber = GlobalVariable.BranchID


            hrow.VendorName = GlobalVariable.MyCompanyName;
            hrow.VendorTaxCode = GlobalVariable.MyCompanyTaxCode;
            hrow.VendorAddress = GlobalVariable.MyCompanyAddress;
            hrow.VendorPhone = GlobalVariable.MyCompanyPhone;


            FillTradeOrderT_Detail(ds);

            FillBonusAccumulation(ds);


            return ds;
        }
        private Zek.DataModel.DS_TradeOrder GetTradeOrderDataSet()
        {

            if (_DoBindPrint)
            {
                ds_Sales.SP_GetRptSalesOrderHeader.Clear();
                ds_Sales.SP_GetRptSalesOrderHeader.Merge(SalesManager.GetRptSalesOrderHeader(SalesOrderID));
                _DoBindPrint = false;
            }

            if (ds_Sales.SP_GetRptSalesOrderHeader.Count == 0) throw new Exception("ფაქტურა არ მოიძებნა");


            var rate1 = DictionaryManager.GetCurrencyRate(CurrencyCode, OrderDate);
            var rate2 = DictionaryManager.GetCurrencyRate(GlobalVariable.MyCompanyConditionalUnitCurrencyCode, OrderDate);

            var ds = PreInitTradeOrderDataSet();
            Zek.DataModel.DS_TradeOrder.T_HeaderRow hrow = ds.T_Header[0];

            //TODO ეს სანახავია შეიძლება თუ არა კურსის ამოღება OFFLINE-ზე
            hrow.CurrencyRate = rate2;
            hrow.ProductCurrencyRate = rate2;

            if (IsOnline)
            {
                var branch = BranchManager.Get(BranchID);
                if (branch.Count > 0)
                {
                    var vendor = PersonManager.GetCompany(branch[0].CompanyID);
                    if (vendor.Count > 0)
                    {
                        hrow.VendorName = vendor[0].Name;
                        hrow.VendorTaxCode = vendor[0].TaxCode;
                        hrow.VendorAddress = vendor[0].Address;
                    }
                }

                var person = PersonManager.GetPersonByUserID(BaseGlobalVariable.UserID);
                if (person.Count > 0)
                {
                    hrow.SellerName = person[0].FullName;
                    hrow.SellerJobTitle = person[0].JobTitle;
                }
            }




            hrow.ShipToName = hrow.CustomerName = ds_Sales.SP_GetRptSalesOrderHeader[0].CustomerName;
            hrow.ShipToTaxCode = hrow.CustomerTaxCode = ds_Sales.SP_GetRptSalesOrderHeader[0].CustomerTaxCode;
            hrow.ShipToAddress = hrow.CustomerAddress = ds_Sales.SP_GetRptSalesOrderHeader[0].CustomerAddress;

            var fromBranch = BranchManager.Get(BranchID);
            if (fromBranch.Count > 0)
            {
                hrow.ShipperName = GlobalVariable.MyCompanyName + " (" + fromBranch[0].Name + ")";
                hrow.ShipperTaxCode = GlobalVariable.MyCompanyTaxCode;
                hrow.ShipperAddress = fromBranch[0].Address;

                hrow.VendorAddress = hrow.ShipperAddress;
            }


            if (!string.IsNullOrEmpty(GlobalVariable.MyCompanyBankName)) hrow.VenderBankInfo = GlobalVariable.MyCompanyBankName;
            if (!string.IsNullOrEmpty(GlobalVariable.MyCompanyBankCode)) hrow.VenderBankInfo += ", კოდი " + GlobalVariable.MyCompanyBankCode;
            if (!string.IsNullOrEmpty(GlobalVariable.MyCompanyBankAccountNumber)) hrow.VenderBankInfo += ", ა/ა " + GlobalVariable.MyCompanyBankAccountNumber;
            hrow.VenderBankInfo = hrow.VenderBankInfo.TrimStart(' ', ',');

            return ds;
        }
        private void FillTradeOrderT_Detail(DS_TradeOrder ds)
        {
            var i = 1;
            DS_Sales.SP_GetSalesOrderDetailDataTable tmp_detail = DataSetHelper.SortDataTable<DS_Sales.SP_GetSalesOrderDetailDataTable>(ds_Sales.SP_GetSalesOrderDetail, ds_Sales.SP_GetSalesOrderDetail.MedicamentNameColumn);
            foreach (var row in tmp_detail)
            {
                Zek.DataModel.DS_TradeOrder.T_DetailRow newRow = ds.T_Detail.NewT_DetailRow();
                newRow.HeaderID = SalesOrderID;
                newRow.DetailID = i++;
                newRow.Line = i - 1;//row.OrdinalNumber;
                newRow.ProductName = row.MedicamentName;
                if (!row.IsSerieNull()) newRow.Serie = row.Serie;
                newRow.Quantity = row.SaleQty;
                newRow.UnitMeasure = "ცალი";


                newRow.UnitPrice = row.UnitPrice;
                newRow.Discount = row.UnitPriceDiscount * 100m;

                if (GlobalVariable.VATPayerFlag) newRow.VATRate = row.TaxRate * 100m;
                newRow.StockedQty = row._ResidualQty;
                newRow.PackQty = row.UnitsInStock;
                if (!row.IsValidDateNull()) newRow.ValidDate = row.ValidDate;
                newRow.Manufacturer = (!row.IsBrandNameNull() ? row.BrandName + " " : string.Empty);
                if (!row.IsCountryNameNull()) newRow.ManufactureCountry = row.CountryName;

                ds.T_Detail.AddT_DetailRow(newRow);
            }
        }
        private void FillBonusAccumulation(DS_TradeOrder ds)
        {
            if (CardNumber.Length == 0) return;
            try
            {
                var bonus = CardManager.GetBonusAccumulationByCardNumber(CardNumber, true, 10);
                if (bonus.Count > 0)
                {
                    DataSetHelper.AddEmptyRow(ds.T_BonusAccumulation);
                    ds.T_BonusAccumulation[0].CardNumber = CardNumber;
                    ds.T_BonusAccumulation[0].Date = BaseGlobalVariable.ServerDateTime.Date.AddDays(-1d);
                    ds.T_BonusAccumulation[0].TotalUnit = bonus[0].TotalUnit;
                    ds.T_BonusAccumulation[0].TotalAmount = bonus[0].TotalAmount;
                }
            }
            catch { }
        }

        private void Print(Reports.ReportName reportName)
        {
            if (!OptionsBaseForm.IsPrintable || !IsValidPrint() || !IsOnline)
                return;

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                Zek.Report.ReportHelper.Show(MdiParent, Text, reportName, GetTradeOrderDataSet());
            }
            catch (Exception ex)
            {
                ExceptionHelper.Show(this, ex, "შეცდომა ამობეჭვდისას", MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void miCardHandleItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsLoading || ReadOnly) return;

            using (var frm = new frmCardHandle())
            {
                if (frm.ShowDialog(this) != DialogResult.OK) return;

                if (CardNumber != frm.CardNumber)
                    IsChanged = true;
                CardNumber = frm.CardNumber;
            }
        }
        #endregion

        #region Bindings
        protected override void BindControls()
        {
            bsCurrency.DataSource = DictionaryManager.GetDictionary(ObjectNames.CurrencyWithLastRate, !ConfigurationManagerEx.OfflineMode);
            CurrencyCode = GlobalVariable.MyCompanyDefaultTradingCurrencyCode;

            lookPaymentMethod.Properties.DataSource = DictionaryManager.GetDictionaryInt(ObjectNames.PaymentMethod, !ConfigurationManagerEx.OfflineMode);
            //lookOperationType.Properties.DataSource = DictionaryManager.GetDictionaryInt(ObjectNames.OperationType, !Apothex.Configuration.ConfigurationManagerEx.OfflineMode);
            //riOpType.DataSource = ((DataTable)lookOperationType.Properties.DataSource).Copy();
        }
        protected override void BindData()
        {
            if (Action == DatabaseAction.Edit)
            {
                ds_Sales.SP_GetSalesOrderHeader.Clear();
                ds_Sales.SP_GetSalesOrderHeader.Merge(SalesManager.GetSalesOrderHeader(SalesOrderID, IsOnline));
                if (ds_Sales.SP_GetSalesOrderHeader.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.", "RecordID");

                SalesOrderID = ds_Sales.SP_GetSalesOrderHeader[0].SalesOrderID;
                BranchID = ds_Sales.SP_GetSalesOrderHeader[0].BranchID;
                OrderDate = ds_Sales.SP_GetSalesOrderHeader[0].OrderDate;
                OverheadNumber = ds_Sales.SP_GetSalesOrderHeader[0].OverheadNumber;
                CustomerID = ds_Sales.SP_GetSalesOrderHeader[0].CustomerID;
                SubTotal = ds_Sales.SP_GetSalesOrderHeader[0].SubTotal;
                TaxAmt = ds_Sales.SP_GetSalesOrderHeader[0].TaxAmt;
                Freight = ds_Sales.SP_GetSalesOrderHeader[0].Freight;
                TotalDue = ds_Sales.SP_GetSalesOrderHeader[0].TotalDue;
                CurrencyCode = ds_Sales.SP_GetSalesOrderHeader[0].CurrencyCode;
                CurrencyRateID = ds_Sales.SP_GetSalesOrderHeader[0].CurrencyRateID;
                PaymentMethodID = ds_Sales.SP_GetSalesOrderHeader[0].PaymentMethodID;
                RevisionNumber = ds_Sales.SP_GetSalesOrderHeader[0].RevisionNumber;
                /*Comment = ds_Sales.SP_GetSalesOrderHeader[0].Comment;*/

                Status = (DatabaseStatus)ds_Sales.SP_GetSalesOrderHeader[0].Status;
                ModifiedUserID = ds_Sales.SP_GetSalesOrderHeader[0].ModifiedUserID;
                ModifiedDate = ds_Sales.SP_GetSalesOrderHeader[0].ModifiedDate;
                ApproverUserID = ds_Sales.SP_GetSalesOrderHeader[0].ApproverUserID;

                ds_Sales.SP_GetSalesOrderDetail.Clear();
                ds_Sales.SP_GetSalesOrderDetail.Merge(SalesManager.GetSalesOrderDetail(SalesOrderID, IsOnline));


                var rate = CurrencyRate;
                foreach (var row in ds_Sales.SP_GetSalesOrderDetail)
                {
                    row._UnitPrice = row.UnitPrice * rate;
                    row._ResidualQty = row.Quantity;
                    row.Quantity += row.SaleQty;
                    row._SaleUnitQty = MathHelper.RoundUnit(row.SaleQty, row.UnitsInStock, 4);
                }


                var t_CardHandle = CardManager.GetCardHandle(SalesOrderID, IsOnline);
                if (t_CardHandle.Count > 0)
                {
                    CardNumber = t_CardHandle[0].CardNumber;
                    if (t_CardHandle[0].Amount < 0m || t_CardHandle[0].Unit < 0m) ReadOnly = true;
                }

                if (!ConfigurationManagerEx.OfflineMode)
                {
                    ds_Hedgehog.SP_GetSalesHedgehog.Clear();
                    ds_Hedgehog.SP_GetSalesHedgehog.Merge(HedgehogManager.GetSalesHedgehog(SalesOrderID));
                    if (ds_Hedgehog.SP_GetSalesHedgehog.Count > 0)
                    {
                        _IsSavedHedgehog = true;
                        Hedgehog = true;
                        HedgehogCardNumber = ds_Hedgehog.SP_GetSalesHedgehog[0].CardNumber;
                    }
                }
            }
            else
            {
                ModifiedUserID = BaseGlobalVariable.UserID;
                ModifiedDate = BaseGlobalVariable.ServerDateTime;

                BranchID = GlobalVariable.BranchID;
                OrderDate = SalesManager.GetOrderDate(ObjectNames.PurchaseOrderHeader, SalesOrderID, BranchID, BaseGlobalVariable.ServerDateTime, !ConfigurationManagerEx.OfflineMode);
                AddHeader();

                //OperationTypeID = (byte)OperationType.Cash;
            }
        }
        #endregion

        #region Valdations
        private bool IsValidOrderDate()
        {
            try
            {
                //if (!TrialMakerHelper.CheckDate(OrderDate.Date))
                //{
                //    SetError(dateOrderDate, TrialMakerHelper.ErrorNotValidCheckDate);
                //    return false;
                //}

                if (_IsAllowedAnyDate)
                    return true;

                if (_IsAllowedFewDate && Math.Abs(DateTimeHelper.SubtractDays(OrderDate.Date, BaseGlobalVariable.ServerDateTime.Date)) <= 3)
                {
                    return true;
                }

                if (OrderDate.Date < BaseGlobalVariable.ServerDateTime.Date)
                {
                    SetError(dateOrderDate, "გაყიდვის თარიღი უნდა იყოს ტოლი სერვერის თარიღის.");
                    return false;
                }
                else if (!ConfigurationManagerEx.OfflineMode && !SalesManager.IsValidOrderDate(ObjectNames.SalesOrderHeader, SalesOrderID, GlobalVariable.BranchID, OrderDate, !ConfigurationManagerEx.OfflineMode))
                {
                    SetError(dateOrderDate, "გაყიდვის თარიღი უნდა აღემატებოდეს ბოლოს დღის დახურვის თარიღს.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, "ფაქტურის თარიღის შემოწმება ვერ მოხერხდა: " + ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private bool IsValidCurrency()
        {
            if (CurrencyCode.Length == 0)
            {
                SetError(lookCurrency, "!");
                return false;
            }

            return true;
        }
        private bool IsValidGrid()
        {
            view.CloseEditor();
            bsDetail.EndEdit();

            var valid = true;
            var today = BaseGlobalVariable.ServerDateTime.Date;
            var expiredProductCount = 0;
            foreach (var row in ds_Sales.SP_GetSalesOrderDetail)
            {
                if (DataSetHelper.IsDataRowDeleted(row)) continue;
                if (!IsValidRow(row)) valid = false;
                if (!row.IsValidDateNull() && row.ValidDate < today)
                {
                    row.SetColumnError(ds_Sales.SP_GetSalesOrderDetail.ValidDateColumn, "ვადა გასულია.");
                    expiredProductCount++;
                }
            }

            if (expiredProductCount > 0)
                XtraMessageBox.Show(this, string.Format("ფაქტურაში ნაპოვნია {0} ვადაგასული პროდუქტი.", expiredProductCount.ToString()), "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (!valid) return valid;

            DS_Sales.SP_GetSalesOrderDetailDataTable table = DataSetHelper.PackAlternationTypedDataTable<DS_Sales.SP_GetSalesOrderDetailDataTable>(ds_Sales.SP_GetSalesOrderDetail, DataRowState.Added | DataRowState.Modified);
            table.PrimaryKey = null;

            DataSetHelper.RemoveColumns(table, true, table.ProductLocationIDColumn,
                                                                table.SalesOrderDetailIDColumn,
                                                                table.ActionColumn);

            var ds = new DataSet("root");
            ds.Tables.Add(table);

            var productLocationQuantity = ProductLocationManager.GetProductLocationQuantity(null, ObjectNames.SalesOrderDetail, !ConfigurationManagerEx.OfflineMode, DataSetHelper.InnerBytesData(ds));
            foreach (var row2 in ds_Sales.SP_GetSalesOrderDetail)
            {
                if (DataSetHelper.IsDataRowDeleted(row2)) continue;
                foreach (var tmp in productLocationQuantity)
                {
                    if (DataSetHelper.IsDataRowDeleted(tmp)) continue;

                    if (row2.ProductLocationID == tmp.ProductLocationID)
                    {
                        row2.Quantity = tmp.Quantity;
                        InitResidualQty(row2);
                    }
                }

                if (!IsValidRowQuantity(row2)) valid = false;
            }

            return valid;
        }
        private bool IsValidRowQuantity(DS_Sales.SP_GetSalesOrderDetailRow row)
        {
            var ok = true;
            if (row.Quantity < row.SaleQty)
            {
                ok = false;
                row.SetColumnError(ds_Sales.SP_GetSalesOrderDetail.SaleQtyColumn, string.Format("გასაყიდი მედიკამენტების რაოდენობა არ უნდა აღემატებოდეს არსებულს.\nდარჩენილი რაოდენობა = {0}", row.Quantity));
            }

            return ok;
        }
        private bool IsValidRow(DS_Sales.SP_GetSalesOrderDetailRow row)
        {
            row.ClearErrors();
            var flag = true;


            if (row.BranchID != BranchID)
            {
                flag = false;
                row.SetColumnError(ds_Sales.SP_GetSalesOrderDetail.OrdinalNumberColumn, "ეს პროდუქტი არის სხვა ფილიალში.");
            }

            if (row.UnitPriceDiscount < 0m)
            {
                flag = false;
                row.SetColumnError(ds_Sales.SP_GetSalesOrderDetail.UnitPriceDiscountColumn, "მნიშვნელობა არ შეიძლება იყოს უარყოფითი.");
            }
            else if (row.UnitPriceDiscount > 1m)
            {
                flag = false;
                row.SetColumnError(ds_Sales.SP_GetSalesOrderDetail.UnitPriceDiscountColumn, "მნიშვნელობა არ შეიძლება იყოს 100-ზე მეტი.");
            }
            else if (row.DiscountPct != row.UnitPriceDiscount && !_isCurrentPaymentMethodGift)
            {
                if (!_IsAllowedAnyProductDiscount && !_IsAllowedZeroDiscountedProductDiscount)
                {
                    flag = false;
                    row.SetColumnError(ds_Sales.SP_GetSalesOrderDetail.UnitPriceDiscountColumn, "თქვენ არ გაქვთ ფასდაკლების უფლება.");
                }
                else if (!_IsAllowedAnyProductDiscount && _IsAllowedZeroDiscountedProductDiscount && row.DiscountPct != 0m)
                {
                    flag = false;
                    row.SetColumnError(ds_Sales.SP_GetSalesOrderDetail.UnitPriceDiscountColumn, "ამ პროდუქტზე არ მოქმედებს ფასდაკლება.");
                }
            }


            var minQty = MathHelper.MinQuantity(row.UnitsInStock, 4);
            if (row.SaleQty < minQty && row.SaleQty != row.Quantity)
            {
                flag = false;
                row.SetColumnError(ds_Sales.SP_GetSalesOrderDetail.SaleQtyColumn, string.Format("მნიშვნელობა უნდა აღემატებოდეს {0}-ს.", minQty.ToString("n4")));
            }

            return flag;
        }
        private bool IsValidOperationGrid()
        {
            var valid = true;
            viewOperation.CloseEditor();
            bsOperation.EndEdit();

            foreach (var row in ds_Operation.T_Operation)
            {
                if (DataSetHelper.IsDataRowDeleted(row)) continue;
                //if (!IsValidRow(row)) valid = false;
                //if (!row.IsValidDateNull() && row.ValidDate < today)
                //{
                //    row.SetColumnError(ds_Sales.SP_GetSalesOrderDetail.ValidDateColumn, "ვადა გასულია.");
                //    expiredProductCount++;
                //}
            }


            return valid;

        }
        private bool IsValidHedgehog()
        {
            if (_IsSavedHedgehog)
            {
                XtraMessageBox.Show(this, "ზღარბი ბარათის ინფორმაცია გაგზავნილია, თქვენ არ შეგიძლიათ მისი ცვლილება.", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetError(chkHedgehog, "ზღარბი ბარათის ინფორმაცია გაგზავნილია, თქვენ არ შეგიძლიათ მისი ცვლილება.");
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var ok = true;
            if (!IsValidOrderDate()) ok = false;
            if (!IsValidCurrency()) ok = false;
            if (!IsValidHedgehog()) ok = false;
            if (ok && !IsValidGrid()) ok = false;

            return ok;
        }

        private bool IsValidPrint()
        {
            if (IsChanged || Action == DatabaseAction.Add)
            {
                XtraMessageBox.Show(this, "გთხოვთ შეინახოთ ჩანაწერი და შემდეგ გაიმეოროთ ოპერაცია.", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        #endregion

        #region Methods
        public override void InvokeAction(string actionName, params object[] args)
        {
            switch (actionName)
            {
                case "PurchaseOrderID":
                    if (args.Length != 1) return;
                    var id = ConvertHelper.ToInt32(args[0]);
                    _purchaseOrderID = id;
                    return;
            }
            base.InvokeAction(actionName, args);
        }
        protected override void InitPermission()
        {
            base.InitPermission();
            _IsAllowedZeroDiscountedProductDiscount = IsPermitted(ObjectNames.DiscountZeroDiscountedProduct, Action);
            _IsAllowedAnyProductDiscount = IsPermitted(ObjectNames.DiscountAnyProduct, Action);
            _IsAllowedAnyDate = IsPermitted(ObjectNames.SalesOrderHeaderAnyDate, Action);
            _IsAllowedFewDate = IsPermitted(ObjectNames.SalesOrderHeaderFewDate, Action);
            _IsAllowedSaleStandardCost = IsPermitted(ObjectNames.SalesOrderHeaderStandardCost, Action);
            _IsAllowedSaleAnyPrice = IsPermitted(ObjectNames.SalesOrderHeaderAnyPrice, Action);
            _IsAllowedSalesOrderHeaderAnyModifier = IsPermitted(ObjectNames.SalesOrderHeaderAnyModifier, DatabaseAction.Edit);
        }
        public void ReEnableDisableFormControls()
        {
            EnableDisableFormControls();
        }
        protected override void Init()
        {
            base.Init();

            ReadOnly = (ReadOnly || (ModifiedUserID != BaseGlobalVariable.UserID && !_IsAllowedSalesOrderHeaderAnyModifier) || Hedgehog);
            ReadOnly = ReadOnly || (ConfigurationManagerEx.OfflineMode && IsOnline);

            txtSalesOrderID.Properties.ReadOnly = true;
            dateOrderDate.Properties.ReadOnly = (ReadOnly || (!_IsAllowedAnyDate && !_IsAllowedFewDate));
            spinDiscountPct.Properties.ReadOnly = (ReadOnly || (!_IsAllowedZeroDiscountedProductDiscount && !_IsAllowedAnyProductDiscount));
            btnCalculator.Enabled = !ReadOnly;

            spinFreight.Properties.ReadOnly = ReadOnly;
            lookCurrency.Properties.ReadOnly = ReadOnly;
            lookPaymentMethod.Properties.ReadOnly = ReadOnly;

            txtOverheadNumber.Properties.ReadOnly = ReadOnly;
            bbCustomer.Properties.ReadOnly = ReadOnly;
            chkSaleStandardCost.Properties.ReadOnly = (ReadOnly || !_IsAllowedSaleStandardCost);
            chkSaleStandardCost.Enabled = (!ReadOnly && _IsAllowedSaleStandardCost);
            memoComment.Properties.ReadOnly = ReadOnly;

            colUnitPrice.OptionsColumn.AllowEdit = (!ReadOnly && _IsAllowedSaleAnyPrice);

            beCard.Properties.Buttons[1].Enabled = !ReadOnly;

            lblHedgehog.Visible = (Hedgehog || ConfigurationManagerEx.UseHedgehog);
            chkHedgehog.Visible = (Hedgehog || ConfigurationManagerEx.UseHedgehog);
            //txtHedgehog.Visible = Hedgehog;
            txtHedgehog.Visible = false;

            chkHedgehog.Properties.ReadOnly = ReadOnly;
            txtHedgehog.Properties.ReadOnly = ReadOnly;

            view.OptionsBehavior.Editable = !ReadOnly;
            XtraGridHelper.SetReadOnly(grid, ReadOnly, true);
            bbBranch.Properties.ReadOnly = ReadOnly || IsPermitted(ObjectNames.SalesOrderHeaderAllBranch, Action);
            miCardHandleItem.Enabled = !ReadOnly;

            //TODO
            XtraGridHelper.SetReadOnly(gridOperation, ReadOnly, true);
        }
        protected override bool SaveData()
        {
            view.CloseEditor();
            bsDetail.EndEdit();

            AddHeader();
            //InitOperation();



            var ds = new DataSet("root");
            DS_Sales.SP_GetSalesOrderDetailDataTable detail = DataSetHelper.PackAlternationTypedDataTable<DS_Sales.SP_GetSalesOrderDetailDataTable>(ds_Sales.SP_GetSalesOrderDetail);
            DataSetHelper.RemoveColumns(detail, true,
                                                detail.SalesOrderDetailIDColumn,
                                                detail.ProductLocationIDColumn,
                                                detail.UnitPriceColumn,
                                                detail.UnitPriceDiscountColumn,
                                                detail.SaleQtyColumn,
                                                detail.OrdinalNumberColumn,
                                                detail.ActionColumn
                                                );
            ds.Tables.Add(detail);

            if (CardNumber.Length != 0)
            {
                var t_cardHandle = new DS_Card.T_CardHandleDataTable();
                t_cardHandle.AddT_CardHandleRow(SalesOrderID, CardNumber, 0m, 0m, BaseGlobalVariable.ServerDateTime, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, BaseGlobalVariable.UserID);
                DataSetHelper.RemoveColumns(t_cardHandle, true, t_cardHandle.CardNumberColumn);
                DataSetHelper.SetColumnMappingType(t_cardHandle);
                ds.Tables.Add(t_cardHandle);
            }

            if (ConfigurationManagerEx.UseHedgehog)
            {
                AddHedgehog();
                DS_Hedgehog.SP_GetSalesHedgehogDataTable hedgehogTable = DataSetHelper.PackAlternationTypedDataTable<DS_Hedgehog.SP_GetSalesHedgehogDataTable>(ds_Hedgehog.SP_GetSalesHedgehog);
                hedgehogTable.Columns.Remove(hedgehogTable.SalesOrderIDColumn);
                hedgehogTable.Columns.Remove(hedgehogTable.ModifiedUserIDColumn);
                hedgehogTable.Columns.Remove(hedgehogTable.ModifiedDateColumn);
                ds.Tables.Add(hedgehogTable);
            }

            var id = SalesManager.AddOrEditSalesOrder(SalesOrderID, BranchID, OrderDate, OverheadNumber, CustomerID, SubTotal, TaxAmt, Freight, TotalDue, CurrencyCode, CurrencyRateID, PaymentMethodID, RevisionNumber, Comment, Status, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, ApproverUserID, ds_Sales.SP_GetSalesOrderHeader[0].rowguid, Action, !ConfigurationManagerEx.OfflineMode, DataSetHelper.InnerBytesData(ds));

            if (id > 0)
            {
                if (Action == DatabaseAction.Add)
                {
                    ds_Sales.SP_GetSalesOrderHeader[0].SalesOrderID = id;

                    DataSetHelper.SetColumnValue(ds_Sales.SP_GetSalesOrderDetail.SalesOrderIDColumn, id);
                    //TODO
                    //foreach (DS_Sales.SP_GetSalesOrderDetailRow row in ds_Sales.SP_GetSalesOrderDetail)
                    //{
                    //    if (DataSetHelper.IsDataRowDeleted(row)) continue;
                    //    row.SalesOrderID = id;
                    //}

                    SalesOrderID = id;
                }
                ds_Sales.AcceptChanges();

                if (ConfigurationManagerEx.UseHedgehog && Hedgehog)
                {
                    try
                    {
                        HedgehogManager.AddOrEditHedgehog(id, TotalDue, DateTime.Now, Action);
                        _IsSavedHedgehog = true;
                        ds_Hedgehog.AcceptChanges();
                    }
                    catch (Exception ex)
                    {
                        ds_Hedgehog.AcceptChanges();
                        Hedgehog = false;
                        XtraMessageBox.Show(this, "ფაქტურა შენახულია, მაგრამ დაზღარბვა ვერ მოხერხდა.\n" + ex.Message, "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }

            return (id > 0);
        }
        protected override void Print()
        {
            if (!IsValidPrint()) return;

            ReportFactory.Show(MdiParent, OptionsBaseForm.Text, ObjectNames.SalesOrderDetail, ds_Sales);
        }

        public void AddHeader()
        {
            try
            {
                DS_Sales.SP_GetSalesOrderHeaderRow row;
                if (ds_Sales.SP_GetSalesOrderHeader.Count == 0)
                {
                    row = ds_Sales.SP_GetSalesOrderHeader.NewSP_GetSalesOrderHeaderRow();
                    row.SalesOrderID = -1;
                    row.rowguid = Guid.NewGuid();
                }
                else
                {
                    row = ds_Sales.SP_GetSalesOrderHeader[0];
                }

                row.BranchID = BranchID;
                row.BranchName = bbBranch.Text;
                row.OrderDate = OrderDate;
                row.OverheadNumber = OverheadNumber;
                row.CustomerID = CustomerID;
                row.CustomerName = CustomerName;

                row.SubTotal = SubTotal;
                row.TaxAmt = TaxAmt;
                row.Freight = Freight;
                row.TotalDue = TotalDue;
                row.CurrencyCode = CurrencyCode;
                row.CurrencyRateID = CurrencyRateID;
                row.PaymentMethodID = PaymentMethodID;
                row.PaymentMethodName = PaymentMethodName;
                row.RevisionNumber = RevisionNumber;
                //row.Comment = Comment;
                row.Status = (byte)Status;
                row.ModifiedUserID = ModifiedUserID;
                row.Modifier = Modifier;
                row.ModifiedDate = ModifiedDate;
                row.ApproverUserID = ApproverUserID;
                row.Approver = Approver;


                if (ds_Sales.SP_GetSalesOrderHeader.Rows.Count == 0)
                    ds_Sales.SP_GetSalesOrderHeader.AddSP_GetSalesOrderHeaderRow(row);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, ex.Message, "შეცდომა", MessageBoxButtons.OK);
            }
        }
        public void AddDetail()
        {
            if (ReadOnly) return;

            try
            {
                if (ds_Sales.SP_GetSalesOrderHeader.Rows.Count == 0)
                    throw new Exception("გთხოვთ შეავსოთ ძირითადი პარამეტრები.");

                bool isContainsForm = FormHelper.ContainsForm(FormHelper.GetFormID(typeof(frmProductLocationBrowse), Handle));
                IForm frm = FormHelper.CreateInstance(typeof(frmProductLocationBrowse), MdiParent, Handle);
                if (!isContainsForm)
                {
                    if (frm is frmProductLocationBrowse)
                    {
                        _frmpl = ((frmProductLocationBrowse)frm);
                        _frmpl.OptionsListForm.ServerMode = true;
                        _frmpl.OptionsListForm.BrowseFormStyle = BrowseFormStyle.Browse;
                        _frmpl.OperationCurrencyRate = CurrencyRate;
                        _frmpl.OnChooseRecord += new CancelEventHandler(OnChooseProduct);
                        _frmpl.OptionsListForm.CloseAfterChoose = false;
                        _frmpl.BranchID = BranchID;
                    }
                }

                frm.Show();
                frm.BringToFront();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool AddDetail(DS_ProductLocation.VW_ProductLocationRow row)
        {
            return AddDetail(row, false);
        }
        public bool AddDetail(DS_ProductLocation.VW_ProductLocationRow row, bool includeAllQuantity)
        {
            if (!row.FinishedGoodsFlag)
            {
                XtraMessageBox.Show(this, "ეს მედიკამენტი არ არის გაყიდვაში", "ინფორმაცია", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }


            //შევამოწმო უკვე არჩეული ხომ არ აქვს ესეთი პროდუქტი
            foreach (var tmprow in ds_Sales.SP_GetSalesOrderDetail)
            {
                if (DataSetHelper.IsDataRowDeleted(tmprow)) continue;
                if (tmprow.ProductLocationID == row.ProductLocationID)
                {
                    XtraMessageBox.Show(this, "ეს მედიკამენტი უკვე არჩეული გაქვთ", "ინფორმაცია", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            //თუ არჩეული არ აქვს მაშინ დავამატოთ.
            var crossRate = row.ProductCurrencyRate / CurrencyRate;
            var saleQty = 0m;
            var unitPrice = (SaleStandardCost ? row.StandardCost : row.ListPrice) * crossRate;

            if (includeAllQuantity)
            {
                saleQty = row.Quantity;
            }
            else
            {
                using (var frm = new frmQuantity(row.UnitsInStock, row.Quantity, unitPrice))
                {
                    if (frm.ShowDialog(this) != DialogResult.OK || frm.OutQty <= 0m)
                        return false;
                    saleQty = frm.OutQty;
                }
            }

            var newRow = ds_Sales.SP_GetSalesOrderDetail.NewSP_GetSalesOrderDetailRow();
            newRow.SalesOrderDetailID = Guid.NewGuid();
            newRow.SalesOrderID = SalesOrderID;
            newRow.ProductLocationID = row.ProductLocationID;
            newRow.BranchID = row.BranchID;
            newRow.ProductID = row.ProductID;
            newRow.ProductNumber = row.ProductNumber;
            newRow.MedicamentName = row.MedicamentName;
            newRow.Quantity = row.Quantity;
            newRow[ds_Sales.SP_GetSalesOrderDetail.ValidDateColumn] = row[ds_Sales.SP_GetSalesOrderDetail.ValidDateColumn.ColumnName];
            newRow[ds_Sales.SP_GetSalesOrderDetail.CountryNameColumn] = row[ds_Sales.SP_GetSalesOrderDetail.CountryNameColumn.ColumnName];
            newRow[ds_Sales.SP_GetSalesOrderDetail.BrandNameColumn] = row[ds_Sales.SP_GetSalesOrderDetail.BrandNameColumn.ColumnName];
            newRow[ds_Sales.SP_GetSalesOrderDetail.SerieColumn] = row[ds_Sales.SP_GetSalesOrderDetail.SerieColumn.ColumnName];

            newRow.DiscountPct = row.DiscountPct;
            newRow.TaxRate = row.TaxRate;
            newRow[ds_Sales.SP_GetSalesOrderDetail.SizeColumn] = row[ds_Sales.SP_GetSalesOrderDetail.SizeColumn.ColumnName];
            newRow[ds_Sales.SP_GetSalesOrderDetail.SizeRangeColumn] = row[ds_Sales.SP_GetSalesOrderDetail.SizeRangeColumn.ColumnName];
            newRow[ds_Sales.SP_GetSalesOrderDetail.SizeUnitMeasureCodeColumn] = row[ds_Sales.SP_GetSalesOrderDetail.SizeUnitMeasureCodeColumn.ColumnName];
            newRow[ds_Sales.SP_GetSalesOrderDetail.WeightColumn] = row[ds_Sales.SP_GetSalesOrderDetail.WeightColumn.ColumnName];
            newRow[ds_Sales.SP_GetSalesOrderDetail.WeightUnitMeasureCodeColumn] = row[ds_Sales.SP_GetSalesOrderDetail.WeightUnitMeasureCodeColumn.ColumnName];
            newRow.UnitsInStock = row.UnitsInStock;

            newRow.UnitPrice = unitPrice;
            newRow._UnitPrice = unitPrice * CurrencyRate;
            newRow.UnitPriceDiscount = (!SaleStandardCost ? row.DiscountPct : 0m);
            newRow.SaleQty = saleQty;
            InitSaleUnitQty(newRow);
            InitResidualQty(newRow);
            InitSaleLineTotal(newRow);

            newRow.OrdinalNumber = (short)(view.RowCount + 1);
            newRow.ModifiedUserID = BaseGlobalVariable.UserID;
            newRow.ModifiedDate = BaseGlobalVariable.ServerDateTime;
            ds_Sales.SP_GetSalesOrderDetail.AddSP_GetSalesOrderDetailRow(newRow);

            IsChanged = true;
            //TaxAmt = TaxAmt;
            //SubTotal = SubTotal;
            //TotalDue = TotalDue;

            view.Focus();
            view.FocusedColumn = colSaleQty;

            return true;
        }

        public void AddHedgehog()
        {
            if (!Hedgehog) return;

            DS_Hedgehog.SP_GetSalesHedgehogRow row;
            if (ds_Hedgehog.SP_GetSalesHedgehog.Count == 0)
            {
                row = ds_Hedgehog.SP_GetSalesHedgehog.NewSP_GetSalesHedgehogRow();
            }
            else
            {
                row = ds_Hedgehog.SP_GetSalesHedgehog[0];
                row.RejectChanges();
            }

            row.SalesOrderID = SalesOrderID;
            row.OrderDate = BaseGlobalVariable.ServerDateTime;
            row.TotalDue = TotalDue;
            row.CardNumber = HedgehogCardNumber;
            row.ModifiedDate = BaseGlobalVariable.ServerDateTime;
            row.ModifiedUserID = BaseGlobalVariable.UserID;

            if (ds_Hedgehog.SP_GetSalesHedgehog.Count == 0)
                ds_Hedgehog.SP_GetSalesHedgehog.AddSP_GetSalesHedgehogRow(row);
        }
        public void DeleteDetail()
        {
            if (ReadOnly) return;

            view.DeleteSelectedRows();
            IsChanged = true;
        }


        public void InitPrices(bool changeDiscount)
        {
            InitPrices(changeDiscount, false);
        }
        public void InitPrices(bool changeDiscount, bool isPaymentMethodChanged)
        {
            if (ReadOnly || IsLoading || (changeDiscount && !_IsAllowedZeroDiscountedProductDiscount && !_IsAllowedAnyProductDiscount && !isPaymentMethodChanged))
                return;

            IsChanged = true;

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                OptionsBaseForm.IsLoading = true;

                var rate = CurrencyRate;
                foreach (var row in ds_Sales.SP_GetSalesOrderDetail)
                {
                    if (DataSetHelper.IsDataRowDeleted(row)) continue;

                    //როცა ეხლა ან წინა გადახდის მეთოდი არჩეული იყო "დაგროვების ბარათი" მაშინ უნდა შეცვალოს ფასდაკლებები.
                    if (isPaymentMethodChanged)
                    {
                        if (_isCurrentPaymentMethodGift || _isPreviousPaymentMethodGift)
                            row.UnitPriceDiscount = _isCurrentPaymentMethodGift ? 0m : row.DiscountPct;
                    }
                    else if (changeDiscount && (_IsAllowedAnyProductDiscount || (_IsAllowedZeroDiscountedProductDiscount && row.DiscountPct == 0m)))
                    {
                        row.UnitPriceDiscount = spinDiscountPct.Value;
                    }
                    row.UnitPrice = row._UnitPrice / rate;
                    InitSaleLineTotal(row);
                }
                SubTotal = SubTotal;
                TotalDue = TotalDue;
                view.UpdateSummary();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, "შეცდომა ფასების ინიციალიზაციისას.\n" + ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                OptionsBaseForm.IsLoading = false;
                Cursor = Cursors.Default;
            }
        }
        public void InitSaleLineTotal(DS_Sales.SP_GetSalesOrderDetailRow row)
        {
            row.LineTotal = (row.UnitPrice * (1m - row.UnitPriceDiscount) * row.SaleQty);
        }
        public void InitResidualQty(DS_Sales.SP_GetSalesOrderDetailRow row)
        {
            row._ResidualQty = row.Quantity - row.SaleQty;
        }
        public void InitSaleUnitQty(DS_Sales.SP_GetSalesOrderDetailRow row)
        {
            row._SaleUnitQty = MathHelper.RoundUnit(row.SaleQty, row.UnitsInStock, 4, row.Quantity);
        }

        public void OnChooseProduct(object sender, CancelEventArgs e)
        {
            if (ReadOnly || OptionsBaseForm.IsLoading || OptionsBaseForm.IsClosing) return;

            try
            {
                var frm = (sender as frmBrowse);

                if (frm == null) return;

                if (frm.OptionsGrid.SelectedRecordID == null)
                    throw new NullReferenceException("არჩეული ჩანაწერის იდენთიფიკატორი ცარიელია. (frm.SelectedRecordID = null)");

                var table = ProductLocationManager.GetVWByIDAndBranch(ConvertHelper.ToInt32(frm.OptionsGrid.SelectedRecordID), BranchID, !ConfigurationManagerEx.OfflineMode);
                if (table.Count == 0)
                    throw new NullReferenceException("ჩანაწერი ვერ ვიპოვე მონაცემთა ბაზაში.");


                if (SaleStandardCost)//თვითღირებულება
                {
                    var crossRate = table[0].ProductCurrencyRate / CurrencyRate;
                    table[0].StandardCost = ProductionManager.GetPurchaseUnitPrice(table[0].ProductID, CurrencyCode) / crossRate;
                }

                e.Cancel = !AddDetail(table[0]);
            }
            catch (Exception ex)
            {
                ExceptionHelper.Show(ex, "შეცდომა მონაცემის არჩევისას", MessageBoxIcon.Error);
            }
        }
        public void IndexOrdinalNumbers()
        {
            if (ReadOnly) return;

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                XtraGridHelper.IndexOrdinalNumbers(view, colOrdinalNumber);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, string.Format("რიგითი ნომრების ინდექსირება ვერ მოხერხდა.\n{0}", ex.Message), "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        public void ShowCalculator()
        {
            if (ReadOnly || spinTotalDue.Value <= 0m) return;

            using (var frm = new frmCalculator(spinTotalDue.Value))
            {
                frm.ShowDialog(this);
            }
        }
        public void ProcessKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert && !e.Control && !e.Alt && !e.Shift)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;

                AddDetail();
            }
            else if (e.KeyCode == Keys.Insert && e.Control && !e.Alt && !e.Shift)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;

                if (ReadOnly) return;

                using (var frm = new frmBarCode(BranchID))
                {
                    if (frm.ShowDialog(this) == DialogResult.OK)
                        AddDetail(frm.ds_ProductLocation.VW_ProductLocation[0]);
                }
            }
            else if (e.KeyCode == Keys.F8 && !e.Shift && !e.Control && !e.Alt)
            {
                if (xtraTabControl.SelectedTabPage != tabMain) return;

                e.SuppressKeyPress = true;
                e.Handled = true;

                DeleteDetail();
            }
            else if (e.KeyCode == Keys.F12 && !e.Control && !e.Alt && !e.Shift)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                ShowCalculator();
            }
            else if (e.KeyCode == Keys.F9 && !e.Control && !e.Alt && !e.Shift)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                XtraGridHelper.BestFitColumns(view);
            }
        }
        #endregion

        private void txtSalesID_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(txtSalesOrderID);
        }

        private void dateOrderDate_EditValueChanged(object sender, EventArgs e)
        {
            if (OptionsBaseForm.IsLoading) return;

            IsChanged = true;
            ClearError(dateOrderDate);
        }

        private void dateOrderDate_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (ReadOnly) return;

            if (e.Button.Kind == ButtonPredefines.OK)
            {
                try
                {
                    Application.DoEvents();
                    Cursor = Cursors.WaitCursor;

                    OrderDate = SalesManager.GetOrderDate(ObjectNames.PurchaseOrderHeader, 0, GlobalVariable.BranchID, BaseGlobalVariable.ServerDateTime, !ConfigurationManagerEx.OfflineMode);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(this, "შეცდომა თარიღის ამოღებისას.\n" + ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
            }
        }

        private void spinFreight_EditValueChanged(object sender, EventArgs e)
        {
            if (OptionsBaseForm.IsLoading) return;

            IsChanged = true;
            ClearError(spinFreight);
            TotalDue = TotalDue;
        }

        private void spinTaxAmt_EditValueChanged(object sender, EventArgs e)
        {
            if (OptionsBaseForm.IsLoading) return;

            IsChanged = true;
            ClearError(spinTaxAmt);
            TotalDue = TotalDue;
        }

        private void lookCurrency_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(lookCurrency);
            InitPrices(false);
        }

        private void spinSubTotal_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(spinSubTotal);
        }

        private void spinTotalDue_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(spinTotalDue);
        }

        private bool _isPreviousPaymentMethodGift;
        private bool _isCurrentPaymentMethodGift;
        private void lookPaymentMethod_EditValueChanged(object sender, EventArgs e)
        {
            if (IsLoading) return;

            IsChanged = true;
            ClearError(lookPaymentMethod);

            _isPreviousPaymentMethodGift = _isCurrentPaymentMethodGift;
            _isCurrentPaymentMethodGift = lookPaymentMethod.Text == "დაგროვების ბარათი";

            if (_isPreviousPaymentMethodGift || _isCurrentPaymentMethodGift)
                InitPrices(true, true);
        }

        private void txtOverheadNumber_EditValueChanged(object sender, EventArgs e)
        {
            if (OptionsBaseForm.IsLoading) return;

            IsChanged = true;
            ClearError(txtOverheadNumber);
        }

        private void memoComment_EditValueChanged(object sender, EventArgs e)
        {
            if (OptionsBaseForm.IsLoading) return;

            IsChanged = true;
            ClearError(memoComment);
        }

        private void gridEmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (ReadOnly && e.Button.ButtonType != NavigatorButtonType.Custom)
            {
                e.Handled = true;
                return;
            }

            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                e.Handled = true;
                AddDetail();
            }
            else if (e.Button.ButtonType == NavigatorButtonType.Custom)
            {
                e.Handled = true;
                var tag = (int)e.Button.Tag;

                switch (tag)
                {
                    case 1:
                        IndexOrdinalNumbers();
                        break;
                }
            }
        }

        private void grid_ProcessGridKey(object sender, KeyEventArgs e)
        {
            ProcessKey(sender, e);
        }

        private void view_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (ReadOnly || OptionsBaseForm.IsLoading) return;

            IsChanged = true;

            var row = ((DS_Sales.SP_GetSalesOrderDetailRow)view.GetDataRow(e.RowHandle));
            row.SetColumnError(e.Column.FieldName, string.Empty);
            try
            {
                OptionsBaseForm.IsLoading = true;

                switch (e.Column.Name)
                {
                    case "colUnitPrice":
                        row._UnitPrice = row.UnitPrice * CurrencyRate;
                        InitSaleLineTotal(row);
                        SubTotal = SubTotal;
                        TaxAmt = TaxAmt;
                        TotalDue = TotalDue;
                        break;
                    case "colUnitPriceDiscount":
                        InitSaleLineTotal(row);
                        SubTotal = SubTotal;
                        TaxAmt = TaxAmt;
                        TotalDue = TotalDue;
                        break;

                    case "col_SaleUnitQty":
                    case "colSaleQty":
                        var value = (e.Column.Name == "colSaleQty" ? row.SaleQty : MathHelper.CeilingQuantity(row._SaleUnitQty, row.UnitsInStock, 4, row.Quantity));
                        if (value > row.Quantity)
                        {
                            value = row.Quantity;
                            row.SaleQty = row.Quantity;
                        }

                        if (e.Column.Name == "col_SaleUnitQty")
                            row.SaleQty = value;
                        row._SaleUnitQty = MathHelper.RoundUnit(row.SaleQty, row.UnitsInStock, 4);
                        row._ResidualQty = row.Quantity - row.SaleQty;

                        InitResidualQty(row);
                        InitSaleLineTotal(row);

                        SubTotal = SubTotal;
                        TaxAmt = TaxAmt;
                        TotalDue = TotalDue;
                        break;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, string.Format("შეცდომა ცხრილში მნიშვნელობების მინიჭებისას. გთხოვთ გაიმეოროთ მიმდინარე ოპერაცია.\n{0}", ex.Message), "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                OptionsBaseForm.IsLoading = false;
            }

            view.UpdateSummary();
        }

        private void view_RowCountChanged(object sender, EventArgs e)
        {
            if (OptionsBaseForm.IsLoading) return;
            TaxAmt = TaxAmt;
            SubTotal = SubTotal;
            TotalDue = TotalDue;
        }

        private void view_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (IsLoading || ReadOnly) return;

            if (view.FocusedColumn == colUnitPriceDiscount)
            {
                if (!_IsAllowedZeroDiscountedProductDiscount && _IsAllowedAnyProductDiscount)
                {
                    e.Cancel = true;
                    return;
                }

                if (!_IsAllowedAnyProductDiscount)
                {
                    var tmprow = view.GetFocusedDataRow();
                    if (tmprow == null) return;
                    var row = (DS_Sales.SP_GetSalesOrderDetailRow)tmprow;
                    if (row.DiscountPct != 0)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
        }

        private void frmSalesOrderEdit_KeyDown(object sender, KeyEventArgs e)
        {
            ProcessKey(sender, e);
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            ShowCalculator();
        }

        private void frmSalesOrderEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_frmpl != null)
            {
                if (_frmpl.IsDisposed)
                    _frmpl = null;
                else
                    _frmpl.Close();
            }
        }

        private void chkHedgehog_CheckedChanged(object sender, EventArgs e)
        {
            if (OptionsBaseForm.IsLoading) return;

            IsChanged = true;
            ClearError(chkHedgehog);

            //txtHedgehog.Visible = Hedgehog;
            if (!Hedgehog && ds_Hedgehog.SP_GetSalesHedgehog.Count > 0)
                ds_Hedgehog.SP_GetSalesHedgehog[0].Delete();
        }

        private void frmSalesOrderEdit_Shown(object sender, EventArgs e)
        {
            if (ReadOnly || OptionsBaseForm.IsClosing) return;

            if (_purchaseOrderID != 0)
            {
                var header = PurchasingManager.GetPurchaseOrderHeader(_purchaseOrderID);
                if (header.Count == 0 || header[0].Status != (byte)DatabaseStatus.Approved) return;
                BranchID = header[0].BranchID;
                var detail = ProductLocationManager.GetVWByPurchaseOrderID(_purchaseOrderID);
                foreach (var row in detail)
                {
                    AddDetail(row, true);
                }
            }
            else if (ConfigurationManagerEx.AutoNewRow && Action == DatabaseAction.Add)
                AddDetail();
        }

        private void spinDiscountPct_EditValueChanged(object sender, EventArgs e)
        {
            InitPrices(true);
        }

        private void bbCustomer_PrimaryKeyChanged(object sender, EventArgs e)
        {
            if (OptionsBaseForm.IsLoading) return;

            IsChanged = true;
        }

        private void chkSaleStandardCost_CheckedChanged(object sender, EventArgs e)
        {
            if (!_IsAllowedSaleStandardCost) return;

            if (SaleStandardCost)
            {
                var table = new DS_PurchaseOrderInfo.T_ProductDataTable();
                foreach (var row in ds_Sales.SP_GetSalesOrderDetail)
                {
                    if (DataSetHelper.IsDataRowDeleted(row)) continue;

                    table.AddT_ProductRow(row.ProductID);
                }
                DataTable t_xml = DataSetHelper.PackAlternationDataTable(table);
                var purchaseInfo = ProductionManager.GetPurchaseOrderInfo(0, CurrencyCode, DataSetHelper.InnerBytesData(t_xml));
                var view = new DataView(purchaseInfo);
                view.Sort = purchaseInfo.ProductIDColumn.ColumnName;

                var rate = CurrencyRate;
                foreach (var row in ds_Sales.SP_GetSalesOrderDetail)
                {
                    if (DataSetHelper.IsDataRowDeleted(row)) continue;

                    var i = view.Find(row.ProductID);
                    if (i == -1) continue;

                    var purchaseRow = (DS_PurchaseOrderInfo.SP_GetPurchaseOrderInfoRow)view[i].Row;
                    var price = ProductionManager.GetPurchaseUnitPrice(purchaseRow.UnitPrice, purchaseRow.AverageRate1, purchaseRow.AverageRate2) * rate;
                    row._UnitPrice = MathHelper.AddPct(price, row.TaxRate * 100m);
                    row.UnitPriceDiscount = 0m;
                }
            }

            InitPrices(false);
        }

        private void btnGetCardInfo_Click(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                gridCard.DataSource = CardManager.GetCardInfoForNameValueGrid(CardNumber, IsOnline);
            }
            catch (Exception ex)
            {
                ExceptionHelper.Show(ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void beCard_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            switch (e.Button.Kind)
            {
                case ButtonPredefines.Delete:
                    if (IsLoading || ReadOnly) return;
                    if (CardNumber.Length != 0) IsChanged = true;
                    CardNumber = string.Empty;
                    break;
                case ButtonPredefines.Up:
                    if (CardNumber.Length == 0) return;
                    var id = CardManager.GetCardID(CardNumber);
                    if (id == 0) return;
                    FormHelper.Show(typeof(frmCardEdit), MdiParent, IntPtr.Zero, id);
                    break;
            }
        }

        private void gridOperation_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            switch (e.Button.ButtonType)
            {
                case NavigatorButtonType.Append:
                    e.Handled = true;
                    //ds_Operation.T_Operation.AddT_OperationRow(OrderDate, 0m, CurrencyCode, 0, GlobalVariable.ServerDateTime, GlobalVariable.UserID, GlobalVariable.ServerDateTime, GlobalVariable.UserID, Guid.NewGuid());
                    break;
            }
        }
        /*
        CREATE TABLE '00018028' (
            'DATE' VarChar(10), 
            'CLIENTID' VarChar(9), 
            'NAME' VarChar(150), 
            'FULLNAME' VarChar(150), 
            'CODE' VarChar(25), 
            'VAT' VarChar(50), 
            'BARCODE' VarChar(50), 
            'COST' double, 
            'QUANTITY' double
        )*/
    }
}
