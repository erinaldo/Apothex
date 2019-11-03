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

    public class RptPurchaseOrderDetail : StiReport
    {

        public RptPurchaseOrderDetail()
        {
            InitializeComponent();
        }
        #region StiReport Designer generated code - do not modify
        public StiDataRelation ParentSP_GetPurchaseOrderHeader;
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
        public StiDataBand DataSP_GetPurchaseOrderHeader;
        public StiText Text1;
        public StiText Text2;
        public StiHeaderBand HeaderSP_GetPurchaseOrderDetail;
        public StiText Text3;
        public StiText Text4;
        public StiText Text5;
        public StiText Text6;
        public StiText Text7;
        public StiText Text8;
        public StiText Text9;
        public StiText Text22;
        public StiText Text33;
        public StiText Text24;
        public StiDataBand DataSP_GetPurchaseOrderDetail;
        public StiText Text10;
        public StiText Text11;
        public StiText Text12;
        public StiText Text13;
        public StiText Text14;
        public StiText Text15;
        public StiText Text16;
        public StiText Text23;
        public StiText Text32;
        public StiText Text25;
        public StiFooterBand FooterSP_GetPurchaseOrderDetail;
        public StiText Text17;
        public StiSumDecimalFunctionService Text17_Sum;
        public StiText Text18;
        public StiSumDecimalFunctionService Text18_Sum;
        public StiText Text19;
        public StiText Text20;
        public StiText Text21;
        public StiHorizontalLinePrimitive HorizontalLine1;
        public StiHorizontalLinePrimitive HorizontalLine2;
        public StiWatermark Page1_Watermark;
        public StiPrinterSettings RptPurchaseOrderDetail_PrinterSettings;
        public SP_GetPurchaseOrderDetailDataSource SP_GetPurchaseOrderDetail;
        public SP_GetPurchaseOrderHeaderDataSource SP_GetPurchaseOrderHeader;

        public void Text1__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "შემავალი ფაქტურა №" + ToString(sender, SP_GetPurchaseOrderHeader.PurchaseOrderID, true) + "    თარიღი: " + ToString(sender, Format("{0:yyyy.MM.dd}", SP_GetPurchaseOrderHeader.OrderDate), true);
        }

        public void Text2__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, MyCompanyName, true) + "\r\nმის: " + ToString(sender, MyCompanyAddress, true) + ToString(sender, IIF(MyCompanyPhone.Length > 0, " ტელ:" + MyCompanyPhone, string.Empty), true) + "\r\nფილიალი: " + ToString(sender, SP_GetPurchaseOrderHeader.BranchName, true);
        }

        public void Text3__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "№";
        }

        public void Text4__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "მედიკამენტი";
        }

        public void Text5__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "რაოდ.";
        }

        public void Text6__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ფასი / შ.";
        }

        public void Text7__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ჯამი";
        }

        public void Text8__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "სერია";
        }

        public void Text9__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ვადა";
        }

        public void Text22__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "მწარმოებელი";
        }

        public void Text33__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "მწ. ქვეყანა";
        }

        public void Text24__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ფასი / გ.";
        }

        public void Text10__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Line, true);
        }

        public void Text11__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetPurchaseOrderDetail.MedicamentName, true);
        }

        public void Text12__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text12.TextFormat.Format(CheckExcelValue(sender, SP_GetPurchaseOrderDetail.ReceivedQty));
        }

        public void Text13__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text13.TextFormat.Format(CheckExcelValue(sender, SP_GetPurchaseOrderDetail.UnitPrice));
        }

        public void Text14__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text14.TextFormat.Format(CheckExcelValue(sender, SP_GetPurchaseOrderDetail.LineTotal));
        }

        public void Text15__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetPurchaseOrderDetail.Serie, true);
        }

        public void Text16__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = String.Format("{0:MM\\/yy}", SP_GetPurchaseOrderDetail.ValidDate);
        }

        public void Text23__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetPurchaseOrderDetail.BrandName, true);
        }

        public void Text32__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetPurchaseOrderDetail.CountryName, true);
        }

        public void Text25__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text25.TextFormat.Format(CheckExcelValue(sender, SP_GetPurchaseOrderDetail._ListPrice));
        }

        public void Text17__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(SP_GetPurchaseOrderDetail.ReceivedQty)}";
            e.StoreToPrinted = true;
        }

        public String Text17_GetValue_End(StiComponent sender)
        {
            return Text17.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text17_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void Text18__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(SP_GetPurchaseOrderDetail.LineTotal)}";
            e.StoreToPrinted = true;
        }

        public String Text18_GetValue_End(StiComponent sender)
        {
            return Text18.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text18_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void Text19__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "პროდუქცია: " + ToString(sender, Format("{0:N2}", SP_GetPurchaseOrderDetail.SP_GetPurchaseOrderHeader.SubTotal), true) + " " + ToString(sender, SP_GetPurchaseOrderDetail.SP_GetPurchaseOrderHeader.CurrencyCode, true) + "\r\nტრანსპორტირება: " + ToString(sender, Format("{0:N2}", SP_GetPurchaseOrderDetail.SP_GetPurchaseOrderHeader.Freight), true) + " " + ToString(sender, SP_GetPurchaseOrderDetail.SP_GetPurchaseOrderHeader.CurrencyCode, true) + "\r\nსაგადასახადო: " + ToString(sender, Format("{0:N2}", SP_GetPurchaseOrderDetail.SP_GetPurchaseOrderHeader.TaxAmt), true) + " " + ToString(sender, SP_GetPurchaseOrderDetail.SP_GetPurchaseOrderHeader.CurrencyCode, true) + "\r\nთანხა სულ: " + ToString(sender, Format("{0:N2}", SP_GetPurchaseOrderDetail.SP_GetPurchaseOrderHeader.TotalDue), true) + " " + ToString(sender, SP_GetPurchaseOrderDetail.SP_GetPurchaseOrderHeader.CurrencyCode, true) + "\r\n\r\nსერტიფიცირებულია და ნებადართულია სარეალიზაციოდ";
        }

        public void Text20__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "გასცა:";
        }

        public void Text21__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "მიიღო:";
        }

        public void DataSP_GetPurchaseOrderDetail__BeginRender(object sender, EventArgs e)
        {
            Text17_Sum.Init();
            Text17.TextValue = "";
            Text18_Sum.Init();
            Text18.TextValue = "";
        }

        public void DataSP_GetPurchaseOrderDetail__EndRender(object sender, EventArgs e)
        {
            Text17.SetText(new StiGetValue(Text17_GetValue_End));
            Text18.SetText(new StiGetValue(Text18_GetValue_End));
        }

        public void DataSP_GetPurchaseOrderDetail__Rendering(object sender, EventArgs e)
        {
            Text17_Sum.CalcItem(SP_GetPurchaseOrderDetail.ReceivedQty);
            Text18_Sum.CalcItem(SP_GetPurchaseOrderDetail.LineTotal);
        }

        private void InitializeComponent()
        {
            SP_GetPurchaseOrderHeader = new SP_GetPurchaseOrderHeaderDataSource();
            SP_GetPurchaseOrderDetail = new SP_GetPurchaseOrderDetailDataSource();
            ParentSP_GetPurchaseOrderHeader = new StiDataRelation("SP_GetPurchaseOrderHeader_SP_GetPurchaseOrderDetail", "SP_GetPurchaseOrderHeader", "SP_GetPurchaseOrderHeader", SP_GetPurchaseOrderHeader, SP_GetPurchaseOrderDetail, new[] {
                        "PurchaseOrderID"}, new[] {
                        "PurchaseOrderID"});
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyName", "MyCompanyName", "", typeof(string), "", false, false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyTaxCode", "MyCompanyTaxCode", "", typeof(string), "", false, false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyDirectorName", "MyCompanyDirectorName", "", typeof(string), "", false, false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyCountryCode", "MyCompanyCountryCode", "", typeof(string), "", false, false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyCountryName", "MyCompanyCountryName", "", typeof(string), "", false, false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyCity", "MyCompanyCity", "", typeof(string), "", false, false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyPostalCode", "MyCompanyPostalCode", "", typeof(string), "", false, false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyAddress", "MyCompanyAddress", "", typeof(string), "", false, false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyPhone", "MyCompanyPhone", "", typeof(string), "", false, false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyFax", "MyCompanyFax", "", typeof(string), "", false, false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyBankName", "MyCompanyBankName", "", typeof(string), "", false, false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyBankCode", "MyCompanyBankCode", "", typeof(string), "", false, false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyBankAccountNumber", "MyCompanyBankAccountNumber", "", typeof(string), "", false, false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyVATPayerFlag", "MyCompanyVATPayerFlag", "", typeof(bool), "", false, false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyConditionalUnitCurrencyCode", "MyCompanyConditionalUnitCurrencyCode", "", typeof(string), "", false, false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyDefaultTradingCurrencyCode", "MyCompanyDefaultTradingCurrencyCode", "", typeof(string), "", false, false, false));
            Dictionary.Variables.Add(new StiVariable("", "MyCompanyConditionalUnitCurrencyRate", "MyCompanyConditionalUnitCurrencyRate", "", typeof(decimal), "", false, false, false));
            NeedsCompiling = false;
            Text18_Sum = new StiSumDecimalFunctionService();
            Text17_Sum = new StiSumDecimalFunctionService();
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
            ReportAlias = "Rpt Purchase Order Detail";
            ReportAuthor = "Programmer.GE";
            // 
            // ReportChanged
            // 
            ReportChanged = new DateTime(2010, 7, 17, 22, 27, 41, 365);
            // 
            // ReportCreated
            // 
            ReportCreated = new DateTime(2009, 2, 7, 15, 51, 39, 0);
            ReportDescription = "შესყიდვის დეტალური რეპორტი";
            ReportFile = "D:\\User\\Documents\\Projects\\Apothex\\Source\\Class Library\\Apothex.Reporting\\Purchas" +
"ing\\RptPurchaseOrderDetail.mrt";
            ReportGuid = "a45fc7e110e84d7885df646559550b3b";
            ReportName = "RptPurchaseOrderDetail";
            ReportUnit = StiReportUnitType.Centimeters;
            ScriptLanguage = StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            Page1 = new StiPage();
            Page1.Guid = "fe95fec27f0d4ff49322fb6edbd2e1be";
            Page1.Name = "Page1";
            Page1.Orientation = StiPageOrientation.Landscape;
            Page1.PageHeight = 21;
            Page1.PageWidth = 29.7;
            Page1.PaperSize = PaperKind.A4;
            Page1.Border = new StiBorder(StiBorderSides.None, Color.Black, 2, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Page1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // DataSP_GetPurchaseOrderHeader
            // 
            DataSP_GetPurchaseOrderHeader = new StiDataBand();
            DataSP_GetPurchaseOrderHeader.ClientRectangle = new RectangleD(0, 0.4, 27.7, 2);
            DataSP_GetPurchaseOrderHeader.DataSourceName = "SP_GetPurchaseOrderHeader";
            DataSP_GetPurchaseOrderHeader.Name = "DataSP_GetPurchaseOrderHeader";
            DataSP_GetPurchaseOrderHeader.Sort = new[] {
                    "ASC",
                    "PurchaseOrderID"};
            DataSP_GetPurchaseOrderHeader.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetPurchaseOrderHeader.Brush = new StiSolidBrush(Color.Transparent);
            DataSP_GetPurchaseOrderHeader.BusinessObjectGuid = null;
            // 
            // Text1
            // 
            Text1 = new StiText();
            Text1.ClientRectangle = new RectangleD(0, 0, 27.6, 0.6);
            Text1.HorAlignment = StiTextHorAlignment.Center;
            Text1.Name = "Text1";
            Text1.GetValue += new StiGetValueEventHandler(Text1__GetValue);
            Text1.VertAlignment = StiVertAlignment.Center;
            Text1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text1.Brush = new StiSolidBrush(Color.Transparent);
            Text1.Font = new Font("BPG Glaho Arial", 9F);
            Text1.Guid = null;
            Text1.Interaction = null;
            Text1.Margins = new StiMargins(0, 0, 0, 0);
            Text1.TextBrush = new StiSolidBrush(Color.Black);
            Text1.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text2
            // 
            Text2 = new StiText();
            Text2.ClientRectangle = new RectangleD(0, 0.6, 27.6, 1.4);
            Text2.Name = "Text2";
            Text2.GetValue += new StiGetValueEventHandler(Text2__GetValue);
            Text2.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text2.Brush = new StiSolidBrush(Color.Transparent);
            Text2.Font = new Font("BPG Glaho Arial", 9F);
            Text2.Guid = null;
            Text2.Interaction = null;
            Text2.Margins = new StiMargins(0, 0, 0, 0);
            Text2.TextBrush = new StiSolidBrush(Color.Black);
            Text2.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            DataSP_GetPurchaseOrderHeader.DataRelationName = null;
            DataSP_GetPurchaseOrderHeader.Guid = null;
            DataSP_GetPurchaseOrderHeader.Interaction = null;
            DataSP_GetPurchaseOrderHeader.MasterComponent = null;
            // 
            // HeaderSP_GetPurchaseOrderDetail
            // 
            HeaderSP_GetPurchaseOrderDetail = new StiHeaderBand();
            HeaderSP_GetPurchaseOrderDetail.ClientRectangle = new RectangleD(0, 3.2, 27.7, 1);
            HeaderSP_GetPurchaseOrderDetail.Name = "HeaderSP_GetPurchaseOrderDetail";
            HeaderSP_GetPurchaseOrderDetail.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderSP_GetPurchaseOrderDetail.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text3
            // 
            Text3 = new StiText();
            Text3.ClientRectangle = new RectangleD(0, 0, 1, 1);
            Text3.HorAlignment = StiTextHorAlignment.Center;
            Text3.Name = "Text3";
            Text3.GetValue += new StiGetValueEventHandler(Text3__GetValue);
            Text3.VertAlignment = StiVertAlignment.Center;
            Text3.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text3.Brush = new StiSolidBrush(Color.Transparent);
            Text3.Font = new Font("BPG Glaho Arial", 9F, FontStyle.Bold);
            Text3.Guid = null;
            Text3.Interaction = null;
            Text3.Margins = new StiMargins(0, 0, 0, 0);
            Text3.TextBrush = new StiSolidBrush(Color.Black);
            Text3.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text4
            // 
            Text4 = new StiText();
            Text4.ClientRectangle = new RectangleD(1, 0, 7.4, 1);
            Text4.Guid = "be1f1b1ed32d4af2a8d354d2e045373b";
            Text4.HorAlignment = StiTextHorAlignment.Center;
            Text4.Name = "Text4";
            Text4.GetValue += new StiGetValueEventHandler(Text4__GetValue);
            Text4.VertAlignment = StiVertAlignment.Center;
            Text4.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text4.Brush = new StiSolidBrush(Color.Transparent);
            Text4.Font = new Font("BPG Glaho Arial", 9F, FontStyle.Bold);
            Text4.Interaction = null;
            Text4.Margins = new StiMargins(0, 0, 0, 0);
            Text4.TextBrush = new StiSolidBrush(Color.Black);
            Text4.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text5
            // 
            Text5 = new StiText();
            Text5.ClientRectangle = new RectangleD(20.2, 0, 1.8, 1);
            Text5.Guid = "4b8a671054664c058ff9aad0d3e75c1c";
            Text5.HorAlignment = StiTextHorAlignment.Center;
            Text5.Name = "Text5";
            Text5.GetValue += new StiGetValueEventHandler(Text5__GetValue);
            Text5.VertAlignment = StiVertAlignment.Center;
            Text5.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text5.Brush = new StiSolidBrush(Color.Transparent);
            Text5.Font = new Font("BPG Glaho Arial", 9F, FontStyle.Bold);
            Text5.Interaction = null;
            Text5.Margins = new StiMargins(0, 0, 0, 0);
            Text5.TextBrush = new StiSolidBrush(Color.Black);
            Text5.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text6
            // 
            Text6 = new StiText();
            Text6.ClientRectangle = new RectangleD(22, 0, 1.8, 1);
            Text6.Guid = "9f87c506cb0143218adb278007ac93bc";
            Text6.HorAlignment = StiTextHorAlignment.Center;
            Text6.Name = "Text6";
            Text6.GetValue += new StiGetValueEventHandler(Text6__GetValue);
            Text6.VertAlignment = StiVertAlignment.Center;
            Text6.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text6.Brush = new StiSolidBrush(Color.Transparent);
            Text6.Font = new Font("BPG Glaho Arial", 9F, FontStyle.Bold);
            Text6.Interaction = null;
            Text6.Margins = new StiMargins(0, 0, 0, 0);
            Text6.TextBrush = new StiSolidBrush(Color.Black);
            Text6.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text7
            // 
            Text7 = new StiText();
            Text7.ClientRectangle = new RectangleD(25.6, 0, 2, 1);
            Text7.Guid = "c250c822512d455ea510fd9b4209cc5e";
            Text7.HorAlignment = StiTextHorAlignment.Center;
            Text7.Name = "Text7";
            Text7.GetValue += new StiGetValueEventHandler(Text7__GetValue);
            Text7.VertAlignment = StiVertAlignment.Center;
            Text7.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text7.Brush = new StiSolidBrush(Color.Transparent);
            Text7.Font = new Font("BPG Glaho Arial", 9F, FontStyle.Bold);
            Text7.Interaction = null;
            Text7.Margins = new StiMargins(0, 0, 0, 0);
            Text7.TextBrush = new StiSolidBrush(Color.Black);
            Text7.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text8
            // 
            Text8 = new StiText();
            Text8.ClientRectangle = new RectangleD(8.4, 0, 3, 1);
            Text8.Guid = "83e44455beec4a628a45df1c78514cb1";
            Text8.HorAlignment = StiTextHorAlignment.Center;
            Text8.Name = "Text8";
            Text8.GetValue += new StiGetValueEventHandler(Text8__GetValue);
            Text8.VertAlignment = StiVertAlignment.Center;
            Text8.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text8.Brush = new StiSolidBrush(Color.Transparent);
            Text8.Font = new Font("BPG Glaho Arial", 9F, FontStyle.Bold);
            Text8.Interaction = null;
            Text8.Margins = new StiMargins(0, 0, 0, 0);
            Text8.TextBrush = new StiSolidBrush(Color.Black);
            Text8.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text9
            // 
            Text9 = new StiText();
            Text9.ClientRectangle = new RectangleD(11.4, 0, 1.2, 1);
            Text9.Guid = "0635eae15de3441495063d92a1db0b4b";
            Text9.HorAlignment = StiTextHorAlignment.Center;
            Text9.Name = "Text9";
            Text9.GetValue += new StiGetValueEventHandler(Text9__GetValue);
            Text9.VertAlignment = StiVertAlignment.Center;
            Text9.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text9.Brush = new StiSolidBrush(Color.Transparent);
            Text9.Font = new Font("BPG Glaho Arial", 9F, FontStyle.Bold);
            Text9.Interaction = null;
            Text9.Margins = new StiMargins(0, 0, 0, 0);
            Text9.TextBrush = new StiSolidBrush(Color.Black);
            Text9.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text22
            // 
            Text22 = new StiText();
            Text22.ClientRectangle = new RectangleD(12.6, 0, 5, 1);
            Text22.Guid = "833ebda4ef93479eb3f375a76dc8808b";
            Text22.HorAlignment = StiTextHorAlignment.Center;
            Text22.Name = "Text22";
            Text22.GetValue += new StiGetValueEventHandler(Text22__GetValue);
            Text22.VertAlignment = StiVertAlignment.Center;
            Text22.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text22.Brush = new StiSolidBrush(Color.Transparent);
            Text22.Font = new Font("BPG Glaho Arial", 9F, FontStyle.Bold);
            Text22.Interaction = null;
            Text22.Margins = new StiMargins(0, 0, 0, 0);
            Text22.TextBrush = new StiSolidBrush(Color.Black);
            Text22.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text33
            // 
            Text33 = new StiText();
            Text33.ClientRectangle = new RectangleD(17.6, 0, 2.6, 1);
            Text33.Guid = "ea9cd036bd29489faef02ca6c39036c8";
            Text33.HorAlignment = StiTextHorAlignment.Center;
            Text33.Name = "Text33";
            Text33.GetValue += new StiGetValueEventHandler(Text33__GetValue);
            Text33.VertAlignment = StiVertAlignment.Center;
            Text33.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text33.Brush = new StiSolidBrush(Color.Transparent);
            Text33.Font = new Font("BPG Glaho Arial", 9F, FontStyle.Bold);
            Text33.Interaction = null;
            Text33.Margins = new StiMargins(0, 0, 0, 0);
            Text33.TextBrush = new StiSolidBrush(Color.Black);
            Text33.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text24
            // 
            Text24 = new StiText();
            Text24.ClientRectangle = new RectangleD(23.8, 0, 1.8, 1);
            Text24.Guid = "b6042d4fb88246b78ddc680d7cd26f34";
            Text24.HorAlignment = StiTextHorAlignment.Center;
            Text24.Name = "Text24";
            Text24.GetValue += new StiGetValueEventHandler(Text24__GetValue);
            Text24.VertAlignment = StiVertAlignment.Center;
            Text24.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text24.Brush = new StiSolidBrush(Color.Transparent);
            Text24.Font = new Font("BPG Glaho Arial", 9F, FontStyle.Bold);
            Text24.Interaction = null;
            Text24.Margins = new StiMargins(0, 0, 0, 0);
            Text24.TextBrush = new StiSolidBrush(Color.Black);
            Text24.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            HeaderSP_GetPurchaseOrderDetail.Guid = null;
            HeaderSP_GetPurchaseOrderDetail.Interaction = null;
            // 
            // DataSP_GetPurchaseOrderDetail
            // 
            DataSP_GetPurchaseOrderDetail = new StiDataBand();
            DataSP_GetPurchaseOrderDetail.ClientRectangle = new RectangleD(0, 5, 27.7, 0.8);
            DataSP_GetPurchaseOrderDetail.DataRelationName = "SP_GetPurchaseOrderHeader_SP_GetPurchaseOrderDetail";
            DataSP_GetPurchaseOrderDetail.DataSourceName = "SP_GetPurchaseOrderDetail";
            DataSP_GetPurchaseOrderDetail.Name = "DataSP_GetPurchaseOrderDetail";
            DataSP_GetPurchaseOrderDetail.Sort = new[] {
                    "ASC",
                    "OrdinalNumber"};
            DataSP_GetPurchaseOrderDetail.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetPurchaseOrderDetail.Brush = new StiSolidBrush(Color.Transparent);
            DataSP_GetPurchaseOrderDetail.BusinessObjectGuid = null;
            // 
            // Text10
            // 
            Text10 = new StiText();
            Text10.ClientRectangle = new RectangleD(0, 0, 1, 0.8);
            Text10.GrowToHeight = true;
            Text10.Name = "Text10";
            Text10.GetValue += new StiGetValueEventHandler(Text10__GetValue);
            Text10.VertAlignment = StiVertAlignment.Center;
            Text10.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text10.Brush = new StiSolidBrush(Color.Transparent);
            Text10.Font = new Font("BPG Glaho Arial", 8F);
            Text10.Guid = null;
            Text10.Interaction = null;
            Text10.Margins = new StiMargins(0, 0, 0, 0);
            Text10.TextBrush = new StiSolidBrush(Color.Black);
            Text10.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text11
            // 
            Text11 = new StiText();
            Text11.CanGrow = true;
            Text11.ClientRectangle = new RectangleD(1, 0, 7.4, 0.8);
            Text11.GrowToHeight = true;
            Text11.Name = "Text11";
            Text11.GetValue += new StiGetValueEventHandler(Text11__GetValue);
            Text11.VertAlignment = StiVertAlignment.Center;
            Text11.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text11.Brush = new StiSolidBrush(Color.Transparent);
            Text11.Font = new Font("BPG Glaho Arial", 8F);
            Text11.Guid = null;
            Text11.Interaction = null;
            Text11.Margins = new StiMargins(0, 0, 0, 0);
            Text11.TextBrush = new StiSolidBrush(Color.Black);
            Text11.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.EllipsisCharacter);
            // 
            // Text12
            // 
            Text12 = new StiText();
            Text12.ClientRectangle = new RectangleD(20.2, 0, 1.8, 0.8);
            Text12.GrowToHeight = true;
            Text12.HorAlignment = StiTextHorAlignment.Right;
            Text12.Name = "Text12";
            Text12.GetValue += new StiGetValueEventHandler(Text12__GetValue);
            Text12.VertAlignment = StiVertAlignment.Center;
            Text12.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text12.Brush = new StiSolidBrush(Color.Transparent);
            Text12.Font = new Font("BPG Glaho Arial", 8F);
            Text12.Guid = null;
            Text12.Interaction = null;
            Text12.Margins = new StiMargins(0, 0, 0, 0);
            Text12.TextBrush = new StiSolidBrush(Color.Black);
            Text12.TextFormat = new StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            Text12.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text13
            // 
            Text13 = new StiText();
            Text13.ClientRectangle = new RectangleD(22, 0, 1.8, 0.8);
            Text13.GrowToHeight = true;
            Text13.HorAlignment = StiTextHorAlignment.Right;
            Text13.Name = "Text13";
            Text13.GetValue += new StiGetValueEventHandler(Text13__GetValue);
            Text13.VertAlignment = StiVertAlignment.Center;
            Text13.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text13.Brush = new StiSolidBrush(Color.Transparent);
            Text13.Font = new Font("BPG Glaho Arial", 8F);
            Text13.Guid = null;
            Text13.Interaction = null;
            Text13.Margins = new StiMargins(0, 0, 0, 0);
            Text13.TextBrush = new StiSolidBrush(Color.Black);
            Text13.TextFormat = new StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            Text13.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text14
            // 
            Text14 = new StiText();
            Text14.ClientRectangle = new RectangleD(25.6, 0, 2, 0.8);
            Text14.GrowToHeight = true;
            Text14.HorAlignment = StiTextHorAlignment.Right;
            Text14.Name = "Text14";
            Text14.GetValue += new StiGetValueEventHandler(Text14__GetValue);
            Text14.VertAlignment = StiVertAlignment.Center;
            Text14.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text14.Brush = new StiSolidBrush(Color.Transparent);
            Text14.Font = new Font("BPG Glaho Arial", 8F);
            Text14.Guid = null;
            Text14.Interaction = null;
            Text14.Margins = new StiMargins(0, 0, 0, 0);
            Text14.TextBrush = new StiSolidBrush(Color.Black);
            Text14.TextFormat = new StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            Text14.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text15
            // 
            Text15 = new StiText();
            Text15.ClientRectangle = new RectangleD(8.4, 0, 3, 0.8);
            Text15.GrowToHeight = true;
            Text15.Name = "Text15";
            Text15.GetValue += new StiGetValueEventHandler(Text15__GetValue);
            Text15.VertAlignment = StiVertAlignment.Center;
            Text15.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text15.Brush = new StiSolidBrush(Color.Transparent);
            Text15.Font = new Font("BPG Glaho Arial", 8F);
            Text15.Guid = null;
            Text15.Interaction = null;
            Text15.Margins = new StiMargins(0, 0, 0, 0);
            Text15.TextBrush = new StiSolidBrush(Color.Black);
            Text15.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text16
            // 
            Text16 = new StiText();
            Text16.ClientRectangle = new RectangleD(11.4, 0, 1.2, 0.8);
            Text16.GrowToHeight = true;
            Text16.HorAlignment = StiTextHorAlignment.Center;
            Text16.Name = "Text16";
            Text16.GetValue += new StiGetValueEventHandler(Text16__GetValue);
            Text16.VertAlignment = StiVertAlignment.Center;
            Text16.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text16.Brush = new StiSolidBrush(Color.Transparent);
            Text16.Font = new Font("BPG Glaho Arial", 8F);
            Text16.Guid = null;
            Text16.Interaction = null;
            Text16.Margins = new StiMargins(0, 0, 0, 0);
            Text16.TextBrush = new StiSolidBrush(Color.Black);
            Text16.TextFormat = new StiCustomFormatService("MM\\/yy");
            Text16.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text23
            // 
            Text23 = new StiText();
            Text23.CanGrow = true;
            Text23.ClientRectangle = new RectangleD(12.6, 0, 5, 0.8);
            Text23.GrowToHeight = true;
            Text23.Guid = "d938f50e38974de79eb8fcd387869aa1";
            Text23.Name = "Text23";
            Text23.GetValue += new StiGetValueEventHandler(Text23__GetValue);
            Text23.VertAlignment = StiVertAlignment.Center;
            Text23.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text23.Brush = new StiSolidBrush(Color.Transparent);
            Text23.Font = new Font("BPG Glaho Arial", 8F);
            Text23.Interaction = null;
            Text23.Margins = new StiMargins(0, 0, 0, 0);
            Text23.TextBrush = new StiSolidBrush(Color.Black);
            Text23.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text32
            // 
            Text32 = new StiText();
            Text32.CanGrow = true;
            Text32.ClientRectangle = new RectangleD(17.6, 0, 2.6, 0.8);
            Text32.Guid = "11b70ea107f54eaba427a6d7a164bba8";
            Text32.Name = "Text32";
            Text32.GetValue += new StiGetValueEventHandler(Text32__GetValue);
            Text32.VertAlignment = StiVertAlignment.Center;
            Text32.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text32.Brush = new StiSolidBrush(Color.Transparent);
            Text32.Font = new Font("BPG Glaho Arial", 8F);
            Text32.Interaction = null;
            Text32.Margins = new StiMargins(0, 0, 0, 0);
            Text32.TextBrush = new StiSolidBrush(Color.Black);
            Text32.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text25
            // 
            Text25 = new StiText();
            Text25.ClientRectangle = new RectangleD(23.8, 0, 1.8, 0.8);
            Text25.GrowToHeight = true;
            Text25.Guid = "1f58102890a04388879cdfd17ad9a616";
            Text25.HorAlignment = StiTextHorAlignment.Right;
            Text25.Name = "Text25";
            Text25.GetValue += new StiGetValueEventHandler(Text25__GetValue);
            Text25.VertAlignment = StiVertAlignment.Center;
            Text25.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text25.Brush = new StiSolidBrush(Color.Transparent);
            Text25.Font = new Font("BPG Glaho Arial", 8F);
            Text25.Interaction = null;
            Text25.Margins = new StiMargins(0, 0, 0, 0);
            Text25.TextBrush = new StiSolidBrush(Color.Black);
            Text25.TextFormat = new StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            Text25.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            DataSP_GetPurchaseOrderDetail.Guid = null;
            DataSP_GetPurchaseOrderDetail.Interaction = null;
            // 
            // FooterSP_GetPurchaseOrderDetail
            // 
            FooterSP_GetPurchaseOrderDetail = new StiFooterBand();
            FooterSP_GetPurchaseOrderDetail.ClientRectangle = new RectangleD(0, 6.6, 27.7, 4.4);
            FooterSP_GetPurchaseOrderDetail.Name = "FooterSP_GetPurchaseOrderDetail";
            FooterSP_GetPurchaseOrderDetail.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            FooterSP_GetPurchaseOrderDetail.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text17
            // 
            Text17 = new StiText();
            Text17.ClientRectangle = new RectangleD(20.2, 0, 1.8, 0.6);
            Text17.HorAlignment = StiTextHorAlignment.Right;
            Text17.Name = "Text17";
            // 
            // Text17_Sum
            // 
            Text17.GetValue += new StiGetValueEventHandler(Text17__GetValue);
            Text17.VertAlignment = StiVertAlignment.Center;
            Text17.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text17.Brush = new StiSolidBrush(Color.Transparent);
            Text17.Font = new Font("BPG Glaho Arial", 9F);
            Text17.Guid = null;
            Text17.Interaction = null;
            Text17.Margins = new StiMargins(0, 0, 0, 0);
            Text17.TextBrush = new StiSolidBrush(Color.Black);
            Text17.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            Text17.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text18
            // 
            Text18 = new StiText();
            Text18.ClientRectangle = new RectangleD(25.6, 0, 2, 0.6);
            Text18.HorAlignment = StiTextHorAlignment.Right;
            Text18.Name = "Text18";
            // 
            // Text18_Sum
            // 
            Text18.GetValue += new StiGetValueEventHandler(Text18__GetValue);
            Text18.VertAlignment = StiVertAlignment.Center;
            Text18.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text18.Brush = new StiSolidBrush(Color.Transparent);
            Text18.Font = new Font("BPG Glaho Arial", 9F);
            Text18.Guid = null;
            Text18.Interaction = null;
            Text18.Margins = new StiMargins(0, 0, 0, 0);
            Text18.TextBrush = new StiSolidBrush(Color.Black);
            Text18.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            Text18.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text19
            // 
            Text19 = new StiText();
            Text19.ClientRectangle = new RectangleD(0, 0.8, 19, 1.8);
            Text19.HorAlignment = StiTextHorAlignment.Right;
            Text19.Name = "Text19";
            Text19.GetValue += new StiGetValueEventHandler(Text19__GetValue);
            Text19.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text19.Brush = new StiSolidBrush(Color.Transparent);
            Text19.Font = new Font("BPG Glaho Arial", 9F);
            Text19.Guid = null;
            Text19.Interaction = null;
            Text19.Margins = new StiMargins(0, 0, 0, 0);
            Text19.TextBrush = new StiSolidBrush(Color.Black);
            Text19.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text20
            // 
            Text20 = new StiText();
            Text20.ClientRectangle = new RectangleD(6.2, 3.8, 1.6, 0.6);
            Text20.HorAlignment = StiTextHorAlignment.Right;
            Text20.Name = "Text20";
            Text20.GetValue += new StiGetValueEventHandler(Text20__GetValue);
            Text20.VertAlignment = StiVertAlignment.Center;
            Text20.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text20.Brush = new StiSolidBrush(Color.Transparent);
            Text20.Font = new Font("BPG Glaho Arial", 9F);
            Text20.Guid = null;
            Text20.Interaction = null;
            Text20.Margins = new StiMargins(0, 0, 0, 0);
            Text20.TextBrush = new StiSolidBrush(Color.Black);
            Text20.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text21
            // 
            Text21 = new StiText();
            Text21.ClientRectangle = new RectangleD(12.8, 3.8, 1.6, 0.6);
            Text21.Guid = "17c9c51df77b4f0d87fb853966c9b1f8";
            Text21.HorAlignment = StiTextHorAlignment.Right;
            Text21.Name = "Text21";
            Text21.GetValue += new StiGetValueEventHandler(Text21__GetValue);
            Text21.VertAlignment = StiVertAlignment.Center;
            Text21.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text21.Brush = new StiSolidBrush(Color.Transparent);
            Text21.Font = new Font("BPG Glaho Arial", 9F);
            Text21.Interaction = null;
            Text21.Margins = new StiMargins(0, 0, 0, 0);
            Text21.TextBrush = new StiSolidBrush(Color.Black);
            Text21.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HorizontalLine1
            // 
            HorizontalLine1 = new StiHorizontalLinePrimitive();
            HorizontalLine1.ClientRectangle = new RectangleD(7.8, 4.2, 4.6, 0.0254);
            HorizontalLine1.Color = Color.Black;
            HorizontalLine1.Name = "HorizontalLine1";
            HorizontalLine1.Style = StiPenStyle.Dot;
            HorizontalLine1.EndCap = new StiCap(10, StiCapStyle.None, 10, true, Color.Black);
            HorizontalLine1.Guid = null;
            HorizontalLine1.Interaction = null;
            HorizontalLine1.StartCap = new StiCap(10, StiCapStyle.None, 10, true, Color.Black);
            // 
            // HorizontalLine2
            // 
            HorizontalLine2 = new StiHorizontalLinePrimitive();
            HorizontalLine2.ClientRectangle = new RectangleD(14.4, 4.2, 4.6, 0.0254);
            HorizontalLine2.Color = Color.Black;
            HorizontalLine2.Guid = "eb5065805ee7455cb2f5f2716141505c";
            HorizontalLine2.Name = "HorizontalLine2";
            HorizontalLine2.Style = StiPenStyle.Dot;
            HorizontalLine2.EndCap = new StiCap(10, StiCapStyle.None, 10, true, Color.Black);
            HorizontalLine2.Interaction = null;
            HorizontalLine2.StartCap = new StiCap(10, StiCapStyle.None, 10, true, Color.Black);
            FooterSP_GetPurchaseOrderDetail.Guid = null;
            FooterSP_GetPurchaseOrderDetail.Interaction = null;
            Page1.ExcelSheetValue = null;
            Page1.Interaction = null;
            Page1.Margins = new StiMargins(1, 1, 1, 1);
            Page1_Watermark = new StiWatermark();
            Page1_Watermark.Font = new Font("Arial", 100F);
            Page1_Watermark.Image = null;
            Page1_Watermark.TextBrush = new StiSolidBrush(Color.FromArgb(50, 0, 0, 0));
            RptPurchaseOrderDetail_PrinterSettings = new StiPrinterSettings();
            PrinterSettings = RptPurchaseOrderDetail_PrinterSettings;
            Page1.Report = this;
            Page1.Watermark = Page1_Watermark;
            DataSP_GetPurchaseOrderHeader.Page = Page1;
            DataSP_GetPurchaseOrderHeader.Parent = Page1;
            Text1.Page = Page1;
            Text1.Parent = DataSP_GetPurchaseOrderHeader;
            Text2.Page = Page1;
            Text2.Parent = DataSP_GetPurchaseOrderHeader;
            HeaderSP_GetPurchaseOrderDetail.Page = Page1;
            HeaderSP_GetPurchaseOrderDetail.Parent = Page1;
            Text3.Page = Page1;
            Text3.Parent = HeaderSP_GetPurchaseOrderDetail;
            Text4.Page = Page1;
            Text4.Parent = HeaderSP_GetPurchaseOrderDetail;
            Text5.Page = Page1;
            Text5.Parent = HeaderSP_GetPurchaseOrderDetail;
            Text6.Page = Page1;
            Text6.Parent = HeaderSP_GetPurchaseOrderDetail;
            Text7.Page = Page1;
            Text7.Parent = HeaderSP_GetPurchaseOrderDetail;
            Text8.Page = Page1;
            Text8.Parent = HeaderSP_GetPurchaseOrderDetail;
            Text9.Page = Page1;
            Text9.Parent = HeaderSP_GetPurchaseOrderDetail;
            Text22.Page = Page1;
            Text22.Parent = HeaderSP_GetPurchaseOrderDetail;
            Text33.Page = Page1;
            Text33.Parent = HeaderSP_GetPurchaseOrderDetail;
            Text24.Page = Page1;
            Text24.Parent = HeaderSP_GetPurchaseOrderDetail;
            DataSP_GetPurchaseOrderDetail.MasterComponent = DataSP_GetPurchaseOrderHeader;
            DataSP_GetPurchaseOrderDetail.Page = Page1;
            DataSP_GetPurchaseOrderDetail.Parent = Page1;
            Text10.Page = Page1;
            Text10.Parent = DataSP_GetPurchaseOrderDetail;
            Text11.Page = Page1;
            Text11.Parent = DataSP_GetPurchaseOrderDetail;
            Text12.Page = Page1;
            Text12.Parent = DataSP_GetPurchaseOrderDetail;
            Text13.Page = Page1;
            Text13.Parent = DataSP_GetPurchaseOrderDetail;
            Text14.Page = Page1;
            Text14.Parent = DataSP_GetPurchaseOrderDetail;
            Text15.Page = Page1;
            Text15.Parent = DataSP_GetPurchaseOrderDetail;
            Text16.Page = Page1;
            Text16.Parent = DataSP_GetPurchaseOrderDetail;
            Text23.Page = Page1;
            Text23.Parent = DataSP_GetPurchaseOrderDetail;
            Text32.Page = Page1;
            Text32.Parent = DataSP_GetPurchaseOrderDetail;
            Text25.Page = Page1;
            Text25.Parent = DataSP_GetPurchaseOrderDetail;
            FooterSP_GetPurchaseOrderDetail.Page = Page1;
            FooterSP_GetPurchaseOrderDetail.Parent = Page1;
            Text17.Page = Page1;
            Text17.Parent = FooterSP_GetPurchaseOrderDetail;
            Text18.Page = Page1;
            Text18.Parent = FooterSP_GetPurchaseOrderDetail;
            Text19.Page = Page1;
            Text19.Parent = FooterSP_GetPurchaseOrderDetail;
            Text20.Page = Page1;
            Text20.Parent = FooterSP_GetPurchaseOrderDetail;
            Text21.Page = Page1;
            Text21.Parent = FooterSP_GetPurchaseOrderDetail;
            HorizontalLine1.Page = Page1;
            HorizontalLine1.Parent = FooterSP_GetPurchaseOrderDetail;
            HorizontalLine2.Page = Page1;
            HorizontalLine2.Parent = FooterSP_GetPurchaseOrderDetail;
            DataSP_GetPurchaseOrderDetail.BeginRender += new EventHandler(DataSP_GetPurchaseOrderDetail__BeginRender);
            DataSP_GetPurchaseOrderDetail.EndRender += new EventHandler(DataSP_GetPurchaseOrderDetail__EndRender);
            DataSP_GetPurchaseOrderDetail.Rendering += new EventHandler(DataSP_GetPurchaseOrderDetail__Rendering);
            AggregateFunctions = new object[] {
                    Text17_Sum,
                    Text18_Sum};
            // 
            // Add to DataSP_GetPurchaseOrderHeader.Components
            // 
            DataSP_GetPurchaseOrderHeader.Components.Clear();
            DataSP_GetPurchaseOrderHeader.Components.AddRange(new StiComponent[] {
                        Text1,
                        Text2});
            // 
            // Add to HeaderSP_GetPurchaseOrderDetail.Components
            // 
            HeaderSP_GetPurchaseOrderDetail.Components.Clear();
            HeaderSP_GetPurchaseOrderDetail.Components.AddRange(new StiComponent[] {
                        Text3,
                        Text4,
                        Text5,
                        Text6,
                        Text7,
                        Text8,
                        Text9,
                        Text22,
                        Text33,
                        Text24});
            // 
            // Add to DataSP_GetPurchaseOrderDetail.Components
            // 
            DataSP_GetPurchaseOrderDetail.Components.Clear();
            DataSP_GetPurchaseOrderDetail.Components.AddRange(new StiComponent[] {
                        Text10,
                        Text11,
                        Text12,
                        Text13,
                        Text14,
                        Text15,
                        Text16,
                        Text23,
                        Text32,
                        Text25});
            // 
            // Add to FooterSP_GetPurchaseOrderDetail.Components
            // 
            FooterSP_GetPurchaseOrderDetail.Components.Clear();
            FooterSP_GetPurchaseOrderDetail.Components.AddRange(new StiComponent[] {
                        Text17,
                        Text18,
                        Text19,
                        Text20,
                        Text21,
                        HorizontalLine1,
                        HorizontalLine2});
            // 
            // Add to Page1.Components
            // 
            Page1.Components.Clear();
            Page1.Components.AddRange(new StiComponent[] {
                        DataSP_GetPurchaseOrderHeader,
                        HeaderSP_GetPurchaseOrderDetail,
                        DataSP_GetPurchaseOrderDetail,
                        FooterSP_GetPurchaseOrderDetail});
            // 
            // Add to Pages
            // 
            Pages.Clear();
            Pages.AddRange(new[] {
                        Page1});
            Dictionary.Relations.Add(ParentSP_GetPurchaseOrderHeader);
            SP_GetPurchaseOrderDetail.Columns.AddRange(new[] {
                        new StiDataColumn("PurchaseOrderDetailID", "PurchaseOrderDetailID", "PurchaseOrderDetailID", typeof(Guid)),
                        new StiDataColumn("PurchaseOrderID", "PurchaseOrderID", "PurchaseOrderID", typeof(int)),
                        new StiDataColumn("ReceivedQty", "ReceivedQty", "ReceivedQty", typeof(decimal)),
                        new StiDataColumn("UnitPrice", "UnitPrice", "UnitPrice", typeof(decimal)),
                        new StiDataColumn("LineTotal", "LineTotal", "LineTotal", typeof(decimal)),
                        new StiDataColumn("VendorUnitPrice", "VendorUnitPrice", "VendorUnitPrice", typeof(decimal)),
                        new StiDataColumn("OrdinalNumber", "OrdinalNumber", "OrdinalNumber", typeof(short)),
                        new StiDataColumn("ProductID", "ProductID", "ProductID", typeof(int)),
                        new StiDataColumn("MedicamentID", "MedicamentID", "MedicamentID", typeof(int)),
                        new StiDataColumn("ProductNumber", "ProductNumber", "ProductNumber", typeof(string)),
                        new StiDataColumn("MedicamentName", "MedicamentName", "MedicamentName", typeof(string)),
                        new StiDataColumn("StandardCost", "StandardCost", "StandardCost", typeof(decimal)),
                        new StiDataColumn("ListPrice", "ListPrice", "ListPrice", typeof(decimal)),
                        new StiDataColumn("DealerPrice", "DealerPrice", "DealerPrice", typeof(decimal)),
                        new StiDataColumn("ProductCurrencyCode", "ProductCurrencyCode", "ProductCurrencyCode", typeof(string)),
                        new StiDataColumn("ProductCurrencyRate", "ProductCurrencyRate", "ProductCurrencyRate", typeof(decimal)),
                        new StiDataColumn("DiscountPct", "DiscountPct", "DiscountPct", typeof(decimal)),
                        new StiDataColumn("TaxRate", "TaxRate", "TaxRate", typeof(decimal)),
                        new StiDataColumn("ValidDate", "ValidDate", "ValidDate", typeof(DateTime?)),
                        new StiDataColumn("CountryCode", "CountryCode", "CountryCode", typeof(string)),
                        new StiDataColumn("CountryName", "CountryName", "CountryName", typeof(string)),
                        new StiDataColumn("BrandID", "BrandID", "BrandID", typeof(int)),
                        new StiDataColumn("BrandName", "BrandName", "BrandName", typeof(string)),
                        new StiDataColumn("Serie", "Serie", "Serie", typeof(string)),
                        new StiDataColumn("UnitsInStock", "UnitsInStock", "UnitsInStock", typeof(short)),
                        new StiDataColumn("_TaxAmt", "_TaxAmt", "_TaxAmt", typeof(decimal)),
                        new StiDataColumn("_LineTotal", "_LineTotal", "_LineTotal", typeof(decimal)),
                        new StiDataColumn("_ListPrice", "_ListPrice", "_ListPrice", typeof(decimal)),
                        new StiDataColumn("_DealerPrice", "_DealerPrice", "_DealerPrice", typeof(decimal)),
                        new StiDataColumn("_VendorUnitPrice", "_VendorUnitPrice", "_VendorUnitPrice", typeof(decimal)),
                        new StiDataColumn("_CalcVendorUnitPricePct", "_CalcVendorUnitPricePct", "_CalcVendorUnitPricePct", typeof(decimal)),
                        new StiDataColumn("Action", "Action", "Action", typeof(int))});
            DataSources.Add(SP_GetPurchaseOrderDetail);
            SP_GetPurchaseOrderHeader.Columns.AddRange(new[] {
                        new StiDataColumn("PurchaseOrderID", "PurchaseOrderID", "PurchaseOrderID", typeof(int)),
                        new StiDataColumn("BranchID", "BranchID", "BranchID", typeof(int)),
                        new StiDataColumn("BranchName", "BranchName", "BranchName", typeof(string)),
                        new StiDataColumn("OrderDate", "OrderDate", "OrderDate", typeof(DateTime)),
                        new StiDataColumn("OverheadNumber", "OverheadNumber", "OverheadNumber", typeof(string)),
                        new StiDataColumn("VendorID", "VendorID", "VendorID", typeof(int)),
                        new StiDataColumn("VendorName", "VendorName", "VendorName", typeof(string)),
                        new StiDataColumn("SubTotal", "SubTotal", "SubTotal", typeof(decimal)),
                        new StiDataColumn("TaxAmt", "TaxAmt", "TaxAmt", typeof(decimal)),
                        new StiDataColumn("Freight", "Freight", "Freight", typeof(decimal)),
                        new StiDataColumn("TotalDue", "TotalDue", "TotalDue", typeof(decimal)),
                        new StiDataColumn("CurrencyCode", "CurrencyCode", "CurrencyCode", typeof(string)),
                        new StiDataColumn("CurrencyRate1", "CurrencyRate1", "CurrencyRate1", typeof(decimal)),
                        new StiDataColumn("CurrencyRate2", "CurrencyRate2", "CurrencyRate2", typeof(decimal)),
                        new StiDataColumn("PaymentMethodID", "PaymentMethodID", "PaymentMethodID", typeof(int)),
                        new StiDataColumn("PaymentMethodName", "PaymentMethodName", "PaymentMethodName", typeof(string)),
                        new StiDataColumn("RevisionNumber", "RevisionNumber", "RevisionNumber", typeof(byte)),
                        new StiDataColumn("Status", "Status", "Status", typeof(byte)),
                        new StiDataColumn("ModifiedUserID", "ModifiedUserID", "ModifiedUserID", typeof(int)),
                        new StiDataColumn("Modifier", "Modifier", "Modifier", typeof(string)),
                        new StiDataColumn("ModifiedDate", "ModifiedDate", "ModifiedDate", typeof(DateTime)),
                        new StiDataColumn("ApproverUserID", "ApproverUserID", "ApproverUserID", typeof(int)),
                        new StiDataColumn("Approver", "Approver", "Approver", typeof(string)),
                        new StiDataColumn("rowguid", "rowguid", "rowguid", typeof(Guid)),
                        new StiDataColumn("Action", "Action", "Action", typeof(int))});
            DataSources.Add(SP_GetPurchaseOrderHeader);
        }

        #region Relation ParentSP_GetPurchaseOrderHeader
        public class ParentSP_GetPurchaseOrderHeaderRelation : StiDataRow
        {

            public ParentSP_GetPurchaseOrderHeaderRelation(StiDataRow dataRow) :
                base(dataRow)
            {
            }

            public virtual int PurchaseOrderID
            {
                get
                {
                    return ((int)(ChangeType(this["PurchaseOrderID"], typeof(int), true)));
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

            public virtual int VendorID
            {
                get
                {
                    return ((int)(ChangeType(this["VendorID"], typeof(int), true)));
                }
            }

            public virtual string VendorName
            {
                get
                {
                    return ((string)(ChangeType(this["VendorName"], typeof(string), true)));
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

            public virtual decimal CurrencyRate1
            {
                get
                {
                    return ((decimal)(ChangeType(this["CurrencyRate1"], typeof(decimal), true)));
                }
            }

            public virtual decimal CurrencyRate2
            {
                get
                {
                    return ((decimal)(ChangeType(this["CurrencyRate2"], typeof(decimal), true)));
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

            public virtual Guid rowguid
            {
                get
                {
                    return ((Guid)(ChangeType(this["rowguid"], typeof(Guid), true)));
                }
            }

            public virtual int Action
            {
                get
                {
                    return ((int)(ChangeType(this["Action"], typeof(int), true)));
                }
            }
        }
        #endregion Relation ParentSP_GetPurchaseOrderHeader

        #region DataSource SP_GetPurchaseOrderDetail
        public class SP_GetPurchaseOrderDetailDataSource : StiDataTableSource
        {

            public SP_GetPurchaseOrderDetailDataSource() :
                base("DS_Purchasing.SP_GetPurchaseOrderDetail", "SP_GetPurchaseOrderDetail")
            {
            }

            public virtual Guid PurchaseOrderDetailID
            {
                get
                {
                    return ((Guid)(ChangeType(this["PurchaseOrderDetailID"], typeof(Guid), true)));
                }
            }

            public virtual int PurchaseOrderID
            {
                get
                {
                    return ((int)(ChangeType(this["PurchaseOrderID"], typeof(int), true)));
                }
            }

            public virtual decimal ReceivedQty
            {
                get
                {
                    return ((decimal)(ChangeType(this["ReceivedQty"], typeof(decimal), true)));
                }
            }

            public virtual decimal UnitPrice
            {
                get
                {
                    return ((decimal)(ChangeType(this["UnitPrice"], typeof(decimal), true)));
                }
            }

            public virtual decimal LineTotal
            {
                get
                {
                    return ((decimal)(ChangeType(this["LineTotal"], typeof(decimal), true)));
                }
            }

            public virtual decimal VendorUnitPrice
            {
                get
                {
                    return ((decimal)(ChangeType(this["VendorUnitPrice"], typeof(decimal), true)));
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

            public virtual string ProductCurrencyCode
            {
                get
                {
                    return ((string)(ChangeType(this["ProductCurrencyCode"], typeof(string), true)));
                }
            }

            public virtual decimal ProductCurrencyRate
            {
                get
                {
                    return ((decimal)(ChangeType(this["ProductCurrencyRate"], typeof(decimal), true)));
                }
            }

            public virtual decimal DiscountPct
            {
                get
                {
                    return ((decimal)(ChangeType(this["DiscountPct"], typeof(decimal), true)));
                }
            }

            public virtual decimal TaxRate
            {
                get
                {
                    return ((decimal)(ChangeType(this["TaxRate"], typeof(decimal), true)));
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

            public virtual decimal _TaxAmt
            {
                get
                {
                    return ((decimal)(ChangeType(this["_TaxAmt"], typeof(decimal), true)));
                }
            }

            public virtual decimal _LineTotal
            {
                get
                {
                    return ((decimal)(ChangeType(this["_LineTotal"], typeof(decimal), true)));
                }
            }

            public virtual decimal _ListPrice
            {
                get
                {
                    return ((decimal)(ChangeType(this["_ListPrice"], typeof(decimal), true)));
                }
            }

            public virtual decimal _DealerPrice
            {
                get
                {
                    return ((decimal)(ChangeType(this["_DealerPrice"], typeof(decimal), true)));
                }
            }

            public virtual decimal _VendorUnitPrice
            {
                get
                {
                    return ((decimal)(ChangeType(this["_VendorUnitPrice"], typeof(decimal), true)));
                }
            }

            public virtual decimal _CalcVendorUnitPricePct
            {
                get
                {
                    return ((decimal)(ChangeType(this["_CalcVendorUnitPricePct"], typeof(decimal), true)));
                }
            }

            public virtual int Action
            {
                get
                {
                    return ((int)(ChangeType(this["Action"], typeof(int), true)));
                }
            }

            public virtual ParentSP_GetPurchaseOrderHeaderRelation SP_GetPurchaseOrderHeader
            {
                get
                {
                    return new ParentSP_GetPurchaseOrderHeaderRelation(GetParentData("SP_GetPurchaseOrderHeader_SP_GetPurchaseOrderDetail"));
                }
            }
        }
        #endregion DataSource SP_GetPurchaseOrderDetail

        #region DataSource SP_GetPurchaseOrderHeader
        public class SP_GetPurchaseOrderHeaderDataSource : StiDataTableSource
        {

            public SP_GetPurchaseOrderHeaderDataSource() :
                base("DS_Purchasing.SP_GetPurchaseOrderHeader", "SP_GetPurchaseOrderHeader")
            {
            }

            public virtual int PurchaseOrderID
            {
                get
                {
                    return ((int)(ChangeType(this["PurchaseOrderID"], typeof(int), true)));
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

            public virtual int VendorID
            {
                get
                {
                    return ((int)(ChangeType(this["VendorID"], typeof(int), true)));
                }
            }

            public virtual string VendorName
            {
                get
                {
                    return ((string)(ChangeType(this["VendorName"], typeof(string), true)));
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

            public virtual decimal CurrencyRate1
            {
                get
                {
                    return ((decimal)(ChangeType(this["CurrencyRate1"], typeof(decimal), true)));
                }
            }

            public virtual decimal CurrencyRate2
            {
                get
                {
                    return ((decimal)(ChangeType(this["CurrencyRate2"], typeof(decimal), true)));
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

            public virtual Guid rowguid
            {
                get
                {
                    return ((Guid)(ChangeType(this["rowguid"], typeof(Guid), true)));
                }
            }

            public virtual int Action
            {
                get
                {
                    return ((int)(ChangeType(this["Action"], typeof(int), true)));
                }
            }
        }
        #endregion DataSource SP_GetPurchaseOrderHeader
        #endregion StiReport Designer generated code - do not modify
    }
}
