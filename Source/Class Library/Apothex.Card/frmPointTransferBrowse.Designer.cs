namespace Apothex.Card
{
    partial class frmPointTransferBrowse
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
            this.ds = new Apothex.DataType.DS_CardPointTransfer();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.view = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreator = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifierID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApproverID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboxToCardHolder = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtToCardHolder = new DevExpress.XtraEditors.TextEdit();
            this.lblToCardHolder = new DevExpress.XtraEditors.LabelControl();
            this.lblFromCardHolder = new DevExpress.XtraEditors.LabelControl();
            this.txtFromCardHolder = new DevExpress.XtraEditors.TextEdit();
            this.cboxFromCardHolder = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblToCardNumber = new DevExpress.XtraEditors.LabelControl();
            this.txtToCardNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblFromCardNumber = new DevExpress.XtraEditors.LabelControl();
            this.txtFromCardNumber = new DevExpress.XtraEditors.TextEdit();
            this.cboxToCardNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboxFromCardNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.cboxDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateDate1 = new DevExpress.XtraEditors.DateEdit();
            this.dateDate2 = new DevExpress.XtraEditors.DateEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.cboxToCardHolder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToCardHolder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromCardHolder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxFromCardHolder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToCardNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromCardNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxToCardNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxFromCardNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.lblDate);
            this.pnlFilter.Controls.Add(this.cboxDate);
            this.pnlFilter.Controls.Add(this.dateDate1);
            this.pnlFilter.Controls.Add(this.dateDate2);
            this.pnlFilter.Controls.Add(this.cboxFromCardNumber);
            this.pnlFilter.Controls.Add(this.cboxFromCardHolder);
            this.pnlFilter.Controls.Add(this.cboxToCardNumber);
            this.pnlFilter.Controls.Add(this.cboxToCardHolder);
            this.pnlFilter.Controls.Add(this.txtFromCardNumber);
            this.pnlFilter.Controls.Add(this.lblFromCardNumber);
            this.pnlFilter.Controls.Add(this.txtFromCardHolder);
            this.pnlFilter.Controls.Add(this.txtToCardNumber);
            this.pnlFilter.Controls.Add(this.lblFromCardHolder);
            this.pnlFilter.Controls.Add(this.lblToCardNumber);
            this.pnlFilter.Controls.Add(this.txtToCardHolder);
            this.pnlFilter.Controls.Add(this.lblToCardHolder);
            this.pnlFilter.Size = new System.Drawing.Size(784, 150);
            this.pnlFilter.Controls.SetChildIndex(this.btnFilter, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblToCardHolder, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtToCardHolder, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblToCardNumber, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblFromCardHolder, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtToCardNumber, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtFromCardHolder, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblFromCardNumber, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtFromCardNumber, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxToCardHolder, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxToCardNumber, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxFromCardHolder, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxFromCardNumber, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateDate2, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateDate1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxDate, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblDate, 0);
            // 
            // bsGridControl
            // 
            this.bsGridControl.DataMember = "VW_PointTransferHeader";
            this.bsGridControl.DataSource = this.ds;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.grid);
            this.pnlGrid.Location = new System.Drawing.Point(0, 189);
            this.pnlGrid.Size = new System.Drawing.Size(784, 373);
            // 
            // btnFilter
            // 
            this.btnFilter.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.Appearance.Options.UseFont = true;
            // 
            // popupMenu
            // 
            this.popupMenu.MenuAppearance.Menu.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popupMenu.MenuAppearance.Menu.Options.UseFont = true;
            // 
            // ds
            // 
            this.ds.DataSetName = "DS_CardPointTransfer";
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
            this.grid.Size = new System.Drawing.Size(784, 373);
            this.grid.TabIndex = 0;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view});
            // 
            // view
            // 
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDate,
            this.colFromCardNumber,
            this.colFromPerson,
            this.colToCardNumber,
            this.colToPerson,
            this.colComment,
            this.colCreator,
            this.colModifier,
            this.colApprover,
            this.colStatusID,
            this.colCreateDate,
            this.colCreatorID,
            this.colModifiedDate,
            this.colModifierID,
            this.colApproverID});
            this.view.GridControl = this.grid;
            this.view.Name = "view";
            // 
            // colID
            // 
            this.colID.Caption = "№";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colDate
            // 
            this.colDate.Caption = "თარიღი";
            this.colDate.DisplayFormat.FormatString = "G";
            this.colDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            // 
            // colFromCardNumber
            // 
            this.colFromCardNumber.Caption = "ძველი ბარათი";
            this.colFromCardNumber.FieldName = "FromCardNumber";
            this.colFromCardNumber.Name = "colFromCardNumber";
            this.colFromCardNumber.Visible = true;
            this.colFromCardNumber.VisibleIndex = 2;
            // 
            // colFromPerson
            // 
            this.colFromPerson.Caption = "ძველი მფლობელი";
            this.colFromPerson.FieldName = "FromPerson";
            this.colFromPerson.Name = "colFromPerson";
            this.colFromPerson.OptionsColumn.ReadOnly = true;
            this.colFromPerson.Visible = true;
            this.colFromPerson.VisibleIndex = 3;
            // 
            // colToCardNumber
            // 
            this.colToCardNumber.Caption = "ახალი ბარათი";
            this.colToCardNumber.FieldName = "ToCardNumber";
            this.colToCardNumber.Name = "colToCardNumber";
            this.colToCardNumber.Visible = true;
            this.colToCardNumber.VisibleIndex = 4;
            // 
            // colToPerson
            // 
            this.colToPerson.Caption = "ახალი მფლობელი";
            this.colToPerson.FieldName = "ToPerson";
            this.colToPerson.Name = "colToPerson";
            this.colToPerson.OptionsColumn.ReadOnly = true;
            this.colToPerson.Visible = true;
            this.colToPerson.VisibleIndex = 5;
            // 
            // colComment
            // 
            this.colComment.Caption = "კომენტარი";
            this.colComment.FieldName = "Comment";
            this.colComment.Name = "colComment";
            this.colComment.Visible = true;
            this.colComment.VisibleIndex = 6;
            // 
            // colCreator
            // 
            this.colCreator.FieldName = "Creator";
            this.colCreator.Name = "colCreator";
            // 
            // colModifier
            // 
            this.colModifier.FieldName = "Modifier";
            this.colModifier.Name = "colModifier";
            // 
            // colApprover
            // 
            this.colApprover.FieldName = "Approver";
            this.colApprover.Name = "colApprover";
            // 
            // colStatusID
            // 
            this.colStatusID.FieldName = "StatusID";
            this.colStatusID.Name = "colStatusID";
            // 
            // colCreateDate
            // 
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            // 
            // colCreatorID
            // 
            this.colCreatorID.FieldName = "CreatorID";
            this.colCreatorID.Name = "colCreatorID";
            // 
            // colModifiedDate
            // 
            this.colModifiedDate.FieldName = "ModifiedDate";
            this.colModifiedDate.Name = "colModifiedDate";
            // 
            // colModifierID
            // 
            this.colModifierID.FieldName = "ModifierID";
            this.colModifierID.Name = "colModifierID";
            // 
            // colApproverID
            // 
            this.colApproverID.FieldName = "ApproverID";
            this.colApproverID.Name = "colApproverID";
            // 
            // cboxToCardHolder
            // 
            this.cboxToCardHolder.EditValue = "%a%";
            this.cboxToCardHolder.EnterMoveNextControl = true;
            this.cboxToCardHolder.Location = new System.Drawing.Point(120, 109);
            this.cboxToCardHolder.Name = "cboxToCardHolder";
            this.cboxToCardHolder.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxToCardHolder.Properties.Appearance.Options.UseFont = true;
            this.cboxToCardHolder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxToCardHolder.Properties.Items.AddRange(new object[] {
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
            this.cboxToCardHolder.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxToCardHolder.Size = new System.Drawing.Size(75, 20);
            this.cboxToCardHolder.TabIndex = 14;
            this.cboxToCardHolder.SelectedIndexChanged += new System.EventHandler(this.cboxToCardHolder_SelectedIndexChanged);
            // 
            // txtToCardHolder
            // 
            this.txtToCardHolder.EnterMoveNextControl = true;
            this.txtToCardHolder.Location = new System.Drawing.Point(201, 109);
            this.txtToCardHolder.Name = "txtToCardHolder";
            this.txtToCardHolder.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtToCardHolder.Properties.Appearance.Options.UseFont = true;
            this.txtToCardHolder.Size = new System.Drawing.Size(306, 20);
            this.txtToCardHolder.TabIndex = 15;
            // 
            // lblToCardHolder
            // 
            this.lblToCardHolder.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblToCardHolder.Location = new System.Drawing.Point(3, 112);
            this.lblToCardHolder.Name = "lblToCardHolder";
            this.lblToCardHolder.Size = new System.Drawing.Size(110, 14);
            this.lblToCardHolder.TabIndex = 13;
            this.lblToCardHolder.Text = "ახალი მფლობელი:";
            // 
            // lblFromCardHolder
            // 
            this.lblFromCardHolder.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFromCardHolder.Location = new System.Drawing.Point(3, 86);
            this.lblFromCardHolder.Name = "lblFromCardHolder";
            this.lblFromCardHolder.Size = new System.Drawing.Size(110, 14);
            this.lblFromCardHolder.TabIndex = 10;
            this.lblFromCardHolder.Text = "ძველი მფლობელი:";
            // 
            // txtFromCardHolder
            // 
            this.txtFromCardHolder.EnterMoveNextControl = true;
            this.txtFromCardHolder.Location = new System.Drawing.Point(201, 83);
            this.txtFromCardHolder.Name = "txtFromCardHolder";
            this.txtFromCardHolder.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFromCardHolder.Properties.Appearance.Options.UseFont = true;
            this.txtFromCardHolder.Size = new System.Drawing.Size(306, 20);
            this.txtFromCardHolder.TabIndex = 12;
            // 
            // cboxFromCardHolder
            // 
            this.cboxFromCardHolder.EditValue = "%a%";
            this.cboxFromCardHolder.EnterMoveNextControl = true;
            this.cboxFromCardHolder.Location = new System.Drawing.Point(120, 83);
            this.cboxFromCardHolder.Name = "cboxFromCardHolder";
            this.cboxFromCardHolder.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxFromCardHolder.Properties.Appearance.Options.UseFont = true;
            this.cboxFromCardHolder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxFromCardHolder.Properties.Items.AddRange(new object[] {
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
            this.cboxFromCardHolder.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxFromCardHolder.Size = new System.Drawing.Size(75, 20);
            this.cboxFromCardHolder.TabIndex = 11;
            this.cboxFromCardHolder.SelectedIndexChanged += new System.EventHandler(this.cboxFromCardHolder_SelectedIndexChanged);
            // 
            // lblToCardNumber
            // 
            this.lblToCardNumber.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblToCardNumber.Location = new System.Drawing.Point(3, 60);
            this.lblToCardNumber.Name = "lblToCardNumber";
            this.lblToCardNumber.Size = new System.Drawing.Size(86, 14);
            this.lblToCardNumber.TabIndex = 7;
            this.lblToCardNumber.Text = "ახალი ბარათი:";
            // 
            // txtToCardNumber
            // 
            this.txtToCardNumber.EnterMoveNextControl = true;
            this.txtToCardNumber.Location = new System.Drawing.Point(201, 57);
            this.txtToCardNumber.Name = "txtToCardNumber";
            this.txtToCardNumber.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtToCardNumber.Properties.Appearance.Options.UseFont = true;
            this.txtToCardNumber.Size = new System.Drawing.Size(306, 20);
            this.txtToCardNumber.TabIndex = 9;
            // 
            // lblFromCardNumber
            // 
            this.lblFromCardNumber.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFromCardNumber.Location = new System.Drawing.Point(3, 34);
            this.lblFromCardNumber.Name = "lblFromCardNumber";
            this.lblFromCardNumber.Size = new System.Drawing.Size(86, 14);
            this.lblFromCardNumber.TabIndex = 4;
            this.lblFromCardNumber.Text = "ძველი ბარათი:";
            // 
            // txtFromCardNumber
            // 
            this.txtFromCardNumber.EnterMoveNextControl = true;
            this.txtFromCardNumber.Location = new System.Drawing.Point(201, 31);
            this.txtFromCardNumber.Name = "txtFromCardNumber";
            this.txtFromCardNumber.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFromCardNumber.Properties.Appearance.Options.UseFont = true;
            this.txtFromCardNumber.Size = new System.Drawing.Size(306, 20);
            this.txtFromCardNumber.TabIndex = 6;
            // 
            // cboxToCardNumber
            // 
            this.cboxToCardNumber.EditValue = "%a%";
            this.cboxToCardNumber.EnterMoveNextControl = true;
            this.cboxToCardNumber.Location = new System.Drawing.Point(120, 57);
            this.cboxToCardNumber.Name = "cboxToCardNumber";
            this.cboxToCardNumber.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxToCardNumber.Properties.Appearance.Options.UseFont = true;
            this.cboxToCardNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxToCardNumber.Properties.Items.AddRange(new object[] {
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
            this.cboxToCardNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxToCardNumber.Size = new System.Drawing.Size(75, 20);
            this.cboxToCardNumber.TabIndex = 8;
            this.cboxToCardNumber.SelectedIndexChanged += new System.EventHandler(this.cboxToCardNumber_SelectedIndexChanged);
            // 
            // cboxFromCardNumber
            // 
            this.cboxFromCardNumber.EditValue = "%a%";
            this.cboxFromCardNumber.EnterMoveNextControl = true;
            this.cboxFromCardNumber.Location = new System.Drawing.Point(120, 31);
            this.cboxFromCardNumber.Name = "cboxFromCardNumber";
            this.cboxFromCardNumber.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxFromCardNumber.Properties.Appearance.Options.UseFont = true;
            this.cboxFromCardNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxFromCardNumber.Properties.Items.AddRange(new object[] {
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
            this.cboxFromCardNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxFromCardNumber.Size = new System.Drawing.Size(75, 20);
            this.cboxFromCardNumber.TabIndex = 5;
            this.cboxFromCardNumber.SelectedIndexChanged += new System.EventHandler(this.cboxFromCardNumber_SelectedIndexChanged);
            // 
            // lblDate
            // 
            this.lblDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.Location = new System.Drawing.Point(3, 8);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 14);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "თარიღი:";
            // 
            // cboxDate
            // 
            this.cboxDate.EnterMoveNextControl = true;
            this.cboxDate.Location = new System.Drawing.Point(120, 5);
            this.cboxDate.Name = "cboxDate";
            this.cboxDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxDate.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxDate.Properties.Appearance.Options.UseFont = true;
            this.cboxDate.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxDate.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxDate.Properties.Items.AddRange(new object[] {
            "",
            "=",
            ">",
            "<",
            "[ ]"});
            this.cboxDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxDate.Size = new System.Drawing.Size(75, 20);
            this.cboxDate.TabIndex = 1;
            this.cboxDate.SelectedIndexChanged += new System.EventHandler(this.cboxDate_SelectedIndexChanged);
            // 
            // dateDate1
            // 
            this.dateDate1.EditValue = null;
            this.dateDate1.Enabled = false;
            this.dateDate1.EnterMoveNextControl = true;
            this.dateDate1.Location = new System.Drawing.Point(201, 5);
            this.dateDate1.Name = "dateDate1";
            this.dateDate1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dateDate1.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateDate1.Properties.Appearance.Options.UseFont = true;
            this.dateDate1.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateDate1.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dateDate1.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateDate1.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.dateDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDate1.Properties.DisplayFormat.FormatString = "G";
            this.dateDate1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateDate1.Properties.EditFormat.FormatString = "G";
            this.dateDate1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateDate1.Properties.Mask.EditMask = "G";
            this.dateDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateDate1.Size = new System.Drawing.Size(150, 20);
            this.dateDate1.TabIndex = 2;
            // 
            // dateDate2
            // 
            this.dateDate2.EditValue = null;
            this.dateDate2.Enabled = false;
            this.dateDate2.EnterMoveNextControl = true;
            this.dateDate2.Location = new System.Drawing.Point(357, 5);
            this.dateDate2.Name = "dateDate2";
            this.dateDate2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dateDate2.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateDate2.Properties.Appearance.Options.UseFont = true;
            this.dateDate2.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateDate2.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dateDate2.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateDate2.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.dateDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDate2.Properties.DisplayFormat.FormatString = "G";
            this.dateDate2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateDate2.Properties.EditFormat.FormatString = "G";
            this.dateDate2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateDate2.Properties.Mask.EditMask = "G";
            this.dateDate2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateDate2.Size = new System.Drawing.Size(150, 20);
            this.dateDate2.TabIndex = 3;
            // 
            // frmPointTransferBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "frmPointTransferBrowse";
            this.ObjectName = Apothex.DataType.ObjectNames.PointTransfer;
            this.OptionsBaseForm.Text = "დაგროვილი ქულების გადატანები";
            this.OptionsListForm.IsBlockable = false;
            this.OptionsListForm.IsSystemColumnsable = true;
            this.OptionsListForm.IsUnblockable = false;
            this.OptionsGrid.GridView = this.view;
            this.TableName = "Card.VW_PointTransferHeader";
            this.Text = "დაგროვილი ქულების გადატანები";
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
            ((System.ComponentModel.ISupportInitialize)(this.cboxToCardHolder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToCardHolder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromCardHolder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxFromCardHolder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToCardNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromCardNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxToCardNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxFromCardNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataType.DS_CardPointTransfer ds;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView view;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colFromCardNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colFromPerson;
        private DevExpress.XtraGrid.Columns.GridColumn colToCardNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colToPerson;
        private DevExpress.XtraGrid.Columns.GridColumn colComment;
        private DevExpress.XtraGrid.Columns.GridColumn colCreator;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraGrid.Columns.GridColumn colApprover;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusID;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatorID;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colModifierID;
        private DevExpress.XtraGrid.Columns.GridColumn colApproverID;
        private DevExpress.XtraEditors.ComboBoxEdit cboxFromCardHolder;
        private DevExpress.XtraEditors.ComboBoxEdit cboxToCardHolder;
        private DevExpress.XtraEditors.TextEdit txtFromCardHolder;
        private DevExpress.XtraEditors.LabelControl lblFromCardHolder;
        private DevExpress.XtraEditors.TextEdit txtToCardHolder;
        private DevExpress.XtraEditors.LabelControl lblToCardHolder;
        private DevExpress.XtraEditors.ComboBoxEdit cboxFromCardNumber;
        private DevExpress.XtraEditors.ComboBoxEdit cboxToCardNumber;
        private DevExpress.XtraEditors.TextEdit txtFromCardNumber;
        private DevExpress.XtraEditors.LabelControl lblFromCardNumber;
        private DevExpress.XtraEditors.TextEdit txtToCardNumber;
        private DevExpress.XtraEditors.LabelControl lblToCardNumber;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.ComboBoxEdit cboxDate;
        private DevExpress.XtraEditors.DateEdit dateDate1;
        private DevExpress.XtraEditors.DateEdit dateDate2;
    }
}