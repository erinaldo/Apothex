using System;
using System.Data;
using System.Data.SqlClient;
using Apothex.DataType;

namespace Apothex.Contracts.Dictionary
{
    public abstract class DictionaryProvider : IDictionary
    {
        public abstract DataTable GetDataTable(SqlCommand cmd, bool isOnline);

        public abstract DS_Dictionary.SP_GetDictionaryDataTable GetDictionary(int tableID, int paramInt1, string paramString1, DateTime paramDateTime1, Guid paramGuid1, int paramInt2, string paramString2, DateTime paramDateTime2, Guid paramGuid2, bool isOnline);
        public abstract DS_Dictionary.SP_GetDictionaryIntDataTable GetDictionaryInt(int tableID, int paramInt1, string paramString1, DateTime paramDateTime1, Guid paramGuid1, int paramInt2, string paramString2, DateTime paramDateTime2, Guid paramGuid2, bool isOnline);
        public abstract DS_Dictionary.SP_GetButtonBrowseDataTable GetButtonBrowse(int tableID, int paramInt, string paramString, Guid paramGuid, DateTime paramDateTime, bool isOnline);
        public abstract int ActionRecord(int tableID, int paramInt1, string paramString1, DateTime paramDateTime1, Guid paramGuid1, int paramInt2, string paramString2, DateTime paramDateTime2, Guid paramGuid2, int action, int modifiedUserID, bool isOnline);
        
        public abstract int Import(int tableID, int modifierUserID, byte[] b);

        public abstract DS_Dictionary.SP_GetBankDataTable GetBank(int bankID);
        public abstract int AddOrEditBank(int bankID, string name, string bankCode, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action);
        public abstract bool IsValidBankName(int bankID, string name);
        public abstract bool IsValidBankCode(int bankID, string bankCode);

        public abstract DS_Dictionary.SP_GetCountryDataTable GetCountry(string countryCode);
        public abstract bool IsValidCountryCode(string countryCodeOld, string countryCodeNew);
        public abstract bool IsValidCountryName(string countryCodeOld, string name);
        public abstract int AddOrEditCountry(string countryCodeOld, string countryCodeNew, string name, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action);

        public abstract DS_Currency.SP_GetCurrencyDataTable GetCurrency(string currencyCode);
        public abstract bool IsValidCurrencyCode(string currencyCodeOld, string currencyCodeNew);
        public abstract bool IsValidCurrencyName(string currencyCode, string name);
        public abstract int AddOrEditCurrency(string currencyCodeOld, string currencyCodeNew, string name, string coin, decimal averageRate, int position, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action);

        public abstract DS_CurrencyRate.SP_GetCurrencyRateDataTable GetCurrencyRate(int currencyRateID);
        public abstract decimal GetCurrencyRate(string currencyCode, DateTime date, bool isOnline);
        public abstract bool IsValidCurrencyRateDate(int currencyRateID, string currencyCode, DateTime date);
        public abstract int AddOrEditCurrencyRate(int currencyRateID, string currencyCode, DateTime startDate, DateTime endDate, decimal averageRate, int Events, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action);

        public abstract DS_Dictionary.SP_GetMedicamentCategoryDataTable GetMedicamentCategory(int medicamentCategoryID);
        public abstract bool IsValidMedicamentCategoryName(int medicamentCategoryID, string name);
        public abstract int AddOrEditMedicamentCategory(int medicamentCategoryID, string name, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action);

        public abstract DS_Dictionary.SP_GetMedicamentSubcategoryDataTable GetMedicamentSubcategory(int medicamentSubcategoryID);
        public abstract bool IsValidMedicamentSubcategoryName(int medicamentSubcategoryID, int medicamentCategoryID, string name);
        public abstract int AddOrEditMedicamentSubcategory(int medicamentSubcategoryID, int medicamentCategoryID, string name, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action);

        public abstract DS_Medicament.SP_GetMedicamentDataTable GetMedicament(int medicamentID);
        public abstract bool IsValidMedicamentName(int medicamentID, string name);
        public abstract bool IsValidProductNumber(int medicamentID, string productNumber);
        public abstract int AddOrEditMedicament(int medicamentID, int medicamentSubcategoryID, string name, string productNumber, bool makeFlag, bool finishedGoodsFlag, string color, short safetyStockLevel, short reorderPoint, decimal standardCost, decimal listPrice, decimal dealerPrice, string productCurrencyCode, decimal discountPct, decimal taxRate, string size, string sizeRange, string sizeUnitMeasureCode, decimal weight, string weightUnitMeasureCode, int daysToManufacture, string productLine, string _class, string style, int productModelID, DateTime sellStartDate, DateTime sellEndDate, DateTime discontinuedDate, short unitsInStock, DateTime validDate, int genericID, string countryCode, int brandID, string serie, bool autoUpdateProducts, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action);

        public abstract DS_Dictionary.SP_GetPaymentMethodDataTable GetPaymentMethod(int paymentMethodID);
        public abstract bool IsValidPaymentMethodName(int paymentMethodID, string name);
        public abstract int AddOrEditPaymentMethod(int paymentMethodID, string name, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action);

        public abstract DS_Dictionary.SP_GetUnitMeasureDataTable GetUnitMeasure(string unitMeasureCode);
        public abstract bool IsValidUnitMeasureCode(string unitMeasureCodeOld, string unitMeasureCodeNew);
        public abstract bool IsValidUnitMeasureName(string unitMeasureCode, string name);
        public abstract int AddOrEditUnitMeasure(string unitMeasureCodeOld, string unitMeasureCodeNew, string name, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action);

        public abstract DS_Dictionary.SP_GetMedicamentsDataTable GetMedicaments(int medicamentID, string medicamentName, int medicamentCategoryID, string medicamentCategoryName, int medicamentSubcategoryID, string medicamentSubcategoryName, int status);

        public abstract DS_Dictionary.SP_GetBrandDataTable GetBrand(int brandID);
        public abstract bool IsValidBrandName(int brandID, string name);
        public abstract int AddOrEditBrand(int brandID, string name, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action);

        public abstract DS_Dictionary.SP_GetMergeMedicamentDataTable GetMergeMedicament(int fromMedicamentID);

        public abstract DS_Dictionary.SP_GetGenericDataTable GetGeneric(int genericID);
        public abstract bool IsValidGenericName(int genericID, string name);
        public abstract int AddOrEditGeneric(int genericID, string name, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action);
    }
}
