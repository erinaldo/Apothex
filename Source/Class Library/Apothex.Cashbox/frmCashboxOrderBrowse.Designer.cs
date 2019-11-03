namespace Apothex.Cashbox
{
    partial class frmCashboxOrderBrowse
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
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.view = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifierID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApproverID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ds = new Apothex.DataType.DS_Cashbox();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.cboxDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateDate1 = new DevExpress.XtraEditors.DateEdit();
            this.dateDate2 = new DevExpress.XtraEditors.DateEdit();
            this.cboxActNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtActNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblActNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblIssuedPerson = new DevExpress.XtraEditors.LabelControl();
            this.txtIssuedPerson = new DevExpress.XtraEditors.TextEdit();
            this.cboxIssuedPerson = new DevExpress.XtraEditors.ComboBoxEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.cboxDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxActNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIssuedPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxIssuedPerson.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.lblDate);
            this.pnlFilter.Controls.Add(this.cboxDate);
            this.pnlFilter.Controls.Add(this.dateDate1);
            this.pnlFilter.Controls.Add(this.dateDate2);
            this.pnlFilter.Controls.Add(this.cboxIssuedPerson);
            this.pnlFilter.Controls.Add(this.txtIssuedPerson);
            this.pnlFilter.Controls.Add(this.cboxActNumber);
            this.pnlFilter.Controls.Add(this.lblIssuedPerson);
            this.pnlFilter.Controls.Add(this.txtActNumber);
            this.pnlFilter.Controls.Add(this.lblActNumber);
            this.pnlFilter.Controls.SetChildIndex(this.btnFilter, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblActNumber, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtActNumber, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblIssuedPerson, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxActNumber, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtIssuedPerson, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxIssuedPerson, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateDate2, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateDate1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxDate, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblDate, 0);
            // 
            // bsGridControl
            // 
            this.bsGridControl.DataMember = "VW_CashboxOrder";
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
            this.btnFilter.Location = new System.Drawing.Point(373, 45);
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
            this.colActNumber,
            this.colOrderDate,
            this.colBranchID,
            this.colBranch,
            this.colPersonID,
            this.colPerson,
            this.colOrderTypeID,
            this.colOrderType,
            this.colAmount,
            this.colCurrencyID,
            this.colCurrency,
            this.colCreateDate,
            this.colCreatorID,
            this.colModifiedDate,
            this.colModifierID,
            this.colApproverID,
            this.colStatusID});
            this.view.GridControl = this.grid;
            this.view.Name = "view";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colActNumber
            // 
            this.colActNumber.Caption = "№";
            this.colActNumber.FieldName = "ActNumber";
            this.colActNumber.Name = "colActNumber";
            this.colActNumber.Visible = true;
            this.colActNumber.VisibleIndex = 0;
            // 
            // colOrderDate
            // 
            this.colOrderDate.Caption = "თარიღი";
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 1;
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
            this.colBranch.VisibleIndex = 2;
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
            this.colPerson.Visible = true;
            this.colPerson.VisibleIndex = 3;
            // 
            // colOrderTypeID
            // 
            this.colOrderTypeID.FieldName = "OrderTypeID";
            this.colOrderTypeID.Name = "colOrderTypeID";
            // 
            // colOrderType
            // 
            this.colOrderType.Caption = "ტიპი";
            this.colOrderType.FieldName = "OrderType";
            this.colOrderType.Name = "colOrderType";
            this.colOrderType.Visible = true;
            this.colOrderType.VisibleIndex = 4;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "თანხა";
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 5;
            // 
            // colCurrencyID
            // 
            this.colCurrencyID.FieldName = "CurrencyID";
            this.colCurrencyID.Name = "colCurrencyID";
            // 
            // colCurrency
            // 
            this.colCurrency.Caption = "ვალუტა";
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.Visible = true;
            this.colCurrency.VisibleIndex = 6;
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
            // colStatusID
            // 
            this.colStatusID.FieldName = "StatusID";
            this.colStatusID.Name = "colStatusID";
            this.colStatusID.Visible = true;
            this.colStatusID.VisibleIndex = 7;
            // 
            // ds
            // 
            this.ds.DataSetName = "DS_Cashbox";
            this.ds.Locale = new System.Globalization.CultureInfo("");
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblDate
            // 
            this.lblDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.Location = new System.Drawing.Point(13, 35);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 14);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "თარიღი:";
            // 
            // cboxDate
            // 
            this.cboxDate.EnterMoveNextControl = true;
            this.cboxDate.Location = new System.Drawing.Point(80, 32);
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
            this.cboxDate.TabIndex = 4;
            this.cboxDate.SelectedIndexChanged += new System.EventHandler(this.cboxDate_SelectedIndexChanged);
            // 
            // dateDate1
            // 
            this.dateDate1.EditValue = null;
            this.dateDate1.Enabled = false;
            this.dateDate1.EnterMoveNextControl = true;
            this.dateDate1.Location = new System.Drawing.Point(161, 32);
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
            this.dateDate1.Size = new System.Drawing.Size(100, 20);
            this.dateDate1.TabIndex = 5;
            // 
            // dateDate2
            // 
            this.dateDate2.EditValue = null;
            this.dateDate2.Enabled = false;
            this.dateDate2.EnterMoveNextControl = true;
            this.dateDate2.Location = new System.Drawing.Point(267, 32);
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
            this.dateDate2.Size = new System.Drawing.Size(100, 20);
            this.dateDate2.TabIndex = 6;
            // 
            // cboxActNumber
            // 
            this.cboxActNumber.EditValue = "%a%";
            this.cboxActNumber.EnterMoveNextControl = true;
            this.cboxActNumber.Location = new System.Drawing.Point(80, 6);
            this.cboxActNumber.Name = "cboxActNumber";
            this.cboxActNumber.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxActNumber.Properties.Appearance.Options.UseFont = true;
            this.cboxActNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxActNumber.Properties.Items.AddRange(new object[] {
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
            this.cboxActNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxActNumber.Size = new System.Drawing.Size(75, 20);
            this.cboxActNumber.TabIndex = 1;
            this.cboxActNumber.SelectedIndexChanged += new System.EventHandler(this.cboxActNumber_SelectedIndexChanged);
            // 
            // txtActNumber
            // 
            this.txtActNumber.EnterMoveNextControl = true;
            this.txtActNumber.Location = new System.Drawing.Point(161, 6);
            this.txtActNumber.Name = "txtActNumber";
            this.txtActNumber.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtActNumber.Properties.Appearance.Options.UseFont = true;
            this.txtActNumber.Size = new System.Drawing.Size(206, 20);
            this.txtActNumber.TabIndex = 2;
            // 
            // lblActNumber
            // 
            this.lblActNumber.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblActNumber.Location = new System.Drawing.Point(13, 9);
            this.lblActNumber.Name = "lblActNumber";
            this.lblActNumber.Size = new System.Drawing.Size(14, 14);
            this.lblActNumber.TabIndex = 0;
            this.lblActNumber.Text = "№";
            // 
            // lblIssuedPerson
            // 
            this.lblIssuedPerson.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIssuedPerson.Location = new System.Drawing.Point(13, 61);
            this.lblIssuedPerson.Name = "lblIssuedPerson";
            this.lblIssuedPerson.Size = new System.Drawing.Size(52, 14);
            this.lblIssuedPerson.TabIndex = 7;
            this.lblIssuedPerson.Text = "პერსონა:";
            // 
            // txtIssuedPerson
            // 
            this.txtIssuedPerson.EnterMoveNextControl = true;
            this.txtIssuedPerson.Location = new System.Drawing.Point(161, 58);
            this.txtIssuedPerson.Name = "txtIssuedPerson";
            this.txtIssuedPerson.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIssuedPerson.Properties.Appearance.Options.UseFont = true;
            this.txtIssuedPerson.Size = new System.Drawing.Size(206, 20);
            this.txtIssuedPerson.TabIndex = 9;
            // 
            // cboxIssuedPerson
            // 
            this.cboxIssuedPerson.EditValue = "%a%";
            this.cboxIssuedPerson.EnterMoveNextControl = true;
            this.cboxIssuedPerson.Location = new System.Drawing.Point(80, 58);
            this.cboxIssuedPerson.Name = "cboxIssuedPerson";
            this.cboxIssuedPerson.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxIssuedPerson.Properties.Appearance.Options.UseFont = true;
            this.cboxIssuedPerson.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxIssuedPerson.Properties.Items.AddRange(new object[] {
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
            this.cboxIssuedPerson.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxIssuedPerson.Size = new System.Drawing.Size(75, 20);
            this.cboxIssuedPerson.TabIndex = 8;
            this.cboxIssuedPerson.SelectedIndexChanged += new System.EventHandler(this.cboxIssuedPerson_SelectedIndexChanged);
            // 
            // frmCashboxOrderBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "frmCashboxOrderBrowse";
            this.ObjectName = Apothex.DataType.ObjectNames.Cashbox;
            this.OptionsListForm.IsBlockable = false;
            this.OptionsListForm.IsSystemColumnsable = true;
            this.OptionsListForm.IsUnblockable = false;
            this.OptionsGrid.GridView = this.view;
            this.TableName = "Accounting.VW_CashboxOrder";
            this.Text = "სალაროს გასავლის ორდერები";
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
            ((System.ComponentModel.ISupportInitialize)(this.cboxDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxActNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIssuedPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxIssuedPerson.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView view;
        private DataType.DS_Cashbox ds;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colActNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchID;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonID;
        private DevExpress.XtraGrid.Columns.GridColumn colPerson;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderType;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyID;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatorID;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colModifierID;
        private DevExpress.XtraGrid.Columns.GridColumn colApproverID;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusID;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.ComboBoxEdit cboxDate;
        private DevExpress.XtraEditors.DateEdit dateDate1;
        private DevExpress.XtraEditors.DateEdit dateDate2;
        private DevExpress.XtraEditors.ComboBoxEdit cboxIssuedPerson;
        private DevExpress.XtraEditors.TextEdit txtIssuedPerson;
        private DevExpress.XtraEditors.ComboBoxEdit cboxActNumber;
        private DevExpress.XtraEditors.LabelControl lblIssuedPerson;
        private DevExpress.XtraEditors.TextEdit txtActNumber;
        private DevExpress.XtraEditors.LabelControl lblActNumber;
    }
}