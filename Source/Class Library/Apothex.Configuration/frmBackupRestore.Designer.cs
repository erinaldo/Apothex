namespace Apothex.Configuration
{
    partial class frmBackupRestore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpSettings = new DevExpress.XtraEditors.GroupControl();
            this.btnConnect = new DevExpress.XtraEditors.SimpleButton();
            this.txtDatabaseName = new DevExpress.XtraEditors.TextEdit();
            this.lblDatabaseName = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.txtServerName = new DevExpress.XtraEditors.TextEdit();
            this.lblServerName = new DevExpress.XtraEditors.LabelControl();
            this.btnBackup = new DevExpress.XtraEditors.SimpleButton();
            this.btnRestore = new DevExpress.XtraEditors.SimpleButton();
            this.progressBar = new DevExpress.XtraEditors.ProgressBarControl();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.openBackupDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveBackupDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grpSettings)).BeginInit();
            this.grpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabaseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSettings
            // 
            this.grpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSettings.AppearanceCaption.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpSettings.AppearanceCaption.Options.UseFont = true;
            this.grpSettings.Controls.Add(this.btnConnect);
            this.grpSettings.Controls.Add(this.txtDatabaseName);
            this.grpSettings.Controls.Add(this.lblDatabaseName);
            this.grpSettings.Controls.Add(this.txtPassword);
            this.grpSettings.Controls.Add(this.lblPassword);
            this.grpSettings.Controls.Add(this.txtUserName);
            this.grpSettings.Controls.Add(this.lblUserName);
            this.grpSettings.Controls.Add(this.txtServerName);
            this.grpSettings.Controls.Add(this.lblServerName);
            this.grpSettings.Location = new System.Drawing.Point(12, 12);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(420, 190);
            this.grpSettings.TabIndex = 0;
            this.grpSettings.Text = "კონფიგურაცია";
            // 
            // btnConnect
            // 
            this.btnConnect.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConnect.Appearance.Options.UseFont = true;
            this.btnConnect.Location = new System.Drawing.Point(115, 143);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(298, 33);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "კავშირის შემოწმება";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.EnterMoveNextControl = true;
            this.txtDatabaseName.Location = new System.Drawing.Point(115, 113);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDatabaseName.Properties.Appearance.Options.UseFont = true;
            this.txtDatabaseName.Size = new System.Drawing.Size(298, 23);
            this.txtDatabaseName.TabIndex = 7;
            this.txtDatabaseName.EditValueChanged += new System.EventHandler(this.txtDatabase_EditValueChanged);
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDatabaseName.Appearance.Options.UseFont = true;
            this.lblDatabaseName.Location = new System.Drawing.Point(5, 116);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(106, 17);
            this.lblDatabaseName.TabIndex = 6;
            this.lblDatabaseName.Text = "ბაზის სახელი:";
            // 
            // txtPassword
            // 
            this.txtPassword.EnterMoveNextControl = true;
            this.txtPassword.Location = new System.Drawing.Point(115, 84);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(298, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.EditValueChanged += new System.EventHandler(this.txtPassword_EditValueChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Appearance.Options.UseFont = true;
            this.lblPassword.Location = new System.Drawing.Point(5, 87);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "პაროლი:";
            // 
            // txtUserName
            // 
            this.txtUserName.EnterMoveNextControl = true;
            this.txtUserName.Location = new System.Drawing.Point(115, 55);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Size = new System.Drawing.Size(298, 23);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.EditValueChanged += new System.EventHandler(this.txtUsername_EditValueChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserName.Appearance.Options.UseFont = true;
            this.lblUserName.Location = new System.Drawing.Point(5, 58);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(85, 17);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "მომხმარებ:";
            // 
            // txtServerName
            // 
            this.txtServerName.EnterMoveNextControl = true;
            this.txtServerName.Location = new System.Drawing.Point(115, 26);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtServerName.Properties.Appearance.Options.UseFont = true;
            this.txtServerName.Size = new System.Drawing.Size(298, 23);
            this.txtServerName.TabIndex = 1;
            this.txtServerName.EditValueChanged += new System.EventHandler(this.txtServer_EditValueChanged);
            // 
            // lblServerName
            // 
            this.lblServerName.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblServerName.Appearance.Options.UseFont = true;
            this.lblServerName.Location = new System.Drawing.Point(5, 29);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(69, 17);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "სერვერი:";
            // 
            // btnBackup
            // 
            this.btnBackup.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackup.Appearance.Options.UseFont = true;
            this.btnBackup.Location = new System.Drawing.Point(68, 215);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(150, 33);
            this.btnBackup.TabIndex = 1;
            this.btnBackup.Text = "შენახვა";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestore.Appearance.Options.UseFont = true;
            this.btnRestore.Location = new System.Drawing.Point(224, 215);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(150, 33);
            this.btnRestore.TabIndex = 2;
            this.btnRestore.Text = "აღდგენა";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 261);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(420, 23);
            this.progressBar.TabIndex = 3;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // openBackupDialog
            // 
            this.openBackupDialog.FileName = "Backup.bak";
            this.openBackupDialog.Filter = "Backup File|*.bak";
            // 
            // saveBackupDialog
            // 
            this.saveBackupDialog.FileName = "Backup.bak";
            this.saveBackupDialog.Filter = "Backup File|*.bak";
            // 
            // frmBackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 298);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.grpSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBackupRestore";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "მონაცემთა ბაზის შენახვა/აღდგენა";
            this.Load += new System.EventHandler(this.frmBackupRestore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpSettings)).EndInit();
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabaseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpSettings;
        private DevExpress.XtraEditors.TextEdit txtServerName;
        private DevExpress.XtraEditors.LabelControl lblServerName;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl lblUserName;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.TextEdit txtDatabaseName;
        private DevExpress.XtraEditors.LabelControl lblDatabaseName;
        private DevExpress.XtraEditors.SimpleButton btnConnect;
        private DevExpress.XtraEditors.SimpleButton btnBackup;
        private DevExpress.XtraEditors.SimpleButton btnRestore;
        private DevExpress.XtraEditors.ProgressBarControl progressBar;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private System.Windows.Forms.OpenFileDialog openBackupDialog;
        private System.Windows.Forms.SaveFileDialog saveBackupDialog;
    }
}