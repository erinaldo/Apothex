using System;
using Apothex.DataType;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Zek.Core;
using Zek.Data;

namespace Apothex.Dictionary
{
    public partial class frmMedicamentSubcategoryEdit : frmEditBrowse
    {
        public frmMedicamentSubcategoryEdit()
        {
            InitializeComponent();
        }

        #region Properties
        public int MedicamentSubcategoryID
        {
            get { return ConvertHelper.ToInt32(PrimaryKey); }
            set { PrimaryKey = value; txtID.Text = value.ToString(); }
        }
        public int MedicamentCategoryID
        {
            get { return ConvertHelper.ToInt32(lookMedicamentCategory.EditValue); }
            set { lookMedicamentCategory.EditValue = value.ToString(); }
        }
        public string MedicamentSubcategoryName
        {
            get { return txtMedicamentSubcategoryName.Text.Trim(); }
            set { txtMedicamentSubcategoryName.Text = value; }
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
            bsMedicamentCategory.DataSource = DictionaryManager.GetDictionary(ObjectNames.MedicamentCategory);
        }
        protected override void BindData()
        {
            if (Action == DatabaseAction.Edit)
            {
                var table = DictionaryManager.GetMedicamentSubcategory(MedicamentSubcategoryID);
                if (table.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.");

                MedicamentSubcategoryID = table[0].MedicamentSubcategoryID;
                MedicamentCategoryID = table[0].MedicamentCategoryID;
                MedicamentSubcategoryName = table[0].Name;

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

            lookMedicamentCategory.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
            txtMedicamentSubcategoryName.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
        }
        protected override bool SaveData()
        {
            var id = DictionaryManager.AddOrEditMedicamentSubcategory(MedicamentSubcategoryID, MedicamentCategoryID, MedicamentSubcategoryName, Status, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, ApproverUserID, Action);
            if (id > 0) MedicamentSubcategoryID = id;
            return (id > 0);
        }
        #endregion

        #region Validations
        public bool IsValidMedicamentCategory()
        {
            if (MedicamentCategoryID == 0)
            {
                dxErrorProvider.SetError(lookMedicamentCategory, "გთხოვთ აირჩიოთ მედიკამენტის კატეგორია.");
                return false;
            }

            return true;
        }
        public bool IsValidMedicamentSubcategoryName()
        {
            if (MedicamentSubcategoryName.Length == 0)
            {
                dxErrorProvider.SetError(txtMedicamentSubcategoryName, "გთხოვთ შეიყვანოთ მედიკამენტის ქვეკატეგორიის დასახელება.");
                return false;
            }

            if (!DictionaryManager.IsValidMedicamentSubcategoryName(MedicamentSubcategoryID, MedicamentCategoryID, MedicamentSubcategoryName))
            {
                dxErrorProvider.SetError(txtMedicamentSubcategoryName, "ესეთი მედიკამენტის კატეგორიის სახელით უკვე არსებობს ჩანაწერი.");
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var ok = true;
            if (!IsValidMedicamentCategory()) ok = false;
            if (!IsValidMedicamentSubcategoryName()) ok = false;

            return ok;
        }
        #endregion

        private void lookMedicamentCategory_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(lookMedicamentCategory, string.Empty);
        }

        private void txtMedicamentSubcategoryName_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtMedicamentSubcategoryName, string.Empty);
        }
    }
}