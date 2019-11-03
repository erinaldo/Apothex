using System;
using Apothex.DataType;
using Apothex.Contracts.Card;
using Apothex.Configuration;
using Apothex.SqlDataAccess.Card;
using Zek.Core;

namespace Apothex.DataManagment.Card
{
    public static class CardManager
    {
        #region Fields
        private static object sync = new object();
        private static CardProvider _instance;
        private static CardProvider Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (sync)
                    {
                        if (_instance == null)
                        {
                            switch (ConfigurationManagerEx.CardProvider)
                            {
                                case "WebService":
                                case "SqlDataBase":
                                default: //SqlDataBase
                                    _instance = new SqlCardProvider();
                                    break;
                            }
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion

        public static DS_Card.DD_CardTypeDataTable GetCardType(int? id)
        {
            return Instance.GetCardType(id);
        }
        public static bool IsValidCartTypeName(int? id, string name)
        {
            return Instance.IsValidCartTypeName(id, name);
        }
        public static int AddOrEditCartType(int? id, string name, int? modifierID)
        {
            return Instance.AddOrEditCartType(id, name, modifierID);
        }

        public static DS_Card.DD_CardDiscountSchemaDataTable GetCardDiscountSchema(int? id)
        {
            return Instance.GetCardDiscountSchema(id);
        }
        public static bool IsValidCardDiscountSchema(int? id, int? min, int? max)
        {
            return Instance.IsValidCardDiscountSchema(id, min, max);
        }
        public static int AddOrEditCardDiscountSchema(int? id, int? minUnit, int? maxUnit, decimal discount, int? modifierID)
        {
            return Instance.AddOrEditCardDiscountSchema(id, minUnit, maxUnit, discount, modifierID);
        }

        public static DS_Card.DD_CardUnitRateDataTable GetCardUnitRate(int? id)
        {
            return Instance.GetCardUnitRate(id);
        }
        public static bool IsValidCardUnitRate(int? id, decimal? min, decimal? max)
        {
            return Instance.IsValidCardUnitRate(id, min, max);
        }
        public static int AddOrEditCardUnitRate(int? id, decimal? minAmount, decimal? maxAmount, decimal? unit, decimal? amount, int? modifierID)
        {
            return Instance.AddOrEditCardUnitRate(id, minAmount, maxAmount, unit, amount, modifierID);
        }
        public static decimal GetCardUnitRateUnit(decimal? amount, bool isOnline)
        {
            return Instance.GetCardUnitRateUnit(amount, isOnline);
        }
        public static decimal GetCardUnitRateAmount(decimal? amount, bool isOnline)
        {
            return Instance.GetCardUnitRateAmount(amount, isOnline);
        }

        public static DS_Card.T_CardDataTable GetCard(int? id)
        {
            return Instance.GetCard(id);
        }
        public static bool IsValidCardNumber(int? id, string cardNumber)
        {
            return Instance.IsValidCardNumber(id, cardNumber);
        }
        public static int GetCardID(string cardNumber)
        {
            return Instance.GetCardID(cardNumber);
        }
        public static string GetCardNumber(int? id)
        {
            return Instance.GetCardNumber(id);
        }
        public static int AddOrEditCard(int? id, string cardNumber, int? cardTypeID, int? personID, int? parentCardID, int? modifierID)
        {
            return Instance.AddOrEditCard(id, cardNumber, cardTypeID, personID, parentCardID, modifierID);
        }

        public static DS_Card.VW_CardInfoDataTable GetCardInfo(string cardNumber)
        {
            return !string.IsNullOrEmpty(cardNumber) ? Instance.GetCardInfo(cardNumber) : new DS_Card.VW_CardInfoDataTable();
        }
        public static DS_Simple.T_GridNameValueDataTable GetCardInfoForNameValueGrid(string cardNumber, bool isOnline)
        {
            var cardInfo = GetCardInfo(cardNumber);
            if (cardInfo.Count == 0) return null;

            var result = new DS_Simple.T_GridNameValueDataTable();
            result.AddT_GridNameValueRow("ბარათის ნომერი", cardInfo[0].CardNumber);
            result.AddT_GridNameValueRow("მფლობელი", cardInfo[0].Person);
            result.AddT_GridNameValueRow("ბარათზე დანაგროვი თანხა", cardInfo[0].CurrentCardTotalAmount.ToString("n2"));
            result.AddT_GridNameValueRow("ბარათზე დანაგროვი ქულა", cardInfo[0].CurrentCardTotalUnit.ToString("n2"));

            result.AddT_GridNameValueRow("ჯამური დანაგროვი თანხა", cardInfo[0].TotalAmount.ToString("n2"));
            result.AddT_GridNameValueRow("ჯამური დანაგროვი ქულა", cardInfo[0].TotalUnit.ToString("n2"));

            //if (!isOnline)
            //{
            //    DS_Card.T_BonusAccumulationDataTable bonus = GetBonusAccumulationByCardNumber(cardNumber, isOnline);
            //    if (bonus.Count > 0)
            //    {
            //        result.AddT_GridNameValueRow("გადასაგზავნი თანხა", cardInfo[0].TotalAmount.ToString("n2"));
            //        result.AddT_GridNameValueRow("გადასაგზავნი ქულა", cardInfo[0].TotalUnit.ToString("n2"));
            //    }
            //}

            return result;
        }
        public static DS_Card.T_CardHandleDataTable GetCardHandle(int? id, bool isOnline)
        {
            return GetCardHandle(id, DateTimeHelper.MinDate, isOnline);
        }
        public static DS_Card.T_CardHandleDataTable GetCardHandle(DateTime? date, bool isOnline)
        {
            return GetCardHandle(0, date, isOnline);
        }
        public static DS_Card.T_CardHandleDataTable GetCardHandle(int? id, DateTime? date, bool isOnline)
        {
            return Instance.GetCardHandle(id, date, isOnline);
        }
        public static DS_Card.VW_CardHandleDataTable GetVWCardHandle(int? id, int? parentID, DateTime? date1, DateTime? date2)
        {
            return Instance.GetVWCardHandle(id, parentID, date1, date2);
        }

        public static DS_Card.T_BonusAccumulationDataTable GetBonusAccumulationByID(int? id, bool isOnline, int commandTimeOut)
        {
            return GetBonusAccumulation(id, null, isOnline, commandTimeOut);
        }
        public static DS_Card.T_BonusAccumulationDataTable GetBonusAccumulationByCardNumber(string cardNumber, bool isOnline, int commandTimeOut)
        {
            return GetBonusAccumulation(null, cardNumber, isOnline, commandTimeOut);
        }
        private static DS_Card.T_BonusAccumulationDataTable GetBonusAccumulation(int? id, string cardNumber, bool isOnline, int commandTimeOut)
        {
            return Instance.GetBonusAccumulation(id, cardNumber, isOnline, commandTimeOut);
        }
        public static DS_Card.VW_BonusAccumulationDataTable GetBonusAccumulationVW(DateTime? date1, DateTime? date2)
        {
            return Instance.GetBonusAccumulationVW(date1, date2);
        }

        public static int SaveCardHandle(byte[] b, int? modifierID)
        {
            return Instance.SaveCardHandle(b, modifierID);
        }
    }
}
