namespace Apothex.Person
{
    partial class frmPersonBrowse
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
            this.ds = new Apothex.DataType.DS_Person();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.view = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonalNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreator = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifierID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApproverID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboxPersonalNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPersonalNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblPersonalNumber = new DevExpress.XtraEditors.LabelControl();
            this.cboxFullName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtFullName = new DevExpress.XtraEditors.TextEdit();
            this.lblFullName = new DevExpress.XtraEditors.LabelControl();
            this.lookPersonCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.bsPersonCategory = new System.Windows.Forms.BindingSource(this.components);
            this.cboxPersonCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblCardType = new DevExpress.XtraEditors.LabelControl();
            this.lblCity = new DevExpress.XtraEditors.LabelControl();
            this.txtCity = new DevExpress.XtraEditors.TextEdit();
            this.cboxCity = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.cboxAddress = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblBranch = new DevExpress.XtraEditors.LabelControl();
            this.lookBranch = new DevExpress.XtraEditors.LookUpEdit();
            this.colBranchID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxPersonalNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonalNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookPersonCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPersonCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxPersonCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookBranch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.lblBranch);
            this.pnlFilter.Controls.Add(this.lookBranch);
            this.pnlFilter.Controls.Add(this.lookPersonCategory);
            this.pnlFilter.Controls.Add(this.cboxPersonCategory);
            this.pnlFilter.Controls.Add(this.lblCardType);
            this.pnlFilter.Controls.Add(this.cboxFullName);
            this.pnlFilter.Controls.Add(this.txtFullName);
            this.pnlFilter.Controls.Add(this.lblFullName);
            this.pnlFilter.Controls.Add(this.cboxAddress);
            this.pnlFilter.Controls.Add(this.cboxCity);
            this.pnlFilter.Controls.Add(this.txtAddress);
            this.pnlFilter.Controls.Add(this.txtCity);
            this.pnlFilter.Controls.Add(this.lblAddress);
            this.pnlFilter.Controls.Add(this.cboxPersonalNumber);
            this.pnlFilter.Controls.Add(this.lblCity);
            this.pnlFilter.Controls.Add(this.txtPersonalNumber);
            this.pnlFilter.Controls.Add(this.lblPersonalNumber);
            this.pnlFilter.Controls.SetChildIndex(this.btnFilter, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblPersonalNumber, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtPersonalNumber, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblCity, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxPersonalNumber, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblAddress, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtCity, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtAddress, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxCity, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxAddress, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblFullName, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtFullName, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxFullName, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblCardType, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxPersonCategory, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lookPersonCategory, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lookBranch, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblBranch, 0);
            // 
            // bsGridControl
            // 
            this.bsGridControl.DataMember = "VW_Person";
            this.bsGridControl.DataSource = this.ds;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.grid);
            // 
            // btnFilter
            // 
            this.btnFilter.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.Appearance.Options.UseFont = true;
            this.btnFilter.Location = new System.Drawing.Point(857, 51);
            this.btnFilter.TabIndex = 17;
            // 
            // popupMenu
            // 
            this.popupMenu.MenuAppearance.Menu.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popupMenu.MenuAppearance.Menu.Options.UseFont = true;
            // 
            // ds
            // 
            this.ds.DataSetName = "DS_Person";
            this.ds.Locale = new System.Globalization.CultureInfo("");
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grid
            // 
            this.grid.DataSource = this.bsGridControl;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.view;
            this.grid.MenuManager = this.barManager;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(784, 423);
            this.grid.TabIndex = 0;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view});
            // 
            // view
            // 
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFullName,
            this.colPersonalNumber,
            this.colPersonCategoryName,
            this.colCity,
            this.colAddress,
            this.colJobTitle,
            this.colBirthDate,
            this.colPhone,
            this.colMobile,
            this.colEmail,
            this.colPersonID,
            this.colPersonCategoryID,
            this.colStatusID,
            this.colCreateDate,
            this.colCreatorID,
            this.colCreator,
            this.colBranchID,
            this.colBranch,
            this.colModifiedDate,
            this.colModifierID,
            this.colModifier,
            this.colApproverID,
            this.colApprover});
            this.view.GridControl = this.grid;
            this.view.Name = "view";
            // 
            // colFullName
            // 
            this.colFullName.Caption = "სრული სახელი";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.OptionsColumn.ReadOnly = true;
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 0;
            // 
            // colPersonalNumber
            // 
            this.colPersonalNumber.Caption = "№";
            this.colPersonalNumber.FieldName = "PersonalNumber";
            this.colPersonalNumber.Name = "colPersonalNumber";
            this.colPersonalNumber.Visible = true;
            this.colPersonalNumber.VisibleIndex = 1;
            // 
            // colPersonCategoryName
            // 
            this.colPersonCategoryName.Caption = "კატეგირია";
            this.colPersonCategoryName.FieldName = "PersonCategoryName";
            this.colPersonCategoryName.Name = "colPersonCategoryName";
            this.colPersonCategoryName.Visible = true;
            this.colPersonCategoryName.VisibleIndex = 2;
            // 
            // colCity
            // 
            this.colCity.Caption = "ქალაქი";
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 3;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "მისამართი";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 4;
            // 
            // colJobTitle
            // 
            this.colJobTitle.Caption = "თანამდებობა";
            this.colJobTitle.FieldName = "JobTitle";
            this.colJobTitle.Name = "colJobTitle";
            this.colJobTitle.Visible = true;
            this.colJobTitle.VisibleIndex = 5;
            // 
            // colBirthDate
            // 
            this.colBirthDate.Caption = "დაბ თარიღი";
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.Visible = true;
            this.colBirthDate.VisibleIndex = 6;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "ტელეფონი";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 7;
            // 
            // colMobile
            // 
            this.colMobile.Caption = "მობილური";
            this.colMobile.FieldName = "Mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.Visible = true;
            this.colMobile.VisibleIndex = 8;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "E-mail";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 9;
            // 
            // colPersonID
            // 
            this.colPersonID.Caption = "ID";
            this.colPersonID.FieldName = "PersonID";
            this.colPersonID.Name = "colPersonID";
            // 
            // colPersonCategoryID
            // 
            this.colPersonCategoryID.FieldName = "PersonCategoryID";
            this.colPersonCategoryID.Name = "colPersonCategoryID";
            // 
            // colStatusID
            // 
            this.colStatusID.FieldName = "StatusID";
            this.colStatusID.Name = "colStatusID";
            // 
            // colCreateDate
            // 
            this.colCreateDate.DisplayFormat.FormatString = "G";
            this.colCreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            // 
            // colCreatorID
            // 
            this.colCreatorID.FieldName = "CreatorID";
            this.colCreatorID.Name = "colCreatorID";
            // 
            // colCreator
            // 
            this.colCreator.FieldName = "Creator";
            this.colCreator.Name = "colCreator";
            // 
            // colModifiedDate
            // 
            this.colModifiedDate.DisplayFormat.FormatString = "G";
            this.colModifiedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colModifiedDate.FieldName = "ModifiedDate";
            this.colModifiedDate.Name = "colModifiedDate";
            // 
            // colModifierID
            // 
            this.colModifierID.FieldName = "ModifierID";
            this.colModifierID.Name = "colModifierID";
            // 
            // colModifier
            // 
            this.colModifier.FieldName = "Modifier";
            this.colModifier.Name = "colModifier";
            // 
            // colApproverID
            // 
            this.colApproverID.FieldName = "ApproverID";
            this.colApproverID.Name = "colApproverID";
            // 
            // colApprover
            // 
            this.colApprover.FieldName = "Approver";
            this.colApprover.Name = "colApprover";
            // 
            // cboxPersonalNumber
            // 
            this.cboxPersonalNumber.EditValue = "%a%";
            this.cboxPersonalNumber.EnterMoveNextControl = true;
            this.cboxPersonalNumber.Location = new System.Drawing.Point(130, 35);
            this.cboxPersonalNumber.Name = "cboxPersonalNumber";
            this.cboxPersonalNumber.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxPersonalNumber.Properties.Appearance.Options.UseFont = true;
            this.cboxPersonalNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxPersonalNumber.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!=",
            "%a%",
            "!%a%",
            "a%",
            "!a%",
            "%a",
            "!%a",
            "a,b,c",
            "!a,b,c"});
            this.cboxPersonalNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxPersonalNumber.Size = new System.Drawing.Size(75, 23);
            this.cboxPersonalNumber.TabIndex = 4;
            this.cboxPersonalNumber.SelectedIndexChanged += new System.EventHandler(this.cboxPersonalNumber_SelectedIndexChanged);
            // 
            // txtPersonalNumber
            // 
            this.txtPersonalNumber.EnterMoveNextControl = true;
            this.txtPersonalNumber.Location = new System.Drawing.Point(211, 35);
            this.txtPersonalNumber.Name = "txtPersonalNumber";
            this.txtPersonalNumber.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPersonalNumber.Properties.Appearance.Options.UseFont = true;
            this.txtPersonalNumber.Size = new System.Drawing.Size(231, 23);
            this.txtPersonalNumber.TabIndex = 5;
            // 
            // lblPersonalNumber
            // 
            this.lblPersonalNumber.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPersonalNumber.Location = new System.Drawing.Point(6, 38);
            this.lblPersonalNumber.Name = "lblPersonalNumber";
            this.lblPersonalNumber.Size = new System.Drawing.Size(20, 17);
            this.lblPersonalNumber.TabIndex = 3;
            this.lblPersonalNumber.Text = "№:";
            // 
            // cboxFullName
            // 
            this.cboxFullName.EditValue = "%a%";
            this.cboxFullName.EnterMoveNextControl = true;
            this.cboxFullName.Location = new System.Drawing.Point(130, 6);
            this.cboxFullName.Name = "cboxFullName";
            this.cboxFullName.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxFullName.Properties.Appearance.Options.UseFont = true;
            this.cboxFullName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxFullName.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!=",
            "%a%",
            "!%a%",
            "a%",
            "!a%",
            "%a",
            "!%a",
            "a,b,c",
            "!a,b,c"});
            this.cboxFullName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxFullName.Size = new System.Drawing.Size(75, 23);
            this.cboxFullName.TabIndex = 1;
            this.cboxFullName.SelectedIndexChanged += new System.EventHandler(this.cboxFullName_SelectedIndexChanged);
            // 
            // txtFullName
            // 
            this.txtFullName.EnterMoveNextControl = true;
            this.txtFullName.Location = new System.Drawing.Point(211, 6);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFullName.Properties.Appearance.Options.UseFont = true;
            this.txtFullName.Size = new System.Drawing.Size(231, 23);
            this.txtFullName.TabIndex = 2;
            // 
            // lblFullName
            // 
            this.lblFullName.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFullName.Location = new System.Drawing.Point(6, 9);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(118, 17);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "სრული სახელი:";
            // 
            // lookPersonCategory
            // 
            this.lookPersonCategory.EnterMoveNextControl = true;
            this.lookPersonCategory.Location = new System.Drawing.Point(211, 64);
            this.lookPersonCategory.Name = "lookPersonCategory";
            this.lookPersonCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookPersonCategory.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookPersonCategory.Properties.Appearance.Options.UseFont = true;
            this.lookPersonCategory.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookPersonCategory.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookPersonCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookPersonCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.lookPersonCategory.Properties.DataSource = this.bsPersonCategory;
            this.lookPersonCategory.Properties.DisplayMember = "Caption";
            this.lookPersonCategory.Properties.NullText = "";
            this.lookPersonCategory.Properties.ShowHeader = false;
            this.lookPersonCategory.Properties.ValueMember = "ID";
            this.lookPersonCategory.Size = new System.Drawing.Size(231, 23);
            this.lookPersonCategory.TabIndex = 8;
            // 
            // cboxPersonCategory
            // 
            this.cboxPersonCategory.EditValue = "=";
            this.cboxPersonCategory.EnterMoveNextControl = true;
            this.cboxPersonCategory.Location = new System.Drawing.Point(130, 64);
            this.cboxPersonCategory.Name = "cboxPersonCategory";
            this.cboxPersonCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxPersonCategory.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxPersonCategory.Properties.Appearance.Options.UseFont = true;
            this.cboxPersonCategory.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxPersonCategory.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxPersonCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxPersonCategory.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!="});
            this.cboxPersonCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxPersonCategory.Size = new System.Drawing.Size(75, 23);
            this.cboxPersonCategory.TabIndex = 7;
            this.cboxPersonCategory.SelectedIndexChanged += new System.EventHandler(this.cboxPersonCategory_SelectedIndexChanged);
            // 
            // lblCardType
            // 
            this.lblCardType.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCardType.Location = new System.Drawing.Point(6, 67);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(86, 17);
            this.lblCardType.TabIndex = 6;
            this.lblCardType.Text = "კატეგორია:";
            // 
            // lblCity
            // 
            this.lblCity.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCity.Location = new System.Drawing.Point(448, 9);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(61, 17);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "ქალაქი:";
            // 
            // txtCity
            // 
            this.txtCity.EnterMoveNextControl = true;
            this.txtCity.Location = new System.Drawing.Point(620, 6);
            this.txtCity.Name = "txtCity";
            this.txtCity.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCity.Properties.Appearance.Options.UseFont = true;
            this.txtCity.Size = new System.Drawing.Size(231, 23);
            this.txtCity.TabIndex = 11;
            // 
            // cboxCity
            // 
            this.cboxCity.EditValue = "%a%";
            this.cboxCity.EnterMoveNextControl = true;
            this.cboxCity.Location = new System.Drawing.Point(539, 6);
            this.cboxCity.Name = "cboxCity";
            this.cboxCity.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxCity.Properties.Appearance.Options.UseFont = true;
            this.cboxCity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxCity.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!=",
            "%a%",
            "!%a%",
            "a%",
            "!a%",
            "%a",
            "!%a",
            "a,b,c",
            "!a,b,c"});
            this.cboxCity.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxCity.Size = new System.Drawing.Size(75, 23);
            this.cboxCity.TabIndex = 10;
            this.cboxCity.SelectedIndexChanged += new System.EventHandler(this.cboxCity_SelectedIndexChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddress.Location = new System.Drawing.Point(448, 38);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(85, 17);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "მისამართი:";
            // 
            // txtAddress
            // 
            this.txtAddress.EnterMoveNextControl = true;
            this.txtAddress.Location = new System.Drawing.Point(620, 35);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Size = new System.Drawing.Size(231, 23);
            this.txtAddress.TabIndex = 14;
            // 
            // cboxAddress
            // 
            this.cboxAddress.EditValue = "%a%";
            this.cboxAddress.EnterMoveNextControl = true;
            this.cboxAddress.Location = new System.Drawing.Point(539, 35);
            this.cboxAddress.Name = "cboxAddress";
            this.cboxAddress.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxAddress.Properties.Appearance.Options.UseFont = true;
            this.cboxAddress.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxAddress.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!=",
            "%a%",
            "!%a%",
            "a%",
            "!a%",
            "%a",
            "!%a",
            "a,b,c",
            "!a,b,c"});
            this.cboxAddress.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxAddress.Size = new System.Drawing.Size(75, 23);
            this.cboxAddress.TabIndex = 13;
            this.cboxAddress.SelectedIndexChanged += new System.EventHandler(this.cboxAddress_SelectedIndexChanged);
            // 
            // lblBranch
            // 
            this.lblBranch.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBranch.Location = new System.Drawing.Point(448, 67);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(81, 17);
            this.lblBranch.TabIndex = 15;
            this.lblBranch.Text = "ფილიალი:";
            // 
            // lookBranch
            // 
            this.lookBranch.EnterMoveNextControl = true;
            this.lookBranch.Location = new System.Drawing.Point(539, 64);
            this.lookBranch.Name = "lookBranch";
            this.lookBranch.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookBranch.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookBranch.Properties.Appearance.Options.UseFont = true;
            this.lookBranch.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookBranch.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookBranch.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.lookBranch.Properties.DisplayMember = "Caption";
            this.lookBranch.Properties.NullText = "";
            this.lookBranch.Properties.ShowHeader = false;
            this.lookBranch.Properties.ValueMember = "ID";
            this.lookBranch.Size = new System.Drawing.Size(312, 23);
            this.lookBranch.TabIndex = 16;
            // 
            // colBranchID
            // 
            this.colBranchID.FieldName = "BranchID";
            this.colBranchID.Name = "colBranchID";
            // 
            // colBranch
            // 
            this.colBranch.Caption = "ფილიალი";
            this.colBranch.FieldName = "Branch";
            this.colBranch.Name = "colBranch";
            this.colBranch.Visible = true;
            this.colBranch.VisibleIndex = 10;
            // 
            // frmPersonBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "frmPersonBrowse";
            this.ObjectName = Apothex.DataType.ObjectNames.Person;
            this.OptionsBaseForm.Text = "პერსონები";
            this.OptionsListForm.IsBlockable = false;
            this.OptionsListForm.IsSystemColumnsable = true;
            this.OptionsListForm.IsUnblockable = false;
            this.OptionsGrid.ColumnID = "PersonID";
            this.OptionsGrid.GridView = this.view;
            this.TableName = "Person.VW_Person";
            this.Text = "პერსონები";
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxPersonalNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonalNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookPersonCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPersonCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxPersonCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookBranch.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataType.DS_Person ds;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView view;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonID;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonalNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colJobTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusID;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatorID;
        private DevExpress.XtraGrid.Columns.GridColumn colCreator;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colModifierID;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraGrid.Columns.GridColumn colApproverID;
        private DevExpress.XtraGrid.Columns.GridColumn colApprover;
        private DevExpress.XtraEditors.ComboBoxEdit cboxFullName;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraEditors.LabelControl lblFullName;
        private DevExpress.XtraEditors.ComboBoxEdit cboxPersonalNumber;
        private DevExpress.XtraEditors.TextEdit txtPersonalNumber;
        private DevExpress.XtraEditors.LabelControl lblPersonalNumber;
        private DevExpress.XtraEditors.LookUpEdit lookPersonCategory;
        private DevExpress.XtraEditors.ComboBoxEdit cboxPersonCategory;
        private DevExpress.XtraEditors.LabelControl lblCardType;
        private DevExpress.XtraEditors.ComboBoxEdit cboxCity;
        private DevExpress.XtraEditors.TextEdit txtCity;
        private DevExpress.XtraEditors.LabelControl lblCity;
        private DevExpress.XtraEditors.ComboBoxEdit cboxAddress;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl lblAddress;
        private System.Windows.Forms.BindingSource bsPersonCategory;
        private DevExpress.XtraEditors.LabelControl lblBranch;
        private DevExpress.XtraEditors.LookUpEdit lookBranch;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchID;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch;
    }
}