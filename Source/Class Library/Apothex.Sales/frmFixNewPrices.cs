using System;
using System.ComponentModel;
using System.Windows.Forms;
using Apothex.Production;
using Apothex.Windows.Forms;
using Zek.Windows.Forms;
using Apothex.DataManagment.Sales;
using Zek.Data;

namespace Apothex.Sales
{
    public partial class frmFixNewPrices : frmEditBrowse
    {
        public frmFixNewPrices()
        {
            InitializeComponent();
        }

        private void btnChooseSalesOrder_Click(object sender, EventArgs e)
        {
            bool isContainsForm = FormHelper.ContainsForm(FormHelper.GetFormID(typeof(frmProductLocationBrowse), Handle));
            IForm frm = FormHelper.CreateInstance(typeof(frmSalesOrderBrowse), MdiParent, Handle);
            if (!isContainsForm)
            {
                var frmSales = (frmSalesOrderBrowse)frm;
                frmSales.OptionsListForm.BrowseFormStyle = BrowseFormStyle.Browse;
                frmSales.OnChooseRecord += new CancelEventHandler(OnChooseSales);
            }

            frm.Show();
            frm.BringToFront();
        }

        public void OnChooseSales(object sender, CancelEventArgs e)
        {
            var frm = (sender as frmBrowse);
            if (frm == null) return;

            if (frm.OptionsGrid.SelectedRecordID == null)
                throw new NullReferenceException("არჩეული ჩანაწერის იდენთიფიკატორი ცარიელია. (frm.SelectedRecordID = null)");

            ds_Sales.SP_GetSalesOrderDetail.Merge(SalesManager.GetSalesOrderDetail((int)frm.OptionsGrid.SelectedRecordID, true));
        }

        private void btnOpenExcel_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Importable Files (*.xlsx;*.xls)|*.xlsx;*.xls|All Files (*.*)|*.*";
            if (dlg.ShowDialog(this) != DialogResult.OK) return;

            var excelTable = ExcelHelper.GetDataTable(dlg.FileName);
            
            new frmSyncColumns()
            {
                Target = excelTable.Columns
            }.ShowDialog(this);
            
            //gridExcel.DataSource = excelTable;
        }
    }
}