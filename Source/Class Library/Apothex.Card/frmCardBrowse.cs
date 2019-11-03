using System;
using System.Data;
using System.Data.SqlClient;
using Apothex.DataType;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;

namespace Apothex.Card
{
    public partial class frmCardBrowse : frmBrowse
    {
        public frmCardBrowse()
        {
            InitializeComponent();
        }

        protected override void BindControls()
        {
            bsCardType.DataSource = DictionaryManager.GetDictionaryInt(ObjectNames.CardType);
            lookBranch.Properties.DataSource = DictionaryManager.GetDictionaryInt(ObjectNames.Branch, -1);
        }
        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = SelectAllFromTableWhereStatus;
                if (IsFiltered)
                {
                    string filter = FilterHelper.CreateFilter("BranchID", "=", lookBranch.EditValue, SqlDbType.Int, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("CardNumber", cboxNumber.Text, txtNumber.Text, SqlDbType.NVarChar, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("CardTypeID", cboxCardType.Text, lookCardType.EditValue, SqlDbType.Int, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("PersonID", cboxPersonID.Text, bbPersonID.RecordValue, SqlDbType.NVarChar, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("Person", cboxPersonName.Text, txtPersonName.Text.Trim(), SqlDbType.NVarChar, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                    filter = FilterHelper.CreateFilter("ParentCardNumber", cboxParentCardNumber.Text, txtParentCardNumber.Text, SqlDbType.NVarChar, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;

                }
                cmd.CommandText += " ORDER BY ModifiedDate DESC, ID DESC";
                ds.VW_Card.Clear();
                ds.VW_Card.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }

        private void cboxNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxNumber.Text, txtNumber);
        }

        private void cboxParentCardNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxParentCardNumber.Text, txtParentCardNumber);
        }

        private void cboxCardType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxCardType.Text, lookCardType);
        }
    }
}
