using System;
using System.Data;
using Apothex.DataType;
using Apothex.Reporting;
using Apothex.Windows.Forms;
using System.Data.SqlClient;
using Apothex.DataManagment.Dictionary;
using Zek.Core;
using Zek.Data;
using Zek.Windows.Forms;

namespace Apothex.Production
{
    public partial class frmProductDistributionDetailList : frmEditDialog
    {
        public frmProductDistributionDetailList()
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
            using (var cmd = new SqlCommand("SELECT * FROM Production.VW_ProductDistributionDetailList WITH (NOLOCK) WHERE StartDate >= @date1 AND StartDate < @date2"))
            {
                cmd.Parameters.Add("@date1", SqlDbType.DateTime).Value = date1;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime).Value = date2;

                ds.VW_ProductDistributionDetailList.Clear();
                ds.VW_ProductDistributionDetailList.Merge(DictionaryManager.GetDataTable(cmd));
            }

            ds.T_RptHeader.Clear();
            ds.T_RptHeader.AddT_RptHeaderRow(date1, date2.AddDays(-1d));
            Print();
            return true;
        }
        protected override void Print()
        {
            ReportFactory.Show(FormHelper.MdiParent, Text, ObjectNames.ProductDistributionDetailList, ds);
        }
    }
}
