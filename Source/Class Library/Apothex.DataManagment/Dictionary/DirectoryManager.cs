using System;
using System.Data;
using System.Data.SqlClient;
using Apothex.Contracts.Dictionary;
using Apothex.DataType;
using Apothex.SqlDataAccess.Dictionary;
using Zek.Data;
using Zek.Core;

namespace Apothex.DataManagment.Dictionary
{
    public static class DictionaryManager
    {
        #region Instance
        private static object sync = new object();
        private static DictionaryProvider _Instance;
        private static DictionaryProvider Instance
        {
            get
            {
                if (_Instance == null)
                {
                    lock (sync)
                    {
                        if (_Instance == null)
                        {
                            //switch (ConfigurationManagerEx.DictionaryProvider)
                            //{
                                //case "WebService":
                                //case "SqlDataBase":
                                //default: //SqlDataBase
                                    _Instance = new SqlDictionaryProvider();
                                    //break;
                            //}
                        }
                    }
                }
                return _Instance;
            }
        }
        #endregion

        public static DataTable GetDataTable(SqlCommand cmd)
        {
            return GetDataTable(cmd, true);
        }
        public static DataTable GetDataTable(SqlCommand cmd, bool isOnline)
        {
            return Instance.GetDataTable(cmd, isOnline);
        }

        public static DS_Dictionary.SP_GetDictionaryDataTable GetDictionary(ObjectNames tableName)
        {
            return GetDictionary(tableName, true);
        }
        public static DS_Dictionary.SP_GetDictionaryDataTable GetDictionary(ObjectNames tableName, int paramInt1)
        {
            return GetDictionary(tableName, paramInt1, true);
        }
        public static DS_Dictionary.SP_GetDictionaryDataTable GetDictionary(ObjectNames tableName, bool isOnline)
        {
            return GetDictionary(tableName, 0, isOnline);
        }
        public static DS_Dictionary.SP_GetDictionaryDataTable GetDictionary(ObjectNames tableName, int paramInt1, bool isOnline)
        {
            return GetDictionary(tableName, paramInt1, string.Empty, DateTime.Now, Guid.Empty, isOnline);
        }
        public static DS_Dictionary.SP_GetDictionaryDataTable GetDictionary(ObjectNames tableName, int paramInt1, string paramString1, DateTime paramDateTime1, Guid paramGuid1)
        {
            return GetDictionary(tableName, paramInt1, paramString1, paramDateTime1, paramGuid1, true);
        }
        public static DS_Dictionary.SP_GetDictionaryDataTable GetDictionary(ObjectNames tableName, int paramInt1, string paramString1, DateTime paramDateTime1, Guid paramGuid1, bool isOnline)
        {
            return GetDictionary(tableName, paramInt1, paramString1, paramDateTime1, paramGuid1, 0, string.Empty, DateTime.Now, Guid.Empty, isOnline);
        }
        public static DS_Dictionary.SP_GetDictionaryDataTable GetDictionary(ObjectNames tableName, int paramInt1, string paramString1, DateTime paramDateTime1, Guid paramGuid1, int paramInt2, string paramString2, DateTime paramDateTime2, Guid paramGuid2)
        {
            return GetDictionary(tableName, paramInt1, paramString1, paramDateTime1, paramGuid1, paramInt2, paramString2, paramDateTime2, paramGuid2, true);
        }
        public static DS_Dictionary.SP_GetDictionaryDataTable GetDictionary(ObjectNames tableName, int paramInt1, string paramString1, DateTime paramDateTime1, Guid paramGuid1, int paramInt2, string paramString2, DateTime paramDateTime2, Guid paramGuid2, bool isOnline)
        {
            return Instance.GetDictionary((int)tableName, paramInt1, paramString1, paramDateTime1, paramGuid1, paramInt2, paramString2, paramDateTime2, paramGuid2, isOnline);
        }
        
        public static DS_Dictionary.SP_GetDictionaryIntDataTable GetDictionaryInt(ObjectNames tableName)
        {
            return GetDictionaryInt(tableName, true);
        }
        public static DS_Dictionary.SP_GetDictionaryIntDataTable GetDictionaryInt(ObjectNames tableName, int paramInt1)
        {
            return GetDictionaryInt(tableName, paramInt1, true);
        }
        public static DS_Dictionary.SP_GetDictionaryIntDataTable GetDictionaryInt(ObjectNames tableName, bool isOnline)
        {
            return GetDictionaryInt(tableName, 0, isOnline);
        }
        public static DS_Dictionary.SP_GetDictionaryIntDataTable GetDictionaryInt(ObjectNames tableName, int paramInt1, bool isOnline)
        {
            return GetDictionaryInt(tableName, paramInt1, string.Empty, DateTime.Now, Guid.Empty, isOnline);
        }
        public static DS_Dictionary.SP_GetDictionaryIntDataTable GetDictionaryInt(ObjectNames tableName, int paramInt1, string paramString1, DateTime paramDateTime1, Guid paramGuid1)
        {
            return GetDictionaryInt(tableName, paramInt1, paramString1, paramDateTime1, paramGuid1, true);
        }
        public static DS_Dictionary.SP_GetDictionaryIntDataTable GetDictionaryInt(ObjectNames tableName, int paramInt1, string paramString1, DateTime paramDateTime1, Guid paramGuid1, bool isOnline)
        {
            return GetDictionaryInt(tableName, paramInt1, paramString1, paramDateTime1, paramGuid1, 0, string.Empty, DateTime.Now, Guid.Empty, isOnline);
        }
        public static DS_Dictionary.SP_GetDictionaryIntDataTable GetDictionaryInt(ObjectNames tableName, int paramInt1, string paramString1, DateTime paramDateTime1, Guid paramGuid1, int paramInt2, string paramString2, DateTime paramDateTime2, Guid paramGuid2)
        {
            return GetDictionaryInt(tableName, paramInt1, paramString1, paramDateTime1, paramGuid1, paramInt2, paramString2, paramDateTime2, paramGuid2, true);
        }
        public static DS_Dictionary.SP_GetDictionaryIntDataTable GetDictionaryInt(ObjectNames tableName, int paramInt1, string paramString1, DateTime paramDateTime1, Guid paramGuid1, int paramInt2, string paramString2, DateTime paramDateTime2, Guid paramGuid2, bool isOnline)
        {
            return Instance.GetDictionaryInt((int)tableName, paramInt1, paramString1, paramDateTime1, paramGuid1, paramInt2, paramString2, paramDateTime2, paramGuid2, isOnline);
        }


        public static DS_Dictionary.SP_GetButtonBrowseDataTable GetButtonBrowse(ObjectNames tableName, int paramInt, string paramString, Guid paramGuid, DateTime paramDateTime)
        {
            return GetButtonBrowse(tableName, paramInt, paramString, paramGuid, paramDateTime, true);
        }
        public static DS_Dictionary.SP_GetButtonBrowseDataTable GetButtonBrowse(ObjectNames tableName, int paramInt, string paramString, Guid paramGuid, DateTime paramDateTime, bool isOnline)
        {
            return Instance.GetButtonBrowse((int)tableName, paramInt, paramString, paramGuid, paramDateTime, isOnline);
        }

        public static int ActionRecord(ObjectNames tableName, int paramInt1, string paramString1, DateTime paramDateTime1, Guid paramGuid1, int paramInt2, string paramString2, DateTime paramDateTime2, Guid paramGuid2, DatabaseAction action, int modifiedUserID, bool isOnline)
        {
            return Instance.ActionRecord((int)tableName, paramInt1, paramString1, paramDateTime1, paramGuid1, paramInt2, paramString2, paramDateTime2, paramGuid2, (int)action, modifiedUserID, isOnline);
        }
        public static int Import(ObjectNames tableName, int modifierUserID, byte[] b)
        {
            return Instance.Import((int)tableName, modifierUserID, b);
        }




        public static DS_Dictionary.SP_GetDictionaryDataTable GetProductLine()
        {
            var table = new DS_Dictionary.SP_GetDictionaryDataTable();
            table.AddSP_GetDictionaryRow("R ", "R ", "გზა");
            table.AddSP_GetDictionaryRow("M ", "M ", "მთა");
            table.AddSP_GetDictionaryRow("T ", "T ", "ტურისტული");
            table.AddSP_GetDictionaryRow("S ", "S ", "სტანდარტული");
            return table;
        }
        public static DS_Dictionary.SP_GetDictionaryDataTable GetClass()
        {
            var table = new DS_Dictionary.SP_GetDictionaryDataTable();
            table.AddSP_GetDictionaryRow("H ", "H ", "მაღალი");
            table.AddSP_GetDictionaryRow("M ", "M ", "საშუალო");
            table.AddSP_GetDictionaryRow("L ", "L ", "დაბალი");
            return table;
        }
        public static DS_Dictionary.SP_GetDictionaryDataTable GetStyle()
        {
            var table = new DS_Dictionary.SP_GetDictionaryDataTable();
            table.AddSP_GetDictionaryRow("W ", "W ", "ქალის");
            table.AddSP_GetDictionaryRow("M ", "M ", "კაცის");
            table.AddSP_GetDictionaryRow("U ", "U ", "უნივერსალური");
            return table;
        }

        public static DS_Dictionary.SP_GetBankDataTable GetBank(int bankID)
        {
            return Instance.GetBank(bankID);
        }
        public static int AddOrEditBank(int bankID, string name, string bankCode, DatabaseStatus status, int modifiedUserID, DateTime modifiedDate, int approverUserID, DatabaseAction action)
        {
            return Instance.AddOrEditBank(bankID, name, bankCode, (int)status, modifiedUserID, modifiedDate, approverUserID, (int)action);
        }
        public static bool IsValidBankName(int bankID, string name)
        {
            return Instance.IsValidBankName(bankID, name);
        }
        public static bool IsValidBankCode(int bankID, string bankCode)
        {
            return Instance.IsValidBankCode(bankID, bankCode);
        }


        public static DS_Dictionary.SP_GetCountryDataTable GetCountry(string countryCode)
        {
            return Instance.GetCountry(countryCode);
        }
        public static bool IsValidCountryCode(string countryCodeOld, string countryCodeNew)
        {
            return Instance.IsValidCountryCode(countryCodeOld, countryCodeNew);
        }
        public static bool IsValidCountryName(string countryCodeOld, string name)
        {
            return Instance.IsValidCountryName(countryCodeOld, name);
        }
        public static int AddOrEditCountry(string countryCodeOld, string countryCodeNew, string name, DatabaseStatus status, int modifiedUserID, DateTime modifiedDate, int approverUserID, DatabaseAction action)
        {

            return Instance.AddOrEditCountry(countryCodeOld, countryCodeNew, name, (int)status, modifiedUserID, modifiedDate, approverUserID, (int)action);
        }


        public static DS_Currency.DD_CurrencyDataTable GetCurrencies()
        {
            return GetCurrencies(GetDictionary(ObjectNames.CurrencyWithLastRate));
        }
        public static DS_Currency.DD_CurrencyDataTable GetCurrencies(DS_Dictionary.SP_GetDictionaryDataTable table)
        {
            var result = new DS_Currency.DD_CurrencyDataTable();
            foreach (var row in table)
                result.AddDD_CurrencyRow(result.Count + 1, row.ID, NumToStrHelper.ToCurrencyName(row.ID), NumToStrHelper.ToCurrencyMinorUnit(row.ID), NumToStrHelper.ToCurrencySymbol(row.ID), ConvertHelper.ToDecimal(row[table.CodeColumn]));

            return result;
        }
        public static DS_Currency.SP_GetCurrencyDataTable GetCurrency(string currencyCode)
        {
            return Instance.GetCurrency(currencyCode);
        }
        public static bool IsValidCurrencyCode(string currencyCodeOld, string currencyCodeNew)
        {
            return Instance.IsValidCurrencyCode(currencyCodeOld, currencyCodeNew);
        }
        public static bool IsValidCurrencyName(string currencyCode, string name)
        {
            return Instance.IsValidCurrencyName(currencyCode, name);
        }
        public static int AddOrEditCurrency(string currencyCodeOld, string currencyCodeNew, string name, string coin, decimal averageRate, int position, DatabaseStatus status, int modifiedUserID, DateTime modifiedDate, int approverUserID, DatabaseAction action)
        {
            return Instance.AddOrEditCurrency(currencyCodeOld, currencyCodeNew, name, coin, averageRate, position, (int)status, modifiedUserID, modifiedDate, approverUserID, (int)action);
        }


        public static DS_CurrencyRate.SP_GetCurrencyRateDataTable GetCurrencyRate(int currencyRateID)
        {
            return Instance.GetCurrencyRate(currencyRateID);
        }
        public static decimal GetCurrencyRate(string currencyCode, DateTime date)
        {
            return GetCurrencyRate(currencyCode, date, true);
        }
        public static decimal GetCurrencyRate(string currencyCode, DateTime date, bool isOnline)
        {
            return Instance.GetCurrencyRate(currencyCode, date, isOnline);
        }
        public static bool IsValidCurrencyRateDate(int currencyRateID, string currencyCode, DateTime date)
        {
            return Instance.IsValidCurrencyRateDate(currencyRateID, currencyCode, date);
        }
        public static int AddOrEditCurrencyRate(int currencyRateID, string currencyCode, DateTime startDate, DateTime endDate, decimal averageRate, int Events, DatabaseStatus status, int modifiedUserID, DateTime modifiedDate, int approverUserID, DatabaseAction action)
        {
            return Instance.AddOrEditCurrencyRate(currencyRateID, currencyCode, startDate, endDate, averageRate, Events, (int)status, modifiedUserID, modifiedDate, approverUserID, (int)action);
        }


        public static DS_Dictionary.SP_GetMedicamentCategoryDataTable GetMedicamentCategory(int medicamentCategoryID)
        {
            return Instance.GetMedicamentCategory(medicamentCategoryID);
        }
        public static bool IsValidMedicamentCategoryName(int medicamentCategoryID, string name)
        {
            return Instance.IsValidMedicamentCategoryName(medicamentCategoryID, name);
        }
        public static int AddOrEditMedicamentCategory(int medicamentCategoryID, string name, DatabaseStatus status, int modifiedUserID, DateTime modifiedDate, int approverUserID, DatabaseAction action)
        {
            return Instance.AddOrEditMedicamentCategory(medicamentCategoryID, name, (int)status, modifiedUserID, modifiedDate, approverUserID, (int)action);
        }


        public static DS_Dictionary.SP_GetMedicamentSubcategoryDataTable GetMedicamentSubcategory(int medicamentSubcategoryID)
        {
            return Instance.GetMedicamentSubcategory(medicamentSubcategoryID);
        }
        public static bool IsValidMedicamentSubcategoryName(int medicamentSubcategoryID, int medicamentCategoryID, string name)
        {
            return Instance.IsValidMedicamentSubcategoryName(medicamentSubcategoryID, medicamentSubcategoryID, name);
        }
        public static int AddOrEditMedicamentSubcategory(int medicamentSubcategoryID, int medicamentCategoryID, string name, DatabaseStatus status, int modifiedUserID, DateTime modifiedDate, int approverUserID, DatabaseAction action)
        {
            return Instance.AddOrEditMedicamentSubcategory(medicamentSubcategoryID, medicamentCategoryID, name, (int)status, modifiedUserID, modifiedDate, approverUserID, (int)action);
        }


        public static DS_Medicament.SP_GetMedicamentDataTable GetMedicament(int medicamentID)
        {
            return Instance.GetMedicament(medicamentID);
        }
        public static bool IsValidMedicamentName(int medicamentID, string name)
        {
            return Instance.IsValidMedicamentName(medicamentID, name);
        }
        public static bool IsValidProductNumber(int medicamentID, string productNumber)
        {
            return Instance.IsValidProductNumber(medicamentID, productNumber);
        }
        public static int AddOrEditMedicament(int medicamentID, int medicamentSubcategoryID, string name, string productNumber, bool makeFlag, bool finishedGoodsFlag, string color, short safetyStockLevel, short reorderPoint, decimal standardCost, decimal listPrice, decimal dealerPrice, string productCurrencyCode, decimal discountPct, decimal taxRate, string size, string sizeRange, string sizeUnitMeasureCode, decimal weight, string weightUnitMeasureCode, int daysToManufacture, string productLine, string _class, string style, int productModelID, DateTime sellStartDate, DateTime sellEndDate, DateTime discontinuedDate, short unitsInStock, DateTime validDate, int genericID, string countryCode, int brandID, string serie, bool autoUpdateProducts, DatabaseStatus status, int modifiedUserID, DateTime modifiedDate, int approverUserID, DatabaseAction action)
        {
            return Instance.AddOrEditMedicament(medicamentID, medicamentSubcategoryID, name, productNumber, makeFlag, finishedGoodsFlag, color, safetyStockLevel, reorderPoint, standardCost, listPrice, dealerPrice, productCurrencyCode, discountPct, taxRate, size, sizeRange, sizeUnitMeasureCode, weight, weightUnitMeasureCode, daysToManufacture, productLine, _class, style, productModelID, sellStartDate, sellEndDate, discontinuedDate, unitsInStock, validDate, genericID, countryCode, brandID, serie, autoUpdateProducts, (int)status, modifiedUserID, modifiedDate, approverUserID, (int)action);
        }


        public static DS_Dictionary.SP_GetPaymentMethodDataTable GetPaymentMethod(int paymentMethodID)
        {
            return Instance.GetPaymentMethod(paymentMethodID);
        }
        public static bool IsValidPaymentMethodName(int paymentMethodID, string name)
        {
            return Instance.IsValidPaymentMethodName(paymentMethodID, name);
        }
        public static int AddOrEditPaymentMethod(int paymentMethodID, string name, DatabaseStatus status, int modifiedUserID, DateTime modifiedDate, int approverUserID, DatabaseAction action)
        {
            return Instance.AddOrEditPaymentMethod(paymentMethodID, name, (int)status, modifiedUserID, modifiedDate, approverUserID, (int)action);
        }


        public static DS_Dictionary.SP_GetUnitMeasureDataTable GetUnitMeasure(string unitMeasureCode)
        {
            return Instance.GetUnitMeasure(unitMeasureCode);
        }
        public static bool IsValidUnitMeasureCode(string unitMeasureCodeOld, string unitMeasureCodeNew)
        {
            return Instance.IsValidUnitMeasureCode(unitMeasureCodeOld, unitMeasureCodeNew);
        }
        public static bool IsValidUnitMeasureName(string unitMeasureCode, string name)
        {
            return Instance.IsValidUnitMeasureName(unitMeasureCode, name);
        }
        public static int AddOrEditUnitMeasure(string unitMeasureCodeOld, string unitMeasureCodeNew, string name, DatabaseStatus status, int modifiedUserID, DateTime modifiedDate, int approverUserID, DatabaseAction action)
        {
            return Instance.AddOrEditUnitMeasure(unitMeasureCodeOld, unitMeasureCodeNew, name, (int)status, modifiedUserID, modifiedDate, approverUserID, (int)action);
        }

        public static DS_Dictionary.SP_GetMedicamentsDataTable GetMedicaments()
        {
            return GetMedicaments(0, string.Empty, 0, string.Empty, 0, string.Empty, DatabaseStatus.None);
        }
        public static DS_Dictionary.SP_GetMedicamentsDataTable GetMedicaments(int medicamentID, string medicamentName, int medicamentCategoryID, string medicamentCategoryName, int medicamentSubcategoryID, string medicamentSubcategoryName, DatabaseStatus status)
        {
            return Instance.GetMedicaments(medicamentID, medicamentName, medicamentCategoryID, medicamentCategoryName, medicamentSubcategoryID, medicamentSubcategoryName, (int)status);
        }


        public static DS_Dictionary.SP_GetBrandDataTable GetBrand(int brandID)
        {
            return Instance.GetBrand(brandID);
        }
        public static bool IsValidBrandName(int brandID, string name)
        {
            return Instance.IsValidBrandName(brandID, name);
        }
        public static int AddOrEditBrand(int brandID, string name, DatabaseStatus status, int modifiedUserID, DateTime modifiedDate, int approverUserID, DatabaseAction action)
        {
            return Instance.AddOrEditBrand(brandID, name, (int)status, modifiedUserID, modifiedDate, approverUserID, (int)action);
        }

        public static DS_Dictionary.SP_GetMergeMedicamentDataTable GetMergeMedicament(int fromMedicamentID)
        {
            return Instance.GetMergeMedicament(fromMedicamentID);
        }

        public static DS_Dictionary.SP_GetGenericDataTable GetGeneric(int genericID)
        {
            return Instance.GetGeneric(genericID);
        }
        public static bool IsValidGenericName(int genericID, string name)
        {
            return Instance.IsValidGenericName(genericID, name);
        }
        public static int AddOrEditGeneric(int genericID, string name, DatabaseStatus status, int modifiedUserID, DateTime modifiedDate, int approverUserID, DatabaseAction action)
        {
            return Instance.AddOrEditGeneric(genericID, name, (int)status, modifiedUserID, modifiedDate, approverUserID, (int)action);
        }
    }
}
