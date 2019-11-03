namespace Apothex.Person
{
    partial class frmCompanyBrowse
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankAccountNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApproverUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsCountry = new System.Windows.Forms.BindingSource(this.components);
            this.bsBank = new System.Windows.Forms.BindingSource(this.components);
            this.lblCompanyName = new DevExpress.XtraEditors.LabelControl();
            this.txtCompanyName = new DevExpress.XtraEditors.TextEdit();
            this.lblTaxCode = new DevExpress.XtraEditors.LabelControl();
            this.txtTaxCode = new DevExpress.XtraEditors.TextEdit();
            this.lblPhone = new DevExpress.XtraEditors.LabelControl();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.lblFax = new DevExpress.XtraEditors.LabelControl();
            this.txtFax = new DevExpress.XtraEditors.TextEdit();
            this.lookCountry = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCountry = new DevExpress.XtraEditors.LabelControl();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.lblBank = new DevExpress.XtraEditors.LabelControl();
            this.lookBank = new DevExpress.XtraEditors.LookUpEdit();
            this.lblBankAccountNumber = new DevExpress.XtraEditors.LabelControl();
            this.txtBankAccountNumber = new DevExpress.XtraEditors.TextEdit();
            this.ds = new Apothex.DataType.DS_Person();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookBank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankAccountNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.lookBank);
            this.pnlFilter.Controls.Add(this.lookCountry);
            this.pnlFilter.Controls.Add(this.lblBank);
            this.pnlFilter.Controls.Add(this.txtFax);
            this.pnlFilter.Controls.Add(this.lblCountry);
            this.pnlFilter.Controls.Add(this.lblFax);
            this.pnlFilter.Controls.Add(this.txtPhone);
            this.pnlFilter.Controls.Add(this.lblPhone);
            this.pnlFilter.Controls.Add(this.txtBankAccountNumber);
            this.pnlFilter.Controls.Add(this.txtAddress);
            this.pnlFilter.Controls.Add(this.lblBankAccountNumber);
            this.pnlFilter.Controls.Add(this.txtTaxCode);
            this.pnlFilter.Controls.Add(this.lblAddress);
            this.pnlFilter.Controls.Add(this.lblTaxCode);
            this.pnlFilter.Controls.Add(this.txtCompanyName);
            this.pnlFilter.Controls.Add(this.lblCompanyName);
            this.pnlFilter.Size = new System.Drawing.Size(784, 151);
            this.pnlFilter.Controls.SetChildIndex(this.btnFilter, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblCompanyName, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtCompanyName, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblTaxCode, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblAddress, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtTaxCode, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblBankAccountNumber, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtAddress, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtBankAccountNumber, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblPhone, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtPhone, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblFax, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblCountry, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtFax, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblBank, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lookCountry, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lookBank, 0);
            // 
            // bsGridControl
            // 
            this.bsGridControl.DataMember = "VW_Company";
            this.bsGridControl.DataSource = this.ds;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridControl);
            this.pnlGrid.Location = new System.Drawing.Point(0, 190);
            this.pnlGrid.Size = new System.Drawing.Size(784, 372);
            // 
            // btnFilter
            // 
            this.btnFilter.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.Appearance.Options.UseFont = true;
            this.btnFilter.Location = new System.Drawing.Point(745, 6);
            // 
            // popupMenu
            // 
            this.popupMenu.MenuAppearance.Menu.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popupMenu.MenuAppearance.Menu.Options.UseFont = true;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bsGridControl;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(784, 372);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colTaxCode,
            this.colPhone,
            this.colFax,
            this.colCountryName,
            this.colAddress,
            this.colBankName,
            this.colBankCode,
            this.colBankAccountNumber,
            this.colCompanyID,
            this.colCountryCode,
            this.colBankID,
            this.colStatus,
            this.colModifiedUserID,
            this.colModifier,
            this.colModifiedDate,
            this.colApproverUserID,
            this.colApprover});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            // 
            // colName
            // 
            this.colName.Caption = "დასახელება";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colTaxCode
            // 
            this.colTaxCode.Caption = "საგად. კოდი";
            this.colTaxCode.FieldName = "TaxCode";
            this.colTaxCode.Name = "colTaxCode";
            this.colTaxCode.Visible = true;
            this.colTaxCode.VisibleIndex = 1;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "ტელეფონი";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 2;
            // 
            // colFax
            // 
            this.colFax.Caption = "ფაქსი";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 3;
            // 
            // colCountryName
            // 
            this.colCountryName.Caption = "ქვეყანა";
            this.colCountryName.FieldName = "CountryName";
            this.colCountryName.Name = "colCountryName";
            this.colCountryName.Visible = true;
            this.colCountryName.VisibleIndex = 4;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "მისამართი";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 5;
            // 
            // colBankName
            // 
            this.colBankName.Caption = "ბანკი";
            this.colBankName.FieldName = "BankName";
            this.colBankName.Name = "colBankName";
            this.colBankName.Visible = true;
            this.colBankName.VisibleIndex = 6;
            // 
            // colBankCode
            // 
            this.colBankCode.Caption = "ბანკის კოდი";
            this.colBankCode.FieldName = "BankCode";
            this.colBankCode.Name = "colBankCode";
            this.colBankCode.Visible = true;
            this.colBankCode.VisibleIndex = 7;
            // 
            // colBankAccountNumber
            // 
            this.colBankAccountNumber.Caption = "ანგარიშის №";
            this.colBankAccountNumber.FieldName = "BankAccountNumber";
            this.colBankAccountNumber.Name = "colBankAccountNumber";
            this.colBankAccountNumber.Visible = true;
            this.colBankAccountNumber.VisibleIndex = 8;
            // 
            // colCompanyID
            // 
            this.colCompanyID.FieldName = "CompanyID";
            this.colCompanyID.Name = "colCompanyID";
            // 
            // colCountryCode
            // 
            this.colCountryCode.FieldName = "CountryCode";
            this.colCountryCode.Name = "colCountryCode";
            // 
            // colBankID
            // 
            this.colBankID.FieldName = "BankID";
            this.colBankID.Name = "colBankID";
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // colModifiedUserID
            // 
            this.colModifiedUserID.FieldName = "ModifiedUserID";
            this.colModifiedUserID.Name = "colModifiedUserID";
            // 
            // colModifier
            // 
            this.colModifier.Caption = "შეცვალა";
            this.colModifier.FieldName = "Modifier";
            this.colModifier.Name = "colModifier";
            // 
            // colModifiedDate
            // 
            this.colModifiedDate.Caption = "შეცვლის თარიღი";
            this.colModifiedDate.DisplayFormat.FormatString = "G";
            this.colModifiedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colModifiedDate.FieldName = "ModifiedDate";
            this.colModifiedDate.Name = "colModifiedDate";
            // 
            // colApproverUserID
            // 
            this.colApproverUserID.FieldName = "ApproverUserID";
            this.colApproverUserID.Name = "colApproverUserID";
            // 
            // colApprover
            // 
            this.colApprover.Caption = "დაამოწმა";
            this.colApprover.FieldName = "Approver";
            this.colApprover.Name = "colApprover";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompanyName.Location = new System.Drawing.Point(6, 9);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(72, 17);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "კომპანია:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.EnterMoveNextControl = true;
            this.txtCompanyName.Location = new System.Drawing.Point(110, 6);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCompanyName.Properties.Appearance.Options.UseFont = true;
            this.txtCompanyName.Size = new System.Drawing.Size(300, 23);
            this.txtCompanyName.TabIndex = 1;
            // 
            // lblTaxCode
            // 
            this.lblTaxCode.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTaxCode.Location = new System.Drawing.Point(6, 38);
            this.lblTaxCode.Name = "lblTaxCode";
            this.lblTaxCode.Size = new System.Drawing.Size(98, 17);
            this.lblTaxCode.TabIndex = 2;
            this.lblTaxCode.Text = "საგად. კოდი:";
            // 
            // txtTaxCode
            // 
            this.txtTaxCode.EnterMoveNextControl = true;
            this.txtTaxCode.Location = new System.Drawing.Point(110, 35);
            this.txtTaxCode.Name = "txtTaxCode";
            this.txtTaxCode.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTaxCode.Properties.Appearance.Options.UseFont = true;
            this.txtTaxCode.Size = new System.Drawing.Size(200, 23);
            this.txtTaxCode.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhone.Location = new System.Drawing.Point(6, 67);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(87, 17);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "ტელეფონი:";
            // 
            // txtPhone
            // 
            this.txtPhone.EnterMoveNextControl = true;
            this.txtPhone.Location = new System.Drawing.Point(110, 64);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPhone.Size = new System.Drawing.Size(200, 23);
            this.txtPhone.TabIndex = 5;
            // 
            // lblFax
            // 
            this.lblFax.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFax.Location = new System.Drawing.Point(5, 99);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(49, 17);
            this.lblFax.TabIndex = 6;
            this.lblFax.Text = "ფაქსი:";
            // 
            // txtFax
            // 
            this.txtFax.EnterMoveNextControl = true;
            this.txtFax.Location = new System.Drawing.Point(110, 96);
            this.txtFax.Name = "txtFax";
            this.txtFax.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFax.Properties.Appearance.Options.UseFont = true;
            this.txtFax.Size = new System.Drawing.Size(200, 23);
            this.txtFax.TabIndex = 7;
            // 
            // lookCountry
            // 
            this.lookCountry.EnterMoveNextControl = true;
            this.lookCountry.Location = new System.Drawing.Point(499, 6);
            this.lookCountry.Name = "lookCountry";
            this.lookCountry.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookCountry.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookCountry.Properties.Appearance.Options.UseFont = true;
            this.lookCountry.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookCountry.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.lookCountry.Properties.DataSource = this.bsCountry;
            this.lookCountry.Properties.DisplayMember = "Caption";
            this.lookCountry.Properties.NullText = "";
            this.lookCountry.Properties.ShowHeader = false;
            this.lookCountry.Properties.ValueMember = "ID";
            this.lookCountry.Size = new System.Drawing.Size(240, 23);
            this.lookCountry.TabIndex = 9;
            // 
            // lblCountry
            // 
            this.lblCountry.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountry.Location = new System.Drawing.Point(432, 9);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(61, 17);
            this.lblCountry.TabIndex = 8;
            this.lblCountry.Text = "ქვეყანა:";
            // 
            // lblAddress
            // 
            this.lblAddress.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddress.Location = new System.Drawing.Point(408, 41);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(85, 17);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "მისამართი:";
            // 
            // txtAddress
            // 
            this.txtAddress.EnterMoveNextControl = true;
            this.txtAddress.Location = new System.Drawing.Point(499, 38);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Size = new System.Drawing.Size(240, 23);
            this.txtAddress.TabIndex = 11;
            // 
            // lblBank
            // 
            this.lblBank.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBank.Location = new System.Drawing.Point(449, 70);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(44, 17);
            this.lblBank.TabIndex = 12;
            this.lblBank.Text = "ბანკი:";
            // 
            // lookBank
            // 
            this.lookBank.EnterMoveNextControl = true;
            this.lookBank.Location = new System.Drawing.Point(499, 67);
            this.lookBank.Name = "lookBank";
            this.lookBank.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookBank.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookBank.Properties.Appearance.Options.UseFont = true;
            this.lookBank.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookBank.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.lookBank.Properties.DataSource = this.bsBank;
            this.lookBank.Properties.DisplayMember = "Caption";
            this.lookBank.Properties.NullText = "";
            this.lookBank.Properties.ShowHeader = false;
            this.lookBank.Properties.ValueMember = "ID";
            this.lookBank.Size = new System.Drawing.Size(240, 23);
            this.lookBank.TabIndex = 13;
            // 
            // lblBankAccountNumber
            // 
            this.lblBankAccountNumber.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBankAccountNumber.Location = new System.Drawing.Point(419, 99);
            this.lblBankAccountNumber.Name = "lblBankAccountNumber";
            this.lblBankAccountNumber.Size = new System.Drawing.Size(74, 17);
            this.lblBankAccountNumber.TabIndex = 14;
            this.lblBankAccountNumber.Text = "ანგარ. №:";
            // 
            // txtBankAccountNumber
            // 
            this.txtBankAccountNumber.EnterMoveNextControl = true;
            this.txtBankAccountNumber.Location = new System.Drawing.Point(499, 96);
            this.txtBankAccountNumber.Name = "txtBankAccountNumber";
            this.txtBankAccountNumber.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBankAccountNumber.Properties.Appearance.Options.UseFont = true;
            this.txtBankAccountNumber.Size = new System.Drawing.Size(240, 23);
            this.txtBankAccountNumber.TabIndex = 15;
            // 
            // ds
            // 
            this.ds.DataSetName = "DS_Person";
            this.ds.Locale = new System.Globalization.CultureInfo("");
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmCompanyBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "frmCompanyBrowse";
            this.ObjectName = Apothex.DataType.ObjectNames.Company;
            this.OptionsBaseForm.Text = "კომპანიები";
            this.OptionsListForm.IsBlockable = false;
            this.OptionsListForm.IsSystemColumnsable = true;
            this.OptionsListForm.IsUnblockable = false;
            this.OptionsGrid.ColumnID = "CompanyID";
            this.OptionsGrid.ColumnStatusID = "Status";
            this.OptionsGrid.GridView = this.gridView;
            this.Text = "კომპანიები";
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookBank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankAccountNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.BindingSource bsCountry;
        private System.Windows.Forms.BindingSource bsBank;
        private DevExpress.XtraEditors.TextEdit txtCompanyName;
        private DevExpress.XtraEditors.LabelControl lblCompanyName;
        private DevExpress.XtraEditors.TextEdit txtTaxCode;
        private DevExpress.XtraEditors.LabelControl lblTaxCode;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.LabelControl lblPhone;
        private DevExpress.XtraEditors.TextEdit txtFax;
        private DevExpress.XtraEditors.LabelControl lblFax;
        private DevExpress.XtraEditors.LookUpEdit lookCountry;
        private DevExpress.XtraEditors.LabelControl lblCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colBankID;
        private DevExpress.XtraGrid.Columns.GridColumn colBankName;
        private DevExpress.XtraGrid.Columns.GridColumn colBankCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBankAccountNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colApproverUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colApprover;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl lblAddress;
        private DevExpress.XtraEditors.LookUpEdit lookBank;
        private DevExpress.XtraEditors.LabelControl lblBank;
        private DevExpress.XtraEditors.TextEdit txtBankAccountNumber;
        private DevExpress.XtraEditors.LabelControl lblBankAccountNumber;
        private Apothex.DataType.DS_Person ds;
    }
}