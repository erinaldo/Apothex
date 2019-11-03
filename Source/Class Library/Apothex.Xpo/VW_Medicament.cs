using System;
using DevExpress.Xpo;

namespace Xpo
{
    [Persistent("Dictionary.VW_Medicament")]
    public class VW_Medicament : XPLiteObject
    {
        [Key]
        public int MedicamentID;
        public string MedicamentName;
        //public int MedicamentCategoryID;
        public string MedicamentCategoryName;
        //public int MedicamentSubcategoryID;
        public string MedicamentSubcategoryName;
        public string ProductNumber;
        public bool MakeFlag;
        public bool FinishedGoodsFlag;
        public string Color;
        public short SafetyStockLevel;
        public short ReorderPoint;
        public decimal StandardCost;
        public decimal ListPrice;
        public decimal DealerPrice;
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
        public DateTime ValidDate;
        //public int GenericID;
        //public string GenericName;
        public string CountryCode;
        public string CountryName;
        //public int BrandID;
        public string BrandName;
        public string Serie;

        public byte Status;
        //public int ModifiedUserID;
        //public string Modifier;
        //public DateTime ModifiedDate;
        //public int ApproverUserID;
        //public string Approver;

        public decimal Quantity;

        [NonPersistent]
        public bool InUse;

        public VW_Medicament(Session session) : base(session)
        {
            AutoSaveOnEndEdit = false;
        }
    }


}
