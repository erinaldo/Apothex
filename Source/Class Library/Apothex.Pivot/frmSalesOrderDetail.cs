using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using DevExpress.XtraPivotGrid;
using Zek.Core;
using Zek.Data;
using Zek.Extensions;
using Zek.Windows.Forms;
using Apothex.DataType;
using Zek.Windows.Forms.DevEx;

namespace Apothex.Pivot
{
    public partial class frmSalesOrderDetail : frmBrowse
    {
        public frmSalesOrderDetail()
        {
            InitializeComponent();
        }

        protected override void BindControls()
        {
            lookCurrency.Properties.DataSource = DictionaryManager.GetDictionary(ObjectNames.Currency);
        }

        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = SelectAllFromTableWhereStatus + " WHERE 1=1 ";
                if (IsFiltered)
                {
                    var where = new SqlWhereStatement(false);
                    where.AddWhere("PurchaseOrderID", cboxPurchaseOrderID.Text, true, txtPurchaseOrderID.Text.ToNullableInt32());
                    where.AddWhere("PurchaseOrderBranchID", WhereOperator.Equals, true, bbPurchaseOrderBranch.PrimaryKey);
                    where.AddWhere("PurchaseOrderDate", cboxPurchaseOrderDate.Text, true, ConvertHelper.ToNullableDateTime(datePurchaseOrderDate1.EditValue), ConvertHelper.ToNullableDateTime(datePurchaseOrderDate2.EditValue), DateTimePrecision.Days);
                    where.AddWhere("VendorID", cboxVendorID.Text, true, bbVendorID.PrimaryKey);
                    where.AddWhere("VendorName", cboxVendorName.Text, true, txtVendorName.Text.Trim());
                    where.AddWhere("SalesOrderID", cboxSalesOrderID.Text, true, txtSalesOrderID.Text.ToNullableInt32());
                    where.AddWhere("SalesOrderBranchID", WhereOperator.Equals, true, bbSalesOrderBranch.PrimaryKey);

                   

                    //todo filter = FilterHelper.GetWhereClause("SalesOrderDate", cboxSalesOrderDate.Text, ConvertHelper.ToDateTime(dateSalesOrderDate1.EditValue), ConvertHelper.ToDateTime(dateSalesOrderDate2.EditValue), RoundingFormat.None, cmd);
                    //if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    //filter = FilterHelper.GetWhereClause("CustomerID", cboxCustomerID.Text, bbCustomerID.RecordValue);
                    //if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    //filter = FilterHelper.GetWhereClause("CustomerName", cboxCustomerName.Text, txtCustomerName.Text.Trim());
                    //if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    //filter = FilterHelper.GetWhereClause("ProductName", cboxProduct.Text, true, txtProduct.Text.Trim());
                    //if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    //filter = FilterHelper.GetWhereClause("ProductNumber", cboxProductNumber.Text, txtProductNumber.Text.Trim());
                    //if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    //filter = FilterHelper.GetWhereClause("ProductCurrencyCode", "=", lookCurrency.EditValue, SqlDbType.NChar, cmd);
                    //if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    cmd.CommandText += where;
                }
                cmd.CommandText += " ORDER BY SalesOrderDate DESC, SalesOrderID DESC";
                ds.VW_SalesOrderDetailPivot.Clear();
                ds.VW_SalesOrderDetailPivot.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }

 
        protected override void Export()
        {
            if (!IsAllowedExport) return;

            pivotGridControl1.ShowExportToDialog(this, true);
        }

        private void pivotGridControl1_CellDoubleClick(object sender, PivotCellEventArgs e)
        {
            var frm = new Form();
            var grid = new DataGrid();
            frm.Controls.Add(grid);
            grid.Dock = DockStyle.Fill;
            grid.DataSource = e.CreateDrillDownDataSource();
            frm.ShowDialog(this);
            frm.Dispose();
        }

        private void cboxPurchaseOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxPurchaseOrderID.Text, txtPurchaseOrderID);
        }

        private void cboxPurchaseOrderDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxPurchaseOrderDate.Text, datePurchaseOrderDate1, datePurchaseOrderDate2);
        }

        private void cboxSalesOrderDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxSalesOrderDate.Text, dateSalesOrderDate1, dateSalesOrderDate2);
        }

        private void cboxSalesOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxSalesOrderID.Text, txtSalesOrderID);
        }

        private void cboxVendorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxVendorID.Text, bbVendorID);
        }

        private void cboxVendorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxVendorName.Text, txtVendorName);
        }

        private void cboxCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxCustomerID.Text, bbCustomerID);
        }

        private void cboxCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxCustomerName.Text, txtCustomerName);
        }

        private void cboxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxProduct.Text, txtProduct);
        }

        private void cboxProductNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxProductNumber.Text, txtProductNumber);
        }

    }
}
