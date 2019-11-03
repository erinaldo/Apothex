namespace Apothex.Sales
{
    partial class frmCalculator
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
            this.lblPayed = new DevExpress.XtraEditors.LabelControl();
            this.spinPayed = new DevExpress.XtraEditors.SpinEdit();
            this.lblTotalDue = new DevExpress.XtraEditors.LabelControl();
            this.spinTotalDue = new DevExpress.XtraEditors.SpinEdit();
            this.lblReturned = new DevExpress.XtraEditors.LabelControl();
            this.spinReturned = new DevExpress.XtraEditors.SpinEdit();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.spinPayed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalDue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinReturned.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPayed
            // 
            this.lblPayed.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPayed.Appearance.Options.UseFont = true;
            this.lblPayed.Location = new System.Drawing.Point(12, 15);
            this.lblPayed.Name = "lblPayed";
            this.lblPayed.Size = new System.Drawing.Size(93, 17);
            this.lblPayed.TabIndex = 0;
            this.lblPayed.Text = "გადაიხადეს:";
            // 
            // spinPayed
            // 
            this.spinPayed.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinPayed.EnterMoveNextControl = true;
            this.spinPayed.Location = new System.Drawing.Point(135, 12);
            this.spinPayed.Name = "spinPayed";
            this.spinPayed.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinPayed.Properties.Appearance.Options.UseFont = true;
            this.spinPayed.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinPayed.Properties.DisplayFormat.FormatString = "n2";
            this.spinPayed.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinPayed.Properties.EditFormat.FormatString = "n2";
            this.spinPayed.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinPayed.Properties.Mask.EditMask = "n2";
            this.spinPayed.Properties.MaxValue = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.spinPayed.Size = new System.Drawing.Size(147, 23);
            this.spinPayed.TabIndex = 1;
            this.spinPayed.EditValueChanged += new System.EventHandler(this.spinPayed_EditValueChanged);
            this.spinPayed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.spinPayed_KeyDown);
            // 
            // lblTotalDue
            // 
            this.lblTotalDue.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalDue.Appearance.Options.UseFont = true;
            this.lblTotalDue.Location = new System.Drawing.Point(12, 44);
            this.lblTotalDue.Name = "lblTotalDue";
            this.lblTotalDue.Size = new System.Drawing.Size(109, 17);
            this.lblTotalDue.TabIndex = 2;
            this.lblTotalDue.Text = "გადასახდელი:";
            // 
            // spinTotalDue
            // 
            this.spinTotalDue.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTotalDue.EnterMoveNextControl = true;
            this.spinTotalDue.Location = new System.Drawing.Point(135, 41);
            this.spinTotalDue.Name = "spinTotalDue";
            this.spinTotalDue.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinTotalDue.Properties.Appearance.Options.UseFont = true;
            this.spinTotalDue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinTotalDue.Properties.DisplayFormat.FormatString = "n2";
            this.spinTotalDue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTotalDue.Properties.EditFormat.FormatString = "n2";
            this.spinTotalDue.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTotalDue.Properties.Mask.EditMask = "n2";
            this.spinTotalDue.Properties.ReadOnly = true;
            this.spinTotalDue.Size = new System.Drawing.Size(147, 23);
            this.spinTotalDue.TabIndex = 3;
            this.spinTotalDue.TabStop = false;
            // 
            // lblReturned
            // 
            this.lblReturned.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReturned.Appearance.Options.UseFont = true;
            this.lblReturned.Location = new System.Drawing.Point(12, 73);
            this.lblReturned.Name = "lblReturned";
            this.lblReturned.Size = new System.Drawing.Size(53, 17);
            this.lblReturned.TabIndex = 4;
            this.lblReturned.Text = "ხურდა:";
            // 
            // spinReturned
            // 
            this.spinReturned.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinReturned.EnterMoveNextControl = true;
            this.spinReturned.Location = new System.Drawing.Point(135, 70);
            this.spinReturned.Name = "spinReturned";
            this.spinReturned.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinReturned.Properties.Appearance.Options.UseFont = true;
            this.spinReturned.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinReturned.Properties.DisplayFormat.FormatString = "n2";
            this.spinReturned.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinReturned.Properties.EditFormat.FormatString = "n2";
            this.spinReturned.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinReturned.Properties.Mask.EditMask = "n2";
            this.spinReturned.Properties.ReadOnly = true;
            this.spinReturned.Size = new System.Drawing.Size(147, 23);
            this.spinReturned.TabIndex = 5;
            this.spinReturned.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Appearance.Options.UseFont = true;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.Location = new System.Drawing.Point(13, 98);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(268, 38);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "დახურვა";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOk;
            this.ClientSize = new System.Drawing.Size(294, 148);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.spinReturned);
            this.Controls.Add(this.lblReturned);
            this.Controls.Add(this.spinTotalDue);
            this.Controls.Add(this.lblTotalDue);
            this.Controls.Add(this.spinPayed);
            this.Controls.Add(this.lblPayed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculator";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "კალკულატორი";
            ((System.ComponentModel.ISupportInitialize)(this.spinPayed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalDue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinReturned.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblPayed;
        private DevExpress.XtraEditors.SpinEdit spinPayed;
        private DevExpress.XtraEditors.LabelControl lblTotalDue;
        private DevExpress.XtraEditors.SpinEdit spinTotalDue;
        private DevExpress.XtraEditors.LabelControl lblReturned;
        private DevExpress.XtraEditors.SpinEdit spinReturned;
        private DevExpress.XtraEditors.SimpleButton btnOk;
    }
}