using System;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Zek.Core;
using Zek.Data;

namespace Apothex.Dictionary
{
    public partial class frmMedicamentCategoryEdit : frmEditBrowse
    {
        public frmMedicamentCategoryEdit()
        {
            InitializeComponent();
        }

        #region Properties
        public int MedicamentCategoryID
        {
            get { return ConvertHelper.ToInt32(PrimaryKey); }
            set { PrimaryKey = value; txtID.Text = value.ToString(); }
        }
        public string MedicamentCategoryName
        {
            get { return txtMedicamentCategoryName.Text.Trim(); }
            set { txtMedicamentCategoryName.Text = value; }
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
                var table = DictionaryManager.GetMedicamentCategory(MedicamentCategoryID);
                if (table.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.");

                MedicamentCategoryID = table[0].MedicamentCategoryID;
                MedicamentCategoryName = table[0].Name;

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

            txtMedicamentCategoryName.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
        }
        protected override bool SaveData()
        {
            var id = DictionaryManager.AddOrEditMedicamentCategory(MedicamentCategoryID, MedicamentCategoryName, Status, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, ApproverUserID, Action);
            if (id > 0) MedicamentCategoryID = id;
            return (id > 0);
        }
        #endregion

        #region Validations
        public bool IsValidMedicamentCategoryName()
        {
            if (MedicamentCategoryName.Length == 0)
            {
                dxErrorProvider.SetError(txtMedicamentCategoryName, "გთხოვთ შეიყვანოთ მედიკამენტის კატეგორიის დასახელება.");
                return false;
            }

            if (!DictionaryManager.IsValidMedicamentCategoryName(MedicamentCategoryID, MedicamentCategoryName))
            {
                dxErrorProvider.SetError(txtMedicamentCategoryName, "ესეთი მედიკამენტის კატეგორიის სახელით უკვე არსებობს ჩანაწერი.");
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var ok = true;
            if (!IsValidMedicamentCategoryName()) ok = false;

            return ok;
        }
        #endregion

        private void txtMedicamentCategoryName_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtMedicamentCategoryName, string.Empty);
        }
    }
}