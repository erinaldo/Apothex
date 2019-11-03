using System.Data.SqlClient;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Zek.Data;

namespace Apothex.Dictionary
{
    public partial class frmMedicamentCategoryBrowse : frmBrowse
    {
        public frmMedicamentCategoryBrowse()
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
  FROM [Dictionary].[VW_MedicamentCategory] WITH (NOLOCK)
  WHERE [Status]" + (IsApprovedChecked ? "<>" : "=") + ((byte)DatabaseStatus.Pending).ToString();

                if (IsFiltered)
                {

                }

                cmd.CommandText += " ORDER BY [ModifiedDate] DESC";

                ds.VW_MedicamentCategory.Clear();
                ds.VW_MedicamentCategory.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }
    }
}