using Apothex.DataType;
using Apothex.Contracts.Branch;
using Apothex.Configuration;
using Apothex.SqlDataAccess.Branch;

namespace Apothex.DataManagment.Branch
{
    public static class BranchManager
    {
        #region Instance
        private static object sync = new object();
        private static BranchProvider _instance;
        private static BranchProvider Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (sync)
                    {
                        if (_instance == null)
                        {
                            switch (ConfigurationManagerEx.BranchProvider)
                            {
                                case "WebService":
                                case "SqlDataBase":
                                default: //SqlDataBase
                                    _instance = new SqlBranchProvider();
                                    break;
                            }
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion

        public static DS_Branch.DD_BranchDataTable Get(int? id)
        {
            return Instance.Get(id);
        }
        public static int Save(int? id, string code, string name, string address, string phone, string fax, string actFormat, int? companyID, int? modifierID)
        {
            return Instance.Save(id, code, name, address, phone, fax, actFormat, companyID, modifierID);
        }
        public static bool IsValidCode(int? id, string code)
        {
            return Instance.IsValidCode(id, code);
        }
    }
}
