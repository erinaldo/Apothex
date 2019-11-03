namespace Apothex.Production
{
    partial class frmProductBrowse
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
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.view = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPurchaseOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVendorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicamentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicamentCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicamentSubcategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenericName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitsInStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValidDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMakeFlag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinishedGoodsFlag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSafetyStockLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReorderPoint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_UnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ListPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_DealerPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_DiscountPct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col__PricePct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NewListPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riPrice = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.col_NewDealerPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNewDiscountPct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riPct = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSizeRange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSizeUnitMeasureCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeightUnitMeasureCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaysToManufacture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStyle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscontinuedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVendorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseOrderDetailID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicamentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicamentCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicamentSubcategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenericID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ds = new Apothex.DataType.DS_Product();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabMain = new DevExpress.XtraTab.XtraTabPage();
            this.dateOrderDate2 = new DevExpress.XtraEditors.DateEdit();
            this.dateOrderDate1 = new DevExpress.XtraEditors.DateEdit();
            this.cboxOrderDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblStartDate = new DevExpress.XtraEditors.LabelControl();
            this.cboxBranch = new DevExpress.XtraEditors.ComboBoxEdit();
            this.bbBranch = new Apothex.Windows.Forms.ButtonBrowse();
            this.lblBranch = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalQty = new DevExpress.XtraEditors.LabelControl();
            this.cboxTotalQty = new DevExpress.XtraEditors.ComboBoxEdit();
            this.spinTotalQty1 = new DevExpress.XtraEditors.SpinEdit();
            this.spinTotalQty2 = new DevExpress.XtraEditors.SpinEdit();
            this.cboxMedicament = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblValidDate = new DevExpress.XtraEditors.LabelControl();
            this.cboxValidDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateValidDate1 = new DevExpress.XtraEditors.DateEdit();
            this.dateValidDate2 = new DevExpress.XtraEditors.DateEdit();
            this.lblMedicament = new DevExpress.XtraEditors.LabelControl();
            this.txtMedicament = new DevExpress.XtraEditors.TextEdit();
            this.lookCurrency = new DevExpress.XtraEditors.LookUpEdit();
            this.bsCurrency = new System.Windows.Forms.BindingSource();
            this.lblCurrency = new DevExpress.XtraEditors.LabelControl();
            this.tabAdditional = new DevExpress.XtraTab.XtraTabPage();
            this.dateState = new DevExpress.XtraEditors.DateEdit();
            this.lblState = new DevExpress.XtraEditors.LabelControl();
            this.cboxState = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboxOrderID = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtOrderID = new DevExpress.XtraEditors.TextEdit();
            this.lblOrderID = new DevExpress.XtraEditors.LabelControl();
            this.cboxVendor = new DevExpress.XtraEditors.ComboBoxEdit();
            this.bbVendor = new Apothex.Windows.Forms.ButtonBrowse();
            this.lblVendor = new DevExpress.XtraEditors.LabelControl();
            this.chkSafetyStockLevel = new DevExpress.XtraEditors.CheckEdit();
            this.tabPrice = new DevExpress.XtraTab.XtraTabPage();
            this.chkNewDiscountPct = new DevExpress.XtraEditors.CheckEdit();
            this.chkNewDealerPrice = new DevExpress.XtraEditors.CheckEdit();
            this.chkNewPriceFromStandardCost = new DevExpress.XtraEditors.CheckEdit();
            this.chkNewListPrice = new DevExpress.XtraEditors.CheckEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnGenerateNewPrice = new DevExpress.XtraEditors.SimpleButton();
            this.spinNewDiscountPct = new DevExpress.XtraEditors.SpinEdit();
            this.lblNewDiscountPct = new DevExpress.XtraEditors.LabelControl();
            this.spinNewDealerPrice = new DevExpress.XtraEditors.SpinEdit();
            this.lblNewDealerPrice = new DevExpress.XtraEditors.LabelControl();
            this.spinNewPriceFromStandardCost = new DevExpress.XtraEditors.SpinEdit();
            this.lblNewPriceFromStandardCost = new DevExpress.XtraEditors.LabelControl();
            this.spinNewListPrice = new DevExpress.XtraEditors.SpinEdit();
            this.lblNewListPrice = new DevExpress.XtraEditors.LabelControl();
            this.miChangeCurrencyCode = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxTotalQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalQty1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalQty2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxMedicament.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxValidDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValidDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValidDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValidDate2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValidDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMedicament.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrency)).BeginInit();
            this.tabAdditional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateState.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxVendor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbVendor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSafetyStockLevel.Properties)).BeginInit();
            this.tabPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkNewDiscountPct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNewDealerPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNewPriceFromStandardCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNewListPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNewDiscountPct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNewDealerPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNewPriceFromStandardCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNewListPrice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.xtraTabControl);
            this.pnlFilter.Size = new System.Drawing.Size(784, 200);
            this.pnlFilter.Controls.SetChildIndex(this.xtraTabControl, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnFilter, 0);
            // 
            // bsGridControl
            // 
            this.bsGridControl.DataMember = "VW_Product";
            this.bsGridControl.DataSource = this.ds;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.grid);
            this.pnlGrid.Location = new System.Drawing.Point(0, 239);
            this.pnlGrid.Size = new System.Drawing.Size(784, 323);
            // 
            // btnFilter
            // 
            this.btnFilter.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.Appearance.Options.UseFont = true;
            this.btnFilter.Location = new System.Drawing.Point(759, 129);
            // 
            // popupMenu
            // 
            this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.miChangeCurrencyCode, true)});
            this.popupMenu.MenuAppearance.Menu.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popupMenu.MenuAppearance.Menu.Options.UseFont = true;
            // 
            // grid
            // 
            this.grid.DataSource = this.bsGridControl;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.view;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riPrice,
            this.riPct});
            this.grid.Size = new System.Drawing.Size(784, 323);
            this.grid.TabIndex = 0;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view});
            // 
            // view
            // 
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPurchaseOrderID,
            this.colBranchName,
            this.colOrderDate,
            this.colVendorName,
            this.colMedicamentName,
            this.colMedicamentCategoryName,
            this.colMedicamentSubcategoryName,
            this.colGenericName,
            this.colProductNumber,
            this.colUnitsInStock,
            this.colQuantity,
            this.colValidDate,
            this.colCountryName,
            this.colBrandName,
            this.colSerie,
            this.colProductCurrencyCode,
            this.colMakeFlag,
            this.colFinishedGoodsFlag,
            this.colColor,
            this.colSafetyStockLevel,
            this.colReorderPoint,
            this.col_UnitPrice,
            this.col_ListPrice,
            this.col_DealerPrice,
            this.col_DiscountPct,
            this.colTaxRate,
            this.col__PricePct,
            this.col_NewListPrice,
            this.col_NewDealerPrice,
            this.colNewDiscountPct,
            this.colSize,
            this.colSizeRange,
            this.colSizeUnitMeasureCode,
            this.colWeight,
            this.colWeightUnitMeasureCode,
            this.colDaysToManufacture,
            this.colProductLine,
            this.colClass,
            this.colStyle,
            this.colSellStartDate,
            this.colSellEndDate,
            this.colDiscontinuedDate,
            this.colBranchID,
            this.colVendorID,
            this.colProductID,
            this.colPurchaseOrderDetailID,
            this.colMedicamentID,
            this.colMedicamentCategoryID,
            this.colMedicamentSubcategoryID,
            this.colGenericID,
            this.colCountryCode,
            this.colBrandID,
            this.colStatus,
            this.colModifiedUserID,
            this.colModifier,
            this.colModifiedDate});
            this.view.GridControl = this.grid;
            this.view.Name = "view";
            this.view.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.view_CellValueChanged);
            this.view.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.view_InvalidRowException);
            this.view.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.view_ValidateRow);
            this.view.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.view_CustomUnboundColumnData);
            // 
            // colPurchaseOrderID
            // 
            this.colPurchaseOrderID.Caption = "შესყიდ. №";
            this.colPurchaseOrderID.FieldName = "PurchaseOrderID";
            this.colPurchaseOrderID.Name = "colPurchaseOrderID";
            this.colPurchaseOrderID.Visible = true;
            this.colPurchaseOrderID.VisibleIndex = 0;
            // 
            // colBranchName
            // 
            this.colBranchName.Caption = "შესყ. ფილიალი";
            this.colBranchName.FieldName = "BranchName";
            this.colBranchName.Name = "colBranchName";
            this.colBranchName.Visible = true;
            this.colBranchName.VisibleIndex = 1;
            // 
            // colOrderDate
            // 
            this.colOrderDate.Caption = "თარიღი";
            this.colOrderDate.DisplayFormat.FormatString = "G";
            this.colOrderDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 2;
            // 
            // colVendorName
            // 
            this.colVendorName.Caption = "კომპანია";
            this.colVendorName.FieldName = "VendorName";
            this.colVendorName.Name = "colVendorName";
            this.colVendorName.Visible = true;
            this.colVendorName.VisibleIndex = 3;
            // 
            // colMedicamentName
            // 
            this.colMedicamentName.Caption = "მედიკამენტი";
            this.colMedicamentName.FieldName = "MedicamentName";
            this.colMedicamentName.Name = "colMedicamentName";
            this.colMedicamentName.Visible = true;
            this.colMedicamentName.VisibleIndex = 4;
            // 
            // colMedicamentCategoryName
            // 
            this.colMedicamentCategoryName.Caption = "კატეგორია";
            this.colMedicamentCategoryName.FieldName = "MedicamentCategoryName";
            this.colMedicamentCategoryName.Name = "colMedicamentCategoryName";
            // 
            // colMedicamentSubcategoryName
            // 
            this.colMedicamentSubcategoryName.Caption = "ქვეკატეგორია";
            this.colMedicamentSubcategoryName.FieldName = "MedicamentSubcategoryName";
            this.colMedicamentSubcategoryName.Name = "colMedicamentSubcategoryName";
            // 
            // colGenericName
            // 
            this.colGenericName.Caption = "ჯენერიკი";
            this.colGenericName.FieldName = "GenericName";
            this.colGenericName.Name = "colGenericName";
            // 
            // colProductNumber
            // 
            this.colProductNumber.Caption = "პროდ. №";
            this.colProductNumber.FieldName = "ProductNumber";
            this.colProductNumber.Name = "colProductNumber";
            // 
            // colUnitsInStock
            // 
            this.colUnitsInStock.Caption = "დაყოფა";
            this.colUnitsInStock.FieldName = "UnitsInStock";
            this.colUnitsInStock.Name = "colUnitsInStock";
            this.colUnitsInStock.Visible = true;
            this.colUnitsInStock.VisibleIndex = 5;
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
            this.colQuantity.VisibleIndex = 6;
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
            this.colValidDate.Visible = true;
            this.colValidDate.VisibleIndex = 7;
            // 
            // colCountryName
            // 
            this.colCountryName.Caption = "მწ. ქვეყანა";
            this.colCountryName.FieldName = "CountryName";
            this.colCountryName.Name = "colCountryName";
            this.colCountryName.Visible = true;
            this.colCountryName.VisibleIndex = 8;
            // 
            // colBrandName
            // 
            this.colBrandName.Caption = "ბრენდი";
            this.colBrandName.FieldName = "BrandName";
            this.colBrandName.Name = "colBrandName";
            this.colBrandName.Visible = true;
            this.colBrandName.VisibleIndex = 9;
            // 
            // colSerie
            // 
            this.colSerie.Caption = "სერია";
            this.colSerie.FieldName = "Serie";
            this.colSerie.Name = "colSerie";
            this.colSerie.Visible = true;
            this.colSerie.VisibleIndex = 10;
            // 
            // colProductCurrencyCode
            // 
            this.colProductCurrencyCode.Caption = "პ/ე ვალუტა";
            this.colProductCurrencyCode.FieldName = "ProductCurrencyCode";
            this.colProductCurrencyCode.Name = "colProductCurrencyCode";
            this.colProductCurrencyCode.Visible = true;
            this.colProductCurrencyCode.VisibleIndex = 11;
            // 
            // colMakeFlag
            // 
            this.colMakeFlag.Caption = "შიდა პროდ.";
            this.colMakeFlag.FieldName = "MakeFlag";
            this.colMakeFlag.Name = "colMakeFlag";
            // 
            // colFinishedGoodsFlag
            // 
            this.colFinishedGoodsFlag.Caption = "იყიდება";
            this.colFinishedGoodsFlag.FieldName = "FinishedGoodsFlag";
            this.colFinishedGoodsFlag.Name = "colFinishedGoodsFlag";
            // 
            // colColor
            // 
            this.colColor.Caption = "ფერი";
            this.colColor.FieldName = "Color";
            this.colColor.Name = "colColor";
            // 
            // colSafetyStockLevel
            // 
            this.colSafetyStockLevel.Caption = "კრიტ. რაოდ.";
            this.colSafetyStockLevel.FieldName = "SafetyStockLevel";
            this.colSafetyStockLevel.Name = "colSafetyStockLevel";
            // 
            // colReorderPoint
            // 
            this.colReorderPoint.Caption = "შესაკ. რაოდ.";
            this.colReorderPoint.FieldName = "ReorderPoint";
            this.colReorderPoint.Name = "colReorderPoint";
            // 
            // col_UnitPrice
            // 
            this.col_UnitPrice.Caption = "ფასი / შ.";
            this.col_UnitPrice.DisplayFormat.FormatString = "n4";
            this.col_UnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_UnitPrice.FieldName = "_UnitPrice";
            this.col_UnitPrice.GroupFormat.FormatString = "n2";
            this.col_UnitPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_UnitPrice.Name = "col_UnitPrice";
            this.col_UnitPrice.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col_UnitPrice.Visible = true;
            this.col_UnitPrice.VisibleIndex = 12;
            // 
            // col_ListPrice
            // 
            this.col_ListPrice.Caption = "ფასი / გ.";
            this.col_ListPrice.DisplayFormat.FormatString = "n4";
            this.col_ListPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_ListPrice.FieldName = "_ListPrice";
            this.col_ListPrice.GroupFormat.FormatString = "n2";
            this.col_ListPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_ListPrice.Name = "col_ListPrice";
            this.col_ListPrice.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col_ListPrice.Visible = true;
            this.col_ListPrice.VisibleIndex = 13;
            // 
            // col_DealerPrice
            // 
            this.col_DealerPrice.Caption = "ფასი / დილ.";
            this.col_DealerPrice.DisplayFormat.FormatString = "n4";
            this.col_DealerPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_DealerPrice.FieldName = "_DealerPrice";
            this.col_DealerPrice.GroupFormat.FormatString = "n2";
            this.col_DealerPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_DealerPrice.Name = "col_DealerPrice";
            this.col_DealerPrice.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col_DealerPrice.Visible = true;
            this.col_DealerPrice.VisibleIndex = 14;
            // 
            // col_DiscountPct
            // 
            this.col_DiscountPct.Caption = "ფასდაკ.";
            this.col_DiscountPct.DisplayFormat.FormatString = "p";
            this.col_DiscountPct.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_DiscountPct.FieldName = "DiscountPct";
            this.col_DiscountPct.GroupFormat.FormatString = "p";
            this.col_DiscountPct.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_DiscountPct.Name = "col_DiscountPct";
            this.col_DiscountPct.Visible = true;
            this.col_DiscountPct.VisibleIndex = 15;
            // 
            // colTaxRate
            // 
            this.colTaxRate.Caption = "დ.ღ.გ.";
            this.colTaxRate.DisplayFormat.FormatString = "p";
            this.colTaxRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTaxRate.FieldName = "TaxRate";
            this.colTaxRate.GroupFormat.FormatString = "p";
            this.colTaxRate.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTaxRate.Name = "colTaxRate";
            this.colTaxRate.Visible = true;
            this.colTaxRate.VisibleIndex = 16;
            // 
            // col__PricePct
            // 
            this.col__PricePct.Caption = "გაყ. ფასდაკ.";
            this.col__PricePct.DisplayFormat.FormatString = "p4";
            this.col__PricePct.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col__PricePct.FieldName = "col__PricePct";
            this.col__PricePct.GroupFormat.FormatString = "p2";
            this.col__PricePct.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col__PricePct.Name = "col__PricePct";
            this.col__PricePct.UnboundExpression = "Iif([_ListPrice] != 0m,  (1m-([_UnitPrice]*(1m+[TaxRate]))/[_ListPrice]), 1m)";
            this.col__PricePct.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col__PricePct.Visible = true;
            this.col__PricePct.VisibleIndex = 17;
            // 
            // col_NewListPrice
            // 
            this.col_NewListPrice.Caption = "ახალი ფასი / გ.";
            this.col_NewListPrice.ColumnEdit = this.riPrice;
            this.col_NewListPrice.DisplayFormat.FormatString = "n4";
            this.col_NewListPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_NewListPrice.FieldName = "_NewListPrice";
            this.col_NewListPrice.Name = "col_NewListPrice";
            this.col_NewListPrice.Visible = true;
            this.col_NewListPrice.VisibleIndex = 18;
            // 
            // riPrice
            // 
            this.riPrice.AutoHeight = false;
            this.riPrice.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
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
            // col_NewDealerPrice
            // 
            this.col_NewDealerPrice.Caption = "ახალი ფასი / დილ.";
            this.col_NewDealerPrice.ColumnEdit = this.riPrice;
            this.col_NewDealerPrice.DisplayFormat.FormatString = "n4";
            this.col_NewDealerPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_NewDealerPrice.FieldName = "_NewDealerPrice";
            this.col_NewDealerPrice.Name = "col_NewDealerPrice";
            this.col_NewDealerPrice.Visible = true;
            this.col_NewDealerPrice.VisibleIndex = 19;
            // 
            // colNewDiscountPct
            // 
            this.colNewDiscountPct.Caption = "ახალი ფასდაკლება";
            this.colNewDiscountPct.ColumnEdit = this.riPct;
            this.colNewDiscountPct.DisplayFormat.FormatString = "p";
            this.colNewDiscountPct.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNewDiscountPct.FieldName = "NewDiscountPct";
            this.colNewDiscountPct.GroupFormat.FormatString = "p";
            this.colNewDiscountPct.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNewDiscountPct.Name = "colNewDiscountPct";
            this.colNewDiscountPct.Visible = true;
            this.colNewDiscountPct.VisibleIndex = 20;
            // 
            // riPct
            // 
            this.riPct.AutoHeight = false;
            this.riPct.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.riPct.DisplayFormat.FormatString = "p";
            this.riPct.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riPct.EditFormat.FormatString = "p";
            this.riPct.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riPct.Mask.EditMask = "p";
            this.riPct.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.riPct.Name = "riPct";
            // 
            // colSize
            // 
            this.colSize.Caption = "ზომა";
            this.colSize.FieldName = "Size";
            this.colSize.Name = "colSize";
            // 
            // colSizeRange
            // 
            this.colSizeRange.Caption = "ზომ. დიაპ.";
            this.colSizeRange.FieldName = "SizeRange";
            this.colSizeRange.Name = "colSizeRange";
            // 
            // colSizeUnitMeasureCode
            // 
            this.colSizeUnitMeasureCode.Caption = "ზომ. ერთ.";
            this.colSizeUnitMeasureCode.FieldName = "SizeUnitMeasureCode";
            this.colSizeUnitMeasureCode.Name = "colSizeUnitMeasureCode";
            // 
            // colWeight
            // 
            this.colWeight.Caption = "წონა";
            this.colWeight.DisplayFormat.FormatString = "n2";
            this.colWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colWeight.FieldName = "Weight";
            this.colWeight.GroupFormat.FormatString = "n2";
            this.colWeight.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colWeight.Name = "colWeight";
            // 
            // colWeightUnitMeasureCode
            // 
            this.colWeightUnitMeasureCode.Caption = "წონ. ერთ.";
            this.colWeightUnitMeasureCode.FieldName = "WeightUnitMeasureCode";
            this.colWeightUnitMeasureCode.Name = "colWeightUnitMeasureCode";
            // 
            // colDaysToManufacture
            // 
            this.colDaysToManufacture.Caption = "წარმ. ხანგძლ.";
            this.colDaysToManufacture.FieldName = "DaysToManufacture";
            this.colDaysToManufacture.Name = "colDaysToManufacture";
            // 
            // colProductLine
            // 
            this.colProductLine.Caption = "პროდ. ხაზი";
            this.colProductLine.FieldName = "ProductLine";
            this.colProductLine.Name = "colProductLine";
            // 
            // colClass
            // 
            this.colClass.Caption = "ხარისხი";
            this.colClass.FieldName = "Class";
            this.colClass.Name = "colClass";
            // 
            // colStyle
            // 
            this.colStyle.Caption = "სტილი";
            this.colStyle.FieldName = "Style";
            this.colStyle.Name = "colStyle";
            // 
            // colSellStartDate
            // 
            this.colSellStartDate.Caption = "გაყ. დაიწყოს";
            this.colSellStartDate.FieldName = "SellStartDate";
            this.colSellStartDate.Name = "colSellStartDate";
            // 
            // colSellEndDate
            // 
            this.colSellEndDate.Caption = "გაყ. დასრულდეს";
            this.colSellEndDate.FieldName = "SellEndDate";
            this.colSellEndDate.Name = "colSellEndDate";
            // 
            // colDiscontinuedDate
            // 
            this.colDiscontinuedDate.Caption = "გაყ. შეწყდა";
            this.colDiscontinuedDate.FieldName = "DiscontinuedDate";
            this.colDiscontinuedDate.Name = "colDiscontinuedDate";
            // 
            // colBranchID
            // 
            this.colBranchID.FieldName = "BranchID";
            this.colBranchID.Name = "colBranchID";
            // 
            // colVendorID
            // 
            this.colVendorID.FieldName = "VendorID";
            this.colVendorID.Name = "colVendorID";
            // 
            // colProductID
            // 
            this.colProductID.FieldName = "ProductID";
            this.colProductID.Name = "colProductID";
            // 
            // colPurchaseOrderDetailID
            // 
            this.colPurchaseOrderDetailID.FieldName = "PurchaseOrderDetailID";
            this.colPurchaseOrderDetailID.Name = "colPurchaseOrderDetailID";
            // 
            // colMedicamentID
            // 
            this.colMedicamentID.FieldName = "MedicamentID";
            this.colMedicamentID.Name = "colMedicamentID";
            // 
            // colMedicamentCategoryID
            // 
            this.colMedicamentCategoryID.FieldName = "MedicamentCategoryID";
            this.colMedicamentCategoryID.Name = "colMedicamentCategoryID";
            // 
            // colMedicamentSubcategoryID
            // 
            this.colMedicamentSubcategoryID.FieldName = "MedicamentSubcategoryID";
            this.colMedicamentSubcategoryID.Name = "colMedicamentSubcategoryID";
            // 
            // colGenericID
            // 
            this.colGenericID.FieldName = "GenericID";
            this.colGenericID.Name = "colGenericID";
            // 
            // colCountryCode
            // 
            this.colCountryCode.FieldName = "CountryCode";
            this.colCountryCode.Name = "colCountryCode";
            // 
            // colBrandID
            // 
            this.colBrandID.FieldName = "BrandID";
            this.colBrandID.Name = "colBrandID";
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
            this.colModifiedDate.DisplayFormat.FormatString = "G";
            this.colModifiedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colModifiedDate.FieldName = "ModifiedDate";
            this.colModifiedDate.Name = "colModifiedDate";
            // 
            // ds
            // 
            this.ds.DataSetName = "DS_Production";
            this.ds.Locale = new System.Globalization.CultureInfo("");
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.AppearancePage.Header.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xtraTabControl.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl.Location = new System.Drawing.Point(2, 2);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.SelectedTabPage = this.tabMain;
            this.xtraTabControl.Size = new System.Drawing.Size(780, 196);
            this.xtraTabControl.TabIndex = 0;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabMain,
            this.tabAdditional,
            this.tabPrice});
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.dateOrderDate2);
            this.tabMain.Controls.Add(this.dateOrderDate1);
            this.tabMain.Controls.Add(this.cboxOrderDate);
            this.tabMain.Controls.Add(this.lblStartDate);
            this.tabMain.Controls.Add(this.cboxBranch);
            this.tabMain.Controls.Add(this.bbBranch);
            this.tabMain.Controls.Add(this.lblBranch);
            this.tabMain.Controls.Add(this.lblTotalQty);
            this.tabMain.Controls.Add(this.cboxTotalQty);
            this.tabMain.Controls.Add(this.spinTotalQty1);
            this.tabMain.Controls.Add(this.spinTotalQty2);
            this.tabMain.Controls.Add(this.cboxMedicament);
            this.tabMain.Controls.Add(this.lblValidDate);
            this.tabMain.Controls.Add(this.cboxValidDate);
            this.tabMain.Controls.Add(this.dateValidDate1);
            this.tabMain.Controls.Add(this.dateValidDate2);
            this.tabMain.Controls.Add(this.lblMedicament);
            this.tabMain.Controls.Add(this.txtMedicament);
            this.tabMain.Controls.Add(this.lookCurrency);
            this.tabMain.Controls.Add(this.lblCurrency);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(774, 167);
            this.tabMain.Text = "მთავარი";
            // 
            // dateOrderDate2
            // 
            this.dateOrderDate2.EditValue = null;
            this.dateOrderDate2.Enabled = false;
            this.dateOrderDate2.EnterMoveNextControl = true;
            this.dateOrderDate2.Location = new System.Drawing.Point(375, 93);
            this.dateOrderDate2.Name = "dateOrderDate2";
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
            this.dateOrderDate2.TabIndex = 36;
            // 
            // dateOrderDate1
            // 
            this.dateOrderDate1.EditValue = null;
            this.dateOrderDate1.Enabled = false;
            this.dateOrderDate1.EnterMoveNextControl = true;
            this.dateOrderDate1.Location = new System.Drawing.Point(219, 93);
            this.dateOrderDate1.Name = "dateOrderDate1";
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
            this.dateOrderDate1.TabIndex = 35;
            // 
            // cboxOrderDate
            // 
            this.cboxOrderDate.EnterMoveNextControl = true;
            this.cboxOrderDate.Location = new System.Drawing.Point(153, 93);
            this.cboxOrderDate.Name = "cboxOrderDate";
            this.cboxOrderDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxOrderDate.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxOrderDate.Properties.Appearance.Options.UseFont = true;
            this.cboxOrderDate.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxOrderDate.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxOrderDate.Properties.Items.AddRange(new object[] {
            "",
            "=",
            ">",
            "<",
            "[ ]"});
            this.cboxOrderDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxOrderDate.Size = new System.Drawing.Size(60, 23);
            this.cboxOrderDate.TabIndex = 34;
            this.cboxOrderDate.SelectedIndexChanged += new System.EventHandler(this.cboxOrderDate_SelectedIndexChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStartDate.Location = new System.Drawing.Point(8, 96);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(144, 17);
            this.lblStartDate.TabIndex = 33;
            this.lblStartDate.Text = "ფაქტურის თარიღი:";
            // 
            // cboxBranch
            // 
            this.cboxBranch.EditValue = "=";
            this.cboxBranch.EnterMoveNextControl = true;
            this.cboxBranch.Location = new System.Drawing.Point(153, 64);
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
            this.cboxBranch.Size = new System.Drawing.Size(60, 23);
            this.cboxBranch.TabIndex = 31;
            this.cboxBranch.SelectedIndexChanged += new System.EventHandler(this.cboxBranch_SelectedIndexChanged);
            // 
            // bbBranch
            // 
            this.bbBranch.EnterMoveNextControl = true;
            this.bbBranch.IsOnline = true;
            this.bbBranch.Location = new System.Drawing.Point(219, 64);
            this.bbBranch.MenuManager = this.barManager;
            this.bbBranch.Name = "bbBranch";
            this.bbBranch.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F);
            this.bbBranch.Properties.Appearance.Options.UseFont = true;
            this.bbBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject1, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject2, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbBranch.Size = new System.Drawing.Size(306, 23);
            this.bbBranch.TabIndex = 32;
            this.bbBranch.TableName = Apothex.DataType.ObjectNames.Branch;
            // 
            // lblBranch
            // 
            this.lblBranch.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBranch.Location = new System.Drawing.Point(8, 67);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(81, 17);
            this.lblBranch.TabIndex = 30;
            this.lblBranch.Text = "ფილიალი:";
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalQty.Location = new System.Drawing.Point(552, 38);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(106, 17);
            this.lblTotalQty.TabIndex = 26;
            this.lblTotalQty.Text = "ჯამური რაოდ:";
            // 
            // cboxTotalQty
            // 
            this.cboxTotalQty.EditValue = ">";
            this.cboxTotalQty.EnterMoveNextControl = true;
            this.cboxTotalQty.Location = new System.Drawing.Point(664, 35);
            this.cboxTotalQty.Name = "cboxTotalQty";
            this.cboxTotalQty.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxTotalQty.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxTotalQty.Properties.Appearance.Options.UseFont = true;
            this.cboxTotalQty.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxTotalQty.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxTotalQty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxTotalQty.Properties.Items.AddRange(new object[] {
            "",
            "=",
            ">",
            ">=",
            "<",
            "<=",
            "[ ]"});
            this.cboxTotalQty.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxTotalQty.Size = new System.Drawing.Size(75, 23);
            this.cboxTotalQty.TabIndex = 27;
            this.cboxTotalQty.SelectedIndexChanged += new System.EventHandler(this.cboxTotalQty_SelectedIndexChanged);
            // 
            // spinTotalQty1
            // 
            this.spinTotalQty1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTotalQty1.EnterMoveNextControl = true;
            this.spinTotalQty1.Location = new System.Drawing.Point(745, 35);
            this.spinTotalQty1.Name = "spinTotalQty1";
            this.spinTotalQty1.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinTotalQty1.Properties.Appearance.Options.UseFont = true;
            this.spinTotalQty1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinTotalQty1.Properties.DisplayFormat.FormatString = "n4";
            this.spinTotalQty1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTotalQty1.Properties.EditFormat.FormatString = "n4";
            this.spinTotalQty1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTotalQty1.Properties.Mask.EditMask = "n4";
            this.spinTotalQty1.Properties.MaxValue = new decimal(new int[] {
            -1806942208,
            209547,
            0,
            0});
            this.spinTotalQty1.Size = new System.Drawing.Size(110, 23);
            this.spinTotalQty1.TabIndex = 28;
            this.spinTotalQty1.EditValueChanged += new System.EventHandler(this.spinTotalQty1_EditValueChanged);
            // 
            // spinTotalQty2
            // 
            this.spinTotalQty2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTotalQty2.Enabled = false;
            this.spinTotalQty2.EnterMoveNextControl = true;
            this.spinTotalQty2.Location = new System.Drawing.Point(861, 35);
            this.spinTotalQty2.Name = "spinTotalQty2";
            this.spinTotalQty2.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinTotalQty2.Properties.Appearance.Options.UseFont = true;
            this.spinTotalQty2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinTotalQty2.Properties.DisplayFormat.FormatString = "n4";
            this.spinTotalQty2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTotalQty2.Properties.EditFormat.FormatString = "n4";
            this.spinTotalQty2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTotalQty2.Properties.Mask.EditMask = "n4";
            this.spinTotalQty2.Properties.MaxValue = new decimal(new int[] {
            -1806942208,
            209547,
            0,
            0});
            this.spinTotalQty2.Size = new System.Drawing.Size(110, 23);
            this.spinTotalQty2.TabIndex = 29;
            this.spinTotalQty2.EditValueChanged += new System.EventHandler(this.spinTotalQty2_EditValueChanged);
            // 
            // cboxMedicament
            // 
            this.cboxMedicament.EditValue = "a%";
            this.cboxMedicament.EnterMoveNextControl = true;
            this.cboxMedicament.Location = new System.Drawing.Point(153, 35);
            this.cboxMedicament.Name = "cboxMedicament";
            this.cboxMedicament.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxMedicament.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxMedicament.Properties.Appearance.Options.UseFont = true;
            this.cboxMedicament.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxMedicament.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxMedicament.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxMedicament.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!=",
            "%a%",
            "!%a%",
            "a%",
            "!a%",
            "%a",
            "!%a"});
            this.cboxMedicament.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxMedicament.Size = new System.Drawing.Size(60, 23);
            this.cboxMedicament.TabIndex = 16;
            this.cboxMedicament.SelectedIndexChanged += new System.EventHandler(this.cboxMedicament_SelectedIndexChanged);
            // 
            // lblValidDate
            // 
            this.lblValidDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblValidDate.Location = new System.Drawing.Point(552, 6);
            this.lblValidDate.Name = "lblValidDate";
            this.lblValidDate.Size = new System.Drawing.Size(41, 17);
            this.lblValidDate.TabIndex = 22;
            this.lblValidDate.Text = "ვადა:";
            // 
            // cboxValidDate
            // 
            this.cboxValidDate.EnterMoveNextControl = true;
            this.cboxValidDate.Location = new System.Drawing.Point(664, 3);
            this.cboxValidDate.Name = "cboxValidDate";
            this.cboxValidDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxValidDate.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxValidDate.Properties.Appearance.Options.UseFont = true;
            this.cboxValidDate.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxValidDate.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxValidDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxValidDate.Properties.Items.AddRange(new object[] {
            "",
            "=",
            ">",
            "<",
            "[ ]"});
            this.cboxValidDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxValidDate.Size = new System.Drawing.Size(75, 23);
            this.cboxValidDate.TabIndex = 23;
            this.cboxValidDate.SelectedIndexChanged += new System.EventHandler(this.cboxValidDate_SelectedIndexChanged);
            // 
            // dateValidDate1
            // 
            this.dateValidDate1.EditValue = null;
            this.dateValidDate1.Enabled = false;
            this.dateValidDate1.EnterMoveNextControl = true;
            this.dateValidDate1.Location = new System.Drawing.Point(745, 3);
            this.dateValidDate1.Name = "dateValidDate1";
            this.dateValidDate1.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateValidDate1.Properties.Appearance.Options.UseFont = true;
            this.dateValidDate1.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateValidDate1.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dateValidDate1.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateValidDate1.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.dateValidDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateValidDate1.Properties.DisplayFormat.FormatString = "MM\\/yy";
            this.dateValidDate1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateValidDate1.Properties.EditFormat.FormatString = "MM\\/yy";
            this.dateValidDate1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateValidDate1.Properties.Mask.EditMask = "MM\\/yy";
            this.dateValidDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateValidDate1.Size = new System.Drawing.Size(110, 23);
            this.dateValidDate1.TabIndex = 24;
            this.dateValidDate1.EditValueChanged += new System.EventHandler(this.dateValidDate1_EditValueChanged);
            // 
            // dateValidDate2
            // 
            this.dateValidDate2.EditValue = null;
            this.dateValidDate2.Enabled = false;
            this.dateValidDate2.EnterMoveNextControl = true;
            this.dateValidDate2.Location = new System.Drawing.Point(861, 3);
            this.dateValidDate2.Name = "dateValidDate2";
            this.dateValidDate2.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateValidDate2.Properties.Appearance.Options.UseFont = true;
            this.dateValidDate2.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateValidDate2.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dateValidDate2.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateValidDate2.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.dateValidDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateValidDate2.Properties.DisplayFormat.FormatString = "MM\\/yy";
            this.dateValidDate2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateValidDate2.Properties.EditFormat.FormatString = "MM\\/yy";
            this.dateValidDate2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateValidDate2.Properties.Mask.EditMask = "MM\\/yy";
            this.dateValidDate2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateValidDate2.Size = new System.Drawing.Size(110, 23);
            this.dateValidDate2.TabIndex = 25;
            this.dateValidDate2.EditValueChanged += new System.EventHandler(this.dateValidDate2_EditValueChanged);
            // 
            // lblMedicament
            // 
            this.lblMedicament.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMedicament.Location = new System.Drawing.Point(7, 38);
            this.lblMedicament.Name = "lblMedicament";
            this.lblMedicament.Size = new System.Drawing.Size(98, 17);
            this.lblMedicament.TabIndex = 15;
            this.lblMedicament.Text = "მედიკამენტი:";
            // 
            // txtMedicament
            // 
            this.txtMedicament.EnterMoveNextControl = true;
            this.txtMedicament.Location = new System.Drawing.Point(219, 35);
            this.txtMedicament.Name = "txtMedicament";
            this.txtMedicament.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMedicament.Properties.Appearance.Options.UseFont = true;
            this.txtMedicament.Size = new System.Drawing.Size(306, 23);
            this.txtMedicament.TabIndex = 17;
            // 
            // lookCurrency
            // 
            this.lookCurrency.EnterMoveNextControl = true;
            this.lookCurrency.Location = new System.Drawing.Point(153, 6);
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
            this.lookCurrency.Size = new System.Drawing.Size(372, 23);
            this.lookCurrency.TabIndex = 1;
            this.lookCurrency.EditValueChanged += new System.EventHandler(this.lookCurrency_EditValueChanged);
            // 
            // lblCurrency
            // 
            this.lblCurrency.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrency.Location = new System.Drawing.Point(7, 9);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(140, 17);
            this.lblCurrency.TabIndex = 0;
            this.lblCurrency.Text = "ვალუტაში ჩვენება:";
            // 
            // tabAdditional
            // 
            this.tabAdditional.Controls.Add(this.dateState);
            this.tabAdditional.Controls.Add(this.lblState);
            this.tabAdditional.Controls.Add(this.cboxState);
            this.tabAdditional.Controls.Add(this.cboxOrderID);
            this.tabAdditional.Controls.Add(this.txtOrderID);
            this.tabAdditional.Controls.Add(this.lblOrderID);
            this.tabAdditional.Controls.Add(this.cboxVendor);
            this.tabAdditional.Controls.Add(this.bbVendor);
            this.tabAdditional.Controls.Add(this.lblVendor);
            this.tabAdditional.Controls.Add(this.chkSafetyStockLevel);
            this.tabAdditional.Name = "tabAdditional";
            this.tabAdditional.Size = new System.Drawing.Size(774, 167);
            this.tabAdditional.Text = "დამატებითი";
            // 
            // dateState
            // 
            this.dateState.EditValue = null;
            this.dateState.Enabled = false;
            this.dateState.EnterMoveNextControl = true;
            this.dateState.Location = new System.Drawing.Point(209, 64);
            this.dateState.Name = "dateState";
            this.dateState.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateState.Properties.Appearance.Options.UseFont = true;
            this.dateState.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateState.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dateState.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateState.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.dateState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateState.Properties.DisplayFormat.FormatString = "G";
            this.dateState.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateState.Properties.EditFormat.FormatString = "G";
            this.dateState.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateState.Properties.Mask.EditMask = "G";
            this.dateState.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateState.Size = new System.Drawing.Size(226, 23);
            this.dateState.TabIndex = 8;
            // 
            // lblState
            // 
            this.lblState.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblState.Location = new System.Drawing.Point(8, 67);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(109, 17);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "მდგომარეობა:";
            // 
            // cboxState
            // 
            this.cboxState.EditValue = "";
            this.cboxState.EnterMoveNextControl = true;
            this.cboxState.Location = new System.Drawing.Point(123, 64);
            this.cboxState.Name = "cboxState";
            this.cboxState.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxState.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxState.Properties.Appearance.Options.UseFont = true;
            this.cboxState.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxState.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxState.Properties.Items.AddRange(new object[] {
            "",
            "="});
            this.cboxState.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxState.Size = new System.Drawing.Size(80, 23);
            this.cboxState.TabIndex = 7;
            this.cboxState.SelectedIndexChanged += new System.EventHandler(this.cboxState_SelectedIndexChanged);
            // 
            // cboxOrderID
            // 
            this.cboxOrderID.EditValue = "=";
            this.cboxOrderID.EnterMoveNextControl = true;
            this.cboxOrderID.Location = new System.Drawing.Point(123, 6);
            this.cboxOrderID.Name = "cboxOrderID";
            this.cboxOrderID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxOrderID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxOrderID.Properties.Appearance.Options.UseFont = true;
            this.cboxOrderID.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxOrderID.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxOrderID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxOrderID.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!=",
            "a,b,c",
            "!a,b,c"});
            this.cboxOrderID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxOrderID.Size = new System.Drawing.Size(80, 23);
            this.cboxOrderID.TabIndex = 1;
            this.cboxOrderID.SelectedIndexChanged += new System.EventHandler(this.cboxOrderID_SelectedIndexChanged);
            // 
            // txtOrderID
            // 
            this.txtOrderID.EnterMoveNextControl = true;
            this.txtOrderID.Location = new System.Drawing.Point(209, 6);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOrderID.Properties.Appearance.Options.UseFont = true;
            this.txtOrderID.Properties.DisplayFormat.FormatString = "f0";
            this.txtOrderID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtOrderID.Properties.EditFormat.FormatString = "f0";
            this.txtOrderID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtOrderID.Properties.Mask.EditMask = "[0-9,]+";
            this.txtOrderID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtOrderID.Properties.MaxLength = 10;
            this.txtOrderID.Size = new System.Drawing.Size(226, 23);
            this.txtOrderID.TabIndex = 2;
            // 
            // lblOrderID
            // 
            this.lblOrderID.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderID.Location = new System.Drawing.Point(7, 9);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(90, 17);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "შესყიდ.ვ №:";
            // 
            // cboxVendor
            // 
            this.cboxVendor.EditValue = "=";
            this.cboxVendor.EnterMoveNextControl = true;
            this.cboxVendor.Location = new System.Drawing.Point(123, 35);
            this.cboxVendor.Name = "cboxVendor";
            this.cboxVendor.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxVendor.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxVendor.Properties.Appearance.Options.UseFont = true;
            this.cboxVendor.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxVendor.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxVendor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxVendor.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!="});
            this.cboxVendor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxVendor.Size = new System.Drawing.Size(80, 23);
            this.cboxVendor.TabIndex = 4;
            this.cboxVendor.SelectedIndexChanged += new System.EventHandler(this.cboxCompany_SelectedIndexChanged);
            // 
            // bbVendor
            // 
            this.bbVendor.EnterMoveNextControl = true;
            this.bbVendor.IsOnline = true;
            this.bbVendor.Location = new System.Drawing.Point(209, 35);
            this.bbVendor.MenuManager = this.barManager;
            this.bbVendor.Name = "bbVendor";
            this.bbVendor.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bbVendor.Properties.Appearance.Options.UseFont = true;
            this.bbVendor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject3, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject4, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbVendor.Size = new System.Drawing.Size(226, 23);
            this.bbVendor.TabIndex = 5;
            this.bbVendor.TableName = Apothex.DataType.ObjectNames.Company;
            // 
            // lblVendor
            // 
            this.lblVendor.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVendor.Location = new System.Drawing.Point(6, 38);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(72, 17);
            this.lblVendor.TabIndex = 3;
            this.lblVendor.Text = "კომპანია:";
            // 
            // chkSafetyStockLevel
            // 
            this.chkSafetyStockLevel.Location = new System.Drawing.Point(121, 94);
            this.chkSafetyStockLevel.Name = "chkSafetyStockLevel";
            this.chkSafetyStockLevel.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSafetyStockLevel.Properties.Appearance.Options.UseFont = true;
            this.chkSafetyStockLevel.Properties.Caption = "კრიტიკული რაოდენობა";
            this.chkSafetyStockLevel.Size = new System.Drawing.Size(312, 22);
            this.chkSafetyStockLevel.TabIndex = 9;
            // 
            // tabPrice
            // 
            this.tabPrice.Controls.Add(this.chkNewDiscountPct);
            this.tabPrice.Controls.Add(this.chkNewDealerPrice);
            this.tabPrice.Controls.Add(this.chkNewPriceFromStandardCost);
            this.tabPrice.Controls.Add(this.chkNewListPrice);
            this.tabPrice.Controls.Add(this.btnSave);
            this.tabPrice.Controls.Add(this.btnGenerateNewPrice);
            this.tabPrice.Controls.Add(this.spinNewDiscountPct);
            this.tabPrice.Controls.Add(this.lblNewDiscountPct);
            this.tabPrice.Controls.Add(this.spinNewDealerPrice);
            this.tabPrice.Controls.Add(this.lblNewDealerPrice);
            this.tabPrice.Controls.Add(this.spinNewPriceFromStandardCost);
            this.tabPrice.Controls.Add(this.lblNewPriceFromStandardCost);
            this.tabPrice.Controls.Add(this.spinNewListPrice);
            this.tabPrice.Controls.Add(this.lblNewListPrice);
            this.tabPrice.Name = "tabPrice";
            this.tabPrice.Size = new System.Drawing.Size(774, 167);
            this.tabPrice.Text = "ფასები";
            // 
            // chkNewDiscountPct
            // 
            this.chkNewDiscountPct.Location = new System.Drawing.Point(272, 97);
            this.chkNewDiscountPct.Name = "chkNewDiscountPct";
            this.chkNewDiscountPct.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkNewDiscountPct.Properties.Appearance.Options.UseFont = true;
            this.chkNewDiscountPct.Properties.Caption = "";
            this.chkNewDiscountPct.Size = new System.Drawing.Size(75, 22);
            this.chkNewDiscountPct.TabIndex = 11;
            this.chkNewDiscountPct.CheckedChanged += new System.EventHandler(this.chkNewDiscountPct_CheckedChanged);
            // 
            // chkNewDealerPrice
            // 
            this.chkNewDealerPrice.Location = new System.Drawing.Point(272, 68);
            this.chkNewDealerPrice.Name = "chkNewDealerPrice";
            this.chkNewDealerPrice.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkNewDealerPrice.Properties.Appearance.Options.UseFont = true;
            this.chkNewDealerPrice.Properties.Caption = "";
            this.chkNewDealerPrice.Size = new System.Drawing.Size(75, 22);
            this.chkNewDealerPrice.TabIndex = 8;
            this.chkNewDealerPrice.CheckedChanged += new System.EventHandler(this.chkNewDealerPrice_CheckedChanged);
            // 
            // chkNewPriceFromStandardCost
            // 
            this.chkNewPriceFromStandardCost.Location = new System.Drawing.Point(272, 10);
            this.chkNewPriceFromStandardCost.Name = "chkNewPriceFromStandardCost";
            this.chkNewPriceFromStandardCost.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkNewPriceFromStandardCost.Properties.Appearance.Options.UseFont = true;
            this.chkNewPriceFromStandardCost.Properties.Caption = "";
            this.chkNewPriceFromStandardCost.Size = new System.Drawing.Size(75, 22);
            this.chkNewPriceFromStandardCost.TabIndex = 2;
            this.chkNewPriceFromStandardCost.CheckedChanged += new System.EventHandler(this.chkNewPriceFromStandardCost_CheckedChanged);
            // 
            // chkNewListPrice
            // 
            this.chkNewListPrice.Location = new System.Drawing.Point(272, 39);
            this.chkNewListPrice.Name = "chkNewListPrice";
            this.chkNewListPrice.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkNewListPrice.Properties.Appearance.Options.UseFont = true;
            this.chkNewListPrice.Properties.Caption = "";
            this.chkNewListPrice.Size = new System.Drawing.Size(75, 22);
            this.chkNewListPrice.TabIndex = 5;
            this.chkNewListPrice.CheckedChanged += new System.EventHandler(this.chkNewPricePct_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(271, 128);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 33);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "ცვლილებების შენახვა";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGenerateNewPrice
            // 
            this.btnGenerateNewPrice.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerateNewPrice.Appearance.Options.UseFont = true;
            this.btnGenerateNewPrice.Location = new System.Drawing.Point(65, 128);
            this.btnGenerateNewPrice.Name = "btnGenerateNewPrice";
            this.btnGenerateNewPrice.Size = new System.Drawing.Size(200, 33);
            this.btnGenerateNewPrice.TabIndex = 12;
            this.btnGenerateNewPrice.Text = "ახალი მნიშვნ. გენერ.";
            this.btnGenerateNewPrice.Click += new System.EventHandler(this.btnGenerateNewPrice_Click);
            // 
            // spinNewDiscountPct
            // 
            this.spinNewDiscountPct.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinNewDiscountPct.EnterMoveNextControl = true;
            this.spinNewDiscountPct.Location = new System.Drawing.Point(165, 97);
            this.spinNewDiscountPct.Name = "spinNewDiscountPct";
            this.spinNewDiscountPct.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinNewDiscountPct.Properties.Appearance.Options.UseFont = true;
            this.spinNewDiscountPct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinNewDiscountPct.Properties.DisplayFormat.FormatString = "p4";
            this.spinNewDiscountPct.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinNewDiscountPct.Properties.EditFormat.FormatString = "p4";
            this.spinNewDiscountPct.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinNewDiscountPct.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.spinNewDiscountPct.Properties.Mask.EditMask = "p4";
            this.spinNewDiscountPct.Properties.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinNewDiscountPct.Properties.ReadOnly = true;
            this.spinNewDiscountPct.Size = new System.Drawing.Size(100, 23);
            this.spinNewDiscountPct.TabIndex = 10;
            // 
            // lblNewDiscountPct
            // 
            this.lblNewDiscountPct.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewDiscountPct.Location = new System.Drawing.Point(6, 100);
            this.lblNewDiscountPct.Name = "lblNewDiscountPct";
            this.lblNewDiscountPct.Size = new System.Drawing.Size(153, 17);
            this.lblNewDiscountPct.TabIndex = 9;
            this.lblNewDiscountPct.Text = "ახალი ფასდაკლება:";
            // 
            // spinNewDealerPrice
            // 
            this.spinNewDealerPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinNewDealerPrice.EnterMoveNextControl = true;
            this.spinNewDealerPrice.Location = new System.Drawing.Point(165, 68);
            this.spinNewDealerPrice.Name = "spinNewDealerPrice";
            this.spinNewDealerPrice.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinNewDealerPrice.Properties.Appearance.Options.UseFont = true;
            this.spinNewDealerPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinNewDealerPrice.Properties.DisplayFormat.FormatString = "p4";
            this.spinNewDealerPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinNewDealerPrice.Properties.EditFormat.FormatString = "p4";
            this.spinNewDealerPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinNewDealerPrice.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.spinNewDealerPrice.Properties.Mask.EditMask = "p4";
            this.spinNewDealerPrice.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinNewDealerPrice.Properties.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.spinNewDealerPrice.Properties.ReadOnly = true;
            this.spinNewDealerPrice.Size = new System.Drawing.Size(100, 23);
            this.spinNewDealerPrice.TabIndex = 7;
            // 
            // lblNewDealerPrice
            // 
            this.lblNewDealerPrice.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewDealerPrice.Location = new System.Drawing.Point(6, 71);
            this.lblNewDealerPrice.Name = "lblNewDealerPrice";
            this.lblNewDealerPrice.Size = new System.Drawing.Size(150, 17);
            this.lblNewDealerPrice.TabIndex = 6;
            this.lblNewDealerPrice.Text = "ახალი ფასი / დილ.:";
            // 
            // spinNewPriceFromStandardCost
            // 
            this.spinNewPriceFromStandardCost.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinNewPriceFromStandardCost.EnterMoveNextControl = true;
            this.spinNewPriceFromStandardCost.Location = new System.Drawing.Point(165, 10);
            this.spinNewPriceFromStandardCost.Name = "spinNewPriceFromStandardCost";
            this.spinNewPriceFromStandardCost.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinNewPriceFromStandardCost.Properties.Appearance.Options.UseFont = true;
            this.spinNewPriceFromStandardCost.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinNewPriceFromStandardCost.Properties.DisplayFormat.FormatString = "p4";
            this.spinNewPriceFromStandardCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinNewPriceFromStandardCost.Properties.EditFormat.FormatString = "p4";
            this.spinNewPriceFromStandardCost.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinNewPriceFromStandardCost.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.spinNewPriceFromStandardCost.Properties.Mask.EditMask = "p4";
            this.spinNewPriceFromStandardCost.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinNewPriceFromStandardCost.Properties.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.spinNewPriceFromStandardCost.Properties.ReadOnly = true;
            this.spinNewPriceFromStandardCost.Size = new System.Drawing.Size(100, 23);
            this.spinNewPriceFromStandardCost.TabIndex = 1;
            // 
            // lblNewPriceFromStandardCost
            // 
            this.lblNewPriceFromStandardCost.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewPriceFromStandardCost.Location = new System.Drawing.Point(6, 13);
            this.lblNewPriceFromStandardCost.Name = "lblNewPriceFromStandardCost";
            this.lblNewPriceFromStandardCost.Size = new System.Drawing.Size(150, 17);
            this.lblNewPriceFromStandardCost.TabIndex = 0;
            this.lblNewPriceFromStandardCost.Text = "ახალი ფასი / შ-დან:";
            // 
            // spinNewListPrice
            // 
            this.spinNewListPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinNewListPrice.EnterMoveNextControl = true;
            this.spinNewListPrice.Location = new System.Drawing.Point(165, 39);
            this.spinNewListPrice.Name = "spinNewListPrice";
            this.spinNewListPrice.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinNewListPrice.Properties.Appearance.Options.UseFont = true;
            this.spinNewListPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinNewListPrice.Properties.DisplayFormat.FormatString = "p4";
            this.spinNewListPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinNewListPrice.Properties.EditFormat.FormatString = "p4";
            this.spinNewListPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinNewListPrice.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.spinNewListPrice.Properties.Mask.EditMask = "p4";
            this.spinNewListPrice.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinNewListPrice.Properties.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.spinNewListPrice.Properties.ReadOnly = true;
            this.spinNewListPrice.Size = new System.Drawing.Size(100, 23);
            this.spinNewListPrice.TabIndex = 4;
            // 
            // lblNewListPrice
            // 
            this.lblNewListPrice.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewListPrice.Location = new System.Drawing.Point(6, 42);
            this.lblNewListPrice.Name = "lblNewListPrice";
            this.lblNewListPrice.Size = new System.Drawing.Size(122, 17);
            this.lblNewListPrice.TabIndex = 3;
            this.lblNewListPrice.Text = "ახალი ფასი / გ.:";
            // 
            // miChangeCurrencyCode
            // 
            this.miChangeCurrencyCode.Caption = "ვალუტის შეცვლა";
            this.miChangeCurrencyCode.Id = 18;
            this.miChangeCurrencyCode.Name = "miChangeCurrencyCode";
            this.miChangeCurrencyCode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.miChangeCurrencyCode_ItemClick);
            // 
            // frmProductBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsFiltered = true;
            this.IsFilterPanelVisible = true;
            this.Name = "frmProductBrowse";
            this.ObjectName = Apothex.DataType.ObjectNames.Product;
            this.OptionsBaseForm.IsPrintable = true;
            this.OptionsBaseForm.Text = "პროდუქცია";
            this.OptionsListForm.IsAddable = false;
            this.OptionsListForm.IsApprovable = false;
            this.OptionsListForm.IsBlockable = false;
            this.OptionsListForm.IsChooseable = false;
            this.OptionsListForm.IsDeletable = false;
            this.OptionsListForm.IsDisapprovable = false;
            this.OptionsListForm.IsSystemColumnsable = true;
            this.OptionsListForm.IsUnblockable = false;
            this.OptionsGrid.ColumnID = "ProductID";
            this.OptionsGrid.ColumnStatusID = "Status";
            this.OptionsGrid.GridView = this.view;
            this.Text = "პროდუქცია";
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxTotalQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalQty1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalQty2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxMedicament.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxValidDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValidDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValidDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValidDate2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValidDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMedicament.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrency)).EndInit();
            this.tabAdditional.ResumeLayout(false);
            this.tabAdditional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateState.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxVendor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbVendor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSafetyStockLevel.Properties)).EndInit();
            this.tabPrice.ResumeLayout(false);
            this.tabPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkNewDiscountPct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNewDealerPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNewPriceFromStandardCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNewListPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNewDiscountPct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNewDealerPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNewPriceFromStandardCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNewListPrice.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView view;
        private Apothex.DataType.DS_Product ds;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage tabMain;
        private DevExpress.XtraEditors.LabelControl lblCurrency;
        private DevExpress.XtraEditors.LookUpEdit lookCurrency;
        private System.Windows.Forms.BindingSource bsCurrency;
        private DevExpress.XtraEditors.LabelControl lblTotalQty;
        private DevExpress.XtraEditors.ComboBoxEdit cboxTotalQty;
        private DevExpress.XtraEditors.SpinEdit spinTotalQty1;
        private DevExpress.XtraEditors.SpinEdit spinTotalQty2;
        private DevExpress.XtraEditors.ComboBoxEdit cboxMedicament;
        private DevExpress.XtraEditors.LabelControl lblValidDate;
        private DevExpress.XtraEditors.ComboBoxEdit cboxValidDate;
        private DevExpress.XtraEditors.DateEdit dateValidDate1;
        private DevExpress.XtraEditors.DateEdit dateValidDate2;
        private DevExpress.XtraEditors.LabelControl lblMedicament;
        private DevExpress.XtraEditors.TextEdit txtMedicament;
        private DevExpress.XtraTab.XtraTabPage tabPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit riPrice;
        private DevExpress.XtraEditors.SpinEdit spinNewListPrice;
        private DevExpress.XtraEditors.LabelControl lblNewListPrice;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnGenerateNewPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit riPct;
        private DevExpress.XtraEditors.SpinEdit spinNewDiscountPct;
        private DevExpress.XtraEditors.LabelControl lblNewDiscountPct;
        private DevExpress.XtraEditors.CheckEdit chkNewDiscountPct;
        private DevExpress.XtraEditors.CheckEdit chkNewListPrice;
        private DevExpress.XtraTab.XtraTabPage tabAdditional;
        private DevExpress.XtraEditors.CheckEdit chkSafetyStockLevel;
        private DevExpress.XtraEditors.ComboBoxEdit cboxVendor;
        private Apothex.Windows.Forms.ButtonBrowse bbVendor;
        private DevExpress.XtraEditors.LabelControl lblVendor;
        private DevExpress.XtraEditors.ComboBoxEdit cboxOrderID;
        private DevExpress.XtraEditors.TextEdit txtOrderID;
        private DevExpress.XtraEditors.LabelControl lblOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn colVendorName;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentName;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentSubcategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colValidDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryName;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandName;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colProductNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colMakeFlag;
        private DevExpress.XtraGrid.Columns.GridColumn colFinishedGoodsFlag;
        private DevExpress.XtraGrid.Columns.GridColumn colColor;
        private DevExpress.XtraGrid.Columns.GridColumn colSafetyStockLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colReorderPoint;
        private DevExpress.XtraGrid.Columns.GridColumn col_UnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn col_ListPrice;
        private DevExpress.XtraGrid.Columns.GridColumn col_DealerPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSize;
        private DevExpress.XtraGrid.Columns.GridColumn colSizeRange;
        private DevExpress.XtraGrid.Columns.GridColumn colSizeUnitMeasureCode;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colWeightUnitMeasureCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDaysToManufacture;
        private DevExpress.XtraGrid.Columns.GridColumn colProductLine;
        private DevExpress.XtraGrid.Columns.GridColumn colClass;
        private DevExpress.XtraGrid.Columns.GridColumn colStyle;
        private DevExpress.XtraGrid.Columns.GridColumn colSellStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSellEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscontinuedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colVendorID;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseOrderDetailID;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentID;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentSubcategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryCode;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitsInStock;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandID;
        private DevExpress.XtraGrid.Columns.GridColumn col_NewListPrice;
        private DevExpress.XtraGrid.Columns.GridColumn col_NewDealerPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colNewDiscountPct;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn col_DiscountPct;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxRate;
        private DevExpress.XtraEditors.CheckEdit chkNewDealerPrice;
        private DevExpress.XtraEditors.SpinEdit spinNewDealerPrice;
        private DevExpress.XtraEditors.LabelControl lblNewDealerPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchName;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchID;
        private DevExpress.XtraGrid.Columns.GridColumn colGenericName;
        private DevExpress.XtraGrid.Columns.GridColumn colGenericID;
        private DevExpress.XtraEditors.DateEdit dateState;
        private DevExpress.XtraEditors.LabelControl lblState;
        private DevExpress.XtraEditors.ComboBoxEdit cboxState;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCurrencyCode;
        private DevExpress.XtraEditors.ComboBoxEdit cboxBranch;
        private Windows.Forms.ButtonBrowse bbBranch;
        private DevExpress.XtraEditors.LabelControl lblBranch;
        private DevExpress.XtraEditors.DateEdit dateOrderDate2;
        private DevExpress.XtraEditors.DateEdit dateOrderDate1;
        private DevExpress.XtraEditors.ComboBoxEdit cboxOrderDate;
        private DevExpress.XtraEditors.LabelControl lblStartDate;
        private DevExpress.XtraBars.BarButtonItem miChangeCurrencyCode;
        private DevExpress.XtraEditors.CheckEdit chkNewPriceFromStandardCost;
        private DevExpress.XtraEditors.SpinEdit spinNewPriceFromStandardCost;
        private DevExpress.XtraEditors.LabelControl lblNewPriceFromStandardCost;
        private DevExpress.XtraGrid.Columns.GridColumn col__PricePct;
    }
}