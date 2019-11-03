namespace Apothex.Dictionary
{
    partial class frmBankBrowse
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
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApproverUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblBankCode = new DevExpress.XtraEditors.LabelControl();
            this.lblBankName = new DevExpress.XtraEditors.LabelControl();
            this.txtBankCode = new DevExpress.XtraEditors.TextEdit();
            this.txtBankName = new DevExpress.XtraEditors.TextEdit();
            this.ds = new Apothex.DataType.DS_Dictionary();
            this.cboxBankName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboxBankCode = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxBankCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.cboxBankCode);
            this.pnlFilter.Controls.Add(this.cboxBankName);
            this.pnlFilter.Controls.Add(this.lblBankCode);
            this.pnlFilter.Controls.Add(this.lblBankName);
            this.pnlFilter.Controls.Add(this.txtBankCode);
            this.pnlFilter.Controls.Add(this.txtBankName);
            this.pnlFilter.Controls.SetChildIndex(this.btnFilter, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtBankName, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtBankCode, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblBankName, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblBankCode, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxBankName, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxBankCode, 0);
            // 
            // bsGridControl
            // 
            this.bsGridControl.DataMember = "VW_Bank";
            this.bsGridControl.DataSource = this.ds;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridControl);
            this.pnlGrid.Location = new System.Drawing.Point(0, 134);
            this.pnlGrid.Size = new System.Drawing.Size(784, 428);
            // 
            // btnFilter
            // 
            this.btnFilter.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.Appearance.Options.UseFont = true;
            this.btnFilter.Location = new System.Drawing.Point(403, 25);
            // 
            // popupMenu
            // 
            this.popupMenu.MenuAppearance.Menu.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popupMenu.MenuAppearance.Menu.Options.UseFont = true;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bsGridControl;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(784, 428);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colBankCode,
            this.colModifier,
            this.colApprover,
            this.colBankID,
            this.colStatus,
            this.colModifiedUserID,
            this.colModifiedDate,
            this.colApproverUserID});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            // 
            // colName
            // 
            this.colName.Caption = "ბანკი";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colBankCode
            // 
            this.colBankCode.Caption = "ბანკის კოდი";
            this.colBankCode.FieldName = "BankCode";
            this.colBankCode.Name = "colBankCode";
            // 
            // colModifier
            // 
            this.colModifier.Caption = "შეცვალა მომხ.";
            this.colModifier.FieldName = "Modifier";
            this.colModifier.Name = "colModifier";
            // 
            // colApprover
            // 
            this.colApprover.Caption = "დაამოწმა მომხ.";
            this.colApprover.FieldName = "Approver";
            this.colApprover.Name = "colApprover";
            // 
            // colBankID
            // 
            this.colBankID.FieldName = "BankID";
            this.colBankID.Name = "colBankID";
            // 
            // colModifiedUserID
            // 
            this.colModifiedUserID.FieldName = "ModifiedUserID";
            this.colModifiedUserID.Name = "colModifiedUserID";
            // 
            // colModifiedDate
            // 
            this.colModifiedDate.Caption = "შეცვლის თარიღი";
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
            // lblBankCode
            // 
            this.lblBankCode.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBankCode.Appearance.Options.UseFont = true;
            this.lblBankCode.Location = new System.Drawing.Point(6, 38);
            this.lblBankCode.Name = "lblBankCode";
            this.lblBankCode.Size = new System.Drawing.Size(85, 17);
            this.lblBankCode.TabIndex = 3;
            this.lblBankCode.Text = "ბანკ. კოდი:";
            // 
            // lblBankName
            // 
            this.lblBankName.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBankName.Appearance.Options.UseFont = true;
            this.lblBankName.Location = new System.Drawing.Point(6, 9);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(44, 17);
            this.lblBankName.TabIndex = 0;
            this.lblBankName.Text = "ბანკი:";
            // 
            // txtBankCode
            // 
            this.txtBankCode.EnterMoveNextControl = true;
            this.txtBankCode.Location = new System.Drawing.Point(178, 35);
            this.txtBankCode.Name = "txtBankCode";
            this.txtBankCode.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBankCode.Properties.Appearance.Options.UseFont = true;
            this.txtBankCode.Properties.Mask.EditMask = "\\d{0,25}";
            this.txtBankCode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtBankCode.Size = new System.Drawing.Size(219, 23);
            this.txtBankCode.TabIndex = 5;
            // 
            // txtBankName
            // 
            this.txtBankName.EnterMoveNextControl = true;
            this.txtBankName.Location = new System.Drawing.Point(178, 6);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBankName.Properties.Appearance.Options.UseFont = true;
            this.txtBankName.Size = new System.Drawing.Size(219, 23);
            this.txtBankName.TabIndex = 2;
            // 
            // ds
            // 
            this.ds.DataSetName = "DS_Dictionary";
            this.ds.Locale = new System.Globalization.CultureInfo("");
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboxBankName
            // 
            this.cboxBankName.EditValue = "%a%";
            this.cboxBankName.EnterMoveNextControl = true;
            this.cboxBankName.Location = new System.Drawing.Point(97, 6);
            this.cboxBankName.Name = "cboxBankName";
            this.cboxBankName.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxBankName.Properties.Appearance.Options.UseFont = true;
            this.cboxBankName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxBankName.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!=",
            "%a%",
            "!%a%",
            "a%",
            "!a%",
            "%a",
            "!%a"});
            this.cboxBankName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxBankName.Size = new System.Drawing.Size(75, 23);
            this.cboxBankName.TabIndex = 1;
            this.cboxBankName.SelectedIndexChanged += new System.EventHandler(this.cboxBankName_SelectedIndexChanged);
            // 
            // cboxBankCode
            // 
            this.cboxBankCode.EditValue = "%a%";
            this.cboxBankCode.EnterMoveNextControl = true;
            this.cboxBankCode.Location = new System.Drawing.Point(97, 35);
            this.cboxBankCode.Name = "cboxBankCode";
            this.cboxBankCode.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxBankCode.Properties.Appearance.Options.UseFont = true;
            this.cboxBankCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxBankCode.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!=",
            "%a%",
            "!%a%",
            "a%",
            "!a%",
            "%a",
            "!%a"});
            this.cboxBankCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxBankCode.Size = new System.Drawing.Size(75, 23);
            this.cboxBankCode.TabIndex = 4;
            this.cboxBankCode.SelectedIndexChanged += new System.EventHandler(this.cboxBankCode_SelectedIndexChanged);
            // 
            // frmBankBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "frmBankBrowse";
            this.ObjectName = Apothex.DataType.ObjectNames.Bank;
            this.OptionsListForm.IsEditable = true;
            this.OptionsListForm.IsSystemColumnsable = true;
            this.OptionsGrid.ColumnID = "BankID";
            this.OptionsGrid.ColumnStatusID = "Status";
            this.OptionsGrid.GridView = this.gridView;
            this.Text = "ბანკები";
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxBankCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraEditors.LabelControl lblBankCode;
        private DevExpress.XtraEditors.LabelControl lblBankName;
        private DevExpress.XtraEditors.TextEdit txtBankCode;
        private DevExpress.XtraEditors.TextEdit txtBankName;
        private DevExpress.XtraGrid.Columns.GridColumn colBankCode;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colApprover;
        private DevExpress.XtraGrid.Columns.GridColumn colBankID;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colApproverUserID;
        private Apothex.DataType.DS_Dictionary ds;
        private DevExpress.XtraEditors.ComboBoxEdit cboxBankCode;
        private DevExpress.XtraEditors.ComboBoxEdit cboxBankName;
    }
}