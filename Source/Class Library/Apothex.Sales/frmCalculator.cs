using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Apothex.Sales
{
    public partial class frmCalculator : XtraForm
    {
        public frmCalculator(decimal totalDue)
        {
            InitializeComponent();
            spinTotalDue.Value = totalDue;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void spinPayed_EditValueChanged(object sender, EventArgs e)
        {
            var value = spinPayed.Value - spinTotalDue.Value;
            spinReturned.Value = (value > 0m ? value : 0m);
        }

        private void spinPayed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Control && !e.Alt && !e.Shift)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}