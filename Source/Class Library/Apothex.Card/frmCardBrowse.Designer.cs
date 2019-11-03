namespace Apothex.Card
{
    partial class frmCardBrowse
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
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.view = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonalNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentCardID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreator = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifierID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApproverID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ds = new Apothex.DataType.DS_Card();
            this.cboxNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblNumber = new DevExpress.XtraEditors.LabelControl();
            this.cboxPersonID = new DevExpress.XtraEditors.ComboBoxEdit();
            this.bbPersonID = new Apothex.Windows.Forms.ButtonBrowse();
            this.lblPersonID = new DevExpress.XtraEditors.LabelControl();
            this.cboxPersonName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPersonName = new DevExpress.XtraEditors.TextEdit();
            this.lblPersonName = new DevExpress.XtraEditors.LabelControl();
            this.lblCardType = new DevExpress.XtraEditors.LabelControl();
            this.cboxCardType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lookCardType = new DevExpress.XtraEditors.LookUpEdit();
            this.bsCardType = new System.Windows.Forms.BindingSource(this.components);
            this.lblParentCardNumber = new DevExpress.XtraEditors.LabelControl();
            this.txtParentCardNumber = new DevExpress.XtraEditors.TextEdit();
            this.cboxParentCardNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblBranch = new DevExpress.XtraEditors.LabelControl();
            this.lookBranch = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxPersonID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbPersonID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxPersonName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxCardType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCardType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCardType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParentCardNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxParentCardNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookBranch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.lblBranch);
            this.pnlFilter.Controls.Add(this.lookBranch);
            this.pnlFilter.Controls.Add(this.lookCardType);
            this.pnlFilter.Controls.Add(this.cboxCardType);
            this.pnlFilter.Controls.Add(this.cboxPersonID);
            this.pnlFilter.Controls.Add(this.lblCardType);
            this.pnlFilter.Controls.Add(this.bbPersonID);
            this.pnlFilter.Controls.Add(this.lblPersonID);
            this.pnlFilter.Controls.Add(this.cboxPersonName);
            this.pnlFilter.Controls.Add(this.txtPersonName);
            this.pnlFilter.Controls.Add(this.lblPersonName);
            this.pnlFilter.Controls.Add(this.cboxParentCardNumber);
            this.pnlFilter.Controls.Add(this.cboxNumber);
            this.pnlFilter.Controls.Add(this.txtParentCardNumber);
            this.pnlFilter.Controls.Add(this.lblParentCardNumber);
            this.pnlFilter.Controls.Add(this.txtNumber);
            this.pnlFilter.Controls.Add(this.lblNumber);
            this.pnlFilter.Controls.SetChildIndex(this.btnFilter, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblNumber, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtNumber, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblParentCardNumber, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtParentCardNumber, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxNumber, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxParentCardNumber, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblPersonName, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtPersonName, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxPersonName, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblPersonID, 0);
            this.pnlFilter.Controls.SetChildIndex(this.bbPersonID, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblCardType, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxPersonID, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxCardType, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lookCardType, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lookBranch, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblBranch, 0);
            // 
            // bsGridControl
            // 
            this.bsGridControl.DataMember = "VW_Card";
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
            this.btnFilter.Location = new System.Drawing.Point(842, 26);
            // 
            // popupMenu
            // 
            this.popupMenu.MenuAppearance.Menu.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popupMenu.MenuAppearance.Menu.Options.UseFont = true;
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
            this.colID,
            this.colCardNumber,
            this.colCardTypeID,
            this.colCardTypeName,
            this.colPersonID,
            this.colPerson,
            this.colPersonalNumber,
            this.colParentCardID,
            this.colParentCardNumber,
            this.colTotalAmount,
            this.colTotalUnit,
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
            this.view.OptionsView.ShowFooter = true;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colCardNumber
            // 
            this.colCardNumber.Caption = "№";
            this.colCardNumber.FieldName = "CardNumber";
            this.colCardNumber.Name = "colCardNumber";
            this.colCardNumber.SummaryItem.DisplayFormat = "{0}";
            this.colCardNumber.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.colCardNumber.Visible = true;
            this.colCardNumber.VisibleIndex = 0;
            // 
            // colCardTypeID
            // 
            this.colCardTypeID.FieldName = "CardTypeID";
            this.colCardTypeID.Name = "colCardTypeID";
            // 
            // colCardTypeName
            // 
            this.colCardTypeName.Caption = "ბარათის ტიპი";
            this.colCardTypeName.FieldName = "CardTypeName";
            this.colCardTypeName.Name = "colCardTypeName";
            this.colCardTypeName.Visible = true;
            this.colCardTypeName.VisibleIndex = 1;
            // 
            // colPersonID
            // 
            this.colPersonID.FieldName = "PersonID";
            this.colPersonID.Name = "colPersonID";
            // 
            // colPerson
            // 
            this.colPerson.Caption = "პერსონა";
            this.colPerson.FieldName = "Person";
            this.colPerson.Name = "colPerson";
            this.colPerson.OptionsColumn.ReadOnly = true;
            this.colPerson.Visible = true;
            this.colPerson.VisibleIndex = 2;
            // 
            // colPersonalNumber
            // 
            this.colPersonalNumber.Caption = "პირადი №";
            this.colPersonalNumber.FieldName = "PersonalNumber";
            this.colPersonalNumber.Name = "colPersonalNumber";
            this.colPersonalNumber.Visible = true;
            this.colPersonalNumber.VisibleIndex = 3;
            // 
            // colParentCardID
            // 
            this.colParentCardID.FieldName = "ParentCardID";
            this.colParentCardID.Name = "colParentCardID";
            // 
            // colParentCardNumber
            // 
            this.colParentCardNumber.Caption = "მშობელი ბარათი";
            this.colParentCardNumber.DisplayFormat.FormatString = "n2";
            this.colParentCardNumber.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colParentCardNumber.FieldName = "ParentCardNumber";
            this.colParentCardNumber.GroupFormat.FormatString = "n2";
            this.colParentCardNumber.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colParentCardNumber.Name = "colParentCardNumber";
            this.colParentCardNumber.Visible = true;
            this.colParentCardNumber.VisibleIndex = 4;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.Caption = "ჯამ. დანაგ. თანხა";
            this.colTotalAmount.DisplayFormat.FormatString = "n2";
            this.colTotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalAmount.FieldName = "TotalAmount";
            this.colTotalAmount.GroupFormat.FormatString = "n2";
            this.colTotalAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colTotalAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTotalAmount.Visible = true;
            this.colTotalAmount.VisibleIndex = 5;
            // 
            // colTotalUnit
            // 
            this.colTotalUnit.Caption = "ჯამ. დანაგ. ქულა";
            this.colTotalUnit.FieldName = "TotalUnit";
            this.colTotalUnit.Name = "colTotalUnit";
            this.colTotalUnit.SummaryItem.DisplayFormat = "{0:n2}";
            this.colTotalUnit.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTotalUnit.Visible = true;
            this.colTotalUnit.VisibleIndex = 6;
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
            this.colBranch.VisibleIndex = 7;
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
            // ds
            // 
            this.ds.DataSetName = "DS_Card";
            this.ds.Locale = new System.Globalization.CultureInfo("");
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboxNumber
            // 
            this.cboxNumber.EditValue = "a%";
            this.cboxNumber.EnterMoveNextControl = true;
            this.cboxNumber.Location = new System.Drawing.Point(105, 6);
            this.cboxNumber.Name = "cboxNumber";
            this.cboxNumber.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxNumber.Properties.Appearance.Options.UseFont = true;
            this.cboxNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxNumber.Properties.Items.AddRange(new object[] {
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
            this.cboxNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxNumber.Size = new System.Drawing.Size(75, 23);
            this.cboxNumber.TabIndex = 1;
            this.cboxNumber.SelectedIndexChanged += new System.EventHandler(this.cboxNumber_SelectedIndexChanged);
            // 
            // txtNumber
            // 
            this.txtNumber.EnterMoveNextControl = true;
            this.txtNumber.Location = new System.Drawing.Point(186, 6);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNumber.Properties.Appearance.Options.UseFont = true;
            this.txtNumber.Properties.Mask.EditMask = "[0-9]{0,100}";
            this.txtNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNumber.Size = new System.Drawing.Size(231, 23);
            this.txtNumber.TabIndex = 2;
            // 
            // lblNumber
            // 
            this.lblNumber.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumber.Location = new System.Drawing.Point(6, 9);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(20, 17);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "№:";
            // 
            // cboxPersonID
            // 
            this.cboxPersonID.EditValue = "=";
            this.cboxPersonID.EnterMoveNextControl = true;
            this.cboxPersonID.Location = new System.Drawing.Point(524, 6);
            this.cboxPersonID.Name = "cboxPersonID";
            this.cboxPersonID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxPersonID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxPersonID.Properties.Appearance.Options.UseFont = true;
            this.cboxPersonID.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxPersonID.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxPersonID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxPersonID.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!="});
            this.cboxPersonID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxPersonID.Size = new System.Drawing.Size(75, 23);
            this.cboxPersonID.TabIndex = 10;
            // 
            // bbPersonID
            // 
            this.bbPersonID.EnterMoveNextControl = true;
            this.bbPersonID.IsOnline = true;
            this.bbPersonID.Location = new System.Drawing.Point(605, 6);
            this.bbPersonID.MenuManager = this.barManager;
            this.bbPersonID.Name = "bbPersonID";
            this.bbPersonID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bbPersonID.Properties.Appearance.Options.UseFont = true;
            this.bbPersonID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject1, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject2, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbPersonID.Size = new System.Drawing.Size(231, 23);
            this.bbPersonID.TabIndex = 11;
            this.bbPersonID.TableName = Apothex.DataType.ObjectNames.Person;
            // 
            // lblPersonID
            // 
            this.lblPersonID.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPersonID.Location = new System.Drawing.Point(425, 9);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(93, 17);
            this.lblPersonID.TabIndex = 9;
            this.lblPersonID.Text = "მფლობელი:";
            // 
            // cboxPersonName
            // 
            this.cboxPersonName.EditValue = "%a%";
            this.cboxPersonName.EnterMoveNextControl = true;
            this.cboxPersonName.Location = new System.Drawing.Point(524, 36);
            this.cboxPersonName.Name = "cboxPersonName";
            this.cboxPersonName.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxPersonName.Properties.Appearance.Options.UseFont = true;
            this.cboxPersonName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxPersonName.Properties.Items.AddRange(new object[] {
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
            this.cboxPersonName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxPersonName.Size = new System.Drawing.Size(75, 23);
            this.cboxPersonName.TabIndex = 13;
            // 
            // txtPersonName
            // 
            this.txtPersonName.EnterMoveNextControl = true;
            this.txtPersonName.Location = new System.Drawing.Point(605, 36);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPersonName.Properties.Appearance.Options.UseFont = true;
            this.txtPersonName.Size = new System.Drawing.Size(231, 23);
            this.txtPersonName.TabIndex = 14;
            // 
            // lblPersonName
            // 
            this.lblPersonName.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPersonName.Location = new System.Drawing.Point(425, 39);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(93, 17);
            this.lblPersonName.TabIndex = 12;
            this.lblPersonName.Text = "მფლობელი:";
            // 
            // lblCardType
            // 
            this.lblCardType.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCardType.Location = new System.Drawing.Point(6, 39);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(39, 17);
            this.lblCardType.TabIndex = 3;
            this.lblCardType.Text = "ტიპი:";
            // 
            // cboxCardType
            // 
            this.cboxCardType.EditValue = "=";
            this.cboxCardType.EnterMoveNextControl = true;
            this.cboxCardType.Location = new System.Drawing.Point(105, 36);
            this.cboxCardType.Name = "cboxCardType";
            this.cboxCardType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxCardType.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxCardType.Properties.Appearance.Options.UseFont = true;
            this.cboxCardType.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxCardType.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxCardType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxCardType.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!="});
            this.cboxCardType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxCardType.Size = new System.Drawing.Size(75, 23);
            this.cboxCardType.TabIndex = 4;
            this.cboxCardType.SelectedIndexChanged += new System.EventHandler(this.cboxCardType_SelectedIndexChanged);
            // 
            // lookCardType
            // 
            this.lookCardType.EnterMoveNextControl = true;
            this.lookCardType.Location = new System.Drawing.Point(186, 36);
            this.lookCardType.Name = "lookCardType";
            this.lookCardType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookCardType.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookCardType.Properties.Appearance.Options.UseFont = true;
            this.lookCardType.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookCardType.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookCardType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookCardType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.lookCardType.Properties.DataSource = this.bsCardType;
            this.lookCardType.Properties.DisplayMember = "Caption";
            this.lookCardType.Properties.NullText = "";
            this.lookCardType.Properties.ShowHeader = false;
            this.lookCardType.Properties.ValueMember = "ID";
            this.lookCardType.Size = new System.Drawing.Size(231, 23);
            this.lookCardType.TabIndex = 5;
            // 
            // lblParentCardNumber
            // 
            this.lblParentCardNumber.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblParentCardNumber.Location = new System.Drawing.Point(6, 68);
            this.lblParentCardNumber.Name = "lblParentCardNumber";
            this.lblParentCardNumber.Size = new System.Drawing.Size(93, 17);
            this.lblParentCardNumber.TabIndex = 6;
            this.lblParentCardNumber.Text = "მშობლის №:";
            // 
            // txtParentCardNumber
            // 
            this.txtParentCardNumber.EnterMoveNextControl = true;
            this.txtParentCardNumber.Location = new System.Drawing.Point(186, 65);
            this.txtParentCardNumber.Name = "txtParentCardNumber";
            this.txtParentCardNumber.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtParentCardNumber.Properties.Appearance.Options.UseFont = true;
            this.txtParentCardNumber.Size = new System.Drawing.Size(231, 23);
            this.txtParentCardNumber.TabIndex = 8;
            // 
            // cboxParentCardNumber
            // 
            this.cboxParentCardNumber.EditValue = "a%";
            this.cboxParentCardNumber.EnterMoveNextControl = true;
            this.cboxParentCardNumber.Location = new System.Drawing.Point(105, 65);
            this.cboxParentCardNumber.Name = "cboxParentCardNumber";
            this.cboxParentCardNumber.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxParentCardNumber.Properties.Appearance.Options.UseFont = true;
            this.cboxParentCardNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxParentCardNumber.Properties.Items.AddRange(new object[] {
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
            this.cboxParentCardNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxParentCardNumber.Size = new System.Drawing.Size(75, 23);
            this.cboxParentCardNumber.TabIndex = 7;
            this.cboxParentCardNumber.SelectedIndexChanged += new System.EventHandler(this.cboxParentCardNumber_SelectedIndexChanged);
            // 
            // lblBranch
            // 
            this.lblBranch.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBranch.Location = new System.Drawing.Point(425, 68);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(81, 17);
            this.lblBranch.TabIndex = 15;
            this.lblBranch.Text = "ფილიალი:";
            // 
            // lookBranch
            // 
            this.lookBranch.EnterMoveNextControl = true;
            this.lookBranch.Location = new System.Drawing.Point(524, 65);
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
            // frmCardBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "frmCardBrowse";
            this.ObjectName = Apothex.DataType.ObjectNames.Card;
            this.OptionsBaseForm.Text = "ბარათები";
            this.OptionsListForm.IsSystemColumnsable = true;
            this.OptionsGrid.GridView = this.view;
            this.TableName = "Card.VW_Card";
            this.Text = "ბარათები";
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxPersonID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbPersonID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxPersonName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxCardType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCardType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCardType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParentCardNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxParentCardNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookBranch.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataType.DS_Card ds;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView view;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCardNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCardTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn colCardTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonID;
        private DevExpress.XtraGrid.Columns.GridColumn colPerson;
        private DevExpress.XtraGrid.Columns.GridColumn colParentCardID;
        private DevExpress.XtraGrid.Columns.GridColumn colParentCardNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusID;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatorID;
        private DevExpress.XtraGrid.Columns.GridColumn colCreator;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colModifierID;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraGrid.Columns.GridColumn colApproverID;
        private DevExpress.XtraGrid.Columns.GridColumn colApprover;
        private DevExpress.XtraEditors.ComboBoxEdit cboxNumber;
        private DevExpress.XtraEditors.TextEdit txtNumber;
        private DevExpress.XtraEditors.LabelControl lblNumber;
        private DevExpress.XtraEditors.ComboBoxEdit cboxPersonID;
        private Windows.Forms.ButtonBrowse bbPersonID;
        private DevExpress.XtraEditors.LabelControl lblPersonID;
        private DevExpress.XtraEditors.ComboBoxEdit cboxPersonName;
        private DevExpress.XtraEditors.TextEdit txtPersonName;
        private DevExpress.XtraEditors.LabelControl lblPersonName;
        private DevExpress.XtraEditors.ComboBoxEdit cboxCardType;
        private DevExpress.XtraEditors.LabelControl lblCardType;
        private DevExpress.XtraEditors.LookUpEdit lookCardType;
        private DevExpress.XtraEditors.ComboBoxEdit cboxParentCardNumber;
        private DevExpress.XtraEditors.TextEdit txtParentCardNumber;
        private DevExpress.XtraEditors.LabelControl lblParentCardNumber;
        private System.Windows.Forms.BindingSource bsCardType;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchID;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch;
        private DevExpress.XtraEditors.LabelControl lblBranch;
        private DevExpress.XtraEditors.LookUpEdit lookBranch;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonalNumber;
    }
}