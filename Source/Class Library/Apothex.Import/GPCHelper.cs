using System.IO;
using System.Data;
using Apothex.DataType;
using Zek.Data;
using Zek.Core;

namespace Apothex.Import
{
    public class GPCHelper
    {
        public GPCHelper(string csvFilePath, decimal unitPricePct, decimal taxRate)
        {
            _CsvFilePath = csvFilePath;
            _UnitPricePct = unitPricePct;
            _TaxRate = taxRate;
        }

        private string _CsvFilePath;

        private decimal _UnitPricePct;

        private decimal _TaxRate;

        private string FileDir
        {
            get { return Path.GetDirectoryName(_CsvFilePath); }
        }

        private string TableName
        {
            get { return Path.GetFileName(_CsvFilePath); }
        }

        private string ConnectionString
        {
            get { return CsvHelper.GetOleDbConnectionString(FileDir); }
        }

        private string SelectCmd
        {
            get { return string.Format("SELECT * FROM [{0}]", TableName); }
        }

        public void Fill(DS_GPC.T_GPCDataTable table)
        {
            var tmpTable = OleDbHelper.GetDataTable(ConnectionString, SelectCmd);
            table.Clear();
            foreach (DataRow row in tmpTable.Rows)
            {
                table.ImportRow(row);
            }
            Translate(table);
        }

        public void Translate(DS_GPC.T_GPCDataTable table)
        {
            foreach (var row in table)
            {
                if (!row.IsnameNull())
                    row.name = StringHelper.GeorgianASCIIToUTF8(row.name);
                if (!row.IscountryNull())
                    row.country = StringHelper.GeorgianASCIIToUTF8(row.country);
                if (!row.IsforabcNull())
                    row.forabc = StringHelper.GeorgianASCIIToUTF8(row.forabc);
                if (!row.Isexp_35Null())
                    row.exp_35 = StringHelper.GeorgianASCIIToUTF8(row.exp_35);

                //შესასყიდი ფასი
                row._SalePriceUSD = MathHelper.RemoveAddedPct(row.usdoutamt, _UnitPricePct);
                row._SalePriceGEL = MathHelper.RemoveAddedPct(row.exp_11, _UnitPricePct);

                row._UnitPriceUSD = MathHelper.RemoveAddedPct(row.usdoutamt, _TaxRate);
                row._UnitPriceGEL = MathHelper.RemoveAddedPct(row.exp_11, _TaxRate);
            }
        }
    }
}
