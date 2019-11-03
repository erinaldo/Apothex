using System.Data.SqlClient;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Zek.Data;

namespace Apothex.Dictionary
{
    public partial class frmUnitMeasureBrowse : frmBrowse
    {
        public frmUnitMeasureBrowse()
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
  FROM [Dictionary].[VW_UnitMeasure] WITH (NOLOCK)
  WHERE [Status]" + (IsApprovedChecked ? "<>" : "=") + ((byte)DatabaseStatus.Pending).ToString();

                if (IsFiltered)
                {

                }

                cmd.CommandText += " ORDER BY [ModifiedDate] DESC";

                ds.VW_UnitMeasure.Clear();
                ds.VW_UnitMeasure.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }
    }
}