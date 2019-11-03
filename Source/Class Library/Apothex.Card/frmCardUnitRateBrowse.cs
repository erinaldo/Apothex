using System.Data.SqlClient;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;

namespace Apothex.Card
{
    public partial class frmCardUnitRateBrowse : frmBrowse
    {
        public frmCardUnitRateBrowse()
        {
            InitializeComponent();
        }

        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = SelectAllFromTable;

                ds.VW_CardUnitRate.Clear();
                ds.VW_CardUnitRate.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }
    }
}
