using System;
using Apothex.Windows.Forms;
using Zek.Core;
using Apothex.DataManagment.Person;
using Zek.Data;

namespace Apothex.Person
{
    public partial class frmPersonCategoryEdit : frmEditBrowse
    {
        public frmPersonCategoryEdit()
        {
            InitializeComponent();
        }

        #region Properties
        public int ID
        {
            get { return ConvertHelper.ToInt32(PrimaryKey); }
            set { PrimaryKey = value; txtID.Text = value.ToString(); }
        }
        public string PersonCategoryName
        {
            get { return txtName.Text.Trim(); }
            set { txtName.Text = value; }
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
        #endregion

        #region Bindings
        protected override void BindData()
        {
            if (Action == DatabaseAction.Edit)
            {
                var table = PersonManager.GetPersonCategory(ID);
                if (table.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.");

                ID = table[0].PersonCategoryID;
                PersonCategoryName = table[0].Name;

                //Status = (Zek.Data.Statuses)table[0].Status;
                CreateDate = table[0].CreateDate;
                CreatorID = table[0].CreatorID;
                ModifiedDate = table[0].ModifiedDate;
                ModifierID = table[0].ModifierID;
            }
            else
            {
                CreateDate = BaseGlobalVariable.ServerDateTime;
                CreatorID = BaseGlobalVariable.UserID;
                ModifiedDate = BaseGlobalVariable.ServerDateTime;
                ModifierID = BaseGlobalVariable.UserID;
            }
        }
        #endregion

        #region Methods
        protected override void Init()
        {
            base.Init();

            txtName.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
        }
        protected override bool SaveData()
        {
            var id = PersonManager.AddOrEditPersonCategory(ID, PersonCategoryName, BaseGlobalVariable.UserID, Action);
            if (id > 0) ID = id;
            return (id > 0);
        }
        #endregion

        #region Validations
        public bool IsValidBrandName()
        {
            if (PersonCategoryName.Length == 0)
            {
                SetError(txtName, "გთხოვთ შეიყვანოთ ბრენდის დასახელება.");
                return false;
            }

            if (!PersonManager.IsValidPersonCategoryName(ID, PersonCategoryName))
            {
                SetError(txtName, "ესეთი ბრენდის სახელით უკვე არსებობს ჩანაწერი.");
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var ok = true;
            if (!IsValidBrandName()) ok = false;

            return ok;
        }
        #endregion

        private void txtName_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(txtName);
        }
    }
}
