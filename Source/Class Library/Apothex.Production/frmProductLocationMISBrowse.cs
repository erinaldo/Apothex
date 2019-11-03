using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Apothex.DataType;
using Apothex.Common;
using Zek.Windows.Forms;

namespace Apothex.Production
{
    public partial class frmProductLocationMISBrowse : frmBrowse
    {
        public frmProductLocationMISBrowse()
        {
            InitializeComponent();
        }

        protected override void BindControls()
        {
            view.OptionsBehavior.Editable = true;
            bbBranch.RecordValue = GlobalVariable.BranchID;
        }
        protected override void BindGrid()
        {
            view.OptionsBehavior.Editable = true;
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = SelectSql +
@"
*
FROM Production.VW_ProductLocationMIS WITH (NOLOCK)
";

                if (IsFiltered)
                {
                    var where = " WHERE ";
                    string filter = FilterHelper.CreateFilter("BranchID", cboxBranch.Text, bbBranch.RecordValue, SqlDbType.Int, cmd);
                    if (filter.Length > 0)
                    {
                        cmd.CommandText += where + filter;
                        where = " AND ";
                    }
                }

                ds.VW_ProductLocationMIS.Clear();
                ds.VW_ProductLocationMIS.Merge(DictionaryManager.GetDataTable(cmd));
                foreach (var row in ds.VW_ProductLocationMIS)
                {
                    if (row.Discount != 0m) row.NewDiscount = row.Discount;
                    row.MedicamentName = GeoConvertHelper.Convert(row.MedicamentName, "_utf8_", "AcadNusx", "");
                    row.CountryName = GeoConvertHelper.Convert(row.CountryName, "_utf8_", "AcadNusx", "");
                    row.BrandName = GeoConvertHelper.Convert(row.BrandName, "_utf8_", "AcadNusx", "");
                }
            }
        }

        private void cboxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxBranch.Text, bbBranch);
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {

            try
            {
                
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                view.BeginDataUpdate();
                foreach (var rowHandle in view.GetSelectedRows())
                {
                    var tmprow = view.GetDataRow(rowHandle);
                    if (tmprow == null) continue;

                    var row = (DS_ProductLocationMIS.VW_ProductLocationMISRow)tmprow;

                    if (row.Discount != 0m) continue;
                    view.SetRowCellValue(rowHandle, colNewDiscount, spinDiscount.Value);
                }
            }
            catch (Exception ex)
            {
                ExceptionHelper.Show(ex);
            }
            finally
            {
                view.EndDataUpdate();
                Cursor = Cursors.Default;
            }
        }

        private void view_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (view.FocusedColumn == colNewDiscount)
            {
                var tmprow = view.GetFocusedDataRow();
                if (tmprow == null) return;
                var row = (DS_ProductLocationMIS.VW_ProductLocationMISRow)tmprow;
                if (row.Discount != 0m)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }
    }
}
