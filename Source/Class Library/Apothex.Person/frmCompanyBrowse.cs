using System.Data;
using System.Data.SqlClient;
using Apothex.DataType;
using Apothex.Windows.Forms;
using Apothex.DataManagment.Dictionary;

namespace Apothex.Person
{
    public partial class frmCompanyBrowse : frmBrowse
    {
        public frmCompanyBrowse()
        {
            InitializeComponent();
        }

        protected override void BindControls()
        {
            bsCountry.DataSource = DictionaryManager.GetDictionary(ObjectNames.Country, -1);
            bsBank.DataSource = DictionaryManager.GetDictionary(ObjectNames.Bank, -1);
        }
        protected override void BindGrid()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = SelectSql +
@"
*
FROM Person.VW_Company WITH (NOLOCK)
WHERE " + FilterStatusSql;

                if (IsFiltered)
                {
                    if (txtCompanyName.Text.Trim().Length > 0)
                    {
                        cmd.CommandText += " AND [Name] LIKE '%'+@Name+'%'";
                        cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtCompanyName.Text.Trim();
                    }

                    if (txtTaxCode.Text.Trim().Length > 0)
                    {
                        cmd.CommandText += " AND [TaxCode] LIKE '%'+@TaxCode+'%'";
                        cmd.Parameters.Add("@TaxCode", SqlDbType.NVarChar).Value = txtTaxCode.Text.Trim();
                    }

                    if (txtPhone.Text.Trim().Length > 0)
                    {
                        cmd.CommandText += " AND [Phone] LIKE '%'+@Phone+'%'";
                        cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = txtPhone.Text.Trim();
                    }

                    if (txtFax.Text.Trim().Length > 0)
                    {
                        cmd.CommandText += " AND [Fax] LIKE '%'+@Fax+'%'";
                        cmd.Parameters.Add("@Fax", SqlDbType.NVarChar).Value = txtFax.Text.Trim();
                    }

                    if (lookCountry.EditValue != null)
                    {
                        cmd.CommandText += " AND [CountryCode] = @CountryCode";
                        cmd.Parameters.Add("@CountryCode", SqlDbType.NVarChar).Value = lookCountry.EditValue;
                    }

                    if (txtAddress.Text.Trim().Length > 0)
                    {
                        cmd.CommandText += " AND [Address] LIKE '%'+@Address+'%'";
                        cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = txtAddress.Text.Trim();
                    }

                    if (lookBank.EditValue != null)
                    {
                        cmd.CommandText += " AND [BankID] = @BankID";
                        cmd.Parameters.Add("@BankID", SqlDbType.Int).Value = lookBank.EditValue;
                    }

                    if (txtBankAccountNumber.Text.Trim().Length > 0)
                    {
                        cmd.CommandText += " AND [BankAccountNumber] LIKE '%'+@BankAccountNumber+'%'";
                        cmd.Parameters.Add("@BankAccountNumber", SqlDbType.NVarChar).Value = txtBankAccountNumber.Text.Trim();
                    }
                }

                cmd.CommandText += " ORDER BY [ModifiedDate] DESC";

                ds.VW_Company.Clear();
                ds.VW_Company.Merge(DictionaryManager.GetDataTable(cmd));
            }
        }
    }
}