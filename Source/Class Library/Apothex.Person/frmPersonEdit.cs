using System;
using Apothex.DataType;
using Apothex.Windows.Forms;
using Zek.Data;
using Zek.Properties;
using Apothex.DataManagment.Dictionary;
using Apothex.DataManagment.Person;
using Zek.Core;
using Zek.Windows.Forms.DevEx;
using Zek.Validation;

namespace Apothex.Person
{
    public partial class frmPersonEdit : frmEditBrowse
    {
        public frmPersonEdit()
        {
            InitializeComponent();
        }

        #region Properties
        public int ID
        {
            get { return ConvertHelper.ToInt32(PrimaryKey); }
            set { PrimaryKey = value; txtID.Text = value.ToString(); }
        }
        public string FirstName
        {
            get { return txtFirstName.Text.Trim(); }
            set { txtFirstName.Text = value; }
        }
        public string LastName
        {
            get { return txtLastName.Text.Trim(); }
            set { txtLastName.Text = value; }
        }
        public string PersonalNumber
        {
            get { return txtPersonalNumber.Text.Trim(); }
            set { txtPersonalNumber.Text = value; }
        }
        public int PersonCategoryID
        {
            get { return ConvertHelper.ToInt32(lookPersonCategory.EditValue); }
            set { lookPersonCategory.EditValue = value; }
        }
        public string City
        {
            get { return txtCity.Text.Trim(); }
            set { txtCity.Text = value; }
        }
        public string Address
        {
            get { return txtAddress.Text.Trim(); }
            set { txtAddress.Text = value; }
        }
        public string JobTitle
        {
            get { return txtJobTitle.Text.Trim(); }
            set { txtJobTitle.Text = value; }
        }
        public DateTime BirthDate
        {
            get { return ConvertHelper.ToDateTime(dateBirthDate.EditValue).Date; }
            set { dateBirthDate.EditValue = value; }
        }
        public string Phone
        {
            get { return txtPhone.Text.Trim(); }
            set { txtPhone.Text = value; }
        }
        public string Mobile
        {
            get { return txtMobile.Text.Trim(); }
            set { txtMobile.Text = value; }
        }
        public string Email
        {
            get { return txtEmail.Text.Trim(); }
            set { txtEmail.Text = value; }
        }

        public DateTime CreateDate
        {
            get { return ConvertHelper.ToDateTime(dateCreateDate.EditValue); }
            set { dateCreateDate.EditValue = value; }
        }
        public int CreatorID
        {
            get { return ConvertHelper.ToInt32(bbCreator.RecordValue); }
            set { bbCreator.RecordValue = value; }
        }
        public DateTime ModifiedDate
        {
            get { return ConvertHelper.ToDateTime(dateModifiedDate.EditValue); }
            set { dateModifiedDate.EditValue = value; }
        }
        public int ModifierID
        {
            get { return ConvertHelper.ToInt32(bbModifier.RecordValue); }
            set { bbModifier.RecordValue = value; }
        }
        public int ApproverID
        {
            get { return ConvertHelper.ToInt32(bbApprover.RecordValue); }
            set { bbApprover.RecordValue = value; }
        }
        #endregion

        private bool IsValidFirstName()
        {
            if (FirstName.Length == 0)
            {
                SetError(txtFirstName, Exceptions.ValueIsEmtpyErrorText);
                return false;
            }

            return true;
        }
        private bool IsValidPersonalNumber()
        {
            if (PersonalNumber.Length == 0)
            {
                SetError(txtPersonalNumber, Exceptions.ValueIsEmtpyErrorText);
                return false;
            }

            return true;
        }
        private bool IsValidEmail()
        {
            if (Email.Length > 0 && !ValidationHelper.IsValidEmail(Email))
            {
                SetError(txtEmail, "E-mail არასწორი ფორმატისაა.");
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var flag = true;
            if (!IsValidFirstName()) flag = false;
            if (!IsValidPersonalNumber()) flag = false;
            if (!IsValidEmail()) flag = false;
            return flag;
        }

        protected override void Init()
        {
            base.Init();

            XtraControlHelper.SetChildrenReadOnly(tabMain, OptionsBaseForm.ReadOnly);
        }
        protected override void BindControls()
        {
            bsPersonCategory.DataSource = DictionaryManager.GetDictionaryInt(ObjectNames.PersonCategory);
        }
        protected override void BindData()
        {

            if (Action == DatabaseAction.Edit)
            {
                var table = PersonManager.GetPerson(ID);
                if (table.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.");

                ID = table[0].PersonID;
                FirstName = table[0].FirstName;
                LastName = table[0].LastName;
                PersonalNumber = table[0].PersonalNumber;
                PersonCategoryID = table[0].PersonCategoryID;
                City = table[0].City;
                Address = table[0].Address;
                JobTitle = table[0].JobTitle;
                dateBirthDate.EditValue = table[0][table.BirthDateColumn];
                Phone = table[0].Phone;
                Mobile = table[0].Mobile;
                Email = table[0].Email;

                Status = (DatabaseStatus)table[0].StatusID;
                CreateDate = table[0].CreateDate;
                CreatorID = table[0].CreatorID;
                ModifiedDate = table[0].ModifiedDate;
                ModifierID = table[0].ModifierID;
                ApproverID = table[0].ApproverID;
            }
            else
            {
                CreateDate = BaseGlobalVariable.ServerDateTime;
                CreatorID = BaseGlobalVariable.UserID;
                ModifiedDate = BaseGlobalVariable.ServerDateTime;
                ModifierID = BaseGlobalVariable.UserID;
            }
        }
        protected override bool SaveData()
        {
            var id = PersonManager.AddOrEditPerson(ID, FirstName, LastName, PersonalNumber, PersonCategoryID, City, Address, JobTitle, BirthDate, Phone, Mobile, Email, BaseGlobalVariable.UserID, Action);
            if (id > 0) ID = id;
            return id > 0;
        }

        private void txtEmail_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(txtEmail);
        }

        private void txtFirstName_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(txtFirstName);
        }

        private void txtPersonalNumber_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(txtPersonalNumber);
        }
    }
}
