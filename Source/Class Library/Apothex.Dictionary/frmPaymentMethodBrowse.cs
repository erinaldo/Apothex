using System.Data.SqlClient;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Zek.Data;

namespace Apothex.Dictionary
{
    public partial class frmPaymentMethodBrowse : frmBrowse
    {
        public frmPaymentMethodBrowse()
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
  FROM [Dictionary].[VW_PaymentMethod] WITH (NOLOCK)
  WHERE [Status]" + (IsApprovedChecked ? "<>" : "=") + ((byte)DatabaseStatus.Pending).ToString();

                if (IsFiltered)
                {

                }

                cmd.CommandText += " ORDER BY [ModifiedDate] DESC";

                ds.VW_PaymentMethod.Clear();
                ds.VW_PaymentMethod.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }
    }
}