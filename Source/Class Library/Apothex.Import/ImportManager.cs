using System.Data;
using Apothex.DataType;
using Apothex.DataManagment.Dictionary;
using Zek.Core;
using Zek.Data;

namespace Apothex.Import
{
    public static class ImportManager
    {
        /// <summary>
        /// აიმპორტებს Dictionary-ც ცხრილს.
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="table"></param>
        /// <param name="fieldID"></param>
        /// <param name="fieldParentName"></param>
        /// <param name="fieldName"></param>
        public static void SynchronizeDictionary(DataTable table, ObjectNames objectName, string fieldID, bool chekByID, string fieldParentName, string fieldName)
        {
            string[] fieldNames;

            if (!string.IsNullOrEmpty(fieldParentName))
                fieldNames = new[] { fieldID, fieldParentName, fieldName };
            else
                fieldNames = new[] { fieldID, fieldName };

            var newTable = table.SelectDistinct(false, fieldNames, fieldID, fieldName);
            var importTable = new DS_Import.T_ImportDataTable();
            foreach (DataRow row in newTable.Rows)
            {
                if (row[fieldName].ToString().Trim().Length == 0) continue;

                var newRrow = importTable.NewT_ImportRow();
                newRrow.StringName = row[fieldName].ToString().Trim();
                if (!string.IsNullOrEmpty(fieldID))
                    newRrow.StringID = row[fieldID].ToString().Trim();

                if (!string.IsNullOrEmpty(fieldParentName))
                    newRrow.StringParentName = row[fieldParentName].ToString().Trim();
                importTable.AddT_ImportRow(newRrow);
            }


            if (importTable.Count == 0) return;
            DataTable xmlTable = importTable.PackAlternationTypedDataTable<DS_Import.T_ImportDataTable>(dataRowState: DataRowState.Added, addActionColumn: true);
            ImportDataTable(objectName, xmlTable);

            InitID(table, objectName, fieldID, chekByID, fieldParentName, fieldName);
        }

        public static void InitID(DataTable table, ObjectNames objectName, string fieldID, bool chekByID, string fieldParentName, string fieldName)
        {
            var dictionary = DictionaryManager.GetDictionary(objectName, -1);
            var viewID = new DataView(dictionary);
            viewID.Sort = dictionary.IDColumn.ColumnName;
            var viewName = dictionary.DefaultView;
            viewName.Sort = dictionary.CaptionColumn.ColumnName;
            foreach (DataRow row in table.Rows)
            {
                if (ConvertHelper.ToString(row[fieldName]).Trim().Length == 0)
                    continue;

                int id;
                if (chekByID)
                {
                    id = viewID.Find(ConvertHelper.ToString(row[fieldID]).Trim());
                    if (id != -1)
                    {
                        row[fieldID] = row[fieldID];
                        continue;
                    }
                }

                id = viewName.Find(ConvertHelper.ToString(row[fieldName]).Trim());
                if (id != -1)
                {
                    row[fieldID] = viewName[id][0];
                    continue;
                }
            }
        }

        public static void ImportDataTable(ObjectNames objectName, DataTable table)
        {
            var ds = new DataSet("root");
            ds.Tables.Add(table.Copy());
            DictionaryManager.Import(objectName, BaseGlobalVariable.UserID, ds.GetBytesData());
        }
    }
}
