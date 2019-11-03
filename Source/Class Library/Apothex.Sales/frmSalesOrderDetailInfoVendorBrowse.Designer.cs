namespace Apothex.Sales
{
    partial class frmSalesOrderDetailInfoVendorBrowse
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPurchaseOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseOrderBranchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVendorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesOrderBranchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaleQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPriceDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLineTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_PurchaseLineTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrdinalNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicamentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitsInStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStandardCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colListPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDealerPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountPct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValidDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseOrderBranchID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVendorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesOrderBranchID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifierID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ds = new Apothex.DataType.DS_SalesOrderDetailInfoVendor();
            this.bsBranch = new System.Windows.Forms.BindingSource(this.components);
            this.datePurchaseOrderDate2 = new DevExpress.XtraEditors.DateEdit();
            this.datePurchaseOrderDate1 = new DevExpress.XtraEditors.DateEdit();
            this.cboxPurchaseOrderDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblOrderDate = new DevExpress.XtraEditors.LabelControl();
            this.cboxPurchaseOrderID = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPurchaseOrderID = new DevExpress.XtraEditors.TextEdit();
            this.lblOrderID = new DevExpress.XtraEditors.LabelControl();
            this.lblCompany = new DevExpress.XtraEditors.LabelControl();
            this.bbVendor = new Apothex.Windows.Forms.ButtonBrowse();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabPurchase = new DevExpress.XtraTab.XtraTabPage();
            this.bbPurchaseOrderBranch = new Apothex.Windows.Forms.ButtonBrowse();
            this.lblPurchaseOrderBranch = new DevExpress.XtraEditors.LabelControl();
            this.tabSales = new DevExpress.XtraTab.XtraTabPage();
            this.bbSalesOrderBranch = new Apothex.Windows.Forms.ButtonBrowse();
            this.lblSalesOrderBranch = new DevExpress.XtraEditors.LabelControl();
            this.lblSalesOrderID = new DevExpress.XtraEditors.LabelControl();
            this.cboxSalesOrderDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateSalesOrderDate1 = new DevExpress.XtraEditors.DateEdit();
            this.bbCustomer = new Apothex.Windows.Forms.ButtonBrowse();
            this.dateSalesOrderDate2 = new DevExpress.XtraEditors.DateEdit();
            this.lblCustomer = new DevExpress.XtraEditors.LabelControl();
            this.lblSalesOrderDate = new DevExpress.XtraEditors.LabelControl();
            this.cboxSalesOrderID = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtSalesOrderID = new DevExpress.XtraEditors.TextEdit();
            this.tabProduct = new DevExpress.XtraTab.XtraTabPage();
            this.lblProductCurrencyCode = new DevExpress.XtraEditors.LabelControl();
            this.lookProductCurrencyCode = new DevExpress.XtraEditors.LookUpEdit();
            this.cboxProduct = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblProduct = new DevExpress.XtraEditors.LabelControl();
            this.txtProduct = new DevExpress.XtraEditors.TextEdit();
            this.colPurchaseOrderOverheadNumber = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.datePurchaseOrderDate2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePurchaseOrderDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePurchaseOrderDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePurchaseOrderDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxPurchaseOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxPurchaseOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchaseOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbVendor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.tabPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbPurchaseOrderBranch.Properties)).BeginInit();
            this.tabSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbSalesOrderBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxSalesOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDate2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxSalesOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalesOrderID.Properties)).BeginInit();
            this.tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookProductCurrencyCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduct.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.xtraTabControl);
            this.pnlFilter.Size = new System.Drawing.Size(784, 130);
            this.pnlFilter.Controls.SetChildIndex(this.xtraTabControl, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnFilter, 0);
            // 
            // bsGridControl
            // 
            this.bsGridControl.DataMember = "VW_SalesOrderDetailInfoVendor";
            this.bsGridControl.DataSource = this.ds;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridControl);
            this.pnlGrid.Location = new System.Drawing.Point(0, 169);
            this.pnlGrid.Size = new System.Drawing.Size(784, 393);
            // 
            // btnFilter
            // 
            this.btnFilter.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.Appearance.Options.UseFont = true;
            this.btnFilter.Location = new System.Drawing.Point(526, 81);
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
            this.gridControl.MenuManager = this.barManager;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(784, 393);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPurchaseOrderID,
            this.colPurchaseOrderBranchName,
            this.colPurchaseOrderDate,
            this.colPurchaseOrderOverheadNumber,
            this.colVendorName,
            this.colSalesOrderID,
            this.colSalesOrderBranchName,
            this.colSalesOrderDate,
            this.colCustomerName,
            this.colSaleQty,
            this.colUnitPrice,
            this.colUnitPriceDiscount,
            this.colLineTotal,
            this.colCurrencyCode,
            this.colPurchaseUnitPrice,
            this.colPurchaseCurrencyCode,
            this.col_PurchaseLineTotal,
            this.colOrdinalNumber,
            this.colMedicamentName,
            this.colUnitsInStock,
            this.colProductNumber,
            this.colQuantity,
            this.colStandardCost,
            this.colListPrice,
            this.colDealerPrice,
            this.colProductCurrencyCode,
            this.colDiscountPct,
            this.colTaxRate,
            this.colValidDate,
            this.colCountryName,
            this.colBrandName,
            this.colSerie,
            this.colPurchaseOrderBranchID,
            this.colVendorID,
            this.colSalesOrderBranchID,
            this.colCustomerID,
            this.colStatus,
            this.colModifierID,
            this.colModifier});
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LineTotal", this.colLineTotal, "{0:n2}")});
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowFooter = true;
            // 
            // colPurchaseOrderID
            // 
            this.colPurchaseOrderID.Caption = "შესყიდვის №";
            this.colPurchaseOrderID.FieldName = "PurchaseOrderID";
            this.colPurchaseOrderID.Name = "colPurchaseOrderID";
            this.colPurchaseOrderID.Visible = true;
            this.colPurchaseOrderID.VisibleIndex = 0;
            // 
            // colPurchaseOrderBranchName
            // 
            this.colPurchaseOrderBranchName.Caption = "შესყ. ფილიალი";
            this.colPurchaseOrderBranchName.FieldName = "PurchaseOrderBranchName";
            this.colPurchaseOrderBranchName.Name = "colPurchaseOrderBranchName";
            this.colPurchaseOrderBranchName.Visible = true;
            this.colPurchaseOrderBranchName.VisibleIndex = 1;
            // 
            // colPurchaseOrderDate
            // 
            this.colPurchaseOrderDate.Caption = "შესყ. თარიღი";
            this.colPurchaseOrderDate.DisplayFormat.FormatString = "G";
            this.colPurchaseOrderDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colPurchaseOrderDate.FieldName = "PurchaseOrderDate";
            this.colPurchaseOrderDate.GroupFormat.FormatString = "d";
            this.colPurchaseOrderDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colPurchaseOrderDate.Name = "colPurchaseOrderDate";
            this.colPurchaseOrderDate.Visible = true;
            this.colPurchaseOrderDate.VisibleIndex = 2;
            // 
            // colVendorName
            // 
            this.colVendorName.Caption = "შესყ. კომპანია";
            this.colVendorName.FieldName = "VendorName";
            this.colVendorName.Name = "colVendorName";
            this.colVendorName.Visible = true;
            this.colVendorName.VisibleIndex = 4;
            // 
            // colSalesOrderID
            // 
            this.colSalesOrderID.Caption = "გაყიდვის №";
            this.colSalesOrderID.FieldName = "SalesOrderID";
            this.colSalesOrderID.Name = "colSalesOrderID";
            this.colSalesOrderID.Visible = true;
            this.colSalesOrderID.VisibleIndex = 5;
            // 
            // colSalesOrderBranchName
            // 
            this.colSalesOrderBranchName.Caption = "გაყ. ფილიალი";
            this.colSalesOrderBranchName.FieldName = "SalesOrderBranchName";
            this.colSalesOrderBranchName.Name = "colSalesOrderBranchName";
            this.colSalesOrderBranchName.Visible = true;
            this.colSalesOrderBranchName.VisibleIndex = 6;
            // 
            // colSalesOrderDate
            // 
            this.colSalesOrderDate.Caption = "გაყ. თარიღი";
            this.colSalesOrderDate.DisplayFormat.FormatString = "G";
            this.colSalesOrderDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSalesOrderDate.FieldName = "SalesOrderDate";
            this.colSalesOrderDate.GroupFormat.FormatString = "d";
            this.colSalesOrderDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSalesOrderDate.Name = "colSalesOrderDate";
            this.colSalesOrderDate.Visible = true;
            this.colSalesOrderDate.VisibleIndex = 7;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "გაყ. კომპანია";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 8;
            // 
            // colSaleQty
            // 
            this.colSaleQty.Caption = "რაოდენობა";
            this.colSaleQty.DisplayFormat.FormatString = "n4";
            this.colSaleQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSaleQty.FieldName = "SaleQty";
            this.colSaleQty.GroupFormat.FormatString = "n2";
            this.colSaleQty.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSaleQty.Name = "colSaleQty";
            this.colSaleQty.Visible = true;
            this.colSaleQty.VisibleIndex = 9;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "ფასი / გ.";
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 10;
            // 
            // colUnitPriceDiscount
            // 
            this.colUnitPriceDiscount.Caption = "ფასდაკლ.";
            this.colUnitPriceDiscount.DisplayFormat.FormatString = "p";
            this.colUnitPriceDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPriceDiscount.FieldName = "UnitPriceDiscount";
            this.colUnitPriceDiscount.GroupFormat.FormatString = "p";
            this.colUnitPriceDiscount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPriceDiscount.Name = "colUnitPriceDiscount";
            this.colUnitPriceDiscount.Visible = true;
            this.colUnitPriceDiscount.VisibleIndex = 11;
            // 
            // colLineTotal
            // 
            this.colLineTotal.AppearanceCell.BackColor = System.Drawing.Color.Cornsilk;
            this.colLineTotal.AppearanceCell.Options.UseBackColor = true;
            this.colLineTotal.Caption = "თანხა / გ.";
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
            this.colLineTotal.VisibleIndex = 12;
            // 
            // colCurrencyCode
            // 
            this.colCurrencyCode.Caption = "ვალუტა";
            this.colCurrencyCode.FieldName = "CurrencyCode";
            this.colCurrencyCode.Name = "colCurrencyCode";
            this.colCurrencyCode.Visible = true;
            this.colCurrencyCode.VisibleIndex = 13;
            // 
            // colPurchaseUnitPrice
            // 
            this.colPurchaseUnitPrice.Caption = "ფასი / შ.";
            this.colPurchaseUnitPrice.FieldName = "PurchaseUnitPrice";
            this.colPurchaseUnitPrice.Name = "colPurchaseUnitPrice";
            this.colPurchaseUnitPrice.Visible = true;
            this.colPurchaseUnitPrice.VisibleIndex = 14;
            // 
            // colPurchaseCurrencyCode
            // 
            this.colPurchaseCurrencyCode.Caption = "ვალუტა / შ.";
            this.colPurchaseCurrencyCode.FieldName = "PurchaseCurrencyCode";
            this.colPurchaseCurrencyCode.Name = "colPurchaseCurrencyCode";
            this.colPurchaseCurrencyCode.Visible = true;
            this.colPurchaseCurrencyCode.VisibleIndex = 15;
            // 
            // col_PurchaseLineTotal
            // 
            this.col_PurchaseLineTotal.AppearanceCell.BackColor = System.Drawing.Color.Cornsilk;
            this.col_PurchaseLineTotal.AppearanceCell.Options.UseBackColor = true;
            this.col_PurchaseLineTotal.Caption = "თანხა / გ. / შეს. ფას.";
            this.col_PurchaseLineTotal.DisplayFormat.FormatString = "n4";
            this.col_PurchaseLineTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_PurchaseLineTotal.FieldName = "col_PurchaseLineTotal";
            this.col_PurchaseLineTotal.GroupFormat.FormatString = "n2";
            this.col_PurchaseLineTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_PurchaseLineTotal.Name = "col_PurchaseLineTotal";
            this.col_PurchaseLineTotal.SummaryItem.DisplayFormat = "{0:n2}";
            this.col_PurchaseLineTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.col_PurchaseLineTotal.UnboundExpression = "[SaleQty] * [PurchaseUnitPrice]";
            this.col_PurchaseLineTotal.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col_PurchaseLineTotal.Visible = true;
            this.col_PurchaseLineTotal.VisibleIndex = 16;
            // 
            // colOrdinalNumber
            // 
            this.colOrdinalNumber.Caption = "რიგით. №";
            this.colOrdinalNumber.DisplayFormat.FormatString = "f00";
            this.colOrdinalNumber.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOrdinalNumber.FieldName = "OrdinalNumber";
            this.colOrdinalNumber.GroupFormat.FormatString = "f00";
            this.colOrdinalNumber.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOrdinalNumber.Name = "colOrdinalNumber";
            this.colOrdinalNumber.Visible = true;
            this.colOrdinalNumber.VisibleIndex = 17;
            // 
            // colMedicamentName
            // 
            this.colMedicamentName.Caption = "მედიკამენტი";
            this.colMedicamentName.FieldName = "MedicamentName";
            this.colMedicamentName.Name = "colMedicamentName";
            this.colMedicamentName.Visible = true;
            this.colMedicamentName.VisibleIndex = 18;
            // 
            // colUnitsInStock
            // 
            this.colUnitsInStock.Caption = "დაყოფა";
            this.colUnitsInStock.FieldName = "UnitsInStock";
            this.colUnitsInStock.Name = "colUnitsInStock";
            this.colUnitsInStock.Visible = true;
            this.colUnitsInStock.VisibleIndex = 19;
            // 
            // colProductNumber
            // 
            this.colProductNumber.Caption = "პროდუქტის. №";
            this.colProductNumber.FieldName = "ProductNumber";
            this.colProductNumber.Name = "colProductNumber";
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
            this.colQuantity.VisibleIndex = 20;
            // 
            // colStandardCost
            // 
            this.colStandardCost.Caption = "ფასი / შ. პ. ე.";
            this.colStandardCost.DisplayFormat.FormatString = "n4";
            this.colStandardCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colStandardCost.FieldName = "StandardCost";
            this.colStandardCost.GroupFormat.FormatString = "n2";
            this.colStandardCost.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colStandardCost.Name = "colStandardCost";
            this.colStandardCost.Visible = true;
            this.colStandardCost.VisibleIndex = 21;
            // 
            // colListPrice
            // 
            this.colListPrice.Caption = "ფასი /გ. პ.ე.";
            this.colListPrice.DisplayFormat.FormatString = "n4";
            this.colListPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colListPrice.FieldName = "ListPrice";
            this.colListPrice.GroupFormat.FormatString = "n2";
            this.colListPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colListPrice.Name = "colListPrice";
            this.colListPrice.Visible = true;
            this.colListPrice.VisibleIndex = 22;
            // 
            // colDealerPrice
            // 
            this.colDealerPrice.Caption = "ფასი / დილ. პ.ე.";
            this.colDealerPrice.DisplayFormat.FormatString = "n4";
            this.colDealerPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDealerPrice.FieldName = "DealerPrice";
            this.colDealerPrice.GroupFormat.FormatString = "n2";
            this.colDealerPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDealerPrice.Name = "colDealerPrice";
            this.colDealerPrice.Visible = true;
            this.colDealerPrice.VisibleIndex = 23;
            // 
            // colProductCurrencyCode
            // 
            this.colProductCurrencyCode.Caption = "პ/ე ვალუტა";
            this.colProductCurrencyCode.FieldName = "ProductCurrencyCode";
            this.colProductCurrencyCode.Name = "colProductCurrencyCode";
            this.colProductCurrencyCode.Visible = true;
            this.colProductCurrencyCode.VisibleIndex = 25;
            // 
            // colDiscountPct
            // 
            this.colDiscountPct.Caption = "ფასდაკლ.";
            this.colDiscountPct.DisplayFormat.FormatString = "p";
            this.colDiscountPct.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscountPct.FieldName = "DiscountPct";
            this.colDiscountPct.GroupFormat.FormatString = "p";
            this.colDiscountPct.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscountPct.Name = "colDiscountPct";
            this.colDiscountPct.Visible = true;
            this.colDiscountPct.VisibleIndex = 24;
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
            this.colTaxRate.VisibleIndex = 26;
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
            this.colValidDate.VisibleIndex = 27;
            // 
            // colCountryName
            // 
            this.colCountryName.Caption = "მწ. ქვეყანა";
            this.colCountryName.FieldName = "CountryName";
            this.colCountryName.Name = "colCountryName";
            this.colCountryName.Visible = true;
            this.colCountryName.VisibleIndex = 28;
            // 
            // colBrandName
            // 
            this.colBrandName.Caption = "ბრენდი";
            this.colBrandName.FieldName = "BrandName";
            this.colBrandName.Name = "colBrandName";
            this.colBrandName.Visible = true;
            this.colBrandName.VisibleIndex = 29;
            // 
            // colSerie
            // 
            this.colSerie.Caption = "სერია";
            this.colSerie.FieldName = "Serie";
            this.colSerie.Name = "colSerie";
            this.colSerie.Visible = true;
            this.colSerie.VisibleIndex = 30;
            // 
            // colPurchaseOrderBranchID
            // 
            this.colPurchaseOrderBranchID.FieldName = "PurchaseOrderBranchID";
            this.colPurchaseOrderBranchID.Name = "colPurchaseOrderBranchID";
            // 
            // colVendorID
            // 
            this.colVendorID.FieldName = "VendorID";
            this.colVendorID.Name = "colVendorID";
            // 
            // colSalesOrderBranchID
            // 
            this.colSalesOrderBranchID.FieldName = "SalesOrderBranchID";
            this.colSalesOrderBranchID.Name = "colSalesOrderBranchID";
            // 
            // colCustomerID
            // 
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.Name = "colCustomerID";
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
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
            // ds
            // 
            this.ds.DataSetName = "DS_Sales";
            this.ds.Locale = new System.Globalization.CultureInfo("");
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsBranch
            // 
            this.bsBranch.Sort = "";
            // 
            // datePurchaseOrderDate2
            // 
            this.datePurchaseOrderDate2.EditValue = null;
            this.datePurchaseOrderDate2.Enabled = false;
            this.datePurchaseOrderDate2.EnterMoveNextControl = true;
            this.datePurchaseOrderDate2.Location = new System.Drawing.Point(328, 32);
            this.datePurchaseOrderDate2.Name = "datePurchaseOrderDate2";
            this.datePurchaseOrderDate2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.datePurchaseOrderDate2.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datePurchaseOrderDate2.Properties.Appearance.Options.UseFont = true;
            this.datePurchaseOrderDate2.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datePurchaseOrderDate2.Properties.AppearanceDropDown.Options.UseFont = true;
            this.datePurchaseOrderDate2.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datePurchaseOrderDate2.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.datePurchaseOrderDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePurchaseOrderDate2.Properties.DisplayFormat.FormatString = "G";
            this.datePurchaseOrderDate2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datePurchaseOrderDate2.Properties.EditFormat.FormatString = "G";
            this.datePurchaseOrderDate2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datePurchaseOrderDate2.Properties.Mask.EditMask = "G";
            this.datePurchaseOrderDate2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.datePurchaseOrderDate2.Size = new System.Drawing.Size(150, 23);
            this.datePurchaseOrderDate2.TabIndex = 6;
            // 
            // datePurchaseOrderDate1
            // 
            this.datePurchaseOrderDate1.EditValue = null;
            this.datePurchaseOrderDate1.Enabled = false;
            this.datePurchaseOrderDate1.EnterMoveNextControl = true;
            this.datePurchaseOrderDate1.Location = new System.Drawing.Point(172, 32);
            this.datePurchaseOrderDate1.Name = "datePurchaseOrderDate1";
            this.datePurchaseOrderDate1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.datePurchaseOrderDate1.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datePurchaseOrderDate1.Properties.Appearance.Options.UseFont = true;
            this.datePurchaseOrderDate1.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datePurchaseOrderDate1.Properties.AppearanceDropDown.Options.UseFont = true;
            this.datePurchaseOrderDate1.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datePurchaseOrderDate1.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.datePurchaseOrderDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePurchaseOrderDate1.Properties.DisplayFormat.FormatString = "G";
            this.datePurchaseOrderDate1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datePurchaseOrderDate1.Properties.EditFormat.FormatString = "G";
            this.datePurchaseOrderDate1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datePurchaseOrderDate1.Properties.Mask.EditMask = "G";
            this.datePurchaseOrderDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.datePurchaseOrderDate1.Size = new System.Drawing.Size(150, 23);
            this.datePurchaseOrderDate1.TabIndex = 5;
            // 
            // cboxPurchaseOrderDate
            // 
            this.cboxPurchaseOrderDate.EnterMoveNextControl = true;
            this.cboxPurchaseOrderDate.Location = new System.Drawing.Point(86, 32);
            this.cboxPurchaseOrderDate.Name = "cboxPurchaseOrderDate";
            this.cboxPurchaseOrderDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxPurchaseOrderDate.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxPurchaseOrderDate.Properties.Appearance.Options.UseFont = true;
            this.cboxPurchaseOrderDate.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxPurchaseOrderDate.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxPurchaseOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxPurchaseOrderDate.Properties.Items.AddRange(new object[] {
            "",
            "=",
            ">",
            "<",
            "[ ]"});
            this.cboxPurchaseOrderDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxPurchaseOrderDate.Size = new System.Drawing.Size(80, 23);
            this.cboxPurchaseOrderDate.TabIndex = 4;
            this.cboxPurchaseOrderDate.SelectedIndexChanged += new System.EventHandler(this.cboxPurchaseOrderDate_SelectedIndexChanged);
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderDate.Location = new System.Drawing.Point(8, 35);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(65, 17);
            this.lblOrderDate.TabIndex = 3;
            this.lblOrderDate.Text = "თარიღი:";
            // 
            // cboxPurchaseOrderID
            // 
            this.cboxPurchaseOrderID.EditValue = "=";
            this.cboxPurchaseOrderID.EnterMoveNextControl = true;
            this.cboxPurchaseOrderID.Location = new System.Drawing.Point(86, 3);
            this.cboxPurchaseOrderID.Name = "cboxPurchaseOrderID";
            this.cboxPurchaseOrderID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxPurchaseOrderID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxPurchaseOrderID.Properties.Appearance.Options.UseFont = true;
            this.cboxPurchaseOrderID.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxPurchaseOrderID.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxPurchaseOrderID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxPurchaseOrderID.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!=",
            "a,b,c",
            "!a,b,c"});
            this.cboxPurchaseOrderID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxPurchaseOrderID.Size = new System.Drawing.Size(80, 23);
            this.cboxPurchaseOrderID.TabIndex = 1;
            this.cboxPurchaseOrderID.SelectedIndexChanged += new System.EventHandler(this.cboxPurchaseOrderID_SelectedIndexChanged);
            // 
            // txtPurchaseOrderID
            // 
            this.txtPurchaseOrderID.EnterMoveNextControl = true;
            this.txtPurchaseOrderID.Location = new System.Drawing.Point(172, 3);
            this.txtPurchaseOrderID.Name = "txtPurchaseOrderID";
            this.txtPurchaseOrderID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPurchaseOrderID.Properties.Appearance.Options.UseFont = true;
            this.txtPurchaseOrderID.Properties.DisplayFormat.FormatString = "f0";
            this.txtPurchaseOrderID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPurchaseOrderID.Properties.EditFormat.FormatString = "f0";
            this.txtPurchaseOrderID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPurchaseOrderID.Properties.Mask.EditMask = "[0-9,]+";
            this.txtPurchaseOrderID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPurchaseOrderID.Properties.MaxLength = 10;
            this.txtPurchaseOrderID.Size = new System.Drawing.Size(306, 23);
            this.txtPurchaseOrderID.TabIndex = 2;
            // 
            // lblOrderID
            // 
            this.lblOrderID.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderID.Location = new System.Drawing.Point(8, 6);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(20, 17);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "№:";
            // 
            // lblCompany
            // 
            this.lblCompany.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompany.Location = new System.Drawing.Point(8, 64);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(72, 17);
            this.lblCompany.TabIndex = 7;
            this.lblCompany.Text = "კომპანია:";
            // 
            // bbVendor
            // 
            this.bbVendor.EnterMoveNextControl = true;
            this.bbVendor.IsOnline = true;
            this.bbVendor.Location = new System.Drawing.Point(86, 61);
            this.bbVendor.MenuManager = this.barManager;
            this.bbVendor.Name = "bbVendor";
            this.bbVendor.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F);
            this.bbVendor.Properties.Appearance.Options.UseFont = true;
            this.bbVendor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject3, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject4, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbVendor.Size = new System.Drawing.Size(392, 23);
            this.bbVendor.TabIndex = 8;
            this.bbVendor.TableName = Apothex.DataType.ObjectNames.Company;
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.AppearancePage.Header.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xtraTabControl.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl.Location = new System.Drawing.Point(2, 2);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.SelectedTabPage = this.tabPurchase;
            this.xtraTabControl.Size = new System.Drawing.Size(780, 126);
            this.xtraTabControl.TabIndex = 0;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPurchase,
            this.tabSales,
            this.tabProduct});
            // 
            // tabPurchase
            // 
            this.tabPurchase.Controls.Add(this.lblOrderID);
            this.tabPurchase.Controls.Add(this.cboxPurchaseOrderDate);
            this.tabPurchase.Controls.Add(this.datePurchaseOrderDate1);
            this.tabPurchase.Controls.Add(this.bbPurchaseOrderBranch);
            this.tabPurchase.Controls.Add(this.bbVendor);
            this.tabPurchase.Controls.Add(this.lblPurchaseOrderBranch);
            this.tabPurchase.Controls.Add(this.datePurchaseOrderDate2);
            this.tabPurchase.Controls.Add(this.lblCompany);
            this.tabPurchase.Controls.Add(this.lblOrderDate);
            this.tabPurchase.Controls.Add(this.cboxPurchaseOrderID);
            this.tabPurchase.Controls.Add(this.txtPurchaseOrderID);
            this.tabPurchase.Name = "tabPurchase";
            this.tabPurchase.Size = new System.Drawing.Size(774, 97);
            this.tabPurchase.Text = "შესყიდვა";
            // 
            // bbPurchaseOrderBranch
            // 
            this.bbPurchaseOrderBranch.EnterMoveNextControl = true;
            this.bbPurchaseOrderBranch.IsOnline = true;
            this.bbPurchaseOrderBranch.Location = new System.Drawing.Point(571, 3);
            this.bbPurchaseOrderBranch.Name = "bbPurchaseOrderBranch";
            this.bbPurchaseOrderBranch.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F);
            this.bbPurchaseOrderBranch.Properties.Appearance.Options.UseFont = true;
            this.bbPurchaseOrderBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject1, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject2, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbPurchaseOrderBranch.Size = new System.Drawing.Size(342, 23);
            this.bbPurchaseOrderBranch.TabIndex = 10;
            this.bbPurchaseOrderBranch.TableName = Apothex.DataType.ObjectNames.Branch;
            // 
            // lblPurchaseOrderBranch
            // 
            this.lblPurchaseOrderBranch.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPurchaseOrderBranch.Location = new System.Drawing.Point(484, 6);
            this.lblPurchaseOrderBranch.Name = "lblPurchaseOrderBranch";
            this.lblPurchaseOrderBranch.Size = new System.Drawing.Size(81, 17);
            this.lblPurchaseOrderBranch.TabIndex = 9;
            this.lblPurchaseOrderBranch.Text = "ფილიალი:";
            // 
            // tabSales
            // 
            this.tabSales.Controls.Add(this.bbSalesOrderBranch);
            this.tabSales.Controls.Add(this.lblSalesOrderBranch);
            this.tabSales.Controls.Add(this.lblSalesOrderID);
            this.tabSales.Controls.Add(this.cboxSalesOrderDate);
            this.tabSales.Controls.Add(this.dateSalesOrderDate1);
            this.tabSales.Controls.Add(this.bbCustomer);
            this.tabSales.Controls.Add(this.dateSalesOrderDate2);
            this.tabSales.Controls.Add(this.lblCustomer);
            this.tabSales.Controls.Add(this.lblSalesOrderDate);
            this.tabSales.Controls.Add(this.cboxSalesOrderID);
            this.tabSales.Controls.Add(this.txtSalesOrderID);
            this.tabSales.Name = "tabSales";
            this.tabSales.Size = new System.Drawing.Size(774, 97);
            this.tabSales.Text = "გაყიდვა";
            // 
            // bbSalesOrderBranch
            // 
            this.bbSalesOrderBranch.EnterMoveNextControl = true;
            this.bbSalesOrderBranch.IsOnline = true;
            this.bbSalesOrderBranch.Location = new System.Drawing.Point(571, 3);
            this.bbSalesOrderBranch.Name = "bbSalesOrderBranch";
            this.bbSalesOrderBranch.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F);
            this.bbSalesOrderBranch.Properties.Appearance.Options.UseFont = true;
            this.bbSalesOrderBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject5, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject6, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbSalesOrderBranch.Size = new System.Drawing.Size(342, 23);
            this.bbSalesOrderBranch.TabIndex = 10;
            this.bbSalesOrderBranch.TableName = Apothex.DataType.ObjectNames.Branch;
            // 
            // lblSalesOrderBranch
            // 
            this.lblSalesOrderBranch.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSalesOrderBranch.Location = new System.Drawing.Point(484, 6);
            this.lblSalesOrderBranch.Name = "lblSalesOrderBranch";
            this.lblSalesOrderBranch.Size = new System.Drawing.Size(81, 17);
            this.lblSalesOrderBranch.TabIndex = 9;
            this.lblSalesOrderBranch.Text = "ფილიალი:";
            // 
            // lblSalesOrderID
            // 
            this.lblSalesOrderID.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSalesOrderID.Location = new System.Drawing.Point(8, 6);
            this.lblSalesOrderID.Name = "lblSalesOrderID";
            this.lblSalesOrderID.Size = new System.Drawing.Size(20, 17);
            this.lblSalesOrderID.TabIndex = 0;
            this.lblSalesOrderID.Text = "№:";
            // 
            // cboxSalesOrderDate
            // 
            this.cboxSalesOrderDate.EnterMoveNextControl = true;
            this.cboxSalesOrderDate.Location = new System.Drawing.Point(86, 32);
            this.cboxSalesOrderDate.Name = "cboxSalesOrderDate";
            this.cboxSalesOrderDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxSalesOrderDate.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxSalesOrderDate.Properties.Appearance.Options.UseFont = true;
            this.cboxSalesOrderDate.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxSalesOrderDate.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxSalesOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxSalesOrderDate.Properties.Items.AddRange(new object[] {
            "",
            "=",
            ">",
            "<",
            "[ ]"});
            this.cboxSalesOrderDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxSalesOrderDate.Size = new System.Drawing.Size(80, 23);
            this.cboxSalesOrderDate.TabIndex = 4;
            this.cboxSalesOrderDate.SelectedIndexChanged += new System.EventHandler(this.cboxSalesOrderDate_SelectedIndexChanged);
            // 
            // dateSalesOrderDate1
            // 
            this.dateSalesOrderDate1.EditValue = null;
            this.dateSalesOrderDate1.Enabled = false;
            this.dateSalesOrderDate1.EnterMoveNextControl = true;
            this.dateSalesOrderDate1.Location = new System.Drawing.Point(172, 32);
            this.dateSalesOrderDate1.Name = "dateSalesOrderDate1";
            this.dateSalesOrderDate1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dateSalesOrderDate1.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateSalesOrderDate1.Properties.Appearance.Options.UseFont = true;
            this.dateSalesOrderDate1.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateSalesOrderDate1.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dateSalesOrderDate1.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateSalesOrderDate1.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.dateSalesOrderDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSalesOrderDate1.Properties.DisplayFormat.FormatString = "G";
            this.dateSalesOrderDate1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSalesOrderDate1.Properties.EditFormat.FormatString = "G";
            this.dateSalesOrderDate1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSalesOrderDate1.Properties.Mask.EditMask = "G";
            this.dateSalesOrderDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateSalesOrderDate1.Size = new System.Drawing.Size(150, 23);
            this.dateSalesOrderDate1.TabIndex = 5;
            // 
            // bbCustomer
            // 
            this.bbCustomer.EnterMoveNextControl = true;
            this.bbCustomer.IsOnline = true;
            this.bbCustomer.Location = new System.Drawing.Point(86, 61);
            this.bbCustomer.MenuManager = this.barManager;
            this.bbCustomer.Name = "bbCustomer";
            this.bbCustomer.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F);
            this.bbCustomer.Properties.Appearance.Options.UseFont = true;
            this.bbCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject7, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject8, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbCustomer.Size = new System.Drawing.Size(392, 23);
            this.bbCustomer.TabIndex = 8;
            this.bbCustomer.TableName = Apothex.DataType.ObjectNames.Company;
            // 
            // dateSalesOrderDate2
            // 
            this.dateSalesOrderDate2.EditValue = null;
            this.dateSalesOrderDate2.Enabled = false;
            this.dateSalesOrderDate2.EnterMoveNextControl = true;
            this.dateSalesOrderDate2.Location = new System.Drawing.Point(328, 32);
            this.dateSalesOrderDate2.Name = "dateSalesOrderDate2";
            this.dateSalesOrderDate2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dateSalesOrderDate2.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateSalesOrderDate2.Properties.Appearance.Options.UseFont = true;
            this.dateSalesOrderDate2.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateSalesOrderDate2.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dateSalesOrderDate2.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateSalesOrderDate2.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.dateSalesOrderDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSalesOrderDate2.Properties.DisplayFormat.FormatString = "G";
            this.dateSalesOrderDate2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSalesOrderDate2.Properties.EditFormat.FormatString = "G";
            this.dateSalesOrderDate2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSalesOrderDate2.Properties.Mask.EditMask = "G";
            this.dateSalesOrderDate2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateSalesOrderDate2.Size = new System.Drawing.Size(150, 23);
            this.dateSalesOrderDate2.TabIndex = 6;
            // 
            // lblCustomer
            // 
            this.lblCustomer.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCustomer.Location = new System.Drawing.Point(8, 64);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(72, 17);
            this.lblCustomer.TabIndex = 7;
            this.lblCustomer.Text = "კომპანია:";
            // 
            // lblSalesOrderDate
            // 
            this.lblSalesOrderDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSalesOrderDate.Location = new System.Drawing.Point(8, 35);
            this.lblSalesOrderDate.Name = "lblSalesOrderDate";
            this.lblSalesOrderDate.Size = new System.Drawing.Size(65, 17);
            this.lblSalesOrderDate.TabIndex = 3;
            this.lblSalesOrderDate.Text = "თარიღი:";
            // 
            // cboxSalesOrderID
            // 
            this.cboxSalesOrderID.EditValue = "=";
            this.cboxSalesOrderID.EnterMoveNextControl = true;
            this.cboxSalesOrderID.Location = new System.Drawing.Point(86, 3);
            this.cboxSalesOrderID.Name = "cboxSalesOrderID";
            this.cboxSalesOrderID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxSalesOrderID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxSalesOrderID.Properties.Appearance.Options.UseFont = true;
            this.cboxSalesOrderID.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxSalesOrderID.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxSalesOrderID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxSalesOrderID.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!=",
            "a,b,c",
            "!a,b,c"});
            this.cboxSalesOrderID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxSalesOrderID.Size = new System.Drawing.Size(80, 23);
            this.cboxSalesOrderID.TabIndex = 1;
            this.cboxSalesOrderID.SelectedIndexChanged += new System.EventHandler(this.cboxSalesOrderID_SelectedIndexChanged);
            // 
            // txtSalesOrderID
            // 
            this.txtSalesOrderID.EnterMoveNextControl = true;
            this.txtSalesOrderID.Location = new System.Drawing.Point(172, 3);
            this.txtSalesOrderID.Name = "txtSalesOrderID";
            this.txtSalesOrderID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSalesOrderID.Properties.Appearance.Options.UseFont = true;
            this.txtSalesOrderID.Properties.DisplayFormat.FormatString = "f0";
            this.txtSalesOrderID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSalesOrderID.Properties.EditFormat.FormatString = "f0";
            this.txtSalesOrderID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSalesOrderID.Properties.Mask.EditMask = "[0-9,]+";
            this.txtSalesOrderID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSalesOrderID.Properties.MaxLength = 10;
            this.txtSalesOrderID.Size = new System.Drawing.Size(306, 23);
            this.txtSalesOrderID.TabIndex = 2;
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.lblProductCurrencyCode);
            this.tabProduct.Controls.Add(this.lookProductCurrencyCode);
            this.tabProduct.Controls.Add(this.cboxProduct);
            this.tabProduct.Controls.Add(this.lblProduct);
            this.tabProduct.Controls.Add(this.txtProduct);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Size = new System.Drawing.Size(774, 97);
            this.tabProduct.Text = "პროდუქცია";
            // 
            // lblProductCurrencyCode
            // 
            this.lblProductCurrencyCode.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductCurrencyCode.Location = new System.Drawing.Point(14, 35);
            this.lblProductCurrencyCode.Name = "lblProductCurrencyCode";
            this.lblProductCurrencyCode.Size = new System.Drawing.Size(89, 17);
            this.lblProductCurrencyCode.TabIndex = 13;
            this.lblProductCurrencyCode.Text = "პ/ე ვალუტა:";
            // 
            // lookProductCurrencyCode
            // 
            this.lookProductCurrencyCode.EnterMoveNextControl = true;
            this.lookProductCurrencyCode.Location = new System.Drawing.Point(109, 32);
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
            this.lookProductCurrencyCode.Size = new System.Drawing.Size(312, 23);
            this.lookProductCurrencyCode.TabIndex = 14;
            // 
            // cboxProduct
            // 
            this.cboxProduct.EditValue = "%a%";
            this.cboxProduct.EnterMoveNextControl = true;
            this.cboxProduct.Location = new System.Drawing.Point(109, 3);
            this.cboxProduct.Name = "cboxProduct";
            this.cboxProduct.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxProduct.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxProduct.Properties.Appearance.Options.UseFont = true;
            this.cboxProduct.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxProduct.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxProduct.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!=",
            "%a%",
            "!%a%",
            "a%",
            "!a%",
            "%a",
            "!%a"});
            this.cboxProduct.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxProduct.Size = new System.Drawing.Size(80, 23);
            this.cboxProduct.TabIndex = 4;
            this.cboxProduct.SelectedIndexChanged += new System.EventHandler(this.cboxProduct_SelectedIndexChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProduct.Location = new System.Drawing.Point(14, 6);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(73, 17);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.Text = "პროდუქი:";
            // 
            // txtProduct
            // 
            this.txtProduct.EnterMoveNextControl = true;
            this.txtProduct.Location = new System.Drawing.Point(195, 3);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProduct.Properties.Appearance.Options.UseFont = true;
            this.txtProduct.Size = new System.Drawing.Size(226, 23);
            this.txtProduct.TabIndex = 5;
            // 
            // colPurchaseOrderOverheadNumber
            // 
            this.colPurchaseOrderOverheadNumber.Caption = "შესყ. ზედნად. ნომერი";
            this.colPurchaseOrderOverheadNumber.FieldName = "PurchaseOrderOverheadNumber";
            this.colPurchaseOrderOverheadNumber.Name = "colPurchaseOrderOverheadNumber";
            this.colPurchaseOrderOverheadNumber.Visible = true;
            this.colPurchaseOrderOverheadNumber.VisibleIndex = 3;
            // 
            // frmSalesOrderDetailInfoVendorBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "frmSalesOrderDetailInfoVendorBrowse";
            this.ObjectName = Apothex.DataType.ObjectNames.SalesOrderDetailInfoVendor;
            this.OptionsBaseForm.Text = "გაყიდვის დეტალური ინფო შესყიდვების მიხედვით";
            this.OptionsListForm.IsAddable = false;
            this.OptionsListForm.IsApprovable = false;
            this.OptionsListForm.IsBlockable = false;
            this.OptionsListForm.IsDisapprovable = false;
            this.OptionsListForm.IsSystemColumnsable = true;
            this.OptionsListForm.IsUnblockable = false;
            this.OptionsGrid.ColumnID = "SalesOrderID";
            this.OptionsGrid.ColumnStatusID = "Status";
            this.OptionsGrid.GridView = this.gridView;
            this.Text = "გაყიდვის დეტალური ინფო შესყიდვების მიხედვით";
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
            ((System.ComponentModel.ISupportInitialize)(this.datePurchaseOrderDate2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePurchaseOrderDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePurchaseOrderDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePurchaseOrderDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxPurchaseOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxPurchaseOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchaseOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbVendor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.tabPurchase.ResumeLayout(false);
            this.tabPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbPurchaseOrderBranch.Properties)).EndInit();
            this.tabSales.ResumeLayout(false);
            this.tabSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbSalesOrderBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxSalesOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDate2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxSalesOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalesOrderID.Properties)).EndInit();
            this.tabProduct.ResumeLayout(false);
            this.tabProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookProductCurrencyCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduct.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private Apothex.DataType.DS_SalesOrderDetailInfoVendor ds;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colVendorName;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleQty;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPriceDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colLineTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colOrdinalNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitsInStock;
        private DevExpress.XtraGrid.Columns.GridColumn colProductNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colStandardCost;
        private DevExpress.XtraGrid.Columns.GridColumn colListPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDealerPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountPct;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxRate;
        private DevExpress.XtraGrid.Columns.GridColumn colValidDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryName;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandName;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colVendorID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private System.Windows.Forms.BindingSource bsBranch;
        private DevExpress.XtraEditors.DateEdit datePurchaseOrderDate2;
        private DevExpress.XtraEditors.DateEdit datePurchaseOrderDate1;
        private DevExpress.XtraEditors.ComboBoxEdit cboxPurchaseOrderDate;
        private DevExpress.XtraEditors.LabelControl lblOrderDate;
        private DevExpress.XtraEditors.ComboBoxEdit cboxPurchaseOrderID;
        private DevExpress.XtraEditors.TextEdit txtPurchaseOrderID;
        private DevExpress.XtraEditors.LabelControl lblOrderID;
        private Apothex.Windows.Forms.ButtonBrowse bbVendor;
        private DevExpress.XtraEditors.LabelControl lblCompany;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage tabPurchase;
        private DevExpress.XtraTab.XtraTabPage tabSales;
        private DevExpress.XtraEditors.LabelControl lblSalesOrderID;
        private DevExpress.XtraEditors.ComboBoxEdit cboxSalesOrderDate;
        private DevExpress.XtraEditors.DateEdit dateSalesOrderDate1;
        private Apothex.Windows.Forms.ButtonBrowse bbCustomer;
        private DevExpress.XtraEditors.DateEdit dateSalesOrderDate2;
        private DevExpress.XtraEditors.LabelControl lblCustomer;
        private DevExpress.XtraEditors.LabelControl lblSalesOrderDate;
        private DevExpress.XtraEditors.ComboBoxEdit cboxSalesOrderID;
        private DevExpress.XtraEditors.TextEdit txtSalesOrderID;
        private Apothex.Windows.Forms.ButtonBrowse bbPurchaseOrderBranch;
        private DevExpress.XtraEditors.LabelControl lblPurchaseOrderBranch;
        private Apothex.Windows.Forms.ButtonBrowse bbSalesOrderBranch;
        private DevExpress.XtraEditors.LabelControl lblSalesOrderBranch;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseOrderBranchName;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesOrderBranchName;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseOrderBranchID;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesOrderBranchID;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn col_PurchaseLineTotal;
        private DevExpress.XtraTab.XtraTabPage tabProduct;
        private DevExpress.XtraEditors.ComboBoxEdit cboxProduct;
        private DevExpress.XtraEditors.LabelControl lblProduct;
        private DevExpress.XtraEditors.TextEdit txtProduct;
        private DevExpress.XtraEditors.LabelControl lblProductCurrencyCode;
        private DevExpress.XtraEditors.LookUpEdit lookProductCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colModifierID;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseOrderOverheadNumber;
    }
}