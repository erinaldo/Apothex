using System.Data.SqlClient;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;

namespace Apothex.Card
{
    public partial class frmCardDiscountSchemaBrowse : frmBrowse
    {
        public frmCardDiscountSchemaBrowse()
        {
            InitializeComponent();
        }

        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = SelectAllFromTable;

                ds.VW_CardDiscountSchema.Clear();
                ds.VW_CardDiscountSchema.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }
    }
}
