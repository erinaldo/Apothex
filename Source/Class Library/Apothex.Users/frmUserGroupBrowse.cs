using System.Data.SqlClient;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using Zek.Data;

namespace Apothex.Users
{
    public partial class frmUserGroupBrowse : frmBrowse
    {
        public frmUserGroupBrowse()
        {
            InitializeComponent();
        }

        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = SelectSql +
@"
  *
  FROM [VW_UserGroup]  WITH (NOLOCK)
  WHERE [Status]" + (IsApprovedChecked ? "<>" : "=") + ((byte)DatabaseStatus.Pending).ToString();

                if (IsFiltered)
                {

                }

                cmd.CommandText += " ORDER BY [ModifiedDate] DESC";

                ds.VW_UserGroup.Clear();
                ds.VW_UserGroup.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }
    }
}