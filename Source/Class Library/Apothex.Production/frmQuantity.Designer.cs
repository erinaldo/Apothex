namespace Apothex.Production
{
    partial class frmQuantity
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
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.spinUnit = new DevExpress.XtraEditors.SpinEdit();
            this.lblUnitQty = new DevExpress.XtraEditors.LabelControl();
            this.lblOutQuantity = new DevExpress.XtraEditors.LabelControl();
            this.spinAvailability = new DevExpress.XtraEditors.SpinEdit();
            this.lblAvailability = new DevExpress.XtraEditors.LabelControl();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lblPrice = new DevExpress.XtraEditors.LabelControl();
            this.spinSaleUnitPrice = new DevExpress.XtraEditors.SpinEdit();
            this.lblOneSaleUnitPrice = new DevExpress.XtraEditors.LabelControl();
            this.spinOneSaleUnitPrice = new DevExpress.XtraEditors.SpinEdit();
            this.lblSaleLineTotal = new DevExpress.XtraEditors.LabelControl();
            this.spinSaleLineTotal = new DevExpress.XtraEditors.SpinEdit();
            this.calcOutQty = new DevExpress.XtraEditors.CalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.spinUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAvailability.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSaleUnitPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinOneSaleUnitPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSaleLineTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcOutQty.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Appearance.Options.UseFont = true;
            this.btnOk.Location = new System.Drawing.Point(124, 123);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(130, 33);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // spinUnit
            // 
            this.spinUnit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinUnit.EnterMoveNextControl = true;
            this.spinUnit.Location = new System.Drawing.Point(111, 41);
            this.spinUnit.Name = "spinUnit";
            this.spinUnit.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinUnit.Properties.Appearance.Options.UseFont = true;
            this.spinUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinUnit.Properties.DisplayFormat.FormatString = "N00";
            this.spinUnit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinUnit.Properties.EditFormat.FormatString = "N00";
            this.spinUnit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinUnit.Properties.IsFloatValue = false;
            this.spinUnit.Properties.Mask.EditMask = "N00";
            this.spinUnit.Size = new System.Drawing.Size(147, 23);
            this.spinUnit.TabIndex = 3;
            this.spinUnit.EditValueChanged += new System.EventHandler(this.spinUnit_EditValueChanged);
            // 
            // lblUnitQty
            // 
            this.lblUnitQty.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUnitQty.Appearance.Options.UseFont = true;
            this.lblUnitQty.Location = new System.Drawing.Point(12, 44);
            this.lblUnitQty.Name = "lblUnitQty";
            this.lblUnitQty.Size = new System.Drawing.Size(46, 17);
            this.lblUnitQty.TabIndex = 2;
            this.lblUnitQty.Text = "ცალი:";
            // 
            // lblOutQuantity
            // 
            this.lblOutQuantity.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOutQuantity.Appearance.Options.UseFont = true;
            this.lblOutQuantity.Location = new System.Drawing.Point(12, 15);
            this.lblOutQuantity.Name = "lblOutQuantity";
            this.lblOutQuantity.Size = new System.Drawing.Size(93, 17);
            this.lblOutQuantity.TabIndex = 0;
            this.lblOutQuantity.Text = "რაოდენობა:";
            // 
            // spinAvailability
            // 
            this.spinAvailability.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinAvailability.EnterMoveNextControl = true;
            this.spinAvailability.Location = new System.Drawing.Point(111, 70);
            this.spinAvailability.Name = "spinAvailability";
            this.spinAvailability.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinAvailability.Properties.Appearance.Options.UseFont = true;
            this.spinAvailability.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinAvailability.Properties.DisplayFormat.FormatString = "n4";
            this.spinAvailability.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinAvailability.Properties.EditFormat.FormatString = "n4";
            this.spinAvailability.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinAvailability.Properties.Mask.EditMask = "n4";
            this.spinAvailability.Properties.ReadOnly = true;
            this.spinAvailability.Size = new System.Drawing.Size(147, 23);
            this.spinAvailability.TabIndex = 5;
            this.spinAvailability.TabStop = false;
            // 
            // lblAvailability
            // 
            this.lblAvailability.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAvailability.Appearance.Options.UseFont = true;
            this.lblAvailability.Location = new System.Drawing.Point(12, 73);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(49, 17);
            this.lblAvailability.TabIndex = 4;
            this.lblAvailability.Text = "ნაშთი:";
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(260, 123);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 33);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            // 
            // lblPrice
            // 
            this.lblPrice.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Appearance.Options.UseFont = true;
            this.lblPrice.Location = new System.Drawing.Point(277, 15);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(64, 17);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "ფასი / გ:";
            // 
            // spinSaleUnitPrice
            // 
            this.spinSaleUnitPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinSaleUnitPrice.EnterMoveNextControl = true;
            this.spinSaleUnitPrice.Location = new System.Drawing.Point(347, 12);
            this.spinSaleUnitPrice.Name = "spinSaleUnitPrice";
            this.spinSaleUnitPrice.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinSaleUnitPrice.Properties.Appearance.Options.UseFont = true;
            this.spinSaleUnitPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinSaleUnitPrice.Properties.DisplayFormat.FormatString = "n4";
            this.spinSaleUnitPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSaleUnitPrice.Properties.EditFormat.FormatString = "n4";
            this.spinSaleUnitPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSaleUnitPrice.Properties.Mask.EditMask = "n4";
            this.spinSaleUnitPrice.Properties.ReadOnly = true;
            this.spinSaleUnitPrice.Size = new System.Drawing.Size(147, 23);
            this.spinSaleUnitPrice.TabIndex = 7;
            this.spinSaleUnitPrice.TabStop = false;
            // 
            // lblOneSaleUnitPrice
            // 
            this.lblOneSaleUnitPrice.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOneSaleUnitPrice.Appearance.Options.UseFont = true;
            this.lblOneSaleUnitPrice.Location = new System.Drawing.Point(277, 44);
            this.lblOneSaleUnitPrice.Name = "lblOneSaleUnitPrice";
            this.lblOneSaleUnitPrice.Size = new System.Drawing.Size(65, 17);
            this.lblOneSaleUnitPrice.TabIndex = 8;
            this.lblOneSaleUnitPrice.Text = "ფასი / ც:";
            // 
            // spinOneSaleUnitPrice
            // 
            this.spinOneSaleUnitPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinOneSaleUnitPrice.EnterMoveNextControl = true;
            this.spinOneSaleUnitPrice.Location = new System.Drawing.Point(347, 41);
            this.spinOneSaleUnitPrice.Name = "spinOneSaleUnitPrice";
            this.spinOneSaleUnitPrice.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinOneSaleUnitPrice.Properties.Appearance.Options.UseFont = true;
            this.spinOneSaleUnitPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinOneSaleUnitPrice.Properties.DisplayFormat.FormatString = "n4";
            this.spinOneSaleUnitPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinOneSaleUnitPrice.Properties.EditFormat.FormatString = "n4";
            this.spinOneSaleUnitPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinOneSaleUnitPrice.Properties.Mask.EditMask = "n4";
            this.spinOneSaleUnitPrice.Properties.ReadOnly = true;
            this.spinOneSaleUnitPrice.Size = new System.Drawing.Size(147, 23);
            this.spinOneSaleUnitPrice.TabIndex = 9;
            this.spinOneSaleUnitPrice.TabStop = false;
            // 
            // lblSaleLineTotal
            // 
            this.lblSaleLineTotal.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSaleLineTotal.Appearance.Options.UseFont = true;
            this.lblSaleLineTotal.Location = new System.Drawing.Point(277, 73);
            this.lblSaleLineTotal.Name = "lblSaleLineTotal";
            this.lblSaleLineTotal.Size = new System.Drawing.Size(37, 17);
            this.lblSaleLineTotal.TabIndex = 10;
            this.lblSaleLineTotal.Text = "ჯამი:";
            // 
            // spinSaleLineTotal
            // 
            this.spinSaleLineTotal.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinSaleLineTotal.EnterMoveNextControl = true;
            this.spinSaleLineTotal.Location = new System.Drawing.Point(347, 70);
            this.spinSaleLineTotal.Name = "spinSaleLineTotal";
            this.spinSaleLineTotal.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinSaleLineTotal.Properties.Appearance.Options.UseFont = true;
            this.spinSaleLineTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinSaleLineTotal.Properties.DisplayFormat.FormatString = "n4";
            this.spinSaleLineTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSaleLineTotal.Properties.EditFormat.FormatString = "n4";
            this.spinSaleLineTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSaleLineTotal.Properties.Mask.EditMask = "n4";
            this.spinSaleLineTotal.Properties.ReadOnly = true;
            this.spinSaleLineTotal.Size = new System.Drawing.Size(147, 23);
            this.spinSaleLineTotal.TabIndex = 11;
            this.spinSaleLineTotal.TabStop = false;
            // 
            // calcOutQty
            // 
            this.calcOutQty.EnterMoveNextControl = true;
            this.calcOutQty.Location = new System.Drawing.Point(111, 12);
            this.calcOutQty.Name = "calcOutQty";
            this.calcOutQty.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcOutQty.Properties.Appearance.Options.UseFont = true;
            this.calcOutQty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcOutQty.Properties.DisplayFormat.FormatString = "n4";
            this.calcOutQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcOutQty.Properties.EditFormat.FormatString = "n4";
            this.calcOutQty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcOutQty.Properties.Mask.EditMask = "n4";
            this.calcOutQty.Properties.Precision = 4;
            this.calcOutQty.Size = new System.Drawing.Size(147, 23);
            this.calcOutQty.TabIndex = 1;
            this.calcOutQty.ValueChanged += new System.EventHandler(this.calcOutQty_ValueChanged);
            // 
            // frmQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(514, 168);
            this.Controls.Add(this.calcOutQty);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.spinSaleLineTotal);
            this.Controls.Add(this.lblSaleLineTotal);
            this.Controls.Add(this.spinOneSaleUnitPrice);
            this.Controls.Add(this.lblOneSaleUnitPrice);
            this.Controls.Add(this.spinSaleUnitPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.spinAvailability);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.spinUnit);
            this.Controls.Add(this.lblUnitQty);
            this.Controls.Add(this.lblOutQuantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuantity";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "რაოდენობა";
            ((System.ComponentModel.ISupportInitialize)(this.spinUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAvailability.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSaleUnitPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinOneSaleUnitPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSaleLineTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcOutQty.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SpinEdit spinUnit;
        private DevExpress.XtraEditors.LabelControl lblUnitQty;
        private DevExpress.XtraEditors.LabelControl lblOutQuantity;
        private DevExpress.XtraEditors.SpinEdit spinAvailability;
        private DevExpress.XtraEditors.LabelControl lblAvailability;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SpinEdit spinSaleUnitPrice;
        private DevExpress.XtraEditors.LabelControl lblPrice;
        private DevExpress.XtraEditors.SpinEdit spinOneSaleUnitPrice;
        private DevExpress.XtraEditors.LabelControl lblOneSaleUnitPrice;
        private DevExpress.XtraEditors.SpinEdit spinSaleLineTotal;
        private DevExpress.XtraEditors.LabelControl lblSaleLineTotal;
        private DevExpress.XtraEditors.CalcEdit calcOutQty;
    }
}