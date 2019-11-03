using System;
using Apothex.Contracts.User;
using Apothex.DataType;
using Zek.Data;
using Apothex.Configuration;
using Apothex.SqlDataAccess.User;

namespace Apothex.DataManagment.User
{
    public static class UserManager
    {
        #region Instance
        private static object sync = new object();
        private static UserProvider _instance;
        private static UserProvider Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (sync)
                    {
                        if (_instance == null)
                        {
                            switch (ConfigurationManagerEx.UserProvider)
                            {
                                case "WebService":
                                case "SqlDataBase":
                                default: //SqlDataBase
                                    _instance = new SqlUserProvider();
                                    break;
                            }
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion

        public static DS_User.SP_LogInDataTable LogIn(string username, string passwordHash)
        {
            return Instance.LogIn(username, passwordHash);
        }
        public static DS_User.SP_GetUserDataTable GetUser(int? id)
        {
            return Instance.GetUser(id);
        }
        public static bool IsValidUsername(int? id, string userName)
        {
            return Instance.IsValidUserName(id, userName);
        }
        public static int Save(int? id, int? branchID, string userName, string passwordHash, int? personID, int? modifierID)
        {
            return Instance.Save(id, branchID, userName, passwordHash, personID, modifierID);
        }

        public static DS_User.UserGroupPermissionDataTable GetUserGroupPermissions()
        {
            var table = new DS_User.UserGroupPermissionDataTable();


            AddUserGroupPermissionRow(table, ObjectNames.BackupDatabase, "მონაცემთა ბაზის შენახვა");
            AddUserGroupPermissionRow(table, ObjectNames.RestoreDatabase, "მონაცემთა ბაზის აღდგენა");

            AddUserGroupPermissionRow(table, ObjectNames.PurchaseOrderHeader, "შესყიდვა");
            AddUserGroupPermissionRow(table, ObjectNames.PurchaseOrderHeaderAllBranch, "შესყიდვა ყველა ფილიალში");
            AddUserGroupPermissionRow(table, ObjectNames.PurchaseOrderHeaderAnyDate, "შესყიდვა ნებისმიერი თარიღით");
            AddUserGroupPermissionRow(table, ObjectNames.PurchaseOrderHeaderAnyModifier, "ნებისმიერი შესყიდვის შეცვლა");
            
            AddUserGroupPermissionRow(table, ObjectNames.SalesOrderHeader, "გაყიდვა");
            AddUserGroupPermissionRow(table, ObjectNames.SalesOrderHeaderAllBranch, "გაყიდვა ყველა ფილიალში");
            AddUserGroupPermissionRow(table, ObjectNames.SalesOrderHeaderAllModifierFilter, "გაყიდვაში მხოლოდ ჩემი სალაროს ნახვის ფილტრის მოხსნა");
            AddUserGroupPermissionRow(table, ObjectNames.SalesOrderHeaderAnyDate, "გაყიდვა ნებისმიერი თარიღით");
            AddUserGroupPermissionRow(table, ObjectNames.SalesOrderHeaderFewDate, "გაყიდვა 3 დღის შუალედში");
            AddUserGroupPermissionRow(table, ObjectNames.SalesOrderHeaderAnyModifier, "ნებისმიერი გაყიდვის შეცვლა");
            AddUserGroupPermissionRow(table, ObjectNames.SalesOrderHeaderStandardCost, "გაყიდვა თვითღირებულებით");
            AddUserGroupPermissionRow(table, ObjectNames.SalesOrderHeaderAnyPrice, "გაყიდვა ნებისმიერი ფასით");
            AddUserGroupPermissionRow(table, ObjectNames.SalesOrderFixNewPrice, "გაყიდვების გადაფასება");
            AddUserGroupPermissionRow(table, ObjectNames.SalesOrderHeaderByPurchaseID, "გაყიდვის გენერირება შესყიდვის ნომრით");
            AddUserGroupPermissionRow(table, ObjectNames.DiscountZeroDiscountedProduct, "ნებისმიერ 0%-ვან ფასდაკ. პროდუქტზე ფასდაკლების გაკეთება");
            AddUserGroupPermissionRow(table, ObjectNames.DiscountAnyProduct, "ნებისმიერ პროდუქტზე ფასდაკლების გაკეთება");

            AddUserGroupPermissionRow(table, ObjectNames.CloseDay, "დღის დახურვა");
            AddUserGroupPermissionRow(table, ObjectNames.CloseDayAllBranch, "დღის დახურვა ყველა ფილიალში");
            AddUserGroupPermissionRow(table, ObjectNames.ProductDistributionHeader, "შიდა გადაცემა");
            AddUserGroupPermissionRow(table, ObjectNames.ProductDistributionHeaderAllBranch, "შიდა გადაცემა ყველა ფილიალში");
            AddUserGroupPermissionRow(table, ObjectNames.ProductDistributionHeaderAnyDate, "შიდა გადაცემა ნებისმიერი თარიღით");
            AddUserGroupPermissionRow(table, ObjectNames.Request, "შეკვეთა");
            AddUserGroupPermissionRow(table, ObjectNames.WarehouseDescriprion, "საწყობის აღწერა");
            AddUserGroupPermissionRow(table, ObjectNames.ProductLocation, "პროდუქცია ფილიალებში");
            AddUserGroupPermissionRow(table, ObjectNames.ProductLocationAllBranch, "პროდუქცია ყველა ფილიალში");
            AddUserGroupPermissionRow(table, ObjectNames.Product, "პროდუქცია (შტრიხ-კოდები, ფასები...)");
            AddUserGroupPermissionRow(table, ObjectNames.ProductPrice, "პროდუქციის მასიურად ფასების ცვლა");
            AddUserGroupPermissionRow(table, ObjectNames.Cashbox, "სალაროს გასავლის ორდერი");
            AddUserGroupPermissionRow(table, ObjectNames.Synchronize, "სინქრონიზაცია");



            AddUserGroupPermissionRow(table, ObjectNames.PurchaseOrderDetailInfo, "შესყიდვის დეტალური  ინფორმაცია");
            AddUserGroupPermissionRow(table, ObjectNames.PurchaseOrderDetailInfoAllBranch, "შესყიდვის დეტალური ინფორმაცია ყველა ფილიალში");
            AddUserGroupPermissionRow(table, ObjectNames.SalesOrderDetailInfo, "გაყიდვის დეტალური ბალანსი");
            AddUserGroupPermissionRow(table, ObjectNames.SalesOrderDetailInfoAllBranch, "გაყიდვის დეტალური ბალანსი ყველა ფილიალში");
            AddUserGroupPermissionRow(table, ObjectNames.ProductDistributionDetailInfo, "შიდა გადაცემის დეტალური ინფორმაცია");
            AddUserGroupPermissionRow(table, ObjectNames.SalesOrderHeaderPurchaseTotal, "გაყიდვების ჟურნალი");
            AddUserGroupPermissionRow(table, ObjectNames.SalesOrderHeaderGroupByDate, "დღიური რეესტრი");
            AddUserGroupPermissionRow(table, ObjectNames.SalesOrderDetailInfoVendor, "გაყიდვის დეტალური ინფო შესყიდვების მიხედვით");
            AddUserGroupPermissionRow(table, ObjectNames.SalesOrderDetailDefecture, "დეფექტურა");
            AddUserGroupPermissionRow(table, ObjectNames.ProductListPriceHistory, "გადაფასების აქტი");
            AddUserGroupPermissionRow(table, ObjectNames.RealIncomeExpence, "რეალური შესყიდვა & გაყიდვა");
            AddUserGroupPermissionRow(table, ObjectNames.SalesOrderDetailPivot, "გაყიდვის Pivot რეპორტი");
            AddUserGroupPermissionRow(table, ObjectNames.Nomination, "ნომინაციები");


            AddUserGroupPermissionRow(table, ObjectNames.ProductLocationMIS, "პრაისი");





            AddUserGroupPermissionRow(table, ObjectNames.Medicament, "მედიკამენტი");
            AddUserGroupPermissionRow(table, ObjectNames.MergeMedicament, "მედიკამენტის გაერთიანება");
            AddUserGroupPermissionRow(table, ObjectNames.Generic, "ჯენერიკი");
            AddUserGroupPermissionRow(table, ObjectNames.MedicamentCategory, "მედიკამენტის კატეგორია");
            AddUserGroupPermissionRow(table, ObjectNames.MedicamentSubcategory, "მედიკამენტის ქვეკატეგორია");
            AddUserGroupPermissionRow(table, ObjectNames.UnitMeasure, "ზომის ერთეული");
            AddUserGroupPermissionRow(table, ObjectNames.Country, "ქვეყანა");
            AddUserGroupPermissionRow(table, ObjectNames.Bank, "ბანკი");
            AddUserGroupPermissionRow(table, ObjectNames.Brand, "ბრენდი");

            AddUserGroupPermissionRow(table, ObjectNames.Person, "პერსონა");
            AddUserGroupPermissionRow(table, ObjectNames.PersonCategory, "პერსონის კატეგორია");

            AddUserGroupPermissionRow(table, ObjectNames.Company, "კომპანია");

            AddUserGroupPermissionRow(table, ObjectNames.PaymentMethod, "გადახდის მეთოდი");
            AddUserGroupPermissionRow(table, ObjectNames.Currency, "ვალუტა");
            AddUserGroupPermissionRow(table, ObjectNames.CurrencyRate, "ვალუტის კურსი");


            AddUserGroupPermissionRow(table, ObjectNames.Card, "ბარათი");
            AddUserGroupPermissionRow(table, ObjectNames.CardType, "ბარათის ტიპი");
            AddUserGroupPermissionRow(table, ObjectNames.CardDiscountSchema, "ბარათის ფასდაკლების სქემა");
            AddUserGroupPermissionRow(table, ObjectNames.CardUnitRate, "ბარათის ქულის ექვივალენტი");
            AddUserGroupPermissionRow(table, ObjectNames.CardHandle, "ბარათის გატარების დეტალური რეესტრი");
            AddUserGroupPermissionRow(table, ObjectNames.BonusAccumulation, "ბარათის გატარების ჯამური რეესტრი");
            AddUserGroupPermissionRow(table, ObjectNames.PointTransfer, "ბარათის დაგროვილი ქულების გადატანა.");


            AddUserGroupPermissionRow(table, ObjectNames.MyCompany, "ჩემი კომპანია");
            AddUserGroupPermissionRow(table, ObjectNames.Branch, "ფილიალი");
            AddUserGroupPermissionRow(table, ObjectNames.UserGroup, "ჯგუფი");
            AddUserGroupPermissionRow(table, ObjectNames.UserGroupPermission, "ჯგუფზე უფლებების მინიჭება");
            AddUserGroupPermissionRow(table, ObjectNames.User, "მომხმარებელი");
            AddUserGroupPermissionRow(table, ObjectNames.UserInGroup, "მომხმარებლის ჯგუფეში განაწილება");

            AddUserGroupPermissionRow(table, ObjectNames.Info10, "ინფო 10-დან ბაზის გადმოტანა");


            //AddUserGroupPermissionRow(ObjectNames.CardRead, ObjectNames.CardRead.ToString(), "ბარათის გატარება");
            //AddUserGroupPermissionRow(ObjectNames.CardReadAllBranch, ObjectNames.CardRead.ToString(), "ბარათის გატარება ყველა ფილიალში");

            return table;
        }
        private static void AddUserGroupPermissionRow(DS_User.UserGroupPermissionDataTable table, ObjectNames objectName, string description)
        {
            table.AddUserGroupPermissionRow(0, (int)objectName, description, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 0, 0);
        }

        public static DS_User.SP_GetUserGroupDataTable GetUserGroup(int? userGroupID)
        {
            return Instance.GetUserGroup(userGroupID);
        }
        public static bool IsValidUserGroupName(int? userGroupID, string name)
        {
            return Instance.IsValidUserGroupName(userGroupID, name);
        }
        public static int AddOrEditUserGroup(int? userGroupID, string name, DatabaseStatus status, int? modifiedUserID, DateTime modifiedDate, int? approverUserID, DatabaseAction action)
        {
            return Instance.AddOrEditUserGroup(userGroupID, name, (int)status, modifiedUserID, modifiedDate, approverUserID, (int)action);
        }

        public static DS_User.SP_GetUserInGroupDataTable GetUserInGroup(int? userID, int? userGroupID)
        {
            return Instance.GetUserInGroup(userID, userGroupID);
        }
        public static int AddOrEditUserInGroup(int? userID, int? userGroupID, int? modifiedUserID, DateTime modifiedDate, DatabaseAction action, byte[] b)
        {
            return Instance.AddOrEditUserInGroup(userID, userGroupID, modifiedUserID, modifiedDate, (int)action, b);
        }

        public static DS_User.SP_GetUserGroupPermissionDataTable GetGroupPermission(int? userGroupID)
        {
            return Instance.GetUserGroupPermission(userGroupID);
        }
        public static int AddOrEditUserGroupPermission(int? userGroupID, int? objectID, int? logical, int? modifiedUserID, DateTime modifiedDate, DatabaseAction action, byte[] b)
        {
            return Instance.AddOrEditUserGroupPermission(userGroupID, objectID, logical, modifiedUserID, modifiedDate, (int)action, b);
        }
        public static DS_User.SP_GetUserPermissionDataTable GetUserPermission(int? userID)
        {
            return Instance.GetUserPermission(userID);
        }
    }
}
