using System;
using Apothex.Windows.Forms;
using Zek.Data;
using Apothex.DataManagment.Dictionary;
using Zek.Core;
using Zek.Windows.Forms.DevEx;

namespace Apothex.Dictionary
{
    public partial class frmGenericEdit : frmEditBrowse
    {
        public frmGenericEdit()
        {
            InitializeComponent();
        }

        #region Properties
        public int GenericID
        {
            get { return ConvertHelper.ToInt32(PrimaryKey); }
            set { PrimaryKey = value; txtID.Text = value.ToString(); }
        }
        public string GenericName
        {
            get { return txtGenericName.Text.Trim(); }
            set { txtGenericName.Text = value; }
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
                var table = DictionaryManager.GetGeneric(GenericID);
                if (table.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.");

                GenericID = table[0].GenericID;
                GenericName = table[0].Name;

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

            XtraControlHelper.SetChildrenReadOnly(tabMain, OptionsBaseForm.ReadOnly);
        }
        protected override bool SaveData()
        {
            var id = DictionaryManager.AddOrEditGeneric(GenericID, GenericName, Status, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, ApproverUserID, Action);
            if (id > 0) GenericID = id;
            return (id > 0);
        }
        #endregion

        #region Validations
        public bool IsValidGenericName()
        {
            if (GenericName.Length == 0)
            {
                dxErrorProvider.SetError(txtGenericName, "გთხოვთ შეიყვანოთ ბრენდის დასახელება.");
                return false;
            }

            if (!DictionaryManager.IsValidGenericName(GenericID, GenericName))
            {
                dxErrorProvider.SetError(txtGenericName, "ესეთი ბრენდის სახელით უკვე არსებობს ჩანაწერი.");
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var ok = true;
            if (!IsValidGenericName()) ok = false;

            return ok;
        }
        #endregion

        private void txtGenericName_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtGenericName, string.Empty);
        }
    }
}