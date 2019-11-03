using System;
using Apothex.DataType;


namespace Apothex.Contracts.Card
{
    interface ICard
    {
        DS_Card.DD_CardTypeDataTable GetCardType(int? id);
        bool IsValidCartTypeName(int? id, string name);
        int AddOrEditCartType(int? id, string name, int? modifierID);
        string GetCardNumber(int? id);

        DS_Card.DD_CardDiscountSchemaDataTable GetCardDiscountSchema(int? id);
        bool IsValidCardDiscountSchema(int? id, int? min, int? max);
        int AddOrEditCardDiscountSchema(int? id, int? minUnit, int? maxUnit, decimal? discount, int? modifierID);

        DS_Card.DD_CardUnitRateDataTable GetCardUnitRate(int? id);
        bool IsValidCardUnitRate(int? id, decimal? min, decimal? max);
        int AddOrEditCardUnitRate(int? id, decimal? minAmount, decimal? maxAmount, decimal? unit, decimal? amount, int? modifierID);
        decimal GetCardUnitRateUnit(decimal? amount, bool isOnline);
        decimal GetCardUnitRateAmount(decimal? amount, bool isOnline);

        DS_Card.T_CardDataTable GetCard(int? id);
        int AddOrEditCard(int? id, string cardNumber, int? cardTypeID, int? personID, int? parentCardID, int? modifierID);
        bool IsValidCardNumber(int? id, string cardNumber);
        int GetCardID(string cardNumber);
        DS_Card.VW_CardInfoDataTable GetCardInfo(string cardNumber);
        DS_Card.T_CardHandleDataTable GetCardHandle(int? id, DateTime? date, bool isOnline);
        DS_Card.VW_CardHandleDataTable GetVWCardHandle(int? id, int? parentID, DateTime? date1, DateTime? date2);
        DS_Card.T_BonusAccumulationDataTable GetBonusAccumulation(int? id, string cardNumber, bool isOnline, int commandTimeOut);
        DS_Card.VW_BonusAccumulationDataTable GetBonusAccumulationVW(DateTime? date1, DateTime? date2);

        int SaveCardHandle(byte[] b, int? modifierID);
    }
}
