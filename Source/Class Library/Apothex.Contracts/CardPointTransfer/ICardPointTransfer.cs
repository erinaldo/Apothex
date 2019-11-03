using System;
using Apothex.DataType;

namespace Apothex.Contracts.CardPointTransfer
{
    interface ICardPointTransfer
    {
        DS_CardPointTransfer.T_PointTransferHeaderDataTable GetHeader(int? id);
        DS_CardPointTransfer.VW_PointTransferDetailDataTable GetDetail(int? id);
        int Save(int? id, DateTime? date, string fromCardNumber, string toCardNumber, string comment, int? modifierID);
    }
}
