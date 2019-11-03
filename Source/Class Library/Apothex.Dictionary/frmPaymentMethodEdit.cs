using System;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Zek.Core;
using Zek.Data;

namespace Apothex.Dictionary
{
    public partial class frmPaymentMethodEdit : frmEditBrowse
    {
        public frmPaymentMethodEdit()
        {
            InitializeComponent();
        }

        #region Properties
        public int PaymentMethodID
        {
            get { return ConvertHelper.ToInt32(PrimaryKey); }
            set { PrimaryKey = value; txtID.Text = value.ToString(); }
        }
        public string PaymentMethodName
        {
            get { return txtPaymentMethodName.Text.Trim(); }
            set { txtPaymentMethodName.Text = value; }
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
                var table = DictionaryManager.GetPaymentMethod(PaymentMethodID);
                if (table.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.");

                PaymentMethodID = table[0].PaymentMethodID;
                PaymentMethodName = table[0].Name;

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

            txtPaymentMethodName.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
        }
        protected override bool SaveData()
        {
            var id = DictionaryManager.AddOrEditPaymentMethod(PaymentMethodID, PaymentMethodName, Status, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, ApproverUserID, Action);
            if (id > 0) PaymentMethodID = id;
            return (id > 0);
        }
        #endregion

        #region Validations
        public bool IsValidPaymentMethodName()
        {
            if (PaymentMethodName.Length == 0)
            {
                dxErrorProvider.SetError(txtPaymentMethodName, "გთხოვთ შეიყვანოთ გადახდის მეთოდის დასახელება.");
                return false;
            }

            if (!DictionaryManager.IsValidPaymentMethodName(PaymentMethodID, PaymentMethodName))
            {
                dxErrorProvider.SetError(txtPaymentMethodName, "ესეთი გადახდის მეთოდის სახელით უკვე არსებობს ჩანაწერი.");
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var ok = true;
            if (!IsValidPaymentMethodName()) ok = false;

            return ok;
        }
        #endregion

        private void txtPaymentMethodName_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtPaymentMethodName, string.Empty);
        }
    }
}