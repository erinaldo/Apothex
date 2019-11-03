using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Apothex.Configuration;
using Apothex.Reporting;
using Apothex.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using Zek.Core;
using Apothex.DataType;
using Apothex.Common;
using Apothex.DataManagment.Production;
using Zek.Data;
using Apothex.DataManagment.Dictionary;
using Zek.Windows.Forms.DevEx;
using Zek.Windows.Forms;
using Apothex.DataManagment.ProductLocation;
using Apothex.DataManagment.Branch;

namespace Apothex.Production
{
    public partial class frmProductDistributionEdit : frmEditBrowse
    {
        public frmProductDistributionEdit()
        {
            InitializeComponent();

            InitMenu();
            XtraGridHelper.InitGrid(grid, true);
            XtraGridHelper.BestFitColumns(view);
        }

        #region Fields
        public int ProductDistributionID
        {
            get { return ConvertHelper.ToInt32(PrimaryKey); }
            set
            {
                PrimaryKey = value;
                txtProductDistributionID.Text = txtID.Text = value.ToString();
                Text = OptionsBaseForm.Text + (value > 0 ? " №" + value.ToString() : string.Empty);
            }
        }
        public int FromBranchID
        {
            get { return ConvertHelper.ToInt32(lookFromBranch.EditValue); }
            set { lookFromBranch.EditValue = value.ToString(); }
        }
        public int ToBranchID
        {
            get { return ConvertHelper.ToInt32(lookToBranch.EditValue); }
            set { lookToBranch.EditValue = value.ToString(); }
        }
        public DateTime StartDate
        {
            get { return DateTimeHelper.GetStartOfSecond(dateStartDate.EditValue); }
            set { dateStartDate.EditValue = value; }
        }
        public DateTime EndDate
        {
            get { return DateTimeHelper.GetStartOfSecond(dateEndDate.EditValue); }
            set { dateEndDate.EditValue = value; }
        }
        public decimal SubTotal
        {
            get
            {
                var value = 0m;
                foreach (var row in ds_Production.SP_GetProductDistributionDetail)
                {
                    if (DataSetHelper.IsDataRowDeleted(row)) continue;
                    value += row.LineTotal;
                }
                return Math.Round(value, 4) - TaxAmt;
            }
            set { }
        }
        public decimal TaxAmt
        {
            get
            {
                return 0m;
                //if (!GlobalVariable.VATPayerFlag) return 0m;
                //decimal value = 0m;
                //foreach (DS_ProductDistribution.SP_GetProductDistributionDetailRow row in ds_Production.SP_GetProductDistributionDetail)
                //{
                //    if (DataSetHelper.IsDataRowDeleted(row)) continue;
                //    value += row.LineTotal - MathHelper.RemoveAddedPct(row.LineTotal, row.TaxRate * 100);
                //}
                //return Math.Round(value, 4);
            }
            set { }
        }
        public decimal Freight
        {
            get { return 0m; }
            set { }
        }
        public decimal TotalDue
        {
            get { return SubTotal + TaxAmt + Freight; }
            set { }
        }
        public string CurrencyCode
        {
            get { return ConvertHelper.ToString(lookCurrency.EditValue); ; }
            set { lookCurrency.EditValue = value; }
        }
        public int CurrencyRateID
        {
            get { return 0; }
            set { }
        }
        public decimal CurrencyRate
        {
            get { return Convert.ToDecimal(lookCurrency.GetColumnValue("Code")); }
        }
        public string Comment
        {
            get { return memoComment.Text.Trim(); }
            set { memoComment.Text = value.Trim(); }
        }
        public byte RevisionNumber
        {
            get { return ConvertHelper.ToByte(spinRevisionNumber.EditValue); }
            set { spinRevisionNumber.EditValue = value; }
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

        public bool _IsAllowedAnyDate = false;
        public bool _IsAllowedAnyBranch = false;

        public frmProductLocationBrowse _frmpl;
        #endregion

        #region Menu
        private void InitMenu()
        {
            BarSubItem subMenu = XtraBarHelper.MoveIntoBarSubItem(miPrint, "ამობეჭვდა", miPrint.Glyph, BarItemPaintStyle.CaptionInMenu);
            miPrint.Glyph = null;
            XtraBarHelper.AddBarButtonItem(subMenu, "ამობეჭვდა სასაქონლო ზედნადების", null, miPrintVATOrder_ItemClick);
            XtraBarHelper.AddBarButtonItem(subMenu, "ამობეჭვდა დანართი №4", null, miPrintEnclosure4_ItemClick);
            XtraBarHelper.AddBarButtonItem(subMenu, "ამობეჭვდა დანართი №7", null, miEnclosure7_ItemClick);
            XtraBarHelper.AddBarButtonItem(subMenu, "ამობეჭვდა გასავლის ზედდებულის", null, miEnclosureInCountry_ItemClick);
        }
        private void Print(Reports.ReportName reportName)
        {
            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                var rate1 = DictionaryManager.GetCurrencyRate(CurrencyCode, StartDate);
                var rate2 = DictionaryManager.GetCurrencyRate(GlobalVariable.MyCompanyConditionalUnitCurrencyCode, StartDate);
                var crossRate = rate2 / rate1;

                var ds = new Zek.DataModel.DS_TradeOrder();
                Zek.DataModel.DS_TradeOrder.T_HeaderRow hrow = ds.T_Header.NewT_HeaderRow();
                hrow.HeaderID = ProductDistributionID;
                hrow.OrderNumber = ProductDistributionID.ToString();
                hrow.OrderDate = StartDate;
                hrow.SubTotal = SubTotal;
                hrow.VATAmt = TaxAmt;
                hrow.Freight = Freight;
                hrow.TotalDue = TotalDue;
                hrow.CurrencyCode = CurrencyCode;
                hrow.CurrencyName = NumToStrHelper.ToCurrencyName(CurrencyCode);
                hrow.CurrencyCoin = NumToStrHelper.ToCurrencyCoin(CurrencyCode);
                hrow.CurrencyRate = rate2;
                hrow.ProductCurrencyRate = rate2;

                hrow.VendorName = GlobalVariable.MyCompanyName + " (" + lookFromBranch.Text + ")";
                hrow.VendorTaxCode = GlobalVariable.MyCompanyTaxCode;
                hrow.VendorAddress = GlobalVariable.MyCompanyAddress;
                hrow.VendorPhone = GlobalVariable.MyCompanyPhone;

                hrow.CustomerName = GlobalVariable.MyCompanyName + " (" + lookToBranch.Text + ")";
                hrow.CustomerTaxCode = GlobalVariable.MyCompanyTaxCode;
                hrow.CustomerAddress = GlobalVariable.MyCompanyAddress;
                hrow.CustomerPhone = GlobalVariable.MyCompanyPhone;

                var fromBranch = BranchManager.Get(FromBranchID);
                if (fromBranch.Count > 0)
                {
                    hrow.ShipperName = GlobalVariable.MyCompanyName + " (" + fromBranch[0].Name + ")";
                    hrow.ShipperTaxCode = GlobalVariable.MyCompanyTaxCode;
                    hrow.ShipperAddress = fromBranch[0].Address;
                    hrow.ShipperPhone = fromBranch[0].Phone;

                    hrow.VendorAddress = hrow.ShipperAddress;
                    hrow.VendorPhone = hrow.ShipperPhone;
                }

                var toBranch = BranchManager.Get(ToBranchID);
                if (toBranch.Count > 0)
                {
                    hrow.ShipToName = GlobalVariable.MyCompanyName + " (" + fromBranch[0].Name + ")";
                    hrow.ShipToTaxCode = GlobalVariable.MyCompanyTaxCode;
                    hrow.ShipToAddress = toBranch[0].Address;
                    hrow.ShipToPhone = toBranch[0].Phone;

                    hrow.CustomerAddress = hrow.ShipToAddress;
                    hrow.CustomerPhone = hrow.ShipToPhone;
                }


                ds.T_Header.AddT_HeaderRow(hrow);


                if (!string.IsNullOrEmpty(GlobalVariable.MyCompanyBankName)) ds.T_Header[0].VenderBankInfo = GlobalVariable.MyCompanyBankName;
                if (!string.IsNullOrEmpty(GlobalVariable.MyCompanyBankCode)) ds.T_Header[0].VenderBankInfo += ", კოდი " + GlobalVariable.MyCompanyBankCode;
                if (!string.IsNullOrEmpty(GlobalVariable.MyCompanyBankAccountNumber)) ds.T_Header[0].VenderBankInfo += ", ა/ა " + GlobalVariable.MyCompanyBankAccountNumber;
                ds.T_Header[0].VenderBankInfo = ds.T_Header[0].VenderBankInfo.TrimStart(' ', ',');




                var i = 1;
                foreach (var row in ds_Production.SP_GetProductDistributionDetail)
                {
                    Zek.DataModel.DS_TradeOrder.T_DetailRow newRow = ds.T_Detail.NewT_DetailRow();
                    newRow.HeaderID = ProductDistributionID;
                    newRow.DetailID = i++;
                    newRow.Line = row.OrdinalNumber;
                    newRow.ProductName = row.MedicamentName;
                    if (!row.IsSerieNull()) newRow.Serie = row.Serie;
                    newRow.Quantity = row.DistributeQty;
                    newRow.UnitMeasure = "ცალი";
                    newRow.UnitPrice = row.UnitPrice;
                    newRow.StockedQty = row._ResidualQty;
                    newRow.PackQty = row.UnitsInStock;
                    if (!row.IsValidDateNull()) newRow.ValidDate = row.ValidDate;
                    newRow.Manufacturer = (!row.IsBrandNameNull() ? row.BrandName + " " : string.Empty);
                    if (!row.IsCountryNameNull()) newRow.ManufactureCountry = row.CountryName;

                    ds.T_Detail.AddT_DetailRow(newRow);
                }

                Zek.Report.ReportHelper.Show(MdiParent, Text, reportName, ds);
                //ReportViewerForm.Show(MdiParent, Text, reportName, ds);
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
        private void miPrintVATOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            Print(Reports.ReportName.VATOrder);
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
        #endregion

        #region Bindings
        protected override void BindControls()
        {
            bsCurrency.DataSource = DictionaryManager.GetDictionary(ObjectNames.CurrencyWithLastRate);
            CurrencyCode = GlobalVariable.MyCompanyDefaultTradingCurrencyCode;

            bsFromBranch.DataSource = DictionaryManager.GetDictionary(ObjectNames.Branch);
            bsToBranch.DataSource = DictionaryManager.GetDictionary(ObjectNames.Branch);
        }
        protected override void BindData()
        {
            if (Action == DatabaseAction.Edit)
            {
                ds_Production.SP_GetProductDistributionHeader.Clear();
                ds_Production.SP_GetProductDistributionHeader.Merge(ProductionManager.GetProductDistributionHeader(ProductDistributionID));
                if (ds_Production.SP_GetProductDistributionHeader.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.", "RecordID");

                ProductDistributionID = ds_Production.SP_GetProductDistributionHeader[0].ProductDistributionID;
                FromBranchID = ds_Production.SP_GetProductDistributionHeader[0].FromBranchID;
                ToBranchID = ds_Production.SP_GetProductDistributionHeader[0].ToBranchID;
                StartDate = ds_Production.SP_GetProductDistributionHeader[0].StartDate;
                dateEndDate.EditValue = ds_Production.SP_GetProductDistributionHeader[0][ds_Production.SP_GetProductDistributionHeader.EndDateColumn];
                RevisionNumber = ds_Production.SP_GetProductDistributionHeader[0].RevisionNumber;
                //Comment = ds_Production.SP_GetProductDistributionHeader[0].Comment;

                Status = (DatabaseStatus)ds_Production.SP_GetProductDistributionHeader[0].Status;
                ModifiedUserID = ds_Production.SP_GetProductDistributionHeader[0].ModifiedUserID;
                ModifiedDate = ds_Production.SP_GetProductDistributionHeader[0].ModifiedDate;
                ApproverUserID = ds_Production.SP_GetProductDistributionHeader[0].ApproverUserID;

                ds_Production.SP_GetProductDistributionDetail.Clear();
                ds_Production.SP_GetProductDistributionDetail.Merge(ProductionManager.GetProductDistributionDetail(ProductDistributionID));

                var rate = CurrencyRate;
                foreach (var row in ds_Production.SP_GetProductDistributionDetail)
                {
                    row._UnitPrice = row.UnitPrice * rate;
                    row._ResidualQty = row.Quantity;
                    row.Quantity += row.DistributeQty;
                    row._DistributeUnitQty = MathHelper.RoundUnit(row.DistributeQty, row.UnitsInStock, 4);
                }

                ds_Production.AcceptChanges();
            }
            else
            {
                ModifiedUserID = BaseGlobalVariable.UserID;
                ModifiedDate = BaseGlobalVariable.ServerDateTime;

                FromBranchID = GlobalVariable.BranchID;
                StartDate = BaseGlobalVariable.ServerDateTime;

                AddHeader();
            }
        }
        #endregion

        #region Valdations
        public bool IsValidDistributionDate()
        {
            //if (!TrialMakerHelper.CheckDate(StartDate.Date))
            //{
            //    dxErrorProvider.SetError(dateStartDate, TrialMakerHelper.ErrorNotValidCheckDate);
            //    return false;
            //}

            if (_IsAllowedAnyDate)
                return true;

            if (StartDate.Date != BaseGlobalVariable.ServerDateTime.Date)
            {
                dxErrorProvider.SetError(dateStartDate, "დისტრიბუციის თარიღი უნდა იყოს ტოლი სერვერის თარიღის.");
                return false;
            }

            return true;
        }
        public bool IsValidCurrency()
        {
            if (CurrencyCode.Length == 0)
            {
                dxErrorProvider.SetError(lookCurrency, "!");
                return false;
            }

            return true;
        }
        public bool IsValidFromBranch()
        {
            if (FromBranchID == 0)
            {
                dxErrorProvider.SetError(lookFromBranch, "ფილიალი არ არის არჩეული.");
                return false;
            }

            return true;
        }
        public bool IsValidToBranch()
        {
            if (ToBranchID == 0)
            {
                dxErrorProvider.SetError(lookToBranch, "გთხოვთ აირჩიეთ ფილიალი.");
                return false;
            }
            if (FromBranchID == ToBranchID)
            {
                dxErrorProvider.SetError(lookToBranch, "გამგზავნი და მიმღები ფილიალები ემთხვევა ერთმანეთს. გთხოვთ აირჩიეთ სხვა ფილიალი.");
                return false;
            }

            return true;
        }
        public bool IsValidGrid()
        {
            view.CloseEditor();
            bsDetail.EndEdit();

            var ok = true;
            foreach (var row in ds_Production.SP_GetProductDistributionDetail)
            {
                if (row.RowState == DataRowState.Deleted) continue;
                if (!IsValidRow(row)) ok = false;
            }
            if (!ok) return ok;


            DS_ProductDistribution.SP_GetProductDistributionDetailDataTable table = DataSetHelper.PackAlternationTypedDataTable<DS_ProductDistribution.SP_GetProductDistributionDetailDataTable>(ds_Production.SP_GetProductDistributionDetail, DataRowState.Added | DataRowState.Modified);
            table.PrimaryKey = null;
            DataSetHelper.RemoveColumns(table, true, table.ProductLocationIDColumn,
                                                                                    table.ProductDistributionDetailIDColumn,
                                                                                    table.ActionColumn);
            var ds = new DataSet("root");
            ds.Tables.Add(table);
            var productLocationQuantity = ProductLocationManager.GetProductLocationQuantity(0, ObjectNames.ProductDistributionDetail, true, DataSetHelper.InnerBytesData(ds));

            foreach (var row2 in ds_Production.SP_GetProductDistributionDetail)
            {
                if (row2.RowState == DataRowState.Deleted) continue;
                foreach (var tmp in productLocationQuantity)
                {
                    if (tmp.RowState == DataRowState.Deleted) continue;
                    if (row2.ProductLocationID == tmp.ProductLocationID)
                    {
                        row2.Quantity = tmp.Quantity;
                        InitResidualQty(row2);
                    }
                }

                if (!IsValidRowQuantity(row2)) ok = false;
            }

            return ok;
        }
        public bool IsValidRow(DS_ProductDistribution.SP_GetProductDistributionDetailRow row)
        {
            row.ClearErrors();
            var ok = true;

            if (row.BranchID != FromBranchID)
            {
                ok = false;
                row.SetColumnError(ds_Production.SP_GetProductDistributionDetail.OrdinalNumberColumn, "ეს პროდუქტი არის სხვა ფილიალში.");
            }


            var minQty = MathHelper.MinQuantity(row.UnitsInStock, 4);
            if (row.DistributeQty < minQty && row.DistributeQty != row.Quantity)
            {
                ok = false;
                row.SetColumnError(ds_Production.SP_GetProductDistributionDetail.DistributeQtyColumn, string.Format("მნიშვნელობა უნდა აღემატებოდეს {0}-ს.", minQty.ToString("n4")));
            }

            return ok;
        }
        public bool IsValidRowQuantity(DS_ProductDistribution.SP_GetProductDistributionDetailRow row)
        {
            var ok = true;
            if (row.Quantity < row.DistributeQty)
            {
                ok = false;
                row.SetColumnError(ds_Production.SP_GetProductDistributionDetail.DistributeQtyColumn, string.Format("სადისტრიბუციო მედიკამენტების რაოდენობა არ უნდა აღემატებოდეს არსებულს.\nდარჩენილი რაოდენობა = {0}", row.Quantity));
            }

            return ok;
        }
        protected override bool IsValidForm()
        {
            var ok = true;
            if (!IsValidDistributionDate()) ok = false;
            if (!IsValidCurrency()) ok = false;
            if (!IsValidFromBranch()) ok = false;
            if (!IsValidToBranch()) ok = false;
            if (ok && !IsValidGrid()) ok = false;

            return ok;
        }

        public bool IsValidCurrentRow()
        {
            view.CloseEditor();
            bsDetail.EndEdit();
            if (view.SelectedRowsCount > 0 && !IsValidRow(((DS_ProductDistribution.SP_GetProductDistributionDetailRow)view.GetDataRow(view.FocusedRowHandle))))
                return false;

            return true;
        }
        #endregion

        #region Methods
        protected override void Init()
        {
            base.Init();

            _IsAllowedAnyDate = IsPermitted(ObjectNames.ProductDistributionHeaderAnyDate, Action);
            _IsAllowedAnyBranch = IsPermitted(ObjectNames.ProductDistributionHeaderAllBranch, Action);
            ReadOnly = (ReadOnly || ModifiedUserID != BaseGlobalVariable.UserID);

            txtProductDistributionID.Properties.ReadOnly = true;
            dateStartDate.Properties.ReadOnly = ReadOnly || !_IsAllowedAnyDate;
            dateEndDate.Properties.ReadOnly = true;
            lookCurrency.Properties.ReadOnly = ReadOnly;
            lookFromBranch.Properties.ReadOnly = ReadOnly || !_IsAllowedAnyBranch;
            lookToBranch.Properties.ReadOnly = ReadOnly;
            memoComment.Properties.ReadOnly = ReadOnly;


            view.OptionsBehavior.Editable = !ReadOnly;
            grid.EmbeddedNavigator.Buttons.Append.Enabled = !ReadOnly;
            grid.EmbeddedNavigator.Buttons.Edit.Enabled = !ReadOnly;
            grid.EmbeddedNavigator.Buttons.Remove.Enabled = !ReadOnly;
            grid.EmbeddedNavigator.Buttons.CancelEdit.Enabled = !ReadOnly;
            grid.EmbeddedNavigator.Buttons.EndEdit.Enabled = !ReadOnly;
            grid.EmbeddedNavigator.Buttons.CustomButtons[0].Enabled = !ReadOnly;
        }
        protected override bool SaveData()
        {
            view.CloseEditor();
            bsDetail.EndEdit();

            DS_ProductDistribution.SP_GetProductDistributionDetailDataTable table = DataSetHelper.PackAlternationTypedDataTable<DS_ProductDistribution.SP_GetProductDistributionDetailDataTable>(ds_Production.SP_GetProductDistributionDetail);
            DataSetHelper.RemoveColumns(table, true, table.ProductDistributionDetailIDColumn,
                                                                                    table.ProductLocationIDColumn,
                                                                                    table.DistributeQtyColumn,
                                                                                    table.UnitPriceColumn,
                                                                                    table.OrdinalNumberColumn,
                                                                                    table.ActionColumn);

            var ds = new DataSet("root");
            ds.Tables.Add(table);

            var id = ProductionManager.AddOrEditProductDistribution(ProductDistributionID, FromBranchID, ToBranchID, StartDate, EndDate, SubTotal, TaxAmt, Freight, TotalDue, CurrencyCode, CurrencyRateID, Comment, RevisionNumber, Status, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, ApproverUserID, Action, DataSetHelper.InnerBytesData(ds));
            if (id > 0)
            {
                if (Action == DatabaseAction.Add)
                {
                    ds_Production.SP_GetProductDistributionHeader[0].ProductDistributionID = id;
                    foreach (var row in ds_Production.SP_GetProductDistributionDetail)
                    {
                        if (row.RowState == DataRowState.Deleted) continue;
                        row.ProductDistributionID = id;
                    }
                    ProductDistributionID = id;
                }
            }

            ds_Production.AcceptChanges();
            return (id > 0);
        }
        protected override void Print()
        {
            AddHeader();

            var rpt = ReportFactory.GetReport(ObjectNames.ProductDistributionDetail);
            rpt.Printed += new EventHandler(OnPrint);

            ReportFactory.Show(MdiParent, OptionsBaseForm.Text, rpt, ds_Production);
        }
        private void OnPrint(object sender, EventArgs e)
        {
            //if (IsChanged || Action == DatabaseAction.Add)
            //{
            //    XtraMessageBox.Show(this, "გთხოვთ შეინახოთ ჩანაწერი და შემდეგ გაიმეოროთ ოპერაცია.", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (Status == DatabaseStatus.Pending)
            //{
            //    XtraMessageBox.Show(this, "მხოლოდ დადასტურებული შეკვეთის ამობეჭვდაა შესაძლებელი.", "ამობეჭვდა", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            ProductionManager.UpdateProductDistributionStatus(ProductDistributionID, (int)DatabaseStatus.Shipped, BaseGlobalVariable.UserID);
        }


        public void AddHeader()
        {
            try
            {
                DS_ProductDistribution.SP_GetProductDistributionHeaderRow row;
                if (ds_Production.SP_GetProductDistributionHeader.Count == 0)
                {
                    row = ds_Production.SP_GetProductDistributionHeader.NewSP_GetProductDistributionHeaderRow();
                    row.ProductDistributionID = -1;
                }
                else
                {
                    row = ds_Production.SP_GetProductDistributionHeader[0];
                }

                row.FromBranchID = FromBranchID;
                row.FromBranchName = lookFromBranch.Text;
                row.ToBranchID = ToBranchID;
                row.ToBranchName = lookToBranch.Text;
                row.StartDate = StartDate;
                row.SubTotal = SubTotal;
                row.TaxAmt = TaxAmt;
                row.Freight = Freight;
                row.TotalDue = TotalDue;
                row.CurrencyCode = CurrencyCode;
                //row.CurrencyRateID = 0;
                //row.Comment = Comment;
                row.RevisionNumber = RevisionNumber;
                row.Status = (byte)Status;
                row.ModifiedUserID = ModifiedUserID;
                row.Modifier = Modifier;
                row.ModifiedDate = ModifiedDate;
                row.ApproverUserID = ApproverUserID;
                row.Approver = Approver;


                if (ds_Production.SP_GetProductDistributionHeader.Rows.Count == 0)
                    ds_Production.SP_GetProductDistributionHeader.AddSP_GetProductDistributionHeaderRow(row);
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
                if (ds_Production.SP_GetProductDistributionHeader.Rows.Count == 0)
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
                        //_frmpl.CrossRate = CrossRate;
                        _frmpl.OnChooseRecord += new CancelEventHandler(OnChooseProduct);
                        _frmpl.OptionsListForm.CloseAfterChoose = false;
                        _frmpl.BranchID = FromBranchID;
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
            //შევამოწმო უკვე არჩეული ხომ არ აქვს ესეთი პროდუქტი
            foreach (var tmprow in ds_Production.SP_GetProductDistributionDetail)
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
            var distributeQty = 0m;
            var unitPrice = row.StandardCost * crossRate;
            using (var frm = new frmQuantity(row.UnitsInStock, row.Quantity, unitPrice))
            {
                if (frm.ShowDialog(this) != DialogResult.OK || frm.OutQty <= 0m)
                    return false;
                distributeQty = frm.OutQty;
            }

            var newRow = ds_Production.SP_GetProductDistributionDetail.NewSP_GetProductDistributionDetailRow();
            newRow.ProductDistributionDetailID = Guid.NewGuid();
            newRow.ProductDistributionID = ProductDistributionID;
            newRow.ProductLocationID = row.ProductLocationID;
            newRow.ProductID = row.ProductID;
            newRow.BranchID = row.BranchID;
            newRow.ProductNumber = row.ProductNumber;
            newRow.MedicamentName = row.MedicamentName;
            newRow.Quantity = row.Quantity;
            newRow[ds_Production.SP_GetProductDistributionDetail.ValidDateColumn] = row[ds_Production.SP_GetProductDistributionDetail.ValidDateColumn.ColumnName];
            newRow[ds_Production.SP_GetProductDistributionDetail.CountryNameColumn] = row[ds_Production.SP_GetProductDistributionDetail.CountryNameColumn.ColumnName];
            newRow[ds_Production.SP_GetProductDistributionDetail.BrandNameColumn] = row[ds_Production.SP_GetProductDistributionDetail.BrandNameColumn.ColumnName];
            newRow[ds_Production.SP_GetProductDistributionDetail.SerieColumn] = row[ds_Production.SP_GetProductDistributionDetail.SerieColumn.ColumnName];

            newRow.UnitPrice = unitPrice;
            newRow._UnitPrice = unitPrice * CurrencyRate;
            newRow.UnitsInStock = row.UnitsInStock;
            newRow.DistributeQty = distributeQty;
            InitDistributeUnitQty(newRow);
            InitResidualQty(newRow);
            InitLineTotal(newRow);

            newRow.OrdinalNumber = (short)(view.RowCount + 1);

            ds_Production.SP_GetProductDistributionDetail.AddSP_GetProductDistributionDetailRow(newRow);

            view.Focus();
            view.FocusedColumn = colDistributeQty;

            IsChanged = true;
            return true;
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

                var table = ProductLocationManager.GetVWByIDAndBranch(ConvertHelper.ToInt32(frm.OptionsGrid.SelectedRecordID), FromBranchID, true);
                if (table.Count == 0)
                    throw new NullReferenceException("ჩანაწერი ვერ ვიპოვე მონაცემთა ბაზაში.");

                var crossRate = table[0].ProductCurrencyRate / CurrencyRate;
                table[0].StandardCost = ProductionManager.GetPurchaseUnitPrice(table[0].ProductID, CurrencyCode) / crossRate;
                e.Cancel = !AddDetail(table[0]);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("შეცდომა მონაცემის არჩევისას.\n" + ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteDetail()
        {
            if (ReadOnly) return;

            view.DeleteSelectedRows();
        }
        public void IndexOrdinalNumbers()
        {
            if (ReadOnly) return;

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                for (var rowHandle = 0; rowHandle < view.RowCount; rowHandle++)
                {
                    view.SetRowCellValue(rowHandle, colOrdinalNumber, rowHandle + 1);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, "რიგითი ნომრების ინდექსირება ვერ მოხერხდა.\n" + ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
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
            else if (e.KeyCode == Keys.F8 && !e.Shift && !e.Control && !e.Alt)
            {
                if (xtraTabControl.SelectedTabPage != tabMain) return;

                e.SuppressKeyPress = true;
                e.Handled = true;

                DeleteDetail();
            }
            else if (e.KeyCode == Keys.F9 && !e.Control && !e.Alt && !e.Shift)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;

                XtraGridHelper.BestFitColumns(view);
            }
        }
        public void InitPrices()
        {
            if (ReadOnly || OptionsBaseForm.IsLoading) return;

            IsChanged = true;

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                OptionsBaseForm.IsLoading = true;

                var rate = CurrencyRate;
                foreach (var row in ds_Production.SP_GetProductDistributionDetail)
                {
                    if (DataSetHelper.IsDataRowDeleted(row)) continue;

                    row.UnitPrice = row._UnitPrice / rate;
                    InitLineTotal(row);

                    SubTotal = SubTotal;
                    TotalDue = TotalDue;
                    view.UpdateSummary();
                }
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
        public void InitLineTotal(DS_ProductDistribution.SP_GetProductDistributionDetailRow row)
        {
            row.LineTotal = (row.UnitPrice * row.DistributeQty);
        }
        public void InitResidualQty(DS_ProductDistribution.SP_GetProductDistributionDetailRow row)
        {
            row._ResidualQty = row.Quantity - row.DistributeQty;
        }
        public void InitDistributeUnitQty(DS_ProductDistribution.SP_GetProductDistributionDetailRow row)
        {
            row._DistributeUnitQty = MathHelper.RoundUnit(row.DistributeQty, row.UnitsInStock, 4);
        }

        #endregion

        private void txtProductDistributionID_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtProductDistributionID, string.Empty);
        }

        private void dateStartDate_EditValueChanged(object sender, EventArgs e)
        {
            if (OptionsBaseForm.IsLoading) return;

            IsChanged = true;
            dxErrorProvider.SetError(dateStartDate, string.Empty);
        }

        private void dateOrderDate_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (ReadOnly) return;

            if (e.Button.Kind == ButtonPredefines.OK)
            {
                try
                {
                    Application.DoEvents();
                    Cursor = Cursors.WaitCursor;

                    StartDate = BaseGlobalVariable.ServerDateTime;
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

        private void lookFromBranch_EditValueChanged(object sender, EventArgs e)
        {
            if (OptionsBaseForm.IsLoading) return;

            IsChanged = true;
            dxErrorProvider.SetError(lookFromBranch, string.Empty);
        }

        private void lookToBranch_EditValueChanged(object sender, EventArgs e)
        {
            if (OptionsBaseForm.IsLoading) return;

            IsChanged = true;
            dxErrorProvider.SetError(lookToBranch, string.Empty);
        }

        private void memoComment_EditValueChanged(object sender, EventArgs e)
        {
            if (OptionsBaseForm.IsLoading) return;

            IsChanged = true;
            dxErrorProvider.SetError(memoComment, string.Empty);
        }

        private void grid_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                e.Handled = true;
                AddDetail();
            }
            else if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                e.Handled = true;
                DeleteDetail();
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

        /*private void gridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.WindowCaption = "შეცდომა";
            //e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.Ignore;
        }

        private void gridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DS_Production.SP_GetProductDistributionDetailRow row = ((DS_Production.SP_GetProductDistributionDetailRow)(((DataRowView)e.Row).Row));

            if (!IsValidRowQuantity(row))
            {
                view.SetColumnError(null, "სტრიქონში არის შეცდომა!");
                e.Valid = false;
                e.ErrorText = "სტრიქონში არის შეცდომა!\n";
            }
        }*/

        private void view_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (ReadOnly || OptionsBaseForm.IsLoading) return;

            IsChanged = true;

            var row = ((DS_ProductDistribution.SP_GetProductDistributionDetailRow)view.GetDataRow(e.RowHandle));
            row.SetColumnError(e.Column.FieldName, string.Empty);
            try
            {
                OptionsBaseForm.IsLoading = true;
                switch (e.Column.Name)
                {
                    case "col_DistributeUnitQty":
                    case "colDistributeQty":
                        var value = (e.Column.Name == "colDistributeQty" ? row.DistributeQty : MathHelper.CeilingQuantity(row._DistributeUnitQty, row.UnitsInStock, 4, row.Quantity));
                        if (value > row.Quantity)
                        {
                            value = row.Quantity;
                            row.DistributeQty = row.Quantity;
                        }

                        if (e.Column.Name == "col_DistributeUnitQty")
                            row.DistributeQty = value;
                        row._DistributeUnitQty = MathHelper.RoundUnit(row.DistributeQty, row.UnitsInStock, 4);

                        InitResidualQty(row);
                        InitLineTotal(row);
                        SubTotal = SubTotal;
                        TaxAmt = TaxAmt;
                        TotalDue = TotalDue;
                        break;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, "შეცდომა ცხრილში მნიშვნელობების მინიჭებისას. გთხოვთ გაიმეოროთ მიმდინარე ოპერაცია.\n" + ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                OptionsBaseForm.IsLoading = false;
            }

            view.UpdateSummary();
        }

        private void frmProductDistributionEdit_KeyDown(object sender, KeyEventArgs e)
        {
            ProcessKey(sender, e);
        }

        private void frmProductDistributionEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_frmpl != null)
            {
                if (_frmpl.IsDisposed)
                    _frmpl = null;
                else
                    _frmpl.Close();
            }
        }

        private void frmProductDistributionEdit_Shown(object sender, EventArgs e)
        {
            if (ConfigurationManagerEx.AutoNewRow && Action == DatabaseAction.Add)
                AddDetail();
        }

        private void lookCurrency_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(lookCurrency, string.Empty);
            InitPrices();
        }

    }
}