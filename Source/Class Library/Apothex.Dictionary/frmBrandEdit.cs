using System;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Zek.Core;
using Zek.Data;

namespace Apothex.Dictionary
{
    public partial class frmBrandEdit : frmEditBrowse
    {
        public frmBrandEdit()
        {
            InitializeComponent();
        }

        #region Properties
        public int BrandID
        {
            get { return ConvertHelper.ToInt32(PrimaryKey); }
            set { PrimaryKey = value; txtID.Text = value.ToString(); }
        }
        public string BrandName
        {
            get { return txtBrandName.Text.Trim(); }
            set { txtBrandName.Text = value; }
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
                var table = DictionaryManager.GetBrand(BrandID);
                if (table.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.");

                BrandID = table[0].BrandID;
                BrandName = table[0].Name;

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

            txtBrandName.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
        }
        protected override bool SaveData()
        {
            var id = DictionaryManager.AddOrEditBrand(BrandID, BrandName, Status, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, ApproverUserID, Action);
            if (id > 0) BrandID = id;
            return (id > 0);
        }
        #endregion

        #region Validations
        public bool IsValidBrandName()
        {
            if (BrandName.Length == 0)
            {
                dxErrorProvider.SetError(txtBrandName, "გთხოვთ შეიყვანოთ ბრენდის დასახელება.");
                return false;
            }

            if (!DictionaryManager.IsValidBrandName(BrandID, BrandName))
            {
                dxErrorProvider.SetError(txtBrandName, "ესეთი ბრენდის სახელით უკვე არსებობს ჩანაწერი.");
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

        private void txtBrandName_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(txtBrandName);
        }
    }
}