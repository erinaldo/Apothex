namespace Apothex.Card
{
    partial class frmCardUnitRateEdit
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabMain = new DevExpress.XtraTab.XtraTabPage();
            this.spinUnit = new DevExpress.XtraEditors.SpinEdit();
            this.spinMaxAmount = new DevExpress.XtraEditors.SpinEdit();
            this.lblUnit = new DevExpress.XtraEditors.LabelControl();
            this.lblMaxAmount = new DevExpress.XtraEditors.LabelControl();
            this.spinMinAmount = new DevExpress.XtraEditors.SpinEdit();
            this.lblMinAmount = new DevExpress.XtraEditors.LabelControl();
            this.tabInfo = new DevExpress.XtraTab.XtraTabPage();
            this.bbModifier = new Apothex.Windows.Forms.ButtonBrowse();
            this.bbCreator = new Apothex.Windows.Forms.ButtonBrowse();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.dateCreateDate = new DevExpress.XtraEditors.DateEdit();
            this.lblCreator = new DevExpress.XtraEditors.LabelControl();
            this.dateModifiedDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblModifier = new DevExpress.XtraEditors.LabelControl();
            this.lblModifiedDate = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.spinAmount = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMinAmount.Properties)).BeginInit();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbModifier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbCreator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCreateDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCreateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifiedDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifiedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAmount.Properties)).BeginInit();
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
            this.tabMain.Controls.Add(this.spinAmount);
            this.tabMain.Controls.Add(this.spinUnit);
            this.tabMain.Controls.Add(this.labelControl2);
            this.tabMain.Controls.Add(this.spinMaxAmount);
            this.tabMain.Controls.Add(this.lblUnit);
            this.tabMain.Controls.Add(this.lblMaxAmount);
            this.tabMain.Controls.Add(this.spinMinAmount);
            this.tabMain.Controls.Add(this.lblMinAmount);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(778, 493);
            this.tabMain.Text = "მთავარი";
            // 
            // spinUnit
            // 
            this.spinUnit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinUnit.EnterMoveNextControl = true;
            this.spinUnit.Location = new System.Drawing.Point(162, 64);
            this.spinUnit.MenuManager = this.barManager;
            this.spinUnit.Name = "spinUnit";
            this.spinUnit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.spinUnit.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinUnit.Properties.Appearance.Options.UseFont = true;
            this.spinUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinUnit.Properties.DisplayFormat.FormatString = "n4";
            this.spinUnit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinUnit.Properties.EditFormat.FormatString = "n4";
            this.spinUnit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinUnit.Properties.Mask.EditMask = "n4";
            this.spinUnit.Properties.MaxValue = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.spinUnit.Size = new System.Drawing.Size(200, 23);
            this.spinUnit.TabIndex = 5;
            // 
            // spinMaxAmount
            // 
            this.spinMaxAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinMaxAmount.EnterMoveNextControl = true;
            this.spinMaxAmount.Location = new System.Drawing.Point(162, 35);
            this.spinMaxAmount.Name = "spinMaxAmount";
            this.spinMaxAmount.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinMaxAmount.Properties.Appearance.Options.UseFont = true;
            this.spinMaxAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinMaxAmount.Properties.DisplayFormat.FormatString = "n4";
            this.spinMaxAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinMaxAmount.Properties.EditFormat.FormatString = "n4";
            this.spinMaxAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinMaxAmount.Properties.Mask.EditMask = "n4";
            this.spinMaxAmount.Properties.MaxValue = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.spinMaxAmount.Size = new System.Drawing.Size(200, 23);
            this.spinMaxAmount.TabIndex = 3;
            this.spinMaxAmount.EditValueChanged += new System.EventHandler(this.spinMaxAmount_EditValueChanged);
            // 
            // lblUnit
            // 
            this.lblUnit.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUnit.Location = new System.Drawing.Point(6, 67);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(45, 17);
            this.lblUnit.TabIndex = 4;
            this.lblUnit.Text = "ქულა:";
            // 
            // lblMaxAmount
            // 
            this.lblMaxAmount.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaxAmount.Location = new System.Drawing.Point(6, 38);
            this.lblMaxAmount.Name = "lblMaxAmount";
            this.lblMaxAmount.Size = new System.Drawing.Size(146, 17);
            this.lblMaxAmount.TabIndex = 2;
            this.lblMaxAmount.Text = "მაქსიმალური თნხა:";
            // 
            // spinMinAmount
            // 
            this.spinMinAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinMinAmount.EnterMoveNextControl = true;
            this.spinMinAmount.Location = new System.Drawing.Point(162, 6);
            this.spinMinAmount.MenuManager = this.barManager;
            this.spinMinAmount.Name = "spinMinAmount";
            this.spinMinAmount.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinMinAmount.Properties.Appearance.Options.UseFont = true;
            this.spinMinAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinMinAmount.Properties.DisplayFormat.FormatString = "n4";
            this.spinMinAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinMinAmount.Properties.EditFormat.FormatString = "n4";
            this.spinMinAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinMinAmount.Properties.Mask.EditMask = "n4";
            this.spinMinAmount.Properties.MaxValue = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.spinMinAmount.Size = new System.Drawing.Size(200, 23);
            this.spinMinAmount.TabIndex = 1;
            this.spinMinAmount.EditValueChanged += new System.EventHandler(this.spinMinAmount_EditValueChanged);
            // 
            // lblMinAmount
            // 
            this.lblMinAmount.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMinAmount.Location = new System.Drawing.Point(6, 9);
            this.lblMinAmount.Name = "lblMinAmount";
            this.lblMinAmount.Size = new System.Drawing.Size(146, 17);
            this.lblMinAmount.TabIndex = 0;
            this.lblMinAmount.Text = "მინიმალური თანხა:";
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.bbModifier);
            this.tabInfo.Controls.Add(this.bbCreator);
            this.tabInfo.Controls.Add(this.txtID);
            this.tabInfo.Controls.Add(this.dateCreateDate);
            this.tabInfo.Controls.Add(this.lblCreator);
            this.tabInfo.Controls.Add(this.dateModifiedDate);
            this.tabInfo.Controls.Add(this.labelControl1);
            this.tabInfo.Controls.Add(this.lblModifier);
            this.tabInfo.Controls.Add(this.lblModifiedDate);
            this.tabInfo.Controls.Add(this.lblID);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Size = new System.Drawing.Size(778, 493);
            this.tabInfo.Text = "ინფორმაცია";
            // 
            // bbModifier
            // 
            this.bbModifier.EnterMoveNextControl = true;
            this.bbModifier.IsOnline = true;
            this.bbModifier.Location = new System.Drawing.Point(89, 123);
            this.bbModifier.Name = "bbModifier";
            this.bbModifier.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F);
            this.bbModifier.Properties.Appearance.Options.UseFont = true;
            this.bbModifier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject3, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject4, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbModifier.Properties.ReadOnly = true;
            this.bbModifier.Size = new System.Drawing.Size(300, 23);
            this.bbModifier.TabIndex = 9;
            this.bbModifier.TableName = Apothex.DataType.ObjectNames.User;
            // 
            // bbCreator
            // 
            this.bbCreator.EnterMoveNextControl = true;
            this.bbCreator.IsOnline = true;
            this.bbCreator.Location = new System.Drawing.Point(89, 65);
            this.bbCreator.MenuManager = this.barManager;
            this.bbCreator.Name = "bbCreator";
            this.bbCreator.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F);
            this.bbCreator.Properties.Appearance.Options.UseFont = true;
            this.bbCreator.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject5, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject6, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbCreator.Properties.ReadOnly = true;
            this.bbCreator.Size = new System.Drawing.Size(300, 23);
            this.bbCreator.TabIndex = 5;
            this.bbCreator.TableName = Apothex.DataType.ObjectNames.User;
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
            // dateCreateDate
            // 
            this.dateCreateDate.EditValue = null;
            this.dateCreateDate.EnterMoveNextControl = true;
            this.dateCreateDate.Location = new System.Drawing.Point(89, 35);
            this.dateCreateDate.Name = "dateCreateDate";
            this.dateCreateDate.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateCreateDate.Properties.Appearance.Options.UseFont = true;
            this.dateCreateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateCreateDate.Properties.DisplayFormat.FormatString = "G";
            this.dateCreateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateCreateDate.Properties.EditFormat.FormatString = "G";
            this.dateCreateDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateCreateDate.Properties.Mask.EditMask = "G";
            this.dateCreateDate.Properties.ReadOnly = true;
            this.dateCreateDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateCreateDate.Size = new System.Drawing.Size(150, 23);
            this.dateCreateDate.TabIndex = 3;
            // 
            // lblCreator
            // 
            this.lblCreator.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreator.Location = new System.Drawing.Point(6, 68);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(53, 17);
            this.lblCreator.TabIndex = 4;
            this.lblCreator.Text = "შექმნა:";
            // 
            // dateModifiedDate
            // 
            this.dateModifiedDate.EditValue = null;
            this.dateModifiedDate.EnterMoveNextControl = true;
            this.dateModifiedDate.Location = new System.Drawing.Point(89, 94);
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
            this.dateModifiedDate.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Location = new System.Drawing.Point(6, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "შეიქმნა:";
            // 
            // lblModifier
            // 
            this.lblModifier.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblModifier.Location = new System.Drawing.Point(6, 126);
            this.lblModifier.Name = "lblModifier";
            this.lblModifier.Size = new System.Drawing.Size(70, 17);
            this.lblModifier.TabIndex = 8;
            this.lblModifier.Text = "შეცვალა:";
            // 
            // lblModifiedDate
            // 
            this.lblModifiedDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblModifiedDate.Location = new System.Drawing.Point(6, 97);
            this.lblModifiedDate.Name = "lblModifiedDate";
            this.lblModifiedDate.Size = new System.Drawing.Size(78, 17);
            this.lblModifiedDate.TabIndex = 6;
            this.lblModifiedDate.Text = "შეიცვალა:";
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
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Location = new System.Drawing.Point(6, 96);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 17);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "თანხა:";
            // 
            // spinAmount
            // 
            this.spinAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinAmount.EnterMoveNextControl = true;
            this.spinAmount.Location = new System.Drawing.Point(162, 93);
            this.spinAmount.Name = "spinAmount";
            this.spinAmount.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.spinAmount.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinAmount.Properties.Appearance.Options.UseFont = true;
            this.spinAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinAmount.Properties.DisplayFormat.FormatString = "p4";
            this.spinAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinAmount.Properties.EditFormat.FormatString = "p4";
            this.spinAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinAmount.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.spinAmount.Properties.Mask.EditMask = "p4";
            this.spinAmount.Properties.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinAmount.Size = new System.Drawing.Size(200, 23);
            this.spinAmount.TabIndex = 7;
            // 
            // frmCardUnitRateEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.xtraTabControl);
            this.Name = "frmCardUnitRateEdit";
            this.ObjectName = Apothex.DataType.ObjectNames.CardUnitRate;
            this.OptionsBaseForm.Text = "ბარათის ქულის ექვივალენტი";
            this.Text = "ბარათის ქულის ექვივალენტი";
            this.Controls.SetChildIndex(this.xtraTabControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMinAmount.Properties)).EndInit();
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbModifier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbCreator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCreateDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCreateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifiedDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifiedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAmount.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage tabMain;
        private DevExpress.XtraEditors.SpinEdit spinMinAmount;
        private DevExpress.XtraEditors.LabelControl lblMinAmount;
        private DevExpress.XtraTab.XtraTabPage tabInfo;
        private Windows.Forms.ButtonBrowse bbModifier;
        private Windows.Forms.ButtonBrowse bbCreator;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.DateEdit dateCreateDate;
        private DevExpress.XtraEditors.LabelControl lblCreator;
        private DevExpress.XtraEditors.DateEdit dateModifiedDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblModifier;
        private DevExpress.XtraEditors.LabelControl lblModifiedDate;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.SpinEdit spinMaxAmount;
        private DevExpress.XtraEditors.LabelControl lblMaxAmount;
        private DevExpress.XtraEditors.SpinEdit spinUnit;
        private DevExpress.XtraEditors.LabelControl lblUnit;
        private DevExpress.XtraEditors.SpinEdit spinAmount;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}