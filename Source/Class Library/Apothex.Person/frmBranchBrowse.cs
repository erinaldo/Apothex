using System;
using System.Data;
using System.Data.SqlClient;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;

namespace Apothex.Person
{
    public partial class frmBranchBrowse : frmBrowse
    {
        public frmBranchBrowse()
        {
            InitializeComponent();
        }

        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = SelectSql +
@"
*
FROM Company.VW_Branch WITH (NOLOCK)
WHERE " + FilterStatusSql;

                if (IsFiltered)
                {
                    var filter = string.Empty;


                    filter = FilterHelper.CreateFilter("BranchName", cboxName.Text, txtName.Text.Trim(), SqlDbType.NVarChar, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;
                }

                cmd.CommandText += " ORDER BY ModifiedDate DESC";

                ds.VW_Branch.Clear();
                ds.VW_Branch.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }

        private void cboxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxName.Text, txtName);
        }
    }
}