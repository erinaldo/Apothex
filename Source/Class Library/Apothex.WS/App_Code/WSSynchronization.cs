using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using Apothex.DataManagment.Synchronization;
using Zek.Data;
using System.Data;
using Apothex.DataType;
using Apothex.Configuration;
using Apothex.DataType.DS_SynchronizationTableAdapters;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class WSSynchronization : System.Web.Services.WebService
{

    public WSSynchronization()
    {
        //InitializeComponent(); 
    }
    private static byte[] GetBytes(DataTable table)
    {
        return Zek.Data.Serialization.SerializationHelper.Serialize(SerializationFormat.Xml, table, true);
    }


    [WebMethod]
    public byte[] GetSyncBranch(int branchID, DateTime modifiedDate, int action)
    {
        return GetBytes(SynchronizationManager.GetSyncBranch(branchID, modifiedDate, (DatabaseAction)action));
    }

    [WebMethod]
    public byte[] GetSyncUser(int userID, int branchID, DateTime modifiedDate, int action)
    {
        return GetBytes(SynchronizationManager.GetSyncUser(userID, branchID, modifiedDate, (DatabaseAction)action));
    }

    [WebMethod]
    public byte[] GetSyncUserPermission(int userID, int branchID, DateTime modifiedDate, int action)
    {
        return GetBytes(SynchronizationManager.GetSyncUserPermission(userID, branchID, modifiedDate, (DatabaseAction)action));
    }

    [WebMethod]
    public byte[] GetSyncMyCompany(int myCompanyID, DateTime modifiedDate, int action)
    {
        return GetBytes(SynchronizationManager.GetSyncMyCompany(myCompanyID, modifiedDate, (DatabaseAction)action));
    }

    [WebMethod]
    public byte[] GetSyncCurrency(string currencyCode, DateTime modifiedDate, int action)
    {
        return GetBytes(SynchronizationManager.GetSyncCurrency(currencyCode, modifiedDate, (DatabaseAction)action));
    }

    [WebMethod]
    public byte[] GetSyncPaymentMethod(int paymentMethodID, DateTime modifiedDate, int action)
    {
        return GetBytes(SynchronizationManager.GetSyncPaymentMethod(paymentMethodID, modifiedDate, (DatabaseAction)action));
    }

    [WebMethod]
    public byte[] GetSyncProductLocation(int productLocationID, int productID, int branchID, DateTime modifiedDate, int action)
    {
        return GetBytes(SynchronizationManager.GetSyncProductLocation(productLocationID, productID, branchID, modifiedDate, (DatabaseAction)action));
    }

    [WebMethod]
    public byte[] GetSyncCardUnitRate()
    {
        return GetBytes(SynchronizationManager.GetSyncCardUnitRate());
    }

    [WebMethod]
    public byte[] GetSyncCardDiscountSchema()
    {
        return GetBytes(SynchronizationManager.GetSyncCardDiscountSchema());
    }

    [WebMethod]
    public byte[] GetOperationType()
    {
        return GetBytes(SynchronizationManager.GetOperationType());
    }

    [WebMethod]
    public byte[] GetInvalidSalesOrderDetail(byte[] b)
    {
        return GetBytes(SynchronizationManager.GetInvalidSalesOrderDetail(b));
    }

    [WebMethod]
    public DateTime GetDate(int objectID, bool isOnline)
    {
        return SynchronizationManager.GetDate(objectID, isOnline);
    }

    //[WebMethod]
    //public string GetConnectionString()
    //{
    //    return SynchronizationQueriesAdapter.GetConnectionString();
    //}

    //[WebMethod]
    //public string Test()
    //{
    //    return Apothex.DataManagment.Config.ConfigManager.GetString(ConfigName.WSSynchronizationUrl);
    //}


    [WebMethod]
    public int Synchronize(int objectID, int modifiedUserID, DateTime modifiedDate, int action, bool isOnline, byte[] b)
    {
        return SynchronizationManager.Synchronize(objectID, modifiedUserID, modifiedDate, action, isOnline, b);
    }
}
