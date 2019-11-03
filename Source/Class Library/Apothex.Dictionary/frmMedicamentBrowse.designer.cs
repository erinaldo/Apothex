namespace Apothex.Dictionary
{
    partial class frmMedicamentBrowse
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colInUse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMedicamentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicamentCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicamentSubcategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenericName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitsInStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_StandardCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ListPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_DealerPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountPct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValidDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMakeFlag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinishedGoodsFlag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSafetyStockLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReorderPoint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSizeRange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSizeUnitMeasureCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeightUnitMeasureCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaysToManufacture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStyle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicamentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicamentCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicamentSubcategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductModelID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscontinuedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenericID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApproverUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabMain = new DevExpress.XtraTab.XtraTabPage();
            this.lookCurrency = new DevExpress.XtraEditors.LookUpEdit();
            this.bsCurrency = new System.Windows.Forms.BindingSource(this.components);
            this.lblCurrency = new DevExpress.XtraEditors.LabelControl();
            this.lookCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.bsCategory = new System.Windows.Forms.BindingSource(this.components);
            this.cboxCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lookSubcategory = new DevExpress.XtraEditors.LookUpEdit();
            this.bsSubcategory = new System.Windows.Forms.BindingSource(this.components);
            this.lblCategory = new DevExpress.XtraEditors.LabelControl();
            this.cboxSubcategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblSubcategory = new DevExpress.XtraEditors.LabelControl();
            this.cboxProductID = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboxProductNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboxProductName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblProductID = new DevExpress.XtraEditors.LabelControl();
            this.lblProductNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblProductName = new DevExpress.XtraEditors.LabelControl();
            this.txtProductID = new DevExpress.XtraEditors.TextEdit();
            this.txtProductNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            this.tabAdditional = new DevExpress.XtraTab.XtraTabPage();
            this.cboxWeight = new DevExpress.XtraEditors.ComboBoxEdit();
            this.spinWeight2 = new DevExpress.XtraEditors.SpinEdit();
            this.spinWeight1 = new DevExpress.XtraEditors.SpinEdit();
            this.lblWeight = new DevExpress.XtraEditors.LabelControl();
            this.cboxSizeRange = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboxSize = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtSizeRange = new DevExpress.XtraEditors.TextEdit();
            this.lblSizeRange = new DevExpress.XtraEditors.LabelControl();
            this.txtSize = new DevExpress.XtraEditors.TextEdit();
            this.lblSize = new DevExpress.XtraEditors.LabelControl();
            this.cboxColor = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblColor = new DevExpress.XtraEditors.LabelControl();
            this.txtColor = new DevExpress.XtraEditors.TextEdit();
            this.chkFinishedGoodsFlag = new DevExpress.XtraEditors.CheckEdit();
            this.chkMakeFlag = new DevExpress.XtraEditors.CheckEdit();
            this.tabQuantity = new DevExpress.XtraTab.XtraTabPage();
            this.spinDaysToManufacture2 = new DevExpress.XtraEditors.SpinEdit();
            this.spinDaysToManufacture1 = new DevExpress.XtraEditors.SpinEdit();
            this.lblDaysToManufacture = new DevExpress.XtraEditors.LabelControl();
            this.spinReorderPoint2 = new DevExpress.XtraEditors.SpinEdit();
            this.spinReorderPoint1 = new DevExpress.XtraEditors.SpinEdit();
            this.lblReorderPoint = new DevExpress.XtraEditors.LabelControl();
            this.spinSafetyStockLevel2 = new DevExpress.XtraEditors.SpinEdit();
            this.spinSafetyStockLevel1 = new DevExpress.XtraEditors.SpinEdit();
            this.cboxDaysToManufacture = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboxReorderPoint = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboxSafetyStockLevel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblSafetyStockLevel = new DevExpress.XtraEditors.LabelControl();
            this.tabPrice = new DevExpress.XtraTab.XtraTabPage();
            this.spinListPrice2 = new DevExpress.XtraEditors.SpinEdit();
            this.spinListPrice1 = new DevExpress.XtraEditors.SpinEdit();
            this.cboxListPrice = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblListPrice = new DevExpress.XtraEditors.LabelControl();
            this.cboxStandardCost = new DevExpress.XtraEditors.ComboBoxEdit();
            this.spinStandardCost2 = new DevExpress.XtraEditors.SpinEdit();
            this.spinStandardCost1 = new DevExpress.XtraEditors.SpinEdit();
            this.lblStandardCost = new DevExpress.XtraEditors.LabelControl();
            this.ds = new Apothex.DataType.DS_Medicament();
            this.miMedicamentLocation = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookSubcategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSubcategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxSubcategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxProductNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            this.tabAdditional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinWeight2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinWeight1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxSizeRange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSizeRange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFinishedGoodsFlag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMakeFlag.Properties)).BeginInit();
            this.tabQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDaysToManufacture2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDaysToManufacture1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinReorderPoint2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinReorderPoint1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSafetyStockLevel2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSafetyStockLevel1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxDaysToManufacture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxReorderPoint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxSafetyStockLevel.Properties)).BeginInit();
            this.tabPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinListPrice2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinListPrice1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxListPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxStandardCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinStandardCost2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinStandardCost1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.xtraTabControl);
            this.pnlFilter.Size = new System.Drawing.Size(784, 183);
            this.pnlFilter.Controls.SetChildIndex(this.btnFilter, 0);
            this.pnlFilter.Controls.SetChildIndex(this.xtraTabControl, 0);
            // 
            // bsGridControl
            // 
            this.bsGridControl.DataMember = "VW_Medicament";
            this.bsGridControl.DataSource = this.ds;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridControl);
            this.pnlGrid.Location = new System.Drawing.Point(0, 222);
            this.pnlGrid.Size = new System.Drawing.Size(784, 340);
            // 
            // btnFilter
            // 
            this.btnFilter.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.Appearance.Options.UseFont = true;
            this.btnFilter.Location = new System.Drawing.Point(630, 144);
            // 
            // popupMenu
            // 
            this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.miMedicamentLocation)});
            this.popupMenu.MenuAppearance.Menu.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popupMenu.MenuAppearance.Menu.Options.UseFont = true;
            // 
            // colInUse
            // 
            this.colInUse.Caption = "არჩეულია";
            this.colInUse.FieldName = "InUse";
            this.colInUse.Name = "colInUse";
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bsGridControl;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(784, 340);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridControl_ProcessGridKey);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMedicamentName,
            this.colMedicamentCategoryName,
            this.colMedicamentSubcategoryName,
            this.colGenericName,
            this.colProductNumber,
            this.colUnitsInStock,
            this.colQuantity,
            this.col_StandardCost,
            this.col_ListPrice,
            this.col_DealerPrice,
            this.colProductCurrencyCode,
            this.colDiscountPct,
            this.colTaxRate,
            this.colValidDate,
            this.colCountryName,
            this.colBrandName,
            this.colSerie,
            this.colMakeFlag,
            this.colFinishedGoodsFlag,
            this.colColor,
            this.colSafetyStockLevel,
            this.colReorderPoint,
            this.colSize,
            this.colSizeRange,
            this.colSizeUnitMeasureCode,
            this.colWeight,
            this.colWeightUnitMeasureCode,
            this.colDaysToManufacture,
            this.colProductLine,
            this.colClass,
            this.colStyle,
            this.colMedicamentID,
            this.colMedicamentCategoryID,
            this.colMedicamentSubcategoryID,
            this.colProductModelID,
            this.colSellStartDate,
            this.colSellEndDate,
            this.colDiscontinuedDate,
            this.colGenericID,
            this.colCountryCode,
            this.colBrandID,
            this.colStatus,
            this.colModifiedDate,
            this.colModifiedUserID,
            this.colModifier,
            this.colApproverUserID,
            this.colApprover,
            this.colInUse});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Yellow;
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.Orange;
            styleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colInUse;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = true;
            this.gridView.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMedicamentName, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView_CustomUnboundColumnData);
            // 
            // colMedicamentName
            // 
            this.colMedicamentName.Caption = "მედიკამენტი";
            this.colMedicamentName.FieldName = "MedicamentName";
            this.colMedicamentName.Name = "colMedicamentName";
            this.colMedicamentName.Visible = true;
            this.colMedicamentName.VisibleIndex = 0;
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
            this.colProductNumber.Caption = "პროდუქტის №";
            this.colProductNumber.FieldName = "ProductNumber";
            this.colProductNumber.Name = "colProductNumber";
            // 
            // colUnitsInStock
            // 
            this.colUnitsInStock.Caption = "დაყოფა";
            this.colUnitsInStock.FieldName = "UnitsInStock";
            this.colUnitsInStock.Name = "colUnitsInStock";
            this.colUnitsInStock.Visible = true;
            this.colUnitsInStock.VisibleIndex = 1;
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
            this.colQuantity.VisibleIndex = 2;
            // 
            // col_StandardCost
            // 
            this.col_StandardCost.Caption = "ფასი / შ.";
            this.col_StandardCost.DisplayFormat.FormatString = "n4";
            this.col_StandardCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_StandardCost.FieldName = "col_StandardCost";
            this.col_StandardCost.GroupFormat.FormatString = "n2";
            this.col_StandardCost.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_StandardCost.Name = "col_StandardCost";
            this.col_StandardCost.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col_StandardCost.Visible = true;
            this.col_StandardCost.VisibleIndex = 3;
            // 
            // col_ListPrice
            // 
            this.col_ListPrice.Caption = "ფასი / გ.";
            this.col_ListPrice.DisplayFormat.FormatString = "n4";
            this.col_ListPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_ListPrice.FieldName = "col_ListPrice";
            this.col_ListPrice.GroupFormat.FormatString = "n2";
            this.col_ListPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_ListPrice.Name = "col_ListPrice";
            this.col_ListPrice.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col_ListPrice.Visible = true;
            this.col_ListPrice.VisibleIndex = 4;
            // 
            // col_DealerPrice
            // 
            this.col_DealerPrice.Caption = "ფასი / დილ.";
            this.col_DealerPrice.DisplayFormat.FormatString = "n4";
            this.col_DealerPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_DealerPrice.FieldName = "col_DealerPrice";
            this.col_DealerPrice.GroupFormat.FormatString = "n2";
            this.col_DealerPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_DealerPrice.Name = "col_DealerPrice";
            this.col_DealerPrice.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col_DealerPrice.Visible = true;
            this.col_DealerPrice.VisibleIndex = 5;
            // 
            // colProductCurrencyCode
            // 
            this.colProductCurrencyCode.Caption = "პ/ე ვალუტა";
            this.colProductCurrencyCode.FieldName = "ProductCurrencyCode";
            this.colProductCurrencyCode.Name = "colProductCurrencyCode";
            this.colProductCurrencyCode.Visible = true;
            this.colProductCurrencyCode.VisibleIndex = 10;
            // 
            // colDiscountPct
            // 
            this.colDiscountPct.Caption = "ფასდაკ";
            this.colDiscountPct.DisplayFormat.FormatString = "p";
            this.colDiscountPct.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscountPct.FieldName = "DiscountPct";
            this.colDiscountPct.GroupFormat.FormatString = "p";
            this.colDiscountPct.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscountPct.Name = "colDiscountPct";
            this.colDiscountPct.Visible = true;
            this.colDiscountPct.VisibleIndex = 6;
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
            this.colTaxRate.VisibleIndex = 7;
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
            this.colValidDate.VisibleIndex = 8;
            // 
            // colCountryName
            // 
            this.colCountryName.Caption = "მწ. ქვეყანა";
            this.colCountryName.FieldName = "CountryName";
            this.colCountryName.Name = "colCountryName";
            this.colCountryName.Visible = true;
            this.colCountryName.VisibleIndex = 9;
            // 
            // colBrandName
            // 
            this.colBrandName.Caption = "ბრენდი";
            this.colBrandName.FieldName = "BrandName";
            this.colBrandName.Name = "colBrandName";
            this.colBrandName.Visible = true;
            this.colBrandName.VisibleIndex = 11;
            // 
            // colSerie
            // 
            this.colSerie.Caption = "სერია";
            this.colSerie.FieldName = "Serie";
            this.colSerie.Name = "colSerie";
            this.colSerie.Visible = true;
            this.colSerie.VisibleIndex = 12;
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
            this.colSafetyStockLevel.Caption = "კრიტიკ. რაოდ.";
            this.colSafetyStockLevel.FieldName = "SafetyStockLevel";
            this.colSafetyStockLevel.Name = "colSafetyStockLevel";
            // 
            // colReorderPoint
            // 
            this.colReorderPoint.Caption = "შეკვეთ რაოდ.";
            this.colReorderPoint.FieldName = "ReorderPoint";
            this.colReorderPoint.Name = "colReorderPoint";
            // 
            // colSize
            // 
            this.colSize.Caption = "ზომა";
            this.colSize.FieldName = "Size";
            this.colSize.Name = "colSize";
            // 
            // colSizeRange
            // 
            this.colSizeRange.Caption = "ზომის დიაპაზ.";
            this.colSizeRange.FieldName = "SizeRange";
            this.colSizeRange.Name = "colSizeRange";
            // 
            // colSizeUnitMeasureCode
            // 
            this.colSizeUnitMeasureCode.Caption = "ზომ. ერთ. კოდი";
            this.colSizeUnitMeasureCode.FieldName = "SizeUnitMeasureCode";
            this.colSizeUnitMeasureCode.Name = "colSizeUnitMeasureCode";
            // 
            // colWeight
            // 
            this.colWeight.Caption = "წონა";
            this.colWeight.FieldName = "Weight";
            this.colWeight.Name = "colWeight";
            // 
            // colWeightUnitMeasureCode
            // 
            this.colWeightUnitMeasureCode.Caption = "წონ. ერთ. კოდი";
            this.colWeightUnitMeasureCode.FieldName = "WeightUnitMeasureCode";
            this.colWeightUnitMeasureCode.Name = "colWeightUnitMeasureCode";
            // 
            // colDaysToManufacture
            // 
            this.colDaysToManufacture.Caption = "წარმოების ხანგძ. (დღე)";
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
            // colProductModelID
            // 
            this.colProductModelID.FieldName = "ProductModelID";
            this.colProductModelID.Name = "colProductModelID";
            // 
            // colSellStartDate
            // 
            this.colSellStartDate.Caption = "გაყიდვა დაიწყოს";
            this.colSellStartDate.FieldName = "SellStartDate";
            this.colSellStartDate.Name = "colSellStartDate";
            // 
            // colSellEndDate
            // 
            this.colSellEndDate.Caption = "გაყიდვა დასრულდეს";
            this.colSellEndDate.FieldName = "SellEndDate";
            this.colSellEndDate.Name = "colSellEndDate";
            // 
            // colDiscontinuedDate
            // 
            this.colDiscontinuedDate.Caption = "გაყიდვა შეწყდა";
            this.colDiscontinuedDate.FieldName = "DiscontinuedDate";
            this.colDiscontinuedDate.Name = "colDiscontinuedDate";
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
            // colModifiedDate
            // 
            this.colModifiedDate.Caption = "შეცვლის თარიღი";
            this.colModifiedDate.DisplayFormat.FormatString = "G";
            this.colModifiedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colModifiedDate.FieldName = "ModifiedDate";
            this.colModifiedDate.Name = "colModifiedDate";
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
            // colApproverUserID
            // 
            this.colApproverUserID.FieldName = "ApproverUserID";
            this.colApproverUserID.Name = "colApproverUserID";
            // 
            // colApprover
            // 
            this.colApprover.Caption = "დაამოწმა";
            this.colApprover.FieldName = "Approver";
            this.colApprover.Name = "colApprover";
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.AppearancePage.Header.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xtraTabControl.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraTabControl.Location = new System.Drawing.Point(2, 2);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.SelectedTabPage = this.tabMain;
            this.xtraTabControl.Size = new System.Drawing.Size(780, 136);
            this.xtraTabControl.TabIndex = 0;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabMain,
            this.tabAdditional,
            this.tabQuantity,
            this.tabPrice});
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.lookCurrency);
            this.tabMain.Controls.Add(this.lblCurrency);
            this.tabMain.Controls.Add(this.lookCategory);
            this.tabMain.Controls.Add(this.cboxCategory);
            this.tabMain.Controls.Add(this.lookSubcategory);
            this.tabMain.Controls.Add(this.lblCategory);
            this.tabMain.Controls.Add(this.cboxSubcategory);
            this.tabMain.Controls.Add(this.lblSubcategory);
            this.tabMain.Controls.Add(this.cboxProductID);
            this.tabMain.Controls.Add(this.cboxProductNumber);
            this.tabMain.Controls.Add(this.cboxProductName);
            this.tabMain.Controls.Add(this.lblProductID);
            this.tabMain.Controls.Add(this.lblProductNumber);
            this.tabMain.Controls.Add(this.lblProductName);
            this.tabMain.Controls.Add(this.txtProductID);
            this.tabMain.Controls.Add(this.txtProductNumber);
            this.tabMain.Controls.Add(this.txtProductName);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(774, 106);
            this.tabMain.Text = "მთავარი";
            // 
            // lookCurrency
            // 
            this.lookCurrency.EnterMoveNextControl = true;
            this.lookCurrency.Location = new System.Drawing.Point(574, 61);
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
            this.lookCurrency.Size = new System.Drawing.Size(300, 23);
            this.lookCurrency.TabIndex = 13;
            this.lookCurrency.EditValueChanged += new System.EventHandler(this.lookCurrency_EditValueChanged);
            // 
            // lblCurrency
            // 
            this.lblCurrency.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrency.Location = new System.Drawing.Point(428, 64);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(140, 17);
            this.lblCurrency.TabIndex = 12;
            this.lblCurrency.Text = "ვალუტაში ჩვენება:";
            // 
            // lookCategory
            // 
            this.lookCategory.EnterMoveNextControl = true;
            this.lookCategory.Location = new System.Drawing.Point(655, 3);
            this.lookCategory.Name = "lookCategory";
            this.lookCategory.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookCategory.Properties.Appearance.Options.UseFont = true;
            this.lookCategory.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.lookCategory.Properties.DataSource = this.bsCategory;
            this.lookCategory.Properties.DisplayMember = "Caption";
            this.lookCategory.Properties.NullText = "";
            this.lookCategory.Properties.ShowHeader = false;
            this.lookCategory.Properties.SortColumnIndex = 2;
            this.lookCategory.Properties.ValueMember = "ID";
            this.lookCategory.Size = new System.Drawing.Size(219, 23);
            this.lookCategory.TabIndex = 11;
            this.lookCategory.EditValueChanged += new System.EventHandler(this.lookCategory_EditValueChanged);
            // 
            // cboxCategory
            // 
            this.cboxCategory.EditValue = "=";
            this.cboxCategory.EnterMoveNextControl = true;
            this.cboxCategory.Location = new System.Drawing.Point(574, 3);
            this.cboxCategory.Name = "cboxCategory";
            this.cboxCategory.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxCategory.Properties.Appearance.Options.UseFont = true;
            this.cboxCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxCategory.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!="});
            this.cboxCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxCategory.Size = new System.Drawing.Size(75, 23);
            this.cboxCategory.TabIndex = 10;
            this.cboxCategory.SelectedIndexChanged += new System.EventHandler(this.cboxCategory_SelectedIndexChanged);
            // 
            // lookSubcategory
            // 
            this.lookSubcategory.EnterMoveNextControl = true;
            this.lookSubcategory.Location = new System.Drawing.Point(655, 32);
            this.lookSubcategory.Name = "lookSubcategory";
            this.lookSubcategory.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookSubcategory.Properties.Appearance.Options.UseFont = true;
            this.lookSubcategory.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookSubcategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookSubcategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.lookSubcategory.Properties.DataSource = this.bsSubcategory;
            this.lookSubcategory.Properties.DisplayMember = "Caption";
            this.lookSubcategory.Properties.NullText = "";
            this.lookSubcategory.Properties.ShowHeader = false;
            this.lookSubcategory.Properties.SortColumnIndex = 2;
            this.lookSubcategory.Properties.ValueMember = "ID";
            this.lookSubcategory.Size = new System.Drawing.Size(219, 23);
            this.lookSubcategory.TabIndex = 11;
            // 
            // lblCategory
            // 
            this.lblCategory.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCategory.Location = new System.Drawing.Point(428, 6);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(86, 17);
            this.lblCategory.TabIndex = 9;
            this.lblCategory.Text = "კატეგორია:";
            // 
            // cboxSubcategory
            // 
            this.cboxSubcategory.EditValue = "=";
            this.cboxSubcategory.EnterMoveNextControl = true;
            this.cboxSubcategory.Location = new System.Drawing.Point(574, 32);
            this.cboxSubcategory.Name = "cboxSubcategory";
            this.cboxSubcategory.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxSubcategory.Properties.Appearance.Options.UseFont = true;
            this.cboxSubcategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxSubcategory.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!="});
            this.cboxSubcategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxSubcategory.Size = new System.Drawing.Size(75, 23);
            this.cboxSubcategory.TabIndex = 10;
            this.cboxSubcategory.SelectedIndexChanged += new System.EventHandler(this.cboxSubcategory_SelectedIndexChanged);
            // 
            // lblSubcategory
            // 
            this.lblSubcategory.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSubcategory.Location = new System.Drawing.Point(428, 35);
            this.lblSubcategory.Name = "lblSubcategory";
            this.lblSubcategory.Size = new System.Drawing.Size(70, 17);
            this.lblSubcategory.TabIndex = 9;
            this.lblSubcategory.Text = "ქვეკატეგ:";
            // 
            // cboxProductID
            // 
            this.cboxProductID.EditValue = "=";
            this.cboxProductID.EnterMoveNextControl = true;
            this.cboxProductID.Location = new System.Drawing.Point(116, 61);
            this.cboxProductID.Name = "cboxProductID";
            this.cboxProductID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxProductID.Properties.Appearance.Options.UseFont = true;
            this.cboxProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxProductID.Properties.Items.AddRange(new object[] {
            "",
            "=",
            ">",
            ">=",
            "<",
            "<=",
            "a,b,c",
            "!a,b,c"});
            this.cboxProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxProductID.Size = new System.Drawing.Size(75, 23);
            this.cboxProductID.TabIndex = 7;
            this.cboxProductID.SelectedIndexChanged += new System.EventHandler(this.cboxProductID_SelectedIndexChanged);
            // 
            // cboxProductNumber
            // 
            this.cboxProductNumber.EditValue = "=";
            this.cboxProductNumber.EnterMoveNextControl = true;
            this.cboxProductNumber.Location = new System.Drawing.Point(116, 32);
            this.cboxProductNumber.Name = "cboxProductNumber";
            this.cboxProductNumber.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxProductNumber.Properties.Appearance.Options.UseFont = true;
            this.cboxProductNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxProductNumber.Properties.Items.AddRange(new object[] {
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
            this.cboxProductNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxProductNumber.Size = new System.Drawing.Size(75, 23);
            this.cboxProductNumber.TabIndex = 4;
            this.cboxProductNumber.SelectedIndexChanged += new System.EventHandler(this.cboxProductNumber_SelectedIndexChanged);
            // 
            // cboxProductName
            // 
            this.cboxProductName.EditValue = "a%";
            this.cboxProductName.EnterMoveNextControl = true;
            this.cboxProductName.Location = new System.Drawing.Point(116, 3);
            this.cboxProductName.Name = "cboxProductName";
            this.cboxProductName.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxProductName.Properties.Appearance.Options.UseFont = true;
            this.cboxProductName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxProductName.Properties.Items.AddRange(new object[] {
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
            this.cboxProductName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxProductName.Size = new System.Drawing.Size(75, 23);
            this.cboxProductName.TabIndex = 1;
            this.cboxProductName.SelectedIndexChanged += new System.EventHandler(this.cboxProductName_SelectedIndexChanged);
            // 
            // lblProductID
            // 
            this.lblProductID.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductID.Location = new System.Drawing.Point(6, 64);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(73, 17);
            this.lblProductID.TabIndex = 6;
            this.lblProductID.Text = "პროდ. ID:";
            // 
            // lblProductNumber
            // 
            this.lblProductNumber.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductNumber.Location = new System.Drawing.Point(6, 35);
            this.lblProductNumber.Name = "lblProductNumber";
            this.lblProductNumber.Size = new System.Drawing.Size(74, 17);
            this.lblProductNumber.TabIndex = 3;
            this.lblProductNumber.Text = "პროდ. №:";
            // 
            // lblProductName
            // 
            this.lblProductName.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductName.Location = new System.Drawing.Point(6, 6);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(103, 17);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "პროდ. დასახ:";
            // 
            // txtProductID
            // 
            this.txtProductID.EnterMoveNextControl = true;
            this.txtProductID.Location = new System.Drawing.Point(197, 61);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProductID.Properties.Appearance.Options.UseFont = true;
            this.txtProductID.Properties.Mask.EditMask = "[0-9,]+";
            this.txtProductID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtProductID.Size = new System.Drawing.Size(219, 23);
            this.txtProductID.TabIndex = 8;
            // 
            // txtProductNumber
            // 
            this.txtProductNumber.EnterMoveNextControl = true;
            this.txtProductNumber.Location = new System.Drawing.Point(197, 32);
            this.txtProductNumber.Name = "txtProductNumber";
            this.txtProductNumber.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProductNumber.Properties.Appearance.Options.UseFont = true;
            this.txtProductNumber.Size = new System.Drawing.Size(219, 23);
            this.txtProductNumber.TabIndex = 5;
            // 
            // txtProductName
            // 
            this.txtProductName.EnterMoveNextControl = true;
            this.txtProductName.Location = new System.Drawing.Point(197, 3);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProductName.Properties.Appearance.Options.UseFont = true;
            this.txtProductName.Size = new System.Drawing.Size(219, 23);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // tabAdditional
            // 
            this.tabAdditional.Controls.Add(this.cboxWeight);
            this.tabAdditional.Controls.Add(this.spinWeight2);
            this.tabAdditional.Controls.Add(this.spinWeight1);
            this.tabAdditional.Controls.Add(this.lblWeight);
            this.tabAdditional.Controls.Add(this.cboxSizeRange);
            this.tabAdditional.Controls.Add(this.cboxSize);
            this.tabAdditional.Controls.Add(this.txtSizeRange);
            this.tabAdditional.Controls.Add(this.lblSizeRange);
            this.tabAdditional.Controls.Add(this.txtSize);
            this.tabAdditional.Controls.Add(this.lblSize);
            this.tabAdditional.Controls.Add(this.cboxColor);
            this.tabAdditional.Controls.Add(this.lblColor);
            this.tabAdditional.Controls.Add(this.txtColor);
            this.tabAdditional.Controls.Add(this.chkFinishedGoodsFlag);
            this.tabAdditional.Controls.Add(this.chkMakeFlag);
            this.tabAdditional.Name = "tabAdditional";
            this.tabAdditional.Size = new System.Drawing.Size(774, 106);
            this.tabAdditional.Text = "დამატებითი";
            // 
            // cboxWeight
            // 
            this.cboxWeight.EnterMoveNextControl = true;
            this.cboxWeight.Location = new System.Drawing.Point(436, 62);
            this.cboxWeight.Name = "cboxWeight";
            this.cboxWeight.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxWeight.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxWeight.Properties.Appearance.Options.UseFont = true;
            this.cboxWeight.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxWeight.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxWeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxWeight.Properties.Items.AddRange(new object[] {
            "",
            "=",
            ">",
            ">=",
            "<",
            "<=",
            "[ ]"});
            this.cboxWeight.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxWeight.Size = new System.Drawing.Size(75, 23);
            this.cboxWeight.TabIndex = 12;
            this.cboxWeight.SelectedIndexChanged += new System.EventHandler(this.cboxWeight_SelectedIndexChanged);
            // 
            // spinWeight2
            // 
            this.spinWeight2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinWeight2.Enabled = false;
            this.spinWeight2.EnterMoveNextControl = true;
            this.spinWeight2.Location = new System.Drawing.Point(623, 62);
            this.spinWeight2.Name = "spinWeight2";
            this.spinWeight2.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinWeight2.Properties.Appearance.Options.UseFont = true;
            this.spinWeight2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinWeight2.Properties.DisplayFormat.FormatString = "n2";
            this.spinWeight2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinWeight2.Properties.EditFormat.FormatString = "n2";
            this.spinWeight2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinWeight2.Properties.Mask.EditMask = "n2";
            this.spinWeight2.Properties.MaxValue = new decimal(new int[] {
            9000000,
            0,
            0,
            0});
            this.spinWeight2.Size = new System.Drawing.Size(100, 23);
            this.spinWeight2.TabIndex = 14;
            // 
            // spinWeight1
            // 
            this.spinWeight1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinWeight1.Enabled = false;
            this.spinWeight1.EnterMoveNextControl = true;
            this.spinWeight1.Location = new System.Drawing.Point(517, 62);
            this.spinWeight1.Name = "spinWeight1";
            this.spinWeight1.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinWeight1.Properties.Appearance.Options.UseFont = true;
            this.spinWeight1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinWeight1.Properties.DisplayFormat.FormatString = "n2";
            this.spinWeight1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinWeight1.Properties.EditFormat.FormatString = "n2";
            this.spinWeight1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinWeight1.Properties.Mask.EditMask = "n2";
            this.spinWeight1.Properties.MaxValue = new decimal(new int[] {
            9000000,
            0,
            0,
            0});
            this.spinWeight1.Size = new System.Drawing.Size(100, 23);
            this.spinWeight1.TabIndex = 13;
            // 
            // lblWeight
            // 
            this.lblWeight.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWeight.Location = new System.Drawing.Point(324, 65);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 17);
            this.lblWeight.TabIndex = 11;
            this.lblWeight.Text = "წონა:";
            // 
            // cboxSizeRange
            // 
            this.cboxSizeRange.EditValue = "%a%";
            this.cboxSizeRange.EnterMoveNextControl = true;
            this.cboxSizeRange.Location = new System.Drawing.Point(436, 33);
            this.cboxSizeRange.Name = "cboxSizeRange";
            this.cboxSizeRange.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxSizeRange.Properties.Appearance.Options.UseFont = true;
            this.cboxSizeRange.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxSizeRange.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!=",
            "%a%",
            "!%a%",
            "a%",
            "!a%",
            "%a",
            "!%a",
            "a,b,c"});
            this.cboxSizeRange.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxSizeRange.Size = new System.Drawing.Size(75, 23);
            this.cboxSizeRange.TabIndex = 9;
            this.cboxSizeRange.SelectedIndexChanged += new System.EventHandler(this.cboxSizeRange_SelectedIndexChanged);
            // 
            // cboxSize
            // 
            this.cboxSize.EditValue = "%a%";
            this.cboxSize.EnterMoveNextControl = true;
            this.cboxSize.Location = new System.Drawing.Point(436, 6);
            this.cboxSize.Name = "cboxSize";
            this.cboxSize.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxSize.Properties.Appearance.Options.UseFont = true;
            this.cboxSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxSize.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!=",
            "%a%",
            "!%a%",
            "a%",
            "!a%",
            "%a",
            "!%a",
            "a,b,c"});
            this.cboxSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxSize.Size = new System.Drawing.Size(75, 23);
            this.cboxSize.TabIndex = 6;
            this.cboxSize.SelectedIndexChanged += new System.EventHandler(this.cboxSize_SelectedIndexChanged);
            // 
            // txtSizeRange
            // 
            this.txtSizeRange.EnterMoveNextControl = true;
            this.txtSizeRange.Location = new System.Drawing.Point(517, 33);
            this.txtSizeRange.Name = "txtSizeRange";
            this.txtSizeRange.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSizeRange.Properties.Appearance.Options.UseFont = true;
            this.txtSizeRange.Size = new System.Drawing.Size(206, 23);
            this.txtSizeRange.TabIndex = 10;
            // 
            // lblSizeRange
            // 
            this.lblSizeRange.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSizeRange.Location = new System.Drawing.Point(324, 36);
            this.lblSizeRange.Name = "lblSizeRange";
            this.lblSizeRange.Size = new System.Drawing.Size(106, 17);
            this.lblSizeRange.TabIndex = 8;
            this.lblSizeRange.Text = "ზომის დიაპაზ:";
            // 
            // txtSize
            // 
            this.txtSize.EnterMoveNextControl = true;
            this.txtSize.Location = new System.Drawing.Point(517, 6);
            this.txtSize.Name = "txtSize";
            this.txtSize.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSize.Properties.Appearance.Options.UseFont = true;
            this.txtSize.Size = new System.Drawing.Size(206, 23);
            this.txtSize.TabIndex = 7;
            // 
            // lblSize
            // 
            this.lblSize.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSize.Location = new System.Drawing.Point(324, 9);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(41, 17);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "ზომა:";
            // 
            // cboxColor
            // 
            this.cboxColor.EditValue = "%a%";
            this.cboxColor.EnterMoveNextControl = true;
            this.cboxColor.Location = new System.Drawing.Point(59, 62);
            this.cboxColor.Name = "cboxColor";
            this.cboxColor.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxColor.Properties.Appearance.Options.UseFont = true;
            this.cboxColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxColor.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!=",
            "%a%",
            "!%a%",
            "a%",
            "!a%",
            "%a",
            "!%a",
            "a,b,c"});
            this.cboxColor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxColor.Size = new System.Drawing.Size(75, 23);
            this.cboxColor.TabIndex = 3;
            this.cboxColor.SelectedIndexChanged += new System.EventHandler(this.cboxColor_SelectedIndexChanged);
            // 
            // lblColor
            // 
            this.lblColor.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblColor.Location = new System.Drawing.Point(8, 65);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(45, 17);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "ფერი:";
            // 
            // txtColor
            // 
            this.txtColor.EnterMoveNextControl = true;
            this.txtColor.Location = new System.Drawing.Point(140, 62);
            this.txtColor.Name = "txtColor";
            this.txtColor.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtColor.Properties.Appearance.Options.UseFont = true;
            this.txtColor.Size = new System.Drawing.Size(166, 23);
            this.txtColor.TabIndex = 4;
            // 
            // chkFinishedGoodsFlag
            // 
            this.chkFinishedGoodsFlag.EditValue = null;
            this.chkFinishedGoodsFlag.Location = new System.Drawing.Point(6, 34);
            this.chkFinishedGoodsFlag.Name = "chkFinishedGoodsFlag";
            this.chkFinishedGoodsFlag.Properties.AllowGrayed = true;
            this.chkFinishedGoodsFlag.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkFinishedGoodsFlag.Properties.Appearance.Options.UseFont = true;
            this.chkFinishedGoodsFlag.Properties.Caption = "პროდუქტი გაყიდვაშია";
            this.chkFinishedGoodsFlag.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.chkFinishedGoodsFlag.Size = new System.Drawing.Size(300, 22);
            this.chkFinishedGoodsFlag.TabIndex = 1;
            // 
            // chkMakeFlag
            // 
            this.chkMakeFlag.EditValue = null;
            this.chkMakeFlag.Location = new System.Drawing.Point(6, 6);
            this.chkMakeFlag.Name = "chkMakeFlag";
            this.chkMakeFlag.Properties.AllowGrayed = true;
            this.chkMakeFlag.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkMakeFlag.Properties.Appearance.Options.UseFont = true;
            this.chkMakeFlag.Properties.Caption = "შიდა პროდუქტი";
            this.chkMakeFlag.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.chkMakeFlag.Size = new System.Drawing.Size(300, 22);
            this.chkMakeFlag.TabIndex = 0;
            // 
            // tabQuantity
            // 
            this.tabQuantity.Controls.Add(this.spinDaysToManufacture2);
            this.tabQuantity.Controls.Add(this.spinDaysToManufacture1);
            this.tabQuantity.Controls.Add(this.lblDaysToManufacture);
            this.tabQuantity.Controls.Add(this.spinReorderPoint2);
            this.tabQuantity.Controls.Add(this.spinReorderPoint1);
            this.tabQuantity.Controls.Add(this.lblReorderPoint);
            this.tabQuantity.Controls.Add(this.spinSafetyStockLevel2);
            this.tabQuantity.Controls.Add(this.spinSafetyStockLevel1);
            this.tabQuantity.Controls.Add(this.cboxDaysToManufacture);
            this.tabQuantity.Controls.Add(this.cboxReorderPoint);
            this.tabQuantity.Controls.Add(this.cboxSafetyStockLevel);
            this.tabQuantity.Controls.Add(this.lblSafetyStockLevel);
            this.tabQuantity.Name = "tabQuantity";
            this.tabQuantity.Size = new System.Drawing.Size(774, 106);
            this.tabQuantity.Text = "რაოდენობა";
            // 
            // spinDaysToManufacture2
            // 
            this.spinDaysToManufacture2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinDaysToManufacture2.Enabled = false;
            this.spinDaysToManufacture2.EnterMoveNextControl = true;
            this.spinDaysToManufacture2.Location = new System.Drawing.Point(318, 64);
            this.spinDaysToManufacture2.Name = "spinDaysToManufacture2";
            this.spinDaysToManufacture2.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinDaysToManufacture2.Properties.Appearance.Options.UseFont = true;
            this.spinDaysToManufacture2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinDaysToManufacture2.Properties.DisplayFormat.FormatString = "n00";
            this.spinDaysToManufacture2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinDaysToManufacture2.Properties.EditFormat.FormatString = "n00";
            this.spinDaysToManufacture2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinDaysToManufacture2.Properties.IsFloatValue = false;
            this.spinDaysToManufacture2.Properties.Mask.EditMask = "n00";
            this.spinDaysToManufacture2.Properties.MaxValue = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.spinDaysToManufacture2.Size = new System.Drawing.Size(100, 23);
            this.spinDaysToManufacture2.TabIndex = 11;
            // 
            // spinDaysToManufacture1
            // 
            this.spinDaysToManufacture1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinDaysToManufacture1.Enabled = false;
            this.spinDaysToManufacture1.EnterMoveNextControl = true;
            this.spinDaysToManufacture1.Location = new System.Drawing.Point(212, 64);
            this.spinDaysToManufacture1.Name = "spinDaysToManufacture1";
            this.spinDaysToManufacture1.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinDaysToManufacture1.Properties.Appearance.Options.UseFont = true;
            this.spinDaysToManufacture1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinDaysToManufacture1.Properties.DisplayFormat.FormatString = "n00";
            this.spinDaysToManufacture1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinDaysToManufacture1.Properties.EditFormat.FormatString = "n00";
            this.spinDaysToManufacture1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinDaysToManufacture1.Properties.IsFloatValue = false;
            this.spinDaysToManufacture1.Properties.Mask.EditMask = "n00";
            this.spinDaysToManufacture1.Properties.MaxValue = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.spinDaysToManufacture1.Size = new System.Drawing.Size(100, 23);
            this.spinDaysToManufacture1.TabIndex = 10;
            // 
            // lblDaysToManufacture
            // 
            this.lblDaysToManufacture.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDaysToManufacture.Location = new System.Drawing.Point(7, 67);
            this.lblDaysToManufacture.Name = "lblDaysToManufacture";
            this.lblDaysToManufacture.Size = new System.Drawing.Size(118, 17);
            this.lblDaysToManufacture.TabIndex = 8;
            this.lblDaysToManufacture.Text = "წარმ ხანგძლივ:";
            // 
            // spinReorderPoint2
            // 
            this.spinReorderPoint2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinReorderPoint2.Enabled = false;
            this.spinReorderPoint2.EnterMoveNextControl = true;
            this.spinReorderPoint2.Location = new System.Drawing.Point(318, 35);
            this.spinReorderPoint2.Name = "spinReorderPoint2";
            this.spinReorderPoint2.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinReorderPoint2.Properties.Appearance.Options.UseFont = true;
            this.spinReorderPoint2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinReorderPoint2.Properties.DisplayFormat.FormatString = "n00";
            this.spinReorderPoint2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinReorderPoint2.Properties.EditFormat.FormatString = "n00";
            this.spinReorderPoint2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinReorderPoint2.Properties.IsFloatValue = false;
            this.spinReorderPoint2.Properties.Mask.EditMask = "n00";
            this.spinReorderPoint2.Properties.MaxValue = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.spinReorderPoint2.Size = new System.Drawing.Size(100, 23);
            this.spinReorderPoint2.TabIndex = 7;
            // 
            // spinReorderPoint1
            // 
            this.spinReorderPoint1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinReorderPoint1.Enabled = false;
            this.spinReorderPoint1.EnterMoveNextControl = true;
            this.spinReorderPoint1.Location = new System.Drawing.Point(212, 35);
            this.spinReorderPoint1.Name = "spinReorderPoint1";
            this.spinReorderPoint1.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinReorderPoint1.Properties.Appearance.Options.UseFont = true;
            this.spinReorderPoint1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinReorderPoint1.Properties.DisplayFormat.FormatString = "n00";
            this.spinReorderPoint1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinReorderPoint1.Properties.EditFormat.FormatString = "n00";
            this.spinReorderPoint1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinReorderPoint1.Properties.IsFloatValue = false;
            this.spinReorderPoint1.Properties.Mask.EditMask = "n00";
            this.spinReorderPoint1.Properties.MaxValue = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.spinReorderPoint1.Size = new System.Drawing.Size(100, 23);
            this.spinReorderPoint1.TabIndex = 6;
            // 
            // lblReorderPoint
            // 
            this.lblReorderPoint.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReorderPoint.Location = new System.Drawing.Point(7, 38);
            this.lblReorderPoint.Name = "lblReorderPoint";
            this.lblReorderPoint.Size = new System.Drawing.Size(106, 17);
            this.lblReorderPoint.TabIndex = 4;
            this.lblReorderPoint.Text = "შესაკვ. რაოდ:";
            // 
            // spinSafetyStockLevel2
            // 
            this.spinSafetyStockLevel2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinSafetyStockLevel2.Enabled = false;
            this.spinSafetyStockLevel2.EnterMoveNextControl = true;
            this.spinSafetyStockLevel2.Location = new System.Drawing.Point(318, 6);
            this.spinSafetyStockLevel2.Name = "spinSafetyStockLevel2";
            this.spinSafetyStockLevel2.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinSafetyStockLevel2.Properties.Appearance.Options.UseFont = true;
            this.spinSafetyStockLevel2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinSafetyStockLevel2.Properties.DisplayFormat.FormatString = "n00";
            this.spinSafetyStockLevel2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSafetyStockLevel2.Properties.EditFormat.FormatString = "n00";
            this.spinSafetyStockLevel2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSafetyStockLevel2.Properties.IsFloatValue = false;
            this.spinSafetyStockLevel2.Properties.Mask.EditMask = "n00";
            this.spinSafetyStockLevel2.Properties.MaxValue = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.spinSafetyStockLevel2.Size = new System.Drawing.Size(100, 23);
            this.spinSafetyStockLevel2.TabIndex = 3;
            // 
            // spinSafetyStockLevel1
            // 
            this.spinSafetyStockLevel1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinSafetyStockLevel1.Enabled = false;
            this.spinSafetyStockLevel1.EnterMoveNextControl = true;
            this.spinSafetyStockLevel1.Location = new System.Drawing.Point(212, 6);
            this.spinSafetyStockLevel1.Name = "spinSafetyStockLevel1";
            this.spinSafetyStockLevel1.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinSafetyStockLevel1.Properties.Appearance.Options.UseFont = true;
            this.spinSafetyStockLevel1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinSafetyStockLevel1.Properties.DisplayFormat.FormatString = "n00";
            this.spinSafetyStockLevel1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSafetyStockLevel1.Properties.EditFormat.FormatString = "n00";
            this.spinSafetyStockLevel1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSafetyStockLevel1.Properties.IsFloatValue = false;
            this.spinSafetyStockLevel1.Properties.Mask.EditMask = "n00";
            this.spinSafetyStockLevel1.Properties.MaxValue = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.spinSafetyStockLevel1.Size = new System.Drawing.Size(100, 23);
            this.spinSafetyStockLevel1.TabIndex = 2;
            // 
            // cboxDaysToManufacture
            // 
            this.cboxDaysToManufacture.EnterMoveNextControl = true;
            this.cboxDaysToManufacture.Location = new System.Drawing.Point(131, 64);
            this.cboxDaysToManufacture.Name = "cboxDaysToManufacture";
            this.cboxDaysToManufacture.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxDaysToManufacture.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxDaysToManufacture.Properties.Appearance.Options.UseFont = true;
            this.cboxDaysToManufacture.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxDaysToManufacture.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxDaysToManufacture.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxDaysToManufacture.Properties.Items.AddRange(new object[] {
            "",
            "=",
            ">",
            ">=",
            "<",
            "<=",
            "[ ]"});
            this.cboxDaysToManufacture.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxDaysToManufacture.Size = new System.Drawing.Size(75, 23);
            this.cboxDaysToManufacture.TabIndex = 9;
            this.cboxDaysToManufacture.SelectedIndexChanged += new System.EventHandler(this.cboxDaysToManufacture_SelectedIndexChanged);
            // 
            // cboxReorderPoint
            // 
            this.cboxReorderPoint.EnterMoveNextControl = true;
            this.cboxReorderPoint.Location = new System.Drawing.Point(131, 35);
            this.cboxReorderPoint.Name = "cboxReorderPoint";
            this.cboxReorderPoint.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxReorderPoint.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxReorderPoint.Properties.Appearance.Options.UseFont = true;
            this.cboxReorderPoint.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxReorderPoint.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxReorderPoint.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxReorderPoint.Properties.Items.AddRange(new object[] {
            "",
            "=",
            ">",
            ">=",
            "<",
            "<=",
            "[ ]"});
            this.cboxReorderPoint.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxReorderPoint.Size = new System.Drawing.Size(75, 23);
            this.cboxReorderPoint.TabIndex = 5;
            this.cboxReorderPoint.SelectedIndexChanged += new System.EventHandler(this.cboxReorderPoint_SelectedIndexChanged);
            // 
            // cboxSafetyStockLevel
            // 
            this.cboxSafetyStockLevel.EnterMoveNextControl = true;
            this.cboxSafetyStockLevel.Location = new System.Drawing.Point(131, 6);
            this.cboxSafetyStockLevel.Name = "cboxSafetyStockLevel";
            this.cboxSafetyStockLevel.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxSafetyStockLevel.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxSafetyStockLevel.Properties.Appearance.Options.UseFont = true;
            this.cboxSafetyStockLevel.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxSafetyStockLevel.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxSafetyStockLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxSafetyStockLevel.Properties.Items.AddRange(new object[] {
            "",
            "=",
            ">",
            ">=",
            "<",
            "<=",
            "[ ]"});
            this.cboxSafetyStockLevel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxSafetyStockLevel.Size = new System.Drawing.Size(75, 23);
            this.cboxSafetyStockLevel.TabIndex = 1;
            this.cboxSafetyStockLevel.SelectedIndexChanged += new System.EventHandler(this.cboxSafetyStockLevel_SelectedIndexChanged);
            // 
            // lblSafetyStockLevel
            // 
            this.lblSafetyStockLevel.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSafetyStockLevel.Location = new System.Drawing.Point(6, 9);
            this.lblSafetyStockLevel.Name = "lblSafetyStockLevel";
            this.lblSafetyStockLevel.Size = new System.Drawing.Size(111, 17);
            this.lblSafetyStockLevel.TabIndex = 0;
            this.lblSafetyStockLevel.Text = "კრიტიკ. რაოდ:";
            // 
            // tabPrice
            // 
            this.tabPrice.Controls.Add(this.spinListPrice2);
            this.tabPrice.Controls.Add(this.spinListPrice1);
            this.tabPrice.Controls.Add(this.cboxListPrice);
            this.tabPrice.Controls.Add(this.lblListPrice);
            this.tabPrice.Controls.Add(this.cboxStandardCost);
            this.tabPrice.Controls.Add(this.spinStandardCost2);
            this.tabPrice.Controls.Add(this.spinStandardCost1);
            this.tabPrice.Controls.Add(this.lblStandardCost);
            this.tabPrice.Name = "tabPrice";
            this.tabPrice.Size = new System.Drawing.Size(774, 106);
            this.tabPrice.Text = "ფასი";
            // 
            // spinListPrice2
            // 
            this.spinListPrice2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinListPrice2.Enabled = false;
            this.spinListPrice2.EnterMoveNextControl = true;
            this.spinListPrice2.Location = new System.Drawing.Point(291, 35);
            this.spinListPrice2.Name = "spinListPrice2";
            this.spinListPrice2.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinListPrice2.Properties.Appearance.Options.UseFont = true;
            this.spinListPrice2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinListPrice2.Properties.DisplayFormat.FormatString = "n4";
            this.spinListPrice2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinListPrice2.Properties.EditFormat.FormatString = "n4";
            this.spinListPrice2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinListPrice2.Properties.Mask.EditMask = "n4";
            this.spinListPrice2.Properties.MaxValue = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.spinListPrice2.Size = new System.Drawing.Size(100, 23);
            this.spinListPrice2.TabIndex = 7;
            // 
            // spinListPrice1
            // 
            this.spinListPrice1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinListPrice1.Enabled = false;
            this.spinListPrice1.EnterMoveNextControl = true;
            this.spinListPrice1.Location = new System.Drawing.Point(185, 35);
            this.spinListPrice1.Name = "spinListPrice1";
            this.spinListPrice1.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinListPrice1.Properties.Appearance.Options.UseFont = true;
            this.spinListPrice1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinListPrice1.Properties.DisplayFormat.FormatString = "n4";
            this.spinListPrice1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinListPrice1.Properties.EditFormat.FormatString = "n4";
            this.spinListPrice1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinListPrice1.Properties.Mask.EditMask = "n4";
            this.spinListPrice1.Properties.MaxValue = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.spinListPrice1.Size = new System.Drawing.Size(100, 23);
            this.spinListPrice1.TabIndex = 6;
            // 
            // cboxListPrice
            // 
            this.cboxListPrice.EnterMoveNextControl = true;
            this.cboxListPrice.Location = new System.Drawing.Point(104, 35);
            this.cboxListPrice.Name = "cboxListPrice";
            this.cboxListPrice.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxListPrice.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxListPrice.Properties.Appearance.Options.UseFont = true;
            this.cboxListPrice.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxListPrice.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxListPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxListPrice.Properties.Items.AddRange(new object[] {
            "",
            "=",
            ">",
            ">=",
            "<",
            "<=",
            "[ ]"});
            this.cboxListPrice.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxListPrice.Size = new System.Drawing.Size(75, 23);
            this.cboxListPrice.TabIndex = 5;
            this.cboxListPrice.SelectedIndexChanged += new System.EventHandler(this.cboxListPrice_SelectedIndexChanged);
            // 
            // lblListPrice
            // 
            this.lblListPrice.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblListPrice.Location = new System.Drawing.Point(7, 38);
            this.lblListPrice.Name = "lblListPrice";
            this.lblListPrice.Size = new System.Drawing.Size(91, 17);
            this.lblListPrice.TabIndex = 4;
            this.lblListPrice.Text = "გასაყ. ფასი:";
            // 
            // cboxStandardCost
            // 
            this.cboxStandardCost.EnterMoveNextControl = true;
            this.cboxStandardCost.Location = new System.Drawing.Point(104, 6);
            this.cboxStandardCost.Name = "cboxStandardCost";
            this.cboxStandardCost.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxStandardCost.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxStandardCost.Properties.Appearance.Options.UseFont = true;
            this.cboxStandardCost.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxStandardCost.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxStandardCost.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxStandardCost.Properties.Items.AddRange(new object[] {
            "",
            "=",
            ">",
            ">=",
            "<",
            "<=",
            "[ ]"});
            this.cboxStandardCost.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxStandardCost.Size = new System.Drawing.Size(75, 23);
            this.cboxStandardCost.TabIndex = 1;
            this.cboxStandardCost.SelectedIndexChanged += new System.EventHandler(this.cboxStandardCost_SelectedIndexChanged);
            // 
            // spinStandardCost2
            // 
            this.spinStandardCost2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinStandardCost2.Enabled = false;
            this.spinStandardCost2.EnterMoveNextControl = true;
            this.spinStandardCost2.Location = new System.Drawing.Point(291, 6);
            this.spinStandardCost2.Name = "spinStandardCost2";
            this.spinStandardCost2.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinStandardCost2.Properties.Appearance.Options.UseFont = true;
            this.spinStandardCost2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinStandardCost2.Properties.DisplayFormat.FormatString = "n4";
            this.spinStandardCost2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinStandardCost2.Properties.EditFormat.FormatString = "n4";
            this.spinStandardCost2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinStandardCost2.Properties.Mask.EditMask = "n4";
            this.spinStandardCost2.Properties.MaxValue = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.spinStandardCost2.Size = new System.Drawing.Size(100, 23);
            this.spinStandardCost2.TabIndex = 3;
            // 
            // spinStandardCost1
            // 
            this.spinStandardCost1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinStandardCost1.Enabled = false;
            this.spinStandardCost1.EnterMoveNextControl = true;
            this.spinStandardCost1.Location = new System.Drawing.Point(185, 6);
            this.spinStandardCost1.Name = "spinStandardCost1";
            this.spinStandardCost1.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinStandardCost1.Properties.Appearance.Options.UseFont = true;
            this.spinStandardCost1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinStandardCost1.Properties.DisplayFormat.FormatString = "n4";
            this.spinStandardCost1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinStandardCost1.Properties.EditFormat.FormatString = "n4";
            this.spinStandardCost1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinStandardCost1.Properties.Mask.EditMask = "n4";
            this.spinStandardCost1.Properties.MaxValue = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.spinStandardCost1.Size = new System.Drawing.Size(100, 23);
            this.spinStandardCost1.TabIndex = 2;
            // 
            // lblStandardCost
            // 
            this.lblStandardCost.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStandardCost.Location = new System.Drawing.Point(6, 9);
            this.lblStandardCost.Name = "lblStandardCost";
            this.lblStandardCost.Size = new System.Drawing.Size(64, 17);
            this.lblStandardCost.TabIndex = 0;
            this.lblStandardCost.Text = "ფასი / შ:";
            // 
            // ds
            // 
            this.ds.DataSetName = "DS_Dictionary";
            this.ds.Locale = new System.Globalization.CultureInfo("");
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // miMedicamentLocation
            // 
            this.miMedicamentLocation.Caption = "ნაშთი";
            this.miMedicamentLocation.Id = 16;
            this.miMedicamentLocation.Name = "miMedicamentLocation";
            this.miMedicamentLocation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.miMedicamentLocation_ItemClick);
            // 
            // frmMedicamentBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsFilterPanelVisible = true;
            this.Name = "frmMedicamentBrowse";
            this.ObjectName = Apothex.DataType.ObjectNames.Medicament;
            this.OptionsBaseForm.Text = "მედიკამენტები";
            this.OptionsListForm.IsEditable = true;
            this.OptionsListForm.IsSystemColumnsable = true;
            this.OptionsGrid.ColumnID = "MedicamentID";
            this.OptionsGrid.ColumnStatusID = "Status";
            this.OptionsGrid.GridView = this.gridView;
            this.Text = "მედიკამენტები";
            this.Shown += new System.EventHandler(this.frmMedicamentBrowse_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookSubcategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSubcategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxSubcategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxProductNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            this.tabAdditional.ResumeLayout(false);
            this.tabAdditional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinWeight2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinWeight1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxSizeRange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSizeRange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFinishedGoodsFlag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMakeFlag.Properties)).EndInit();
            this.tabQuantity.ResumeLayout(false);
            this.tabQuantity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDaysToManufacture2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDaysToManufacture1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinReorderPoint2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinReorderPoint1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSafetyStockLevel2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSafetyStockLevel1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxDaysToManufacture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxReorderPoint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxSafetyStockLevel.Properties)).EndInit();
            this.tabPrice.ResumeLayout(false);
            this.tabPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinListPrice2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinListPrice1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxListPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxStandardCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinStandardCost2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinStandardCost1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colProductNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colMakeFlag;
        private DevExpress.XtraGrid.Columns.GridColumn colFinishedGoodsFlag;
        private DevExpress.XtraGrid.Columns.GridColumn colColor;
        private DevExpress.XtraGrid.Columns.GridColumn colSafetyStockLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colReorderPoint;
        private DevExpress.XtraGrid.Columns.GridColumn col_ListPrice;
        private DevExpress.XtraGrid.Columns.GridColumn col_DealerPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSize;
        private DevExpress.XtraGrid.Columns.GridColumn colSizeRange;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colDaysToManufacture;
        private DevExpress.XtraGrid.Columns.GridColumn colProductLine;
        private DevExpress.XtraGrid.Columns.GridColumn colClass;
        private DevExpress.XtraGrid.Columns.GridColumn colStyle;
        private DevExpress.XtraGrid.Columns.GridColumn colSizeUnitMeasureCode;
        private DevExpress.XtraGrid.Columns.GridColumn colWeightUnitMeasureCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProductModelID;
        private DevExpress.XtraGrid.Columns.GridColumn colSellStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSellEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscontinuedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraGrid.Columns.GridColumn colApprover;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage tabMain;
        private DevExpress.XtraTab.XtraTabPage tabAdditional;
        private DevExpress.XtraEditors.ComboBoxEdit cboxProductName;
        private DevExpress.XtraEditors.LabelControl lblProductName;
        private DevExpress.XtraEditors.TextEdit txtProductName;
        private DevExpress.XtraEditors.ComboBoxEdit cboxSubcategory;
        private DevExpress.XtraEditors.LabelControl lblSubcategory;
        private DevExpress.XtraEditors.LookUpEdit lookSubcategory;
        private System.Windows.Forms.BindingSource bsSubcategory;
        private DevExpress.XtraEditors.ComboBoxEdit cboxProductNumber;
        private DevExpress.XtraEditors.LabelControl lblProductNumber;
        private DevExpress.XtraEditors.TextEdit txtProductNumber;
        private DevExpress.XtraEditors.CheckEdit chkFinishedGoodsFlag;
        private DevExpress.XtraEditors.CheckEdit chkMakeFlag;
        private DevExpress.XtraEditors.ComboBoxEdit cboxColor;
        private DevExpress.XtraEditors.LabelControl lblColor;
        private DevExpress.XtraEditors.TextEdit txtColor;
        private DevExpress.XtraTab.XtraTabPage tabQuantity;
        private DevExpress.XtraEditors.LabelControl lblSafetyStockLevel;
        private DevExpress.XtraEditors.ComboBoxEdit cboxSafetyStockLevel;
        private DevExpress.XtraEditors.SpinEdit spinSafetyStockLevel2;
        private DevExpress.XtraEditors.SpinEdit spinSafetyStockLevel1;
        private DevExpress.XtraEditors.SpinEdit spinReorderPoint2;
        private DevExpress.XtraEditors.SpinEdit spinReorderPoint1;
        private DevExpress.XtraEditors.LabelControl lblReorderPoint;
        private DevExpress.XtraEditors.ComboBoxEdit cboxReorderPoint;
        private DevExpress.XtraTab.XtraTabPage tabPrice;
        private DevExpress.XtraEditors.ComboBoxEdit cboxStandardCost;
        private DevExpress.XtraEditors.SpinEdit spinStandardCost2;
        private DevExpress.XtraEditors.SpinEdit spinStandardCost1;
        private DevExpress.XtraEditors.LabelControl lblStandardCost;
        private DevExpress.XtraEditors.SpinEdit spinListPrice2;
        private DevExpress.XtraEditors.SpinEdit spinListPrice1;
        private DevExpress.XtraEditors.ComboBoxEdit cboxListPrice;
        private DevExpress.XtraEditors.LabelControl lblListPrice;
        private DevExpress.XtraEditors.ComboBoxEdit cboxSize;
        private DevExpress.XtraEditors.TextEdit txtSize;
        private DevExpress.XtraEditors.LabelControl lblSize;
        private DevExpress.XtraEditors.ComboBoxEdit cboxSizeRange;
        private DevExpress.XtraEditors.TextEdit txtSizeRange;
        private DevExpress.XtraEditors.LabelControl lblSizeRange;
        private DevExpress.XtraEditors.ComboBoxEdit cboxWeight;
        private DevExpress.XtraEditors.SpinEdit spinWeight2;
        private DevExpress.XtraEditors.SpinEdit spinWeight1;
        private DevExpress.XtraEditors.LabelControl lblWeight;
        private DevExpress.XtraEditors.SpinEdit spinDaysToManufacture2;
        private DevExpress.XtraEditors.SpinEdit spinDaysToManufacture1;
        private DevExpress.XtraEditors.LabelControl lblDaysToManufacture;
        private DevExpress.XtraEditors.ComboBoxEdit cboxDaysToManufacture;
        private DevExpress.XtraEditors.ComboBoxEdit cboxProductID;
        private DevExpress.XtraEditors.LabelControl lblProductID;
        private DevExpress.XtraEditors.TextEdit txtProductID;
        private Apothex.DataType.DS_Medicament ds;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colApproverUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentName;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentSubcategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitsInStock;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryName;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandName;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentID;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentSubcategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandID;
        private DevExpress.XtraGrid.Columns.GridColumn colInUse;
        private System.Windows.Forms.BindingSource bsCategory;
        private DevExpress.XtraEditors.LookUpEdit lookCategory;
        private DevExpress.XtraEditors.ComboBoxEdit cboxCategory;
        private DevExpress.XtraEditors.LabelControl lblCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colValidDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountPct;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxRate;
        private DevExpress.XtraGrid.Columns.GridColumn colGenericName;
        private DevExpress.XtraGrid.Columns.GridColumn colGenericID;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraBars.BarButtonItem miMedicamentLocation;
        private System.Windows.Forms.BindingSource bsCurrency;
        private DevExpress.XtraEditors.LookUpEdit lookCurrency;
        private DevExpress.XtraEditors.LabelControl lblCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn col_StandardCost;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCurrencyCode;
    }
}