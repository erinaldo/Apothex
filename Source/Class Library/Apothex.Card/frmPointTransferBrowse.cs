using System;
using System.Data;
using System.Data.SqlClient;
using Apothex.DataManagment.Dictionary;
using Apothex.Windows.Forms;
using Zek.Core;
using Zek.Windows.Forms;

namespace Apothex.Card
{
    public partial class frmPointTransferBrowse : frmBrowse
    {
        public frmPointTransferBrowse()
        {
            InitializeComponent();
        }


        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = SelectAllFromTableWhereStatus;
                if (IsFiltered)
                {
                    string filter = FilterHelper.CreateFilter("Date", cboxDate.Text, ConvertHelper.ToDateTime(dateDate1.EditValue), ConvertHelper.ToDateTime(dateDate2.EditValue),  RoundingFormat.g, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("FromCardNumber", cboxFromCardNumber.Text, txtFromCardNumber.Text.Trim(), SqlDbType.NVarChar, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("ToCardNumber", cboxToCardNumber.Text, txtToCardNumber.Text.Trim(), SqlDbType.NVarChar, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;


                    filter = FilterHelper.CreateFilter("FromPerson", cboxFromCardHolder.Text, txtFromCardHolder.Text.Trim(), SqlDbType.NVarChar, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("ToPerson", cboxToCardHolder.Text, txtToCardHolder.Text.Trim(), SqlDbType.NVarChar, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;
                }
                cmd.CommandText += " ORDER BY Date DESC, ID DESC";
                ds.VW_PointTransferHeader.Clear();
                ds.VW_PointTransferHeader.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }

        private void cboxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxDate.Text, dateDate1, dateDate2);
        }

        private void cboxFromCardNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxFromCardNumber.Text, txtFromCardNumber);
        }

        private void cboxToCardNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxToCardNumber.Text, txtToCardNumber);
        }

        private void cboxFromCardHolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxFromCardHolder.Text, txtFromCardHolder);
        }

        private void cboxToCardHolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxToCardHolder.Text, txtToCardHolder);
        }
    }
}
