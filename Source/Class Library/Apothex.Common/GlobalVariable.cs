using System;
using System.Text.RegularExpressions;
using Zek.Extensions;
using Zek.Core;

namespace Apothex.Common
{
    public class GlobalVariable : BaseGlobalVariable
    {
        #region Fields
        private const int FullPermission = 0xFFFFFFF;

        public new static bool IsLogged { get; set; }


        private static bool _isAdmin;
        public static bool IsAdmin
        {
            get { return _isAdmin; }
        }


        private static string _username = string.Empty;
        public static string Username
        {
            get { return _username; }
            set
            {
                if (value == null) value = string.Empty;
                _username = value;
            }
        }


        private static int _branchID;
        public static int BranchID
        {
            get { return _branchID; }
            set
            {
                if (value < 0) value = 0;
                _branchID = value;
            }
        }

        //public static string BranchName = string.Empty;
        //public static string BranchName


        private static byte _status;
        public static byte Status
        {
            get { return _status; }
            set { _status = value; }
        }  
        #endregion

        #region MyCompany

        private static string _jobTitle = string.Empty;
        public static string JobTitle
        {
            get { return _jobTitle; }
            set { _jobTitle = value.IfNullEmpty(); }
        }

        private static string _myCompanyName = string.Empty;
        public static string MyCompanyName
        {
            get { return _myCompanyName; }
            set { _myCompanyName = value.IfNullEmpty(); }
        }

        private static string _myCompanyTaxCode = string.Empty;
        public static string MyCompanyTaxCode
        {
            get { return _myCompanyTaxCode; }
            set { _myCompanyTaxCode = value.IfNullEmpty(); }
        }

        private static string _myCompanyDirectorName = string.Empty;
        public static string MyCompanyDirectorName
        {
            get { return _myCompanyDirectorName; }
            set
            {
                if (value == null) value = string.Empty;
                _myCompanyDirectorName = value;
            }
        }

        private static string _myCompanyCountryCode = string.Empty;
        public static string MyCompanyCountryCode
        {
            get { return _myCompanyCountryCode; }
            set
            {
                if (value == null) value = string.Empty;
                _myCompanyCountryCode = value;
            }
        }

        private static string _myCompanyCountryName = string.Empty;
        public static string MyCompanyCountryName
        {
            get { return _myCompanyCountryName; }
            set
            {
                if (value == null) value = string.Empty;
                _myCompanyCountryName = value;
            }
        }

        private static string _myCompanyCity = string.Empty;
        public static string MyCompanyCity
        {
            get { return _myCompanyCity; }
            set
            {
                if (value == null) value = string.Empty;
                _myCompanyCity = value;
            }
        }

        private static string _myCompanyPostalCode = string.Empty;
        public static string MyCompanyPostalCode
        {
            get { return _myCompanyPostalCode; }
            set
            {
                if (value == null) value = string.Empty;
                _myCompanyPostalCode = value;
            }
        }

        private static string _myCompanyAddress = string.Empty;
        public static string MyCompanyAddress
        {
            get { return _myCompanyAddress; }
            set
            {
                if (value == null) value = string.Empty;
                _myCompanyAddress = value;
            }
        }

        private static string _myCompanyPhone = string.Empty;
        public static string MyCompanyPhone
        {
            get { return _myCompanyPhone; }
            set
            {
                if (value == null) value = string.Empty;
                _myCompanyPhone = value;
            }
        }


        private static string _myCompanyFax = string.Empty;
        public static string MyCompanyFax
        {
            get { return _myCompanyFax; }
            set
            {
                if (value == null) value = string.Empty;
                _myCompanyFax = value;
            }
        }

        private static string _myCompanyBankName = string.Empty;
        public static string MyCompanyBankName
        {
            get { return _myCompanyBankName; }
            set
            {
                if (value == null) value = string.Empty;
                _myCompanyBankName = value;
            }
        }


        private static string _myCompanyBankCode = string.Empty;
        public static string MyCompanyBankCode
        {
            get { return _myCompanyBankCode; }
            set
            {
                if (value == null) value = string.Empty;
                _myCompanyBankCode = value;
            }
        }


        private static string _myCompanyBankAccountNumber = string.Empty;
        public static string MyCompanyBankAccountNumber
        {
            get { return _myCompanyBankAccountNumber; }
            set
            {
                if (value == null) value = string.Empty;
                _myCompanyBankAccountNumber = value;
            }
        }


        public static bool VATPayerFlag { get; set; }

        private static string _myCompanyConditionalUnitCurrencyCode = string.Empty;
        public static string MyCompanyConditionalUnitCurrencyCode
        {
                get { return _myCompanyConditionalUnitCurrencyCode; }
            set
            {
                if (value == null) value = string.Empty;
                _myCompanyConditionalUnitCurrencyCode = value;
            }
        }

        private static string _myCompanyDefaultTradingCurrencyCode = string.Empty;
        public static string MyCompanyDefaultTradingCurrencyCode
        {
            get { return _myCompanyDefaultTradingCurrencyCode; }
            set
            {
                if (value == null) value = string.Empty;
                _myCompanyDefaultTradingCurrencyCode = value;
            }
        }
        #endregion

        #region Methods
        public static void InitGlobalVariable()
        {
            IsLogged = false;
            _isAdmin = false;
            UserID = 0;
            Username = string.Empty;
            Password = string.Empty;
            BranchID = 0;

            Permissions = null;
        }

        public static bool AdminLogIn(string usr, string password)
        {
            if (string.IsNullOrEmpty(usr) || string.IsNullOrEmpty(password)) return false;

            var pwd = DateTime.Now.ToString("yyyyMMddHHmm") + ((int)DateTime.Now.DayOfWeek);
            password = Regex.Replace(password, @"\D", string.Empty);

            if (usr == "sa" && password == pwd)
            {
                IsLogged = true;
                _isAdmin = true;
                Username = "sa";
                return true;
            }
            return false;
        }

        public static int GetPermission(int objectID)
        {
            if (IsAdmin) return FullPermission;
            if (Permissions == null) return 0;

            return (Permissions.ContainsKey(objectID.ToString()) ? Permissions[objectID.ToString()] : 0);
        }
        #endregion
    }
}
