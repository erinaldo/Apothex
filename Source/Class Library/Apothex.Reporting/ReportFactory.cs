using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Stimulsoft.Report;
using Apothex.DataType;
using Reports;
using Apothex.Common;
using System.IO;
using Zek.IO;

namespace Apothex.Reporting
{
    public class ReportFactory : ReportHelper
    {
        public static void Show(Form mdiParent, string formText, ObjectNames ObjectName, DataSet ds)
        {
            Show(mdiParent, formText, GetReport(ObjectName), ds, -1, -1, GetVariables());
        }
        public static void Show(Form mdiParent, string formText, ObjectNames ObjectName, DataTable table)
        {
            Show(mdiParent, formText, GetReport(ObjectName), table, -1, -1, GetVariables());
        }

        //public static void Show(Form mdiParent, string formText, ObjectNames tableName, DataTable dataTable)
        //{
        //    Show(mdiParent, formText, tableName, dataTable, -1, -1);
        //}
        //public static void Show(Form mdiParent, string formText, ObjectNames tableName, DataTable dataTable, int pageWidth, int pageHeight)
        //{
        //    StiReport rpt = GetReportDocument(tableName);
        //    InitReport(rpt, pageWidth, pageHeight);
        //    rpt.RegData(dataTable);
        //    Show(mdiParent, formText, rpt);
        //}
        //public static void Show(Form mdiParent, string formText, ObjectNames tableName, DataSet dataSet)
        //{
        //    Show(mdiParent, formText, tableName, dataSet, -1, -1);
        //}
        //public static void Show(Form mdiParent, string formText, ObjectNames tableName, DataSet dataSet, int pageWidth, int pageHeight)
        //{
        //    StiReport rpt = GetReportDocument(tableName);
        //    InitReport(rpt, pageWidth, pageHeight);
        //    rpt.RegData(dataSet);
        //    Show(mdiParent, formText, rpt);
        //}
        //private static void Show(Form mdiParent, string formText, StiReport rpt)
        //{
        //    ReportHelper.Show(mdiParent, formText, rpt);
        //    //ReportViewerForm.Show(mdiParent, formText, rpt);
        //}


        //public static void Print(ObjectNames tableName, DataSet dataSet)
        //{
        //    Print(tableName, dataSet, -1, -1);
        //}
        //public static void Print(ObjectNames tableName, DataSet dataSet, int pageWidth, int pageHeight)
        //{
        //    StiReport rpt = GetReportDocument(tableName);
        //    InitReport(rpt, pageWidth, pageHeight);
        //    rpt.RegData(dataSet);
        //    rpt.Print(false);
        //}

        private static string ReportDir
        {
            get { return Path.Combine(IOHelper.GetParentDirectory(), "Reports"); }
        }

        public static StiReport GetReport(ObjectNames tableName)
        {
            StiReport rpt = null;
            switch (tableName)
            {
                case ObjectNames.Country:
                    rpt = new RptCountry();
                    break;

                case ObjectNames.PurchaseOrderHeader:
                    rpt = new RptPurchaseOrderHeader();
                    break;

                case ObjectNames.PurchaseOrderDetail:
                    rpt = new RptPurchaseOrderDetail();
                    break;

                case ObjectNames.SalesOrderHeader:
                    rpt = new RptSalesOrderHeader();
                    break;

                case ObjectNames.SalesOrderDetail:
                    rpt = new RptSalesOrderDetail();
                    //stiReport.Load(@"d:\My Documents\Projects\Apothex\Source\Class Library\Apothex.Reporting\Sales\RptSalesOrderDetail.mrt");
                    break;

                case ObjectNames.SalesOrderDetailThermalPrinter:
                    rpt = new RptSalesOrderDetailThermalPrinter();
                    var file = Path.Combine(ReportDir, "RptSalesOrderDetailThermalPrinter.mrt");
                    if (File.Exists(file))
                    {
                        rpt = new StiReport();
                        rpt.Load(file);
                        rpt.Compile();
                    }
                    break;

                case ObjectNames.SalesOrderDetailInfo:
                    rpt = new RptSalesOrderDetailInfo();

                //case ObjectNames.SalesOrderDetailInvoice:
                //    rpt = new RptSalesOrderDetailInvoice();
                    //rpt.Load(@"d:\My Documents\Projects\Apothex\Source\Class Library\Apothex.Reporting\Sales\RptSalesOrderDetailInvoice.mrt");
                    break;

                case ObjectNames.SalesOrderDetailPurchasePrice:
                    rpt = new RptSalesOrderDetailPurchasePrice();
                    break;

                case ObjectNames.SalesOrderDetailList:
                    rpt = new RptSalesOrderDetailList();
                    break;

                case ObjectNames.SalesOrderHeaderPurchaseTotal:
                    rpt = new RptSalesOrderHeaderPurchaseTotal();
                    //rpt.Load(@"d:\My Documents\Projects\Apothex\Source\Class Library\Apothex.Reporting\Sales\RptSalesOrderHeaderPurchaseTotal.mrt");
                    break;

                case ObjectNames.SalesOrderHeaderGroupByDate:
                    rpt = new RptSalesOrderHeaderGroupByDate();
                    break;

                case ObjectNames.ProductDistributionDetail:
                    rpt = new RptProductDistributionDetail();
                    break;

                case ObjectNames.ProductDistributionDetailList:
                    rpt = new RptProductDistributionDetailList();
                    break;

                case ObjectNames.Product:
                    rpt = new RptProductBarCode();
                    break;

                case ObjectNames.ProductLocation:
                    rpt = new RptProducLocationPrice();
                    break;

                case ObjectNames.WarehouseDescriprion:
                    rpt = new RptWarehouseDescription();
                    break;

                case ObjectNames.Request:
                    rpt = new RptRequestDetail();
                    break;
            }

            if (rpt == null)
                throw new Exception("რეპორტის დოკუმენტი არ დაფიქსირდა.");

            return rpt;
        }
        private static Dictionary<string, object> GetVariables()
        {
            var variables = new Dictionary<string, object>();
            variables.Add("MyCompanyName", GlobalVariable.MyCompanyName);
            variables.Add("MyCompanyTaxCode", GlobalVariable.MyCompanyTaxCode);
            variables.Add("MyCompanyDirectorName", GlobalVariable.MyCompanyDirectorName);
            variables.Add("MyCompanyCountryCode", GlobalVariable.MyCompanyCountryCode);
            variables.Add("MyCompanyCountryName", GlobalVariable.MyCompanyCountryName);
            variables.Add("MyCompanyCity", GlobalVariable.MyCompanyCity);
            variables.Add("MyCompanyPostalCode", GlobalVariable.MyCompanyPostalCode);
            variables.Add("MyCompanyAddress", GlobalVariable.MyCompanyAddress);
            variables.Add("MyCompanyPhone", GlobalVariable.MyCompanyPhone);
            variables.Add("MyCompanyFax", GlobalVariable.MyCompanyFax);
            variables.Add("MyCompanyBankName", GlobalVariable.MyCompanyBankName);
            variables.Add("MyCompanyBankCode", GlobalVariable.MyCompanyBankCode);
            variables.Add("MyCompanyBankAccountNumber", GlobalVariable.MyCompanyBankAccountNumber);

            return variables;
        }

        
    }
}
