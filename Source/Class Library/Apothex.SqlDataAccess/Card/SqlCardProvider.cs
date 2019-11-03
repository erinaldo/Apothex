using System;
using Apothex.DataType;
using Apothex.DataType.DS_CardTableAdapters;
using Zek.Data;
using Apothex.Configuration;
using Apothex.Contracts.Card;

namespace Apothex.SqlDataAccess.Card
{
    public sealed class SqlCardProvider : CardProvider
    {
        public override DS_Card.DD_CardTypeDataTable GetCardType(int? id)
        {
            using (var adapter = DD_CardTypeTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(id);
            }
        }
        public override bool IsValidCartTypeName(int? id, string name)
        {
            using (var adapter = CardQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_DD_CardType_IsValidName(id, name);
            }
        }
        public override int AddOrEditCartType(int? id, string name, int? modifierID)
        {
            using (var adapter = CardQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_DD_CardType_Save(id, name, modifierID);
            }
        }


        public override DS_Card.DD_CardDiscountSchemaDataTable GetCardDiscountSchema(int? id)
        {
            using (var adapter = DD_CardDiscountSchemaTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(id);
            }
        }
        public override bool IsValidCardDiscountSchema(int? id, int? min, int? max)
        {
            using (var adapter = CardQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_DD_CardDiscountSchema_IsValid(id, min, max);
            }
        }
        public override int AddOrEditCardDiscountSchema(int? id, int? minUnit, int? maxUnit, decimal? discount, int? modifierID)
        {
            using (var adapter = CardQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_DD_CardDiscountSchema_Save(id, minUnit, maxUnit, discount, modifierID);
            }
        }

        public override DS_Card.DD_CardUnitRateDataTable GetCardUnitRate(int? id)
        {
            using (var adapter = DD_CardUnitRateTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(id);
            }
        }
        public override bool IsValidCardUnitRate(int? id, decimal? min, decimal? max)
        {
            using (var adapter = CardQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_DD_CardUnitRate_IsValid(id, min, max);
            }
        }
        public override int AddOrEditCardUnitRate(int? id, decimal? minAmount, decimal? maxAmount, decimal? unit, decimal? amount, int? modifierID)
        {
            using (var adapter = CardQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_DD_CardUnitRate_Save(id, minAmount, maxAmount, unit, amount, modifierID);
            }
        }
        public override decimal GetCardUnitRateAmount(decimal? amount, bool isOnline)
        {
            var connectionString = (isOnline ? ConfigurationManagerEx.ConnectionString : ConfigurationManagerEx.OfflineConnectionString);
            var commandTimeout = (isOnline ? ConfigurationManagerEx.CommandTimeout : ConfigurationManagerEx.OfflineCommandTimeout);

            using (var adapter = CardQueriesAdapter.CreateInstance(connectionString, commandTimeout))
            {
                return (decimal)adapter.SP_DD_CardUnitRate_GetAmount(amount);
            }
        }
        public override decimal GetCardUnitRateUnit(decimal? amount, bool isOnline)
        {
            var connectionString = (isOnline ? ConfigurationManagerEx.ConnectionString : ConfigurationManagerEx.OfflineConnectionString);
            var commandTimeout = (isOnline ? ConfigurationManagerEx.CommandTimeout : ConfigurationManagerEx.OfflineCommandTimeout);

            using (var adapter = CardQueriesAdapter.CreateInstance(connectionString, commandTimeout))
            {
                return (decimal)adapter.SP_DD_CardUnitRate_GetUnit(amount);
            }
        }

        public override DS_Card.T_CardDataTable GetCard(int? id)
        {
            using (var adapter = T_CardTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(id);
            }
        }
        public override bool IsValidCardNumber(int? id, string cardNumber)
        {
            using (var adapter = CardQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_T_Card_IsValidCardNumber(id, cardNumber);
            }
        }
        public override int GetCardID(string cardNumber)
        {
            using (var adapter = CardQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_FindCardID(cardNumber);
            }
        }
        public override string GetCardNumber(int? id)
        {
            using (var adapter = CardQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (string)adapter.SP_T_Card_GetCardNumber(id);
            }
        }
        public override int AddOrEditCard(int? id, string cardNumber, int? cardTypeID, int? personID, int? parentCardID, int? modifierID)
        {
            using (var adapter = CardQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_T_Card_Save(id, cardNumber, cardTypeID, personID, parentCardID, modifierID);
            }
        }
        public override DS_Card.VW_CardInfoDataTable GetCardInfo(string cardNumber)
        {
            using (var adapter = VW_CardInfoTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(cardNumber);
            }
        }
        public override DS_Card.T_CardHandleDataTable GetCardHandle(int? id, DateTime? date, bool isOnline)
        {
            var connectionString = (isOnline ? ConfigurationManagerEx.ConnectionString : ConfigurationManagerEx.OfflineConnectionString);
            var commandTimeout = (isOnline ? ConfigurationManagerEx.CommandTimeout : ConfigurationManagerEx.OfflineCommandTimeout);

            using (var adapter = T_CardHandleTableAdapter.CreateInstance(connectionString, commandTimeout))
            {
                return adapter.GetData(id, date);
            }
        }
        public override DS_Card.VW_CardHandleDataTable GetVWCardHandle(int? id, int? parentID, DateTime? date1, DateTime? date2)
        {
            using (var adapter = VW_CardHandleTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(id, parentID, date1, date2);
            }
        }
        public override DS_Card.T_BonusAccumulationDataTable GetBonusAccumulation(int? id, string cardNumber, bool isOnline, int commandTimeout)
        {
            var connectionString = (isOnline ? ConfigurationManagerEx.ConnectionString : ConfigurationManagerEx.OfflineConnectionString);
            if (commandTimeout == 0)
                commandTimeout = (isOnline ? ConfigurationManagerEx.CommandTimeout : ConfigurationManagerEx.OfflineCommandTimeout);

            using (var adapter = T_BonusAccumulationTableAdapter.CreateInstance(connectionString, commandTimeout))
            {
                return adapter.GetData(id, cardNumber);
            }
        }
        public override DS_Card.VW_BonusAccumulationDataTable GetBonusAccumulationVW(DateTime? date1, DateTime? date2)
        {
            using (var adapter = VW_BonusAccumulationTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(date1, date2);
            }
        }

        public override int SaveCardHandle(byte[] b, int? modifierID)
        {
            using (var adapter = CardQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_T_CardHandle_Save(b.GetXmlData(), modifierID, false);
            }
        }
    }
}
