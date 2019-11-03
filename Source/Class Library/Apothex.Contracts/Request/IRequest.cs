using System;
using Apothex.DataType;


namespace Apothex.Contracts.Request
{
    interface IRequest
    {
        DS_Request.SP_GetRequestHeaderDataTable GetRequestHeader(int requestID);
        DS_Request.SP_GetRequestDetailDataTable GetRequestDetail(int requestID);
        int AddOrEditRequest(int requestID, int branchID, DateTime requestDate, int status, int modifierID, DateTime modifiedDate, int approverID, Guid rowguid, int action, byte[] b);
        void UpdateStatus(int? id, int? statusID, int? modifierID);
    }
}
