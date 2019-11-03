namespace Apothex.Purchasing
{
    partial class frmPurchaseOrderBrowse
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPurchaseOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVendorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxAmt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFreight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalDue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentMethodName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOverheadNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVendorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyRateID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRevisionNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentMethodID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApproverUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsBranch = new System.Windows.Forms.BindingSource(this.components);
            this.bsCurrency = new System.Windows.Forms.BindingSource(this.components);
            this.bsPaymentMethod = new System.Windows.Forms.BindingSource(this.components);
            this.lblVendorID = new DevExpress.XtraEditors.LabelControl();
            this.lookBranch = new DevExpress.XtraEditors.LookUpEdit();
            this.lblBranch = new DevExpress.XtraEditors.LabelControl();
            this.txtOverheadNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblOverheadNumber = new DevExpress.XtraEditors.LabelControl();
            this.ds = new Apothex.DataType.DS_Purchasing();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabMain = new DevExpress.XtraTab.XtraTabPage();
            this.cboxVendorID = new DevExpress.XtraEditors.ComboBoxEdit();
            this.bbVendorID = new Apothex.Windows.Forms.ButtonBrowse();
            this.cboxVendorName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboxOverheadNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboxID = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtVendorName = new DevExpress.XtraEditors.TextEdit();
            this.lblVendorName = new DevExpress.XtraEditors.LabelControl();
            this.dateOrderDate2 = new DevExpress.XtraEditors.DateEdit();
            this.dateOrderDate1 = new DevExpress.XtraEditors.DateEdit();
            this.cboxOrderDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblOrderDate = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblOrderID = new DevExpress.XtraEditors.LabelControl();
            this.tabAmount = new DevExpress.XtraTab.XtraTabPage();
            this.lblFreight = new DevExpress.XtraEditors.LabelControl();
            this.cboxFreight = new DevExpress.XtraEditors.ComboBoxEdit();
            this.spinFreight1 = new DevExpress.XtraEditors.SpinEdit();
            this.spinFreight2 = new DevExpress.XtraEditors.SpinEdit();
            this.lblTaxAmt = new DevExpress.XtraEditors.LabelControl();
            this.cboxTaxAmt = new DevExpress.XtraEditors.ComboBoxEdit();
            this.spinTaxAmt1 = new DevExpress.XtraEditors.SpinEdit();
            this.spinTaxAmt2 = new DevExpress.XtraEditors.SpinEdit();
            this.lblSubTotal = new DevExpress.XtraEditors.LabelControl();
            this.cboxSubTotal = new DevExpress.XtraEditors.ComboBoxEdit();
            this.spinSubTotal1 = new DevExpress.XtraEditors.SpinEdit();
            this.spinSubTotal2 = new DevExpress.XtraEditors.SpinEdit();
            this.lblTotalDue = new DevExpress.XtraEditors.LabelControl();
            this.cboxTotalDue = new DevExpress.XtraEditors.ComboBoxEdit();
            this.spinTotalDue1 = new DevExpress.XtraEditors.SpinEdit();
            this.spinTotalDue2 = new DevExpress.XtraEditors.SpinEdit();
            this.lblCurrency = new DevExpress.XtraEditors.LabelControl();
            this.lookCurrency = new DevExpress.XtraEditors.LookUpEdit();
            this.lblPaymentMethod = new DevExpress.XtraEditors.LabelControl();
            this.lookPaymentMethod = new DevExpress.XtraEditors.LookUpEdit();
            this.tabAdditional = new DevExpress.XtraTab.XtraTabPage();
            this.cboxRevisionNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblRevisionNumber = new DevExpress.XtraEditors.LabelControl();
            this.spinRevisionNumber1 = new DevExpress.XtraEditors.SpinEdit();
            this.spinRevisionNumber2 = new DevExpress.XtraEditors.SpinEdit();
            this.miGenerateSales = new DevExpress.XtraBars.BarButtonItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.bsPaymentMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOverheadNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxVendorID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbVendorID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxVendorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxOverheadNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVendorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.tabAmount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxFreight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinFreight1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinFreight2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxTaxAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTaxAmt1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTaxAmt2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxSubTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSubTotal1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSubTotal2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxTotalDue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalDue1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalDue2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookPaymentMethod.Properties)).BeginInit();
            this.tabAdditional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxRevisionNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinRevisionNumber1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinRevisionNumber2.Properties)).BeginInit();
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
            this.bsGridControl.DataMember = "VW_PurchaseOrderHeader";
            this.bsGridControl.DataSource = this.ds;
            this.bsGridControl.Sort = "";
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
            this.btnFilter.Location = new System.Drawing.Point(538, 124);
            // 
            // popupMenu
            // 
            this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.miGenerateSales, true)});
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
            this.colPurchaseOrderID,
            this.colBranchName,
            this.colOrderDate,
            this.colVendorName,
            this.colSubTotal,
            this.colTaxAmt,
            this.colFreight,
            this.colTotalDue,
            this.colCurrencyCode,
            this.colPaymentMethodName,
            this.colOverheadNumber,
            this.colVendorID,
            this.colCurrencyRateID,
            this.colRevisionNumber,
            this.colModifier,
            this.colModifiedDate,
            this.colApprover,
            this.colBranchID,
            this.colPaymentMethodID,
            this.colStatus,
            this.colModifiedUserID,
            this.colApproverUserID});
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalDue", this.colTotalDue, "{0:n2}")});
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowFooter = true;
            // 
            // colPurchaseOrderID
            // 
            this.colPurchaseOrderID.Caption = "№";
            this.colPurchaseOrderID.FieldName = "PurchaseOrderID";
            this.colPurchaseOrderID.Name = "colPurchaseOrderID";
            this.colPurchaseOrderID.SummaryItem.DisplayFormat = "{0:n00}";
            this.colPurchaseOrderID.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.colPurchaseOrderID.Visible = true;
            this.colPurchaseOrderID.VisibleIndex = 0;
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
            // colVendorName
            // 
            this.colVendorName.Caption = "მომწოდებელი:";
            this.colVendorName.FieldName = "VendorName";
            this.colVendorName.Name = "colVendorName";
            this.colVendorName.Visible = true;
            this.colVendorName.VisibleIndex = 3;
            // 
            // colSubTotal
            // 
            this.colSubTotal.Caption = "ქვე ჯამი";
            this.colSubTotal.DisplayFormat.FormatString = "n2";
            this.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubTotal.FieldName = "SubTotal";
            this.colSubTotal.GroupFormat.FormatString = "n2";
            this.colSubTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.Visible = true;
            this.colSubTotal.VisibleIndex = 4;
            // 
            // colTaxAmt
            // 
            this.colTaxAmt.Caption = "დ.ღ.გ.";
            this.colTaxAmt.DisplayFormat.FormatString = "n2";
            this.colTaxAmt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTaxAmt.FieldName = "TaxAmt";
            this.colTaxAmt.GroupFormat.FormatString = "n2";
            this.colTaxAmt.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTaxAmt.Name = "colTaxAmt";
            this.colTaxAmt.Visible = true;
            this.colTaxAmt.VisibleIndex = 5;
            // 
            // colFreight
            // 
            this.colFreight.Caption = "ტრანსპორტ.";
            this.colFreight.DisplayFormat.FormatString = "n2";
            this.colFreight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFreight.FieldName = "Freight";
            this.colFreight.GroupFormat.FormatString = "n2";
            this.colFreight.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFreight.Name = "colFreight";
            this.colFreight.Visible = true;
            this.colFreight.VisibleIndex = 6;
            // 
            // colTotalDue
            // 
            this.colTotalDue.AppearanceCell.BackColor = System.Drawing.Color.Cornsilk;
            this.colTotalDue.AppearanceCell.Options.UseBackColor = true;
            this.colTotalDue.Caption = "სულ ჯამი";
            this.colTotalDue.DisplayFormat.FormatString = "n2";
            this.colTotalDue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalDue.FieldName = "TotalDue";
            this.colTotalDue.GroupFormat.FormatString = "n2";
            this.colTotalDue.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalDue.Name = "colTotalDue";
            this.colTotalDue.SummaryItem.DisplayFormat = "{0:n2}";
            this.colTotalDue.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTotalDue.Visible = true;
            this.colTotalDue.VisibleIndex = 7;
            // 
            // colCurrencyCode
            // 
            this.colCurrencyCode.Caption = "ვალუტა";
            this.colCurrencyCode.FieldName = "CurrencyCode";
            this.colCurrencyCode.Name = "colCurrencyCode";
            this.colCurrencyCode.Visible = true;
            this.colCurrencyCode.VisibleIndex = 8;
            // 
            // colPaymentMethodName
            // 
            this.colPaymentMethodName.Caption = "გადახდ. მეთოდი";
            this.colPaymentMethodName.FieldName = "PaymentMethodName";
            this.colPaymentMethodName.Name = "colPaymentMethodName";
            this.colPaymentMethodName.Visible = true;
            this.colPaymentMethodName.VisibleIndex = 9;
            // 
            // colOverheadNumber
            // 
            this.colOverheadNumber.Caption = "ზედნადების №";
            this.colOverheadNumber.FieldName = "OverheadNumber";
            this.colOverheadNumber.Name = "colOverheadNumber";
            this.colOverheadNumber.Visible = true;
            this.colOverheadNumber.VisibleIndex = 10;
            // 
            // colVendorID
            // 
            this.colVendorID.FieldName = "VendorID";
            this.colVendorID.Name = "colVendorID";
            // 
            // colCurrencyRateID
            // 
            this.colCurrencyRateID.FieldName = "CurrencyRateID";
            this.colCurrencyRateID.Name = "colCurrencyRateID";
            // 
            // colRevisionNumber
            // 
            this.colRevisionNumber.FieldName = "RevisionNumber";
            this.colRevisionNumber.Name = "colRevisionNumber";
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
            // colApprover
            // 
            this.colApprover.Caption = "დაამოწმა";
            this.colApprover.FieldName = "Approver";
            this.colApprover.Name = "colApprover";
            // 
            // colBranchID
            // 
            this.colBranchID.FieldName = "BranchID";
            this.colBranchID.Name = "colBranchID";
            // 
            // colPaymentMethodID
            // 
            this.colPaymentMethodID.FieldName = "PaymentMethodID";
            this.colPaymentMethodID.Name = "colPaymentMethodID";
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
            // colApproverUserID
            // 
            this.colApproverUserID.FieldName = "ApproverUserID";
            this.colApproverUserID.Name = "colApproverUserID";
            // 
            // bsBranch
            // 
            this.bsBranch.Sort = "";
            // 
            // bsPaymentMethod
            // 
            this.bsPaymentMethod.Sort = "Caption";
            // 
            // lblVendorID
            // 
            this.lblVendorID.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVendorID.Location = new System.Drawing.Point(491, 37);
            this.lblVendorID.Name = "lblVendorID";
            this.lblVendorID.Size = new System.Drawing.Size(113, 17);
            this.lblVendorID.TabIndex = 12;
            this.lblVendorID.Text = "მომწოდებელი:";
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
            // txtOverheadNumber
            // 
            this.txtOverheadNumber.EnterMoveNextControl = true;
            this.txtOverheadNumber.Location = new System.Drawing.Point(690, 6);
            this.txtOverheadNumber.Name = "txtOverheadNumber";
            this.txtOverheadNumber.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOverheadNumber.Properties.Appearance.Options.UseFont = true;
            this.txtOverheadNumber.Size = new System.Drawing.Size(231, 23);
            this.txtOverheadNumber.TabIndex = 11;
            // 
            // lblOverheadNumber
            // 
            this.lblOverheadNumber.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOverheadNumber.Location = new System.Drawing.Point(491, 8);
            this.lblOverheadNumber.Name = "lblOverheadNumber";
            this.lblOverheadNumber.Size = new System.Drawing.Size(81, 17);
            this.lblOverheadNumber.TabIndex = 9;
            this.lblOverheadNumber.Text = "ზედნად №:";
            // 
            // ds
            // 
            this.ds.DataSetName = "DS_Purchasing";
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
            this.xtraTabControl.Size = new System.Drawing.Size(780, 171);
            this.xtraTabControl.TabIndex = 0;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabMain,
            this.tabAmount,
            this.tabAdditional});
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.cboxVendorID);
            this.tabMain.Controls.Add(this.bbVendorID);
            this.tabMain.Controls.Add(this.cboxVendorName);
            this.tabMain.Controls.Add(this.cboxOverheadNumber);
            this.tabMain.Controls.Add(this.cboxID);
            this.tabMain.Controls.Add(this.txtVendorName);
            this.tabMain.Controls.Add(this.lblVendorID);
            this.tabMain.Controls.Add(this.lblVendorName);
            this.tabMain.Controls.Add(this.txtOverheadNumber);
            this.tabMain.Controls.Add(this.lblOverheadNumber);
            this.tabMain.Controls.Add(this.dateOrderDate2);
            this.tabMain.Controls.Add(this.dateOrderDate1);
            this.tabMain.Controls.Add(this.cboxOrderDate);
            this.tabMain.Controls.Add(this.lblOrderDate);
            this.tabMain.Controls.Add(this.lookBranch);
            this.tabMain.Controls.Add(this.lblBranch);
            this.tabMain.Controls.Add(this.txtID);
            this.tabMain.Controls.Add(this.lblOrderID);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(774, 142);
            this.tabMain.Text = "მთავარი";
            // 
            // cboxVendorID
            // 
            this.cboxVendorID.EditValue = "=";
            this.cboxVendorID.EnterMoveNextControl = true;
            this.cboxVendorID.Location = new System.Drawing.Point(609, 34);
            this.cboxVendorID.Name = "cboxVendorID";
            this.cboxVendorID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxVendorID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxVendorID.Properties.Appearance.Options.UseFont = true;
            this.cboxVendorID.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxVendorID.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxVendorID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxVendorID.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!="});
            this.cboxVendorID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxVendorID.Size = new System.Drawing.Size(75, 23);
            this.cboxVendorID.TabIndex = 13;
            this.cboxVendorID.SelectedIndexChanged += new System.EventHandler(this.cboxVendorID_SelectedIndexChanged);
            // 
            // bbVendorID
            // 
            this.bbVendorID.EnterMoveNextControl = true;
            this.bbVendorID.IsOnline = true;
            this.bbVendorID.Location = new System.Drawing.Point(690, 34);
            this.bbVendorID.MenuManager = this.barManager;
            this.bbVendorID.Name = "bbVendorID";
            this.bbVendorID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bbVendorID.Properties.Appearance.Options.UseFont = true;
            this.bbVendorID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject1, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject2, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbVendorID.Size = new System.Drawing.Size(231, 23);
            this.bbVendorID.TabIndex = 14;
            this.bbVendorID.TableName = Apothex.DataType.ObjectNames.Company;
            // 
            // cboxVendorName
            // 
            this.cboxVendorName.EditValue = "%a%";
            this.cboxVendorName.EnterMoveNextControl = true;
            this.cboxVendorName.Location = new System.Drawing.Point(609, 65);
            this.cboxVendorName.Name = "cboxVendorName";
            this.cboxVendorName.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxVendorName.Properties.Appearance.Options.UseFont = true;
            this.cboxVendorName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxVendorName.Properties.Items.AddRange(new object[] {
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
            this.cboxVendorName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxVendorName.Size = new System.Drawing.Size(75, 23);
            this.cboxVendorName.TabIndex = 16;
            this.cboxVendorName.SelectedIndexChanged += new System.EventHandler(this.cboxVendorName_SelectedIndexChanged);
            // 
            // cboxOverheadNumber
            // 
            this.cboxOverheadNumber.EditValue = "%a%";
            this.cboxOverheadNumber.EnterMoveNextControl = true;
            this.cboxOverheadNumber.Location = new System.Drawing.Point(609, 6);
            this.cboxOverheadNumber.Name = "cboxOverheadNumber";
            this.cboxOverheadNumber.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxOverheadNumber.Properties.Appearance.Options.UseFont = true;
            this.cboxOverheadNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxOverheadNumber.Properties.Items.AddRange(new object[] {
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
            this.cboxOverheadNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxOverheadNumber.Size = new System.Drawing.Size(75, 23);
            this.cboxOverheadNumber.TabIndex = 10;
            this.cboxOverheadNumber.SelectedIndexChanged += new System.EventHandler(this.cboxOverheadNumber_SelectedIndexChanged);
            // 
            // cboxID
            // 
            this.cboxID.EditValue = "=";
            this.cboxID.EnterMoveNextControl = true;
            this.cboxID.Location = new System.Drawing.Point(93, 6);
            this.cboxID.Name = "cboxID";
            this.cboxID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxID.Properties.Appearance.Options.UseFont = true;
            this.cboxID.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxID.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxID.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!=",
            "a,b,c",
            "!a,b,c"});
            this.cboxID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxID.Size = new System.Drawing.Size(80, 23);
            this.cboxID.TabIndex = 1;
            this.cboxID.SelectedIndexChanged += new System.EventHandler(this.cboxID_SelectedIndexChanged);
            // 
            // txtVendorName
            // 
            this.txtVendorName.EnterMoveNextControl = true;
            this.txtVendorName.Location = new System.Drawing.Point(690, 65);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtVendorName.Properties.Appearance.Options.UseFont = true;
            this.txtVendorName.Size = new System.Drawing.Size(231, 23);
            this.txtVendorName.TabIndex = 17;
            // 
            // lblVendorName
            // 
            this.lblVendorName.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVendorName.Location = new System.Drawing.Point(491, 67);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(113, 17);
            this.lblVendorName.TabIndex = 15;
            this.lblVendorName.Text = "მომწოდებელი:";
            // 
            // dateOrderDate2
            // 
            this.dateOrderDate2.EditValue = null;
            this.dateOrderDate2.Enabled = false;
            this.dateOrderDate2.EnterMoveNextControl = true;
            this.dateOrderDate2.Location = new System.Drawing.Point(335, 65);
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
            // txtID
            // 
            this.txtID.EnterMoveNextControl = true;
            this.txtID.Location = new System.Drawing.Point(179, 6);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Properties.DisplayFormat.FormatString = "f0";
            this.txtID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtID.Properties.EditFormat.FormatString = "f0";
            this.txtID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtID.Properties.Mask.EditMask = "[0-9,]+";
            this.txtID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtID.Properties.MaxLength = 10;
            this.txtID.Size = new System.Drawing.Size(306, 23);
            this.txtID.TabIndex = 2;
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
            this.tabAmount.Controls.Add(this.lblFreight);
            this.tabAmount.Controls.Add(this.cboxFreight);
            this.tabAmount.Controls.Add(this.spinFreight1);
            this.tabAmount.Controls.Add(this.spinFreight2);
            this.tabAmount.Controls.Add(this.lblTaxAmt);
            this.tabAmount.Controls.Add(this.cboxTaxAmt);
            this.tabAmount.Controls.Add(this.spinTaxAmt1);
            this.tabAmount.Controls.Add(this.spinTaxAmt2);
            this.tabAmount.Controls.Add(this.lblSubTotal);
            this.tabAmount.Controls.Add(this.cboxSubTotal);
            this.tabAmount.Controls.Add(this.spinSubTotal1);
            this.tabAmount.Controls.Add(this.spinSubTotal2);
            this.tabAmount.Controls.Add(this.lblTotalDue);
            this.tabAmount.Controls.Add(this.cboxTotalDue);
            this.tabAmount.Controls.Add(this.spinTotalDue1);
            this.tabAmount.Controls.Add(this.spinTotalDue2);
            this.tabAmount.Controls.Add(this.lblCurrency);
            this.tabAmount.Controls.Add(this.lookCurrency);
            this.tabAmount.Controls.Add(this.lblPaymentMethod);
            this.tabAmount.Controls.Add(this.lookPaymentMethod);
            this.tabAmount.Name = "tabAmount";
            this.tabAmount.Size = new System.Drawing.Size(774, 142);
            this.tabAmount.Text = "თანხები";
            // 
            // lblFreight
            // 
            this.lblFreight.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFreight.Location = new System.Drawing.Point(6, 9);
            this.lblFreight.Name = "lblFreight";
            this.lblFreight.Size = new System.Drawing.Size(93, 17);
            this.lblFreight.TabIndex = 0;
            this.lblFreight.Text = "ტრანსპორტ:";
            // 
            // cboxFreight
            // 
            this.cboxFreight.EnterMoveNextControl = true;
            this.cboxFreight.Location = new System.Drawing.Point(130, 6);
            this.cboxFreight.Name = "cboxFreight";
            this.cboxFreight.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxFreight.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxFreight.Properties.Appearance.Options.UseFont = true;
            this.cboxFreight.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxFreight.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxFreight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxFreight.Properties.Items.AddRange(new object[] {
            "",
            "=",
            ">",
            "<",
            "[ ]"});
            this.cboxFreight.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxFreight.Size = new System.Drawing.Size(80, 23);
            this.cboxFreight.TabIndex = 1;
            this.cboxFreight.SelectedIndexChanged += new System.EventHandler(this.cboxFreight_SelectedIndexChanged);
            // 
            // spinFreight1
            // 
            this.spinFreight1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinFreight1.Enabled = false;
            this.spinFreight1.EnterMoveNextControl = true;
            this.spinFreight1.Location = new System.Drawing.Point(216, 6);
            this.spinFreight1.Name = "spinFreight1";
            this.spinFreight1.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinFreight1.Properties.Appearance.Options.UseFont = true;
            this.spinFreight1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinFreight1.Properties.DisplayFormat.FormatString = "n2";
            this.spinFreight1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinFreight1.Properties.EditFormat.FormatString = "n2";
            this.spinFreight1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinFreight1.Properties.Mask.EditMask = "n2";
            this.spinFreight1.Properties.MaxValue = new decimal(new int[] {
            -1806942208,
            209547,
            0,
            0});
            this.spinFreight1.Size = new System.Drawing.Size(110, 23);
            this.spinFreight1.TabIndex = 2;
            this.spinFreight1.EditValueChanged += new System.EventHandler(this.spinFreight1_EditValueChanged);
            // 
            // spinFreight2
            // 
            this.spinFreight2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinFreight2.Enabled = false;
            this.spinFreight2.EnterMoveNextControl = true;
            this.spinFreight2.Location = new System.Drawing.Point(332, 6);
            this.spinFreight2.Name = "spinFreight2";
            this.spinFreight2.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinFreight2.Properties.Appearance.Options.UseFont = true;
            this.spinFreight2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinFreight2.Properties.DisplayFormat.FormatString = "n2";
            this.spinFreight2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinFreight2.Properties.EditFormat.FormatString = "n2";
            this.spinFreight2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinFreight2.Properties.Mask.EditMask = "n2";
            this.spinFreight2.Properties.MaxValue = new decimal(new int[] {
            -1806942208,
            209547,
            0,
            0});
            this.spinFreight2.Size = new System.Drawing.Size(110, 23);
            this.spinFreight2.TabIndex = 3;
            this.spinFreight2.EditValueChanged += new System.EventHandler(this.spinFreight2_EditValueChanged);
            // 
            // lblTaxAmt
            // 
            this.lblTaxAmt.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTaxAmt.Location = new System.Drawing.Point(6, 38);
            this.lblTaxAmt.Name = "lblTaxAmt";
            this.lblTaxAmt.Size = new System.Drawing.Size(52, 17);
            this.lblTaxAmt.TabIndex = 4;
            this.lblTaxAmt.Text = "დ.ღ.გ.:";
            // 
            // cboxTaxAmt
            // 
            this.cboxTaxAmt.EnterMoveNextControl = true;
            this.cboxTaxAmt.Location = new System.Drawing.Point(130, 35);
            this.cboxTaxAmt.Name = "cboxTaxAmt";
            this.cboxTaxAmt.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxTaxAmt.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxTaxAmt.Properties.Appearance.Options.UseFont = true;
            this.cboxTaxAmt.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxTaxAmt.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxTaxAmt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxTaxAmt.Properties.Items.AddRange(new object[] {
            "",
            "=",
            ">",
            "<",
            "[ ]"});
            this.cboxTaxAmt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxTaxAmt.Size = new System.Drawing.Size(80, 23);
            this.cboxTaxAmt.TabIndex = 5;
            this.cboxTaxAmt.SelectedIndexChanged += new System.EventHandler(this.cboxTaxAmt_SelectedIndexChanged);
            // 
            // spinTaxAmt1
            // 
            this.spinTaxAmt1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTaxAmt1.Enabled = false;
            this.spinTaxAmt1.EnterMoveNextControl = true;
            this.spinTaxAmt1.Location = new System.Drawing.Point(216, 35);
            this.spinTaxAmt1.Name = "spinTaxAmt1";
            this.spinTaxAmt1.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinTaxAmt1.Properties.Appearance.Options.UseFont = true;
            this.spinTaxAmt1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinTaxAmt1.Properties.DisplayFormat.FormatString = "n2";
            this.spinTaxAmt1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTaxAmt1.Properties.EditFormat.FormatString = "n2";
            this.spinTaxAmt1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTaxAmt1.Properties.Mask.EditMask = "n2";
            this.spinTaxAmt1.Properties.MaxValue = new decimal(new int[] {
            -1806942208,
            209547,
            0,
            0});
            this.spinTaxAmt1.Size = new System.Drawing.Size(110, 23);
            this.spinTaxAmt1.TabIndex = 6;
            this.spinTaxAmt1.EditValueChanged += new System.EventHandler(this.spinTaxAmt1_EditValueChanged);
            // 
            // spinTaxAmt2
            // 
            this.spinTaxAmt2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTaxAmt2.Enabled = false;
            this.spinTaxAmt2.EnterMoveNextControl = true;
            this.spinTaxAmt2.Location = new System.Drawing.Point(332, 35);
            this.spinTaxAmt2.Name = "spinTaxAmt2";
            this.spinTaxAmt2.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinTaxAmt2.Properties.Appearance.Options.UseFont = true;
            this.spinTaxAmt2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinTaxAmt2.Properties.DisplayFormat.FormatString = "n2";
            this.spinTaxAmt2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTaxAmt2.Properties.EditFormat.FormatString = "n2";
            this.spinTaxAmt2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTaxAmt2.Properties.Mask.EditMask = "n2";
            this.spinTaxAmt2.Properties.MaxValue = new decimal(new int[] {
            -1806942208,
            209547,
            0,
            0});
            this.spinTaxAmt2.Size = new System.Drawing.Size(110, 23);
            this.spinTaxAmt2.TabIndex = 7;
            this.spinTaxAmt2.EditValueChanged += new System.EventHandler(this.spinTaxAmt2_EditValueChanged);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSubTotal.Location = new System.Drawing.Point(6, 67);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(66, 17);
            this.lblSubTotal.TabIndex = 8;
            this.lblSubTotal.Text = "ქვე ჯამი:";
            // 
            // cboxSubTotal
            // 
            this.cboxSubTotal.EnterMoveNextControl = true;
            this.cboxSubTotal.Location = new System.Drawing.Point(130, 64);
            this.cboxSubTotal.Name = "cboxSubTotal";
            this.cboxSubTotal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxSubTotal.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxSubTotal.Properties.Appearance.Options.UseFont = true;
            this.cboxSubTotal.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxSubTotal.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxSubTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxSubTotal.Properties.Items.AddRange(new object[] {
            "",
            "=",
            ">",
            "<",
            "[ ]"});
            this.cboxSubTotal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxSubTotal.Size = new System.Drawing.Size(80, 23);
            this.cboxSubTotal.TabIndex = 9;
            this.cboxSubTotal.SelectedIndexChanged += new System.EventHandler(this.cboxSubTotal_SelectedIndexChanged);
            // 
            // spinSubTotal1
            // 
            this.spinSubTotal1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinSubTotal1.Enabled = false;
            this.spinSubTotal1.EnterMoveNextControl = true;
            this.spinSubTotal1.Location = new System.Drawing.Point(216, 64);
            this.spinSubTotal1.Name = "spinSubTotal1";
            this.spinSubTotal1.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinSubTotal1.Properties.Appearance.Options.UseFont = true;
            this.spinSubTotal1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinSubTotal1.Properties.DisplayFormat.FormatString = "n2";
            this.spinSubTotal1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSubTotal1.Properties.EditFormat.FormatString = "n2";
            this.spinSubTotal1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSubTotal1.Properties.Mask.EditMask = "n2";
            this.spinSubTotal1.Properties.MaxValue = new decimal(new int[] {
            -1806942208,
            209547,
            0,
            0});
            this.spinSubTotal1.Size = new System.Drawing.Size(110, 23);
            this.spinSubTotal1.TabIndex = 10;
            this.spinSubTotal1.EditValueChanged += new System.EventHandler(this.spinSubTotal1_EditValueChanged);
            // 
            // spinSubTotal2
            // 
            this.spinSubTotal2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinSubTotal2.Enabled = false;
            this.spinSubTotal2.EnterMoveNextControl = true;
            this.spinSubTotal2.Location = new System.Drawing.Point(332, 64);
            this.spinSubTotal2.Name = "spinSubTotal2";
            this.spinSubTotal2.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinSubTotal2.Properties.Appearance.Options.UseFont = true;
            this.spinSubTotal2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinSubTotal2.Properties.DisplayFormat.FormatString = "n2";
            this.spinSubTotal2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSubTotal2.Properties.EditFormat.FormatString = "n2";
            this.spinSubTotal2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSubTotal2.Properties.Mask.EditMask = "n2";
            this.spinSubTotal2.Properties.MaxValue = new decimal(new int[] {
            -1806942208,
            209547,
            0,
            0});
            this.spinSubTotal2.Size = new System.Drawing.Size(110, 23);
            this.spinSubTotal2.TabIndex = 11;
            this.spinSubTotal2.EditValueChanged += new System.EventHandler(this.spinSubTotal2_EditValueChanged);
            // 
            // lblTotalDue
            // 
            this.lblTotalDue.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalDue.Location = new System.Drawing.Point(451, 9);
            this.lblTotalDue.Name = "lblTotalDue";
            this.lblTotalDue.Size = new System.Drawing.Size(74, 17);
            this.lblTotalDue.TabIndex = 12;
            this.lblTotalDue.Text = "სულ ჯამი:";
            // 
            // cboxTotalDue
            // 
            this.cboxTotalDue.EnterMoveNextControl = true;
            this.cboxTotalDue.Location = new System.Drawing.Point(532, 6);
            this.cboxTotalDue.Name = "cboxTotalDue";
            this.cboxTotalDue.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxTotalDue.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxTotalDue.Properties.Appearance.Options.UseFont = true;
            this.cboxTotalDue.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxTotalDue.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxTotalDue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxTotalDue.Properties.Items.AddRange(new object[] {
            "",
            "=",
            ">",
            "<",
            "[ ]"});
            this.cboxTotalDue.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxTotalDue.Size = new System.Drawing.Size(80, 23);
            this.cboxTotalDue.TabIndex = 13;
            this.cboxTotalDue.SelectedIndexChanged += new System.EventHandler(this.cboxTotalDue_SelectedIndexChanged);
            // 
            // spinTotalDue1
            // 
            this.spinTotalDue1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTotalDue1.Enabled = false;
            this.spinTotalDue1.EnterMoveNextControl = true;
            this.spinTotalDue1.Location = new System.Drawing.Point(618, 6);
            this.spinTotalDue1.Name = "spinTotalDue1";
            this.spinTotalDue1.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinTotalDue1.Properties.Appearance.Options.UseFont = true;
            this.spinTotalDue1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinTotalDue1.Properties.DisplayFormat.FormatString = "n2";
            this.spinTotalDue1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTotalDue1.Properties.EditFormat.FormatString = "n2";
            this.spinTotalDue1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTotalDue1.Properties.Mask.EditMask = "n2";
            this.spinTotalDue1.Properties.MaxValue = new decimal(new int[] {
            -1806942208,
            209547,
            0,
            0});
            this.spinTotalDue1.Size = new System.Drawing.Size(110, 23);
            this.spinTotalDue1.TabIndex = 14;
            this.spinTotalDue1.EditValueChanged += new System.EventHandler(this.spinTotalDue1_EditValueChanged);
            // 
            // spinTotalDue2
            // 
            this.spinTotalDue2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTotalDue2.Enabled = false;
            this.spinTotalDue2.EnterMoveNextControl = true;
            this.spinTotalDue2.Location = new System.Drawing.Point(734, 6);
            this.spinTotalDue2.Name = "spinTotalDue2";
            this.spinTotalDue2.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinTotalDue2.Properties.Appearance.Options.UseFont = true;
            this.spinTotalDue2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinTotalDue2.Properties.DisplayFormat.FormatString = "n2";
            this.spinTotalDue2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTotalDue2.Properties.EditFormat.FormatString = "n2";
            this.spinTotalDue2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTotalDue2.Properties.Mask.EditMask = "n2";
            this.spinTotalDue2.Properties.MaxValue = new decimal(new int[] {
            -1806942208,
            209547,
            0,
            0});
            this.spinTotalDue2.Size = new System.Drawing.Size(110, 23);
            this.spinTotalDue2.TabIndex = 15;
            this.spinTotalDue2.EditValueChanged += new System.EventHandler(this.spinTotalDue2_EditValueChanged);
            // 
            // lblCurrency
            // 
            this.lblCurrency.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrency.Location = new System.Drawing.Point(451, 38);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(63, 17);
            this.lblCurrency.TabIndex = 16;
            this.lblCurrency.Text = "ვალუტა:";
            // 
            // lookCurrency
            // 
            this.lookCurrency.EnterMoveNextControl = true;
            this.lookCurrency.Location = new System.Drawing.Point(532, 35);
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
            this.lookCurrency.Size = new System.Drawing.Size(312, 23);
            this.lookCurrency.TabIndex = 17;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(451, 67);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(71, 17);
            this.lblPaymentMethod.TabIndex = 18;
            this.lblPaymentMethod.Text = "გად. მეთ:";
            // 
            // lookPaymentMethod
            // 
            this.lookPaymentMethod.EnterMoveNextControl = true;
            this.lookPaymentMethod.Location = new System.Drawing.Point(532, 64);
            this.lookPaymentMethod.Name = "lookPaymentMethod";
            this.lookPaymentMethod.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookPaymentMethod.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookPaymentMethod.Properties.Appearance.Options.UseFont = true;
            this.lookPaymentMethod.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookPaymentMethod.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookPaymentMethod.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookPaymentMethod.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lookPaymentMethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookPaymentMethod.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.lookPaymentMethod.Properties.DataSource = this.bsPaymentMethod;
            this.lookPaymentMethod.Properties.DisplayMember = "Caption";
            this.lookPaymentMethod.Properties.NullText = "";
            this.lookPaymentMethod.Properties.ShowHeader = false;
            this.lookPaymentMethod.Properties.SortColumnIndex = 2;
            this.lookPaymentMethod.Properties.ValueMember = "ID";
            this.lookPaymentMethod.Size = new System.Drawing.Size(312, 23);
            this.lookPaymentMethod.TabIndex = 19;
            // 
            // tabAdditional
            // 
            this.tabAdditional.Controls.Add(this.cboxRevisionNumber);
            this.tabAdditional.Controls.Add(this.lblRevisionNumber);
            this.tabAdditional.Controls.Add(this.spinRevisionNumber1);
            this.tabAdditional.Controls.Add(this.spinRevisionNumber2);
            this.tabAdditional.Name = "tabAdditional";
            this.tabAdditional.Size = new System.Drawing.Size(774, 142);
            this.tabAdditional.Text = "დამატებითი";
            // 
            // cboxRevisionNumber
            // 
            this.cboxRevisionNumber.EnterMoveNextControl = true;
            this.cboxRevisionNumber.Location = new System.Drawing.Point(130, 3);
            this.cboxRevisionNumber.Name = "cboxRevisionNumber";
            this.cboxRevisionNumber.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxRevisionNumber.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxRevisionNumber.Properties.Appearance.Options.UseFont = true;
            this.cboxRevisionNumber.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxRevisionNumber.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxRevisionNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxRevisionNumber.Properties.Items.AddRange(new object[] {
            "",
            "=",
            ">",
            "<",
            "[ ]"});
            this.cboxRevisionNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxRevisionNumber.Size = new System.Drawing.Size(80, 23);
            this.cboxRevisionNumber.TabIndex = 9;
            this.cboxRevisionNumber.SelectedIndexChanged += new System.EventHandler(this.cboxRevisionNumber_SelectedIndexChanged);
            // 
            // lblRevisionNumber
            // 
            this.lblRevisionNumber.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRevisionNumber.Location = new System.Drawing.Point(5, 6);
            this.lblRevisionNumber.Name = "lblRevisionNumber";
            this.lblRevisionNumber.Size = new System.Drawing.Size(119, 17);
            this.lblRevisionNumber.TabIndex = 8;
            this.lblRevisionNumber.Text = "შეცვლის რაოდ:";
            // 
            // spinRevisionNumber1
            // 
            this.spinRevisionNumber1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinRevisionNumber1.Enabled = false;
            this.spinRevisionNumber1.EnterMoveNextControl = true;
            this.spinRevisionNumber1.Location = new System.Drawing.Point(216, 3);
            this.spinRevisionNumber1.Name = "spinRevisionNumber1";
            this.spinRevisionNumber1.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinRevisionNumber1.Properties.Appearance.Options.UseFont = true;
            this.spinRevisionNumber1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinRevisionNumber1.Properties.DisplayFormat.FormatString = "N00";
            this.spinRevisionNumber1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinRevisionNumber1.Properties.EditFormat.FormatString = "f0";
            this.spinRevisionNumber1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinRevisionNumber1.Properties.IsFloatValue = false;
            this.spinRevisionNumber1.Properties.Mask.EditMask = "N00";
            this.spinRevisionNumber1.Properties.MaxValue = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.spinRevisionNumber1.Size = new System.Drawing.Size(110, 23);
            this.spinRevisionNumber1.TabIndex = 10;
            this.spinRevisionNumber1.EditValueChanged += new System.EventHandler(this.spinRevisionNumber1_EditValueChanged);
            // 
            // spinRevisionNumber2
            // 
            this.spinRevisionNumber2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinRevisionNumber2.Enabled = false;
            this.spinRevisionNumber2.EnterMoveNextControl = true;
            this.spinRevisionNumber2.Location = new System.Drawing.Point(332, 3);
            this.spinRevisionNumber2.Name = "spinRevisionNumber2";
            this.spinRevisionNumber2.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinRevisionNumber2.Properties.Appearance.Options.UseFont = true;
            this.spinRevisionNumber2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinRevisionNumber2.Properties.DisplayFormat.FormatString = "N00";
            this.spinRevisionNumber2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinRevisionNumber2.Properties.EditFormat.FormatString = "N00";
            this.spinRevisionNumber2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinRevisionNumber2.Properties.IsFloatValue = false;
            this.spinRevisionNumber2.Properties.Mask.EditMask = "N00";
            this.spinRevisionNumber2.Properties.MaxValue = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.spinRevisionNumber2.Size = new System.Drawing.Size(110, 23);
            this.spinRevisionNumber2.TabIndex = 11;
            this.spinRevisionNumber2.EditValueChanged += new System.EventHandler(this.spinRevisionNumber2_EditValueChanged);
            // 
            // miGenerateSales
            // 
            this.miGenerateSales.Caption = "გაყიდვის გენერირება";
            this.miGenerateSales.Id = 19;
            this.miGenerateSales.Name = "miGenerateSales";
            this.miGenerateSales.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.miGenerateSales_ItemClick);
            // 
            // frmPurchaseOrderBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "frmPurchaseOrderBrowse";
            this.ObjectName = Apothex.DataType.ObjectNames.PurchaseOrderHeader;
            this.OptionsBaseForm.IsPrintable = true;
            this.OptionsBaseForm.Text = "შესყიდვები";
            this.OptionsListForm.IsBlockable = false;
            this.OptionsListForm.IsSystemColumnsable = true;
            this.OptionsListForm.IsUnblockable = false;
            this.OptionsGrid.ColumnID = "PurchaseOrderID";
            this.OptionsGrid.ColumnStatusID = "Status";
            this.OptionsGrid.GridView = this.gridView;
            this.Text = "შესყიდვები";
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
            ((System.ComponentModel.ISupportInitialize)(this.bsPaymentMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOverheadNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxVendorID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbVendorID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxVendorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxOverheadNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVendorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.tabAmount.ResumeLayout(false);
            this.tabAmount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxFreight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinFreight1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinFreight2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxTaxAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTaxAmt1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTaxAmt2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxSubTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSubTotal1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSubTotal2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxTotalDue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalDue1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalDue2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookPaymentMethod.Properties)).EndInit();
            this.tabAdditional.ResumeLayout(false);
            this.tabAdditional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxRevisionNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinRevisionNumber1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinRevisionNumber2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.BindingSource bsBranch;
        private System.Windows.Forms.BindingSource bsCurrency;
        private System.Windows.Forms.BindingSource bsPaymentMethod;
        private DevExpress.XtraEditors.LabelControl lblVendorID;
        private DevExpress.XtraEditors.LookUpEdit lookBranch;
        private DevExpress.XtraEditors.LabelControl lblBranch;
        private DevExpress.XtraEditors.TextEdit txtOverheadNumber;
        private DevExpress.XtraEditors.LabelControl lblOverheadNumber;
        private Apothex.DataType.DS_Purchasing ds;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchName;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn colOverheadNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colVendorName;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxAmt;
        private DevExpress.XtraGrid.Columns.GridColumn colFreight;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalDue;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyRateID;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentMethodName;
        private DevExpress.XtraGrid.Columns.GridColumn colRevisionNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colApprover;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchID;
        private DevExpress.XtraGrid.Columns.GridColumn colVendorID;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentMethodID;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colApproverUserID;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage tabMain;
        private DevExpress.XtraTab.XtraTabPage tabAmount;
        private DevExpress.XtraEditors.ComboBoxEdit cboxOrderDate;
        private DevExpress.XtraEditors.DateEdit dateOrderDate2;
        private DevExpress.XtraEditors.DateEdit dateOrderDate1;
        private DevExpress.XtraEditors.LabelControl lblOrderDate;
        private DevExpress.XtraEditors.ComboBoxEdit cboxFreight;
        private DevExpress.XtraEditors.LookUpEdit lookCurrency;
        private DevExpress.XtraEditors.SpinEdit spinFreight2;
        private DevExpress.XtraEditors.SpinEdit spinFreight1;
        private DevExpress.XtraEditors.LabelControl lblCurrency;
        private DevExpress.XtraEditors.LabelControl lblFreight;
        private DevExpress.XtraEditors.ComboBoxEdit cboxTaxAmt;
        private DevExpress.XtraEditors.SpinEdit spinTaxAmt2;
        private DevExpress.XtraEditors.SpinEdit spinTaxAmt1;
        private DevExpress.XtraEditors.LabelControl lblTaxAmt;
        private DevExpress.XtraEditors.ComboBoxEdit cboxSubTotal;
        private DevExpress.XtraEditors.SpinEdit spinSubTotal2;
        private DevExpress.XtraEditors.SpinEdit spinSubTotal1;
        private DevExpress.XtraEditors.LabelControl lblSubTotal;
        private DevExpress.XtraEditors.ComboBoxEdit cboxTotalDue;
        private DevExpress.XtraEditors.SpinEdit spinTotalDue2;
        private DevExpress.XtraEditors.SpinEdit spinTotalDue1;
        private DevExpress.XtraEditors.LabelControl lblTotalDue;
        private DevExpress.XtraEditors.LookUpEdit lookPaymentMethod;
        private DevExpress.XtraEditors.LabelControl lblPaymentMethod;
        private DevExpress.XtraTab.XtraTabPage tabAdditional;
        private DevExpress.XtraEditors.ComboBoxEdit cboxRevisionNumber;
        private DevExpress.XtraEditors.LabelControl lblRevisionNumber;
        private DevExpress.XtraEditors.SpinEdit spinRevisionNumber1;
        private DevExpress.XtraEditors.SpinEdit spinRevisionNumber2;
        private DevExpress.XtraEditors.LabelControl lblOrderID;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.ComboBoxEdit cboxID;
        private DevExpress.XtraEditors.ComboBoxEdit cboxOverheadNumber;
        private DevExpress.XtraEditors.ComboBoxEdit cboxVendorName;
        private DevExpress.XtraEditors.TextEdit txtVendorName;
        private DevExpress.XtraEditors.LabelControl lblVendorName;
        private DevExpress.XtraEditors.ComboBoxEdit cboxVendorID;
        private Apothex.Windows.Forms.ButtonBrowse bbVendorID;
        private DevExpress.XtraBars.BarButtonItem miGenerateSales;
    }
}