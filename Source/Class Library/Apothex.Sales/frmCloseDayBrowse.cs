using System;
using System.Data;
using System.Data.SqlClient;
using Apothex.Common;
using Apothex.DataType;
using Apothex.Windows.Forms;
using Zek.Core;
using Apothex.DataManagment.Dictionary;
using Zek.Data;

namespace Apothex.Sales
{
    public partial class frmCloseDayBrowse : frmBrowse
    {
        public frmCloseDayBrowse()
        {
            InitializeComponent();
        }

        #region Fields & Properties
        private int permissionAllBranch;
        private int SelectedBranchID
        {
            get
            {
                return (IsPermitted(permissionAllBranch, DatabaseAction.View) ? ConvertHelper.ToInt32(lookBranch.EditValue) : GlobalVariable.BranchID);
            }
        }
        protected override bool IsAllowedDelete
        {
            get
            {
                var ok = base.IsAllowedDelete;
                if (ok && !IsPermitted(permissionAllBranch, DatabaseAction.Delete))
                {
                    foreach (var rowHandle in OptionsGrid.GridView.GetSelectedRows())
                    {
                        if ((int)OptionsGrid.GridView.GetRowCellValue(rowHandle, colBranchID) != GlobalVariable.BranchID)
                        {
                            ok = false;
                            break;
                        }
                    }
                }

                return ok;
            }
        }
        protected override bool IsAllowedApprove
        {
            get
            {
                var ok = base.IsAllowedApprove;
                if (ok)
                {
                    var isAllowed = IsPermitted(permissionAllBranch, DatabaseAction.Approve);
                    foreach (var rowHandle in OptionsGrid.GridView.GetSelectedRows())
                    {
                        if (!isAllowed && (int)OptionsGrid.GridView.GetRowCellValue(rowHandle, colBranchID) != GlobalVariable.BranchID)
                        {
                            ok = false;
                            break;
                        }
                    }
                }

                return ok;
            }
        }
        #endregion

        #region Bindings
        protected override void BindControls()
        {
            bsBranch.DataSource = DictionaryManager.GetDictionary(ObjectNames.Branch, -1);
            lookBranch.EditValue = GlobalVariable.BranchID.ToString();
        }
        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = SelectSql +
@"
  *
  FROM [Sales].[VW_CloseDay]
  WHERE [Status]" + (IsApprovedChecked ? "=" : "<>") + ((byte)DatabaseStatus.Approved).ToString();

                if (!IsPermitted(permissionAllBranch, DatabaseAction.View))
                {
                    cmd.CommandText += " AND [BranchID] = @BranchID";
                    cmd.Parameters.Add("@BranchID", SqlDbType.Int).Value = SelectedBranchID;
                }

                if (IsFiltered)
                {
                    if (lookBranch.EditValue != null && IsPermitted(permissionAllBranch, DatabaseAction.View))
                    {
                        cmd.CommandText += " AND [BranchID] = @BranchID";
                        cmd.Parameters.Add("@BranchID", SqlDbType.Int).Value = SelectedBranchID;
                    }

                    var filter = string.Empty;

                    filter = FilterHelper.CreateFilter("CloseDate", cboxCloseDate.Text, ConvertHelper.ToDateTime(dateCloseDate1.EditValue), ConvertHelper.ToDateTime(dateCloseDate2.EditValue), RoundingFormat.None, cmd);
                    if (filter.Length > 0)
                    {
                        cmd.CommandText += " AND " + filter;
                    }
                }

                cmd.CommandText += " ORDER BY [CloseDate] DESC, [BranchID]";

                ds.VW_CloseDay.Clear();
                ds.VW_CloseDay.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }
        #endregion

        #region Validations
        private bool IsValidDate()
        {
            if (cboxCloseDate.Text == "[ ]" && dateCloseDate1.EditValue != null && dateCloseDate2.EditValue != null && dateCloseDate1.DateTime > dateCloseDate2.DateTime)
            {
                dxErrorProvider.SetError(dateCloseDate2, "დასრულების თარიღი უნდა აღემატებოდეს დაწყების თარიღს.");
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var ok = true;

            if (!IsValidDate()) ok = false;

            return ok;
        }
        #endregion

        #region Methods
        protected override void Init()
        {
            base.Init();

            permissionAllBranch = GlobalVariable.GetPermission((int)ObjectNames.CloseDayAllBranch);

            lookBranch.Properties.ReadOnly = !IsPermitted(permissionAllBranch, DatabaseAction.View);
        }
        #endregion

        private void cboxCloseDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearError(dateCloseDate1);
            ClearError(dateCloseDate2);
            FilterHelper.ShowFilterFields(cboxCloseDate.Text, dateCloseDate1, dateCloseDate2);
        }

        private void dateCloseDate1_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(dateCloseDate1, string.Empty);
            dxErrorProvider.SetError(dateCloseDate2, string.Empty);
        }

        private void dateCloseDate2_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(dateCloseDate1, string.Empty);
            dxErrorProvider.SetError(dateCloseDate2, string.Empty);
        }
    }
}