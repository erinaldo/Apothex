namespace Apothex.Sales
{
    partial class frmSalesOrderDetailList
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
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.bsPaymentMethod = new System.Windows.Forms.BindingSource(this.components);
            this.lblPaymentMethod = new DevExpress.XtraEditors.LabelControl();
            this.lookPaymentMethod = new DevExpress.XtraEditors.LookUpEdit();
            this.ds = new Apothex.DataType.DS_SalesOrderDetailList();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPaymentMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookPaymentMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Appearance.Options.UseFont = true;
            this.btnOk.Image = null;
            this.btnOk.Location = new System.Drawing.Point(44, 82);
            this.btnOk.Text = "OK";
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Image = null;
            this.btnCancel.Location = new System.Drawing.Point(200, 82);
            this.btnCancel.Text = "Cancel";
            // 
            // lblDate
            // 
            this.lblDate.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.Appearance.Options.UseFont = true;
            this.lblDate.Location = new System.Drawing.Point(12, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(73, 17);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "პერიოდი:";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.EnterMoveNextControl = true;
            this.dateEdit1.Location = new System.Drawing.Point(92, 15);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(125, 23);
            this.dateEdit1.TabIndex = 1;
            this.dateEdit1.EditValueChanged += new System.EventHandler(this.dateEdit1_EditValueChanged);
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.EnterMoveNextControl = true;
            this.dateEdit2.Location = new System.Drawing.Point(223, 15);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEdit2.Properties.Appearance.Options.UseFont = true;
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit2.Size = new System.Drawing.Size(125, 23);
            this.dateEdit2.TabIndex = 2;
            this.dateEdit2.EditValueChanged += new System.EventHandler(this.dateEdit2_EditValueChanged);
            // 
            // bsPaymentMethod
            // 
            this.bsPaymentMethod.Sort = "Caption";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPaymentMethod.Appearance.Options.UseFont = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(11, 47);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(71, 17);
            this.lblPaymentMethod.TabIndex = 3;
            this.lblPaymentMethod.Text = "გად. მეთ:";
            // 
            // lookPaymentMethod
            // 
            this.lookPaymentMethod.EnterMoveNextControl = true;
            this.lookPaymentMethod.Location = new System.Drawing.Point(92, 44);
            this.lookPaymentMethod.Name = "lookPaymentMethod";
            this.lookPaymentMethod.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookPaymentMethod.Properties.Appearance.Font = new System.Drawing.Font("BPG Glaho Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookPaymentMethod.Properties.Appearance.Options.UseFont = true;
            this.lookPaymentMethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookPaymentMethod.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.lookPaymentMethod.Properties.DataSource = this.bsPaymentMethod;
            this.lookPaymentMethod.Properties.DisplayMember = "Caption";
            this.lookPaymentMethod.Properties.NullText = "";
            this.lookPaymentMethod.Properties.ShowHeader = false;
            this.lookPaymentMethod.Properties.SortColumnIndex = 2;
            this.lookPaymentMethod.Properties.ValueMember = "ID";
            this.lookPaymentMethod.Size = new System.Drawing.Size(256, 23);
            this.lookPaymentMethod.TabIndex = 4;
            // 
            // ds
            // 
            this.ds.DataSetName = "DS_SalesOrderDetailList";
            this.ds.Locale = new System.Globalization.CultureInfo("");
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmSalesOrderDetailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 131);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.lookPaymentMethod);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateEdit2);
            this.Name = "frmSalesOrderDetailList";
            this.ObjectName = Apothex.DataType.ObjectNames.SalesOrderHeader;
            this.Text = "უკან დაბრუნების რეესტრი";
            this.Controls.SetChildIndex(this.dateEdit2, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.lblDate, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.dateEdit1, 0);
            this.Controls.SetChildIndex(this.lookPaymentMethod, 0);
            this.Controls.SetChildIndex(this.lblPaymentMethod, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPaymentMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookPaymentMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private System.Windows.Forms.BindingSource bsPaymentMethod;
        private DevExpress.XtraEditors.LabelControl lblPaymentMethod;
        private DevExpress.XtraEditors.LookUpEdit lookPaymentMethod;
        private DataType.DS_SalesOrderDetailList ds;
    }
}