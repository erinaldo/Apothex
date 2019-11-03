using System;
using Apothex.Contracts.CardPointTransfer;
using Apothex.Configuration;
using Apothex.SqlDataAccess.CardPointTransfer;
using Apothex.DataType;

namespace Apothex.DataManagment.CardPointTransfer
{
    public static class CardPointTransferManager
    {
        #region Fields
        private static object sync = new object();
        private static CardPointTransferProvider _instance;
        private static CardPointTransferProvider Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (sync)
                    {
                        if (_instance == null)
                        {
                            switch (ConfigurationManagerEx.CardPointTransferProvider)
                            {
                                case "WebService":
                                case "SqlDataBase":
                                default:
                                    _instance = new SqlCardPointTransferProvider();
                                    break;
                            }
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion




        public static DS_CardPointTransfer.T_PointTransferHeaderDataTable GetHeader(int? id)
        {
            return Instance.GetHeader(id);
        }

        public static DS_CardPointTransfer.VW_PointTransferDetailDataTable GetDetail(int? id)
        {
            return Instance.GetDetail(id);
        }

        public static int Save(int? id, DateTime? date, string fromCardNumber, string toCardNumber, string comment, int? modifierID)
        {
            return Instance.Save(id, date, fromCardNumber, toCardNumber, comment, modifierID);
        }
    }
}
