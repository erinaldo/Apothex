using System;
using System.Data;
using System.Data.SqlClient;
using Apothex.DataManagment.Dictionary;
using Apothex.Windows.Forms;
using Zek.Core;
using Apothex.DataType;

namespace Apothex.Sales
{
    public partial class frmSalesOrderDetailInfoVendorBrowse : frmBrowse
    {
        public frmSalesOrderDetailInfoVendorBrowse()
        {
            InitializeComponent();
        }

        protected override void BindControls()
        {
            lookProductCurrencyCode.Properties.DataSource = DictionaryManager.GetDictionary(ObjectNames.Currency);
        }
        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = @SelectSql +
@"
*
FROM Sales.VW_SalesOrderDetailInfoVendor
WHERE " + FilterStatusSql;

                //if (!IsAllowed(_PermissionAllBranch, Zek.Data.DatabaseActions.View))
                //{
                //    cmd.CommandText += " AND BranchID = @BranchID";
                //    cmd.Parameters.Add("@BranchID", SqlDbType.Int).Value = SelectedBranchID;
                //}

                if (IsFiltered)
                {
                    //if (lookBranch.EditValue != null && IsAllowed(_PermissionAllBranch, Zek.Data.DatabaseActions.View))
                    //{
                    //    cmd.CommandText += " AND BranchID = @BranchID";
                    //    cmd.Parameters.Add("@BranchID", SqlDbType.Int).Value = SelectedBranchID;
                    //}


                    var filter = string.Empty;


                    filter = FilterHelper.CreateFilter("PurchaseOrderID", cboxPurchaseOrderID.Text, txtPurchaseOrderID.EditValue, SqlDbType.Int, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    if (bbPurchaseOrderBranch.RecordValue != null)
                    {
                        cmd.CommandText += " AND PurchaseOrderBranchID = @PurchaseOrderBranchID";
                        cmd.Parameters.Add("@PurchaseOrderBranchID", SqlDbType.Int).Value = bbPurchaseOrderBranch.RecordValue;
                    } 

                    filter = FilterHelper.CreateFilter("PurchaseOrderDate", cboxPurchaseOrderDate.Text, ConvertHelper.ToDateTime(datePurchaseOrderDate1.EditValue), ConvertHelper.ToDateTime(datePurchaseOrderDate2.EditValue), RoundingFormat.None, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;


                    if (bbVendor.RecordValue != null)
                    {
                        cmd.CommandText += " AND VendorID = @VendorID";
                        cmd.Parameters.Add("@VendorID", SqlDbType.Int).Value = bbVendor.RecordValue;
                    }


                    filter = FilterHelper.CreateFilter("SalesOrderID", cboxSalesOrderID.Text, txtSalesOrderID.EditValue, SqlDbType.Int, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    if (bbSalesOrderBranch.RecordValue != null)
                    {
                        cmd.CommandText += " AND SalesOrderBranchID = @SalesOrderBranchID";
                        cmd.Parameters.Add("@SalesOrderBranchID", SqlDbType.Int).Value = bbSalesOrderBranch.RecordValue;
                    } 

                    filter = FilterHelper.CreateFilter("SalesOrderDate", cboxSalesOrderDate.Text, ConvertHelper.ToDateTime(dateSalesOrderDate1.EditValue), ConvertHelper.ToDateTime(dateSalesOrderDate2.EditValue), RoundingFormat.None, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;


                    if (bbCustomer.RecordValue != null)
                    {
                        cmd.CommandText += " AND CustomerID = @CustomerID";
                        cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = bbCustomer.RecordValue;
                    }

                    filter = FilterHelper.CreateFilter("MedicamentName", cboxProduct.Text, txtProduct.Text.Trim(), SqlDbType.NVarChar, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("ProductCurrencyCode", "=", lookProductCurrencyCode.EditValue, SqlDbType.NChar, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;
                }

                cmd.CommandText += " ORDER BY SalesOrderDate DESC, SalesOrderBranchID";

                ds.VW_SalesOrderDetailInfoVendor.Clear();
                ds.VW_SalesOrderDetailInfoVendor.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }

        private void cboxPurchaseOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxPurchaseOrderID.Text, txtPurchaseOrderID);
        }

        private void cboxPurchaseOrderDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxPurchaseOrderDate.Text, datePurchaseOrderDate1, datePurchaseOrderDate2);
        }

        private void cboxSalesOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxSalesOrderID.Text, txtSalesOrderID);
        }

        private void cboxSalesOrderDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxSalesOrderDate.Text, dateSalesOrderDate1, dateSalesOrderDate2);
        }

        private void cboxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxProduct.Text, txtProduct);
        }
    }
}