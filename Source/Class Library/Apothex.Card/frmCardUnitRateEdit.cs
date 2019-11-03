using System;
using Apothex.Windows.Forms;
using Zek.Core;
using Apothex.DataManagment.Card;
using Zek.Data;
using Zek.Windows.Forms.DevEx;

namespace Apothex.Card
{
    public partial class frmCardUnitRateEdit : frmEditBrowse
    {
        public frmCardUnitRateEdit()
        {
            InitializeComponent();
        }

        #region Properties
        public int? ID
        {
            get { return ConvertHelper.ToNullableInt32(PrimaryKey); }
            set { PrimaryKey = value; txtID.Text = value.ToString(); }
        }
        public decimal MinAmount
        {
            get { return spinMinAmount.Value; }
            set { spinMinAmount.Value = value; }
        }
        public decimal MaxAmount
        {
            get { return spinMaxAmount.Value; }
            set { spinMaxAmount.Value = value; }
        }
        public decimal Unit
        {
            get { return spinUnit.Value; }
            set { spinUnit.Value = value; }
        }
        public decimal Amount
        {
            get { return spinAmount.Value; }
            set { spinAmount.Value = value; }
        }

        public DateTime CreateDate
        {
            get { return ConvertHelper.ToDateTime(dateCreateDate.EditValue); }
            set { dateCreateDate.EditValue = value; }
        }
        public int CreatorID
        {
            get { return ConvertHelper.ToInt32(bbCreator.RecordValue); }
            set { bbCreator.RecordValue = value; }
        }
        public DateTime ModifiedDate
        {
            get { return ConvertHelper.ToDateTime(dateModifiedDate.EditValue); }
            set { dateModifiedDate.EditValue = value; }
        }
        public int ModifierID
        {
            get { return ConvertHelper.ToInt32(bbModifier.RecordValue); }
            set { bbModifier.RecordValue = value; }
        }
        #endregion

        #region Bindings
        protected override void BindData()
        {
            if (Action == DatabaseAction.Edit)
            {
                var table = CardManager.GetCardUnitRate(ID);
                if (table.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.");

                ID = table[0].ID;
                MinAmount = table[0].MinAmount;
                MaxAmount = table[0].MaxAmount;
                Unit = table[0].Unit;
                Amount = table[0].Amount;

                //Status = (Zek.Data.Statuses)table[0].Status;
                CreateDate = table[0].CreateDate;
                CreatorID = table[0].CreatorID;
                ModifiedDate = table[0].ModifiedDate;
                ModifierID = table[0].ModifierID;
            }
            else
            {
                CreateDate = BaseGlobalVariable.ServerDateTime;
                CreatorID = BaseGlobalVariable.UserID;
                ModifiedDate = BaseGlobalVariable.ServerDateTime;
                ModifierID = BaseGlobalVariable.UserID;
            }
        }
        #endregion

        #region Methods
        protected override void Init()
        {
            base.Init();

            XtraControlHelper.SetChildrenReadOnly(tabMain, OptionsBaseForm.ReadOnly);
        }
        protected override bool SaveData()
        {
            var id = CardManager.AddOrEditCardUnitRate(ID, MinAmount, MaxAmount, Unit, Amount, BaseGlobalVariable.UserID);
            if (id > 0) ID = id;
            return (id > 0);
        }
        #endregion

        #region Validations
        protected override bool IsValidForm()
        {
            var flag = true;
            if (!CardManager.IsValidCardUnitRate(ID, MinAmount, MaxAmount))
            {
                SetError(spinMinAmount, "მინიმალური და მაქსიმალური მნიშვნელობები ჯდება სხვა ჩანაწერის დიაპაზონში.");
                SetError(spinMaxAmount, "მინიმალური და მაქსიმალური მნიშვნელობები ჯდება სხვა ჩანაწერის დიაპაზონში.");
                flag = false;
            }

            return flag;
        }
        #endregion

        private void spinMinAmount_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(spinMinAmount);
        }

        private void spinMaxAmount_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(spinMaxAmount);
        }
    }
}
