using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Apothex.Common;
using Apothex.Configuration;
using Apothex.DataManagment.Dictionary;
using DevExpress.XtraGrid.Views.Grid;
using Zek.Core;
using Zek.Data;
using Zek.Windows.Forms;
using Apothex.Windows.Forms;
using Apothex.DataType;

namespace Apothex.Sales
{
    public partial class frmSalesOrderDetailDefectureBrowse : frmBrowse
    {
        public frmSalesOrderDetailDefectureBrowse()
        {
            InitializeComponent();
            bbBranch.IsOnline = !ConfigurationManagerEx.OfflineMode;
        }

        protected override void InitGrid(GridView view)
        {
            base.InitGrid(view);
            view.OptionsBehavior.Editable = true;
        }
        protected override void BindControls()
        {
            bbBranch.RecordValue = GlobalVariable.BranchID;
            dateOrderDate1.EditValue = BaseGlobalVariable.ServerDateTime.Date;
            dateOrderDate2.EditValue = BaseGlobalVariable.ServerDateTime.Date.AddDays(1d);
        }

        public bool IsValidDate1()
        {
            if (dateOrderDate1.EditValue == null)
            {
                SetError(dateOrderDate1, "!");
                return false;
            }

            return true;
        }
        public bool IsValidDate2()
        {
            if (dateOrderDate2.EditValue == null)
            {
                SetError(dateOrderDate2, "!");
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var flag = true;
            if (!IsValidDate1()) flag = false;
            if (!IsValidDate2()) flag = false;
            return flag;
        }


        protected override void ChooseRecord(CancelEventArgs e)
        {
            base.ChooseRecord(e);

            if (e.Cancel || OptionsListForm.CloseAfterChoose) return;

            view.SetRowCellValue(OptionsGrid.SelectedRowHandle, colIsChoosed, true);
        }

        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = SelectSql +
@"
*
FROM
Sales.FN_SalesOrderDetailDefacture(@branchID, @date1, @date2, @vendorID)";

                if (!ConfigurationManagerEx.IsOnline)
                {
                    cmd.CommandText = @"
SELECT  s.BranchID,
        b.Name Branch,
        s.MedicamentName AS Nomenclature,
        s.CountryName AS Country,
        s.BrandName AS Brand,
        s.ValidDate,
        t.Quantity,
        s.SaleQty
FROM    (SELECT soh.BranchID,
                pl.MedicamentName,
                pl.CountryName,
                pl.BrandName,
                pl.ValidDate,
                SUM(sod.SaleQty) AS SaleQty
         FROM   dbo.T_SalesOrderDetail sod WITH (NOLOCK)
         INNER JOIN dbo.T_SalesOrderHeader soh WITH (NOLOCK) ON sod.SalesOrderID = soh.SalesOrderID
         INNER JOIN dbo.T_ProductLocation pl WITH (NOLOCK) ON sod.ProductLocationID = pl.ProductLocationID
         WHERE  (@branchID IS NULL
                 OR soh.BranchID = @branchID)
                AND (soh.OrderDate BETWEEN @date1 AND @date2)
         GROUP BY soh.BranchID,
                pl.MedicamentName,
                pl.CountryName,
                pl.BrandName,
                pl.ValidDate
        ) AS s
LEFT OUTER JOIN (SELECT plx.BranchID,
                        plx.MedicamentName,
                        plx.CountryName,
                        plx.BrandName,
                        plx.ValidDate,
                        SUM(plx.Quantity) AS Quantity
                 FROM   dbo.T_ProductLocation plx WITH (NOLOCK)
                 WHERE  plx.ValidDate IS NULL
                        OR plx.ValidDate > GETDATE()
                 GROUP BY plx.BranchID,
                        plx.MedicamentName,
                        plx.CountryName,
                        plx.BrandName,
                        plx.ValidDate
                ) AS t ON s.BranchID = t.BranchID
                          AND s.MedicamentName = t.MedicamentName
                          AND s.CountryName = t.CountryName
                          AND s.BrandName = t.BrandName
                          AND s.ValidDate = t.ValidDate
INNER JOIN T_Branch AS b ON s.BranchID = b.BranchID";
                }

                var filter = string.Empty;

                cmd.Parameters.Add("@branchID", SqlDbType.Int).Value = ConvertHelper.ToDBValue(bbBranch.RecordValue);
                if (ConfigurationManagerEx.IsOnline)
                    cmd.Parameters.Add("@vendorID", SqlDbType.Int).Value = ConvertHelper.ToDBValue(bbVendor.RecordValue);

                cmd.Parameters.Add("@date1", SqlDbType.DateTime).Value = ConvertHelper.ToDBValue(dateOrderDate1.EditValue);
                cmd.Parameters.Add("@date2", SqlDbType.DateTime).Value = ConvertHelper.ToDBValue(dateOrderDate2.EditValue);

                ds.FN_SalesOrderDetailDefacture.Clear();
                ds.FN_SalesOrderDetailDefacture.Merge(DictionaryManager.GetDataTable(cmd, ConfigurationManagerEx.IsOnline));
            }
        }

        private void dateOrderDate1_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(dateOrderDate1);
        }

        private void dateOrderDate2_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(dateOrderDate2);
        }

        private void btnGenerateRequest_Click(object sender, EventArgs e)
        {
            if (IsPermitted(ObjectNames.Request, DatabaseAction.Add))
            {
                var frm = FormHelper.CreateInstance((int)ObjectNames.Request, FormStyle.Edit, MdiParent);

                var table = (DS_SalesOrderDetailDefacture.FN_SalesOrderDetailDefactureDataTable)ds.FN_SalesOrderDetailDefacture.Clone();
                foreach (var row in ds.FN_SalesOrderDetailDefacture)
                {
                    if (row.CustomQty <= 0m) continue;
                    table.Rows.Add(row.ItemArray);
                }
                ((IRequestForm)frm).AddRows(table);

                frm.Show();
                frm.BringToFront();
            }
        }
    }
}