using System;
using Apothex.DataType;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Person;
using Apothex.DataManagment.Dictionary;
using Zek.Core;
using Zek.Data;

namespace Apothex.Person
{
    public partial class frmCompanyEdit : frmEditBrowse
    {
        public frmCompanyEdit()
        {
            InitializeComponent();
        }

        #region Properties
        public int CompanyID
        {
            get { return ConvertHelper.ToInt32(PrimaryKey); }
            set { PrimaryKey = value; txtID.Text = value.ToString(); }
        }
        public string companyName
        {
            get { return txtCompanyName.Text.Trim(); }
            set { txtCompanyName.Text = value; }
        }
        public string TaxCode
        {
            get { return txtTaxCode.Text.Trim(); }
            set { txtTaxCode.Text = value; }
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
        public string CountryCode
        {
            get { return ConvertHelper.ToString(lookCountry.EditValue); }
            set { lookCountry.EditValue = value; }
        }
        public string Address
        {
            get { return txtAddress.Text.Trim(); }
            set { txtAddress.Text = value; }
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
        public string Note
        {
            get { return memoNote.Text.Trim(); }
            set { memoNote.Text = value; }
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

        #region Binding
        protected override void BindControls()
        {
            bsCountry.DataSource = DictionaryManager.GetDictionary(ObjectNames.Country);
            bsBank.DataSource = DictionaryManager.GetDictionary(ObjectNames.Bank);

        }
        protected override void BindData()
        {
            if (Action == DatabaseAction.Edit)
            {
                var table = PersonManager.GetCompany(CompanyID);
                if (table.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.");

                CompanyID = table[0].CompanyID;
                companyName = table[0].Name;
                TaxCode = table[0].TaxCode;
                Phone = table[0].Phone;
                Fax = table[0].Fax;
                CountryCode = table[0].CountryCode;
                Address = table[0].Address;
                BankID = table[0].BankID;
                BankAccountNumber = table[0].BankAccountNumber;
                Note = table[0].Note;

                Status = (DatabaseStatus)table[0].Status;
                ModifiedUserID = table[0].ModifiedUserID;
                ModifiedDate = table[0].ModifiedDate;
                ApproverUserID = table[0].ApproverUserID;
            }
            else
            {
                ModifiedUserID = BaseGlobalVariable.UserID;
                ModifiedDate = BaseGlobalVariable.ServerDateTime;
            }
        }
        #endregion

        #region Methods
        protected override void Init()
        {
            base.Init();

            txtCompanyName.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
            txtTaxCode.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
            txtPhone.Properties.ReadOnly = OptionsBaseForm.ReadOnly;

            txtFax.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
            lookCountry.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
            txtAddress.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
            lookBank.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
            txtBankAccountNumber.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
            memoNote.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
        }
        protected override bool SaveData()
        {
            var id = PersonManager.AddOrEditCompany(CompanyID, companyName, TaxCode, Phone, Fax, CountryCode, Address, BankID, BankAccountNumber, Note, (byte)Status, ModifiedUserID, ModifiedDate, ApproverUserID, (byte)Action);
            if (id > 0) CompanyID = id;
            return (id > 0);
        }
        #endregion

        #region Validations
        public bool IsValidCompanyName()
        {
            if (companyName.Length == 0)
            {
                dxErrorProvider.SetError(txtCompanyName, "გთხოვთ შეიყვანოთ კომპანიის დასახელება!");
                return false;
            }


            if (!PersonManager.IsValidCompanyName(CompanyID, companyName))
            {
                dxErrorProvider.SetError(txtCompanyName, "ესეთი კომპანიის დასახელებით უკვე არსებობს ჩანაწერი.");
                return false;
            }
            

            return true;
        }
        protected override bool IsValidForm()
        {
            var ok = true;
            if (!IsValidCompanyName()) ok = false;

            return ok;
        }
        #endregion

        private void txtCompanyName_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtCompanyName, string.Empty);
        }
    }
}