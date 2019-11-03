namespace Apothex.Sales
{
    partial class frmSalesOrderHeaderPurchaseTotal
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSalesOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseTaxAmt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseTotalDue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesTaxAmt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesFreight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesTotalDue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentMethodName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ds = new Apothex.DataType.DS_SalesOrderHeaderPurchaseTotal();
            this.cboxOrderID = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtOrderID = new DevExpress.XtraEditors.TextEdit();
            this.lblOrderID = new DevExpress.XtraEditors.LabelControl();
            this.lblBranch = new DevExpress.XtraEditors.LabelControl();
            this.bsBranch = new System.Windows.Forms.BindingSource();
            this.lookBranch = new DevExpress.XtraEditors.LookUpEdit();
            this.lblOrderDate = new DevExpress.XtraEditors.LabelControl();
            this.cboxOrderDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateOrderDate1 = new DevExpress.XtraEditors.DateEdit();
            this.dateOrderDate2 = new DevExpress.XtraEditors.DateEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.cboxOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.lblOrderDate);
            this.pnlFilter.Controls.Add(this.cboxOrderDate);
            this.pnlFilter.Controls.Add(this.dateOrderDate1);
            this.pnlFilter.Controls.Add(this.dateOrderDate2);
            this.pnlFilter.Controls.Add(this.lookBranch);
            this.pnlFilter.Controls.Add(this.lblBranch);
            this.pnlFilter.Controls.Add(this.cboxOrderID);
            this.pnlFilter.Controls.Add(this.txtOrderID);
            this.pnlFilter.Controls.Add(this.lblOrderID);
            this.pnlFilter.Controls.SetChildIndex(this.btnFilter, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblOrderID, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtOrderID, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxOrderID, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblBranch, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lookBranch, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateOrderDate2, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateOrderDate1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxOrderDate, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblOrderDate, 0);
            // 
            // bsGridControl
            // 
            this.bsGridControl.DataMember = "FN_GetSalesOrderHeaderPurchaseTotal";
            this.bsGridControl.DataSource = this.ds;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridControl);
            // 
            // btnFilter
            // 
            this.btnFilter.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.Appearance.Options.UseFont = true;
            this.btnFilter.Location = new System.Drawing.Point(497, 54);
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
            this.gridControl.Size = new System.Drawing.Size(784, 423);
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
            this.colPurchaseSubTotal,
            this.colPurchaseTaxAmt,
            this.colPurchaseTotalDue,
            this.colSalesSubTotal,
            this.colSalesTaxAmt,
            this.colSalesFreight,
            this.colSalesTotalDue,
            this.colWon,
            this.colCurrencyCode,
            this.colPaymentMethodName,
            this.colBranchID,
            this.colStatus});
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PurchaseLineTotal", this.colPurchaseSubTotal, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SaleLineTotal", this.colSalesSubTotal, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Won", this.colWon, "{0:n2}")});
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView_CustomUnboundColumnData);
            // 
            // colSalesOrderID
            // 
            this.colSalesOrderID.Caption = "№";
            this.colSalesOrderID.FieldName = "SalesOrderID";
            this.colSalesOrderID.Name = "colSalesOrderID";
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
            this.colOrderDate.GroupFormat.FormatString = "d";
            this.colOrderDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 2;
            // 
            // colPurchaseSubTotal
            // 
            this.colPurchaseSubTotal.Caption = "ჯამი / შ.";
            this.colPurchaseSubTotal.DisplayFormat.FormatString = "n2";
            this.colPurchaseSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPurchaseSubTotal.FieldName = "PurchaseSubTotal";
            this.colPurchaseSubTotal.GroupFormat.FormatString = "n2";
            this.colPurchaseSubTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPurchaseSubTotal.Name = "colPurchaseSubTotal";
            this.colPurchaseSubTotal.Visible = true;
            this.colPurchaseSubTotal.VisibleIndex = 3;
            // 
            // colPurchaseTaxAmt
            // 
            this.colPurchaseTaxAmt.Caption = "დ.ღ.გ. / შ.";
            this.colPurchaseTaxAmt.DisplayFormat.FormatString = "n2";
            this.colPurchaseTaxAmt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPurchaseTaxAmt.FieldName = "PurchaseTaxAmt";
            this.colPurchaseTaxAmt.GroupFormat.FormatString = "n2";
            this.colPurchaseTaxAmt.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPurchaseTaxAmt.Name = "colPurchaseTaxAmt";
            this.colPurchaseTaxAmt.Visible = true;
            this.colPurchaseTaxAmt.VisibleIndex = 4;
            // 
            // colPurchaseTotalDue
            // 
            this.colPurchaseTotalDue.Caption = "სულ / შ.";
            this.colPurchaseTotalDue.DisplayFormat.FormatString = "n2";
            this.colPurchaseTotalDue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPurchaseTotalDue.FieldName = "colPurchaseTotalDue";
            this.colPurchaseTotalDue.GroupFormat.FormatString = "n2";
            this.colPurchaseTotalDue.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPurchaseTotalDue.Name = "colPurchaseTotalDue";
            this.colPurchaseTotalDue.SummaryItem.DisplayFormat = "{0:n2}";
            this.colPurchaseTotalDue.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colPurchaseTotalDue.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colPurchaseTotalDue.Visible = true;
            this.colPurchaseTotalDue.VisibleIndex = 5;
            // 
            // colSalesSubTotal
            // 
            this.colSalesSubTotal.Caption = "ჯამი / გ.";
            this.colSalesSubTotal.DisplayFormat.FormatString = "n2";
            this.colSalesSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalesSubTotal.FieldName = "SalesSubTotal";
            this.colSalesSubTotal.GroupFormat.FormatString = "n2";
            this.colSalesSubTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalesSubTotal.Name = "colSalesSubTotal";
            this.colSalesSubTotal.Visible = true;
            this.colSalesSubTotal.VisibleIndex = 6;
            // 
            // colSalesTaxAmt
            // 
            this.colSalesTaxAmt.Caption = "დ.ღ.გ. / გ.";
            this.colSalesTaxAmt.DisplayFormat.FormatString = "n2";
            this.colSalesTaxAmt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalesTaxAmt.FieldName = "SalesTaxAmt";
            this.colSalesTaxAmt.GroupFormat.FormatString = "n2";
            this.colSalesTaxAmt.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalesTaxAmt.Name = "colSalesTaxAmt";
            this.colSalesTaxAmt.Visible = true;
            this.colSalesTaxAmt.VisibleIndex = 7;
            // 
            // colSalesFreight
            // 
            this.colSalesFreight.Caption = "ტრანსპორტ. / გ.";
            this.colSalesFreight.DisplayFormat.FormatString = "n2";
            this.colSalesFreight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalesFreight.FieldName = "SalesFreight";
            this.colSalesFreight.GroupFormat.FormatString = "n2";
            this.colSalesFreight.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalesFreight.Name = "colSalesFreight";
            this.colSalesFreight.Visible = true;
            this.colSalesFreight.VisibleIndex = 8;
            // 
            // colSalesTotalDue
            // 
            this.colSalesTotalDue.Caption = "სულ / გ.";
            this.colSalesTotalDue.DisplayFormat.FormatString = "n2";
            this.colSalesTotalDue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalesTotalDue.FieldName = "SalesTotalDue";
            this.colSalesTotalDue.GroupFormat.FormatString = "n2";
            this.colSalesTotalDue.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalesTotalDue.Name = "colSalesTotalDue";
            this.colSalesTotalDue.SummaryItem.DisplayFormat = "{0:n2}";
            this.colSalesTotalDue.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSalesTotalDue.Visible = true;
            this.colSalesTotalDue.VisibleIndex = 9;
            // 
            // colWon
            // 
            this.colWon.Caption = "მოგება";
            this.colWon.DisplayFormat.FormatString = "n2";
            this.colWon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colWon.FieldName = "Won";
            this.colWon.GroupFormat.FormatString = "n2";
            this.colWon.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colWon.Name = "colWon";
            this.colWon.SummaryItem.DisplayFormat = "{0:n2}";
            this.colWon.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colWon.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colWon.Visible = true;
            this.colWon.VisibleIndex = 10;
            // 
            // colCurrencyCode
            // 
            this.colCurrencyCode.Caption = "ვალუტა";
            this.colCurrencyCode.FieldName = "CurrencyCode";
            this.colCurrencyCode.Name = "colCurrencyCode";
            this.colCurrencyCode.Visible = true;
            this.colCurrencyCode.VisibleIndex = 11;
            // 
            // colPaymentMethodName
            // 
            this.colPaymentMethodName.Caption = "გადახდის მეთოდი";
            this.colPaymentMethodName.FieldName = "PaymentMethodName";
            this.colPaymentMethodName.Name = "colPaymentMethodName";
            this.colPaymentMethodName.Visible = true;
            this.colPaymentMethodName.VisibleIndex = 12;
            // 
            // colBranchID
            // 
            this.colBranchID.FieldName = "BranchID";
            this.colBranchID.Name = "colBranchID";
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // ds
            // 
            this.ds.DataSetName = "DS_Sales";
            this.ds.Locale = new System.Globalization.CultureInfo("");
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboxOrderID
            // 
            this.cboxOrderID.EditValue = "=";
            this.cboxOrderID.EnterMoveNextControl = true;
            this.cboxOrderID.Location = new System.Drawing.Point(99, 6);
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
            this.txtOrderID.Location = new System.Drawing.Point(185, 6);
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
            this.lblOrderID.Location = new System.Drawing.Point(12, 9);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(20, 17);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "№:";
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
            // bsBranch
            // 
            this.bsBranch.Sort = "";
            // 
            // lookBranch
            // 
            this.lookBranch.EnterMoveNextControl = true;
            this.lookBranch.Location = new System.Drawing.Point(99, 35);
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
            // lblOrderDate
            // 
            this.lblOrderDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderDate.Location = new System.Drawing.Point(12, 67);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(65, 17);
            this.lblOrderDate.TabIndex = 5;
            this.lblOrderDate.Text = "თარიღი:";
            // 
            // cboxOrderDate
            // 
            this.cboxOrderDate.EnterMoveNextControl = true;
            this.cboxOrderDate.Location = new System.Drawing.Point(99, 64);
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
            // dateOrderDate1
            // 
            this.dateOrderDate1.EditValue = null;
            this.dateOrderDate1.Enabled = false;
            this.dateOrderDate1.EnterMoveNextControl = true;
            this.dateOrderDate1.Location = new System.Drawing.Point(185, 64);
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
            // 
            // dateOrderDate2
            // 
            this.dateOrderDate2.EditValue = null;
            this.dateOrderDate2.Enabled = false;
            this.dateOrderDate2.EnterMoveNextControl = true;
            this.dateOrderDate2.Location = new System.Drawing.Point(341, 64);
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
            // 
            // frmSalesOrderHeaderPurchaseTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsFiltered = true;
            this.IsFilterPanelVisible = true;
            this.Name = "frmSalesOrderHeaderPurchaseTotal";
            this.ObjectName = Apothex.DataType.ObjectNames.SalesOrderHeaderPurchaseTotal;
            this.OptionsBaseForm.IsPrintable = true;
            this.OptionsBaseForm.Text = "გაყიდვების ჟურნალი";
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
            this.Text = "გაყიდვების ჟურნალი";
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private Apothex.DataType.DS_SalesOrderHeaderPurchaseTotal ds;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchName;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseSubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesSubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchID;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraEditors.ComboBoxEdit cboxOrderID;
        private DevExpress.XtraEditors.TextEdit txtOrderID;
        private DevExpress.XtraEditors.LabelControl lblOrderID;
        private DevExpress.XtraEditors.LabelControl lblBranch;
        private System.Windows.Forms.BindingSource bsBranch;
        private DevExpress.XtraEditors.LookUpEdit lookBranch;
        private DevExpress.XtraEditors.LabelControl lblOrderDate;
        private DevExpress.XtraEditors.ComboBoxEdit cboxOrderDate;
        private DevExpress.XtraEditors.DateEdit dateOrderDate1;
        private DevExpress.XtraEditors.DateEdit dateOrderDate2;
        private DevExpress.XtraGrid.Columns.GridColumn colWon;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentMethodName;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseTaxAmt;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesTaxAmt;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesFreight;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesTotalDue;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseTotalDue;
    }
}