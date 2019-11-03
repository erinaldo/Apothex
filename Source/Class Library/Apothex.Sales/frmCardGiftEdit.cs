using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Apothex.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using Zek.Core;
using Apothex.DataManagment.Operation;
using Apothex.DataType;
using Apothex.DataManagment.Dictionary;
using Apothex.DataManagment.Card;
using Apothex.Configuration;
using Apothex.DataManagment.Person;
using Apothex.DataManagment.Sales;
using Zek.Data;
using Zek.Properties;

namespace Apothex.Sales
{
    public partial class frmCardGiftEdit : frmEditDialog
    {
        public frmCardGiftEdit()
        {
            InitializeComponent();
        }

        private int ID
        {
            get { return ConvertHelper.ToInt32(PrimaryKey); }
            set { PrimaryKey = value; }
        }
        private string CardNumber
        {
            get { return txtCardNumber.Text.Trim(); }
            set { txtCardNumber.Text = value; }
        }
        public DS_Card.T_CardHandleDataTable T_CardHandle
        {
            get
            {
                var amount = 0m;
                foreach (var row in ds_Operation.T_Operation)
                {
                    if (DataSetHelper.IsDataRowDeleted(row) || row.TypeID != (byte)OperationType.Gift) continue;

                    amount += row.Amount;
                }

                var unit = (spinTotalUnit.Value / spinTotalAmount.Value) * amount;//CardManager.GetCardUnitRateUnit(amount, true) * amount;

                var table = new DS_Card.T_CardHandleDataTable();
                table.AddT_CardHandleRow(ID, CardNumber, -amount, -unit, BaseGlobalVariable.ServerDateTime, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, BaseGlobalVariable.UserID);

                return table;
            }
        }

        #region Validations
        private bool IsValidCardNumber()
        {
            if (CardNumber.Length == 0)
            {
                SetError(txtCardNumber, Exceptions.ValueIsEmtpyErrorText);
                txtCardNumber.SelectAll();
                return false;
            }
            else if (ds_Card.T_Card.Count == 0)
            {
                SetError(txtCardNumber, Exceptions.RecordNotFoundErrorText);
                txtCardNumber.SelectAll();
                return false;
            }
            else if (ds_Card.T_Card[0].StatusID != (byte)DatabaseStatus.Approved)
            {
                SetError(txtCardNumber, "ბარათს არ აქვს დადასტურების სტატუსი.");
                txtCardNumber.SelectAll();
                return false;
            }


            return true;
        }
        private bool IsValidGrid()
        {
            BindingOrder();
            BindingBonusAccumulation();

            viewOperation.CloseEditor();
            bsOperation.EndEdit();

            var valid = true;
            var opTypes = new List<byte>();
            var total = 0m;

            var isGiftRowExists = false;
            foreach (var row in ds_Operation.T_Operation)
            {
                if (DataSetHelper.IsDataRowDeleted(row)) continue;

                row.ClearErrors();
                if (row.TypeID == 0)
                {
                    valid = false;
                    row.SetColumnError(ds_Operation.T_Operation.TypeIDColumn, Exceptions.ValueIsEmtpyErrorText);
                }
                else if (opTypes.Contains(row.TypeID))
                {
                    valid = false;
                    row.SetColumnError(ds_Operation.T_Operation.TypeIDColumn, Exceptions.ValueIsDuplicatedErrorText);
                }
                else opTypes.Add(row.TypeID);

                if (row.Amount <= 0m)
                {
                    valid = false;
                    row.SetColumnError(ds_Operation.T_Operation.AmountColumn, Exceptions.ValueIsEmtpyErrorText);
                }
                
                if (row.TypeID == (byte)OperationType.Gift)
                {
                    isGiftRowExists = true;
                    if (row.Amount > spinTotalAmount.Value)
                    {
                        valid = false;
                        row.SetColumnError(ds_Operation.T_Operation.AmountColumn, "თანხა აჭარბებს დაგროვილ ქულებს.");
                    }
                }

                total += row.Amount;
            }
            
            if (!isGiftRowExists)
            {
                valid = false;
                XtraMessageBox.Show("საჩუქრის ოპერაცია არ მოიძებნა, გადახედეთ ცხრილს.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (total != spinTotalDue.Value)
            {
                valid = false;
                XtraMessageBox.Show("ოპერაციების ჯამი არ ემთხვევა ფაქტურის თანხას.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return valid;
        }
        protected override bool IsValidForm()
        {
            var valid = true;
            if (!IsValidCardNumber()) valid = false;
            if (!IsValidGrid()) valid = false;
            return valid;
        }
        #endregion

        #region Bindings
        protected override void BindControls()
        {
            bsOpType.DataSource = DictionaryManager.GetDictionaryInt(ObjectNames.OperationType);
        }
        private void BindingCard()
        {
            ds_Card.T_Card.Clear();
            bbPerson.RecordValue = null;

            if (CardNumber.Length > 0)
            {
                var id = CardManager.GetCardID(CardNumber);
                if (id > 0)
                {
                    ds_Card.T_Card.Merge(CardManager.GetCard(id));
                    if (ds_Card.T_Card.Count > 0)
                    {
                        bbPerson.RecordValue = ds_Card.T_Card[0].PersonID;
                        BindingBonusAccumulation();
                    }
                }
            }
        }
        private void BindingBonusAccumulation()
        {
            spinTotalAmount.Value = 0m;
            spinTotalUnit.Value = 0m;

            if (CardNumber.Length > 0)
            {
                var info = CardManager.GetCardInfo(CardNumber);
                if (info.Count == 0) return;
                spinTotalAmount.Value = info[0].CurrentCardTotalAmount;
                spinTotalUnit.Value = info[0].CurrentCardTotalUnit;
            }
        }
        private void BindingOrder()
        {
            ds_Sales.SP_GetSalesOrderHeader.Clear();
            ds_Sales.SP_GetSalesOrderHeader.Merge(SalesManager.GetSalesOrderHeader(ID, IsOnline));

            if (ds_Sales.SP_GetSalesOrderHeader.Count == 0)
                throw new ArgumentException(Exceptions.RecordNotFoundErrorText);

            spinTotalDue.Value = ds_Sales.SP_GetSalesOrderHeader[0].TotalDue;
        }
        protected override void BindData()
        {
            if (ID == 0)
                throw new ArgumentException(Exceptions.RecordNotFoundErrorText);

            ds_Card.T_CardHandle.Clear();
            ds_Card.T_CardHandle.Merge(CardManager.GetCardHandle(ID, IsOnline));
            if (ds_Card.T_CardHandle.Count > 0 && ds_Card.T_CardHandle[0].Amount > 0m)
            {
                throw new Exception("ამ ფაქტურაზე უკვე გატარებულია ბარათი. საჩუქრის გაცემისას ფაქტურაზე არ უნდა იყოს ბარათის გატარება განხორციელებული.");
            }
            else if (ds_Card.T_CardHandle.Count > 0 && ds_Card.T_CardHandle[0].Amount < 0m)
            {
                throw new Exception("ამ ფაქტურაზე უკვე გაცემულია საჩუქარი.");
                //CardNumber = handle[0].CardNumber;
                //BindingCard();
            }

            BindingOrder();

            if (!ConfigurationManagerEx.IsOnline)
            {
                ds_Operation.T_Operation.Clear();
                ds_Operation.T_Operation.Merge(OperationManager.Get(ObjectNames.SalesOrderHeader, ID));
            }
        }
        #endregion

        protected override bool SaveData()
        {
            return true;
        }
        private void InitGiftOperationRow()
        {
            var rowIndex = -1;
            var firstNonGiftRowIndex = -1;
            for (var i = 0; i < ds_Operation.T_Operation.Count; i++)
            {
                if (DataSetHelper.IsDataRowDeleted(ds_Operation.T_Operation[i])) continue;

                if (rowIndex == -1 && ds_Operation.T_Operation[i].TypeID == (byte)OperationType.Gift)
                    rowIndex = i;
                else if (firstNonGiftRowIndex == -1)
                    firstNonGiftRowIndex = i;
            }

            
            if (rowIndex == -1)
                AddNewRow(Math.Min(spinTotalAmount.Value, spinTotalDue.Value), OperationType.Gift);
            else
                ds_Operation.T_Operation[rowIndex].Amount = Math.Min(spinTotalAmount.Value, spinTotalDue.Value);

            if (spinTotalAmount.Value < spinTotalDue.Value)
            {
                if (firstNonGiftRowIndex == -1)
                    AddNewRow(spinTotalDue.Value - spinTotalAmount.Value, OperationType.Cash);
                else
                    ds_Operation.T_Operation[firstNonGiftRowIndex].Amount = spinTotalDue.Value - spinTotalAmount.Value;
            }
        }
        private void AddNewRow(decimal amount, OperationType operationType)
        {
            ds_Operation.T_Operation.AddT_OperationRow(ds_Sales.SP_GetSalesOrderHeader[0].OrderDate, amount, ds_Sales.SP_GetSalesOrderHeader[0].CurrencyCode, (byte)operationType, BaseGlobalVariable.ServerDateTime, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, BaseGlobalVariable.UserID, Guid.NewGuid());
        }

        private void txtCardNumber_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Return:
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    
                    BindingCard();
                    if (!IsValidCardNumber()) return;
                    InitGiftOperationRow();
                    break;
            }
        }

        private void bbPerson_PrimaryKeyChanged(object sender, EventArgs e)
        {
            txtPersonalNumber.Text = string.Empty;
            if (bbPerson.RecordValue == null) return;

            var person = PersonManager.GetPerson(ConvertHelper.ToInt32(bbPerson.RecordValue));
            if (person.Count == 0) return;
            txtPersonalNumber.Text = person[0].PersonalNumber;
        }

        private void txtCardNumber_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(txtCardNumber);
        }

        private void gridOperation_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            switch (e.Button.ButtonType)
            {
                case NavigatorButtonType.Append:
                    e.Handled = true;
                    AddNewRow(0m, OperationType.None);
                    break;
            }
        }

        private void viewOperation_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            viewOperation.UpdateTotalSummary();
            var row = (DS_Operation.T_OperationRow)viewOperation.GetFocusedDataRow();
            DataSetHelper.ClearDataRowColumnError(row, e.Column.FieldName);
        }
    }
}