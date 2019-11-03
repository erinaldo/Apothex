using System;
using Apothex.DataType;

namespace Apothex.Contracts.ProductLocation
{
    public abstract class ProductLocationProvider : IProductLocation
    {
        public abstract DS_ProductLocation.VW_ProductLocationDataTable GetVW(int? id, int? purchaseOrderID, int? branchID, int? productID, string barcode, DateTime? date, bool isOnline);

        public abstract DS_ProductLocationPurchaseOrderHeader.SP_GetProductLocationPurchaseOrderHeaderDataTable GetProductLocationPurchaseOrderHeader(int? productID, int? productLocationID);

        public abstract DS_ProductLocation.SP_GetProductLocationQuantityDataTable GetProductLocationQuantity(int? productLocationID, int? tableID, bool isOnline, byte[] b);
    }
}
