using System.Data.SqlClient;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Zek.Data;

namespace Apothex.Dictionary
{
    public partial class frmMedicamentSubcategoryBrowse : frmBrowse
    {
        public frmMedicamentSubcategoryBrowse()
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
  FROM [Dictionary].[VW_MedicamentSubcategory] WITH (NOLOCK)
  WHERE [Status]" + (IsApprovedChecked ? "<>" : "=") + ((byte)DatabaseStatus.Pending).ToString();

                if (IsFiltered)
                {

                }

                cmd.CommandText += " ORDER BY [ModifiedDate] DESC";

                ds.VW_MedicamentSubcategory.Clear();
                ds.VW_MedicamentSubcategory.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }
    }
}