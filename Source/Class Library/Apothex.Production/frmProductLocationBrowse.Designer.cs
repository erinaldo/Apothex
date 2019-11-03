namespace Apothex.Production
{
    partial class frmProductLocationBrowse
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
            this.colInUse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBranchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicamentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicamentCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicamentSubcategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenericName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitsInStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ListPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_OneUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValidDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMakeFlag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinishedGoodsFlag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSafetyStockLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReorderPoint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_UnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col__PricePct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_DealerPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountPct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col__PurchaseLineTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col__SalesLineTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col__PurchaseTaxAmt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col__SalesTaxAmt = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colProductLocationID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseOrderDetailID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicamentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicamentCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicamentSubcategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenericID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ds = new Apothex.DataType.DS_ProductLocation();
            this.bsBranch = new System.Windows.Forms.BindingSource();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabMain = new DevExpress.XtraTab.XtraTabPage();
            this.lookCurrency = new DevExpress.XtraEditors.LookUpEdit();
            this.bsCurrency = new System.Windows.Forms.BindingSource();
            this.lblCurrency = new DevExpress.XtraEditors.LabelControl();
            this.cboxMedicamentName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lookMedicamentSubcategory = new DevExpress.XtraEditors.LookUpEdit();
            this.bsMedicamentSubcategory = new System.Windows.Forms.BindingSource();
            this.lblMedicamentSubcategory = new DevExpress.XtraEditors.LabelControl();
            this.lookMedicamentCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.bsMedicamentCategory = new System.Windows.Forms.BindingSource();
            this.lblMedicamentCategory = new DevExpress.XtraEditors.LabelControl();
            this.lblBranch = new DevExpress.XtraEditors.LabelControl();
            this.lookBranch = new DevExpress.XtraEditors.LookUpEdit();
            this.lblValidDate = new DevExpress.XtraEditors.LabelControl();
            this.cboxValidDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateValidDate1 = new DevExpress.XtraEditors.DateEdit();
            this.dateValidDate2 = new DevExpress.XtraEditors.DateEdit();
            this.lblMedicament = new DevExpress.XtraEditors.LabelControl();
            this.txtMedicament = new DevExpress.XtraEditors.TextEdit();
            this.tabAdditional = new DevExpress.XtraTab.XtraTabPage();
            this.chkSafetyStockLevel = new DevExpress.XtraEditors.CheckEdit();
            this.dateState = new DevExpress.XtraEditors.DateEdit();
            this.lblState = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalQty = new DevExpress.XtraEditors.LabelControl();
            this.cboxState = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboxTotalQty = new DevExpress.XtraEditors.ComboBoxEdit();
            this.spinTotalQty1 = new DevExpress.XtraEditors.SpinEdit();
            this.spinTotalQty2 = new DevExpress.XtraEditors.SpinEdit();
            this.miShowProductLocationPurchaseOrderHeader = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxMedicamentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookMedicamentSubcategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicamentSubcategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookMedicamentCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicamentCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxValidDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValidDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValidDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValidDate2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValidDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMedicament.Properties)).BeginInit();
            this.tabAdditional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkSafetyStockLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateState.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxTotalQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalQty1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalQty2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.xtraTabControl);
            this.pnlFilter.Size = new System.Drawing.Size(784, 170);
            this.pnlFilter.Controls.SetChildIndex(this.xtraTabControl, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnFilter, 0);
            // 
            // bsGridControl
            // 
            this.bsGridControl.DataMember = "VW_ProductLocation";
            this.bsGridControl.DataSource = this.ds;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridControl);
            this.pnlGrid.Location = new System.Drawing.Point(0, 209);
            this.pnlGrid.Size = new System.Drawing.Size(784, 353);
            // 
            // btnFilter
            // 
            this.btnFilter.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.Appearance.Options.UseFont = true;
            this.btnFilter.Location = new System.Drawing.Point(752, 112);
            // 
            // popupMenu
            // 
            this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.miShowProductLocationPurchaseOrderHeader, true)});
            this.popupMenu.MenuAppearance.Menu.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popupMenu.MenuAppearance.Menu.Options.UseFont = true;
            // 
            // colInUse
            // 
            this.colInUse.Caption = "არჩეული";
            this.colInUse.FieldName = "InUse";
            this.colInUse.Name = "colInUse";
            this.colInUse.Width = 20;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bsGridControl;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(784, 353);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridControl_ProcessGridKey);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBranchName,
            this.colMedicamentName,
            this.colMedicamentCategoryName,
            this.colMedicamentSubcategoryName,
            this.colGenericName,
            this.colProductNumber,
            this.colUnitsInStock,
            this.colQuantity,
            this.col_Quantity,
            this.col_ListPrice,
            this.col_OneUnitPrice,
            this.colValidDate,
            this.colCountryName,
            this.colBrandName,
            this.colSerie,
            this.colMakeFlag,
            this.colFinishedGoodsFlag,
            this.colColor,
            this.colSafetyStockLevel,
            this.colReorderPoint,
            this.col_UnitPrice,
            this.col__PricePct,
            this.col_DealerPrice,
            this.colDiscountPct,
            this.colTaxRate,
            this.col__PurchaseLineTotal,
            this.col__SalesLineTotal,
            this.col__PurchaseTaxAmt,
            this.col__SalesTaxAmt,
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
            this.colInUse,
            this.colBranchID,
            this.colProductLocationID,
            this.colPurchaseOrderDetailID,
            this.colProductID,
            this.colMedicamentID,
            this.colMedicamentCategoryID,
            this.colMedicamentSubcategoryID,
            this.colGenericID,
            this.colCountryCode,
            this.colBrandID,
            this.colModifiedUserID,
            this.colModifier,
            this.colModifiedDate});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Yellow;
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.Orange;
            styleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            styleFormatCondition1.Appearance.Options.HighPriority = true;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colInUse;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = true;
            this.gridView.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMedicamentName, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colValidDate, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView_CustomUnboundColumnData);
            // 
            // colBranchName
            // 
            this.colBranchName.Caption = "ფილიალი";
            this.colBranchName.FieldName = "BranchName";
            this.colBranchName.Name = "colBranchName";
            this.colBranchName.Visible = true;
            this.colBranchName.VisibleIndex = 0;
            this.colBranchName.Width = 20;
            // 
            // colMedicamentName
            // 
            this.colMedicamentName.Caption = "პროდუქციის დასახელება";
            this.colMedicamentName.FieldName = "MedicamentName";
            this.colMedicamentName.Name = "colMedicamentName";
            this.colMedicamentName.Visible = true;
            this.colMedicamentName.VisibleIndex = 1;
            this.colMedicamentName.Width = 20;
            // 
            // colMedicamentCategoryName
            // 
            this.colMedicamentCategoryName.Caption = "კატეგორია";
            this.colMedicamentCategoryName.FieldName = "MedicamentCategoryName";
            this.colMedicamentCategoryName.Name = "colMedicamentCategoryName";
            this.colMedicamentCategoryName.Width = 20;
            // 
            // colMedicamentSubcategoryName
            // 
            this.colMedicamentSubcategoryName.Caption = "ქვეკატეგორია";
            this.colMedicamentSubcategoryName.FieldName = "MedicamentSubcategoryName";
            this.colMedicamentSubcategoryName.Name = "colMedicamentSubcategoryName";
            this.colMedicamentSubcategoryName.Width = 20;
            // 
            // colGenericName
            // 
            this.colGenericName.Caption = "ჯენერიკი";
            this.colGenericName.FieldName = "GenericName";
            this.colGenericName.Name = "colGenericName";
            this.colGenericName.Width = 20;
            // 
            // colProductNumber
            // 
            this.colProductNumber.Caption = "პროდ. №";
            this.colProductNumber.FieldName = "ProductNumber";
            this.colProductNumber.Name = "colProductNumber";
            this.colProductNumber.Width = 20;
            // 
            // colUnitsInStock
            // 
            this.colUnitsInStock.Caption = "დაყოფა";
            this.colUnitsInStock.DisplayFormat.FormatString = "n00";
            this.colUnitsInStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitsInStock.FieldName = "UnitsInStock";
            this.colUnitsInStock.GroupFormat.FormatString = "n00";
            this.colUnitsInStock.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitsInStock.Name = "colUnitsInStock";
            this.colUnitsInStock.Visible = true;
            this.colUnitsInStock.VisibleIndex = 2;
            this.colUnitsInStock.Width = 20;
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
            this.colQuantity.VisibleIndex = 3;
            this.colQuantity.Width = 39;
            // 
            // col_Quantity
            // 
            this.col_Quantity.Caption = "ნაშთი (კალკ.)";
            this.col_Quantity.FieldName = "_Quantity";
            this.col_Quantity.Name = "col_Quantity";
            this.col_Quantity.Tag = true;
            this.col_Quantity.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.col_Quantity.Visible = true;
            this.col_Quantity.VisibleIndex = 4;
            this.col_Quantity.Width = 39;
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
            this.col_ListPrice.VisibleIndex = 5;
            this.col_ListPrice.Width = 39;
            // 
            // col_OneUnitPrice
            // 
            this.col_OneUnitPrice.Caption = "ფასი / ც.";
            this.col_OneUnitPrice.DisplayFormat.FormatString = "n4";
            this.col_OneUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_OneUnitPrice.FieldName = "_OneUnitPrice";
            this.col_OneUnitPrice.GroupFormat.FormatString = "n2";
            this.col_OneUnitPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_OneUnitPrice.Name = "col_OneUnitPrice";
            this.col_OneUnitPrice.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col_OneUnitPrice.Visible = true;
            this.col_OneUnitPrice.VisibleIndex = 6;
            this.col_OneUnitPrice.Width = 39;
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
            this.colValidDate.Width = 39;
            // 
            // colCountryName
            // 
            this.colCountryName.Caption = "მწ. ქვეყანა";
            this.colCountryName.FieldName = "CountryName";
            this.colCountryName.Name = "colCountryName";
            this.colCountryName.Visible = true;
            this.colCountryName.VisibleIndex = 8;
            this.colCountryName.Width = 39;
            // 
            // colBrandName
            // 
            this.colBrandName.Caption = "ბრენდი";
            this.colBrandName.FieldName = "BrandName";
            this.colBrandName.Name = "colBrandName";
            this.colBrandName.Visible = true;
            this.colBrandName.VisibleIndex = 9;
            this.colBrandName.Width = 35;
            // 
            // colSerie
            // 
            this.colSerie.Caption = "სერია";
            this.colSerie.FieldName = "Serie";
            this.colSerie.Name = "colSerie";
            this.colSerie.Visible = true;
            this.colSerie.VisibleIndex = 10;
            this.colSerie.Width = 40;
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
            this.col_UnitPrice.VisibleIndex = 11;
            this.col_UnitPrice.Width = 43;
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
            this.col__PricePct.VisibleIndex = 12;
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
            this.col_DealerPrice.Width = 54;
            // 
            // colDiscountPct
            // 
            this.colDiscountPct.Caption = "ფასდაკლება";
            this.colDiscountPct.DisplayFormat.FormatString = "p4";
            this.colDiscountPct.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscountPct.FieldName = "DiscountPct";
            this.colDiscountPct.GroupFormat.FormatString = "p4";
            this.colDiscountPct.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscountPct.Name = "colDiscountPct";
            this.colDiscountPct.Visible = true;
            this.colDiscountPct.VisibleIndex = 13;
            this.colDiscountPct.Width = 55;
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
            this.colTaxRate.VisibleIndex = 14;
            this.colTaxRate.Width = 59;
            // 
            // col__PurchaseLineTotal
            // 
            this.col__PurchaseLineTotal.AppearanceCell.BackColor = System.Drawing.Color.Cornsilk;
            this.col__PurchaseLineTotal.AppearanceCell.Options.UseBackColor = true;
            this.col__PurchaseLineTotal.Caption = "ჯამი /შ.";
            this.col__PurchaseLineTotal.DisplayFormat.FormatString = "n4";
            this.col__PurchaseLineTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col__PurchaseLineTotal.FieldName = "col__PurchaseLineTotal";
            this.col__PurchaseLineTotal.GroupFormat.FormatString = "n2";
            this.col__PurchaseLineTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col__PurchaseLineTotal.Name = "col__PurchaseLineTotal";
            this.col__PurchaseLineTotal.SummaryItem.DisplayFormat = "{0:n2}";
            this.col__PurchaseLineTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.col__PurchaseLineTotal.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col__PurchaseLineTotal.Visible = true;
            this.col__PurchaseLineTotal.VisibleIndex = 15;
            this.col__PurchaseLineTotal.Width = 60;
            // 
            // col__SalesLineTotal
            // 
            this.col__SalesLineTotal.AppearanceCell.BackColor = System.Drawing.Color.Cornsilk;
            this.col__SalesLineTotal.AppearanceCell.Options.UseBackColor = true;
            this.col__SalesLineTotal.Caption = "ჯამი / გ.";
            this.col__SalesLineTotal.DisplayFormat.FormatString = "n4";
            this.col__SalesLineTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col__SalesLineTotal.FieldName = "col__SalesLineTotal";
            this.col__SalesLineTotal.GroupFormat.FormatString = "n2";
            this.col__SalesLineTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col__SalesLineTotal.Name = "col__SalesLineTotal";
            this.col__SalesLineTotal.SummaryItem.DisplayFormat = "{0:n2}";
            this.col__SalesLineTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.col__SalesLineTotal.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col__SalesLineTotal.Visible = true;
            this.col__SalesLineTotal.VisibleIndex = 16;
            this.col__SalesLineTotal.Width = 66;
            // 
            // col__PurchaseTaxAmt
            // 
            this.col__PurchaseTaxAmt.Caption = "დ.ღ.გ. თანხა / შ.";
            this.col__PurchaseTaxAmt.DisplayFormat.FormatString = "n4";
            this.col__PurchaseTaxAmt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col__PurchaseTaxAmt.FieldName = "col__PurchaseTaxAmt";
            this.col__PurchaseTaxAmt.GroupFormat.FormatString = "n2";
            this.col__PurchaseTaxAmt.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col__PurchaseTaxAmt.Name = "col__PurchaseTaxAmt";
            this.col__PurchaseTaxAmt.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col__PurchaseTaxAmt.Visible = true;
            this.col__PurchaseTaxAmt.VisibleIndex = 17;
            this.col__PurchaseTaxAmt.Width = 20;
            // 
            // col__SalesTaxAmt
            // 
            this.col__SalesTaxAmt.Caption = "დ.ღ.გ. თანხა / გ.";
            this.col__SalesTaxAmt.DisplayFormat.FormatString = "n4";
            this.col__SalesTaxAmt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col__SalesTaxAmt.FieldName = "col__SalesTaxAmt";
            this.col__SalesTaxAmt.GroupFormat.FormatString = "n2";
            this.col__SalesTaxAmt.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col__SalesTaxAmt.Name = "col__SalesTaxAmt";
            this.col__SalesTaxAmt.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col__SalesTaxAmt.Visible = true;
            this.col__SalesTaxAmt.VisibleIndex = 18;
            this.col__SalesTaxAmt.Width = 20;
            // 
            // colSize
            // 
            this.colSize.Caption = "ზომა";
            this.colSize.FieldName = "Size";
            this.colSize.Name = "colSize";
            this.colSize.Width = 20;
            // 
            // colSizeRange
            // 
            this.colSizeRange.Caption = "ზომ. დიაპ.";
            this.colSizeRange.FieldName = "SizeRange";
            this.colSizeRange.Name = "colSizeRange";
            this.colSizeRange.Width = 20;
            // 
            // colSizeUnitMeasureCode
            // 
            this.colSizeUnitMeasureCode.Caption = "ზომ. ერთ.";
            this.colSizeUnitMeasureCode.FieldName = "SizeUnitMeasureCode";
            this.colSizeUnitMeasureCode.Name = "colSizeUnitMeasureCode";
            this.colSizeUnitMeasureCode.Width = 20;
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
            this.colWeight.Width = 20;
            // 
            // colWeightUnitMeasureCode
            // 
            this.colWeightUnitMeasureCode.Caption = "წონ. ერთ.";
            this.colWeightUnitMeasureCode.FieldName = "WeightUnitMeasureCode";
            this.colWeightUnitMeasureCode.Name = "colWeightUnitMeasureCode";
            this.colWeightUnitMeasureCode.Width = 20;
            // 
            // colDaysToManufacture
            // 
            this.colDaysToManufacture.Caption = "წარმ. ხანგძლ.";
            this.colDaysToManufacture.FieldName = "DaysToManufacture";
            this.colDaysToManufacture.Name = "colDaysToManufacture";
            this.colDaysToManufacture.Width = 20;
            // 
            // colProductLine
            // 
            this.colProductLine.Caption = "პროდ. ხაზი.";
            this.colProductLine.FieldName = "ProductLine";
            this.colProductLine.Name = "colProductLine";
            this.colProductLine.Width = 20;
            // 
            // colClass
            // 
            this.colClass.Caption = "ხარისხი";
            this.colClass.FieldName = "Class";
            this.colClass.Name = "colClass";
            this.colClass.Width = 20;
            // 
            // colStyle
            // 
            this.colStyle.Caption = "სტილი";
            this.colStyle.FieldName = "Style";
            this.colStyle.Name = "colStyle";
            this.colStyle.Width = 20;
            // 
            // colSellStartDate
            // 
            this.colSellStartDate.Caption = "გაყ. დაიწყოს";
            this.colSellStartDate.FieldName = "SellStartDate";
            this.colSellStartDate.Name = "colSellStartDate";
            this.colSellStartDate.Width = 20;
            // 
            // colSellEndDate
            // 
            this.colSellEndDate.Caption = "გაყ. დასრულდეს";
            this.colSellEndDate.FieldName = "SellEndDate";
            this.colSellEndDate.Name = "colSellEndDate";
            this.colSellEndDate.Width = 20;
            // 
            // colDiscontinuedDate
            // 
            this.colDiscontinuedDate.Caption = "გაყ. შეწყდა";
            this.colDiscontinuedDate.FieldName = "DiscontinuedDate";
            this.colDiscontinuedDate.Name = "colDiscontinuedDate";
            this.colDiscontinuedDate.Width = 20;
            // 
            // colBranchID
            // 
            this.colBranchID.FieldName = "BranchID";
            this.colBranchID.Name = "colBranchID";
            this.colBranchID.Width = 20;
            // 
            // colProductLocationID
            // 
            this.colProductLocationID.FieldName = "ProductLocationID";
            this.colProductLocationID.Name = "colProductLocationID";
            this.colProductLocationID.Width = 20;
            // 
            // colPurchaseOrderDetailID
            // 
            this.colPurchaseOrderDetailID.FieldName = "PurchaseOrderDetailID";
            this.colPurchaseOrderDetailID.Name = "colPurchaseOrderDetailID";
            this.colPurchaseOrderDetailID.Width = 20;
            // 
            // colProductID
            // 
            this.colProductID.FieldName = "ProductID";
            this.colProductID.Name = "colProductID";
            this.colProductID.Width = 20;
            // 
            // colMedicamentID
            // 
            this.colMedicamentID.FieldName = "MedicamentID";
            this.colMedicamentID.Name = "colMedicamentID";
            this.colMedicamentID.Width = 20;
            // 
            // colMedicamentCategoryID
            // 
            this.colMedicamentCategoryID.FieldName = "MedicamentCategoryID";
            this.colMedicamentCategoryID.Name = "colMedicamentCategoryID";
            this.colMedicamentCategoryID.Width = 20;
            // 
            // colMedicamentSubcategoryID
            // 
            this.colMedicamentSubcategoryID.FieldName = "MedicamentSubcategoryID";
            this.colMedicamentSubcategoryID.Name = "colMedicamentSubcategoryID";
            this.colMedicamentSubcategoryID.Width = 20;
            // 
            // colGenericID
            // 
            this.colGenericID.FieldName = "GenericID";
            this.colGenericID.Name = "colGenericID";
            this.colGenericID.Width = 20;
            // 
            // colCountryCode
            // 
            this.colCountryCode.FieldName = "CountryCode";
            this.colCountryCode.Name = "colCountryCode";
            this.colCountryCode.Width = 20;
            // 
            // colBrandID
            // 
            this.colBrandID.FieldName = "BrandID";
            this.colBrandID.Name = "colBrandID";
            this.colBrandID.Width = 20;
            // 
            // colModifiedUserID
            // 
            this.colModifiedUserID.FieldName = "ModifiedUserID";
            this.colModifiedUserID.Name = "colModifiedUserID";
            this.colModifiedUserID.Width = 20;
            // 
            // colModifier
            // 
            this.colModifier.FieldName = "Modifier";
            this.colModifier.Name = "colModifier";
            this.colModifier.Width = 20;
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
            this.xtraTabControl.Size = new System.Drawing.Size(780, 166);
            this.xtraTabControl.TabIndex = 0;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabMain,
            this.tabAdditional});
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.lookCurrency);
            this.tabMain.Controls.Add(this.lblCurrency);
            this.tabMain.Controls.Add(this.cboxMedicamentName);
            this.tabMain.Controls.Add(this.lookMedicamentSubcategory);
            this.tabMain.Controls.Add(this.lblMedicamentSubcategory);
            this.tabMain.Controls.Add(this.lookMedicamentCategory);
            this.tabMain.Controls.Add(this.lblMedicamentCategory);
            this.tabMain.Controls.Add(this.lblBranch);
            this.tabMain.Controls.Add(this.lookBranch);
            this.tabMain.Controls.Add(this.lblValidDate);
            this.tabMain.Controls.Add(this.cboxValidDate);
            this.tabMain.Controls.Add(this.dateValidDate1);
            this.tabMain.Controls.Add(this.dateValidDate2);
            this.tabMain.Controls.Add(this.lblMedicament);
            this.tabMain.Controls.Add(this.txtMedicament);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(774, 137);
            this.tabMain.Text = "მთავარი";
            // 
            // lookCurrency
            // 
            this.lookCurrency.EnterMoveNextControl = true;
            this.lookCurrency.Location = new System.Drawing.Point(152, 6);
            this.lookCurrency.Name = "lookCurrency";
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
            this.lookCurrency.Size = new System.Drawing.Size(312, 23);
            this.lookCurrency.TabIndex = 1;
            this.lookCurrency.EditValueChanged += new System.EventHandler(this.lookCurrency_EditValueChanged);
            // 
            // lblCurrency
            // 
            this.lblCurrency.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrency.Location = new System.Drawing.Point(6, 9);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(140, 17);
            this.lblCurrency.TabIndex = 0;
            this.lblCurrency.Text = "ვალუტაში ჩვენება:";
            // 
            // cboxMedicamentName
            // 
            this.cboxMedicamentName.EditValue = "a%";
            this.cboxMedicamentName.EnterMoveNextControl = true;
            this.cboxMedicamentName.Location = new System.Drawing.Point(152, 64);
            this.cboxMedicamentName.Name = "cboxMedicamentName";
            this.cboxMedicamentName.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxMedicamentName.Properties.Appearance.Options.UseFont = true;
            this.cboxMedicamentName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxMedicamentName.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!=",
            "%a%",
            "!%a%",
            "a%",
            "!a%",
            "%a",
            "!%a"});
            this.cboxMedicamentName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxMedicamentName.Size = new System.Drawing.Size(75, 23);
            this.cboxMedicamentName.TabIndex = 5;
            this.cboxMedicamentName.SelectedIndexChanged += new System.EventHandler(this.cboxMedicamentName_SelectedIndexChanged);
            // 
            // lookMedicamentSubcategory
            // 
            this.lookMedicamentSubcategory.EnterMoveNextControl = true;
            this.lookMedicamentSubcategory.Location = new System.Drawing.Point(586, 6);
            this.lookMedicamentSubcategory.Name = "lookMedicamentSubcategory";
            this.lookMedicamentSubcategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookMedicamentSubcategory.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookMedicamentSubcategory.Properties.Appearance.Options.UseFont = true;
            this.lookMedicamentSubcategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookMedicamentSubcategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.lookMedicamentSubcategory.Properties.DataSource = this.bsMedicamentSubcategory;
            this.lookMedicamentSubcategory.Properties.DisplayMember = "Caption";
            this.lookMedicamentSubcategory.Properties.NullText = "";
            this.lookMedicamentSubcategory.Properties.ShowHeader = false;
            this.lookMedicamentSubcategory.Properties.SortColumnIndex = 2;
            this.lookMedicamentSubcategory.Properties.ValueMember = "ID";
            this.lookMedicamentSubcategory.Size = new System.Drawing.Size(312, 23);
            this.lookMedicamentSubcategory.TabIndex = 10;
            // 
            // lblMedicamentSubcategory
            // 
            this.lblMedicamentSubcategory.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMedicamentSubcategory.Location = new System.Drawing.Point(470, 9);
            this.lblMedicamentSubcategory.Name = "lblMedicamentSubcategory";
            this.lblMedicamentSubcategory.Size = new System.Drawing.Size(110, 17);
            this.lblMedicamentSubcategory.TabIndex = 9;
            this.lblMedicamentSubcategory.Text = "ქვეკატეგორია:";
            // 
            // lookMedicamentCategory
            // 
            this.lookMedicamentCategory.EnterMoveNextControl = true;
            this.lookMedicamentCategory.Location = new System.Drawing.Point(152, 93);
            this.lookMedicamentCategory.Name = "lookMedicamentCategory";
            this.lookMedicamentCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookMedicamentCategory.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookMedicamentCategory.Properties.Appearance.Options.UseFont = true;
            this.lookMedicamentCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookMedicamentCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.lookMedicamentCategory.Properties.DataSource = this.bsMedicamentCategory;
            this.lookMedicamentCategory.Properties.DisplayMember = "Caption";
            this.lookMedicamentCategory.Properties.NullText = "";
            this.lookMedicamentCategory.Properties.ShowHeader = false;
            this.lookMedicamentCategory.Properties.SortColumnIndex = 2;
            this.lookMedicamentCategory.Properties.ValueMember = "ID";
            this.lookMedicamentCategory.Size = new System.Drawing.Size(312, 23);
            this.lookMedicamentCategory.TabIndex = 8;
            this.lookMedicamentCategory.EditValueChanged += new System.EventHandler(this.lookMedicamentCategory_EditValueChanged);
            // 
            // lblMedicamentCategory
            // 
            this.lblMedicamentCategory.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMedicamentCategory.Location = new System.Drawing.Point(6, 96);
            this.lblMedicamentCategory.Name = "lblMedicamentCategory";
            this.lblMedicamentCategory.Size = new System.Drawing.Size(86, 17);
            this.lblMedicamentCategory.TabIndex = 7;
            this.lblMedicamentCategory.Text = "კატეგორია:";
            // 
            // lblBranch
            // 
            this.lblBranch.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBranch.Location = new System.Drawing.Point(6, 38);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(81, 17);
            this.lblBranch.TabIndex = 2;
            this.lblBranch.Text = "ფილიალი:";
            // 
            // lookBranch
            // 
            this.lookBranch.EnterMoveNextControl = true;
            this.lookBranch.Location = new System.Drawing.Point(152, 35);
            this.lookBranch.Name = "lookBranch";
            this.lookBranch.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookBranch.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookBranch.Properties.Appearance.Options.UseFont = true;
            this.lookBranch.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookBranch.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookBranch.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.lookBranch.Properties.DataSource = this.bsBranch;
            this.lookBranch.Properties.DisplayMember = "Caption";
            this.lookBranch.Properties.NullText = "";
            this.lookBranch.Properties.ShowHeader = false;
            this.lookBranch.Properties.ValueMember = "ID";
            this.lookBranch.Size = new System.Drawing.Size(312, 23);
            this.lookBranch.TabIndex = 3;
            // 
            // lblValidDate
            // 
            this.lblValidDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblValidDate.Location = new System.Drawing.Point(470, 38);
            this.lblValidDate.Name = "lblValidDate";
            this.lblValidDate.Size = new System.Drawing.Size(41, 17);
            this.lblValidDate.TabIndex = 11;
            this.lblValidDate.Text = "ვადა:";
            // 
            // cboxValidDate
            // 
            this.cboxValidDate.EnterMoveNextControl = true;
            this.cboxValidDate.Location = new System.Drawing.Point(586, 35);
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
            this.cboxValidDate.Size = new System.Drawing.Size(80, 23);
            this.cboxValidDate.TabIndex = 12;
            this.cboxValidDate.SelectedIndexChanged += new System.EventHandler(this.cboxValidDate_SelectedIndexChanged);
            // 
            // dateValidDate1
            // 
            this.dateValidDate1.EditValue = null;
            this.dateValidDate1.Enabled = false;
            this.dateValidDate1.EnterMoveNextControl = true;
            this.dateValidDate1.Location = new System.Drawing.Point(672, 35);
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
            this.dateValidDate1.TabIndex = 13;
            this.dateValidDate1.EditValueChanged += new System.EventHandler(this.dateValidDate1_EditValueChanged);
            // 
            // dateValidDate2
            // 
            this.dateValidDate2.EditValue = null;
            this.dateValidDate2.Enabled = false;
            this.dateValidDate2.EnterMoveNextControl = true;
            this.dateValidDate2.Location = new System.Drawing.Point(788, 35);
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
            this.dateValidDate2.TabIndex = 14;
            this.dateValidDate2.EditValueChanged += new System.EventHandler(this.dateValidDate2_EditValueChanged);
            // 
            // lblMedicament
            // 
            this.lblMedicament.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMedicament.Location = new System.Drawing.Point(6, 67);
            this.lblMedicament.Name = "lblMedicament";
            this.lblMedicament.Size = new System.Drawing.Size(97, 17);
            this.lblMedicament.TabIndex = 4;
            this.lblMedicament.Text = "დასახელება:";
            // 
            // txtMedicament
            // 
            this.txtMedicament.Location = new System.Drawing.Point(233, 64);
            this.txtMedicament.Name = "txtMedicament";
            this.txtMedicament.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMedicament.Properties.Appearance.Options.UseFont = true;
            this.txtMedicament.Size = new System.Drawing.Size(231, 23);
            this.txtMedicament.TabIndex = 6;
            this.txtMedicament.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMedicament_KeyDown);
            // 
            // tabAdditional
            // 
            this.tabAdditional.Controls.Add(this.chkSafetyStockLevel);
            this.tabAdditional.Controls.Add(this.dateState);
            this.tabAdditional.Controls.Add(this.lblState);
            this.tabAdditional.Controls.Add(this.lblTotalQty);
            this.tabAdditional.Controls.Add(this.cboxState);
            this.tabAdditional.Controls.Add(this.cboxTotalQty);
            this.tabAdditional.Controls.Add(this.spinTotalQty1);
            this.tabAdditional.Controls.Add(this.spinTotalQty2);
            this.tabAdditional.Name = "tabAdditional";
            this.tabAdditional.Size = new System.Drawing.Size(774, 137);
            this.tabAdditional.Text = "დამატებითი";
            // 
            // chkSafetyStockLevel
            // 
            this.chkSafetyStockLevel.Location = new System.Drawing.Point(131, 65);
            this.chkSafetyStockLevel.Name = "chkSafetyStockLevel";
            this.chkSafetyStockLevel.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSafetyStockLevel.Properties.Appearance.Options.UseFont = true;
            this.chkSafetyStockLevel.Properties.Caption = "კრიტიკული რაოდენობა";
            this.chkSafetyStockLevel.Size = new System.Drawing.Size(312, 22);
            this.chkSafetyStockLevel.TabIndex = 13;
            // 
            // dateState
            // 
            this.dateState.EditValue = null;
            this.dateState.Enabled = false;
            this.dateState.EnterMoveNextControl = true;
            this.dateState.Location = new System.Drawing.Point(217, 35);
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
            this.dateState.TabIndex = 12;
            this.dateState.EditValueChanged += new System.EventHandler(this.dateState_EditValueChanged);
            // 
            // lblState
            // 
            this.lblState.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblState.Location = new System.Drawing.Point(7, 38);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(109, 17);
            this.lblState.TabIndex = 4;
            this.lblState.Text = "მდგომარეობა:";
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalQty.Location = new System.Drawing.Point(7, 9);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(106, 17);
            this.lblTotalQty.TabIndex = 4;
            this.lblTotalQty.Text = "ჯამური რაოდ:";
            // 
            // cboxState
            // 
            this.cboxState.EditValue = "";
            this.cboxState.EnterMoveNextControl = true;
            this.cboxState.Location = new System.Drawing.Point(131, 35);
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
            this.cboxState.TabIndex = 5;
            this.cboxState.SelectedIndexChanged += new System.EventHandler(this.cboxState_SelectedIndexChanged);
            // 
            // cboxTotalQty
            // 
            this.cboxTotalQty.EditValue = ">";
            this.cboxTotalQty.EnterMoveNextControl = true;
            this.cboxTotalQty.Location = new System.Drawing.Point(131, 6);
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
            "<",
            "[ ]"});
            this.cboxTotalQty.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxTotalQty.Size = new System.Drawing.Size(80, 23);
            this.cboxTotalQty.TabIndex = 5;
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
            this.spinTotalQty1.Location = new System.Drawing.Point(217, 6);
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
            this.spinTotalQty1.TabIndex = 6;
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
            this.spinTotalQty2.Location = new System.Drawing.Point(333, 6);
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
            this.spinTotalQty2.TabIndex = 7;
            // 
            // miShowProductLocationPurchaseOrderHeader
            // 
            this.miShowProductLocationPurchaseOrderHeader.Caption = "პროდუქციის შესყიდვის ინფორმაცია";
            this.miShowProductLocationPurchaseOrderHeader.Id = 17;
            this.miShowProductLocationPurchaseOrderHeader.Name = "miShowProductLocationPurchaseOrderHeader";
            this.miShowProductLocationPurchaseOrderHeader.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.miShowProductLocationPurchaseOrderHeader_ItemClick);
            // 
            // frmProductLocationBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsFiltered = true;
            this.IsFilterPanelVisible = true;
            this.Name = "frmProductLocationBrowse";
            this.ObjectName = Apothex.DataType.ObjectNames.ProductLocation;
            this.OptionsBaseForm.Text = "პროდუქცია ფილიალებში";
            this.OptionsListForm.IsAddable = false;
            this.OptionsListForm.IsApprovable = false;
            this.OptionsListForm.IsBlockable = false;
            this.OptionsListForm.IsDeletable = false;
            this.OptionsListForm.IsDisapprovable = false;
            this.OptionsListForm.IsFilterApprovable = false;
            this.OptionsListForm.IsSystemColumnsable = true;
            this.OptionsListForm.IsUnblockable = false;
            this.OptionsGrid.ColumnID = "ProductLocationID";
            this.OptionsGrid.ColumnStatusID = null;
            this.OptionsGrid.GridView = this.gridView;
            this.Text = "პროდუქცია ფილიალებში";
            this.Shown += new System.EventHandler(this.frmProductLocationBrowse_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxMedicamentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookMedicamentSubcategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicamentSubcategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookMedicamentCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicamentCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxValidDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValidDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValidDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValidDate2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValidDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMedicament.Properties)).EndInit();
            this.tabAdditional.ResumeLayout(false);
            this.tabAdditional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkSafetyStockLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateState.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxTotalQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalQty1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalQty2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private Apothex.DataType.DS_ProductLocation ds;
        private System.Windows.Forms.BindingSource bsBranch;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage tabMain;
        private DevExpress.XtraEditors.LabelControl lblBranch;
        private DevExpress.XtraEditors.LookUpEdit lookBranch;
        private DevExpress.XtraEditors.LabelControl lblValidDate;
        private DevExpress.XtraEditors.ComboBoxEdit cboxValidDate;
        private DevExpress.XtraEditors.DateEdit dateValidDate1;
        private DevExpress.XtraEditors.DateEdit dateValidDate2;
        private DevExpress.XtraTab.XtraTabPage tabAdditional;
        private DevExpress.XtraEditors.LabelControl lblTotalQty;
        private DevExpress.XtraEditors.ComboBoxEdit cboxTotalQty;
        private DevExpress.XtraEditors.SpinEdit spinTotalQty1;
        private DevExpress.XtraEditors.SpinEdit spinTotalQty2;
        private DevExpress.XtraEditors.LabelControl lblMedicament;
        private DevExpress.XtraEditors.TextEdit txtMedicament;
        private DevExpress.XtraEditors.LookUpEdit lookMedicamentSubcategory;
        private DevExpress.XtraEditors.LabelControl lblMedicamentSubcategory;
        private DevExpress.XtraEditors.LookUpEdit lookMedicamentCategory;
        private DevExpress.XtraEditors.LabelControl lblMedicamentCategory;
        private System.Windows.Forms.BindingSource bsMedicamentSubcategory;
        private System.Windows.Forms.BindingSource bsMedicamentCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.ComboBoxEdit cboxMedicamentName;
        private DevExpress.XtraEditors.DateEdit dateState;
        private DevExpress.XtraEditors.LabelControl lblState;
        private DevExpress.XtraEditors.ComboBoxEdit cboxState;
        private DevExpress.XtraEditors.CheckEdit chkSafetyStockLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colProductNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentName;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentSubcategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colValidDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryName;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandName;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colMakeFlag;
        private DevExpress.XtraGrid.Columns.GridColumn colFinishedGoodsFlag;
        private DevExpress.XtraGrid.Columns.GridColumn colColor;
        private DevExpress.XtraGrid.Columns.GridColumn colSafetyStockLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colReorderPoint;
        private DevExpress.XtraGrid.Columns.GridColumn col_UnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn col_ListPrice;
        private DevExpress.XtraGrid.Columns.GridColumn col_DealerPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountPct;
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
        private DevExpress.XtraGrid.Columns.GridColumn colInUse;
        private DevExpress.XtraGrid.Columns.GridColumn colProductLocationID;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseOrderDetailID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentID;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitsInStock;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentSubcategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandID;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchName;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchID;
        private DevExpress.XtraGrid.Columns.GridColumn col_OneUnitPrice;
        private DevExpress.XtraBars.BarButtonItem miShowProductLocationPurchaseOrderHeader;
        private DevExpress.XtraGrid.Columns.GridColumn col_Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn colGenericName;
        private DevExpress.XtraGrid.Columns.GridColumn colGenericID;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxRate;
        private DevExpress.XtraGrid.Columns.GridColumn col__PurchaseLineTotal;
        private DevExpress.XtraGrid.Columns.GridColumn col__SalesLineTotal;
        private DevExpress.XtraGrid.Columns.GridColumn col__PurchaseTaxAmt;
        private DevExpress.XtraGrid.Columns.GridColumn col__SalesTaxAmt;
        private System.Windows.Forms.BindingSource bsCurrency;
        private DevExpress.XtraEditors.LookUpEdit lookCurrency;
        private DevExpress.XtraEditors.LabelControl lblCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn col__PricePct;
    }
}