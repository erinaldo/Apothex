namespace Apothex.Dictionary
{
    partial class frmMedicamentLocation
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
            this.lblMedicament = new DevExpress.XtraEditors.LabelControl();
            this.bbMedicament = new Apothex.Windows.Forms.ButtonBrowse();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.bsGrid = new System.Windows.Forms.BindingSource(this.components);
            this.ds_ProductLocation = new Apothex.DataType.DS_ProductLocation();
            this.view = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBranchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbMedicament.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ProductLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Appearance.Options.UseFont = true;
            this.btnOk.Location = new System.Drawing.Point(144, 227);
            this.btnOk.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(219, 227);
            // 
            // lblMedicament
            // 
            this.lblMedicament.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMedicament.Location = new System.Drawing.Point(6, 6);
            this.lblMedicament.Name = "lblMedicament";
            this.lblMedicament.Size = new System.Drawing.Size(90, 17);
            this.lblMedicament.TabIndex = 100;
            this.lblMedicament.Text = "პროდუქცია:";
            // 
            // bbMedicament
            // 
            this.bbMedicament.EnterMoveNextControl = true;
            this.bbMedicament.IsOnline = true;
            this.bbMedicament.Location = new System.Drawing.Point(110, 3);
            this.bbMedicament.Name = "bbMedicament";
            this.bbMedicament.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F);
            this.bbMedicament.Properties.Appearance.Options.UseFont = true;
            this.bbMedicament.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject1, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject2, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbMedicament.Properties.ReadOnly = true;
            this.bbMedicament.Size = new System.Drawing.Size(472, 23);
            this.bbMedicament.TabIndex = 101;
            this.bbMedicament.TableName = Apothex.DataType.ObjectNames.Medicament;
            // 
            // grid
            // 
            this.grid.DataSource = this.bsGrid;
            this.grid.Location = new System.Drawing.Point(6, 32);
            this.grid.MainView = this.view;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(576, 189);
            this.grid.TabIndex = 102;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view});
            // 
            // bsGrid
            // 
            this.bsGrid.DataMember = "VW_ProductLocation";
            this.bsGrid.DataSource = this.ds_ProductLocation;
            // 
            // ds_ProductLocation
            // 
            this.ds_ProductLocation.DataSetName = "DS_ProductLocation";
            this.ds_ProductLocation.Locale = new System.Globalization.CultureInfo("");
            this.ds_ProductLocation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view
            // 
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBranchName,
            this.colQuantity,
            this.colCountryName,
            this.colBrandName,
            this.colSerie});
            this.view.GridControl = this.grid;
            this.view.Name = "view";
            this.view.OptionsBehavior.Editable = false;
            this.view.OptionsCustomization.AllowFilter = false;
            this.view.OptionsCustomization.AllowGroup = false;
            this.view.OptionsView.ShowGroupPanel = false;
            this.view.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colBranchName, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colBranchName
            // 
            this.colBranchName.Caption = "ფილიალი";
            this.colBranchName.FieldName = "BranchName";
            this.colBranchName.Name = "colBranchName";
            this.colBranchName.Visible = true;
            this.colBranchName.VisibleIndex = 0;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "ნაშთი";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            // 
            // colCountryName
            // 
            this.colCountryName.Caption = "მწ. ქვეყანა";
            this.colCountryName.FieldName = "CountryName";
            this.colCountryName.Name = "colCountryName";
            this.colCountryName.Visible = true;
            this.colCountryName.VisibleIndex = 2;
            // 
            // colBrandName
            // 
            this.colBrandName.Caption = "ბრენდი";
            this.colBrandName.FieldName = "BrandName";
            this.colBrandName.Name = "colBrandName";
            this.colBrandName.Visible = true;
            this.colBrandName.VisibleIndex = 3;
            // 
            // colSerie
            // 
            this.colSerie.Caption = "სერია";
            this.colSerie.FieldName = "Serie";
            this.colSerie.Name = "colSerie";
            this.colSerie.Visible = true;
            this.colSerie.VisibleIndex = 4;
            // 
            // frmMedicamentLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 272);
            this.Controls.Add(this.lblMedicament);
            this.Controls.Add(this.bbMedicament);
            this.Controls.Add(this.grid);
            this.Name = "frmMedicamentLocation";
            this.OptionsBaseForm.Text = "მედიკამენტის ადგილმდებარეობა";
            this.OptionsEditForm.AutoFormatText = false;
            this.OptionsEditForm.AutoUpdateAction = false;
            this.OptionsPermission.AutoCheckPermission = false;
            this.OptionsPermission.AutoInitPermission = false;
            this.Text = "მედიკამენტის ადგილმდებარეობა";
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this.bbMedicament, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lblMedicament, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbMedicament.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ProductLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblMedicament;
        private Windows.Forms.ButtonBrowse bbMedicament;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView view;
        private System.Windows.Forms.BindingSource bsGrid;
        private DataType.DS_ProductLocation ds_ProductLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryName;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandName;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
    }
}