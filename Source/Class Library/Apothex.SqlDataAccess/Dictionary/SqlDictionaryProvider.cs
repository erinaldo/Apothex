using System;
using System.Data;
using System.Data.SqlClient;
using Apothex.DataType.DS_DictionaryTableAdapters;
using Apothex.Contracts.Dictionary;
using Apothex.DataType;
using Apothex.DataType.DS_MedicamentTableAdapters;
using Apothex.Configuration;
using Zek.Data;
using Apothex.DataType.DS_CurrencyTableAdapters;
using Apothex.DataType.DS_CurrencyRateTableAdapters;

namespace Apothex.SqlDataAccess.Dictionary
{
    public sealed class SqlDictionaryProvider : DictionaryProvider
    {
        public override DataTable GetDataTable(SqlCommand cmd, bool isOnline)
        {
            using (var conn = new SqlConnection((isOnline ? ConfigurationManagerEx.ConnectionString : ConfigurationManagerEx.OfflineConnectionString)))
            {
                //conn.Open();
                cmd.Connection = conn;
                cmd.CommandTimeout = (isOnline ? ConfigurationManagerEx.CommandTimeout : ConfigurationManagerEx.OfflineCommandTimeout);

                var dataTable = new DataTable();
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public override DS_Dictionary.SP_GetDictionaryDataTable GetDictionary(int tableID, int ParamInt1, string ParamString1, DateTime ParamDateTime1, Guid ParamGuid1, int paramInt2, string paramString2, DateTime paramDateTime2, Guid paramGuid2, bool isOnline)
        {
            var connectionString = (isOnline ? ConfigurationManagerEx.ConnectionString : ConfigurationManagerEx.OfflineConnectionString);
            var commandTimeout = (isOnline ? ConfigurationManagerEx.CommandTimeout : ConfigurationManagerEx.OfflineCommandTimeout);

            using (var adapter = SP_GetDictionaryTableAdapter.CreateInstance(connectionString, commandTimeout))
            {
                return adapter.GetData(tableID, 0, string.Empty, string.Empty, ParamInt1, ParamString1, ParamDateTime1, ParamGuid1, paramInt2, paramString2, paramDateTime2, paramGuid2);
            }
        }
        public override DS_Dictionary.SP_GetDictionaryIntDataTable GetDictionaryInt(int tableID, int ParamInt1, string ParamString1, DateTime ParamDateTime1, Guid ParamGuid1, int paramInt2, string paramString2, DateTime paramDateTime2, Guid paramGuid2, bool isOnline)
        {
            var connectionString = (isOnline ? ConfigurationManagerEx.ConnectionString : ConfigurationManagerEx.OfflineConnectionString);
            var commandTimeout = (isOnline ? ConfigurationManagerEx.CommandTimeout : ConfigurationManagerEx.OfflineCommandTimeout);

            using (var adapter = SP_GetDictionaryIntTableAdapter.CreateInstance(connectionString, commandTimeout))
            {
                return adapter.GetData(tableID, 0, string.Empty, string.Empty, ParamInt1, ParamString1, ParamDateTime1, ParamGuid1, paramInt2, paramString2, paramDateTime2, paramGuid2);
            }
        }
        public override DS_Dictionary.SP_GetButtonBrowseDataTable GetButtonBrowse(int TypeID, int ParamInt, string ParamString, Guid ParamGuid, DateTime ParamDateTime, bool isOnline)
        {
            var connectionString = (isOnline ? ConfigurationManagerEx.ConnectionString : ConfigurationManagerEx.OfflineConnectionString);
            var commandTimeout = (isOnline ? ConfigurationManagerEx.CommandTimeout : ConfigurationManagerEx.OfflineCommandTimeout);

            using (var adapter = SP_GetButtonBrowseTableAdapter.CreateInstance(connectionString, commandTimeout))
            {
                return adapter.GetData(TypeID, ParamInt, ParamString, ParamGuid, ParamDateTime);
            }
        }
        public override int ActionRecord(int tableID, int paramInt1, string paramString1, DateTime paramDateTime1, Guid paramGuid1, int paramInt2, string paramString2, DateTime paramDateTime2, Guid paramGuid2, int action, int modifiedUserID, bool isOnline)
        {
            var connectionString = (isOnline ? ConfigurationManagerEx.ConnectionString : ConfigurationManagerEx.OfflineConnectionString);
            var commandTimeout = (isOnline ? ConfigurationManagerEx.CommandTimeout : ConfigurationManagerEx.OfflineCommandTimeout);

            using (var adapter = DictionaryQueriesAdapter.CreateInstance(connectionString, commandTimeout))
            {
                return (int)adapter.SP_ActionRecord(tableID, paramInt1, paramString1, paramDateTime1, paramGuid1, paramInt2, paramString2, paramDateTime2, paramGuid2, action, modifiedUserID);
            }
        }
        public override int Import(int tableID, int modifierUserID, byte[] b)
        {
            using (var adapter = DictionaryQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_Import(tableID, modifierUserID, b.GetXmlData());
            }
        }

        public override DS_Dictionary.SP_GetBankDataTable GetBank(int BankID)
        {
            using (var adapter = SP_GetBankTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(BankID);
            }
        }
        public override int AddOrEditBank(int BankID, string Name, string BankCode, int Status, int ModifiedUserID, DateTime ModifiedDate, int ApproverUserID, int Action)
        {
            using (var adapter = DictionaryQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_AddOrEditBank(BankID, Name, BankCode, Status, ModifiedUserID, ModifiedDate, ApproverUserID, Action);
            }
        }
        public override bool IsValidBankName(int BankID, string Name)
        {
            using (var adapter = DictionaryQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_IsValidBankName(BankID, Name);
            }
        }
        public override bool IsValidBankCode(int BankID, string BankCode)
        {
            using (var adapter = DictionaryQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_IsValidBankCode(BankID, BankCode);
            }
        }

        public override DS_Dictionary.SP_GetCountryDataTable GetCountry(string countryCode)
        {
            using (var adapter = SP_GetCountryTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(countryCode);
            }
        }
        public override bool IsValidCountryCode(string countryCodeOld, string countryCodeNew)
        {
            using (var adapter = DictionaryQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_IsValidCountryCode(countryCodeOld, countryCodeNew);
            }
        }
        public override bool IsValidCountryName(string countryCodeOld, string name)
        {
            using (var adapter = DictionaryQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_IsValidCountryName(countryCodeOld, name);
            }
        }
        public override int AddOrEditCountry(string countryCodeOld, string countryCodeNew, string name, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action)
        {
            using (var adapter = DictionaryQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_AddOrEditCountry(countryCodeOld, countryCodeNew, name, status, modifiedUserID, modifiedDate, approverUserID, action);
            }
        }

        public override DS_Currency.SP_GetCurrencyDataTable GetCurrency(string currencyCode)
        {
            using (var adapter = SP_GetCurrencyTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(currencyCode);
            }
        }
        public override bool IsValidCurrencyCode(string currencyCodeOld, string currencyCodeNew)
        {
            using (var adapter = DictionaryQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_IsValidCurrencyCode(currencyCodeOld, currencyCodeNew);
            }
        }
        public override bool IsValidCurrencyName(string currencyCode, string name)
        {
            using (var adapter = DictionaryQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_IsValidCurrencyName(currencyCode, name);
            }
        }
        public override int AddOrEditCurrency(string currencyCodeOld, string currencyCodeNew, string name, string coin, decimal averageRate, int position, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action)
        {
            using (var adapter = DictionaryQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_AddOrEditCurrency(currencyCodeOld, currencyCodeNew, name, coin, averageRate, position, status, modifiedUserID, modifiedDate, approverUserID, action);
            }
        }


        public override DS_CurrencyRate.SP_GetCurrencyRateDataTable GetCurrencyRate(int currencyRateID)
        {
            using (var adapter = SP_GetCurrencyRateTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(currencyRateID);
            }
        }
        public override decimal GetCurrencyRate(string currencyCode, DateTime date, bool isOnline)
        {
            var connectionString = (isOnline ? ConfigurationManagerEx.ConnectionString : ConfigurationManagerEx.OfflineConnectionString);
            var commandTimeout = (isOnline ? ConfigurationManagerEx.CommandTimeout : ConfigurationManagerEx.OfflineCommandTimeout);

            using (var adapter = DictionaryQueriesAdapter.CreateInstance(connectionString, commandTimeout))
            {
                return (decimal)adapter.SP_GetRate(currencyCode, date);
            }
        }
        public override bool IsValidCurrencyRateDate(int currencyRateID, string currencyCode, DateTime date)
        {
            using (var adapter = DictionaryQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_IsValidCurrencyRateDate(currencyRateID, currencyCode, date);
            }
        }
        public override int AddOrEditCurrencyRate(int currencyRateID, string currencyCode, DateTime startDate, DateTime endDate, decimal averageRate, int Events, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action)
        {
            using (var adapter = DictionaryQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_AddOrEditCurrencyRate(currencyRateID, currencyCode, startDate, endDate, averageRate, Events, status, modifiedUserID, modifiedDate, approverUserID, action);
            }
        }


        public override DS_Dictionary.SP_GetMedicamentCategoryDataTable GetMedicamentCategory(int medicamentCategoryID)
        {
            using (var adapter = SP_GetMedicamentCategoryTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(medicamentCategoryID);
            }
        }
        public override bool IsValidMedicamentCategoryName(int medicamentCategoryID, string name)
        {
            using (var adapter = DictionaryQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_IsValidMedicamentCategoryName(medicamentCategoryID, name);
            }
        }
        public override int AddOrEditMedicamentCategory(int medicamentCategoryID, string name, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action)
        {
            using (var adapter = DictionaryQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_AddOrEditMedicamentCategory(medicamentCategoryID, name, status, modifiedUserID, modifiedDate, approverUserID, action);
            }
        }

        public override DS_Dictionary.SP_GetMedicamentSubcategoryDataTable GetMedicamentSubcategory(int medicamentSubcategoryID)
        {
            using (var adapter = SP_GetMedicamentSubcategoryTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(medicamentSubcategoryID);
            }
        }
        public override bool IsValidMedicamentSubcategoryName(int medicamentSubcategoryID, int medicamentCategoryID, string name)
        {
            using (var adapter = DictionaryQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_IsValidMedicamentSubcategoryName(medicamentSubcategoryID, medicamentCategoryID, name);
            }
        }
        public override int AddOrEditMedicamentSubcategory(int medicamentSubcategoryID, int medicamentCategoryID, string name, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action)
        {
            using (var adapter = DictionaryQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_AddOrEditMedicamentSubcategory(medicamentSubcategoryID, medicamentCategoryID, name, status, modifiedUserID, modifiedDate, approverUserID, action);
            }
        }

        public override DS_Medicament.SP_GetMedicamentDataTable GetMedicament(int medicamentID)
        {
            using (var adapter = SP_GetMedicamentTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(medicamentID);
            }
        }
        public override bool IsValidMedicamentName(int medicamentID, string name)
        {
            using (var adapter = MedicamentQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_IsValidMedicamentName(medicamentID, name);
            }
        }
        public override bool IsValidProductNumber(int medicamentID, string productNumber)
        {
            using (var adapter = MedicamentQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_IsValidProductNumber(medicamentID, productNumber);
            }
        }
        public override int AddOrEditMedicament(int medicamentID, int medicamentSubcategoryID, string name, string productNumber, bool makeFlag, bool finishedGoodsFlag, string color, short safetyStockLevel, short reorderPoint, decimal standardCost, decimal listPrice, decimal dealerPrice, string productCurrencyCode, decimal discountPct, decimal taxRate, string size, string sizeRange, string sizeUnitMeasureCode, decimal weight, string weightUnitMeasureCode, int daysToManufacture, string productLine, string _class, string style, int productModelID, DateTime sellStartDate, DateTime sellEndDate, DateTime discontinuedDate, short unitsInStock, DateTime validDate, int genericID, string countryCode, int brandID, string serie, bool autoUpdateProducts, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action)
        {
            using (var adapter = MedicamentQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_AddOrEditMedicament(medicamentID, medicamentSubcategoryID, name, productNumber, makeFlag, finishedGoodsFlag, color, safetyStockLevel, reorderPoint, standardCost, listPrice, dealerPrice, productCurrencyCode, discountPct, taxRate, size, sizeRange, sizeUnitMeasureCode, weight, weightUnitMeasureCode, daysToManufacture, productLine, _class, style, productModelID, sellStartDate, sellEndDate, discontinuedDate, unitsInStock, validDate, genericID, countryCode, brandID, serie, autoUpdateProducts, status, modifiedUserID, modifiedDate, approverUserID, action);
            }
        }


        public override DS_Dictionary.SP_GetPaymentMethodDataTable GetPaymentMethod(int paymentMethodID)
        {
            using (var adapter = SP_GetPaymentMethodTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(paymentMethodID);
            }
        }
        public override bool IsValidPaymentMethodName(int paymentMethodID, string name)
        {
            using (var adapter = DictionaryQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_IsValidPaymentMethodName(paymentMethodID, name);
            }
        }
        public override int AddOrEditPaymentMethod(int paymentMethodID, string name, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action)
        {
            using (var adapter = DictionaryQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_AddOrEditPaymentMethod(paymentMethodID, name, status, modifiedUserID, modifiedDate, approverUserID, action);
            }
        }

        public override DS_Dictionary.SP_GetUnitMeasureDataTable GetUnitMeasure(string unitMeasureCode)
        {
            using (var adapter = SP_GetUnitMeasureTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(unitMeasureCode);
            }
        }
        public override bool IsValidUnitMeasureCode(string unitMeasureCodeOld, string unitMeasureCodeNew)
        {
            using (var adapter = DictionaryQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_IsValidUnitMeasureCode(unitMeasureCodeOld, unitMeasureCodeNew);
            }
        }
        public override bool IsValidUnitMeasureName(string unitMeasureCode, string name)
        {
            using (var adapter = DictionaryQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_IsValidUnitMeasureName(unitMeasureCode, name);
            }
        }
        public override int AddOrEditUnitMeasure(string unitMeasureCodeOld, string unitMeasureCodeNew, string name, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action)
        {
            using (var adapter = DictionaryQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_AddOrEditUnitMeasure(unitMeasureCodeOld, unitMeasureCodeNew, name, status, modifiedUserID, modifiedDate, approverUserID, action);
            }
        }

        public override DS_Dictionary.SP_GetMedicamentsDataTable GetMedicaments(int medicamentID, string medicamentName, int medicamentCategoryID, string medicamentCategoryName, int medicamentSubcategoryID, string medicamentSubcategoryName, int Status)
        {
            using (var adapter = SP_GetMedicamentsTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(medicamentID, medicamentName, medicamentCategoryID, medicamentCategoryName, medicamentSubcategoryID, medicamentSubcategoryName, Status);
            }
        }


        public override DS_Dictionary.SP_GetBrandDataTable GetBrand(int brandID)
        {
            using (var adapter = SP_GetBrandTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(brandID);
            }
        }
        public override bool IsValidBrandName(int brandID, string name)
        {
            using (var adapter = DictionaryQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_IsValidBrandName(brandID, name);
            }
        }
        public override int AddOrEditBrand(int brandID, string name, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action)
        {
            using (var adapter = DictionaryQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_AddOrEditBrand(brandID, name, status, modifiedUserID, modifiedDate, approverUserID, action);
            }
        }

        public override DS_Dictionary.SP_GetMergeMedicamentDataTable GetMergeMedicament(int fromMedicamentID)
        {
            using (var adapter = SP_GetMergeMedicamentTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(fromMedicamentID);
            }
        }

        public override DS_Dictionary.SP_GetGenericDataTable GetGeneric(int genericID)
        {
            using (var adapter = SP_GetGenericTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(genericID);
            }
        }
        public override bool IsValidGenericName(int genericID, string name)
        {
            using (var adapter = DictionaryQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_IsValidGenericName(genericID, name);
            }
        }
        public override int AddOrEditGeneric(int genericID, string name, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action)
        {
            using (var adapter = DictionaryQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_AddOrEditGeneric(genericID, name, status, modifiedUserID, modifiedDate, approverUserID, action);
            }
        }
    }
}
