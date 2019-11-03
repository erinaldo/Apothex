namespace Apothex.Card
{
    partial class frmCardDiscountSchemaEdit
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabMain = new DevExpress.XtraTab.XtraTabPage();
            this.spinDiscount = new DevExpress.XtraEditors.SpinEdit();
            this.spinMaxUnit = new DevExpress.XtraEditors.SpinEdit();
            this.lblDiscount = new DevExpress.XtraEditors.LabelControl();
            this.lblMaxUnit = new DevExpress.XtraEditors.LabelControl();
            this.spinMinUnit = new DevExpress.XtraEditors.SpinEdit();
            this.lblMinUnit = new DevExpress.XtraEditors.LabelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMaxUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMinUnit.Properties)).BeginInit();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbModifier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbCreator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCreateDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCreateDate.Properties)).BeginInit();
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
            this.tabMain.Controls.Add(this.spinDiscount);
            this.tabMain.Controls.Add(this.spinMaxUnit);
            this.tabMain.Controls.Add(this.lblDiscount);
            this.tabMain.Controls.Add(this.lblMaxUnit);
            this.tabMain.Controls.Add(this.spinMinUnit);
            this.tabMain.Controls.Add(this.lblMinUnit);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(778, 493);
            this.tabMain.Text = "მთავარი";
            // 
            // spinDiscount
            // 
            this.spinDiscount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinDiscount.EnterMoveNextControl = true;
            this.spinDiscount.Location = new System.Drawing.Point(162, 64);
            this.spinDiscount.MenuManager = this.barManager;
            this.spinDiscount.Name = "spinDiscount";
            this.spinDiscount.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinDiscount.Properties.Appearance.Options.UseFont = true;
            this.spinDiscount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinDiscount.Properties.DisplayFormat.FormatString = "p";
            this.spinDiscount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinDiscount.Properties.EditFormat.FormatString = "p";
            this.spinDiscount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinDiscount.Properties.Mask.EditMask = "p";
            this.spinDiscount.Properties.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinDiscount.Size = new System.Drawing.Size(150, 23);
            this.spinDiscount.TabIndex = 5;
            // 
            // spinMaxUnit
            // 
            this.spinMaxUnit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinMaxUnit.EnterMoveNextControl = true;
            this.spinMaxUnit.Location = new System.Drawing.Point(162, 35);
            this.spinMaxUnit.Name = "spinMaxUnit";
            this.spinMaxUnit.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinMaxUnit.Properties.Appearance.Options.UseFont = true;
            this.spinMaxUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinMaxUnit.Properties.DisplayFormat.FormatString = "N00";
            this.spinMaxUnit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinMaxUnit.Properties.EditFormat.FormatString = "N00";
            this.spinMaxUnit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinMaxUnit.Properties.IsFloatValue = false;
            this.spinMaxUnit.Properties.Mask.EditMask = "N00";
            this.spinMaxUnit.Properties.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.spinMaxUnit.Size = new System.Drawing.Size(150, 23);
            this.spinMaxUnit.TabIndex = 3;
            this.spinMaxUnit.EditValueChanged += new System.EventHandler(this.spinMaxUnit_EditValueChanged);
            // 
            // lblDiscount
            // 
            this.lblDiscount.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDiscount.Location = new System.Drawing.Point(6, 67);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(100, 17);
            this.lblDiscount.TabIndex = 4;
            this.lblDiscount.Text = "ფასდაკლება:";
            // 
            // lblMaxUnit
            // 
            this.lblMaxUnit.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaxUnit.Location = new System.Drawing.Point(6, 38);
            this.lblMaxUnit.Name = "lblMaxUnit";
            this.lblMaxUnit.Size = new System.Drawing.Size(150, 17);
            this.lblMaxUnit.TabIndex = 2;
            this.lblMaxUnit.Text = "მაქსიმალური ქულა:";
            // 
            // spinMinUnit
            // 
            this.spinMinUnit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinMinUnit.EnterMoveNextControl = true;
            this.spinMinUnit.Location = new System.Drawing.Point(162, 6);
            this.spinMinUnit.MenuManager = this.barManager;
            this.spinMinUnit.Name = "spinMinUnit";
            this.spinMinUnit.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinMinUnit.Properties.Appearance.Options.UseFont = true;
            this.spinMinUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinMinUnit.Properties.DisplayFormat.FormatString = "N00";
            this.spinMinUnit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinMinUnit.Properties.EditFormat.FormatString = "N00";
            this.spinMinUnit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinMinUnit.Properties.IsFloatValue = false;
            this.spinMinUnit.Properties.Mask.EditMask = "N00";
            this.spinMinUnit.Properties.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.spinMinUnit.Size = new System.Drawing.Size(150, 23);
            this.spinMinUnit.TabIndex = 1;
            this.spinMinUnit.EditValueChanged += new System.EventHandler(this.spinMinUnit_EditValueChanged);
            // 
            // lblMinUnit
            // 
            this.lblMinUnit.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMinUnit.Location = new System.Drawing.Point(6, 9);
            this.lblMinUnit.Name = "lblMinUnit";
            this.lblMinUnit.Size = new System.Drawing.Size(142, 17);
            this.lblMinUnit.TabIndex = 0;
            this.lblMinUnit.Text = "მინიმალური ქულა:";
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
            this.tabInfo.Size = new System.Drawing.Size(778, 498);
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject1, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject2, "წაშლა (Shift+Delete)", null, null, false)});
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject3, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject4, "წაშლა (Shift+Delete)", null, null, false)});
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
            // frmCardDiscountSchemaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.xtraTabControl);
            this.Name = "frmCardDiscountSchemaEdit";
            this.ObjectName = Apothex.DataType.ObjectNames.CardDiscountSchema;
            this.Text = "ბარათის ფასდაკლების სქემა";
            this.Controls.SetChildIndex(this.xtraTabControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMaxUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMinUnit.Properties)).EndInit();
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbModifier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbCreator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCreateDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCreateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifiedDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifiedDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage tabMain;
        private DevExpress.XtraEditors.SpinEdit spinMinUnit;
        private DevExpress.XtraEditors.LabelControl lblMinUnit;
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
        private DevExpress.XtraEditors.SpinEdit spinMaxUnit;
        private DevExpress.XtraEditors.LabelControl lblMaxUnit;
        private DevExpress.XtraEditors.SpinEdit spinDiscount;
        private DevExpress.XtraEditors.LabelControl lblDiscount;
    }
}