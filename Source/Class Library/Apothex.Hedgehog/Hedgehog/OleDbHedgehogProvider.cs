using System;
using Apothex.Configuration;
using Apothex.Contracts.Hedgehog;
using Apothex.DataType;
using System.Data.OleDb;
using Apothex.DataType.DS_HedgehogTableAdapters;
using Apothex.Hedgehog.Properties;
using Zek.Data;
using System.IO;

namespace Apothex.SqlDataAccess.Hedgehog
{
    public sealed class OleDbHedgehogProvider : HedgehogProvider
    {

        private string HedgehogFile
        {
            get { return ConfigurationManagerEx.HedgehogFile.Trim(); }
        }
        private string HedgehogDir
        {
            get { return Path.GetDirectoryName(HedgehogFile); }
        }
        private string TableName
        {
            get { return Path.GetFileName(ConfigurationManagerEx.HedgehogFile);  }
        }
        private string ConnectionString
        {
            get { return DbfHelper.GetOleDbConnectionString(HedgehogDir); }
        }

        public void CheckFile()
        {
            if (HedgehogFile.Length == 0)
                throw new ArgumentNullException("HedgehogFile", "კონფიგურაციაში არ არის მითითებული ზღარბი ბარათის ფაილი.");
            else if (!Path.IsPathRooted(HedgehogFile))
                throw new ArgumentNullException("HedgehogFile", "კონფიგურაციაში მითითებულ ზღარბის ბარათის ფაილს არ აქვს სწორი მისამართი.");
            else if (!Path.HasExtension(HedgehogFile))
                throw new ArgumentNullException("HedgehogFile", "კონფიგურაციაში მითითებულ ზღარბის ბარათის ფაილს არ აქვს გაფართოება.");

            if (!Directory.Exists(HedgehogDir))
                Directory.CreateDirectory(HedgehogDir);
            if (!File.Exists(HedgehogFile))
            {
                File.WriteAllBytes(HedgehogFile, Resources.BARAT);
                //Zek.IO.IOHelper.SaveFile(Apothex.Hedgehog.Properties.Resources.BARAT, HedgehogFile);
            }
        }

        public override DS_Hedgehog.SP_GetSalesHedgehogDataTable GetSalesHedgehog(int salesOrderID)
        {
                using (var adapter = SP_GetSalesHedgehogTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
                {
                    return adapter.GetData(salesOrderID);
                }
        }

        public override void AddOrEditHedgehog(int salesOrderID, decimal totalDue, DateTime orderDate, int action)
        {
            try
            {
                CheckFile();
                //Add = 4
                //Edit = 16
                
                action = (OleDbHelper.GetDataTable(ConnectionString, string.Format("SELECT * FROM [{0}] WHERE INV = '{1}'", TableName, salesOrderID)).Rows.Count > 0 ? (int)DatabaseAction.Edit : (int)DatabaseAction.Add);
                //DeleteHedgehog(salesOrderID);

                var insertSQL = string.Format(@"
INSERT INTO [{0}]
    (INV,
    AMOUNT,
    SALEDATE,
    SALETIME)
VALUES
    ('{1}',
    @AMOUNT,
    @SALEDATE,
    @SALETIME)
", TableName, salesOrderID);


                var updateSQL = string.Format(@"
UPDATE [{0}]
SET AMOUNT = @AMOUNT
WHERE INV = '{1}'
", TableName, salesOrderID);

                var cmd = new OleDbCommand((action == 4) ? insertSQL : updateSQL);

                //cmd.Parameters.Add("@INV", OleDbType.VarChar, 10).Value = salesOrderID;
                cmd.Parameters.Add("@AMOUNT", OleDbType.Double, 10).Value = totalDue;
                if (action == 4)
                {
                    cmd.Parameters.Add("@SALEDATE", OleDbType.Date, 8).Value = orderDate.Date;
                    cmd.Parameters.Add("@SALETIME", OleDbType.VarChar, 5).Value = ((orderDate.Hour * 3600) + (orderDate.Minute * 60)).ToString();
                }

                OleDbHelper.ExecuteNonQuery(ConnectionString, cmd);
            }
            catch
            {
                throw;
            }
        }

        public override void DeleteHedgehog(int salesOrderID)
        {
            OleDbHelper.ExecuteNonQuery(ConnectionString, string.Format(@"DELETE FROM {0} WHERE INV = '{1}'", TableName, salesOrderID));
        }
    }
}
