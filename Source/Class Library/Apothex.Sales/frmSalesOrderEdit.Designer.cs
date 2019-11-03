namespace Apothex.Sales
{
    partial class frmSalesOrderEdit
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.col_ResidualQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riOpAmount = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.bsDetail = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Sales = new Apothex.DataType.DS_Sales();
            this.bsCurrency = new System.Windows.Forms.BindingSource(this.components);
            this.bsHeader = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Hedgehog = new Apothex.DataType.DS_Hedgehog();
            this.tabInfo = new DevExpress.XtraTab.XtraTabPage();
            this.bbBranch = new Apothex.Windows.Forms.ButtonBrowse();
            this.spinRevisionNumber = new DevExpress.XtraEditors.SpinEdit();
            this.lblRevisionNumber = new DevExpress.XtraEditors.LabelControl();
            this.bbApprover = new Apothex.Windows.Forms.ButtonBrowse();
            this.bbModifier = new Apothex.Windows.Forms.ButtonBrowse();
            this.lblBranch = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblApprover = new DevExpress.XtraEditors.LabelControl();
            this.dateModifiedDate = new DevExpress.XtraEditors.DateEdit();
            this.lblModifier = new DevExpress.XtraEditors.LabelControl();
            this.lblModifiedDate = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.tabCard = new DevExpress.XtraTab.XtraTabPage();
            this.beCard = new DevExpress.XtraEditors.ButtonEdit();
            this.btnGetCardInfo = new DevExpress.XtraEditors.SimpleButton();
            this.gridCard = new DevExpress.XtraGrid.GridControl();
            this.viewCard = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCardInfoName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardInfoValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblCard = new DevExpress.XtraEditors.LabelControl();
            this.tabAdditional = new DevExpress.XtraTab.XtraTabPage();
            this.chkSaleStandardCost = new DevExpress.XtraEditors.CheckEdit();
            this.bbCustomer = new Apothex.Windows.Forms.ButtonBrowse();
            this.txtHedgehog = new DevExpress.XtraEditors.TextEdit();
            this.grpComment = new DevExpress.XtraEditors.GroupControl();
            this.memoComment = new DevExpress.XtraEditors.MemoEdit();
            this.chkHedgehog = new DevExpress.XtraEditors.CheckEdit();
            this.txtOverheadNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblOverheadNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblHedgehog = new DevExpress.XtraEditors.LabelControl();
            this.lblCompany = new DevExpress.XtraEditors.LabelControl();
            this.tabMain = new DevExpress.XtraTab.XtraTabPage();
            this.pnlMainFill = new DevExpress.XtraEditors.PanelControl();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.view = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOrdinalNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riShort = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colMedicamentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitsInStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riUnitPrice = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colSaleQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinSaleQty = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.col_SaleUnitQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSaleUnitQty = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colUnitPriceDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riUnitPriceDiscount = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colLineTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValidDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductLocationID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSaleUnitPriceDiscount = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.pnlMainTop = new DevExpress.XtraEditors.PanelControl();
            this.spinDiscountPct = new DevExpress.XtraEditors.SpinEdit();
            this.lblDiscountPct = new DevExpress.XtraEditors.LabelControl();
            this.btnCalculator = new DevExpress.XtraEditors.SimpleButton();
            this.lookPaymentMethod = new DevExpress.XtraEditors.LookUpEdit();
            this.lookCurrency = new DevExpress.XtraEditors.LookUpEdit();
            this.spinFreight = new DevExpress.XtraEditors.SpinEdit();
            this.spinTaxAmt = new DevExpress.XtraEditors.SpinEdit();
            this.lblPaymentMethod = new DevExpress.XtraEditors.LabelControl();
            this.spinSubTotal = new DevExpress.XtraEditors.SpinEdit();
            this.lblFreight = new DevExpress.XtraEditors.LabelControl();
            this.spinTotalDue = new DevExpress.XtraEditors.SpinEdit();
            this.lblTaxAmt = new DevExpress.XtraEditors.LabelControl();
            this.dateOrderDate = new DevExpress.XtraEditors.DateEdit();
            this.lblCurrency = new DevExpress.XtraEditors.LabelControl();
            this.lblSubTotal = new DevExpress.XtraEditors.LabelControl();
            this.txtSalesOrderID = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalDue = new DevExpress.XtraEditors.LabelControl();
            this.lblOrderDate = new DevExpress.XtraEditors.LabelControl();
            this.lblPurchaseID = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabOperation = new DevExpress.XtraTab.XtraTabPage();
            this.gridOperation = new DevExpress.XtraGrid.GridControl();
            this.bsOperation = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Operation = new Apothex.DataType.DS_Operation();
            this.viewOperation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOpTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riOpType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riOpAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Hedgehog)).BeginInit();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinRevisionNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbApprover.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbModifier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifiedDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifiedDate.Properties)).BeginInit();
            this.tabCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beCard.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCard)).BeginInit();
            this.tabAdditional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkSaleStandardCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHedgehog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpComment)).BeginInit();
            this.grpComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkHedgehog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOverheadNumber.Properties)).BeginInit();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainFill)).BeginInit();
            this.pnlMainFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riShort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSaleQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSaleUnitQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riUnitPriceDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSaleUnitPriceDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainTop)).BeginInit();
            this.pnlMainTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDiscountPct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookPaymentMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinFreight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTaxAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSubTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalDue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalesOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.tabOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Operation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riOpType)).BeginInit();
            this.SuspendLayout();
            // 
            // col_ResidualQty
            // 
            this.col_ResidualQty.Caption = "ნაშთი";
            this.col_ResidualQty.DisplayFormat.FormatString = "n4";
            this.col_ResidualQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_ResidualQty.FieldName = "_ResidualQty";
            this.col_ResidualQty.Name = "col_ResidualQty";
            this.col_ResidualQty.OptionsColumn.AllowEdit = false;
            this.col_ResidualQty.Visible = true;
            this.col_ResidualQty.VisibleIndex = 3;
            // 
            // colOpAmount
            // 
            this.colOpAmount.Caption = "თანხა";
            this.colOpAmount.ColumnEdit = this.riOpAmount;
            this.colOpAmount.DisplayFormat.FormatString = "n2";
            this.colOpAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOpAmount.FieldName = "Amount";
            this.colOpAmount.GroupFormat.FormatString = "n2";
            this.colOpAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOpAmount.Name = "colOpAmount";
            this.colOpAmount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colOpAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colOpAmount.Visible = true;
            this.colOpAmount.VisibleIndex = 0;
            // 
            // riOpAmount
            // 
            this.riOpAmount.AutoHeight = false;
            this.riOpAmount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.riOpAmount.DisplayFormat.FormatString = "n2";
            this.riOpAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riOpAmount.EditFormat.FormatString = "n2";
            this.riOpAmount.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riOpAmount.Mask.EditMask = "n2";
            this.riOpAmount.MaxValue = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.riOpAmount.Name = "riOpAmount";
            // 
            // bsDetail
            // 
            this.bsDetail.DataMember = "SP_GetSalesOrderDetail";
            this.bsDetail.DataSource = this.ds_Sales;
            // 
            // ds_Sales
            // 
            this.ds_Sales.DataSetName = "DS_Sales";
            this.ds_Sales.Locale = new System.Globalization.CultureInfo("");
            this.ds_Sales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ds_Hedgehog
            // 
            this.ds_Hedgehog.DataSetName = "DS_Hedgehog";
            this.ds_Hedgehog.Locale = new System.Globalization.CultureInfo("");
            this.ds_Hedgehog.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.bbBranch);
            this.tabInfo.Controls.Add(this.spinRevisionNumber);
            this.tabInfo.Controls.Add(this.lblRevisionNumber);
            this.tabInfo.Controls.Add(this.bbApprover);
            this.tabInfo.Controls.Add(this.bbModifier);
            this.tabInfo.Controls.Add(this.lblBranch);
            this.tabInfo.Controls.Add(this.txtID);
            this.tabInfo.Controls.Add(this.lblApprover);
            this.tabInfo.Controls.Add(this.dateModifiedDate);
            this.tabInfo.Controls.Add(this.lblModifier);
            this.tabInfo.Controls.Add(this.lblModifiedDate);
            this.tabInfo.Controls.Add(this.lblID);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Size = new System.Drawing.Size(778, 494);
            this.tabInfo.Text = "ინფორმაცია";
            // 
            // bbBranch
            // 
            this.bbBranch.EnterMoveNextControl = true;
            this.bbBranch.IsOnline = true;
            this.bbBranch.Location = new System.Drawing.Point(149, 123);
            this.bbBranch.MenuManager = this.barManager;
            this.bbBranch.Name = "bbBranch";
            this.bbBranch.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F);
            this.bbBranch.Properties.Appearance.Options.UseFont = true;
            this.bbBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject2, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject3, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbBranch.Size = new System.Drawing.Size(300, 23);
            this.bbBranch.TabIndex = 9;
            this.bbBranch.TableName = Apothex.DataType.ObjectNames.Branch;
            // 
            // spinRevisionNumber
            // 
            this.spinRevisionNumber.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinRevisionNumber.EnterMoveNextControl = true;
            this.spinRevisionNumber.Location = new System.Drawing.Point(149, 151);
            this.spinRevisionNumber.Name = "spinRevisionNumber";
            this.spinRevisionNumber.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinRevisionNumber.Properties.Appearance.Options.UseFont = true;
            this.spinRevisionNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinRevisionNumber.Properties.DisplayFormat.FormatString = "N00";
            this.spinRevisionNumber.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinRevisionNumber.Properties.EditFormat.FormatString = "N00";
            this.spinRevisionNumber.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinRevisionNumber.Properties.IsFloatValue = false;
            this.spinRevisionNumber.Properties.Mask.EditMask = "N00";
            this.spinRevisionNumber.Properties.MaxValue = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.spinRevisionNumber.Properties.ReadOnly = true;
            this.spinRevisionNumber.Size = new System.Drawing.Size(150, 23);
            this.spinRevisionNumber.TabIndex = 15;
            // 
            // lblRevisionNumber
            // 
            this.lblRevisionNumber.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRevisionNumber.Location = new System.Drawing.Point(6, 154);
            this.lblRevisionNumber.Name = "lblRevisionNumber";
            this.lblRevisionNumber.Size = new System.Drawing.Size(94, 17);
            this.lblRevisionNumber.TabIndex = 14;
            this.lblRevisionNumber.Text = "შეცვლილია:";
            // 
            // bbApprover
            // 
            this.bbApprover.EnterMoveNextControl = true;
            this.bbApprover.IsOnline = true;
            this.bbApprover.Location = new System.Drawing.Point(149, 93);
            this.bbApprover.Name = "bbApprover";
            this.bbApprover.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bbApprover.Properties.Appearance.Options.UseFont = true;
            this.bbApprover.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bbApprover.Properties.ReadOnly = true;
            this.bbApprover.Size = new System.Drawing.Size(300, 23);
            this.bbApprover.TabIndex = 7;
            this.bbApprover.TableName = Apothex.DataType.ObjectNames.User;
            // 
            // bbModifier
            // 
            this.bbModifier.EnterMoveNextControl = true;
            this.bbModifier.IsOnline = true;
            this.bbModifier.Location = new System.Drawing.Point(149, 65);
            this.bbModifier.Name = "bbModifier";
            this.bbModifier.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bbModifier.Properties.Appearance.Options.UseFont = true;
            this.bbModifier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bbModifier.Properties.ReadOnly = true;
            this.bbModifier.Size = new System.Drawing.Size(300, 23);
            this.bbModifier.TabIndex = 5;
            this.bbModifier.TableName = Apothex.DataType.ObjectNames.User;
            // 
            // lblBranch
            // 
            this.lblBranch.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBranch.Location = new System.Drawing.Point(6, 126);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(81, 17);
            this.lblBranch.TabIndex = 8;
            this.lblBranch.Text = "ფილიალი:";
            // 
            // txtID
            // 
            this.txtID.EnterMoveNextControl = true;
            this.txtID.Location = new System.Drawing.Point(149, 6);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(300, 23);
            this.txtID.TabIndex = 1;
            // 
            // lblApprover
            // 
            this.lblApprover.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblApprover.Location = new System.Drawing.Point(6, 97);
            this.lblApprover.Name = "lblApprover";
            this.lblApprover.Size = new System.Drawing.Size(77, 17);
            this.lblApprover.TabIndex = 6;
            this.lblApprover.Text = "დაამოწმა:";
            // 
            // dateModifiedDate
            // 
            this.dateModifiedDate.EditValue = null;
            this.dateModifiedDate.EnterMoveNextControl = true;
            this.dateModifiedDate.Location = new System.Drawing.Point(149, 35);
            this.dateModifiedDate.Name = "dateModifiedDate";
            this.dateModifiedDate.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateModifiedDate.Properties.Appearance.Options.UseFont = true;
            this.dateModifiedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateModifiedDate.Properties.DisplayFormat.FormatString = "G";
            this.dateModifiedDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateModifiedDate.Properties.EditFormat.FormatString = "G";
            this.dateModifiedDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateModifiedDate.Properties.Mask.EditMask = "G";
            this.dateModifiedDate.Properties.ReadOnly = true;
            this.dateModifiedDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateModifiedDate.Size = new System.Drawing.Size(150, 23);
            this.dateModifiedDate.TabIndex = 3;
            // 
            // lblModifier
            // 
            this.lblModifier.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblModifier.Location = new System.Drawing.Point(6, 68);
            this.lblModifier.Name = "lblModifier";
            this.lblModifier.Size = new System.Drawing.Size(70, 17);
            this.lblModifier.TabIndex = 4;
            this.lblModifier.Text = "შეცვალა:";
            // 
            // lblModifiedDate
            // 
            this.lblModifiedDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblModifiedDate.Location = new System.Drawing.Point(6, 38);
            this.lblModifiedDate.Name = "lblModifiedDate";
            this.lblModifiedDate.Size = new System.Drawing.Size(65, 17);
            this.lblModifiedDate.TabIndex = 2;
            this.lblModifiedDate.Text = "თარიღი:";
            // 
            // lblID
            // 
            this.lblID.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblID.Location = new System.Drawing.Point(6, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // tabCard
            // 
            this.tabCard.Controls.Add(this.beCard);
            this.tabCard.Controls.Add(this.btnGetCardInfo);
            this.tabCard.Controls.Add(this.gridCard);
            this.tabCard.Controls.Add(this.lblCard);
            this.tabCard.Name = "tabCard";
            this.tabCard.Size = new System.Drawing.Size(778, 494);
            this.tabCard.Text = "ბარათი";
            // 
            // beCard
            // 
            this.beCard.Location = new System.Drawing.Point(76, 6);
            this.beCard.MenuManager = this.barManager;
            this.beCard.Name = "beCard";
            this.beCard.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beCard.Properties.Appearance.Options.UseFont = true;
            this.beCard.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Up),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.beCard.Properties.ReadOnly = true;
            this.beCard.Size = new System.Drawing.Size(204, 26);
            this.beCard.TabIndex = 4;
            this.beCard.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beCard_ButtonClick);
            // 
            // btnGetCardInfo
            // 
            this.btnGetCardInfo.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetCardInfo.Appearance.Options.UseFont = true;
            this.btnGetCardInfo.Appearance.Options.UseTextOptions = true;
            this.btnGetCardInfo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnGetCardInfo.Location = new System.Drawing.Point(286, 5);
            this.btnGetCardInfo.Name = "btnGetCardInfo";
            this.btnGetCardInfo.Size = new System.Drawing.Size(170, 27);
            this.btnGetCardInfo.TabIndex = 2;
            this.btnGetCardInfo.Text = "ინფორმაციის ამოღება";
            this.btnGetCardInfo.Click += new System.EventHandler(this.btnGetCardInfo_Click);
            // 
            // gridCard
            // 
            this.gridCard.Location = new System.Drawing.Point(6, 38);
            this.gridCard.MainView = this.viewCard;
            this.gridCard.MenuManager = this.barManager;
            this.gridCard.Name = "gridCard";
            this.gridCard.Size = new System.Drawing.Size(450, 200);
            this.gridCard.TabIndex = 3;
            this.gridCard.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewCard});
            // 
            // viewCard
            // 
            this.viewCard.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCardInfoName,
            this.colCardInfoValue});
            this.viewCard.GridControl = this.gridCard;
            this.viewCard.Name = "viewCard";
            this.viewCard.OptionsBehavior.Editable = false;
            this.viewCard.OptionsCustomization.AllowGroup = false;
            this.viewCard.OptionsCustomization.AllowSort = false;
            this.viewCard.OptionsMenu.EnableColumnMenu = false;
            this.viewCard.OptionsMenu.EnableFooterMenu = false;
            this.viewCard.OptionsMenu.EnableGroupPanelMenu = false;
            this.viewCard.OptionsView.ShowGroupPanel = false;
            // 
            // colCardInfoName
            // 
            this.colCardInfoName.Caption = "დასახელება";
            this.colCardInfoName.FieldName = "Name";
            this.colCardInfoName.Name = "colCardInfoName";
            this.colCardInfoName.Visible = true;
            this.colCardInfoName.VisibleIndex = 0;
            // 
            // colCardInfoValue
            // 
            this.colCardInfoValue.Caption = "მნიშვნელობა";
            this.colCardInfoValue.FieldName = "Value";
            this.colCardInfoValue.Name = "colCardInfoValue";
            this.colCardInfoValue.Visible = true;
            this.colCardInfoValue.VisibleIndex = 1;
            // 
            // lblCard
            // 
            this.lblCard.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCard.Location = new System.Drawing.Point(6, 13);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(61, 17);
            this.lblCard.TabIndex = 0;
            this.lblCard.Text = "ბარათი:";
            // 
            // tabAdditional
            // 
            this.tabAdditional.Controls.Add(this.chkSaleStandardCost);
            this.tabAdditional.Controls.Add(this.bbCustomer);
            this.tabAdditional.Controls.Add(this.txtHedgehog);
            this.tabAdditional.Controls.Add(this.grpComment);
            this.tabAdditional.Controls.Add(this.chkHedgehog);
            this.tabAdditional.Controls.Add(this.txtOverheadNumber);
            this.tabAdditional.Controls.Add(this.lblOverheadNumber);
            this.tabAdditional.Controls.Add(this.lblHedgehog);
            this.tabAdditional.Controls.Add(this.lblCompany);
            this.tabAdditional.Name = "tabAdditional";
            this.tabAdditional.Size = new System.Drawing.Size(778, 494);
            this.tabAdditional.Text = "დამატებითი";
            // 
            // chkSaleStandardCost
            // 
            this.chkSaleStandardCost.Location = new System.Drawing.Point(123, 64);
            this.chkSaleStandardCost.MenuManager = this.barManager;
            this.chkSaleStandardCost.Name = "chkSaleStandardCost";
            this.chkSaleStandardCost.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkSaleStandardCost.Properties.Appearance.Options.UseFont = true;
            this.chkSaleStandardCost.Properties.Caption = "თვითღირებულებაში გაყიდვა";
            this.chkSaleStandardCost.Size = new System.Drawing.Size(302, 22);
            this.chkSaleStandardCost.TabIndex = 4;
            this.chkSaleStandardCost.CheckedChanged += new System.EventHandler(this.chkSaleStandardCost_CheckedChanged);
            // 
            // bbCustomer
            // 
            this.bbCustomer.EnterMoveNextControl = true;
            this.bbCustomer.IsOnline = true;
            this.bbCustomer.Location = new System.Drawing.Point(125, 35);
            this.bbCustomer.MenuManager = this.barManager;
            this.bbCustomer.Name = "bbCustomer";
            this.bbCustomer.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F);
            this.bbCustomer.Properties.Appearance.Options.UseFont = true;
            this.bbCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject4, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject5, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbCustomer.Size = new System.Drawing.Size(300, 23);
            this.bbCustomer.TabIndex = 3;
            this.bbCustomer.TableName = Apothex.DataType.ObjectNames.Company;
            this.bbCustomer.PrimaryKeyChanged += new System.EventHandler(this.bbCustomer_PrimaryKeyChanged);
            // 
            // txtHedgehog
            // 
            this.txtHedgehog.Location = new System.Drawing.Point(540, 6);
            this.txtHedgehog.Name = "txtHedgehog";
            this.txtHedgehog.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtHedgehog.Properties.Appearance.Options.UseFont = true;
            this.txtHedgehog.Properties.Mask.EditMask = "[0-9A-Za-Z]{0,100}";
            this.txtHedgehog.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtHedgehog.Properties.MaxLength = 100;
            this.txtHedgehog.Size = new System.Drawing.Size(250, 23);
            this.txtHedgehog.TabIndex = 8;
            // 
            // grpComment
            // 
            this.grpComment.AppearanceCaption.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpComment.AppearanceCaption.Options.UseFont = true;
            this.grpComment.Controls.Add(this.memoComment);
            this.grpComment.Location = new System.Drawing.Point(3, 92);
            this.grpComment.Name = "grpComment";
            this.grpComment.Size = new System.Drawing.Size(422, 187);
            this.grpComment.TabIndex = 5;
            this.grpComment.Text = "კომენტარი:";
            this.grpComment.Visible = false;
            // 
            // memoComment
            // 
            this.memoComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoComment.Location = new System.Drawing.Point(2, 25);
            this.memoComment.Name = "memoComment";
            this.memoComment.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoComment.Properties.Appearance.Options.UseFont = true;
            this.memoComment.Properties.MaxLength = 128;
            this.memoComment.Size = new System.Drawing.Size(418, 160);
            this.memoComment.TabIndex = 0;
            this.memoComment.EditValueChanged += new System.EventHandler(this.memoComment_EditValueChanged);
            // 
            // chkHedgehog
            // 
            this.chkHedgehog.Location = new System.Drawing.Point(513, 6);
            this.chkHedgehog.Name = "chkHedgehog";
            this.chkHedgehog.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkHedgehog.Properties.Appearance.Options.UseFont = true;
            this.chkHedgehog.Properties.Caption = "";
            this.chkHedgehog.Size = new System.Drawing.Size(22, 22);
            this.chkHedgehog.TabIndex = 7;
            this.chkHedgehog.CheckedChanged += new System.EventHandler(this.chkHedgehog_CheckedChanged);
            // 
            // txtOverheadNumber
            // 
            this.txtOverheadNumber.EnterMoveNextControl = true;
            this.txtOverheadNumber.Location = new System.Drawing.Point(125, 6);
            this.txtOverheadNumber.Name = "txtOverheadNumber";
            this.txtOverheadNumber.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOverheadNumber.Properties.Appearance.Options.UseFont = true;
            this.txtOverheadNumber.Properties.MaxLength = 50;
            this.txtOverheadNumber.Size = new System.Drawing.Size(300, 23);
            this.txtOverheadNumber.TabIndex = 1;
            this.txtOverheadNumber.EditValueChanged += new System.EventHandler(this.txtOverheadNumber_EditValueChanged);
            // 
            // lblOverheadNumber
            // 
            this.lblOverheadNumber.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOverheadNumber.Location = new System.Drawing.Point(6, 9);
            this.lblOverheadNumber.Name = "lblOverheadNumber";
            this.lblOverheadNumber.Size = new System.Drawing.Size(113, 17);
            this.lblOverheadNumber.TabIndex = 0;
            this.lblOverheadNumber.Text = "ზედნადების №:";
            // 
            // lblHedgehog
            // 
            this.lblHedgehog.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHedgehog.Location = new System.Drawing.Point(446, 9);
            this.lblHedgehog.Name = "lblHedgehog";
            this.lblHedgehog.Size = new System.Drawing.Size(61, 17);
            this.lblHedgehog.TabIndex = 6;
            this.lblHedgehog.Text = "ზღარბი:";
            // 
            // lblCompany
            // 
            this.lblCompany.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompany.Location = new System.Drawing.Point(6, 38);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(72, 17);
            this.lblCompany.TabIndex = 2;
            this.lblCompany.Text = "კომპანია:";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.pnlMainFill);
            this.tabMain.Controls.Add(this.pnlMainTop);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(778, 494);
            this.tabMain.Text = "მთავარი";
            // 
            // pnlMainFill
            // 
            this.pnlMainFill.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlMainFill.Controls.Add(this.grid);
            this.pnlMainFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainFill.Location = new System.Drawing.Point(0, 135);
            this.pnlMainFill.Name = "pnlMainFill";
            this.pnlMainFill.Size = new System.Drawing.Size(778, 359);
            this.pnlMainFill.TabIndex = 1;
            // 
            // grid
            // 
            this.grid.DataSource = this.bsDetail;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EmbeddedNavigator.CustomButtons.AddRange(new DevExpress.XtraEditors.NavigatorCustomButton[] {
            new DevExpress.XtraEditors.NavigatorCustomButton(-1, 17, true, true, "დალაგება", 1)});
            this.grid.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridEmbeddedNavigator_ButtonClick);
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.view;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSaleUnitPriceDiscount,
            this.spinSaleQty,
            this.repSaleUnitQty,
            this.riUnitPriceDiscount,
            this.riShort,
            this.riUnitPrice});
            this.grid.Size = new System.Drawing.Size(778, 359);
            this.grid.TabIndex = 0;
            this.grid.UseEmbeddedNavigator = true;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view});
            this.grid.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.grid_ProcessGridKey);
            // 
            // view
            // 
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrdinalNumber,
            this.colMedicamentName,
            this.colUnitsInStock,
            this.col_ResidualQty,
            this.colUnitPrice,
            this.colSaleQty,
            this.col_SaleUnitQty,
            this.colUnitPriceDiscount,
            this.colLineTotal,
            this.colTaxRate,
            this.colValidDate,
            this.colCountryName,
            this.colBrandName,
            this.colSerie,
            this.colProductID,
            this.colProductLocationID});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.LightCoral;
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.White;
            styleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            styleFormatCondition1.Appearance.Options.HighPriority = true;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.Column = this.col_ResidualQty;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition1.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.view.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.view.GridControl = this.grid;
            this.view.Name = "view";
            this.view.OptionsCustomization.AllowFilter = false;
            this.view.OptionsCustomization.AllowGroup = false;
            this.view.OptionsNavigation.EnterMoveNextColumn = true;
            this.view.OptionsView.ShowFooter = true;
            this.view.OptionsView.ShowGroupPanel = false;
            this.view.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colOrdinalNumber, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.view.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.view_ShowingEditor);
            this.view.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.view_CellValueChanged);
            this.view.RowCountChanged += new System.EventHandler(this.view_RowCountChanged);
            // 
            // colOrdinalNumber
            // 
            this.colOrdinalNumber.Caption = "№";
            this.colOrdinalNumber.ColumnEdit = this.riShort;
            this.colOrdinalNumber.DisplayFormat.FormatString = "f00";
            this.colOrdinalNumber.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOrdinalNumber.FieldName = "OrdinalNumber";
            this.colOrdinalNumber.Name = "colOrdinalNumber";
            this.colOrdinalNumber.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.colOrdinalNumber.Visible = true;
            this.colOrdinalNumber.VisibleIndex = 0;
            // 
            // riShort
            // 
            this.riShort.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.riShort.AutoHeight = false;
            this.riShort.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", null, null, false)});
            this.riShort.DisplayFormat.FormatString = "f00";
            this.riShort.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riShort.EditFormat.FormatString = "f00";
            this.riShort.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riShort.IsFloatValue = false;
            this.riShort.Mask.EditMask = "f00";
            this.riShort.MaxValue = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.riShort.Name = "riShort";
            // 
            // colMedicamentName
            // 
            this.colMedicamentName.Caption = "მედიკამენტი";
            this.colMedicamentName.FieldName = "MedicamentName";
            this.colMedicamentName.Name = "colMedicamentName";
            this.colMedicamentName.OptionsColumn.AllowEdit = false;
            this.colMedicamentName.Visible = true;
            this.colMedicamentName.VisibleIndex = 1;
            // 
            // colUnitsInStock
            // 
            this.colUnitsInStock.Caption = "დაყოფა";
            this.colUnitsInStock.FieldName = "UnitsInStock";
            this.colUnitsInStock.Name = "colUnitsInStock";
            this.colUnitsInStock.OptionsColumn.AllowEdit = false;
            this.colUnitsInStock.Visible = true;
            this.colUnitsInStock.VisibleIndex = 2;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "ფასი / გ.";
            this.colUnitPrice.ColumnEdit = this.riUnitPrice;
            this.colUnitPrice.DisplayFormat.FormatString = "n4";
            this.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.OptionsColumn.AllowEdit = false;
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 4;
            // 
            // riUnitPrice
            // 
            this.riUnitPrice.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.riUnitPrice.AutoHeight = false;
            this.riUnitPrice.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject7, "", null, null, false)});
            this.riUnitPrice.DisplayFormat.FormatString = "n4";
            this.riUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riUnitPrice.EditFormat.FormatString = "n4";
            this.riUnitPrice.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riUnitPrice.Mask.EditMask = "n4";
            this.riUnitPrice.MaxValue = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.riUnitPrice.Name = "riUnitPrice";
            // 
            // colSaleQty
            // 
            this.colSaleQty.Caption = "რაოდენობა";
            this.colSaleQty.ColumnEdit = this.spinSaleQty;
            this.colSaleQty.DisplayFormat.FormatString = "n4";
            this.colSaleQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSaleQty.FieldName = "SaleQty";
            this.colSaleQty.Name = "colSaleQty";
            this.colSaleQty.Visible = true;
            this.colSaleQty.VisibleIndex = 5;
            // 
            // spinSaleQty
            // 
            this.spinSaleQty.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.spinSaleQty.AutoHeight = false;
            this.spinSaleQty.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject8, "", null, null, false)});
            this.spinSaleQty.DisplayFormat.FormatString = "n4";
            this.spinSaleQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSaleQty.EditFormat.FormatString = "n4";
            this.spinSaleQty.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSaleQty.Mask.EditMask = "n4";
            this.spinSaleQty.MaxValue = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.spinSaleQty.Name = "spinSaleQty";
            // 
            // col_SaleUnitQty
            // 
            this.col_SaleUnitQty.Caption = "ცალი";
            this.col_SaleUnitQty.ColumnEdit = this.repSaleUnitQty;
            this.col_SaleUnitQty.DisplayFormat.FormatString = "n00";
            this.col_SaleUnitQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_SaleUnitQty.FieldName = "_SaleUnitQty";
            this.col_SaleUnitQty.Name = "col_SaleUnitQty";
            this.col_SaleUnitQty.Visible = true;
            this.col_SaleUnitQty.VisibleIndex = 6;
            // 
            // repSaleUnitQty
            // 
            this.repSaleUnitQty.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repSaleUnitQty.AutoHeight = false;
            this.repSaleUnitQty.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, "", null, null, false)});
            this.repSaleUnitQty.DisplayFormat.FormatString = "N00";
            this.repSaleUnitQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSaleUnitQty.EditFormat.FormatString = "N00";
            this.repSaleUnitQty.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSaleUnitQty.IsFloatValue = false;
            this.repSaleUnitQty.Mask.EditMask = "N00";
            this.repSaleUnitQty.MaxValue = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.repSaleUnitQty.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repSaleUnitQty.Name = "repSaleUnitQty";
            // 
            // colUnitPriceDiscount
            // 
            this.colUnitPriceDiscount.Caption = "ფასდაკ.";
            this.colUnitPriceDiscount.ColumnEdit = this.riUnitPriceDiscount;
            this.colUnitPriceDiscount.DisplayFormat.FormatString = "p";
            this.colUnitPriceDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPriceDiscount.FieldName = "UnitPriceDiscount";
            this.colUnitPriceDiscount.Name = "colUnitPriceDiscount";
            this.colUnitPriceDiscount.Visible = true;
            this.colUnitPriceDiscount.VisibleIndex = 7;
            // 
            // riUnitPriceDiscount
            // 
            this.riUnitPriceDiscount.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.riUnitPriceDiscount.AutoHeight = false;
            this.riUnitPriceDiscount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject10, "", null, null, false)});
            this.riUnitPriceDiscount.DisplayFormat.FormatString = "p";
            this.riUnitPriceDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riUnitPriceDiscount.EditFormat.FormatString = "p";
            this.riUnitPriceDiscount.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riUnitPriceDiscount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.riUnitPriceDiscount.Mask.EditMask = "p";
            this.riUnitPriceDiscount.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.riUnitPriceDiscount.Name = "riUnitPriceDiscount";
            // 
            // colLineTotal
            // 
            this.colLineTotal.AppearanceCell.BackColor = System.Drawing.Color.Cornsilk;
            this.colLineTotal.AppearanceCell.Options.UseBackColor = true;
            this.colLineTotal.Caption = "ჯამი / გ.";
            this.colLineTotal.DisplayFormat.FormatString = "n4";
            this.colLineTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLineTotal.FieldName = "LineTotal";
            this.colLineTotal.Name = "colLineTotal";
            this.colLineTotal.OptionsColumn.AllowEdit = false;
            this.colLineTotal.SummaryItem.DisplayFormat = "{0:n2}";
            this.colLineTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colLineTotal.Visible = true;
            this.colLineTotal.VisibleIndex = 8;
            // 
            // colTaxRate
            // 
            this.colTaxRate.Caption = "დ.ღ.გ.";
            this.colTaxRate.DisplayFormat.FormatString = "p";
            this.colTaxRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTaxRate.FieldName = "TaxRate";
            this.colTaxRate.Name = "colTaxRate";
            this.colTaxRate.OptionsColumn.AllowEdit = false;
            this.colTaxRate.Visible = true;
            this.colTaxRate.VisibleIndex = 9;
            // 
            // colValidDate
            // 
            this.colValidDate.Caption = "ვადა";
            this.colValidDate.DisplayFormat.FormatString = "MM\\/yy";
            this.colValidDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colValidDate.FieldName = "ValidDate";
            this.colValidDate.Name = "colValidDate";
            this.colValidDate.OptionsColumn.AllowEdit = false;
            this.colValidDate.Visible = true;
            this.colValidDate.VisibleIndex = 10;
            // 
            // colCountryName
            // 
            this.colCountryName.Caption = "მწ. ქვეყანა";
            this.colCountryName.FieldName = "CountryName";
            this.colCountryName.Name = "colCountryName";
            this.colCountryName.OptionsColumn.AllowEdit = false;
            this.colCountryName.Visible = true;
            this.colCountryName.VisibleIndex = 11;
            // 
            // colBrandName
            // 
            this.colBrandName.Caption = "ბრენდი";
            this.colBrandName.FieldName = "BrandName";
            this.colBrandName.Name = "colBrandName";
            this.colBrandName.OptionsColumn.AllowEdit = false;
            this.colBrandName.Visible = true;
            this.colBrandName.VisibleIndex = 12;
            // 
            // colSerie
            // 
            this.colSerie.Caption = "სერია";
            this.colSerie.FieldName = "Serie";
            this.colSerie.Name = "colSerie";
            this.colSerie.OptionsColumn.AllowEdit = false;
            this.colSerie.Visible = true;
            this.colSerie.VisibleIndex = 13;
            // 
            // colProductID
            // 
            this.colProductID.FieldName = "ProductID";
            this.colProductID.Name = "colProductID";
            this.colProductID.OptionsColumn.AllowEdit = false;
            // 
            // colProductLocationID
            // 
            this.colProductLocationID.FieldName = "ProductLocationID";
            this.colProductLocationID.Name = "colProductLocationID";
            this.colProductLocationID.OptionsColumn.AllowEdit = false;
            // 
            // repSaleUnitPriceDiscount
            // 
            this.repSaleUnitPriceDiscount.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repSaleUnitPriceDiscount.AutoHeight = false;
            this.repSaleUnitPriceDiscount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject11, "", null, null, false)});
            this.repSaleUnitPriceDiscount.DisplayFormat.FormatString = "n4";
            this.repSaleUnitPriceDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSaleUnitPriceDiscount.EditFormat.FormatString = "n4";
            this.repSaleUnitPriceDiscount.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSaleUnitPriceDiscount.Mask.EditMask = "n4";
            this.repSaleUnitPriceDiscount.MaxValue = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.repSaleUnitPriceDiscount.Name = "repSaleUnitPriceDiscount";
            // 
            // pnlMainTop
            // 
            this.pnlMainTop.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlMainTop.Controls.Add(this.spinDiscountPct);
            this.pnlMainTop.Controls.Add(this.lblDiscountPct);
            this.pnlMainTop.Controls.Add(this.btnCalculator);
            this.pnlMainTop.Controls.Add(this.lookPaymentMethod);
            this.pnlMainTop.Controls.Add(this.lookCurrency);
            this.pnlMainTop.Controls.Add(this.spinFreight);
            this.pnlMainTop.Controls.Add(this.spinTaxAmt);
            this.pnlMainTop.Controls.Add(this.lblPaymentMethod);
            this.pnlMainTop.Controls.Add(this.spinSubTotal);
            this.pnlMainTop.Controls.Add(this.lblFreight);
            this.pnlMainTop.Controls.Add(this.spinTotalDue);
            this.pnlMainTop.Controls.Add(this.lblTaxAmt);
            this.pnlMainTop.Controls.Add(this.dateOrderDate);
            this.pnlMainTop.Controls.Add(this.lblCurrency);
            this.pnlMainTop.Controls.Add(this.lblSubTotal);
            this.pnlMainTop.Controls.Add(this.txtSalesOrderID);
            this.pnlMainTop.Controls.Add(this.lblTotalDue);
            this.pnlMainTop.Controls.Add(this.lblOrderDate);
            this.pnlMainTop.Controls.Add(this.lblPurchaseID);
            this.pnlMainTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainTop.Location = new System.Drawing.Point(0, 0);
            this.pnlMainTop.Name = "pnlMainTop";
            this.pnlMainTop.Size = new System.Drawing.Size(778, 135);
            this.pnlMainTop.TabIndex = 0;
            // 
            // spinDiscountPct
            // 
            this.spinDiscountPct.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinDiscountPct.EnterMoveNextControl = true;
            this.spinDiscountPct.Location = new System.Drawing.Point(89, 64);
            this.spinDiscountPct.Name = "spinDiscountPct";
            this.spinDiscountPct.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinDiscountPct.Properties.Appearance.Options.UseFont = true;
            this.spinDiscountPct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinDiscountPct.Properties.DisplayFormat.FormatString = "p";
            this.spinDiscountPct.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinDiscountPct.Properties.EditFormat.FormatString = "p";
            this.spinDiscountPct.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinDiscountPct.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.spinDiscountPct.Properties.Mask.EditMask = "p";
            this.spinDiscountPct.Properties.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinDiscountPct.Size = new System.Drawing.Size(200, 23);
            this.spinDiscountPct.TabIndex = 5;
            this.spinDiscountPct.EditValueChanged += new System.EventHandler(this.spinDiscountPct_EditValueChanged);
            // 
            // lblDiscountPct
            // 
            this.lblDiscountPct.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDiscountPct.Location = new System.Drawing.Point(6, 67);
            this.lblDiscountPct.Name = "lblDiscountPct";
            this.lblDiscountPct.Size = new System.Drawing.Size(60, 17);
            this.lblDiscountPct.TabIndex = 4;
            this.lblDiscountPct.Text = "ფასდაკ:";
            // 
            // btnCalculator
            // 
            this.btnCalculator.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculator.Appearance.Options.UseFont = true;
            this.btnCalculator.Image = global::Apothex.Sales.Properties.Resources.Calculator_24x24;
            this.btnCalculator.Location = new System.Drawing.Point(89, 93);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(200, 35);
            this.btnCalculator.TabIndex = 6;
            this.btnCalculator.TabStop = false;
            this.btnCalculator.Text = "კალკულატორი (F12)";
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // lookPaymentMethod
            // 
            this.lookPaymentMethod.EnterMoveNextControl = true;
            this.lookPaymentMethod.Location = new System.Drawing.Point(437, 93);
            this.lookPaymentMethod.Name = "lookPaymentMethod";
            this.lookPaymentMethod.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookPaymentMethod.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookPaymentMethod.Properties.Appearance.Options.UseFont = true;
            this.lookPaymentMethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookPaymentMethod.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.lookPaymentMethod.Properties.DisplayMember = "Caption";
            this.lookPaymentMethod.Properties.NullText = "";
            this.lookPaymentMethod.Properties.ShowHeader = false;
            this.lookPaymentMethod.Properties.ValueMember = "ID";
            this.lookPaymentMethod.Size = new System.Drawing.Size(340, 23);
            this.lookPaymentMethod.TabIndex = 18;
            this.lookPaymentMethod.EditValueChanged += new System.EventHandler(this.lookPaymentMethod_EditValueChanged);
            // 
            // lookCurrency
            // 
            this.lookCurrency.EnterMoveNextControl = true;
            this.lookCurrency.Location = new System.Drawing.Point(437, 64);
            this.lookCurrency.Name = "lookCurrency";
            this.lookCurrency.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.lookCurrency.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookCurrency.Properties.Appearance.Options.UseFont = true;
            this.lookCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookCurrency.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", 100, "Caption"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 75, DevExpress.Utils.FormatType.None, "n4", true, DevExpress.Utils.HorzAlignment.Default)});
            this.lookCurrency.Properties.DataSource = this.bsCurrency;
            this.lookCurrency.Properties.DisplayMember = "Caption";
            this.lookCurrency.Properties.NullText = "";
            this.lookCurrency.Properties.ShowHeader = false;
            this.lookCurrency.Properties.ValueMember = "ID";
            this.lookCurrency.Size = new System.Drawing.Size(340, 23);
            this.lookCurrency.TabIndex = 16;
            this.lookCurrency.EditValueChanged += new System.EventHandler(this.lookCurrency_EditValueChanged);
            // 
            // spinFreight
            // 
            this.spinFreight.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinFreight.EnterMoveNextControl = true;
            this.spinFreight.Location = new System.Drawing.Point(437, 6);
            this.spinFreight.Name = "spinFreight";
            this.spinFreight.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinFreight.Properties.Appearance.Options.UseFont = true;
            this.spinFreight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinFreight.Properties.DisplayFormat.FormatString = "n2";
            this.spinFreight.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinFreight.Properties.EditFormat.FormatString = "n2";
            this.spinFreight.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinFreight.Properties.Mask.EditMask = "n2";
            this.spinFreight.Properties.MaxValue = new decimal(new int[] {
            -1806942208,
            209547,
            0,
            0});
            this.spinFreight.Size = new System.Drawing.Size(120, 23);
            this.spinFreight.TabIndex = 8;
            this.spinFreight.EditValueChanged += new System.EventHandler(this.spinFreight_EditValueChanged);
            // 
            // spinTaxAmt
            // 
            this.spinTaxAmt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTaxAmt.EnterMoveNextControl = true;
            this.spinTaxAmt.Location = new System.Drawing.Point(437, 35);
            this.spinTaxAmt.Name = "spinTaxAmt";
            this.spinTaxAmt.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinTaxAmt.Properties.Appearance.Options.UseFont = true;
            this.spinTaxAmt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinTaxAmt.Properties.DisplayFormat.FormatString = "n2";
            this.spinTaxAmt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTaxAmt.Properties.EditFormat.FormatString = "n2";
            this.spinTaxAmt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTaxAmt.Properties.Mask.EditMask = "n2";
            this.spinTaxAmt.Properties.ReadOnly = true;
            this.spinTaxAmt.Size = new System.Drawing.Size(120, 23);
            this.spinTaxAmt.TabIndex = 12;
            this.spinTaxAmt.EditValueChanged += new System.EventHandler(this.spinTaxAmt_EditValueChanged);
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(301, 96);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(131, 17);
            this.lblPaymentMethod.TabIndex = 17;
            this.lblPaymentMethod.Text = "გადახდ. მეთოდი:";
            // 
            // spinSubTotal
            // 
            this.spinSubTotal.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinSubTotal.EnterMoveNextControl = true;
            this.spinSubTotal.Location = new System.Drawing.Point(657, 6);
            this.spinSubTotal.Name = "spinSubTotal";
            this.spinSubTotal.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinSubTotal.Properties.Appearance.Options.UseFont = true;
            this.spinSubTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinSubTotal.Properties.DisplayFormat.FormatString = "n2";
            this.spinSubTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSubTotal.Properties.EditFormat.FormatString = "n2";
            this.spinSubTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSubTotal.Properties.Mask.EditMask = "n2";
            this.spinSubTotal.Properties.ReadOnly = true;
            this.spinSubTotal.Size = new System.Drawing.Size(120, 23);
            this.spinSubTotal.TabIndex = 10;
            this.spinSubTotal.Visible = false;
            this.spinSubTotal.EditValueChanged += new System.EventHandler(this.spinSubTotal_EditValueChanged);
            // 
            // lblFreight
            // 
            this.lblFreight.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFreight.Location = new System.Drawing.Point(301, 9);
            this.lblFreight.Name = "lblFreight";
            this.lblFreight.Size = new System.Drawing.Size(113, 17);
            this.lblFreight.TabIndex = 7;
            this.lblFreight.Text = "ტრანსპორტირ:";
            // 
            // spinTotalDue
            // 
            this.spinTotalDue.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTotalDue.EnterMoveNextControl = true;
            this.spinTotalDue.Location = new System.Drawing.Point(657, 35);
            this.spinTotalDue.Name = "spinTotalDue";
            this.spinTotalDue.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinTotalDue.Properties.Appearance.Options.UseFont = true;
            this.spinTotalDue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinTotalDue.Properties.DisplayFormat.FormatString = "n2";
            this.spinTotalDue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTotalDue.Properties.EditFormat.FormatString = "n2";
            this.spinTotalDue.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTotalDue.Properties.Mask.EditMask = "n2";
            this.spinTotalDue.Properties.ReadOnly = true;
            this.spinTotalDue.Size = new System.Drawing.Size(120, 23);
            this.spinTotalDue.TabIndex = 14;
            this.spinTotalDue.EditValueChanged += new System.EventHandler(this.spinTotalDue_EditValueChanged);
            // 
            // lblTaxAmt
            // 
            this.lblTaxAmt.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTaxAmt.Location = new System.Drawing.Point(301, 38);
            this.lblTaxAmt.Name = "lblTaxAmt";
            this.lblTaxAmt.Size = new System.Drawing.Size(52, 17);
            this.lblTaxAmt.TabIndex = 11;
            this.lblTaxAmt.Text = "დ.ღ.გ.:";
            // 
            // dateOrderDate
            // 
            this.dateOrderDate.EditValue = null;
            this.dateOrderDate.EnterMoveNextControl = true;
            this.dateOrderDate.Location = new System.Drawing.Point(89, 35);
            this.dateOrderDate.Name = "dateOrderDate";
            this.dateOrderDate.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOrderDate.Properties.Appearance.Options.UseFont = true;
            this.dateOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject12, "", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "OK", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, "განახლება", null, null, false)});
            this.dateOrderDate.Properties.DisplayFormat.FormatString = "G";
            this.dateOrderDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateOrderDate.Properties.EditFormat.FormatString = "G";
            this.dateOrderDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateOrderDate.Properties.Mask.EditMask = "G";
            this.dateOrderDate.Properties.ReadOnly = true;
            this.dateOrderDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateOrderDate.Size = new System.Drawing.Size(200, 23);
            this.dateOrderDate.TabIndex = 3;
            this.dateOrderDate.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.dateOrderDate_ButtonClick);
            this.dateOrderDate.EditValueChanged += new System.EventHandler(this.dateOrderDate_EditValueChanged);
            // 
            // lblCurrency
            // 
            this.lblCurrency.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrency.Location = new System.Drawing.Point(301, 67);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(63, 17);
            this.lblCurrency.TabIndex = 15;
            this.lblCurrency.Text = "ვალუტა:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSubTotal.Location = new System.Drawing.Point(575, 9);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(66, 17);
            this.lblSubTotal.TabIndex = 9;
            this.lblSubTotal.Text = "ქვე ჯამი:";
            this.lblSubTotal.Visible = false;
            // 
            // txtSalesOrderID
            // 
            this.txtSalesOrderID.EnterMoveNextControl = true;
            this.txtSalesOrderID.Location = new System.Drawing.Point(89, 6);
            this.txtSalesOrderID.Name = "txtSalesOrderID";
            this.txtSalesOrderID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSalesOrderID.Properties.Appearance.Options.UseFont = true;
            this.txtSalesOrderID.Properties.ReadOnly = true;
            this.txtSalesOrderID.Size = new System.Drawing.Size(200, 23);
            this.txtSalesOrderID.TabIndex = 1;
            this.txtSalesOrderID.EditValueChanged += new System.EventHandler(this.txtSalesID_EditValueChanged);
            // 
            // lblTotalDue
            // 
            this.lblTotalDue.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalDue.Location = new System.Drawing.Point(575, 38);
            this.lblTotalDue.Name = "lblTotalDue";
            this.lblTotalDue.Size = new System.Drawing.Size(74, 17);
            this.lblTotalDue.TabIndex = 13;
            this.lblTotalDue.Text = "სულ ჯამი:";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderDate.Location = new System.Drawing.Point(6, 38);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(65, 17);
            this.lblOrderDate.TabIndex = 2;
            this.lblOrderDate.Text = "თარიღი:";
            // 
            // lblPurchaseID
            // 
            this.lblPurchaseID.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPurchaseID.Location = new System.Drawing.Point(6, 9);
            this.lblPurchaseID.Name = "lblPurchaseID";
            this.lblPurchaseID.Size = new System.Drawing.Size(20, 17);
            this.lblPurchaseID.TabIndex = 0;
            this.lblPurchaseID.Text = "№:";
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.AppearancePage.Header.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xtraTabControl.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl.Location = new System.Drawing.Point(0, 39);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.SelectedTabPage = this.tabMain;
            this.xtraTabControl.Size = new System.Drawing.Size(784, 523);
            this.xtraTabControl.TabIndex = 0;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabMain,
            this.tabAdditional,
            this.tabCard,
            this.tabOperation,
            this.tabInfo});
            // 
            // tabOperation
            // 
            this.tabOperation.Controls.Add(this.gridOperation);
            this.tabOperation.Name = "tabOperation";
            this.tabOperation.Size = new System.Drawing.Size(778, 494);
            this.tabOperation.Text = "ოპერაცია";
            // 
            // gridOperation
            // 
            this.gridOperation.DataSource = this.bsOperation;
            this.gridOperation.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridOperation.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridOperation_EmbeddedNavigator_ButtonClick);
            this.gridOperation.Location = new System.Drawing.Point(0, 0);
            this.gridOperation.MainView = this.viewOperation;
            this.gridOperation.MenuManager = this.barManager;
            this.gridOperation.Name = "gridOperation";
            this.gridOperation.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riOpAmount,
            this.riOpType});
            this.gridOperation.Size = new System.Drawing.Size(500, 494);
            this.gridOperation.TabIndex = 0;
            this.gridOperation.UseEmbeddedNavigator = true;
            this.gridOperation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewOperation});
            // 
            // bsOperation
            // 
            this.bsOperation.DataMember = "T_Operation";
            this.bsOperation.DataSource = this.ds_Operation;
            // 
            // ds_Operation
            // 
            this.ds_Operation.DataSetName = "DS_Operation";
            this.ds_Operation.Locale = new System.Globalization.CultureInfo("");
            this.ds_Operation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewOperation
            // 
            this.viewOperation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOpAmount,
            this.colOpTypeID});
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.LightCoral;
            styleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.Red;
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.White;
            styleFormatCondition2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            styleFormatCondition2.Appearance.Options.HighPriority = true;
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.Column = this.colOpAmount;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.LessOrEqual;
            styleFormatCondition2.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.viewOperation.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition2});
            this.viewOperation.GridControl = this.gridOperation;
            this.viewOperation.Name = "viewOperation";
            this.viewOperation.OptionsCustomization.AllowGroup = false;
            this.viewOperation.OptionsNavigation.EnterMoveNextColumn = true;
            this.viewOperation.OptionsSelection.MultiSelect = true;
            this.viewOperation.OptionsView.ShowFooter = true;
            this.viewOperation.OptionsView.ShowGroupPanel = false;
            // 
            // colOpTypeID
            // 
            this.colOpTypeID.Caption = "ტიპი";
            this.colOpTypeID.ColumnEdit = this.riOpType;
            this.colOpTypeID.FieldName = "TypeID";
            this.colOpTypeID.Name = "colOpTypeID";
            this.colOpTypeID.Visible = true;
            this.colOpTypeID.VisibleIndex = 1;
            // 
            // riOpType
            // 
            this.riOpType.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.riOpType.AutoHeight = false;
            this.riOpType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riOpType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.riOpType.DisplayMember = "Caption";
            this.riOpType.Name = "riOpType";
            this.riOpType.NullText = "";
            this.riOpType.ShowHeader = false;
            this.riOpType.ValueMember = "ID";
            // 
            // frmSalesOrderEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.xtraTabControl);
            this.Name = "frmSalesOrderEdit";
            this.ObjectName = Apothex.DataType.ObjectNames.SalesOrderHeader;
            this.OptionsBaseForm.IsPrintable = true;
            this.OptionsBaseForm.Text = "გაყიდვა";
            this.Text = "გაყიდვა";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSalesOrderEdit_FormClosed);
            this.Shown += new System.EventHandler(this.frmSalesOrderEdit_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSalesOrderEdit_KeyDown);
            this.Controls.SetChildIndex(this.xtraTabControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riOpAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Hedgehog)).EndInit();
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinRevisionNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbApprover.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbModifier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifiedDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifiedDate.Properties)).EndInit();
            this.tabCard.ResumeLayout(false);
            this.tabCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beCard.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCard)).EndInit();
            this.tabAdditional.ResumeLayout(false);
            this.tabAdditional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkSaleStandardCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHedgehog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpComment)).EndInit();
            this.grpComment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkHedgehog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOverheadNumber.Properties)).EndInit();
            this.tabMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainFill)).EndInit();
            this.pnlMainFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riShort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSaleQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSaleUnitQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riUnitPriceDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSaleUnitPriceDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainTop)).EndInit();
            this.pnlMainTop.ResumeLayout(false);
            this.pnlMainTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDiscountPct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookPaymentMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinFreight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTaxAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSubTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalDue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalesOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.tabOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Operation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riOpType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsDetail;
        private System.Windows.Forms.BindingSource bsCurrency;
        private System.Windows.Forms.BindingSource bsHeader;
        private Apothex.DataType.DS_Sales ds_Sales;
        private Apothex.DataType.DS_Hedgehog ds_Hedgehog;
        private DevExpress.XtraTab.XtraTabPage tabInfo;
        private Windows.Forms.ButtonBrowse bbBranch;
        private DevExpress.XtraEditors.SpinEdit spinRevisionNumber;
        private DevExpress.XtraEditors.LabelControl lblRevisionNumber;
        private Windows.Forms.ButtonBrowse bbApprover;
        private Windows.Forms.ButtonBrowse bbModifier;
        private DevExpress.XtraEditors.LabelControl lblBranch;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblApprover;
        private DevExpress.XtraEditors.DateEdit dateModifiedDate;
        private DevExpress.XtraEditors.LabelControl lblModifier;
        private DevExpress.XtraEditors.LabelControl lblModifiedDate;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraTab.XtraTabPage tabCard;
        private DevExpress.XtraGrid.GridControl gridCard;
        private DevExpress.XtraEditors.LabelControl lblCard;
        private DevExpress.XtraTab.XtraTabPage tabAdditional;
        private DevExpress.XtraEditors.CheckEdit chkSaleStandardCost;
        private Windows.Forms.ButtonBrowse bbCustomer;
        private DevExpress.XtraEditors.TextEdit txtHedgehog;
        private DevExpress.XtraEditors.GroupControl grpComment;
        private DevExpress.XtraEditors.MemoEdit memoComment;
        private DevExpress.XtraEditors.CheckEdit chkHedgehog;
        private DevExpress.XtraEditors.TextEdit txtOverheadNumber;
        private DevExpress.XtraEditors.LabelControl lblOverheadNumber;
        private DevExpress.XtraEditors.LabelControl lblHedgehog;
        private DevExpress.XtraEditors.LabelControl lblCompany;
        private DevExpress.XtraTab.XtraTabPage tabMain;
        private DevExpress.XtraEditors.PanelControl pnlMainFill;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView view;
        private DevExpress.XtraGrid.Columns.GridColumn colOrdinalNumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit riShort;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitsInStock;
        private DevExpress.XtraGrid.Columns.GridColumn col_ResidualQty;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit riUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleQty;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinSaleQty;
        private DevExpress.XtraGrid.Columns.GridColumn col_SaleUnitQty;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSaleUnitQty;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPriceDiscount;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit riUnitPriceDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colLineTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxRate;
        private DevExpress.XtraGrid.Columns.GridColumn colValidDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryName;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandName;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSaleUnitPriceDiscount;
        private DevExpress.XtraEditors.PanelControl pnlMainTop;
        private DevExpress.XtraEditors.SpinEdit spinDiscountPct;
        private DevExpress.XtraEditors.LabelControl lblDiscountPct;
        private DevExpress.XtraEditors.SimpleButton btnCalculator;
        private DevExpress.XtraEditors.LookUpEdit lookPaymentMethod;
        private DevExpress.XtraEditors.LookUpEdit lookCurrency;
        private DevExpress.XtraEditors.SpinEdit spinFreight;
        private DevExpress.XtraEditors.SpinEdit spinTaxAmt;
        private DevExpress.XtraEditors.LabelControl lblPaymentMethod;
        private DevExpress.XtraEditors.SpinEdit spinSubTotal;
        private DevExpress.XtraEditors.LabelControl lblFreight;
        private DevExpress.XtraEditors.SpinEdit spinTotalDue;
        private DevExpress.XtraEditors.LabelControl lblTaxAmt;
        private DevExpress.XtraEditors.DateEdit dateOrderDate;
        private DevExpress.XtraEditors.LabelControl lblCurrency;
        private DevExpress.XtraEditors.LabelControl lblSubTotal;
        private DevExpress.XtraEditors.TextEdit txtSalesOrderID;
        private DevExpress.XtraEditors.LabelControl lblTotalDue;
        private DevExpress.XtraEditors.LabelControl lblOrderDate;
        private DevExpress.XtraEditors.LabelControl lblPurchaseID;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraGrid.Views.Grid.GridView viewCard;
        private DevExpress.XtraEditors.SimpleButton btnGetCardInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colCardInfoName;
        private DevExpress.XtraGrid.Columns.GridColumn colCardInfoValue;
        private DevExpress.XtraEditors.ButtonEdit beCard;
        private DevExpress.XtraTab.XtraTabPage tabOperation;
        private DevExpress.XtraGrid.GridControl gridOperation;
        private DevExpress.XtraGrid.Views.Grid.GridView viewOperation;
        private System.Windows.Forms.BindingSource bsOperation;
        private DataType.DS_Operation ds_Operation;
        private DevExpress.XtraGrid.Columns.GridColumn colOpAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colOpTypeID;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit riOpAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riOpType;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductLocationID;
    }
}