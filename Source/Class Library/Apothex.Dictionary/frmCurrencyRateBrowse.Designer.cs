namespace Apothex.Dictionary
{
    partial class frmCurrencyRateBrowse
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
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAverageRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyRateID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEvents = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApproverUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ds = new Apothex.DataType.DS_CurrencyRate();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.cboxDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateStartDate = new DevExpress.XtraEditors.DateEdit();
            this.dateEndDate = new DevExpress.XtraEditors.DateEdit();
            this.lblCurrency = new DevExpress.XtraEditors.LabelControl();
            this.lookCurrency = new DevExpress.XtraEditors.LookUpEdit();
            this.bsCurrency = new System.Windows.Forms.BindingSource();
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
            ((System.ComponentModel.ISupportInitialize)(this.cboxDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrency)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.lookCurrency);
            this.pnlFilter.Controls.Add(this.dateEndDate);
            this.pnlFilter.Controls.Add(this.dateStartDate);
            this.pnlFilter.Controls.Add(this.cboxDate);
            this.pnlFilter.Controls.Add(this.lblCurrency);
            this.pnlFilter.Controls.Add(this.lblDate);
            this.pnlFilter.Controls.SetChildIndex(this.lblDate, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblCurrency, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnFilter, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cboxDate, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateStartDate, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateEndDate, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lookCurrency, 0);
            // 
            // bsGridControl
            // 
            this.bsGridControl.DataMember = "VW_CurrencyRate";
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
            this.btnFilter.Location = new System.Drawing.Point(642, 61);
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
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(784, 428);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStartDate,
            this.colEndDate,
            this.colCurrencyCode,
            this.colAverageRate,
            this.colCurrencyRateID,
            this.colEvents,
            this.colStatus,
            this.colModifiedUserID,
            this.colModifier,
            this.colModifiedDate,
            this.colApproverUserID,
            this.colApprover});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            // 
            // colStartDate
            // 
            this.colStartDate.Caption = "დაწყების თარიღი";
            this.colStartDate.DisplayFormat.FormatString = "G";
            this.colStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.GroupFormat.FormatString = "d";
            this.colStartDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 0;
            // 
            // colEndDate
            // 
            this.colEndDate.Caption = "დასრულების თარიღი";
            this.colEndDate.DisplayFormat.FormatString = "G";
            this.colEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.GroupFormat.FormatString = "d";
            this.colEndDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 1;
            // 
            // colCurrencyCode
            // 
            this.colCurrencyCode.Caption = "ვალუტა";
            this.colCurrencyCode.FieldName = "CurrencyCode";
            this.colCurrencyCode.Name = "colCurrencyCode";
            this.colCurrencyCode.Visible = true;
            this.colCurrencyCode.VisibleIndex = 2;
            // 
            // colAverageRate
            // 
            this.colAverageRate.Caption = "კურსი";
            this.colAverageRate.FieldName = "AverageRate";
            this.colAverageRate.Name = "colAverageRate";
            this.colAverageRate.Visible = true;
            this.colAverageRate.VisibleIndex = 3;
            // 
            // colCurrencyRateID
            // 
            this.colCurrencyRateID.FieldName = "CurrencyRateID";
            this.colCurrencyRateID.Name = "colCurrencyRateID";
            // 
            // colEvents
            // 
            this.colEvents.Caption = "მოქმედების კოდი";
            this.colEvents.FieldName = "Events";
            this.colEvents.Name = "colEvents";
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
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
            // lblDate
            // 
            this.lblDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.Appearance.Options.UseFont = true;
            this.lblDate.Location = new System.Drawing.Point(6, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(65, 17);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "თარიღი:";
            // 
            // cboxDate
            // 
            this.cboxDate.EnterMoveNextControl = true;
            this.cboxDate.Location = new System.Drawing.Point(83, 6);
            this.cboxDate.Name = "cboxDate";
            this.cboxDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboxDate.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxDate.Properties.Appearance.Options.UseFont = true;
            this.cboxDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxDate.Properties.Items.AddRange(new object[] {
            "",
            "=",
            ">",
            "<",
            "[ ]"});
            this.cboxDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxDate.Size = new System.Drawing.Size(75, 23);
            this.cboxDate.TabIndex = 1;
            this.cboxDate.SelectedIndexChanged += new System.EventHandler(this.cboxDate_SelectedIndexChanged);
            // 
            // dateStartDate
            // 
            this.dateStartDate.EditValue = null;
            this.dateStartDate.EnterMoveNextControl = true;
            this.dateStartDate.Location = new System.Drawing.Point(164, 6);
            this.dateStartDate.Name = "dateStartDate";
            this.dateStartDate.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateStartDate.Properties.Appearance.Options.UseFont = true;
            this.dateStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStartDate.Properties.DisplayFormat.FormatString = "G";
            this.dateStartDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStartDate.Properties.EditFormat.FormatString = "G";
            this.dateStartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStartDate.Properties.Mask.EditMask = "G";
            this.dateStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateStartDate.Size = new System.Drawing.Size(150, 23);
            this.dateStartDate.TabIndex = 2;
            this.dateStartDate.EditValueChanged += new System.EventHandler(this.dateStartDate_EditValueChanged);
            // 
            // dateEndDate
            // 
            this.dateEndDate.EditValue = null;
            this.dateEndDate.EnterMoveNextControl = true;
            this.dateEndDate.Location = new System.Drawing.Point(320, 6);
            this.dateEndDate.Name = "dateEndDate";
            this.dateEndDate.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEndDate.Properties.Appearance.Options.UseFont = true;
            this.dateEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEndDate.Properties.DisplayFormat.FormatString = "G";
            this.dateEndDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEndDate.Properties.EditFormat.FormatString = "G";
            this.dateEndDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEndDate.Properties.Mask.EditMask = "G";
            this.dateEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEndDate.Size = new System.Drawing.Size(150, 23);
            this.dateEndDate.TabIndex = 3;
            this.dateEndDate.EditValueChanged += new System.EventHandler(this.dateEndDate_EditValueChanged);
            // 
            // lblCurrency
            // 
            this.lblCurrency.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrency.Appearance.Options.UseFont = true;
            this.lblCurrency.Location = new System.Drawing.Point(6, 38);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(63, 17);
            this.lblCurrency.TabIndex = 4;
            this.lblCurrency.Text = "ვალუტა:";
            // 
            // lookCurrency
            // 
            this.lookCurrency.EnterMoveNextControl = true;
            this.lookCurrency.Location = new System.Drawing.Point(83, 35);
            this.lookCurrency.Name = "lookCurrency";
            this.lookCurrency.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookCurrency.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookCurrency.Properties.Appearance.Options.UseFont = true;
            this.lookCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookCurrency.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", 200, "Caption")});
            this.lookCurrency.Properties.DataSource = this.bsCurrency;
            this.lookCurrency.Properties.DisplayMember = "Caption";
            this.lookCurrency.Properties.NullText = "";
            this.lookCurrency.Properties.ShowHeader = false;
            this.lookCurrency.Properties.ValueMember = "ID";
            this.lookCurrency.Size = new System.Drawing.Size(387, 23);
            this.lookCurrency.TabIndex = 5;
            // 
            // frmCurrencyRateBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "frmCurrencyRateBrowse";
            this.ObjectName = Apothex.DataType.ObjectNames.CurrencyRate;
            this.OptionsListForm.IsBlockable = false;
            this.OptionsListForm.IsDisapprovable = false;
            this.OptionsListForm.IsEditable = true;
            this.OptionsListForm.IsSystemColumnsable = true;
            this.OptionsListForm.IsUnblockable = false;
            this.OptionsGrid.ColumnID = "CurrencyRateID";
            this.OptionsGrid.ColumnStatusID = "Status";
            this.OptionsGrid.GridView = this.gridView;
            this.Text = "ვალუტის კურსები";
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
            ((System.ComponentModel.ISupportInitialize)(this.cboxDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private Apothex.DataType.DS_CurrencyRate ds;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colAverageRate;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraGrid.Columns.GridColumn colApprover;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyRateID;
        private DevExpress.XtraGrid.Columns.GridColumn colEvents;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colApproverUserID;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.ComboBoxEdit cboxDate;
        private DevExpress.XtraEditors.DateEdit dateEndDate;
        private DevExpress.XtraEditors.DateEdit dateStartDate;
        private DevExpress.XtraEditors.LabelControl lblCurrency;
        private DevExpress.XtraEditors.LookUpEdit lookCurrency;
        private System.Windows.Forms.BindingSource bsCurrency;
    }
}