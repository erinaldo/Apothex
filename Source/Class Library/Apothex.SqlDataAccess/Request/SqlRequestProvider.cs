using System;
using Apothex.Contracts.Request;
using Apothex.DataType;
using Apothex.DataType.DS_RequestTableAdapters;
using Zek.Data;
using Apothex.Configuration;

namespace Apothex.SqlDataAccess.Request
{
    public sealed class SqlRequestProvider : RequestProvider
    {
        public override DS_Request.SP_GetRequestHeaderDataTable GetRequestHeader(int requestID)
        {
            using (var adapter = SP_GetRequestHeaderTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(requestID);
            }
        }

        public override DS_Request.SP_GetRequestDetailDataTable GetRequestDetail(int requestID)
        {
            using (var adapter = SP_GetRequestDetailTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(requestID);
            }
        }

        public override int AddOrEditRequest(int requestID, int branchID, DateTime requestDate, int status, int modifierID, DateTime modifiedDate, int approverID, Guid rowguid, int action, byte[] b)
        {
            using (var adapter = RequestQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_AddOrEditRequest(requestID, branchID, requestDate, status, modifierID, modifiedDate, approverID, rowguid, action, b.GetXmlData());
            }
        }
        public override void UpdateStatus(int? id, int? statusID, int? modifierID)
        {
            using (var adapter = RequestQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                adapter.SP_T_RequestHeader_UpdateStatus(id, statusID, modifierID);
            }
        }
    }
}
