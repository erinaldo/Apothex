using Apothex.Windows.Forms;
using Apothex.DataManagment.Sales;
using Zek.Core;

namespace Apothex.Sales
{
    public partial class frmNomination : frmBrowse
    {
        public frmNomination()
        {
            InitializeComponent();
            dateEdit1.DateTime = dateEdit2.DateTime = BaseGlobalVariable.ServerDateTime.Date;
        }


        protected override void BindGrid()
        {
            grid.DataSource = SalesManager.GetNomination(dateEdit1.DateTime, dateEdit2.DateTime);
        }

    }
}