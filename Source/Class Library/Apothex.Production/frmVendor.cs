using System;
using Apothex.Windows.Forms;
using Zek.Core;
using Zek.Windows.Forms.DevEx;
using Apothex.DataManagment.ProductLocation;

namespace Apothex.Production
{
    public partial class frmVendor : frmEditDialog
    {
        public frmVendor()
        {
            InitializeComponent();
        }

        public int ProductLocationID
        {
            get { return ConvertHelper.ToInt32(PrimaryKey); }
            set { PrimaryKey = value; }
        }

        protected override void BindData()
        {
            var table = ProductLocationManager.GetProductLocationPurchaseOrderHeader(null, ProductLocationID);
            if (table.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.", "RecordID");
            txtOrderID.EditValue = table[0][table.PurchaseOrderIDColumn];
            dateOrderDate.EditValue = table[0][table.OrderDateColumn];
            txtBranch.EditValue = table[0][table.BranchNameColumn];
            txtVendor.EditValue = table[0][table.VendorNameColumn];
            txtMedicament.EditValue = table[0][table.MedicamentNameColumn];
            spinReceivedQty.EditValue = table[0][table.ReceivedQtyColumn];
            spinUnitPrice.EditValue = table[0][table.UnitPriceColumn];
            txtCurrency.EditValue = table[0][table.CurrencyCodeColumn];
        }

        protected override void Init()
        {
            ReadOnly = true;
            XtraControlHelper.SetReadOnly(this, true);
            btnCancel.Enabled = true;
        }

        protected override bool SaveData()
        {
            return true;
        }
    }
}