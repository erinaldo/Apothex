namespace Apothex.Dictionary
{
    partial class frmCurrencyEdit
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
            this.spinCurrencyRate = new DevExpress.XtraEditors.SpinEdit();
            this.lblCurrencyRate = new DevExpress.XtraEditors.LabelControl();
            this.spinPosition = new DevExpress.XtraEditors.SpinEdit();
            this.txtCoin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblCoin = new DevExpress.XtraEditors.LabelControl();
            this.txtCurrencyName = new DevExpress.XtraEditors.TextEdit();
            this.lblCurrencyName = new DevExpress.XtraEditors.LabelControl();
            this.txtCurrencyCode = new DevExpress.XtraEditors.TextEdit();
            this.lblCurrencyCode = new DevExpress.XtraEditors.LabelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.spinCurrencyRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCoin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrencyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrencyCode.Properties)).BeginInit();
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
            this.xtraTabControl.Location = new System.Drawing.Point(0, 59);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.SelectedTabPage = this.tabMain;
            this.xtraTabControl.Size = new System.Drawing.Size(792, 485);
            this.xtraTabControl.TabIndex = 0;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabMain,
            this.tabInfo});
            // 
            // tabMain
            // 
            this.tabMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabMain.Controls.Add(this.spinCurrencyRate);
            this.tabMain.Controls.Add(this.lblCurrencyRate);
            this.tabMain.Controls.Add(this.spinPosition);
            this.tabMain.Controls.Add(this.txtCoin);
            this.tabMain.Controls.Add(this.labelControl1);
            this.tabMain.Controls.Add(this.lblCoin);
            this.tabMain.Controls.Add(this.txtCurrencyName);
            this.tabMain.Controls.Add(this.lblCurrencyName);
            this.tabMain.Controls.Add(this.txtCurrencyCode);
            this.tabMain.Controls.Add(this.lblCurrencyCode);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(783, 451);
            this.tabMain.Text = "მთავარი";
            // 
            // spinCurrencyRate
            // 
            this.spinCurrencyRate.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.spinCurrencyRate.EnterMoveNextControl = true;
            this.spinCurrencyRate.Location = new System.Drawing.Point(113, 93);
            this.spinCurrencyRate.Name = "spinCurrencyRate";
            this.spinCurrencyRate.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinCurrencyRate.Properties.Appearance.Options.UseFont = true;
            this.spinCurrencyRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinCurrencyRate.Properties.DisplayFormat.FormatString = "n4";
            this.spinCurrencyRate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinCurrencyRate.Properties.EditFormat.FormatString = "n4";
            this.spinCurrencyRate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinCurrencyRate.Properties.Mask.EditMask = "n4";
            this.spinCurrencyRate.Properties.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.spinCurrencyRate.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.spinCurrencyRate.Size = new System.Drawing.Size(100, 23);
            this.spinCurrencyRate.TabIndex = 7;
            // 
            // lblCurrencyRate
            // 
            this.lblCurrencyRate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrencyRate.Appearance.Options.UseFont = true;
            this.lblCurrencyRate.Location = new System.Drawing.Point(6, 96);
            this.lblCurrencyRate.Name = "lblCurrencyRate";
            this.lblCurrencyRate.Size = new System.Drawing.Size(101, 17);
            this.lblCurrencyRate.TabIndex = 6;
            this.lblCurrencyRate.Text = "ახალი კურსი:";
            // 
            // spinPosition
            // 
            this.spinPosition.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinPosition.EnterMoveNextControl = true;
            this.spinPosition.Location = new System.Drawing.Point(113, 122);
            this.spinPosition.Name = "spinPosition";
            this.spinPosition.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinPosition.Properties.Appearance.Options.UseFont = true;
            this.spinPosition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinPosition.Properties.DisplayFormat.FormatString = "n00";
            this.spinPosition.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinPosition.Properties.EditFormat.FormatString = "n00";
            this.spinPosition.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinPosition.Properties.IsFloatValue = false;
            this.spinPosition.Properties.Mask.EditMask = "N00";
            this.spinPosition.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinPosition.Size = new System.Drawing.Size(100, 23);
            this.spinPosition.TabIndex = 9;
            // 
            // txtCoin
            // 
            this.txtCoin.EnterMoveNextControl = true;
            this.txtCoin.Location = new System.Drawing.Point(113, 64);
            this.txtCoin.Name = "txtCoin";
            this.txtCoin.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCoin.Properties.Appearance.Options.UseFont = true;
            this.txtCoin.Properties.MaxLength = 100;
            this.txtCoin.Size = new System.Drawing.Size(349, 23);
            this.txtCoin.TabIndex = 5;
            this.txtCoin.EditValueChanged += new System.EventHandler(this.txtCoin_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 125);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 17);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "პოზიცია:";
            // 
            // lblCoin
            // 
            this.lblCoin.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCoin.Appearance.Options.UseFont = true;
            this.lblCoin.Location = new System.Drawing.Point(6, 67);
            this.lblCoin.Name = "lblCoin";
            this.lblCoin.Size = new System.Drawing.Size(91, 17);
            this.lblCoin.TabIndex = 4;
            this.lblCoin.Text = "1/100 დასახ:";
            // 
            // txtCurrencyName
            // 
            this.txtCurrencyName.EnterMoveNextControl = true;
            this.txtCurrencyName.Location = new System.Drawing.Point(113, 35);
            this.txtCurrencyName.Name = "txtCurrencyName";
            this.txtCurrencyName.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCurrencyName.Properties.Appearance.Options.UseFont = true;
            this.txtCurrencyName.Properties.MaxLength = 100;
            this.txtCurrencyName.Size = new System.Drawing.Size(349, 23);
            this.txtCurrencyName.TabIndex = 3;
            this.txtCurrencyName.EditValueChanged += new System.EventHandler(this.txtCurrencyName_EditValueChanged);
            // 
            // lblCurrencyName
            // 
            this.lblCurrencyName.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrencyName.Appearance.Options.UseFont = true;
            this.lblCurrencyName.Location = new System.Drawing.Point(6, 38);
            this.lblCurrencyName.Name = "lblCurrencyName";
            this.lblCurrencyName.Size = new System.Drawing.Size(97, 17);
            this.lblCurrencyName.TabIndex = 2;
            this.lblCurrencyName.Text = "დასახელება:";
            // 
            // txtCurrencyCode
            // 
            this.txtCurrencyCode.EnterMoveNextControl = true;
            this.txtCurrencyCode.Location = new System.Drawing.Point(113, 6);
            this.txtCurrencyCode.Name = "txtCurrencyCode";
            this.txtCurrencyCode.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCurrencyCode.Properties.Appearance.Options.UseFont = true;
            this.txtCurrencyCode.Properties.MaxLength = 3;
            this.txtCurrencyCode.Size = new System.Drawing.Size(60, 23);
            this.txtCurrencyCode.TabIndex = 1;
            this.txtCurrencyCode.EditValueChanged += new System.EventHandler(this.txtCurrencyCode_EditValueChanged);
            // 
            // lblCurrencyCode
            // 
            this.lblCurrencyCode.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrencyCode.Appearance.Options.UseFont = true;
            this.lblCurrencyCode.Location = new System.Drawing.Point(6, 9);
            this.lblCurrencyCode.Name = "lblCurrencyCode";
            this.lblCurrencyCode.Size = new System.Drawing.Size(44, 17);
            this.lblCurrencyCode.TabIndex = 0;
            this.lblCurrencyCode.Text = "კოდი:";
            // 
            // tabInfo
            // 
            this.tabInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabInfo.Controls.Add(this.bbApprover);
            this.tabInfo.Controls.Add(this.bbModifier);
            this.tabInfo.Controls.Add(this.txtID);
            this.tabInfo.Controls.Add(this.lblApprover);
            this.tabInfo.Controls.Add(this.dateModifiedDate);
            this.tabInfo.Controls.Add(this.lblModifier);
            this.tabInfo.Controls.Add(this.lblModifiedDate);
            this.tabInfo.Controls.Add(this.lblID);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Size = new System.Drawing.Size(683, 400);
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
            this.bbApprover.RecordValue = null;
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
            this.bbModifier.RecordValue = null;
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
            this.lblApprover.Appearance.Options.UseFont = true;
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
            this.lblModifier.Appearance.Options.UseFont = true;
            this.lblModifier.Location = new System.Drawing.Point(6, 68);
            this.lblModifier.Name = "lblModifier";
            this.lblModifier.Size = new System.Drawing.Size(70, 17);
            this.lblModifier.TabIndex = 4;
            this.lblModifier.Text = "შეცვალა:";
            // 
            // lblModifiedDate
            // 
            this.lblModifiedDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblModifiedDate.Appearance.Options.UseFont = true;
            this.lblModifiedDate.Location = new System.Drawing.Point(6, 38);
            this.lblModifiedDate.Name = "lblModifiedDate";
            this.lblModifiedDate.Size = new System.Drawing.Size(65, 17);
            this.lblModifiedDate.TabIndex = 2;
            this.lblModifiedDate.Text = "თარიღი:";
            // 
            // lblID
            // 
            this.lblID.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblID.Appearance.Options.UseFont = true;
            this.lblID.Location = new System.Drawing.Point(6, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // frmCurrencyEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.Controls.Add(this.xtraTabControl);
            this.Name = "frmCurrencyEdit";
            this.ObjectName = Apothex.DataType.ObjectNames.Currency;
            this.Text = "ვალუტა";
            this.Controls.SetChildIndex(this.xtraTabControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinCurrencyRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCoin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrencyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrencyCode.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtCurrencyName;
        private DevExpress.XtraEditors.LabelControl lblCurrencyName;
        private DevExpress.XtraEditors.TextEdit txtCurrencyCode;
        private DevExpress.XtraEditors.LabelControl lblCurrencyCode;
        private DevExpress.XtraTab.XtraTabPage tabInfo;
        private Apothex.Windows.Forms.ButtonBrowse bbApprover;
        private Apothex.Windows.Forms.ButtonBrowse bbModifier;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblApprover;
        private DevExpress.XtraEditors.DateEdit dateModifiedDate;
        private DevExpress.XtraEditors.LabelControl lblModifier;
        private DevExpress.XtraEditors.LabelControl lblModifiedDate;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.TextEdit txtCoin;
        private DevExpress.XtraEditors.LabelControl lblCoin;
        private DevExpress.XtraEditors.SpinEdit spinPosition;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit spinCurrencyRate;
        private DevExpress.XtraEditors.LabelControl lblCurrencyRate;
    }
}