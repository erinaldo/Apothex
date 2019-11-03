namespace Apothex.Production
{
    partial class frmWarehouseDescriptionEdit
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabMain = new DevExpress.XtraTab.XtraTabPage();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.bsGrid = new System.Windows.Forms.BindingSource();
            this.ds_WarehouseDescription = new Apothex.DataType.DS_WarehouseDescription();
            this.view = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.bandProduct = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colOrdinalNumber = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPurchaseOrderID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMedicamentName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCountryCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.riCountry = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsCountry = new System.Windows.Forms.BindingSource();
            this.colBrandID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.riBrand = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsBrand = new System.Windows.Forms.BindingSource();
            this.colUnitPrice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.riPrice = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.bandQty = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colQuantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDescrQty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.riQuantity = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.bandQtyString = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colQtyString = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.col_DescrQtyString = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandTotal = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colLineTotal = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDescrLineTotal = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandOther = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colComment = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.riComment = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.pnlTop = new DevExpress.XtraEditors.PanelControl();
            this.btnGenerate = new DevExpress.XtraEditors.SimpleButton();
            this.lookCurrency = new DevExpress.XtraEditors.LookUpEdit();
            this.bsCurrency = new System.Windows.Forms.BindingSource();
            this.lblCurrency = new DevExpress.XtraEditors.LabelControl();
            this.bbBranch = new Apothex.Windows.Forms.ButtonBrowse();
            this.lblBranch = new DevExpress.XtraEditors.LabelControl();
            this.txtWarehouseDescriptionID = new DevExpress.XtraEditors.TextEdit();
            this.lblWarehouseDescriptionID = new DevExpress.XtraEditors.LabelControl();
            this.dateDate = new DevExpress.XtraEditors.DateEdit();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.tabInfo = new DevExpress.XtraTab.XtraTabPage();
            this.bbCreator = new Apothex.Windows.Forms.ButtonBrowse();
            this.bbModifier = new Apothex.Windows.Forms.ButtonBrowse();
            this.bbApprover = new Apothex.Windows.Forms.ButtonBrowse();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblApprover = new DevExpress.XtraEditors.LabelControl();
            this.lblCreator = new DevExpress.XtraEditors.LabelControl();
            this.dateCreateDate = new DevExpress.XtraEditors.DateEdit();
            this.dateModifiedDate = new DevExpress.XtraEditors.DateEdit();
            this.lblCreateDate = new DevExpress.XtraEditors.LabelControl();
            this.lblModifier = new DevExpress.XtraEditors.LabelControl();
            this.lblModifiedDate = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_WarehouseDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWarehouseDescriptionID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbCreator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbModifier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbApprover.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCreateDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCreateDate.Properties)).BeginInit();
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
            this.tabMain.Controls.Add(this.grid);
            this.tabMain.Controls.Add(this.pnlTop);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(777, 496);
            this.tabMain.Text = "მთავარი";
            // 
            // grid
            // 
            this.grid.DataSource = this.bsGrid;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.grid_EmbeddedNavigator_ButtonClick);
            this.grid.Location = new System.Drawing.Point(0, 100);
            this.grid.MainView = this.view;
            this.grid.MenuManager = this.barManager;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riCountry,
            this.riBrand,
            this.riPrice,
            this.riQuantity,
            this.riComment});
            this.grid.Size = new System.Drawing.Size(777, 396);
            this.grid.TabIndex = 1;
            this.grid.UseEmbeddedNavigator = true;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view});
            // 
            // bsGrid
            // 
            this.bsGrid.DataMember = "SP_GetWarehouseDescriptionDetail";
            this.bsGrid.DataSource = this.ds_WarehouseDescription;
            // 
            // ds_WarehouseDescription
            // 
            this.ds_WarehouseDescription.DataSetName = "DS_WarehouseDescription";
            this.ds_WarehouseDescription.Locale = new System.Globalization.CultureInfo("");
            this.ds_WarehouseDescription.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view
            // 
            this.view.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.bandProduct,
            this.bandQty,
            this.bandQtyString,
            this.bandTotal,
            this.bandOther});
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colOrdinalNumber,
            this.colPurchaseOrderID,
            this.colOrderDate,
            this.colMedicamentName,
            this.colCountryCode,
            this.colBrandID,
            this.colUnitPrice,
            this.colQuantity,
            this.colDescrQty,
            this.colQtyString,
            this.col_DescrQtyString,
            this.colLineTotal,
            this.colDescrLineTotal,
            this.colComment});
            this.view.GridControl = this.grid;
            this.view.Name = "view";
            this.view.OptionsCustomization.AllowGroup = false;
            this.view.OptionsNavigation.EnterMoveNextColumn = true;
            this.view.OptionsSelection.MultiSelect = true;
            this.view.OptionsView.ShowFooter = true;
            this.view.OptionsView.ShowGroupPanel = false;
            this.view.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colOrdinalNumber, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.view.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.view_CellValueChanged);
            this.view.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.view_CustomUnboundColumnData);
            // 
            // bandProduct
            // 
            this.bandProduct.Caption = "პროდუქცია";
            this.bandProduct.Columns.Add(this.colOrdinalNumber);
            this.bandProduct.Columns.Add(this.colPurchaseOrderID);
            this.bandProduct.Columns.Add(this.colOrderDate);
            this.bandProduct.Columns.Add(this.colMedicamentName);
            this.bandProduct.Columns.Add(this.colCountryCode);
            this.bandProduct.Columns.Add(this.colBrandID);
            this.bandProduct.Columns.Add(this.colUnitPrice);
            this.bandProduct.Name = "bandProduct";
            this.bandProduct.Width = 525;
            // 
            // colOrdinalNumber
            // 
            this.colOrdinalNumber.Caption = "№";
            this.colOrdinalNumber.FieldName = "OrdinalNumber";
            this.colOrdinalNumber.Name = "colOrdinalNumber";
            this.colOrdinalNumber.OptionsColumn.AllowEdit = false;
            this.colOrdinalNumber.Visible = true;
            // 
            // colPurchaseOrderID
            // 
            this.colPurchaseOrderID.Caption = "ფაქტურის №";
            this.colPurchaseOrderID.FieldName = "PurchaseOrderID";
            this.colPurchaseOrderID.Name = "colPurchaseOrderID";
            this.colPurchaseOrderID.OptionsColumn.AllowEdit = false;
            this.colPurchaseOrderID.Visible = true;
            // 
            // colOrderDate
            // 
            this.colOrderDate.Caption = "ფაქტურის თარიღი";
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.OptionsColumn.AllowEdit = false;
            this.colOrderDate.Visible = true;
            // 
            // colMedicamentName
            // 
            this.colMedicamentName.Caption = "პროდუქცია";
            this.colMedicamentName.FieldName = "MedicamentName";
            this.colMedicamentName.Name = "colMedicamentName";
            this.colMedicamentName.OptionsColumn.AllowEdit = false;
            this.colMedicamentName.Visible = true;
            // 
            // colCountryCode
            // 
            this.colCountryCode.Caption = "მწ. ქვეყანა";
            this.colCountryCode.ColumnEdit = this.riCountry;
            this.colCountryCode.FieldName = "CountryCode";
            this.colCountryCode.Name = "colCountryCode";
            this.colCountryCode.Visible = true;
            // 
            // riCountry
            // 
            this.riCountry.AutoHeight = false;
            this.riCountry.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riCountry.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.riCountry.DataSource = this.bsCountry;
            this.riCountry.DisplayMember = "Caption";
            this.riCountry.Name = "riCountry";
            this.riCountry.NullText = "";
            this.riCountry.ShowHeader = false;
            this.riCountry.ValueMember = "ID";
            // 
            // colBrandID
            // 
            this.colBrandID.Caption = "ბრენდი";
            this.colBrandID.ColumnEdit = this.riBrand;
            this.colBrandID.FieldName = "BrandID";
            this.colBrandID.Name = "colBrandID";
            this.colBrandID.Visible = true;
            // 
            // riBrand
            // 
            this.riBrand.AutoHeight = false;
            this.riBrand.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riBrand.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.riBrand.DataSource = this.bsBrand;
            this.riBrand.DisplayMember = "Caption";
            this.riBrand.Name = "riBrand";
            this.riBrand.NullText = "";
            this.riBrand.ShowHeader = false;
            this.riBrand.ValueMember = "ID";
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "ფასი / შ.";
            this.colUnitPrice.ColumnEdit = this.riPrice;
            this.colUnitPrice.DisplayFormat.FormatString = "n4";
            this.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.GroupFormat.FormatString = "n2";
            this.colUnitPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            // 
            // riPrice
            // 
            this.riPrice.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.riPrice.AutoHeight = false;
            this.riPrice.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.riPrice.DisplayFormat.FormatString = "n4";
            this.riPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riPrice.EditFormat.FormatString = "n4";
            this.riPrice.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riPrice.Mask.EditMask = "n4";
            this.riPrice.MaxValue = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.riPrice.Name = "riPrice";
            // 
            // bandQty
            // 
            this.bandQty.Caption = "რაოდენობა";
            this.bandQty.Columns.Add(this.colQuantity);
            this.bandQty.Columns.Add(this.colDescrQty);
            this.bandQty.Name = "bandQty";
            this.bandQty.Width = 150;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "დოკუმ.";
            this.colQuantity.DisplayFormat.FormatString = "n4";
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.GroupFormat.FormatString = "n2";
            this.colQuantity.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.AllowEdit = false;
            this.colQuantity.SummaryItem.DisplayFormat = "{0:n2}";
            this.colQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuantity.Visible = true;
            // 
            // colDescrQty
            // 
            this.colDescrQty.Caption = "ფაქტ.";
            this.colDescrQty.ColumnEdit = this.riQuantity;
            this.colDescrQty.DisplayFormat.FormatString = "n4";
            this.colDescrQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDescrQty.FieldName = "DescrQty";
            this.colDescrQty.GroupFormat.FormatString = "n2";
            this.colDescrQty.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDescrQty.Name = "colDescrQty";
            this.colDescrQty.SummaryItem.DisplayFormat = "{0:n2}";
            this.colDescrQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDescrQty.Visible = true;
            // 
            // riQuantity
            // 
            this.riQuantity.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.riQuantity.AutoHeight = false;
            this.riQuantity.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.riQuantity.DisplayFormat.FormatString = "n4";
            this.riQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riQuantity.EditFormat.FormatString = "n4";
            this.riQuantity.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riQuantity.Mask.EditMask = "n4";
            this.riQuantity.MaxValue = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.riQuantity.Name = "riQuantity";
            // 
            // bandQtyString
            // 
            this.bandQtyString.Caption = "კალკ. რაოდენობა";
            this.bandQtyString.Columns.Add(this.colQtyString);
            this.bandQtyString.Columns.Add(this.col_DescrQtyString);
            this.bandQtyString.Name = "bandQtyString";
            this.bandQtyString.Width = 150;
            // 
            // colQtyString
            // 
            this.colQtyString.Caption = "დოკუმ.";
            this.colQtyString.FieldName = "colQtyString";
            this.colQtyString.Name = "colQtyString";
            this.colQtyString.OptionsColumn.AllowEdit = false;
            this.colQtyString.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colQtyString.Visible = true;
            // 
            // col_DescrQtyString
            // 
            this.col_DescrQtyString.Caption = "ფაქტ.";
            this.col_DescrQtyString.FieldName = "_DescrQtyString";
            this.col_DescrQtyString.Name = "col_DescrQtyString";
            this.col_DescrQtyString.Visible = true;
            // 
            // bandTotal
            // 
            this.bandTotal.Caption = "თანხა";
            this.bandTotal.Columns.Add(this.colLineTotal);
            this.bandTotal.Columns.Add(this.colDescrLineTotal);
            this.bandTotal.Name = "bandTotal";
            this.bandTotal.Width = 150;
            // 
            // colLineTotal
            // 
            this.colLineTotal.Caption = "დოკუმ.";
            this.colLineTotal.DisplayFormat.FormatString = "n4";
            this.colLineTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLineTotal.FieldName = "colLineTotal";
            this.colLineTotal.GroupFormat.FormatString = "n2";
            this.colLineTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLineTotal.Name = "colLineTotal";
            this.colLineTotal.OptionsColumn.AllowEdit = false;
            this.colLineTotal.SummaryItem.DisplayFormat = "{0:n2}";
            this.colLineTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colLineTotal.UnboundExpression = "[UnitPrice]*[Quantity]";
            this.colLineTotal.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colLineTotal.Visible = true;
            // 
            // colDescrLineTotal
            // 
            this.colDescrLineTotal.Caption = "ფაქტ.";
            this.colDescrLineTotal.DisplayFormat.FormatString = "n4";
            this.colDescrLineTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDescrLineTotal.FieldName = "colDescrLineTotal";
            this.colDescrLineTotal.GroupFormat.FormatString = "n2";
            this.colDescrLineTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDescrLineTotal.Name = "colDescrLineTotal";
            this.colDescrLineTotal.OptionsColumn.AllowEdit = false;
            this.colDescrLineTotal.SummaryItem.DisplayFormat = "{0:n2}";
            this.colDescrLineTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDescrLineTotal.UnboundExpression = "[UnitPrice]*[DescrQty]";
            this.colDescrLineTotal.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colDescrLineTotal.Visible = true;
            // 
            // bandOther
            // 
            this.bandOther.Columns.Add(this.colComment);
            this.bandOther.Name = "bandOther";
            this.bandOther.Width = 75;
            // 
            // colComment
            // 
            this.colComment.Caption = "კომენტარი";
            this.colComment.ColumnEdit = this.riComment;
            this.colComment.FieldName = "Comment";
            this.colComment.Name = "colComment";
            this.colComment.Visible = true;
            // 
            // riComment
            // 
            this.riComment.AutoHeight = false;
            this.riComment.MaxLength = 100;
            this.riComment.Name = "riComment";
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlTop.Controls.Add(this.btnGenerate);
            this.pnlTop.Controls.Add(this.lookCurrency);
            this.pnlTop.Controls.Add(this.lblCurrency);
            this.pnlTop.Controls.Add(this.bbBranch);
            this.pnlTop.Controls.Add(this.lblBranch);
            this.pnlTop.Controls.Add(this.txtWarehouseDescriptionID);
            this.pnlTop.Controls.Add(this.lblWarehouseDescriptionID);
            this.pnlTop.Controls.Add(this.dateDate);
            this.pnlTop.Controls.Add(this.lblDate);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(777, 100);
            this.pnlTop.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(673, 6);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(150, 52);
            this.btnGenerate.TabIndex = 19;
            this.btnGenerate.Text = " გენერაცია";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lookCurrency
            // 
            this.lookCurrency.EnterMoveNextControl = true;
            this.lookCurrency.Location = new System.Drawing.Point(367, 35);
            this.lookCurrency.Name = "lookCurrency";
            this.lookCurrency.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.lookCurrency.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookCurrency.Properties.Appearance.Options.UseFont = true;
            this.lookCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookCurrency.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", 100, "Caption"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 75, DevExpress.Utils.FormatType.None, "n4", true, DevExpress.Utils.HorzAlignment.Default)});
            this.lookCurrency.Properties.DataSource = this.bsCurrency;
            this.lookCurrency.Properties.DisplayMember = "Caption";
            this.lookCurrency.Properties.NullText = "";
            this.lookCurrency.Properties.ReadOnly = true;
            this.lookCurrency.Properties.ShowHeader = false;
            this.lookCurrency.Properties.ValueMember = "ID";
            this.lookCurrency.Size = new System.Drawing.Size(300, 23);
            this.lookCurrency.TabIndex = 18;
            // 
            // lblCurrency
            // 
            this.lblCurrency.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrency.Appearance.Options.UseFont = true;
            this.lblCurrency.Location = new System.Drawing.Point(280, 38);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(63, 17);
            this.lblCurrency.TabIndex = 17;
            this.lblCurrency.Text = "ვალუტა:";
            // 
            // bbBranch
            // 
            this.bbBranch.EnterMoveNextControl = true;
            this.bbBranch.IsOnline = true;
            this.bbBranch.Location = new System.Drawing.Point(367, 6);
            this.bbBranch.MenuManager = this.barManager;
            this.bbBranch.Name = "bbBranch";
            this.bbBranch.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F);
            this.bbBranch.Properties.Appearance.Options.UseFont = true;
            this.bbBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject3, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject4, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbBranch.Size = new System.Drawing.Size(300, 23);
            this.bbBranch.TabIndex = 5;
            this.bbBranch.TableName = Apothex.DataType.ObjectNames.Branch;
            // 
            // lblBranch
            // 
            this.lblBranch.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBranch.Appearance.Options.UseFont = true;
            this.lblBranch.Location = new System.Drawing.Point(280, 9);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(81, 17);
            this.lblBranch.TabIndex = 4;
            this.lblBranch.Text = "ფილიალი:";
            // 
            // txtWarehouseDescriptionID
            // 
            this.txtWarehouseDescriptionID.EnterMoveNextControl = true;
            this.txtWarehouseDescriptionID.Location = new System.Drawing.Point(84, 6);
            this.txtWarehouseDescriptionID.Name = "txtWarehouseDescriptionID";
            this.txtWarehouseDescriptionID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWarehouseDescriptionID.Properties.Appearance.Options.UseFont = true;
            this.txtWarehouseDescriptionID.Properties.ReadOnly = true;
            this.txtWarehouseDescriptionID.Size = new System.Drawing.Size(150, 23);
            this.txtWarehouseDescriptionID.TabIndex = 1;
            // 
            // lblWarehouseDescriptionID
            // 
            this.lblWarehouseDescriptionID.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWarehouseDescriptionID.Appearance.Options.UseFont = true;
            this.lblWarehouseDescriptionID.Location = new System.Drawing.Point(10, 9);
            this.lblWarehouseDescriptionID.Name = "lblWarehouseDescriptionID";
            this.lblWarehouseDescriptionID.Size = new System.Drawing.Size(20, 17);
            this.lblWarehouseDescriptionID.TabIndex = 0;
            this.lblWarehouseDescriptionID.Text = "№:";
            // 
            // dateDate
            // 
            this.dateDate.EditValue = null;
            this.dateDate.Location = new System.Drawing.Point(84, 35);
            this.dateDate.MenuManager = this.barManager;
            this.dateDate.Name = "dateDate";
            this.dateDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateDate.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateDate.Properties.Appearance.Options.UseFont = true;
            this.dateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDate.Properties.DisplayFormat.FormatString = "G";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateDate.Properties.EditFormat.FormatString = "G";
            this.dateDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateDate.Properties.Mask.EditMask = "G";
            this.dateDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateDate.Size = new System.Drawing.Size(150, 23);
            this.dateDate.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.Appearance.Options.UseFont = true;
            this.lblDate.Location = new System.Drawing.Point(6, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(65, 17);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "თარიღი:";
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.bbCreator);
            this.tabInfo.Controls.Add(this.bbModifier);
            this.tabInfo.Controls.Add(this.bbApprover);
            this.tabInfo.Controls.Add(this.txtID);
            this.tabInfo.Controls.Add(this.lblApprover);
            this.tabInfo.Controls.Add(this.lblCreator);
            this.tabInfo.Controls.Add(this.dateCreateDate);
            this.tabInfo.Controls.Add(this.dateModifiedDate);
            this.tabInfo.Controls.Add(this.lblCreateDate);
            this.tabInfo.Controls.Add(this.lblModifier);
            this.tabInfo.Controls.Add(this.lblModifiedDate);
            this.tabInfo.Controls.Add(this.lblID);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Size = new System.Drawing.Size(1001, 664);
            this.tabInfo.Text = "ინფორმაცია";
            // 
            // bbCreator
            // 
            this.bbCreator.EnterMoveNextControl = true;
            this.bbCreator.IsOnline = true;
            this.bbCreator.Location = new System.Drawing.Point(149, 64);
            this.bbCreator.Name = "bbCreator";
            this.bbCreator.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F);
            this.bbCreator.Properties.Appearance.Options.UseFont = true;
            this.bbCreator.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject5, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject6, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbCreator.Properties.ReadOnly = true;
            this.bbCreator.Size = new System.Drawing.Size(300, 23);
            this.bbCreator.TabIndex = 5;
            this.bbCreator.TableName = Apothex.DataType.ObjectNames.User;
            // 
            // bbModifier
            // 
            this.bbModifier.EnterMoveNextControl = true;
            this.bbModifier.IsOnline = true;
            this.bbModifier.Location = new System.Drawing.Point(149, 122);
            this.bbModifier.Name = "bbModifier";
            this.bbModifier.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F);
            this.bbModifier.Properties.Appearance.Options.UseFont = true;
            this.bbModifier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject7, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject8, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbModifier.Properties.ReadOnly = true;
            this.bbModifier.Size = new System.Drawing.Size(300, 23);
            this.bbModifier.TabIndex = 9;
            this.bbModifier.TableName = Apothex.DataType.ObjectNames.User;
            // 
            // bbApprover
            // 
            this.bbApprover.EnterMoveNextControl = true;
            this.bbApprover.IsOnline = true;
            this.bbApprover.Location = new System.Drawing.Point(149, 151);
            this.bbApprover.MenuManager = this.barManager;
            this.bbApprover.Name = "bbApprover";
            this.bbApprover.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F);
            this.bbApprover.Properties.Appearance.Options.UseFont = true;
            this.bbApprover.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject9, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject10, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbApprover.Properties.ReadOnly = true;
            this.bbApprover.Size = new System.Drawing.Size(300, 23);
            this.bbApprover.TabIndex = 11;
            this.bbApprover.TableName = Apothex.DataType.ObjectNames.User;
            // 
            // txtID
            // 
            this.txtID.EnterMoveNextControl = true;
            this.txtID.Location = new System.Drawing.Point(149, 6);
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
            this.lblApprover.Location = new System.Drawing.Point(6, 154);
            this.lblApprover.Name = "lblApprover";
            this.lblApprover.Size = new System.Drawing.Size(77, 17);
            this.lblApprover.TabIndex = 10;
            this.lblApprover.Text = "დაამოწმა:";
            // 
            // lblCreator
            // 
            this.lblCreator.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreator.Appearance.Options.UseFont = true;
            this.lblCreator.Location = new System.Drawing.Point(6, 67);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(53, 17);
            this.lblCreator.TabIndex = 4;
            this.lblCreator.Text = "შექმნა:";
            // 
            // dateCreateDate
            // 
            this.dateCreateDate.EditValue = null;
            this.dateCreateDate.EnterMoveNextControl = true;
            this.dateCreateDate.Location = new System.Drawing.Point(149, 35);
            this.dateCreateDate.Name = "dateCreateDate";
            this.dateCreateDate.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateCreateDate.Properties.Appearance.Options.UseFont = true;
            this.dateCreateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateCreateDate.Properties.DisplayFormat.FormatString = "G";
            this.dateCreateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateCreateDate.Properties.EditFormat.FormatString = "G";
            this.dateCreateDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateCreateDate.Properties.Mask.EditMask = "G";
            this.dateCreateDate.Properties.ReadOnly = true;
            this.dateCreateDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateCreateDate.Size = new System.Drawing.Size(150, 23);
            this.dateCreateDate.TabIndex = 3;
            // 
            // dateModifiedDate
            // 
            this.dateModifiedDate.EditValue = null;
            this.dateModifiedDate.EnterMoveNextControl = true;
            this.dateModifiedDate.Location = new System.Drawing.Point(149, 93);
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
            this.dateModifiedDate.TabIndex = 7;
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreateDate.Appearance.Options.UseFont = true;
            this.lblCreateDate.Location = new System.Drawing.Point(6, 38);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(126, 17);
            this.lblCreateDate.TabIndex = 2;
            this.lblCreateDate.Text = "შექმნის თარიღი:";
            // 
            // lblModifier
            // 
            this.lblModifier.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblModifier.Appearance.Options.UseFont = true;
            this.lblModifier.Location = new System.Drawing.Point(6, 125);
            this.lblModifier.Name = "lblModifier";
            this.lblModifier.Size = new System.Drawing.Size(70, 17);
            this.lblModifier.TabIndex = 8;
            this.lblModifier.Text = "შეცვალა:";
            // 
            // lblModifiedDate
            // 
            this.lblModifiedDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblModifiedDate.Appearance.Options.UseFont = true;
            this.lblModifiedDate.Location = new System.Drawing.Point(6, 96);
            this.lblModifiedDate.Name = "lblModifiedDate";
            this.lblModifiedDate.Size = new System.Drawing.Size(135, 17);
            this.lblModifiedDate.TabIndex = 6;
            this.lblModifiedDate.Text = "შეცვლის თარიღი:";
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
            // frmWarehouseDescriptionEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.xtraTabControl);
            this.Name = "frmWarehouseDescriptionEdit";
            this.ObjectName = Apothex.DataType.ObjectNames.WarehouseDescriprion;
            this.OptionsBaseForm.IsPrintable = true;
            this.Text = "საწყობის აღწერა";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmWarehouseDescriptionEdit_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmWarehouseDescriptionEdit_KeyDown);
            this.Controls.SetChildIndex(this.xtraTabControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_WarehouseDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWarehouseDescriptionID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).EndInit();
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbCreator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbModifier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbApprover.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCreateDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCreateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifiedDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifiedDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage tabMain;
        private DevExpress.XtraTab.XtraTabPage tabInfo;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblApprover;
        private DevExpress.XtraEditors.LabelControl lblCreator;
        private DevExpress.XtraEditors.DateEdit dateCreateDate;
        private DevExpress.XtraEditors.DateEdit dateModifiedDate;
        private DevExpress.XtraEditors.LabelControl lblCreateDate;
        private DevExpress.XtraEditors.LabelControl lblModifier;
        private DevExpress.XtraEditors.LabelControl lblModifiedDate;
        private DevExpress.XtraEditors.LabelControl lblID;
        private Windows.Forms.ButtonBrowse bbCreator;
        private Windows.Forms.ButtonBrowse bbModifier;
        private Windows.Forms.ButtonBrowse bbApprover;
        private DevExpress.XtraEditors.PanelControl pnlTop;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraEditors.DateEdit dateDate;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.TextEdit txtWarehouseDescriptionID;
        private DevExpress.XtraEditors.LabelControl lblWarehouseDescriptionID;
        private Windows.Forms.ButtonBrowse bbBranch;
        private DevExpress.XtraEditors.LabelControl lblBranch;
        private DataType.DS_WarehouseDescription ds_WarehouseDescription;
        private System.Windows.Forms.BindingSource bsGrid;
        private System.Windows.Forms.BindingSource bsCurrency;
        private DevExpress.XtraEditors.LookUpEdit lookCurrency;
        private DevExpress.XtraEditors.LabelControl lblCurrency;
        private DevExpress.XtraEditors.SimpleButton btnGenerate;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riCountry;
        private System.Windows.Forms.BindingSource bsCountry;
        private System.Windows.Forms.BindingSource bsBrand;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riBrand;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit riPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit riQuantity;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOrdinalNumber;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMedicamentName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCountryCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colBrandID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnitPrice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colQuantity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDescrQty;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPurchaseOrderID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOrderDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLineTotal;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDescrLineTotal;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colQtyString;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col_DescrQtyString;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandProduct;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandQty;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandQtyString;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandTotal;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandOther;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colComment;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riComment;
    }
}