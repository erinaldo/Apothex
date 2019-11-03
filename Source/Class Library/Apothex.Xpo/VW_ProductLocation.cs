using System;
using DevExpress.Xpo;

namespace Xpo
{
    [Persistent("Production.VW_ProductLocation")]
    public class VW_ProductLocation : XPLiteObject
    {
        [Key]
        public int ProductLocationID;
        public int ProductID;
        public int BranchID;
        //public string BranchName;
        //public Guid PurchaseOrderDetailID;
        //public int MedicamentID;
        public string ProductNumber;
        public string MedicamentName;
        //public int MedicamentCategoryID;
        public string MedicamentCategoryName;
        //public int MedicamentSubcategoryID;
        public string MedicamentSubcategoryName;
        public decimal Quantity;
        public decimal UnitPrice;
        public DateTime ValidDate;
        //public int GenericID;
        public string GenericName;
        //public string CountryCode;
        public string CountryName;
        //public int BrandID;
        public string BrandName;
        public string Serie;
        public bool MakeFlag;
        public bool FinishedGoodsFlag;
        public string Color;
        public short SafetyStockLevel;
        public short ReorderPoint;
        public decimal StandardCost;
        public decimal ListPrice;
        public decimal DealerPrice;
        //public string ProductCurrencyCode;
        public decimal PurchaseCurrencyRate;
        public decimal ProductCurrencyRate;
        public decimal DiscountPct;
        public decimal TaxRate;
        public string Size;
        public string SizeRange;
        public string SizeUnitMeasureCode;
        public decimal Weight;
        public string WeightUnitMeasureCode;
        public int DaysToManufacture;
        public string ProductLine;
        public string Class;
        public string Style;
        //public int ProductModelID;
        public DateTime SellStartDate;
        public DateTime SellEndDate;
        public DateTime DiscontinuedDate;
        public short UnitsInStock;
        //public int ModifiedUserID;
        //public string Modifier;
        //public DateTime ModifiedDate;

        [NonPersistent]
        public bool InUse;


        public VW_ProductLocation(Session session) : base(session)
        {
            AutoSaveOnEndEdit = false;
        }
    }

}
