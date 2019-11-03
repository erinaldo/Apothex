using System;
using System.Data;
using System.Data.SqlClient;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Zek.Core;

namespace Apothex.Request
{
    public partial class frmRequestBrowse : frmBrowse
    {
        public frmRequestBrowse()
        {
            InitializeComponent();
        }

        #region Bindings
        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = SelectSql +
@"
*
FROM Production.VW_RequestHeader
WHERE " + FilterStatusSql;


                if (IsFiltered)
                {
                    var filter = string.Empty;

                    filter = FilterHelper.CreateFilter("RequestID", cboxID.Text, txtID.EditValue, SqlDbType.Int, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("BranchID", cboxBranch.Text, bbBranch.RecordValue, SqlDbType.Int, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("RequestDate", cboxOrderDate.Text, ConvertHelper.ToDateTime(dateOrderDate1.EditValue), ConvertHelper.ToDateTime(dateOrderDate2.EditValue), RoundingFormat.None, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;
                }

                cmd.CommandText += " ORDER BY RequestDate DESC, RequestID DESC";

                ds.VW_RequestHeader.Clear();
                ds.VW_RequestHeader.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }
        
        #endregion

        private void cboxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxID.Text, txtID);
        }

        private void cboxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxBranch.Text, bbBranch);
        }

        private void cboxOrderDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxOrderDate.Text, dateOrderDate1, dateOrderDate2);
        }
    }
}