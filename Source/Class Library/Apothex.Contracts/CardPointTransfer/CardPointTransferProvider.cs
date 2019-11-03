using System;
using Apothex.DataType;

namespace Apothex.Contracts.CardPointTransfer
{
    public abstract class CardPointTransferProvider : ICardPointTransfer
    {
        public abstract DS_CardPointTransfer.T_PointTransferHeaderDataTable GetHeader(int? id);
        public abstract DS_CardPointTransfer.VW_PointTransferDetailDataTable GetDetail(int? id);
        public abstract int Save(int? id, DateTime? date, string fromCardNumber, string toCardNumber, string comment, int? modifierID);
    }
}
