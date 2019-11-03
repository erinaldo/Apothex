using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace Apothex.Configuration
{
    public partial class frmOptions : XtraForm
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        #region Properties
        public string ServerName
        {
            get { return txtServerName.Text.Trim(); }
            set { txtServerName.Text = value; }
        }
        public string DatabaseName
        {
            get { return txtDatabaseName.Text.Trim(); }
            set { txtDatabaseName.Text = value; }
        }
        public string UserName
        {
            get { return txtUserName.Text.Trim(); }
            set { txtUserName.Text = value; }
        }
        public string Password
        {
            get { return txtPassword.Text.Trim(); }
            set { txtPassword.Text = value; }
        }
        public int ConnectionTimeout
        {
            get { return (int)spinConnectionTimeout.Value; }
            set { spinConnectionTimeout.Value = value; }
        }
        public int CommandTimeout
        {
            get { return (int)spinCommandTimeout.Value; }
            set { spinCommandTimeout.Value = value; }
        }

        public bool AutoNewRow
        {
            get { return chkAutoNewRow.Checked; }
            set { chkAutoNewRow.Checked = value; }
        }
        public bool OfflineMode
        {
            get { return chkOfflineMode.Checked; }
            set { chkOfflineMode.Checked = value; }
        }

        public string OfflineServerName
        {
            get { return txtOfflineServerName.Text.Trim(); }
            set { txtOfflineServerName.Text = value; }
        }
        public string OfflineDatabaseName
        {
            get { return txtOfflineDatabaseName.Text.Trim(); }
            set { txtOfflineDatabaseName.Text = value; }
        }
        public string OfflineUserName
        {
            get { return txtOfflineUserName.Text.Trim(); }
            set { txtOfflineUserName.Text = value; }
        }
        public string OfflinePassword
        {
            get { return txtOfflinePassword.Text.Trim(); }
            set { txtOfflinePassword.Text = value; }
        }
        public int OfflineConnectionTimeout
        {
            get { return (int)spinOfflineConnectionTimeout.Value; }
            set { spinOfflineConnectionTimeout.Value = value; }
        }
        public int OfflineCommandTimeout
        {
            get { return (int)spinOfflineCommandTimeout.Value; }
            set { spinOfflineCommandTimeout.Value = value; }
        }

        public bool UseHedgehog
        {
            get { return chkUseHedgehog.Checked; }
            set { chkUseHedgehog.Checked = value; }
        }
        public string HedgehogFile
        {
            get { return beHedgehogFile.Text.Trim(); }
            set { beHedgehogFile.Text = value; }
        }
        #endregion

        #region Bindings
        private void BindControls()
        {
            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                ServerName = ConfigurationManagerEx.ServerName;
                DatabaseName = ConfigurationManagerEx.DatabaseName;
                UserName = ConfigurationManagerEx.UserName;
                Password = ConfigurationManagerEx.Password;
                ConnectionTimeout = ConfigurationManagerEx.ConnectionTimeout;
                CommandTimeout = ConfigurationManagerEx.CommandTimeout;

                AutoNewRow = ConfigurationManagerEx.AutoNewRow;
                OfflineMode = ConfigurationManagerEx.OfflineMode;

                OfflineServerName = ConfigurationManagerEx.OfflineServerName;
                OfflineDatabaseName = ConfigurationManagerEx.OfflineDatabaseName;
                OfflineUserName = ConfigurationManagerEx.OfflineUserName;
                OfflinePassword = ConfigurationManagerEx.OfflinePassword;
                OfflineConnectionTimeout = ConfigurationManagerEx.OfflineConnectionTimeout;
                OfflineCommandTimeout = ConfigurationManagerEx.OfflineCommandTimeout;

                UseHedgehog = ConfigurationManagerEx.UseHedgehog;
                HedgehogFile = ConfigurationManagerEx.HedgehogFile;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        #endregion

        #region Validations
        private bool IsValidServerName()
        {
            if (ServerName.Length == 0)
            {
                dxErrorProvider.SetError(txtServerName, "შეიყვანეთ მონაცემთა ბაზის მისამართი.");
                return false;
            }

            return true;
        }
        private bool IsValidDatabaseName()
        {
            if (DatabaseName.Length == 0)
            {
                dxErrorProvider.SetError(txtDatabaseName, "გთხოვთ შეიყვანოთ მონაცემთა ბაზის სახელი (მაგ: Apothex)");
                return false;
            }
            else if (DatabaseName.Contains(" "))
            {
                dxErrorProvider.SetError(txtDatabaseName, "მონაცემთა ბაზის სახელში შეიძლება გამოიყენოთ შემდეგი სიმბოლოები (a-Z0-9_-)");
                return false;
            }

            return true;
        }
        private bool IsValidUsername()
        {
            if (chkUserName.Checked && UserName.Length == 0)
            {
                dxErrorProvider.SetError(txtUserName, "გთხოვთ შეიყვანოთ მონაცემთა ბაზის მომხმარებლის სახელი");
                return false;
            }

            return true;
        }
        private bool IsValidHedgehog()
        {
            if (!UseHedgehog) return true;

            if (HedgehogFile.Length == 0)
            {
                dxErrorProvider.SetError(beHedgehogFile, "არ არის მითითებული ზღარბი ბარათის ფაილი.");
                return false;
            }
            else if (!Path.IsPathRooted(HedgehogFile))
            {
                dxErrorProvider.SetError(beHedgehogFile, "მითითებულ ზღარბის ბარათის ფაილს არ აქვს სწორი მისამართი.");
                return false;
            }
            else if (!Path.HasExtension(HedgehogFile))
            {
                dxErrorProvider.SetError(beHedgehogFile, "მითითებულ ზღარბის ბარათის ფაილს არ აქვს გაფართოება.");
                return false;
            }

            return true;
        }

        private bool IsValidOfflineServerName()
        {
            if (OfflineServerName.Length == 0)
            {
                dxErrorProvider.SetError(txtOfflineServerName, "შეიყვანეთ მონაცემთა ბაზის მისამართი.");
                return false;
            }

            return true;
        }
        private bool IsValidOfflineDatabaseName()
        {
            if (OfflineDatabaseName.Length == 0)
            {
                dxErrorProvider.SetError(txtOfflineDatabaseName, "გთხოვთ შეიყვანოთ მონაცემთა ბაზის სახელი (მაგ: Apothex)");
                return false;
            }
            else if (OfflineDatabaseName.Contains(" "))
            {
                dxErrorProvider.SetError(txtOfflineDatabaseName, "მონაცემთა ბაზის სახელში შეიძლება გამოიყენოთ შემდეგი სიმბოლოები (a-Z0-9_-)");
                return false;
            }

            return true;
        }
        private bool IsValidOfflineUsername()
        {
            if (chkOfflineUserName.Checked && OfflineUserName.Length == 0)
            {
                dxErrorProvider.SetError(txtOfflineUserName, "გთხოვთ შეიყვანოთ მონაცემთა ბაზის მომხმარებლის სახელი");
                return false;
            }

            return true;
        }

        private bool IsValidForm()
        {
            var ok = true;
            if (!IsValidServerName()) ok = false;
            if (!IsValidDatabaseName()) ok = false;
            if (!IsValidUsername()) ok = false;
            if (!IsValidHedgehog()) ok = false;

            if (OfflineMode)
            {
                if (!IsValidOfflineServerName()) ok = false;
                if (!IsValidOfflineDatabaseName()) ok = false;
                if (!IsValidOfflineUsername()) ok = false;
            }

            return ok;
        }
        #endregion

        #region Methods
        private void EnableDisableFormControls()
        {
            chkUserName.Checked = (UserName.Length > 0);
            chkConnectionTimeout.Checked = (spinConnectionTimeout.Value > 0m);
            chkCommandTimeout.Checked = (spinCommandTimeout.Value > 0m);

            tabOffline.PageVisible = OfflineMode;
            chkOfflineUserName.Checked = (OfflineUserName.Length > 0);
            chkOfflineConnectionTimeout.Checked = (spinOfflineConnectionTimeout.Value > 0m);
            chkOfflineCommandTimeout.Checked = (spinOfflineCommandTimeout.Value > 0m);
        }
        #endregion

        private void frmOptions_Load(object sender, EventArgs e)
        {
            BindControls();
            EnableDisableFormControls();
        }

        private void txtDataSource_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtServerName, string.Empty);
        }

        private void txtDatabaseName_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtDatabaseName, string.Empty);
        }

        private void chkUserName_CheckedChanged(object sender, EventArgs e)
        {
            txtUserName.Enabled = chkUserName.Checked;
            txtPassword.Enabled = chkUserName.Checked;
            if (!chkUserName.Checked)
            {
                dxErrorProvider.SetError(txtUserName, string.Empty);
                dxErrorProvider.SetError(txtPassword, string.Empty);
            }
        }

        private void txtUsername_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtUserName, string.Empty);
        }

        private void chkConnectionTimeout_CheckedChanged(object sender, EventArgs e)
        {
            spinConnectionTimeout.Enabled = chkConnectionTimeout.Checked;
        }

        private void chkCommandTimeout_CheckedChanged(object sender, EventArgs e)
        {
            spinCommandTimeout.Enabled = chkCommandTimeout.Checked;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var ok = IsValidForm();
            if (ok)
            {
                try
                {
                    ConfigurationManagerEx.ServerName = ServerName;
                    ConfigurationManagerEx.DatabaseName = DatabaseName;
                    ConfigurationManagerEx.UserName = (chkUserName.Checked ? UserName : string.Empty);
                    ConfigurationManagerEx.Password = (chkUserName.Checked ? Password : string.Empty);
                    ConfigurationManagerEx.ConnectionTimeout = chkConnectionTimeout.Checked ? ConnectionTimeout : 0;
                    ConfigurationManagerEx.CommandTimeout = chkCommandTimeout.Checked ? CommandTimeout : 0;

                    ConfigurationManagerEx.AutoNewRow = AutoNewRow;
                    ConfigurationManagerEx.OfflineMode = OfflineMode;


                    ConfigurationManagerEx.OfflineServerName = OfflineServerName;
                    ConfigurationManagerEx.OfflineDatabaseName = OfflineDatabaseName;
                    ConfigurationManagerEx.OfflineUserName = (chkOfflineUserName.Checked ? OfflineUserName : string.Empty);
                    ConfigurationManagerEx.OfflinePassword = (chkOfflineUserName.Checked ? OfflinePassword : string.Empty);
                    ConfigurationManagerEx.OfflineConnectionTimeout = chkOfflineConnectionTimeout.Checked ? OfflineConnectionTimeout : 0;
                    ConfigurationManagerEx.OfflineCommandTimeout = chkOfflineCommandTimeout.Checked ? OfflineCommandTimeout : 0;


                    ConfigurationManagerEx.UseHedgehog = UseHedgehog;
                    ConfigurationManagerEx.HedgehogFile = HedgehogFile;


                    ConfigurationManagerEx.Save();
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(this, string.Format("შეცდომა კონფიგურაციის შენახვისას.\r{0}", ex.Message), "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void beHedgehogFile_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            ofdHedgehog.ShowDialog(this);
        }

        private void ofdHedgehog_FileOk(object sender, CancelEventArgs e)
        {
            HedgehogFile = ofdHedgehog.FileName;
        }

        private void chkUseHedgehog_CheckedChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(beHedgehogFile, string.Empty);
        }

        private void beHedgehogFile_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(beHedgehogFile, string.Empty);
        }

        private void chkOfflineUserName_CheckedChanged(object sender, EventArgs e)
        {
            txtOfflineUserName.Enabled =
            txtOfflinePassword.Enabled = chkOfflineUserName.Checked;
            if (!chkOfflineUserName.Checked)
            {
                dxErrorProvider.SetError(txtOfflineUserName, string.Empty);
                dxErrorProvider.SetError(txtOfflinePassword, string.Empty);
            }
        }

        private void chkOfflineConnectionTimeout_CheckedChanged(object sender, EventArgs e)
        {
            spinOfflineConnectionTimeout.Enabled = chkOfflineConnectionTimeout.Checked;
        }

        private void chkOfflineCommandTimeout_CheckedChanged(object sender, EventArgs e)
        {
            spinOfflineCommandTimeout.Enabled = chkOfflineCommandTimeout.Checked;
        }

        private void txtOfflineDataSource_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtOfflineServerName, string.Empty);
        }

        private void txtOfflineDatabaseName_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtOfflineDatabaseName, string.Empty);
        }

        private void txtOfflineUserName_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtOfflineUserName, string.Empty);
        }

        private void txtOfflinePassword_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtOfflinePassword, string.Empty);
        }

        private void chkOfflineMode_CheckedChanged(object sender, EventArgs e)
        {
            tabOffline.PageVisible = OfflineMode;
        }
    }
}