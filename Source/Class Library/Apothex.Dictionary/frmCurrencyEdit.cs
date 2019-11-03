using System;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Zek.Core;
using Zek.Data;

namespace Apothex.Dictionary
{
    public partial class frmCurrencyEdit : frmEditBrowse
    {
        public frmCurrencyEdit()
        {
            InitializeComponent();
        }

        #region Fields & Properties
        public string CurrencyCodeOld
        {
            get { return ConvertHelper.ToString(PrimaryKey); }
            set { PrimaryKey = value; txtID.Text = value; }
        }
        public string CurrencyCodeNew
        {
            get { return txtCurrencyCode.Text; }
            set { txtCurrencyCode.Text = value; }
        }
        public string CurrencyName
        {
            get { return txtCurrencyName.Text.Trim(); }
            set { txtCurrencyName.Text = value; }
        }
        public string Coin
        {
            get { return txtCoin.Text.Trim(); }
            set { txtCoin.Text = value; }
        }
        public decimal AverageRate
        {
            get { return spinCurrencyRate.Value; }
            set { spinCurrencyRate.Value = value; }
        }
        public int Position
        {
            get { return ConvertHelper.ToInt32(spinPosition.EditValue); }
            set { spinPosition.EditValue = value; }
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
                var table = DictionaryManager.GetCurrency(CurrencyCodeOld);
                if (table.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.");

                CurrencyCodeNew = table[0].CurrencyCode;
                CurrencyCodeOld = table[0].CurrencyCode;
                CurrencyName = table[0].Name;
                Coin = table[0].Coin;
                AverageRate = table[0].AverageRate;
                Position = table[0].Position;

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

            txtCurrencyCode.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
            txtCurrencyName.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
            txtCoin.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
            spinCurrencyRate.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
            spinPosition.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
        }
        protected override bool SaveData()
        {
            var id = DictionaryManager.AddOrEditCurrency(CurrencyCodeOld, CurrencyCodeNew, CurrencyName, Coin, AverageRate, Position, Status, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, ApproverUserID, Action);
            if (id > 0) CurrencyCodeOld = CurrencyCodeNew;

            return (id > 0);
        }
        #endregion

        #region Validations
        public bool IsValidCurrencyCode()
        {
            if (CurrencyCodeNew.Length == 0)
            {
                dxErrorProvider.SetError(txtCurrencyCode, "გთხოვთ შეიყვანოთ ვალუტის კოდი.");
                return false;
            }

            if (CurrencyCodeNew.Length != 3)
            {
                dxErrorProvider.SetError(txtCurrencyCode, " ვალუტის კოდი უნდა იყოს 3 სიმბოლოიანი.");
                return false;
            }

            if (!DictionaryManager.IsValidCurrencyCode(CurrencyCodeOld, CurrencyCodeNew))
            {
                dxErrorProvider.SetError(txtCurrencyCode, "ესეთი ვალუტის კოდით უკვე არსებობს ჩანაწერი.");
                return false;
            }

            return true;
        }
        public bool IsValidCurrencyName()
        {
            if (CurrencyName.Length == 0)
            {
                dxErrorProvider.SetError(txtCurrencyName, "გთხოვთ შეიყვანოთ ვალუტის დასახელება.");
                return false;
            }

            if (!DictionaryManager.IsValidCurrencyName(CurrencyCodeOld, CurrencyName))
            {
                dxErrorProvider.SetError(txtCurrencyCode, "ესეთი ვალუტის სახელით უკვე არსებობს ჩანაწერი.");
                return false;
            }

            return true;
        }
        public bool IsValidCurrencyCoin()
        {
            if (Coin.Length == 0)
            {
                dxErrorProvider.SetError(txtCoin, "გთხოვთ შეიყვანოთ 1/100 დასახელება.");
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var ok = true;
            if (!IsValidCurrencyCode()) ok = false;
            if (!IsValidCurrencyName()) ok = false;
            if (!IsValidCurrencyCoin()) ok = false;

            return ok;
        }
        #endregion

        private void txtCurrencyCode_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtCurrencyCode, string.Empty);
        }

        private void txtCurrencyName_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtCurrencyName, string.Empty);
        }

        private void txtCoin_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtCoin, string.Empty);
        }
    }
}