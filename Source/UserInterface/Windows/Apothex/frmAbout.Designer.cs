namespace Apothex
{
    partial class frmAbout
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
            this.lblProductName = new DevExpress.XtraEditors.LabelControl();
            this.lblVersion = new DevExpress.XtraEditors.LabelControl();
            this.lblCompanyName = new DevExpress.XtraEditors.LabelControl();
            this.lblCopyright = new DevExpress.XtraEditors.LabelControl();
            this.lnkVisitSite = new System.Windows.Forms.LinkLabel();
            this.memoDescription = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductName.Appearance.Options.UseFont = true;
            this.lblProductName.Location = new System.Drawing.Point(12, 12);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(83, 17);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "პროდუქტი:";
            // 
            // lblVersion
            // 
            this.lblVersion.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVersion.Appearance.Options.UseFont = true;
            this.lblVersion.Location = new System.Drawing.Point(12, 35);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(57, 17);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "ვერსია:";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompanyName.Appearance.Options.UseFont = true;
            this.lblCompanyName.Location = new System.Drawing.Point(12, 58);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(72, 17);
            this.lblCompanyName.TabIndex = 2;
            this.lblCompanyName.Text = "კომპანია:";
            // 
            // lblCopyright
            // 
            this.lblCopyright.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCopyright.Appearance.Options.UseFont = true;
            this.lblCopyright.Location = new System.Drawing.Point(12, 81);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(148, 17);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "საავტორო უფლება:";
            // 
            // lnkVisitSite
            // 
            this.lnkVisitSite.AutoSize = true;
            this.lnkVisitSite.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkVisitSite.Location = new System.Drawing.Point(9, 101);
            this.lnkVisitSite.Name = "lnkVisitSite";
            this.lnkVisitSite.Size = new System.Drawing.Size(143, 17);
            this.lnkVisitSite.TabIndex = 4;
            this.lnkVisitSite.TabStop = true;
            this.lnkVisitSite.Text = "www.programmer.ge";
            this.lnkVisitSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkVisitSite_LinkClicked);
            // 
            // memoDescription
            // 
            this.memoDescription.Location = new System.Drawing.Point(12, 121);
            this.memoDescription.Name = "memoDescription";
            this.memoDescription.Properties.ReadOnly = true;
            this.memoDescription.Size = new System.Drawing.Size(390, 135);
            this.memoDescription.TabIndex = 5;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 268);
            this.Controls.Add(this.memoDescription);
            this.Controls.Add(this.lnkVisitSite);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "პროგრამის შესახებ";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memoDescription.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblProductName;
        private DevExpress.XtraEditors.LabelControl lblVersion;
        private DevExpress.XtraEditors.LabelControl lblCompanyName;
        private DevExpress.XtraEditors.LabelControl lblCopyright;
        private System.Windows.Forms.LinkLabel lnkVisitSite;
        private DevExpress.XtraEditors.MemoEdit memoDescription;
    }
}