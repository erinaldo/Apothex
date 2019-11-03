namespace Apothex.Request
{
    partial class frmRequestBrowse
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRequestID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequestDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifierID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApproverID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ds = new Apothex.DataType.DS_Request();
            this.cboxID = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblOrderID = new DevExpress.XtraEditors.LabelControl();
            this.dateOrderDate2 = new DevExpress.XtraEditors.DateEdit();
            this.dateOrderDate1 = new DevExpress.XtraEditors.DateEdit();
            this.cboxOrderDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblOrderDate = new DevExpress.XtraEditors.LabelControl();
            this.lblBranch = new DevExpress.XtraEditors.LabelControl();
            this.cboxBranch = new DevExpress.XtraEditors.ComboBoxEdit();
            this.bbBranch = new Apothex.Windows.Forms.ButtonBrowse();
            this.miSynchronize = new DevExpress.XtraBars.BarButtonItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.cboxID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbBranch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.bbBranch);
            this.pnlFilter.Controls.Add(this.lblBranch);
            this.pnlFilter.Controls.Add(this.dateOrderDate2);
            this.pnlFilter.Controls.Add(this.dateOrderDate1);
            this.pnlFilter.Controls.Add(this.cboxOrderDate);
            this.pnlFilter.Controls.Add(this.lblOrderDate);
            this.pnlFilter.Controls.Add(this.cboxBranch);
            this.pnlFilter.Controls.Add(this.cboxID);
            this.pnlFilter.Controls.Add(this.txtID);
            this.pnlFilter.Controls.Add(this.lblOrderID);
            this.pnlFilter.Controls.SetChildIndex(this.btnFilter, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblOrderID, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtID, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxID, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxBranch, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblOrderDate, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxOrderDate, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateOrderDate1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateOrderDate2, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblBranch, 0);
            this.pnlFilter.Controls.SetChildIndex(this.bbBranch, 0);
            // 
            // bsGridControl
            // 
            this.bsGridControl.DataMember = "VW_RequestHeader";
            this.bsGridControl.DataSource = this.ds;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridControl);
            // 
            // btnFilter
            // 
            this.btnFilter.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.Appearance.Options.UseFont = true;
            this.btnFilter.Location = new System.Drawing.Point(497, 52);
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
            this.gridControl.MenuManager = this.barManager;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(784, 423);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRequestID,
            this.colBranchName,
            this.colRequestDate,
            this.colBranchID,
            this.colStatus,
            this.colModifierID,
            this.colModifier,
            this.colModifiedDate,
            this.colApproverID,
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
            this.gridView.Name = "gridView";
            // 
            // colRequestID
            // 
            this.colRequestID.Caption = "შეკვეთის №";
            this.colRequestID.FieldName = "RequestID";
            this.colRequestID.Name = "colRequestID";
            this.colRequestID.Visible = true;
            this.colRequestID.VisibleIndex = 0;
            // 
            // colBranchName
            // 
            this.colBranchName.Caption = "ფილიალი";
            this.colBranchName.FieldName = "BranchName";
            this.colBranchName.Name = "colBranchName";
            this.colBranchName.Visible = true;
            this.colBranchName.VisibleIndex = 1;
            // 
            // colRequestDate
            // 
            this.colRequestDate.Caption = "თარიღი";
            this.colRequestDate.FieldName = "RequestDate";
            this.colRequestDate.Name = "colRequestDate";
            this.colRequestDate.Visible = true;
            this.colRequestDate.VisibleIndex = 2;
            // 
            // colBranchID
            // 
            this.colBranchID.FieldName = "BranchID";
            this.colBranchID.Name = "colBranchID";
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
            // colModifiedDate
            // 
            this.colModifiedDate.FieldName = "ModifiedDate";
            this.colModifiedDate.Name = "colModifiedDate";
            // 
            // colApproverID
            // 
            this.colApproverID.FieldName = "ApproverID";
            this.colApproverID.Name = "colApproverID";
            // 
            // colApprover
            // 
            this.colApprover.FieldName = "Approver";
            this.colApprover.Name = "colApprover";
            // 
            // ds
            // 
            this.ds.DataSetName = "DS_Request";
            this.ds.Locale = new System.Globalization.CultureInfo("");
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboxID
            // 
            this.cboxID.EditValue = "=";
            this.cboxID.EnterMoveNextControl = true;
            this.cboxID.Location = new System.Drawing.Point(99, 3);
            this.cboxID.Name = "cboxID";
            this.cboxID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxID.Properties.Appearance.Options.UseFont = true;
            this.cboxID.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxID.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxID.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!=",
            "a,b,c",
            "!a,b,c"});
            this.cboxID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxID.Size = new System.Drawing.Size(80, 23);
            this.cboxID.TabIndex = 1;
            this.cboxID.SelectedIndexChanged += new System.EventHandler(this.cboxID_SelectedIndexChanged);
            // 
            // txtID
            // 
            this.txtID.EnterMoveNextControl = true;
            this.txtID.Location = new System.Drawing.Point(185, 3);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Properties.DisplayFormat.FormatString = "f0";
            this.txtID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtID.Properties.EditFormat.FormatString = "f0";
            this.txtID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtID.Properties.Mask.EditMask = "[0-9,]+";
            this.txtID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtID.Properties.MaxLength = 10;
            this.txtID.Size = new System.Drawing.Size(306, 23);
            this.txtID.TabIndex = 2;
            // 
            // lblOrderID
            // 
            this.lblOrderID.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderID.Location = new System.Drawing.Point(12, 6);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(20, 17);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "№:";
            // 
            // dateOrderDate2
            // 
            this.dateOrderDate2.EditValue = null;
            this.dateOrderDate2.Enabled = false;
            this.dateOrderDate2.EnterMoveNextControl = true;
            this.dateOrderDate2.Location = new System.Drawing.Point(341, 62);
            this.dateOrderDate2.Name = "dateOrderDate2";
            this.dateOrderDate2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dateOrderDate2.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOrderDate2.Properties.Appearance.Options.UseFont = true;
            this.dateOrderDate2.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOrderDate2.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dateOrderDate2.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOrderDate2.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.dateOrderDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateOrderDate2.Properties.DisplayFormat.FormatString = "G";
            this.dateOrderDate2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateOrderDate2.Properties.EditFormat.FormatString = "G";
            this.dateOrderDate2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateOrderDate2.Properties.Mask.EditMask = "G";
            this.dateOrderDate2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateOrderDate2.Size = new System.Drawing.Size(150, 23);
            this.dateOrderDate2.TabIndex = 9;
            // 
            // dateOrderDate1
            // 
            this.dateOrderDate1.EditValue = null;
            this.dateOrderDate1.Enabled = false;
            this.dateOrderDate1.EnterMoveNextControl = true;
            this.dateOrderDate1.Location = new System.Drawing.Point(185, 61);
            this.dateOrderDate1.Name = "dateOrderDate1";
            this.dateOrderDate1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dateOrderDate1.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOrderDate1.Properties.Appearance.Options.UseFont = true;
            this.dateOrderDate1.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOrderDate1.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dateOrderDate1.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOrderDate1.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.dateOrderDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateOrderDate1.Properties.DisplayFormat.FormatString = "G";
            this.dateOrderDate1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateOrderDate1.Properties.EditFormat.FormatString = "G";
            this.dateOrderDate1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateOrderDate1.Properties.Mask.EditMask = "G";
            this.dateOrderDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateOrderDate1.Size = new System.Drawing.Size(150, 23);
            this.dateOrderDate1.TabIndex = 8;
            // 
            // cboxOrderDate
            // 
            this.cboxOrderDate.EnterMoveNextControl = true;
            this.cboxOrderDate.Location = new System.Drawing.Point(99, 61);
            this.cboxOrderDate.Name = "cboxOrderDate";
            this.cboxOrderDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxOrderDate.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxOrderDate.Properties.Appearance.Options.UseFont = true;
            this.cboxOrderDate.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxOrderDate.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxOrderDate.Properties.Items.AddRange(new object[] {
            "",
            "=",
            ">",
            "<",
            "[ ]"});
            this.cboxOrderDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxOrderDate.Size = new System.Drawing.Size(80, 23);
            this.cboxOrderDate.TabIndex = 7;
            this.cboxOrderDate.SelectedIndexChanged += new System.EventHandler(this.cboxOrderDate_SelectedIndexChanged);
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderDate.Location = new System.Drawing.Point(12, 64);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(65, 17);
            this.lblOrderDate.TabIndex = 6;
            this.lblOrderDate.Text = "თარიღი:";
            // 
            // lblBranch
            // 
            this.lblBranch.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBranch.Location = new System.Drawing.Point(12, 35);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(81, 17);
            this.lblBranch.TabIndex = 3;
            this.lblBranch.Text = "ფილიალი:";
            // 
            // cboxBranch
            // 
            this.cboxBranch.EditValue = "=";
            this.cboxBranch.EnterMoveNextControl = true;
            this.cboxBranch.Location = new System.Drawing.Point(99, 32);
            this.cboxBranch.Name = "cboxBranch";
            this.cboxBranch.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxBranch.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxBranch.Properties.Appearance.Options.UseFont = true;
            this.cboxBranch.Properties.AppearanceDropDown.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxBranch.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboxBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxBranch.Properties.Items.AddRange(new object[] {
            "",
            "=",
            "!="});
            this.cboxBranch.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxBranch.Size = new System.Drawing.Size(80, 23);
            this.cboxBranch.TabIndex = 4;
            this.cboxBranch.SelectedIndexChanged += new System.EventHandler(this.cboxBranch_SelectedIndexChanged);
            // 
            // bbBranch
            // 
            this.bbBranch.EnterMoveNextControl = true;
            this.bbBranch.IsOnline = true;
            this.bbBranch.Location = new System.Drawing.Point(185, 32);
            this.bbBranch.MenuManager = this.barManager;
            this.bbBranch.Name = "bbBranch";
            this.bbBranch.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F);
            this.bbBranch.Properties.Appearance.Options.UseFont = true;
            this.bbBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject1, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject2, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbBranch.Size = new System.Drawing.Size(306, 23);
            this.bbBranch.TabIndex = 5;
            this.bbBranch.TableName = Apothex.DataType.ObjectNames.Branch;
            // 
            // miSynchronize
            // 
            this.miSynchronize.Caption = "სინქრონიზაცია";
            this.miSynchronize.Id = 19;
            this.miSynchronize.Name = "miSynchronize";
            // 
            // frmRequestBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "frmRequestBrowse";
            this.ObjectName = Apothex.DataType.ObjectNames.Request;
            this.OptionsBaseForm.Text = "შეკვეთები";
            this.OptionsListForm.IsBlockable = false;
            this.OptionsListForm.IsSystemColumnsable = true;
            this.OptionsListForm.IsUnblockable = false;
            this.OptionsGrid.ColumnID = "RequestID";
            this.OptionsGrid.ColumnStatusID = "Status";
            this.OptionsGrid.GridView = this.gridView;
            this.Text = "შეკვეთები";
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
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbBranch.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private Apothex.DataType.DS_Request ds;
        private DevExpress.XtraGrid.Columns.GridColumn colRequestID;
        private DevExpress.XtraGrid.Columns.GridColumn colRequestDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchID;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colModifierID;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colApproverID;
        private DevExpress.XtraGrid.Columns.GridColumn colApprover;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchName;
        private DevExpress.XtraEditors.ComboBoxEdit cboxID;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblOrderID;
        private DevExpress.XtraEditors.DateEdit dateOrderDate2;
        private DevExpress.XtraEditors.DateEdit dateOrderDate1;
        private DevExpress.XtraEditors.ComboBoxEdit cboxOrderDate;
        private DevExpress.XtraEditors.LabelControl lblOrderDate;
        private Apothex.Windows.Forms.ButtonBrowse bbBranch;
        private DevExpress.XtraEditors.LabelControl lblBranch;
        private DevExpress.XtraEditors.ComboBoxEdit cboxBranch;
        private DevExpress.XtraBars.BarButtonItem miSynchronize;
    }
}