using System;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Card;
using Zek.Core;

namespace Apothex.Card
{
    public partial class frmCardHandleBrowse : frmBrowse
    {
        public frmCardHandleBrowse()
        {
            InitializeComponent();
        }

        protected override void BindControls()
        {
            dateHandle1.EditValue = BaseGlobalVariable.ServerDateTime.Date.AddDays(-1d);
            dateHandle2.EditValue = BaseGlobalVariable.ServerDateTime.Date;
        }
        protected override void BindGrid()
        {
            ds.VW_CardHandle.Clear();
            ds.VW_CardHandle.Merge(CardManager.GetVWCardHandle(null, null, ConvertHelper.ToNullableDateTime(dateHandle1.EditValue), ConvertHelper.ToNullableDateTime(dateHandle2.EditValue)));

            //using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
            //{
            //    cmd.CommandText = SelectAllFromTableWhereStatus;
            //    if (IsFiltered)
            //    {
            //        string filter = FilterHelper.CreateFilter("CardNumber", cboxNumber.Text, txtNumber.Text, SqlDbType.NVarChar, cmd);
            //        if (filter.Length > 0) cmd.CommandText += " AND " + filter;

            //        filter = FilterHelper.CreateFilter("CardTypeID", cboxCardType.Text, lookCardType.EditValue, SqlDbType.Int, cmd);
            //        if (filter.Length > 0) cmd.CommandText += " AND " + filter;

            //        filter = FilterHelper.CreateFilter("PersonID", cboxPersonID.Text, bbPersonID.RecordValue, SqlDbType.NVarChar, cmd);
            //        if (filter.Length > 0) cmd.CommandText += " AND " + filter;

            //        filter = FilterHelper.CreateFilter("Person", cboxPersonName.Text, txtPersonName.Text.Trim(), SqlDbType.NVarChar, cmd);
            //        if (filter.Length > 0) cmd.CommandText += " AND " + filter;

            //        filter = FilterHelper.CreateFilter("ParentCardNumber", cboxParentCardNumber.Text, txtParentCardNumber.Text, SqlDbType.NVarChar, cmd);
            //        if (filter.Length > 0) cmd.CommandText += " AND " + filter;

            //    }
            //    cmd.CommandText += " ORDER BY ModifiedDate DESC, ID DESC";
            //    ds.VW_Card.Clear();
            //    ds.VW_Card.Merge(DictionaryManager.GetDataTable(cmd));
            //}
        }

        private void cboxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxBranch.Text, bbBranch);
        }
    }
}