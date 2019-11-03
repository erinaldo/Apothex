using System;
using System.Data;
using System.Data.SqlClient;
using Apothex.DataType;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Zek.Core;

namespace Apothex.Dictionary
{
    public partial class frmCurrencyRateBrowse : frmBrowse
    {
        public frmCurrencyRateBrowse()
        {
            InitializeComponent();
            
            dateStartDate.EditValue = BaseGlobalVariable.ServerDateTime.Date;
            cboxDate.EditValue = ">";
        }

        protected override void BindControls()
        {
            bsCurrency.DataSource = DictionaryManager.GetDictionary(ObjectNames.Currency, -1);
        }

        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = SelectSql +
@"
  *
  FROM Dictionary.VW_CurrencyRate WITH (NOLOCK)
  WHERE " + FilterStatusSql;

                if (IsFiltered)
                {
                    string filter = FilterHelper.CreateFilter("StartDate", cboxDate.Text, dateStartDate.DateTime, dateEndDate.DateTime, RoundingFormat.None, cmd);
                    if (filter.Length > 0)
                    {
                        cmd.CommandText += " AND " + filter;
                    }

                    if (lookCurrency.EditValue != null)
                    {
                        cmd.CommandText += " AND CurrencyCode = @CurrencyCode";
                        cmd.Parameters.Add("@CurrencyCode", SqlDbType.NChar).Value = lookCurrency.EditValue;
                    }
                }

                cmd.CommandText += " ORDER BY [StartDate] DESC, [CurrencyCode] ASC";

                ds.VW_CurrencyRate.Clear();
                ds.VW_CurrencyRate.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }

        private bool IsValidFilterControls()
        {
            if (dateStartDate.EditValue != null && dateEndDate.EditValue != null && dateStartDate.DateTime > dateEndDate.DateTime)
            {
                dxErrorProvider.SetError(dateEndDate, "კურსის დასრულების თარიღი უნდა აღემატებოდეს კურსის დაწყების თარიღს.");
                return false;
            }

            return true;
        }

        protected override void ApproveRecord(int rowHandle)
        {
            if ((DateTime)OptionsGrid.GridView.GetRowCellValue(rowHandle, colStartDate) != BaseGlobalVariable.ServerDateTime.Date)
                throw new Exception("ვალუტის კურსის ცვლილების თარიღი არ უდრის სერვერის თარიღს.");

            base.ApproveRecord(rowHandle);
        }

        private void cboxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxDate.Text, dateStartDate, dateEndDate);
        }

        private void dateStartDate_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(dateEndDate, string.Empty);
        }

        private void dateEndDate_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(dateEndDate, string.Empty);
        }
    }
}