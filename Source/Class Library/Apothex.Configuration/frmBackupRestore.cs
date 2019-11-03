using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using System.Data.SqlClient;

namespace Apothex.Configuration
{
    public partial class frmBackupRestore : DevExpress.XtraEditors.XtraForm
    {
        public frmBackupRestore(bool isAllowedBackup, bool isAllowedRestore)
        {
            InitializeComponent();
            this.isAllowedBackup = isAllowedBackup;
            this.isAllowedRestore = isAllowedRestore;

            ServerName = ConfigurationManagerEx.ServerName;
            DatabaseName = ConfigurationManagerEx.DatabaseName;

            backup = new Zek.SqlServer.BackupHelper();
            backup.Complete += new Microsoft.SqlServer.Management.Common.ServerMessageEventHandler(OnComplete);
            backup.PercentComplete += new Microsoft.SqlServer.Management.Smo.PercentCompleteEventHandler(OnPercentComplete);

            restore = new Zek.SqlServer.RestoreHelper();
            restore.Complete += new Microsoft.SqlServer.Management.Common.ServerMessageEventHandler(OnComplete);
            restore.PercentComplete += new Microsoft.SqlServer.Management.Smo.PercentCompleteEventHandler(OnPercentComplete);
        }

        private readonly bool isAllowedBackup = false;
        private readonly bool isAllowedRestore = false;

        Zek.SqlServer.BackupHelper backup;
        Zek.SqlServer.RestoreHelper restore;

        public string ServerName
        {
            get { return txtServerName.Text.Trim(); }
            set { txtServerName.Text = value; }
        }
        public string UserName
        {
            get { return txtUserName.Text.Trim(); }
            set { txtUserName.Text = value; }
        }
        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }
        public string DatabaseName
        {
            get { return txtDatabaseName.Text.Trim(); }
            set { txtDatabaseName.Text = value; }
        }
        public string ConnectionString
        {
            get
            {
                SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();

                connectionStringBuilder.DataSource = ServerName;

                connectionStringBuilder.InitialCatalog = DatabaseName;

                if (UserName.Length == 0)
                    connectionStringBuilder.IntegratedSecurity = true;
                else
                    connectionStringBuilder.UserID = UserName;

                if (Password.Length > 0 & UserName.Length > 0)
                    connectionStringBuilder.Password = Password;

                connectionStringBuilder.PersistSecurityInfo = true;

                return connectionStringBuilder.ConnectionString;
            }
        }

        public bool IsValidServer()
        {
            if (ServerName.Length == 0)
            {
                dxErrorProvider.SetError(txtServerName, "გთხოვთ შეიყვანოთ სერვერის მისამართი.");
                return false;
            }

            return true;
        }
        public bool IsValidDatabase()
        {
            if (DatabaseName.Length == 0)
            {
                dxErrorProvider.SetError(txtDatabaseName, "გთხოვთ შეიყვანოთ მონაცემთა ბაზის დასახელება.");
                return false; 
            }

            return true;
        }
        public bool IsValidFormControls()
        {
            bool ok = true;
            if (!IsValidServer()) ok = false;
            if (!IsValidDatabase()) ok = false;

            return ok;
        }
        public bool IsValid
        {
            get { return IsValidFormControls(); }
        }

        public void EnableDisableFormControls()
        {
            btnConnect.Enabled = (isAllowedBackup || isAllowedRestore);

            btnBackup.Enabled = isAllowedBackup;
            btnRestore.Enabled = isAllowedRestore;
        }

        private void frmBackupRestore_Load(object sender, EventArgs e)
        {
            EnableDisableFormControls();
        }

        private void txtServer_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtServerName, string.Empty);
        }

        private void txtUsername_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtUserName, string.Empty);
        }

        private void txtPassword_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtPassword, string.Empty);
        }

        private void txtDatabase_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtDatabaseName, string.Empty);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!IsValid) return;

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                XtraMessageBox.Show(this, "კავშირი წარმატებით დამყარდა.", "ინფორმაცია", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, "შეცდომა მონაცემთა ბაზასთან დაკაშირების დროს.\n" + ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (!isAllowedBackup) return;
            progressBar.Position = 0;
            if (!IsValid) return;

            if (saveBackupDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                backup.BackupDatabase(ServerName, UserName, Password, DatabaseName, saveBackupDialog.FileName);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, "შეცდომა მონაცემთა ბაზასთან შენახვის დროს.\n" + ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (!isAllowedRestore) return;
            progressBar.Position = 0;
            if (!IsValid) return;

            if (openBackupDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                restore.RestoreDatabase(ServerName, UserName, Password, DatabaseName, openBackupDialog.FileName, null, null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, "შეცდომა მონაცემთა ბაზასთან აღდგენის დროს.\n" + ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void OnComplete(object sender, Microsoft.SqlServer.Management.Common.ServerMessageEventArgs e)
        {
            XtraMessageBox.Show(this, "ოპერაცია წარმატებით განხორციელდა.", "ინფორმაცია", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OnPercentComplete(object sender, Microsoft.SqlServer.Management.Smo.PercentCompleteEventArgs e)
        {
            progressBar.Position = e.Percent;
        }
    }
}