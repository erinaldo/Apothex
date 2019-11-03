using System;
using System.Data;
using System.Data.SqlClient;
using Apothex.DataType;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Zek.Windows.Forms;

namespace Apothex.Person
{
    public partial class frmPersonBrowse : frmBrowse
    {
        public frmPersonBrowse()
        {
            InitializeComponent();
        }

        protected override void BindControls()
        {
            bsPersonCategory.DataSource = DictionaryManager.GetDictionaryInt(ObjectNames.PersonCategory);
            lookBranch.Properties.DataSource = DictionaryManager.GetDictionaryInt(ObjectNames.Branch, -1);
        }
        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = SelectAllFromTableWhereStatus;
                if (IsFiltered)
                {
                    string filter = FilterHelper.CreateFilter("BranchID", "=", lookBranch.EditValue, SqlDbType.Int, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("FullName", cboxFullName.Text, txtFullName.Text, SqlDbType.NVarChar, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("PersonalNumber", cboxPersonalNumber.Text, txtPersonalNumber.Text, SqlDbType.NVarChar, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("PersonCategoryID", cboxPersonCategory.Text, lookPersonCategory.EditValue, SqlDbType.Int, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("City", cboxCity.Text, txtCity.Text.Trim(), SqlDbType.NVarChar, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("Address", cboxAddress.Text, txtAddress.Text, SqlDbType.NVarChar, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                }
                cmd.CommandText += " ORDER BY ModifiedDate DESC, PersonID DESC";
                ds.VW_Person.Clear();
                ds.VW_Person.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }

        private void cboxFullName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxFullName.Text, txtFullName);
        }

        private void cboxPersonalNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxPersonalNumber.Text, txtPersonalNumber);
        }

        private void cboxPersonCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxPersonCategory.Text, lookPersonCategory);
        }

        private void cboxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxCity.Text, txtCity);
        }

        private void cboxAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxAddress.Text, txtAddress);
        }
    }
}
