using System;
using System.Windows.Forms;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Zek.Core;
using Apothex.DataManagment.Card;
using Apothex.DataType;
using Zek.Data;
using Zek.Windows.Forms;
using Zek.Windows.Forms.DevEx;
using DevExpress.XtraGrid.Views.Grid;
using Zek.Properties;

namespace Apothex.Card
{
    public partial class frmCardEdit : frmEditBrowse
    {
        public frmCardEdit()
        {
            InitializeComponent();
            XtraGridHelper.InitGrid(gridHandle);
        }

        #region Properties
        public int? ID
        {
            get { return ConvertHelper.ToNullableInt32(PrimaryKey); }
            set { PrimaryKey = value; txtID.Text = value.ToString(); }
        }
        public string CardNumber
        {
            get { return StringHelper.MatchReplace(txtCardNumber.Text, "[^a-zA-Z0-9]", string.Empty); }
            set { txtCardNumber.Text = value; }
        }
        public int? CardTypeID
        {
            get { return ConvertHelper.ToNullableInt32(lookCardType.EditValue); }
            set { lookCardType.EditValue = value; }
        }
        public int? PersonID
        {
            get { return ConvertHelper.ToNullableInt32(bbPerson.PrimaryKey); }
            set { bbPerson.PrimaryKey = value; }
        }
        public int? ParentCardID
        {
            get { return ConvertHelper.ToNullableInt32(bbParentCard.PrimaryKey); }
            set { bbParentCard.PrimaryKey = value; }
        }

        public DateTime CreateDate
        {
            get { return ConvertHelper.ToDateTime(dateCreateDate.EditValue); }
            set { dateCreateDate.EditValue = value; }
        }
        public int CreatorID
        {
            get { return ConvertHelper.ToInt32(bbCreator.PrimaryKey); }
            set { bbCreator.PrimaryKey = value; }
        }
        public DateTime ModifiedDate
        {
            get { return ConvertHelper.ToDateTime(dateModifiedDate.EditValue); }
            set { dateModifiedDate.EditValue = value; }
        }
        public int ModifierID
        {
            get { return ConvertHelper.ToInt32(bbModifier.PrimaryKey); }
            set { bbModifier.PrimaryKey = value; }
        }
        public int ApproverID
        {
            get { return ConvertHelper.ToInt32(bbApprover.PrimaryKey); }
            set { bbApprover.PrimaryKey = value; }
        }
        #endregion

        public bool IsValidCardNumber()
        {
            CardNumber = CardNumber;
            if (CardNumber.Length == 0)
            {
                SetError(txtCardNumber, "გთხოვთ შეიყვანოთ მნიშვნელობა.");
                return false;
            }

            if (!CardManager.IsValidCardNumber(ID, CardNumber))
            {
                SetError(txtCardNumber, "ბარათის ნომერი დუბლირებულია.");
                return false;
            }

            return true;
        }
        public bool IsValidPerson()
        {
            if (PersonID == null)
            {
                //if (XtraMessageBox.Show(this, "მფლობელი არ არის არჩეული. დარწმუნებული ხართ რომ გინდა შეინახოთ ცვლილებები პიროვნების არჩევის გარეშე?", "შეკითხვა", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //{
                //    ClearError(bbPerson);
                //    return true;
                //}

                SetError(bbPerson, Exceptions.ValueIsEmtpyErrorText);
                return false;
            }

            return true;
        }
        public bool IsValidParentCard()
        {
            if (ParentCardID == null) return true;
            if (ParentCardID == ID)
            {
                SetError(bbParentCard, "მშობელი ბარათი არ შეიძლება იყოს თავისი თავი.");
                return false;
            }

            var table = CardManager.GetCard(ParentCardID);
            if (table.Count == 0)
            {
                SetError(bbParentCard, "ბარათი ვერ მოიძებნა.");
                return false;
            }
            if (table[0].ParentCardID != 0)
            {
                SetError(bbParentCard, "მშობელ ბარათს არ შეიძლება ყავდეს მშობელი ბარათი.");
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var flag = IsValidCardNumber();
            if (!IsValidPerson()) flag = false;
            if (!IsValidParentCard()) flag = false;
            return flag;
        }

        protected override void Init()
        {
            base.Init();

            XtraControlHelper.SetChildrenReadOnly(tabMain, OptionsBaseForm.ReadOnly);
        }
        protected override void BindControls()
        {
            bsCardType.DataSource = DictionaryManager.GetDictionaryInt(ObjectNames.CardType);
        }
        protected override void BindData()
        {

            if (Action == DatabaseAction.Edit)
            {
                var table = CardManager.GetCard(ID);
                if (table.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.");

                ID = table[0].CardID;
                CardNumber = table[0].CardNumber;
                CardTypeID = table[0].CardTypeID;
                PersonID = table[0].PersonID;
                ParentCardID = table[0].ParentCardID;

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
            }
        }
        protected override bool SaveData()
        {
            var id = CardManager.AddOrEditCard(ID, CardNumber, CardTypeID, PersonID, ParentCardID, BaseGlobalVariable.UserID);
            if (id > 0) ID = id;
            return id > 0;
        }

        private void txtCardNumber_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(txtCardNumber);
        }

        private void bbPerson_PrimaryKeyChanged(object sender, EventArgs e)
        {
            ClearError(bbPerson);
        }

        private void bbParentCard_PrimaryKeyChanged(object sender, EventArgs e)
        {
            ClearError(bbParentCard);
        }

        private void btnBindHandle_Click(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                ds.VW_CardHandle.Clear();
                ds.VW_CardHandle.Merge(CardManager.GetVWCardHandle(ID, ParentCardID, ConvertHelper.ToNullableDateTime(dateHandle1.EditValue), ConvertHelper.ToNullableDateTime(dateHandle2.EditValue)));
            }
            catch (Exception ex)
            {
                ExceptionHelper.Show(ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void viewHandle_DoubleClick(object sender, EventArgs e)
        {
            var view = (GridView)sender;
            var pt = view.GridControl.PointToClient(MousePosition);
            var info = view.CalcHitInfo(pt);
            if (!info.InRow) return;

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                var id = ConvertHelper.ToInt32(view.GetFocusedRowCellValue(colSalesOrderID));
                if (id == 0) return;
                FormHelper.Show((int)ObjectNames.SalesOrderHeader, FormStyle.Edit, MdiParent, IntPtr.Zero, id);
            }
            catch (Exception ex)
            {
                ExceptionHelper.Show(ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
