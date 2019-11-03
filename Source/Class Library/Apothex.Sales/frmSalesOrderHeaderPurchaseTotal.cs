using System;
using System.Data;
using System.Data.SqlClient;
using Apothex.Common;
using Apothex.DataManagment.Dictionary;
using Apothex.DataType;
using Apothex.Reporting;
using Apothex.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using Zek.Core;
using Zek.Windows.Forms;

namespace Apothex.Sales
{
    public partial class frmSalesOrderHeaderPurchaseTotal : frmBrowse
    {
        public frmSalesOrderHeaderPurchaseTotal()
        {
            InitializeComponent();
        }

        #region Bindings
        protected override void BindControls()
        {
            bsBranch.DataSource = DictionaryManager.GetDictionary(ObjectNames.Branch);
            lookBranch.EditValue = GlobalVariable.BranchID.ToString();
        }
        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = SelectSql +
@"
*
FROM dbo.FN_GetSalesOrderHeaderPurchaseTotal(@VATPayerFlag)
WHERE " + FilterStatusSql;

                cmd.Parameters.Add("@VATPayerFlag", SqlDbType.Bit).Value = GlobalVariable.VATPayerFlag;

                if (IsFiltered)
                {
                    if (lookBranch.EditValue != null)
                    {
                        cmd.CommandText += " AND BranchID = @BranchID";
                        cmd.Parameters.Add("@BranchID", SqlDbType.Int).Value = ConvertHelper.ToInt32(lookBranch.EditValue);
                    }

                    var filter = string.Empty;


                    filter = FilterHelper.CreateFilter("SalesOrderID", cboxOrderID.Text, txtOrderID.EditValue, SqlDbType.Int, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;


                    filter = FilterHelper.CreateFilter("OrderDate", cboxOrderDate.Text, ConvertHelper.ToDateTime(dateOrderDate1.EditValue), ConvertHelper.ToDateTime(dateOrderDate2.EditValue), RoundingFormat.None, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;


                   
                }

                cmd.CommandText += " ORDER BY OrderDate DESC, SalesOrderID DESC, BranchID";

                ds.FN_GetSalesOrderHeaderPurchaseTotal.Clear();
                ds.FN_GetSalesOrderHeaderPurchaseTotal.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }
        #endregion

        protected override void Print()
        {
            ReportFactory.Show(MdiParent, Text, ObjectName, ds.FN_GetSalesOrderHeaderPurchaseTotal);
        }

        private void cboxOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxOrderID.Text, txtOrderID);
        }

        private void cboxOrderDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxOrderDate.Text, dateOrderDate1, dateOrderDate2);
        }

        private void gridView_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (!e.IsGetData) return;

            var row = ds.FN_GetSalesOrderHeaderPurchaseTotal[e.ListSourceRowIndex];
            switch (e.Column.Name)
            {
                case "colPurchaseTotalDue":
                    e.Value = row.PurchaseSubTotal + row.PurchaseTaxAmt;
                    break;

                case "colWon":
                    e.Value = row.SalesSubTotal + row.SalesTaxAmt - row.PurchaseSubTotal + row.PurchaseTaxAmt;
                    break;

            }
        }
    }
}