using System.Collections.Generic;
using System.Data;
using Apothex.Windows.Forms;


namespace Apothex.Sales
{
    public partial class frmSyncColumns : frmEditDialog
    {
        public frmSyncColumns()
        {
            InitializeComponent();

            ds_Column.T_Columns.AddT_ColumnsRow("A", "");
            ds_Column.T_Columns.AddT_ColumnsRow("B", "");
        }


        public Dictionary<string, string> Columns
        {
            get
            {
                var dic = new Dictionary<string, string>();
                foreach (var row in ds_Column.T_Columns)
                {
                    if (row.Target.Length == 0) continue;

                    dic.Add(row.Source, row.Target);
                }
                return dic;
            }
        }
        public DataColumnCollection Source
        {
            set
            {
                ds_Column.T_Columns.Clear();
                foreach (DataColumn item in value)
                {
                    ds_Column.T_Columns.AddT_ColumnsRow(item.ColumnName, null);
                }
            }
        }
        public DataColumnCollection Target
        {
            set
            {
                riTarget.Items.Clear();
                riTarget.Items.Add("");
                foreach (DataColumn item in value)
                {
                    riTarget.Items.Add(item.ColumnName);
                }
            }
        }

        protected override bool SaveData()
        {
            view.CloseEditor();
            bsColumn.EndEdit();

            return true;
        }

    }
}
