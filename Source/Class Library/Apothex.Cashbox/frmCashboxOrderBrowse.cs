using System;
using System.Data.SqlClient;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Zek.Core;
using Zek.Data;
using Zek.Extensions;
using Zek.Windows.Forms;

namespace Apothex.Cashbox
{
    public partial class frmCashboxOrderBrowse : frmBrowse
    {
        public frmCashboxOrderBrowse()
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
                    var where = new SqlWhereStatement(false);
                    where.AddWhere("OrderDate", cboxDate.Text, true, ConvertHelper.ToDateTime(dateDate1.EditValue), ConvertHelper.ToDateTime(dateDate2.EditValue), DateTimePrecision.Days);
                    where.AddWhere("ActNumber", cboxActNumber.Text, true, txtActNumber.Text.Trim());
                    where.AddWhere("IssuedPerson", cboxIssuedPerson.Text, true, txtIssuedPerson.Text.Trim());

                    cmd.CommandText += where;
                }

                cmd.CommandText += " ORDER BY OrderDate DESC, ID DESC";
                ds.VW_CashboxOrder.Clear();
                ds.VW_CashboxOrder.Merge(DictionaryManager.GetDataTable(cmd));
            }
            
        }

        private void cboxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxDate.Text, dateDate1, dateDate2);
        }

        private void cboxActNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxActNumber.Text, txtActNumber);
        }

        private void cboxIssuedPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxIssuedPerson.Text, txtIssuedPerson);
        }
    }
}