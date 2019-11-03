using System;
using System.Data;
using Apothex.Reporting;
using Apothex.Windows.Forms;
using System.Data.SqlClient;
using Apothex.DataManagment.Dictionary;
using Zek.Core;
using Zek.Data;
using Zek.Windows.Forms;
using Apothex.DataType;

namespace Apothex.Sales
{
    public partial class frmSalesOrderDetailList : frmEditDialog
    {
        public frmSalesOrderDetailList()
        {
            InitializeComponent();
            Action = DatabaseAction.Print;
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(dateEdit1);
        }

        private void dateEdit2_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(dateEdit2);
        }

        protected override void BindControls()
        {
            bsPaymentMethod.DataSource = DictionaryManager.GetDictionary(ObjectNames.PaymentMethod);
        }
        protected override bool IsValidForm()
        {
            var flag = true;
            if (dateEdit1.EditValue == null)
            {
                SetError(dateEdit1, "მნიშვნელობა არ შეიძლება იყოს ცარიელი.");
                flag = false;
            }
            if (dateEdit2.EditValue == null)
            {
                SetError(dateEdit2, "მნიშვნელობა არ შეიძლება იყოს ცარიელი.");
                flag = false;
            }
            return flag;
        }
        protected override bool SaveData()
        {
            var date1 = ConvertHelper.ToDateTime(dateEdit1.EditValue);
            var date2 = ConvertHelper.ToDateTime(dateEdit2.EditValue).AddDays(1d);
            var paymentMethodID = ConvertHelper.ToInt32(lookPaymentMethod.EditValue);
            using (var cmd = new SqlCommand("SELECT * FROM Sales.VW_SalesOrderDetailList WITH (NOLOCK) WHERE OrderDate >= @date1 AND OrderDate < @date2"))
            {
                cmd.Parameters.Add("@date1", SqlDbType.DateTime).Value = date1;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime).Value = date2;
                if (paymentMethodID != 0)
                {
                    cmd.CommandText += " AND PaymentMethodID = @paymentMethodID";
                    cmd.Parameters.Add("@paymentMethodID", SqlDbType.Int).Value = paymentMethodID;
                }

                ds.VW_SalesOrderDetailList.Clear();
                ds.VW_SalesOrderDetailList.Merge(DictionaryManager.GetDataTable(cmd));
            }

            ds.T_RptHeader.Clear();
            ds.T_RptHeader.AddT_RptHeaderRow(date1, date2.AddDays(-1d));
            Print();
            return true;
        }
        protected override void Print()
        {
            ReportFactory.Show(FormHelper.MdiParent, Text, ObjectNames.SalesOrderDetailList, ds);
        }
    }
}
