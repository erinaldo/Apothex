using System;
using Apothex.DataType;

namespace Apothex.Contracts.ProductLocation
{
    public interface IProductLocation
    {
        DS_ProductLocation.VW_ProductLocationDataTable GetVW(int? productLocationID, int? purchaseOrderID, int? branchID, int? productID, string barcode, DateTime? date, bool isOnline);
        DS_ProductLocationPurchaseOrderHeader.SP_GetProductLocationPurchaseOrderHeaderDataTable GetProductLocationPurchaseOrderHeader(int? productID, int? productLocationID);
        DS_ProductLocation.SP_GetProductLocationQuantityDataTable GetProductLocationQuantity(int? productLocationID, int? tableID, bool isOnline, byte[] b);
    }
}
