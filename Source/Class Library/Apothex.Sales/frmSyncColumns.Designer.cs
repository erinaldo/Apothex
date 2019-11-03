namespace Apothex.Sales
{
    partial class frmSyncColumns
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
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.bsColumn = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Column = new DS_Column();
            this.view = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSource = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riTarget = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Column)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Appearance.Options.UseFont = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Appearance.Options.UseFont = true;
            // 
            // grid
            // 
            this.grid.DataSource = this.bsColumn;
            this.grid.Dock = System.Windows.Forms.DockStyle.Top;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.view;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riTarget});
            this.grid.Size = new System.Drawing.Size(394, 221);
            this.grid.TabIndex = 100;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view});
            // 
            // bsColumn
            // 
            this.bsColumn.DataMember = "T_Columns";
            this.bsColumn.DataSource = this.ds_Column;
            // 
            // ds_Column
            // 
            this.ds_Column.DataSetName = "DS_Column";
            this.ds_Column.Locale = new System.Globalization.CultureInfo("");
            this.ds_Column.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view
            // 
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSource,
            this.colTarget});
            this.view.GridControl = this.grid;
            this.view.Name = "view";
            this.view.OptionsCustomization.AllowColumnMoving = false;
            this.view.OptionsCustomization.AllowGroup = false;
            this.view.OptionsMenu.EnableColumnMenu = false;
            this.view.OptionsNavigation.EnterMoveNextColumn = true;
            this.view.OptionsView.ShowGroupPanel = false;
            // 
            // colSource
            // 
            this.colSource.FieldName = "Source";
            this.colSource.Name = "colSource";
            this.colSource.OptionsColumn.AllowEdit = false;
            this.colSource.Visible = true;
            this.colSource.VisibleIndex = 0;
            // 
            // colTarget
            // 
            this.colTarget.ColumnEdit = this.riTarget;
            this.colTarget.FieldName = "Target";
            this.colTarget.Name = "colTarget";
            this.colTarget.Visible = true;
            this.colTarget.VisibleIndex = 1;
            // 
            // riTarget
            // 
            this.riTarget.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.riTarget.AutoHeight = false;
            this.riTarget.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riTarget.Name = "riTarget";
            this.riTarget.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // frmSyncColumns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 272);
            this.Controls.Add(this.grid);
            this.Name = "frmSyncColumns";
            this.OptionsBaseForm.Text = "Sync Columns";
            this.OptionsEditForm.AutoFormatText = false;
            this.OptionsEditForm.AutoUpdateAction = false;
            this.OptionsEditForm.PromptSave = false;
            this.OptionsPermission.AutoCheckPermission = false;
            this.OptionsPermission.AutoInitPermission = false;
            this.Text = "Sync Columns";
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Column)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riTarget)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView view;
        private System.Windows.Forms.BindingSource bsColumn;
        private DS_Column ds_Column;
        private DevExpress.XtraGrid.Columns.GridColumn colSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTarget;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox riTarget;
    }
}