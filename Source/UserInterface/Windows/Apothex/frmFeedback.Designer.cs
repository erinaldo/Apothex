namespace Apothex
{
    partial class frmFeedback
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
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.lblSubject = new DevExpress.XtraEditors.LabelControl();
            this.txtSubject = new DevExpress.XtraEditors.TextEdit();
            this.grpMessage = new DevExpress.XtraEditors.GroupControl();
            this.memoMessage = new DevExpress.XtraEditors.MemoEdit();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMessage)).BeginInit();
            this.grpMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoMessage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Appearance.Options.UseFont = true;
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "სახელი:";
            // 
            // txtName
            // 
            this.txtName.EnterMoveNextControl = true;
            this.txtName.Location = new System.Drawing.Point(109, 12);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(271, 23);
            this.txtName.TabIndex = 1;
            this.txtName.EditValueChanged += new System.EventHandler(this.txtName_EditValueChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmail.Appearance.Options.UseFont = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 44);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(89, 17);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "ელ. ფოსტა:";
            // 
            // txtEmail
            // 
            this.txtEmail.EnterMoveNextControl = true;
            this.txtEmail.Location = new System.Drawing.Point(109, 41);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Size = new System.Drawing.Size(271, 23);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.EditValueChanged += new System.EventHandler(this.txtEmail_EditValueChanged);
            // 
            // lblSubject
            // 
            this.lblSubject.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSubject.Appearance.Options.UseFont = true;
            this.lblSubject.Location = new System.Drawing.Point(12, 73);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(69, 17);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "სათაური:";
            // 
            // txtSubject
            // 
            this.txtSubject.EnterMoveNextControl = true;
            this.txtSubject.Location = new System.Drawing.Point(109, 70);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSubject.Properties.Appearance.Options.UseFont = true;
            this.txtSubject.Size = new System.Drawing.Size(271, 23);
            this.txtSubject.TabIndex = 5;
            this.txtSubject.EditValueChanged += new System.EventHandler(this.txtSubject_EditValueChanged);
            // 
            // grpMessage
            // 
            this.grpMessage.AppearanceCaption.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpMessage.AppearanceCaption.Options.UseFont = true;
            this.grpMessage.Controls.Add(this.memoMessage);
            this.grpMessage.Location = new System.Drawing.Point(12, 99);
            this.grpMessage.Name = "grpMessage";
            this.grpMessage.Size = new System.Drawing.Size(370, 178);
            this.grpMessage.TabIndex = 6;
            this.grpMessage.Text = "მესიჯი:";
            // 
            // memoMessage
            // 
            this.memoMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoMessage.Location = new System.Drawing.Point(2, 23);
            this.memoMessage.Name = "memoMessage";
            this.memoMessage.Size = new System.Drawing.Size(366, 153);
            this.memoMessage.TabIndex = 0;
            this.memoMessage.EditValueChanged += new System.EventHandler(this.memoMessage_EditValueChanged);
            // 
            // btnOk
            // 
            this.btnOk.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Appearance.Options.UseFont = true;
            this.btnOk.Image = global::Apothex.Properties.Resources.mail_24x24;
            this.btnOk.Location = new System.Drawing.Point(44, 283);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(150, 33);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "გაგზავნა";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::Apothex.Properties.Resources.delete_24x24;
            this.btnCancel.Location = new System.Drawing.Point(200, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 33);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "გაუქმება";
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // frmFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(394, 328);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpMessage);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFeedback";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ავტორთან გაგზავნა";
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMessage)).EndInit();
            this.grpMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoMessage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl lblEmail;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl lblSubject;
        private DevExpress.XtraEditors.TextEdit txtSubject;
        private DevExpress.XtraEditors.GroupControl grpMessage;
        private DevExpress.XtraEditors.MemoEdit memoMessage;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
    }
}