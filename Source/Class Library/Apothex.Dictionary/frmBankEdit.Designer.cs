namespace Apothex.Dictionary
{
    partial class frmBankEdit
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
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabMain = new DevExpress.XtraTab.XtraTabPage();
            this.txtBankCode = new DevExpress.XtraEditors.TextEdit();
            this.lblBankCode = new DevExpress.XtraEditors.LabelControl();
            this.txtBankName = new DevExpress.XtraEditors.TextEdit();
            this.lblBankName = new DevExpress.XtraEditors.LabelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtBankCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).BeginInit();
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
            this.tabMain.Controls.Add(this.txtBankCode);
            this.tabMain.Controls.Add(this.lblBankCode);
            this.tabMain.Controls.Add(this.txtBankName);
            this.tabMain.Controls.Add(this.lblBankName);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(778, 493);
            this.tabMain.Text = "მთავარი";
            // 
            // txtBankCode
            // 
            this.txtBankCode.EnterMoveNextControl = true;
            this.txtBankCode.Location = new System.Drawing.Point(109, 35);
            this.txtBankCode.Name = "txtBankCode";
            this.txtBankCode.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBankCode.Properties.Appearance.Options.UseFont = true;
            this.txtBankCode.Properties.Mask.EditMask = "\\d{0,25}";
            this.txtBankCode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtBankCode.Properties.MaxLength = 25;
            this.txtBankCode.Size = new System.Drawing.Size(200, 23);
            this.txtBankCode.TabIndex = 3;
            this.txtBankCode.EditValueChanged += new System.EventHandler(this.txtBankCode_EditValueChanged);
            // 
            // lblBankCode
            // 
            this.lblBankCode.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBankCode.Location = new System.Drawing.Point(6, 38);
            this.lblBankCode.Name = "lblBankCode";
            this.lblBankCode.Size = new System.Drawing.Size(85, 17);
            this.lblBankCode.TabIndex = 2;
            this.lblBankCode.Text = "ბანკ. კოდი:";
            // 
            // txtBankName
            // 
            this.txtBankName.EnterMoveNextControl = true;
            this.txtBankName.Location = new System.Drawing.Point(109, 6);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBankName.Properties.Appearance.Options.UseFont = true;
            this.txtBankName.Properties.MaxLength = 100;
            this.txtBankName.Size = new System.Drawing.Size(349, 23);
            this.txtBankName.TabIndex = 1;
            this.txtBankName.EditValueChanged += new System.EventHandler(this.txtBankName_EditValueChanged);
            // 
            // lblBankName
            // 
            this.lblBankName.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBankName.Location = new System.Drawing.Point(6, 9);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(97, 17);
            this.lblBankName.TabIndex = 0;
            this.lblBankName.Text = "დასახელება:";
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
            this.tabInfo.Size = new System.Drawing.Size(786, 455);
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
            this.txtID.Size = new System.Drawing.Size(300, 23);
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
            // frmBankEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.xtraTabControl);
            this.Name = "frmBankEdit";
            this.ObjectName = Apothex.DataType.ObjectNames.Bank;
            this.OptionsBaseForm.Text = "ბანკი";
            this.Text = "ბანკი";
            this.Controls.SetChildIndex(this.xtraTabControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).EndInit();
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
        private DevExpress.XtraTab.XtraTabPage tabInfo;
        private DevExpress.XtraEditors.TextEdit txtBankCode;
        private DevExpress.XtraEditors.LabelControl lblBankCode;
        private DevExpress.XtraEditors.TextEdit txtBankName;
        private DevExpress.XtraEditors.LabelControl lblBankName;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.DateEdit dateModifiedDate;
        private DevExpress.XtraEditors.LabelControl lblModifiedDate;
        private Apothex.Windows.Forms.ButtonBrowse bbModifier;
        private Apothex.Windows.Forms.ButtonBrowse bbApprover;
        private DevExpress.XtraEditors.LabelControl lblApprover;
        private DevExpress.XtraEditors.LabelControl lblModifier;
    }
}