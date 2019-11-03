using System;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Zek.Core;
using Zek.Data;

namespace Apothex.Dictionary
{
    public partial class frmUnitMeasureEdit : frmEditBrowse
    {
        public frmUnitMeasureEdit()
        {
            InitializeComponent();
        }

        #region Properties
        public string UnitMeasureCodeOld
        {
            get { return ConvertHelper.ToString(PrimaryKey); }
            set { PrimaryKey = value; txtID.Text = value; }
        }
        public string UnitMeasureCodeNew
        {
            get { return txtUnitMeasureCode.Text; }
            set { txtUnitMeasureCode.Text = value; }
        }
        public string UnitMeasureName
        {
            get { return txtUnitMeasureName.Text.Trim(); }
            set { txtUnitMeasureName.Text = value; }
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
                var table = DictionaryManager.GetUnitMeasure(UnitMeasureCodeOld);
                if (table.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.");

                UnitMeasureCodeNew = table[0].UnitMeasureCode;
                UnitMeasureCodeOld = table[0].UnitMeasureCode;
                UnitMeasureName = table[0].Name;

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

            txtUnitMeasureCode.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
            txtUnitMeasureName.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
        }
        protected override bool SaveData()
        {
            var id = DictionaryManager.AddOrEditUnitMeasure(UnitMeasureCodeOld, UnitMeasureCodeNew, UnitMeasureName, Status, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, ApproverUserID, Action);
            UnitMeasureCodeOld = UnitMeasureCodeNew;
            return (id > 0);
        }
        #endregion

        #region Validations
        public bool IsValidUnitMeasureCode()
        {
            if (UnitMeasureCodeNew.Length == 0)
            {
                dxErrorProvider.SetError(txtUnitMeasureCode, "გთხოვთ შეიყვანოთ ზომის ერთეულის კოდი.");
                return false;
            }

            if (!DictionaryManager.IsValidUnitMeasureCode(UnitMeasureCodeOld, UnitMeasureCodeNew))
            {
                dxErrorProvider.SetError(txtUnitMeasureCode, "ესეთი ზომის ერთეულის კოდით უკვე არსებობს ჩანაწერი.");
                return false;
            }

            return true;
        }
        public bool IsValidUnitMeasureName()
        {
            if (UnitMeasureName.Length == 0)
            {
                dxErrorProvider.SetError(txtUnitMeasureName, "გთხოვთ შეიყვანოთ ზომის ერთეულის დასახელება.");
                return false;
            }

            if (!DictionaryManager.IsValidUnitMeasureName(UnitMeasureCodeOld, UnitMeasureName))
            {
                dxErrorProvider.SetError(txtUnitMeasureName, "ესეთი ზომის ერთეულის დასახელებით უკვე არსებობს ჩანაწერი.");
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var ok = true;
            if (!IsValidUnitMeasureCode()) ok = false;
            if (!IsValidUnitMeasureName()) ok = false;

            return ok;
        }
        #endregion

        private void txtUnitMeasureCode_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtUnitMeasureCode, string.Empty);
        }

        private void txtUnitMeasureName_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtUnitMeasureName, string.Empty);
        }
    }
}