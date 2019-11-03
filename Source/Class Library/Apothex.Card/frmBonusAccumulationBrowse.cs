using Apothex.Windows.Forms;
using Apothex.DataManagment.Card;
using Zek.Core;

namespace Apothex.Card
{
    public partial class frmBonusAccumulationBrowse : frmBrowse
    {
        public frmBonusAccumulationBrowse()
        {
            InitializeComponent();
        }

        protected override void BindControls()
        {
            dateHandle1.EditValue = BaseGlobalVariable.ServerDateTime.Date.AddDays(-1d);
            dateHandle2.EditValue = BaseGlobalVariable.ServerDateTime.Date;
        }
        protected override void BindGrid()
        {
            ds.VW_BonusAccumulation.Clear();
            ds.VW_BonusAccumulation.Merge(CardManager.GetBonusAccumulationVW(ConvertHelper.ToNullableDateTime(dateHandle1.EditValue), ConvertHelper.ToNullableDateTime(dateHandle2.EditValue)));
        }

    }
}