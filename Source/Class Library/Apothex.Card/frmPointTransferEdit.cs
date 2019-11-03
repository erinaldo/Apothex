using System;
using Apothex.Windows.Forms;
using Zek.Core;
using Apothex.DataManagment.CardPointTransfer;
using Apothex.Common;
using Zek.Windows.Forms.DevEx;
using Zek.Properties;
using Apothex.DataManagment.Card;
using Zek.Data;
using Apothex.DataManagment.Person;

namespace Apothex.Card
{
    public partial class frmPointTransferEdit : frmEditBrowse
    {
        public frmPointTransferEdit()
        {
            InitializeComponent();
        }

        #region Properties
        private int? ID
        {
            get { return ConvertHelper.ToNullableInt32(PrimaryKey); }
            set { PrimaryKey = value; txtNumber.Text = txtID.Text = value.ToString(); }
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

        public string FromCardNumber
        {
            get { return ConvertHelper.ToString(bbFromCardNumber.PrimaryKey); }
            set { bbFromCardNumber.PrimaryKey = value; }
        }
        public string ToCardNumber
        {
            get { return ConvertHelper.ToString(bbToCardNumber.PrimaryKey); }
            set { bbToCardNumber.PrimaryKey = value; }
        }
        public DateTime? Date
        {
            get { return ConvertHelper.ToNullableDateTime(dateDate.EditValue); }
            set { dateDate.EditValue = value; }
        }
        public string Comment
        {
            get { return ConvertHelper.ToNullableString(memoComment.Text); }
            set { memoComment.EditValue = value; }
        }
        #endregion

        protected override void BindData()
        {
            if (Action == DatabaseAction.Edit)
            {
                var table = CardPointTransferManager.GetHeader(ID);
                if (table.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.");

                ID = table[0].PointTransferID;
                FromCardNumber = table[0].FromCardNumber;
                ToCardNumber = table[0].ToCardNumber;
                Date = table[0].Date;
                Comment = table[0].Comment;


                Status = (DatabaseStatus)table[0].StatusID;
                CreateDate = table[0].CreateDate;
                CreatorID = table[0].CreatorID;
                ModifiedDate = table[0].ModifiedDate;
                ModifierID = table[0].ModifierID;
                ApproverID = table[0].ApproverID;

                if (!table[0].IsApproverIDNull())
                {
                    ds_CardPointTransfer.VW_PointTransferDetail.Clear();
                    ds_CardPointTransfer.VW_PointTransferDetail.Merge(CardPointTransferManager.GetDetail(ID));
                }
            }
            else
            {
                CreateDate = BaseGlobalVariable.ServerDateTime;
                CreatorID = BaseGlobalVariable.UserID;
                ModifiedDate = BaseGlobalVariable.ServerDateTime;
                ModifierID = BaseGlobalVariable.UserID;

                Date = BaseGlobalVariable.ServerDateTime;
            }
        }
        protected override void Init()
        {
            base.Init();

            XtraControlHelper.SetChildrenReadOnly(tabMain, OptionsBaseForm.ReadOnly);
            txtNumber.Properties.ReadOnly = true;
        }
        protected override bool SaveData()
        {
            var id = CardPointTransferManager.Save(ID, Date, FromCardNumber, ToCardNumber, Comment, BaseGlobalVariable.UserID);
            if (id > 0) ID = id;
            return id > 0;
        }


        private bool IsValidFromCardNumber()
        {
            if (FromCardNumber.Length == 0)
            {
                SetError(bbFromCardNumber, Exceptions.ValueIsEmtpyErrorText);
                return false;
            }

            return true;
        }
        private bool IsValidToCardNumber()
        {
            if (ToCardNumber.Length == 0)
            {
                SetError(bbToCardNumber, Exceptions.ValueIsEmtpyErrorText);
                return false;
            }

            if (FromCardNumber == ToCardNumber)
            {
                SetError(bbToCardNumber, Exceptions.ValueIsDuplicatedErrorText);
                return false;
            }

            return true;
        }



        protected override bool IsValidForm()
        {
            var valid = IsValidFromCardNumber();
            if (!IsValidToCardNumber()) valid = false;
            return valid;
        }

        protected override void Print()
        {
            var ds = new Zek.DataModel.DS_CardPointTransfer();
            DataSetHelper.AddEmptyRow(ds.T_CardPointTransfer);


            var cardID = CardManager.GetCardID(FromCardNumber);
            var card = CardManager.GetCard(cardID);
            var holder = PersonManager.GetPerson(card[0].PersonID);

            ds.T_CardPointTransfer[0].Company = GlobalVariable.MyCompanyName;
            ds.T_CardPointTransfer[0].CardNumber = FromCardNumber;
            ds.T_CardPointTransfer[0].CardHolder = holder[0].FullName;
            ds.T_CardPointTransfer[0].Address = holder[0].Address;
            ds.T_CardPointTransfer[0].PersonalNumber = holder[0].PersonalNumber;
            ds.T_CardPointTransfer[0].Phone = holder[0].Phone + "  " + holder[0].Mobile;


            Zek.Report.ReportHelper.Show(MdiParent, Text, Reports.ReportName.CardPointTransfer, ds);
        }

        private void bbFromCardNumber_PrimaryKeyChanged(object sender, EventArgs e)
        {
            ClearError(bbFromCardNumber);
        }

        private void bbToCardNumber_PrimaryKeyChanged(object sender, EventArgs e)
        {
            ClearError(bbToCardNumber);
        }

        private void OnCardNumberRecordValueChanging(object sender, ChangingEventArgs e)
        {
            if (IsLoading) return;
            try
            {
                IsLoading = true;
                if (e.NewValue is int)
                    e.NewValue = CardManager.GetCardNumber(ConvertHelper.ToNullableInt32(e.NewValue));
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
}
