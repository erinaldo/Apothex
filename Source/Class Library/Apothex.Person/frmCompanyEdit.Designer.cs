namespace Apothex.Person
{
    partial class frmCompanyEdit
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
            this.grpNote = new DevExpress.XtraEditors.GroupControl();
            this.memoNote = new DevExpress.XtraEditors.MemoEdit();
            this.lookBank = new DevExpress.XtraEditors.LookUpEdit();
            this.bsBank = new System.Windows.Forms.BindingSource();
            this.lookCountry = new DevExpress.XtraEditors.LookUpEdit();
            this.bsCountry = new System.Windows.Forms.BindingSource();
            this.lblBank = new DevExpress.XtraEditors.LabelControl();
            this.txtFax = new DevExpress.XtraEditors.TextEdit();
            this.lblCountry = new DevExpress.XtraEditors.LabelControl();
            this.lblFax = new DevExpress.XtraEditors.LabelControl();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.lblPhone = new DevExpress.XtraEditors.LabelControl();
            this.txtBankAccountNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblBankAccountNumber = new DevExpress.XtraEditors.LabelControl();
            this.txtTaxCode = new DevExpress.XtraEditors.TextEdit();
            this.lblTaxCode = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.txtCompanyName = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.grpNote)).BeginInit();
            this.grpNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookBank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankAccountNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).BeginInit();
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
            this.xtraTabControl.Location = new System.Drawing.Point(0, 34);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.SelectedTabPage = this.tabMain;
            this.xtraTabControl.Size = new System.Drawing.Size(784, 528);
            this.xtraTabControl.TabIndex = 0;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabMain,
            this.tabInfo});
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.grpNote);
            this.tabMain.Controls.Add(this.lookBank);
            this.tabMain.Controls.Add(this.lookCountry);
            this.tabMain.Controls.Add(this.lblBank);
            this.tabMain.Controls.Add(this.txtFax);
            this.tabMain.Controls.Add(this.lblCountry);
            this.tabMain.Controls.Add(this.lblFax);
            this.tabMain.Controls.Add(this.txtPhone);
            this.tabMain.Controls.Add(this.lblPhone);
            this.tabMain.Controls.Add(this.txtBankAccountNumber);
            this.tabMain.Controls.Add(this.lblBankAccountNumber);
            this.tabMain.Controls.Add(this.txtTaxCode);
            this.tabMain.Controls.Add(this.lblTaxCode);
            this.tabMain.Controls.Add(this.txtAddress);
            this.tabMain.Controls.Add(this.lblAddress);
            this.tabMain.Controls.Add(this.txtCompanyName);
            this.tabMain.Controls.Add(this.lblBankName);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(777, 496);
            this.tabMain.Text = "მთავარი";
            // 
            // grpNote
            // 
            this.grpNote.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNote.Appearance.Options.UseFont = true;
            this.grpNote.AppearanceCaption.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpNote.AppearanceCaption.Options.UseFont = true;
            this.grpNote.Controls.Add(this.memoNote);
            this.grpNote.Location = new System.Drawing.Point(6, 238);
            this.grpNote.Name = "grpNote";
            this.grpNote.Size = new System.Drawing.Size(492, 160);
            this.grpNote.TabIndex = 16;
            this.grpNote.Text = "კომენტარი";
            // 
            // memoNote
            // 
            this.memoNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoNote.Location = new System.Drawing.Point(2, 25);
            this.memoNote.Name = "memoNote";
            this.memoNote.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoNote.Properties.Appearance.Options.UseFont = true;
            this.memoNote.Properties.MaxLength = 255;
            this.memoNote.Size = new System.Drawing.Size(488, 133);
            this.memoNote.TabIndex = 0;
            // 
            // lookBank
            // 
            this.lookBank.EnterMoveNextControl = true;
            this.lookBank.Location = new System.Drawing.Point(109, 180);
            this.lookBank.Name = "lookBank";
            this.lookBank.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookBank.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookBank.Properties.Appearance.Options.UseFont = true;
            this.lookBank.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookBank.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 200, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.lookBank.Properties.DataSource = this.bsBank;
            this.lookBank.Properties.DisplayMember = "Caption";
            this.lookBank.Properties.NullText = "";
            this.lookBank.Properties.ShowHeader = false;
            this.lookBank.Properties.SortColumnIndex = 2;
            this.lookBank.Properties.ValueMember = "ID";
            this.lookBank.Size = new System.Drawing.Size(387, 23);
            this.lookBank.TabIndex = 13;
            // 
            // lookCountry
            // 
            this.lookCountry.EnterMoveNextControl = true;
            this.lookCountry.Location = new System.Drawing.Point(109, 122);
            this.lookCountry.Name = "lookCountry";
            this.lookCountry.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookCountry.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookCountry.Properties.Appearance.Options.UseFont = true;
            this.lookCountry.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookCountry.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 200, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.lookCountry.Properties.DataSource = this.bsCountry;
            this.lookCountry.Properties.DisplayMember = "Caption";
            this.lookCountry.Properties.NullText = "";
            this.lookCountry.Properties.ShowHeader = false;
            this.lookCountry.Properties.SortColumnIndex = 2;
            this.lookCountry.Properties.ValueMember = "ID";
            this.lookCountry.Size = new System.Drawing.Size(387, 23);
            this.lookCountry.TabIndex = 9;
            // 
            // lblBank
            // 
            this.lblBank.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBank.Appearance.Options.UseFont = true;
            this.lblBank.Location = new System.Drawing.Point(6, 183);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(44, 17);
            this.lblBank.TabIndex = 12;
            this.lblBank.Text = "ბანკი:";
            // 
            // txtFax
            // 
            this.txtFax.EnterMoveNextControl = true;
            this.txtFax.Location = new System.Drawing.Point(109, 93);
            this.txtFax.Name = "txtFax";
            this.txtFax.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFax.Properties.Appearance.Options.UseFont = true;
            this.txtFax.Properties.MaxLength = 50;
            this.txtFax.Size = new System.Drawing.Size(387, 23);
            this.txtFax.TabIndex = 7;
            // 
            // lblCountry
            // 
            this.lblCountry.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountry.Appearance.Options.UseFont = true;
            this.lblCountry.Location = new System.Drawing.Point(6, 125);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(61, 17);
            this.lblCountry.TabIndex = 8;
            this.lblCountry.Text = "ქვეყანა:";
            // 
            // lblFax
            // 
            this.lblFax.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFax.Appearance.Options.UseFont = true;
            this.lblFax.Location = new System.Drawing.Point(6, 96);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(49, 17);
            this.lblFax.TabIndex = 6;
            this.lblFax.Text = "ფაქსი:";
            // 
            // txtPhone
            // 
            this.txtPhone.EnterMoveNextControl = true;
            this.txtPhone.Location = new System.Drawing.Point(109, 64);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPhone.Properties.MaxLength = 50;
            this.txtPhone.Size = new System.Drawing.Size(387, 23);
            this.txtPhone.TabIndex = 5;
            // 
            // lblPhone
            // 
            this.lblPhone.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhone.Appearance.Options.UseFont = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 67);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(87, 17);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "ტელეფონი:";
            // 
            // txtBankAccountNumber
            // 
            this.txtBankAccountNumber.EnterMoveNextControl = true;
            this.txtBankAccountNumber.Location = new System.Drawing.Point(109, 209);
            this.txtBankAccountNumber.Name = "txtBankAccountNumber";
            this.txtBankAccountNumber.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBankAccountNumber.Properties.Appearance.Options.UseFont = true;
            this.txtBankAccountNumber.Properties.MaxLength = 25;
            this.txtBankAccountNumber.Size = new System.Drawing.Size(387, 23);
            this.txtBankAccountNumber.TabIndex = 15;
            // 
            // lblBankAccountNumber
            // 
            this.lblBankAccountNumber.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBankAccountNumber.Appearance.Options.UseFont = true;
            this.lblBankAccountNumber.Location = new System.Drawing.Point(6, 212);
            this.lblBankAccountNumber.Name = "lblBankAccountNumber";
            this.lblBankAccountNumber.Size = new System.Drawing.Size(90, 17);
            this.lblBankAccountNumber.TabIndex = 14;
            this.lblBankAccountNumber.Text = "ანგარიშ. №:";
            // 
            // txtTaxCode
            // 
            this.txtTaxCode.EnterMoveNextControl = true;
            this.txtTaxCode.Location = new System.Drawing.Point(109, 35);
            this.txtTaxCode.Name = "txtTaxCode";
            this.txtTaxCode.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTaxCode.Properties.Appearance.Options.UseFont = true;
            this.txtTaxCode.Properties.MaxLength = 25;
            this.txtTaxCode.Size = new System.Drawing.Size(387, 23);
            this.txtTaxCode.TabIndex = 3;
            // 
            // lblTaxCode
            // 
            this.lblTaxCode.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTaxCode.Appearance.Options.UseFont = true;
            this.lblTaxCode.Location = new System.Drawing.Point(6, 38);
            this.lblTaxCode.Name = "lblTaxCode";
            this.lblTaxCode.Size = new System.Drawing.Size(98, 17);
            this.lblTaxCode.TabIndex = 2;
            this.lblTaxCode.Text = "საგად. კოდი:";
            // 
            // txtAddress
            // 
            this.txtAddress.EnterMoveNextControl = true;
            this.txtAddress.Location = new System.Drawing.Point(109, 151);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Properties.MaxLength = 100;
            this.txtAddress.Size = new System.Drawing.Size(387, 23);
            this.txtAddress.TabIndex = 11;
            // 
            // lblAddress
            // 
            this.lblAddress.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddress.Appearance.Options.UseFont = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 154);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(85, 17);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "მისამართი:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.EnterMoveNextControl = true;
            this.txtCompanyName.Location = new System.Drawing.Point(109, 6);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCompanyName.Properties.Appearance.Options.UseFont = true;
            this.txtCompanyName.Properties.MaxLength = 100;
            this.txtCompanyName.Size = new System.Drawing.Size(387, 23);
            this.txtCompanyName.TabIndex = 1;
            this.txtCompanyName.EditValueChanged += new System.EventHandler(this.txtCompanyName_EditValueChanged);
            // 
            // lblBankName
            // 
            this.lblBankName.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBankName.Appearance.Options.UseFont = true;
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
            this.tabInfo.Size = new System.Drawing.Size(785, 453);
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
            // frmCompanyEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.xtraTabControl);
            this.Name = "frmCompanyEdit";
            this.ObjectName = Apothex.DataType.ObjectNames.Company;
            this.Text = "კომპანია";
            this.Controls.SetChildIndex(this.xtraTabControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpNote)).EndInit();
            this.grpNote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookBank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankAccountNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtTaxCode;
        private DevExpress.XtraEditors.LabelControl lblTaxCode;
        private DevExpress.XtraEditors.TextEdit txtCompanyName;
        private DevExpress.XtraEditors.LabelControl lblBankName;
        private DevExpress.XtraTab.XtraTabPage tabInfo;
        private Apothex.Windows.Forms.ButtonBrowse bbApprover;
        private Apothex.Windows.Forms.ButtonBrowse bbModifier;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblApprover;
        private DevExpress.XtraEditors.DateEdit dateModifiedDate;
        private DevExpress.XtraEditors.LabelControl lblModifier;
        private DevExpress.XtraEditors.LabelControl lblModifiedDate;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.TextEdit txtFax;
        private DevExpress.XtraEditors.LabelControl lblFax;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.LabelControl lblPhone;
        private DevExpress.XtraEditors.LookUpEdit lookCountry;
        private DevExpress.XtraEditors.LabelControl lblCountry;
        private System.Windows.Forms.BindingSource bsCountry;
        private DevExpress.XtraEditors.LookUpEdit lookBank;
        private System.Windows.Forms.BindingSource bsBank;
        private DevExpress.XtraEditors.LabelControl lblBank;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl lblAddress;
        private DevExpress.XtraEditors.TextEdit txtBankAccountNumber;
        private DevExpress.XtraEditors.LabelControl lblBankAccountNumber;
        private DevExpress.XtraEditors.GroupControl grpNote;
        private DevExpress.XtraEditors.MemoEdit memoNote;
    }
}