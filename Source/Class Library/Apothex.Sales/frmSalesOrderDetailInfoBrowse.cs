using System;
using System.Data;
using System.Data.SqlClient;
using Apothex.Configuration;
using Apothex.Reporting;
using Apothex.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using Zek.Core;
using Apothex.DataManagment.Dictionary;
using Apothex.Common;
using Apothex.DataType;
using Zek.Data;
using Zek.Windows.Forms;

namespace Apothex.Sales
{
    public partial class frmSalesOrderDetailInfoBrowse : frmBrowse
    {
        public frmSalesOrderDetailInfoBrowse()
        {
            InitializeComponent();
        }

        #region Fields
        private int _PermissionAllBranch;
        private int SelectedBranchID
        {
            get
            {
                return (IsPermitted(_PermissionAllBranch, DatabaseAction.View) ? ConvertHelper.ToInt32(lookBranch.EditValue) : GlobalVariable.BranchID);
            }
        }

        public int MedicamentCategoryID
        {
            get { return ConvertHelper.ToInt32(lookMedicamentCategory.EditValue); }
            set { lookMedicamentCategory.EditValue = value.ToString(); }
        }
        public int MedicamentSubcategoryID
        {
            get { return ConvertHelper.ToInt32(lookMedicamentSubcategory.EditValue); }
            set { lookMedicamentSubcategory.EditValue = value.ToString(); }
        }
        public int SelectedMedicamentCategoryID
        {
            get { return ConvertHelper.ToInt32(lookMedicamentSubcategory.GetColumnValue("Code")); }
        }
        #endregion

        #region Bindings
        protected override void BindControls()
        {
            bsBranch.DataSource = DictionaryManager.GetDictionary(ObjectNames.Branch);
            lookBranch.EditValue = GlobalVariable.BranchID.ToString();
            bsCurrency.DataSource = DictionaryManager.GetDictionary(ObjectNames.Currency);
            bsMedicamentCategory.DataSource = DictionaryManager.GetDictionary(ObjectNames.MedicamentCategory);
            bsMedicamentSubcategory.DataSource = DictionaryManager.GetDictionary(ObjectNames.MedicamentSubcategoryWithMedicamentCategoryID);
            bsMedicamentSubcategory.Filter = "Code=" + MedicamentCategoryID.ToString();
            lookProductCurrencyCode.Properties.DataSource = DictionaryManager.GetDictionary(ObjectNames.Currency);
        }
        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = @SelectSql+
@"
*
FROM Sales.VW_SalesOrderDetailInfo
WHERE " + FilterStatusSql;

                if (!IsPermitted(_PermissionAllBranch, DatabaseAction.View))
                {
                    cmd.CommandText += " AND BranchID = @BranchID";
                    cmd.Parameters.Add("@BranchID", SqlDbType.Int).Value = SelectedBranchID;
                }

                if (IsFiltered)
                {
                    if (lookBranch.EditValue != null && IsPermitted(_PermissionAllBranch, DatabaseAction.View))
                    {
                        cmd.CommandText += " AND BranchID = @BranchID";
                        cmd.Parameters.Add("@BranchID", SqlDbType.Int).Value = SelectedBranchID;
                    }


                    var filter = string.Empty;

                    filter = FilterHelper.CreateFilter("SalesOrderID", cboxOrderID.Text, txtOrderID.EditValue, SqlDbType.Int, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("OrderDate", cboxOrderDate.Text, ConvertHelper.ToDateTime(dateOrderDate1.EditValue), ConvertHelper.ToDateTime(dateOrderDate2.EditValue), RoundingFormat.None, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("CustomerID", cboxCustomer.Text, bbCustomer.RecordValue, SqlDbType.Int, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("CurrencyCode", cboxCurrency.Text, ConvertHelper.ToString(lookCurrency.EditValue), SqlDbType.NChar, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("MedicamentName", cboxMedicament.Text, txtMedicament.Text.Trim(), SqlDbType.NVarChar, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    if (lookMedicamentCategory.EditValue != null)
                    {
                        cmd.CommandText += " AND MedicamentCategoryID = @MedicamentCategoryID";
                        cmd.Parameters.Add("@MedicamentCategoryID", SqlDbType.Int).Value = ConvertHelper.ToInt32(lookMedicamentCategory.EditValue);
                    }
                    if (lookMedicamentSubcategory.EditValue != null)
                    {
                        cmd.CommandText += " AND MedicamentSubcategoryID = @MedicamentSubcategoryID";
                        cmd.Parameters.Add("@MedicamentSubcategoryID", SqlDbType.Int).Value = ConvertHelper.ToInt32(lookMedicamentSubcategory.EditValue);
                    }


                    filter = FilterHelper.CreateFilter("ProductCurrencyCode", "=", lookProductCurrencyCode.EditValue, SqlDbType.NChar, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;
                }

                cmd.CommandText += " ORDER BY OrderDate DESC, BranchID";

                ds.VW_SalesOrderDetailInfo.Clear();
                ds.VW_SalesOrderDetailInfo.Merge(DictionaryManager.GetDataTable(cmd, ConfigurationManagerEx.IsOnline));
            }
        }
        #endregion

        #region Validations
        private bool IsValidOrderDate()
        {
            if (cboxOrderDate.Text == "[ ]" && dateOrderDate1.EditValue != null && dateOrderDate2.EditValue != null && dateOrderDate1.DateTime > dateOrderDate2.DateTime)
            {
                dxErrorProvider.SetError(dateOrderDate2, "დასრულების თარიღი უნდა აღემატებოდეს დაწყების თარიღს.");
                return false;
            }

            return true;
        }
        private bool IsValidValidDate()
        {
            if (cboxValidDate.Text == "[ ]" && dateValidDate1.EditValue != null && dateValidDate2.EditValue != null && dateValidDate1.DateTime > dateValidDate2.DateTime)
            {
                dxErrorProvider.SetError(dateValidDate2, "დასრულების თარიღი უნდა აღემატებოდეს დაწყების თარიღს.");
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var ok = true;

            if (!IsValidOrderDate()) ok = false;
            if (!IsValidValidDate()) ok = false;

            return ok;
        }
        #endregion

        #region Methods
        protected override void Init()
        {
            base.Init();

            _PermissionAllBranch = GlobalVariable.GetPermission((int)ObjectNames.SalesOrderDetailInfoAllBranch);

            lookBranch.Properties.ReadOnly = !IsPermitted(_PermissionAllBranch, DatabaseAction.View);
        }
        protected override void Print()
        {
            ReportFactory.Show(MdiParent, Text, ObjectName, ds.VW_SalesOrderDetailInfo);
        }
        #endregion

        private void cboxCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxCurrency.Text, lookCurrency);
        }

        private void cboxOrderDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxOrderDate.Text, dateOrderDate1, dateOrderDate2);
            SetError(dateOrderDate1, string.Empty);
            SetError(dateOrderDate2, string.Empty);
        }

        private void dateOrderDate1_EditValueChanged(object sender, EventArgs e)
        {
            SetError(dateOrderDate1, string.Empty);
            SetError(dateOrderDate2, string.Empty);
        }

        private void dateOrderDate2_EditValueChanged(object sender, EventArgs e)
        {
            SetError(dateOrderDate1, string.Empty);
            SetError(dateOrderDate2, string.Empty);
        }

        private void lookMedicamentCategory_EditValueChanged(object sender, EventArgs e)
        {
            lookMedicamentSubcategory.EditValue = null;
            bsMedicamentSubcategory.Filter = "Code=" + MedicamentCategoryID.ToString();
        }

        private void cboxMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxMedicament.Text, txtMedicament);
        }

        private void cboxValidDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxValidDate.Text, dateValidDate1, dateValidDate2);
            SetError(dateValidDate1, string.Empty);
            SetError(dateValidDate2, string.Empty);
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

        private void cboxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxCustomer.Text, bbCustomer);
        }

        private void cboxOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxOrderID.Text, txtOrderID);
        }

        private void gridView_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (!e.IsGetData) return;

            var row = ds.VW_SalesOrderDetailInfo[e.ListSourceRowIndex];

            if (e.Column == col_StandardCostLineTotal)
                e.Value = row.StandardCost * row.SaleQty;
            else if (e.Column == col_ListPriceLineTotal)
                e.Value = row.ListPrice * row.SaleQty;
        }

    }
}