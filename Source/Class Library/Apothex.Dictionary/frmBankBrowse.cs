using System;
using System.Data;
using System.Data.SqlClient;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;

namespace Apothex.Dictionary
{
    public partial class frmBankBrowse : frmBrowse
    {
        public frmBankBrowse()
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
FROM Dictionary.VW_Bank WITH (NOLOCK)
WHERE " + FilterStatusSql;
                if (IsFiltered)
                {
                    var sql = string.Empty;

                    sql = FilterHelper.CreateFilter("Name", cboxBankName.Text, txtBankName.Text.Trim(), SqlDbType.NVarChar, cmd);
                    if (sql.Length > 0) cmd.CommandText += " AND " + sql;


                    sql = FilterHelper.CreateFilter("BankCode", cboxBankCode.Text, txtBankCode.Text.Trim(), SqlDbType.NVarChar, cmd);
                    if (sql.Length > 0) cmd.CommandText += " AND " + sql;
                }

                cmd.CommandText += " ORDER BY ModifiedDate DESC";

                ds.VW_Bank.Clear();
                ds.VW_Bank.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }

        private void cboxBankName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxBankName.Text, txtBankName);
        }

        private void cboxBankCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxBankCode.Text, txtBankCode);
        }
    }
}