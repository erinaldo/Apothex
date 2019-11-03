namespace Apothex.Sales
{
    partial class frmSalesOrderDetailInfoBrowse
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSalesOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicamentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicamentCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicamentSubcategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenericName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitsInStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaleQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPriceDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLineTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValidDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMakeFlag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinishedGoodsFlag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSafetyStockLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReorderPoint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStandardCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_StandardCostLineTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colListPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ListPriceLineTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDealerPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountPct = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colOrdinalNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesOrderDetailID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductLocationID = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.bsBranch = new System.Windows.Forms.BindingSource();
            this.bsCurrency = new System.Windows.Forms.BindingSource();
            this.bsMedicamentSubcategory = new System.Windows.Forms.BindingSource();
            this.bsMedicamentCategory = new System.Windows.Forms.BindingSource();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabMain = new DevExpress.XtraTab.XtraTabPage();
            this.cboxOrderID = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboxCustomer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.bbCustomer = new Apothex.Windows.Forms.ButtonBrowse();
            this.lblCustomer = new DevExpress.XtraEditors.LabelControl();
            this.dateOrderDate2 = new DevExpress.XtraEditors.DateEdit();
            this.dateOrderDate1 = new DevExpress.XtraEditors.DateEdit();
            this.cboxOrderDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblOrderDate = new DevExpress.XtraEditors.LabelControl();
            this.lookBranch = new DevExpress.XtraEditors.LookUpEdit();
            this.lblBranch = new DevExpress.XtraEditors.LabelControl();
            this.txtOrderID = new DevExpress.XtraEditors.TextEdit();
            this.lblOrderID = new DevExpress.XtraEditors.LabelControl();
            this.tabAmount = new DevExpress.XtraTab.XtraTabPage();
            this.cboxCurrency = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblCurrency = new DevExpress.XtraEditors.LabelControl();
            this.lookCurrency = new DevExpress.XtraEditors.LookUpEdit();
            this.tabProduct = new DevExpress.XtraTab.XtraTabPage();
            this.cboxMedicament = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lookMedicamentSubcategory = new DevExpress.XtraEditors.LookUpEdit();
            this.lblMedicamentSubcategory = new DevExpress.XtraEditors.LabelControl();
            this.lookMedicamentCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.lblMedicamentCategory = new DevExpress.XtraEditors.LabelControl();
            this.lblValidDate = new DevExpress.XtraEditors.LabelControl();
            this.cboxValidDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateValidDate1 = new DevExpress.XtraEditors.DateEdit();
            this.dateValidDate2 = new DevExpress.XtraEditors.DateEdit();
            this.lblMedicament = new DevExpress.XtraEditors.LabelControl();
            this.txtMedicament = new DevExpress.XtraEditors.TextEdit();
            this.ds = new Apothex.DataType.DS_SalesOrderDetailInfo();
            this.lblProductCurrencyCode = new DevExpress.XtraEditors.LabelControl();
            this.lookProductCurrencyCode = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicamentSubcategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicamentCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderID.Properties)).BeginInit();
            this.tabAmount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCurrency.Properties)).BeginInit();
            this.tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxMedicament.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookMedicamentSubcategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookMedicamentCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxValidDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValidDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValidDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValidDate2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValidDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMedicament.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookProductCurrencyCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.xtraTabControl);
            this.pnlFilter.Size = new System.Drawing.Size(784, 175);
            this.pnlFilter.Controls.SetChildIndex(this.xtraTabControl, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnFilter, 0);
            // 
            // bsGridControl
            // 
            this.bsGridControl.DataMember = "VW_SalesOrderDetailInfo";
            this.bsGridControl.DataSource = this.ds;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridControl);
            this.pnlGrid.Location = new System.Drawing.Point(0, 214);
            this.pnlGrid.Size = new System.Drawing.Size(784, 348);
            // 
            // btnFilter
            // 
            this.btnFilter.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.Appearance.Options.UseFont = true;
            this.btnFilter.Location = new System.Drawing.Point(630, 131);
            // 
            // popupMenu
            // 
            this.popupMenu.MenuAppearance.Menu.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popupMenu.MenuAppearance.Menu.Options.UseFont = true;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bsGridControl;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(784, 348);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSalesOrderID,
            this.colBranchName,
            this.colOrderDate,
            this.colCustomerName,
            this.colMedicamentName,
            this.colMedicamentCategoryName,
            this.colMedicamentSubcategoryName,
            this.colGenericName,
            this.colProductNumber,
            this.colUnitsInStock,
            this.colSaleQty,
            this.colUnitPrice,
            this.colUnitPriceDiscount,
            this.colTaxRate,
            this.colLineTotal,
            this.colCurrencyCode,
            this.colValidDate,
            this.colCountryName,
            this.colBrandName,
            this.colSerie,
            this.colQuantity,
            this.colMakeFlag,
            this.colFinishedGoodsFlag,
            this.colColor,
            this.colSafetyStockLevel,
            this.colReorderPoint,
            this.colStandardCost,
            this.col_StandardCostLineTotal,
            this.colListPrice,
            this.col_ListPriceLineTotal,
            this.colDealerPrice,
            this.colProductCurrencyCode,
            this.colDiscountPct,
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
            this.colOrdinalNumber,
            this.colSalesOrderDetailID,
            this.colBranchID,
            this.colCustomerID,
            this.colProductLocationID,
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
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LineTotal", this.colLineTotal, "{0:n2}")});
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView_CustomUnboundColumnData);
            // 
            // colSalesOrderID
            // 
            this.colSalesOrderID.Caption = "გაყიდვის №";
            this.colSalesOrderID.FieldName = "SalesOrderID";
            this.colSalesOrderID.Name = "colSalesOrderID";
            this.colSalesOrderID.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.colSalesOrderID.Visible = true;
            this.colSalesOrderID.VisibleIndex = 0;
            // 
            // colBranchName
            // 
            this.colBranchName.Caption = "ფილიალი";
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
            // colCustomerName
            // 
            this.colCustomerName.Caption = "კომპანია";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 3;
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
            this.colProductNumber.Caption = "პროდუქტის №";
            this.colProductNumber.FieldName = "ProductNumber";
            this.colProductNumber.Name = "colProductNumber";
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
            this.colUnitsInStock.VisibleIndex = 5;
            // 
            // colSaleQty
            // 
            this.colSaleQty.Caption = "რაოდ. / გ.";
            this.colSaleQty.DisplayFormat.FormatString = "n4";
            this.colSaleQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSaleQty.FieldName = "SaleQty";
            this.colSaleQty.GroupFormat.FormatString = "n2";
            this.colSaleQty.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSaleQty.Name = "colSaleQty";
            this.colSaleQty.Visible = true;
            this.colSaleQty.VisibleIndex = 6;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "ფასი / გ.";
            this.colUnitPrice.DisplayFormat.FormatString = "n4";
            this.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.GroupFormat.FormatString = "n2";
            this.colUnitPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 7;
            // 
            // colUnitPriceDiscount
            // 
            this.colUnitPriceDiscount.Caption = "ფასდაკლება";
            this.colUnitPriceDiscount.DisplayFormat.FormatString = "p";
            this.colUnitPriceDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPriceDiscount.FieldName = "UnitPriceDiscount";
            this.colUnitPriceDiscount.GroupFormat.FormatString = "p";
            this.colUnitPriceDiscount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPriceDiscount.Name = "colUnitPriceDiscount";
            this.colUnitPriceDiscount.Visible = true;
            this.colUnitPriceDiscount.VisibleIndex = 8;
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
            this.colTaxRate.VisibleIndex = 9;
            // 
            // colLineTotal
            // 
            this.colLineTotal.AppearanceCell.BackColor = System.Drawing.Color.Cornsilk;
            this.colLineTotal.AppearanceCell.Options.UseBackColor = true;
            this.colLineTotal.Caption = "ჯამი / გ.";
            this.colLineTotal.DisplayFormat.FormatString = "n4";
            this.colLineTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLineTotal.FieldName = "LineTotal";
            this.colLineTotal.GroupFormat.FormatString = "n2";
            this.colLineTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLineTotal.Name = "colLineTotal";
            this.colLineTotal.OptionsColumn.ReadOnly = true;
            this.colLineTotal.SummaryItem.DisplayFormat = "{0:n2}";
            this.colLineTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colLineTotal.Visible = true;
            this.colLineTotal.VisibleIndex = 10;
            // 
            // colCurrencyCode
            // 
            this.colCurrencyCode.Caption = "ვალუტა";
            this.colCurrencyCode.FieldName = "CurrencyCode";
            this.colCurrencyCode.Name = "colCurrencyCode";
            this.colCurrencyCode.Visible = true;
            this.colCurrencyCode.VisibleIndex = 11;
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
            this.colValidDate.VisibleIndex = 12;
            // 
            // colCountryName
            // 
            this.colCountryName.Caption = "მწ. ქვეყანა";
            this.colCountryName.FieldName = "CountryName";
            this.colCountryName.Name = "colCountryName";
            this.colCountryName.Visible = true;
            this.colCountryName.VisibleIndex = 13;
            // 
            // colBrandName
            // 
            this.colBrandName.Caption = "ბრენდი";
            this.colBrandName.FieldName = "BrandName";
            this.colBrandName.Name = "colBrandName";
            this.colBrandName.Visible = true;
            this.colBrandName.VisibleIndex = 14;
            // 
            // colSerie
            // 
            this.colSerie.Caption = "სერია";
            this.colSerie.FieldName = "Serie";
            this.colSerie.Name = "colSerie";
            this.colSerie.Visible = true;
            this.colSerie.VisibleIndex = 15;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "ნაშთი";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 16;
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
            // colStandardCost
            // 
            this.colStandardCost.Caption = "ფასი / შ. / პ.ე.";
            this.colStandardCost.DisplayFormat.FormatString = "n4";
            this.colStandardCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colStandardCost.FieldName = "StandardCost";
            this.colStandardCost.GroupFormat.FormatString = "n2";
            this.colStandardCost.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colStandardCost.Name = "colStandardCost";
            this.colStandardCost.Visible = true;
            this.colStandardCost.VisibleIndex = 17;
            // 
            // col_StandardCostLineTotal
            // 
            this.col_StandardCostLineTotal.Caption = "ჯამი / შ. / პ.ე.";
            this.col_StandardCostLineTotal.DisplayFormat.FormatString = "n4";
            this.col_StandardCostLineTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_StandardCostLineTotal.FieldName = "_StandardCostLineTotal";
            this.col_StandardCostLineTotal.GroupFormat.FormatString = "n2";
            this.col_StandardCostLineTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_StandardCostLineTotal.Name = "col_StandardCostLineTotal";
            this.col_StandardCostLineTotal.SummaryItem.DisplayFormat = "{0:n2}";
            this.col_StandardCostLineTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.col_StandardCostLineTotal.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col_StandardCostLineTotal.Visible = true;
            this.col_StandardCostLineTotal.VisibleIndex = 18;
            // 
            // colListPrice
            // 
            this.colListPrice.Caption = "ფასი / გ. / პ.ე.";
            this.colListPrice.DisplayFormat.FormatString = "n4";
            this.colListPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colListPrice.FieldName = "ListPrice";
            this.colListPrice.GroupFormat.FormatString = "n2";
            this.colListPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colListPrice.Name = "colListPrice";
            this.colListPrice.Visible = true;
            this.colListPrice.VisibleIndex = 19;
            // 
            // col_ListPriceLineTotal
            // 
            this.col_ListPriceLineTotal.Caption = "ჯამი / გ. / პ.ე.";
            this.col_ListPriceLineTotal.DisplayFormat.FormatString = "n4";
            this.col_ListPriceLineTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_ListPriceLineTotal.FieldName = "_ListPriceLineTotal";
            this.col_ListPriceLineTotal.GroupFormat.FormatString = "n2";
            this.col_ListPriceLineTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_ListPriceLineTotal.Name = "col_ListPriceLineTotal";
            this.col_ListPriceLineTotal.SummaryItem.DisplayFormat = "{0:n2}";
            this.col_ListPriceLineTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.col_ListPriceLineTotal.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col_ListPriceLineTotal.Visible = true;
            this.col_ListPriceLineTotal.VisibleIndex = 20;
            // 
            // colDealerPrice
            // 
            this.colDealerPrice.Caption = "ფასი / დილ. / პ.ე.";
            this.colDealerPrice.DisplayFormat.FormatString = "n4";
            this.colDealerPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDealerPrice.FieldName = "DealerPrice";
            this.colDealerPrice.GroupFormat.FormatString = "n2";
            this.colDealerPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDealerPrice.Name = "colDealerPrice";
            this.colDealerPrice.Visible = true;
            this.colDealerPrice.VisibleIndex = 21;
            // 
            // colProductCurrencyCode
            // 
            this.colProductCurrencyCode.Caption = "პ/ე ვალუტა";
            this.colProductCurrencyCode.FieldName = "ProductCurrencyCode";
            this.colProductCurrencyCode.Name = "colProductCurrencyCode";
            this.colProductCurrencyCode.Visible = true;
            this.colProductCurrencyCode.VisibleIndex = 22;
            // 
            // colDiscountPct
            // 
            this.colDiscountPct.Caption = "ფასდაკლება";
            this.colDiscountPct.DisplayFormat.FormatString = "p";
            this.colDiscountPct.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscountPct.FieldName = "DiscountPct";
            this.colDiscountPct.GroupFormat.FormatString = "p";
            this.colDiscountPct.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscountPct.Name = "colDiscountPct";
            this.colDiscountPct.Visible = true;
            this.colDiscountPct.VisibleIndex = 23;
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
            this.colProductLine.Caption = "პროდ. ხაზი.";
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
            // colOrdinalNumber
            // 
            this.colOrdinalNumber.Caption = "რიგითი №";
            this.colOrdinalNumber.FieldName = "OrdinalNumber";
            this.colOrdinalNumber.Name = "colOrdinalNumber";
            this.colOrdinalNumber.Visible = true;
            this.colOrdinalNumber.VisibleIndex = 24;
            // 
            // colSalesOrderDetailID
            // 
            this.colSalesOrderDetailID.FieldName = "SalesOrderDetailID";
            this.colSalesOrderDetailID.Name = "colSalesOrderDetailID";
            // 
            // colBranchID
            // 
            this.colBranchID.FieldName = "BranchID";
            this.colBranchID.Name = "colBranchID";
            // 
            // colCustomerID
            // 
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.Name = "colCustomerID";
            // 
            // colProductLocationID
            // 
            this.colProductLocationID.FieldName = "ProductLocationID";
            this.colProductLocationID.Name = "colProductLocationID";
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
            // bsBranch
            // 
            this.bsBranch.Sort = "";
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.AppearancePage.Header.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xtraTabControl.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl.Location = new System.Drawing.Point(2, 2);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.SelectedTabPage = this.tabMain;
            this.xtraTabControl.Size = new System.Drawing.Size(780, 171);
            this.xtraTabControl.TabIndex = 0;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabMain,
            this.tabAmount,
            this.tabProduct});
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.cboxOrderID);
            this.tabMain.Controls.Add(this.cboxCustomer);
            this.tabMain.Controls.Add(this.bbCustomer);
            this.tabMain.Controls.Add(this.lblCustomer);
            this.tabMain.Controls.Add(this.dateOrderDate2);
            this.tabMain.Controls.Add(this.dateOrderDate1);
            this.tabMain.Controls.Add(this.cboxOrderDate);
            this.tabMain.Controls.Add(this.lblOrderDate);
            this.tabMain.Controls.Add(this.lookBranch);
            this.tabMain.Controls.Add(this.lblBranch);
            this.tabMain.Controls.Add(this.txtOrderID);
            this.tabMain.Controls.Add(this.lblOrderID);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(774, 142);
            this.tabMain.Text = "მთავარი";
            // 
            // cboxOrderID
            // 
            this.cboxOrderID.EditValue = "=";
            this.cboxOrderID.EnterMoveNextControl = true;
            this.cboxOrderID.Location = new System.Drawing.Point(93, 6);
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
            // cboxCustomer
            // 
            this.cboxCustomer.EditValue = "=";
            this.cboxCustomer.EnterMoveNextControl = true;
            this.cboxCustomer.Location = new System.Drawing.Point(93, 93);
            this.cboxCustomer.Name = "cboxCustomer";
            this.cboxCustomer.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxCustomer.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxCustomer.Properties.Appearance.Options.UseFont = true;
            this.cboxCustomer.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxCustomer.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxCustomer.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!="});
            this.cboxCustomer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxCustomer.Size = new System.Drawing.Size(80, 23);
            this.cboxCustomer.TabIndex = 10;
            this.cboxCustomer.SelectedIndexChanged += new System.EventHandler(this.cboxCustomer_SelectedIndexChanged);
            // 
            // bbCustomer
            // 
            this.bbCustomer.EnterMoveNextControl = true;
            this.bbCustomer.IsOnline = true;
            this.bbCustomer.Location = new System.Drawing.Point(179, 93);
            this.bbCustomer.MenuManager = this.barManager;
            this.bbCustomer.Name = "bbCustomer";
            this.bbCustomer.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bbCustomer.Properties.Appearance.Options.UseFont = true;
            this.bbCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject1, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject2, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbCustomer.Size = new System.Drawing.Size(306, 23);
            this.bbCustomer.TabIndex = 11;
            this.bbCustomer.TableName = Apothex.DataType.ObjectNames.Company;
            // 
            // lblCustomer
            // 
            this.lblCustomer.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCustomer.Location = new System.Drawing.Point(6, 96);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(72, 17);
            this.lblCustomer.TabIndex = 9;
            this.lblCustomer.Text = "კომპანია:";
            // 
            // dateOrderDate2
            // 
            this.dateOrderDate2.EditValue = null;
            this.dateOrderDate2.Enabled = false;
            this.dateOrderDate2.EnterMoveNextControl = true;
            this.dateOrderDate2.Location = new System.Drawing.Point(335, 64);
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
            this.dateOrderDate2.TabIndex = 8;
            this.dateOrderDate2.EditValueChanged += new System.EventHandler(this.dateOrderDate2_EditValueChanged);
            // 
            // dateOrderDate1
            // 
            this.dateOrderDate1.EditValue = null;
            this.dateOrderDate1.Enabled = false;
            this.dateOrderDate1.EnterMoveNextControl = true;
            this.dateOrderDate1.Location = new System.Drawing.Point(179, 64);
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
            this.dateOrderDate1.TabIndex = 7;
            this.dateOrderDate1.EditValueChanged += new System.EventHandler(this.dateOrderDate1_EditValueChanged);
            // 
            // cboxOrderDate
            // 
            this.cboxOrderDate.EnterMoveNextControl = true;
            this.cboxOrderDate.Location = new System.Drawing.Point(93, 64);
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
            this.cboxOrderDate.Size = new System.Drawing.Size(80, 23);
            this.cboxOrderDate.TabIndex = 6;
            this.cboxOrderDate.SelectedIndexChanged += new System.EventHandler(this.cboxOrderDate_SelectedIndexChanged);
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderDate.Location = new System.Drawing.Point(6, 67);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(65, 17);
            this.lblOrderDate.TabIndex = 5;
            this.lblOrderDate.Text = "თარიღი:";
            // 
            // lookBranch
            // 
            this.lookBranch.EnterMoveNextControl = true;
            this.lookBranch.Location = new System.Drawing.Point(93, 35);
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
            this.lookBranch.Size = new System.Drawing.Size(392, 23);
            this.lookBranch.TabIndex = 4;
            // 
            // lblBranch
            // 
            this.lblBranch.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBranch.Location = new System.Drawing.Point(6, 38);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(81, 17);
            this.lblBranch.TabIndex = 3;
            this.lblBranch.Text = "ფილიალი:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.EnterMoveNextControl = true;
            this.txtOrderID.Location = new System.Drawing.Point(179, 6);
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
            this.txtOrderID.Size = new System.Drawing.Size(306, 23);
            this.txtOrderID.TabIndex = 2;
            // 
            // lblOrderID
            // 
            this.lblOrderID.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderID.Location = new System.Drawing.Point(6, 9);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(20, 17);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "№:";
            // 
            // tabAmount
            // 
            this.tabAmount.Controls.Add(this.cboxCurrency);
            this.tabAmount.Controls.Add(this.lblCurrency);
            this.tabAmount.Controls.Add(this.lookCurrency);
            this.tabAmount.Name = "tabAmount";
            this.tabAmount.Size = new System.Drawing.Size(774, 142);
            this.tabAmount.Text = "თანხები";
            // 
            // cboxCurrency
            // 
            this.cboxCurrency.EditValue = "=";
            this.cboxCurrency.EnterMoveNextControl = true;
            this.cboxCurrency.Location = new System.Drawing.Point(91, 6);
            this.cboxCurrency.Name = "cboxCurrency";
            this.cboxCurrency.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxCurrency.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxCurrency.Properties.Appearance.Options.UseFont = true;
            this.cboxCurrency.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxCurrency.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxCurrency.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!="});
            this.cboxCurrency.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxCurrency.Size = new System.Drawing.Size(80, 23);
            this.cboxCurrency.TabIndex = 1;
            this.cboxCurrency.SelectedIndexChanged += new System.EventHandler(this.cboxCurrency_SelectedIndexChanged);
            // 
            // lblCurrency
            // 
            this.lblCurrency.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrency.Location = new System.Drawing.Point(6, 9);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(63, 17);
            this.lblCurrency.TabIndex = 0;
            this.lblCurrency.Text = "ვალუტა:";
            // 
            // lookCurrency
            // 
            this.lookCurrency.EnterMoveNextControl = true;
            this.lookCurrency.Location = new System.Drawing.Point(177, 6);
            this.lookCurrency.Name = "lookCurrency";
            this.lookCurrency.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookCurrency.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookCurrency.Properties.Appearance.Options.UseFont = true;
            this.lookCurrency.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookCurrency.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookCurrency.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookCurrency.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lookCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookCurrency.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.lookCurrency.Properties.DataSource = this.bsCurrency;
            this.lookCurrency.Properties.DisplayMember = "Caption";
            this.lookCurrency.Properties.NullText = "";
            this.lookCurrency.Properties.ShowHeader = false;
            this.lookCurrency.Properties.ValueMember = "ID";
            this.lookCurrency.Size = new System.Drawing.Size(226, 23);
            this.lookCurrency.TabIndex = 2;
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.lblProductCurrencyCode);
            this.tabProduct.Controls.Add(this.lookProductCurrencyCode);
            this.tabProduct.Controls.Add(this.cboxMedicament);
            this.tabProduct.Controls.Add(this.lookMedicamentSubcategory);
            this.tabProduct.Controls.Add(this.lblMedicamentSubcategory);
            this.tabProduct.Controls.Add(this.lookMedicamentCategory);
            this.tabProduct.Controls.Add(this.lblMedicamentCategory);
            this.tabProduct.Controls.Add(this.lblValidDate);
            this.tabProduct.Controls.Add(this.cboxValidDate);
            this.tabProduct.Controls.Add(this.dateValidDate1);
            this.tabProduct.Controls.Add(this.dateValidDate2);
            this.tabProduct.Controls.Add(this.lblMedicament);
            this.tabProduct.Controls.Add(this.txtMedicament);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Size = new System.Drawing.Size(774, 142);
            this.tabProduct.Text = "პროდუქცია";
            // 
            // cboxMedicament
            // 
            this.cboxMedicament.EditValue = "%a%";
            this.cboxMedicament.EnterMoveNextControl = true;
            this.cboxMedicament.Location = new System.Drawing.Point(126, 6);
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
            this.cboxMedicament.Size = new System.Drawing.Size(80, 23);
            this.cboxMedicament.TabIndex = 1;
            this.cboxMedicament.SelectedIndexChanged += new System.EventHandler(this.cboxMedicament_SelectedIndexChanged);
            // 
            // lookMedicamentSubcategory
            // 
            this.lookMedicamentSubcategory.EnterMoveNextControl = true;
            this.lookMedicamentSubcategory.Location = new System.Drawing.Point(126, 64);
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
            this.lookMedicamentSubcategory.TabIndex = 6;
            // 
            // lblMedicamentSubcategory
            // 
            this.lblMedicamentSubcategory.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMedicamentSubcategory.Location = new System.Drawing.Point(7, 67);
            this.lblMedicamentSubcategory.Name = "lblMedicamentSubcategory";
            this.lblMedicamentSubcategory.Size = new System.Drawing.Size(110, 17);
            this.lblMedicamentSubcategory.TabIndex = 5;
            this.lblMedicamentSubcategory.Text = "ქვეკატეგორია:";
            // 
            // lookMedicamentCategory
            // 
            this.lookMedicamentCategory.EnterMoveNextControl = true;
            this.lookMedicamentCategory.Location = new System.Drawing.Point(126, 35);
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
            this.lookMedicamentCategory.TabIndex = 4;
            this.lookMedicamentCategory.EditValueChanged += new System.EventHandler(this.lookMedicamentCategory_EditValueChanged);
            // 
            // lblMedicamentCategory
            // 
            this.lblMedicamentCategory.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMedicamentCategory.Location = new System.Drawing.Point(7, 38);
            this.lblMedicamentCategory.Name = "lblMedicamentCategory";
            this.lblMedicamentCategory.Size = new System.Drawing.Size(86, 17);
            this.lblMedicamentCategory.TabIndex = 3;
            this.lblMedicamentCategory.Text = "კატეგორია:";
            // 
            // lblValidDate
            // 
            this.lblValidDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblValidDate.Location = new System.Drawing.Point(7, 96);
            this.lblValidDate.Name = "lblValidDate";
            this.lblValidDate.Size = new System.Drawing.Size(41, 17);
            this.lblValidDate.TabIndex = 7;
            this.lblValidDate.Text = "ვადა:";
            // 
            // cboxValidDate
            // 
            this.cboxValidDate.EnterMoveNextControl = true;
            this.cboxValidDate.Location = new System.Drawing.Point(126, 93);
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
            this.cboxValidDate.TabIndex = 8;
            this.cboxValidDate.SelectedIndexChanged += new System.EventHandler(this.cboxValidDate_SelectedIndexChanged);
            // 
            // dateValidDate1
            // 
            this.dateValidDate1.EditValue = null;
            this.dateValidDate1.Enabled = false;
            this.dateValidDate1.EnterMoveNextControl = true;
            this.dateValidDate1.Location = new System.Drawing.Point(212, 93);
            this.dateValidDate1.Name = "dateValidDate1";
            this.dateValidDate1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
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
            this.dateValidDate1.TabIndex = 9;
            this.dateValidDate1.EditValueChanged += new System.EventHandler(this.dateValidDate1_EditValueChanged);
            // 
            // dateValidDate2
            // 
            this.dateValidDate2.EditValue = null;
            this.dateValidDate2.Enabled = false;
            this.dateValidDate2.EnterMoveNextControl = true;
            this.dateValidDate2.Location = new System.Drawing.Point(328, 93);
            this.dateValidDate2.Name = "dateValidDate2";
            this.dateValidDate2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
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
            this.dateValidDate2.TabIndex = 10;
            this.dateValidDate2.EditValueChanged += new System.EventHandler(this.dateValidDate2_EditValueChanged);
            // 
            // lblMedicament
            // 
            this.lblMedicament.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMedicament.Location = new System.Drawing.Point(7, 9);
            this.lblMedicament.Name = "lblMedicament";
            this.lblMedicament.Size = new System.Drawing.Size(98, 17);
            this.lblMedicament.TabIndex = 0;
            this.lblMedicament.Text = "მედიკამენტი:";
            // 
            // txtMedicament
            // 
            this.txtMedicament.EnterMoveNextControl = true;
            this.txtMedicament.Location = new System.Drawing.Point(212, 6);
            this.txtMedicament.Name = "txtMedicament";
            this.txtMedicament.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMedicament.Properties.Appearance.Options.UseFont = true;
            this.txtMedicament.Size = new System.Drawing.Size(226, 23);
            this.txtMedicament.TabIndex = 2;
            // 
            // ds
            // 
            this.ds.DataSetName = "DS_SalesOrderDetailInfo";
            this.ds.Locale = new System.Globalization.CultureInfo("");
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblProductCurrencyCode
            // 
            this.lblProductCurrencyCode.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductCurrencyCode.Location = new System.Drawing.Point(453, 9);
            this.lblProductCurrencyCode.Name = "lblProductCurrencyCode";
            this.lblProductCurrencyCode.Size = new System.Drawing.Size(89, 17);
            this.lblProductCurrencyCode.TabIndex = 11;
            this.lblProductCurrencyCode.Text = "პ/ე ვალუტა:";
            // 
            // lookProductCurrencyCode
            // 
            this.lookProductCurrencyCode.EnterMoveNextControl = true;
            this.lookProductCurrencyCode.Location = new System.Drawing.Point(557, 6);
            this.lookProductCurrencyCode.Name = "lookProductCurrencyCode";
            this.lookProductCurrencyCode.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookProductCurrencyCode.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookProductCurrencyCode.Properties.Appearance.Options.UseFont = true;
            this.lookProductCurrencyCode.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookProductCurrencyCode.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookProductCurrencyCode.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookProductCurrencyCode.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lookProductCurrencyCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookProductCurrencyCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.lookProductCurrencyCode.Properties.DisplayMember = "Caption";
            this.lookProductCurrencyCode.Properties.NullText = "";
            this.lookProductCurrencyCode.Properties.ShowHeader = false;
            this.lookProductCurrencyCode.Properties.ValueMember = "ID";
            this.lookProductCurrencyCode.Size = new System.Drawing.Size(224, 23);
            this.lookProductCurrencyCode.TabIndex = 12;
            // 
            // frmSalesOrderDetailInfoBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsFiltered = true;
            this.IsFilterPanelVisible = true;
            this.Name = "frmSalesOrderDetailInfoBrowse";
            this.ObjectName = Apothex.DataType.ObjectNames.SalesOrderDetailInfo;
            this.OptionsBaseForm.IsPrintable = true;
            this.OptionsBaseForm.Text = "გაყიდვების დეტალური ინფორმაცია";
            this.OptionsListForm.IsAddable = false;
            this.OptionsListForm.IsApprovable = false;
            this.OptionsListForm.IsBlockable = false;
            this.OptionsListForm.IsChooseable = false;
            this.OptionsListForm.IsDeletable = false;
            this.OptionsListForm.IsDisapprovable = false;
            this.OptionsListForm.IsSystemColumnsable = true;
            this.OptionsListForm.IsUnblockable = false;
            this.OptionsGrid.ColumnID = "SalesOrderID";
            this.OptionsGrid.ColumnStatusID = "Status";
            this.OptionsGrid.GridView = this.gridView;
            this.Text = "გაყიდვების დეტალური ინფორმაცია";
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicamentSubcategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicamentCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderID.Properties)).EndInit();
            this.tabAmount.ResumeLayout(false);
            this.tabAmount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCurrency.Properties)).EndInit();
            this.tabProduct.ResumeLayout(false);
            this.tabProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxMedicament.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookMedicamentSubcategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookMedicamentCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxValidDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValidDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValidDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValidDate2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValidDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMedicament.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookProductCurrencyCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.BindingSource bsBranch;
        private System.Windows.Forms.BindingSource bsCurrency;
        private System.Windows.Forms.BindingSource bsMedicamentSubcategory;
        private System.Windows.Forms.BindingSource bsMedicamentCategory;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage tabMain;
        private DevExpress.XtraEditors.DateEdit dateOrderDate2;
        private DevExpress.XtraEditors.DateEdit dateOrderDate1;
        private DevExpress.XtraEditors.ComboBoxEdit cboxOrderDate;
        private DevExpress.XtraEditors.LabelControl lblOrderDate;
        private DevExpress.XtraEditors.LookUpEdit lookBranch;
        private DevExpress.XtraEditors.LabelControl lblBranch;
        private DevExpress.XtraEditors.TextEdit txtOrderID;
        private DevExpress.XtraEditors.LabelControl lblOrderID;
        private DevExpress.XtraTab.XtraTabPage tabAmount;
        private DevExpress.XtraEditors.ComboBoxEdit cboxCurrency;
        private DevExpress.XtraEditors.LabelControl lblCurrency;
        private DevExpress.XtraEditors.LookUpEdit lookCurrency;
        private DevExpress.XtraTab.XtraTabPage tabProduct;
        private DevExpress.XtraEditors.ComboBoxEdit cboxMedicament;
        private DevExpress.XtraEditors.LookUpEdit lookMedicamentSubcategory;
        private DevExpress.XtraEditors.LabelControl lblMedicamentSubcategory;
        private DevExpress.XtraEditors.LookUpEdit lookMedicamentCategory;
        private DevExpress.XtraEditors.LabelControl lblMedicamentCategory;
        private DevExpress.XtraEditors.LabelControl lblValidDate;
        private DevExpress.XtraEditors.ComboBoxEdit cboxValidDate;
        private DevExpress.XtraEditors.DateEdit dateValidDate1;
        private DevExpress.XtraEditors.DateEdit dateValidDate2;
        private DevExpress.XtraEditors.LabelControl lblMedicament;
        private DevExpress.XtraEditors.TextEdit txtMedicament;
        private DevExpress.XtraEditors.ComboBoxEdit cboxCustomer;
        private Apothex.Windows.Forms.ButtonBrowse bbCustomer;
        private DevExpress.XtraEditors.LabelControl lblCustomer;
        private DevExpress.XtraEditors.ComboBoxEdit cboxOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchName;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentName;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentSubcategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitsInStock;
        private DevExpress.XtraGrid.Columns.GridColumn colProductNumber;
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
        private DevExpress.XtraGrid.Columns.GridColumn colStandardCost;
        private DevExpress.XtraGrid.Columns.GridColumn colListPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDealerPrice;
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
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPriceDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleQty;
        private DevExpress.XtraGrid.Columns.GridColumn colLineTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colOrdinalNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesOrderDetailID;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductLocationID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseOrderDetailID;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentID;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentSubcategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandID;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxRate;
        private DevExpress.XtraGrid.Columns.GridColumn col_StandardCostLineTotal;
        private DevExpress.XtraGrid.Columns.GridColumn col_ListPriceLineTotal;
        private Apothex.DataType.DS_SalesOrderDetailInfo ds;
        private DevExpress.XtraGrid.Columns.GridColumn colGenericName;
        private DevExpress.XtraGrid.Columns.GridColumn colGenericID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCurrencyCode;
        private DevExpress.XtraEditors.LabelControl lblProductCurrencyCode;
        private DevExpress.XtraEditors.LookUpEdit lookProductCurrencyCode;
    }
}