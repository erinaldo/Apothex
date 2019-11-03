using System;
using System.Data;
using System.Data.SqlClient;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;

namespace Apothex.Dictionary
{
    public partial class frmGenericBrowse : frmBrowse
    {
        public frmGenericBrowse()
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
FROM Dictionary.VW_Generic
WHERE " + FilterStatusSql;

                if (IsFiltered)
                {
                    var filter = string.Empty;                  

                    filter = FilterHelper.CreateFilter("GenericName", cboxName.Text, txtName.Text.Trim(), SqlDbType.NVarChar, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                }

                cmd.CommandText += " ORDER BY ModifiedDate DESC, GenericID DESC";

                ds.VW_Generic.Clear();
                ds.VW_Generic.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }

        private void cboxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxName.Text, txtName);
        }
    }
}