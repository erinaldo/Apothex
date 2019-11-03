using System;
using System.Data;
using System.Data.SqlClient;
using Apothex.Windows.Forms;
using Apothex.Common;
using Apothex.DataManagment.Dictionary;
using Zek.Core;
using Apothex.Reporting;

namespace Apothex.Sales
{
    public partial class frmSalesOrderHeaderGroupByDateBrowse : frmBrowse
    {
        public frmSalesOrderHeaderGroupByDateBrowse()
        {
            InitializeComponent();
        }

        #region Bindings
        protected override void BindControls()
        {
            bbBranch.RecordValue = GlobalVariable.BranchID;
            dateOrderDate1.EditValue = BaseGlobalVariable.ServerDateTime.Date.AddDays(-1d);
        }
        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = SelectSql +
@"
*
FROM Sales.FN_T_SalesOrderHeader_GetGroupByDate(@vat)
WHERE " + FilterStatusSql;

                cmd.Parameters.Add("@vat", SqlDbType.Bit).Value = GlobalVariable.VATPayerFlag;

                if (IsFiltered)
                {
                    var filter = string.Empty;


                    filter = FilterHelper.CreateFilter("OrderDate", cboxOrderDate.Text, ConvertHelper.ToDateTime(dateOrderDate1.EditValue), ConvertHelper.ToDateTime(dateOrderDate2.EditValue), RoundingFormat.d, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    if (bbBranch.RecordValue != null)
                    {
                        cmd.CommandText += " AND BranchID = @BranchID";
                        cmd.Parameters.Add("@BranchID", SqlDbType.Int).Value = bbBranch.RecordValue;
                    } 

                }

                cmd.CommandText += " ORDER BY OrderDate DESC, BranchID";

                ds.T_SalesOrderHeaderGroupByDate.Clear();
                ds.T_SalesOrderHeaderGroupByDate.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }
        protected override void Print()
        {
            ReportFactory.Show(MdiParent, Text, ObjectName, ds);
        }
        #endregion

        private void cboxOrderDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxOrderDate.Text, dateOrderDate1, dateOrderDate2);
        }
    }
}