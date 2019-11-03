using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Apothex.Dictionary;
using Apothex.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Zek.Core;
using Apothex.Common;
using Apothex.DataManagment.Production;
using Zek.Data;
using Apothex.DataManagment.Dictionary;
using Apothex.DataType;
using Zek.Windows.Forms;
using Zek.Windows.Forms.DevEx;
using Apothex.Reporting;
using Apothex.DataManagment.ProductLocation;

namespace Apothex.Production
{
    public partial class frmWarehouseDescriptionEdit : frmEditBrowse
    {
        public frmWarehouseDescriptionEdit()
        {
            InitializeComponent();
            XtraGridHelper.InitGrid(grid);
            XtraGridHelper.BestFitColumns(view);
            DataSetHelper.SetColumnAutoIncrement(ds_WarehouseDescription.SP_GetWarehouseDescriptionDetail.WarehouseDescriptionDetailIDColumn);
        }

        #region Properties
        public int WarehouseDescriptionID
        {
            get { return ConvertHelper.ToInt32(PrimaryKey); }
            set
            {
                PrimaryKey = value;
                txtWarehouseDescriptionID.Text = txtID.Text = value.ToString();
                Text = OptionsBaseForm.Text + (value > 0 ? " №" + value.ToString() : string.Empty);
            }
        }
        public int BranchID
        {
            get { return ConvertHelper.ToInt32(bbBranch.RecordValue); }
            set { bbBranch.RecordValue = value; }
        }
        public DateTime Date
        {
            get { return ConvertHelper.ToDateTime(dateDate.EditValue); }
            set { dateDate.EditValue = value; }
        }
        public int ProductCount
        {
            get { return 0; }
            set { }
        }
        public decimal ProductQty
        {
            get
            {
                var value = 0m;
                foreach (var row in ds_WarehouseDescription.SP_GetWarehouseDescriptionDetail)
                {
                    if (DataSetHelper.IsDataRowDeleted(row)) continue;
                    value += row.Quantity;
                }
                return value;
            }
            set
            {
            }
        }
        public decimal DescrQty
        {
            get
            {
                var value = 0m;
                foreach (var row in ds_WarehouseDescription.SP_GetWarehouseDescriptionDetail)
                {
                    if (DataSetHelper.IsDataRowDeleted(row)) continue;
                    value += row.DescrQty;
                }
                return value;
            }
            set { }
        }

        public decimal ProductTotalDue
        {
            get
            {
                var value = 0m;
                foreach (var row in ds_WarehouseDescription.SP_GetWarehouseDescriptionDetail)
                {
                    if (DataSetHelper.IsDataRowDeleted(row)) continue;

                    value += row.Quantity * row.UnitPrice;
                }

                return value;
            }
            set { }
        }
        public decimal DescrTotalDue
        {
            get
            {
                var value = 0m;
                foreach (var row in ds_WarehouseDescription.SP_GetWarehouseDescriptionDetail)
                {
                    if (DataSetHelper.IsDataRowDeleted(row)) continue;

                    value += row.DescrQty * row.UnitPrice;
                }

                return value;
            }
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
        //public decimal CrossRate
        //{
        //    get { return GlobalVariable.MyCompanyConditionalUnitCurrencyRate / CurrencyRate; }
        //}

        public DateTime CreateDate
        {
            get { return ConvertHelper.ToDateTime(dateCreateDate.EditValue); }
            set { dateCreateDate.EditValue = value; }
        }
        public int CreatorID
        {
            get { return ConvertHelper.ToInt32(bbCreator.RecordValue); }
            set { bbCreator.RecordValue = value; }
        }
        public DateTime ModifiedDate
        {
            get { return ConvertHelper.ToDateTime(dateModifiedDate.EditValue); }
            set { dateModifiedDate.EditValue = value; }
        }
        public int ModifierID
        {
            get { return ConvertHelper.ToInt32(bbModifier.RecordValue); }
            set { bbModifier.RecordValue = value; }
        }
        public int ApproverID
        {
            get { return ConvertHelper.ToInt32(bbApprover.RecordValue); }
            set { bbApprover.RecordValue = value; }
        }
        #endregion

        private frmMedicamentBrowse _frmm;

        #region Bindings
        protected override void BindControls()
        {
            bsCurrency.DataSource = DictionaryManager.GetDictionary(ObjectNames.CurrencyWithLastRate);
            CurrencyCode = GlobalVariable.MyCompanyDefaultTradingCurrencyCode;

            bsCountry.DataSource = DictionaryManager.GetDictionary(ObjectNames.Country, -1);
            bsBrand.DataSource = DictionaryManager.GetDictionaryInt(ObjectNames.Brand, -1);

        }
        protected override void BindData()
        {
            if (Action == DatabaseAction.Edit)
            {
                ds_WarehouseDescription.SP_GetWarehouseDescriptionHeader.Clear();
                ds_WarehouseDescription.SP_GetWarehouseDescriptionHeader.Merge(ProductionManager.GetWarehouseDescriptionHeader(WarehouseDescriptionID));
                if (ds_WarehouseDescription.SP_GetWarehouseDescriptionHeader.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.", "RecordID");

                WarehouseDescriptionID = ds_WarehouseDescription.SP_GetWarehouseDescriptionHeader[0].WarehouseDescriptionID;
                BranchID = ds_WarehouseDescription.SP_GetWarehouseDescriptionHeader[0].BranchID;
                Date = ds_WarehouseDescription.SP_GetWarehouseDescriptionHeader[0].Date;
                CurrencyCode = ds_WarehouseDescription.SP_GetWarehouseDescriptionHeader[0].CurrencyCode;

                Status = (DatabaseStatus)ds_WarehouseDescription.SP_GetWarehouseDescriptionHeader[0].Status;
                CreateDate = ds_WarehouseDescription.SP_GetWarehouseDescriptionHeader[0].CreateDate;
                CreatorID = ds_WarehouseDescription.SP_GetWarehouseDescriptionHeader[0].CreatorID;
                ModifiedDate = ds_WarehouseDescription.SP_GetWarehouseDescriptionHeader[0].ModifiedDate;
                ModifierID = ds_WarehouseDescription.SP_GetWarehouseDescriptionHeader[0].ModifierID;
                ApproverID = ds_WarehouseDescription.SP_GetWarehouseDescriptionHeader[0].ApproverID;

                BindingDetail();
            }
            else
            {
                BranchID = GlobalVariable.BranchID;
                Date =
                CreateDate =
                ModifiedDate = BaseGlobalVariable.ServerDateTime;
                CreatorID =
                ModifierID = BaseGlobalVariable.UserID;
            }
        }
        private void BindingDetail()
        {
            ds_WarehouseDescription.SP_GetWarehouseDescriptionDetail.Clear();
            ds_WarehouseDescription.SP_GetWarehouseDescriptionDetail.Merge(ProductionManager.GetWarehouseDescriptionDetail(WarehouseDescriptionID));
        }
        #endregion

        protected override void Init()
        {
            base.Init();

            dateDate.Properties.ReadOnly =
            bbBranch.Properties.ReadOnly = ReadOnly;
            btnGenerate.Enabled = !ReadOnly;

            XtraGridHelper.SetReadOnly(grid, ReadOnly, true, true);
        }
        protected override bool SaveData()
        {
            view.CloseEditor();
            bsGrid.EndEdit();

            DS_WarehouseDescription.SP_GetWarehouseDescriptionDetailDataTable t1 = DataSetHelper.PackAlternationTypedDataTable<DS_WarehouseDescription.SP_GetWarehouseDescriptionDetailDataTable>(ds_WarehouseDescription.SP_GetWarehouseDescriptionDetail);
            DataSetHelper.RemoveColumns(t1, true,
                                    t1.WarehouseDescriptionDetailIDColumn,
                                    t1.OrdinalNumberColumn,
                                    t1.ProductIDColumn,
                                    t1.MedicamentIDColumn,
                                    t1.CountryCodeColumn,
                                    t1.BrandIDColumn,
                                    t1.UnitPriceColumn,
                                    t1.QuantityColumn,
                                    t1.DescrQtyColumn,
                                    t1.CommentColumn,
                                    t1.ActionColumn
                                    );

            var id = ProductionManager.AddOrEditWarehouseDescription(WarehouseDescriptionID, BranchID, Date, ProductCount, ProductQty, DescrQty, ProductTotalDue, DescrTotalDue, CurrencyCode, DataSetHelper.InnerBytesData(t1), Status, CreateDate, CreatorID, BaseGlobalVariable.ServerDateTime, BaseGlobalVariable.UserID, ApproverID, Action);
            if (id > 0)
            {
                WarehouseDescriptionID = id;

                if (!OptionsEditForm.IsSaveAndCloseExecuting)
                    BindingDetail();
            }
            return (id > 0);
        }
        private void DeleteDetail()
        {
            if (ReadOnly) return;

            view.DeleteSelectedRows();
            IsChanged = true;
        }
        public void AddDetail()
        {
            if (ReadOnly) return;
            try
            {
                //if (ds_Purchasing.SP_GetPurchaseOrderHeader.Rows.Count == 0)
                //    throw new Exception("გთხოვთ შეავსოთ ძირითადი პარამეტრები.");

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
                        _frmm.CurrencyRate = CurrencyRate;
                    }
                }

                frm.Show();
                frm.BringToFront();
            }
            catch (Exception ex)
            {
                ExceptionHelper.Show(this, ex, "შეცდომა", MessageBoxIcon.Error);
            }
        }
        private void OnChooseProduct(object sender, CancelEventArgs e)
        {
            if (ReadOnly || OptionsBaseForm.IsLoading || OptionsBaseForm.IsClosing) return;

            try
            {
                var frm = (sender as frmMedicamentBrowse);
                if (frm == null) return;
                if (frm.OptionsGrid.SelectedRecordID == null)
                    throw new NullReferenceException("არჩეული ჩანაწერის იდენთიფიკატორი ცარიელია. (frm.SelectedRecordID = null)");

                var table = DictionaryManager.GetMedicament(ConvertHelper.ToInt32(frm.OptionsGrid.SelectedRecordID));
                if (table.Count == 0) throw new Exception("მონაცემი ვერ მოიძებმა.");
                var newRow = ds_WarehouseDescription.SP_GetWarehouseDescriptionDetail.NewSP_GetWarehouseDescriptionDetailRow();

                newRow.WarehouseDescriptionID = WarehouseDescriptionID;
                newRow.OrdinalNumber = (short)(view.RowCount + 1);
                newRow.MedicamentID = table[0].MedicamentID;
                newRow.MedicamentName = table[0].Name;
                newRow.UnitsInStock = table[0].UnitsInStock;
                newRow[ds_WarehouseDescription.SP_GetWarehouseDescriptionDetail.CountryCodeColumn] = table[0][table.CountryCodeColumn];
                newRow[ds_WarehouseDescription.SP_GetWarehouseDescriptionDetail.BrandIDColumn] = table[0][table.BrandIDColumn];
                newRow.UnitPrice = table[0].StandardCost * DictionaryManager.GetCurrencyRate(table[0].ProductCurrencyCode, BaseGlobalVariable.ServerDateTime) / CurrencyRate;
                newRow.Quantity = 0m;
                newRow.DescrQty = 0m;
                newRow._DescrQtyString = 0m;

                ds_WarehouseDescription.SP_GetWarehouseDescriptionDetail.AddSP_GetWarehouseDescriptionDetailRow(newRow);

                IsChanged = true;

                view.Focus();
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                ExceptionHelper.Show(this, ex, "შეცდომა მონაცემის არჩევისას", MessageBoxIcon.Error);
            }
        }
        private void ProcessKey(object sender, KeyEventArgs e)
        {
            if (OptionsBaseForm.IsLoading) return;

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
        protected override void Print()
        {
            ReportFactory.Show(MdiParent, Text, ObjectName, ds_WarehouseDescription);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (ReadOnly) return;


            var productLocation = ProductLocationManager.GetVWByBranchAndDate(BranchID, Date);
            DataSetHelper.DeleteAllRows(ds_WarehouseDescription.SP_GetWarehouseDescriptionDetail);
            
            short i = 0;
            var rate = CurrencyRate;
            var id = WarehouseDescriptionID;
            var t_product = new DS_PurchaseOrderInfo.T_ProductDataTable();
            foreach (var row in productLocation)
            {
                i++;
                var newRow = ds_WarehouseDescription.SP_GetWarehouseDescriptionDetail.NewSP_GetWarehouseDescriptionDetailRow();
                newRow.WarehouseDescriptionID = id;
                newRow.OrdinalNumber = i;
                newRow.MedicamentID = row.MedicamentID;
                newRow.MedicamentName = row.MedicamentName;
                newRow.UnitsInStock = row.UnitsInStock;
                newRow.ProductID = row.ProductID;
                newRow[ds_WarehouseDescription.SP_GetWarehouseDescriptionDetail.CountryCodeColumn] = row[productLocation.CountryCodeColumn.ColumnName];
                newRow[ds_WarehouseDescription.SP_GetWarehouseDescriptionDetail.BrandIDColumn] = row[productLocation.BrandIDColumn];
                newRow.UnitPrice = row.StandardCost * rate;
                newRow.Quantity = row.Quantity;
                newRow.DescrQty = 0m;
                ds_WarehouseDescription.SP_GetWarehouseDescriptionDetail.AddSP_GetWarehouseDescriptionDetailRow(newRow);
                t_product.AddT_ProductRow(row.ProductID);
            }

            DataTable t_xml = DataSetHelper.PackAlternationDataTable(t_product);
            var purchaseInfo = ProductionManager.GetPurchaseOrderInfo(0, CurrencyCode, DataSetHelper.InnerBytesData(t_xml));
            var view = new DataView(purchaseInfo);
            view.Sort = purchaseInfo.ProductIDColumn.ColumnName;

            foreach (var row in ds_WarehouseDescription.SP_GetWarehouseDescriptionDetail)
            {
                if (DataSetHelper.IsDataRowDeleted(row)) continue;

                var j = view.Find(row.ProductID);
                if (j == -1) continue;

                var purchaseRow = (DS_PurchaseOrderInfo.SP_GetPurchaseOrderInfoRow)view[j].Row;
                row.UnitPrice = ProductionManager.GetPurchaseUnitPrice(purchaseRow.UnitPrice, purchaseRow.AverageRate1, purchaseRow.AverageRate2);
            }
        }

        private void grid_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            switch (e.Button.ButtonType)
            {
                case NavigatorButtonType.Append:
                    e.Handled = true;
                    AddDetail();
                    break;
                case NavigatorButtonType.Remove:
                    e.Handled = true;
                    DeleteDetail();
                    break;
            }
        }

        private void frmWarehouseDescriptionEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_frmm != null)
            {
                if (_frmm.IsDisposed)
                    _frmm = null;
                else
                    _frmm.Close();
            }
        }

        private void view_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var row = (DS_WarehouseDescription.SP_GetWarehouseDescriptionDetailRow)view.GetDataRow(e.RowHandle);
            switch (e.Column.Name)
            {
                case "colDescrQty":
                    InitDescrQtyString(row);
                    view.UpdateSummary();
                    break;

                case "col_DescrQtyString":
                    row.DescrQty = (int)row._DescrQtyString + ((1m / row.UnitsInStock) * MathHelper.FracToInt32(row._DescrQtyString));
                    break;
            }
        }
        private void InitDescrQtyString(DS_WarehouseDescription.SP_GetWarehouseDescriptionDetailRow row)
        {
            row._DescrQtyString = (int)row.DescrQty + MathHelper.MoveAfterDecimalMark(Math.Round(MathHelper.Fraction(row.DescrQty) * row.UnitsInStock, 0));
        }

        private void frmWarehouseDescriptionEdit_KeyDown(object sender, KeyEventArgs e)
        {
            ProcessKey(sender, e);
        }

        private void view_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (!e.IsGetData) return;

            switch (e.Column.Name)
            {
                case "colQtyString":
                    var row = (DS_WarehouseDescription.SP_GetWarehouseDescriptionDetailRow)view.GetDataRow(e.RowHandle);
                    //DS_WarehouseDescription.SP_GetWarehouseDescriptionDetailRow row = (DS_WarehouseDescription.SP_GetWarehouseDescriptionDetailRow)e.Row;
                    e.Value = QtyToString(row.Quantity, row.UnitsInStock);
                    break;
            }
        }
        private string QtyToString(decimal quantity, short unitsInStock)
        {
            return ProductionManager.QtyToString(quantity, unitsInStock);
        }
    }
}
