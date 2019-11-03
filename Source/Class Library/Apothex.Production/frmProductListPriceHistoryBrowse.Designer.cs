namespace Apothex.Production
{
    partial class frmProductListPriceHistoryBrowse
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
            this.colVendorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicamentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colListPriceCurrency1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colListPriceCurrency2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_LineTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_LineTotal2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colListPrice1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colListPrice2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateStartDate2 = new DevExpress.XtraEditors.DateEdit();
            this.dateStartDate1 = new DevExpress.XtraEditors.DateEdit();
            this.cboxStartDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblStartDate = new DevExpress.XtraEditors.LabelControl();
            this.ds = new Apothex.DataType.DS_ProductListPriceHistory();
            this.bsCurrency = new System.Windows.Forms.BindingSource();
            this.lookCurrency = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCurrency = new DevExpress.XtraEditors.LabelControl();
            this.cboxVendorID = new DevExpress.XtraEditors.ComboBoxEdit();
            this.bbVendorID = new Apothex.Windows.Forms.ButtonBrowse();
            this.cboxVendorName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtVendorName = new DevExpress.XtraEditors.TextEdit();
            this.lblVendorID = new DevExpress.XtraEditors.LabelControl();
            this.lblVendorName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxVendorID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbVendorID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxVendorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVendorName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.cboxVendorID);
            this.pnlFilter.Controls.Add(this.bbVendorID);
            this.pnlFilter.Controls.Add(this.cboxVendorName);
            this.pnlFilter.Controls.Add(this.txtVendorName);
            this.pnlFilter.Controls.Add(this.lblVendorID);
            this.pnlFilter.Controls.Add(this.lblVendorName);
            this.pnlFilter.Controls.Add(this.lookCurrency);
            this.pnlFilter.Controls.Add(this.lblCurrency);
            this.pnlFilter.Controls.Add(this.dateStartDate2);
            this.pnlFilter.Controls.Add(this.dateStartDate1);
            this.pnlFilter.Controls.Add(this.cboxStartDate);
            this.pnlFilter.Controls.Add(this.lblStartDate);
            this.pnlFilter.Size = new System.Drawing.Size(784, 143);
            this.pnlFilter.Controls.SetChildIndex(this.btnFilter, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblStartDate, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxStartDate, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateStartDate1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateStartDate2, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblCurrency, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lookCurrency, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblVendorName, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblVendorID, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtVendorName, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxVendorName, 0);
            this.pnlFilter.Controls.SetChildIndex(this.bbVendorID, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxVendorID, 0);
            // 
            // bsGridControl
            // 
            this.bsGridControl.DataMember = "FN_GetProductListPriceHistory";
            this.bsGridControl.DataSource = this.ds;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.grid);
            this.pnlGrid.Location = new System.Drawing.Point(0, 177);
            this.pnlGrid.Size = new System.Drawing.Size(784, 385);
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
            // grid
            // 
            this.grid.DataSource = this.bsGridControl;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.view;
            this.grid.MenuManager = this.barManager;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(784, 385);
            this.grid.TabIndex = 0;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view});
            // 
            // view
            // 
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBranchName,
            this.colVendorName,
            this.colMedicamentName,
            this.colCountryName,
            this.colBrandName,
            this.colStartDate,
            this.colEndDate,
            this.colQuantity,
            this.colListPriceCurrency1,
            this.colListPriceCurrency2,
            this.col_LineTotal,
            this.col_LineTotal2,
            this.colListPrice1,
            this.colListPrice2});
            this.view.GridControl = this.grid;
            this.view.Name = "view";
            // 
            // colBranchName
            // 
            this.colBranchName.Caption = "ფილიალი";
            this.colBranchName.FieldName = "BranchName";
            this.colBranchName.Name = "colBranchName";
            this.colBranchName.Visible = true;
            this.colBranchName.VisibleIndex = 0;
            // 
            // colVendorName
            // 
            this.colVendorName.Caption = "მომწოდებელი";
            this.colVendorName.FieldName = "VendorName";
            this.colVendorName.Name = "colVendorName";
            this.colVendorName.Visible = true;
            this.colVendorName.VisibleIndex = 1;
            // 
            // colMedicamentName
            // 
            this.colMedicamentName.Caption = "პროდუქცია";
            this.colMedicamentName.FieldName = "MedicamentName";
            this.colMedicamentName.Name = "colMedicamentName";
            this.colMedicamentName.Visible = true;
            this.colMedicamentName.VisibleIndex = 2;
            // 
            // colCountryName
            // 
            this.colCountryName.Caption = "მწ. ქვეყანა";
            this.colCountryName.FieldName = "CountryName";
            this.colCountryName.Name = "colCountryName";
            this.colCountryName.Visible = true;
            this.colCountryName.VisibleIndex = 3;
            // 
            // colBrandName
            // 
            this.colBrandName.Caption = "ბრენდი";
            this.colBrandName.FieldName = "BrandName";
            this.colBrandName.Name = "colBrandName";
            this.colBrandName.Visible = true;
            this.colBrandName.VisibleIndex = 4;
            // 
            // colStartDate
            // 
            this.colStartDate.Caption = "დაიწყო";
            this.colStartDate.DisplayFormat.FormatString = "G";
            this.colStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.GroupFormat.FormatString = "d";
            this.colStartDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 5;
            // 
            // colEndDate
            // 
            this.colEndDate.Caption = "დასრულდა";
            this.colEndDate.DisplayFormat.FormatString = "G";
            this.colEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.GroupFormat.FormatString = "d";
            this.colEndDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 6;
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
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 7;
            // 
            // colListPriceCurrency1
            // 
            this.colListPriceCurrency1.Caption = "ფასი / მდე";
            this.colListPriceCurrency1.DisplayFormat.FormatString = "n2";
            this.colListPriceCurrency1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colListPriceCurrency1.FieldName = "ListPriceCurrency1";
            this.colListPriceCurrency1.GroupFormat.FormatString = "n4";
            this.colListPriceCurrency1.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colListPriceCurrency1.Name = "colListPriceCurrency1";
            this.colListPriceCurrency1.Visible = true;
            this.colListPriceCurrency1.VisibleIndex = 8;
            // 
            // colListPriceCurrency2
            // 
            this.colListPriceCurrency2.Caption = "ფასი / შემდ.";
            this.colListPriceCurrency2.DisplayFormat.FormatString = "n2";
            this.colListPriceCurrency2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colListPriceCurrency2.FieldName = "ListPriceCurrency2";
            this.colListPriceCurrency2.GroupFormat.FormatString = "n4";
            this.colListPriceCurrency2.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colListPriceCurrency2.Name = "colListPriceCurrency2";
            this.colListPriceCurrency2.Visible = true;
            this.colListPriceCurrency2.VisibleIndex = 9;
            // 
            // col_LineTotal
            // 
            this.col_LineTotal.AppearanceCell.BackColor = System.Drawing.Color.Cornsilk;
            this.col_LineTotal.AppearanceCell.Options.UseBackColor = true;
            this.col_LineTotal.Caption = "თანხა / მდე.";
            this.col_LineTotal.DisplayFormat.FormatString = "n4";
            this.col_LineTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_LineTotal.FieldName = "col_LineTotal1";
            this.col_LineTotal.GroupFormat.FormatString = "n2";
            this.col_LineTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_LineTotal.Name = "col_LineTotal";
            this.col_LineTotal.SummaryItem.DisplayFormat = "{0:n2}";
            this.col_LineTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.col_LineTotal.UnboundExpression = "[Quantity] * [ListPriceCurrency1]";
            this.col_LineTotal.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col_LineTotal.Visible = true;
            this.col_LineTotal.VisibleIndex = 10;
            // 
            // col_LineTotal2
            // 
            this.col_LineTotal2.AppearanceCell.BackColor = System.Drawing.Color.Cornsilk;
            this.col_LineTotal2.AppearanceCell.Options.UseBackColor = true;
            this.col_LineTotal2.Caption = "თანხა / შემდ.";
            this.col_LineTotal2.DisplayFormat.FormatString = "n4";
            this.col_LineTotal2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_LineTotal2.FieldName = "col_LineTotal2";
            this.col_LineTotal2.GroupFormat.FormatString = "n2";
            this.col_LineTotal2.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_LineTotal2.Name = "col_LineTotal2";
            this.col_LineTotal2.SummaryItem.DisplayFormat = "{0:n2}";
            this.col_LineTotal2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.col_LineTotal2.UnboundExpression = "[Quantity] * [ListPriceCurrency2]";
            this.col_LineTotal2.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col_LineTotal2.Visible = true;
            this.col_LineTotal2.VisibleIndex = 11;
            // 
            // colListPrice1
            // 
            this.colListPrice1.Caption = "ფასი / მდე / პ.ე.";
            this.colListPrice1.DisplayFormat.FormatString = "n4";
            this.colListPrice1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colListPrice1.FieldName = "ListPrice1";
            this.colListPrice1.GroupFormat.FormatString = "n2";
            this.colListPrice1.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colListPrice1.Name = "colListPrice1";
            this.colListPrice1.Visible = true;
            this.colListPrice1.VisibleIndex = 12;
            // 
            // colListPrice2
            // 
            this.colListPrice2.Caption = "ფასი / შემდ. / პ.ე.";
            this.colListPrice2.DisplayFormat.FormatString = "n4";
            this.colListPrice2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colListPrice2.FieldName = "ListPrice2";
            this.colListPrice2.GroupFormat.FormatString = "n2";
            this.colListPrice2.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colListPrice2.Name = "colListPrice2";
            this.colListPrice2.Visible = true;
            this.colListPrice2.VisibleIndex = 13;
            // 
            // dateStartDate2
            // 
            this.dateStartDate2.EditValue = null;
            this.dateStartDate2.Enabled = false;
            this.dateStartDate2.EnterMoveNextControl = true;
            this.dateStartDate2.Location = new System.Drawing.Point(400, 6);
            this.dateStartDate2.Name = "dateStartDate2";
            this.dateStartDate2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dateStartDate2.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateStartDate2.Properties.Appearance.Options.UseFont = true;
            this.dateStartDate2.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateStartDate2.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dateStartDate2.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateStartDate2.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.dateStartDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStartDate2.Properties.DisplayFormat.FormatString = "G";
            this.dateStartDate2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStartDate2.Properties.EditFormat.FormatString = "G";
            this.dateStartDate2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStartDate2.Properties.Mask.EditMask = "G";
            this.dateStartDate2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateStartDate2.Size = new System.Drawing.Size(150, 23);
            this.dateStartDate2.TabIndex = 3;
            // 
            // dateStartDate1
            // 
            this.dateStartDate1.EditValue = null;
            this.dateStartDate1.Enabled = false;
            this.dateStartDate1.EnterMoveNextControl = true;
            this.dateStartDate1.Location = new System.Drawing.Point(244, 6);
            this.dateStartDate1.Name = "dateStartDate1";
            this.dateStartDate1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dateStartDate1.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateStartDate1.Properties.Appearance.Options.UseFont = true;
            this.dateStartDate1.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateStartDate1.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dateStartDate1.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateStartDate1.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.dateStartDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStartDate1.Properties.DisplayFormat.FormatString = "G";
            this.dateStartDate1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStartDate1.Properties.EditFormat.FormatString = "G";
            this.dateStartDate1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStartDate1.Properties.Mask.EditMask = "G";
            this.dateStartDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateStartDate1.Size = new System.Drawing.Size(150, 23);
            this.dateStartDate1.TabIndex = 2;
            // 
            // cboxStartDate
            // 
            this.cboxStartDate.EnterMoveNextControl = true;
            this.cboxStartDate.Location = new System.Drawing.Point(158, 6);
            this.cboxStartDate.Name = "cboxStartDate";
            this.cboxStartDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxStartDate.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxStartDate.Properties.Appearance.Options.UseFont = true;
            this.cboxStartDate.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxStartDate.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxStartDate.Properties.Items.AddRange(new object[] {
            "",
            "=",
            ">",
            "<",
            "[ ]"});
            this.cboxStartDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxStartDate.Size = new System.Drawing.Size(80, 23);
            this.cboxStartDate.TabIndex = 1;
            this.cboxStartDate.SelectedIndexChanged += new System.EventHandler(this.cboxStartDate_SelectedIndexChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStartDate.Appearance.Options.UseFont = true;
            this.lblStartDate.Location = new System.Drawing.Point(12, 9);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(65, 17);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "თარიღი:";
            // 
            // ds
            // 
            this.ds.DataSetName = "DS_ProductListPriceHistory";
            this.ds.Locale = new System.Globalization.CultureInfo("");
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lookCurrency
            // 
            this.lookCurrency.EnterMoveNextControl = true;
            this.lookCurrency.Location = new System.Drawing.Point(158, 35);
            this.lookCurrency.Name = "lookCurrency";
            this.lookCurrency.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.lookCurrency.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookCurrency.Properties.Appearance.Options.UseFont = true;
            this.lookCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookCurrency.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 75, DevExpress.Utils.FormatType.None, "n4", true, DevExpress.Utils.HorzAlignment.Default)});
            this.lookCurrency.Properties.DataSource = this.bsCurrency;
            this.lookCurrency.Properties.DisplayMember = "Caption";
            this.lookCurrency.Properties.NullText = "";
            this.lookCurrency.Properties.ShowHeader = false;
            this.lookCurrency.Properties.ValueMember = "ID";
            this.lookCurrency.Size = new System.Drawing.Size(392, 23);
            this.lookCurrency.TabIndex = 5;
            // 
            // lblCurrency
            // 
            this.lblCurrency.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrency.Appearance.Options.UseFont = true;
            this.lblCurrency.Location = new System.Drawing.Point(12, 38);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(140, 17);
            this.lblCurrency.TabIndex = 4;
            this.lblCurrency.Text = "ვალუტაში ჩვენება:";
            // 
            // cboxVendorID
            // 
            this.cboxVendorID.EditValue = "=";
            this.cboxVendorID.EnterMoveNextControl = true;
            this.cboxVendorID.Location = new System.Drawing.Point(158, 64);
            this.cboxVendorID.Name = "cboxVendorID";
            this.cboxVendorID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxVendorID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxVendorID.Properties.Appearance.Options.UseFont = true;
            this.cboxVendorID.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxVendorID.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxVendorID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxVendorID.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!="});
            this.cboxVendorID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxVendorID.Size = new System.Drawing.Size(75, 23);
            this.cboxVendorID.TabIndex = 101;
            this.cboxVendorID.SelectedIndexChanged += new System.EventHandler(this.cboxVendorID_SelectedIndexChanged);
            // 
            // bbVendorID
            // 
            this.bbVendorID.EnterMoveNextControl = true;
            this.bbVendorID.IsOnline = true;
            this.bbVendorID.Location = new System.Drawing.Point(239, 64);
            this.bbVendorID.MenuManager = this.barManager;
            this.bbVendorID.Name = "bbVendorID";
            this.bbVendorID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bbVendorID.Properties.Appearance.Options.UseFont = true;
            this.bbVendorID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject1, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject2, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbVendorID.Size = new System.Drawing.Size(311, 23);
            this.bbVendorID.TabIndex = 102;
            this.bbVendorID.TableName = Apothex.DataType.ObjectNames.Company;
            // 
            // cboxVendorName
            // 
            this.cboxVendorName.EditValue = "%a%";
            this.cboxVendorName.EnterMoveNextControl = true;
            this.cboxVendorName.Location = new System.Drawing.Point(158, 94);
            this.cboxVendorName.Name = "cboxVendorName";
            this.cboxVendorName.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxVendorName.Properties.Appearance.Options.UseFont = true;
            this.cboxVendorName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxVendorName.Properties.Items.AddRange(new object[] {
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
            this.cboxVendorName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxVendorName.Size = new System.Drawing.Size(75, 23);
            this.cboxVendorName.TabIndex = 104;
            this.cboxVendorName.SelectedIndexChanged += new System.EventHandler(this.cboxVendorName_SelectedIndexChanged);
            // 
            // txtVendorName
            // 
            this.txtVendorName.EnterMoveNextControl = true;
            this.txtVendorName.Location = new System.Drawing.Point(239, 94);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtVendorName.Properties.Appearance.Options.UseFont = true;
            this.txtVendorName.Size = new System.Drawing.Size(311, 23);
            this.txtVendorName.TabIndex = 105;
            // 
            // lblVendorID
            // 
            this.lblVendorID.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVendorID.Appearance.Options.UseFont = true;
            this.lblVendorID.Location = new System.Drawing.Point(12, 67);
            this.lblVendorID.Name = "lblVendorID";
            this.lblVendorID.Size = new System.Drawing.Size(113, 17);
            this.lblVendorID.TabIndex = 100;
            this.lblVendorID.Text = "მომწოდებელი:";
            // 
            // lblVendorName
            // 
            this.lblVendorName.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVendorName.Appearance.Options.UseFont = true;
            this.lblVendorName.Location = new System.Drawing.Point(12, 97);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(113, 17);
            this.lblVendorName.TabIndex = 103;
            this.lblVendorName.Text = "მომწოდებელი:";
            // 
            // frmProductListPriceHistoryBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsFilterPanelVisible = true;
            this.Name = "frmProductListPriceHistoryBrowse";
            this.ObjectName = Apothex.DataType.ObjectNames.ProductListPriceHistory;
            this.OptionsListForm.IsAddable = false;
            this.OptionsListForm.IsApprovable = false;
            this.OptionsListForm.IsBlockable = false;
            this.OptionsListForm.IsChooseable = false;
            this.OptionsListForm.IsDeletable = false;
            this.OptionsListForm.IsDisapprovable = false;
            this.OptionsListForm.IsFilterApprovable = false;
            this.OptionsListForm.IsSystemColumnsable = true;
            this.OptionsListForm.IsUnblockable = false;
            this.OptionsGrid.GridView = this.view;
            this.Text = "გადაფასების აქტი";
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
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxVendorID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbVendorID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxVendorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVendorName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView view;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentName;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryName;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandName;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colListPrice1;
        private DevExpress.XtraGrid.Columns.GridColumn colListPrice2;
        private DevExpress.XtraEditors.DateEdit dateStartDate2;
        private DevExpress.XtraEditors.DateEdit dateStartDate1;
        private DevExpress.XtraEditors.ComboBoxEdit cboxStartDate;
        private DevExpress.XtraEditors.LabelControl lblStartDate;
        private DataType.DS_ProductListPriceHistory ds;
        private DevExpress.XtraGrid.Columns.GridColumn colListPriceCurrency1;
        private DevExpress.XtraGrid.Columns.GridColumn colListPriceCurrency2;
        private System.Windows.Forms.BindingSource bsCurrency;
        private DevExpress.XtraEditors.LookUpEdit lookCurrency;
        private DevExpress.XtraEditors.LabelControl lblCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn col_LineTotal;
        private DevExpress.XtraGrid.Columns.GridColumn col_LineTotal2;
        private DevExpress.XtraGrid.Columns.GridColumn colVendorName;
        private DevExpress.XtraEditors.ComboBoxEdit cboxVendorID;
        private Windows.Forms.ButtonBrowse bbVendorID;
        private DevExpress.XtraEditors.ComboBoxEdit cboxVendorName;
        private DevExpress.XtraEditors.TextEdit txtVendorName;
        private DevExpress.XtraEditors.LabelControl lblVendorID;
        private DevExpress.XtraEditors.LabelControl lblVendorName;
    }
}