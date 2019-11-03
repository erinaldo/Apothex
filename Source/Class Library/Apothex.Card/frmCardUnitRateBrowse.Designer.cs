namespace Apothex.Card
{
    partial class frmCardUnitRateBrowse
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
            this.ds = new Apothex.DataType.DS_Card();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.view = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaxUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreator = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifierID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            // 
            // bsGridControl
            // 
            this.bsGridControl.DataMember = "VW_CardUnitRate";
            this.bsGridControl.DataSource = this.ds;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.grid);
            this.pnlGrid.Location = new System.Drawing.Point(0, 39);
            this.pnlGrid.Size = new System.Drawing.Size(784, 523);
            // 
            // btnFilter
            // 
            this.btnFilter.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.Appearance.Options.UseFont = true;
            // 
            // popupMenu
            // 
            this.popupMenu.MenuAppearance.Menu.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popupMenu.MenuAppearance.Menu.Options.UseFont = true;
            // 
            // ds
            // 
            this.ds.DataSetName = "DS_Card";
            this.ds.Locale = new System.Globalization.CultureInfo("");
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grid
            // 
            this.grid.DataSource = this.bsGridControl;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.view;
            this.grid.MenuManager = this.barManager;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(784, 523);
            this.grid.TabIndex = 0;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view});
            // 
            // view
            // 
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMinUnit,
            this.colMaxUnit,
            this.colDiscount,
            this.colAmount,
            this.colCreateDate,
            this.colCreatorID,
            this.colCreator,
            this.colModifiedDate,
            this.colModifierID,
            this.colModifier});
            this.view.GridControl = this.grid;
            this.view.Name = "view";
            this.view.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMinUnit, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMaxUnit, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colMinUnit
            // 
            this.colMinUnit.Caption = "მინიმალური";
            this.colMinUnit.DisplayFormat.FormatString = "n4";
            this.colMinUnit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMinUnit.FieldName = "MinAmount";
            this.colMinUnit.GroupFormat.FormatString = "n4";
            this.colMinUnit.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMinUnit.Name = "colMinUnit";
            this.colMinUnit.Visible = true;
            this.colMinUnit.VisibleIndex = 0;
            // 
            // colMaxUnit
            // 
            this.colMaxUnit.Caption = "მაქსიმალური";
            this.colMaxUnit.DisplayFormat.FormatString = "n4";
            this.colMaxUnit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMaxUnit.FieldName = "MaxAmount";
            this.colMaxUnit.GroupFormat.FormatString = "n4";
            this.colMaxUnit.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMaxUnit.Name = "colMaxUnit";
            this.colMaxUnit.Visible = true;
            this.colMaxUnit.VisibleIndex = 1;
            // 
            // colDiscount
            // 
            this.colDiscount.Caption = "ქულა";
            this.colDiscount.DisplayFormat.FormatString = "n4";
            this.colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscount.FieldName = "Unit";
            this.colDiscount.GroupFormat.FormatString = "n4";
            this.colDiscount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Visible = true;
            this.colDiscount.VisibleIndex = 2;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "თანხა";
            this.colAmount.DisplayFormat.FormatString = "p4";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.GroupFormat.FormatString = "p2";
            this.colAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 3;
            // 
            // colCreateDate
            // 
            this.colCreateDate.DisplayFormat.FormatString = "G";
            this.colCreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            // 
            // colCreatorID
            // 
            this.colCreatorID.FieldName = "CreatorID";
            this.colCreatorID.Name = "colCreatorID";
            // 
            // colCreator
            // 
            this.colCreator.FieldName = "Creator";
            this.colCreator.Name = "colCreator";
            // 
            // colModifiedDate
            // 
            this.colModifiedDate.DisplayFormat.FormatString = "G";
            this.colModifiedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colModifiedDate.FieldName = "ModifiedDate";
            this.colModifiedDate.Name = "colModifiedDate";
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
            // frmCardUnitRateBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "frmCardUnitRateBrowse";
            this.ObjectName = Apothex.DataType.ObjectNames.CardUnitRate;
            this.OptionsBaseForm.Text = "ბარათის ქულის ექვივალენტები";
            this.OptionsListForm.IsApprovable = false;
            this.OptionsListForm.IsBlockable = false;
            this.OptionsListForm.IsDisapprovable = false;
            this.OptionsListForm.IsEditable = true;
            this.OptionsListForm.IsFilterable = false;
            this.OptionsListForm.IsFilterApprovable = false;
            this.OptionsListForm.IsSystemColumnsable = true;
            this.OptionsListForm.IsTopable = false;
            this.OptionsListForm.IsUnblockable = false;
            this.OptionsGrid.GridView = this.view;
            this.TableName = "Card.VW_CardUnitRate";
            this.Text = "ბარათის ქულის ექვივალენტები";
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataType.DS_Card ds;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView view;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMinUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colMaxUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatorID;
        private DevExpress.XtraGrid.Columns.GridColumn colCreator;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colModifierID;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
    }
}