using System;
using System.Data;
using System.Windows.Forms;
using Apothex.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

using Apothex.DataType;
using Apothex.DataManagment.User;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Zek.Core;
using Zek.Data;
using Zek.Security;

namespace Apothex.Users
{
    public partial class frmUserGroupEdit : frmEditBrowse
    {
        public frmUserGroupEdit()
        {
            InitializeComponent();
        }

        #region Properties
        public int UserGroupID
        {
            get { return ConvertHelper.ToInt32(PrimaryKey); }
            set { PrimaryKey = value; txtID.Text = value.ToString(); }
        }
        public string UserGroupName
        {
            get { return txtUserGroupName.Text.Trim(); }
            set { txtUserGroupName.Text = value; }
        }

        public int ModifiedUserID
        {
            get { return ConvertHelper.ToInt32(bbModifier.RecordValue); }
            set { bbModifier.RecordValue = value; }
        }
        public DateTime ModifiedDate
        {
            get { return ConvertHelper.ToDateTime(dateModifiedDate.EditValue); }
            set { dateModifiedDate.EditValue = value; }
        }
        public int ApproverUserID
        {
            get { return ConvertHelper.ToInt32(bbApprover.RecordValue); }
            set { bbApprover.RecordValue = value; }
        }
        #endregion

        #region Bindings
        protected override void BindData()
        {
            if (Action == DatabaseAction.Edit)
            {
                var table = UserManager.GetUserGroup(UserGroupID);
                if (table.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.");

                UserGroupID = table[0].UserGroupID;
                UserGroupName = table[0].Name;

                Status = (DatabaseStatus)table[0].Status;
                ModifiedUserID = table[0].ModifiedUserID;
                ModifiedDate = table[0].ModifiedDate;
                ApproverUserID = table[0].ApproverUserID;


                if (IsPermitted(ObjectNames.UserGroupPermission, DatabaseAction.View))
                    BindingGroupPermission(true);
            }
            else
            {
                ModifiedUserID = BaseGlobalVariable.UserID;
                ModifiedDate = BaseGlobalVariable.ServerDateTime;
            }
        }
        private void BindingGroupPermission(bool throwError)
        {
            try
            {
                Application.DoEvents();
                if (!throwError)
                    Cursor = Cursors.WaitCursor;

                btnSavePermission.Enabled = false;

                ds_Permission.SP_GetUserGroupPermission.Clear();
                ds_Permission.SP_GetUserGroupPermission.Merge(UserManager.GetGroupPermission(UserGroupID));

                BindingDefaultGroupPermission();


                foreach (DS_User.SP_GetUserGroupPermissionRow rowLogical in ds_Permission.SP_GetUserGroupPermission.Rows)
                {
                    foreach (DS_User.UserGroupPermissionRow rowGrid in ds_Permission.UserGroupPermission.Rows)
                    {
                        if (rowLogical.ObjectID == rowGrid.ObjectID)
                        {
                            rowGrid.Logical = rowLogical.Logical;

                            rowGrid.View = BitwisePermissionHelper.IsPermitted(rowLogical.Logical, (int)DatabaseAction.View);
                            rowGrid.Add = BitwisePermissionHelper.IsPermitted(rowLogical.Logical, (int)DatabaseAction.Add);
                            rowGrid.Del = BitwisePermissionHelper.IsPermitted(rowLogical.Logical, (int)DatabaseAction.Delete);
                            rowGrid.Edit = BitwisePermissionHelper.IsPermitted(rowLogical.Logical, (int)DatabaseAction.Edit);
                            rowGrid.Approve = BitwisePermissionHelper.IsPermitted(rowLogical.Logical, (int)DatabaseAction.Approve);
                            rowGrid.Disapprove = BitwisePermissionHelper.IsPermitted(rowLogical.Logical, (int)DatabaseAction.Disapprove);
                            rowGrid.Block = BitwisePermissionHelper.IsPermitted(rowLogical.Logical, (int)DatabaseAction.Block);
                            rowGrid.Unblock = BitwisePermissionHelper.IsPermitted(rowLogical.Logical, (int)DatabaseAction.Unblock);
                            rowGrid.Cancel = BitwisePermissionHelper.IsPermitted(rowLogical.Logical, (int)DatabaseAction.Cancel);
                            rowGrid.Uncancel = BitwisePermissionHelper.IsPermitted(rowLogical.Logical, (int)DatabaseAction.Uncancel);
                            rowGrid.Print = BitwisePermissionHelper.IsPermitted(rowLogical.Logical, (int)DatabaseAction.Print);
                            rowGrid.Import = BitwisePermissionHelper.IsPermitted(rowLogical.Logical, (int)DatabaseAction.Import);
                            rowGrid.Export = BitwisePermissionHelper.IsPermitted(rowLogical.Logical, (int)DatabaseAction.Export);
                            rowGrid.HiddenColumn = BitwisePermissionHelper.IsPermitted(rowLogical.Logical, (int)DatabaseAction.HiddenColumn);

                            rowGrid.AcceptChanges();
                            break;
                        }
                    }
                }

                btnSavePermission.Enabled = IsPermitted(ObjectNames.UserGroupPermission, DatabaseAction.Manage);
            }
            catch (Exception ex)
            {
                if (throwError)
                    throw;
                else
                    XtraMessageBox.Show(this, "შეცდომა უფლებების ინფორმაციის ამოღებისას.\n" + ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (!throwError)
                    Cursor = Cursors.Default;
            }
        }
        private void BindingDefaultGroupPermission()
        {
            ds_Permission.UserGroupPermission.Clear();
            ds_Permission.UserGroupPermission.Merge(UserManager.GetUserGroupPermissions());
            ds_Permission.UserGroupPermission.AcceptChanges();
        }
        #endregion

        #region Methods
        protected override void Init()
        {
            base.Init();

            txtUserGroupName.Properties.ReadOnly = OptionsBaseForm.ReadOnly;

            tabPermission.PageVisible = IsPermitted(ObjectNames.UserGroupPermission, DatabaseAction.View);
            var canEditPermissions = IsPermitted(ObjectNames.UserGroupPermission, DatabaseAction.Manage);
            btnSavePermission.Enabled = canEditPermissions;
            btnCheckAllPermissions.Enabled = canEditPermissions;
            btnUnchekAllPermissions.Enabled = canEditPermissions;
            gridViewPermission.OptionsBehavior.Editable = canEditPermissions;
            if (!canEditPermissions)
                gridViewPermission.PopupMenuShowing -= new PopupMenuShowingEventHandler(gridViewPermission_PopupMenuShowing);
        }
        protected override bool SaveData()
        {
            var id = UserManager.AddOrEditUserGroup(UserGroupID, UserGroupName, Status, ModifiedUserID, ModifiedDate, ApproverUserID, Action);
            if (id > 0) UserGroupID = id;
            return (id > 0);
        }
        public void SaveGroupPermission()
        {
            if (!IsPermitted(ObjectNames.UserGroupPermission, DatabaseAction.Manage))
            {
                XtraMessageBox.Show(this, "თქვენ არ გაქვთ უფლება ამ მომხმარებლის ჯფუფზე უფლებების მინიჭების.", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                btnSavePermission.Enabled = false;

                gridViewPermission.CloseEditor();
                bsPermission.EndEdit();
                InitLogical();


                DS_User.UserGroupPermissionDataTable table = DataSetHelper.PackAlternationTypedDataTable<DS_User.UserGroupPermissionDataTable>(ds_Permission.UserGroupPermission);
                DataSetHelper.RemoveColumns(table, true, table.ObjectIDColumn, table.LogicalColumn);


                var ds = new DataSet("root");
                ds.Tables.Add(table);

                var id = UserManager.AddOrEditUserGroupPermission(UserGroupID, 0, 0, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, DatabaseAction.Manage, DataSetHelper.InnerBytesData(ds));
                if (id > 0)
                {
                    ds_Permission.UserGroupPermission.AcceptChanges();
                }
                else
                {
                    XtraMessageBox.Show(this, "მონაცემი არ შენახულა.", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                BindingGroupPermission(false);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, "შეცდომა ჯგუფის უფლებების შენახვისას.\n" + ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        public void InitLogical()
        {
            int logical;
            foreach (DS_User.UserGroupPermissionRow row in ds_Permission.UserGroupPermission.Rows)
            {
                logical = 0;

                if (row.View) logical = BitwisePermissionHelper.AddPermission(logical, (int)DatabaseAction.View);
                if (row.Validate) logical = BitwisePermissionHelper.AddPermission(logical, (int)DatabaseAction.Validate);
                if (row.Add) logical = BitwisePermissionHelper.AddPermission(logical, (int)DatabaseAction.Add);
                if (row.Del) logical = BitwisePermissionHelper.AddPermission(logical, (int)DatabaseAction.Delete);
                if (row.Edit) logical = BitwisePermissionHelper.AddPermission(logical, (int)DatabaseAction.Edit);
                if (row.Approve) logical = BitwisePermissionHelper.AddPermission(logical, (int)DatabaseAction.Approve);
                if (row.Disapprove) logical = BitwisePermissionHelper.AddPermission(logical, (int)DatabaseAction.Disapprove);
                if (row.Block) logical = BitwisePermissionHelper.AddPermission(logical, (int)DatabaseAction.Block);
                if (row.Unblock) logical = BitwisePermissionHelper.AddPermission(logical, (int)DatabaseAction.Unblock);
                if (row.Cancel) logical = BitwisePermissionHelper.AddPermission(logical, (int)DatabaseAction.Cancel);
                if (row.Uncancel) logical = BitwisePermissionHelper.AddPermission(logical, (int)DatabaseAction.Uncancel);
                if (row.Print) logical = BitwisePermissionHelper.AddPermission(logical, (int)DatabaseAction.Print);
                if (row.Import) logical = BitwisePermissionHelper.AddPermission(logical, (int)DatabaseAction.Import);
                if (row.Export) logical = BitwisePermissionHelper.AddPermission(logical, (int)DatabaseAction.Export);
                if (row.HiddenColumn) logical = BitwisePermissionHelper.AddPermission(logical, (int)DatabaseAction.HiddenColumn);

                if (row.Logical != logical)
                    row.Logical = logical;
                else
                    row.AcceptChanges();
            }
        }
        public void CheckAll(bool check)
        {
            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                for (var i = 0; i < gridViewPermission.RowCount; i++)
                {
                    CheckRow(check, i);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, "შეცდომა უფლებების ჩართვა/გამორთვის დროს.\n" + ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        public void CheckColumn(bool check)
        {
            if (_HitInfo.Column == null || _HitInfo.Column == colDescription) return;

            for (var i = 0; i < gridViewPermission.RowCount; i++)
            {
                gridViewPermission.SetRowCellValue(i, _HitInfo.Column, check);
            }
        }
        public void CheckRow(bool check)
        {
            if (gridViewPermission.FocusedRowHandle < 0) return;

            CheckRow(check, gridViewPermission.FocusedRowHandle);
        }
        public void CheckRow(bool check, int rowHandle)
        {
            foreach (GridColumn col in gridViewPermission.Columns)
            {
                if (col == colDescription) continue;

                gridViewPermission.SetRowCellValue(rowHandle, col, check);
            }
        }
        #endregion

        #region Validations
        public bool IsValidUserGroupName()
        {
            if (UserGroupName.Length == 0)
            {
                dxErrorProvider.SetError(txtUserGroupName, "გთხოვთ შეიყვანოთ ჯგუფის დასახელება.");
                return false;
            }

            if (!UserManager.IsValidUserGroupName(UserGroupID, UserGroupName))
            {
                dxErrorProvider.SetError(txtUserGroupName, "ესეთი ჯგუფის დასახელებით უკვე არსებობს ჩანაწერი.");
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var ok = true;
            if (!IsValidUserGroupName()) ok = false;

            return ok;
        }
        #endregion

        private void txtUserGroupName_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtUserGroupName, string.Empty);
        }

        private void btnSavePermission_Click(object sender, EventArgs e)
        {
            SaveGroupPermission();
        }

        private void btnRefreshPermission_Click(object sender, EventArgs e)
        {
            BindingGroupPermission(false);
        }

        private GridHitInfo _HitInfo;
        private void gridViewPermission_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            e.Allow = false;

            //სისტემური სვეტების მენიუს გათიშვა (თუ არ აქვს უფლება
            if (e.MenuType == GridMenuType.Row)
            {
                iCheckColumn.Visibility = BarItemVisibility.Never;
                iUnCheckColumn.Visibility = BarItemVisibility.Never;

                iCheckRow.Visibility = BarItemVisibility.Always;
                iUnCheckRow.Visibility = BarItemVisibility.Always;
                popupMenu.ShowPopup(MousePosition);
            }
            else if (e.MenuType == GridMenuType.Column && e.HitInfo.Column != colDescription)
            {
                _HitInfo = e.HitInfo;
                iCheckColumn.Visibility = BarItemVisibility.Always;
                iUnCheckColumn.Visibility = BarItemVisibility.Always;

                iCheckRow.Visibility = BarItemVisibility.Never;
                iUnCheckRow.Visibility = BarItemVisibility.Never;
                popupMenu.ShowPopup(MousePosition);
            }
        }

        private void iCheckColumn_ItemClick(object sender, ItemClickEventArgs e)
        {
            CheckColumn(true);
        }

        private void iUnCheckColumn_ItemClick(object sender, ItemClickEventArgs e)
        {
            CheckColumn(false);
        }

        private void iCheckRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            CheckRow(true);
        }

        private void iUnCheckRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            CheckRow(false);
        }

        private void btnCheckAllPermissions_Click(object sender, EventArgs e)
        {
            CheckAll(true);
        }

        private void btnUnchekAllPermissions_Click(object sender, EventArgs e)
        {
            CheckAll(false);
        }
    }
}