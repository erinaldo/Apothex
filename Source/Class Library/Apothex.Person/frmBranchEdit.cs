using System;
using Apothex.Windows.Forms;
using Zek.Core;
using Apothex.DataManagment.Branch;
using Zek.Data;
using Zek.Properties;
using Zek.Windows.Forms.DevEx;

namespace Apothex.Person
{
    public partial class frmBranchEdit : frmEditBrowse
    {
        public frmBranchEdit()
        {
            InitializeComponent();
        }

        #region Properties
        public int? ID
        {
            get { return ConvertHelper.ToNullableInt32(PrimaryKey); }
            set { PrimaryKey = value; txtID.Text = value.ToString(); }
        }
        public int? CompanyID
        {
            get { return ConvertHelper.ToNullableInt32(bbCompany.RecordValue); }
            set { bbCompany.RecordValue = value; }
        }
        public string Code
        {
            get { return txtCode.Text.Trim(); }
            set { txtCode.Text = value; }
        }
        public string BranchName
        {
            get { return txtBranchName.Text.Trim(); }
            set { txtBranchName.Text = value; }
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
        public string ActFormat
        {
            get { return txtActFormat.Text.Trim(); }
            set { txtActFormat.Text = value; }
        }

        public int ModifierID
        {
            get { return ConvertHelper.ToInt32(bbModifier.RecordValue); }
            set { bbModifier.RecordValue = value; }
        }
        public DateTime ModifiedDate
        {
            get { return ConvertHelper.ToDateTime(dateModifiedDate.EditValue); }
            set { dateModifiedDate.EditValue = value; }
        }
        public int ApproverID
        {
            get { return ConvertHelper.ToInt32(bbApprover.RecordValue); }
            set { bbApprover.RecordValue = value; }
        }
        #endregion

        #region Binding
        protected override void BindData()
        {
            if (ID > 0)
            {
                var table = BranchManager.Get(ID);
                if (table.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.");

                CompanyID = table[0].CompanyID;
                Code = table[0].Code;
                BranchName = table[0].Name;
                Address = table[0].Address;
                Phone = table[0].Phone;
                Fax = table[0].Fax;
                ActFormat = table[0].ActFormat;

                ID = table[0].ID;
                Status = (DatabaseStatus)table[0].StatusID;
                ModifierID = table[0].ModifierID;
                ModifiedDate = table[0].ModifiedDate;
                ApproverID = table[0].ApproverID;
            }
            else
            {
                ModifierID = BaseGlobalVariable.UserID;
                ModifiedDate = BaseGlobalVariable.ServerDateTime;
            }
        }
        #endregion

        #region Methods
        protected override void Init()
        {
            base.Init();

            XtraControlHelper.SetReadOnly(tabMain, ReadOnly);
        }
        protected override bool SaveData()
        {
            var id = BranchManager.Save(ID, Code, BranchName, Address, Phone, Fax, ActFormat, CompanyID, BaseGlobalVariable.UserID);
            if (id > 0) ID = id;
            return (id > 0);
        }
        #endregion

        #region Validations
        public bool IsValidCode()
        {
            if (Code.Length == 0)
            {
                SetError(txtCode, Exceptions.ValueIsEmtpyErrorText);
                return false;
            }

            return true;
        }
        public bool IsValidBranchName()
        {
            if (BranchName.Length == 0)
            {
                dxErrorProvider.SetError(txtBranchName, "გთხოვთ შეიყვანოთ ფილიალის დასახელება.");
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var ok = true;
            if (!IsValidBranchName()) ok = false;

            return ok;
        }
        #endregion

        private void txtBranchName_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtBranchName, string.Empty);
        }
    }
}