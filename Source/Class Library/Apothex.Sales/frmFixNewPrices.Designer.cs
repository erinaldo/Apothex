namespace Apothex.Sales
{
    partial class frmFixNewPrices
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabSales = new DevExpress.XtraTab.XtraTabPage();
            this.gridSales = new DevExpress.XtraGrid.GridControl();
            this.bsSale = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Sales = new Apothex.DataType.DS_Sales();
            this.viewSales = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSales_SalesOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSales_MedicamentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSales_UnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSales_UnitPriceDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSales_SaleQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colSales_LineTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridExcel = new DevExpress.XtraGrid.GridControl();
            this.viewExcel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabNewPrice = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnOpenExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnChooseSalesOrder = new DevExpress.XtraEditors.SimpleButton();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tabSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSales)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.AppearancePage.Header.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xtraTabControl1.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 84);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabSales;
            this.xtraTabControl1.Size = new System.Drawing.Size(784, 478);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabSales,
            this.xtraTabPage2,
            this.tabNewPrice});
            // 
            // tabSales
            // 
            this.tabSales.Controls.Add(this.gridSales);
            this.tabSales.Name = "tabSales";
            this.tabSales.Size = new System.Drawing.Size(778, 449);
            this.tabSales.Text = "ფაქტურიდან გაწერილი";
            // 
            // gridSales
            // 
            this.gridSales.DataSource = this.bsSale;
            this.gridSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSales.Location = new System.Drawing.Point(0, 0);
            this.gridSales.MainView = this.viewSales;
            this.gridSales.MenuManager = this.barManager;
            this.gridSales.Name = "gridSales";
            this.gridSales.Size = new System.Drawing.Size(778, 449);
            this.gridSales.TabIndex = 0;
            this.gridSales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewSales});
            // 
            // bsSale
            // 
            this.bsSale.DataMember = "SP_GetSalesOrderDetail";
            this.bsSale.DataSource = this.ds_Sales;
            // 
            // ds_Sales
            // 
            this.ds_Sales.DataSetName = "DS_Sales";
            this.ds_Sales.Locale = new System.Globalization.CultureInfo("");
            this.ds_Sales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewSales
            // 
            this.viewSales.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSales_SalesOrderID,
            this.colSales_MedicamentName,
            this.colSales_UnitPrice,
            this.colSales_UnitPriceDiscount,
            this.colSales_SaleQty,
            this._colSales_LineTotal});
            this.viewSales.GridControl = this.gridSales;
            this.viewSales.Name = "viewSales";
            this.viewSales.OptionsBehavior.Editable = false;
            this.viewSales.OptionsView.ShowAutoFilterRow = true;
            this.viewSales.OptionsView.ShowFooter = true;
            this.viewSales.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSales_SalesOrderID, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSales_MedicamentName, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colSales_SalesOrderID
            // 
            this.colSales_SalesOrderID.Caption = "ფაქტურის №";
            this.colSales_SalesOrderID.FieldName = "SalesOrderID";
            this.colSales_SalesOrderID.Name = "colSales_SalesOrderID";
            this.colSales_SalesOrderID.Visible = true;
            this.colSales_SalesOrderID.VisibleIndex = 0;
            // 
            // colSales_MedicamentName
            // 
            this.colSales_MedicamentName.Caption = "პროდუქცია";
            this.colSales_MedicamentName.FieldName = "MedicamentName";
            this.colSales_MedicamentName.Name = "colSales_MedicamentName";
            this.colSales_MedicamentName.Visible = true;
            this.colSales_MedicamentName.VisibleIndex = 1;
            // 
            // colSales_UnitPrice
            // 
            this.colSales_UnitPrice.Caption = "ფასი";
            this.colSales_UnitPrice.DisplayFormat.FormatString = "n2";
            this.colSales_UnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSales_UnitPrice.FieldName = "UnitPrice";
            this.colSales_UnitPrice.GroupFormat.FormatString = "n4";
            this.colSales_UnitPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSales_UnitPrice.Name = "colSales_UnitPrice";
            this.colSales_UnitPrice.Visible = true;
            this.colSales_UnitPrice.VisibleIndex = 2;
            // 
            // colSales_UnitPriceDiscount
            // 
            this.colSales_UnitPriceDiscount.Caption = "ფასდაკლება";
            this.colSales_UnitPriceDiscount.DisplayFormat.FormatString = "p2";
            this.colSales_UnitPriceDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSales_UnitPriceDiscount.FieldName = "UnitPriceDiscount";
            this.colSales_UnitPriceDiscount.GroupFormat.FormatString = "p2";
            this.colSales_UnitPriceDiscount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSales_UnitPriceDiscount.Name = "colSales_UnitPriceDiscount";
            this.colSales_UnitPriceDiscount.Visible = true;
            this.colSales_UnitPriceDiscount.VisibleIndex = 3;
            // 
            // colSales_SaleQty
            // 
            this.colSales_SaleQty.Caption = "რაოდენობა";
            this.colSales_SaleQty.DisplayFormat.FormatString = "n2";
            this.colSales_SaleQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSales_SaleQty.FieldName = "SaleQty";
            this.colSales_SaleQty.GroupFormat.FormatString = "n4";
            this.colSales_SaleQty.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSales_SaleQty.Name = "colSales_SaleQty";
            this.colSales_SaleQty.Visible = true;
            this.colSales_SaleQty.VisibleIndex = 4;
            // 
            // _colSales_LineTotal
            // 
            this._colSales_LineTotal.Caption = "თანხა";
            this._colSales_LineTotal.DisplayFormat.FormatString = "n2";
            this._colSales_LineTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._colSales_LineTotal.FieldName = "_colSales_LineTotal";
            this._colSales_LineTotal.GroupFormat.FormatString = "n4";
            this._colSales_LineTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._colSales_LineTotal.Name = "_colSales_LineTotal";
            this._colSales_LineTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "_colSales_LineTotal", "SUM={0:n2}")});
            this._colSales_LineTotal.UnboundExpression = "[UnitPrice]*(1m-[UnitPriceDiscount])*[SaleQty]";
            this._colSales_LineTotal.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this._colSales_LineTotal.Visible = true;
            this._colSales_LineTotal.VisibleIndex = 5;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridExcel);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(778, 449);
            this.xtraTabPage2.Text = "დაიმპორტირებული";
            // 
            // gridExcel
            // 
            this.gridExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridExcel.Location = new System.Drawing.Point(0, 0);
            this.gridExcel.MainView = this.viewExcel;
            this.gridExcel.MenuManager = this.barManager;
            this.gridExcel.Name = "gridExcel";
            this.gridExcel.Size = new System.Drawing.Size(778, 449);
            this.gridExcel.TabIndex = 0;
            this.gridExcel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewExcel});
            // 
            // viewExcel
            // 
            this.viewExcel.GridControl = this.gridExcel;
            this.viewExcel.Name = "viewExcel";
            this.viewExcel.OptionsBehavior.Editable = false;
            this.viewExcel.OptionsView.ShowAutoFilterRow = true;
            this.viewExcel.OptionsView.ShowFooter = true;
            // 
            // tabNewPrice
            // 
            this.tabNewPrice.Name = "tabNewPrice";
            this.tabNewPrice.Size = new System.Drawing.Size(778, 449);
            this.tabNewPrice.Text = "გადაფასებული";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnOpenExcel);
            this.panelControl1.Controls.Add(this.btnChooseSalesOrder);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 39);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(784, 45);
            this.panelControl1.TabIndex = 0;
            // 
            // btnOpenExcel
            // 
            this.btnOpenExcel.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenExcel.Appearance.Options.UseFont = true;
            this.btnOpenExcel.Location = new System.Drawing.Point(168, 6);
            this.btnOpenExcel.Name = "btnOpenExcel";
            this.btnOpenExcel.Size = new System.Drawing.Size(150, 33);
            this.btnOpenExcel.TabIndex = 1;
            this.btnOpenExcel.Text = "ექსელის ფაილის არჩევა";
            this.btnOpenExcel.Click += new System.EventHandler(this.btnOpenExcel_Click);
            // 
            // btnChooseSalesOrder
            // 
            this.btnChooseSalesOrder.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChooseSalesOrder.Appearance.Options.UseFont = true;
            this.btnChooseSalesOrder.Location = new System.Drawing.Point(12, 6);
            this.btnChooseSalesOrder.Name = "btnChooseSalesOrder";
            this.btnChooseSalesOrder.Size = new System.Drawing.Size(150, 33);
            this.btnChooseSalesOrder.TabIndex = 0;
            this.btnChooseSalesOrder.Text = "ფაქტურის არჩევა";
            this.btnChooseSalesOrder.Click += new System.EventHandler(this.btnChooseSalesOrder_Click);
            // 
            // frmFixNewPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmFixNewPrices";
            this.ObjectName = Apothex.DataType.ObjectNames.SalesOrderFixNewPrice;
            this.OptionsBaseForm.Text = "გადაფასება";
            this.Text = "გადაფასება";
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.xtraTabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tabSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSales)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tabSales;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage tabNewPrice;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnChooseSalesOrder;
        private DevExpress.XtraEditors.SimpleButton btnOpenExcel;
        private DevExpress.XtraGrid.GridControl gridSales;
        private System.Windows.Forms.BindingSource bsSale;
        private DataType.DS_Sales ds_Sales;
        private DevExpress.XtraGrid.Views.Grid.GridView viewSales;
        private DevExpress.XtraGrid.Columns.GridColumn colSales_SalesOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn colSales_MedicamentName;
        private DevExpress.XtraGrid.Columns.GridColumn colSales_UnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSales_UnitPriceDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colSales_SaleQty;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource bindingSource3;
        private DevExpress.XtraGrid.GridControl gridExcel;
        private DevExpress.XtraGrid.Views.Grid.GridView viewExcel;
        private DevExpress.XtraGrid.Columns.GridColumn _colSales_LineTotal;
    }
}