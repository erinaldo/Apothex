namespace Apothex.DataType
{
    /// <summary>
    /// ობიექტების სახელები
    /// </summary>
    public enum ObjectNames
    {
        None = 0,

        /// <summary>
        /// მომხმარებელი
        /// </summary>
        User = 10,

        /// <summary>
        /// ჯგუფი
        /// </summary>
        UserGroup = 20,

        /// <summary>
        /// მომხმარებლების ჯგუფებში განაწილება
        /// </summary>
        UserInGroup = 30,

        /// <summary>
        /// უფლებების მართვა
        /// </summary>
        UserGroupPermission = 40,

        /// <summary>
        /// მომხმარებლის უფლება
        /// </summary>
        UserPermission = 50,



        /// <summary>
        /// ფილიალი
        /// </summary>
        Branch = 10010,

        
        /// <summary>
        /// ბანკი
        /// </summary>
        Bank = 10020,

        
        /// <summary>
        /// ქვეყანა
        /// </summary>
        Country = 10030,

        
        /// <summary>
        /// ვალუტა
        /// </summary>
        Currency = 10040,
        /// <summary>
        /// ვალუტა
        /// </summary>
        CurrencyName = 10041,
        /// <summary>
        /// ვალუტა კურსით
        /// </summary>
        CurrencyWithLastRate = 10042,
        /// <summary>
        /// ვალუტა კურსით
        /// </summary>
        CurrencyWithRate = 10043,
        /// <summary>
        /// ვალუტა
        /// </summary>
        DD_Currency = 10044,
        
        /// <summary>
        /// ვალუტის კურსი
        /// </summary>
        CurrencyRate = 10050,

        
        /// <summary>
        /// მედიკამენტი
        /// </summary>
        Medicament = 10060,

        
        /// <summary>
        /// მედიკამენტის კატეგორია
        /// </summary>
        MedicamentCategory = 10070,

        
        /// <summary>
        /// მედიკამენტის კატეგორია
        /// </summary>
        MedicamentSubcategory = 10080,
        /// <summary>
        /// მედიკამენტის კატეგორია Code-ში არის CategoryID
        /// </summary>
        MedicamentSubcategoryWithMedicamentCategoryID = 10081,
        /// <summary>
        /// მედიკამენტის კატეგორია Code-ში არის CategoryName
        /// </summary>
        MedicamentSubcategoryWithMedicamentCategoryName = 10082,

        
        /// <summary>
        /// ზომის ერთეული
        /// </summary>
        UnitMeasure = 10090,

        
        /// <summary>
        /// გადახდის მეთოდი
        /// </summary>
        PaymentMethod = 10100,


        /// <summary>
        /// ბრენდი.
        /// </summary>
        Brand = 10120,


        /// <summary>
        /// ჯენერიკი.
        /// </summary>
        Generic = 10130,

        /// <summary>
        /// ფარმაკოლოგიური ჯგუფი.
        /// </summary>
        PharmacologyGroup = 10140,


        /// <summary>
        /// კომპანია
        /// </summary>
        Company = 20010,

        
        /// <summary>
        /// კომპანია
        /// </summary>
        MyCompany = 20020,



        /// <summary>
        /// პროდუქცია
        /// </summary>
        Product = 30010,
        
        /// <summary>
        /// პროდუქციის ადგილმდებარეობა
        /// </summary>
        ProductLocation = 30020,
        /// <summary>
        /// პროდუქციის ადგილმდებარეობა საინფორმაციოსთვის.
        /// </summary>
        ProductLocationMIS = 30021,

        /// <summary>
        /// პროდუქციის ადგილმდებარეობა ყველა ფილიალში
        /// </summary>
        ProductLocationAllBranch = 30030,

        /// <summary>
        /// პროდუქტის დისტრიბუციის ჰედერი.
        /// </summary>
        ProductDistributionHeader = 30040,
        /// <summary>
        /// პროდუქტის დისტრიბუციის ჰედერის შეყვანა ნებისმიერი თარიღით.
        /// </summary>
        ProductDistributionHeaderAnyDate = 30041,

        /// <summary>
        /// პროდუქტის დისტრიბუციის დეტალები.
        /// </summary>
        ProductDistributionDetail  = 30050,
        /// <summary>
        /// შიდა გადაცემის რეესტრი.
        /// </summary>
        ProductDistributionDetailList = 30051,

        /// <summary>
        /// პროდუქციის დისტრიბუციის ჰედერი ყველა ფილიალში.
        /// </summary>
        ProductDistributionHeaderAllBranch = 30060,

        /// <summary>
        /// პროდუქციის მასიურად ფასების ცვლა.
        /// </summary>
        ProductPrice = 30070,


        /// <summary>
        /// ფასდაკლება ნებისმიერ მედიკამენტზე.
        /// </summary>
        DiscountZeroDiscountedProduct = 30090,
        /// <summary>
        /// ნებისმიერი ფასდაკლებით.
        /// </summary>
        DiscountAnyProduct = 30091,

        /// <summary>
        /// ყიდვის დეტალური ბალანსი.
        /// </summary>
        ProductDistributionDetailInfo = 30100,

        /// <summary>
        /// რეალური შესყიდვა & გაყიდვა.
        /// </summary>
        RealIncomeExpence = 30110,

        /// <summary>
        /// პროფუქტის გადაფასების აქტი.
        /// </summary>
        ProductListPriceHistory = 30120,

        


        /// <summary>
        /// ყიდვის ჰედერი.
        /// </summary>
        PurchaseOrderHeader = 40010,
        /// <summary>
        /// ყიდვის ჰედერის შეყვანა ნებისმიერი თარიღით.
        /// </summary>
        PurchaseOrderHeaderAnyDate = 40011,

        /// <summary>
        /// ტიდვის დეთაილსი.
        /// </summary>
        PurchaseOrderDetail = 40020,
        /// <summary>
        /// ყიდვის დეთაილსის ფაქტურა.
        /// </summary>
        PurchaseOrderDetailInvoice = 40021,

        /// <summary>
        /// ყიდვის ჰედერი ყველა ფილიალში.
        /// </summary>
        PurchaseOrderHeaderAllBranch = 40030,


        /// <summary>
        /// ყიდვის დეტალური ბალანსი.
        /// </summary>
        PurchaseOrderDetailInfo = 40040,
        /// <summary>
        /// ყიდვის დეტალური ბალანსი ყველა ფილიალში.
        /// </summary>
        PurchaseOrderDetailInfoAllBranch = 40050,


        /// <summary>
        /// ნებისმიერი შესყიდვის ცვლილება.
        /// </summary>
        PurchaseOrderHeaderAnyModifier = 40060,

        /// <summary>
        /// გაყიდვის ჰედერი
        /// </summary>
        SalesOrderHeader = 50010,
        /// <summary>
        /// გაყიდვის ჰედერის შეყვანა ნებისმიერი თარიღით.
        /// </summary>
        SalesOrderHeaderAnyDate = 50011,
        /// <summary>
        /// გაყიდვის ჰედერის შეყვანა რამოდენიმე დღით განსხვავებული თარიღით.
        /// </summary>
        SalesOrderHeaderFewDate = 50012,
        /// <summary>
        /// გაყიდვა თვითღირებულებით.
        /// </summary>
        SalesOrderHeaderStandardCost = 50013,
        /// <summary>
        /// გაყიდვა ნებისმიერი ფასით.
        /// </summary>
        SalesOrderHeaderAnyPrice = 50014,
        /// <summary>
        /// გაყიდვაში ანახებს სტანდარტულად მხოლოდ თავის გაყიდულს.
        /// </summary>
        SalesOrderHeaderAllModifierFilter = 50015,
        /// <summary>
        /// გაყიდვის გენერირება შესყიდვის ნომრით.
        /// </summary>
        SalesOrderHeaderByPurchaseID = 50016,
        /// <summary>
        /// გადაფასება.
        /// </summary>
        SalesOrderFixNewPrice = 50017,
        /// <summary>
        /// გაყიდვის დეთაილსი
        /// </summary>
        SalesOrderDetail = 50020,
        ///// <summary>
        ///// გაყიდვის დეთაილსის ფაქტურა
        ///// </summary>
        //SalesOrderDetailInvoice = 50021,
        /// <summary>
        /// გაყიდვის დეთაილსი შესასყიდი ფასით
        /// </summary>
        SalesOrderDetailPurchasePrice = 50022,
        /// <summary>
        /// გაყიდვის დეთაილსი თერმულ პრინტერზე.
        /// </summary>
        SalesOrderDetailThermalPrinter = 50023,
        /// <summary>
        /// გაყიდვების დეფექტურა.
        /// </summary>
        SalesOrderDetailDefecture = 50025,
        /// <summary>
        /// გაყიდვების დღიური რეესტრი.
        /// </summary>
        SalesOrderHeaderGroupByDate = 50026,
        /// <summary>
        /// მედიკამენტის უკან დაბრუნების რეესტრი.
        /// </summary>
        SalesOrderDetailList = 50027,
        /// <summary>
        /// გაყიდვების დეტალური ცხრილი.
        /// </summary>
        SalesOrderDetailPivot = 50028,


        /// <summary>
        /// გაყიდვის ჰედერი ყველა ფილიალში
        /// </summary>
        SalesOrderHeaderAllBranch = 50030,
        /// <summary>
        /// ნომინაციები.
        /// </summary>
        Nomination = 50031,



        /// <summary>
        /// დღის დახურვა
        /// </summary>
        CloseDay = 50040,

        /// <summary>
        /// დღის დახურვა ყველა ფილიალში
        /// </summary>
        CloseDayAllBranch = 50050,

        /// <summary>
        /// გაყიდვის დეტალური ბალანსი.
        /// </summary>
        SalesOrderDetailInfo = 50080,
        /// <summary>
        /// გაყიდვის დეტალური ბალანსი ყველა ფილიალში.
        /// </summary>
        SalesOrderDetailInfoAllBranch = 50090,

        /// <summary>
        /// გაყიდვების ჟურნალი
        /// </summary>
        SalesOrderHeaderPurchaseTotal = 50100,
        /// <summary>
        /// გაყიდვები, შესყიდული კომპანიების მიხედვით.
        /// </summary>
        SalesOrderDetailInfoVendor = 50110,

        /// <summary>
        /// გაყიდვები, შესყიდული კომპანიების მიხედვით.
        /// </summary>
        SalesOrderHeaderAnyModifier = 50120,

        /// <summary>
        /// სინქრონიზაცია.
        /// </summary>
        Synchronize = 60000,

        /// <summary>
        /// თარიღის სინქრონიზაცია.
        /// </summary>
        SynchronizeDate = 60010,

        /// <summary>
        /// მედიკამენტების გაერთიანება.
        /// </summary>
        MergeMedicament = 70010,

        /// <summary>
        /// ინფო 10
        /// </summary>
        Info10 = 80010,

        /// <summary>
        /// შეკვეთა.
        /// </summary>
        Request = 90010,

        /// <summary>
        /// საწყობის აღწერა.
        /// </summary>
        WarehouseDescriprion = 90100,


        /// <summary>
        /// ბარათი
        /// </summary>
        Card = 90200,
        /// <summary>
        /// ბარათის თავისი მფლობელით
        /// </summary>
        CardAndHolderByCardNumber = 90202,
        /// <summary>
        /// ბარათის ტიპი.
        /// </summary>
        CardType = 90210,
        /// <summary>
        /// ბარათის ფასდაკლების სქემა.
        /// </summary>
        CardDiscountSchema = 90220,
        /// <summary>
        /// ბარათის კურსი.
        /// </summary>
        CardUnitRate = 90230,
        /// <summary>
        /// ბარათის რეესტრი დეტალური.
        /// </summary>
        CardHandle = 90240,
        /// <summary>
        /// ბარათის რეესტრი ჯამური.
        /// </summary>
        BonusAccumulation = 90250,
        /// <summary>
        /// ქულების ტრანსფერი.
        /// </summary>
        PointTransfer = 90260,


        /// <summary>
        /// პიროვნება.
        /// </summary>
        Person = 90300,
        /// <summary>
        /// პიროვნების კატეგორია.
        /// </summary>
        PersonCategory = 90310,
        
        /// <summary>
        /// ოპერაცია.
        /// </summary>
        Operation = 90400,
        /// <summary>
        /// ოპერაციის ტიპი.
        /// </summary>
        OperationType = 90410,

        /// <summary>
        /// სალარო ორდერი
        /// </summary>
        Cashbox = 90500,
        /// <summary>
        /// სალარო ორდერის ტიპი
        /// </summary>
        CashboxOrderType = 90510,


        

        /// <summary>
        /// მონაცემების გადანახვა.
        /// </summary>
        BackupDatabase = 100010,
        /// <summary>
        /// მონაცემების აღდგენა.
        /// </summary>
        RestoreDatabase = 100020,
    }
}
