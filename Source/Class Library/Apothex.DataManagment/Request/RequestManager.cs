using System;
using Apothex.DataType;
using Zek.Data;
using Apothex.Contracts.Request;
using Apothex.Configuration;
using Apothex.SqlDataAccess.Request;

namespace Apothex.DataManagment.Request
{
    public static class RequestManager
    {
        #region Fields
        private static object sync = new object();
        private static RequestProvider _instance;
        private static RequestProvider Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (sync)
                    {
                        if (_instance == null)
                        {
                            switch (ConfigurationManagerEx.RequestProvider)
                            {
                                case "WebService":
                                case "SqlDataBase":
                                default: //SqlDataBase
                                    _instance = new SqlRequestProvider();
                                    break;
                            }
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion

        public static DS_Request.SP_GetRequestHeaderDataTable GetRequestHeader(int requestID)
        {
            return Instance.GetRequestHeader(requestID);
        }
        public static DS_Request.SP_GetRequestDetailDataTable GetRequestDetail(int requestID)
        {
            return Instance.GetRequestDetail(requestID);
        }
        public static int AddOrEditRequest(int requestID, int branchID, DateTime requestDate, DatabaseStatus status, int modifierID, DateTime modifiedDate, int approverID, Guid rowguid, DatabaseAction action, byte[] b)
        {
            return Instance.AddOrEditRequest(requestID, branchID, requestDate, (int)status, modifierID, modifiedDate, approverID, rowguid, (int)action, b);
        }
        public static void UpdateStatus(int? id, int? statusID, int? modifierID)
        {
            Instance.UpdateStatus(id, statusID, modifierID);
        }
    }
}
