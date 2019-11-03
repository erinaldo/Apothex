using System.IO;
using Zek.Core;
using Zek.Data;
using System.Data;
using Apothex.DataType;

namespace Apothex.Import
{
    public class AversiHelper
    {
        public AversiHelper(string dbfFilePath, decimal unitPricePct, decimal taxRate)
        {
            _DbfFilePath = dbfFilePath;
            _UnitPricePct = unitPricePct;
            _TaxRate = taxRate;
        }

        private string _DbfFilePath;

        private decimal _UnitPricePct;

        private decimal _TaxRate;

        private string FileDir
        {
            get { return Path.GetDirectoryName(_DbfFilePath); }
        }

        private string TableName
        {
            get { return Path.GetFileName(_DbfFilePath); }
        }

        private string ConnectionString
        {
            get { return DbfHelper.GetOleDbConnectionString(FileDir); }
        }

        private string SelectCmd
        {
            get { return string.Format("SELECT * FROM [{0}]", TableName); }
        }

        public void Fill(DS_Aversi.T_ImportDataTable table)
        {
            var tmpTable = OleDbHelper.GetDataTable(ConnectionString, SelectCmd);
            table.Clear();
            foreach (DataRow row in tmpTable.Rows)
            {
                table.ImportRow(row);
            }
            Translate(table);
        }

        public void Translate(DS_Aversi.T_ImportDataTable table)
        {           
            foreach (var row in table)
            {
                if (!row.IsNAM_MATNull())
                    row.NAM_MAT = GeoConvertHelper.Convert(row.NAM_MAT, GeoConvertHelper.Aversi, GeoConvertHelper.Unicode);

                if (!row.IsPRONAMENull())
                    row.PRONAME = GeoConvertHelper.Convert(row.PRONAME, GeoConvertHelper.Aversi, GeoConvertHelper.Unicode);

                if (!row.IsNAM_CONGNull())
                    row.NAM_CONG = GeoConvertHelper.Convert(row.NAM_CONG, GeoConvertHelper.Aversi, GeoConvertHelper.Unicode);
                
                //შესასყიდი ფასი
                //row._UNIT_PRICE_USD = (_UnitPricePct == 0m ? MathHelper.RemoveAddedPct(row.USD_PRICE, _TaxRate) : MathHelper.RemoveAddedPct(MathHelper.AddPct(row.USD_PRICE, _UnitPricePct), _TaxRate));
                //row._UNIT_PRICE_GEL = (_UnitPricePct == 0m ? MathHelper.RemoveAddedPct(row.PRICE, _TaxRate) : MathHelper.RemoveAddedPct(MathHelper.AddPct(row.PRICE, _UnitPricePct), _TaxRate));
            }
        }

        private static string Replace(string fromLetters, string toLetters, string value)
        {
            for (var i = 0; i < fromLetters.Length; i++)
                value = value.Replace(fromLetters[i], toLetters[i]);

            return value;
        }
    }
}
