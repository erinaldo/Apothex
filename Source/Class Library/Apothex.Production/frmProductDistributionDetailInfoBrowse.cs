using System;
using System.Data;
using System.Data.SqlClient;
using Apothex.DataType;
using Apothex.Windows.Forms;
using Zek.Core;
using Apothex.DataManagment.Dictionary;

namespace Apothex.Production
{
    public partial class frmProductDistributionDetailInfoBrowse : frmBrowse
    {
        public frmProductDistributionDetailInfoBrowse()
        {
            InitializeComponent();
        }

        //private int _PermissionAllBranch = 0;
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

        protected override void BindControls()
        {
            bsMedicamentCategory.DataSource = DictionaryManager.GetDictionary(ObjectNames.MedicamentCategory);
            bsMedicamentSubcategory.DataSource = DictionaryManager.GetDictionary(ObjectNames.MedicamentSubcategoryWithMedicamentCategoryID);
            bsMedicamentSubcategory.Filter = "Code=" + MedicamentCategoryID.ToString();
        }
        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = SelectSql +
@"
*
FROM Production.VW_ProductDistributionDetailInfo
WHERE " + FilterStatusSql;


                if (IsFiltered)
                {
                    var filter = string.Empty;

                    filter = FilterHelper.CreateFilter("ProductDistributionID", cboxID.Text, txtID.EditValue, SqlDbType.Int, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("StartDate", cboxStartDate.Text, ConvertHelper.ToDateTime(dateStartDate1.EditValue), ConvertHelper.ToDateTime(dateStartDate2.EditValue), RoundingFormat.None, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("FromBranchID", cboxFromBranch.Text, bbFromBranch.RecordValue, SqlDbType.Int, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("ToBranchID", cboxToBranch.Text, bbToBranch.RecordValue, SqlDbType.Int, cmd);
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
                }

                cmd.CommandText += " ORDER BY StartDate DESC, FromBranchID, ToBranchID";
                ds.VW_ProductDistributionDetailInfo.Clear();
                ds.VW_ProductDistributionDetailInfo.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }
        //protected override void Init()
        //{
        //    base.Init();

            //_PermissionAllBranch = GlobalVariable.GetPermission((int)Apothex.DataType.ObjectNames.SalesOrderDetailInfoAllBranch);
            //lookBranch.Properties.ReadOnly = !IsAllowed(_PermissionAllBranch, Zek.Data.DatabaseActions.View);
        //}

        private void cboxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxID.Text, txtID);
        }

        private void cboxFromBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxFromBranch.Text, bbFromBranch);
        }

        private void cboxToBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxToBranch.Text, bbToBranch);
        }

        private void cboxStartDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxStartDate.Text, dateStartDate1, dateStartDate2);
        }

        private void cboxMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxMedicament.Text, txtMedicament);
        }

        private void cboxValidDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxValidDate.Text, dateValidDate1, dateValidDate2);
        }

        private void lookMedicamentCategory_EditValueChanged(object sender, EventArgs e)
        {
            lookMedicamentSubcategory.EditValue = null;
            bsMedicamentSubcategory.Filter = "Code=" + MedicamentCategoryID.ToString();
        }
    }
}