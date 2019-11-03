using System;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Zek.Core;
using Zek.Data;

namespace Apothex.Dictionary
{
    public partial class frmCountryEdit : frmEditBrowse
    {
        public frmCountryEdit()
        {
            InitializeComponent();
        }

        #region Properties
        public string CountryCodeOld
        {
            get { return ConvertHelper.ToString(PrimaryKey); }
            set { PrimaryKey = value; txtID.Text = value.ToString(); }
        }
        public string CountryCodeNew
        {
            get { return txtCountryCode.Text.Trim(); }
            set { txtCountryCode.Text = value; }
        }
        public string CountryName
        {
            get { return txtCountryName.Text.Trim(); }
            set { txtCountryName.Text = value; }
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
                var table = DictionaryManager.GetCountry(CountryCodeOld);
                if (table.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.");

                CountryCodeNew = table[0].CountryCode;
                CountryCodeOld = table[0].CountryCode;
                CountryName = table[0].Name;

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

            txtCountryCode.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
            txtCountryName.Properties.ReadOnly = OptionsBaseForm.ReadOnly;
        }
        protected override bool SaveData()
        {
            var id = DictionaryManager.AddOrEditCountry(CountryCodeOld, CountryCodeNew, CountryName, Status, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, ApproverUserID, Action);
            if (id > 0) CountryCodeOld = CountryCodeNew;

            return (id > 0);
        }
        #endregion

        #region Validations
        public bool IsValidCountryCode()
        {
            if (CountryCodeNew.Length == 0)
            {
                dxErrorProvider.SetError(txtCountryCode, "გთხოვთ შეიყვანოთ ქვეყნის კოდი.");
                return false;
            }

            if (!DictionaryManager.IsValidCountryCode(CountryCodeOld, CountryCodeNew))
            {
                dxErrorProvider.SetError(txtCountryCode, "ესეთი ქვეყნის კოდით უკვე არსებობს ჩანაწერი.");
                return false;
            }

            return true;
        }
        public bool IsValidCountryName()
        {
            if (CountryName.Length == 0)
            {
                dxErrorProvider.SetError(txtCountryName, "გთხოვთ შეიყვანოთ ქვეყნის დასახელება.");
                return false;
            }

            if (!DictionaryManager.IsValidCountryName(CountryCodeOld, CountryName))
            {
                dxErrorProvider.SetError(txtCountryName, "ესეთი ქვეყნის სახელით უკვე არსებობს ჩანაწერი.");
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var ok = true;
            if (!IsValidCountryCode()) ok = false;
            if (!IsValidCountryName()) ok = false;

            return ok;
        }
        #endregion

        private void txtCountryCode_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtCountryCode, string.Empty);
        }

        private void txtCountryName_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtCountryName, string.Empty);
        }
    }
}