using System;
using System.Data;
using System.Windows.Forms;
using Apothex.DataManagment.Person;
using Apothex.Sales;
using Apothex.Windows.Forms;
using Apothex.DataType;
using Apothex.DataManagment.Synchronization;
using DevExpress.XtraEditors.Controls;
using Zek.Core;
using Zek.Data;
using Apothex.Common;
using Zek.Win32;
using Zek.Windows.Forms;
using Zek.Windows.Forms.DevEx;
using Apothex.DataManagment.Branch;

namespace Apothex.Synchronization
{
    public partial class frmSynchronizeEdit : frmEditBrowse
    {
        public frmSynchronizeEdit()
        {
            InitializeComponent();

            XtraGridHelper.InitGridView(viewSales);
        }

        protected override void BindControls()
        {
            chklstTable.Items.Add((int)ObjectNames.SynchronizeDate, "თარიღი", CheckState.Checked, true);
            chklstTable.Items.Add((int)ObjectNames.SalesOrderHeader, "გაყიდვა", CheckState.Checked, true);
            chklstTable.Items.Add((int)ObjectNames.ProductLocation, "პროდუქცია ფილიალში", CheckState.Checked, true);
            chklstTable.Items.Add((int)ObjectNames.Currency, "ვალუტა", CheckState.Checked, true);
            chklstTable.Items.Add((int)ObjectNames.PaymentMethod, "გადახდის მეთოდი", CheckState.Unchecked, true);
            chklstTable.Items.Add((int)ObjectNames.OperationType, "ოპერაციის ტიპი", CheckState.Unchecked, true);
            chklstTable.Items.Add((int)ObjectNames.CardUnitRate, "ბარათის ქულების კურსი", CheckState.Unchecked, true);
            chklstTable.Items.Add((int)ObjectNames.CardDiscountSchema, "ბარათის ფასდაკლების სქემა", CheckState.Unchecked, true);
            chklstTable.Items.Add((int)ObjectNames.MyCompany, "ჩემი კომპანია", CheckState.Unchecked, true);
            chklstTable.Items.Add((int)ObjectNames.Branch, "ფილიალი", CheckState.Unchecked, true);
            chklstTable.Items.Add((int)ObjectNames.User, "მომხმარებელი", CheckState.Unchecked, true);
            chklstTable.Items.Add((int)ObjectNames.UserPermission, "უფლებები", CheckState.Unchecked, true);
        }

        protected override bool SaveData()
        {
            foreach (CheckedListBoxItem item in chklstTable.Items)
            {
                if (item.CheckState != CheckState.Checked || !item.Enabled) continue;
                var objectName = (ObjectNames)ConvertHelper.ToInt32(item.Value);
                var modifiedDate = SynchronizationManager.GetDate(objectName, false);
                var table = new DataTable();
                switch (objectName)
                {
                    case ObjectNames.SynchronizeDate:
                        Win32Native.SetLocalTime(SynchronizationManager.GetDate(ObjectNames.None, true));
                        InitSynchronizedCheckedListBoxItem(item);
                        break;

                    //case ObjectNames.SalesOrderHeader:
                    //    DateTime serverDateTime = SynchronizationManager.GetDate(ObjectNames.None, true);
                    //    DS_Sales.SP_GetSalesOrderHeaderDataTable header = Apothex.DataManagment.Sales.SalesManager.GetSalesOrderHeader(serverDateTime.Date, false);
                    //    DS_Sales.SP_GetSalesOrderDetailDataTable detail = Apothex.DataManagment.Sales.SalesManager.GetSalesOrderDetail(serverDateTime.Date, false);
                    //    DS_Card.T_CardHandleDataTable card = CardManager.GetCardHandle(serverDateTime.Date, false);
                    //    using (DataSet ds = new DataSet("root"))
                    //    {
                    //        DataSetHelper.SetColumnMappingType(header);
                    //        DataSetHelper.SetColumnMappingType(detail);
                    //        DataSetHelper.SetColumnMappingType(card);

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
                    //        ds.Tables.Add(card);
                    //        Synchronize(objectName, ds, true);
                    //        ds.Tables.Remove(detail);
                    //        ds.Tables.Remove(card);

                    //        DataSetHelper.RemoveColumns(header, true, header.SalesOrderIDColumn);
                    //        Synchronize(objectName, ds, false);
                    //        InitSynchronizedCheckedListBoxItem(item);
                    //    }
                    //    break;
                    case ObjectNames.SalesOrderHeader:
                        SynchronizationManager.SynchronizeSalesOrder(0);
                        InitSynchronizedCheckedListBoxItem(item);
                        break;

                    case ObjectNames.ProductLocation:
                        table = SynchronizationManager.GetSyncProductLocation(0, 0, GlobalVariable.BranchID, modifiedDate, DatabaseAction.Synchronize);
                        Synchronize(objectName, table, false);
                        InitSynchronizedCheckedListBoxItem(item);
                        break;

                    case ObjectNames.Currency:
                        table = SynchronizationManager.GetSyncCurrency(string.Empty, modifiedDate, DatabaseAction.Synchronize);
                        Synchronize(objectName, table, false);
                        InitSynchronizedCheckedListBoxItem(item);
                        break;

                    case ObjectNames.CardUnitRate:
                        table = SynchronizationManager.GetSyncCardUnitRate();
                        Synchronize(objectName, table, false);
                        InitSynchronizedCheckedListBoxItem(item);
                        break;

                    case ObjectNames.CardDiscountSchema:
                        table = SynchronizationManager.GetSyncCardDiscountSchema();
                        Synchronize(objectName, table, false);
                        InitSynchronizedCheckedListBoxItem(item);
                        break;

                    case ObjectNames.MyCompany:
                        var mycompany = SynchronizationManager.GetSyncMyCompany(0, modifiedDate, DatabaseAction.Synchronize);
                        if (mycompany.Count > 0)
                        {
                            var branch = BranchManager.Get(GlobalVariable.BranchID);
                            if (branch.Count > 0 && !branch[0].IsCompanyIDNull())
                            {
                                var company = PersonManager.GetCompany(branch[0].CompanyID);
                                if (company.Count > 0)
                                {
                                    mycompany[0].MyCompanyName = company[0].Name;
                                    mycompany[0].TaxCode = company[0].TaxCode;
                                    mycompany[0].DirectorName = string.Empty;
                                    mycompany[0].CountryCode = company[0].CountryCode;
                                    mycompany[0].City = string.Empty;
                                    mycompany[0].Address = company[0].Address;
                                    mycompany[0].Phone = company[0].Phone;
                                    mycompany[0].Fax = company[0].Fax;
                                    if (!company[0].IsBankIDNull())
                                        mycompany[0].BankID = company[0].BankID;
                                    else
                                        mycompany[0].SetBankIDNull();
                                    mycompany[0].BankAccountNumber = company[0].BankAccountNumber;
                                }
                            }
                        }
                        table = mycompany;
                        Synchronize(objectName, table, false);
                        InitSynchronizedCheckedListBoxItem(item);
                        break;

                    case ObjectNames.Branch:
                        table = SynchronizationManager.GetSyncBranch(0, modifiedDate, DatabaseAction.Synchronize);
                        Synchronize(objectName, table, false);
                        InitSynchronizedCheckedListBoxItem(item);
                        break;

                    case ObjectNames.User:
                        table = SynchronizationManager.GetSyncUser(0, GlobalVariable.BranchID, modifiedDate, DatabaseAction.Synchronize);
                        Synchronize(objectName, table, false);
                        InitSynchronizedCheckedListBoxItem(item);
                        break;

                    case ObjectNames.UserPermission:
                        table = SynchronizationManager.GetSyncUserPermission(0, GlobalVariable.BranchID, modifiedDate, DatabaseAction.Synchronize);
                        Synchronize(objectName, table, false);
                        InitSynchronizedCheckedListBoxItem(item);
                        break;

                    case ObjectNames.PaymentMethod:
                        table = SynchronizationManager.GetSyncPaymentMethod(0, modifiedDate, DatabaseAction.Synchronize);
                        Synchronize(objectName, table, false);
                        InitSynchronizedCheckedListBoxItem(item);
                        break;

                    case ObjectNames.OperationType:
                        table = SynchronizationManager.GetOperationType();
                        Synchronize(objectName, table, false);
                        InitSynchronizedCheckedListBoxItem(item);
                        break;
                }
            }

            return true;
        }

        public void InitSynchronizedCheckedListBoxItem(CheckedListBoxItem item)
        {
            item.Description += " - OK";
            item.Enabled = false;
        }

        public void Synchronize(ObjectNames objectName, DataTable table, bool isOnline)
        {
            using (var ds = new DataSet("root"))
            {
                var xmlTable = table.Copy();
                DataSetHelper.SetColumnMappingType(xmlTable);
                ds.Tables.Add(xmlTable);
                Synchronize(objectName, ds, isOnline);
            }
        }

        public void Synchronize(ObjectNames objectName, DataSet ds, bool isOnline)
        {
            string xml = DataSetHelper.InnerXmlData(ds);
            try
            {
                var id = SynchronizationManager.Synchronize(objectName, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, DatabaseAction.Synchronize, isOnline, DataSetHelper.InnerBytesData(xml));
                if (id <= 0)
                    throw new Exception("შეცდომა ცხრილის სინქრონიზაციის დროს.");
            }
            catch
            {
                if (isOnline)
                {
                    txtServerErrorObjectID.Text = ((int)objectName).ToString();
                    memoServerXml.Text = xml;
                }
                else
                {
                    txtLocalErrorObjectID.Text = ((int)objectName).ToString();
                    memoLocalXml.Text = xml;
                }
                throw;
            }
        }

        private void btnInitSales_Click(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                ds_SyncSalesOrderDetail.T_SalesOrderDetail_Invalid.Clear();
                ds_SyncSalesOrderDetail.T_SalesOrderDetail_Invalid.Merge(SynchronizationManager.GetInvalidSalesOrderDetail());
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

        private void viewSales_DoubleClick(object sender, EventArgs e)
        {
            if (viewSales.FocusedRowHandle == -1) return;

            var id = ConvertHelper.ToInt32(viewSales.GetFocusedRowCellValue(colSalesOrderID));
            if (id == 0) return;

            string formID = FormHelper.GetFormID((typeof(frmSalesOrderEdit)), IntPtr.Zero, id);

            FormHelper.Show((typeof(frmSalesOrderEdit)), MdiParent, IntPtr.Zero, id);
            frmSalesOrderEdit frm = FormHelper.GetForm<frmSalesOrderEdit>(formID);
            frm.ReadOnly = false;
            frm._IsAllowedAnyDate = true;
            frm._IsAllowedSalesOrderHeaderAnyModifier = true;
            frm.ReEnableDisableFormControls();
        }
    }
}
