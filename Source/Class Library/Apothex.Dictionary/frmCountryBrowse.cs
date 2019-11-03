using System.Data;
using System.Data.SqlClient;
using Apothex.Reporting;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Zek.Data;

namespace Apothex.Dictionary
{
    public partial class frmCountryBrowse : frmBrowse
    {
        public frmCountryBrowse()
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
  FROM [Dictionary].[VW_Country] WITH (NOLOCK)
  WHERE [Status]" + (IsApprovedChecked ? "<>" : "=") + ((byte)DatabaseStatus.Pending).ToString();

                if (IsFiltered)
                {
                    if (txtCountryCode.Text.Trim().Length > 0)
                    {
                        cmd.CommandText += " AND [CountryCode] LIKE '%'+@CountryCode+'%'";
                        cmd.Parameters.Add("@CountryCode", SqlDbType.NVarChar).Value = txtCountryCode.Text.Trim();
                    }

                    if (txtCountryName.Text.Trim().Length > 0)
                    {
                        cmd.CommandText += " AND [Name] LIKE '%'+@Name+'%'";
                        cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtCountryName.Text.Trim();
                    }
                }

                cmd.CommandText += " ORDER BY [ModifiedDate] DESC";

                ds.VW_Country.Clear();
                ds.VW_Country.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }

        protected override void Print()
        {
            ReportFactory.Show(MdiParent, OptionsBaseForm.Text, ObjectName, ds);
        }
    }
}