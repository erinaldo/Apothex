namespace Apothex.Sales
{
    partial class frmCardGiftEdit
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
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riAmount = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridOperation = new DevExpress.XtraGrid.GridControl();
            this.bsOperation = new System.Windows.Forms.BindingSource();
            this.ds_Operation = new Apothex.DataType.DS_Operation();
            this.viewOperation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsOpType = new System.Windows.Forms.BindingSource();
            this.lblTotalDue = new DevExpress.XtraEditors.LabelControl();
            this.spinTotalDue = new DevExpress.XtraEditors.SpinEdit();
            this.bbPerson = new Apothex.Windows.Forms.ButtonBrowse();
            this.lblPerson = new DevExpress.XtraEditors.LabelControl();
            this.txtPersonalNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblPersonalNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalAmount = new DevExpress.XtraEditors.LabelControl();
            this.spinTotalAmount = new DevExpress.XtraEditors.SpinEdit();
            this.ds_Card = new Apothex.DataType.DS_Card();
            this.ds_Sales = new Apothex.DataType.DS_Sales();
            this.lblTotalUnit = new DevExpress.XtraEditors.LabelControl();
            this.spinTotalUnit = new DevExpress.XtraEditors.SpinEdit();
            this.txtCardNumber = new Zek.Windows.Forms.DevEx.CardReaderTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Operation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOpType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalDue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonalNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Card)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Appearance.Options.UseFont = true;
            this.btnOk.Location = new System.Drawing.Point(56, 410);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(212, 410);
            // 
            // colAmount
            // 
            this.colAmount.Caption = "თანხა";
            this.colAmount.ColumnEdit = this.riAmount;
            this.colAmount.DisplayFormat.FormatString = "n2";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 0;
            // 
            // riAmount
            // 
            this.riAmount.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.riAmount.AutoHeight = false;
            this.riAmount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.riAmount.DisplayFormat.FormatString = "n2";
            this.riAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riAmount.EditFormat.FormatString = "n2";
            this.riAmount.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riAmount.Mask.EditMask = "n2";
            this.riAmount.MaxValue = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.riAmount.Name = "riAmount";
            // 
            // gridOperation
            // 
            this.gridOperation.DataSource = this.bsOperation;
            this.gridOperation.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridOperation_EmbeddedNavigator_ButtonClick);
            this.gridOperation.Location = new System.Drawing.Point(12, 189);
            this.gridOperation.MainView = this.viewOperation;
            this.gridOperation.Name = "gridOperation";
            this.gridOperation.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riAmount,
            this.riType});
            this.gridOperation.Size = new System.Drawing.Size(400, 200);
            this.gridOperation.TabIndex = 11;
            this.gridOperation.UseEmbeddedNavigator = true;
            this.gridOperation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewOperation});
            // 
            // bsOperation
            // 
            this.bsOperation.DataMember = "T_Operation";
            this.bsOperation.DataSource = this.ds_Operation;
            // 
            // ds_Operation
            // 
            this.ds_Operation.DataSetName = "DS_Operation";
            this.ds_Operation.Locale = new System.Globalization.CultureInfo("");
            this.ds_Operation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewOperation
            // 
            this.viewOperation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAmount,
            this.colTypeID});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.LightCoral;
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Column = this.colAmount;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.LessOrEqual;
            styleFormatCondition1.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.viewOperation.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.viewOperation.GridControl = this.gridOperation;
            this.viewOperation.Name = "viewOperation";
            this.viewOperation.OptionsCustomization.AllowColumnMoving = false;
            this.viewOperation.OptionsCustomization.AllowFilter = false;
            this.viewOperation.OptionsCustomization.AllowGroup = false;
            this.viewOperation.OptionsCustomization.AllowSort = false;
            this.viewOperation.OptionsMenu.EnableColumnMenu = false;
            this.viewOperation.OptionsNavigation.EnterMoveNextColumn = true;
            this.viewOperation.OptionsView.ShowFooter = true;
            this.viewOperation.OptionsView.ShowGroupPanel = false;
            this.viewOperation.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.viewOperation_CellValueChanged);
            // 
            // colTypeID
            // 
            this.colTypeID.Caption = "ოპერაციის ტიპი";
            this.colTypeID.ColumnEdit = this.riType;
            this.colTypeID.FieldName = "TypeID";
            this.colTypeID.Name = "colTypeID";
            this.colTypeID.Visible = true;
            this.colTypeID.VisibleIndex = 1;
            // 
            // riType
            // 
            this.riType.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.riType.AutoHeight = false;
            this.riType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.riType.DataSource = this.bsOpType;
            this.riType.DisplayMember = "Caption";
            this.riType.Name = "riType";
            this.riType.NullText = "";
            this.riType.ShowHeader = false;
            this.riType.ValueMember = "ID";
            // 
            // lblTotalDue
            // 
            this.lblTotalDue.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalDue.Location = new System.Drawing.Point(13, 163);
            this.lblTotalDue.Name = "lblTotalDue";
            this.lblTotalDue.Size = new System.Drawing.Size(128, 17);
            this.lblTotalDue.TabIndex = 9;
            this.lblTotalDue.Text = "ფაქტურის თანხა:";
            // 
            // spinTotalDue
            // 
            this.spinTotalDue.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTotalDue.Location = new System.Drawing.Point(165, 160);
            this.spinTotalDue.Name = "spinTotalDue";
            this.spinTotalDue.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinTotalDue.Properties.Appearance.Options.UseFont = true;
            this.spinTotalDue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinTotalDue.Properties.DisplayFormat.FormatString = "n2";
            this.spinTotalDue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTotalDue.Properties.EditFormat.FormatString = "n2";
            this.spinTotalDue.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTotalDue.Properties.Mask.EditMask = "n2";
            this.spinTotalDue.Properties.ReadOnly = true;
            this.spinTotalDue.Size = new System.Drawing.Size(150, 23);
            this.spinTotalDue.TabIndex = 10;
            this.spinTotalDue.TabStop = false;
            // 
            // bbPerson
            // 
            this.bbPerson.EnterMoveNextControl = true;
            this.bbPerson.IsOnline = true;
            this.bbPerson.Location = new System.Drawing.Point(165, 44);
            this.bbPerson.Name = "bbPerson";
            this.bbPerson.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bbPerson.Properties.Appearance.Options.UseFont = true;
            this.bbPerson.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject1, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject2, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbPerson.Properties.ReadOnly = true;
            this.bbPerson.Size = new System.Drawing.Size(247, 23);
            this.bbPerson.TabIndex = 2;
            this.bbPerson.TableName = Apothex.DataType.ObjectNames.Person;
            this.bbPerson.TabStop = false;
            this.bbPerson.PrimaryKeyChanged += new System.EventHandler(this.bbPerson_PrimaryKeyChanged);
            // 
            // lblPerson
            // 
            this.lblPerson.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPerson.Location = new System.Drawing.Point(13, 47);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(93, 17);
            this.lblPerson.TabIndex = 1;
            this.lblPerson.Text = "მფლობელი:";
            // 
            // txtPersonalNumber
            // 
            this.txtPersonalNumber.Location = new System.Drawing.Point(165, 73);
            this.txtPersonalNumber.Name = "txtPersonalNumber";
            this.txtPersonalNumber.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPersonalNumber.Properties.Appearance.Options.UseFont = true;
            this.txtPersonalNumber.Properties.ReadOnly = true;
            this.txtPersonalNumber.Size = new System.Drawing.Size(247, 23);
            this.txtPersonalNumber.TabIndex = 4;
            this.txtPersonalNumber.TabStop = false;
            // 
            // lblPersonalNumber
            // 
            this.lblPersonalNumber.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPersonalNumber.Location = new System.Drawing.Point(12, 76);
            this.lblPersonalNumber.Name = "lblPersonalNumber";
            this.lblPersonalNumber.Size = new System.Drawing.Size(122, 17);
            this.lblPersonalNumber.TabIndex = 3;
            this.lblPersonalNumber.Text = "პირადი ნომერი:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalAmount.Location = new System.Drawing.Point(13, 105);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(99, 17);
            this.lblTotalAmount.TabIndex = 5;
            this.lblTotalAmount.Text = "დაგრ. თანხა:";
            // 
            // spinTotalAmount
            // 
            this.spinTotalAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTotalAmount.Location = new System.Drawing.Point(165, 102);
            this.spinTotalAmount.Name = "spinTotalAmount";
            this.spinTotalAmount.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinTotalAmount.Properties.Appearance.Options.UseFont = true;
            this.spinTotalAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinTotalAmount.Properties.DisplayFormat.FormatString = "n2";
            this.spinTotalAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTotalAmount.Properties.EditFormat.FormatString = "n2";
            this.spinTotalAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTotalAmount.Properties.Mask.EditMask = "n2";
            this.spinTotalAmount.Properties.ReadOnly = true;
            this.spinTotalAmount.Size = new System.Drawing.Size(150, 23);
            this.spinTotalAmount.TabIndex = 6;
            this.spinTotalAmount.TabStop = false;
            // 
            // ds_Card
            // 
            this.ds_Card.DataSetName = "DS_Card";
            this.ds_Card.Locale = new System.Globalization.CultureInfo("");
            this.ds_Card.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ds_Sales
            // 
            this.ds_Sales.DataSetName = "DS_Sales";
            this.ds_Sales.Locale = new System.Globalization.CultureInfo("");
            this.ds_Sales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTotalUnit
            // 
            this.lblTotalUnit.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalUnit.Location = new System.Drawing.Point(13, 134);
            this.lblTotalUnit.Name = "lblTotalUnit";
            this.lblTotalUnit.Size = new System.Drawing.Size(95, 17);
            this.lblTotalUnit.TabIndex = 7;
            this.lblTotalUnit.Text = "დაგრ. ქულა:";
            // 
            // spinTotalUnit
            // 
            this.spinTotalUnit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTotalUnit.Location = new System.Drawing.Point(165, 131);
            this.spinTotalUnit.Name = "spinTotalUnit";
            this.spinTotalUnit.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinTotalUnit.Properties.Appearance.Options.UseFont = true;
            this.spinTotalUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinTotalUnit.Properties.DisplayFormat.FormatString = "n2";
            this.spinTotalUnit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTotalUnit.Properties.EditFormat.FormatString = "n2";
            this.spinTotalUnit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTotalUnit.Properties.Mask.EditMask = "n2";
            this.spinTotalUnit.Properties.ReadOnly = true;
            this.spinTotalUnit.Size = new System.Drawing.Size(150, 23);
            this.spinTotalUnit.TabIndex = 8;
            this.spinTotalUnit.TabStop = false;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.EditValue = "";
            this.txtCardNumber.Location = new System.Drawing.Point(13, 12);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCardNumber.Properties.Appearance.Options.UseFont = true;
            this.txtCardNumber.Size = new System.Drawing.Size(399, 26);
            this.txtCardNumber.TabIndex = 0;
            this.txtCardNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardNumber_KeyDown);
            // 
            // frmCardGiftEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 452);
            this.Controls.Add(this.txtPersonalNumber);
            this.Controls.Add(this.lblPersonalNumber);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.bbPerson);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.spinTotalUnit);
            this.Controls.Add(this.lblTotalUnit);
            this.Controls.Add(this.spinTotalAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.spinTotalDue);
            this.Controls.Add(this.lblTotalDue);
            this.Controls.Add(this.gridOperation);
            this.Name = "frmCardGiftEdit";
            this.OptionsBaseForm.Text = "საჩუქრის გაცემა";
            this.OptionsPermission.AutoCheckPermission = false;
            this.OptionsPermission.AutoInitPermission = false;
            this.Text = "საჩუქრის გაცემა";
            this.Controls.SetChildIndex(this.gridOperation, 0);
            this.Controls.SetChildIndex(this.lblTotalDue, 0);
            this.Controls.SetChildIndex(this.spinTotalDue, 0);
            this.Controls.SetChildIndex(this.lblTotalAmount, 0);
            this.Controls.SetChildIndex(this.spinTotalAmount, 0);
            this.Controls.SetChildIndex(this.lblTotalUnit, 0);
            this.Controls.SetChildIndex(this.spinTotalUnit, 0);
            this.Controls.SetChildIndex(this.lblPerson, 0);
            this.Controls.SetChildIndex(this.bbPerson, 0);
            this.Controls.SetChildIndex(this.txtCardNumber, 0);
            this.Controls.SetChildIndex(this.lblPersonalNumber, 0);
            this.Controls.SetChildIndex(this.txtPersonalNumber, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Operation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOpType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalDue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonalNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Card)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardNumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridOperation;
        private DevExpress.XtraGrid.Views.Grid.GridView viewOperation;
        private DevExpress.XtraEditors.LabelControl lblTotalDue;
        private DevExpress.XtraEditors.SpinEdit spinTotalDue;
        private Windows.Forms.ButtonBrowse bbPerson;
        private DevExpress.XtraEditors.LabelControl lblPerson;
        private DevExpress.XtraEditors.TextEdit txtPersonalNumber;
        private DevExpress.XtraEditors.LabelControl lblPersonalNumber;
        private DevExpress.XtraEditors.LabelControl lblTotalAmount;
        private DevExpress.XtraEditors.SpinEdit spinTotalAmount;
        private System.Windows.Forms.BindingSource bsOperation;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeID;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit riAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riType;
        private System.Windows.Forms.BindingSource bsOpType;
        private DevExpress.XtraEditors.LabelControl lblTotalUnit;
        private DevExpress.XtraEditors.SpinEdit spinTotalUnit;
        public DataType.DS_Operation ds_Operation;
        private DataType.DS_Sales ds_Sales;
        private DataType.DS_Card ds_Card;
        private Zek.Windows.Forms.DevEx.CardReaderTextEdit txtCardNumber;
    }
}