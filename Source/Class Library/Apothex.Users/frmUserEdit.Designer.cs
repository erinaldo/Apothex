namespace Apothex.Users
{
    partial class frmUserEdit
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
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabMain = new DevExpress.XtraTab.XtraTabPage();
            this.bbPerson = new Apothex.Windows.Forms.ButtonBrowse();
            this.chkChangePassword = new DevExpress.XtraEditors.CheckEdit();
            this.lookBranch = new DevExpress.XtraEditors.LookUpEdit();
            this.bsBranch = new System.Windows.Forms.BindingSource(this.components);
            this.lblPerson = new DevExpress.XtraEditors.LabelControl();
            this.lblBranch = new DevExpress.XtraEditors.LabelControl();
            this.txtRepeatPassword = new DevExpress.XtraEditors.TextEdit();
            this.lblRepeatPassword = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.lblUsername = new DevExpress.XtraEditors.LabelControl();
            this.tabUserInGroup = new DevExpress.XtraTab.XtraTabPage();
            this.pnlUserInGroupFill = new DevExpress.XtraEditors.PanelControl();
            this.lstRight = new DevExpress.XtraEditors.ListBoxControl();
            this.bsRight = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Right = new Apothex.DataType.DS_User();
            this.pnlButton = new DevExpress.XtraEditors.PanelControl();
            this.btnLeft = new DevExpress.XtraEditors.SimpleButton();
            this.btnRight = new DevExpress.XtraEditors.SimpleButton();
            this.lstLeft = new DevExpress.XtraEditors.ListBoxControl();
            this.bsLeft = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Left = new Apothex.DataType.DS_Dictionary();
            this.pnlUserInGroupTop = new DevExpress.XtraEditors.PanelControl();
            this.btnRefreshUserInGroup = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveUserInGroup = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.bbPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkChangePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepeatPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            this.tabUserInGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUserInGroupFill)).BeginInit();
            this.pnlUserInGroupFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButton)).BeginInit();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUserInGroupTop)).BeginInit();
            this.pnlUserInGroupTop.SuspendLayout();
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
            this.tabUserInGroup,
            this.tabInfo});
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.bbPerson);
            this.tabMain.Controls.Add(this.chkChangePassword);
            this.tabMain.Controls.Add(this.lookBranch);
            this.tabMain.Controls.Add(this.lblPerson);
            this.tabMain.Controls.Add(this.lblBranch);
            this.tabMain.Controls.Add(this.txtRepeatPassword);
            this.tabMain.Controls.Add(this.lblRepeatPassword);
            this.tabMain.Controls.Add(this.txtPassword);
            this.tabMain.Controls.Add(this.lblPassword);
            this.tabMain.Controls.Add(this.txtUsername);
            this.tabMain.Controls.Add(this.lblUsername);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(778, 494);
            this.tabMain.Text = "მთავარი";
            // 
            // bbPerson
            // 
            this.bbPerson.EnterMoveNextControl = true;
            this.bbPerson.IsOnline = true;
            this.bbPerson.Location = new System.Drawing.Point(156, 122);
            this.bbPerson.MenuManager = this.barManager;
            this.bbPerson.Name = "bbPerson";
            this.bbPerson.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F);
            this.bbPerson.Properties.Appearance.Options.UseFont = true;
            this.bbPerson.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "გახსნა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject1, "გახსნა (Ctrl+Enter)", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "წაშლა", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)), serializableAppearanceObject2, "წაშლა (Shift+Delete)", null, null, false)});
            this.bbPerson.Size = new System.Drawing.Size(387, 23);
            this.bbPerson.TabIndex = 10;
            this.bbPerson.TableName = Apothex.DataType.ObjectNames.Person;
            // 
            // chkChangePassword
            // 
            this.chkChangePassword.EditValue = true;
            this.chkChangePassword.Location = new System.Drawing.Point(130, 35);
            this.chkChangePassword.Name = "chkChangePassword";
            this.chkChangePassword.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkChangePassword.Properties.Appearance.Options.UseFont = true;
            this.chkChangePassword.Properties.Caption = "";
            this.chkChangePassword.Size = new System.Drawing.Size(22, 22);
            this.chkChangePassword.TabIndex = 3;
            this.chkChangePassword.CheckedChanged += new System.EventHandler(this.chkChangePassword_CheckedChanged);
            // 
            // lookBranch
            // 
            this.lookBranch.EnterMoveNextControl = true;
            this.lookBranch.Location = new System.Drawing.Point(156, 93);
            this.lookBranch.Name = "lookBranch";
            this.lookBranch.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookBranch.Properties.Appearance.Options.UseFont = true;
            this.lookBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookBranch.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 200, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.lookBranch.Properties.DataSource = this.bsBranch;
            this.lookBranch.Properties.DisplayMember = "Caption";
            this.lookBranch.Properties.NullText = "";
            this.lookBranch.Properties.ShowHeader = false;
            this.lookBranch.Properties.SortColumnIndex = 2;
            this.lookBranch.Properties.ValueMember = "ID";
            this.lookBranch.Size = new System.Drawing.Size(387, 23);
            this.lookBranch.TabIndex = 8;
            this.lookBranch.EditValueChanged += new System.EventHandler(this.lookBranch_EditValueChanged);
            // 
            // lblPerson
            // 
            this.lblPerson.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPerson.Location = new System.Drawing.Point(9, 125);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(69, 17);
            this.lblPerson.TabIndex = 9;
            this.lblPerson.Text = "პერსონა:";
            // 
            // lblBranch
            // 
            this.lblBranch.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBranch.Location = new System.Drawing.Point(9, 96);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(81, 17);
            this.lblBranch.TabIndex = 7;
            this.lblBranch.Text = "ფილიალი:";
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.EnterMoveNextControl = true;
            this.txtRepeatPassword.Location = new System.Drawing.Point(156, 64);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRepeatPassword.Properties.Appearance.Options.UseFont = true;
            this.txtRepeatPassword.Properties.PasswordChar = '*';
            this.txtRepeatPassword.Size = new System.Drawing.Size(387, 23);
            this.txtRepeatPassword.TabIndex = 6;
            this.txtRepeatPassword.EditValueChanged += new System.EventHandler(this.txtRepeatPassword_EditValueChanged);
            // 
            // lblRepeatPassword
            // 
            this.lblRepeatPassword.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRepeatPassword.Location = new System.Drawing.Point(9, 67);
            this.lblRepeatPassword.Name = "lblRepeatPassword";
            this.lblRepeatPassword.Size = new System.Drawing.Size(143, 17);
            this.lblRepeatPassword.TabIndex = 5;
            this.lblRepeatPassword.Text = "განმეორ. პაროლი:";
            // 
            // txtPassword
            // 
            this.txtPassword.EnterMoveNextControl = true;
            this.txtPassword.Location = new System.Drawing.Point(156, 35);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(387, 23);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.EditValueChanged += new System.EventHandler(this.txtPassword_EditValueChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Location = new System.Drawing.Point(9, 38);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "პაროლი:";
            // 
            // txtUsername
            // 
            this.txtUsername.EnterMoveNextControl = true;
            this.txtUsername.Location = new System.Drawing.Point(156, 6);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUsername.Properties.Appearance.Options.UseFont = true;
            this.txtUsername.Properties.MaxLength = 255;
            this.txtUsername.Size = new System.Drawing.Size(387, 23);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.EditValueChanged += new System.EventHandler(this.txtUsername_EditValueChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUsername.Location = new System.Drawing.Point(9, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(117, 17);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "მომხმარებელი:";
            // 
            // tabUserInGroup
            // 
            this.tabUserInGroup.Controls.Add(this.pnlUserInGroupFill);
            this.tabUserInGroup.Controls.Add(this.pnlUserInGroupTop);
            this.tabUserInGroup.Name = "tabUserInGroup";
            this.tabUserInGroup.Size = new System.Drawing.Size(778, 494);
            this.tabUserInGroup.Text = "ჯგუფებში განაწილება";
            // 
            // pnlUserInGroupFill
            // 
            this.pnlUserInGroupFill.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlUserInGroupFill.Controls.Add(this.lstRight);
            this.pnlUserInGroupFill.Controls.Add(this.pnlButton);
            this.pnlUserInGroupFill.Controls.Add(this.lstLeft);
            this.pnlUserInGroupFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserInGroupFill.Location = new System.Drawing.Point(0, 51);
            this.pnlUserInGroupFill.Name = "pnlUserInGroupFill";
            this.pnlUserInGroupFill.Size = new System.Drawing.Size(778, 443);
            this.pnlUserInGroupFill.TabIndex = 1;
            this.pnlUserInGroupFill.Resize += new System.EventHandler(this.pnlFill_Resize);
            // 
            // lstRight
            // 
            this.lstRight.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstRight.Appearance.Options.UseFont = true;
            this.lstRight.DataSource = this.bsRight;
            this.lstRight.DisplayMember = "UserGroup";
            this.lstRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstRight.Location = new System.Drawing.Point(414, 0);
            this.lstRight.Name = "lstRight";
            this.lstRight.Size = new System.Drawing.Size(364, 443);
            this.lstRight.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.lstRight.TabIndex = 2;
            this.lstRight.ValueMember = "UserGroupID";
            this.lstRight.DoubleClick += new System.EventHandler(this.lstRight_DoubleClick);
            // 
            // bsRight
            // 
            this.bsRight.DataMember = "SP_GetUserInGroup";
            this.bsRight.DataSource = this.ds_Right;
            // 
            // ds_Right
            // 
            this.ds_Right.DataSetName = "DS_User";
            this.ds_Right.Locale = new System.Globalization.CultureInfo("");
            this.ds_Right.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlButton
            // 
            this.pnlButton.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlButton.Controls.Add(this.btnLeft);
            this.pnlButton.Controls.Add(this.btnRight);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButton.Location = new System.Drawing.Point(369, 0);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(45, 443);
            this.pnlButton.TabIndex = 1;
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLeft.Image = global::Apothex.Users.Properties.Resources.Move_Previous__Arrow_24;
            this.btnLeft.Location = new System.Drawing.Point(6, 224);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(33, 33);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRight.Image = global::Apothex.Users.Properties.Resources.Move_Next__Arrow_24;
            this.btnRight.Location = new System.Drawing.Point(6, 185);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(33, 33);
            this.btnRight.TabIndex = 0;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // lstLeft
            // 
            this.lstLeft.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstLeft.Appearance.Options.UseFont = true;
            this.lstLeft.DataSource = this.bsLeft;
            this.lstLeft.DisplayMember = "Caption";
            this.lstLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstLeft.Location = new System.Drawing.Point(0, 0);
            this.lstLeft.Name = "lstLeft";
            this.lstLeft.Size = new System.Drawing.Size(369, 443);
            this.lstLeft.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.lstLeft.TabIndex = 0;
            this.lstLeft.ValueMember = "ID";
            this.lstLeft.DoubleClick += new System.EventHandler(this.lstLeft_DoubleClick);
            // 
            // bsLeft
            // 
            this.bsLeft.DataMember = "SP_GetDictionary";
            this.bsLeft.DataSource = this.ds_Left;
            // 
            // ds_Left
            // 
            this.ds_Left.DataSetName = "DS_Dictionary";
            this.ds_Left.Locale = new System.Globalization.CultureInfo("");
            this.ds_Left.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlUserInGroupTop
            // 
            this.pnlUserInGroupTop.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlUserInGroupTop.Controls.Add(this.btnRefreshUserInGroup);
            this.pnlUserInGroupTop.Controls.Add(this.btnSaveUserInGroup);
            this.pnlUserInGroupTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserInGroupTop.Location = new System.Drawing.Point(0, 0);
            this.pnlUserInGroupTop.Name = "pnlUserInGroupTop";
            this.pnlUserInGroupTop.Size = new System.Drawing.Size(778, 51);
            this.pnlUserInGroupTop.TabIndex = 0;
            // 
            // btnRefreshUserInGroup
            // 
            this.btnRefreshUserInGroup.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefreshUserInGroup.Appearance.Options.UseFont = true;
            this.btnRefreshUserInGroup.Image = global::Apothex.Users.Properties.Resources.Refresh24;
            this.btnRefreshUserInGroup.Location = new System.Drawing.Point(190, 9);
            this.btnRefreshUserInGroup.Name = "btnRefreshUserInGroup";
            this.btnRefreshUserInGroup.Size = new System.Drawing.Size(175, 33);
            this.btnRefreshUserInGroup.TabIndex = 0;
            this.btnRefreshUserInGroup.Text = "სიის განახლება";
            this.btnRefreshUserInGroup.Click += new System.EventHandler(this.btnRefreshUserInGroup_Click);
            // 
            // btnSaveUserInGroup
            // 
            this.btnSaveUserInGroup.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveUserInGroup.Appearance.Options.UseFont = true;
            this.btnSaveUserInGroup.Enabled = false;
            this.btnSaveUserInGroup.Image = global::Apothex.Users.Properties.Resources.Save24;
            this.btnSaveUserInGroup.Location = new System.Drawing.Point(9, 9);
            this.btnSaveUserInGroup.Name = "btnSaveUserInGroup";
            this.btnSaveUserInGroup.Size = new System.Drawing.Size(175, 33);
            this.btnSaveUserInGroup.TabIndex = 0;
            this.btnSaveUserInGroup.Text = "განაწ. შენახვა";
            this.btnSaveUserInGroup.Click += new System.EventHandler(this.btnSaveUserInGroup_Click);
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
            // frmUserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.xtraTabControl);
            this.Name = "frmUserEdit";
            this.ObjectName = Apothex.DataType.ObjectNames.User;
            this.OptionsBaseForm.Text = "მომხმარებელი";
            this.Text = "მომხმარებელი";
            this.Controls.SetChildIndex(this.xtraTabControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkChangePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepeatPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            this.tabUserInGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlUserInGroupFill)).EndInit();
            this.pnlUserInGroupFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButton)).EndInit();
            this.pnlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUserInGroupTop)).EndInit();
            this.pnlUserInGroupTop.ResumeLayout(false);
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
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.LabelControl lblUsername;
        private DevExpress.XtraTab.XtraTabPage tabInfo;
        private Apothex.Windows.Forms.ButtonBrowse bbApprover;
        private Apothex.Windows.Forms.ButtonBrowse bbModifier;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblApprover;
        private DevExpress.XtraEditors.DateEdit dateModifiedDate;
        private DevExpress.XtraEditors.LabelControl lblModifier;
        private DevExpress.XtraEditors.LabelControl lblModifiedDate;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.LabelControl lblBranch;
        private DevExpress.XtraEditors.TextEdit txtRepeatPassword;
        private DevExpress.XtraEditors.LabelControl lblRepeatPassword;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.LookUpEdit lookBranch;
        private System.Windows.Forms.BindingSource bsBranch;
        private DevExpress.XtraEditors.CheckEdit chkChangePassword;
        private DevExpress.XtraTab.XtraTabPage tabUserInGroup;
        private DevExpress.XtraEditors.PanelControl pnlUserInGroupFill;
        private DevExpress.XtraEditors.PanelControl pnlUserInGroupTop;
        private DevExpress.XtraEditors.SimpleButton btnSaveUserInGroup;
        private DevExpress.XtraEditors.ListBoxControl lstRight;
        private DevExpress.XtraEditors.PanelControl pnlButton;
        private DevExpress.XtraEditors.ListBoxControl lstLeft;
        private DevExpress.XtraEditors.SimpleButton btnLeft;
        private DevExpress.XtraEditors.SimpleButton btnRight;
        private System.Windows.Forms.BindingSource bsLeft;
        private System.Windows.Forms.BindingSource bsRight;
        private Apothex.DataType.DS_User ds_Right;
        private Apothex.DataType.DS_Dictionary ds_Left;
        private DevExpress.XtraEditors.SimpleButton btnRefreshUserInGroup;
        private Windows.Forms.ButtonBrowse bbPerson;
        private DevExpress.XtraEditors.LabelControl lblPerson;
    }
}