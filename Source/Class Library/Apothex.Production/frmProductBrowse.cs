using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Apothex.Reporting;
using Apothex.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

using Apothex.DataManagment.Dictionary;
using Apothex.DataType;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Zek.Core;
using Apothex.DataManagment.Production;
using Apothex.Common;
using Zek.Data;
using Zek.Windows.Forms;

namespace Apothex.Production
{
    public partial class frmProductBrowse : frmBrowse
    {
        public frmProductBrowse()
        {
            InitializeComponent();
        }

        #region Fields & Properties
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
        public string CurrencyCode
        {
            get { return ConvertHelper.ToString(lookCurrency.EditValue); }
            set { lookCurrency.EditValue = value; }
        }
        public decimal CurrencyRate
        {
            get { return Convert.ToDecimal(lookCurrency.GetColumnValue("Code")); }
        }
        private decimal _CurrencyRate = 1m;

        private bool _IsAllowedChangePrice;
        #endregion

        #region Bindings
        protected override void BindControls()
        {
            bsCurrency.DataSource = DictionaryManager.GetDictionary(ObjectNames.CurrencyWithLastRate, -1);
            CurrencyCode = GlobalVariable.MyCompanyDefaultTradingCurrencyCode;
            InitCurrencyRate();

            //GlobalVariable.MyCompanyConditionalUnitCurrencyRate = DictionaryManager.GetCurrencyRate(GlobalVariable.MyCompanyConditionalUnitCurrencyCode, GlobalVariable.ServerDateTime, true);
            //if (GlobalVariable.MyCompanyConditionalUnitCurrencyRate <= 0m)
            //    throw new Exception(string.Format("პირობითი ერთეულის ვალუტის კურსის ამოღება ვერ მოხერხდა (ვალუტა='{0}', კურსი='{1}').", GlobalVariable.MyCompanyConditionalUnitCurrencyCode, GlobalVariable.MyCompanyConditionalUnitCurrencyRate));
        }
        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                if (cboxState.Text == "=")
                {
                    cmd.CommandText = SelectSql + @"
*
FROM dbo.FN_GetVW_ProductState(@StateDate)
WHERE " + FilterStatusSql;
                    cmd.Parameters.Add("@StateDate", SqlDbType.DateTime).Value = ConvertHelper.ToDateTime(dateState.EditValue);
                }
                else
                {
                    cmd.CommandText = SelectSql + @"
*
FROM Production.VW_Product
WHERE " + FilterStatusSql;
                }


                if (IsFiltered)
                {
                    var filter = string.Empty;

                    filter = FilterHelper.CreateFilter("MedicamentName", cboxMedicament.Text, txtMedicament.Text.Trim(), SqlDbType.NVarChar, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("BranchID", cboxBranch.Text, bbBranch.RecordValue, SqlDbType.Int, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("OrderDate", cboxOrderDate.Text, ConvertHelper.ToDateTime(dateOrderDate1.EditValue), ConvertHelper.ToDateTime(dateOrderDate2.EditValue), RoundingFormat.None, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;


                    filter = FilterHelper.CreateFilter("ValidDate", cboxValidDate.Text, ValidDate1, ValidDate2, RoundingFormat.None, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;


                    filter = FilterHelper.CreateFilter("Quantity", cboxTotalQty.Text, spinTotalQty1.Value, spinTotalQty1.Value, SqlDbType.Decimal, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;


                    filter = FilterHelper.CreateFilter("PurchaseOrderID", cboxOrderID.Text, txtOrderID.EditValue, SqlDbType.Int, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;


                    filter = FilterHelper.CreateFilter("VendorID", cboxVendor.Text, ConvertHelper.ToInt32(bbVendor.RecordValue), SqlDbType.Int, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;


                    if (chkSafetyStockLevel.Checked)
                        cmd.CommandText += " AND (SafetyStockLevel <> 0 AND Quantity < SafetyStockLevel)";
                }

                cmd.CommandText += " ORDER BY ProductID DESC";

                ds.VW_Product.Clear();
                ds.VW_Product.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }
        #endregion

        #region Validations
        public bool IsValidGrid()
        {
            OptionsGrid.GridView.CloseEditor();
            bsGridControl.EndEdit();

            var ok = true;
            foreach (var row in ds.VW_Product)
            {
                if (row.RowState == DataRowState.Deleted || row.RowState == DataRowState.Unchanged) continue;
                if (!IsValidRow(row)) ok = false;
            }

            return ok;
        }
        private bool IsValidRow(DS_Product.VW_ProductRow row)
        {
            row.ClearErrors();
            var ok = true;

            if (!row.IsNewListPriceNull() && row.NewListPrice < 0m)
            {
                ok = false;
                row.SetColumnError(ds.VW_Product._NewListPriceColumn, "მნიშვნელობა არ შეიძლება იყოს უარყოფითი");
            }

            if (!row.IsNewDealerPriceNull() && row.NewDealerPrice < 0m)
            {
                ok = false;
                row.SetColumnError(ds.VW_Product._NewDealerPriceColumn, "მნიშვნელობა არ შეიძლება იყოს უარყოფითი");
            }

            if (!row.IsNewDiscountPctNull() && (row.NewDiscountPct < 0m || row.NewDiscountPct > 1m))
            {
                ok = false;
                row.SetColumnError(ds.VW_Product.NewDiscountPctColumn, "მნიშვნელობა უნდა იყოს 0-დან 100-მდე.");
            }

            return ok;
        }
        #endregion

        #region Methods
        protected override void Print()
        {
            ReportFactory.Show(MdiParent, OptionsBaseForm.Text, ObjectName, ds);
        }
        protected override void Init()
        {
            base.Init();

            _IsAllowedChangePrice = IsPermitted(ObjectNames.ProductPrice, DatabaseAction.Edit);


            if (!_IsAllowedChangePrice)
                tabPrice.PageVisible = false;
        }
        protected override void InitGrid(GridView gridView)
        {
            base.InitGrid(gridView);

            if (_IsAllowedChangePrice)
            {
                OptionsGrid.GridView.OptionsBehavior.Editable = true;
                foreach (GridColumn col in OptionsGrid.GridView.Columns)
                {
                    if (col == col_NewListPrice || col == col_NewDealerPrice || col == colNewDiscountPct) continue;
                    col.OptionsColumn.AllowEdit = false;
                }
            }
            else
            {
                OptionsGrid.GridView.Columns.Remove(col_NewListPrice);
                OptionsGrid.GridView.Columns.Remove(col_NewDealerPrice);
                OptionsGrid.GridView.Columns.Remove(colNewDiscountPct);
                col_NewListPrice = null;
                col_NewDealerPrice = null;
                colNewDiscountPct = null;
            }
        }
        public void InitNewValues()
        {
            if (!_IsAllowedChangePrice) return;

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                var rate = CurrencyRate;
                if (rate <= 0m)
                {
                    XtraMessageBox.Show(this, "ვალუტის კურსი არ დაფიქსირდა ან ვალუტა არ გაქვთ არჩეული ფილტრში.", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                view.BeginDataUpdate();
                foreach (var rowHandle in view.GetSelectedRows())
                {
                    var row = (DS_Product.VW_ProductRow)view.GetDataRow(rowHandle);

                    var isChanged = false;
                    if (chkNewPriceFromStandardCost.Checked)
                    {
                        row.NewListPrice = MathHelper.AddPct(row.StandardCost, row.TaxRate * 100m) * (1m + spinNewPriceFromStandardCost.Value);
                        isChanged = true;
                    }
                    else if (chkNewListPrice.Checked)
                    {
                        row.NewListPrice = row.ListPrice * (1m + spinNewListPrice.Value);
                        isChanged = true;
                    }
                    else
                        row.NewListPrice = row.ListPrice;
                    row._NewListPrice = row.NewListPrice * row.ProductCurrencyRate / rate;


                    if (chkNewDealerPrice.Checked)
                    {
                        row.NewDealerPrice = row.DealerPrice * (1m + spinNewDealerPrice.Value);
                        isChanged = true;
                    }
                    else
                        row.NewDealerPrice = row.DealerPrice;
                    row._NewDealerPrice = row.NewDealerPrice * row.ProductCurrencyRate / rate;

                    if (chkNewDiscountPct.Checked)
                    {
                        row.NewDiscountPct = spinNewDiscountPct.Value;
                        isChanged = true;
                    }
                    else
                        row.NewDiscountPct = row.DiscountPct;

                    row.IsChanged = isChanged;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, string.Format("შეცდომა ფასების ცვლილებისას.\n{0}", ex.Message), "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                view.EndDataUpdate();
                Cursor = Cursors.Default;
            }
        }
        public void SavePrices()
        {
            if (!_IsAllowedChangePrice) return;
            if (!IsValidGrid()) return;

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                OptionsGrid.GridView.CloseEditor();
                bsGridControl.EndEdit();

                DS_Product.VW_ProductDataTable table = Zek.Data.DataSetHelper.PackAlternationTypedDataTable<DS_Product.VW_ProductDataTable>(ds.VW_Product);
                Zek.Data.DataSetHelper.RemoveColumns(table, true, table.ProductIDColumn,
                                                            table.NewListPriceColumn,
                                                            table.NewDealerPriceColumn,
                                                            table.NewDiscountPctColumn,
                                                            table.ActionColumn);


                using (var tmpds = new DataSet("root"))
                {
                    tmpds.Tables.Add(table);
                    var id = ProductionManager.AddOrEditProducts(BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, DatabaseAction.Import, Zek.Data.DataSetHelper.InnerBytesData(tmpds));
                    if (id > 0)
                    {
                        ds.VW_Product.AcceptChanges();
                        XtraMessageBox.Show(this, "ცვლილებები შენახულია.", "ინფორმაცია", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        throw new Exception("id <= 0");
                }
            }
            catch (Exception ex)
            {
                ExceptionHelper.Show(ex, "ცვლილებები არ შენახულა", MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private void InitCurrencyRate()
        {
            _CurrencyRate = CurrencyRate;
        }
        #endregion

        protected override void EnableDisableToolbar()
        {
            base.EnableDisableToolbar();

            miChangeCurrencyCode.Enabled = (IsAllowedEdit && IsPermitted(DatabaseAction.Edit));
        }

        private void lookCurrency_EditValueChanged(object sender, EventArgs e)
        {
            if (OptionsBaseForm.IsLoading) return;
            InitCurrencyRate();

            try
            {
                if (_IsAllowedChangePrice)
                {
                    var rate = CurrencyRate;
                    foreach (var row in ds.VW_Product)
                    {
                        if (!row.IsNewListPriceNull()) row._NewListPrice = row.NewListPrice * row.ProductCurrencyRate / rate;
                        if (!row.IsNewDealerPriceNull()) row._NewDealerPrice = row.NewDealerPrice * row.ProductCurrencyRate / rate;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, string.Format("შეცდომა ვალუტის ცვლილებისას.\n{0}", ex.Message), "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            view.RefreshData();
        }

        private void cboxMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxMedicament.Text, txtMedicament);
        }

        private void cboxValidDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxValidDate.Text, dateValidDate1, dateValidDate2);
            ClearError(dateValidDate1);
            ClearError(dateValidDate2);
        }

        private void dateValidDate1_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(dateValidDate1);
            ClearError(dateValidDate2);
        }

        private void dateValidDate2_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(dateValidDate1);
            ClearError(dateValidDate2);
        }

        private void cboxTotalQty_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxTotalQty.Text, spinTotalQty1, spinTotalQty2);
            ClearError(spinTotalQty1);
            ClearError(spinTotalQty2);
        }

        private void spinTotalQty1_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(spinTotalQty1);
            ClearError(spinTotalQty2);
        }

        private void spinTotalQty2_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(spinTotalQty1);
            ClearError(spinTotalQty2);
        }

        private void btnGenerateNewPrice_Click(object sender, EventArgs e)
        {
            InitNewValues();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SavePrices();
        }

        private void view_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var row = ((DS_Product.VW_ProductRow)view.GetDataRow(e.RowHandle));
            row.SetColumnError(e.Column.FieldName, string.Empty);

            switch (e.Column.Name)
            {
                case "col_NewListPrice":
                    row.NewListPrice = row._NewListPrice / (row.ProductCurrencyRate / _CurrencyRate);
                    if (row.ListPrice != row.NewListPrice)
                        row.IsChanged = true;
                    break;

                case "col_NewDealerPrice":
                    row.NewDealerPrice = row._NewDealerPrice / (row.ProductCurrencyRate / _CurrencyRate);
                    if (row.DealerPrice != row.NewDealerPrice)
                        row.IsChanged = true;
                    break;
            }
        }

        private void view_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.WindowCaption = "შეცდომა";
        }

        private void view_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            var row = ((DS_Product.VW_ProductRow)(((DataRowView)e.Row).Row));

            if (!IsValidRow(row))
            {
                view.SetColumnError(null, "სტრიქონში არის შეცდომა!");
                e.Valid = false;
                e.ErrorText = "სტრიქონში არის შეცდომა!\n";
            }
        }

        private void chkNewPricePct_CheckedChanged(object sender, EventArgs e)
        {
            spinNewListPrice.Properties.ReadOnly = !chkNewListPrice.Checked;
        }

        private void chkNewDiscountPct_CheckedChanged(object sender, EventArgs e)
        {
            spinNewDiscountPct.Properties.ReadOnly = !chkNewDiscountPct.Checked;
        }

        private void cboxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxVendor.Text, bbVendor);
        }

        private void cboxOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxOrderID.Text, txtOrderID);
        }

        private void view_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (!e.IsGetData) return;

            if (e.Column == col_UnitPrice)
                e.Value = ds.VW_Product[e.ListSourceRowIndex].UnitPrice * ds.VW_Product[e.ListSourceRowIndex].PurchaseCurrencyRate / _CurrencyRate;
            else if (e.Column == col_ListPrice)
                e.Value = ds.VW_Product[e.ListSourceRowIndex].ListPrice * ds.VW_Product[e.ListSourceRowIndex].ProductCurrencyRate / _CurrencyRate;
            else if (e.Column == col_DealerPrice)
                e.Value = ds.VW_Product[e.ListSourceRowIndex].DealerPrice * ds.VW_Product[e.ListSourceRowIndex].ProductCurrencyRate / _CurrencyRate;
        }

        private void chkNewDealerPrice_CheckedChanged(object sender, EventArgs e)
        {
            spinNewDealerPrice.Properties.ReadOnly = !chkNewDealerPrice.Checked;
        }

        private void cboxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxState.Text, dateState);
        }

        private void cboxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxBranch.Text, bbBranch);
        }

        private void cboxOrderDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxOrderDate.Text, dateOrderDate1, dateOrderDate2);
        }

        private void miChangeCurrencyCode_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!IsAllowedEdit || !IsPermitted(DatabaseAction.Edit)) return;


            try
            {
                Application.DoEvents();

                using (var frm = new frmChangeCurencyCode())
                {
                    if (frm.ShowDialog(this) != DialogResult.OK) return;
                    Cursor = Cursors.WaitCursor;

                    var table = new DS_Product.T_ProductIDDataTable();
                    foreach (var id in OptionsGrid.SelectedRecordIDs)
                    {
                        table.AddT_ProductIDRow((int)id);
                    }

                    DataSetHelper.SetColumnMappingType(table);

                    ProductionManager.ChangeProductCurrencyCode(frm.ProductCurrencyCode, frm.ChangePrice, DataSetHelper.InnerBytesData(table), BaseGlobalVariable.ServerDateTime, BaseGlobalVariable.UserID);

                }
            }
            catch (Exception ex)
            {
                ExceptionHelper.Show(this, ex, "შეცდომა პ/ე ვალუტის შეცვლისას", MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void chkNewPriceFromStandardCost_CheckedChanged(object sender, EventArgs e)
        {
            spinNewPriceFromStandardCost.Properties.ReadOnly = !chkNewPriceFromStandardCost.Checked;
        }
    }
}