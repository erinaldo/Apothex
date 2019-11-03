namespace Apothex.Production
{
    partial class frmProductDistributionBrowse
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductDistributionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromBranchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToBranchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxAmt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFreight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalDue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromBranchID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToBranchID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRevisionNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApproverUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ds = new Apothex.DataType.DS_ProductDistributionHeader();
            this.bsFromBranch = new System.Windows.Forms.BindingSource(this.components);
            this.bsToBranch = new System.Windows.Forms.BindingSource(this.components);
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabMain = new DevExpress.XtraTab.XtraTabPage();
            this.dateStartDate2 = new DevExpress.XtraEditors.DateEdit();
            this.dateStartDate1 = new DevExpress.XtraEditors.DateEdit();
            this.cboxStartDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblStartDate = new DevExpress.XtraEditors.LabelControl();
            this.lookToBranch = new DevExpress.XtraEditors.LookUpEdit();
            this.lblToBranch = new DevExpress.XtraEditors.LabelControl();
            this.lookFromBranch = new DevExpress.XtraEditors.LookUpEdit();
            this.lblBranch = new DevExpress.XtraEditors.LabelControl();
            this.txtProductDistributionID = new DevExpress.XtraEditors.TextEdit();
            this.lblProductDistributionID = new DevExpress.XtraEditors.LabelControl();
            this.tabAdditional = new DevExpress.XtraTab.XtraTabPage();
            this.cboxRevisionNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblRevisionNumber = new DevExpress.XtraEditors.LabelControl();
            this.spinRevisionNumber1 = new DevExpress.XtraEditors.SpinEdit();
            this.spinRevisionNumber2 = new DevExpress.XtraEditors.SpinEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.bsFromBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsToBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookToBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookFromBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductDistributionID.Properties)).BeginInit();
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
            this.bsGridControl.DataMember = "VW_ProductDistributionHeader";
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
            this.btnFilter.Location = new System.Drawing.Point(524, 114);
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
            this.colProductDistributionID,
            this.colFromBranchName,
            this.colToBranchName,
            this.colStartDate,
            this.colEndDate,
            this.colSubTotal,
            this.colTaxAmt,
            this.colFreight,
            this.colTotalDue,
            this.colCurrencyCode,
            this.colFromBranchID,
            this.colToBranchID,
            this.colRevisionNumber,
            this.colStatus,
            this.colModifiedUserID,
            this.colModifier,
            this.colModifiedDate,
            this.colApproverUserID,
            this.colApprover});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.LimeGreen;
            styleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = ((byte)(6));
            this.gridView.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", this.colTotalDue, "{0:n2}")});
            this.gridView.Name = "gridView";
            // 
            // colProductDistributionID
            // 
            this.colProductDistributionID.Caption = "დისტრიბუციის №";
            this.colProductDistributionID.FieldName = "ProductDistributionID";
            this.colProductDistributionID.Name = "colProductDistributionID";
            this.colProductDistributionID.Visible = true;
            this.colProductDistributionID.VisibleIndex = 0;
            // 
            // colFromBranchName
            // 
            this.colFromBranchName.Caption = "ფილიალიდან";
            this.colFromBranchName.FieldName = "FromBranchName";
            this.colFromBranchName.Name = "colFromBranchName";
            this.colFromBranchName.Visible = true;
            this.colFromBranchName.VisibleIndex = 1;
            // 
            // colToBranchName
            // 
            this.colToBranchName.Caption = "ფილიალში";
            this.colToBranchName.FieldName = "ToBranchName";
            this.colToBranchName.Name = "colToBranchName";
            this.colToBranchName.Visible = true;
            this.colToBranchName.VisibleIndex = 2;
            // 
            // colStartDate
            // 
            this.colStartDate.Caption = "დაწყების თარიღი";
            this.colStartDate.DisplayFormat.FormatString = "G";
            this.colStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 3;
            // 
            // colEndDate
            // 
            this.colEndDate.Caption = "დასრულების თარიღი";
            this.colEndDate.DisplayFormat.FormatString = "G";
            this.colEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 4;
            // 
            // colSubTotal
            // 
            this.colSubTotal.Caption = "ქვეჯამი";
            this.colSubTotal.DisplayFormat.FormatString = "n2";
            this.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubTotal.FieldName = "SubTotal";
            this.colSubTotal.GroupFormat.FormatString = "n2";
            this.colSubTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.Visible = true;
            this.colSubTotal.VisibleIndex = 5;
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
            this.colTaxAmt.VisibleIndex = 6;
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
            this.colFreight.VisibleIndex = 7;
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
            this.colTotalDue.VisibleIndex = 8;
            // 
            // colCurrencyCode
            // 
            this.colCurrencyCode.Caption = "ვალუტა";
            this.colCurrencyCode.FieldName = "CurrencyCode";
            this.colCurrencyCode.Name = "colCurrencyCode";
            this.colCurrencyCode.Visible = true;
            this.colCurrencyCode.VisibleIndex = 9;
            // 
            // colFromBranchID
            // 
            this.colFromBranchID.FieldName = "FromBranchID";
            this.colFromBranchID.Name = "colFromBranchID";
            // 
            // colToBranchID
            // 
            this.colToBranchID.FieldName = "ToBranchID";
            this.colToBranchID.Name = "colToBranchID";
            // 
            // colRevisionNumber
            // 
            this.colRevisionNumber.Caption = "შეცვლის რაოდ.";
            this.colRevisionNumber.FieldName = "RevisionNumber";
            this.colRevisionNumber.Name = "colRevisionNumber";
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
            this.xtraTabControl.Size = new System.Drawing.Size(780, 171);
            this.xtraTabControl.TabIndex = 0;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabMain,
            this.tabAdditional});
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.dateStartDate2);
            this.tabMain.Controls.Add(this.dateStartDate1);
            this.tabMain.Controls.Add(this.cboxStartDate);
            this.tabMain.Controls.Add(this.lblStartDate);
            this.tabMain.Controls.Add(this.lookToBranch);
            this.tabMain.Controls.Add(this.lblToBranch);
            this.tabMain.Controls.Add(this.lookFromBranch);
            this.tabMain.Controls.Add(this.lblBranch);
            this.tabMain.Controls.Add(this.txtProductDistributionID);
            this.tabMain.Controls.Add(this.lblProductDistributionID);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(774, 142);
            this.tabMain.Text = "მთავარი";
            // 
            // dateStartDate2
            // 
            this.dateStartDate2.EditValue = null;
            this.dateStartDate2.Enabled = false;
            this.dateStartDate2.EnterMoveNextControl = true;
            this.dateStartDate2.Location = new System.Drawing.Point(363, 93);
            this.dateStartDate2.Name = "dateStartDate2";
            this.dateStartDate2.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateStartDate2.Properties.Appearance.Options.UseFont = true;
            this.dateStartDate2.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateStartDate2.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dateStartDate2.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateStartDate2.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.dateStartDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStartDate2.Properties.DisplayFormat.FormatString = "G";
            this.dateStartDate2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStartDate2.Properties.EditFormat.FormatString = "G";
            this.dateStartDate2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStartDate2.Properties.Mask.EditMask = "G";
            this.dateStartDate2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateStartDate2.Size = new System.Drawing.Size(150, 23);
            this.dateStartDate2.TabIndex = 9;
            this.dateStartDate2.EditValueChanged += new System.EventHandler(this.dateStartDate2_EditValueChanged);
            // 
            // dateStartDate1
            // 
            this.dateStartDate1.EditValue = null;
            this.dateStartDate1.Enabled = false;
            this.dateStartDate1.EnterMoveNextControl = true;
            this.dateStartDate1.Location = new System.Drawing.Point(207, 93);
            this.dateStartDate1.Name = "dateStartDate1";
            this.dateStartDate1.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateStartDate1.Properties.Appearance.Options.UseFont = true;
            this.dateStartDate1.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateStartDate1.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dateStartDate1.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateStartDate1.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.dateStartDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStartDate1.Properties.DisplayFormat.FormatString = "G";
            this.dateStartDate1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStartDate1.Properties.EditFormat.FormatString = "G";
            this.dateStartDate1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStartDate1.Properties.Mask.EditMask = "G";
            this.dateStartDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateStartDate1.Size = new System.Drawing.Size(150, 23);
            this.dateStartDate1.TabIndex = 8;
            this.dateStartDate1.EditValueChanged += new System.EventHandler(this.dateStartDate1_EditValueChanged);
            // 
            // cboxStartDate
            // 
            this.cboxStartDate.EnterMoveNextControl = true;
            this.cboxStartDate.Location = new System.Drawing.Point(121, 93);
            this.cboxStartDate.Name = "cboxStartDate";
            this.cboxStartDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxStartDate.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxStartDate.Properties.Appearance.Options.UseFont = true;
            this.cboxStartDate.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxStartDate.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxStartDate.Properties.Items.AddRange(new object[] {
            "",
            "=",
            ">",
            "<",
            "[ ]"});
            this.cboxStartDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxStartDate.Size = new System.Drawing.Size(80, 23);
            this.cboxStartDate.TabIndex = 7;
            this.cboxStartDate.SelectedIndexChanged += new System.EventHandler(this.cboxStartDate_SelectedIndexChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStartDate.Location = new System.Drawing.Point(6, 96);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(65, 17);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "თარიღი:";
            // 
            // lookToBranch
            // 
            this.lookToBranch.EnterMoveNextControl = true;
            this.lookToBranch.Location = new System.Drawing.Point(121, 64);
            this.lookToBranch.Name = "lookToBranch";
            this.lookToBranch.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookToBranch.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookToBranch.Properties.Appearance.Options.UseFont = true;
            this.lookToBranch.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookToBranch.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookToBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookToBranch.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.lookToBranch.Properties.DataSource = this.bsToBranch;
            this.lookToBranch.Properties.DisplayMember = "Caption";
            this.lookToBranch.Properties.NullText = "";
            this.lookToBranch.Properties.ShowHeader = false;
            this.lookToBranch.Properties.ValueMember = "ID";
            this.lookToBranch.Size = new System.Drawing.Size(392, 23);
            this.lookToBranch.TabIndex = 5;
            // 
            // lblToBranch
            // 
            this.lblToBranch.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblToBranch.Location = new System.Drawing.Point(6, 67);
            this.lblToBranch.Name = "lblToBranch";
            this.lblToBranch.Size = new System.Drawing.Size(89, 17);
            this.lblToBranch.TabIndex = 4;
            this.lblToBranch.Text = "ფილიალში:";
            // 
            // lookFromBranch
            // 
            this.lookFromBranch.EnterMoveNextControl = true;
            this.lookFromBranch.Location = new System.Drawing.Point(121, 35);
            this.lookFromBranch.Name = "lookFromBranch";
            this.lookFromBranch.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookFromBranch.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookFromBranch.Properties.Appearance.Options.UseFont = true;
            this.lookFromBranch.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookFromBranch.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookFromBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookFromBranch.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.lookFromBranch.Properties.DataSource = this.bsFromBranch;
            this.lookFromBranch.Properties.DisplayMember = "Caption";
            this.lookFromBranch.Properties.NullText = "";
            this.lookFromBranch.Properties.ShowHeader = false;
            this.lookFromBranch.Properties.ValueMember = "ID";
            this.lookFromBranch.Size = new System.Drawing.Size(392, 23);
            this.lookFromBranch.TabIndex = 3;
            // 
            // lblBranch
            // 
            this.lblBranch.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBranch.Location = new System.Drawing.Point(6, 38);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(109, 17);
            this.lblBranch.TabIndex = 2;
            this.lblBranch.Text = "ფილიალიდან:";
            // 
            // txtProductDistributionID
            // 
            this.txtProductDistributionID.EnterMoveNextControl = true;
            this.txtProductDistributionID.Location = new System.Drawing.Point(121, 6);
            this.txtProductDistributionID.Name = "txtProductDistributionID";
            this.txtProductDistributionID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProductDistributionID.Properties.Appearance.Options.UseFont = true;
            this.txtProductDistributionID.Properties.DisplayFormat.FormatString = "f0";
            this.txtProductDistributionID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtProductDistributionID.Properties.EditFormat.FormatString = "f0";
            this.txtProductDistributionID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtProductDistributionID.Properties.Mask.EditMask = "\\d{0,10}";
            this.txtProductDistributionID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtProductDistributionID.Properties.MaxLength = 10;
            this.txtProductDistributionID.Size = new System.Drawing.Size(196, 23);
            this.txtProductDistributionID.TabIndex = 1;
            // 
            // lblProductDistributionID
            // 
            this.lblProductDistributionID.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductDistributionID.Location = new System.Drawing.Point(6, 9);
            this.lblProductDistributionID.Name = "lblProductDistributionID";
            this.lblProductDistributionID.Size = new System.Drawing.Size(20, 17);
            this.lblProductDistributionID.TabIndex = 0;
            this.lblProductDistributionID.Text = "№:";
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
            this.cboxRevisionNumber.Location = new System.Drawing.Point(133, 3);
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
            this.lblRevisionNumber.Location = new System.Drawing.Point(8, 6);
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
            this.spinRevisionNumber1.Location = new System.Drawing.Point(219, 3);
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
            this.spinRevisionNumber2.Location = new System.Drawing.Point(335, 3);
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
            // frmProductDistributionBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "frmProductDistributionBrowse";
            this.ObjectName = Apothex.DataType.ObjectNames.ProductDistributionHeader;
            this.OptionsBaseForm.Text = "შიდა გადაცემები";
            this.OptionsListForm.IsBlockable = false;
            this.OptionsListForm.IsDisapprovable = false;
            this.OptionsListForm.IsSystemColumnsable = true;
            this.OptionsListForm.IsUnblockable = false;
            this.OptionsGrid.ColumnID = "ProductDistributionID";
            this.OptionsGrid.ColumnStatusID = "Status";
            this.OptionsGrid.GridView = this.gridView;
            this.Text = "შიდა გადაცემები";
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
            ((System.ComponentModel.ISupportInitialize)(this.bsFromBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsToBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookToBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookFromBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductDistributionID.Properties)).EndInit();
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
        private Apothex.DataType.DS_ProductDistributionHeader ds;
        private DevExpress.XtraGrid.Columns.GridColumn colFromBranchName;
        private DevExpress.XtraGrid.Columns.GridColumn colToBranchName;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colProductDistributionID;
        private DevExpress.XtraGrid.Columns.GridColumn colFromBranchID;
        private DevExpress.XtraGrid.Columns.GridColumn colToBranchID;
        private DevExpress.XtraGrid.Columns.GridColumn colRevisionNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colApproverUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colApprover;
        private System.Windows.Forms.BindingSource bsFromBranch;
        private System.Windows.Forms.BindingSource bsToBranch;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage tabMain;
        private DevExpress.XtraEditors.DateEdit dateStartDate2;
        private DevExpress.XtraEditors.DateEdit dateStartDate1;
        private DevExpress.XtraEditors.ComboBoxEdit cboxStartDate;
        private DevExpress.XtraEditors.LabelControl lblStartDate;
        private DevExpress.XtraEditors.LookUpEdit lookFromBranch;
        private DevExpress.XtraEditors.LabelControl lblBranch;
        private DevExpress.XtraEditors.TextEdit txtProductDistributionID;
        private DevExpress.XtraEditors.LabelControl lblProductDistributionID;
        private DevExpress.XtraTab.XtraTabPage tabAdditional;
        private DevExpress.XtraEditors.ComboBoxEdit cboxRevisionNumber;
        private DevExpress.XtraEditors.LabelControl lblRevisionNumber;
        private DevExpress.XtraEditors.SpinEdit spinRevisionNumber1;
        private DevExpress.XtraEditors.SpinEdit spinRevisionNumber2;
        private DevExpress.XtraEditors.LookUpEdit lookToBranch;
        private DevExpress.XtraEditors.LabelControl lblToBranch;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxAmt;
        private DevExpress.XtraGrid.Columns.GridColumn colFreight;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalDue;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyCode;
    }
}