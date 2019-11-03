using System.Data.SqlClient;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;

namespace Apothex.Production
{
    public partial class frmWarehouseDescriptionBrowse : frmBrowse
    {
        public frmWarehouseDescriptionBrowse()
        {
            InitializeComponent();
        }

        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = SelectSql +
@"
*
 FROM Production.VW_WarehouseDescriptionHeader WITH (NOLOCK) 
 WHERE " + FilterStatusSql;

                //if (!IsPermitted(_PermissionAllBranch, Zek.Data.DatabaseActions.View))
                //{
                //    cmd.CommandText += " AND BranchID = @BranchID";
                //    cmd.Parameters.Add("@BranchID", SqlDbType.Int).Value = SelectedBranchID;
                //}

                if (IsFiltered)
                {
                    //if (lookBranch.EditValue != null && IsPermitted(_PermissionAllBranch, Zek.Data.DatabaseActions.View))
                    //{
                    //    cmd.CommandText += " AND BranchID = @BranchID";
                    //    cmd.Parameters.Add("@BranchID", SqlDbType.Int).Value = SelectedBranchID;
                    //}

                    //string filter = string.Empty;


                    //filter = FilterHelper.CreateFilter("SalesOrderID", cboxOrderID.Text, txtOrderID.EditValue, SqlDbType.Int, cmd);
                    //if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    //filter = FilterHelper.CreateFilter("OrderDate", cboxOrderDate.Text, ConvertHelper.ToDateTime(dateOrderDate1.EditValue), ConvertHelper.ToDateTime(dateOrderDate2.EditValue), RoundingFormat.None, cmd);
                    //if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    //filter = FilterHelper.CreateFilter("CustomerID", cboxCustomerID.Text, bbCustomerID.RecordValue, SqlDbType.NVarChar, cmd);
                    //if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    //filter = FilterHelper.CreateFilter("CustomerName", cboxCustomerName.Text, txtCustomerName.Text.Trim(), SqlDbType.NVarChar, cmd);
                    //if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    //filter = FilterHelper.CreateFilter("OverheadNumber", cboxOverheadNumber.Text, txtOverheadNumber.Text.Trim(), SqlDbType.NVarChar, cmd);
                    //if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    //filter = FilterHelper.CreateFilter("SubTotal", cboxSubTotal.Text, spinSubTotal1.Value, spinSubTotal2.Value, SqlDbType.Money, cmd);
                    //if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    //filter = FilterHelper.CreateFilter("TaxAmt", cboxTaxAmt.Text, spinTaxAmt1.Value, spinTaxAmt2.Value, SqlDbType.Money, cmd);
                    //if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    //filter = FilterHelper.CreateFilter("Freight", cboxFreight.Text, spinFreight1.Value, spinFreight2.Value, SqlDbType.Money, cmd);
                    //if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    //filter = FilterHelper.CreateFilter("TotalDue", cboxTotalDue.Text, spinTotalDue1.Value, spinTotalDue2.Value, SqlDbType.Money, cmd);
                    //if (filter.Length > 0) cmd.CommandText += " AND " + filter;


                    //filter = FilterHelper.CreateFilter("CurrencyCode", "=", lookCurrency.EditValue, SqlDbType.NChar, cmd);
                    //if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    //filter = FilterHelper.CreateFilter("PaymentMethodID", "=", lookPaymentMethod.EditValue, SqlDbType.Int, cmd);
                    //if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    //filter = FilterHelper.CreateFilter("RevisionNumber", cboxRevisionNumber.Text, ConvertHelper.ToByte(spinRevisionNumber1.Value), ConvertHelper.ToByte(spinRevisionNumber2.Value), SqlDbType.TinyInt, cmd);
                    //if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    //filter = FilterHelper.CreateFilter("ModifiedUserID", cboxModifier.Text, bbModifier.RecordValue, SqlDbType.Int, cmd);
                    //if (filter.Length > 0) cmd.CommandText += " AND " + filter;
                }

                cmd.CommandText += " ORDER BY Date DESC, WarehouseDescriptionID DESC, BranchID";

                ds.VW_WarehouseDescriptionHeader.Clear();
                ds.VW_WarehouseDescriptionHeader.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }
    }
}
