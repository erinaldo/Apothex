using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Apothex.Reporting;
using Apothex.Windows.Forms;
using DevExpress.XtraBars;
using Apothex.DataManagment.Dictionary;
using Apothex.Common;
using Zek.Data;
using Zek.Core;
using Zek.Windows.Forms;
using Apothex.DataType;

namespace Apothex.Purchasing
{
    public partial class frmPurchaseOrderBrowse : frmBrowse
    {
        public frmPurchaseOrderBrowse()
        {
            InitializeComponent();
        }

        #region Fields & Properties
        private int _PermissionAllBranch;
        private int SelectedBranchID
        {
            get
            {
                return (IsPermitted(_PermissionAllBranch, DatabaseAction.View) ? ConvertHelper.ToInt32(lookBranch.EditValue) : GlobalVariable.BranchID);
            }
        }
        protected override bool IsAllowedDelete
        {
            get
            {
                var ok = base.IsAllowedDelete;
                if (ok && !IsPermitted(_PermissionAllBranch, DatabaseAction.Delete))
                {
                    foreach (var rowHandle in OptionsGrid.GridView.GetSelectedRows())
                    {
                        if ((int)OptionsGrid.GridView.GetRowCellValue(rowHandle, colBranchID) != GlobalVariable.BranchID)
                        {
                            ok = false;
                            break;
                        }
                    }
                }

                return ok;
            }
        }
        protected override bool IsAllowedApprove
        {
            get
            {
                var ok = base.IsAllowedApprove;
                if (ok)
                {
                    var isAllowed = IsPermitted(_PermissionAllBranch, DatabaseAction.Approve);
                    foreach (var rowHandle in OptionsGrid.GridView.GetSelectedRows())
                    {
                        if (!isAllowed && (int)OptionsGrid.GridView.GetRowCellValue(rowHandle, colBranchID) != GlobalVariable.BranchID)
                        {
                            ok = false;
                            break;
                        }
                    }
                }

                return ok;
            }
        }
        #endregion

        #region Validations
        private bool IsValidDate()
        {
            if (cboxOrderDate.Text == "[ ]" && dateOrderDate1.EditValue != null && dateOrderDate2.EditValue != null && dateOrderDate1.DateTime > dateOrderDate2.DateTime)
            {
                dxErrorProvider.SetError(dateOrderDate2, "დასრულების თარიღი უნდა აღემატებოდეს დაწყების თარიღს.");
                return false;
            }

            return true;
        }
        private bool IsValidSubTotal()
        {
            if (cboxSubTotal.Text == "[ ]" && spinSubTotal1.Value > spinSubTotal2.Value)
            {
                dxErrorProvider.SetError(spinSubTotal2, "საბოლოო მნიშვნელობა უნდა აღემატებოდეს საწყისს.");
                return false;
            }

            return true;
        }
        private bool IsValidTaxAmt()
        {
            if (cboxTaxAmt.Text == "[ ]" && spinTaxAmt1.Value > spinTaxAmt2.Value)
            {
                dxErrorProvider.SetError(spinTaxAmt2, "საბოლოო მნიშვნელობა უნდა აღემატებოდეს საწყისს.");
                return false;
            }

            return true;
        }
        private bool IsValidFreight()
        {
            if (cboxFreight.Text == "[ ]" && spinFreight1.Value > spinFreight2.Value)
            {
                dxErrorProvider.SetError(spinFreight2, "საბოლოო მნიშვნელობა უნდა აღემატებოდეს საწყისს.");
                return false;
            }

            return true;
        }
        private bool IsValidTotalDue()
        {
            if (cboxTotalDue.Text == "[ ]" && spinTotalDue1.Value > spinTotalDue2.Value)
            {
                dxErrorProvider.SetError(spinTotalDue2, "საბოლოო მნიშვნელობა უნდა აღემატებოდეს საწყისს.");
                return false;
            }

            return true;
        }
        public bool IsValidRevisionNumber()
        {
            if (cboxRevisionNumber.Text == "[ ]" && spinRevisionNumber1.Value > spinRevisionNumber2.Value)
            {
                dxErrorProvider.SetError(spinRevisionNumber2, "საბოლოო მნიშვნელობა უნდა აღემატებოდეს საწყისს.");
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var ok = true;

            if (!IsValidDate()) ok = false;

            if (!IsValidSubTotal()) ok = false;
            if (!IsValidTaxAmt()) ok = false;
            if (!IsValidFreight()) ok = false;
            if (!IsValidTotalDue()) ok = false;

            if (!IsValidRevisionNumber()) ok = false;

            return ok;
        }
        #endregion

        #region Bindings
        protected override void BindControls()
        {
            bsBranch.DataSource = DictionaryManager.GetDictionary(ObjectNames.Branch, -1);
            bsCurrency.DataSource = DictionaryManager.GetDictionary(ObjectNames.Currency, -1);
            bsPaymentMethod.DataSource = DictionaryManager.GetDictionary(ObjectNames.PaymentMethod, -1);
        }
        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = SelectSql +
@"
*
FROM Purchasing.VW_PurchaseOrderHeader WITH (NOLOCK)
WHERE " + FilterStatusSql;




                //FilterControlHelper helper = new FilterControlHelper(gridView);
                //string z = helper.GetSQLFilter();
                //SqlData data = helper.GetSQLFilter(true);


                if (!IsPermitted(_PermissionAllBranch, DatabaseAction.View))
                {
                    cmd.CommandText += " AND BranchID = @BranchID";
                    cmd.Parameters.Add("@BranchID", SqlDbType.Int).Value = SelectedBranchID;
                }

                //if (data.Filters.Length > 0)
                //    cmd.CommandText += "AND" + data.Filters;


                if (IsFiltered)
                {
                    var filter = string.Empty;


                    if (lookBranch.EditValue != null && IsPermitted(_PermissionAllBranch, DatabaseAction.View))
                    {
                        cmd.CommandText += " AND BranchID = @BranchID";
                        cmd.Parameters.Add("@BranchID", SqlDbType.Int).Value = SelectedBranchID;
                    }

                    filter = FilterHelper.CreateFilter("PurchaseOrderID", cboxID.Text, txtID.EditValue, SqlDbType.Int, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("OrderDate", cboxOrderDate.Text, ConvertHelper.ToDateTime(dateOrderDate1.EditValue), ConvertHelper.ToDateTime(dateOrderDate2.EditValue), RoundingFormat.None, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("VendorID", cboxVendorID.Text, bbVendorID.RecordValue, SqlDbType.NVarChar, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("VendorName", cboxVendorName.Text, txtVendorName.Text.Trim(), SqlDbType.NVarChar, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("OverheadNumber", cboxOverheadNumber.Text, txtOverheadNumber.Text.Trim(), SqlDbType.NVarChar, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("SubTotal", cboxSubTotal.Text, spinSubTotal1.Value, spinSubTotal2.Value, SqlDbType.Money, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("TaxAmt", cboxTaxAmt.Text, spinTaxAmt1.Value, spinTaxAmt2.Value, SqlDbType.Money, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("Freight", cboxFreight.Text, spinFreight1.Value, spinFreight2.Value, SqlDbType.Money, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("TotalDue", cboxTotalDue.Text, spinTotalDue1.Value, spinTotalDue2.Value, SqlDbType.Money, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    if (lookCurrency.EditValue != null)
                    {
                        cmd.CommandText += " AND CurrencyCode = @CurrencyCode";
                        cmd.Parameters.Add("@CurrencyCode", SqlDbType.NChar).Value = lookCurrency.EditValue;
                    }

                    if (lookPaymentMethod.EditValue != null)
                    {
                        cmd.CommandText += " AND PaymentMethodID = @PaymentMethodID";
                        cmd.Parameters.Add("@PaymentMethodID", SqlDbType.Int).Value = lookPaymentMethod.EditValue;
                    }



                    filter = FilterHelper.CreateFilter("RevisionNumber", cboxRevisionNumber.Text, ConvertHelper.ToByte(spinRevisionNumber1.Value), ConvertHelper.ToByte(spinRevisionNumber2.Value), SqlDbType.TinyInt, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;
                    
                }

                cmd.CommandText += " ORDER BY OrderDate DESC, PurchaseOrderID DESC";

                ds.VW_PurchaseOrderHeader.Clear();
                ds.VW_PurchaseOrderHeader.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }
        #endregion

        #region Methods
        protected override void Print()
        {
            ReportFactory.Show(MdiParent, OptionsBaseForm.Text, ObjectName, ds);
        }
        protected override void Init()
        {
            base.Init();

            _PermissionAllBranch = GlobalVariable.GetPermission((int)ObjectNames.PurchaseOrderHeaderAllBranch);

            lookBranch.Properties.ReadOnly = !IsPermitted(_PermissionAllBranch, DatabaseAction.View);

            miGenerateSales.Enabled = IsPermitted(ObjectNames.SalesOrderHeaderByPurchaseID, DatabaseAction.Add);
        }
        #endregion

        private void cboxOrderDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetError(dateOrderDate1, string.Empty);
            SetError(dateOrderDate2, string.Empty);
            FilterHelper.ShowFilterFields(cboxOrderDate.Text, dateOrderDate1, dateOrderDate2);
        }

        private void dateOrderDate1_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(dateOrderDate1, string.Empty);
            dxErrorProvider.SetError(dateOrderDate2, string.Empty);
        }

        private void dateOrderDate2_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(dateOrderDate1, string.Empty);
            dxErrorProvider.SetError(dateOrderDate2, string.Empty);

        }

        private void cboxFreight_SelectedIndexChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(spinFreight1, string.Empty);
            dxErrorProvider.SetError(spinFreight2, string.Empty);
            FilterHelper.ShowFilterFields(cboxFreight.Text, spinFreight1, spinFreight2);
        }

        private void spinFreight1_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(spinFreight1, string.Empty);
            dxErrorProvider.SetError(spinFreight2, string.Empty);
        }

        private void spinFreight2_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(spinFreight1, string.Empty);
            dxErrorProvider.SetError(spinFreight2, string.Empty);
        }

        private void cboxTaxAmt_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearError(spinTaxAmt1);
            ClearError(spinTaxAmt2);
            FilterHelper.ShowFilterFields(cboxTaxAmt.Text, spinTaxAmt1, spinTaxAmt2);
        }

        private void spinTaxAmt1_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(spinTaxAmt1);
            ClearError(spinTaxAmt2);
        }

        private void spinTaxAmt2_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(spinTaxAmt1);
            ClearError(spinTaxAmt2);
        }

        private void cboxSubTotal_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearError(spinSubTotal1);
            ClearError(spinSubTotal2);
            FilterHelper.ShowFilterFields(cboxSubTotal.Text, spinSubTotal1, spinSubTotal2);
        }

        private void spinSubTotal1_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(spinSubTotal1);
            ClearError(spinSubTotal2);
        }

        private void spinSubTotal2_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(spinSubTotal1);
            ClearError(spinSubTotal2);
        }

        private void cboxTotalDue_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearError(spinTotalDue1);
            ClearError(spinTotalDue2);
            FilterHelper.ShowFilterFields(cboxTotalDue.Text, spinTotalDue1, spinTotalDue2);
        }

        private void spinTotalDue1_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(spinTotalDue1, string.Empty);
            dxErrorProvider.SetError(spinTotalDue2, string.Empty);
        }

        private void spinTotalDue2_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(spinTotalDue1, string.Empty);
            dxErrorProvider.SetError(spinTotalDue2, string.Empty);
        }

        private void cboxRevisionNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(spinRevisionNumber1, string.Empty);
            dxErrorProvider.SetError(spinRevisionNumber2, string.Empty);
            FilterHelper.ShowFilterFields(cboxRevisionNumber.Text, spinRevisionNumber1, spinRevisionNumber2);
        }

        private void spinRevisionNumber1_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(spinRevisionNumber1, string.Empty);
            dxErrorProvider.SetError(spinRevisionNumber2, string.Empty);
        }

        private void spinRevisionNumber2_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(spinRevisionNumber1, string.Empty);
            dxErrorProvider.SetError(spinRevisionNumber2, string.Empty);
        }

        private void cboxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxID.Text, txtID);
        }

        private void cboxOverheadNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxOverheadNumber.Text, txtOverheadNumber);
        }

        private void cboxVendorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxVendorID.Text, bbVendorID);
        }

        private void cboxVendorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxVendorName.Text, txtVendorName);
        }

        private void miGenerateSales_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!IsPermitted(ObjectNames.SalesOrderHeaderByPurchaseID, DatabaseAction.Add) || gridView.SelectedRowsCount == 0) return;

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                var id = ConvertHelper.ToInt32(OptionsGrid.SelectedRecordID);
                if (id == 0) return;
                Zek.Windows.Forms.IForm frm = FormHelper.CreateInstance((int)ObjectNames.SalesOrderHeader, Zek.Windows.Forms.FormStyle.Edit, MdiParent);
                frm.InvokeAction("PurchaseOrderID", id);
                frm.Show();
                frm.BringToFront();
            }
            catch (Exception ex)
            {
                ExceptionHelper.Show(ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}