namespace Apothex.Production
{
    partial class frmRptRealIncomeExpenceBrowse
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
            this.colBranchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOldResidualAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseOrderTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncomingTransferTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutgoingTransferTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRealIncome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesOrderTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesOrderStandardCostTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesOrderTotalByCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNewResidualAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblFromDate = new DevExpress.XtraEditors.LabelControl();
            this.dateFromDate = new DevExpress.XtraEditors.DateEdit();
            this.lblToDate = new DevExpress.XtraEditors.LabelControl();
            this.dateToDate = new DevExpress.XtraEditors.DateEdit();
            this.ds = new Apothex.DataType.DS_RealIncomeExpence();
            this.lblCurrency = new DevExpress.XtraEditors.LabelControl();
            this.lookCurrency = new DevExpress.XtraEditors.LookUpEdit();
            this.bsCurrency = new System.Windows.Forms.BindingSource();
            this.bbCustomer = new Apothex.Windows.Forms.ButtonBrowse();
            this.lblCustomer = new DevExpress.XtraEditors.LabelControl();
            this.chkAddVatAmt = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAddVatAmt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.chkAddVatAmt);
            this.pnlFilter.Controls.Add(this.bbCustomer);
            this.pnlFilter.Controls.Add(this.lblCustomer);
            this.pnlFilter.Controls.Add(this.lblCurrency);
            this.pnlFilter.Controls.Add(this.lookCurrency);
            this.pnlFilter.Controls.Add(this.dateToDate);
            this.pnlFilter.Controls.Add(this.lblToDate);
            this.pnlFilter.Controls.Add(this.dateFromDate);
            this.pnlFilter.Controls.Add(this.lblFromDate);
            this.pnlFilter.Controls.SetChildIndex(this.lblFromDate, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateFromDate, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblToDate, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnFilter, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateToDate, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lookCurrency, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblCurrency, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblCustomer, 0);
            this.pnlFilter.Controls.SetChildIndex(this.bbCustomer, 0);
            this.pnlFilter.Controls.SetChildIndex(this.chkAddVatAmt, 0);
            // 
            // bsGridControl
            // 
            this.bsGridControl.DataMember = "SP_GetRealIncomeExpence";
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
            this.btnFilter.Location = new System.Drawing.Point(570, 62);
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
            this.colBranchName,
            this.colOldResidualAmount,
            this.colPurchaseOrderTotal,
            this.colIncomingTransferTotal,
            this.colOutgoingTransferTotal,
            this.colRealIncome,
            this.colSalesOrderTotal,
            this.colSalesOrderStandardCostTotal,
            this.colSalesOrderTotalByCustomer,
            this.colNewResidualAmount,
            this.colWin,
            this.colCurrencyCode});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView_CustomUnboundColumnData);
            // 
            // colBranchName
            // 
            this.colBranchName.Caption = "ფილიალი";
            this.colBranchName.FieldName = "BranchName";
            this.colBranchName.Name = "colBranchName";
            this.colBranchName.Visible = true;
            this.colBranchName.VisibleIndex = 0;
            // 
            // colOldResidualAmount
            // 
            this.colOldResidualAmount.Caption = "წინა ნაშთი თვ. ღირ.";
            this.colOldResidualAmount.DisplayFormat.FormatString = "n2";
            this.colOldResidualAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOldResidualAmount.FieldName = "OldResidualAmount";
            this.colOldResidualAmount.GroupFormat.FormatString = "n2";
            this.colOldResidualAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOldResidualAmount.Name = "colOldResidualAmount";
            this.colOldResidualAmount.Visible = true;
            this.colOldResidualAmount.VisibleIndex = 1;
            // 
            // colPurchaseOrderTotal
            // 
            this.colPurchaseOrderTotal.Caption = "შესყიდვა ფაქტურით თვ. ღირ.";
            this.colPurchaseOrderTotal.DisplayFormat.FormatString = "n2";
            this.colPurchaseOrderTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPurchaseOrderTotal.FieldName = "PurchaseOrderTotal";
            this.colPurchaseOrderTotal.GroupFormat.FormatString = "n2";
            this.colPurchaseOrderTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPurchaseOrderTotal.Name = "colPurchaseOrderTotal";
            this.colPurchaseOrderTotal.Visible = true;
            this.colPurchaseOrderTotal.VisibleIndex = 2;
            // 
            // colIncomingTransferTotal
            // 
            this.colIncomingTransferTotal.Caption = "შემოსული შიდა თვ. ღირ.";
            this.colIncomingTransferTotal.DisplayFormat.FormatString = "n2";
            this.colIncomingTransferTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIncomingTransferTotal.FieldName = "IncomingTransferTotal";
            this.colIncomingTransferTotal.GroupFormat.FormatString = "n2";
            this.colIncomingTransferTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIncomingTransferTotal.Name = "colIncomingTransferTotal";
            this.colIncomingTransferTotal.Visible = true;
            this.colIncomingTransferTotal.VisibleIndex = 3;
            // 
            // colOutgoingTransferTotal
            // 
            this.colOutgoingTransferTotal.Caption = "გასული შიდა თვ. ღირ.";
            this.colOutgoingTransferTotal.DisplayFormat.FormatString = "n2";
            this.colOutgoingTransferTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOutgoingTransferTotal.FieldName = "OutgoingTransferTotal";
            this.colOutgoingTransferTotal.GroupFormat.FormatString = "n2";
            this.colOutgoingTransferTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOutgoingTransferTotal.Name = "colOutgoingTransferTotal";
            this.colOutgoingTransferTotal.Visible = true;
            this.colOutgoingTransferTotal.VisibleIndex = 4;
            // 
            // colRealIncome
            // 
            this.colRealIncome.Caption = "რეალური შესყიდვა";
            this.colRealIncome.DisplayFormat.FormatString = "n2";
            this.colRealIncome.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRealIncome.FieldName = "colRealIncome";
            this.colRealIncome.GroupFormat.FormatString = "n2";
            this.colRealIncome.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRealIncome.Name = "colRealIncome";
            this.colRealIncome.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colRealIncome.Visible = true;
            this.colRealIncome.VisibleIndex = 5;
            // 
            // colSalesOrderTotal
            // 
            this.colSalesOrderTotal.Caption = "რეალიზაცია";
            this.colSalesOrderTotal.DisplayFormat.FormatString = "n2";
            this.colSalesOrderTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalesOrderTotal.FieldName = "SalesOrderTotal";
            this.colSalesOrderTotal.GroupFormat.FormatString = "n2";
            this.colSalesOrderTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalesOrderTotal.Name = "colSalesOrderTotal";
            this.colSalesOrderTotal.Visible = true;
            this.colSalesOrderTotal.VisibleIndex = 6;
            // 
            // colSalesOrderStandardCostTotal
            // 
            this.colSalesOrderStandardCostTotal.Caption = "რეალიზაცია თვ. ღირ.";
            this.colSalesOrderStandardCostTotal.DisplayFormat.FormatString = "n2";
            this.colSalesOrderStandardCostTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalesOrderStandardCostTotal.FieldName = "SalesOrderStandardCostTotal";
            this.colSalesOrderStandardCostTotal.GroupFormat.FormatString = "n2";
            this.colSalesOrderStandardCostTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalesOrderStandardCostTotal.Name = "colSalesOrderStandardCostTotal";
            this.colSalesOrderStandardCostTotal.Visible = true;
            this.colSalesOrderStandardCostTotal.VisibleIndex = 7;
            // 
            // colSalesOrderTotalByCustomer
            // 
            this.colSalesOrderTotalByCustomer.Caption = "კომპანიაზე გაყიდული თვ. ღირ.";
            this.colSalesOrderTotalByCustomer.DisplayFormat.FormatString = "n2";
            this.colSalesOrderTotalByCustomer.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalesOrderTotalByCustomer.FieldName = "SalesOrderTotalByCustomer";
            this.colSalesOrderTotalByCustomer.GroupFormat.FormatString = "n2";
            this.colSalesOrderTotalByCustomer.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalesOrderTotalByCustomer.Name = "colSalesOrderTotalByCustomer";
            this.colSalesOrderTotalByCustomer.Visible = true;
            this.colSalesOrderTotalByCustomer.VisibleIndex = 8;
            // 
            // colNewResidualAmount
            // 
            this.colNewResidualAmount.Caption = "ნაშთი თვ. ღირ.";
            this.colNewResidualAmount.DisplayFormat.FormatString = "n2";
            this.colNewResidualAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNewResidualAmount.FieldName = "NewResidualAmount";
            this.colNewResidualAmount.GroupFormat.FormatString = "n2";
            this.colNewResidualAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNewResidualAmount.Name = "colNewResidualAmount";
            this.colNewResidualAmount.Visible = true;
            this.colNewResidualAmount.VisibleIndex = 9;
            // 
            // colWin
            // 
            this.colWin.Caption = "მოგება";
            this.colWin.DisplayFormat.FormatString = "n2";
            this.colWin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colWin.FieldName = "colWin";
            this.colWin.GroupFormat.FormatString = "n2";
            this.colWin.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colWin.Name = "colWin";
            this.colWin.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colWin.Visible = true;
            this.colWin.VisibleIndex = 10;
            // 
            // colCurrencyCode
            // 
            this.colCurrencyCode.Caption = "ვალუტა";
            this.colCurrencyCode.FieldName = "CurrencyCode";
            this.colCurrencyCode.Name = "colCurrencyCode";
            this.colCurrencyCode.Visible = true;
            this.colCurrencyCode.VisibleIndex = 11;
            // 
            // lblFromDate
            // 
            this.lblFromDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFromDate.Location = new System.Drawing.Point(12, 9);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(138, 17);
            this.lblFromDate.TabIndex = 0;
            this.lblFromDate.Text = "დაწყების თარიღი:";
            // 
            // dateFromDate
            // 
            this.dateFromDate.EditValue = null;
            this.dateFromDate.EnterMoveNextControl = true;
            this.dateFromDate.Location = new System.Drawing.Point(184, 6);
            this.dateFromDate.MenuManager = this.barManager;
            this.dateFromDate.Name = "dateFromDate";
            this.dateFromDate.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateFromDate.Properties.Appearance.Options.UseFont = true;
            this.dateFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFromDate.Properties.DisplayFormat.FormatString = "G";
            this.dateFromDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateFromDate.Properties.EditFormat.FormatString = "G";
            this.dateFromDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateFromDate.Properties.Mask.EditMask = "G";
            this.dateFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateFromDate.Size = new System.Drawing.Size(150, 23);
            this.dateFromDate.TabIndex = 1;
            this.dateFromDate.EditValueChanged += new System.EventHandler(this.dateFromDate_EditValueChanged);
            // 
            // lblToDate
            // 
            this.lblToDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblToDate.Location = new System.Drawing.Point(12, 38);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(166, 17);
            this.lblToDate.TabIndex = 2;
            this.lblToDate.Text = "დასრულების თარიღი:";
            // 
            // dateToDate
            // 
            this.dateToDate.EditValue = null;
            this.dateToDate.EnterMoveNextControl = true;
            this.dateToDate.Location = new System.Drawing.Point(184, 35);
            this.dateToDate.Name = "dateToDate";
            this.dateToDate.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateToDate.Properties.Appearance.Options.UseFont = true;
            this.dateToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateToDate.Properties.DisplayFormat.FormatString = "G";
            this.dateToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateToDate.Properties.EditFormat.FormatString = "G";
            this.dateToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateToDate.Properties.Mask.EditMask = "G";
            this.dateToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateToDate.Size = new System.Drawing.Size(150, 23);
            this.dateToDate.TabIndex = 3;
            this.dateToDate.EditValueChanged += new System.EventHandler(this.dateToDate_EditValueChanged);
            // 
            // ds
            // 
            this.ds.DataSetName = "DS_RealIncomeExpence";
            this.ds.Locale = new System.Globalization.CultureInfo("");
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCurrency
            // 
            this.lblCurrency.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrency.Location = new System.Drawing.Point(12, 66);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(63, 17);
            this.lblCurrency.TabIndex = 4;
            this.lblCurrency.Text = "ვალუტა:";
            // 
            // lookCurrency
            // 
            this.lookCurrency.EnterMoveNextControl = true;
            this.lookCurrency.Location = new System.Drawing.Point(184, 63);
            this.lookCurrency.Name = "lookCurrency";
            this.lookCurrency.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.lookCurrency.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookCurrency.Properties.Appearance.Options.UseFont = true;
            this.lookCurrency.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookCurrency.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookCurrency.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookCurrency.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lookCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookCurrency.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption")});
            this.lookCurrency.Properties.DataSource = this.bsCurrency;
            this.lookCurrency.Properties.DisplayMember = "Caption";
            this.lookCurrency.Properties.NullText = "";
            this.lookCurrency.Properties.ShowHeader = false;
            this.lookCurrency.Properties.ValueMember = "ID";
            this.lookCurrency.Size = new System.Drawing.Size(150, 23);
            this.lookCurrency.TabIndex = 5;
            // 
            // bbCustomer
            // 
            this.bbCustomer.EnterMoveNextControl = true;
            this.bbCustomer.IsOnline = true;
            this.bbCustomer.Location = new System.Drawing.Point(420, 35);
            this.bbCustomer.MenuManager = this.barManager;
            this.bbCustomer.Name = "bbCustomer";
            this.bbCustomer.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F);
            this.bbCustomer.Properties.Appearance.Options.UseFont = true;
            this.bbCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject1, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject2, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbCustomer.Size = new System.Drawing.Size(300, 23);
            this.bbCustomer.TabIndex = 8;
            this.bbCustomer.TableName = Apothex.DataType.ObjectNames.Company;
            // 
            // lblCustomer
            // 
            this.lblCustomer.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCustomer.Location = new System.Drawing.Point(340, 38);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(72, 17);
            this.lblCustomer.TabIndex = 7;
            this.lblCustomer.Text = "კომპანია:";
            // 
            // chkAddVatAmt
            // 
            this.chkAddVatAmt.Location = new System.Drawing.Point(418, 10);
            this.chkAddVatAmt.MenuManager = this.barManager;
            this.chkAddVatAmt.Name = "chkAddVatAmt";
            this.chkAddVatAmt.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkAddVatAmt.Properties.Appearance.Options.UseFont = true;
            this.chkAddVatAmt.Properties.Caption = "დ.ღ.გ.";
            this.chkAddVatAmt.Size = new System.Drawing.Size(302, 22);
            this.chkAddVatAmt.TabIndex = 6;
            // 
            // frmRptRealIncomeExpenceBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsFilterPanelVisible = true;
            this.Name = "frmRptRealIncomeExpenceBrowse";
            this.ObjectName = Apothex.DataType.ObjectNames.RealIncomeExpence;
            this.OptionsBaseForm.Text = "რეალური შესყიდვა & გაყიდვა";
            this.OptionsListForm.IsAddable = false;
            this.OptionsListForm.IsApprovable = false;
            this.OptionsListForm.IsBlockable = false;
            this.OptionsListForm.IsChooseable = false;
            this.OptionsListForm.IsDeletable = false;
            this.OptionsListForm.IsDisapprovable = false;
            this.OptionsListForm.IsFilterApprovable = false;
            this.OptionsListForm.IsSystemColumnsable = true;
            this.OptionsListForm.IsTopable = false;
            this.OptionsListForm.IsUnblockable = false;
            this.OptionsGrid.GridView = this.gridView;
            this.Text = "რეალური შესყიდვა & გაყიდვა";
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
            ((System.ComponentModel.ISupportInitialize)(this.dateFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAddVatAmt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.DateEdit dateToDate;
        private DevExpress.XtraEditors.LabelControl lblToDate;
        private DevExpress.XtraEditors.DateEdit dateFromDate;
        private DevExpress.XtraEditors.LabelControl lblFromDate;
        private Apothex.DataType.DS_RealIncomeExpence ds;
        private DevExpress.XtraEditors.LabelControl lblCurrency;
        private DevExpress.XtraEditors.LookUpEdit lookCurrency;
        private System.Windows.Forms.BindingSource bsCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchName;
        private DevExpress.XtraGrid.Columns.GridColumn colOldResidualAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseOrderTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIncomingTransferTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colOutgoingTransferTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colRealIncome;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesOrderTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colNewResidualAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colWin;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesOrderStandardCostTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesOrderTotalByCustomer;
        private Apothex.Windows.Forms.ButtonBrowse bbCustomer;
        private DevExpress.XtraEditors.LabelControl lblCustomer;
        private DevExpress.XtraEditors.CheckEdit chkAddVatAmt;
    }
}