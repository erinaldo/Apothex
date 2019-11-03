using System;
using Apothex.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using Zek.Core;
using Apothex.DataManagment.Dictionary;
using Apothex.Common;
using Apothex.DataType;
using Apothex.DataManagment.Production;

namespace Apothex.Production
{
    public partial class frmRptRealIncomeExpenceBrowse : frmBrowse
    {
        public frmRptRealIncomeExpenceBrowse()
        {
            InitializeComponent();
            dateFromDate.EditValue = DateTimeHelper.GetStartOfMonth(BaseGlobalVariable.ServerDateTime).AddMonths(-1);
            dateToDate.EditValue = DateTimeHelper.GetStartOfMonth(BaseGlobalVariable.ServerDateTime);
        }

        public bool IsValidFromDate()
        {
            if (dateFromDate.EditValue == null)
            {
                dxErrorProvider.SetError(dateFromDate, "!");
                return false;
            }

            return true;
        }
        public bool IsValidToDate()
        {
            if (dateToDate.EditValue == null)
            {
                dxErrorProvider.SetError(dateToDate, "!");
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var flag = true;
            if (!IsValidFromDate()) flag = false;
            if (!IsValidToDate()) flag = false;
            return flag;
        }

        int _BindGridCount;
        protected override void BindControls()
        {
            bsCurrency.DataSource = DictionaryManager.GetDictionary(ObjectNames.Currency);
            lookCurrency.EditValue = GlobalVariable.MyCompanyDefaultTradingCurrencyCode;
        }
        protected override void BindGrid()
        {
            _BindGridCount++;
            if (_BindGridCount <= 1) return;
            ds.SP_GetRealIncomeExpence.Clear();
            ds.SP_GetRealIncomeExpence.Merge(ProductionManager.GetRealIncomeExpence(ConvertHelper.ToDateTime(dateFromDate.EditValue), ConvertHelper.ToDateTime(dateToDate.EditValue), ConvertHelper.ToString(lookCurrency.EditValue), chkAddVatAmt.Checked, ConvertHelper.ToInt32(bbCustomer.RecordValue)));
        }

        private void dateFromDate_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(dateFromDate, string.Empty);
        }

        private void dateToDate_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(dateToDate, string.Empty);
        }

        private void gridView_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (!e.IsGetData) return;

            switch (e.Column.Name)
            {
                case "colRealIncome":
                    var row = (DS_RealIncomeExpence.SP_GetRealIncomeExpenceRow)gridView.GetDataRow(e.RowHandle);// ds.SP_GetRealIncomeExpence[e.ListSourceRowIndex];
                    e.Value = row.PurchaseOrderTotal + row.IncomingTransferTotal - row.OutgoingTransferTotal;
                    break;
            }
        }
    }
}