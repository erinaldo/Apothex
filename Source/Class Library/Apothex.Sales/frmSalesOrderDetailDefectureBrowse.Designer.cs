namespace Apothex.Sales
{
    partial class frmSalesOrderDetailDefectureBrowse
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.colIsChoosed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.view = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBranch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomenclature = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValidDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaleQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_AfterQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riQty = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colBranchID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomenclatureID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblOrderDate = new DevExpress.XtraEditors.LabelControl();
            this.dateOrderDate1 = new DevExpress.XtraEditors.DateEdit();
            this.dateOrderDate2 = new DevExpress.XtraEditors.DateEdit();
            this.lblBranch = new DevExpress.XtraEditors.LabelControl();
            this.bbBranch = new Apothex.Windows.Forms.ButtonBrowse();
            this.ds = new Apothex.DataType.DS_SalesOrderDetailDefacture();
            this.btnGenerateRequest = new DevExpress.XtraEditors.SimpleButton();
            this.lblVendor = new DevExpress.XtraEditors.LabelControl();
            this.bbVendor = new Apothex.Windows.Forms.ButtonBrowse();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbVendor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.btnGenerateRequest);
            this.pnlFilter.Controls.Add(this.bbVendor);
            this.pnlFilter.Controls.Add(this.lblVendor);
            this.pnlFilter.Controls.Add(this.bbBranch);
            this.pnlFilter.Controls.Add(this.lblBranch);
            this.pnlFilter.Controls.Add(this.lblOrderDate);
            this.pnlFilter.Controls.Add(this.dateOrderDate1);
            this.pnlFilter.Controls.Add(this.dateOrderDate2);
            this.pnlFilter.Controls.SetChildIndex(this.btnFilter, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateOrderDate2, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateOrderDate1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblOrderDate, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblBranch, 0);
            this.pnlFilter.Controls.SetChildIndex(this.bbBranch, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblVendor, 0);
            this.pnlFilter.Controls.SetChildIndex(this.bbVendor, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnGenerateRequest, 0);
            // 
            // bsGridControl
            // 
            this.bsGridControl.DataMember = "FN_SalesOrderDetailDefacture";
            this.bsGridControl.DataSource = this.ds;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.grid);
            // 
            // btnFilter
            // 
            this.btnFilter.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.Appearance.Options.UseFont = true;
            this.btnFilter.Location = new System.Drawing.Point(443, 9);
            // 
            // popupMenu
            // 
            this.popupMenu.MenuAppearance.Menu.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popupMenu.MenuAppearance.Menu.Options.UseFont = true;
            // 
            // colIsChoosed
            // 
            this.colIsChoosed.FieldName = "IsChoosed";
            this.colIsChoosed.Name = "colIsChoosed";
            this.colIsChoosed.OptionsColumn.AllowEdit = false;
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
            this.riQty});
            this.grid.Size = new System.Drawing.Size(784, 423);
            this.grid.TabIndex = 0;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view});
            // 
            // view
            // 
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBranch,
            this.colNomenclature,
            this.colCountry,
            this.colBrand,
            this.colValidDate,
            this.colSaleQty,
            this.colQuantity,
            this.col_AfterQty,
            this.colCustomQty,
            this.colBranchID,
            this.colNomenclatureID,
            this.colCountryCode,
            this.colBrandID,
            this.colIsChoosed});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Yellow;
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.Orange;
            styleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            styleFormatCondition1.Appearance.Options.HighPriority = true;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colIsChoosed;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = true;
            this.view.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.view.GridControl = this.grid;
            this.view.Name = "view";
            this.view.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNomenclature, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colBranch, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colBranch
            // 
            this.colBranch.Caption = "ფილიალი";
            this.colBranch.FieldName = "Branch";
            this.colBranch.Name = "colBranch";
            this.colBranch.OptionsColumn.AllowEdit = false;
            this.colBranch.Visible = true;
            this.colBranch.VisibleIndex = 0;
            // 
            // colNomenclature
            // 
            this.colNomenclature.Caption = "პროდუქცია";
            this.colNomenclature.FieldName = "Nomenclature";
            this.colNomenclature.Name = "colNomenclature";
            this.colNomenclature.OptionsColumn.AllowEdit = false;
            this.colNomenclature.Visible = true;
            this.colNomenclature.VisibleIndex = 1;
            // 
            // colCountry
            // 
            this.colCountry.Caption = "მწ. ქვეყანა";
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.OptionsColumn.AllowEdit = false;
            this.colCountry.Visible = true;
            this.colCountry.VisibleIndex = 2;
            // 
            // colBrand
            // 
            this.colBrand.Caption = "ბრენდი";
            this.colBrand.FieldName = "Brand";
            this.colBrand.Name = "colBrand";
            this.colBrand.OptionsColumn.AllowEdit = false;
            this.colBrand.Visible = true;
            this.colBrand.VisibleIndex = 3;
            // 
            // colValidDate
            // 
            this.colValidDate.Caption = "ვადა";
            this.colValidDate.DisplayFormat.FormatString = "MM\\/yy";
            this.colValidDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colValidDate.FieldName = "ValidDate";
            this.colValidDate.GroupFormat.FormatString = "MM\\/yy";
            this.colValidDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colValidDate.Name = "colValidDate";
            this.colValidDate.OptionsColumn.AllowEdit = false;
            this.colValidDate.Visible = true;
            this.colValidDate.VisibleIndex = 4;
            // 
            // colSaleQty
            // 
            this.colSaleQty.Caption = "გაყ. რაოდ";
            this.colSaleQty.DisplayFormat.FormatString = "n4";
            this.colSaleQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSaleQty.FieldName = "SaleQty";
            this.colSaleQty.GroupFormat.FormatString = "n2";
            this.colSaleQty.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSaleQty.Name = "colSaleQty";
            this.colSaleQty.OptionsColumn.AllowEdit = false;
            this.colSaleQty.Visible = true;
            this.colSaleQty.VisibleIndex = 6;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "ნაშთი";
            this.colQuantity.DisplayFormat.FormatString = "n4";
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.GroupFormat.FormatString = "n2";
            this.colQuantity.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.AllowEdit = false;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 5;
            // 
            // col_AfterQty
            // 
            this.col_AfterQty.Caption = "სავარ. დარჩ. რაოდ.";
            this.col_AfterQty.DisplayFormat.FormatString = "n4";
            this.col_AfterQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_AfterQty.FieldName = "col_AfterQty";
            this.col_AfterQty.GroupFormat.FormatString = "n2";
            this.col_AfterQty.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_AfterQty.Name = "col_AfterQty";
            this.col_AfterQty.OptionsColumn.AllowEdit = false;
            this.col_AfterQty.UnboundExpression = "[Quantity]-[SaleQty]";
            this.col_AfterQty.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col_AfterQty.Visible = true;
            this.col_AfterQty.VisibleIndex = 7;
            // 
            // colCustomQty
            // 
            this.colCustomQty.Caption = "შესაკ. რაოდ";
            this.colCustomQty.ColumnEdit = this.riQty;
            this.colCustomQty.DisplayFormat.FormatString = "n4";
            this.colCustomQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCustomQty.FieldName = "CustomQty";
            this.colCustomQty.GroupFormat.FormatString = "n2";
            this.colCustomQty.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCustomQty.Name = "colCustomQty";
            this.colCustomQty.Visible = true;
            this.colCustomQty.VisibleIndex = 8;
            // 
            // riQty
            // 
            this.riQty.AutoHeight = false;
            this.riQty.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.riQty.DisplayFormat.FormatString = "n4";
            this.riQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riQty.EditFormat.FormatString = "n4";
            this.riQty.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riQty.Mask.EditMask = "n4";
            this.riQty.MaxValue = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.riQty.Name = "riQty";
            // 
            // colBranchID
            // 
            this.colBranchID.FieldName = "BranchID";
            this.colBranchID.Name = "colBranchID";
            this.colBranchID.OptionsColumn.AllowEdit = false;
            // 
            // colNomenclatureID
            // 
            this.colNomenclatureID.FieldName = "NomenclatureID";
            this.colNomenclatureID.Name = "colNomenclatureID";
            this.colNomenclatureID.OptionsColumn.AllowEdit = false;
            // 
            // colCountryCode
            // 
            this.colCountryCode.FieldName = "CountryCode";
            this.colCountryCode.Name = "colCountryCode";
            this.colCountryCode.OptionsColumn.AllowEdit = false;
            // 
            // colBrandID
            // 
            this.colBrandID.FieldName = "BrandID";
            this.colBrandID.Name = "colBrandID";
            this.colBrandID.OptionsColumn.AllowEdit = false;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderDate.Location = new System.Drawing.Point(12, 9);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(65, 17);
            this.lblOrderDate.TabIndex = 0;
            this.lblOrderDate.Text = "თარიღი:";
            // 
            // dateOrderDate1
            // 
            this.dateOrderDate1.EditValue = null;
            this.dateOrderDate1.EnterMoveNextControl = true;
            this.dateOrderDate1.Location = new System.Drawing.Point(131, 6);
            this.dateOrderDate1.Name = "dateOrderDate1";
            this.dateOrderDate1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dateOrderDate1.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOrderDate1.Properties.Appearance.Options.UseFont = true;
            this.dateOrderDate1.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOrderDate1.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dateOrderDate1.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOrderDate1.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.dateOrderDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateOrderDate1.Properties.DisplayFormat.FormatString = "G";
            this.dateOrderDate1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateOrderDate1.Properties.EditFormat.FormatString = "G";
            this.dateOrderDate1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateOrderDate1.Properties.Mask.EditMask = "G";
            this.dateOrderDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateOrderDate1.Size = new System.Drawing.Size(150, 23);
            this.dateOrderDate1.TabIndex = 1;
            this.dateOrderDate1.EditValueChanged += new System.EventHandler(this.dateOrderDate1_EditValueChanged);
            // 
            // dateOrderDate2
            // 
            this.dateOrderDate2.EditValue = null;
            this.dateOrderDate2.EnterMoveNextControl = true;
            this.dateOrderDate2.Location = new System.Drawing.Point(287, 6);
            this.dateOrderDate2.Name = "dateOrderDate2";
            this.dateOrderDate2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dateOrderDate2.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOrderDate2.Properties.Appearance.Options.UseFont = true;
            this.dateOrderDate2.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOrderDate2.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dateOrderDate2.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOrderDate2.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.dateOrderDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateOrderDate2.Properties.DisplayFormat.FormatString = "G";
            this.dateOrderDate2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateOrderDate2.Properties.EditFormat.FormatString = "G";
            this.dateOrderDate2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateOrderDate2.Properties.Mask.EditMask = "G";
            this.dateOrderDate2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateOrderDate2.Size = new System.Drawing.Size(150, 23);
            this.dateOrderDate2.TabIndex = 2;
            this.dateOrderDate2.EditValueChanged += new System.EventHandler(this.dateOrderDate2_EditValueChanged);
            // 
            // lblBranch
            // 
            this.lblBranch.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBranch.Location = new System.Drawing.Point(12, 38);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(81, 17);
            this.lblBranch.TabIndex = 3;
            this.lblBranch.Text = "ფილიალი:";
            // 
            // bbBranch
            // 
            this.bbBranch.EnterMoveNextControl = true;
            this.bbBranch.IsOnline = true;
            this.bbBranch.Location = new System.Drawing.Point(131, 35);
            this.bbBranch.MenuManager = this.barManager;
            this.bbBranch.Name = "bbBranch";
            this.bbBranch.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F);
            this.bbBranch.Properties.Appearance.Options.UseFont = true;
            this.bbBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject3, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject4, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbBranch.Size = new System.Drawing.Size(306, 23);
            this.bbBranch.TabIndex = 4;
            this.bbBranch.TableName = Apothex.DataType.ObjectNames.Branch;
            // 
            // ds
            // 
            this.ds.DataSetName = "DS_SalesOrderDetailDefacture";
            this.ds.Locale = new System.Globalization.CultureInfo("");
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGenerateRequest
            // 
            this.btnGenerateRequest.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerateRequest.Appearance.Options.UseFont = true;
            this.btnGenerateRequest.Location = new System.Drawing.Point(609, 9);
            this.btnGenerateRequest.Name = "btnGenerateRequest";
            this.btnGenerateRequest.Size = new System.Drawing.Size(194, 33);
            this.btnGenerateRequest.TabIndex = 100;
            this.btnGenerateRequest.Text = "შეკვეთის გენერაცია";
            this.btnGenerateRequest.Click += new System.EventHandler(this.btnGenerateRequest_Click);
            // 
            // lblVendor
            // 
            this.lblVendor.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVendor.Location = new System.Drawing.Point(12, 67);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(113, 17);
            this.lblVendor.TabIndex = 5;
            this.lblVendor.Text = "მომწოდებელი:";
            // 
            // bbVendor
            // 
            this.bbVendor.EnterMoveNextControl = true;
            this.bbVendor.IsOnline = true;
            this.bbVendor.Location = new System.Drawing.Point(131, 64);
            this.bbVendor.Name = "bbVendor";
            this.bbVendor.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F);
            this.bbVendor.Properties.Appearance.Options.UseFont = true;
            this.bbVendor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject1, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject2, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbVendor.Size = new System.Drawing.Size(306, 23);
            this.bbVendor.TabIndex = 6;
            this.bbVendor.TableName = Apothex.DataType.ObjectNames.Company;
            // 
            // frmSalesOrderDetailDefectureBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsFiltered = true;
            this.IsFilterPanelVisible = true;
            this.Name = "frmSalesOrderDetailDefectureBrowse";
            this.ObjectName = Apothex.DataType.ObjectNames.SalesOrderDetailDefecture;
            this.OptionsBaseForm.Text = "დეფექტურა";
            this.OptionsListForm.IsAddable = false;
            this.OptionsListForm.IsApprovable = false;
            this.OptionsListForm.IsBlockable = false;
            this.OptionsListForm.IsDeletable = false;
            this.OptionsListForm.IsDisapprovable = false;
            this.OptionsListForm.IsEditable = false;
            this.OptionsListForm.IsSystemColumnsable = true;
            this.OptionsListForm.IsUnblockable = false;
            this.OptionsGrid.AutoInitStyleFormat = false;
            this.OptionsGrid.ColumnID = "NomenclatureID";
            this.OptionsGrid.GridView = this.view;
            this.Text = "დეფექტურა";
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
            ((System.ComponentModel.ISupportInitialize)(this.riQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbVendor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch;
        private DevExpress.XtraGrid.Columns.GridColumn colNomenclature;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleQty;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraEditors.LabelControl lblOrderDate;
        private DevExpress.XtraEditors.DateEdit dateOrderDate1;
        private DevExpress.XtraEditors.DateEdit dateOrderDate2;
        private Apothex.Windows.Forms.ButtonBrowse bbBranch;
        private DevExpress.XtraEditors.LabelControl lblBranch;
        private Apothex.DataType.DS_SalesOrderDetailDefacture ds;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchID;
        private DevExpress.XtraGrid.Columns.GridColumn col_AfterQty;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colNomenclatureID;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryCode;
        public DevExpress.XtraGrid.Views.Grid.GridView view;
        private DevExpress.XtraGrid.Columns.GridColumn colBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomQty;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit riQty;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandID;
        private DevExpress.XtraGrid.Columns.GridColumn colValidDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIsChoosed;
        private DevExpress.XtraEditors.SimpleButton btnGenerateRequest;
        private Windows.Forms.ButtonBrowse bbVendor;
        private DevExpress.XtraEditors.LabelControl lblVendor;
    }
}