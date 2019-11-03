namespace Apothex.Production
{
    partial class frmChangeCurencyCode
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
            this.lblProductCurrency = new DevExpress.XtraEditors.LabelControl();
            this.lookProductCurrency = new DevExpress.XtraEditors.LookUpEdit();
            this.bsProductCurrency = new System.Windows.Forms.BindingSource(this.components);
            this.chkChangePrice = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookProductCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkChangePrice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Appearance.Options.UseFont = true;
            this.btnOk.Location = new System.Drawing.Point(44, 87);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(200, 87);
            // 
            // lblProductCurrency
            // 
            this.lblProductCurrency.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductCurrency.Appearance.Options.UseFont = true;
            this.lblProductCurrency.Location = new System.Drawing.Point(12, 15);
            this.lblProductCurrency.Name = "lblProductCurrency";
            this.lblProductCurrency.Size = new System.Drawing.Size(63, 17);
            this.lblProductCurrency.TabIndex = 0;
            this.lblProductCurrency.Text = "ვალუტა:";
            // 
            // lookProductCurrency
            // 
            this.lookProductCurrency.EnterMoveNextControl = true;
            this.lookProductCurrency.Location = new System.Drawing.Point(81, 12);
            this.lookProductCurrency.Name = "lookProductCurrency";
            this.lookProductCurrency.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.lookProductCurrency.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookProductCurrency.Properties.Appearance.Options.UseFont = true;
            this.lookProductCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookProductCurrency.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption")});
            this.lookProductCurrency.Properties.DataSource = this.bsProductCurrency;
            this.lookProductCurrency.Properties.DisplayMember = "Caption";
            this.lookProductCurrency.Properties.NullText = "";
            this.lookProductCurrency.Properties.ShowHeader = false;
            this.lookProductCurrency.Properties.ValueMember = "ID";
            this.lookProductCurrency.Size = new System.Drawing.Size(301, 23);
            this.lookProductCurrency.TabIndex = 1;
            this.lookProductCurrency.EditValueChanged += new System.EventHandler(this.lookProductCurrency_EditValueChanged);
            // 
            // chkChangePrice
            // 
            this.chkChangePrice.EditValue = true;
            this.chkChangePrice.Location = new System.Drawing.Point(12, 41);
            this.chkChangePrice.Name = "chkChangePrice";
            this.chkChangePrice.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkChangePrice.Properties.Appearance.Options.UseFont = true;
            this.chkChangePrice.Properties.Caption = "ფასის გადაყვანა კურსის მიხედვით";
            this.chkChangePrice.Size = new System.Drawing.Size(370, 22);
            this.chkChangePrice.TabIndex = 2;
            // 
            // frmChangeCurencyCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 132);
            this.Controls.Add(this.lblProductCurrency);
            this.Controls.Add(this.lookProductCurrency);
            this.Controls.Add(this.chkChangePrice);
            this.Name = "frmChangeCurencyCode";
            this.ObjectName = Apothex.DataType.ObjectNames.Product;
            this.Text = "პ/ე ვალუტის შეცვლა";
            this.Controls.SetChildIndex(this.chkChangePrice, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.lookProductCurrency, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lblProductCurrency, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookProductCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkChangePrice.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblProductCurrency;
        private DevExpress.XtraEditors.LookUpEdit lookProductCurrency;
        private System.Windows.Forms.BindingSource bsProductCurrency;
        private DevExpress.XtraEditors.CheckEdit chkChangePrice;
    }
}