using Apothex.DataType;
using Apothex.Contracts.Operation;
using Apothex.Configuration;
using Apothex.SqlDataAccess.Operation;

namespace Apothex.DataManagment.Operation
{
    public static class OperationManager
    {
        #region Fields
        private static object sync = new object();
        private static OperationProvider _Instance;
        private static OperationProvider Instance
        {
            get
            {
                if (_Instance == null)
                {
                    lock (sync)
                    {
                        if (_Instance == null)
                        {
                            switch (ConfigurationManagerEx.OperationProvider)
                            {
                                case "WebService":
                                case "SqlDataBase":
                                default: //SqlDataBase
                                    _Instance = new SqlOperationProvider();
                                    break;
                            }
                        }
                    }
                }
                return _Instance;
            }
        }
        #endregion

        public static DS_Operation.T_OperationDataTable Get(ObjectNames objectName, int? id)
        {
            return Instance.Get(objectName.ToString(), id);
        }
        public static int Save(ObjectNames objectName, int? id, byte[] b)
        {
            return Instance.Save(objectName.ToString(), id, b);
        }

        public static bool IsAutoOperationType(byte operationTypeID)
        {
            return IsAutoOperationType((OperationType)operationTypeID);
        }
        public static bool IsAutoOperationType(OperationType operationType)
        {
            switch (operationType)
            {
                case OperationType.Cash:
                case OperationType.ClearingTerminal:
                case OperationType.ClearingTransfer:
                case OperationType.ClearingConsignation:
                    return true;
            }
            
            return false;
        }
    }
}
