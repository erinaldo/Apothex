using System;
using Apothex.Configuration;
using Apothex.Contracts.Person;
using Apothex.DataType;
using Apothex.SqlDataAccess.Person;
using Zek.Data;

namespace Apothex.DataManagment.Person
{
    public static class PersonManager
    {
        #region Instance
        private static object sync = new object();
        private static PersonProvider _Instance;
        private static PersonProvider Instance
        {
            get
            {
                if (_Instance == null)
                {
                    lock (sync)
                    {
                        if (_Instance == null)
                        {
                            switch (ConfigurationManagerEx.PersonProvider)
                            {
                                case "WebService":
                                case "SqlDataBase":
                                default: //SqlDataBase
                                    _Instance = new SqlPersonProvider();
                                    break;
                            }
                        }
                    }
                }
                return _Instance;
            }
        }
        #endregion

        public static DS_Person.SP_GetCompanyDataTable GetCompany(int companyID)
        {
            return Instance.GetCompany(companyID);
        }
        public static bool IsValidCompanyName(int companyID, string name)
        {
            return Instance.IsValidCompanyName(companyID, name);
        }
        public static int AddOrEditCompany(int companyID, string name, string taxCode, string phone, string fax, string countryCode, string address, int bankID, string bankAccountNumber, string note, byte status, int modifiedUserID, DateTime modifiedDate, int approverUserID, byte action)
        {
            return Instance.AddOrEditCompany(companyID, name, taxCode, phone, fax, countryCode, address, bankID, bankAccountNumber, note, status, modifiedUserID, modifiedDate, approverUserID, action);
        }

        public static DS_Person.SP_GetMyCompanyDataTable GetMyCompany(int myCompanyID, bool isOnline)
        {
            return Instance.GetMyCompany(myCompanyID, isOnline);
        }
        public static int AddOrEditMyCompany(int myCompanyID, string name, string taxCode, string directorName, string countryCode, string city, string postalCode, string address, string phone, string fax, int bankID, string bankAccountNumber, bool vatPayerFlag, string conditionalUnitCurrencyCode, string defaultTradingCurrencyCode, int modifiedUserID, DateTime modifiedDate, DatabaseAction action)
        {
            return Instance.AddOrEditMyCompany(myCompanyID, name, taxCode, directorName, countryCode, city, postalCode, address, phone, fax, bankID, bankAccountNumber, vatPayerFlag, conditionalUnitCurrencyCode, defaultTradingCurrencyCode, modifiedUserID, modifiedDate, (int)action);
        }

        public static DS_Person.T_PersonDataTable GetPerson(int? id)
        {
            return Instance.GetPerson(id);
        }
        public static DS_Person.T_PersonDataTable GetPersonByUserID(int? id)
        {
            var personID = FindPersonID(id);
            if (personID != 0)
                return GetPerson(personID);
            else
                return new DS_Person.T_PersonDataTable();
        }
        public static int AddOrEditPerson(int id, string firstName, string lastName, string personalNumber, int personCategoryID, string city, string address, string jobTitle, DateTime birthDate, string phone, string mobile, string email, int modifierID, DatabaseAction action)
        {
            return Instance.AddOrEditPerson(id, firstName, lastName, personalNumber, personCategoryID, city, address, jobTitle, birthDate, phone, mobile, email, modifierID, (int)action);
        }
        public static int FindPersonID(int? userID)
        {
            return Instance.FindPersonID(userID);
        }

        public static DS_Person.SP_GetPersonCategoryDataTable GetPersonCategory(int id)
        {
            return Instance.GetPersonCategory(id);
        }
        public static bool IsValidPersonCategoryName(int id, string name)
        {
            return Instance.IsValidPersonCategoryName(id, name);
        }
        public static int AddOrEditPersonCategory(int id, string name, int modifierID, DatabaseAction action)
        {
            return Instance.AddOrEditPersonCategory(id, name, modifierID, (int)action);
        }
    }
}
