using System;
using System.Data.SqlClient;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Zek.Data;
using Zek.Windows.Forms;

namespace Apothex.Card
{
    public partial class frmCardTypeBrowse : frmBrowse
    {
        public frmCardTypeBrowse()
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

                    sql = SqlFilterHelper.GetWhereClause("Name", cboxName.Text, true, txtName.Text.Trim());
                    if (sql.Length > 0) cmd.CommandText += " WHERE " + sql;
                }

                cmd.CommandText += " ORDER BY ModifiedDate DESC";

                ds.VW_CardType.Clear();
                ds.VW_CardType.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }

        private void cboxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxName.Text, txtName);
        }
    }
}
