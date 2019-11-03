using System.Data;
using System.Data.SqlClient;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Zek.Data;

namespace Apothex.Dictionary
{
    public partial class frmCurrencyBrowse : frmBrowse
    {
        public frmCurrencyBrowse()
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
  FROM [Dictionary].[VW_Currency] WITH (NOLOCK)
  WHERE [Status]" + (IsApprovedChecked ? "<>" : "=") + ((byte)DatabaseStatus.Pending).ToString();

                if (IsFiltered)
                {
                    if (txtCurrencyCode.Text.Trim().Length > 0)
                    {
                        cmd.CommandText += " AND [CurrencyCode] LIKE '%'+@CurrencyCode+'%'";
                        cmd.Parameters.Add("@CurrencyCode", SqlDbType.NChar).Value = txtCurrencyCode.Text.Trim();
                    }

                    if (txtCurrencyName.Text.Trim().Length > 0)
                    {
                        cmd.CommandText += " AND [Name] LIKE '%'+@Name+'%'";
                        cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtCurrencyName.Text.Trim();
                    }
                }

                cmd.CommandText += " ORDER BY [ModifiedDate] DESC";

                ds.VW_Currency.Clear();
                ds.VW_Currency.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }
    }
}