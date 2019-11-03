namespace Apothex.Production
{
    partial class frmVendor
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.lblOrderID = new DevExpress.XtraEditors.LabelControl();
            this.txtOrderID = new DevExpress.XtraEditors.TextEdit();
            this.dateOrderDate = new DevExpress.XtraEditors.DateEdit();
            this.lblOrderDate = new DevExpress.XtraEditors.LabelControl();
            this.lblBranch = new DevExpress.XtraEditors.LabelControl();
            this.txtBranch = new DevExpress.XtraEditors.TextEdit();
            this.lblVendor = new DevExpress.XtraEditors.LabelControl();
            this.txtVendor = new DevExpress.XtraEditors.TextEdit();
            this.lblMedicament = new DevExpress.XtraEditors.LabelControl();
            this.txtMedicament = new DevExpress.XtraEditors.TextEdit();
            this.lblReceivedQty = new DevExpress.XtraEditors.LabelControl();
            this.spinReceivedQty = new DevExpress.XtraEditors.SpinEdit();
            this.lblUnitPrice = new DevExpress.XtraEditors.LabelControl();
            this.spinUnitPrice = new DevExpress.XtraEditors.SpinEdit();
            this.txtCurrency = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVendor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMedicament.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinReceivedQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinUnitPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrency.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Appearance.Options.UseFont = true;
            this.btnOk.Location = new System.Drawing.Point(92, 209);
            this.btnOk.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(172, 209);
            // 
            // lblOrderID
            // 
            this.lblOrderID.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderID.Appearance.Options.UseFont = true;
            this.lblOrderID.Location = new System.Drawing.Point(12, 9);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(20, 17);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "№:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.EnterMoveNextControl = true;
            this.txtOrderID.Location = new System.Drawing.Point(120, 6);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOrderID.Properties.Appearance.Options.UseFont = true;
            this.txtOrderID.Size = new System.Drawing.Size(150, 23);
            this.txtOrderID.TabIndex = 1;
            // 
            // dateOrderDate
            // 
            this.dateOrderDate.EditValue = null;
            this.dateOrderDate.EnterMoveNextControl = true;
            this.dateOrderDate.Location = new System.Drawing.Point(120, 35);
            this.dateOrderDate.Name = "dateOrderDate";
            this.dateOrderDate.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOrderDate.Properties.Appearance.Options.UseFont = true;
            this.dateOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, false)});
            this.dateOrderDate.Properties.DisplayFormat.FormatString = "G";
            this.dateOrderDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateOrderDate.Properties.EditFormat.FormatString = "G";
            this.dateOrderDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateOrderDate.Properties.Mask.EditMask = "G";
            this.dateOrderDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateOrderDate.Size = new System.Drawing.Size(150, 23);
            this.dateOrderDate.TabIndex = 3;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderDate.Appearance.Options.UseFont = true;
            this.lblOrderDate.Location = new System.Drawing.Point(12, 38);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(65, 17);
            this.lblOrderDate.TabIndex = 2;
            this.lblOrderDate.Text = "თარიღი:";
            // 
            // lblBranch
            // 
            this.lblBranch.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBranch.Appearance.Options.UseFont = true;
            this.lblBranch.Location = new System.Drawing.Point(12, 67);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(81, 17);
            this.lblBranch.TabIndex = 4;
            this.lblBranch.Text = "ფილიალი:";
            // 
            // txtBranch
            // 
            this.txtBranch.EnterMoveNextControl = true;
            this.txtBranch.Location = new System.Drawing.Point(120, 64);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBranch.Properties.Appearance.Options.UseFont = true;
            this.txtBranch.Size = new System.Drawing.Size(350, 23);
            this.txtBranch.TabIndex = 5;
            // 
            // lblVendor
            // 
            this.lblVendor.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVendor.Appearance.Options.UseFont = true;
            this.lblVendor.Location = new System.Drawing.Point(12, 96);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(72, 17);
            this.lblVendor.TabIndex = 6;
            this.lblVendor.Text = "კომპანია:";
            // 
            // txtVendor
            // 
            this.txtVendor.EnterMoveNextControl = true;
            this.txtVendor.Location = new System.Drawing.Point(120, 93);
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtVendor.Properties.Appearance.Options.UseFont = true;
            this.txtVendor.Size = new System.Drawing.Size(350, 23);
            this.txtVendor.TabIndex = 7;
            // 
            // lblMedicament
            // 
            this.lblMedicament.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMedicament.Appearance.Options.UseFont = true;
            this.lblMedicament.Location = new System.Drawing.Point(12, 125);
            this.lblMedicament.Name = "lblMedicament";
            this.lblMedicament.Size = new System.Drawing.Size(83, 17);
            this.lblMedicament.TabIndex = 8;
            this.lblMedicament.Text = "პროდუქტი:";
            // 
            // txtMedicament
            // 
            this.txtMedicament.EnterMoveNextControl = true;
            this.txtMedicament.Location = new System.Drawing.Point(120, 122);
            this.txtMedicament.Name = "txtMedicament";
            this.txtMedicament.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMedicament.Properties.Appearance.Options.UseFont = true;
            this.txtMedicament.Size = new System.Drawing.Size(350, 23);
            this.txtMedicament.TabIndex = 9;
            // 
            // lblReceivedQty
            // 
            this.lblReceivedQty.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReceivedQty.Appearance.Options.UseFont = true;
            this.lblReceivedQty.Location = new System.Drawing.Point(12, 154);
            this.lblReceivedQty.Name = "lblReceivedQty";
            this.lblReceivedQty.Size = new System.Drawing.Size(91, 17);
            this.lblReceivedQty.TabIndex = 10;
            this.lblReceivedQty.Text = "შესყ. რაოდ:";
            // 
            // spinReceivedQty
            // 
            this.spinReceivedQty.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinReceivedQty.EnterMoveNextControl = true;
            this.spinReceivedQty.Location = new System.Drawing.Point(120, 151);
            this.spinReceivedQty.Name = "spinReceivedQty";
            this.spinReceivedQty.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinReceivedQty.Properties.Appearance.Options.UseFont = true;
            this.spinReceivedQty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, false)});
            this.spinReceivedQty.Properties.DisplayFormat.FormatString = "n4";
            this.spinReceivedQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinReceivedQty.Properties.EditFormat.FormatString = "n4";
            this.spinReceivedQty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinReceivedQty.Properties.Mask.EditMask = "n4";
            this.spinReceivedQty.Size = new System.Drawing.Size(150, 23);
            this.spinReceivedQty.TabIndex = 11;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUnitPrice.Appearance.Options.UseFont = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(12, 183);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(41, 17);
            this.lblUnitPrice.TabIndex = 12;
            this.lblUnitPrice.Text = "ფასი:";
            // 
            // spinUnitPrice
            // 
            this.spinUnitPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinUnitPrice.EnterMoveNextControl = true;
            this.spinUnitPrice.Location = new System.Drawing.Point(120, 180);
            this.spinUnitPrice.Name = "spinUnitPrice";
            this.spinUnitPrice.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinUnitPrice.Properties.Appearance.Options.UseFont = true;
            this.spinUnitPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, false)});
            this.spinUnitPrice.Properties.DisplayFormat.FormatString = "n4";
            this.spinUnitPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinUnitPrice.Properties.EditFormat.FormatString = "n4";
            this.spinUnitPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinUnitPrice.Properties.Mask.EditMask = "n4";
            this.spinUnitPrice.Size = new System.Drawing.Size(150, 23);
            this.spinUnitPrice.TabIndex = 13;
            // 
            // txtCurrency
            // 
            this.txtCurrency.EnterMoveNextControl = true;
            this.txtCurrency.Location = new System.Drawing.Point(276, 180);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCurrency.Properties.Appearance.Options.UseFont = true;
            this.txtCurrency.Size = new System.Drawing.Size(150, 23);
            this.txtCurrency.TabIndex = 14;
            // 
            // frmVendor
            // 
            this.OptionsPermission.AutoCheckPermission = false;
            this.OptionsPermission.AutoInitPermission = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 252);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.txtBranch);
            this.Controls.Add(this.lblBranch);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lblMedicament);
            this.Controls.Add(this.txtVendor);
            this.Controls.Add(this.spinUnitPrice);
            this.Controls.Add(this.spinReceivedQty);
            this.Controls.Add(this.dateOrderDate);
            this.Controls.Add(this.txtMedicament);
            this.Controls.Add(this.lblVendor);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblReceivedQty);
            this.Name = "frmVendor";
            this.Text = "პროდუქციის შესყიდვის ინფორმაცია";
            this.Controls.SetChildIndex(this.lblReceivedQty, 0);
            this.Controls.SetChildIndex(this.lblOrderDate, 0);
            this.Controls.SetChildIndex(this.lblUnitPrice, 0);
            this.Controls.SetChildIndex(this.lblVendor, 0);
            this.Controls.SetChildIndex(this.txtMedicament, 0);
            this.Controls.SetChildIndex(this.dateOrderDate, 0);
            this.Controls.SetChildIndex(this.spinReceivedQty, 0);
            this.Controls.SetChildIndex(this.spinUnitPrice, 0);
            this.Controls.SetChildIndex(this.txtVendor, 0);
            this.Controls.SetChildIndex(this.lblMedicament, 0);
            this.Controls.SetChildIndex(this.txtOrderID, 0);
            this.Controls.SetChildIndex(this.txtCurrency, 0);
            this.Controls.SetChildIndex(this.lblBranch, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.txtBranch, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lblOrderID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVendor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMedicament.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinReceivedQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinUnitPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrency.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblOrderID;
        private DevExpress.XtraEditors.TextEdit txtOrderID;
        private DevExpress.XtraEditors.DateEdit dateOrderDate;
        private DevExpress.XtraEditors.LabelControl lblOrderDate;
        private DevExpress.XtraEditors.LabelControl lblBranch;
        private DevExpress.XtraEditors.TextEdit txtBranch;
        private DevExpress.XtraEditors.LabelControl lblVendor;
        private DevExpress.XtraEditors.TextEdit txtVendor;
        private DevExpress.XtraEditors.LabelControl lblMedicament;
        private DevExpress.XtraEditors.TextEdit txtMedicament;
        private DevExpress.XtraEditors.LabelControl lblReceivedQty;
        private DevExpress.XtraEditors.SpinEdit spinReceivedQty;
        private DevExpress.XtraEditors.LabelControl lblUnitPrice;
        private DevExpress.XtraEditors.SpinEdit spinUnitPrice;
        private DevExpress.XtraEditors.TextEdit txtCurrency;
    }
}