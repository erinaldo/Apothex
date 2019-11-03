using System;
using Apothex.DataType;

namespace Apothex.Contracts.Card
{
    public abstract class CardProvider : ICard
    {
        public abstract DS_Card.DD_CardTypeDataTable GetCardType(int? id);
        public abstract bool IsValidCartTypeName(int? id, string name);
        public abstract int AddOrEditCartType(int? id, string name, int? modifierID);
        public abstract string GetCardNumber(int? id);

        public abstract DS_Card.DD_CardDiscountSchemaDataTable GetCardDiscountSchema(int? id);
        public abstract bool IsValidCardDiscountSchema(int? id, int? min, int? max);
        public abstract int AddOrEditCardDiscountSchema(int? id, int? minUnit, int? maxUnit, decimal? discount, int? modifierID);

        public abstract DS_Card.DD_CardUnitRateDataTable GetCardUnitRate(int? id);
        public abstract bool IsValidCardUnitRate(int? id, decimal? min, decimal? max);
        public abstract int AddOrEditCardUnitRate(int? id, decimal? minAmount, decimal? maxAmount, decimal? unit, decimal? amount, int? modifierID);
        public abstract decimal GetCardUnitRateUnit(decimal? amount, bool isOnline);
        public abstract decimal GetCardUnitRateAmount(decimal? amount, bool isOnline);

        public abstract DS_Card.T_CardDataTable GetCard(int? id);
        public abstract int AddOrEditCard(int? id, string cardNumber, int? cardTypeID, int? personID, int? parentCardID, int? modifierID);
        public abstract bool IsValidCardNumber(int? id, string cardNumber);
        public abstract int GetCardID(string cardNumber);
        public abstract DS_Card.VW_CardInfoDataTable GetCardInfo(string cardNumber);
        public abstract DS_Card.T_CardHandleDataTable GetCardHandle(int? id, DateTime? date, bool isOnline);
        public abstract DS_Card.VW_CardHandleDataTable GetVWCardHandle(int? id, int? parentID, DateTime? date1, DateTime? date2);
        public abstract DS_Card.T_BonusAccumulationDataTable GetBonusAccumulation(int? id, string cardNumber, bool isOnline, int commandTimeOut);
        public abstract DS_Card.VW_BonusAccumulationDataTable GetBonusAccumulationVW(DateTime? date1, DateTime? date2);

        public abstract int SaveCardHandle(byte[] b, int? modifierID);
    }
}
