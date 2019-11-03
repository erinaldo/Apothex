namespace Apothex.Production
{
    partial class frmProductLocationMISBrowse
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
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.view = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBranchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicamentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colListPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNewDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riDiscount = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this._colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValidDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVendor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ds = new Apothex.DataType.DS_ProductLocationMIS();
            this.cboxBranch = new DevExpress.XtraEditors.ComboBoxEdit();
            this.bbBranch = new Apothex.Windows.Forms.ButtonBrowse();
            this.lblBranch = new DevExpress.XtraEditors.LabelControl();
            this.lblDiscount = new DevExpress.XtraEditors.LabelControl();
            this.spinDiscount = new DevExpress.XtraEditors.SpinEdit();
            this.btnDiscount = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDiscount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.btnDiscount);
            this.pnlFilter.Controls.Add(this.spinDiscount);
            this.pnlFilter.Controls.Add(this.cboxBranch);
            this.pnlFilter.Controls.Add(this.bbBranch);
            this.pnlFilter.Controls.Add(this.lblDiscount);
            this.pnlFilter.Controls.Add(this.lblBranch);
            this.pnlFilter.Controls.SetChildIndex(this.btnFilter, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblBranch, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblDiscount, 0);
            this.pnlFilter.Controls.SetChildIndex(this.bbBranch, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxBranch, 0);
            this.pnlFilter.Controls.SetChildIndex(this.spinDiscount, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnDiscount, 0);
            // 
            // bsGridControl
            // 
            this.bsGridControl.DataMember = "VW_ProductLocationMIS";
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
            this.btnFilter.Location = new System.Drawing.Point(492, 6);
            this.btnFilter.TabIndex = 3;
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
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riDiscount});
            this.grid.Size = new System.Drawing.Size(784, 423);
            this.grid.TabIndex = 0;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view});
            // 
            // view
            // 
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBranchName,
            this.colMedicamentName,
            this.colListPrice,
            this.colNewDiscount,
            this._colPrice,
            this.colCountryName,
            this.colBrandName,
            this.colValidDate,
            this.colVendor});
            this.view.GridControl = this.grid;
            this.view.Name = "view";
            this.view.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMedicamentName, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.view.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.view_ShowingEditor);
            // 
            // colBranchName
            // 
            this.colBranchName.Caption = "ფილიალი";
            this.colBranchName.FieldName = "BranchName";
            this.colBranchName.Name = "colBranchName";
            this.colBranchName.OptionsColumn.AllowEdit = false;
            this.colBranchName.Visible = true;
            this.colBranchName.VisibleIndex = 0;
            // 
            // colMedicamentName
            // 
            this.colMedicamentName.Caption = "პროდუქცია";
            this.colMedicamentName.FieldName = "MedicamentName";
            this.colMedicamentName.Name = "colMedicamentName";
            this.colMedicamentName.OptionsColumn.AllowEdit = false;
            this.colMedicamentName.Visible = true;
            this.colMedicamentName.VisibleIndex = 1;
            // 
            // colListPrice
            // 
            this.colListPrice.Caption = "ფასი";
            this.colListPrice.FieldName = "ListPrice";
            this.colListPrice.Name = "colListPrice";
            this.colListPrice.OptionsColumn.AllowEdit = false;
            this.colListPrice.Visible = true;
            this.colListPrice.VisibleIndex = 2;
            // 
            // colNewDiscount
            // 
            this.colNewDiscount.Caption = "ფასდაკლება";
            this.colNewDiscount.ColumnEdit = this.riDiscount;
            this.colNewDiscount.DisplayFormat.FormatString = "p4";
            this.colNewDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNewDiscount.FieldName = "NewDiscount";
            this.colNewDiscount.GroupFormat.FormatString = "p2";
            this.colNewDiscount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNewDiscount.Name = "colNewDiscount";
            this.colNewDiscount.Visible = true;
            this.colNewDiscount.VisibleIndex = 3;
            // 
            // riDiscount
            // 
            this.riDiscount.AutoHeight = false;
            this.riDiscount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.riDiscount.DisplayFormat.FormatString = "p4";
            this.riDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riDiscount.EditFormat.FormatString = "p4";
            this.riDiscount.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riDiscount.Mask.EditMask = "p4";
            this.riDiscount.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.riDiscount.Name = "riDiscount";
            // 
            // _colPrice
            // 
            this._colPrice.Caption = "ფასი ფასდაკ.";
            this._colPrice.DisplayFormat.FormatString = "n4";
            this._colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._colPrice.FieldName = "_colPrice";
            this._colPrice.GroupFormat.FormatString = "n2";
            this._colPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._colPrice.Name = "_colPrice";
            this._colPrice.OptionsColumn.AllowEdit = false;
            this._colPrice.UnboundExpression = "[ListPrice]*(1m-Iif(IsNull([NewDiscount]),  0m, [NewDiscount]))";
            this._colPrice.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this._colPrice.Visible = true;
            this._colPrice.VisibleIndex = 4;
            // 
            // colCountryName
            // 
            this.colCountryName.Caption = "მწ. ქვეყანა";
            this.colCountryName.FieldName = "CountryName";
            this.colCountryName.Name = "colCountryName";
            this.colCountryName.OptionsColumn.AllowEdit = false;
            this.colCountryName.Visible = true;
            this.colCountryName.VisibleIndex = 5;
            // 
            // colBrandName
            // 
            this.colBrandName.Caption = "ბრენდი";
            this.colBrandName.FieldName = "BrandName";
            this.colBrandName.Name = "colBrandName";
            this.colBrandName.OptionsColumn.AllowEdit = false;
            this.colBrandName.Visible = true;
            this.colBrandName.VisibleIndex = 6;
            // 
            // colValidDate
            // 
            this.colValidDate.Caption = "ვადა";
            this.colValidDate.FieldName = "ValidDate";
            this.colValidDate.Name = "colValidDate";
            this.colValidDate.OptionsColumn.AllowEdit = false;
            this.colValidDate.Visible = true;
            this.colValidDate.VisibleIndex = 7;
            // 
            // colVendor
            // 
            this.colVendor.Caption = "მომწოდებელი";
            this.colVendor.FieldName = "Vendor";
            this.colVendor.Name = "colVendor";
            this.colVendor.OptionsColumn.AllowEdit = false;
            this.colVendor.Visible = true;
            this.colVendor.VisibleIndex = 8;
            // 
            // ds
            // 
            this.ds.DataSetName = "DS_ProductLocationMIS";
            this.ds.Locale = new System.Globalization.CultureInfo("");
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboxBranch
            // 
            this.cboxBranch.EditValue = "=";
            this.cboxBranch.EnterMoveNextControl = true;
            this.cboxBranch.Location = new System.Drawing.Point(124, 6);
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
            this.cboxBranch.Size = new System.Drawing.Size(75, 23);
            this.cboxBranch.TabIndex = 1;
            this.cboxBranch.SelectedIndexChanged += new System.EventHandler(this.cboxBranch_SelectedIndexChanged);
            // 
            // bbBranch
            // 
            this.bbBranch.EnterMoveNextControl = true;
            this.bbBranch.IsOnline = true;
            this.bbBranch.Location = new System.Drawing.Point(205, 6);
            this.bbBranch.MenuManager = this.barManager;
            this.bbBranch.Name = "bbBranch";
            this.bbBranch.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F);
            this.bbBranch.Properties.Appearance.Options.UseFont = true;
            this.bbBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject1, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject2, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbBranch.Size = new System.Drawing.Size(281, 23);
            this.bbBranch.TabIndex = 2;
            this.bbBranch.TableName = Apothex.DataType.ObjectNames.Branch;
            // 
            // lblBranch
            // 
            this.lblBranch.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBranch.Location = new System.Drawing.Point(12, 9);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(81, 17);
            this.lblBranch.TabIndex = 0;
            this.lblBranch.Text = "ფილიალი:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDiscount.Location = new System.Drawing.Point(12, 38);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(100, 17);
            this.lblDiscount.TabIndex = 4;
            this.lblDiscount.Text = "ფასდაკლება:";
            // 
            // spinDiscount
            // 
            this.spinDiscount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinDiscount.Location = new System.Drawing.Point(124, 35);
            this.spinDiscount.MenuManager = this.barManager;
            this.spinDiscount.Name = "spinDiscount";
            this.spinDiscount.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinDiscount.Properties.Appearance.Options.UseFont = true;
            this.spinDiscount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinDiscount.Properties.DisplayFormat.FormatString = "p4";
            this.spinDiscount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinDiscount.Properties.EditFormat.FormatString = "p4";
            this.spinDiscount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinDiscount.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.spinDiscount.Properties.Mask.EditMask = "p4";
            this.spinDiscount.Properties.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinDiscount.Size = new System.Drawing.Size(150, 23);
            this.spinDiscount.TabIndex = 5;
            // 
            // btnDiscount
            // 
            this.btnDiscount.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDiscount.Appearance.Options.UseFont = true;
            this.btnDiscount.Location = new System.Drawing.Point(280, 35);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(75, 23);
            this.btnDiscount.TabIndex = 6;
            this.btnDiscount.Text = "გადაფასება";
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // frmProductLocationMISBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsFiltered = true;
            this.IsFilterPanelVisible = true;
            this.Name = "frmProductLocationMISBrowse";
            this.ObjectName = Apothex.DataType.ObjectNames.ProductLocationMIS;
            this.OptionsBaseForm.Text = "პრაისი";
            this.OptionsListForm.IsAddable = false;
            this.OptionsListForm.IsApprovable = false;
            this.OptionsListForm.IsBlockable = false;
            this.OptionsListForm.IsChooseable = false;
            this.OptionsListForm.IsDeletable = false;
            this.OptionsListForm.IsDisapprovable = false;
            this.OptionsListForm.IsSystemColumnsable = true;
            this.OptionsListForm.IsUnblockable = false;
            this.OptionsGrid.GridView = this.view;
            this.Text = "პრაისი";
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
            ((System.ComponentModel.ISupportInitialize)(this.riDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDiscount.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView view;
        private DataType.DS_ProductLocationMIS ds;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchName;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentName;
        private DevExpress.XtraGrid.Columns.GridColumn colListPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryName;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandName;
        private DevExpress.XtraGrid.Columns.GridColumn colValidDate;
        private DevExpress.XtraEditors.ComboBoxEdit cboxBranch;
        private Windows.Forms.ButtonBrowse bbBranch;
        private DevExpress.XtraEditors.LabelControl lblBranch;
        private DevExpress.XtraGrid.Columns.GridColumn colVendor;
        private DevExpress.XtraGrid.Columns.GridColumn colNewDiscount;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit riDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn _colPrice;
        private DevExpress.XtraEditors.SpinEdit spinDiscount;
        private DevExpress.XtraEditors.LabelControl lblDiscount;
        private DevExpress.XtraEditors.SimpleButton btnDiscount;
    }
}