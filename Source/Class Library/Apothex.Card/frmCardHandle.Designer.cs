namespace Apothex.Card
{
    partial class frmCardHandle
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
            this.txtCardNumber = new Zek.Windows.Forms.DevEx.CardReaderTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Appearance.Options.UseFont = true;
            this.btnOk.Location = new System.Drawing.Point(44, 47);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(200, 47);
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(12, 12);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCardNumber.Properties.Appearance.Options.UseFont = true;
            this.txtCardNumber.Size = new System.Drawing.Size(370, 26);
            this.txtCardNumber.TabIndex = 0;
            this.txtCardNumber.EditValueChanged += new System.EventHandler(this.txtCardNumber_EditValueChanged);
            // 
            // frmCardHandle
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 92);
            this.Controls.Add(this.txtCardNumber);
            this.Name = "frmCardHandle";
            this.OptionsBaseForm.Text = "ბარათის გატარება";
            this.OptionsPermission.AutoCheckPermission = false;
            this.OptionsPermission.AutoInitPermission = false;
            this.Text = "ბარათის გატარება";
            this.Controls.SetChildIndex(this.txtCardNumber, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardNumber.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Zek.Windows.Forms.DevEx.CardReaderTextEdit txtCardNumber;

    }
}