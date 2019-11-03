using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Apothex.DataManagment.ProductLocation;

namespace Apothex.Sales
{
    public partial class frmBarCode : XtraForm
    {
        public frmBarCode(int branchID)
        {
            InitializeComponent();
            _branchID = branchID;
        }

        private int _branchID;
        public int BranchID
        {
            get { return _branchID; }
            set { _branchID = value; }
        }
        public int ProductID
        {
            get
            {
                int value;
                int.TryParse(BarCodeWithoutUPC, out value);
                return value;
            }
        }
        public string BarCodeWithoutUPC
        {
            get { return (BarCode.ToUpper().StartsWith("UPC") ? BarCode.Substring("UPC".Length) : string.Empty); }
        }
        public string BarCode
        {
            get { return txtBarCode.Text.Trim(); }
            set { txtBarCode.Text = value; }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                ds_ProductLocation.Clear();
                ds_ProductLocation.VW_ProductLocation.Merge(ProductLocationManager.GetVWByBarCode(BranchID, ProductID, BarCode));
                if (ds_ProductLocation.VW_ProductLocation.Count == 0)
                {
                    txtBarCode.Focus();
                    txtBarCode.SelectAll();
                    dxErrorProvider.SetError(txtBarCode, "პროდუქტი ვერ მოიძებნა.");
                }
                else
                {
                    var row = ds_ProductLocation.VW_ProductLocation.NewVW_ProductLocationRow();
                    row.ItemArray = ds_ProductLocation.VW_ProductLocation[0].ItemArray;
                    ds_ProductLocation.VW_ProductLocation.AddVW_ProductLocationRow(row);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, "შეცდომა შტრიხ-კოდით მოძებნისას.\n" + ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void txtBarCode_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtBarCode, string.Empty);
        }
    }
}