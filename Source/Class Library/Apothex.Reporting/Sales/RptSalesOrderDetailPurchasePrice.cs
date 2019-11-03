using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Components.TextFormats;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Engine;
using Stimulsoft.Report.Events;
using Stimulsoft.Report.Print;

namespace Reports
{

    public class RptSalesOrderDetailPurchasePrice : StiReport
    {

        public RptSalesOrderDetailPurchasePrice()
        {
            InitializeComponent();
        }
        #region StiReport Designer generated code - do not modify
        public StiDataRelation ParentSP_GetSalesOrderHeader;
        public string MyCompanyName;
        public string MyCompanyTaxCode;
        public string MyCompanyDirectorName;
        public string MyCompanyCountryCode;
        public string MyCompanyCountryName;
        public string MyCompanyCity;
        public string MyCompanyPostalCode;
        public string MyCompanyAddress;
        public string MyCompanyPhone;
        public string MyCompanyFax;
        public string MyCompanyBankName;
        public string MyCompanyBankCode;
        public string MyCompanyBankAccountNumber;
        public bool MyCompanyVATPayerFlag;
        public string MyCompanyConditionalUnitCurrencyCode;
        public string MyCompanyDefaultTradingCurrencyCode;
        public decimal MyCompanyConditionalUnitCurrencyRate;
        public StiPage Page1;
        public StiDataBand DataSP_GetSalesOrderHeader;
        public StiText Text2;
        public StiText Text1;
        public StiHeaderBand HeaderSP_GetSalesOrderDetail;
        public StiText HeaderSP_GetSalesOrderDetail_OrdinalNumber;
        public StiText HeaderSP_GetSalesOrderDetail_MedicamentName;
        public StiText HeaderSP_GetSalesOrderDetail_Serie;
        public StiText HeaderSP_GetSalesOrderDetail_ValidDate;
        public StiText HeaderSP_GetSalesOrderDetail_SaleQty;
        public StiText HeaderSP_GetSalesOrderDetail_SaleUnitPriceDiscount;
        public StiText HeaderSP_GetSalesOrderDetail_SaleLineTotal;
        public StiDataBand DataSP_GetSalesOrderDetail;
        public StiText DataSP_GetSalesOrderDetail_OrdinalNumber;
        public StiText DataSP_GetSalesOrderDetail_MedicamentName;
        public StiText DataSP_GetSalesOrderDetail_Serie;
        public StiText DataSP_GetSalesOrderDetail_ValidDate;
        public StiText DataSP_GetSalesOrderDetail_SaleQty;
        public StiText DataSP_GetSalesOrderDetail_SaleUnitPriceDiscount;
        public StiText DataSP_GetSalesOrderDetail_SaleLineTotal;
        public StiFooterBand FooterSP_GetSalesOrderDetail;
        public StiText Text3;
        public StiSumDecimalFunctionService Text3_Sum;
        public StiText Text4;
        public StiSumDecimalFunctionService Text4_Sum;
        public StiText Text5;
        public StiSumDecimalFunctionService Text5_Sum1;
        public StiSumDecimalFunctionService Text5_Sum3;
        public StiText Text6;
        public StiText Text7;
        public StiText Text8;
        public StiHorizontalLinePrimitive HorizontalLine2;
        public StiHorizontalLinePrimitive HorizontalLine1;
        public StiWatermark Page1_Watermark;
        public StiPrinterSettings RptSalesOrderDetailPurchasePrice_PrinterSettings;
        public SP_GetSalesOrderHeaderDataSource SP_GetSalesOrderHeader;
        public SP_GetSalesOrderDetailDataSource SP_GetSalesOrderDetail;

        public void Text2__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "გამავალი ფაქტურა №" + ToString(sender, SP_GetSalesOrderHeader.SalesOrderID, true) + "    თარიღი: " + ToString(sender, Format("{0:yyyy.MM.dd}", SP_GetSalesOrderHeader.OrderDate), true);
        }

        public void Text1__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, MyCompanyName, true) + "\r\nმის: " + ToString(sender, MyCompanyAddress, true) + ToString(sender, IIF(MyCompanyPhone.Length > 0, " ტელ:" + MyCompanyPhone, string.Empty), true) + "\r\nფილიალი: " + ToString(sender, SP_GetSalesOrderHeader.BranchName, true);
        }

        public void HeaderSP_GetSalesOrderDetail_OrdinalNumber__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "№";
        }

        public void HeaderSP_GetSalesOrderDetail_MedicamentName__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "მედიკამენტი";
        }

        public void HeaderSP_GetSalesOrderDetail_Serie__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "სერია";
        }

        public void HeaderSP_GetSalesOrderDetail_ValidDate__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ვადა";
        }

        public void HeaderSP_GetSalesOrderDetail_SaleQty__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "რაოდ.";
        }

        public void HeaderSP_GetSalesOrderDetail_SaleUnitPriceDiscount__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ფასი / შ.";
        }

        public void HeaderSP_GetSalesOrderDetail_SaleLineTotal__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ჯამი";
        }

        public void DataSP_GetSalesOrderDetail_OrdinalNumber__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Line, true);
        }

        public void DataSP_GetSalesOrderDetail_MedicamentName__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetSalesOrderDetail.MedicamentName, true);
        }

        public void DataSP_GetSalesOrderDetail_Serie__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetSalesOrderDetail.Serie, true);
        }

        public void DataSP_GetSalesOrderDetail_ValidDate__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = String.Format("{0:MM\\/yy}", SP_GetSalesOrderDetail.ValidDate);
        }

        public void DataSP_GetSalesOrderDetail_SaleQty__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = DataSP_GetSalesOrderDetail_SaleQty.TextFormat.Format(CheckExcelValue(sender, SP_GetSalesOrderDetail.SaleQty));
        }

        public void DataSP_GetSalesOrderDetail_SaleUnitPriceDiscount__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = DataSP_GetSalesOrderDetail_SaleUnitPriceDiscount.TextFormat.Format(CheckExcelValue(sender, SP_GetSalesOrderDetail.StandardCost));
        }

        public void DataSP_GetSalesOrderDetail_SaleLineTotal__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = DataSP_GetSalesOrderDetail_SaleLineTotal.TextFormat.Format(CheckExcelValue(sender, SP_GetSalesOrderDetail.PurchaseLineTotal));
        }

        public void Text3__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(SP_GetSalesOrderDetail.SaleQty)}";
            e.StoreToPrinted = true;
        }

        public String Text3_GetValue_End(StiComponent sender)
        {
            return Text3.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text3_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void Text4__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(SP_GetSalesOrderDetail.PurchaseLineTotal)}";
            e.StoreToPrinted = true;
        }

        public String Text4_GetValue_End(StiComponent sender)
        {
            return Text4.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text4_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void Text5__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = @"#%#პროდუქცია: {Format(""{0:N2}"", Sum(SP_GetSalesOrderDetail.PurchaseLineTotal))} {SP_GetSalesOrderDetail.SP_GetSalesOrderHeader.CurrencyCode}
ტრანსპორტირება: {Format(""{0:N2}"", SP_GetSalesOrderDetail.SP_GetSalesOrderHeader.Freight)} {SP_GetSalesOrderDetail.SP_GetSalesOrderHeader.CurrencyCode}
საგადასახადო: {Format(""{0:N2}"", SP_GetSalesOrderDetail.SP_GetSalesOrderHeader.TaxAmt)} {SP_GetSalesOrderDetail.SP_GetSalesOrderHeader.CurrencyCode}
თანხა სულ: {Format(""{0:N2}"", Round(Sum(SP_GetSalesOrderDetail.PurchaseLineTotal) + SP_GetSalesOrderDetail.SP_GetSalesOrderHeader.Freight + SP_GetSalesOrderDetail.SP_GetSalesOrderHeader.TaxAmt, 2))} {SP_GetSalesOrderDetail.SP_GetSalesOrderHeader.CurrencyCode}";
            e.StoreToPrinted = true;
        }

        public String Text5_GetValue_End(StiComponent sender)
        {
            return "პროდუქცია: " + ToString(sender, Format("{0:N2}", ((decimal)(ChangeType(Text5_Sum1.GetValue(), typeof(decimal), true)))), true) + " " + ToString(sender, SP_GetSalesOrderDetail.SP_GetSalesOrderHeader.CurrencyCode, true) + "\r\nტრანსპორტირება: " + ToString(sender, Format("{0:N2}", SP_GetSalesOrderDetail.SP_GetSalesOrderHeader.Freight), true) + " " + ToString(sender, SP_GetSalesOrderDetail.SP_GetSalesOrderHeader.CurrencyCode, true) + "\r\nსაგადასახადო: " + ToString(sender, Format("{0:N2}", SP_GetSalesOrderDetail.SP_GetSalesOrderHeader.TaxAmt), true) + " " + ToString(sender, SP_GetSalesOrderDetail.SP_GetSalesOrderHeader.CurrencyCode, true) + "\r\nთანხა სულ: " + ToString(sender, Format("{0:N2}", Math.Round(((decimal)(ChangeType(Text5_Sum3.GetValue(), typeof(decimal), true))) + SP_GetSalesOrderDetail.SP_GetSalesOrderHeader.Freight + SP_GetSalesOrderDetail.SP_GetSalesOrderHeader.TaxAmt, 2)), true) + " " + ToString(sender, SP_GetSalesOrderDetail.SP_GetSalesOrderHeader.CurrencyCode, true);
        }

        public void Text6__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "გასცა:";
        }

        public void Text7__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "მიიღო:";
        }

        public void Text8__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "სერტიფიცირებულია და ნებადართულია სარეალიზაციოდ";
        }

        public void DataSP_GetSalesOrderDetail__BeginRender(object sender, EventArgs e)
        {
            Text3_Sum.Init();
            Text3.TextValue = "";
            Text4_Sum.Init();
            Text4.TextValue = "";
            Text5_Sum1.Init();
            Text5.TextValue = "";
            Text5_Sum3.Init();
            Text5.TextValue = "";
        }

        public void DataSP_GetSalesOrderDetail__EndRender(object sender, EventArgs e)
        {
            Text3.SetText(new StiGetValue(Text3_GetValue_End));
            Text4.SetText(new StiGetValue(Text4_GetValue_End));
            Text5.SetText(new StiGetValue(Text5_GetValue_End));
        }

        public void DataSP_GetSalesOrderDetail__Rendering(object sender, EventArgs e)
        {
            Text3_Sum.CalcItem(SP_GetSalesOrderDetail.SaleQty);
            Text4_Sum.CalcItem(SP_GetSalesOrderDetail.PurchaseLineTotal);
            Text5_Sum1.CalcItem(SP_GetSalesOrderDetail.PurchaseLineTotal);
            Text5_Sum3.CalcItem(SP_GetSalesOrderDetail.PurchaseLineTotal);
        }

        private void InitializeComponent()
        {
            SP_GetSalesOrderDetail = new SP_GetSalesOrderDetailDataSource();
            SP_GetSalesOrderHeader = new SP_GetSalesOrderHeaderDataSource();
            ParentSP_GetSalesOrderHeader = new StiDataRelation("SP_GetSalesOrderHeader_SP_GetSalesOrderDetail", "SP_GetSalesOrderHeader", "SP_GetSalesOrderHeader", SP_GetSalesOrderHeader, SP_GetSalesOrderDetail, new[] {
                        "SalesOrderID"}, new[] {
                        "SalesOrderID"});
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyName", "MyCompanyName", typeof(string), "", false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyTaxCode", "MyCompanyTaxCode", typeof(string), "", false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyDirectorName", "MyCompanyDirectorName", typeof(string), "", false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyCountryCode", "MyCompanyCountryCode", typeof(string), "", false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyCountryName", "MyCompanyCountryName", typeof(string), "", false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyCity", "MyCompanyCity", typeof(string), "", false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyPostalCode", "MyCompanyPostalCode", typeof(string), "", false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyAddress", "MyCompanyAddress", typeof(string), "", false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyPhone", "MyCompanyPhone", typeof(string), "", false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyFax", "MyCompanyFax", typeof(string), "", false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyBankName", "MyCompanyBankName", typeof(string), "", false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyBankCode", "MyCompanyBankCode", typeof(string), "", false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyBankAccountNumber", "MyCompanyBankAccountNumber", typeof(string), "", false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyVATPayerFlag", "MyCompanyVATPayerFlag", typeof(bool), "", false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyConditionalUnitCurrencyCode", "MyCompanyConditionalUnitCurrencyCode", typeof(string), "", false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyDefaultTradingCurrencyCode", "MyCompanyDefaultTradingCurrencyCode", typeof(string), "", false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyConditionalUnitCurrencyRate", "MyCompanyConditionalUnitCurrencyRate", typeof(decimal), "", false, false));
            NeedsCompiling = false;
            Text5_Sum1 = new StiSumDecimalFunctionService();
            Text4_Sum = new StiSumDecimalFunctionService();
            Text5_Sum3 = new StiSumDecimalFunctionService();
            Text3_Sum = new StiSumDecimalFunctionService();
            // Variables init
            // Variables init
            MyCompanyName = "";
            MyCompanyTaxCode = "";
            MyCompanyDirectorName = "";
            MyCompanyCountryCode = "";
            MyCompanyCountryName = "";
            MyCompanyCity = "";
            MyCompanyPostalCode = "";
            MyCompanyAddress = "";
            MyCompanyPhone = "";
            MyCompanyFax = "";
            MyCompanyBankName = "";
            MyCompanyBankCode = "";
            MyCompanyBankAccountNumber = "";
            MyCompanyVATPayerFlag = false;
            MyCompanyConditionalUnitCurrencyCode = "";
            MyCompanyDefaultTradingCurrencyCode = "";
            MyCompanyConditionalUnitCurrencyRate = 0m;
            EngineVersion = StiEngineVersion.EngineV2;
            ReferencedAssemblies = new[] {
                    "System.Dll",
                    "System.Drawing.Dll",
                    "System.Windows.Forms.Dll",
                    "System.Data.Dll",
                    "System.Xml.Dll",
                    "Stimulsoft.Controls.Dll",
                    "Stimulsoft.Base.Dll",
                    "Stimulsoft.Report.Dll"};
            ReportAlias = "Rpt Sales Order Detail Purchase Price";
            ReportAuthor = "Programmer.GE";
            // 
            // ReportChanged
            // 
            ReportChanged = new DateTime(2010, 3, 21, 22, 27, 32, 703);
            // 
            // ReportCreated
            // 
            ReportCreated = new DateTime(2009, 2, 11, 22, 7, 37, 0);
            ReportDescription = "გაყიდვის დეტალური რეპორტი შესყიდვის ფასით";
            ReportFile = "D:\\My Documents\\Projects\\Apothex\\Source\\Class Library\\Apothex.Reporting\\Sales\\Rpt" +
"SalesOrderDetailPurchasePrice.mrt";
            ReportGuid = "180e8188e72b499c8488b449d2994c3e";
            ReportName = "RptSalesOrderDetailPurchasePrice";
            ReportUnit = StiReportUnitType.Centimeters;
            ScriptLanguage = StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            Page1 = new StiPage();
            Page1.Guid = "92ecb1451ebd45bd9476a3f60f57bcb1";
            Page1.Name = "Page1";
            Page1.PageHeight = 29.7;
            Page1.PageWidth = 21;
            Page1.PaperSize = PaperKind.A4;
            Page1.Border = new StiBorder(StiBorderSides.None, Color.Black, 2, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Page1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // DataSP_GetSalesOrderHeader
            // 
            DataSP_GetSalesOrderHeader = new StiDataBand();
            DataSP_GetSalesOrderHeader.ClientRectangle = new RectangleD(0, 0.4, 19, 2);
            DataSP_GetSalesOrderHeader.Name = "DataSP_GetSalesOrderHeader";
            DataSP_GetSalesOrderHeader.Sort = new String[0];
            DataSP_GetSalesOrderHeader.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetSalesOrderHeader.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text2
            // 
            Text2 = new StiText();
            Text2.ClientRectangle = new RectangleD(0, 0, 19, 0.6);
            Text2.Guid = "b81a3cea473147d7a268424c9cadc278";
            Text2.HorAlignment = StiTextHorAlignment.Center;
            Text2.Name = "Text2";
            Text2.GetValue += new StiGetValueEventHandler(Text2__GetValue);
            Text2.VertAlignment = StiVertAlignment.Center;
            Text2.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text2.Brush = new StiSolidBrush(Color.Transparent);
            Text2.Font = new Font("BPG Glaho Arial", 10F);
            Text2.Interaction = null;
            Text2.Margins = new StiMargins(0, 0, 0, 0);
            Text2.TextBrush = new StiSolidBrush(Color.Black);
            Text2.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text1
            // 
            Text1 = new StiText();
            Text1.ClientRectangle = new RectangleD(0, 0.6, 19, 1.4);
            Text1.Guid = "7c130ef7199f48e7ade68d7bda9f513b";
            Text1.Name = "Text1";
            Text1.GetValue += new StiGetValueEventHandler(Text1__GetValue);
            Text1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text1.Brush = new StiSolidBrush(Color.Transparent);
            Text1.Font = new Font("BPG Glaho Arial", 10F);
            Text1.Interaction = null;
            Text1.Margins = new StiMargins(0, 0, 0, 0);
            Text1.TextBrush = new StiSolidBrush(Color.Black);
            Text1.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            DataSP_GetSalesOrderHeader.DataRelationName = null;
            DataSP_GetSalesOrderHeader.Guid = null;
            DataSP_GetSalesOrderHeader.Interaction = null;
            DataSP_GetSalesOrderHeader.MasterComponent = null;
            // 
            // HeaderSP_GetSalesOrderDetail
            // 
            HeaderSP_GetSalesOrderDetail = new StiHeaderBand();
            HeaderSP_GetSalesOrderDetail.ClientRectangle = new RectangleD(0, 3.2, 19, 0.6);
            HeaderSP_GetSalesOrderDetail.Name = "HeaderSP_GetSalesOrderDetail";
            HeaderSP_GetSalesOrderDetail.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderSP_GetSalesOrderDetail.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // HeaderSP_GetSalesOrderDetail_OrdinalNumber
            // 
            HeaderSP_GetSalesOrderDetail_OrdinalNumber = new StiText();
            HeaderSP_GetSalesOrderDetail_OrdinalNumber.ClientRectangle = new RectangleD(0, 0, 1, 0.6);
            HeaderSP_GetSalesOrderDetail_OrdinalNumber.HorAlignment = StiTextHorAlignment.Center;
            HeaderSP_GetSalesOrderDetail_OrdinalNumber.Name = "HeaderSP_GetSalesOrderDetail_OrdinalNumber";
            HeaderSP_GetSalesOrderDetail_OrdinalNumber.GetValue += new StiGetValueEventHandler(HeaderSP_GetSalesOrderDetail_OrdinalNumber__GetValue);
            HeaderSP_GetSalesOrderDetail_OrdinalNumber.VertAlignment = StiVertAlignment.Center;
            HeaderSP_GetSalesOrderDetail_OrdinalNumber.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderSP_GetSalesOrderDetail_OrdinalNumber.Brush = new StiSolidBrush(Color.Transparent);
            HeaderSP_GetSalesOrderDetail_OrdinalNumber.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderSP_GetSalesOrderDetail_OrdinalNumber.Guid = null;
            HeaderSP_GetSalesOrderDetail_OrdinalNumber.Interaction = null;
            HeaderSP_GetSalesOrderDetail_OrdinalNumber.Margins = new StiMargins(0, 0, 0, 0);
            HeaderSP_GetSalesOrderDetail_OrdinalNumber.TextBrush = new StiSolidBrush(Color.Black);
            HeaderSP_GetSalesOrderDetail_OrdinalNumber.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderSP_GetSalesOrderDetail_MedicamentName
            // 
            HeaderSP_GetSalesOrderDetail_MedicamentName = new StiText();
            HeaderSP_GetSalesOrderDetail_MedicamentName.ClientRectangle = new RectangleD(1, 0, 7.4, 0.6);
            HeaderSP_GetSalesOrderDetail_MedicamentName.HorAlignment = StiTextHorAlignment.Center;
            HeaderSP_GetSalesOrderDetail_MedicamentName.Name = "HeaderSP_GetSalesOrderDetail_MedicamentName";
            HeaderSP_GetSalesOrderDetail_MedicamentName.GetValue += new StiGetValueEventHandler(HeaderSP_GetSalesOrderDetail_MedicamentName__GetValue);
            HeaderSP_GetSalesOrderDetail_MedicamentName.VertAlignment = StiVertAlignment.Center;
            HeaderSP_GetSalesOrderDetail_MedicamentName.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderSP_GetSalesOrderDetail_MedicamentName.Brush = new StiSolidBrush(Color.Transparent);
            HeaderSP_GetSalesOrderDetail_MedicamentName.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderSP_GetSalesOrderDetail_MedicamentName.Guid = null;
            HeaderSP_GetSalesOrderDetail_MedicamentName.Interaction = null;
            HeaderSP_GetSalesOrderDetail_MedicamentName.Margins = new StiMargins(0, 0, 0, 0);
            HeaderSP_GetSalesOrderDetail_MedicamentName.TextBrush = new StiSolidBrush(Color.Black);
            HeaderSP_GetSalesOrderDetail_MedicamentName.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderSP_GetSalesOrderDetail_Serie
            // 
            HeaderSP_GetSalesOrderDetail_Serie = new StiText();
            HeaderSP_GetSalesOrderDetail_Serie.ClientRectangle = new RectangleD(8.4, 0, 3, 0.6);
            HeaderSP_GetSalesOrderDetail_Serie.HorAlignment = StiTextHorAlignment.Center;
            HeaderSP_GetSalesOrderDetail_Serie.Name = "HeaderSP_GetSalesOrderDetail_Serie";
            HeaderSP_GetSalesOrderDetail_Serie.GetValue += new StiGetValueEventHandler(HeaderSP_GetSalesOrderDetail_Serie__GetValue);
            HeaderSP_GetSalesOrderDetail_Serie.VertAlignment = StiVertAlignment.Center;
            HeaderSP_GetSalesOrderDetail_Serie.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderSP_GetSalesOrderDetail_Serie.Brush = new StiSolidBrush(Color.Transparent);
            HeaderSP_GetSalesOrderDetail_Serie.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderSP_GetSalesOrderDetail_Serie.Guid = null;
            HeaderSP_GetSalesOrderDetail_Serie.Interaction = null;
            HeaderSP_GetSalesOrderDetail_Serie.Margins = new StiMargins(0, 0, 0, 0);
            HeaderSP_GetSalesOrderDetail_Serie.TextBrush = new StiSolidBrush(Color.Black);
            HeaderSP_GetSalesOrderDetail_Serie.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderSP_GetSalesOrderDetail_ValidDate
            // 
            HeaderSP_GetSalesOrderDetail_ValidDate = new StiText();
            HeaderSP_GetSalesOrderDetail_ValidDate.ClientRectangle = new RectangleD(11.4, 0, 1.2, 0.6);
            HeaderSP_GetSalesOrderDetail_ValidDate.HorAlignment = StiTextHorAlignment.Center;
            HeaderSP_GetSalesOrderDetail_ValidDate.Name = "HeaderSP_GetSalesOrderDetail_ValidDate";
            HeaderSP_GetSalesOrderDetail_ValidDate.GetValue += new StiGetValueEventHandler(HeaderSP_GetSalesOrderDetail_ValidDate__GetValue);
            HeaderSP_GetSalesOrderDetail_ValidDate.VertAlignment = StiVertAlignment.Center;
            HeaderSP_GetSalesOrderDetail_ValidDate.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderSP_GetSalesOrderDetail_ValidDate.Brush = new StiSolidBrush(Color.Transparent);
            HeaderSP_GetSalesOrderDetail_ValidDate.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderSP_GetSalesOrderDetail_ValidDate.Guid = null;
            HeaderSP_GetSalesOrderDetail_ValidDate.Interaction = null;
            HeaderSP_GetSalesOrderDetail_ValidDate.Margins = new StiMargins(0, 0, 0, 0);
            HeaderSP_GetSalesOrderDetail_ValidDate.TextBrush = new StiSolidBrush(Color.Black);
            HeaderSP_GetSalesOrderDetail_ValidDate.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderSP_GetSalesOrderDetail_SaleQty
            // 
            HeaderSP_GetSalesOrderDetail_SaleQty = new StiText();
            HeaderSP_GetSalesOrderDetail_SaleQty.ClientRectangle = new RectangleD(12.6, 0, 2, 0.6);
            HeaderSP_GetSalesOrderDetail_SaleQty.HorAlignment = StiTextHorAlignment.Center;
            HeaderSP_GetSalesOrderDetail_SaleQty.Name = "HeaderSP_GetSalesOrderDetail_SaleQty";
            HeaderSP_GetSalesOrderDetail_SaleQty.GetValue += new StiGetValueEventHandler(HeaderSP_GetSalesOrderDetail_SaleQty__GetValue);
            HeaderSP_GetSalesOrderDetail_SaleQty.VertAlignment = StiVertAlignment.Center;
            HeaderSP_GetSalesOrderDetail_SaleQty.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderSP_GetSalesOrderDetail_SaleQty.Brush = new StiSolidBrush(Color.Transparent);
            HeaderSP_GetSalesOrderDetail_SaleQty.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderSP_GetSalesOrderDetail_SaleQty.Guid = null;
            HeaderSP_GetSalesOrderDetail_SaleQty.Interaction = null;
            HeaderSP_GetSalesOrderDetail_SaleQty.Margins = new StiMargins(0, 0, 0, 0);
            HeaderSP_GetSalesOrderDetail_SaleQty.TextBrush = new StiSolidBrush(Color.Black);
            HeaderSP_GetSalesOrderDetail_SaleQty.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderSP_GetSalesOrderDetail_SaleUnitPriceDiscount
            // 
            HeaderSP_GetSalesOrderDetail_SaleUnitPriceDiscount = new StiText();
            HeaderSP_GetSalesOrderDetail_SaleUnitPriceDiscount.ClientRectangle = new RectangleD(14.6, 0, 2.2, 0.6);
            HeaderSP_GetSalesOrderDetail_SaleUnitPriceDiscount.HorAlignment = StiTextHorAlignment.Center;
            HeaderSP_GetSalesOrderDetail_SaleUnitPriceDiscount.Name = "HeaderSP_GetSalesOrderDetail_SaleUnitPriceDiscount";
            HeaderSP_GetSalesOrderDetail_SaleUnitPriceDiscount.GetValue += new StiGetValueEventHandler(HeaderSP_GetSalesOrderDetail_SaleUnitPriceDiscount__GetValue);
            HeaderSP_GetSalesOrderDetail_SaleUnitPriceDiscount.VertAlignment = StiVertAlignment.Center;
            HeaderSP_GetSalesOrderDetail_SaleUnitPriceDiscount.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderSP_GetSalesOrderDetail_SaleUnitPriceDiscount.Brush = new StiSolidBrush(Color.Transparent);
            HeaderSP_GetSalesOrderDetail_SaleUnitPriceDiscount.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderSP_GetSalesOrderDetail_SaleUnitPriceDiscount.Guid = null;
            HeaderSP_GetSalesOrderDetail_SaleUnitPriceDiscount.Interaction = null;
            HeaderSP_GetSalesOrderDetail_SaleUnitPriceDiscount.Margins = new StiMargins(0, 0, 0, 0);
            HeaderSP_GetSalesOrderDetail_SaleUnitPriceDiscount.TextBrush = new StiSolidBrush(Color.Black);
            HeaderSP_GetSalesOrderDetail_SaleUnitPriceDiscount.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderSP_GetSalesOrderDetail_SaleLineTotal
            // 
            HeaderSP_GetSalesOrderDetail_SaleLineTotal = new StiText();
            HeaderSP_GetSalesOrderDetail_SaleLineTotal.ClientRectangle = new RectangleD(16.8, 0, 2.2, 0.6);
            HeaderSP_GetSalesOrderDetail_SaleLineTotal.HorAlignment = StiTextHorAlignment.Center;
            HeaderSP_GetSalesOrderDetail_SaleLineTotal.Name = "HeaderSP_GetSalesOrderDetail_SaleLineTotal";
            HeaderSP_GetSalesOrderDetail_SaleLineTotal.GetValue += new StiGetValueEventHandler(HeaderSP_GetSalesOrderDetail_SaleLineTotal__GetValue);
            HeaderSP_GetSalesOrderDetail_SaleLineTotal.VertAlignment = StiVertAlignment.Center;
            HeaderSP_GetSalesOrderDetail_SaleLineTotal.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderSP_GetSalesOrderDetail_SaleLineTotal.Brush = new StiSolidBrush(Color.Transparent);
            HeaderSP_GetSalesOrderDetail_SaleLineTotal.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderSP_GetSalesOrderDetail_SaleLineTotal.Guid = null;
            HeaderSP_GetSalesOrderDetail_SaleLineTotal.Interaction = null;
            HeaderSP_GetSalesOrderDetail_SaleLineTotal.Margins = new StiMargins(0, 0, 0, 0);
            HeaderSP_GetSalesOrderDetail_SaleLineTotal.TextBrush = new StiSolidBrush(Color.Black);
            HeaderSP_GetSalesOrderDetail_SaleLineTotal.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            HeaderSP_GetSalesOrderDetail.Guid = null;
            HeaderSP_GetSalesOrderDetail.Interaction = null;
            // 
            // DataSP_GetSalesOrderDetail
            // 
            DataSP_GetSalesOrderDetail = new StiDataBand();
            DataSP_GetSalesOrderDetail.ClientRectangle = new RectangleD(0, 4.6, 19, 0.8);
            DataSP_GetSalesOrderDetail.DataRelationName = "SP_GetSalesOrderHeader_SP_GetSalesOrderDetail";
            DataSP_GetSalesOrderDetail.DataSourceName = "SP_GetSalesOrderDetail";
            DataSP_GetSalesOrderDetail.Name = "DataSP_GetSalesOrderDetail";
            DataSP_GetSalesOrderDetail.Sort = new[] {
                    "ASC",
                    "OrdinalNumber"};
            DataSP_GetSalesOrderDetail.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetSalesOrderDetail.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // DataSP_GetSalesOrderDetail_OrdinalNumber
            // 
            DataSP_GetSalesOrderDetail_OrdinalNumber = new StiText();
            DataSP_GetSalesOrderDetail_OrdinalNumber.ClientRectangle = new RectangleD(0, 0, 1, 0.8);
            DataSP_GetSalesOrderDetail_OrdinalNumber.Name = "DataSP_GetSalesOrderDetail_OrdinalNumber";
            DataSP_GetSalesOrderDetail_OrdinalNumber.GetValue += new StiGetValueEventHandler(DataSP_GetSalesOrderDetail_OrdinalNumber__GetValue);
            DataSP_GetSalesOrderDetail_OrdinalNumber.VertAlignment = StiVertAlignment.Center;
            DataSP_GetSalesOrderDetail_OrdinalNumber.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetSalesOrderDetail_OrdinalNumber.Brush = new StiSolidBrush(Color.Transparent);
            DataSP_GetSalesOrderDetail_OrdinalNumber.Font = new Font("BPG Glaho Arial", 9F);
            DataSP_GetSalesOrderDetail_OrdinalNumber.Guid = null;
            DataSP_GetSalesOrderDetail_OrdinalNumber.Interaction = null;
            DataSP_GetSalesOrderDetail_OrdinalNumber.Margins = new StiMargins(0, 0, 0, 0);
            DataSP_GetSalesOrderDetail_OrdinalNumber.TextBrush = new StiSolidBrush(Color.Black);
            DataSP_GetSalesOrderDetail_OrdinalNumber.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataSP_GetSalesOrderDetail_MedicamentName
            // 
            DataSP_GetSalesOrderDetail_MedicamentName = new StiText();
            DataSP_GetSalesOrderDetail_MedicamentName.ClientRectangle = new RectangleD(1, 0, 7.4, 0.8);
            DataSP_GetSalesOrderDetail_MedicamentName.Name = "DataSP_GetSalesOrderDetail_MedicamentName";
            DataSP_GetSalesOrderDetail_MedicamentName.GetValue += new StiGetValueEventHandler(DataSP_GetSalesOrderDetail_MedicamentName__GetValue);
            DataSP_GetSalesOrderDetail_MedicamentName.VertAlignment = StiVertAlignment.Center;
            DataSP_GetSalesOrderDetail_MedicamentName.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetSalesOrderDetail_MedicamentName.Brush = new StiSolidBrush(Color.Transparent);
            DataSP_GetSalesOrderDetail_MedicamentName.Font = new Font("BPG Glaho Arial", 9F);
            DataSP_GetSalesOrderDetail_MedicamentName.Guid = null;
            DataSP_GetSalesOrderDetail_MedicamentName.Interaction = null;
            DataSP_GetSalesOrderDetail_MedicamentName.Margins = new StiMargins(0, 0, 0, 0);
            DataSP_GetSalesOrderDetail_MedicamentName.TextBrush = new StiSolidBrush(Color.Black);
            DataSP_GetSalesOrderDetail_MedicamentName.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.EllipsisCharacter);
            // 
            // DataSP_GetSalesOrderDetail_Serie
            // 
            DataSP_GetSalesOrderDetail_Serie = new StiText();
            DataSP_GetSalesOrderDetail_Serie.ClientRectangle = new RectangleD(8.4, 0, 3, 0.8);
            DataSP_GetSalesOrderDetail_Serie.Name = "DataSP_GetSalesOrderDetail_Serie";
            DataSP_GetSalesOrderDetail_Serie.GetValue += new StiGetValueEventHandler(DataSP_GetSalesOrderDetail_Serie__GetValue);
            DataSP_GetSalesOrderDetail_Serie.VertAlignment = StiVertAlignment.Center;
            DataSP_GetSalesOrderDetail_Serie.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetSalesOrderDetail_Serie.Brush = new StiSolidBrush(Color.Transparent);
            DataSP_GetSalesOrderDetail_Serie.Font = new Font("BPG Glaho Arial", 9F);
            DataSP_GetSalesOrderDetail_Serie.Guid = null;
            DataSP_GetSalesOrderDetail_Serie.Interaction = null;
            DataSP_GetSalesOrderDetail_Serie.Margins = new StiMargins(0, 0, 0, 0);
            DataSP_GetSalesOrderDetail_Serie.TextBrush = new StiSolidBrush(Color.Black);
            DataSP_GetSalesOrderDetail_Serie.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataSP_GetSalesOrderDetail_ValidDate
            // 
            DataSP_GetSalesOrderDetail_ValidDate = new StiText();
            DataSP_GetSalesOrderDetail_ValidDate.ClientRectangle = new RectangleD(11.4, 0, 1.2, 0.8);
            DataSP_GetSalesOrderDetail_ValidDate.Name = "DataSP_GetSalesOrderDetail_ValidDate";
            DataSP_GetSalesOrderDetail_ValidDate.GetValue += new StiGetValueEventHandler(DataSP_GetSalesOrderDetail_ValidDate__GetValue);
            DataSP_GetSalesOrderDetail_ValidDate.VertAlignment = StiVertAlignment.Center;
            DataSP_GetSalesOrderDetail_ValidDate.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetSalesOrderDetail_ValidDate.Brush = new StiSolidBrush(Color.Transparent);
            DataSP_GetSalesOrderDetail_ValidDate.Font = new Font("BPG Glaho Arial", 9F);
            DataSP_GetSalesOrderDetail_ValidDate.Guid = null;
            DataSP_GetSalesOrderDetail_ValidDate.Interaction = null;
            DataSP_GetSalesOrderDetail_ValidDate.Margins = new StiMargins(0, 0, 0, 0);
            DataSP_GetSalesOrderDetail_ValidDate.TextBrush = new StiSolidBrush(Color.Black);
            DataSP_GetSalesOrderDetail_ValidDate.TextFormat = new StiCustomFormatService("MM\\/yy");
            DataSP_GetSalesOrderDetail_ValidDate.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataSP_GetSalesOrderDetail_SaleQty
            // 
            DataSP_GetSalesOrderDetail_SaleQty = new StiText();
            DataSP_GetSalesOrderDetail_SaleQty.ClientRectangle = new RectangleD(12.6, 0, 2, 0.8);
            DataSP_GetSalesOrderDetail_SaleQty.HorAlignment = StiTextHorAlignment.Right;
            DataSP_GetSalesOrderDetail_SaleQty.Name = "DataSP_GetSalesOrderDetail_SaleQty";
            DataSP_GetSalesOrderDetail_SaleQty.GetValue += new StiGetValueEventHandler(DataSP_GetSalesOrderDetail_SaleQty__GetValue);
            DataSP_GetSalesOrderDetail_SaleQty.VertAlignment = StiVertAlignment.Center;
            DataSP_GetSalesOrderDetail_SaleQty.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetSalesOrderDetail_SaleQty.Brush = new StiSolidBrush(Color.Transparent);
            DataSP_GetSalesOrderDetail_SaleQty.Font = new Font("BPG Glaho Arial", 9F);
            DataSP_GetSalesOrderDetail_SaleQty.Guid = null;
            DataSP_GetSalesOrderDetail_SaleQty.Interaction = null;
            DataSP_GetSalesOrderDetail_SaleQty.Margins = new StiMargins(0, 0, 0, 0);
            DataSP_GetSalesOrderDetail_SaleQty.TextBrush = new StiSolidBrush(Color.Black);
            DataSP_GetSalesOrderDetail_SaleQty.TextFormat = new StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            DataSP_GetSalesOrderDetail_SaleQty.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataSP_GetSalesOrderDetail_SaleUnitPriceDiscount
            // 
            DataSP_GetSalesOrderDetail_SaleUnitPriceDiscount = new StiText();
            DataSP_GetSalesOrderDetail_SaleUnitPriceDiscount.ClientRectangle = new RectangleD(14.6, 0, 2.2, 0.8);
            DataSP_GetSalesOrderDetail_SaleUnitPriceDiscount.HorAlignment = StiTextHorAlignment.Right;
            DataSP_GetSalesOrderDetail_SaleUnitPriceDiscount.Name = "DataSP_GetSalesOrderDetail_SaleUnitPriceDiscount";
            DataSP_GetSalesOrderDetail_SaleUnitPriceDiscount.GetValue += new StiGetValueEventHandler(DataSP_GetSalesOrderDetail_SaleUnitPriceDiscount__GetValue);
            DataSP_GetSalesOrderDetail_SaleUnitPriceDiscount.VertAlignment = StiVertAlignment.Center;
            DataSP_GetSalesOrderDetail_SaleUnitPriceDiscount.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetSalesOrderDetail_SaleUnitPriceDiscount.Brush = new StiSolidBrush(Color.Transparent);
            DataSP_GetSalesOrderDetail_SaleUnitPriceDiscount.Font = new Font("BPG Glaho Arial", 9F);
            DataSP_GetSalesOrderDetail_SaleUnitPriceDiscount.Guid = null;
            DataSP_GetSalesOrderDetail_SaleUnitPriceDiscount.Interaction = null;
            DataSP_GetSalesOrderDetail_SaleUnitPriceDiscount.Margins = new StiMargins(0, 0, 0, 0);
            DataSP_GetSalesOrderDetail_SaleUnitPriceDiscount.TextBrush = new StiSolidBrush(Color.Black);
            DataSP_GetSalesOrderDetail_SaleUnitPriceDiscount.TextFormat = new StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            DataSP_GetSalesOrderDetail_SaleUnitPriceDiscount.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataSP_GetSalesOrderDetail_SaleLineTotal
            // 
            DataSP_GetSalesOrderDetail_SaleLineTotal = new StiText();
            DataSP_GetSalesOrderDetail_SaleLineTotal.ClientRectangle = new RectangleD(16.8, 0, 2.2, 0.8);
            DataSP_GetSalesOrderDetail_SaleLineTotal.HorAlignment = StiTextHorAlignment.Right;
            DataSP_GetSalesOrderDetail_SaleLineTotal.Name = "DataSP_GetSalesOrderDetail_SaleLineTotal";
            DataSP_GetSalesOrderDetail_SaleLineTotal.GetValue += new StiGetValueEventHandler(DataSP_GetSalesOrderDetail_SaleLineTotal__GetValue);
            DataSP_GetSalesOrderDetail_SaleLineTotal.VertAlignment = StiVertAlignment.Center;
            DataSP_GetSalesOrderDetail_SaleLineTotal.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetSalesOrderDetail_SaleLineTotal.Brush = new StiSolidBrush(Color.Transparent);
            DataSP_GetSalesOrderDetail_SaleLineTotal.Font = new Font("BPG Glaho Arial", 9F);
            DataSP_GetSalesOrderDetail_SaleLineTotal.Guid = null;
            DataSP_GetSalesOrderDetail_SaleLineTotal.Interaction = null;
            DataSP_GetSalesOrderDetail_SaleLineTotal.Margins = new StiMargins(0, 0, 0, 0);
            DataSP_GetSalesOrderDetail_SaleLineTotal.TextBrush = new StiSolidBrush(Color.Black);
            DataSP_GetSalesOrderDetail_SaleLineTotal.TextFormat = new StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            DataSP_GetSalesOrderDetail_SaleLineTotal.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            DataSP_GetSalesOrderDetail.Guid = null;
            DataSP_GetSalesOrderDetail.Interaction = null;
            // 
            // FooterSP_GetSalesOrderDetail
            // 
            FooterSP_GetSalesOrderDetail = new StiFooterBand();
            FooterSP_GetSalesOrderDetail.ClientRectangle = new RectangleD(0, 6.2, 19, 4.4);
            FooterSP_GetSalesOrderDetail.Name = "FooterSP_GetSalesOrderDetail";
            FooterSP_GetSalesOrderDetail.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            FooterSP_GetSalesOrderDetail.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text3
            // 
            Text3 = new StiText();
            Text3.ClientRectangle = new RectangleD(12.6, 0, 2, 0.6);
            Text3.Guid = "9d2e1e11f5d448a1981310c3acc9d407";
            Text3.HorAlignment = StiTextHorAlignment.Right;
            Text3.Name = "Text3";
            // 
            // Text3_Sum
            // 
            Text3.GetValue += new StiGetValueEventHandler(Text3__GetValue);
            Text3.VertAlignment = StiVertAlignment.Center;
            Text3.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text3.Brush = new StiSolidBrush(Color.Transparent);
            Text3.Font = new Font("BPG Glaho Arial", 10F);
            Text3.Interaction = null;
            Text3.Margins = new StiMargins(0, 0, 0, 0);
            Text3.TextBrush = new StiSolidBrush(Color.Black);
            Text3.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            Text3.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text4
            // 
            Text4 = new StiText();
            Text4.ClientRectangle = new RectangleD(16.8, 0, 2.2, 0.6);
            Text4.Guid = "0aa69d80280644fcb6b01d107b2396dd";
            Text4.HorAlignment = StiTextHorAlignment.Right;
            Text4.Name = "Text4";
            // 
            // Text4_Sum
            // 
            Text4.GetValue += new StiGetValueEventHandler(Text4__GetValue);
            Text4.VertAlignment = StiVertAlignment.Center;
            Text4.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text4.Brush = new StiSolidBrush(Color.Transparent);
            Text4.Font = new Font("BPG Glaho Arial", 10F);
            Text4.Interaction = null;
            Text4.Margins = new StiMargins(0, 0, 0, 0);
            Text4.TextBrush = new StiSolidBrush(Color.Black);
            Text4.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            Text4.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text5
            // 
            Text5 = new StiText();
            Text5.ClientRectangle = new RectangleD(0, 0.8, 19, 1.8);
            Text5.Guid = "e6abd5f176714126923f1dbb6bf16f4a";
            Text5.HorAlignment = StiTextHorAlignment.Right;
            Text5.Name = "Text5";
            // 
            // Text5_Sum1
            // 
            // 
            // Text5_Sum3
            // 
            Text5.GetValue += new StiGetValueEventHandler(Text5__GetValue);
            Text5.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text5.Brush = new StiSolidBrush(Color.Transparent);
            Text5.Font = new Font("BPG Glaho Arial", 10F);
            Text5.Interaction = null;
            Text5.Margins = new StiMargins(0, 0, 0, 0);
            Text5.TextBrush = new StiSolidBrush(Color.Black);
            Text5.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text6
            // 
            Text6 = new StiText();
            Text6.ClientRectangle = new RectangleD(6.2, 3.8, 1.6, 0.6);
            Text6.Guid = "9fc217734a864bd0a47b12a7405bda2d";
            Text6.HorAlignment = StiTextHorAlignment.Right;
            Text6.Name = "Text6";
            Text6.GetValue += new StiGetValueEventHandler(Text6__GetValue);
            Text6.VertAlignment = StiVertAlignment.Center;
            Text6.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text6.Brush = new StiSolidBrush(Color.Transparent);
            Text6.Font = new Font("BPG Glaho Arial", 10F);
            Text6.Interaction = null;
            Text6.Margins = new StiMargins(0, 0, 0, 0);
            Text6.TextBrush = new StiSolidBrush(Color.Black);
            Text6.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text7
            // 
            Text7 = new StiText();
            Text7.ClientRectangle = new RectangleD(12.8, 3.8, 1.6, 0.6);
            Text7.Guid = "0c56763cd51c471d9bacf71bfb226a5e";
            Text7.HorAlignment = StiTextHorAlignment.Right;
            Text7.Name = "Text7";
            Text7.GetValue += new StiGetValueEventHandler(Text7__GetValue);
            Text7.VertAlignment = StiVertAlignment.Center;
            Text7.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text7.Brush = new StiSolidBrush(Color.Transparent);
            Text7.Font = new Font("BPG Glaho Arial", 10F);
            Text7.Interaction = null;
            Text7.Margins = new StiMargins(0, 0, 0, 0);
            Text7.TextBrush = new StiSolidBrush(Color.Black);
            Text7.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text8
            // 
            Text8 = new StiText();
            Text8.ClientRectangle = new RectangleD(6.2, 2.8, 12.8, 0.6);
            Text8.HorAlignment = StiTextHorAlignment.Right;
            Text8.Name = "Text8";
            Text8.GetValue += new StiGetValueEventHandler(Text8__GetValue);
            Text8.VertAlignment = StiVertAlignment.Center;
            Text8.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text8.Brush = new StiSolidBrush(Color.Transparent);
            Text8.Font = new Font("BPG Glaho Arial", 10F);
            Text8.Guid = null;
            Text8.Interaction = null;
            Text8.Margins = new StiMargins(0, 0, 0, 0);
            Text8.TextBrush = new StiSolidBrush(Color.Black);
            Text8.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HorizontalLine2
            // 
            HorizontalLine2 = new StiHorizontalLinePrimitive();
            HorizontalLine2.ClientRectangle = new RectangleD(7.8, 4.2, 4.6, 0.0254);
            HorizontalLine2.Color = Color.Black;
            HorizontalLine2.Guid = "9bfc533c670b4aa995b8979d25645c50";
            HorizontalLine2.Name = "HorizontalLine2";
            HorizontalLine2.Style = StiPenStyle.Dot;
            HorizontalLine2.Interaction = null;
            // 
            // HorizontalLine1
            // 
            HorizontalLine1 = new StiHorizontalLinePrimitive();
            HorizontalLine1.ClientRectangle = new RectangleD(14.4, 4.2, 4.6, 0.0254);
            HorizontalLine1.Color = Color.Black;
            HorizontalLine1.Guid = "3e01951480944758bac76a42fc4fe0ca";
            HorizontalLine1.Name = "HorizontalLine1";
            HorizontalLine1.Style = StiPenStyle.Dot;
            HorizontalLine1.Interaction = null;
            FooterSP_GetSalesOrderDetail.Guid = null;
            FooterSP_GetSalesOrderDetail.Interaction = null;
            Page1.ExcelSheetValue = null;
            Page1.Interaction = null;
            Page1.Margins = new StiMargins(1, 1, 1, 1);
            Page1_Watermark = new StiWatermark();
            Page1_Watermark.Font = new Font("Arial", 100F);
            Page1_Watermark.Image = null;
            Page1_Watermark.TextBrush = new StiSolidBrush(Color.FromArgb(50, 0, 0, 0));
            RptSalesOrderDetailPurchasePrice_PrinterSettings = new StiPrinterSettings();
            PrinterSettings = RptSalesOrderDetailPurchasePrice_PrinterSettings;
            Page1.Page = Page1;
            Page1.Report = this;
            Page1.Watermark = Page1_Watermark;
            DataSP_GetSalesOrderHeader.Page = Page1;
            DataSP_GetSalesOrderHeader.Parent = Page1;
            Text2.Page = Page1;
            Text2.Parent = DataSP_GetSalesOrderHeader;
            Text1.Page = Page1;
            Text1.Parent = DataSP_GetSalesOrderHeader;
            HeaderSP_GetSalesOrderDetail.Page = Page1;
            HeaderSP_GetSalesOrderDetail.Parent = Page1;
            HeaderSP_GetSalesOrderDetail_OrdinalNumber.Page = Page1;
            HeaderSP_GetSalesOrderDetail_OrdinalNumber.Parent = HeaderSP_GetSalesOrderDetail;
            HeaderSP_GetSalesOrderDetail_MedicamentName.Page = Page1;
            HeaderSP_GetSalesOrderDetail_MedicamentName.Parent = HeaderSP_GetSalesOrderDetail;
            HeaderSP_GetSalesOrderDetail_Serie.Page = Page1;
            HeaderSP_GetSalesOrderDetail_Serie.Parent = HeaderSP_GetSalesOrderDetail;
            HeaderSP_GetSalesOrderDetail_ValidDate.Page = Page1;
            HeaderSP_GetSalesOrderDetail_ValidDate.Parent = HeaderSP_GetSalesOrderDetail;
            HeaderSP_GetSalesOrderDetail_SaleQty.Page = Page1;
            HeaderSP_GetSalesOrderDetail_SaleQty.Parent = HeaderSP_GetSalesOrderDetail;
            HeaderSP_GetSalesOrderDetail_SaleUnitPriceDiscount.Page = Page1;
            HeaderSP_GetSalesOrderDetail_SaleUnitPriceDiscount.Parent = HeaderSP_GetSalesOrderDetail;
            HeaderSP_GetSalesOrderDetail_SaleLineTotal.Page = Page1;
            HeaderSP_GetSalesOrderDetail_SaleLineTotal.Parent = HeaderSP_GetSalesOrderDetail;
            DataSP_GetSalesOrderDetail.MasterComponent = DataSP_GetSalesOrderHeader;
            DataSP_GetSalesOrderDetail.Page = Page1;
            DataSP_GetSalesOrderDetail.Parent = Page1;
            DataSP_GetSalesOrderDetail_OrdinalNumber.Page = Page1;
            DataSP_GetSalesOrderDetail_OrdinalNumber.Parent = DataSP_GetSalesOrderDetail;
            DataSP_GetSalesOrderDetail_MedicamentName.Page = Page1;
            DataSP_GetSalesOrderDetail_MedicamentName.Parent = DataSP_GetSalesOrderDetail;
            DataSP_GetSalesOrderDetail_Serie.Page = Page1;
            DataSP_GetSalesOrderDetail_Serie.Parent = DataSP_GetSalesOrderDetail;
            DataSP_GetSalesOrderDetail_ValidDate.Page = Page1;
            DataSP_GetSalesOrderDetail_ValidDate.Parent = DataSP_GetSalesOrderDetail;
            DataSP_GetSalesOrderDetail_SaleQty.Page = Page1;
            DataSP_GetSalesOrderDetail_SaleQty.Parent = DataSP_GetSalesOrderDetail;
            DataSP_GetSalesOrderDetail_SaleUnitPriceDiscount.Page = Page1;
            DataSP_GetSalesOrderDetail_SaleUnitPriceDiscount.Parent = DataSP_GetSalesOrderDetail;
            DataSP_GetSalesOrderDetail_SaleLineTotal.Page = Page1;
            DataSP_GetSalesOrderDetail_SaleLineTotal.Parent = DataSP_GetSalesOrderDetail;
            FooterSP_GetSalesOrderDetail.Page = Page1;
            FooterSP_GetSalesOrderDetail.Parent = Page1;
            Text3.Page = Page1;
            Text3.Parent = FooterSP_GetSalesOrderDetail;
            Text4.Page = Page1;
            Text4.Parent = FooterSP_GetSalesOrderDetail;
            Text5.Page = Page1;
            Text5.Parent = FooterSP_GetSalesOrderDetail;
            Text6.Page = Page1;
            Text6.Parent = FooterSP_GetSalesOrderDetail;
            Text7.Page = Page1;
            Text7.Parent = FooterSP_GetSalesOrderDetail;
            Text8.Page = Page1;
            Text8.Parent = FooterSP_GetSalesOrderDetail;
            HorizontalLine2.Page = Page1;
            HorizontalLine2.Parent = FooterSP_GetSalesOrderDetail;
            HorizontalLine1.Page = Page1;
            HorizontalLine1.Parent = FooterSP_GetSalesOrderDetail;
            DataSP_GetSalesOrderDetail.BeginRender += new EventHandler(DataSP_GetSalesOrderDetail__BeginRender);
            DataSP_GetSalesOrderDetail.EndRender += new EventHandler(DataSP_GetSalesOrderDetail__EndRender);
            DataSP_GetSalesOrderDetail.Rendering += new EventHandler(DataSP_GetSalesOrderDetail__Rendering);
            AggregateFunctions = new object[] {
                    Text3_Sum,
                    Text4_Sum,
                    Text5_Sum1,
                    Text5_Sum3};
            // 
            // Add to DataSP_GetSalesOrderHeader.Components
            // 
            DataSP_GetSalesOrderHeader.Components.Clear();
            DataSP_GetSalesOrderHeader.Components.AddRange(new StiComponent[] {
                        Text2,
                        Text1});
            // 
            // Add to HeaderSP_GetSalesOrderDetail.Components
            // 
            HeaderSP_GetSalesOrderDetail.Components.Clear();
            HeaderSP_GetSalesOrderDetail.Components.AddRange(new StiComponent[] {
                        HeaderSP_GetSalesOrderDetail_OrdinalNumber,
                        HeaderSP_GetSalesOrderDetail_MedicamentName,
                        HeaderSP_GetSalesOrderDetail_Serie,
                        HeaderSP_GetSalesOrderDetail_ValidDate,
                        HeaderSP_GetSalesOrderDetail_SaleQty,
                        HeaderSP_GetSalesOrderDetail_SaleUnitPriceDiscount,
                        HeaderSP_GetSalesOrderDetail_SaleLineTotal});
            // 
            // Add to DataSP_GetSalesOrderDetail.Components
            // 
            DataSP_GetSalesOrderDetail.Components.Clear();
            DataSP_GetSalesOrderDetail.Components.AddRange(new StiComponent[] {
                        DataSP_GetSalesOrderDetail_OrdinalNumber,
                        DataSP_GetSalesOrderDetail_MedicamentName,
                        DataSP_GetSalesOrderDetail_Serie,
                        DataSP_GetSalesOrderDetail_ValidDate,
                        DataSP_GetSalesOrderDetail_SaleQty,
                        DataSP_GetSalesOrderDetail_SaleUnitPriceDiscount,
                        DataSP_GetSalesOrderDetail_SaleLineTotal});
            // 
            // Add to FooterSP_GetSalesOrderDetail.Components
            // 
            FooterSP_GetSalesOrderDetail.Components.Clear();
            FooterSP_GetSalesOrderDetail.Components.AddRange(new StiComponent[] {
                        Text3,
                        Text4,
                        Text5,
                        Text6,
                        Text7,
                        Text8,
                        HorizontalLine2,
                        HorizontalLine1});
            // 
            // Add to Page1.Components
            // 
            Page1.Components.Clear();
            Page1.Components.AddRange(new StiComponent[] {
                        DataSP_GetSalesOrderHeader,
                        HeaderSP_GetSalesOrderDetail,
                        DataSP_GetSalesOrderDetail,
                        FooterSP_GetSalesOrderDetail});
            // 
            // Add to Pages
            // 
            Pages.Clear();
            Pages.AddRange(new[] {
                        Page1});
            Dictionary.Relations.Add(ParentSP_GetSalesOrderHeader);
            SP_GetSalesOrderHeader.Columns.AddRange(new[] {
                        new StiDataColumn("SalesOrderID", "SalesOrderID", "SalesOrderID", typeof(int)),
                        new StiDataColumn("BranchID", "BranchID", "BranchID", typeof(int)),
                        new StiDataColumn("BranchName", "BranchName", "BranchName", typeof(string)),
                        new StiDataColumn("OrderDate", "OrderDate", "OrderDate", typeof(DateTime)),
                        new StiDataColumn("OverheadNumber", "OverheadNumber", "OverheadNumber", typeof(string)),
                        new StiDataColumn("CustomerID", "CustomerID", "CustomerID", typeof(int)),
                        new StiDataColumn("CustomerName", "CustomerName", "CustomerName", typeof(string)),
                        new StiDataColumn("SubTotal", "SubTotal", "SubTotal", typeof(decimal)),
                        new StiDataColumn("TaxAmt", "TaxAmt", "TaxAmt", typeof(decimal)),
                        new StiDataColumn("Freight", "Freight", "Freight", typeof(decimal)),
                        new StiDataColumn("TotalDue", "TotalDue", "TotalDue", typeof(decimal)),
                        new StiDataColumn("CurrencyCode", "CurrencyCode", "CurrencyCode", typeof(string)),
                        new StiDataColumn("CurrencyRateID", "CurrencyRateID", "CurrencyRateID", typeof(int)),
                        new StiDataColumn("PaymentMethodID", "PaymentMethodID", "PaymentMethodID", typeof(int)),
                        new StiDataColumn("PaymentMethodName", "PaymentMethodName", "PaymentMethodName", typeof(string)),
                        new StiDataColumn("RevisionNumber", "RevisionNumber", "RevisionNumber", typeof(byte)),
                        new StiDataColumn("Status", "Status", "Status", typeof(byte)),
                        new StiDataColumn("ModifiedUserID", "ModifiedUserID", "ModifiedUserID", typeof(int)),
                        new StiDataColumn("Modifier", "Modifier", "Modifier", typeof(string)),
                        new StiDataColumn("ModifiedDate", "ModifiedDate", "ModifiedDate", typeof(DateTime)),
                        new StiDataColumn("ApproverUserID", "ApproverUserID", "ApproverUserID", typeof(int)),
                        new StiDataColumn("Approver", "Approver", "Approver", typeof(string))});
            DataSources.Add(SP_GetSalesOrderHeader);
            SP_GetSalesOrderDetail.Columns.AddRange(new[] {
                        new StiDataColumn("SalesOrderDetailID", "SalesOrderDetailID", "SalesOrderDetailID", typeof(Guid)),
                        new StiDataColumn("SalesOrderID", "SalesOrderID", "SalesOrderID", typeof(int)),
                        new StiDataColumn("ProductLocationID", "ProductLocationID", "ProductLocationID", typeof(int)),
                        new StiDataColumn("SaleQty", "SaleQty", "SaleQty", typeof(decimal)),
                        new StiDataColumn("UnitPrice", "UnitPrice", "UnitPrice", typeof(decimal)),
                        new StiDataColumn("UnitPriceDiscount", "UnitPriceDiscount", "UnitPriceDiscount", typeof(decimal)),
                        new StiDataColumn("LineTotal", "LineTotal", "LineTotal", typeof(decimal)),
                        new StiDataColumn("OrdinalNumber", "OrdinalNumber", "OrdinalNumber", typeof(short)),
                        new StiDataColumn("ProductID", "ProductID", "ProductID", typeof(int)),
                        new StiDataColumn("BranchID", "BranchID", "BranchID", typeof(int)),
                        new StiDataColumn("PurchaseOrderDetailID", "PurchaseOrderDetailID", "PurchaseOrderDetailID", typeof(Guid)),
                        new StiDataColumn("MedicamentID", "MedicamentID", "MedicamentID", typeof(int)),
                        new StiDataColumn("ProductNumber", "ProductNumber", "ProductNumber", typeof(string)),
                        new StiDataColumn("MedicamentName", "MedicamentName", "MedicamentName", typeof(string)),
                        new StiDataColumn("Quantity", "Quantity", "Quantity", typeof(decimal)),
                        new StiDataColumn("StandardCost", "StandardCost", "StandardCost", typeof(decimal)),
                        new StiDataColumn("ListPrice", "ListPrice", "ListPrice", typeof(decimal)),
                        new StiDataColumn("DealerPrice", "DealerPrice", "DealerPrice", typeof(decimal)),
                        new StiDataColumn("DiscountPct", "DiscountPct", "DiscountPct", typeof(decimal)),
                        new StiDataColumn("ValidDate", "ValidDate", "ValidDate", typeof(DateTime?)),
                        new StiDataColumn("CountryCode", "CountryCode", "CountryCode", typeof(string)),
                        new StiDataColumn("CountryName", "CountryName", "CountryName", typeof(string)),
                        new StiDataColumn("BrandID", "BrandID", "BrandID", typeof(int)),
                        new StiDataColumn("BrandName", "BrandName", "BrandName", typeof(string)),
                        new StiDataColumn("Serie", "Serie", "Serie", typeof(string)),
                        new StiDataColumn("UnitsInStock", "UnitsInStock", "UnitsInStock", typeof(short)),
                        new StiDataColumn("_ResidualQty", "_ResidualQty", "_ResidualQty", typeof(decimal)),
                        new StiDataColumn("_SaleUnitQty", "_SaleUnitQty", "_SaleUnitQty", typeof(int)),
                        new StiDataColumn("Action", "Action", "Action", typeof(int)),
                        new StiCalcDataColumn("PurchaseLineTotal", "PurchaseLineTotal", typeof(decimal))});
            DataSources.Add(SP_GetSalesOrderDetail);
        }

        public decimal GetSP_GetSalesOrderDetail_PurchaseLineTotal()
        {
            return SP_GetSalesOrderDetail.StandardCost * SP_GetSalesOrderDetail.SaleQty;
        }

        #region Relation ParentSP_GetSalesOrderHeader
        public class ParentSP_GetSalesOrderHeaderRelation : StiDataRow
        {

            public ParentSP_GetSalesOrderHeaderRelation(StiDataRow dataRow) :
                base(dataRow)
            {
            }

            public virtual int SalesOrderID
            {
                get
                {
                    return ((int)(ChangeType(this["SalesOrderID"], typeof(int), true)));
                }
            }

            public virtual int BranchID
            {
                get
                {
                    return ((int)(ChangeType(this["BranchID"], typeof(int), true)));
                }
            }

            public virtual string BranchName
            {
                get
                {
                    return ((string)(ChangeType(this["BranchName"], typeof(string), true)));
                }
            }

            public virtual DateTime OrderDate
            {
                get
                {
                    return ((DateTime)(ChangeType(this["OrderDate"], typeof(DateTime), true)));
                }
            }

            public virtual string OverheadNumber
            {
                get
                {
                    return ((string)(ChangeType(this["OverheadNumber"], typeof(string), true)));
                }
            }

            public virtual int CustomerID
            {
                get
                {
                    return ((int)(ChangeType(this["CustomerID"], typeof(int), true)));
                }
            }

            public virtual string CustomerName
            {
                get
                {
                    return ((string)(ChangeType(this["CustomerName"], typeof(string), true)));
                }
            }

            public virtual decimal SubTotal
            {
                get
                {
                    return ((decimal)(ChangeType(this["SubTotal"], typeof(decimal), true)));
                }
            }

            public virtual decimal TaxAmt
            {
                get
                {
                    return ((decimal)(ChangeType(this["TaxAmt"], typeof(decimal), true)));
                }
            }

            public virtual decimal Freight
            {
                get
                {
                    return ((decimal)(ChangeType(this["Freight"], typeof(decimal), true)));
                }
            }

            public virtual decimal TotalDue
            {
                get
                {
                    return ((decimal)(ChangeType(this["TotalDue"], typeof(decimal), true)));
                }
            }

            public virtual string CurrencyCode
            {
                get
                {
                    return ((string)(ChangeType(this["CurrencyCode"], typeof(string), true)));
                }
            }

            public virtual int CurrencyRateID
            {
                get
                {
                    return ((int)(ChangeType(this["CurrencyRateID"], typeof(int), true)));
                }
            }

            public virtual int PaymentMethodID
            {
                get
                {
                    return ((int)(ChangeType(this["PaymentMethodID"], typeof(int), true)));
                }
            }

            public virtual string PaymentMethodName
            {
                get
                {
                    return ((string)(ChangeType(this["PaymentMethodName"], typeof(string), true)));
                }
            }

            public virtual byte RevisionNumber
            {
                get
                {
                    return ((byte)(ChangeType(this["RevisionNumber"], typeof(byte), true)));
                }
            }

            public virtual byte Status
            {
                get
                {
                    return ((byte)(ChangeType(this["Status"], typeof(byte), true)));
                }
            }

            public virtual int ModifiedUserID
            {
                get
                {
                    return ((int)(ChangeType(this["ModifiedUserID"], typeof(int), true)));
                }
            }

            public virtual string Modifier
            {
                get
                {
                    return ((string)(ChangeType(this["Modifier"], typeof(string), true)));
                }
            }

            public virtual DateTime ModifiedDate
            {
                get
                {
                    return ((DateTime)(ChangeType(this["ModifiedDate"], typeof(DateTime), true)));
                }
            }

            public virtual int ApproverUserID
            {
                get
                {
                    return ((int)(ChangeType(this["ApproverUserID"], typeof(int), true)));
                }
            }

            public virtual string Approver
            {
                get
                {
                    return ((string)(ChangeType(this["Approver"], typeof(string), true)));
                }
            }
        }
        #endregion Relation ParentSP_GetSalesOrderHeader

        #region DataSource SP_GetSalesOrderHeader
        public class SP_GetSalesOrderHeaderDataSource : StiDataTableSource
        {

            public SP_GetSalesOrderHeaderDataSource() :
                base("DS_Sales.SP_GetSalesOrderHeader", "SP_GetSalesOrderHeader")
            {
            }

            public virtual int SalesOrderID
            {
                get
                {
                    return ((int)(ChangeType(this["SalesOrderID"], typeof(int), true)));
                }
            }

            public virtual int BranchID
            {
                get
                {
                    return ((int)(ChangeType(this["BranchID"], typeof(int), true)));
                }
            }

            public virtual string BranchName
            {
                get
                {
                    return ((string)(ChangeType(this["BranchName"], typeof(string), true)));
                }
            }

            public virtual DateTime OrderDate
            {
                get
                {
                    return ((DateTime)(ChangeType(this["OrderDate"], typeof(DateTime), true)));
                }
            }

            public virtual string OverheadNumber
            {
                get
                {
                    return ((string)(ChangeType(this["OverheadNumber"], typeof(string), true)));
                }
            }

            public virtual int CustomerID
            {
                get
                {
                    return ((int)(ChangeType(this["CustomerID"], typeof(int), true)));
                }
            }

            public virtual string CustomerName
            {
                get
                {
                    return ((string)(ChangeType(this["CustomerName"], typeof(string), true)));
                }
            }

            public virtual decimal SubTotal
            {
                get
                {
                    return ((decimal)(ChangeType(this["SubTotal"], typeof(decimal), true)));
                }
            }

            public virtual decimal TaxAmt
            {
                get
                {
                    return ((decimal)(ChangeType(this["TaxAmt"], typeof(decimal), true)));
                }
            }

            public virtual decimal Freight
            {
                get
                {
                    return ((decimal)(ChangeType(this["Freight"], typeof(decimal), true)));
                }
            }

            public virtual decimal TotalDue
            {
                get
                {
                    return ((decimal)(ChangeType(this["TotalDue"], typeof(decimal), true)));
                }
            }

            public virtual string CurrencyCode
            {
                get
                {
                    return ((string)(ChangeType(this["CurrencyCode"], typeof(string), true)));
                }
            }

            public virtual int CurrencyRateID
            {
                get
                {
                    return ((int)(ChangeType(this["CurrencyRateID"], typeof(int), true)));
                }
            }

            public virtual int PaymentMethodID
            {
                get
                {
                    return ((int)(ChangeType(this["PaymentMethodID"], typeof(int), true)));
                }
            }

            public virtual string PaymentMethodName
            {
                get
                {
                    return ((string)(ChangeType(this["PaymentMethodName"], typeof(string), true)));
                }
            }

            public virtual byte RevisionNumber
            {
                get
                {
                    return ((byte)(ChangeType(this["RevisionNumber"], typeof(byte), true)));
                }
            }

            public virtual byte Status
            {
                get
                {
                    return ((byte)(ChangeType(this["Status"], typeof(byte), true)));
                }
            }

            public virtual int ModifiedUserID
            {
                get
                {
                    return ((int)(ChangeType(this["ModifiedUserID"], typeof(int), true)));
                }
            }

            public virtual string Modifier
            {
                get
                {
                    return ((string)(ChangeType(this["Modifier"], typeof(string), true)));
                }
            }

            public virtual DateTime ModifiedDate
            {
                get
                {
                    return ((DateTime)(ChangeType(this["ModifiedDate"], typeof(DateTime), true)));
                }
            }

            public virtual int ApproverUserID
            {
                get
                {
                    return ((int)(ChangeType(this["ApproverUserID"], typeof(int), true)));
                }
            }

            public virtual string Approver
            {
                get
                {
                    return ((string)(ChangeType(this["Approver"], typeof(string), true)));
                }
            }
        }
        #endregion DataSource SP_GetSalesOrderHeader

        #region DataSource SP_GetSalesOrderDetail
        public class SP_GetSalesOrderDetailDataSource : StiDataTableSource
        {

            public SP_GetSalesOrderDetailDataSource() :
                base("DS_Sales.SP_GetSalesOrderDetail", "SP_GetSalesOrderDetail")
            {
            }

            public virtual Guid SalesOrderDetailID
            {
                get
                {
                    return ((Guid)(ChangeType(this["SalesOrderDetailID"], typeof(Guid), true)));
                }
            }

            public virtual int SalesOrderID
            {
                get
                {
                    return ((int)(ChangeType(this["SalesOrderID"], typeof(int), true)));
                }
            }

            public virtual int ProductLocationID
            {
                get
                {
                    return ((int)(ChangeType(this["ProductLocationID"], typeof(int), true)));
                }
            }

            public virtual decimal SaleQty
            {
                get
                {
                    return ((decimal)(ChangeType(this["SaleQty"], typeof(decimal), true)));
                }
            }

            public virtual decimal UnitPrice
            {
                get
                {
                    return ((decimal)(ChangeType(this["UnitPrice"], typeof(decimal), true)));
                }
            }

            public virtual decimal UnitPriceDiscount
            {
                get
                {
                    return ((decimal)(ChangeType(this["UnitPriceDiscount"], typeof(decimal), true)));
                }
            }

            public virtual decimal LineTotal
            {
                get
                {
                    return ((decimal)(ChangeType(this["LineTotal"], typeof(decimal), true)));
                }
            }

            public virtual short OrdinalNumber
            {
                get
                {
                    return ((short)(ChangeType(this["OrdinalNumber"], typeof(short), true)));
                }
            }

            public virtual int ProductID
            {
                get
                {
                    return ((int)(ChangeType(this["ProductID"], typeof(int), true)));
                }
            }

            public virtual int BranchID
            {
                get
                {
                    return ((int)(ChangeType(this["BranchID"], typeof(int), true)));
                }
            }

            public virtual Guid PurchaseOrderDetailID
            {
                get
                {
                    return ((Guid)(ChangeType(this["PurchaseOrderDetailID"], typeof(Guid), true)));
                }
            }

            public virtual int MedicamentID
            {
                get
                {
                    return ((int)(ChangeType(this["MedicamentID"], typeof(int), true)));
                }
            }

            public virtual string ProductNumber
            {
                get
                {
                    return ((string)(ChangeType(this["ProductNumber"], typeof(string), true)));
                }
            }

            public virtual string MedicamentName
            {
                get
                {
                    return ((string)(ChangeType(this["MedicamentName"], typeof(string), true)));
                }
            }

            public virtual decimal Quantity
            {
                get
                {
                    return ((decimal)(ChangeType(this["Quantity"], typeof(decimal), true)));
                }
            }

            public virtual decimal StandardCost
            {
                get
                {
                    return ((decimal)(ChangeType(this["StandardCost"], typeof(decimal), true)));
                }
            }

            public virtual decimal ListPrice
            {
                get
                {
                    return ((decimal)(ChangeType(this["ListPrice"], typeof(decimal), true)));
                }
            }

            public virtual decimal DealerPrice
            {
                get
                {
                    return ((decimal)(ChangeType(this["DealerPrice"], typeof(decimal), true)));
                }
            }

            public virtual decimal DiscountPct
            {
                get
                {
                    return ((decimal)(ChangeType(this["DiscountPct"], typeof(decimal), true)));
                }
            }

            public virtual DateTime? ValidDate
            {
                get
                {
                    return ((DateTime?)(ChangeType(this["ValidDate"], typeof(DateTime?), true)));
                }
            }

            public virtual string CountryCode
            {
                get
                {
                    return ((string)(ChangeType(this["CountryCode"], typeof(string), true)));
                }
            }

            public virtual string CountryName
            {
                get
                {
                    return ((string)(ChangeType(this["CountryName"], typeof(string), true)));
                }
            }

            public virtual int BrandID
            {
                get
                {
                    return ((int)(ChangeType(this["BrandID"], typeof(int), true)));
                }
            }

            public virtual string BrandName
            {
                get
                {
                    return ((string)(ChangeType(this["BrandName"], typeof(string), true)));
                }
            }

            public virtual string Serie
            {
                get
                {
                    return ((string)(ChangeType(this["Serie"], typeof(string), true)));
                }
            }

            public virtual short UnitsInStock
            {
                get
                {
                    return ((short)(ChangeType(this["UnitsInStock"], typeof(short), true)));
                }
            }

            public virtual decimal _ResidualQty
            {
                get
                {
                    return ((decimal)(ChangeType(this["_ResidualQty"], typeof(decimal), true)));
                }
            }

            public virtual int _SaleUnitQty
            {
                get
                {
                    return ((int)(ChangeType(this["_SaleUnitQty"], typeof(int), true)));
                }
            }

            public virtual int Action
            {
                get
                {
                    return ((int)(ChangeType(this["Action"], typeof(int), true)));
                }
            }

            public virtual decimal PurchaseLineTotal
            {
                get
                {
                    return ((RptSalesOrderDetailPurchasePrice)(Dictionary.Report)).GetSP_GetSalesOrderDetail_PurchaseLineTotal();
                }
            }

            public virtual ParentSP_GetSalesOrderHeaderRelation SP_GetSalesOrderHeader
            {
                get
                {
                    return new ParentSP_GetSalesOrderHeaderRelation(GetParentData("SP_GetSalesOrderHeader_SP_GetSalesOrderDetail"));
                }
            }
        }
        #endregion DataSource SP_GetSalesOrderDetail
        #endregion StiReport Designer generated code - do not modify
    }
}
