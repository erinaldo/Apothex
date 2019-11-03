namespace Apothex.Dictionary
{
    partial class frmGenericBrowse
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
            this.cboxName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.view = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGenericName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenericID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApproverUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ds = new Apothex.DataType.DS_Dictionary();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.cboxName);
            this.pnlFilter.Controls.Add(this.txtName);
            this.pnlFilter.Controls.Add(this.lblName);
            this.pnlFilter.Controls.SetChildIndex(this.btnFilter, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblName, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtName, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxName, 0);
            // 
            // bsGridControl
            // 
            this.bsGridControl.DataMember = "VW_Generic";
            this.bsGridControl.DataSource = this.ds;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.grid);
            this.pnlGrid.Location = new System.Drawing.Point(0, 134);
            this.pnlGrid.Size = new System.Drawing.Size(784, 428);
            // 
            // btnFilter
            // 
            this.btnFilter.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.Appearance.Options.UseFont = true;
            this.btnFilter.Location = new System.Drawing.Point(270, 35);
            // 
            // popupMenu
            // 
            this.popupMenu.MenuAppearance.Menu.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popupMenu.MenuAppearance.Menu.Options.UseFont = true;
            // 
            // cboxName
            // 
            this.cboxName.EditValue = "%a%";
            this.cboxName.EnterMoveNextControl = true;
            this.cboxName.Location = new System.Drawing.Point(108, 6);
            this.cboxName.Name = "cboxName";
            this.cboxName.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxName.Properties.Appearance.Options.UseFont = true;
            this.cboxName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxName.Properties.Items.AddRange(new object[] {
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
            this.cboxName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxName.Size = new System.Drawing.Size(75, 23);
            this.cboxName.TabIndex = 1;
            this.cboxName.SelectedIndexChanged += new System.EventHandler(this.cboxName_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.EnterMoveNextControl = true;
            this.txtName.Location = new System.Drawing.Point(189, 6);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(231, 23);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Appearance.Options.UseFont = true;
            this.lblName.Location = new System.Drawing.Point(5, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(97, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "დასახელება:";
            // 
            // grid
            // 
            this.grid.DataSource = this.bsGridControl;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.view;
            this.grid.MenuManager = this.barManager;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(784, 428);
            this.grid.TabIndex = 0;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view});
            // 
            // view
            // 
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGenericName,
            this.colGenericID,
            this.colStatus,
            this.colModifiedDate,
            this.colModifiedUserID,
            this.colModifier,
            this.colApproverUserID,
            this.colApprover});
            this.view.GridControl = this.grid;
            this.view.Name = "view";
            // 
            // colGenericName
            // 
            this.colGenericName.Caption = "ჯენერიკი";
            this.colGenericName.FieldName = "GenericName";
            this.colGenericName.Name = "colGenericName";
            this.colGenericName.Visible = true;
            this.colGenericName.VisibleIndex = 0;
            // 
            // colGenericID
            // 
            this.colGenericID.FieldName = "GenericID";
            this.colGenericID.Name = "colGenericID";
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // colModifiedDate
            // 
            this.colModifiedDate.Caption = "შეცლის თარიღი";
            this.colModifiedDate.DisplayFormat.FormatString = "G";
            this.colModifiedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colModifiedDate.FieldName = "ModifiedDate";
            this.colModifiedDate.Name = "colModifiedDate";
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
            this.ds.DataSetName = "DS_Dictionary";
            this.ds.Locale = new System.Globalization.CultureInfo("");
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmGenericBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "frmGenericBrowse";
            this.ObjectName = Apothex.DataType.ObjectNames.Generic;
            this.OptionsListForm.IsBlockable = false;
            this.OptionsListForm.IsEditable = true;
            this.OptionsListForm.IsSystemColumnsable = true;
            this.OptionsListForm.IsUnblockable = false;
            this.OptionsGrid.ColumnID = "GenericID";
            this.OptionsGrid.ColumnStatusID = "Status";
            this.OptionsGrid.GridView = this.view;
            this.Text = "ჯენერიკები";
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cboxName;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView view;
        private Apothex.DataType.DS_Dictionary ds;
        private DevExpress.XtraGrid.Columns.GridColumn colGenericName;
        private DevExpress.XtraGrid.Columns.GridColumn colGenericID;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraGrid.Columns.GridColumn colApproverUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colApprover;
    }
}