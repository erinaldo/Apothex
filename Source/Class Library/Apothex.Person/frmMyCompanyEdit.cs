using System;
using Apothex.DataType;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Person;
using Zek.Core;
using Apothex.DataManagment.Dictionary;
using Zek.Data;

namespace Apothex.Person
{
    public partial class frmMyCompanyEdit : frmEditBrowse
    {
        public frmMyCompanyEdit()
        {
            InitializeComponent();
        }
        
        #region Properties
        public int MyCompanyID
        {
            get { return ConvertHelper.ToInt32(PrimaryKey); }
            set { PrimaryKey = value; txtID.Text = value.ToString(); }
        }
        public string MyCompanyName
        {
            get { return txtCompanyName.Text.Trim(); }
            set { txtCompanyName.Text = value; }
        }
        public string TaxCode
        {
            get { return txtTaxCode.Text.Trim(); }
            set { txtTaxCode.Text = value; }
        }
        public string DirectorName
        {
            get { return txtDirectorName.Text.Trim(); }
            set { txtDirectorName.Text = value; }
        }
        public string CountryCode
        {
            get { return ConvertHelper.ToString(lookCountry.EditValue); }
            set { lookCountry.EditValue = value; }
        }
        public string City
        {
            get { return txtCity.Text.Trim(); }
            set { txtCity.Text = value; }
        }
        public string PostalCode
        {
            get { return txtPostalCode.Text.Trim(); }
            set { txtPostalCode.Text = value; }
        }
        public string Address
        {
            get { return txtAddress.Text.Trim(); }
            set { txtAddress.Text = value; }
        }
        public string Phone
        {
            get { return txtPhone.Text.Trim(); }
            set { txtPhone.Text = value; }
        }
        public string Fax
        {
            get { return txtFax.Text.Trim(); }
            set { txtFax.Text = value; }
        }
        public int BankID
        {
            get { return ConvertHelper.ToInt32(lookBank.EditValue); }
            set { lookBank.EditValue = value.ToString(); }
        }
        public string BankAccountNumber
        {
            get { return txtBankAccountNumber.Text.Trim(); }
            set { txtBankAccountNumber.Text = value; }
        }
        public bool VatPayerFlag
        {
            get { return chkVatPayerFlag.Checked; }
            set { chkVatPayerFlag.Checked = value; }
        }
        public string ConditionalUnitCurrencyCode
        {
            get { return ConvertHelper.ToString(lookConditionalUnitCurrencyCode.EditValue); }
            set { lookConditionalUnitCurrencyCode.EditValue = value; }
        }
        public string DefaultTradingCurrencyCode
        {
            get { return ConvertHelper.ToString(lookDefaultTradingCurrencyCode.EditValue); }
            set { lookDefaultTradingCurrencyCode.EditValue = value; }
        }

        public int ModifiedUserID
        {
            get { return ConvertHelper.ToInt32(bbModifier.RecordValue); }
            set { bbModifier.RecordValue = value; }
        }
        public DateTime ModifiedDate
        {
            get { return ConvertHelper.ToDateTime(dateModifiedDate.EditValue); }
            set { dateModifiedDate.EditValue = value; }
        }
        public int ApproverUserID
        {
            get { return ConvertHelper.ToInt32(bbApprover.RecordValue); }
            set { bbApprover.RecordValue = value; }
        }
        #endregion

        #region Bindings
        protected override void BindControls()
        {
            bsCountry.DataSource = DictionaryManager.GetDictionary(ObjectNames.Country);
            bsBank.DataSource = DictionaryManager.GetDictionary(ObjectNames.Bank);

            bsConditionalUnitCurrencyCode.DataSource = DictionaryManager.GetDictionary(ObjectNames.Currency);
            bsDefaultTradingCurrencyCode.DataSource = DictionaryManager.GetDictionary(ObjectNames.Currency);
        }
        protected override void BindData()
        {
            var table = PersonManager.GetMyCompany(MyCompanyID, true);
            if (table.Count > 0) Action = DatabaseAction.Edit;
            if (Action == DatabaseAction.Edit)
            {
                MyCompanyID = table[0].MyCompanyID;
                MyCompanyName = table[0].MyCompanyName;
                TaxCode = table[0].TaxCode;
                DirectorName = table[0].DirectorName;
                CountryCode = table[0].CountryCode;
                City = table[0].City;
                PostalCode = table[0].PostalCode;
                Address = table[0].Address;
                Phone = table[0].Phone;
                Fax = table[0].Fax;
                BankID = table[0].BankID;
                BankAccountNumber = table[0].BankAccountNumber;
                VatPayerFlag = table[0].VATPayerFlag;
                ConditionalUnitCurrencyCode = table[0].ConditionalUnitCurrencyCode;
                DefaultTradingCurrencyCode = table[0].DefaultTradingCurrencyCode;

                ModifiedUserID = table[0].ModifiedUserID;
                ModifiedDate = table[0].ModifiedDate;
            }
            else
            {
                ModifiedUserID = BaseGlobalVariable.UserID;
                ModifiedDate = BaseGlobalVariable.ServerDateTime;
            }
        }
        protected override bool SaveData()
        {
            var id = PersonManager.AddOrEditMyCompany(MyCompanyID, MyCompanyName, TaxCode, DirectorName, CountryCode, City, PostalCode, Address, Phone, Fax, BankID, BankAccountNumber, VatPayerFlag, ConditionalUnitCurrencyCode, DefaultTradingCurrencyCode, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, Action);
            if (id > 0) MyCompanyID = id;
            return (id > 0);
        }
        #endregion

        #region Validations
        public bool IsValidMyCompanyName()
        {
            if (MyCompanyName.Length == 0)
            {
                dxErrorProvider.SetError(txtCompanyName, "გთხოვთ შეიყვანოთ კომპანიის სახელი.");
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var ok = true;
            if (!IsValidMyCompanyName()) ok = false;

            return ok;
        }
        #endregion

        private void txtCompanyName_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtCompanyName, string.Empty);
        }
    }
}