using System;
using Apothex.Windows.Forms;
using Zek.Core;
using Apothex.DataManagment.Card;
using Zek.Data;
using Zek.Windows.Forms.DevEx;

namespace Apothex.Card
{
    public partial class frmCardDiscountSchemaEdit : frmEditBrowse
    {
        public frmCardDiscountSchemaEdit()
        {
            InitializeComponent();
        }

        #region Properties
        public int? ID
        {
            get { return ConvertHelper.ToNullableInt32(PrimaryKey); }
            set { PrimaryKey = value; txtID.Text = value.ToString(); }
        }
        public int MinUnit
        {
            get { return ConvertHelper.ToInt32(spinMinUnit.Value); }
            set { spinMinUnit.Value = value; }
        }
        public int MaxUnit
        {
            get { return ConvertHelper.ToInt32(spinMaxUnit.Value); }
            set { spinMaxUnit.Value = value; }
        }
        public decimal Discount
        {
            get { return spinDiscount.Value; }
            set { spinDiscount.Value = value; }
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
                var table = CardManager.GetCardDiscountSchema(ID);
                if (table.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.");

                ID = table[0].ID;
                MinUnit = table[0].MinUnit;
                MaxUnit = table[0].MaxUnit;
                Discount = table[0].Discount;

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
            var id = CardManager.AddOrEditCardDiscountSchema(ID, MinUnit, MaxUnit, Discount, BaseGlobalVariable.UserID);
            if (id > 0) ID = id;
            return (id > 0);
        }
        #endregion

        #region Validations
        protected override bool IsValidForm()
        {
            var flag = true;
            if (!CardManager.IsValidCardDiscountSchema(ID, MinUnit, MaxUnit))
            {
                SetError(spinMinUnit, "მინიმალური და მაქსიმალური მნიშვნელობები ჯდება სხვა ჩანაწერის დიაპაზონში.");
                SetError(spinMaxUnit, "მინიმალური და მაქსიმალური მნიშვნელობები ჯდება სხვა ჩანაწერის დიაპაზონში.");
                flag = false;
            }

            return flag;
        }
        #endregion

        private void spinMinUnit_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(spinMinUnit);
        }

        private void spinMaxUnit_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(spinMaxUnit);
        }
    }
}
