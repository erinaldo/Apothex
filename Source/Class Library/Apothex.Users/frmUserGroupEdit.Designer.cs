namespace Apothex.Users
{
    partial class frmUserGroupEdit
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
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabMain = new DevExpress.XtraTab.XtraTabPage();
            this.txtUserGroupName = new DevExpress.XtraEditors.TextEdit();
            this.lblUserGroupName = new DevExpress.XtraEditors.LabelControl();
            this.tabPermission = new DevExpress.XtraTab.XtraTabPage();
            this.pnlPermissionFill = new DevExpress.XtraEditors.PanelControl();
            this.gridControlPermission = new DevExpress.XtraGrid.GridControl();
            this.bsPermission = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Permission = new Apothex.DataType.DS_User();
            this.gridViewPermission = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colView = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprove = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisapprove = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBlock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnblock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCancel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUncancel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHiddenColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlPermissionTop = new DevExpress.XtraEditors.PanelControl();
            this.btnUnchekAllPermissions = new DevExpress.XtraEditors.SimpleButton();
            this.btnCheckAllPermissions = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefreshPermission = new DevExpress.XtraEditors.SimpleButton();
            this.btnSavePermission = new DevExpress.XtraEditors.SimpleButton();
            this.tabInfo = new DevExpress.XtraTab.XtraTabPage();
            this.bbApprover = new Apothex.Windows.Forms.ButtonBrowse();
            this.bbModifier = new Apothex.Windows.Forms.ButtonBrowse();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblApprover = new DevExpress.XtraEditors.LabelControl();
            this.dateModifiedDate = new DevExpress.XtraEditors.DateEdit();
            this.lblModifier = new DevExpress.XtraEditors.LabelControl();
            this.lblModifiedDate = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.iCheckColumn = new DevExpress.XtraBars.BarButtonItem();
            this.iUnCheckColumn = new DevExpress.XtraBars.BarButtonItem();
            this.iCheckRow = new DevExpress.XtraBars.BarButtonItem();
            this.iUnCheckRow = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserGroupName.Properties)).BeginInit();
            this.tabPermission.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPermissionFill)).BeginInit();
            this.pnlPermissionFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Permission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPermissionTop)).BeginInit();
            this.pnlPermissionTop.SuspendLayout();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbApprover.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbModifier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifiedDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifiedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.AppearancePage.Header.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xtraTabControl.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl.Location = new System.Drawing.Point(0, 39);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.SelectedTabPage = this.tabMain;
            this.xtraTabControl.Size = new System.Drawing.Size(784, 523);
            this.xtraTabControl.TabIndex = 0;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabMain,
            this.tabPermission,
            this.tabInfo});
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.txtUserGroupName);
            this.tabMain.Controls.Add(this.lblUserGroupName);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(778, 494);
            this.tabMain.Text = "მთავარი";
            // 
            // txtUserGroupName
            // 
            this.txtUserGroupName.EnterMoveNextControl = true;
            this.txtUserGroupName.Location = new System.Drawing.Point(153, 6);
            this.txtUserGroupName.Name = "txtUserGroupName";
            this.txtUserGroupName.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUserGroupName.Properties.Appearance.Options.UseFont = true;
            this.txtUserGroupName.Properties.MaxLength = 100;
            this.txtUserGroupName.Size = new System.Drawing.Size(387, 23);
            this.txtUserGroupName.TabIndex = 1;
            this.txtUserGroupName.EditValueChanged += new System.EventHandler(this.txtUserGroupName_EditValueChanged);
            // 
            // lblUserGroupName
            // 
            this.lblUserGroupName.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserGroupName.Location = new System.Drawing.Point(6, 9);
            this.lblUserGroupName.Name = "lblUserGroupName";
            this.lblUserGroupName.Size = new System.Drawing.Size(97, 17);
            this.lblUserGroupName.TabIndex = 0;
            this.lblUserGroupName.Text = "დასახელება:";
            // 
            // tabPermission
            // 
            this.tabPermission.Controls.Add(this.pnlPermissionFill);
            this.tabPermission.Controls.Add(this.pnlPermissionTop);
            this.tabPermission.Name = "tabPermission";
            this.tabPermission.PageVisible = false;
            this.tabPermission.Size = new System.Drawing.Size(778, 494);
            this.tabPermission.Text = "უფლებები";
            // 
            // pnlPermissionFill
            // 
            this.pnlPermissionFill.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlPermissionFill.Controls.Add(this.gridControlPermission);
            this.pnlPermissionFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPermissionFill.Location = new System.Drawing.Point(0, 51);
            this.pnlPermissionFill.Name = "pnlPermissionFill";
            this.pnlPermissionFill.Size = new System.Drawing.Size(778, 443);
            this.pnlPermissionFill.TabIndex = 1;
            // 
            // gridControlPermission
            // 
            this.gridControlPermission.DataSource = this.bsPermission;
            this.gridControlPermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPermission.Location = new System.Drawing.Point(0, 0);
            this.gridControlPermission.MainView = this.gridViewPermission;
            this.gridControlPermission.Name = "gridControlPermission";
            this.gridControlPermission.Size = new System.Drawing.Size(778, 443);
            this.gridControlPermission.TabIndex = 0;
            this.gridControlPermission.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPermission});
            // 
            // bsPermission
            // 
            this.bsPermission.DataMember = "UserGroupPermission";
            this.bsPermission.DataSource = this.ds_Permission;
            // 
            // ds_Permission
            // 
            this.ds_Permission.DataSetName = "DS_User";
            this.ds_Permission.Locale = new System.Globalization.CultureInfo("");
            this.ds_Permission.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewPermission
            // 
            this.gridViewPermission.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescription,
            this.colView,
            this.colAdd,
            this.colEdit,
            this.colDelete,
            this.colApprove,
            this.colDisapprove,
            this.colBlock,
            this.colUnblock,
            this.colCancel,
            this.colUncancel,
            this.colPrint,
            this.colImport,
            this.colExport,
            this.colHiddenColumn});
            this.gridViewPermission.GridControl = this.gridControlPermission;
            this.gridViewPermission.Name = "gridViewPermission";
            this.gridViewPermission.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewPermission.OptionsCustomization.AllowGroup = false;
            this.gridViewPermission.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewPermission.OptionsView.ColumnAutoWidth = false;
            this.gridViewPermission.OptionsView.ShowAutoFilterRow = true;
            this.gridViewPermission.OptionsView.ShowGroupPanel = false;
            this.gridViewPermission.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridViewPermission_PopupMenuShowing);
            // 
            // colDescription
            // 
            this.colDescription.Caption = "აღწერილობა";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 0;
            this.colDescription.Width = 250;
            // 
            // colView
            // 
            this.colView.Caption = "ნახვა";
            this.colView.FieldName = "View";
            this.colView.Name = "colView";
            this.colView.Visible = true;
            this.colView.VisibleIndex = 1;
            this.colView.Width = 100;
            // 
            // colAdd
            // 
            this.colAdd.Caption = "დამატება";
            this.colAdd.FieldName = "Add";
            this.colAdd.Name = "colAdd";
            this.colAdd.Visible = true;
            this.colAdd.VisibleIndex = 2;
            this.colAdd.Width = 100;
            // 
            // colEdit
            // 
            this.colEdit.Caption = "შეცვლა";
            this.colEdit.FieldName = "Edit";
            this.colEdit.Name = "colEdit";
            this.colEdit.Visible = true;
            this.colEdit.VisibleIndex = 3;
            this.colEdit.Width = 100;
            // 
            // colDelete
            // 
            this.colDelete.Caption = "წაშლა";
            this.colDelete.FieldName = "Del";
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 4;
            this.colDelete.Width = 100;
            // 
            // colApprove
            // 
            this.colApprove.Caption = "დამოწმება";
            this.colApprove.FieldName = "Approve";
            this.colApprove.Name = "colApprove";
            this.colApprove.Visible = true;
            this.colApprove.VisibleIndex = 5;
            this.colApprove.Width = 100;
            // 
            // colDisapprove
            // 
            this.colDisapprove.Caption = "დამოწმ. მოხსნა";
            this.colDisapprove.FieldName = "Disapprove";
            this.colDisapprove.Name = "colDisapprove";
            this.colDisapprove.Visible = true;
            this.colDisapprove.VisibleIndex = 6;
            this.colDisapprove.Width = 100;
            // 
            // colBlock
            // 
            this.colBlock.Caption = "დაბლოკვა";
            this.colBlock.FieldName = "Block";
            this.colBlock.Name = "colBlock";
            this.colBlock.Visible = true;
            this.colBlock.VisibleIndex = 7;
            this.colBlock.Width = 100;
            // 
            // colUnblock
            // 
            this.colUnblock.Caption = "დაბლოკ. მოხსნა";
            this.colUnblock.FieldName = "Unblock";
            this.colUnblock.Name = "colUnblock";
            this.colUnblock.Visible = true;
            this.colUnblock.VisibleIndex = 8;
            this.colUnblock.Width = 100;
            // 
            // colCancel
            // 
            this.colCancel.Caption = "უარყოფა";
            this.colCancel.FieldName = "Cancel";
            this.colCancel.Name = "colCancel";
            this.colCancel.Visible = true;
            this.colCancel.VisibleIndex = 9;
            this.colCancel.Width = 100;
            // 
            // colUncancel
            // 
            this.colUncancel.Caption = "უარყ. მოხსნა";
            this.colUncancel.FieldName = "Uncancel";
            this.colUncancel.Name = "colUncancel";
            this.colUncancel.Visible = true;
            this.colUncancel.VisibleIndex = 10;
            this.colUncancel.Width = 100;
            // 
            // colPrint
            // 
            this.colPrint.Caption = "ამობეჭვდა";
            this.colPrint.FieldName = "Print";
            this.colPrint.Name = "colPrint";
            this.colPrint.Visible = true;
            this.colPrint.VisibleIndex = 11;
            this.colPrint.Width = 100;
            // 
            // colImport
            // 
            this.colImport.Caption = "იმპორტი";
            this.colImport.FieldName = "Import";
            this.colImport.Name = "colImport";
            this.colImport.Visible = true;
            this.colImport.VisibleIndex = 12;
            this.colImport.Width = 100;
            // 
            // colExport
            // 
            this.colExport.Caption = "ექსპორტი";
            this.colExport.FieldName = "Export";
            this.colExport.Name = "colExport";
            this.colExport.Visible = true;
            this.colExport.VisibleIndex = 13;
            this.colExport.Width = 100;
            // 
            // colHiddenColumn
            // 
            this.colHiddenColumn.Caption = "დამალ. სვეტ.";
            this.colHiddenColumn.FieldName = "HiddenColumn";
            this.colHiddenColumn.Name = "colHiddenColumn";
            this.colHiddenColumn.Visible = true;
            this.colHiddenColumn.VisibleIndex = 14;
            this.colHiddenColumn.Width = 100;
            // 
            // pnlPermissionTop
            // 
            this.pnlPermissionTop.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlPermissionTop.Controls.Add(this.btnUnchekAllPermissions);
            this.pnlPermissionTop.Controls.Add(this.btnCheckAllPermissions);
            this.pnlPermissionTop.Controls.Add(this.btnRefreshPermission);
            this.pnlPermissionTop.Controls.Add(this.btnSavePermission);
            this.pnlPermissionTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPermissionTop.Location = new System.Drawing.Point(0, 0);
            this.pnlPermissionTop.Name = "pnlPermissionTop";
            this.pnlPermissionTop.Size = new System.Drawing.Size(778, 51);
            this.pnlPermissionTop.TabIndex = 0;
            // 
            // btnUnchekAllPermissions
            // 
            this.btnUnchekAllPermissions.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUnchekAllPermissions.Appearance.Options.UseFont = true;
            this.btnUnchekAllPermissions.Image = global::Apothex.Users.Properties.Resources.Disable24;
            this.btnUnchekAllPermissions.Location = new System.Drawing.Point(517, 9);
            this.btnUnchekAllPermissions.Name = "btnUnchekAllPermissions";
            this.btnUnchekAllPermissions.Size = new System.Drawing.Size(150, 33);
            this.btnUnchekAllPermissions.TabIndex = 2;
            this.btnUnchekAllPermissions.Text = "გამორთვა";
            this.btnUnchekAllPermissions.Click += new System.EventHandler(this.btnUnchekAllPermissions_Click);
            // 
            // btnCheckAllPermissions
            // 
            this.btnCheckAllPermissions.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheckAllPermissions.Appearance.Options.UseFont = true;
            this.btnCheckAllPermissions.Image = global::Apothex.Users.Properties.Resources.Enable24;
            this.btnCheckAllPermissions.Location = new System.Drawing.Point(361, 9);
            this.btnCheckAllPermissions.Name = "btnCheckAllPermissions";
            this.btnCheckAllPermissions.Size = new System.Drawing.Size(150, 33);
            this.btnCheckAllPermissions.TabIndex = 1;
            this.btnCheckAllPermissions.Text = "ჩართვა";
            this.btnCheckAllPermissions.Click += new System.EventHandler(this.btnCheckAllPermissions_Click);
            // 
            // btnRefreshPermission
            // 
            this.btnRefreshPermission.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefreshPermission.Appearance.Options.UseFont = true;
            this.btnRefreshPermission.Image = global::Apothex.Users.Properties.Resources.Refresh24;
            this.btnRefreshPermission.Location = new System.Drawing.Point(185, 9);
            this.btnRefreshPermission.Name = "btnRefreshPermission";
            this.btnRefreshPermission.Size = new System.Drawing.Size(170, 33);
            this.btnRefreshPermission.TabIndex = 0;
            this.btnRefreshPermission.Text = "სიის. განახლება";
            this.btnRefreshPermission.Click += new System.EventHandler(this.btnRefreshPermission_Click);
            // 
            // btnSavePermission
            // 
            this.btnSavePermission.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSavePermission.Appearance.Options.UseFont = true;
            this.btnSavePermission.Image = global::Apothex.Users.Properties.Resources.Save24;
            this.btnSavePermission.Location = new System.Drawing.Point(9, 9);
            this.btnSavePermission.Name = "btnSavePermission";
            this.btnSavePermission.Size = new System.Drawing.Size(170, 33);
            this.btnSavePermission.TabIndex = 0;
            this.btnSavePermission.Text = "უფლებების შენახვა";
            this.btnSavePermission.Click += new System.EventHandler(this.btnSavePermission_Click);
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
            this.tabInfo.Size = new System.Drawing.Size(778, 494);
            this.tabInfo.Text = "ინფორმაცია";
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
            // popupMenu
            // 
            this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iCheckColumn),
            new DevExpress.XtraBars.LinkPersistInfo(this.iUnCheckColumn),
            new DevExpress.XtraBars.LinkPersistInfo(this.iCheckRow),
            new DevExpress.XtraBars.LinkPersistInfo(this.iUnCheckRow)});
            this.popupMenu.Manager = this.barManager;
            this.popupMenu.Name = "popupMenu";
            // 
            // iCheckColumn
            // 
            this.iCheckColumn.Caption = "სვეტის ჩართვა";
            this.iCheckColumn.Glyph = global::Apothex.Users.Properties.Resources.Enable16;
            this.iCheckColumn.Id = 4;
            this.iCheckColumn.Name = "iCheckColumn";
            this.iCheckColumn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iCheckColumn_ItemClick);
            // 
            // iUnCheckColumn
            // 
            this.iUnCheckColumn.Caption = "სვეტის გამორთვა";
            this.iUnCheckColumn.Glyph = global::Apothex.Users.Properties.Resources.Disable16;
            this.iUnCheckColumn.Id = 5;
            this.iUnCheckColumn.Name = "iUnCheckColumn";
            this.iUnCheckColumn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iUnCheckColumn_ItemClick);
            // 
            // iCheckRow
            // 
            this.iCheckRow.Caption = "სტრიქონის ჩართვა";
            this.iCheckRow.Glyph = global::Apothex.Users.Properties.Resources.Enable16;
            this.iCheckRow.Id = 6;
            this.iCheckRow.Name = "iCheckRow";
            this.iCheckRow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iCheckRow_ItemClick);
            // 
            // iUnCheckRow
            // 
            this.iUnCheckRow.Caption = "სტრიქონის გამორთვა";
            this.iUnCheckRow.Glyph = global::Apothex.Users.Properties.Resources.Disable16;
            this.iUnCheckRow.Id = 7;
            this.iUnCheckRow.Name = "iUnCheckRow";
            this.iUnCheckRow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iUnCheckRow_ItemClick);
            // 
            // frmUserGroupEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.xtraTabControl);
            this.Name = "frmUserGroupEdit";
            this.ObjectName = Apothex.DataType.ObjectNames.UserGroup;
            this.OptionsBaseForm.Text = "მომხმარებლის ჯგუფი";
            this.Text = "მომხმარებლის ჯგუფი";
            this.Controls.SetChildIndex(this.xtraTabControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserGroupName.Properties)).EndInit();
            this.tabPermission.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlPermissionFill)).EndInit();
            this.pnlPermissionFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Permission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPermissionTop)).EndInit();
            this.pnlPermissionTop.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbApprover.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbModifier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifiedDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifiedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage tabMain;
        private DevExpress.XtraEditors.TextEdit txtUserGroupName;
        private DevExpress.XtraEditors.LabelControl lblUserGroupName;
        private DevExpress.XtraTab.XtraTabPage tabInfo;
        private Apothex.Windows.Forms.ButtonBrowse bbApprover;
        private Apothex.Windows.Forms.ButtonBrowse bbModifier;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblApprover;
        private DevExpress.XtraEditors.DateEdit dateModifiedDate;
        private DevExpress.XtraEditors.LabelControl lblModifier;
        private DevExpress.XtraEditors.LabelControl lblModifiedDate;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraTab.XtraTabPage tabPermission;
        private DevExpress.XtraEditors.PanelControl pnlPermissionTop;
        private DevExpress.XtraEditors.PanelControl pnlPermissionFill;
        private DevExpress.XtraEditors.SimpleButton btnRefreshPermission;
        private DevExpress.XtraEditors.SimpleButton btnSavePermission;
        private DevExpress.XtraGrid.GridControl gridControlPermission;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPermission;
        private Apothex.DataType.DS_User ds_Permission;
        private System.Windows.Forms.BindingSource bsPermission;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colBlock;
        private DevExpress.XtraGrid.Columns.GridColumn colView;
        private DevExpress.XtraGrid.Columns.GridColumn colAdd;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colApprove;
        private DevExpress.XtraGrid.Columns.GridColumn colDisapprove;
        private DevExpress.XtraGrid.Columns.GridColumn colPrint;
        private DevExpress.XtraGrid.Columns.GridColumn colExport;
        private DevExpress.XtraGrid.Columns.GridColumn colHiddenColumn;
        private DevExpress.XtraGrid.Columns.GridColumn colUnblock;
        private DevExpress.XtraGrid.Columns.GridColumn colCancel;
        private DevExpress.XtraGrid.Columns.GridColumn colUncancel;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraBars.BarButtonItem iCheckColumn;
        private DevExpress.XtraBars.BarButtonItem iUnCheckColumn;
        private DevExpress.XtraBars.BarButtonItem iCheckRow;
        private DevExpress.XtraBars.BarButtonItem iUnCheckRow;
        private DevExpress.XtraEditors.SimpleButton btnUnchekAllPermissions;
        private DevExpress.XtraEditors.SimpleButton btnCheckAllPermissions;
        private DevExpress.XtraGrid.Columns.GridColumn colImport;
    }
}