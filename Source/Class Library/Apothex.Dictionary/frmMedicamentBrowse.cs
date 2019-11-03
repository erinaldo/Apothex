using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Apothex.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using Zek.Core;
using Apothex.DataManagment.Dictionary;
using Apothex.Common;
using Apothex.DataType;
using Apothex.Xpo;
using Xpo;

namespace Apothex.Dictionary
{
    public partial class frmMedicamentBrowse : frmBrowse
    {
        public frmMedicamentBrowse()
        {
            InitializeComponent();
        }

        #region Fields
        public string SelectedCurrencyCode
        {
            get { return ConvertHelper.ToString(lookCurrency.EditValue); }
            set { lookCurrency.EditValue = value; }
        }
        public decimal SelectedCurrencyRate
        {
            get { return Convert.ToDecimal(lookCurrency.GetColumnValue("Code")); }
        }

        public decimal CurrencyRate = 1m;
        #endregion

        #region Bindings
        protected override void BindControls()
        {
            if (OptionsListForm.ServerMode) return;

            bsCurrency.DataSource = DictionaryManager.GetDictionary(ObjectNames.CurrencyWithLastRate, -1);
            SelectedCurrencyCode = GlobalVariable.MyCompanyDefaultTradingCurrencyCode;
            InitCurrencyRate();

            bsCategory.DataSource = DictionaryManager.GetDictionary(ObjectNames.MedicamentCategory);
            bsSubcategory.DataSource = DictionaryManager.GetDictionary(ObjectNames.MedicamentSubcategoryWithMedicamentCategoryID);
            FilterSubcategory();
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
                cmd.CommandText = SelectSql +
@"
*
FROM Dictionary.VW_Medicament WITH (NOLOCK)
WHERE " + FilterStatusSql;

                if (IsFiltered)
                {
                    var sql = string.Empty;

                    sql = FilterHelper.CreateFilter("MedicamentID", cboxProductID.Text, txtProductID.Text.Trim(), SqlDbType.Int, cmd);
                    if (sql.Length > 0) cmd.CommandText += " AND " + sql;

                    sql = FilterHelper.CreateFilter("MedicamentName", cboxProductName.Text, txtProductName.Text.Trim(), SqlDbType.NVarChar, cmd);
                    if (sql.Length > 0) cmd.CommandText += " AND " + sql;


                    sql = FilterHelper.CreateFilter("ProductNumber", cboxProductNumber.Text, txtProductNumber.Text.Trim(), SqlDbType.NVarChar, cmd);
                    if (sql.Length > 0) cmd.CommandText += " AND " + sql;


                    sql = FilterHelper.CreateFilter("MedicamentCategoryID", cboxCategory.Text, lookCategory.EditValue, SqlDbType.Int, cmd);
                    if (sql.Length > 0) cmd.CommandText += " AND " + sql;

                    sql = FilterHelper.CreateFilter("MedicamentSubcategoryID", cboxSubcategory.Text, lookSubcategory.EditValue, SqlDbType.Int, cmd);
                    if (sql.Length > 0) cmd.CommandText += " AND " + sql;


                    if (chkMakeFlag.CheckState != CheckState.Indeterminate)
                    {
                        cmd.CommandText += " AND MakeFlag = @MakeFlag";
                        cmd.Parameters.Add("@MakeFlag", SqlDbType.Bit).Value = chkMakeFlag.Checked;
                    }


                    if (chkFinishedGoodsFlag.CheckState != CheckState.Indeterminate)
                    {
                        cmd.CommandText += " AND FinishedGoodsFlag = @FinishedGoodsFlag";
                        cmd.Parameters.Add("@FinishedGoodsFlag", SqlDbType.Bit).Value = chkFinishedGoodsFlag.Checked;
                    }


                    sql = FilterHelper.CreateFilter("Color", cboxColor.Text, txtColor.Text.Trim(), SqlDbType.NVarChar, cmd);
                    if (sql.Length > 0)
                        cmd.CommandText += " AND " + sql;


                    sql = FilterHelper.CreateFilter("SafetyStockLevel", cboxSafetyStockLevel.Text, spinSafetyStockLevel1.EditValue, spinSafetyStockLevel2.EditValue, SqlDbType.SmallInt, cmd);
                    if (sql.Length > 0)
                        cmd.CommandText += " AND " + sql;


                    sql = FilterHelper.CreateFilter("ReorderPoint", cboxReorderPoint.Text, spinReorderPoint1.EditValue, spinReorderPoint2.EditValue, SqlDbType.SmallInt, cmd);
                    if (sql.Length > 0)
                        cmd.CommandText += " AND " + sql;


                    sql = FilterHelper.CreateFilter("StandardCost", cboxStandardCost.Text, spinStandardCost1.EditValue, spinStandardCost2.EditValue, SqlDbType.Money, cmd);
                    if (sql.Length > 0)
                        cmd.CommandText += " AND " + sql;
                    

                    sql = FilterHelper.CreateFilter("ListPrice", cboxListPrice.Text, spinListPrice1.EditValue, spinListPrice2.EditValue, SqlDbType.Money, cmd);
                    if (sql.Length > 0)
                        cmd.CommandText += " AND " + sql;


                    sql = FilterHelper.CreateFilter("Size", cboxSize.Text, txtSize.Text.Trim(), SqlDbType.NVarChar, cmd);
                    if (sql.Length > 0)
                        cmd.CommandText += " AND " + sql;


                    sql = FilterHelper.CreateFilter("SizeRange", cboxSizeRange.Text, txtSizeRange.Text.Trim(), SqlDbType.NVarChar, cmd);
                    if (sql.Length > 0)
                        cmd.CommandText += " AND " + sql;


                    sql = FilterHelper.CreateFilter("Weight", cboxWeight.Text, spinWeight1.EditValue, spinWeight2.EditValue, SqlDbType.Decimal, cmd);
                    if (sql.Length > 0)
                        cmd.CommandText += " AND " + sql;


                    sql = FilterHelper.CreateFilter("DaysToManufacture", cboxDaysToManufacture.Text, spinDaysToManufacture1.EditValue, spinDaysToManufacture2.EditValue, SqlDbType.Int, cmd);
                    if (sql.Length > 0)
                        cmd.CommandText += " AND " + sql;
                }


                cmd.CommandText += " ORDER BY ModifiedDate DESC, MedicamentID DESC";

                ds.VW_Medicament.Clear();
                ds.VW_Medicament.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }

        private Session _Session;
        private XPServerCollectionSource _XpServerCollectionSource;
        public void BindingXpo()
        {
            if (_Session == null)
            {
                //gridControl.ServerMode = true;
                gridView.OptionsView.ShowAutoFilterRow = true;
                XpoHelper.Fill(ref _Session, typeof(VW_Medicament), ref _XpServerCollectionSource, FilterStatusSql);
                gridControl.DataSource = _XpServerCollectionSource;
            }
            else
                XpoHelper.Fill(ref _Session, typeof(VW_Medicament), ref _XpServerCollectionSource, FilterStatusSql);
        }
        #endregion

        #region Methods
        private void InitCurrencyRate()
        {
            CurrencyRate = SelectedCurrencyRate;
        }
        protected override void Init()
        {
            base.Init();

            if (OptionsListForm.ServerMode)
            {
                OptionsListForm.IsFilterable = false;
                OptionsListForm.IsTopable = false;
            }
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
                gridControl.ForceInitialize();
                gridView.FocusedRowHandle = GridControl.AutoFilterRowHandle;
            }
            else
            {
                if (!pnlFilter.Visible) return;

                txtProductName.Focus();
                txtProductName.SelectAll();
            }
        }
        public void FilterSubcategory()
        {
            bsSubcategory.Filter = "Code=" + ConvertHelper.ToInt32(lookCategory.EditValue).ToString();
        }
        #endregion

        private void cboxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxProductName.Text, txtProductName);
        }

        private void cboxSubcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxSubcategory.Text, lookSubcategory);
        }

        private void cboxProductNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxProductNumber.Text, txtProductNumber);
        }

        private void cboxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxColor.Text, txtColor);
        }

        private void cboxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxSize.Text, txtSize);
        }

        private void cboxSizeRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxSizeRange.Text, txtSizeRange);
        }

        private void cboxWeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxWeight.Text, spinWeight1, spinWeight2);
        }

        private void cboxSafetyStockLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxSafetyStockLevel.Text, spinSafetyStockLevel1, spinSafetyStockLevel2);
        }

        private void cboxReorderPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxReorderPoint.Text, spinReorderPoint1, spinReorderPoint2);
        }

        private void cboxDaysToManufacture_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxDaysToManufacture.Text, spinDaysToManufacture1, spinDaysToManufacture2);
        }

        private void cboxStandardCost_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxStandardCost.Text, spinStandardCost1, spinStandardCost2);
        }

        private void cboxListPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxListPrice.Text, spinListPrice1, spinListPrice2);
        }

        private void cboxProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxProductID.Text, txtProductID);
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

        private void txtProductName_KeyDown(object sender, KeyEventArgs e)
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

                gridView.Focus();
                if (OptionsGrid.GridView.RowCount > 0)
                {
                    gridView.FocusedRowHandle = 0;
                    gridView.SelectRow(0);
                }
            }
        }

        private void frmMedicamentBrowse_Shown(object sender, EventArgs e)
        {
            FocusFilter();
        }

        private void cboxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxCategory.Text, lookCategory);
        }

        private void lookCategory_EditValueChanged(object sender, EventArgs e)
        {
            FilterSubcategory();
        }

        private void miMedicamentLocation_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (OptionsGrid.SelectedRowHandle == -1) return;
            using (var frm = new frmMedicamentLocation())
            {
                frm.PrimaryKey = OptionsGrid.SelectedRecordID;
                frm.ShowDialog();
            }
        }

        private void gridView_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (!e.IsGetData) return;

            var row = OptionsGrid.GridView.GetRow(e.RowHandle);
            switch (e.Column.Name)
            {
                case "col_StandardCost":
                    e.Value = (OptionsListForm.ServerMode ? ((VW_Medicament)row).StandardCost * ((VW_Medicament)row).ProductCurrencyRate : ((DS_Medicament.VW_MedicamentRow)((DataRowView)row).Row).StandardCost * ((DS_Medicament.VW_MedicamentRow)((DataRowView)row).Row).ProductCurrencyRate) / CurrencyRate;
                    break;

                case "col_ListPrice":
                    e.Value = (OptionsListForm.ServerMode ? ((VW_Medicament)row).ListPrice * ((VW_Medicament)row).ProductCurrencyRate : ((DS_Medicament.VW_MedicamentRow)((DataRowView)row).Row).ListPrice * ((DS_Medicament.VW_MedicamentRow)((DataRowView)row).Row).ProductCurrencyRate) / CurrencyRate;
                    break;

                case "col_DealerPrice":
                    e.Value = (OptionsListForm.ServerMode ? ((VW_Medicament)row).DealerPrice * ((VW_Medicament)row).ProductCurrencyRate : ((DS_Medicament.VW_MedicamentRow)((DataRowView)row).Row).DealerPrice * ((DS_Medicament.VW_MedicamentRow)((DataRowView)row).Row).ProductCurrencyRate) / CurrencyRate;
                    break;
            }
        }

        private void lookCurrency_EditValueChanged(object sender, EventArgs e)
        {
            if (OptionsBaseForm.IsLoading) return;

            InitCurrencyRate();
        }

    }
}