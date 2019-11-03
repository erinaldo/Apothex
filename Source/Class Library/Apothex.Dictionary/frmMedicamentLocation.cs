using System;
using System.Data;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;
using System.Data.SqlClient;

namespace Apothex.Dictionary
{
    public partial class frmMedicamentLocation : frmEditDialog
    {
        public frmMedicamentLocation()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            OptionsBaseForm.ReadOnly = true;
        }

        protected override void BindData()
        {
            if (PrimaryKey == null)
                throw new ArgumentException("ჩანაწერი ვერ ვიპოვე.", "RecordID");

            bbMedicament.RecordValue = PrimaryKey;

            ds_ProductLocation.VW_ProductLocation.Clear();
            using (var cmd = new SqlCommand("SELECT * FROM Production.VW_ProductLocation WITH (NOLOCK) WHERE MedicamentID = @MedicamentID AND Quantity > 0"))
            {
                cmd.Parameters.Add("@MedicamentID", SqlDbType.Int).Value = PrimaryKey;
                ds_ProductLocation.VW_ProductLocation.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }
    }
}
