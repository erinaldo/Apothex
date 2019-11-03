using System;
using System.Data;
using System.Data.SqlClient;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;

namespace Apothex.Person
{
    public partial class frmPersonCategoryBrowse : frmBrowse
    {
        public frmPersonCategoryBrowse()
        {
            InitializeComponent();
        }

        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = SelectAllFromTable;

                if (IsFiltered)
                {
                    var sql = string.Empty;

                    sql = FilterHelper.CreateFilter("Name", cboxName.Text, txtName.Text.Trim(), SqlDbType.NVarChar, cmd);
                    if (sql.Length > 0) cmd.CommandText += " WHERE " + sql;
                }

                cmd.CommandText += " ORDER BY ModifiedDate DESC";

                ds.VW_PersonCategory.Clear();
                ds.VW_PersonCategory.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }

        private void cboxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxName.Text, txtName);
        }
    }
}
