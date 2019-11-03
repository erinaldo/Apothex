using System;
using Apothex.DataType.DS_PersonTableAdapters;
using Apothex.Contracts.Person;
using Apothex.DataType;
using Apothex.Configuration;


namespace Apothex.SqlDataAccess.Person
{
    public sealed class SqlPersonProvider : PersonProvider
    {
        public override DS_Person.SP_GetCompanyDataTable GetCompany(int companyID)
        {
            using (var adapter = SP_GetCompanyTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(companyID);
            }
        }
        public override bool IsValidCompanyName(int companyID, string name)
        {
            using (var adapter = PersonQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_IsValidCompanyName(companyID, name);
            }
        }
        public override int AddOrEditCompany(int companyID, string name, string taxCode, string phone, string fax, string countryCode, string address, int bankID, string bankAccountNumber, string note, byte status, int modifiedUserID, DateTime modifiedDate, int approverUserID, byte action)
        {
            using (var adapter = PersonQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_AddOrEditCompany(companyID, name, taxCode, phone, fax, countryCode, address, bankID, bankAccountNumber, note, status, modifiedUserID, modifiedDate, approverUserID, action);
            }
        }

        public override DS_Person.SP_GetMyCompanyDataTable GetMyCompany(int myCompanyID, bool isOnline)
        {
            var connectionString = (isOnline ? ConfigurationManagerEx.ConnectionString : ConfigurationManagerEx.OfflineConnectionString);
            var commandTimeout = (isOnline ? ConfigurationManagerEx.CommandTimeout : ConfigurationManagerEx.OfflineCommandTimeout);
            using (var adapter = SP_GetMyCompanyTableAdapter.CreateInstance(connectionString, commandTimeout))
            {
                return adapter.GetData(myCompanyID);
            }
        }
        public override int AddOrEditMyCompany(int myCompanyID, string name, string taxCode, string directorName, string countryCode, string city, string postalCode, string address, string phone, string fax, int bankID, string bankAccountNumber, bool vatPayerFlag, string conditionalUnitCurrencyCode, string defaultTradingCurrencyCode, int modifiedUserID, DateTime modifiedDate, int action)
        {
            using (var adapter = PersonQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_AddOrEditMyCompany(myCompanyID, name, taxCode, directorName, countryCode, city, postalCode, address, phone, fax, bankID, bankAccountNumber, vatPayerFlag, conditionalUnitCurrencyCode, defaultTradingCurrencyCode, modifiedUserID, modifiedDate, action);
            }
        }

        public override DS_Person.T_PersonDataTable GetPerson(int? id)
        {
            using (var adapter = T_PersonTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(id);
            }
        }
        public override int AddOrEditPerson(int id, string firstName, string lastName, string personalNumber, int personCategoryID, string city, string address, string jobTitle, DateTime birthDate, string phone, string mobile, string email, int modifierID, int action)
        {
            using (var adapter = PersonQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_AddOrEditPerson(id, firstName, lastName, personalNumber, personCategoryID, city, address, jobTitle, birthDate, phone, mobile, email, modifierID, action);
            }
        }
        public override int FindPersonID(int? userID)
        {
            using (var adapter = PersonQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_FindPersonID(userID);
            }
        }

        public override DS_Person.SP_GetPersonCategoryDataTable GetPersonCategory(int id)
        {
            using (var adapter = SP_GetPersonCategoryTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(id);
            }
        }
        public override bool IsValidPersonCategoryName(int id, string name)
        {
            using (var adapter = PersonQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_IsValidPersonCategoryName(id,name);
            }
        }
        public override int AddOrEditPersonCategory(int id, string name, int modifierID, int action)
        {
            using (var adapter = PersonQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_AddOrEditPersonCategory(id, name, modifierID, action);
            }
        }
    }
}
