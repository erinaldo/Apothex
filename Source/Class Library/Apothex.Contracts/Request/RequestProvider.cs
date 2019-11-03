using System;
using Apothex.DataType;

namespace Apothex.Contracts.Request
{
    public abstract class RequestProvider : IRequest
    {
        public abstract DS_Request.SP_GetRequestHeaderDataTable GetRequestHeader(int requestID);
        public abstract DS_Request.SP_GetRequestDetailDataTable GetRequestDetail(int requestID);
        public abstract int AddOrEditRequest(int requestID, int branchID, DateTime requestDate, int status, int modifierID, DateTime modifiedDate, int approverID, Guid rowguid, int action, byte[] b);
        public abstract void UpdateStatus(int? id, int? statusID, int? modifierID);
    }
}