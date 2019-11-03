using System;
using Apothex.Windows.Forms;
using Zek.Core;

namespace Apothex.Card
{
    public partial class frmCardHandle : frmEditDialog
    {
        public frmCardHandle()
        {
            InitializeComponent();
        }

        public string CardNumber
        {
            get { return StringHelper.MatchReplace(txtCardNumber.Text, "[^a-zA-Z0-9]", string.Empty); }
            set { txtCardNumber.Text = value; }
        }

        protected override void BindData()
        {
            txtCardNumber.Focus();
            txtCardNumber.SelectAll();
        }
        protected override bool IsValidForm()
        {
            if (CardNumber.Length == 0)
            {
                SetError(txtCardNumber, "ბარათის ნომერი ცარიელია");
                return false;
            }

            return true;
        }
        protected override bool SaveData()
        {
            return true;
        }

        private void txtCardNumber_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(txtCardNumber);
        }
    }
}
