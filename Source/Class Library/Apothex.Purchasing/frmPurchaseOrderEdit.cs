using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Apothex.Dictionary;
using Apothex.Import;
using Apothex.Reporting;
using Apothex.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

using Apothex.Common;
using Apothex.DataType;
using Apothex.DataManagment.Purchasing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using Zek.Core;
using Apothex.DataManagment.Dictionary;
using Zek.Data;
using Zek.Windows.Forms;
using Apothex.Configuration;
using Zek.Windows.Forms.DevEx;
using Apothex.DataManagment.Sales;

namespace Apothex.Purchasing
{
    public partial class frmPurchaseOrderEdit : frmEditBrowse
    {
        public frmPurchaseOrderEdit()
        {
            InitializeComponent();
            XtraGridHelper.InitGrid(grid, true);
            XtraGridHelper.BestFitColumns(view);
        }

        #region Fields
        public int PurchaseOrderID
        {
            get { return ConvertHelper.ToInt32(PrimaryKey); }
            set
            {
                PrimaryKey = value;
                txtPurchaseID.Text = txtID.Text = value.ToString();
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
        public int VendorID
        {
            get { return ConvertHelper.ToInt32(bbVendor.RecordValue); }
            set { bbVendor.RecordValue = value; }
        }
        public string OverheadNumber
        {
            get { return txtOverheadNumber.Text.Trim(); }
            set { txtOverheadNumber.Text = value.Trim(); }
        }
        public string VendorName
        {
            get { return bbVendor.Text; }
        }
        public decimal SubTotal
        {
            get
            {
                var value = 0m;
                foreach (var row in ds_Purchasing.SP_GetPurchaseOrderDetail)
                {
                    if (row.RowState == DataRowState.Deleted || row.RowState == DataRowState.Detached) continue;
                    value += row.LineTotal;
                }
                return Math.Round(value, 2);
            }
            set { /*spinSubTotal.EditValue = value;*/ }
        }
        public decimal TaxAmt
        {
            get
            {
                var value = 0m;
                foreach (var row in ds_Purchasing.SP_GetPurchaseOrderDetail)
                {
                    if (row.RowState == DataRowState.Deleted || row.RowState == DataRowState.Detached) continue;
                    value += row.LineTotal * row.TaxRate;
                }
                return value;
            }
            set { /*spinTaxAmt.EditValue = value;*/ }
        }
        public decimal Freight
        {
            get { return ConvertHelper.ToDecimal(spinFreight.EditValue); }
            set { spinFreight.EditValue = value; }
        }
        public decimal TotalDue
        {
            get { return Math.Round(SubTotal + TaxAmt + Freight, 2); }
            set { spinTotalDue.EditValue = value; }
        }

        /// <summary>
        /// შესყიდვის პ/ე კურსი.
        /// </summary>
        public decimal CurrencyRate1
        {
            get { return spinCurrencyRate1.Value; }
            set { spinCurrencyRate1.Value = value; }
        }
        /// <summary>
        /// გაყიდვის პ/ე კურსი.
        /// </summary>
        public decimal CurrencyRate2
        {
            get { return spinCurrencyRate2.Value; }
            set { spinCurrencyRate2.Value = value; }
        }

        public decimal CrossRate1
        {
            get { return CurrencyRate1 / SelectedCurrencyRate1; }
        }
        public decimal CrossRate2
        {
            get
            {
                return CurrencyRate2 / SelectedCurrencyRate2;
            }
        }

        public decimal SelectedCurrencyRate1
        {
            get { return ConvertHelper.ToDecimal(lookCurrency.GetColumnValue("Code")); }
        }
        public decimal SelectedCurrencyRate2
        {
            get
            {
                var rate = ConvertHelper.ToDecimal(DataSetHelper.FindValueByValue(dd_SalesCurrencies, dd_SalesCurrencies.CurrencyCodeColumn, CurrencyCode, dd_SalesCurrencies.CurrencyRateColumn));
                if (rate == 0m)
                    throw new Exception("ვერ ვიპოვე SelectedCurrencyRate2.");
                return rate;
            }
        }
        public string CurrencyCode
        {
            get { return ConvertHelper.ToString(lookCurrency.EditValue); }
            set { lookCurrency.EditValue = value; }
        }
        private DS_Currency.DD_CurrencyDataTable dd_SalesCurrencies;


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

        private bool _IsAllowedAnyDate;

        private frmMedicamentBrowse _frmm;
        #endregion

        #region Bindings
        protected override void BindControls()
        {
            var table = DictionaryManager.GetDictionary(ObjectNames.CurrencyWithLastRate);

            bsCurrency.DataSource = table.Copy();
            bsDetailCurrency.DataSource = table.Copy();
            bsProductCurrency.DataSource = table.Copy();
            dd_SalesCurrencies = DictionaryManager.GetCurrencies(table);

            txtConditionalUnitCurrency.Text = GlobalVariable.MyCompanyConditionalUnitCurrencyCode;
            bsPaymentMethod.DataSource = DictionaryManager.GetDictionaryInt(ObjectNames.PaymentMethod);
            bsCountry.DataSource = DictionaryManager.GetDictionary(ObjectNames.Country);
            bsBrand.DataSource = DictionaryManager.GetDictionaryInt(ObjectNames.Brand);
        }
        protected override void BindData()
        {
            if (Action == DatabaseAction.Edit)
            {
                ds_Purchasing.SP_GetPurchaseOrderHeader.Clear();
                ds_Purchasing.SP_GetPurchaseOrderHeader.Merge(PurchasingManager.GetPurchaseOrderHeader(PurchaseOrderID));
                if (ds_Purchasing.SP_GetPurchaseOrderHeader.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.", "RecordID");


                PurchaseOrderID = ds_Purchasing.SP_GetPurchaseOrderHeader[0].PurchaseOrderID;
                BranchID = ds_Purchasing.SP_GetPurchaseOrderHeader[0].BranchID;
                OrderDate = ds_Purchasing.SP_GetPurchaseOrderHeader[0].OrderDate;
                OverheadNumber = ds_Purchasing.SP_GetPurchaseOrderHeader[0].OverheadNumber;
                VendorID = ds_Purchasing.SP_GetPurchaseOrderHeader[0].VendorID;
                SubTotal = ds_Purchasing.SP_GetPurchaseOrderHeader[0].SubTotal;
                //TaxAmt = ds_Purchasing.SP_GetPurchaseOrderHeader[0].TaxAmt;
                Freight = ds_Purchasing.SP_GetPurchaseOrderHeader[0].Freight;
                TotalDue = ds_Purchasing.SP_GetPurchaseOrderHeader[0].TotalDue;
                CurrencyCode = ds_Purchasing.SP_GetPurchaseOrderHeader[0].CurrencyCode;
                CurrencyRate1 = ds_Purchasing.SP_GetPurchaseOrderHeader[0].CurrencyRate1;
                CurrencyRate2 = ds_Purchasing.SP_GetPurchaseOrderHeader[0].CurrencyRate2;
                PaymentMethodID = ds_Purchasing.SP_GetPurchaseOrderHeader[0].PaymentMethodID;
                RevisionNumber = ds_Purchasing.SP_GetPurchaseOrderHeader[0].RevisionNumber;

                Status = (DatabaseStatus)ds_Purchasing.SP_GetPurchaseOrderHeader[0].Status;
                ModifiedUserID = ds_Purchasing.SP_GetPurchaseOrderHeader[0].ModifiedUserID;
                ModifiedDate = ds_Purchasing.SP_GetPurchaseOrderHeader[0].ModifiedDate;
                ApproverUserID = ds_Purchasing.SP_GetPurchaseOrderHeader[0].ApproverUserID;

                ChangeCurrency1Table();
                ChangeCurrency2Table();

                ds_Purchasing.SP_GetPurchaseOrderDetail.Clear();
                ds_Purchasing.SP_GetPurchaseOrderDetail.Merge(PurchasingManager.GetPurchaseOrderDetail(PurchaseOrderID));
                var crossRate2 = CrossRate2;
                foreach (var row in ds_Purchasing.SP_GetPurchaseOrderDetail)
                {
                    row._VendorUnitPrice = row.VendorUnitPrice / CrossRate1;
                    row._ListPrice = row.ListPrice * crossRate2;
                    row._DealerPrice = row.DealerPrice * crossRate2;
                    InitCalcVendorUnitPricePct(row);
                    InitLine(row);
                }
            }
            else
            {
                CurrencyCode = GlobalVariable.MyCompanyDefaultTradingCurrencyCode;
                CurrencyRate1 = CurrencyRate2 = DictionaryManager.GetCurrencyRate(GlobalVariable.MyCompanyConditionalUnitCurrencyCode, BaseGlobalVariable.ServerDateTime);

                ModifiedUserID = BaseGlobalVariable.UserID;
                ModifiedDate = BaseGlobalVariable.ServerDateTime;

                BranchID = GlobalVariable.BranchID;
                OrderDate = SalesManager.GetOrderDate(ObjectNames.PurchaseOrderHeader, 0, GlobalVariable.BranchID, BaseGlobalVariable.ServerDateTime, true);

                if (_SalesOrderID != 0)
                {
                    var sales = SalesManager.GetSalesOrderHeader(_SalesOrderID, _SalesOrderIsOnline);
                    if (sales.Count > 0)
                    {
                        OrderDate = sales[0].OrderDate;

                    }
                }


                AddHeader();
            }
        }
        #endregion

        #region Valdations
        public bool IsValidOrderDate()
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

                if (OrderDate.Date != BaseGlobalVariable.ServerDateTime.Date)
                {
                    SetError(dateOrderDate, "შესყიდვის თარიღი უნდა იყოს ტოლი სერვერის თარიღის.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, string.Format("ფაქტურის თარიღის შემოწმება ვერ მოხერხდა: {0}", ex.Message), "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        public bool IsValidCurrency()
        {
            if (CurrencyCode.Length == 0)
            {
                SetError(lookCurrency, "შ / ვალუტა არ შეიძლება იყოს ცარიელი.");
                return false;
            }

            return true;
        }
        public bool IsValidCUCurrencyCode()
        {
            if (DataSetHelper.FindRowsByValue((DataTable)bsCurrency.DataSource, "ID", GlobalVariable.MyCompanyConditionalUnitCurrencyCode).Length == 0)
            {
                SetError(lookCurrency, string.Format("შ / ვალუტაში ვერ ვიპოვე პ/ე ვალუტაში მითითებული მნიშვნელობა ({0}).", GlobalVariable.MyCompanyConditionalUnitCurrencyCode));
                return false;
            }

            return true;
        }
        public bool IsValidBranch()
        {
            if (BranchID == 0)
            {
                SetError(bbBranch, "!");
                return false;
            }

            return true;
        }
        public bool IsValidGrid()
        {
            view.CloseEditor();
            bsDetail.EndEdit();

            var ok = true;
            foreach (var row2 in ds_Purchasing.SP_GetPurchaseOrderDetail)
            {
                if (row2.RowState == DataRowState.Deleted || row2.RowState == DataRowState.Detached || row2.RowState == DataRowState.Unchanged) continue;

                if (!IsValidRow(row2)) ok = false;
            }

            return ok;
        }
        public bool IsValidRow(DS_Purchasing.SP_GetPurchaseOrderDetailRow row)
        {
            row.ClearErrors();
            var ok = true;

            if (row.MedicamentID <= 0)
            {
                ok = false;
                row.SetColumnError(ds_Purchasing.SP_GetPurchaseOrderDetail.MedicamentIDColumn, "გთხოვთ აირჩიოთ მნიშვნელობა.");
            }

            if (row.StandardCost < 0m)
            {
                ok = false;
                row.SetColumnError(ds_Purchasing.SP_GetPurchaseOrderDetail.UnitPriceColumn, "მნიშვნელობა არ შეიძლება იყოს უარყოფითი.");
            }

            if (row.ReceivedQty <= 0m)
            {
                ok = false;
                row.SetColumnError(ds_Purchasing.SP_GetPurchaseOrderDetail.ReceivedQtyColumn, "მნიშვნელობა უნდა აღემატებოდეს 0-ს.");
            }

            if (row.IsProductCurrencyCodeNull())
            {
                ok = false;
                row.SetColumnError(ds_Purchasing.SP_GetPurchaseOrderDetail.ProductCurrencyCodeColumn, "მნიშვნელობა არ შეიძლება იყოს ცარიელი.");
            }

            return ok;
        }
        protected override bool IsValidForm()
        {
            var ok = true;
            if (!IsValidOrderDate()) ok = false;
            if (!IsValidCurrency()) ok = false;
            if (!IsValidBranch()) ok = false;

            if (ok && !IsValidGrid()) ok = false;

            return ok;
        }
        #endregion

        #region Methods
        private int _SalesOrderID;
        private bool _SalesOrderIsOnline;
        public override void InvokeAction(string actionName, params object[] args)
        {
            switch (actionName)
            {
                case "SalesOrderID":
                    if (args.Length != 2) return;
                    _SalesOrderID = (int)args[0];
                    _SalesOrderIsOnline = (bool)args[1];
                    break;

                default:
                    base.InvokeAction(actionName, args);
                    break;
            }
        }

        protected override void Init()
        {
            base.Init();

            _IsAllowedAnyDate = IsPermitted(ObjectNames.PurchaseOrderHeaderAnyDate, Action);
            ReadOnly = (ReadOnly || (ModifiedUserID != BaseGlobalVariable.UserID && !IsPermitted(ObjectNames.PurchaseOrderHeaderAnyModifier, DatabaseAction.Edit)));


            txtPurchaseID.Properties.ReadOnly = true;
            dateOrderDate.Properties.ReadOnly = ReadOnly || !_IsAllowedAnyDate;

            spinFreight.Properties.ReadOnly = ReadOnly;
            lookCurrency.Properties.ReadOnly = ReadOnly;
            spinCurrencyRate1.Properties.ReadOnly = ReadOnly;
            spinCurrencyRate2.Properties.ReadOnly = ReadOnly;
            lookPaymentMethod.Properties.ReadOnly = ReadOnly;
            spinAddPercent.Properties.ReadOnly = ReadOnly;
            lookDetailCurrency.Properties.ReadOnly = ReadOnly;

            txtOverheadNumber.Properties.ReadOnly = ReadOnly;
            bbVendor.Properties.ReadOnly = ReadOnly;
            memoComment.Properties.ReadOnly = ReadOnly;


            view.OptionsBehavior.Editable = !ReadOnly;
            XtraGridHelper.SetReadOnly(grid, ReadOnly, true);
            bbBranch.Properties.ReadOnly = ReadOnly;

            var isAllowedImport = (!ReadOnly && IsPermitted(DatabaseAction.Import));
            
            iImportAversi.Enabled =
            iImportPSP.Enabled =
            iImportGPC.Enabled =
            iImportKalinaGeorgia.Enabled =
            iImportExcel.Enabled =
            tabImport.PageVisible = isAllowedImport;

            if (ReadOnly)
            {
                riProductCurrency = null;
                bsProductCurrency = null;
            }
        }
        protected override bool SaveData()
        {
            view.CloseEditor();
            bsDetail.EndEdit();

            AddHeader();

            DS_Purchasing.SP_GetPurchaseOrderDetailDataTable table = DataSetHelper.PackAlternationTypedDataTable<DS_Purchasing.SP_GetPurchaseOrderDetailDataTable>(ds_Purchasing.SP_GetPurchaseOrderDetail);
            DataSetHelper.RemoveColumns(table, true, 
                                                 table.PurchaseOrderDetailIDColumn,
                                                 table.ReceivedQtyColumn,
                                                 table.UnitPriceColumn,
                                                 table.VendorUnitPriceColumn,
                                                 table.MedicamentIDColumn,
                                                 table.StandardCostColumn,
                                                 table.ListPriceColumn,
                                                 table.DealerPriceColumn,
                                                 table.ProductCurrencyCodeColumn,
                                                 table.DiscountPctColumn,
                                                 table.TaxRateColumn,
                                                 table.ValidDateColumn,
                                                 table.CountryCodeColumn,
                                                 table.BrandIDColumn,
                                                 table.SerieColumn,
                                                 table.OrdinalNumberColumn,
                                                 table.ChangePriceColumn,
                                                 table.ActionColumn
                                                 );

            var ds = new DataSet("root");
            ds.Tables.Add(table);

            var id = PurchasingManager.AddOrEditPurchaseOrder(PurchaseOrderID, BranchID, OrderDate, OverheadNumber, VendorID, SubTotal, TaxAmt, Freight, TotalDue, CurrencyCode, CurrencyRate1, CurrencyRate2, PaymentMethodID, RevisionNumber, Comment, Status, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, ApproverUserID, ds_Purchasing.SP_GetPurchaseOrderHeader[0].rowguid, Action, DataSetHelper.InnerBytesData(ds));

            if (id > 0)
            {
                if (Action == DatabaseAction.Add)
                {
                    ds_Purchasing.SP_GetPurchaseOrderHeader[0].PurchaseOrderID = id;
                    foreach (var row in ds_Purchasing.SP_GetPurchaseOrderDetail)
                    {
                        if (DataSetHelper.IsDataRowDeleted(row)) continue;
                        row.PurchaseOrderID = id;
                    }
                    PurchaseOrderID = id;
                }
            }

            ds_Purchasing.AcceptChanges();
            return (id > 0);
        }

        private void AddHeader()
        {
            try
            {
                DS_Purchasing.SP_GetPurchaseOrderHeaderRow row;
                if (ds_Purchasing.SP_GetPurchaseOrderHeader.Count == 0)
                {
                    row = ds_Purchasing.SP_GetPurchaseOrderHeader.NewSP_GetPurchaseOrderHeaderRow();
                    row.PurchaseOrderID = -1;
                    row.rowguid = Guid.NewGuid();
                }
                else
                    row = ds_Purchasing.SP_GetPurchaseOrderHeader[0];

                row.BranchID = BranchID;
                row.BranchName = bbBranch.Text;
                row.OrderDate = OrderDate;
                row.OverheadNumber = OverheadNumber;
                row.VendorID = VendorID;
                row.VendorName = VendorName;

                row.SubTotal = SubTotal;
                row.TaxAmt = TaxAmt;
                row.Freight = Freight;
                row.TotalDue = TotalDue;
                row.CurrencyCode = CurrencyCode;
                row.CurrencyRate1 = CurrencyRate1;
                row.CurrencyRate2 = CurrencyRate2;
                row.PaymentMethodID = PaymentMethodID;
                row.PaymentMethodName = PaymentMethodName;
                row.RevisionNumber = RevisionNumber;
                row.Status = (byte)Status;
                row.ModifiedUserID = ModifiedUserID;
                row.Modifier = Modifier;
                row.ModifiedDate = ModifiedDate;
                row.ApproverUserID = ApproverUserID;
                row.Approver = Approver;

                if (ds_Purchasing.SP_GetPurchaseOrderHeader.Rows.Count == 0)
                    ds_Purchasing.SP_GetPurchaseOrderHeader.AddSP_GetPurchaseOrderHeaderRow(row);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, ex.Message, "შეცდომა", MessageBoxButtons.OK);
            }
        }
        private void AddDetail()
        {
            if (ReadOnly) return;
            try
            {
                if (ds_Purchasing.SP_GetPurchaseOrderHeader.Rows.Count == 0)
                    throw new Exception("გთხოვთ შეავსოთ ძირითადი პარამეტრები.");

                bool isContainsForm = FormHelper.ContainsForm(FormHelper.GetFormID(typeof(frmMedicamentBrowse), Handle));
                IForm frm = FormHelper.CreateInstance(typeof(frmMedicamentBrowse), MdiParent, Handle);
                if (!isContainsForm)
                {
                    if (frm is frmMedicamentBrowse)
                    {
                        _frmm = ((frmMedicamentBrowse)frm);
                        _frmm.OptionsListForm.ServerMode = true;
                        _frmm.OptionsListForm.BrowseFormStyle = BrowseFormStyle.Browse;
                        _frmm.OnChooseRecord += new CancelEventHandler(OnChooseProduct);
                        _frmm.OptionsListForm.CloseAfterChoose = false;
                        _frmm.CurrencyRate = DictionaryManager.GetCurrencyRate(CurrencyCode, BaseGlobalVariable.ServerDateTime);
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
        private void OnChooseProduct(object sender, CancelEventArgs e)
        {
            if (ReadOnly || IsLoading || OptionsBaseForm.IsClosing) return;

            try
            {
                var frm = (sender as frmMedicamentBrowse);

                if (frm == null) return;

                if (frm.OptionsGrid.SelectedRecordID == null)
                    throw new NullReferenceException("არჩეული ჩანაწერის იდენთიფიკატორი ცარიელია. (frm.SelectedRecordID = null)");

                var table = DictionaryManager.GetMedicament(ConvertHelper.ToInt32(frm.OptionsGrid.SelectedRecordID));
                if (table.Count == 0) throw new Exception("მონაცემი ვერ მოიძებმა.");
                var row = table[0];
                var newRow = ds_Purchasing.SP_GetPurchaseOrderDetail.NewSP_GetPurchaseOrderDetailRow();



                var frmCurrencyRate = frm.CurrencyRate;
                if (frmCurrencyRate <= 0m)
                    throw new ArgumentNullException("frmMedicamentBrowse.CurrencyRate");

                var t_ProductCurrency = (DS_Dictionary.SP_GetDictionaryDataTable)bsProductCurrency.DataSource;
                var rate = ConvertHelper.ToDecimal(DataSetHelper.FindValueByValue(t_ProductCurrency, t_ProductCurrency.IDColumn, row.ProductCurrencyCode, t_ProductCurrency.CodeColumn));
                if (rate == 0m)
                    rate = DictionaryManager.GetCurrencyRate(row.ProductCurrencyCode, BaseGlobalVariable.ServerDateTime);
                if (rate <= 0m)
                    throw new ArgumentNullException("rate", string.Format("ვერ მოხერხდა ვალუტის ამოღება (ვალუტა={0}, თარიღი={1}).", row.ProductCurrencyCode, BaseGlobalVariable.ServerDateTime.ToString("G")));



                newRow.PurchaseOrderDetailID = Guid.NewGuid();
                newRow.PurchaseOrderID = PurchaseOrderID;
                newRow.ReceivedQty = 0m;
                newRow.OrdinalNumber = (short)(view.RowCount + 1);
                newRow.UnitPrice = row.StandardCost * rate / frmCurrencyRate;
                newRow.StandardCost = newRow.UnitPrice / CrossRate1;
                newRow.LineTotal = 0m;
                newRow.VendorUnitPrice = 0m;
                newRow._VendorUnitPrice = 0m;
                newRow._CalcVendorUnitPricePct = 0m;

                newRow.MedicamentID = row.MedicamentID;
                newRow.ProductNumber = row.ProductNumber;
                newRow.MedicamentName = row.Name;

                newRow._ListPrice = row.ListPrice * rate / frmCurrencyRate;
                newRow.ListPrice = newRow._ListPrice / CrossRate2;
                newRow._DealerPrice = row.DealerPrice * rate / frmCurrencyRate;
                newRow.DealerPrice = newRow._DealerPrice / CrossRate2;

                
                

                newRow.DiscountPct = row.DiscountPct;
                newRow.TaxRate = row.TaxRate;
                newRow.ProductCurrencyCode = row.ProductCurrencyCode;
                //newRow.ProductCurrencyRate = row.ProductCurrencyRate;
                newRow[ds_Purchasing.SP_GetPurchaseOrderDetail.ValidDateColumn] = row[ds_Purchasing.SP_GetPurchaseOrderDetail.ValidDateColumn.ColumnName];
                newRow[ds_Purchasing.SP_GetPurchaseOrderDetail.CountryCodeColumn] = row[ds_Purchasing.SP_GetPurchaseOrderDetail.CountryCodeColumn.ColumnName];
                newRow[ds_Purchasing.SP_GetPurchaseOrderDetail.BrandIDColumn] = row[ds_Purchasing.SP_GetPurchaseOrderDetail.BrandIDColumn.ColumnName];
                newRow[ds_Purchasing.SP_GetPurchaseOrderDetail.SerieColumn] = row[ds_Purchasing.SP_GetPurchaseOrderDetail.SerieColumn.ColumnName];
                newRow.UnitsInStock = row.UnitsInStock;
                newRow.ChangePrice = false;

                ds_Purchasing.SP_GetPurchaseOrderDetail.Rows.Add(newRow);

                IsChanged = true;

                view.Focus();
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                XtraMessageBox.Show("შეცდომა მონაცემის არჩევისას.\n" + ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteDetail()
        {
            if (ReadOnly) return;

            view.DeleteSelectedRows();
            IsChanged = true;
        }
        private void InitUnitPriceByCalcVendorUnitPricePct(DS_Purchasing.SP_GetPurchaseOrderDetailRow row)
        {
            row.UnitPrice = MathHelper.AddPct(row.VendorUnitPrice, -row._CalcVendorUnitPricePct * 100m);
            InitLine(row);
        }
        private void InitCalcVendorUnitPricePct(DS_Purchasing.SP_GetPurchaseOrderDetailRow row)
        {
            row._VendorUnitPrice = row.VendorUnitPrice * SelectedCurrencyRate1 / CurrencyRate1;
            row._CalcVendorUnitPricePct = row.VendorUnitPrice > 0m && row.UnitPrice > 0m ? 1m - row.UnitPrice / row.VendorUnitPrice : 0m;
        }
        private void InitLine(DS_Purchasing.SP_GetPurchaseOrderDetailRow row)
        {
            row.StandardCost = row.UnitPrice / CrossRate1;
            row.LineTotal = row.UnitPrice * row.ReceivedQty;
            row._TaxAmt = row.LineTotal * row.TaxRate;
            row._LineTotal = row.LineTotal + row._TaxAmt;
        }
        private void IndexOrdinalNumbers()
        {
            if (ReadOnly) return;

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                XtraGridHelper.IndexOrdinalNumbers(view, colOrdinalNumber);
                //for (int rowHandle = 0; rowHandle < view.RowCount; rowHandle++)
                //{
                //    view.SetRowCellValue(rowHandle, colOrdinalNumber, rowHandle + 1);
                //}
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
        protected override void Print()
        {
            if (IsChanged || Action == DatabaseAction.Add)
            {
                XtraMessageBox.Show(this, "გთხოვთ შეინახოთ ჩანაწერი და შემდეგ გაიმეოროთ ოპერაცია.", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ReportFactory.Show(MdiParent, OptionsBaseForm.Text, ObjectNames.PurchaseOrderDetail, ds_Purchasing);
        }
        private void ProcessKey(object sender, KeyEventArgs e)
        {
            if (IsLoading) return;

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
        protected override void OnIsChangedChanged()
        {
            base.OnIsChangedChanged();

            //if (IsChanged)
            //    _DoBindPrint = true;
        }

        
        private void OnCurrencyChanged()
        {
            if (IsLoading) return;

            
            try
            {
                IsLoading = true;
                IsChanged = true;

                var crossRate1 = CrossRate1;
                var crossRate2 = CrossRate2;
                foreach (var row in ds_Purchasing.SP_GetPurchaseOrderDetail)
                {
                    if (DataSetHelper.IsDataRowDeleted(row)) continue;

                    row.UnitPrice = row.StandardCost * crossRate1;
                    row.LineTotal = row.UnitPrice * row.ReceivedQty;
                    row._TaxAmt = row.LineTotal * row.TaxRate;
                    row._LineTotal = row.LineTotal + row._TaxAmt;
                    row.VendorUnitPrice = row._VendorUnitPrice * crossRate1;

                    row._ListPrice = row.ListPrice * crossRate2;
                    row._DealerPrice = row.DealerPrice * crossRate2;
                }

                TotalDue = TotalDue;
                view.UpdateSummary();
            }
            catch (Exception ex)
            {
                ExceptionHelper.Show(this, ex, "შეცდომა ფასების ცვლილებისას", MessageBoxIcon.Error);
            }
            finally
            {
                IsLoading = false;
            }
        }
        private void ChangeCurrency1Table()
        {
            foreach (DataRowView rowView in DataSetHelper.FindRowsByValue((DataTable)bsCurrency.DataSource, "ID", GlobalVariable.MyCompanyConditionalUnitCurrencyCode))
            {
                rowView["Code"] = CurrencyRate1.ToString("n4");
            }
        }
        private void OnCurrencyRate1Changed()
        {
            if (IsLoading || !IsValidCUCurrencyCode()) return;
            
            try
            {
                IsChanged = true;
                IsLoading = true;

                ChangeCurrency1Table();
                var rate = CrossRate1;
                foreach (var row in ds_Purchasing.SP_GetPurchaseOrderDetail)
                {
                    if (DataSetHelper.IsDataRowDeleted(row)) continue;

                    row.StandardCost = row.UnitPrice / rate;
                }

                TotalDue = TotalDue;
                view.UpdateSummary();
            }
            catch (Exception ex)
            {
                ExceptionHelper.Show(this, ex, "შეცდომა ფასების ცვლილებისას", MessageBoxIcon.Error);
            }
            finally
            {
                IsLoading = false;
            }
        }
        private void ChangeCurrency2Table()
        {
            foreach (DataRowView rowView in DataSetHelper.FindRowsByValue(dd_SalesCurrencies, dd_SalesCurrencies.CurrencyCodeColumn, GlobalVariable.MyCompanyConditionalUnitCurrencyCode))
            {
                rowView[dd_SalesCurrencies.CurrencyRateColumn.ColumnName] = CurrencyRate2;
            }
        }
        private void OnCurrencyRate2Changed()
        {
            if (IsLoading) return;

            IsChanged = true;

            try
            {
                IsLoading = true;
                ChangeCurrency2Table();
                var crossRate2 = CrossRate2;
                foreach (var row in ds_Purchasing.SP_GetPurchaseOrderDetail)
                {
                    if (DataSetHelper.IsDataRowDeleted(row)) continue;

                    row.ListPrice = row._ListPrice / crossRate2;
                    row.DealerPrice = row._DealerPrice / crossRate2;
                }

                TotalDue = TotalDue;
                view.UpdateSummary();
            }
            catch (Exception ex)
            {
                ExceptionHelper.Show(this, ex, "შეცდომა ფასების ცვლილებისას", MessageBoxIcon.Error);
            }
            finally
            {
                IsLoading = false;
            }
        }
        #endregion

        #region Import
        public void Import(ImportFileTypes importFileType)
        {
            if (!IsPermitted(DatabaseAction.Import))
            {
                XtraMessageBox.Show(this, "თქვენ არ გაქვთ უფლება ამ ოპერაციის განხორციელების.", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ReadOnly) return;

            if (openFileDialog.ShowDialog(this) != DialogResult.OK) return;

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                var import = new ImportPurchaseOrder(openFileDialog.FileName, importFileType, spinPSPUnitPricePct.Value * 100m, spinPSPTaxRate.Value * 100m, spinDiscount.Value * 100m);
                var table = import.Import();
                if (table.Count == 0) return;


                bsCountry.DataSource = DictionaryManager.GetDictionary(ObjectNames.Country, -1);
                bsBrand.DataSource = DictionaryManager.GetDictionaryInt(ObjectNames.Brand, -1);

                if (ds_Purchasing.SP_GetPurchaseOrderHeader.Rows.Count == 0)
                    throw new Exception("გთხოვთ შეავსოთ ძირითადი პარამეტრები.");

                var crossRate1 = CrossRate1;
                var crossRate2 = CrossRate2;
                foreach (var row in table)
                {
                    if (ConvertHelper.ToString(row[table.MedicamentNameColumn]).Trim().Length == 0 || row.IsMedicamentIDNull()) continue;

                    var newRow = ds_Purchasing.SP_GetPurchaseOrderDetail.NewSP_GetPurchaseOrderDetailRow();

                    newRow.PurchaseOrderDetailID = Guid.NewGuid();
                    newRow.PurchaseOrderID = PurchaseOrderID;
                    newRow.ReceivedQty = (!row.IsReceivedQtyNull() ? row.ReceivedQty : 0m);
                    newRow.OrdinalNumber = (short)(view.RowCount + 1);
                    newRow.UnitPrice = (!row.IsUnitPriceNull() ? row.UnitPrice : 0m);
                    //StandardCost ანიჭებს მნიშვნელობას InitLine-ს დროს 
                    //LineTotal ანიჭებს მნიშვნელობას InitLine-ს დროს 

                    newRow.VendorUnitPrice = 0m;
                    newRow._VendorUnitPrice = 0m;
                    newRow._CalcVendorUnitPricePct = 0m;

                    newRow.MedicamentID = row.MedicamentID;
                    newRow.ProductNumber = (!row.IsProductNumberNull() ? row.ProductNumber : string.Empty);
                    newRow.MedicamentName = row.MedicamentName;
                    newRow._ListPrice = (!row.IsListPriceNull() ? row.ListPrice : 0m);
                    newRow.ListPrice = newRow._ListPrice / crossRate2;
                    newRow._DealerPrice = (!row.IsDealerPriceNull() ? row.DealerPrice : 0m);
                    newRow.DealerPrice = newRow._DealerPrice / crossRate2;

                    newRow.ProductCurrencyCode = !row.IsProductCurrencyCodeNull() ? row.ProductCurrencyCode : GlobalVariable.MyCompanyConditionalUnitCurrencyCode;
                    newRow.DiscountPct = (!row.IsDiscountPctNull() ? row.DiscountPct : 0m);
                    newRow.TaxRate = (!row.IsTaxRateNull() ? row.TaxRate : 0m);
                    newRow.UnitsInStock = (!row.IsUnitsInStockNull() ? row.UnitsInStock : (short)1000);


                    if (!row.IsValidDateNull())
                        newRow.ValidDate = DateTimeHelper.GetStartOfMonth(row.ValidDate);
                    if (!row.IsCountryCodeNull())
                        newRow.CountryCode = row.CountryCode.Trim();
                    if (!row.IsBrandIDNull())
                        newRow.BrandID = row.BrandID;
                    if (!row.IsSerieNull())
                        newRow.Serie = row.Serie.Trim();

                    newRow.OrdinalNumber = (short)(view.RowCount + 1);
                    InitLine(newRow);

                    ds_Purchasing.SP_GetPurchaseOrderDetail.Rows.Add(newRow);

                    IsChanged = true;

                    view.Focus();
                }

                XtraMessageBox.Show(this, "იმპორტირება წარმატებით დასრულდა.", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TotalDue = TotalDue;
                view.UpdateSummary();
                xtraTabControl.SelectedTabPage = tabMain;
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
        #endregion

        private void dateOrderDate_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (ReadOnly) return;

            if (e.Button.Kind == ButtonPredefines.OK)
            {
                try
                {
                    OrderDate = SalesManager.GetOrderDate(ObjectNames.PurchaseOrderHeader, 0, GlobalVariable.BranchID, BaseGlobalVariable.ServerDateTime, true);
                }
                catch (Exception ex)
                {
                    ExceptionHelper.Show(this, ex, "შეცდომა თარიღის ამოღებისას", MessageBoxIcon.Error);
                }
            }
        }

        private void dateOrderDate_EditValueChanged(object sender, EventArgs e)
        {
            if (IsLoading) return;

            IsChanged = true;
            ClearError(dateOrderDate);
        }

        private void txtPurchaseID_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(txtPurchaseID);
        }

        private void spinFreight_EditValueChanged(object sender, EventArgs e)
        {
            if (IsLoading) return;

            IsChanged = true;
            ClearError(spinFreight);
            TotalDue = TotalDue;
        }

        private void lookCurrency_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(lookCurrency);
            OnCurrencyChanged();
        }

        private void spinTotalDue_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(spinTotalDue);
        }

        private void lookPaymentMethod_EditValueChanged(object sender, EventArgs e)
        {
            if (IsLoading) return;

            IsChanged = true;
            ClearError(lookPaymentMethod);
        }

        private void txtOverheadNumber_EditValueChanged(object sender, EventArgs e)
        {
            if (IsLoading) return;

            IsChanged = true;
            ClearError(txtOverheadNumber);
        }

        private void bbBranch_PrimaryKeyChanged(object sender, EventArgs e)
        {
            ClearError(bbBranch);
        }

        private void bbVendor_PrimaryKeyChanged(object sender, EventArgs e)
        {
            if (IsLoading) return;

            IsChanged = true;
            ClearError(bbVendor);
        }

        private void memoComment_EditValueChanged(object sender, EventArgs e)
        {
            if (IsLoading) return;

            IsChanged = true;
            ClearError(memoComment);
        }

        private void frmPurchaseOrderEdit_KeyDown(object sender, KeyEventArgs e)
        {
            ProcessKey(sender, e);
        }

        private void frmPurchaseOrderEdit_Shown(object sender, EventArgs e)
        {
            if (ReadOnly || OptionsBaseForm.IsClosing) return;
            if (ConfigurationManagerEx.AutoNewRow && Action == DatabaseAction.Add)
                AddDetail();
        }

        private void frmPurchaseOrderEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_frmm != null)
            {
                if (_frmm.IsDisposed)
                    _frmm = null;
                else
                    _frmm.Close();
            }
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

        private void view_RowCountChanged(object sender, EventArgs e)
        {
            if (IsLoading) return;
            //TaxAmt = TaxAmt;
            SubTotal = SubTotal;
            TotalDue = TotalDue;
        }

        private void view_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (ReadOnly || IsLoading) return;

            IsChanged = true;


            var row = (DS_Purchasing.SP_GetPurchaseOrderDetailRow)view.GetFocusedDataRow();//view.GetDataRow(e.RowHandle));
            DataSetHelper.ClearDataRowColumnError(row, e.Column.FieldName);
            
            
            try
            {
                IsLoading = true;
                switch (e.Column.Name)
                {
                    case "colReceivedQty":
                        InitLine(row);
                        TotalDue = TotalDue;
                        break;

                    case "colUnitPrice":
                        InitLine(row);
                        TotalDue = TotalDue;
                        row.VendorUnitPrice = 0m;
                        row._CalcVendorUnitPricePct = 0m;
                        break;

                    case "col_LineTotal":
                        row.UnitPrice = row.ReceivedQty != 0m ? MathHelper.RemoveAddedPct(row._LineTotal / row.ReceivedQty, row.TaxRate * 100m) : 0m;
                        InitLine(row);
                        TotalDue = TotalDue;
                        row.VendorUnitPrice = 0m;
                        row._CalcVendorUnitPricePct = 0m;
                        break;

                    case "col_ListPrice":
                        row.ListPrice = row._ListPrice / CrossRate2;
                        break;

                    case "col_DealerPrice":
                        row.DealerPrice = row._DealerPrice / CrossRate2;
                        break;

                    case "colVendorUnitPrice":
                        row._VendorUnitPrice = row.VendorUnitPrice / CrossRate1;
                        InitUnitPriceByCalcVendorUnitPricePct(row);
                        TotalDue = TotalDue;
                        break;

                    case "col_CalcVendorUnitPricePct":
                        InitUnitPriceByCalcVendorUnitPricePct(row);
                        TotalDue = TotalDue;
                        break;


                    case "colTaxRate":
                        InitLine(row);
                        TotalDue = TotalDue;
                        break;

                    case "colCountryCode":
                        row.CountryName = ConvertHelper.ToString(view.GetRowCellDisplayText(e.RowHandle, colCountryCode));
                        break;
                }
            }
            catch (Exception ex)
            {
                ExceptionHelper.Show(this, ex, "შეცდომა ცხრილში მნიშვნელობების მინიჭებისას. გთხოვთ გაიმეოროთ მიმდინარე ოპერაცია", MessageBoxIcon.Error);
            }
            finally
            {
                IsLoading = false;
            }

            view.UpdateSummary();
        }

        private void spinCurrencyRate1_EditValueChanged(object sender, EventArgs e)
        {
            OnCurrencyRate1Changed();
        }

        private void spinCurrencyRate2_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(lookCurrency);
            OnCurrencyRate2Changed();
        }

        private void spinAddPercent_EditValueChanged(object sender, EventArgs e)
        {
            if (IsLoading || ReadOnly) return;

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                foreach (var row in ds_Purchasing.SP_GetPurchaseOrderDetail)
                {
                    if (DataSetHelper.IsDataRowDeleted(row)) continue;

                    row._ListPrice = row.UnitPrice * (1m + row.TaxRate) * (1 + spinAddPercent.Value);
                    row.ListPrice = row._ListPrice / CrossRate2;
                }
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

        private void lookDetailCurrency_EditValueChanged(object sender, EventArgs e)
        {
            if (IsLoading || ReadOnly) return;

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                foreach (var row in ds_Purchasing.SP_GetPurchaseOrderDetail)
                {
                    if (DataSetHelper.IsDataRowDeleted(row)) continue;

                    row.ProductCurrencyCode = lookDetailCurrency.Text;
                }
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

        private void iImportPSP_ItemClick(object sender, ItemClickEventArgs e)
        {
            Import(ImportFileTypes.PSP);
        }

        private void iImportAversi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Import(ImportFileTypes.Aversi);
        }

        private void iImportGPC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Import(ImportFileTypes.GPC);
        }

        private void iImportKalinaGeorgia_ItemClick(object sender, ItemClickEventArgs e)
        {
            Import(ImportFileTypes.KalinaGeorgia);
        }

        private void iImportExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!IsPermitted(DatabaseAction.Import))
            {
                XtraMessageBox.Show(this, "თქვენ არ გაქვთ უფლება ამ ოპერაციის განხორციელების.", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Import(ImportFileTypes.Excel);
        }
    }
}