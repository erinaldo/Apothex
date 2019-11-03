using System;
using Apothex.DataType;
using Apothex.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using Zek.Data;
using Zek.Windows.Forms.DevEx;
using Zek.Core;
using Apothex.Common;
using Apothex.DataManagment.Dictionary;
using Apothex.DataManagment.Cashbox;
using Zek.Properties;
using Apothex.DataManagment.Person;
using Apothex.DataManagment.Sales;

namespace Apothex.Cashbox
{
    public partial class frmCashboxOrderEdit : frmEditBrowse
    {
        public frmCashboxOrderEdit()
        {
            InitializeComponent();
        }

        #region Properties
        private string ActNumber
        {
            get { return beOrderNumber.Text.Trim(); }
            set { beOrderNumber.Text = value; }
        }
        private DateTime? OrderDate
        {
            get { return ConvertHelper.ToNullableDateTime(dateOrderDate.EditValue); }
            set { dateOrderDate.EditValue = value; }
        }
        private int? BranchID
        {
            get { return ConvertHelper.ToNullableInt32(lookBranch.EditValue); }
            set { lookBranch.EditValue = value; }
        }
        private string SubAccount
        {
            get { return ConvertHelper.ToNullableString(txtSubAccount.Text.Trim()); }
            set { txtSubAccount.Text = value; }
        }
        private string AnalyticalAccountingCode
        {
            get { return ConvertHelper.ToNullableString(txtAnalyticalAccountingCode.Text.Trim()); }
            set { txtAnalyticalAccountingCode.Text = value; }
        }
        private decimal Amount
        {
            get { return spinAmount.Value; }
            set { spinAmount.Value = value; }
        }
        private byte? CurrencyID
        {
            get { return ConvertHelper.ToNullableByte(lookCurrency.EditValue); }
            set { lookCurrency.EditValue = (int)value; }
        }
        private string SpecialPurposeCode
        {
            get { return ConvertHelper.ToNullableString(txtSpecialPurposeCode.Text.Trim()); }
            set { txtSpecialPurposeCode.Text = value; }
        }
        private string Enclosure
        {
            get { return ConvertHelper.ToNullableString(txtEnclosure.Text.Trim()); }
            set { txtEnclosure.Text = value; }
        }
        private string WarrantNumber
        {
            get { return ConvertHelper.ToNullableString(txtWarrantNumber.Text.Trim()); }
            set { txtWarrantNumber.Text = value; }
        }
        private int? IssuedPersonID
        {
            get { return ConvertHelper.ToNullableInt32(bbPerson.PrimaryKey); }
            set { bbPerson.PrimaryKey = value; }
        }
        private byte? BasisID
        {
            get { return ConvertHelper.ToNullableByte(lookBasis.EditValue); }
            set { lookBasis.EditValue = (int)value; }
        }

        private int? ID
        {
            get { return ConvertHelper.ToNullableInt32(PrimaryKey); }
            set { PrimaryKey = value; txtID.Text = value.ToString(); }
        }
        private DateTime CreateDate
        {
            get { return ConvertHelper.ToDateTime(dateCreateDate.EditValue); }
            set { dateCreateDate.EditValue = value; }
        }
        private int CreatorID
        {
            get { return ConvertHelper.ToInt32(bbCreator.PrimaryKey); }
            set { bbCreator.PrimaryKey = value; }
        }
        private DateTime ModifiedDate
        {
            get { return ConvertHelper.ToDateTime(dateModifiedDate.EditValue); }
            set { dateModifiedDate.EditValue = value; }
        }
        private int ModifierID
        {
            get { return ConvertHelper.ToInt32(bbModifier.PrimaryKey); }
            set { bbModifier.PrimaryKey = value; }
        }
        private int ApproverID
        {
            get { return ConvertHelper.ToInt32(bbApprover.PrimaryKey); }
            set { bbApprover.PrimaryKey = value; }
        }
        #endregion

        protected override void BindControls()
        {
            lookBranch.Properties.DataSource = DictionaryManager.GetDictionaryInt(ObjectNames.Branch);
            lookBasis.Properties.DataSource = DictionaryManager.GetDictionaryInt(ObjectNames.CashboxOrderType);
            lookCurrency.Properties.DataSource = DictionaryManager.GetDictionaryInt(ObjectNames.DD_Currency);
        }
        protected override void BindData()
        {
            if (Action == DatabaseAction.Edit)
            {
                var table = CashboxManager.Get(ID);
                if (table.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.");

                ID = table[0].CashboxOrderID;
                ActNumber = table[0].ActNumber;
                OrderDate = table[0].OrderDate;
                BranchID = table[0].BranchID;
                SubAccount = table[0].SubAccount;
                AnalyticalAccountingCode = table[0].AnalyticalAccountingCode;
                Amount = table[0].Amount;
                CurrencyID = table[0].CurrencyID;
                SpecialPurposeCode = table[0].SpecialPurposeCode;
                IssuedPersonID = table[0].IssuedPersonID;
                BasisID = table[0].BasisID;
                Enclosure = table[0].Enclosure;
                WarrantNumber = table[0].WarrantNumber;

                Status = (DatabaseStatus)table[0].StatusID;
                CreateDate = table[0].CreateDate;
                CreatorID = table[0].CreatorID;
                ModifiedDate = table[0].ModifiedDate;
                ModifierID = table[0].ModifierID;
                ApproverID = table[0].ApproverID;
            }
            else
            {
                CreateDate = BaseGlobalVariable.ServerDateTime;
                CreatorID = BaseGlobalVariable.UserID;
                ModifiedDate = BaseGlobalVariable.ServerDateTime;
                ModifierID = BaseGlobalVariable.UserID;

                OrderDate = BaseGlobalVariable.ServerDateTime.Date;
            }
        }
        protected override void Init()
        {
            base.Init();

            XtraControlHelper.SetChildrenReadOnly(tabMain, OptionsBaseForm.ReadOnly);
            beOrderNumber.Properties.ReadOnly = true;
        }

        private bool IsValidOrderNumber()
        {
            //if (OrderNumber.Length == 0)
            //{
            //    SetError(beOrderNumber, Exceptions.ValueIsEmtpyErrorText);
            //    return false;
            //}

            return true;
        }
        private bool IsValidOrderDate()
        {
            if (OrderDate == null)
            {
                SetError(dateOrderDate, Exceptions.ValueIsEmtpyErrorText);
                return false;
            }

            return true;
        }
        private bool IsValidBranch()
        {
            if (BranchID == null)
            {
                SetError(lookBranch, Exceptions.ValueIsEmtpyErrorText);
                return false;
            }

            return true;
        }
        private bool IsValidPerson()
        {
            if (IssuedPersonID == null)
            {
                SetError(bbPerson, Exceptions.ValueIsEmtpyErrorText);
                return false;
            }

            return true;
        }
        private bool IsValidType()
        {
            if (BasisID == null)
            {
                SetError(lookBasis, Exceptions.ValueIsEmtpyErrorText);
                return false;
            }

            return true;
        }
        private bool IsValidAmount()
        {
            if (Amount == 0)
            {
                SetError(spinAmount, Exceptions.ValueIsEmtpyErrorText);
                return false;
            }

            return true;
        }
        private bool IsValidCurrencyID()
        {
            if (CurrencyID == null)
            {
                SetError(lookCurrency, Exceptions.ValueIsEmtpyErrorText);
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var valid = IsValidOrderNumber();
            if (!IsValidOrderDate()) valid = false;
            if (!IsValidBranch()) valid = false;
            if (!IsValidPerson()) valid = false;
            if (!IsValidType()) valid = false;
            if (!IsValidAmount()) valid = false;
            if (!IsValidCurrencyID()) valid = false;
            return valid;
        }


        protected override void Print()
        {
            var ds = new DS_CashboxOrder();
            var table = ds.T_Cashbox;
            table.AddEmptyRow();
            table[0].ID = ConvertHelper.ToInt32(ID);
            table[0].Company = GlobalVariable.MyCompanyName;
            table[0].Branch = lookBranch.Text;
            table[0].ActNumber = ActNumber;
            table[0].OrderDate = dateOrderDate.DateTime.Date;
            table[0].SubAccount = SubAccount;
            table[0].AnalyticalAccountingCode = AnalyticalAccountingCode;
            table[0].Amount = Amount;

            table[0].CurrencySymbol = NumToStrHelper.ToCurrencySymbol(lookCurrency.Text);
            table[0].AmountToStr = NumToStrHelper.CurrToStr(Amount, NumToStrHelper.ToCurrencyName(lookCurrency.Text),  NumToStrHelper.ToCurrencyMinorUnit(lookCurrency.Text));

            table[0].SpecialPurposeCode = SpecialPurposeCode;
            table[0].IssuedPerson = bbPerson.Text;
            var person = PersonManager.GetPerson(IssuedPersonID);
            if (person.Count > 0)
                table[0].IssuedPersonPersonalNumber = person[0].PersonalNumber;
            table[0].Basis = lookBasis.Text;
            table[0].Enclosure = Enclosure;
            table[0].WarrantNumber = WarrantNumber;

            Zek.Report.ReportHelper.Show(MdiParent, Text, Reports.ReportName.CashboxOrder, ds);
        }
        protected override bool SaveData()
        {
            var id = CashboxManager.Save(ID, null, OrderDate, BranchID, SubAccount, AnalyticalAccountingCode, Amount, CurrencyID, SpecialPurposeCode, IssuedPersonID, BasisID, Enclosure, WarrantNumber, BaseGlobalVariable.UserID);
            if (id > 0) ID = id;
            return id > 0;
        }

        private void beOrderNumber_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            //AccountingManager.GetAutoNumber(DataType.ObjectNames.Cashbox, GlobalVariable.ServerDateTime.Year, 
        }

        private void beOrderNumber_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(beOrderNumber);
        }

        private void dateOrderDate_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(dateOrderDate);
        }

        private void lookBranch_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(lookBranch);
        }

        private void bbPerson_PrimaryKeyChanged(object sender, EventArgs e)
        {
            ClearError(bbPerson);
        }

        private void lookOrderType_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(lookBasis);
        }

        private void spinAmount_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(spinAmount);
        }

        private void lookCurrency_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(lookCurrency);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Amount = SalesManager.GetTotal(BranchID, ConvertHelper.ToDateTime(OrderDate), ConvertHelper.ToDateTime(OrderDate).AddDays(1));
        }
    }
}