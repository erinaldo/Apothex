namespace Apothex.Request
{
    partial class frmRequestEdit
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabMain = new DevExpress.XtraTab.XtraTabPage();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.bsDetail = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Request = new Apothex.DataType.DS_Request();
            this.view = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOrdinalNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riOrdinalNumber = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colMedicamentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequestQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riQuantity = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colCountryCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riCountry = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsCountry = new System.Windows.Forms.BindingSource(this.components);
            this.colCountryCode2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riBrand = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsBrand = new System.Windows.Forms.BindingSource(this.components);
            this.pnlMainTop = new DevExpress.XtraEditors.PanelControl();
            this.bbBranch = new Apothex.Windows.Forms.ButtonBrowse();
            this.dateRequestDate = new DevExpress.XtraEditors.DateEdit();
            this.txtRequestID = new DevExpress.XtraEditors.TextEdit();
            this.lblBranch = new DevExpress.XtraEditors.LabelControl();
            this.lblRequestDate = new DevExpress.XtraEditors.LabelControl();
            this.lblRequestID = new DevExpress.XtraEditors.LabelControl();
            this.tabInfo = new DevExpress.XtraTab.XtraTabPage();
            this.bbApprover = new Apothex.Windows.Forms.ButtonBrowse();
            this.bbModifier = new Apothex.Windows.Forms.ButtonBrowse();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblApprover = new DevExpress.XtraEditors.LabelControl();
            this.dateModifiedDate = new DevExpress.XtraEditors.DateEdit();
            this.lblModifier = new DevExpress.XtraEditors.LabelControl();
            this.lblModifiedDate = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Request)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riOrdinalNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainTop)).BeginInit();
            this.pnlMainTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRequestDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRequestDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRequestID.Properties)).BeginInit();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbApprover.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbModifier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifiedDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifiedDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.AppearancePage.Header.Font = new System.Drawing.Font("BPG Glaho Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xtraTabControl.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl.Location = new System.Drawing.Point(0, 39);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.SelectedTabPage = this.tabMain;
            this.xtraTabControl.Size = new System.Drawing.Size(784, 523);
            this.xtraTabControl.TabIndex = 0;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabMain,
            this.tabInfo});
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.grid);
            this.tabMain.Controls.Add(this.pnlMainTop);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(778, 496);
            this.tabMain.Text = "მთავარი";
            // 
            // grid
            // 
            this.grid.DataSource = this.bsDetail;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EmbeddedNavigator.CustomButtons.AddRange(new DevExpress.XtraEditors.NavigatorCustomButton[] {
            new DevExpress.XtraEditors.NavigatorCustomButton(-1, 17, true, true, "დალაგება", 1),
            new DevExpress.XtraEditors.NavigatorCustomButton(-1, 6, true, true, "დეფექტურიდან დამატება", 2)});
            this.grid.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.grid_EmbeddedNavigator_ButtonClick);
            this.grid.Location = new System.Drawing.Point(0, 70);
            this.grid.MainView = this.view;
            this.grid.MenuManager = this.barManager;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riQuantity,
            this.riCountry,
            this.riBrand,
            this.riOrdinalNumber});
            this.grid.Size = new System.Drawing.Size(778, 426);
            this.grid.TabIndex = 1;
            this.grid.UseEmbeddedNavigator = true;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view});
            // 
            // bsDetail
            // 
            this.bsDetail.DataMember = "SP_GetRequestDetail";
            this.bsDetail.DataSource = this.ds_Request;
            // 
            // ds_Request
            // 
            this.ds_Request.DataSetName = "DS_Request";
            this.ds_Request.Locale = new System.Globalization.CultureInfo("");
            this.ds_Request.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view
            // 
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrdinalNumber,
            this.colMedicamentName,
            this.colRequestQty,
            this.colCountryCode1,
            this.colCountryCode2,
            this.colBrandID});
            this.view.GridControl = this.grid;
            this.view.Name = "view";
            this.view.OptionsCustomization.AllowGroup = false;
            this.view.OptionsNavigation.AutoFocusNewRow = true;
            this.view.OptionsNavigation.EnterMoveNextColumn = true;
            this.view.OptionsSelection.MultiSelect = true;
            this.view.OptionsView.ColumnAutoWidth = false;
            this.view.OptionsView.ShowGroupPanel = false;
            this.view.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colOrdinalNumber, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.view.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.view_CellValueChanged);
            // 
            // colOrdinalNumber
            // 
            this.colOrdinalNumber.Caption = "რიგითი №";
            this.colOrdinalNumber.ColumnEdit = this.riOrdinalNumber;
            this.colOrdinalNumber.DisplayFormat.FormatString = "f0";
            this.colOrdinalNumber.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOrdinalNumber.FieldName = "OrdinalNumber";
            this.colOrdinalNumber.Name = "colOrdinalNumber";
            this.colOrdinalNumber.Visible = true;
            this.colOrdinalNumber.VisibleIndex = 0;
            // 
            // riOrdinalNumber
            // 
            this.riOrdinalNumber.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.riOrdinalNumber.AutoHeight = false;
            this.riOrdinalNumber.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.riOrdinalNumber.DisplayFormat.FormatString = "f0";
            this.riOrdinalNumber.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riOrdinalNumber.EditFormat.FormatString = "f0";
            this.riOrdinalNumber.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riOrdinalNumber.IsFloatValue = false;
            this.riOrdinalNumber.Mask.EditMask = "f0";
            this.riOrdinalNumber.MaxValue = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.riOrdinalNumber.Name = "riOrdinalNumber";
            // 
            // colMedicamentName
            // 
            this.colMedicamentName.Caption = "პროდუქცია";
            this.colMedicamentName.FieldName = "MedicamentName";
            this.colMedicamentName.Name = "colMedicamentName";
            this.colMedicamentName.OptionsColumn.AllowEdit = false;
            this.colMedicamentName.Visible = true;
            this.colMedicamentName.VisibleIndex = 1;
            // 
            // colRequestQty
            // 
            this.colRequestQty.Caption = "რაოდენობა";
            this.colRequestQty.ColumnEdit = this.riQuantity;
            this.colRequestQty.DisplayFormat.FormatString = "n4";
            this.colRequestQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRequestQty.FieldName = "RequestQty";
            this.colRequestQty.Name = "colRequestQty";
            this.colRequestQty.Visible = true;
            this.colRequestQty.VisibleIndex = 2;
            // 
            // riQuantity
            // 
            this.riQuantity.AutoHeight = false;
            this.riQuantity.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.riQuantity.DisplayFormat.FormatString = "n4";
            this.riQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riQuantity.EditFormat.FormatString = "n4";
            this.riQuantity.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riQuantity.Mask.EditMask = "n4";
            this.riQuantity.MaxValue = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.riQuantity.Name = "riQuantity";
            // 
            // colCountryCode1
            // 
            this.colCountryCode1.Caption = "ქვეყანა №1";
            this.colCountryCode1.ColumnEdit = this.riCountry;
            this.colCountryCode1.FieldName = "CountryCode1";
            this.colCountryCode1.Name = "colCountryCode1";
            this.colCountryCode1.Visible = true;
            this.colCountryCode1.VisibleIndex = 3;
            // 
            // riCountry
            // 
            this.riCountry.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.riCountry.AutoHeight = false;
            this.riCountry.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riCountry.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.riCountry.DataSource = this.bsCountry;
            this.riCountry.DisplayMember = "Caption";
            this.riCountry.Name = "riCountry";
            this.riCountry.NullText = "";
            this.riCountry.ShowHeader = false;
            this.riCountry.ValueMember = "ID";
            // 
            // colCountryCode2
            // 
            this.colCountryCode2.Caption = "ქვეყანა №2";
            this.colCountryCode2.ColumnEdit = this.riCountry;
            this.colCountryCode2.FieldName = "CountryCode2";
            this.colCountryCode2.Name = "colCountryCode2";
            this.colCountryCode2.Visible = true;
            this.colCountryCode2.VisibleIndex = 4;
            // 
            // colBrandID
            // 
            this.colBrandID.Caption = "ბრენდი";
            this.colBrandID.ColumnEdit = this.riBrand;
            this.colBrandID.FieldName = "BrandID";
            this.colBrandID.Name = "colBrandID";
            this.colBrandID.Visible = true;
            this.colBrandID.VisibleIndex = 5;
            // 
            // riBrand
            // 
            this.riBrand.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.riBrand.AutoHeight = false;
            this.riBrand.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riBrand.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.riBrand.DataSource = this.bsBrand;
            this.riBrand.DisplayMember = "Caption";
            this.riBrand.Name = "riBrand";
            this.riBrand.NullText = "";
            this.riBrand.ShowHeader = false;
            this.riBrand.ValueMember = "ID";
            // 
            // pnlMainTop
            // 
            this.pnlMainTop.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlMainTop.Controls.Add(this.bbBranch);
            this.pnlMainTop.Controls.Add(this.dateRequestDate);
            this.pnlMainTop.Controls.Add(this.txtRequestID);
            this.pnlMainTop.Controls.Add(this.lblBranch);
            this.pnlMainTop.Controls.Add(this.lblRequestDate);
            this.pnlMainTop.Controls.Add(this.lblRequestID);
            this.pnlMainTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainTop.Location = new System.Drawing.Point(0, 0);
            this.pnlMainTop.Name = "pnlMainTop";
            this.pnlMainTop.Size = new System.Drawing.Size(778, 70);
            this.pnlMainTop.TabIndex = 0;
            // 
            // bbBranch
            // 
            this.bbBranch.EnterMoveNextControl = true;
            this.bbBranch.IsOnline = true;
            this.bbBranch.Location = new System.Drawing.Point(394, 6);
            this.bbBranch.MenuManager = this.barManager;
            this.bbBranch.Name = "bbBranch";
            this.bbBranch.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F);
            this.bbBranch.Properties.Appearance.Options.UseFont = true;
            this.bbBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject3, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject4, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbBranch.Size = new System.Drawing.Size(306, 23);
            this.bbBranch.TabIndex = 5;
            this.bbBranch.TableName = Apothex.DataType.ObjectNames.Branch;
            // 
            // dateRequestDate
            // 
            this.dateRequestDate.EditValue = null;
            this.dateRequestDate.EnterMoveNextControl = true;
            this.dateRequestDate.Location = new System.Drawing.Point(89, 35);
            this.dateRequestDate.Name = "dateRequestDate";
            this.dateRequestDate.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateRequestDate.Properties.Appearance.Options.UseFont = true;
            this.dateRequestDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.dateRequestDate.Properties.DisplayFormat.FormatString = "G";
            this.dateRequestDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateRequestDate.Properties.EditFormat.FormatString = "G";
            this.dateRequestDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateRequestDate.Properties.Mask.EditMask = "G";
            this.dateRequestDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateRequestDate.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.dateRequestDate_Properties_ButtonClick);
            this.dateRequestDate.Size = new System.Drawing.Size(200, 23);
            this.dateRequestDate.TabIndex = 3;
            // 
            // txtRequestID
            // 
            this.txtRequestID.EnterMoveNextControl = true;
            this.txtRequestID.Location = new System.Drawing.Point(89, 6);
            this.txtRequestID.Name = "txtRequestID";
            this.txtRequestID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRequestID.Properties.Appearance.Options.UseFont = true;
            this.txtRequestID.Properties.ReadOnly = true;
            this.txtRequestID.Size = new System.Drawing.Size(200, 23);
            this.txtRequestID.TabIndex = 1;
            // 
            // lblBranch
            // 
            this.lblBranch.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBranch.Location = new System.Drawing.Point(307, 9);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(81, 17);
            this.lblBranch.TabIndex = 4;
            this.lblBranch.Text = "ფილიალი:";
            // 
            // lblRequestDate
            // 
            this.lblRequestDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRequestDate.Location = new System.Drawing.Point(6, 38);
            this.lblRequestDate.Name = "lblRequestDate";
            this.lblRequestDate.Size = new System.Drawing.Size(65, 17);
            this.lblRequestDate.TabIndex = 2;
            this.lblRequestDate.Text = "თარიღი:";
            // 
            // lblRequestID
            // 
            this.lblRequestID.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRequestID.Location = new System.Drawing.Point(6, 9);
            this.lblRequestID.Name = "lblRequestID";
            this.lblRequestID.Size = new System.Drawing.Size(20, 17);
            this.lblRequestID.TabIndex = 0;
            this.lblRequestID.Text = "№:";
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.bbApprover);
            this.tabInfo.Controls.Add(this.bbModifier);
            this.tabInfo.Controls.Add(this.txtID);
            this.tabInfo.Controls.Add(this.lblApprover);
            this.tabInfo.Controls.Add(this.dateModifiedDate);
            this.tabInfo.Controls.Add(this.lblModifier);
            this.tabInfo.Controls.Add(this.lblModifiedDate);
            this.tabInfo.Controls.Add(this.lblID);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Size = new System.Drawing.Size(778, 496);
            this.tabInfo.Text = "ინფო";
            // 
            // bbApprover
            // 
            this.bbApprover.EnterMoveNextControl = true;
            this.bbApprover.IsOnline = true;
            this.bbApprover.Location = new System.Drawing.Point(89, 93);
            this.bbApprover.Name = "bbApprover";
            this.bbApprover.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bbApprover.Properties.Appearance.Options.UseFont = true;
            this.bbApprover.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bbApprover.Properties.ReadOnly = true;
            this.bbApprover.Size = new System.Drawing.Size(300, 23);
            this.bbApprover.TabIndex = 7;
            this.bbApprover.TableName = Apothex.DataType.ObjectNames.User;
            // 
            // bbModifier
            // 
            this.bbModifier.EnterMoveNextControl = true;
            this.bbModifier.IsOnline = true;
            this.bbModifier.Location = new System.Drawing.Point(89, 65);
            this.bbModifier.Name = "bbModifier";
            this.bbModifier.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bbModifier.Properties.Appearance.Options.UseFont = true;
            this.bbModifier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bbModifier.Properties.ReadOnly = true;
            this.bbModifier.Size = new System.Drawing.Size(300, 23);
            this.bbModifier.TabIndex = 5;
            this.bbModifier.TableName = Apothex.DataType.ObjectNames.User;
            // 
            // txtID
            // 
            this.txtID.EnterMoveNextControl = true;
            this.txtID.Location = new System.Drawing.Point(89, 6);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(300, 23);
            this.txtID.TabIndex = 1;
            // 
            // lblApprover
            // 
            this.lblApprover.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblApprover.Location = new System.Drawing.Point(6, 97);
            this.lblApprover.Name = "lblApprover";
            this.lblApprover.Size = new System.Drawing.Size(77, 17);
            this.lblApprover.TabIndex = 6;
            this.lblApprover.Text = "დაამოწმა:";
            // 
            // dateModifiedDate
            // 
            this.dateModifiedDate.EditValue = null;
            this.dateModifiedDate.EnterMoveNextControl = true;
            this.dateModifiedDate.Location = new System.Drawing.Point(89, 35);
            this.dateModifiedDate.Name = "dateModifiedDate";
            this.dateModifiedDate.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateModifiedDate.Properties.Appearance.Options.UseFont = true;
            this.dateModifiedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateModifiedDate.Properties.DisplayFormat.FormatString = "G";
            this.dateModifiedDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateModifiedDate.Properties.EditFormat.FormatString = "G";
            this.dateModifiedDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateModifiedDate.Properties.Mask.EditMask = "G";
            this.dateModifiedDate.Properties.ReadOnly = true;
            this.dateModifiedDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateModifiedDate.Size = new System.Drawing.Size(150, 23);
            this.dateModifiedDate.TabIndex = 3;
            // 
            // lblModifier
            // 
            this.lblModifier.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblModifier.Location = new System.Drawing.Point(6, 68);
            this.lblModifier.Name = "lblModifier";
            this.lblModifier.Size = new System.Drawing.Size(70, 17);
            this.lblModifier.TabIndex = 4;
            this.lblModifier.Text = "შეცვალა:";
            // 
            // lblModifiedDate
            // 
            this.lblModifiedDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblModifiedDate.Location = new System.Drawing.Point(6, 38);
            this.lblModifiedDate.Name = "lblModifiedDate";
            this.lblModifiedDate.Size = new System.Drawing.Size(65, 17);
            this.lblModifiedDate.TabIndex = 2;
            this.lblModifiedDate.Text = "თარიღი:";
            // 
            // lblID
            // 
            this.lblID.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblID.Location = new System.Drawing.Point(6, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // frmRequestEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.xtraTabControl);
            this.Name = "frmRequestEdit";
            this.ObjectName = Apothex.DataType.ObjectNames.Request;
            this.OptionsBaseForm.IsPrintable = true;
            this.OptionsBaseForm.Text = "შეკვეთა";
            this.Text = "შეკვეთა";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRequestEdit_FormClosed);
            this.Shown += new System.EventHandler(this.frmRequestEdit_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRequestEdit_KeyDown);
            this.Controls.SetChildIndex(this.xtraTabControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Request)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riOrdinalNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainTop)).EndInit();
            this.pnlMainTop.ResumeLayout(false);
            this.pnlMainTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRequestDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRequestDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRequestID.Properties)).EndInit();
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbApprover.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbModifier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifiedDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifiedDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage tabMain;
        private DevExpress.XtraTab.XtraTabPage tabInfo;
        private Apothex.Windows.Forms.ButtonBrowse bbApprover;
        private Apothex.Windows.Forms.ButtonBrowse bbModifier;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblApprover;
        private DevExpress.XtraEditors.DateEdit dateModifiedDate;
        private DevExpress.XtraEditors.LabelControl lblModifier;
        private DevExpress.XtraEditors.LabelControl lblModifiedDate;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.PanelControl pnlMainTop;
        private DevExpress.XtraEditors.DateEdit dateRequestDate;
        private DevExpress.XtraEditors.TextEdit txtRequestID;
        private DevExpress.XtraEditors.LabelControl lblRequestDate;
        private DevExpress.XtraEditors.LabelControl lblRequestID;
        private Apothex.Windows.Forms.ButtonBrowse bbBranch;
        private DevExpress.XtraEditors.LabelControl lblBranch;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView view;
        private Apothex.DataType.DS_Request ds_Request;
        private System.Windows.Forms.BindingSource bsDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicamentName;
        private DevExpress.XtraGrid.Columns.GridColumn colRequestQty;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit riQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryCode1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riCountry;
        private System.Windows.Forms.BindingSource bsCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryCode2;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riBrand;
        private System.Windows.Forms.BindingSource bsBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colOrdinalNumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit riOrdinalNumber;
    }
}