using System;
using System.Data;
using System.Data.SqlClient;
using Apothex.DataType;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Zek.Core;

namespace Apothex.Users
{
    public partial class frmUserBrowse : frmBrowse
    {
        public frmUserBrowse()
        {
            InitializeComponent();
        }


        protected override void BindControls()
        {
            bsBranch.DataSource = DictionaryManager.GetDictionary(ObjectNames.Branch);
        }
        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = SelectAllFromTableWhereStatus;

                if (IsFiltered)
                {
                    if (lookBranch.EditValue != null)
                    {
                        cmd.CommandText += " AND [BranchID] = @BranchID";
                        cmd.Parameters.Add("@BranchID", SqlDbType.Int).Value = ConvertHelper.ToInt32(lookBranch.EditValue);
                    }

                    
                    var sql = string.Empty;

                    sql = FilterHelper.CreateFilter("Username", cboxUserName.Text, txtUserName.Text.Trim(), SqlDbType.NVarChar, cmd);
                    if (sql.Length > 0)
                        cmd.CommandText += " AND " + sql;

                }

                cmd.CommandText += " ORDER BY [ModifiedDate] DESC";

                ds.VW_Users.Clear();
                ds.VW_Users.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }

        private void cboxUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHelper.ShowFilterFields(cboxUserName.Text, txtUserName);
        }
    }
}