namespace Apothex.Dictionary
{
    partial class frmMergeMedicamentBrowse
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
            this.colFromMedicamentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToMedicamentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromMedicamentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToMedicamentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ds = new Apothex.DataType.DS_Dictionary();
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
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Location = new System.Drawing.Point(0, 57);
            // 
            // bsGridControl
            // 
            this.bsGridControl.DataMember = "VW_MergeMedicament";
            this.bsGridControl.DataSource = this.ds;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridControl);
            this.pnlGrid.Location = new System.Drawing.Point(0, 39);
            this.pnlGrid.Size = new System.Drawing.Size(784, 523);
            // 
            // btnFilter
            // 
            this.btnFilter.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.Appearance.Options.UseFont = true;
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
            this.gridControl.Size = new System.Drawing.Size(784, 523);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFromMedicamentName,
            this.colToMedicamentName,
            this.colFromMedicamentID,
            this.colToMedicamentID,
            this.colModifiedUserID,
            this.colModifier,
            this.colModifiedDate});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            // 
            // colFromMedicamentName
            // 
            this.colFromMedicamentName.Caption = "მედიკამენტიდან";
            this.colFromMedicamentName.FieldName = "FromMedicamentName";
            this.colFromMedicamentName.Name = "colFromMedicamentName";
            this.colFromMedicamentName.Visible = true;
            this.colFromMedicamentName.VisibleIndex = 0;
            // 
            // colToMedicamentName
            // 
            this.colToMedicamentName.Caption = "მედიკამენტად";
            this.colToMedicamentName.FieldName = "ToMedicamentName";
            this.colToMedicamentName.Name = "colToMedicamentName";
            this.colToMedicamentName.Visible = true;
            this.colToMedicamentName.VisibleIndex = 1;
            // 
            // colFromMedicamentID
            // 
            this.colFromMedicamentID.FieldName = "FromMedicamentID";
            this.colFromMedicamentID.Name = "colFromMedicamentID";
            this.colFromMedicamentID.Tag = true;
            // 
            // colToMedicamentID
            // 
            this.colToMedicamentID.FieldName = "ToMedicamentID";
            this.colToMedicamentID.Name = "colToMedicamentID";
            this.colToMedicamentID.Tag = true;
            // 
            // colModifiedUserID
            // 
            this.colModifiedUserID.FieldName = "ModifiedUserID";
            this.colModifiedUserID.Name = "colModifiedUserID";
            this.colModifiedUserID.Tag = true;
            // 
            // colModifier
            // 
            this.colModifier.Caption = "შეცვალა";
            this.colModifier.FieldName = "Modifier";
            this.colModifier.Name = "colModifier";
            this.colModifier.Tag = true;
            // 
            // colModifiedDate
            // 
            this.colModifiedDate.Caption = "შეცვლის თარიღი";
            this.colModifiedDate.DisplayFormat.FormatString = "G";
            this.colModifiedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colModifiedDate.FieldName = "ModifiedDate";
            this.colModifiedDate.Name = "colModifiedDate";
            this.colModifiedDate.Tag = true;
            // 
            // ds
            // 
            this.ds.DataSetName = "DS_Dictionary";
            this.ds.Locale = new System.Globalization.CultureInfo("");
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmMergeMedicamentBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "frmMergeMedicamentBrowse";
            this.ObjectName = Apothex.DataType.ObjectNames.MergeMedicament;
            this.OptionsBaseForm.Text = "მედიკამენტების გაერთიანება";
            this.OptionsListForm.IsApprovable = false;
            this.OptionsListForm.IsBlockable = false;
            this.OptionsListForm.IsDisapprovable = false;
            this.OptionsListForm.IsEditable = true;
            this.OptionsListForm.IsFilterable = false;
            this.OptionsListForm.IsFilterApprovable = false;
            this.OptionsListForm.IsSystemColumnsable = true;
            this.OptionsListForm.IsUnblockable = false;
            this.OptionsListForm.ServerMode = true;
            this.OptionsGrid.ColumnID = "FromMedicamentID";
            this.OptionsGrid.GridView = this.gridView;
            this.Text = "მედიკამენტების გაერთიანება";
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
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private Apothex.DataType.DS_Dictionary ds;
        private DevExpress.XtraGrid.Columns.GridColumn colFromMedicamentName;
        private DevExpress.XtraGrid.Columns.GridColumn colToMedicamentName;
        private DevExpress.XtraGrid.Columns.GridColumn colFromMedicamentID;
        private DevExpress.XtraGrid.Columns.GridColumn colToMedicamentID;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
    }
}