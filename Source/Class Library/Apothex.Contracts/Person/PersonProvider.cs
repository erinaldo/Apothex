using System;
using Apothex.DataType;

namespace Apothex.Contracts.Person
{
    public abstract class PersonProvider : IPerson
    {
        public abstract DS_Person.SP_GetCompanyDataTable GetCompany(int companyID);
        public abstract bool IsValidCompanyName(int companyID, string name);
        public abstract int AddOrEditCompany(int companyID, string name, string taxCode, string phone, string fax, string countryCode, string address, int bankID, string bankAccountNumber, string note, byte status, int modifiedUserID, DateTime modifiedDate, int approverUserID, byte action);

        public abstract DS_Person.SP_GetMyCompanyDataTable GetMyCompany(int myCompanyID, bool isOnline);
        public abstract int AddOrEditMyCompany(int myCompanyID, string name, string taxCode, string directorName, string countryCode, string city, string postalCode, string address, string phone, string fax, int bankID, string bankAccountNumber, bool vatPayerFlag, string conditionalUnitCurrencyCode, string defaultTradingCurrencyCode, int modifiedUserID, DateTime modifiedDate, int action);

        public abstract DS_Person.T_PersonDataTable GetPerson(int? id);
        public abstract int AddOrEditPerson(int id, string firstName, string lastName, string personalNumber, int personCategoryID, string city, string address, string jobTitle, DateTime birthDate, string phone, string mobile, string email, int modifierID, int action);
        public abstract int FindPersonID(int? userID);

        public abstract DS_Person.SP_GetPersonCategoryDataTable GetPersonCategory(int id);
        public abstract bool IsValidPersonCategoryName(int id, string name);
        public abstract int AddOrEditPersonCategory(int id, string name, int modifierID, int action);

    }
}
