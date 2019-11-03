using System;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Zek.Core;
using Zek.Data;

namespace Apothex.Dictionary
{
    public partial class frmBankEdit : frmEditBrowse
    {
        public frmBankEdit()
        {
            InitializeComponent();
        }

        #region Properties
        public int BankID
        {
            get { return ConvertHelper.ToInt32(PrimaryKey); }
            set { PrimaryKey = value; txtID.Text = value.ToString(); }
        }
        public string BankName
        {
            get { return txtBankName.Text.Trim(); }
            set { txtBankName.Text = value; }
        }
        public string BankCode
        {
            get { return txtBankCode.Text.Trim(); }
            set { txtBankCode.Text = value; }
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
        protected override void BindData()
        {
            if (Action == DatabaseAction.Edit)
            {
                var table = DictionaryManager.GetBank(BankID);
                if (table.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.");

                BankID = table[0].BankID;
                BankName = table[0].Name;
                BankCode = table[0].BankCode;

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

            txtBankName.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
            txtBankCode.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
        }
        protected override bool SaveData()
        {
            var id = DictionaryManager.AddOrEditBank(BankID, BankName, BankCode, Status, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, ApproverUserID, Action);
            if (id > 0) BankID = id;
            return (id > 0);
        }
        #endregion

        #region Validations
        public bool IsValidBankName()
        {
            if (BankName.Length == 0)
            {
                dxErrorProvider.SetError(txtBankName, "გთხოვთ შეიყვანოთ ბანის სახელი.");
                return false;
            }

            if (!DictionaryManager.IsValidBankName(BankID, BankName))
            {
                dxErrorProvider.SetError(txtBankName, "ესეთი ბანკის სახელით უკვე არსებობს ჩანაწერი.");
                return false;
            }

            return true;
        }
        public bool IsValidBankCode()
        {
            if (BankCode.Length == 0)
            {
                dxErrorProvider.SetError(txtBankCode, "გთხოვთ შეიყვანოთ ბანის კოდი.");
                return false;
            }

            if (!DictionaryManager.IsValidBankCode(BankID, BankCode))
            {
                dxErrorProvider.SetError(txtBankName, "ესეთი ბანკის სახელით უკვე არსებობს ჩანაწერი.");
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var ok = true;
            if (!IsValidBankName()) ok = false;
            if (!IsValidBankCode()) ok = false;

            return ok;
        }
        #endregion

        private void txtBankName_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtBankName, string.Empty);
        }

        private void txtBankCode_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtBankCode, string.Empty);
        }
    }
}