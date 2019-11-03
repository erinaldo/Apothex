using System;
using Apothex.DataType;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Zek.Core;

namespace Apothex.Production
{
    public partial class frmChangeCurencyCode : frmEditDialog
    {
        public frmChangeCurencyCode()
        {
            InitializeComponent();
        }

        public string ProductCurrencyCode
        {
            get { return ConvertHelper.ToString(lookProductCurrency.EditValue); }
            set { lookProductCurrency.EditValue = value; }
        }
        public bool ChangePrice
        {
            get { return chkChangePrice.Checked; }
            set { chkChangePrice.Checked = value; }
        }

        public bool IsValidCurrency()
        {
            if (ProductCurrencyCode.Length == 0)
            {
                SetError(lookProductCurrency, "მნიშვნელობა არ შეიძლება იყოს ცარიელი.");
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var flag = true;
            if (!IsValidCurrency()) flag = false;

            return flag;
        }
        protected override void BindControls()
        {
            bsProductCurrency.DataSource = DictionaryManager.GetDictionary(ObjectNames.CurrencyWithLastRate);
        }
        protected override bool SaveData()
        {
            return true;
        }

        private void lookProductCurrency_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(lookProductCurrency);
        }
    }
}
