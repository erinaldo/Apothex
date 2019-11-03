using System;
using Apothex.DataType;
using Apothex.Windows.Forms;
using Zek.Core;
using Apothex.DataManagment.Dictionary;
using Apothex.DataManagment.Sales;
using Apothex.Common;
using Zek.Data;

namespace Apothex.Sales
{
    public partial class frmCloseDayEdit : frmEditBrowse
    {
        public frmCloseDayEdit()
        {
            InitializeComponent();
        }

        #region Properties
        public int permissionAllBranch = 0;

        public int CloseDayID
        {
            get { return ConvertHelper.ToInt32(PrimaryKey); }
            set { PrimaryKey = value; txtID.Text = value.ToString(); }
        }
        public int BranchID
        {
            get { return ConvertHelper.ToInt32(lookBranch.EditValue); }
            set { lookBranch.EditValue = value.ToString(); }
        }
        public DateTime CloseDate
        {
            get { return ConvertHelper.ToDateTime(dateCloseDate.EditValue); }
            set { dateCloseDate.EditValue = value; }
        }
        public string Comment
        {
            get { return memoComment.Text.Trim(); }
            set { memoComment.Text = value; }
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
            bsBranch.DataSource = DictionaryManager.GetDictionary(ObjectNames.Branch, -1);
        }
        protected override void BindData()
        {
            if (Action == DatabaseAction.Edit)
            {
                var table = SalesManager.GetCloseDay(CloseDayID);
                if (table.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.");

                CloseDayID = table[0].CloseDayID;
                BranchID = table[0].BranchID;
                CloseDate = table[0].CloseDate;
                Comment = table[0].Comment;

                Status = (DatabaseStatus)table[0].Status;
                ModifiedUserID = table[0].ModifiedUserID;
                ModifiedDate = table[0].ModifiedDate;
                ApproverUserID = table[0].ApproverUserID;
            }
            else
            {
                BranchID = GlobalVariable.BranchID;
                CloseDate = BaseGlobalVariable.ServerDateTime.Date;

                ModifiedUserID = BaseGlobalVariable.UserID;
                ModifiedDate = BaseGlobalVariable.ServerDateTime;
            }
        }
        #endregion;

        #region Validations
        public bool IsValidBranch()
        {
            if (lookBranch.EditValue == null)
            {
                dxErrorProvider.SetError(lookBranch, "გთხოვთ აირჩიოთ ფილიალი.");
                return false;
            }

            return true;
        }
        public bool IsValidCloseDate()
        {
            if (dateCloseDate.EditValue == null)
            {
                dxErrorProvider.SetError(dateCloseDate, "გთხოვთ აირჩიოთ თარიღი.");
                return false;
            }
            if (!SalesManager.IsValidCloseDate(CloseDayID, BranchID, CloseDate))
            {
                dxErrorProvider.SetError(dateCloseDate, "ამ ფილიალში მიმდინარე თარიღზე უკვე არსებობს დღის დახურვის ჩანაწერი.");
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var ok = true;

            if (!IsValidBranch()) ok = false;
            if (!IsValidCloseDate()) ok = false;

            return ok;
        }
        #endregion

        #region Methods
        protected override void Init()
        {
            base.Init();

            permissionAllBranch = GlobalVariable.GetPermission((int)ObjectNames.CloseDayAllBranch);

            OptionsBaseForm.ReadOnly = (OptionsBaseForm.ReadOnly || (BranchID != GlobalVariable.BranchID && !IsPermitted(permissionAllBranch, Action)));

            lookBranch.Properties.ReadOnly = OptionsBaseForm.ReadOnly || !IsPermitted(permissionAllBranch, Action);
            dateCloseDate.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
            memoComment.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
        }
        protected override bool SaveData()
        {
            var id = SalesManager.AddOrEditCloseDay(CloseDayID, BranchID, CloseDate, Comment, Status, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, ApproverUserID, Action);
            if (id > 0) CloseDayID = id;
            return (id > 0);
        }
        #endregion

        private void lookBranch_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(lookBranch, string.Empty);
        }

        private void dateCloseDate_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(dateCloseDate, string.Empty);
        }
    }
}