namespace Apothex.Synchronization
{
    partial class frmSynchronizeEdit
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
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chklstTable = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabMain = new DevExpress.XtraTab.XtraTabPage();
            this.tabServerError = new DevExpress.XtraTab.XtraTabPage();
            this.memoServerXml = new DevExpress.XtraEditors.MemoEdit();
            this.pnlServerErrorTop = new DevExpress.XtraEditors.PanelControl();
            this.txtServerErrorObjectID = new DevExpress.XtraEditors.TextEdit();
            this.lblServerErrorObjectID = new DevExpress.XtraEditors.LabelControl();
            this.tabLocalError = new DevExpress.XtraTab.XtraTabPage();
            this.memoLocalXml = new DevExpress.XtraEditors.MemoEdit();
            this.pnlLocalErrorTop = new DevExpress.XtraEditors.PanelControl();
            this.txtLocalErrorObjectID = new DevExpress.XtraEditors.TextEdit();
            this.lblLocalErrorObjectID = new DevExpress.XtraEditors.LabelControl();
            this.tabSales = new DevExpress.XtraTab.XtraTabPage();
            this.gridSales = new DevExpress.XtraGrid.GridControl();
            this.bsSyncSalesOrderDetail = new System.Windows.Forms.BindingSource(this.components);
            this.ds_SyncSalesOrderDetail = new Apothex.DataType.DS_SyncSalesOrderDetail();
            this.viewSales = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSalesOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductLocationID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicamentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaleQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlSalesTop = new DevExpress.XtraEditors.PanelControl();
            this.btnInitSales = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chklstTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabServerError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoServerXml.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlServerErrorTop)).BeginInit();
            this.pnlServerErrorTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerErrorObjectID.Properties)).BeginInit();
            this.tabLocalError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoLocalXml.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLocalErrorTop)).BeginInit();
            this.pnlLocalErrorTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalErrorObjectID.Properties)).BeginInit();
            this.tabSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSyncSalesOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SyncSalesOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSalesTop)).BeginInit();
            this.pnlSalesTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "ნაშთი";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            // 
            // chklstTable
            // 
            this.chklstTable.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklstTable.Appearance.Options.UseFont = true;
            this.chklstTable.Location = new System.Drawing.Point(9, 3);
            this.chklstTable.Name = "chklstTable";
            this.chklstTable.Size = new System.Drawing.Size(400, 300);
            this.chklstTable.TabIndex = 5;
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
            this.tabServerError,
            this.tabLocalError,
            this.tabSales});
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.chklstTable);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(778, 494);
            this.tabMain.Text = "მთავარი";
            // 
            // tabServerError
            // 
            this.tabServerError.Controls.Add(this.memoServerXml);
            this.tabServerError.Controls.Add(this.pnlServerErrorTop);
            this.tabServerError.Name = "tabServerError";
            this.tabServerError.Size = new System.Drawing.Size(778, 494);
            this.tabServerError.Text = "სერვერის შეცდომა";
            // 
            // memoServerXml
            // 
            this.memoServerXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoServerXml.Location = new System.Drawing.Point(0, 35);
            this.memoServerXml.MenuManager = this.barManager;
            this.memoServerXml.Name = "memoServerXml";
            this.memoServerXml.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoServerXml.Properties.Appearance.Options.UseFont = true;
            this.memoServerXml.Properties.ReadOnly = true;
            this.memoServerXml.Size = new System.Drawing.Size(778, 459);
            this.memoServerXml.TabIndex = 1;
            // 
            // pnlServerErrorTop
            // 
            this.pnlServerErrorTop.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlServerErrorTop.Controls.Add(this.txtServerErrorObjectID);
            this.pnlServerErrorTop.Controls.Add(this.lblServerErrorObjectID);
            this.pnlServerErrorTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlServerErrorTop.Location = new System.Drawing.Point(0, 0);
            this.pnlServerErrorTop.Name = "pnlServerErrorTop";
            this.pnlServerErrorTop.Size = new System.Drawing.Size(778, 35);
            this.pnlServerErrorTop.TabIndex = 0;
            // 
            // txtServerErrorObjectID
            // 
            this.txtServerErrorObjectID.Location = new System.Drawing.Point(106, 6);
            this.txtServerErrorObjectID.MenuManager = this.barManager;
            this.txtServerErrorObjectID.Name = "txtServerErrorObjectID";
            this.txtServerErrorObjectID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtServerErrorObjectID.Properties.Appearance.Options.UseFont = true;
            this.txtServerErrorObjectID.Properties.ReadOnly = true;
            this.txtServerErrorObjectID.Size = new System.Drawing.Size(200, 23);
            this.txtServerErrorObjectID.TabIndex = 1;
            // 
            // lblServerErrorObjectID
            // 
            this.lblServerErrorObjectID.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblServerErrorObjectID.Location = new System.Drawing.Point(6, 9);
            this.lblServerErrorObjectID.Name = "lblServerErrorObjectID";
            this.lblServerErrorObjectID.Size = new System.Drawing.Size(94, 17);
            this.lblServerErrorObjectID.TabIndex = 0;
            this.lblServerErrorObjectID.Text = "ობიექტის ID:";
            // 
            // tabLocalError
            // 
            this.tabLocalError.Controls.Add(this.memoLocalXml);
            this.tabLocalError.Controls.Add(this.pnlLocalErrorTop);
            this.tabLocalError.Name = "tabLocalError";
            this.tabLocalError.Size = new System.Drawing.Size(778, 494);
            this.tabLocalError.Text = "ლოკალური შეცდომა";
            // 
            // memoLocalXml
            // 
            this.memoLocalXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoLocalXml.Location = new System.Drawing.Point(0, 35);
            this.memoLocalXml.MenuManager = this.barManager;
            this.memoLocalXml.Name = "memoLocalXml";
            this.memoLocalXml.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoLocalXml.Properties.Appearance.Options.UseFont = true;
            this.memoLocalXml.Properties.ReadOnly = true;
            this.memoLocalXml.Size = new System.Drawing.Size(778, 459);
            this.memoLocalXml.TabIndex = 1;
            // 
            // pnlLocalErrorTop
            // 
            this.pnlLocalErrorTop.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlLocalErrorTop.Controls.Add(this.txtLocalErrorObjectID);
            this.pnlLocalErrorTop.Controls.Add(this.lblLocalErrorObjectID);
            this.pnlLocalErrorTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLocalErrorTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLocalErrorTop.Name = "pnlLocalErrorTop";
            this.pnlLocalErrorTop.Size = new System.Drawing.Size(778, 35);
            this.pnlLocalErrorTop.TabIndex = 0;
            // 
            // txtLocalErrorObjectID
            // 
            this.txtLocalErrorObjectID.Location = new System.Drawing.Point(106, 6);
            this.txtLocalErrorObjectID.MenuManager = this.barManager;
            this.txtLocalErrorObjectID.Name = "txtLocalErrorObjectID";
            this.txtLocalErrorObjectID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLocalErrorObjectID.Properties.Appearance.Options.UseFont = true;
            this.txtLocalErrorObjectID.Properties.ReadOnly = true;
            this.txtLocalErrorObjectID.Size = new System.Drawing.Size(200, 23);
            this.txtLocalErrorObjectID.TabIndex = 1;
            // 
            // lblLocalErrorObjectID
            // 
            this.lblLocalErrorObjectID.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLocalErrorObjectID.Location = new System.Drawing.Point(6, 9);
            this.lblLocalErrorObjectID.Name = "lblLocalErrorObjectID";
            this.lblLocalErrorObjectID.Size = new System.Drawing.Size(94, 17);
            this.lblLocalErrorObjectID.TabIndex = 0;
            this.lblLocalErrorObjectID.Text = "ობიექტის ID:";
            // 
            // tabSales
            // 
            this.tabSales.Controls.Add(this.gridSales);
            this.tabSales.Controls.Add(this.pnlSalesTop);
            this.tabSales.Name = "tabSales";
            this.tabSales.Size = new System.Drawing.Size(778, 494);
            this.tabSales.Text = "განაშთული გაყიდული პროდუქცია";
            // 
            // gridSales
            // 
            this.gridSales.DataSource = this.bsSyncSalesOrderDetail;
            this.gridSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSales.Location = new System.Drawing.Point(0, 45);
            this.gridSales.MainView = this.viewSales;
            this.gridSales.MenuManager = this.barManager;
            this.gridSales.Name = "gridSales";
            this.gridSales.Size = new System.Drawing.Size(778, 449);
            this.gridSales.TabIndex = 1;
            this.gridSales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewSales});
            // 
            // bsSyncSalesOrderDetail
            // 
            this.bsSyncSalesOrderDetail.DataMember = "T_SalesOrderDetail_Invalid";
            this.bsSyncSalesOrderDetail.DataSource = this.ds_SyncSalesOrderDetail;
            // 
            // ds_SyncSalesOrderDetail
            // 
            this.ds_SyncSalesOrderDetail.DataSetName = "DS_SyncSalesOrderDetail";
            this.ds_SyncSalesOrderDetail.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewSales
            // 
            this.viewSales.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSalesOrderID,
            this.colProductID,
            this.colProductLocationID,
            this.colMedicamentID,
            this.colName,
            this.colQuantity,
            this.colSaleQty});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.LightCoral;
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.White;
            styleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colQuantity;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.LessOrEqual;
            styleFormatCondition1.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.viewSales.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.viewSales.GridControl = this.gridSales;
            this.viewSales.Name = "viewSales";
            this.viewSales.OptionsBehavior.Editable = false;
            this.viewSales.OptionsView.ShowAutoFilterRow = true;
            this.viewSales.OptionsView.ShowFooter = true;
            this.viewSales.DoubleClick += new System.EventHandler(this.viewSales_DoubleClick);
            // 
            // colSalesOrderID
            // 
            this.colSalesOrderID.Caption = "ფაქტურის №";
            this.colSalesOrderID.FieldName = "SalesOrderID";
            this.colSalesOrderID.Name = "colSalesOrderID";
            this.colSalesOrderID.Visible = true;
            this.colSalesOrderID.VisibleIndex = 0;
            // 
            // colProductID
            // 
            this.colProductID.FieldName = "ProductID";
            this.colProductID.Name = "colProductID";
            this.colProductID.SummaryItem.DisplayFormat = "{0}";
            this.colProductID.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            // 
            // colProductLocationID
            // 
            this.colProductLocationID.FieldName = "ProductLocationID";
            this.colProductLocationID.Name = "colProductLocationID";
            // 
            // colMedicamentID
            // 
            this.colMedicamentID.FieldName = "MedicamentID";
            this.colMedicamentID.Name = "colMedicamentID";
            // 
            // colName
            // 
            this.colName.Caption = "პროდუქცია";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colSaleQty
            // 
            this.colSaleQty.Caption = "გაყ. რაოდ.";
            this.colSaleQty.FieldName = "SaleQty";
            this.colSaleQty.Name = "colSaleQty";
            this.colSaleQty.Visible = true;
            this.colSaleQty.VisibleIndex = 3;
            // 
            // pnlSalesTop
            // 
            this.pnlSalesTop.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlSalesTop.Controls.Add(this.btnInitSales);
            this.pnlSalesTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSalesTop.Location = new System.Drawing.Point(0, 0);
            this.pnlSalesTop.Name = "pnlSalesTop";
            this.pnlSalesTop.Size = new System.Drawing.Size(778, 45);
            this.pnlSalesTop.TabIndex = 0;
            // 
            // btnInitSales
            // 
            this.btnInitSales.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInitSales.Appearance.Options.UseFont = true;
            this.btnInitSales.Location = new System.Drawing.Point(6, 6);
            this.btnInitSales.Name = "btnInitSales";
            this.btnInitSales.Size = new System.Drawing.Size(150, 33);
            this.btnInitSales.TabIndex = 0;
            this.btnInitSales.Text = "ინიციალიზაცია";
            this.btnInitSales.Click += new System.EventHandler(this.btnInitSales_Click);
            // 
            // frmSynchronizeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.xtraTabControl);
            this.Name = "frmSynchronizeEdit";
            this.ObjectName = Apothex.DataType.ObjectNames.Synchronize;
            this.OptionsBaseForm.Text = "სინქრონიზაცია";
            this.Text = "სინქრონიზაცია";
            this.Controls.SetChildIndex(this.xtraTabControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chklstTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabServerError.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoServerXml.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlServerErrorTop)).EndInit();
            this.pnlServerErrorTop.ResumeLayout(false);
            this.pnlServerErrorTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerErrorObjectID.Properties)).EndInit();
            this.tabLocalError.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoLocalXml.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLocalErrorTop)).EndInit();
            this.pnlLocalErrorTop.ResumeLayout(false);
            this.pnlLocalErrorTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalErrorObjectID.Properties)).EndInit();
            this.tabSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSyncSalesOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SyncSalesOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSalesTop)).EndInit();
            this.pnlSalesTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckedListBoxControl chklstTable;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage tabMain;
        private DevExpress.XtraTab.XtraTabPage tabServerError;
        private DevExpress.XtraTab.XtraTabPage tabLocalError;
        private DevExpress.XtraEditors.MemoEdit memoServerXml;
        private DevExpress.XtraEditors.PanelControl pnlServerErrorTop;
        private DevExpress.XtraEditors.TextEdit txtServerErrorObjectID;
        private DevExpress.XtraEditors.LabelControl lblServerErrorObjectID;
        private DevExpress.XtraEditors.MemoEdit memoLocalXml;
        private DevExpress.XtraEditors.PanelControl pnlLocalErrorTop;
        private DevExpress.XtraEditors.TextEdit txtLocalErrorObjectID;
        private DevExpress.XtraEditors.LabelControl lblLocalErrorObjectID;
        private DevExpress.XtraTab.XtraTabPage tabSales;
        private DevExpress.XtraEditors.PanelControl pnlSalesTop;
        private DevExpress.XtraGrid.GridControl gridSales;
        private DevExpress.XtraGrid.Views.Grid.GridView viewSales;
        private DevExpress.XtraEditors.SimpleButton btnInitSales;
        private System.Windows.Forms.BindingSource bsSyncSalesOrderDetail;
        private DataType.DS_SyncSalesOrderDetail ds_SyncSalesOrderDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductLocationID;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleQty;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesOrderID;
    }
}