namespace Apothex.Sales
{
    partial class frmSalesOrderHeaderGroupByDateBrowse
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
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesTaxAmt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesFreight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesTotalDue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRealization = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccumulatedAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpensedAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseTaxAmt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_PurchaseTotalDue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Diff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentMethodName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ds = new Apothex.DataType.DS_SalesOrderHeaderGroupByDate();
            this.lblOrderDate = new DevExpress.XtraEditors.LabelControl();
            this.cboxOrderDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.bbBranch = new Apothex.Windows.Forms.ButtonBrowse();
            this.lblBranch = new DevExpress.XtraEditors.LabelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.cboxOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.bbBranch);
            this.pnlFilter.Controls.Add(this.lblBranch);
            this.pnlFilter.Controls.Add(this.lblOrderDate);
            this.pnlFilter.Controls.Add(this.cboxOrderDate);
            this.pnlFilter.Controls.Add(this.dateOrderDate1);
            this.pnlFilter.Controls.Add(this.dateOrderDate2);
            this.pnlFilter.Controls.SetChildIndex(this.dateOrderDate2, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateOrderDate1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxOrderDate, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblOrderDate, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblBranch, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnFilter, 0);
            this.pnlFilter.Controls.SetChildIndex(this.bbBranch, 0);
            // 
            // bsGridControl
            // 
            this.bsGridControl.DataMember = "T_SalesOrderHeaderGroupByDate";
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
            this.btnFilter.Location = new System.Drawing.Point(390, 25);
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
            this.colOrderDate,
            this.colBranchName,
            this.colSalesSubTotal,
            this.colSalesTaxAmt,
            this.colSalesFreight,
            this.colSalesTotalDue,
            this.colRealization,
            this.colAccumulatedAmount,
            this.colExpensedAmount,
            this.colPurchaseSubTotal,
            this.colPurchaseTaxAmt,
            this.col_PurchaseTotalDue,
            this.colCurrencyCode,
            this.col_Diff,
            this.colPaymentMethodName,
            this.colBranchID,
            this.colStatus});
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SalesTotalDue", this.colSalesTotalDue, "{0:n2}")});
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowFooter = true;
            // 
            // colOrderDate
            // 
            this.colOrderDate.Caption = "თარიღი";
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 0;
            // 
            // colBranchName
            // 
            this.colBranchName.Caption = "ფილიალი";
            this.colBranchName.FieldName = "BranchName";
            this.colBranchName.Name = "colBranchName";
            this.colBranchName.Visible = true;
            this.colBranchName.VisibleIndex = 1;
            // 
            // colSalesSubTotal
            // 
            this.colSalesSubTotal.Caption = "ქვე ჯამი / გ.";
            this.colSalesSubTotal.DisplayFormat.FormatString = "n2";
            this.colSalesSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalesSubTotal.FieldName = "SalesSubTotal";
            this.colSalesSubTotal.GroupFormat.FormatString = "n2";
            this.colSalesSubTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalesSubTotal.Name = "colSalesSubTotal";
            this.colSalesSubTotal.Visible = true;
            this.colSalesSubTotal.VisibleIndex = 2;
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
            this.colSalesTaxAmt.VisibleIndex = 3;
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
            this.colSalesFreight.VisibleIndex = 4;
            // 
            // colSalesTotalDue
            // 
            this.colSalesTotalDue.AppearanceCell.BackColor = System.Drawing.Color.Cornsilk;
            this.colSalesTotalDue.AppearanceCell.Options.UseBackColor = true;
            this.colSalesTotalDue.Caption = "სულ ჯამი / გ.";
            this.colSalesTotalDue.DisplayFormat.FormatString = "n2";
            this.colSalesTotalDue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalesTotalDue.FieldName = "SalesTotalDue";
            this.colSalesTotalDue.GroupFormat.FormatString = "n2";
            this.colSalesTotalDue.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalesTotalDue.Name = "colSalesTotalDue";
            this.colSalesTotalDue.SummaryItem.DisplayFormat = "{0:n2}";
            this.colSalesTotalDue.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSalesTotalDue.Visible = true;
            this.colSalesTotalDue.VisibleIndex = 5;
            // 
            // colRealization
            // 
            this.colRealization.Caption = "რეალიზაცია";
            this.colRealization.DisplayFormat.FormatString = "n2";
            this.colRealization.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRealization.FieldName = "colRealization";
            this.colRealization.GroupFormat.FormatString = "n2";
            this.colRealization.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRealization.Name = "colRealization";
            this.colRealization.UnboundExpression = "[SalesTotalDue]-[AccumulatedAmount]";
            this.colRealization.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colRealization.Visible = true;
            this.colRealization.VisibleIndex = 6;
            // 
            // colAccumulatedAmount
            // 
            this.colAccumulatedAmount.Caption = "დაგროვილი თანხა";
            this.colAccumulatedAmount.DisplayFormat.FormatString = "n2";
            this.colAccumulatedAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAccumulatedAmount.FieldName = "AccumulatedAmount";
            this.colAccumulatedAmount.GroupFormat.FormatString = "n2";
            this.colAccumulatedAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAccumulatedAmount.Name = "colAccumulatedAmount";
            this.colAccumulatedAmount.Visible = true;
            this.colAccumulatedAmount.VisibleIndex = 7;
            // 
            // colExpensedAmount
            // 
            this.colExpensedAmount.Caption = "გახარჯული თანხა";
            this.colExpensedAmount.DisplayFormat.FormatString = "n2";
            this.colExpensedAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colExpensedAmount.FieldName = "ExpensedAmount";
            this.colExpensedAmount.GroupFormat.FormatString = "n2";
            this.colExpensedAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colExpensedAmount.Name = "colExpensedAmount";
            this.colExpensedAmount.Visible = true;
            this.colExpensedAmount.VisibleIndex = 8;
            // 
            // colPurchaseSubTotal
            // 
            this.colPurchaseSubTotal.Caption = "ქვე ჯამი / შ.";
            this.colPurchaseSubTotal.DisplayFormat.FormatString = "n2";
            this.colPurchaseSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPurchaseSubTotal.FieldName = "PurchaseSubTotal";
            this.colPurchaseSubTotal.GroupFormat.FormatString = "n2";
            this.colPurchaseSubTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPurchaseSubTotal.Name = "colPurchaseSubTotal";
            this.colPurchaseSubTotal.Visible = true;
            this.colPurchaseSubTotal.VisibleIndex = 9;
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
            this.colPurchaseTaxAmt.VisibleIndex = 10;
            // 
            // col_PurchaseTotalDue
            // 
            this.col_PurchaseTotalDue.AppearanceCell.BackColor = System.Drawing.Color.Cornsilk;
            this.col_PurchaseTotalDue.AppearanceCell.Options.UseBackColor = true;
            this.col_PurchaseTotalDue.Caption = "სულ ჯამი / შ.";
            this.col_PurchaseTotalDue.DisplayFormat.FormatString = "n2";
            this.col_PurchaseTotalDue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_PurchaseTotalDue.FieldName = "_PurchaseTotalDue";
            this.col_PurchaseTotalDue.GroupFormat.FormatString = "n2";
            this.col_PurchaseTotalDue.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_PurchaseTotalDue.Name = "col_PurchaseTotalDue";
            this.col_PurchaseTotalDue.SummaryItem.DisplayFormat = "{0:n2}";
            this.col_PurchaseTotalDue.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.col_PurchaseTotalDue.UnboundExpression = "[PurchaseSubTotal]+[PurchaseTaxAmt]";
            this.col_PurchaseTotalDue.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col_PurchaseTotalDue.Visible = true;
            this.col_PurchaseTotalDue.VisibleIndex = 11;
            // 
            // colCurrencyCode
            // 
            this.colCurrencyCode.Caption = "ვალუტა";
            this.colCurrencyCode.FieldName = "CurrencyCode";
            this.colCurrencyCode.Name = "colCurrencyCode";
            this.colCurrencyCode.Visible = true;
            this.colCurrencyCode.VisibleIndex = 12;
            // 
            // col_Diff
            // 
            this.col_Diff.Caption = "სხვაობა";
            this.col_Diff.DisplayFormat.FormatString = "n2";
            this.col_Diff.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_Diff.FieldName = "_Diff";
            this.col_Diff.GroupFormat.FormatString = "n2";
            this.col_Diff.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_Diff.Name = "col_Diff";
            this.col_Diff.SummaryItem.DisplayFormat = "{0:n2}";
            this.col_Diff.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.col_Diff.UnboundExpression = "[SalesTotalDue]-[_PurchaseTotalDue]";
            this.col_Diff.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col_Diff.Visible = true;
            this.col_Diff.VisibleIndex = 13;
            // 
            // colPaymentMethodName
            // 
            this.colPaymentMethodName.Caption = "გადახდის მეთოდი";
            this.colPaymentMethodName.FieldName = "PaymentMethodName";
            this.colPaymentMethodName.Name = "colPaymentMethodName";
            this.colPaymentMethodName.Visible = true;
            this.colPaymentMethodName.VisibleIndex = 14;
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
            this.ds.DataSetName = "DS_SalesOrderHeaderGroupByDate";
            this.ds.Locale = new System.Globalization.CultureInfo("");
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderDate.Location = new System.Drawing.Point(5, 9);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(65, 17);
            this.lblOrderDate.TabIndex = 0;
            this.lblOrderDate.Text = "თარიღი:";
            // 
            // cboxOrderDate
            // 
            this.cboxOrderDate.EditValue = "=";
            this.cboxOrderDate.EnterMoveNextControl = true;
            this.cboxOrderDate.Location = new System.Drawing.Point(92, 6);
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
            this.cboxOrderDate.TabIndex = 1;
            this.cboxOrderDate.SelectedIndexChanged += new System.EventHandler(this.cboxOrderDate_SelectedIndexChanged);
            // 
            // bbBranch
            // 
            this.bbBranch.EnterMoveNextControl = true;
            this.bbBranch.IsOnline = true;
            this.bbBranch.Location = new System.Drawing.Point(92, 35);
            this.bbBranch.MenuManager = this.barManager;
            this.bbBranch.Name = "bbBranch";
            this.bbBranch.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F);
            this.bbBranch.Properties.Appearance.Options.UseFont = true;
            this.bbBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject1, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject2, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbBranch.Size = new System.Drawing.Size(292, 23);
            this.bbBranch.TabIndex = 5;
            this.bbBranch.TableName = Apothex.DataType.ObjectNames.Branch;
            // 
            // lblBranch
            // 
            this.lblBranch.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBranch.Location = new System.Drawing.Point(5, 38);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(81, 17);
            this.lblBranch.TabIndex = 4;
            this.lblBranch.Text = "ფილიალი:";
            // 
            // dateOrderDate1
            // 
            this.dateOrderDate1.EditValue = null;
            this.dateOrderDate1.EnterMoveNextControl = true;
            this.dateOrderDate1.Location = new System.Drawing.Point(178, 6);
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
            this.dateOrderDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateOrderDate1.Size = new System.Drawing.Size(100, 23);
            this.dateOrderDate1.TabIndex = 2;
            // 
            // dateOrderDate2
            // 
            this.dateOrderDate2.EditValue = null;
            this.dateOrderDate2.Enabled = false;
            this.dateOrderDate2.EnterMoveNextControl = true;
            this.dateOrderDate2.Location = new System.Drawing.Point(284, 6);
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
            this.dateOrderDate2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateOrderDate2.Size = new System.Drawing.Size(100, 23);
            this.dateOrderDate2.TabIndex = 2;
            // 
            // frmSalesOrderHeaderGroupByDateBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsFiltered = true;
            this.IsFilterPanelVisible = true;
            this.Name = "frmSalesOrderHeaderGroupByDateBrowse";
            this.ObjectName = Apothex.DataType.ObjectNames.SalesOrderHeaderGroupByDate;
            this.OptionsBaseForm.IsPrintable = true;
            this.OptionsBaseForm.Text = "დღიური რეესტრი";
            this.OptionsListForm.IsAddable = false;
            this.OptionsListForm.IsApprovable = false;
            this.OptionsListForm.IsBlockable = false;
            this.OptionsListForm.IsChooseable = false;
            this.OptionsListForm.IsDeletable = false;
            this.OptionsListForm.IsDisapprovable = false;
            this.OptionsListForm.IsEditable = false;
            this.OptionsListForm.IsSystemColumnsable = true;
            this.OptionsListForm.IsUnblockable = false;
            this.OptionsGrid.ColumnStatusID = "Status";
            this.OptionsGrid.GridView = this.gridView;
            this.Text = "დღიური რეესტრი";
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
            ((System.ComponentModel.ISupportInitialize)(this.cboxOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private Apothex.DataType.DS_SalesOrderHeaderGroupByDate ds;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchName;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchID;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraEditors.LabelControl lblOrderDate;
        private DevExpress.XtraEditors.ComboBoxEdit cboxOrderDate;
        private Apothex.Windows.Forms.ButtonBrowse bbBranch;
        private DevExpress.XtraEditors.LabelControl lblBranch;
        private DevExpress.XtraEditors.DateEdit dateOrderDate1;
        private DevExpress.XtraEditors.DateEdit dateOrderDate2;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesSubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesTaxAmt;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesFreight;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesTotalDue;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseSubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseTaxAmt;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentMethodName;
        private DevExpress.XtraGrid.Columns.GridColumn col_PurchaseTotalDue;
        private DevExpress.XtraGrid.Columns.GridColumn col_Diff;
        private DevExpress.XtraGrid.Columns.GridColumn colRealization;
        private DevExpress.XtraGrid.Columns.GridColumn colAccumulatedAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colExpensedAmount;
    }
}