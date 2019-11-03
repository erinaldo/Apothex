using System;
using Apothex.Contracts.CardPointTransfer;
using Apothex.DataType;
using Apothex.DataType.DS_CardPointTransferTableAdapters;
using Apothex.Configuration;

namespace Apothex.SqlDataAccess.CardPointTransfer
{
    public sealed class SqlCardPointTransferProvider : CardPointTransferProvider
    {
        public override DS_CardPointTransfer.T_PointTransferHeaderDataTable GetHeader(int? id)
        {
            using (var adapter = T_PointTransferHeaderTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.ConnectionTimeout))
            {
                return adapter.GetData(id);
            }
        }

        public override DS_CardPointTransfer.VW_PointTransferDetailDataTable GetDetail(int? id)
        {
            using (var adapter = VW_PointTransferDetailTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.ConnectionTimeout))
            {
                return adapter.GetData(id);
            }
        }

        public override int Save(int? id, DateTime? date, string fromCardNumber, string toCardNumber, string comment, int? modifierID)
        {
            using (var adapter = CardPointTransferQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.ConnectionTimeout))
            {
                return (int)adapter.SP_T_PointTransfer_Save(id, date, fromCardNumber, toCardNumber, comment, modifierID);
            }
        }
    }
}
