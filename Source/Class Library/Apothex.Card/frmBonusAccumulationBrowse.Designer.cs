namespace Apothex.Card
{
    partial class frmBonusAccumulationBrowse
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
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.view = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFullName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPersonalNumber = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCardNumber = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colAccumulatedAmount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAccumulatedUnit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colExpensedUnit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colExpensedAmount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ds = new Apothex.DataType.DS_Card();
            this.dateHandle2 = new DevExpress.XtraEditors.DateEdit();
            this.dateHandle1 = new DevExpress.XtraEditors.DateEdit();
            this.lblHandlePeriod = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHandle2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHandle2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHandle1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHandle1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.dateHandle2);
            this.pnlFilter.Controls.Add(this.dateHandle1);
            this.pnlFilter.Controls.Add(this.lblHandlePeriod);
            this.pnlFilter.Controls.SetChildIndex(this.btnFilter, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblHandlePeriod, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateHandle1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateHandle2, 0);
            // 
            // bsGridControl
            // 
            this.bsGridControl.DataMember = "VW_BonusAccumulation";
            this.bsGridControl.DataSource = this.ds;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.grid);
            // 
            // btnFilter
            // 
            this.btnFilter.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.Appearance.Options.UseFont = true;
            this.btnFilter.Location = new System.Drawing.Point(247, 35);
            // 
            // popupMenu
            // 
            this.popupMenu.MenuAppearance.Menu.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popupMenu.MenuAppearance.Menu.Options.UseFont = true;
            // 
            // grid
            // 
            this.grid.DataSource = this.bsGridControl;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.view;
            this.grid.MenuManager = this.barManager;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(784, 423);
            this.grid.TabIndex = 0;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view});
            // 
            // view
            // 
            this.view.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4});
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colFullName,
            this.colPersonalNumber,
            this.colCardNumber,
            this.colAccumulatedUnit,
            this.colAccumulatedAmount,
            this.colExpensedUnit,
            this.colExpensedAmount,
            this.bandedGridColumn1,
            this.bandedGridColumn2});
            this.view.GridControl = this.grid;
            this.view.Name = "view";
            this.view.OptionsView.ShowFooter = true;
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.colFullName);
            this.gridBand1.Columns.Add(this.colPersonalNumber);
            this.gridBand1.Columns.Add(this.colCardNumber);
            this.gridBand1.MinWidth = 20;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 225;
            // 
            // colFullName
            // 
            this.colFullName.Caption = "სახელი, გვარი";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            // 
            // colPersonalNumber
            // 
            this.colPersonalNumber.Caption = "პირადი №";
            this.colPersonalNumber.FieldName = "PersonalNumber";
            this.colPersonalNumber.Name = "colPersonalNumber";
            this.colPersonalNumber.Visible = true;
            // 
            // colCardNumber
            // 
            this.colCardNumber.Caption = "დაგროვების ბარათის №";
            this.colCardNumber.FieldName = "CardNumber";
            this.colCardNumber.Name = "colCardNumber";
            this.colCardNumber.Visible = true;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "დაგროვილი";
            this.gridBand2.Columns.Add(this.colAccumulatedUnit);
            this.gridBand2.Columns.Add(this.colAccumulatedAmount);
            this.gridBand2.MinWidth = 20;
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 150;
            // 
            // colAccumulatedAmount
            // 
            this.colAccumulatedAmount.Caption = "თანხა";
            this.colAccumulatedAmount.FieldName = "AccumulatedAmount";
            this.colAccumulatedAmount.Name = "colAccumulatedAmount";
            this.colAccumulatedAmount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colAccumulatedAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAccumulatedAmount.Visible = true;
            // 
            // colAccumulatedUnit
            // 
            this.colAccumulatedUnit.Caption = "ქულა";
            this.colAccumulatedUnit.FieldName = "AccumulatedUnit";
            this.colAccumulatedUnit.Name = "colAccumulatedUnit";
            this.colAccumulatedUnit.SummaryItem.DisplayFormat = "{0:n2}";
            this.colAccumulatedUnit.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAccumulatedUnit.Visible = true;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "გახარჯული";
            this.gridBand3.Columns.Add(this.colExpensedUnit);
            this.gridBand3.Columns.Add(this.colExpensedAmount);
            this.gridBand3.MinWidth = 20;
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Width = 150;
            // 
            // colExpensedUnit
            // 
            this.colExpensedUnit.Caption = "ქულა";
            this.colExpensedUnit.FieldName = "ExpensedUnit";
            this.colExpensedUnit.Name = "colExpensedUnit";
            this.colExpensedUnit.SummaryItem.DisplayFormat = "{0:n2}";
            this.colExpensedUnit.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colExpensedUnit.Visible = true;
            // 
            // colExpensedAmount
            // 
            this.colExpensedAmount.Caption = "თანხა";
            this.colExpensedAmount.FieldName = "ExpensedAmount";
            this.colExpensedAmount.Name = "colExpensedAmount";
            this.colExpensedAmount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colExpensedAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colExpensedAmount.Visible = true;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "ნაშთი";
            this.gridBand4.Columns.Add(this.bandedGridColumn1);
            this.gridBand4.Columns.Add(this.bandedGridColumn2);
            this.gridBand4.MinWidth = 20;
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.Width = 150;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Caption = "ქულა";
            this.bandedGridColumn1.FieldName = "bandedGridColumn1";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.SummaryItem.DisplayFormat = "{0:n2}";
            this.bandedGridColumn1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.bandedGridColumn1.UnboundExpression = "[AccumulatedUnit]-[ExpensedUnit]";
            this.bandedGridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.bandedGridColumn1.Visible = true;
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.Caption = "თანხა";
            this.bandedGridColumn2.FieldName = "bandedGridColumn2";
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.SummaryItem.DisplayFormat = "{0:n2}";
            this.bandedGridColumn2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.bandedGridColumn2.UnboundExpression = "[AccumulatedAmount]-[ExpensedAmount]";
            this.bandedGridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.bandedGridColumn2.Visible = true;
            // 
            // ds
            // 
            this.ds.DataSetName = "DS_Card";
            this.ds.Locale = new System.Globalization.CultureInfo("");
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateHandle2
            // 
            this.dateHandle2.EditValue = null;
            this.dateHandle2.EnterMoveNextControl = true;
            this.dateHandle2.Location = new System.Drawing.Point(247, 6);
            this.dateHandle2.MenuManager = this.barManager;
            this.dateHandle2.Name = "dateHandle2";
            this.dateHandle2.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateHandle2.Properties.Appearance.Options.UseFont = true;
            this.dateHandle2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateHandle2.Properties.DisplayFormat.FormatString = "G";
            this.dateHandle2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateHandle2.Properties.EditFormat.FormatString = "G";
            this.dateHandle2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateHandle2.Properties.Mask.EditMask = "G";
            this.dateHandle2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateHandle2.Size = new System.Drawing.Size(150, 23);
            this.dateHandle2.TabIndex = 102;
            // 
            // dateHandle1
            // 
            this.dateHandle1.EditValue = null;
            this.dateHandle1.EnterMoveNextControl = true;
            this.dateHandle1.Location = new System.Drawing.Point(91, 6);
            this.dateHandle1.MenuManager = this.barManager;
            this.dateHandle1.Name = "dateHandle1";
            this.dateHandle1.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateHandle1.Properties.Appearance.Options.UseFont = true;
            this.dateHandle1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateHandle1.Properties.DisplayFormat.FormatString = "G";
            this.dateHandle1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateHandle1.Properties.EditFormat.FormatString = "G";
            this.dateHandle1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateHandle1.Properties.Mask.EditMask = "G";
            this.dateHandle1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateHandle1.Size = new System.Drawing.Size(150, 23);
            this.dateHandle1.TabIndex = 101;
            // 
            // lblHandlePeriod
            // 
            this.lblHandlePeriod.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHandlePeriod.Location = new System.Drawing.Point(12, 9);
            this.lblHandlePeriod.Name = "lblHandlePeriod";
            this.lblHandlePeriod.Size = new System.Drawing.Size(73, 17);
            this.lblHandlePeriod.TabIndex = 100;
            this.lblHandlePeriod.Text = "პერიოდი:";
            // 
            // frmBonusAccumulationBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "frmBonusAccumulationBrowse";
            this.ObjectName = Apothex.DataType.ObjectNames.BonusAccumulation;
            this.OptionsBaseForm.Text = "ბარათის გატარების ჯამური რეესტრი";
            this.OptionsListForm.IsAddable = false;
            this.OptionsListForm.IsApprovable = false;
            this.OptionsListForm.IsAutoRefreshVisible = false;
            this.OptionsListForm.IsBlockable = false;
            this.OptionsListForm.IsChooseable = false;
            this.OptionsListForm.IsDeletable = false;
            this.OptionsListForm.IsDisapprovable = false;
            this.OptionsListForm.IsEditable = false;
            this.OptionsListForm.IsFilterApprovable = false;
            this.OptionsListForm.IsSystemColumnsable = true;
            this.OptionsListForm.IsTopable = false;
            this.OptionsListForm.IsUnblockable = false;
            this.OptionsGrid.AutoInitStyleFormat = false;
            this.OptionsGrid.GridView = this.view;
            this.Text = "ბარათის გატარების ჯამური რეესტრი";
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHandle2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHandle2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHandle1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHandle1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view;
        private DataType.DS_Card ds;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFullName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPersonalNumber;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCardNumber;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAccumulatedUnit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAccumulatedAmount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colExpensedUnit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colExpensedAmount;
        private DevExpress.XtraEditors.DateEdit dateHandle2;
        private DevExpress.XtraEditors.DateEdit dateHandle1;
        private DevExpress.XtraEditors.LabelControl lblHandlePeriod;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
    }
}