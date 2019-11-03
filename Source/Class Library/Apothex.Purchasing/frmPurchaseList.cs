using System;
using System.Data;
using Apothex.Reporting;
using Apothex.Windows.Forms;
using System.Data.SqlClient;
using Apothex.DataManagment.Dictionary;
using Zek.Core;
using Zek.Data;
using Zek.Windows.Forms;

namespace Apothex.Purchasing
{
    public partial class frmPurchaseList : frmEditDialog
    {
        public frmPurchaseList()
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
            using (var cmd = new SqlCommand("SELECT * FROM Purchasing.VW_PurchaseOrderHeader WITH (NOLOCK) WHERE OrderDate >= @date1 AND OrderDate < @date2"))
            {
                cmd.Parameters.Add("@date1", SqlDbType.DateTime).Value = date1;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime).Value = date2;

                ds_Purchasing.VW_PurchaseOrderHeader.Clear();
                ds_Purchasing.VW_PurchaseOrderHeader.Merge(DictionaryManager.GetDataTable(cmd));
            }

            ds_Purchasing.T_PurchaseList.Clear();
            ds_Purchasing.T_PurchaseList.AddT_PurchaseListRow(date1, date2.AddDays(-1d));
            Print();
            return true;
        }
        protected override void Print()
        {
            ReportFactory.Show(FormHelper.MdiParent, Text, ObjectName, ds_Purchasing);
        }
    }
}
