using System;
using System.Data;
using System.Data.SqlClient;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Zek.Data;

namespace Apothex.Dictionary
{
    public partial class frmBrandBrowse : frmBrowse
    {
        public frmBrandBrowse()
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
  FROM Dictionary.VW_Brand WITH (NOLOCK)
  WHERE Status" + (IsApprovedChecked ? "<>" : "=") + ((byte)DatabaseStatus.Pending).ToString();

                if (IsFiltered)
                {
                    var sql = string.Empty;

                    sql = FilterHelper.CreateFilter("Name", cboxBrandName.Text, txtBrandName.Text.Trim(), SqlDbType.NVarChar, cmd);
                    if (sql.Length > 0) cmd.CommandText += " AND " + sql;
                }

                cmd.CommandText += " ORDER BY ModifiedDate DESC";

                ds.VW_Brand.Clear();
                ds.VW_Brand.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }

        private void cboxBrandName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxBrandName.Text, txtBrandName);
        }
    }
}