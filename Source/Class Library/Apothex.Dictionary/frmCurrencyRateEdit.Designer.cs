namespace Apothex.Dictionary
{
    partial class frmCurrencyRateEdit
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabMain = new DevExpress.XtraTab.XtraTabPage();
            this.dateStartDate = new DevExpress.XtraEditors.DateEdit();
            this.chkChangePrice = new DevExpress.XtraEditors.CheckEdit();
            this.spinCurrencyRateOld = new DevExpress.XtraEditors.SpinEdit();
            this.spinCurrencyRateNew = new DevExpress.XtraEditors.SpinEdit();
            this.dateEndDate = new DevExpress.XtraEditors.DateEdit();
            this.lblCurrencyRateOld = new DevExpress.XtraEditors.LabelControl();
            this.lookCurrency = new DevExpress.XtraEditors.LookUpEdit();
            this.bsCurrency = new System.Windows.Forms.BindingSource(this.components);
            this.lblChangePrice = new DevExpress.XtraEditors.LabelControl();
            this.lblCurrencyRateNew = new DevExpress.XtraEditors.LabelControl();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.lblCurrency = new DevExpress.XtraEditors.LabelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkChangePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCurrencyRateOld.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCurrencyRateNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrency)).BeginInit();
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
            this.tabMain.Controls.Add(this.dateStartDate);
            this.tabMain.Controls.Add(this.chkChangePrice);
            this.tabMain.Controls.Add(this.spinCurrencyRateOld);
            this.tabMain.Controls.Add(this.spinCurrencyRateNew);
            this.tabMain.Controls.Add(this.dateEndDate);
            this.tabMain.Controls.Add(this.lblCurrencyRateOld);
            this.tabMain.Controls.Add(this.lookCurrency);
            this.tabMain.Controls.Add(this.lblChangePrice);
            this.tabMain.Controls.Add(this.lblCurrencyRateNew);
            this.tabMain.Controls.Add(this.lblDate);
            this.tabMain.Controls.Add(this.lblCurrency);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(778, 493);
            this.tabMain.Text = "მთავარი";
            // 
            // dateStartDate
            // 
            this.dateStartDate.EditValue = null;
            this.dateStartDate.EnterMoveNextControl = true;
            this.dateStartDate.Location = new System.Drawing.Point(130, 35);
            this.dateStartDate.Name = "dateStartDate";
            this.dateStartDate.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateStartDate.Properties.Appearance.Options.UseFont = true;
            this.dateStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "OK", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "ახალი თარიღი", null, null, false)});
            this.dateStartDate.Properties.DisplayFormat.FormatString = "G";
            this.dateStartDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStartDate.Properties.EditFormat.FormatString = "G";
            this.dateStartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStartDate.Properties.Mask.EditMask = "G";
            this.dateStartDate.Properties.ReadOnly = true;
            this.dateStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateStartDate.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.dateStartDate_Properties_ButtonClick);
            this.dateStartDate.Size = new System.Drawing.Size(150, 23);
            this.dateStartDate.TabIndex = 3;
            // 
            // chkChangePrice
            // 
            this.chkChangePrice.EditValue = true;
            this.chkChangePrice.Location = new System.Drawing.Point(128, 122);
            this.chkChangePrice.Name = "chkChangePrice";
            this.chkChangePrice.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChangePrice.Properties.Appearance.Options.UseFont = true;
            this.chkChangePrice.Properties.Caption = "";
            this.chkChangePrice.Size = new System.Drawing.Size(152, 22);
            this.chkChangePrice.TabIndex = 6;
            this.chkChangePrice.Visible = false;
            // 
            // spinCurrencyRateOld
            // 
            this.spinCurrencyRateOld.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinCurrencyRateOld.EnterMoveNextControl = true;
            this.spinCurrencyRateOld.Location = new System.Drawing.Point(130, 64);
            this.spinCurrencyRateOld.Name = "spinCurrencyRateOld";
            this.spinCurrencyRateOld.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinCurrencyRateOld.Properties.Appearance.Options.UseFont = true;
            this.spinCurrencyRateOld.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinCurrencyRateOld.Properties.DisplayFormat.FormatString = "n4";
            this.spinCurrencyRateOld.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinCurrencyRateOld.Properties.EditFormat.FormatString = "n4";
            this.spinCurrencyRateOld.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinCurrencyRateOld.Properties.Mask.EditMask = "n4";
            this.spinCurrencyRateOld.Properties.ReadOnly = true;
            this.spinCurrencyRateOld.Size = new System.Drawing.Size(150, 23);
            this.spinCurrencyRateOld.TabIndex = 5;
            // 
            // spinCurrencyRateNew
            // 
            this.spinCurrencyRateNew.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.spinCurrencyRateNew.EnterMoveNextControl = true;
            this.spinCurrencyRateNew.Location = new System.Drawing.Point(130, 93);
            this.spinCurrencyRateNew.Name = "spinCurrencyRateNew";
            this.spinCurrencyRateNew.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinCurrencyRateNew.Properties.Appearance.Options.UseFont = true;
            this.spinCurrencyRateNew.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinCurrencyRateNew.Properties.DisplayFormat.FormatString = "n4";
            this.spinCurrencyRateNew.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinCurrencyRateNew.Properties.EditFormat.FormatString = "n4";
            this.spinCurrencyRateNew.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinCurrencyRateNew.Properties.Mask.EditMask = "n4";
            this.spinCurrencyRateNew.Properties.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.spinCurrencyRateNew.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.spinCurrencyRateNew.Size = new System.Drawing.Size(150, 23);
            this.spinCurrencyRateNew.TabIndex = 5;
            this.spinCurrencyRateNew.EditValueChanged += new System.EventHandler(this.spinCurrencyRateNew_EditValueChanged);
            // 
            // dateEndDate
            // 
            this.dateEndDate.EditValue = null;
            this.dateEndDate.EnterMoveNextControl = true;
            this.dateEndDate.Location = new System.Drawing.Point(286, 35);
            this.dateEndDate.Name = "dateEndDate";
            this.dateEndDate.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEndDate.Properties.Appearance.Options.UseFont = true;
            this.dateEndDate.Properties.DisplayFormat.FormatString = "G";
            this.dateEndDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEndDate.Properties.EditFormat.FormatString = "G";
            this.dateEndDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEndDate.Properties.Mask.EditMask = "G";
            this.dateEndDate.Properties.ReadOnly = true;
            this.dateEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEndDate.Size = new System.Drawing.Size(150, 23);
            this.dateEndDate.TabIndex = 4;
            // 
            // lblCurrencyRateOld
            // 
            this.lblCurrencyRateOld.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrencyRateOld.Location = new System.Drawing.Point(6, 67);
            this.lblCurrencyRateOld.Name = "lblCurrencyRateOld";
            this.lblCurrencyRateOld.Size = new System.Drawing.Size(94, 17);
            this.lblCurrencyRateOld.TabIndex = 2;
            this.lblCurrencyRateOld.Text = "მიმდ. კურსი:";
            // 
            // lookCurrency
            // 
            this.lookCurrency.EnterMoveNextControl = true;
            this.lookCurrency.Location = new System.Drawing.Point(130, 6);
            this.lookCurrency.Name = "lookCurrency";
            this.lookCurrency.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookCurrency.Properties.Appearance.Options.UseFont = true;
            this.lookCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookCurrency.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", 200, "Caption")});
            this.lookCurrency.Properties.DataSource = this.bsCurrency;
            this.lookCurrency.Properties.DisplayMember = "Caption";
            this.lookCurrency.Properties.NullText = "";
            this.lookCurrency.Properties.ShowHeader = false;
            this.lookCurrency.Properties.ValueMember = "ID";
            this.lookCurrency.Size = new System.Drawing.Size(150, 23);
            this.lookCurrency.TabIndex = 1;
            this.lookCurrency.EditValueChanged += new System.EventHandler(this.lookCurrency_EditValueChanged);
            // 
            // lblChangePrice
            // 
            this.lblChangePrice.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChangePrice.Location = new System.Drawing.Point(6, 125);
            this.lblChangePrice.Name = "lblChangePrice";
            this.lblChangePrice.Size = new System.Drawing.Size(116, 17);
            this.lblChangePrice.TabIndex = 2;
            this.lblChangePrice.Text = "ფასებ. შეცვლა:";
            this.lblChangePrice.Visible = false;
            // 
            // lblCurrencyRateNew
            // 
            this.lblCurrencyRateNew.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrencyRateNew.Location = new System.Drawing.Point(6, 96);
            this.lblCurrencyRateNew.Name = "lblCurrencyRateNew";
            this.lblCurrencyRateNew.Size = new System.Drawing.Size(101, 17);
            this.lblCurrencyRateNew.TabIndex = 2;
            this.lblCurrencyRateNew.Text = "ახალი კურსი:";
            // 
            // lblDate
            // 
            this.lblDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.Location = new System.Drawing.Point(6, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(65, 17);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "თარიღი:";
            // 
            // lblCurrency
            // 
            this.lblCurrency.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrency.Location = new System.Drawing.Point(6, 9);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(63, 17);
            this.lblCurrency.TabIndex = 0;
            this.lblCurrency.Text = "ვალუტა:";
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
            this.lblModifiedDate.Location = new System.Drawing.Point(3, 38);
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
            // frmCurrencyRateEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.xtraTabControl);
            this.Name = "frmCurrencyRateEdit";
            this.ObjectName = Apothex.DataType.ObjectNames.CurrencyRate;
            this.Text = "ვალუტა";
            this.Controls.SetChildIndex(this.xtraTabControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkChangePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCurrencyRateOld.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCurrencyRateNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrency)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl lblCurrency;
        private DevExpress.XtraTab.XtraTabPage tabInfo;
        private Apothex.Windows.Forms.ButtonBrowse bbApprover;
        private Apothex.Windows.Forms.ButtonBrowse bbModifier;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblApprover;
        private DevExpress.XtraEditors.DateEdit dateModifiedDate;
        private DevExpress.XtraEditors.LabelControl lblModifier;
        private DevExpress.XtraEditors.LabelControl lblModifiedDate;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.LookUpEdit lookCurrency;
        private System.Windows.Forms.BindingSource bsCurrency;
        private DevExpress.XtraEditors.DateEdit dateEndDate;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.SpinEdit spinCurrencyRateNew;
        private DevExpress.XtraEditors.SpinEdit spinCurrencyRateOld;
        private DevExpress.XtraEditors.LabelControl lblCurrencyRateOld;
        private DevExpress.XtraEditors.LabelControl lblCurrencyRateNew;
        private DevExpress.XtraEditors.CheckEdit chkChangePrice;
        private DevExpress.XtraEditors.LabelControl lblChangePrice;
        private DevExpress.XtraEditors.DateEdit dateStartDate;
    }
}