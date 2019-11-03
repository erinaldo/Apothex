namespace Apothex.Card
{
    partial class frmCardHandleBrowse
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
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.view = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSalesOrderID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colBranch = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTotalDue = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colFullName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPersonalNumber = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCardNumber = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCardID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colBranchID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCreatorID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCreator = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colModifierID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colModifier = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colUnit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAmount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ds = new Apothex.DataType.DS_Card();
            this.dateHandle2 = new DevExpress.XtraEditors.DateEdit();
            this.dateHandle1 = new DevExpress.XtraEditors.DateEdit();
            this.lblHandlePeriod = new DevExpress.XtraEditors.LabelControl();
            this.bbBranch = new Apothex.Windows.Forms.ButtonBrowse();
            this.lblBranch = new DevExpress.XtraEditors.LabelControl();
            this.cboxBranch = new DevExpress.XtraEditors.ComboBoxEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.dateHandle2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHandle2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHandle1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHandle1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxBranch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.bbBranch);
            this.pnlFilter.Controls.Add(this.lblBranch);
            this.pnlFilter.Controls.Add(this.cboxBranch);
            this.pnlFilter.Controls.Add(this.dateHandle2);
            this.pnlFilter.Controls.Add(this.dateHandle1);
            this.pnlFilter.Controls.Add(this.lblHandlePeriod);
            this.pnlFilter.Controls.SetChildIndex(this.btnFilter, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblHandlePeriod, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateHandle1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateHandle2, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxBranch, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblBranch, 0);
            this.pnlFilter.Controls.SetChildIndex(this.bbBranch, 0);
            // 
            // bsGridControl
            // 
            this.bsGridControl.DataMember = "VW_CardHandle";
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
            this.btnFilter.Location = new System.Drawing.Point(253, 61);
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
            this.view.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colSalesOrderID,
            this.colOrderDate,
            this.colBranch,
            this.colTotalDue,
            this.colFullName,
            this.colPersonalNumber,
            this.colCardNumber,
            this.colAmount,
            this.colUnit,
            this.colCardID,
            this.colBranchID,
            this.colCreateDate,
            this.colCreatorID,
            this.colCreator,
            this.colModifiedDate,
            this.colModifierID,
            this.colModifier});
            this.view.GridControl = this.grid;
            this.view.Name = "view";
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.colSalesOrderID);
            this.gridBand1.Columns.Add(this.colOrderDate);
            this.gridBand1.Columns.Add(this.colBranch);
            this.gridBand1.Columns.Add(this.colTotalDue);
            this.gridBand1.Columns.Add(this.colFullName);
            this.gridBand1.Columns.Add(this.colPersonalNumber);
            this.gridBand1.Columns.Add(this.colCardNumber);
            this.gridBand1.Columns.Add(this.colCardID);
            this.gridBand1.Columns.Add(this.colBranchID);
            this.gridBand1.Columns.Add(this.colCreateDate);
            this.gridBand1.Columns.Add(this.colCreatorID);
            this.gridBand1.Columns.Add(this.colCreator);
            this.gridBand1.Columns.Add(this.colModifiedDate);
            this.gridBand1.Columns.Add(this.colModifierID);
            this.gridBand1.Columns.Add(this.colModifier);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 525;
            // 
            // colSalesOrderID
            // 
            this.colSalesOrderID.Caption = "გაყიდვის №";
            this.colSalesOrderID.FieldName = "SalesOrderID";
            this.colSalesOrderID.Name = "colSalesOrderID";
            this.colSalesOrderID.Visible = true;
            // 
            // colOrderDate
            // 
            this.colOrderDate.Caption = "გაყიდვის თარიღი";
            this.colOrderDate.DisplayFormat.FormatString = "G";
            this.colOrderDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.GroupFormat.FormatString = "d";
            this.colOrderDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            // 
            // colBranch
            // 
            this.colBranch.Caption = "ფილიალი";
            this.colBranch.FieldName = "Branch";
            this.colBranch.Name = "colBranch";
            this.colBranch.Visible = true;
            // 
            // colTotalDue
            // 
            this.colTotalDue.Caption = "თანხა";
            this.colTotalDue.DisplayFormat.FormatString = "n2";
            this.colTotalDue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalDue.FieldName = "TotalDue";
            this.colTotalDue.GroupFormat.FormatString = "n2";
            this.colTotalDue.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalDue.Name = "colTotalDue";
            this.colTotalDue.Visible = true;
            // 
            // colFullName
            // 
            this.colFullName.Caption = "სახელი, გვარი";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            // 
            // colPersonalNumber
            // 
            this.colPersonalNumber.Caption = "მფლობ. პირ. №";
            this.colPersonalNumber.FieldName = "PersonalNumber";
            this.colPersonalNumber.Name = "colPersonalNumber";
            this.colPersonalNumber.Visible = true;
            // 
            // colCardNumber
            // 
            this.colCardNumber.Caption = "ბარათის №";
            this.colCardNumber.FieldName = "CardNumber";
            this.colCardNumber.Name = "colCardNumber";
            this.colCardNumber.Visible = true;
            // 
            // colCardID
            // 
            this.colCardID.FieldName = "CardID";
            this.colCardID.Name = "colCardID";
            // 
            // colBranchID
            // 
            this.colBranchID.FieldName = "BranchID";
            this.colBranchID.Name = "colBranchID";
            // 
            // colCreateDate
            // 
            this.colCreateDate.DisplayFormat.FormatString = "G";
            this.colCreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.GroupFormat.FormatString = "d";
            this.colCreateDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
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
            this.colModifiedDate.GroupFormat.FormatString = "d";
            this.colModifiedDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
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
            // gridBand2
            // 
            this.gridBand2.Caption = "დაგროვილი";
            this.gridBand2.Columns.Add(this.colUnit);
            this.gridBand2.Columns.Add(this.colAmount);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 150;
            // 
            // colUnit
            // 
            this.colUnit.Caption = "ქულა";
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.SummaryItem.DisplayFormat = "{0:n2}";
            this.colUnit.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colUnit.Visible = true;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "თანხა";
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAmount.Visible = true;
            // 
            // ds
            // 
            this.ds.DataSetName = "DS_Card";
            this.ds.Locale = new System.Globalization.CultureInfo("");
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateHandle2
            // 
            this.dateHandle2.EditValue = null;
            this.dateHandle2.EnterMoveNextControl = true;
            this.dateHandle2.Location = new System.Drawing.Point(253, 6);
            this.dateHandle2.MenuManager = this.barManager;
            this.dateHandle2.Name = "dateHandle2";
            this.dateHandle2.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateHandle2.Properties.Appearance.Options.UseFont = true;
            this.dateHandle2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateHandle2.Properties.DisplayFormat.FormatString = "G";
            this.dateHandle2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateHandle2.Properties.EditFormat.FormatString = "G";
            this.dateHandle2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateHandle2.Properties.Mask.EditMask = "G";
            this.dateHandle2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateHandle2.Size = new System.Drawing.Size(150, 23);
            this.dateHandle2.TabIndex = 2;
            // 
            // dateHandle1
            // 
            this.dateHandle1.EditValue = null;
            this.dateHandle1.EnterMoveNextControl = true;
            this.dateHandle1.Location = new System.Drawing.Point(97, 6);
            this.dateHandle1.MenuManager = this.barManager;
            this.dateHandle1.Name = "dateHandle1";
            this.dateHandle1.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateHandle1.Properties.Appearance.Options.UseFont = true;
            this.dateHandle1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateHandle1.Properties.DisplayFormat.FormatString = "G";
            this.dateHandle1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateHandle1.Properties.EditFormat.FormatString = "G";
            this.dateHandle1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateHandle1.Properties.Mask.EditMask = "G";
            this.dateHandle1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateHandle1.Size = new System.Drawing.Size(150, 23);
            this.dateHandle1.TabIndex = 1;
            // 
            // lblHandlePeriod
            // 
            this.lblHandlePeriod.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHandlePeriod.Location = new System.Drawing.Point(12, 9);
            this.lblHandlePeriod.Name = "lblHandlePeriod";
            this.lblHandlePeriod.Size = new System.Drawing.Size(73, 17);
            this.lblHandlePeriod.TabIndex = 0;
            this.lblHandlePeriod.Text = "პერიოდი:";
            // 
            // bbBranch
            // 
            this.bbBranch.EnterMoveNextControl = true;
            this.bbBranch.IsOnline = true;
            this.bbBranch.Location = new System.Drawing.Point(155, 35);
            this.bbBranch.MenuManager = this.barManager;
            this.bbBranch.Name = "bbBranch";
            this.bbBranch.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F);
            this.bbBranch.Properties.Appearance.Options.UseFont = true;
            this.bbBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject3, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject4, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbBranch.Size = new System.Drawing.Size(248, 23);
            this.bbBranch.TabIndex = 5;
            this.bbBranch.TableName = Apothex.DataType.ObjectNames.Branch;
            this.bbBranch.Visible = false;
            // 
            // lblBranch
            // 
            this.lblBranch.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBranch.Location = new System.Drawing.Point(12, 38);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(81, 17);
            this.lblBranch.TabIndex = 3;
            this.lblBranch.Text = "ფილიალი:";
            this.lblBranch.Visible = false;
            // 
            // cboxBranch
            // 
            this.cboxBranch.EditValue = "=";
            this.cboxBranch.EnterMoveNextControl = true;
            this.cboxBranch.Location = new System.Drawing.Point(99, 35);
            this.cboxBranch.Name = "cboxBranch";
            this.cboxBranch.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxBranch.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxBranch.Properties.Appearance.Options.UseFont = true;
            this.cboxBranch.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxBranch.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxBranch.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!="});
            this.cboxBranch.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxBranch.Size = new System.Drawing.Size(50, 23);
            this.cboxBranch.TabIndex = 4;
            this.cboxBranch.Visible = false;
            this.cboxBranch.SelectedIndexChanged += new System.EventHandler(this.cboxBranch_SelectedIndexChanged);
            // 
            // frmCardHandleBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsFiltered = true;
            this.IsFilterPanelVisible = true;
            this.Name = "frmCardHandleBrowse";
            this.ObjectName = Apothex.DataType.ObjectNames.CardHandle;
            this.OptionsBaseForm.Text = "ბარათის გატარების დეტალური რეესტრი";
            this.OptionsListForm.IsAddable = false;
            this.OptionsListForm.IsApprovable = false;
            this.OptionsListForm.IsAutoRefreshVisible = false;
            this.OptionsListForm.IsBlockable = false;
            this.OptionsListForm.IsChooseable = false;
            this.OptionsListForm.IsDeletable = false;
            this.OptionsListForm.IsDisapprovable = false;
            this.OptionsListForm.IsFilterApprovable = false;
            this.OptionsListForm.IsSystemColumnsable = true;
            this.OptionsListForm.IsTopable = false;
            this.OptionsListForm.IsUnblockable = false;
            this.OptionsGrid.AutoInitStyleFormat = false;
            this.OptionsGrid.ColumnID = "SalesOrderID";
            this.OptionsGrid.GridView = this.view;
            this.Text = "ბარათის გატარების დეტალური რეესტრი";
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
            ((System.ComponentModel.ISupportInitialize)(this.dateHandle2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHandle2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHandle1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHandle1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxBranch.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataType.DS_Card ds;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraEditors.DateEdit dateHandle2;
        private DevExpress.XtraEditors.DateEdit dateHandle1;
        private DevExpress.XtraEditors.LabelControl lblHandlePeriod;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSalesOrderID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOrderDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colBranch;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTotalDue;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFullName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPersonalNumber;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCardNumber;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCardID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colBranchID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCreateDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCreatorID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCreator;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colModifiedDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colModifierID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colModifier;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAmount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnit;
        private Windows.Forms.ButtonBrowse bbBranch;
        private DevExpress.XtraEditors.LabelControl lblBranch;
        private DevExpress.XtraEditors.ComboBoxEdit cboxBranch;
    }
}