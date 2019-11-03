using System;
using Apothex.Contracts.ProductLocation;
using Apothex.DataType;
using Apothex.Configuration;
using Apothex.DataType.DS_ProductLocationTableAdapters;
using Apothex.DataType.DS_ProductLocationPurchaseOrderHeaderTableAdapters;
using Zek.Data;

namespace Apothex.SqlDataAccess.ProductLocation
{
    public sealed class SqlProductLocationProvider : ProductLocationProvider
    {
        public override DS_ProductLocation.SP_GetProductLocationQuantityDataTable GetProductLocationQuantity(int? productLocationID, int? tableID, bool isOnline, byte[] b)
        {
            var connectionString = (isOnline ? ConfigurationManagerEx.ConnectionString : ConfigurationManagerEx.OfflineConnectionString);
            var commandTimeout = (isOnline ? ConfigurationManagerEx.CommandTimeout : ConfigurationManagerEx.OfflineCommandTimeout);

            using (var adapter = SP_GetProductLocationQuantityTableAdapter.CreateInstance(connectionString, commandTimeout))
            {
                return adapter.GetData(productLocationID, tableID, b.GetXmlData());
            }
        }
        public override DS_ProductLocation.VW_ProductLocationDataTable GetVW(int? id, int? purchaseOrderID, int? branchID, int? productID, string barcode, DateTime? date, bool isOnline)
        {
            var connectionString = (isOnline ? ConfigurationManagerEx.ConnectionString : ConfigurationManagerEx.OfflineConnectionString);
            var commandTimeout = (isOnline ? ConfigurationManagerEx.CommandTimeout : ConfigurationManagerEx.OfflineCommandTimeout);

            using (var adapter = VW_ProductLocationTableAdapter.CreateInstance(connectionString, commandTimeout))
            {
                return adapter.GetData(id, purchaseOrderID, branchID, productID, barcode, date);
            }
        }
        public override DS_ProductLocationPurchaseOrderHeader.SP_GetProductLocationPurchaseOrderHeaderDataTable GetProductLocationPurchaseOrderHeader(int? productID, int? productLocationID)
        {
            using (var adapter = SP_GetProductLocationPurchaseOrderHeaderTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(productID, productLocationID);
            }
        }
    }
}
