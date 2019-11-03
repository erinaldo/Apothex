using System;
using Apothex.DataType;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using DevExpress.XtraEditors.Controls;
using Zek.Core;
using Zek.Data;

namespace Apothex.Dictionary
{
    public partial class frmCurrencyRateEdit : frmEditBrowse
    {
        public frmCurrencyRateEdit()
        {
            InitializeComponent();
        }

        #region Properties
        public int CurrencyRateID
        {
            get { return ConvertHelper.ToInt32(PrimaryKey); }
            set { PrimaryKey = value; txtID.Text = value.ToString(); }
        }
        public string CurrencyCode
        {
            get { return ConvertHelper.ToString(lookCurrency.EditValue); }
            set { lookCurrency.EditValue = value; }
        }
        public decimal CurrencyRateOld
        {
            get { return ConvertHelper.ToDecimal(lookCurrency.GetColumnValue("Code")); }
            set { spinCurrencyRateOld.EditValue = value; }
        }
        public decimal CurrencyRateNew
        {
            get { return spinCurrencyRateNew.Value; }
            set { spinCurrencyRateNew.Value = value; }
        }
        public DateTime StartDate
        {
            get { return ConvertHelper.ToDateTime(dateStartDate.EditValue); }
            set { dateStartDate.EditValue = value; }
        }
        public DateTime EndDate
        {
            get { return ConvertHelper.ToDateTime(dateEndDate.EditValue); }
            set { dateEndDate.EditValue = value; }
        }
        public byte ChangePrice
        {
            get { return ConvertHelper.ToByte(chkChangePrice.Checked); }
            set { chkChangePrice.Checked = ((value & 1) != 0); }
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
            bsCurrency.DataSource = DictionaryManager.GetDictionary(ObjectNames.CurrencyWithLastRate);
        }
        protected override void BindData()
        {
            if (Action == DatabaseAction.Edit)
            {
                var table = DictionaryManager.GetCurrencyRate(CurrencyRateID);
                if (table.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.");

                CurrencyRateID = table[0].CurrencyRateID;
                CurrencyCode = table[0].CurrencyCode;
                StartDate = table[0].StartDate;
                dateEndDate.EditValue = ConvertHelper.Parse(table[0]["EndDate"]);
                CurrencyRateOld = table[0].AverageRate;
                CurrencyRateNew = table[0].AverageRate;
                ChangePrice = table[0].Events;

                Status = (DatabaseStatus)table[0].Status;
                ModifiedUserID = table[0].ModifiedUserID;
                ModifiedDate = table[0].ModifiedDate;
                ApproverUserID = table[0].ApproverUserID;
            }
            else
            {
                StartDate = BaseGlobalVariable.ServerDateTime;

                ModifiedUserID = BaseGlobalVariable.UserID;
                ModifiedDate = BaseGlobalVariable.ServerDateTime;
            }
        }
        #endregion

        #region Methods
        protected override void Init()
        {
            base.Init();

            lookCurrency.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
            spinCurrencyRateNew.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
            chkChangePrice.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
        }
        protected override bool SaveData()
        {
            var id = DictionaryManager.AddOrEditCurrencyRate(CurrencyRateID, CurrencyCode, StartDate, EndDate, CurrencyRateNew, ChangePrice, Status, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, ApproverUserID, Action);
            if (id > 0) CurrencyRateID = id;
            return (id > 0);
        }
        #endregion

        #region Validations
        public bool IsValidCurrency()
        {
            if (lookCurrency.EditValue == null)
            {
                SetError(lookCurrency, "გთხოვთ აირჩიოთ ვალუტა.");
                return false;
            }

            if (!DictionaryManager.IsValidCurrencyRateDate(CurrencyRateID, CurrencyCode, StartDate))
            {
                SetError(lookCurrency, "მონაცემებში ნაპოვნია ამ ვალუტის დაუმოწმებელი კურსი, ან მიმდინარე თარიღზე უკვე არის შეყვანილი კურსი.");
                return false;
            }

            return true;
        }
        public bool IsValidRateDate()
        {
            if (dateStartDate.EditValue == null)
            {
                dxErrorProvider.SetError(dateStartDate, "გთხოვთ შეიყვანოთ ვალუტის კურსის თარიღი.");
                return false;
            }


            if (StartDate.Date != BaseGlobalVariable.ServerDateTime.Date)
            {
                SetError(dateStartDate, string.Format("თქვენ შეგიძლიათ მხოლოდ '{0}' თაროღით შეყვანა.", BaseGlobalVariable.ServerDateTime.ToShortDateString()));
                return false;
            }

            return true;
        }
        public bool IsValidRate()
        {
            if (spinCurrencyRateNew.EditValue == null)
            {
                SetError(spinCurrencyRateNew, "გთხოვთ შეიყვანოთ ახალი ვალუტის კურსი.");
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var ok = true;
            if (!IsValidCurrency()) ok = false;
            if (!IsValidRateDate()) ok = false;
            if (!IsValidRate()) ok = false;

            return ok;
        }
        #endregion

        private void lookCurrency_EditValueChanged(object sender, EventArgs e)
        {
            SetError(lookCurrency, string.Empty);
            SetError(dateStartDate, string.Empty);
            CurrencyRateOld = CurrencyRateOld;
            CurrencyRateNew = CurrencyRateOld;
        }

        private void dateStartDate_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(dateStartDate, string.Empty);
        }

        private void spinCurrencyRateNew_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(spinCurrencyRateNew, string.Empty);
        }

        private void dateStartDate_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (ReadOnly) return;

            if (e.Button.Caption == "OK")
            {
                dateStartDate.EditValue = BaseGlobalVariable.ServerDateTime;
            }
        }
    }
}