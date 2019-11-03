using System;
using System.Data;
using System.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Apothex.Windows.Forms;
using DevExpress.XtraEditors;

using Apothex.Common;
using Apothex.DataManagment.User;
using Apothex.DataType;
using Zek.Core;
using Zek.Data;
using Zek.Security;
using Apothex.Configuration;
using Apothex.DataManagment.Person;

namespace Apothex.Users
{
    public partial class frmUserEdit : frmEditBrowse
    {
        public frmUserEdit()
        {
            InitializeComponent();
        }

        #region Properties
        public int? UserID
        {
            get { return ConvertHelper.ToNullableInt32(PrimaryKey); }
            set { PrimaryKey = value; txtID.Text = value.ToString(); }
        }
        public string UserName
        {
            get { return txtUsername.Text.Trim(); }
            set { txtUsername.Text = value; }
        }
        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }
        public string PasswordHash
        {
            get
            {
                if (UserID != 0 && !chkChangePassword.Checked)
                    return null;
                return CryptoHelper.Encrypt(CryptoHelper.Encrypt(Password, ConfigurationManagerEx.Salt, HashAlgorithmType.SHA1), ConfigurationManagerEx.Salt, HashAlgorithmType.SHA1);
            }
        }
        public string RepeatPassword
        {
            get { return txtRepeatPassword.Text; }
            set { txtRepeatPassword.Text = value; }
        }
        public int? BranchID
        {
            get { return ConvertHelper.ToNullableInt32(lookBranch.EditValue); }
            set { lookBranch.EditValue = value.ToString(); }
        }
        private int? PersonID
        {
            get { return ConvertHelper.ToNullableInt32(bbPerson.RecordValue); }
            set { bbPerson.RecordValue = value; }
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


        public int LeftSelectedUserGroupID
        {
            get { return ConvertHelper.ToInt32(lstLeft.SelectedValue); }
        }
        public int RightSelectedUserGroupID
        {
            get { return ConvertHelper.ToInt32(lstRight.SelectedValue); }
        }

        private DatabaseAction _OldAction = DatabaseAction.Add;
        #endregion

        #region Bindings
        protected override void BindControls()
        {
            bsBranch.DataSource = DictionaryManager.GetDictionary(ObjectNames.Branch);
        }
        protected override void BindData()
        {
            _OldAction = Action;
            if (Action == DatabaseAction.Edit)
            {
                var table = UserManager.GetUser(UserID);
                if (table.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.");

                UserID = table[0].UserID;
                UserName = table[0].Username;
                BranchID = table[0].BranchID;

                Status = (DatabaseStatus)table[0].Status;
                ModifiedUserID = table[0].ModifiedUserID;
                ModifiedDate = table[0].ModifiedDate;
                ApproverUserID = table[0].ApproverUserID;

                PersonID = PersonManager.FindPersonID(UserID);

            }
            else
            {
                ModifiedUserID = BaseGlobalVariable.UserID;
                ModifiedDate = BaseGlobalVariable.ServerDateTime;
            }

            if (IsPermitted(ObjectNames.UserInGroup, DatabaseAction.View))
                BindingUserInGroup(true);
        }
        private void BindingUserInGroup(bool throwError)
        {
            try
            {
                btnSaveUserInGroup.Enabled = false;

                ds_Left.SP_GetDictionary.Clear();
                ds_Left.SP_GetDictionary.Merge(DictionaryManager.GetDictionary(ObjectNames.UserGroup));
                ds_Left.SP_GetDictionary.DefaultView.Sort = ds_Left.SP_GetDictionary.CaptionColumn.ColumnName;

                ds_Right.SP_GetUserInGroup.Clear();
                ds_Right.SP_GetUserInGroup.Merge(UserManager.GetUserInGroup(UserID, 0));
                ds_Right.SP_GetUserInGroup.DefaultView.Sort = ds_Right.SP_GetUserInGroup.UserGroupColumn.ColumnName;

                foreach (var rRow in ds_Right.SP_GetUserInGroup)
                {
                    foreach (var lRow in ds_Left.SP_GetDictionary)
                    {
                        if (rRow.UserGroupID.ToString() == lRow.ID)
                        {
                            lRow.Delete();
                            lRow.AcceptChanges();
                            break;
                        }
                    }
                }

                btnSaveUserInGroup.Enabled = IsPermitted(ObjectNames.UserInGroup, DatabaseAction.Manage);
            }
            catch (Exception ex)
            {
                if (throwError)
                    throw;
                else
                    XtraMessageBox.Show(this, "შეცდომა მომხმარებლის ჯგუფებში განაწილების სიის ამოღებისას.\n" + ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Methods
        public void MoveRight()
        {
            if (!IsPermitted(ObjectNames.UserInGroup, DatabaseAction.Manage))
            {
                XtraMessageBox.Show(this, "თქვენ არ გაქვთ უფლება მომხმარებლის ჯგუფებში განაწილების.", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (LeftSelectedUserGroupID == 0 || ExistsInRight()) return;

            var row = ((DS_Dictionary.SP_GetDictionaryRow)((DataRowView)lstLeft.SelectedItem).Row);


            DS_User.SP_GetUserInGroupRow newRow;

            var isAdded = false;
            var deletedRows = ds_Right.SP_GetUserInGroup.Select(string.Empty, string.Empty, DataViewRowState.Deleted);
            foreach (var delRow in deletedRows)
            {
                if (row.ID == delRow["UserGroupID", DataRowVersion.Original].ToString())
                {
                    delRow.RejectChanges();
                    isAdded = true;
                }
            }


            if (!isAdded)
            {
                newRow = ds_Right.SP_GetUserInGroup.NewSP_GetUserInGroupRow();

                newRow.UserID = UserID.Value;
                newRow.User = UserName;
                newRow.UserGroupID = ConvertHelper.ToInt32(row.ID);
                newRow.UserGroup = row.Caption;
                newRow.ModifiedUserID = BaseGlobalVariable.UserID;
                newRow.Modifier = GlobalVariable.Username;
                newRow.ModifiedDate = BaseGlobalVariable.ServerDateTime;
                ds_Right.SP_GetUserInGroup.AddSP_GetUserInGroupRow(newRow);
            }


            row.Delete();
            row.AcceptChanges();
        }
        public void MoveLeft()
        {
            if (!IsPermitted(ObjectNames.UserInGroup, DatabaseAction.Manage))
            {
                XtraMessageBox.Show(this, "თქვენ არ გაქვთ უფლება მომხმარებლის ჯგუფებში განაწილების.", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (RightSelectedUserGroupID == 0) return;

            var row = ((DS_User.SP_GetUserInGroupRow)((DataRowView)lstRight.SelectedItem).Row);

            if (!ExistsInLeft())
            {
                var newRow = ds_Left.SP_GetDictionary.NewSP_GetDictionaryRow();
                newRow.ID = row.UserGroupID.ToString();
                newRow.Code = row.UserGroupID.ToString();
                newRow.Caption = row.UserGroup.ToString();
                ds_Left.SP_GetDictionary.AddSP_GetDictionaryRow(newRow);
                newRow.AcceptChanges();
            }

            row.Delete();
        }
        public bool ExistsInRight()
        {
            var id = LeftSelectedUserGroupID;
            foreach (DS_User.SP_GetUserInGroupRow row in ds_Right.SP_GetUserInGroup.Rows)
            {
                if (row.RowState == DataRowState.Deleted) continue;
                if (id == row.UserGroupID)
                    return true;
            }

            return false;
        }
        public bool ExistsInLeft()
        {
            var id = RightSelectedUserGroupID.ToString();
            foreach (DS_Dictionary.SP_GetDictionaryRow row in ds_Left.SP_GetDictionary.Rows)
            {
                if (id == row.ID)
                    return true;
            }

            return false;
        }
        protected override void Init()
        {
            base.Init();

            txtUsername.Properties.ReadOnly = ReadOnly;
            chkChangePassword.Properties.ReadOnly = (ReadOnly || Action == DatabaseAction.Add);
            txtPassword.Properties.ReadOnly =
            txtRepeatPassword.Properties.ReadOnly = 
            lookBranch.Properties.ReadOnly =
            bbPerson.Properties.ReadOnly = ReadOnly;

            chkChangePassword.Checked = (_OldAction == DatabaseAction.Add);


            tabUserInGroup.PageVisible = IsPermitted(ObjectNames.UserInGroup, DatabaseAction.View);
            var allowed = IsPermitted(ObjectNames.UserInGroup, DatabaseAction.Manage);
            btnSaveUserInGroup.Enabled =
            lstLeft.Enabled =
            lstRight.Enabled =
            btnLeft.Enabled =
            btnRight.Enabled = allowed;
        }
        protected override bool SaveData()
        {
            var id = UserManager.Save(UserID, BranchID, UserName, PasswordHash, PersonID, BaseGlobalVariable.UserID);
            if (id > 0) UserID = id;
            return (id > 0);
        }
        #endregion

        #region Validations
        public bool IsValidUsername()
        {
            if (UserName.Length == 0)
            {
                dxErrorProvider.SetError(txtUsername, "გთხოვთ შეიყვანოთ მომხმარებელი.");
                return false;
            }

            if (!UserManager.IsValidUsername(UserID, UserName))
            {
                dxErrorProvider.SetError(txtUsername, "ესეთი მომხმარებელი უკვე რეგისტრირებულია.");
                return false;
            }

            return true;
        }
        private bool IsValidRepeatPassword()
        {
            if (UserID != 0 && !chkChangePassword.Checked)
                return true;

            if (Password != RepeatPassword)
            {
                dxErrorProvider.SetError(txtRepeatPassword, "პაროლები არ ემთხვევა.");
                return false;
            }

            return true;
        }
        public bool IsValidBranch()
        {
            if (BranchID == 0)
            {
                dxErrorProvider.SetError(lookBranch, "გთხოვთ ირჩიოთ ფილიალი.");
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var ok = true;
            if (!IsValidUsername()) ok = false;
            if (!IsValidRepeatPassword()) ok = false;
            if (!IsValidBranch()) ok = false;

            return ok;
        }
        #endregion

        private void txtUsername_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtUsername, string.Empty);
        }

        private void lookBranch_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(lookBranch, string.Empty);
        }

        private void txtPassword_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtPassword, string.Empty);
            dxErrorProvider.SetError(txtRepeatPassword, string.Empty);
        }

        private void txtRepeatPassword_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtRepeatPassword, string.Empty);
        }

        private void chkChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Enabled = chkChangePassword.Checked;
            txtRepeatPassword.Enabled = chkChangePassword.Checked;
        }

        private void lstLeft_DoubleClick(object sender, EventArgs e)
        {
            MoveRight();
        }

        private void lstRight_DoubleClick(object sender, EventArgs e)
        {
            MoveLeft();
        }

        private void pnlFill_Resize(object sender, EventArgs e)
        {
            lstLeft.Width = (pnlUserInGroupFill.Width - pnlButton.Width) / 2;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            MoveRight();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            MoveLeft();
        }

        private void btnRefreshUserInGroup_Click(object sender, EventArgs e)
        {
            BindingUserInGroup(false);
        }

        private void btnSaveUserInGroup_Click(object sender, EventArgs e)
        {
            if (!IsPermitted(ObjectNames.UserInGroup, DatabaseAction.Manage))
            {
                XtraMessageBox.Show(this, "თქვენ არ გაქვთ უფლება მომხმარებლის ჯგუფებში განაწილების.", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                btnSaveUserInGroup.Enabled = false;

                DS_User.SP_GetUserInGroupDataTable table = DataSetHelper.PackAlternationTypedDataTable<DS_User.SP_GetUserInGroupDataTable>(ds_Right.SP_GetUserInGroup);

                table.PrimaryKey = null;
                DataSetHelper.RemoveColumns(table, true, table.UserGroupIDColumn, table.ActionColumn);


                var ds = new DataSet("root");
                ds.Tables.Add(table);

                var id = UserManager.AddOrEditUserInGroup(UserID, 0, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, (DatabaseAction.Add | DatabaseAction.Delete), DataSetHelper.InnerBytesData(ds));
                if (id > 0)
                {
                    ds_Right.SP_GetUserInGroup.AcceptChanges();
                }
                else
                {
                    XtraMessageBox.Show(this, "მონაცემი არ შენახულა.", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                BindingUserInGroup(false);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, "შეცდომა მომხმარებლის ჯგუფებში განაწილებისას.\r" + ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}