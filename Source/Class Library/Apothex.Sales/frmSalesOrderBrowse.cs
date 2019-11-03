using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Apothex.Reporting;
using Apothex.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

using Apothex.Common;
using Apothex.DataManagment.Dictionary;
using Zek.Core;
using Zek.Windows.Forms;
using Apothex.Configuration;
using Zek.Data;
using Apothex.DataManagment.Synchronization;
using Apothex.DataType;
using Apothex.DataManagment.Card;
using Apothex.DataManagment.Sales;

namespace Apothex.Sales
{
    public partial class frmSalesOrderBrowse : frmBrowse
    {
        public frmSalesOrderBrowse()
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
                SetError(dateOrderDate2, "დასრულების თარიღი უნდა აღემატებოდეს დაწყების თარიღს.");
                return false;
            }

            return true;
        }
        private bool IsValidSubTotal()
        {
            if (cboxSubTotal.Text == "[ ]" && spinSubTotal1.Value > spinSubTotal2.Value)
            {
                SetError(spinSubTotal2, "საბოლოო მნიშვნელობა უნდა აღემატებოდეს საწყისს.");
                return false;
            }

            return true;
        }
        private bool IsValidTaxAmt()
        {
            if (cboxTaxAmt.Text == "[ ]" && spinTaxAmt1.Value > spinTaxAmt2.Value)
            {
                SetError(spinTaxAmt2, "საბოლოო მნიშვნელობა უნდა აღემატებოდეს საწყისს.");
                return false;
            }

            return true;
        }
        private bool IsValidFreight()
        {
            if (cboxFreight.Text == "[ ]" && spinFreight1.Value > spinFreight2.Value)
            {
                SetError(spinFreight2, "საბოლოო მნიშვნელობა უნდა აღემატებოდეს საწყისს.");
                return false;
            }

            return true;
        }
        private bool IsValidTotalDue()
        {
            if (cboxTotalDue.Text == "[ ]" && spinTotalDue1.Value > spinTotalDue2.Value)
            {
                SetError(spinTotalDue2, "საბოლოო მნიშვნელობა უნდა აღემატებოდეს საწყისს.");
                return false;
            }

            return true;
        }
        public bool IsValidRevisionNumber()
        {
            if (cboxRevisionNumber.Text == "[ ]" && spinRevisionNumber1.Value > spinRevisionNumber2.Value)
            {
                SetError(spinRevisionNumber2, "საბოლოო მნიშვნელობა უნდა აღემატებოდეს საწყისს.");
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
            bsBranch.DataSource = DictionaryManager.GetDictionary(ObjectNames.Branch, -1, !ConfigurationManagerEx.OfflineMode);
            lookBranch.EditValue = GlobalVariable.BranchID.ToString();
            bsCurrency.DataSource = DictionaryManager.GetDictionary(ObjectNames.Currency, !ConfigurationManagerEx.OfflineMode);
            bsPaymentMethod.DataSource = DictionaryManager.GetDictionary(ObjectNames.PaymentMethod, !ConfigurationManagerEx.OfflineMode);

            if (!IsPermitted(ObjectNames.SalesOrderHeaderAllModifierFilter, DatabaseAction.View))
                bbModifier.RecordValue = BaseGlobalVariable.UserID;

            dateOrderDate1.EditValue = BaseGlobalVariable.ServerDateTime.Date;
            dateOrderDate2.EditValue = BaseGlobalVariable.ServerDateTime.Date.AddDays(1d);
        }
        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = SelectAllFromTableWhereStatus;

                if (!IsPermitted(_PermissionAllBranch, DatabaseAction.View))
                {
                    cmd.CommandText += " AND BranchID = @BranchID";
                    cmd.Parameters.Add("@BranchID", SqlDbType.Int).Value = SelectedBranchID;
                }

                if (IsFiltered)
                {
                    if (lookBranch.EditValue != null && IsPermitted(_PermissionAllBranch, DatabaseAction.View))
                    {
                        cmd.CommandText += " AND BranchID = @BranchID";
                        cmd.Parameters.Add("@BranchID", SqlDbType.Int).Value = SelectedBranchID;
                    }

                    var filter = string.Empty;


                    filter = FilterHelper.CreateFilter("SalesOrderID", cboxOrderID.Text, txtOrderID.EditValue, SqlDbType.Int, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("OrderDate", cboxOrderDate.Text, ConvertHelper.ToDateTime(dateOrderDate1.EditValue), ConvertHelper.ToDateTime(dateOrderDate2.EditValue), RoundingFormat.None, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("CustomerID", cboxCustomerID.Text, bbCustomerID.RecordValue, SqlDbType.NVarChar, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("CustomerName", cboxCustomerName.Text, txtCustomerName.Text.Trim(), SqlDbType.NVarChar, cmd);
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


                    filter = FilterHelper.CreateFilter("CurrencyCode", "=", lookCurrency.EditValue, SqlDbType.NChar, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("PaymentMethodID", "=", lookPaymentMethod.EditValue, SqlDbType.Int, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("RevisionNumber", cboxRevisionNumber.Text, ConvertHelper.ToByte(spinRevisionNumber1.Value), ConvertHelper.ToByte(spinRevisionNumber2.Value), SqlDbType.TinyInt, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("ModifiedUserID", cboxModifier.Text, bbModifier.RecordValue, SqlDbType.Int, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;
                }

                cmd.CommandText += " ORDER BY OrderDate DESC, SalesOrderID DESC, BranchID";

                ds.VW_SalesOrderHeader.Clear();
                ds.VW_SalesOrderHeader.Merge(DictionaryManager.GetDataTable(cmd, ConfigurationManagerEx.IsOnline));
                IsOnline = ConfigurationManagerEx.IsOnline;
            }
        }
        #endregion

        #region Methods
        protected override void EnableDisableToolbar()
        {
            base.EnableDisableToolbar();
            miSynchronize.Enabled = ConfigurationManagerEx.OfflineMode && IsPermitted(ObjectNames.Synchronize, DatabaseAction.Add) && gridView.SelectedRowsCount == 1;
            miGeneratePurchase.Enabled = IsPermitted(ObjectNames.PurchaseOrderHeader, DatabaseAction.Add) && gridView.SelectedRowsCount == 1;
            iCardGift.Enabled = gridView.SelectedRowsCount == 1;
            btnAct.Enabled = IsOnline && gridView.SelectedRowsCount == 1 && IsPermitted(DatabaseAction.Print);
        }
        protected override void Init()
        {
            base.Init();

            _PermissionAllBranch = GlobalVariable.GetPermission((int)ObjectNames.SalesOrderHeaderAllBranch);

            lookBranch.Properties.ReadOnly = !IsPermitted(_PermissionAllBranch, DatabaseAction.View);
        }
        protected override void Print()
        {
            ReportFactory.Show(MdiParent, OptionsBaseForm.Text, ObjectName, ds);
        }
        protected override void ActionRecord(int rowHandle, ActionRecordEventArgs e)
        {
            DictionaryManager.ActionRecord(ObjectName, e.ParamInt, e.ParamString, e.ParamDateTime, e.ParamGuid, 0, string.Empty, DateTimeHelper.MinDate, Guid.Empty, e.Action, BaseGlobalVariable.UserID, IsOnline);
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
            SetError(dateOrderDate1, string.Empty);
            SetError(dateOrderDate2, string.Empty);
        }

        private void dateOrderDate2_EditValueChanged(object sender, EventArgs e)
        {
            SetError(dateOrderDate1, string.Empty);
            SetError(dateOrderDate2, string.Empty);
        }

        private void cboxFreight_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetError(spinFreight1, string.Empty);
            SetError(spinFreight2, string.Empty);
            FilterHelper.ShowFilterFields(cboxFreight.Text, spinFreight1, spinFreight2);
        }

        private void spinFreight1_EditValueChanged(object sender, EventArgs e)
        {
            SetError(spinFreight1, string.Empty);
            SetError(spinFreight2, string.Empty);
        }

        private void spinFreight2_EditValueChanged(object sender, EventArgs e)
        {
            SetError(spinFreight1, string.Empty);
            SetError(spinFreight2, string.Empty);
        }

        private void cboxTaxAmt_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetError(spinTaxAmt1, string.Empty);
            SetError(spinTaxAmt2, string.Empty);
            FilterHelper.ShowFilterFields(cboxTaxAmt.Text, spinTaxAmt1, spinTaxAmt2);
        }

        private void spinTaxAmt1_EditValueChanged(object sender, EventArgs e)
        {
            SetError(spinTaxAmt1, string.Empty);
            SetError(spinTaxAmt2, string.Empty);
        }

        private void spinTaxAmt2_EditValueChanged(object sender, EventArgs e)
        {
            SetError(spinTaxAmt1, string.Empty);
            SetError(spinTaxAmt2, string.Empty);
        }

        private void cboxSubTotal_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetError(spinSubTotal1, string.Empty);
            SetError(spinSubTotal2, string.Empty);
            FilterHelper.ShowFilterFields(cboxSubTotal.Text, spinSubTotal1, spinSubTotal2);
        }

        private void spinSubTotal1_EditValueChanged(object sender, EventArgs e)
        {
            SetError(spinSubTotal1, string.Empty);
            SetError(spinSubTotal2, string.Empty);
        }

        private void spinSubTotal2_EditValueChanged(object sender, EventArgs e)
        {
            SetError(spinSubTotal1, string.Empty);
            SetError(spinSubTotal2, string.Empty);
        }

        private void cboxTotalDue_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetError(spinTotalDue1, string.Empty);
            SetError(spinTotalDue2, string.Empty);
            FilterHelper.ShowFilterFields(cboxTotalDue.Text, spinTotalDue1, spinTotalDue2);
        }

        private void spinTotalDue1_EditValueChanged(object sender, EventArgs e)
        {
            SetError(spinTotalDue1, string.Empty);
            SetError(spinTotalDue2, string.Empty);
        }

        private void spinTotalDue2_EditValueChanged(object sender, EventArgs e)
        {
            SetError(spinTotalDue1, string.Empty);
            SetError(spinTotalDue2, string.Empty);
        }

        private void cboxRevisionNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetError(spinRevisionNumber1, string.Empty);
            SetError(spinRevisionNumber2, string.Empty);
            FilterHelper.ShowFilterFields(cboxRevisionNumber.Text, spinRevisionNumber1, spinRevisionNumber2);
        }

        private void spinRevisionNumber1_EditValueChanged(object sender, EventArgs e)
        {
            SetError(spinRevisionNumber1, string.Empty);
            SetError(spinRevisionNumber2, string.Empty);
        }

        private void spinRevisionNumber2_EditValueChanged(object sender, EventArgs e)
        {
            SetError(spinRevisionNumber1, string.Empty);
            SetError(spinRevisionNumber2, string.Empty);
        }

        private void cboxOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxOrderID.Text, txtOrderID);
        }

        private void cboxOverheadNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxOverheadNumber.Text, txtOverheadNumber);
        }

        private void cboxCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxCustomerName.Text, txtCustomerName);
        }

        private void cboxCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxCustomerID.Text, bbCustomerID);
        }

        private void cboxModifier_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxModifier.Text, bbModifier);
        }

        //private void SyncOrder(int id)
        //{
        //    SyncOrder(id, null, null);
        //}
        //private void SyncOrder(int id, DataTable cardhandle, DataTable operation)
        //{
        //    DateTime serverDateTime = SynchronizationManager.GetDate(ObjectNames.None, true);
        //    var header = Apothex.DataManagment.Sales.SalesManager.GetSalesOrderHeader(id, false);
        //    var detail = Apothex.DataManagment.Sales.SalesManager.GetSalesOrderDetail(id, false);


        //    if (cardhandle == null) cardhandle = CardManager.GetCardHandle(id, false);
        //    if (operation == null) operation = new DS_Operation.T_OperationDataTable();//OperationManager.Get(id, false);

        //    using (DataSet ds = new DataSet("root"))
        //    {
        //        DataSetHelper.RemoveColumns(header, true,
        //                                header.SalesOrderIDColumn,
        //                                header.BranchIDColumn,
        //                                header.OrderDateColumn,
        //                                header.OverheadNumberColumn,
        //                                header.CustomerIDColumn,
        //                                header.SubTotalColumn,
        //                                header.TaxAmtColumn,
        //                                header.FreightColumn,
        //                                header.CurrencyCodeColumn,
        //                                header.CurrencyRateIDColumn,
        //                                header.PaymentMethodIDColumn,
        //                                header.RevisionNumberColumn,
        //                                header.StatusColumn,
        //                                header.ModifiedUserIDColumn,
        //                                header.ModifiedDateColumn,
        //                                header.ApproverUserIDColumn,
        //                                header.rowguidColumn
        //                                );

        //        DataSetHelper.RemoveColumns(detail, true, detail.SalesOrderDetailIDColumn,
        //                                detail.SalesOrderIDColumn,
        //                                detail.ProductLocationIDColumn,
        //                                detail.SaleQtyColumn,
        //                                detail.UnitPriceColumn,
        //                                detail.UnitPriceDiscountColumn,
        //                                detail.OrdinalNumberColumn,
        //                                detail.ModifiedUserIDColumn,
        //                                detail.ModifiedDateColumn,
        //                                detail.ActionColumn
        //                                );
        //        ds.Tables.Add(header);
        //        ds.Tables.Add(detail);
        //        ds.Tables.Add(cardhandle);
        //        ds.Tables.Add(operation);

        //        DataSetHelper.SetColumnMappingType(ds);
        //        SynchronizationManager.Synchronize(ObjectNames.SalesOrderHeader, GlobalVariable.UserID, GlobalVariable.ServerDateTime, DatabaseAction.Synchronize, true, DataSetHelper.InnerBytesData(ds));

        //        ds.Tables.Remove(detail);
        //        ds.Tables.Remove(cardhandle);
        //        ds.Tables.Remove(operation);

        //        DataSetHelper.RemoveColumns(header, true, header.SalesOrderIDColumn);
        //        SynchronizationManager.Synchronize(ObjectNames.SalesOrderHeader, GlobalVariable.UserID, GlobalVariable.ServerDateTime, DatabaseAction.Synchronize, false, DataSetHelper.InnerBytesData(ds));
        //        BindGrid();
        //    }
        //}

        private void miSynchronize_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!ConfigurationManagerEx.OfflineMode || !IsPermitted(ObjectNames.Synchronize, DatabaseAction.Add) || gridView.SelectedRowsCount != 1)
                return;

            if (XtraMessageBox.Show(this, "დარწმუნებული ხართ, რომ გინდათ მონიშნული ფაქტურების სინქრონიზაცია?", "სინქრონიზაცია", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;


            try
            {
                var id = ConvertHelper.ToInt32(OptionsGrid.SelectedRecordID);
                if (id == 0) return;

                SynchronizationManager.SynchronizeSalesOrder(id);
                BindGrid();
                //SyncOrder(id);
            }
            catch (Exception ex)
            {
                ExceptionHelper.Show(this, ex, MessageBoxIcon.Error);
            }
        }

        private void miGeneratePurchase_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!IsPermitted(ObjectNames.PurchaseOrderHeader, DatabaseAction.Add) || gridView.SelectedRowsCount != 1) return;

            var id = ConvertHelper.ToInt32(OptionsGrid.SelectedRecordID);
            if (id == 0) return;
            IForm frm = FormHelper.CreateInstance((int)ObjectNames.PurchaseOrderHeader, FormStyle.Edit, MdiParent);
            frm.InvokeAction("SalesOrderID", id, ConfigurationManagerEx.IsOnline);
            frm.Show();
            frm.BringToFront();
        }

        private void iCardGift_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView.SelectedRowsCount != 1)
                return;

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                var rowguid = ((DS_Sales.VW_SalesOrderHeaderRow)gridView.GetDataRow(OptionsGrid.SelectedRowHandle)).rowguid;
                var id = ConvertHelper.ToInt32(OptionsGrid.SelectedRecordID);
                if (id == 0) return;

                using (var frm = new frmCardGiftEdit())
                {
                    frm.IsOnline = IsOnline;
                    frm.PrimaryKey = id;
                    if (frm.ShowDialog(this) != DialogResult.OK) return;

                    if (frm.IsOnline)
                    {
                        using (var ds = new DataSet("root"))
                        {
                            var t1 = DataSetHelper.PackAlternationDataTable(frm.T_CardHandle);
                            var t2 = DataSetHelper.PackAlternationDataTable(frm.ds_Operation.T_Operation);
                            ds.Tables.Add(t1);
                            ds.Tables.Add(t2);
                            CardManager.SaveCardHandle(DataSetHelper.InnerBytesData(ds), BaseGlobalVariable.UserID);
                        }
                    }
                    else
                        SynchronizationManager.SynchronizeSalesOrder(id, DataSetHelper.PackAlternationDataTable(frm.T_CardHandle), DataSetHelper.PackAlternationDataTable(frm.ds_Operation.T_Operation));
                    BindGrid();
                    //SyncOrder(id, DataSetHelper.PackAlternationDataTable(frm.T_CardHandle), DataSetHelper.PackAlternationDataTable(frm.ds_Operation.T_Operation));

                    var serverSalesOrderID = SalesManager.FindSalesOrderID(rowguid);
                    if (serverSalesOrderID == 0)
                        throw new Exception("სერვერზე გადაგზავნილი ფაქტურა არ მოიძებნა");

                    SaveAndPrintAct(serverSalesOrderID);
                }
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

        private void SaveAndPrintAct(int id)
        {
            var cardHandle = CardManager.GetCardHandle(id, true);
            if (cardHandle.Count == 0)
            {
                XtraMessageBox.Show("ბარათის გატარება არ მოიძებნა.", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cardHandle[0].Amount >= 0m)
            {
                XtraMessageBox.Show("ამ ფაქტურაზე არ არის დაგროვების ბარათით გადახდა დაფიქსირებული.", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SalesManager.SaveAct(id);
            var ds = new DS_ActOfReceipt();
            ds.T_Header.Merge(SalesManager.GetActVW(id));
            ds.T_Detail.Merge(SalesManager.GetActDetailVW(id));

            ReportHelper.Show(MdiParent, id.ToString(), Reports.ReportName.ActOfReceipt, ds);
            ReportHelper.Show(MdiParent, id.ToString(), Reports.ReportName.ActOfReceiptThermal, ds);
            
            //if (actNumber.Length == 0)
            //{
            //    XtraMessageBox.Show("აქტის ნომერი ვერ მოიძებნა", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

        }

        private void btnAct_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                SaveAndPrintAct((int)OptionsGrid.SelectedRecordID);
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