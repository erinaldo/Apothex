using System;
using System.Data;
using System.Data.SqlClient;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Apothex.Common;
using Zek.Core;
using Zek.Data;
using Apothex.DataType;

namespace Apothex.Production
{
    public partial class frmProductDistributionBrowse : frmBrowse
    {
        public frmProductDistributionBrowse()
        {
            InitializeComponent();
        }

        private int _permissionAllBranch;
        private int SelectedFromBranchID
        {
            get
            {
                return (IsPermitted(_permissionAllBranch, DatabaseAction.View) ? ConvertHelper.ToInt32(lookFromBranch.EditValue) : GlobalVariable.BranchID);
            }
        }
        private int SelectedToBranchID
        {
            get
            {
                return (IsPermitted(_permissionAllBranch, DatabaseAction.View) ? ConvertHelper.ToInt32(lookToBranch.EditValue) : GlobalVariable.BranchID);
            }
        }
        protected override bool IsAllowedDelete
        {
            get
            {
                var allowed = base.IsAllowedDelete;
                if (allowed && !IsPermitted(_permissionAllBranch, DatabaseAction.Delete))
                {
                    foreach (var rowHandle in OptionsGrid.GridView.GetSelectedRows())
                    {
                        if ((int)OptionsGrid.GridView.GetRowCellValue(rowHandle, colFromBranchID) != GlobalVariable.BranchID)
                        {
                            allowed = false;
                            break;
                        }
                    }
                }

                return allowed;
            }
        }
        protected override bool IsAllowedApprove
        {
            get
            {
                var allowed = base.IsAllowedApprove;
                if (allowed && !IsPermitted(_permissionAllBranch, DatabaseAction.Approve))
                {
                    foreach (var rowHandle in OptionsGrid.GridView.GetSelectedRows())
                    {
                        if ((int)OptionsGrid.GridView.GetRowCellValue(rowHandle, colToBranchID) != GlobalVariable.BranchID)
                        {
                            allowed = false;
                            break;
                        }
                    }
                }

                return allowed;
            }
        }

        #region Bindings
        protected override void BindControls()
        {
            var table = DictionaryManager.GetDictionary(ObjectNames.Branch, -1);
            bsFromBranch.DataSource = table.Copy();
            bsToBranch.DataSource = table;
        }
        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = SelectSql +
@"
*
FROM Production.VW_ProductDistributionHeader
WHERE " + FilterStatusSql;

                if (!IsPermitted(_permissionAllBranch, DatabaseAction.View))
                {
                    cmd.CommandText += " AND (FromBranchID = @FromBranchID OR ToBranchID = @ToBranchID)";
                    cmd.Parameters.Add("@FromBranchID", SqlDbType.Int).Value = SelectedFromBranchID;
                    cmd.Parameters.Add("@ToBranchID", SqlDbType.Int).Value = SelectedToBranchID;
                }

                if (IsFiltered)
                {
                    if (lookFromBranch.EditValue != null && IsPermitted(_permissionAllBranch, DatabaseAction.View))
                    {
                        cmd.CommandText += " AND FromBranchID = @FromBranchID";
                        cmd.Parameters.Add("@FromBranchID", SqlDbType.Int).Value = SelectedFromBranchID;
                    }

                    if (lookToBranch.EditValue != null && IsPermitted(_permissionAllBranch, DatabaseAction.View))
                    {
                        cmd.CommandText += " AND ToBranchID = @ToBranchID";
                        cmd.Parameters.Add("@ToBranchID", SqlDbType.Int).Value = SelectedToBranchID;
                    }

                    if (txtProductDistributionID.Text.Trim().Length > 0)
                    {
                        var id = 0;
                        int.TryParse(txtProductDistributionID.Text.Trim(), out id);
                        cmd.CommandText += " AND ProductDistributionID = @ProductDistributionID";
                        cmd.Parameters.Add("@ProductDistributionID", SqlDbType.Int).Value = id;
                    }

                    var filter = string.Empty;

                    filter = FilterHelper.CreateFilter("StartDate", cboxStartDate.Text, ConvertHelper.ToDateTime(dateStartDate1.EditValue), ConvertHelper.ToDateTime(dateStartDate2.EditValue), RoundingFormat.None, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;


                    filter = FilterHelper.CreateFilter("RevisionNumber", cboxRevisionNumber.Text, ConvertHelper.ToByte(spinRevisionNumber1.Value), ConvertHelper.ToByte(spinRevisionNumber2.Value), SqlDbType.TinyInt, cmd);
                    if (filter.Length > 0) cmd.CommandText += " AND " + filter;
                }

                cmd.CommandText += " ORDER BY StartDate DESC, FromBranchID, ToBranchID";
                ds.VW_ProductDistributionHeader.Clear();
                ds.VW_ProductDistributionHeader.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }
        #endregion

        #region Validations
        public bool IsValidDate()
        {
            if (cboxStartDate.Text == " " && dateStartDate1.EditValue != null && dateStartDate2.EditValue != null && dateStartDate1.DateTime > dateStartDate2.DateTime)
            {
                dxErrorProvider.SetError(dateStartDate2, "დასრულების თარიღი უნდა აღემატებოდეს დაწყების თარიღს.");
                return false;
            }

            return true;
        }
        public bool IsValidRevisionNumber()
        {
            if (cboxRevisionNumber.Text == " " && spinRevisionNumber1.Value > spinRevisionNumber2.Value)
            {
                dxErrorProvider.SetError(spinRevisionNumber2, "საბოლოო მნიშვნელობა უნდა აღემატებოდეს საწყისს.");
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var ok = true;

            if (!IsValidDate()) ok = false;
            if (!IsValidRevisionNumber()) ok = false;

            return ok;
        }
        #endregion

        #region Methods
        protected override void Init()
        {
            base.Init();

            _permissionAllBranch = GlobalVariable.GetPermission((int)ObjectNames.ProductDistributionHeaderAllBranch);

            lookFromBranch.Properties.ReadOnly =
            lookToBranch.Properties.ReadOnly = !IsPermitted(_permissionAllBranch, DatabaseAction.View);
        }
        #endregion

        private void cboxStartDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(dateStartDate1, string.Empty);
            dxErrorProvider.SetError(dateStartDate2, string.Empty);
            FilterHelper.ShowFilterFields(cboxStartDate.Text, dateStartDate1, dateStartDate2);
        }

        private void dateStartDate1_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(dateStartDate1, string.Empty);
            dxErrorProvider.SetError(dateStartDate2, string.Empty);
        }

        private void dateStartDate2_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(dateStartDate1, string.Empty);
            dxErrorProvider.SetError(dateStartDate2, string.Empty);
        }

        private void cboxRevisionNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(spinRevisionNumber1, string.Empty);
            dxErrorProvider.SetError(spinRevisionNumber2, string.Empty);
            FilterHelper.ShowFilterFields(cboxRevisionNumber.Text, spinRevisionNumber1, spinRevisionNumber2);
        }

        private void spinRevisionNumber1_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(spinRevisionNumber1, string.Empty);
            dxErrorProvider.SetError(spinRevisionNumber2, string.Empty);
        }

        private void spinRevisionNumber2_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(spinRevisionNumber1, string.Empty);
            dxErrorProvider.SetError(spinRevisionNumber2, string.Empty);
        }
    }
}