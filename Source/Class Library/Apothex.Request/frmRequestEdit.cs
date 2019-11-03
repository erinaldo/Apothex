using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Apothex.Dictionary;
using Apothex.Reporting;
using Apothex.Sales;
using DevExpress.XtraEditors;

using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Apothex.DataType;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using Zek.Core;
using Apothex.Common;
using Zek.Data;
using Apothex.DataManagment.Request;
using Zek.Windows.Forms;
using Apothex.Configuration;
using Zek.Windows.Forms.DevEx;

namespace Apothex.Request
{
    public partial class frmRequestEdit : frmEditBrowse, IRequestForm
    {
        public frmRequestEdit()
        {
            InitializeComponent();
            XtraGridHelper.InitGrid(grid);
            XtraGridHelper.BestFitColumns(view);
            DataSetHelper.SetColumnAutoIncrement(ds_Request.SP_GetRequestDetail.RequestDetailIDColumn);
        }

        #region Fields
        public int RequestID
        {
            get { return ConvertHelper.ToInt32(PrimaryKey); }
            set
            {
                PrimaryKey = value;
                txtRequestID.Text = txtID.Text = value.ToString();
                Text = OptionsBaseForm.Text + (value > 0 ? " №" + value.ToString() : string.Empty);
            }
        }
        public DateTime RequestDate
        {
            get { return ConvertHelper.ToDateTime(dateRequestDate.EditValue); }
            set { dateRequestDate.EditValue = value; }
        }
        public int BranchID
        {
            get { return ConvertHelper.ToInt32(bbBranch.RecordValue); }
            set { bbBranch.RecordValue = value; }
        }
        public int ModifierID
        {
            get { return ConvertHelper.ToInt32(bbModifier.RecordValue); }
            set { bbModifier.RecordValue = value; }
        }
        public string Modifier
        {
            get { return bbModifier.Text.Trim(); }
        }
        public DateTime ModifiedDate
        {
            get { return ConvertHelper.ToDateTime(dateModifiedDate.EditValue); }
            set { dateModifiedDate.EditValue = value; }
        }
        public int ApproverID
        {
            get { return ConvertHelper.ToInt32(bbApprover.RecordValue); }
            set { bbApprover.RecordValue = value; }
        }
        public string Approver
        {
            get { return bbApprover.Text.Trim(); }
        }

        private frmSalesOrderDetailDefectureBrowse _frmDefecture;
        private frmMedicamentBrowse _frmMedicament;
        #endregion

        #region Binding
        protected override void BindControls()
        {
            bsCountry.DataSource = DictionaryManager.GetDictionary(ObjectNames.Country);
            bsBrand.DataSource = DictionaryManager.GetDictionary(ObjectNames.Brand);
        }
        protected override void BindData()
        {
            if (Action == DatabaseAction.Edit)
            {
                ds_Request.SP_GetRequestHeader.Clear();
                ds_Request.SP_GetRequestHeader.Merge(RequestManager.GetRequestHeader(RequestID));
                if (ds_Request.SP_GetRequestHeader.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.", "RecordID");

                RequestID = ds_Request.SP_GetRequestHeader[0].RequestID;
                BranchID = ds_Request.SP_GetRequestHeader[0].BranchID;
                RequestDate = ds_Request.SP_GetRequestHeader[0].RequestDate;
                ModifierID = ds_Request.SP_GetRequestHeader[0].ModifierID;
                ModifiedDate = ds_Request.SP_GetRequestHeader[0].ModifiedDate;
                ApproverID = ds_Request.SP_GetRequestHeader[0].ApproverID;
                Status = (DatabaseStatus)ds_Request.SP_GetRequestHeader[0].Status;

                BindingDetails();
            }
            else
            {
                BranchID = GlobalVariable.BranchID;
                RequestDate = BaseGlobalVariable.ServerDateTime;
                ModifierID = BaseGlobalVariable.UserID;
                ModifiedDate = BaseGlobalVariable.ServerDateTime;

                AddHeader();
            }
        }
        private void BindingDetails()
        {
            ds_Request.SP_GetRequestDetail.Clear();
            ds_Request.SP_GetRequestDetail.Merge(RequestManager.GetRequestDetail(RequestID));
        }
        #endregion

        #region Validation
        public bool IsValidGrid()
        {
            var flag = true;
            foreach (var row in ds_Request.SP_GetRequestDetail)
            {
                if (row.RowState == DataRowState.Deleted || row.RowState == DataRowState.Detached) continue;

                if (row.RequestQty <= 0m)
                {
                    row.SetColumnError(ds_Request.SP_GetRequestDetail.RequestQtyColumn, "მნიშვნელობა უნდა აღემატებოდეს 0-ს.");
                    flag = false;
                }
            }
            return flag;
        }
        protected override bool IsValidForm()
        {
            var flag = true;
            if (!IsValidGrid()) flag = false;
            return flag;
        }
        #endregion

        #region Methods
        private void AddHeader()
        {
            DS_Request.SP_GetRequestHeaderRow row;
            if (ds_Request.SP_GetRequestHeader.Count == 0)
            {
                row = ds_Request.SP_GetRequestHeader.NewSP_GetRequestHeaderRow();
                row.RequestID = -1;
                //row.rowguid = Guid.NewGuid();
            }
            else
                row = ds_Request.SP_GetRequestHeader[0];

            row.BranchID = BranchID;
            row.BranchName = bbBranch.Text;
            row.RequestDate = RequestDate;
            row.Status = (byte)Status;
            row.ModifierID = ModifierID;
            row.Modifier = bbModifier.Text;
            row.ModifiedDate = ModifiedDate;
            row.ApproverID = ApproverID;
            row.Approver = bbApprover.Text;

            if (ds_Request.SP_GetRequestHeader.Rows.Count == 0)
                ds_Request.SP_GetRequestHeader.AddSP_GetRequestHeaderRow(row);
        }
        private void AddDetailMedicament()
        {
            if (OptionsBaseForm.ReadOnly) return;
            try
            {
                //if (ds_Request.SP_GetRequestHeader.Rows.Count == 0)
                //    throw new Exception("გთხოვთ შეავსოთ ძირითადი პარამეტრები.");

                bool isContainsForm = FormHelper.ContainsForm(FormHelper.GetFormID(typeof(frmMedicamentBrowse), Handle));
                IForm frm = FormHelper.CreateInstance(typeof(frmMedicamentBrowse), MdiParent, Handle);
                if (!isContainsForm)
                {
                    if (frm is frmMedicamentBrowse)
                    {
                        _frmMedicament = ((frmMedicamentBrowse)frm);
                        _frmMedicament.OptionsListForm.ServerMode = true;
                        _frmMedicament.OptionsListForm.BrowseFormStyle = BrowseFormStyle.Browse;
                        _frmMedicament.OnChooseRecord += new CancelEventHandler(OnChooseProduct);
                        _frmMedicament.OptionsListForm.CloseAfterChoose = false;
                    }
                }

                frm.Show();
                frm.BringToFront();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddDetailDefecture()
        {
            if (OptionsBaseForm.ReadOnly) return;
            try
            {
                //if (ds_Request.SP_GetRequestHeader.Rows.Count == 0)
                //    throw new Exception("გთხოვთ შეავსოთ ძირითადი პარამეტრები.");

                bool isContainsForm = FormHelper.ContainsForm(FormHelper.GetFormID(typeof(frmSalesOrderDetailDefectureBrowse), Handle));
                IForm frm = FormHelper.CreateInstance(typeof(frmSalesOrderDetailDefectureBrowse), MdiParent, Handle);
                if (!isContainsForm)
                {
                    if (frm is frmSalesOrderDetailDefectureBrowse)
                    {
                        _frmDefecture = ((frmSalesOrderDetailDefectureBrowse)frm);
                        _frmDefecture.OptionsListForm.BrowseFormStyle = BrowseFormStyle.Browse;
                        _frmDefecture.OnChooseRecord += new CancelEventHandler(OnChooseProduct);
                        _frmDefecture.OptionsListForm.CloseAfterChoose = false;
                    }
                }

                frm.Show();
                frm.BringToFront();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddRows(DS_SalesOrderDetailDefacture.FN_SalesOrderDetailDefactureDataTable table)
        {
            foreach (var row in table)
            {
                AddRow(row);
            }
        }
        private void AddRow(DS_SalesOrderDetailDefacture.FN_SalesOrderDetailDefactureRow defRow)
        {
            var newRow = ds_Request.SP_GetRequestDetail.NewSP_GetRequestDetailRow();

            newRow.RequestID = RequestID;
            newRow.RequestQty = 0m;
            newRow.OrdinalNumber = (short)(view.RowCount + 1);

            newRow.MedicamentID = defRow.NomenclatureID;
            newRow.MedicamentName = defRow.Nomenclature;
            if (!defRow.IsCountryCodeNull()) newRow.CountryCode1 = defRow.CountryCode;
            if (!defRow.IsCountryNull()) newRow.CountryName1 = defRow.Country;
            if (!defRow.IsBrandIDNull()) newRow.BrandID = defRow.BrandID;
            if (!defRow.IsBrandNull()) newRow.BrandName = defRow.Brand;
            newRow.RequestQty = defRow.CustomQty;

            ds_Request.SP_GetRequestDetail.AddSP_GetRequestDetailRow(newRow);
        }

        private void DeleteDetail()
        {
            if (OptionsBaseForm.ReadOnly) return;

            view.DeleteSelectedRows();
            IsChanged = true;
        }
        private void IndexOrdinalNumbers()
        {
            if (OptionsBaseForm.ReadOnly) return;

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                XtraGridHelper.IndexOrdinalNumbers(view, colOrdinalNumber);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, "რიგითი ნომრების ინდექსირება ვერ მოხერხდა.\n" + ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private void OnChooseProduct(object sender, CancelEventArgs e)
        {
            if (OptionsBaseForm.ReadOnly || OptionsBaseForm.IsLoading || OptionsBaseForm.IsClosing) return;

            try
            {
                var frm = (sender as IBrowseForm);

                if (frm == null) return;

                if (frm.OptionsGrid.SelectedRecordIDs == null || frm.OptionsGrid.SelectedRecordIDs.Length == 0)
                    throw new NullReferenceException("არჩეული ჩანაწერის იდენთიფიკატორი ცარიელია. (frm.SelectedRecordID = null)");

                if (frm is frmSalesOrderDetailDefectureBrowse)
                {
                    var def = (frmSalesOrderDetailDefectureBrowse)frm;
                    foreach (var rowHandle in def.view.GetSelectedRows())
                    {
                        var defRow = (DS_SalesOrderDetailDefacture.FN_SalesOrderDetailDefactureRow)def.view.GetDataRow(rowHandle);
                        AddRow(defRow);
                    }
                }
                else
                {
                    foreach (var id in frm.OptionsGrid.SelectedRecordIDs)
                    {
                        var table = DictionaryManager.GetMedicament(ConvertHelper.ToInt32(id));
                        if (table.Count == 0) throw new Exception("მონაცემი ვერ მოიძებმა.");
                        var row = table[0];
                        var newRow = ds_Request.SP_GetRequestDetail.NewSP_GetRequestDetailRow();

                        newRow.RequestID = RequestID;
                        newRow.RequestQty = 0m;
                        newRow.OrdinalNumber = (short)(view.RowCount + 1);

                        newRow.MedicamentID = row.MedicamentID;
                        newRow.MedicamentName = row.Name;
                        //newRow.UnitsInStock = row.UnitsInStock;
                        if (!row.IsCountryCodeNull()) newRow.CountryCode1 = row.CountryCode;
                        if (!row.IsBrandIDNull()) newRow.BrandID = row.BrandID;

                        ds_Request.SP_GetRequestDetail.AddSP_GetRequestDetailRow(newRow);
                    }
                }

                IsChanged = true;
                view.Focus();
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                ExceptionHelper.Show(this, ex, "შეცდომა მონაცემის არჩევისას", MessageBoxIcon.Error);
            }
        }
        private void ProcessKey(object sender, KeyEventArgs e)
        {
            if (OptionsBaseForm.IsLoading) return;

            if (e.KeyCode == Keys.Insert && !e.Control && !e.Alt && !e.Shift)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;

                AddDetailMedicament();
            }
            else if (e.KeyCode == Keys.F8 && !e.Shift && !e.Control && !e.Alt)
            {
                if (xtraTabControl.SelectedTabPage != tabMain) return;

                e.SuppressKeyPress = true;
                e.Handled = true;

                DeleteDetail();
            }
            else if (e.KeyCode == Keys.F9 && !e.Control && !e.Alt && !e.Shift)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                XtraGridHelper.BestFitColumns(view);
            }
        }
        protected override void Print()
        {
            if (IsChanged || Action == DatabaseAction.Add)
            {
                XtraMessageBox.Show(this, "გთხოვთ შეინახოთ ჩანაწერი და შემდეგ გაიმეოროთ ოპერაცია.", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Status == DatabaseStatus.Pending)
            {
                XtraMessageBox.Show(this, "მხოლოდ დადასტურებული შეკვეთის ამობეჭვდაა შესაძლებელი.", "ამობეჭვდა", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddHeader();
           
            //if (Apothex.Reporting.ReportFactory.Printed == null)
            //    Apothex.Reporting.ReportFactory.Printed += new EventHandler(OnPrint);

            var rpt = ReportFactory.GetReport(ObjectNames.Request);
            rpt.Printed += new EventHandler(OnPrint);

            ReportFactory.Show(MdiParent, OptionsBaseForm.Text, rpt, ds_Request);
        }
        private void OnPrint(object sender, EventArgs e)
        {
            RequestManager.UpdateStatus(RequestID, (int)DatabaseStatus.Shipped, BaseGlobalVariable.UserID);
        }

        protected override void Init()
        {
            base.Init();

            txtRequestID.Properties.ReadOnly = true;
            dateRequestDate.Properties.ReadOnly =
            bbBranch.Properties.ReadOnly = OptionsBaseForm.ReadOnly;

            XtraGridHelper.SetReadOnly(grid, OptionsBaseForm.ReadOnly, true, true);
        }
        protected override bool SaveData()
        {
            view.CloseEditor();
            bsDetail.EndEdit();

            AddHeader();

            DS_Request.SP_GetRequestDetailDataTable table = DataSetHelper.PackAlternationTypedDataTable<DS_Request.SP_GetRequestDetailDataTable>(ds_Request.SP_GetRequestDetail);
            DataSetHelper.RemoveColumns(table, true,
                                                table.RequestDetailIDColumn,
                                                table.MedicamentIDColumn,
                                                table.RequestQtyColumn,
                                                table.CountryCode1Column,
                                                table.CountryCode2Column,
                                                table.BrandIDColumn,
                                                table.OrdinalNumberColumn,
                                                table.ActionColumn);

            var ds = new DataSet("root");
            ds.Tables.Add(table);

            var id = RequestManager.AddOrEditRequest(RequestID, BranchID, RequestDate, Status, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, ApproverID, Guid.Empty, Action, DataSetHelper.InnerBytesData(ds));

            if (id > 0)
            {
                if (Action == DatabaseAction.Add)
                {
                    ds_Request.SP_GetRequestHeader[0].RequestID = id;
                    RequestID = id;
                }

                if (!OptionsEditForm.IsSaveAndCloseExecuting)
                    BindingDetails();
            }
            return (id > 0);
        }
        #endregion

        private void dateRequestDate_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {

            RequestDate = BaseGlobalVariable.ServerDateTime;
        }

        private void grid_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            switch (e.Button.ButtonType)
            {
                case NavigatorButtonType.Append:
                    AddDetailMedicament();
                    e.Handled = true;
                    break;

                case NavigatorButtonType.Remove:
                    DeleteDetail();
                    e.Handled = true;
                    break;

                case NavigatorButtonType.Custom:
                    e.Handled = true;
                    var tag = (int)e.Button.Tag;

                    switch (tag)
                    {
                        case 1:
                            IndexOrdinalNumbers();
                            break;

                        case 2:
                            AddDetailDefecture();
                            break;
                    }
                    break;
            }
        }

        private void frmRequestEdit_KeyDown(object sender, KeyEventArgs e)
        {
            ProcessKey(sender, e);
        }

        private void view_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (OptionsBaseForm.ReadOnly || OptionsBaseForm.IsLoading) return;
            IsChanged = true;

            var row = ((DS_Request.SP_GetRequestDetailRow)view.GetDataRow(e.RowHandle));
            if (ds_Request.SP_GetRequestDetail.Columns.Contains(e.Column.FieldName))
                row.SetColumnError(e.Column.FieldName, string.Empty);
        }

        private void frmRequestEdit_Shown(object sender, EventArgs e)
        {
            if (OptionsBaseForm.ReadOnly || OptionsBaseForm.IsClosing) return;
            if (ConfigurationManagerEx.AutoNewRow && Action == DatabaseAction.Add && ds_Request.SP_GetRequestDetail.Count == 0)
                AddDetailMedicament();
        }

        private void frmRequestEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_frmDefecture != null)
            {
                if (_frmDefecture.IsDisposed)
                    _frmDefecture = null;
                else
                    _frmDefecture.Close();
            }
            if (_frmMedicament != null)
            {
                if (_frmMedicament.IsDisposed)
                    _frmMedicament = null;
                else
                    _frmMedicament.Close();
            }
        }
    }
}