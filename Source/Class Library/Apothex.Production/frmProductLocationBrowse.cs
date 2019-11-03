using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Apothex.Reporting;
using Apothex.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraBars;
using Apothex.Common;
using Apothex.DataManagment.Dictionary;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using Zek.Core;
using Apothex.DataType;
using Apothex.Xpo;
using Apothex.Configuration;
using Xpo;
using Apothex.DataManagment.Production;
using Zek.Windows.Forms;
using Zek.Data;

namespace Apothex.Production
{
    public partial class frmProductLocationBrowse : frmBrowse
    {
        public frmProductLocationBrowse()
        {
            InitializeComponent();

            InitIsOnline();
            BranchID = GlobalVariable.BranchID;

            var styleFormatConditionValidDate = new StyleFormatCondition(FormatConditionEnum.Between, colValidDate, null, DateTimeHelper.MinDate, DateTimeHelper.GetStartOfMonth(BaseGlobalVariable.ServerDateTime).AddMonths(3), true);
            styleFormatConditionValidDate.Appearance.BackColor = Color.LavenderBlush;
            styleFormatConditionValidDate.Appearance.BackColor2 = Color.Pink;
            styleFormatConditionValidDate.Appearance.Options.HighPriority = true;
            styleFormatConditionValidDate.Appearance.GradientMode = LinearGradientMode.ForwardDiagonal;
            styleFormatConditionValidDate.Appearance.Options.UseBackColor = true;

            var tmp = gridView.FormatConditions[0];
            gridView.FormatConditions.Clear();
            gridView.FormatConditions.Add(styleFormatConditionValidDate);
            gridView.FormatConditions.Add(tmp);



        }

        private void miExportApex(object sender, ItemClickEventArgs e)
        {
            var dlg = new SaveFileDialog() { Filter = "Xml Files|*.xml|All Files|*.*" };
            if (dlg.ShowDialog() != DialogResult.OK) return;

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;


                var usdRate = DictionaryManager.GetCurrencyRate("USD", BaseGlobalVariable.ServerDateTime);
                //var rate = CurrencyRate != 0 ? CurrencyRate : 1m;
                var dsExport = new DS_Neopharmi();
                foreach (var row in ds.VW_ProductLocation)
                {
                    if (DataSetHelper.IsDataRowDeleted(row)) continue;

                    var newrow = (DS_Neopharmi.T_NeopharmiRow)DataSetHelper.AddEmptyRow(dsExport.T_Neopharmi);

                    newrow.productsid = row.ProductID.ToString();
                    newrow.products_n = StringHelper.Trim(GeoConvertHelper.Convert(row.MedicamentName, GeoConvertHelper.UnicodeGeo, GeoConvertHelper.StandardGeo), 100);
                    newrow.producer_n = StringHelper.Trim(GeoConvertHelper.Convert(row.BrandName, GeoConvertHelper.UnicodeGeo, GeoConvertHelper.StandardGeo), 40);
                    newrow.country_n = StringHelper.Trim(GeoConvertHelper.Convert(row.CountryName, GeoConvertHelper.UnicodeGeo, GeoConvertHelper.StandardGeo), 20);
                    newrow.icount = row.Quantity;
                    newrow.priceg = row.ListPrice * row.ProductCurrencyRate;
                    newrow.priceu = newrow.priceg / usdRate;
                    newrow.svg = row.Quantity * newrow.priceg;
                    newrow.svu = row.Quantity * newrow.priceu;
                    newrow.discount = row.DiscountPct * 100m;
                    newrow.vg = newrow.icount * (row.UnitPrice * row.PurchaseCurrencyRate);
                    newrow.vu = newrow.icount * ((row.UnitPrice * row.PurchaseCurrencyRate) / usdRate);

                    if (!row.IsValidDateNull())
                        newrow.lifedate = row.ValidDate;
                }

                dsExport.Namespace = " ";
                dsExport.DataSetName = "VFPData";
                dsExport.T_Neopharmi.TableName = "row";
                DataSetHelper.SetColumnMappingType(dsExport);
                dsExport.WriteXml(dlg.FileName, XmlWriteMode.WriteSchema);
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


        #region Fiels & Properties
        public int _PermissionAllBranch = 0;

        private int _BranchID;
        public int BranchID
        {
            get { return _BranchID; }
            set { _BranchID = value; }
        }

        public int SelectedBranchID
        {
            get
            {
                return (IsPermitted(_PermissionAllBranch, DatabaseAction.View) ? ConvertHelper.ToInt32(lookBranch.EditValue) : BranchID);
            }
        }

        //private decimal _CrossRate = 1m;
        //public decimal CrossRate
        //{
        //    get { return _CrossRate; }
        //    set
        //    {
        //        if (value <= 0m)
        //            throw new ArgumentException("ვალუტის კურსი არ შეიძლება იყოს უარყოფითი ან 0-ის ტოლი.", "CrossRate");

        //        _CrossRate = value;
        //    }
        //}

        public decimal OperationCurrencyRate;

        public string CurrencyCode
        {
            get { return ConvertHelper.ToString(lookCurrency.EditValue); }
            set { lookCurrency.EditValue = value; }
        }
        public decimal CurrencyRate
        {
            get { return ConvertHelper.ToDecimal(lookCurrency.GetColumnValue("Code")); }
        }

        public DateTime ValidDate1
        {
            get
            {
                var val = ConvertHelper.ToDateTime(dateValidDate1.EditValue);
                return val.AddDays(-val.Day + 1);
            }
        }
        public DateTime ValidDate2
        {
            get
            {
                var val = ConvertHelper.ToDateTime(dateValidDate2.EditValue);
                return val.AddDays(-val.Day + 1);
            }
        }



        protected override void OnServerModeChanged()
        {
            base.OnServerModeChanged();
            if (OptionsListForm.ServerMode)
            {
                cboxState.EditValue = null;
                dateState.EditValue = null;
                cboxState.Enabled = false;
                dateState.Enabled = false;
            }
        }
        private void InitIsOnline()
        {
            IsOnline = (!ConfigurationManagerEx.OfflineMode || ConfigurationManagerEx.OfflineMode && ConfigurationManagerEx.IsOnline && !OptionsListForm.ServerMode);
        }

        private bool _IsStateBinded;

        protected override bool IsAllowedChoose
        {
            get
            {
                var ok = base.IsAllowedChoose;
                if (ok)
                {
                    if (ConvertHelper.ToInt32(OptionsGrid.GridView.GetRowCellValue(OptionsGrid.SelectedRowHandle, colBranchID)) != BranchID || _IsStateBinded)
                        ok = false;
                }

                return ok;
            }
        }
        #endregion

        #region Bindings
        protected override void BindControls()
        {
            if (OptionsListForm.ServerMode) return;


            var subExport = XtraBarHelper.MoveIntoBarSubItem(miExport, "ექსპოსტი", miExport.Glyph);
            miExport.Glyph = null;
            XtraBarHelper.AddBarButtonItem(subExport, "ექსპორტი აპექსში", null, miExportApex);


            bsBranch.DataSource = DictionaryManager.GetDictionary(ObjectNames.Branch);
            lookBranch.EditValue = BranchID.ToString();

            bsCurrency.DataSource = DictionaryManager.GetDictionary(ObjectNames.CurrencyWithLastRate, -1);
            CurrencyCode = GlobalVariable.MyCompanyDefaultTradingCurrencyCode;

            bsMedicamentCategory.DataSource = DictionaryManager.GetDictionary(ObjectNames.MedicamentCategory);
            bsMedicamentSubcategory.DataSource = DictionaryManager.GetDictionary(ObjectNames.MedicamentSubcategoryWithMedicamentCategoryID);
        }
        protected override void BindGrid()
        {
            if (OptionsListForm.ServerMode)
            {
                BindingXpo();
                return;
            }

            using (var cmd = new SqlCommand())
            {
                if (cboxState.Text == "=")
                {
                    cmd.CommandText = SelectSql + @"
*
FROM dbo.FN_GetVW_ProductLocationState(@StateDate)
";
                    cmd.Parameters.Add("@StateDate", SqlDbType.DateTime).Value = ConvertHelper.ToDateTime(dateState.EditValue);
                    _IsStateBinded = true;
                }
                else
                {
                    cmd.CommandText = SelectSql + @"
*
FROM Production.VW_ProductLocation
";
                    _IsStateBinded = false;
                }

                var where = " WHERE ";
                if (!IsPermitted(_PermissionAllBranch, DatabaseAction.View))
                {
                    cmd.CommandText += where + "BranchID = @BranchID";
                    cmd.Parameters.Add("@BranchID", SqlDbType.Int).Value = SelectedBranchID;
                    where = " AND ";
                }

                if (IsFiltered)
                {
                    if (lookBranch.EditValue != null && IsPermitted(_PermissionAllBranch, DatabaseAction.View))
                    {
                        cmd.CommandText += where + "BranchID = @BranchID";
                        cmd.Parameters.Add("@BranchID", SqlDbType.Int).Value = SelectedBranchID;
                        where = " AND ";
                    }

                    var sql = string.Empty;

                    sql = Zek.Windows.Forms.DevEx.FilterHelper.CreateFilter("MedicamentName", cboxMedicamentName.Text, txtMedicament.Text.Trim(), SqlDbType.NVarChar, cmd);
                    if (sql.Length > 0)
                    {
                        cmd.CommandText += where + sql;
                        where = " AND ";
                    }

                    if (lookMedicamentCategory.EditValue != null)
                    {
                        cmd.CommandText += where + "MedicamentCategoryID = @MedicamentCategoryID";
                        cmd.Parameters.Add("@MedicamentCategoryID", SqlDbType.Int).Value = ConvertHelper.ToInt32(lookMedicamentCategory.EditValue);
                        where = " AND ";
                    }

                    if (lookMedicamentSubcategory.EditValue != null)
                    {
                        cmd.CommandText += where + "MedicamentSubcategoryID = @MedicamentSubcategoryID";
                        cmd.Parameters.Add("@MedicamentSubcategoryID", SqlDbType.Int).Value = ConvertHelper.ToInt32(lookMedicamentSubcategory.EditValue);
                        where = " AND ";
                    }

                    var filter = string.Empty;
                    filter = Zek.Windows.Forms.DevEx.FilterHelper.CreateFilter("ValidDate", cboxValidDate.Text, ValidDate1, ValidDate2, RoundingFormat.None, cmd);
                    if (filter.Length > 0)
                    {
                        cmd.CommandText += where + filter;
                        where = " AND ";
                    }

                    filter = Zek.Windows.Forms.DevEx.FilterHelper.CreateFilter("Quantity", cboxTotalQty.Text, spinTotalQty1.Value, spinTotalQty1.Value, SqlDbType.Decimal, cmd);
                    if (filter.Length > 0)
                    {
                        cmd.CommandText += where + filter;
                        where = " AND ";
                    }


                    if (chkSafetyStockLevel.Checked)
                    {
                        cmd.CommandText += where + "(SafetyStockLevel <> 0 AND Quantity <= SafetyStockLevel)";
                        where = " AND ";
                    }
                }

                //cmd.CommandText += " ORDER BY OrderDate DESC, BranchID";

                ds.VW_ProductLocation.Clear();
                ds.VW_ProductLocation.Merge(DictionaryManager.GetDataTable(cmd, IsOnline));
            }
        }

        private Session _Session;
        private XPServerCollectionSource _XpServerCollectionSource;
        public void BindingXpo()
        {
            var fixedFilterString = string.Format("BranchID = {0} AND Quantity > \'0.00\'", BranchID);
            if (_Session == null)
            {
                //gridControl.ServerMode = true;
                gridView.OptionsView.ShowAutoFilterRow = true;
                XpoHelper.Fill(ref _Session, typeof(VW_ProductLocation), ref _XpServerCollectionSource, fixedFilterString, !ConfigurationManagerEx.OfflineMode);
                gridControl.DataSource = _XpServerCollectionSource;
            }
            else
                XpoHelper.Fill(ref _Session, typeof(VW_ProductLocation), ref _XpServerCollectionSource, fixedFilterString, !ConfigurationManagerEx.OfflineMode);
        }
        #endregion

        #region Validations
        public bool IsValidDate()
        {
            if (cboxValidDate.Text == " " && dateValidDate1.EditValue == null)
            {
                dxErrorProvider.SetError(dateValidDate1, "გთხოვთ აირჩიოთ თარიღი.");
                return false;
            }

            if (cboxValidDate.Text == " " && dateValidDate2.EditValue == null)
            {
                dxErrorProvider.SetError(dateValidDate2, "გთხოვთ აირჩიოთ თარიღი.");
                return false;
            }
            if (cboxValidDate.Text == " " && dateValidDate1.EditValue != null && dateValidDate2.EditValue != null && dateValidDate1.DateTime > dateValidDate2.DateTime)
            {
                dxErrorProvider.SetError(dateValidDate2, "დასრულების თარიღი უნდა აღემატებოდეს დაწყების თარიღს.");
                return false;
            }

            return true;
        }
        public bool IsValidState()
        {
            if (!OptionsListForm.ServerMode && cboxState.Text.Length > 0)
            {
                if (dateState.EditValue == null)
                {
                    dxErrorProvider.SetError(dateState, "გთხოვთ აირჩიოთ მნიშვნელობა.");
                    return false;
                }
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var ok = true;
            if (!IsValidDate()) ok = false;
            if (!IsValidState()) ok = false;

            return ok;
        }
        #endregion

        #region Methods
        protected override void Init()
        {
            base.Init();

            if (OptionsListForm.ServerMode)
            {
                OptionsListForm.IsFilterable = false;
                OptionsListForm.IsTopable = false;
                gridView.Columns.Remove(colBranchName);
                gridView.Columns.Remove(col__PurchaseLineTotal);
                gridView.Columns.Remove(col__SalesLineTotal);
                gridView.Columns.Remove(col__PurchaseTaxAmt);
                gridView.Columns.Remove(col__SalesTaxAmt);
            }
            else
            {
                OptionsBaseForm.IsPrintable = true;
            }

            _PermissionAllBranch = GlobalVariable.GetPermission((int)ObjectNames.PurchaseOrderHeaderAllBranch);
            lookBranch.Properties.ReadOnly = !IsPermitted(_PermissionAllBranch, DatabaseAction.View);
        }
        protected override void ChooseRecord(CancelEventArgs e)
        {
            base.ChooseRecord(e);

            if (e.Cancel || OptionsListForm.CloseAfterChoose) return;

            gridControl.Focus();

            if (!e.Cancel)
            {
                gridView.SetRowCellValue(OptionsGrid.SelectedRowHandle, colInUse, true);
                FocusFilter();
            }
        }
        public void FocusFilter()
        {
            if (OptionsListForm.ServerMode)
            {
                if (OptionsGrid.GridView.GridControl != null)
                    OptionsGrid.GridView.GridControl.ForceInitialize();
                OptionsGrid.GridView.FocusedRowHandle = GridControl.AutoFilterRowHandle;
            }
            else
            {
                if (!pnlFilter.Visible) return;

                xtraTabControl.SelectedTabPage = tabMain;
                txtMedicament.Focus();
                txtMedicament.SelectAll();
            }
        }
        protected override void Print()
        {
            var table = new DS_ProductLocationPrice.T_DetailDataTable();
            foreach (var row in ds.VW_ProductLocation)
            {
                table.AddT_DetailRow(row.ProductLocationID, row.MedicamentName, row.CountryName, row.Serie, row.ListPrice * row.ProductCurrencyRate / OperationCurrencyRate, row.DiscountPct);
            }

            ReportFactory.Show(MdiParent, Text, ObjectName, table);
        }
        #endregion

        private void lookMedicamentCategory_EditValueChanged(object sender, EventArgs e)
        {
            lookMedicamentSubcategory.EditValue = null;
            bsMedicamentSubcategory.Filter = "Code=" + ConvertHelper.ToInt32(lookMedicamentCategory.EditValue).ToString();
        }

        private void cboxValidDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetError(dateValidDate1, string.Empty);
            SetError(dateValidDate2, string.Empty);
            Zek.Windows.Forms.DevEx.FilterHelper.ShowFilterFields(cboxValidDate.Text, dateValidDate1, dateValidDate2);
        }

        private void dateValidDate1_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(dateValidDate1, string.Empty);
            dxErrorProvider.SetError(dateValidDate2, string.Empty);
        }

        private void dateValidDate2_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(dateValidDate1, string.Empty);
            dxErrorProvider.SetError(dateValidDate2, string.Empty);
        }

        private void cboxTotalQty_SelectedIndexChanged(object sender, EventArgs e)
        {
            Zek.Windows.Forms.DevEx.FilterHelper.ShowFilterFields(cboxTotalQty.Text, spinTotalQty1, spinTotalQty2);
        }

        private void gridControl_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7 && !e.Control && !e.Shift && !e.Alt)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                FocusFilter();
            }
        }

        private void txtMedicament_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && !e.Control && !e.Shift && !e.Alt)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                DoFilter();
            }
            else if (e.KeyCode == Keys.Down && !e.Control && !e.Shift && !e.Alt)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;

                OptionsGrid.GridView.Focus();
                if (OptionsGrid.GridView.RowCount > 0)
                {
                    OptionsGrid.GridView.FocusedRowHandle = 0;
                    OptionsGrid.GridView.SelectRow(0);
                }
            }
        }

        private void cboxMedicamentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Zek.Windows.Forms.DevEx.FilterHelper.ShowFilterFields(cboxMedicamentName.Text, txtMedicament);
        }

        private void frmProductLocationBrowse_Shown(object sender, EventArgs e)
        {
            FocusFilter();
        }

        private void gridView_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (!e.IsGetData) return;

            var row = gridView.GetRow(e.RowHandle);

            switch (e.Column.Name)
            {
                case "col_UnitPrice":
                    e.Value = (OptionsListForm.ServerMode ? ((VW_ProductLocation)row).UnitPrice * ((VW_ProductLocation)row).PurchaseCurrencyRate : ((DS_ProductLocation.VW_ProductLocationRow)((DataRowView)row).Row).UnitPrice * ((DS_ProductLocation.VW_ProductLocationRow)((DataRowView)row).Row).PurchaseCurrencyRate) / OperationCurrencyRate;//* _CrossRate;
                    break;

                case "col_ListPrice":
                    e.Value = (OptionsListForm.ServerMode ? ((VW_ProductLocation)row).ListPrice * ((VW_ProductLocation)row).ProductCurrencyRate : ((DS_ProductLocation.VW_ProductLocationRow)((DataRowView)row).Row).ListPrice * ((DS_ProductLocation.VW_ProductLocationRow)((DataRowView)row).Row).ProductCurrencyRate) / OperationCurrencyRate;//* _CrossRate;
                    break;

                case "col_DealerPrice":
                    e.Value = (OptionsListForm.ServerMode ? ((VW_ProductLocation)row).DealerPrice * ((VW_ProductLocation)row).ProductCurrencyRate : ((DS_ProductLocation.VW_ProductLocationRow)((DataRowView)row).Row).DealerPrice * ((DS_ProductLocation.VW_ProductLocationRow)((DataRowView)row).Row).ProductCurrencyRate) / OperationCurrencyRate;//* _CrossRate;
                    break;

                case "col_OneUnitPrice":
                    if (OptionsListForm.ServerMode)
                    {
                        var rowServerMode = ((VW_ProductLocation)row);
                        e.Value = (rowServerMode.ListPrice * rowServerMode.ProductCurrencyRate / OperationCurrencyRate) * MathHelper.MinQuantity(rowServerMode.UnitsInStock, 4);
                    }
                    else
                    {
                        var rowNormalMode = ((DS_ProductLocation.VW_ProductLocationRow)((DataRowView)row).Row);
                        e.Value = (rowNormalMode.ListPrice * rowNormalMode.ProductCurrencyRate / OperationCurrencyRate) * MathHelper.MinQuantity(rowNormalMode.UnitsInStock, 4);
                    }
                    break;

                case "col_Quantity":
                    if (OptionsListForm.ServerMode)
                    {
                        var rowServerMode = ((VW_ProductLocation)row);
                        e.Value = QtyToString(rowServerMode.Quantity, rowServerMode.UnitsInStock);
                    }
                    else
                    {
                        var rowNormalMode = ((DS_ProductLocation.VW_ProductLocationRow)((DataRowView)row).Row);
                        e.Value = QtyToString(rowNormalMode.Quantity, rowNormalMode.UnitsInStock);
                    }
                    break;

                case "col__PurchaseLineTotal":
                    e.Value = ((DS_ProductLocation.VW_ProductLocationRow)((DataRowView)row).Row).UnitPrice * ((DS_ProductLocation.VW_ProductLocationRow)((DataRowView)row).Row).Quantity * ((DS_ProductLocation.VW_ProductLocationRow)((DataRowView)row).Row).PurchaseCurrencyRate / OperationCurrencyRate;
                    break;
                case "col__SalesLineTotal":
                    e.Value = ((DS_ProductLocation.VW_ProductLocationRow)((DataRowView)row).Row).ListPrice * ((DS_ProductLocation.VW_ProductLocationRow)((DataRowView)row).Row).Quantity * ((DS_ProductLocation.VW_ProductLocationRow)((DataRowView)row).Row).ProductCurrencyRate / OperationCurrencyRate;
                    break;

                case "col__PurchaseTaxAmt":
                    e.Value = ((DS_ProductLocation.VW_ProductLocationRow)((DataRowView)row).Row).StandardCost * ((DS_ProductLocation.VW_ProductLocationRow)((DataRowView)row).Row).Quantity * ((DS_ProductLocation.VW_ProductLocationRow)((DataRowView)row).Row).TaxRate * ((DS_ProductLocation.VW_ProductLocationRow)((DataRowView)row).Row).ProductCurrencyRate / OperationCurrencyRate;
                    break;
                case "col__SalesTaxAmt":
                    e.Value = ((DS_ProductLocation.VW_ProductLocationRow)((DataRowView)row).Row).ListPrice * ((DS_ProductLocation.VW_ProductLocationRow)((DataRowView)row).Row).Quantity * ((DS_ProductLocation.VW_ProductLocationRow)((DataRowView)row).Row).TaxRate * ((DS_ProductLocation.VW_ProductLocationRow)((DataRowView)row).Row).ProductCurrencyRate / OperationCurrencyRate;
                    break;
            }
        }
        private string QtyToString(decimal quantity, short unitsInStock)
        {
            return ProductionManager.QtyToString(quantity, unitsInStock);
        }

        private void dateState_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(dateState, string.Empty);
        }

        private void cboxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            Zek.Windows.Forms.DevEx.FilterHelper.ShowFilterFields(cboxState.Text, dateState);
            dxErrorProvider.SetError(dateState, string.Empty);
        }

        private void miShowProductLocationPurchaseOrderHeader_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.ShowDialog(typeof(frmVendor), this, OptionsGrid.SelectedRecordID);
        }

        private void lookCurrency_EditValueChanged(object sender, EventArgs e)
        {
            //CrossRate = GlobalVariable.MyCompanyConditionalUnitCurrencyRate / CurrencyRate;
            OperationCurrencyRate = CurrencyRate;
        }
    }
}