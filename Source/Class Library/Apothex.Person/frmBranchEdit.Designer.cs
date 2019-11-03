namespace Apothex.Person
{
    partial class frmBranchEdit
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabMain = new DevExpress.XtraTab.XtraTabPage();
            this.bbCompany = new Apothex.Windows.Forms.ButtonBrowse();
            this.txtActFormat = new DevExpress.XtraEditors.TextEdit();
            this.lblActFormat = new DevExpress.XtraEditors.LabelControl();
            this.txtFax = new DevExpress.XtraEditors.TextEdit();
            this.lblFax = new DevExpress.XtraEditors.LabelControl();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.lblPhone = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.txtBranchName = new DevExpress.XtraEditors.TextEdit();
            this.lblCode = new DevExpress.XtraEditors.LabelControl();
            this.lblCompany = new DevExpress.XtraEditors.LabelControl();
            this.lblBranchName = new DevExpress.XtraEditors.LabelControl();
            this.tabInfo = new DevExpress.XtraTab.XtraTabPage();
            this.bbApprover = new Apothex.Windows.Forms.ButtonBrowse();
            this.bbModifier = new Apothex.Windows.Forms.ButtonBrowse();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblApprover = new DevExpress.XtraEditors.LabelControl();
            this.dateModifiedDate = new DevExpress.XtraEditors.DateEdit();
            this.lblModifier = new DevExpress.XtraEditors.LabelControl();
            this.lblModifiedDate = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActFormat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranchName.Properties)).BeginInit();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbApprover.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbModifier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifiedDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifiedDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.AppearancePage.Header.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xtraTabControl.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl.Location = new System.Drawing.Point(0, 39);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.SelectedTabPage = this.tabMain;
            this.xtraTabControl.Size = new System.Drawing.Size(784, 523);
            this.xtraTabControl.TabIndex = 0;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabMain,
            this.tabInfo});
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.bbCompany);
            this.tabMain.Controls.Add(this.txtActFormat);
            this.tabMain.Controls.Add(this.lblActFormat);
            this.tabMain.Controls.Add(this.txtFax);
            this.tabMain.Controls.Add(this.lblFax);
            this.tabMain.Controls.Add(this.txtPhone);
            this.tabMain.Controls.Add(this.lblPhone);
            this.tabMain.Controls.Add(this.txtAddress);
            this.tabMain.Controls.Add(this.lblAddress);
            this.tabMain.Controls.Add(this.txtCode);
            this.tabMain.Controls.Add(this.txtBranchName);
            this.tabMain.Controls.Add(this.lblCode);
            this.tabMain.Controls.Add(this.lblCompany);
            this.tabMain.Controls.Add(this.lblBranchName);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(778, 493);
            this.tabMain.Text = "მთავარი";
            // 
            // bbCompany
            // 
            this.bbCompany.EnterMoveNextControl = true;
            this.bbCompany.IsOnline = true;
            this.bbCompany.Location = new System.Drawing.Point(134, 6);
            this.bbCompany.MenuManager = this.barManager;
            this.bbCompany.Name = "bbCompany";
            this.bbCompany.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F);
            this.bbCompany.Properties.Appearance.Options.UseFont = true;
            this.bbCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject1, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject2, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbCompany.Size = new System.Drawing.Size(387, 23);
            this.bbCompany.TabIndex = 1;
            this.bbCompany.TableName = Apothex.DataType.ObjectNames.Company;
            // 
            // txtActFormat
            // 
            this.txtActFormat.EnterMoveNextControl = true;
            this.txtActFormat.Location = new System.Drawing.Point(134, 180);
            this.txtActFormat.Name = "txtActFormat";
            this.txtActFormat.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtActFormat.Properties.Appearance.Options.UseFont = true;
            this.txtActFormat.Properties.MaxLength = 100;
            this.txtActFormat.Size = new System.Drawing.Size(387, 23);
            this.txtActFormat.TabIndex = 13;
            this.txtActFormat.ToolTip = "მაგ: აბგ/{autonumber}-{year}";
            // 
            // lblActFormat
            // 
            this.lblActFormat.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblActFormat.Location = new System.Drawing.Point(6, 183);
            this.lblActFormat.Name = "lblActFormat";
            this.lblActFormat.Size = new System.Drawing.Size(122, 17);
            this.lblActFormat.TabIndex = 12;
            this.lblActFormat.Text = "აქტის ფორმატი:";
            // 
            // txtFax
            // 
            this.txtFax.EnterMoveNextControl = true;
            this.txtFax.Location = new System.Drawing.Point(134, 151);
            this.txtFax.Name = "txtFax";
            this.txtFax.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFax.Properties.Appearance.Options.UseFont = true;
            this.txtFax.Properties.MaxLength = 50;
            this.txtFax.Size = new System.Drawing.Size(200, 23);
            this.txtFax.TabIndex = 11;
            // 
            // lblFax
            // 
            this.lblFax.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFax.Location = new System.Drawing.Point(6, 154);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(49, 17);
            this.lblFax.TabIndex = 10;
            this.lblFax.Text = "ფაქსი:";
            // 
            // txtPhone
            // 
            this.txtPhone.EnterMoveNextControl = true;
            this.txtPhone.Location = new System.Drawing.Point(134, 122);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPhone.Properties.MaxLength = 50;
            this.txtPhone.Size = new System.Drawing.Size(200, 23);
            this.txtPhone.TabIndex = 9;
            // 
            // lblPhone
            // 
            this.lblPhone.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhone.Location = new System.Drawing.Point(6, 125);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(87, 17);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "ტელეფონი:";
            // 
            // txtAddress
            // 
            this.txtAddress.EnterMoveNextControl = true;
            this.txtAddress.Location = new System.Drawing.Point(134, 93);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Properties.MaxLength = 100;
            this.txtAddress.Size = new System.Drawing.Size(387, 23);
            this.txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddress.Location = new System.Drawing.Point(6, 96);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(85, 17);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "მისამართი:";
            // 
            // txtCode
            // 
            this.txtCode.EnterMoveNextControl = true;
            this.txtCode.Location = new System.Drawing.Point(134, 35);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCode.Properties.Appearance.Options.UseFont = true;
            this.txtCode.Properties.MaxLength = 10;
            this.txtCode.Size = new System.Drawing.Size(200, 23);
            this.txtCode.TabIndex = 3;
            this.txtCode.EditValueChanged += new System.EventHandler(this.txtBranchName_EditValueChanged);
            // 
            // txtBranchName
            // 
            this.txtBranchName.EnterMoveNextControl = true;
            this.txtBranchName.Location = new System.Drawing.Point(134, 64);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBranchName.Properties.Appearance.Options.UseFont = true;
            this.txtBranchName.Properties.MaxLength = 100;
            this.txtBranchName.Size = new System.Drawing.Size(387, 23);
            this.txtBranchName.TabIndex = 5;
            this.txtBranchName.EditValueChanged += new System.EventHandler(this.txtBranchName_EditValueChanged);
            // 
            // lblCode
            // 
            this.lblCode.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCode.Location = new System.Drawing.Point(6, 38);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(44, 17);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "კოდი:";
            // 
            // lblCompany
            // 
            this.lblCompany.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompany.Location = new System.Drawing.Point(6, 9);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(72, 17);
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "კომპანია:";
            // 
            // lblBranchName
            // 
            this.lblBranchName.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBranchName.Location = new System.Drawing.Point(6, 67);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Size = new System.Drawing.Size(97, 17);
            this.lblBranchName.TabIndex = 4;
            this.lblBranchName.Text = "დასახელება:";
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.bbApprover);
            this.tabInfo.Controls.Add(this.bbModifier);
            this.tabInfo.Controls.Add(this.txtID);
            this.tabInfo.Controls.Add(this.lblApprover);
            this.tabInfo.Controls.Add(this.dateModifiedDate);
            this.tabInfo.Controls.Add(this.lblModifier);
            this.tabInfo.Controls.Add(this.lblModifiedDate);
            this.tabInfo.Controls.Add(this.lblID);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Size = new System.Drawing.Size(778, 493);
            this.tabInfo.Text = "ინფორმაცია";
            // 
            // bbApprover
            // 
            this.bbApprover.EnterMoveNextControl = true;
            this.bbApprover.IsOnline = true;
            this.bbApprover.Location = new System.Drawing.Point(89, 93);
            this.bbApprover.Name = "bbApprover";
            this.bbApprover.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bbApprover.Properties.Appearance.Options.UseFont = true;
            this.bbApprover.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bbApprover.Properties.ReadOnly = true;
            this.bbApprover.Size = new System.Drawing.Size(300, 23);
            this.bbApprover.TabIndex = 7;
            this.bbApprover.TableName = Apothex.DataType.ObjectNames.User;
            // 
            // bbModifier
            // 
            this.bbModifier.EnterMoveNextControl = true;
            this.bbModifier.IsOnline = true;
            this.bbModifier.Location = new System.Drawing.Point(89, 65);
            this.bbModifier.Name = "bbModifier";
            this.bbModifier.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bbModifier.Properties.Appearance.Options.UseFont = true;
            this.bbModifier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bbModifier.Properties.ReadOnly = true;
            this.bbModifier.Size = new System.Drawing.Size(300, 23);
            this.bbModifier.TabIndex = 5;
            this.bbModifier.TableName = Apothex.DataType.ObjectNames.User;
            // 
            // txtID
            // 
            this.txtID.EnterMoveNextControl = true;
            this.txtID.Location = new System.Drawing.Point(89, 6);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(150, 23);
            this.txtID.TabIndex = 1;
            // 
            // lblApprover
            // 
            this.lblApprover.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblApprover.Location = new System.Drawing.Point(6, 97);
            this.lblApprover.Name = "lblApprover";
            this.lblApprover.Size = new System.Drawing.Size(77, 17);
            this.lblApprover.TabIndex = 6;
            this.lblApprover.Text = "დაამოწმა:";
            // 
            // dateModifiedDate
            // 
            this.dateModifiedDate.EditValue = null;
            this.dateModifiedDate.EnterMoveNextControl = true;
            this.dateModifiedDate.Location = new System.Drawing.Point(89, 35);
            this.dateModifiedDate.Name = "dateModifiedDate";
            this.dateModifiedDate.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateModifiedDate.Properties.Appearance.Options.UseFont = true;
            this.dateModifiedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateModifiedDate.Properties.DisplayFormat.FormatString = "G";
            this.dateModifiedDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateModifiedDate.Properties.EditFormat.FormatString = "G";
            this.dateModifiedDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateModifiedDate.Properties.Mask.EditMask = "G";
            this.dateModifiedDate.Properties.ReadOnly = true;
            this.dateModifiedDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateModifiedDate.Size = new System.Drawing.Size(150, 23);
            this.dateModifiedDate.TabIndex = 3;
            // 
            // lblModifier
            // 
            this.lblModifier.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblModifier.Location = new System.Drawing.Point(6, 68);
            this.lblModifier.Name = "lblModifier";
            this.lblModifier.Size = new System.Drawing.Size(70, 17);
            this.lblModifier.TabIndex = 4;
            this.lblModifier.Text = "შეცვალა:";
            // 
            // lblModifiedDate
            // 
            this.lblModifiedDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblModifiedDate.Location = new System.Drawing.Point(6, 38);
            this.lblModifiedDate.Name = "lblModifiedDate";
            this.lblModifiedDate.Size = new System.Drawing.Size(65, 17);
            this.lblModifiedDate.TabIndex = 2;
            this.lblModifiedDate.Text = "თარიღი:";
            // 
            // lblID
            // 
            this.lblID.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblID.Location = new System.Drawing.Point(6, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // frmBranchEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.xtraTabControl);
            this.Name = "frmBranchEdit";
            this.ObjectName = Apothex.DataType.ObjectNames.Branch;
            this.OptionsBaseForm.Text = "ფილიალი";
            this.Text = "ფილიალი";
            this.Controls.SetChildIndex(this.xtraTabControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActFormat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranchName.Properties)).EndInit();
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbApprover.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbModifier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifiedDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifiedDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage tabMain;
        private DevExpress.XtraEditors.TextEdit txtBranchName;
        private DevExpress.XtraEditors.LabelControl lblBranchName;
        private DevExpress.XtraTab.XtraTabPage tabInfo;
        private Apothex.Windows.Forms.ButtonBrowse bbApprover;
        private Apothex.Windows.Forms.ButtonBrowse bbModifier;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblApprover;
        private DevExpress.XtraEditors.DateEdit dateModifiedDate;
        private DevExpress.XtraEditors.LabelControl lblModifier;
        private DevExpress.XtraEditors.LabelControl lblModifiedDate;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl lblAddress;
        private DevExpress.XtraEditors.TextEdit txtFax;
        private DevExpress.XtraEditors.LabelControl lblFax;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.LabelControl lblPhone;
        private Windows.Forms.ButtonBrowse bbCompany;
        private DevExpress.XtraEditors.LabelControl lblCompany;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl lblCode;
        private DevExpress.XtraEditors.TextEdit txtActFormat;
        private DevExpress.XtraEditors.LabelControl lblActFormat;
    }
}