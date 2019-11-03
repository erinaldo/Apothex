using System;
using System.IO;
using System.Data;
using Zek.Data;
using Apothex.DataType;
using Zek.Core;

namespace Apothex.Import
{
    public class PSPHelper
    {
        public PSPHelper(string dbfFilePath, decimal unitPricePct, decimal taxRate)
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

        public void Fill(DS_PSP.T_DBFDataTable table)
        {
            var tmpTable = OleDbHelper.GetDataTable(ConnectionString, SelectCmd);
            table.Clear();
            foreach (DataRow row in tmpTable.Rows)
            {
                table.ImportRow(row);
            }
            Translate(table);
        }

        public void Translate(DS_PSP.T_DBFDataTable table)
        {
            foreach (var row in table)
            {
                if (!row.IsNAME_GEONull())
                    row.NAME_GEO = GeoConvertHelper.Convert(row.NAME_GEO, GeoConvertHelper.PSP, GeoConvertHelper.Unicode);
                if (!row.IsNAME_MANUFNull())
                    row.NAME_MANUF = GeoConvertHelper.Convert(row.NAME_MANUF, GeoConvertHelper.PSP, GeoConvertHelper.Unicode);
                if (!row.IsCOUNTRYNull())
                    row.COUNTRY = GeoConvertHelper.Convert(row.COUNTRY, GeoConvertHelper.PSP, GeoConvertHelper.Unicode);

                //შესასყიდი ფასი
                row._UNIT_PRICE_USD = (_UnitPricePct == 0m ? MathHelper.RemoveAddedPct(row.SUM_USD, _TaxRate) : MathHelper.RemoveAddedPct(MathHelper.AddPct(row.SUM_USD_D, _UnitPricePct), _TaxRate));
                row._UNIT_PRICE_GEL = (_UnitPricePct == 0m ? MathHelper.RemoveAddedPct(row.SUM_LAR, _TaxRate) : MathHelper.RemoveAddedPct(MathHelper.AddPct(row.SUM_LAR_D, _UnitPricePct), _TaxRate));

                if (!row.IsVADANull())
                {
                    int year;
                    int month;
                    var vada = row.VADA.Split('/');
                    if (vada.Length == 2)
                    {
                        int.TryParse(vada[1].Trim(), out year);
                        int.TryParse(vada[0].Trim(), out month);
                        if (year >= DateTimeHelper.MinDate.Year && year <= DateTimeHelper.MaxDate.Year && month > 0 && month < 13)
                            row._VADA = new DateTime(year, month, 1);
                    }
                }
            }
        }
    }





}
