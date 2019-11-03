using System;
using System.Data;
using System.Data.SqlClient;
using Apothex.DataType;

namespace Apothex.Contracts.Dictionary
{
    internal interface IDictionary
    {
        DataTable GetDataTable(SqlCommand cmd, bool isOnline);

        DS_Dictionary.SP_GetDictionaryDataTable GetDictionary(int tableID, int paramInt1, string paramString1, DateTime paramDateTime1, Guid paramGuid1, int paramInt2, string paramString2, DateTime paramDateTime2, Guid paramGuid2, bool isOnline);
        DS_Dictionary.SP_GetDictionaryIntDataTable GetDictionaryInt(int tableID, int paramInt1, string paramString1, DateTime paramDateTime1, Guid paramGuid1, int paramInt2, string paramString2, DateTime paramDateTime2, Guid paramGuid2, bool isOnline);
        DS_Dictionary.SP_GetButtonBrowseDataTable GetButtonBrowse(int tableID, int paramInt, string paramString, Guid paramGuid, DateTime paramDateTime, bool isOnline);
        int ActionRecord(int tableID, int paramInt1, string paramString1, DateTime paramDateTime1, Guid paramGuid1, int paramInt2, string paramString2, DateTime paramDateTime2, Guid paramGuid2, int action, int modifiedUserID, bool isOnline);
        
        int Import(int tableID, int modifierUserID, byte[] b);

        DS_Dictionary.SP_GetBankDataTable GetBank(int bankID);
        int AddOrEditBank(int bankID, string name, string bankCode, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int cction);
        bool IsValidBankName(int bankID, string name);
        bool IsValidBankCode(int bankID, string bankCode);

        DS_Dictionary.SP_GetCountryDataTable GetCountry(string countryCode);
        bool IsValidCountryCode(string countryCodeOld, string countryCodeNew);
        bool IsValidCountryName(string countryCodeOld, string name);
        int AddOrEditCountry(string countryCodeOld, string countryCodeNew, string name, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action);

        DS_Currency.SP_GetCurrencyDataTable GetCurrency(string currencyCode);
        bool IsValidCurrencyCode(string countryCodeOld, string countryCodeNew);
        bool IsValidCurrencyName(string currencyCode, string name);
        int AddOrEditCurrency(string currencyCodeOld, string currencyCodeNew, string name, string coin, decimal averageRate, int position, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action);

        DS_CurrencyRate.SP_GetCurrencyRateDataTable GetCurrencyRate(int currencyRateID);
        decimal GetCurrencyRate(string currencyCode, DateTime date, bool isOnline);
        bool IsValidCurrencyRateDate(int currencyRateID, string currencyCode, DateTime date);
        int AddOrEditCurrencyRate(int currencyRateID, string currencyCode, DateTime startDate, DateTime endDate, decimal averageRate, int Events, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action);

        DS_Dictionary.SP_GetMedicamentCategoryDataTable GetMedicamentCategory(int medicamentCategoryID);
        bool IsValidMedicamentCategoryName(int medicamentCategoryID, string name);
        int AddOrEditMedicamentCategory(int medicamentCategoryID, string name, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action);

        DS_Dictionary.SP_GetMedicamentSubcategoryDataTable GetMedicamentSubcategory(int medicamentSubcategoryID);
        bool IsValidMedicamentSubcategoryName(int medicamentSubcategoryID, int medicamentCategoryID, string name);
        int AddOrEditMedicamentSubcategory(int medicamentSubcategoryID, int medicamentCategoryID, string name, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action);

        DS_Medicament.SP_GetMedicamentDataTable GetMedicament(int medicamentID);
        bool IsValidMedicamentName(int medicamentID, string name);
        bool IsValidProductNumber(int medicamentID, string productNumber);
        int AddOrEditMedicament(int medicamentID, int medicamentSubcategoryID, string name, string productNumber, bool makeFlag, bool finishedGoodsFlag, string color, short safetyStockLevel, short reorderPoint, decimal standardCost, decimal listPrice, decimal dealerPrice, string productCurrencyCode, decimal discountPct, decimal taxRate, string size, string sizeRange, string sizeUnitMeasureCode, decimal weight, string weightUnitMeasureCode, int daysToManufacture, string productLine, string _class, string style, int productModelID, DateTime sellStartDate, DateTime sellEndDate, DateTime discontinuedDate, short unitsInStock, DateTime validDate, int genericID, string countryCode, int brandID, string serie, bool autoUpdateProducts, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action);

        DS_Dictionary.SP_GetPaymentMethodDataTable GetPaymentMethod(int paymentMethodID);
        bool IsValidPaymentMethodName(int paymentMethodID, string name);
        int AddOrEditPaymentMethod(int paymentMethodID, string name, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action);

        DS_Dictionary.SP_GetUnitMeasureDataTable GetUnitMeasure(string unitMeasureCode);
        bool IsValidUnitMeasureCode(string unitMeasureCodeOld, string unitMeasureCodeNew);
        bool IsValidUnitMeasureName(string unitMeasureCode, string name);
        int AddOrEditUnitMeasure(string unitMeasureCodeOld, string unitMeasureCodeNew, string name, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action);

        DS_Dictionary.SP_GetMedicamentsDataTable GetMedicaments(int medicamentID, string medicamentName, int medicamentCategoryID, string medicamentCategoryName, int medicamentSubcategoryID, string medicamentSubcategoryName, int status);

        DS_Dictionary.SP_GetBrandDataTable GetBrand(int brandID);
        bool IsValidBrandName(int brandID, string name);
        int AddOrEditBrand(int brandID, string name, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action);

        DS_Dictionary.SP_GetMergeMedicamentDataTable GetMergeMedicament(int fromMedicamentID);


        DS_Dictionary.SP_GetGenericDataTable GetGeneric(int genericID);
        bool IsValidGenericName(int genericID, string name);
        int AddOrEditGeneric(int genericID, string name, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action);
    }
}