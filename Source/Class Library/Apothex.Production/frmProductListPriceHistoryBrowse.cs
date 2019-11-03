using System;
using System.Data;
using Apothex.DataType;
using Apothex.Windows.Forms;
using System.Data.SqlClient;
using Apothex.DataManagment.Dictionary;
using Zek.Core;
using Apothex.Common;

namespace Apothex.Production
{
    public partial class frmProductListPriceHistoryBrowse : frmBrowse
    {
        public frmProductListPriceHistoryBrowse()
        {
            InitializeComponent();
        }

        public string CurrencyCode
        {
            get { return ConvertHelper.ToString(lookCurrency.EditValue); }
            set { lookCurrency.EditValue = value; }
        }

        protected override void BindControls()
        {
            bsCurrency.DataSource = DictionaryManager.GetDictionary(ObjectNames.CurrencyWithLastRate, -1);
            CurrencyCode = GlobalVariable.MyCompanyDefaultTradingCurrencyCode;
        }
        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = SelectSql + @"
*
FROM dbo.FN_GetProductListPriceHistory(@CurrencyCode)
";
                cmd.Parameters.Add("@CurrencyCode", SqlDbType.NChar).Value = CurrencyCode;

                if (IsFiltered)
                {
                    var where = " WHERE ";

                    string filter = FilterHelper.CreateFilter("StartDate", cboxStartDate.Text, ConvertHelper.ToDateTime(dateStartDate1.EditValue), ConvertHelper.ToDateTime(dateStartDate2.EditValue), RoundingFormat.None, cmd);
                    if (filter.Length > 0)
                    {
                        cmd.CommandText += where + filter;
                        where = " AND ";
                    }

                    filter = FilterHelper.CreateFilter("VendorID", cboxVendorID.Text, bbVendorID.RecordValue, SqlDbType.NVarChar, cmd);
                    if (filter.Length > 0)
                    {
                        cmd.CommandText += where + filter;
                        where = " AND ";
                    }

                    filter = FilterHelper.CreateFilter("VendorName", cboxVendorName.Text, txtVendorName.Text.Trim(), SqlDbType.NVarChar, cmd);
                    if (filter.Length > 0)
                    {
                        cmd.CommandText += where + filter;
                        where = " AND ";
                    }
                }

                cmd.CommandText += "ORDER BY StartDate DESC, EndDate DESC";


                ds.FN_GetProductListPriceHistory.Clear();
                ds.FN_GetProductListPriceHistory.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }

        private void cboxStartDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxStartDate.Text, dateStartDate1, dateStartDate2);
        }

        private void cboxVendorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxVendorID.Text, bbVendorID);
        }

        private void cboxVendorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxVendorName.Text, txtVendorName);
        }
    }
}
