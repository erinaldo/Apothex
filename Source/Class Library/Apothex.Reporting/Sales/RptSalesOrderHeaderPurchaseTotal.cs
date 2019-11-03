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

    public class RptSalesOrderHeaderPurchaseTotal : StiReport
    {

        public RptSalesOrderHeaderPurchaseTotal()
        {
            InitializeComponent();
        }
        #region StiReport Designer generated code - do not modify
        public StiPage Page1;
        public StiReportTitleBand ReportTitleBand1;
        public StiText Text1;
        public StiHeaderBand HeaderBand1;
        public StiText Text8;
        public StiText Text9;
        public StiText Text10;
        public StiText Text11;
        public StiText Text12;
        public StiText Text13;
        public StiText Text14;
        public StiText Text15;
        public StiGroupHeaderBand GroupHeaderBand2;
        public StiText Text2;
        public StiText Text3;
        public StiText Text4;
        public StiText Text5;
        public StiSumDecimalFunctionService Text5_Sum;
        public StiText Text6;
        public StiSumDecimalFunctionService Text6_Sum;
        public StiText Text7;
        public StiSumDecimalFunctionService Text7_Sum1;
        public StiSumDecimalFunctionService Text7_Sum2;
        public StiDataBand DataFN_GetSalesOrderHeaderPurchaseTotal;
        public StiFooterBand FooterBand1;
        public StiText Text16;
        public StiSumDecimalFunctionService Text16_Sum;
        public StiText Text17;
        public StiSumDecimalFunctionService Text17_Sum;
        public StiText Text18;
        public StiSumDecimalFunctionService Text18_Sum1;
        public StiSumDecimalFunctionService Text18_Sum2;
        public StiWatermark Page1_Watermark;
        public StiPrinterSettings RptSalesOrderHeaderPurchaseTotal_PrinterSettings;
        public FN_GetSalesOrderHeaderPurchaseTotalDataSource FN_GetSalesOrderHeaderPurchaseTotal;

        public void Text1__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "მოგების ჟურნალი";
        }

        public void Text8__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ფილიალი";
        }

        public void Text9__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "თარიღი";
        }

        public void Text10__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ჯამი / შ.";
        }

        public void Text11__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ჯამი / გ.";
        }

        public void Text12__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ჯამი / შ.";
        }

        public void Text13__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ჯამი / გ.";
        }

        public void Text14__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "მოგება";
        }

        public void Text15__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "გადახდის მეთოდი";
        }

        public void GroupHeaderBand2__GetValue(object sender, StiValueEventArgs e)
        {
            e.Value = Format("{0:MM.dd.yyyy}", FN_GetSalesOrderHeaderPurchaseTotal.OrderDate) + " \r\n" + FN_GetSalesOrderHeaderPurchaseTotal.BranchName + "\r\n" + FN_GetSalesOrderHeaderPurchaseTotal.PaymentMethodName;
        }

        public void Text2__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, FN_GetSalesOrderHeaderPurchaseTotal.BranchName, true);
        }

        public void Text3__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text3.TextFormat.Format(CheckExcelValue(sender, FN_GetSalesOrderHeaderPurchaseTotal.OrderDate));
        }

        public void Text4__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, FN_GetSalesOrderHeaderPurchaseTotal.PaymentMethodName, true);
        }

        public void Text5__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(FN_GetSalesOrderHeaderPurchaseTotal.PurchaseSubTotal + FN_GetSalesOrderHe" +
"aderPurchaseTotal.PurchaseTaxAmt)}";
            e.StoreToPrinted = true;
        }

        public String Text5_GetValue_End(StiComponent sender)
        {
            return Text5.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text5_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void Text6__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(FN_GetSalesOrderHeaderPurchaseTotal.SalesSubTotal + FN_GetSalesOrderHeade" +
"rPurchaseTotal.SalesTaxAmt)}";
            e.StoreToPrinted = true;
        }

        public String Text6_GetValue_End(StiComponent sender)
        {
            return Text6.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text6_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void Text7__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(FN_GetSalesOrderHeaderPurchaseTotal.SalesSubTotal + FN_GetSalesOrderHeade" +
"rPurchaseTotal.SalesTaxAmt) - Sum(FN_GetSalesOrderHeaderPurchaseTotal.PurchaseSu" +
"bTotal + FN_GetSalesOrderHeaderPurchaseTotal.PurchaseTaxAmt)}";
            e.StoreToPrinted = true;
        }

        public String Text7_GetValue_End(StiComponent sender)
        {
            return Text7.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text7_Sum1.GetValue(), typeof(decimal), true))) - ((decimal)(ChangeType(Text7_Sum2.GetValue(), typeof(decimal), true)))));
        }

        public void Text16__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(FN_GetSalesOrderHeaderPurchaseTotal.PurchaseSubTotal + FN_GetSalesOrderHe" +
"aderPurchaseTotal.PurchaseTaxAmt)}";
            e.StoreToPrinted = true;
        }

        public String Text16_GetValue_End(StiComponent sender)
        {
            return Text16.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text16_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void Text17__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(FN_GetSalesOrderHeaderPurchaseTotal.SalesSubTotal + FN_GetSalesOrderHeade" +
"rPurchaseTotal.SalesTaxAmt)}";
            e.StoreToPrinted = true;
        }

        public String Text17_GetValue_End(StiComponent sender)
        {
            return Text17.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text17_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void Text18__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(FN_GetSalesOrderHeaderPurchaseTotal.SalesSubTotal + FN_GetSalesOrderHeade" +
"rPurchaseTotal.SalesTaxAmt) - Sum(FN_GetSalesOrderHeaderPurchaseTotal.PurchaseSu" +
"bTotal + FN_GetSalesOrderHeaderPurchaseTotal.PurchaseTaxAmt)}";
            e.StoreToPrinted = true;
        }

        public String Text18_GetValue_End(StiComponent sender)
        {
            return Text18.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text18_Sum1.GetValue(), typeof(decimal), true))) - ((decimal)(ChangeType(Text18_Sum2.GetValue(), typeof(decimal), true)))));
        }

        public void GroupHeaderBand2__BeginRender(object sender, EventArgs e)
        {
            Text5_Sum.Init();
            Text5.TextValue = "";
            Text6_Sum.Init();
            Text6.TextValue = "";
            Text7_Sum1.Init();
            Text7.TextValue = "";
            Text7_Sum2.Init();
            Text7.TextValue = "";
        }

        public void GroupHeaderBand2__EndRender(object sender, EventArgs e)
        {
            Text5.SetText(new StiGetValue(Text5_GetValue_End));
            Text6.SetText(new StiGetValue(Text6_GetValue_End));
            Text7.SetText(new StiGetValue(Text7_GetValue_End));
        }

        public void DataFN_GetSalesOrderHeaderPurchaseTotal__BeginRender(object sender, EventArgs e)
        {
            Text16_Sum.Init();
            Text16.TextValue = "";
            Text17_Sum.Init();
            Text17.TextValue = "";
            Text18_Sum1.Init();
            Text18.TextValue = "";
            Text18_Sum2.Init();
            Text18.TextValue = "";
        }

        public void DataFN_GetSalesOrderHeaderPurchaseTotal__EndRender(object sender, EventArgs e)
        {
            Text16.SetText(new StiGetValue(Text16_GetValue_End));
            Text17.SetText(new StiGetValue(Text17_GetValue_End));
            Text18.SetText(new StiGetValue(Text18_GetValue_End));
        }

        public void GroupHeaderBand2__Rendering(object sender, EventArgs e)
        {
            Text5_Sum.CalcItem(FN_GetSalesOrderHeaderPurchaseTotal.PurchaseSubTotal + FN_GetSalesOrderHeaderPurchaseTotal.PurchaseTaxAmt);
            Text6_Sum.CalcItem(FN_GetSalesOrderHeaderPurchaseTotal.SalesSubTotal + FN_GetSalesOrderHeaderPurchaseTotal.SalesTaxAmt);
            Text7_Sum1.CalcItem(FN_GetSalesOrderHeaderPurchaseTotal.SalesSubTotal + FN_GetSalesOrderHeaderPurchaseTotal.SalesTaxAmt);
            Text7_Sum2.CalcItem(FN_GetSalesOrderHeaderPurchaseTotal.PurchaseSubTotal + FN_GetSalesOrderHeaderPurchaseTotal.PurchaseTaxAmt);
        }

        public void DataFN_GetSalesOrderHeaderPurchaseTotal__Rendering(object sender, EventArgs e)
        {
            Text16_Sum.CalcItem(FN_GetSalesOrderHeaderPurchaseTotal.PurchaseSubTotal + FN_GetSalesOrderHeaderPurchaseTotal.PurchaseTaxAmt);
            Text17_Sum.CalcItem(FN_GetSalesOrderHeaderPurchaseTotal.SalesSubTotal + FN_GetSalesOrderHeaderPurchaseTotal.SalesTaxAmt);
            Text18_Sum1.CalcItem(FN_GetSalesOrderHeaderPurchaseTotal.SalesSubTotal + FN_GetSalesOrderHeaderPurchaseTotal.SalesTaxAmt);
            Text18_Sum2.CalcItem(FN_GetSalesOrderHeaderPurchaseTotal.PurchaseSubTotal + FN_GetSalesOrderHeaderPurchaseTotal.PurchaseTaxAmt);
        }

        private void InitializeComponent()
        {
            FN_GetSalesOrderHeaderPurchaseTotal = new FN_GetSalesOrderHeaderPurchaseTotalDataSource();
            NeedsCompiling = false;
            Text18_Sum1 = new StiSumDecimalFunctionService();
            Text18_Sum2 = new StiSumDecimalFunctionService();
            Text17_Sum = new StiSumDecimalFunctionService();
            Text16_Sum = new StiSumDecimalFunctionService();
            Text7_Sum1 = new StiSumDecimalFunctionService();
            Text7_Sum2 = new StiSumDecimalFunctionService();
            Text6_Sum = new StiSumDecimalFunctionService();
            Text5_Sum = new StiSumDecimalFunctionService();
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
            ReportAlias = "Rpt Sales Order Header Purchase Total";
            ReportAuthor = "Programmer.GE";
            // 
            // ReportChanged
            // 
            ReportChanged = new DateTime(2010, 2, 25, 21, 32, 48, 718);
            // 
            // ReportCreated
            // 
            ReportCreated = new DateTime(2009, 8, 6, 21, 34, 3, 0);
            ReportDescription = "მოგების ჟურნალი (დაჯგუფებული)";
            ReportFile = "D:\\My Documents\\Projects\\Apothex\\Source\\Class Library\\Apothex.Reporting\\Sales\\Rpt" +
"SalesOrderHeaderPurchaseTotal.mrt";
            ReportGuid = "f49a941abd3949d8932cb0fdd662bc9e";
            ReportName = "RptSalesOrderHeaderPurchaseTotal";
            ReportUnit = StiReportUnitType.Centimeters;
            ScriptLanguage = StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            Page1 = new StiPage();
            Page1.Guid = "5bf063ac2d254cd28a26e54f9ff09381";
            Page1.Name = "Page1";
            Page1.PageHeight = 29.7;
            Page1.PageWidth = 21;
            Page1.PaperSize = PaperKind.A4;
            Page1.Border = new StiBorder(StiBorderSides.None, Color.Black, 2, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Page1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // ReportTitleBand1
            // 
            ReportTitleBand1 = new StiReportTitleBand();
            ReportTitleBand1.ClientRectangle = new RectangleD(0, 0.4, 19, 0.8);
            ReportTitleBand1.Name = "ReportTitleBand1";
            ReportTitleBand1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            ReportTitleBand1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text1
            // 
            Text1 = new StiText();
            Text1.ClientRectangle = new RectangleD(0, 0, 19, 0.8);
            Text1.HorAlignment = StiTextHorAlignment.Center;
            Text1.Name = "Text1";
            Text1.GetValue += new StiGetValueEventHandler(Text1__GetValue);
            Text1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text1.Brush = new StiSolidBrush(Color.Transparent);
            Text1.Font = new Font("BPG Glaho Arial", 12F, FontStyle.Bold);
            Text1.Guid = null;
            Text1.Interaction = null;
            Text1.Margins = new StiMargins(0, 0, 0, 0);
            Text1.TextBrush = new StiSolidBrush(Color.Black);
            Text1.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            ReportTitleBand1.Guid = null;
            ReportTitleBand1.Interaction = null;
            // 
            // HeaderBand1
            // 
            HeaderBand1 = new StiHeaderBand();
            HeaderBand1.ClientRectangle = new RectangleD(0, 2, 19, 0.6);
            HeaderBand1.Name = "HeaderBand1";
            HeaderBand1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderBand1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text8
            // 
            Text8 = new StiText();
            Text8.ClientRectangle = new RectangleD(0, 0, 5.8, 0.6);
            Text8.HorAlignment = StiTextHorAlignment.Center;
            Text8.Name = "Text8";
            Text8.GetValue += new StiGetValueEventHandler(Text8__GetValue);
            Text8.VertAlignment = StiVertAlignment.Center;
            Text8.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text8.Brush = new StiSolidBrush(Color.Transparent);
            Text8.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            Text8.Guid = null;
            Text8.Interaction = null;
            Text8.Margins = new StiMargins(0, 0, 0, 0);
            Text8.TextBrush = new StiSolidBrush(Color.Black);
            Text8.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text9
            // 
            Text9 = new StiText();
            Text9.ClientRectangle = new RectangleD(5.8, 0, 2, 0.6);
            Text9.Guid = "f024598007b642c9b6f61c05578288bd";
            Text9.HorAlignment = StiTextHorAlignment.Center;
            Text9.Name = "Text9";
            Text9.GetValue += new StiGetValueEventHandler(Text9__GetValue);
            Text9.VertAlignment = StiVertAlignment.Center;
            Text9.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text9.Brush = new StiSolidBrush(Color.Transparent);
            Text9.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            Text9.Interaction = null;
            Text9.Margins = new StiMargins(0, 0, 0, 0);
            Text9.TextBrush = new StiSolidBrush(Color.Black);
            Text9.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text10
            // 
            Text10 = new StiText();
            Text10.ClientRectangle = new RectangleD(7.8, 0, 2.4, 0.6);
            Text10.Guid = "39898374932e4457b57d3316a524f5cb";
            Text10.HorAlignment = StiTextHorAlignment.Center;
            Text10.Name = "Text10";
            Text10.GetValue += new StiGetValueEventHandler(Text10__GetValue);
            Text10.VertAlignment = StiVertAlignment.Center;
            Text10.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text10.Brush = new StiSolidBrush(Color.Transparent);
            Text10.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            Text10.Interaction = null;
            Text10.Margins = new StiMargins(0, 0, 0, 0);
            Text10.TextBrush = new StiSolidBrush(Color.Black);
            Text10.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text11
            // 
            Text11 = new StiText();
            Text11.ClientRectangle = new RectangleD(10.2, 0, 2.4, 0.6);
            Text11.Guid = "95bb7db1a7624bec9498d8c9787dc960";
            Text11.HorAlignment = StiTextHorAlignment.Center;
            Text11.Name = "Text11";
            Text11.GetValue += new StiGetValueEventHandler(Text11__GetValue);
            Text11.VertAlignment = StiVertAlignment.Center;
            Text11.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text11.Brush = new StiSolidBrush(Color.Transparent);
            Text11.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            Text11.Interaction = null;
            Text11.Margins = new StiMargins(0, 0, 0, 0);
            Text11.TextBrush = new StiSolidBrush(Color.Black);
            Text11.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text12
            // 
            Text12 = new StiText();
            Text12.ClientRectangle = new RectangleD(7.8, 0, 2.4, 0.6);
            Text12.Guid = "07044fbd4db348d8a3ea69548d8d1c72";
            Text12.HorAlignment = StiTextHorAlignment.Center;
            Text12.Name = "Text12";
            Text12.GetValue += new StiGetValueEventHandler(Text12__GetValue);
            Text12.VertAlignment = StiVertAlignment.Center;
            Text12.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text12.Brush = new StiSolidBrush(Color.Transparent);
            Text12.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            Text12.Interaction = null;
            Text12.Margins = new StiMargins(0, 0, 0, 0);
            Text12.TextBrush = new StiSolidBrush(Color.Black);
            Text12.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text13
            // 
            Text13 = new StiText();
            Text13.ClientRectangle = new RectangleD(10.2, 0, 2.4, 0.6);
            Text13.Guid = "0974ed75540740f4af139745ad771e08";
            Text13.HorAlignment = StiTextHorAlignment.Center;
            Text13.Name = "Text13";
            Text13.GetValue += new StiGetValueEventHandler(Text13__GetValue);
            Text13.VertAlignment = StiVertAlignment.Center;
            Text13.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text13.Brush = new StiSolidBrush(Color.Transparent);
            Text13.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            Text13.Interaction = null;
            Text13.Margins = new StiMargins(0, 0, 0, 0);
            Text13.TextBrush = new StiSolidBrush(Color.Black);
            Text13.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text14
            // 
            Text14 = new StiText();
            Text14.ClientRectangle = new RectangleD(12.6, 0, 2.4, 0.6);
            Text14.Guid = "f11d8ef223974cbeb4dd9d4055d584bc";
            Text14.HorAlignment = StiTextHorAlignment.Center;
            Text14.Name = "Text14";
            Text14.GetValue += new StiGetValueEventHandler(Text14__GetValue);
            Text14.VertAlignment = StiVertAlignment.Center;
            Text14.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text14.Brush = new StiSolidBrush(Color.Transparent);
            Text14.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            Text14.Interaction = null;
            Text14.Margins = new StiMargins(0, 0, 0, 0);
            Text14.TextBrush = new StiSolidBrush(Color.Black);
            Text14.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text15
            // 
            Text15 = new StiText();
            Text15.ClientRectangle = new RectangleD(15, 0, 4, 0.6);
            Text15.Guid = "bbef06e2a66d48beb97e857e1eedbaec";
            Text15.HorAlignment = StiTextHorAlignment.Center;
            Text15.Name = "Text15";
            Text15.GetValue += new StiGetValueEventHandler(Text15__GetValue);
            Text15.VertAlignment = StiVertAlignment.Center;
            Text15.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text15.Brush = new StiSolidBrush(Color.Transparent);
            Text15.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            Text15.Interaction = null;
            Text15.Margins = new StiMargins(0, 0, 0, 0);
            Text15.TextBrush = new StiSolidBrush(Color.Black);
            Text15.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            HeaderBand1.Guid = null;
            HeaderBand1.Interaction = null;
            // 
            // GroupHeaderBand2
            // 
            GroupHeaderBand2 = new StiGroupHeaderBand();
            GroupHeaderBand2.ClientRectangle = new RectangleD(0, 3.4, 19, 0.6);
            GroupHeaderBand2.GetValue += new StiValueEventHandler(GroupHeaderBand2__GetValue);
            GroupHeaderBand2.Guid = "d82d03aa1689442db9088bdf4fbd6f74";
            GroupHeaderBand2.Name = "GroupHeaderBand2";
            GroupHeaderBand2.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            GroupHeaderBand2.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text2
            // 
            Text2 = new StiText();
            Text2.ClientRectangle = new RectangleD(0, 0, 5.8, 0.6);
            Text2.Guid = "b4b9c81160034475a70f8e58952c143c";
            Text2.Name = "Text2";
            Text2.GetValue += new StiGetValueEventHandler(Text2__GetValue);
            Text2.VertAlignment = StiVertAlignment.Center;
            Text2.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text2.Brush = new StiSolidBrush(Color.Transparent);
            Text2.Font = new Font("BPG Glaho Arial", 10F);
            Text2.Interaction = null;
            Text2.Margins = new StiMargins(0, 0, 0, 0);
            Text2.TextBrush = new StiSolidBrush(Color.Black);
            Text2.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text3
            // 
            Text3 = new StiText();
            Text3.ClientRectangle = new RectangleD(5.8, 0, 2, 0.6);
            Text3.Guid = "edcd73415b85450bacde997ae60d04b4";
            Text3.HorAlignment = StiTextHorAlignment.Center;
            Text3.Name = "Text3";
            Text3.GetValue += new StiGetValueEventHandler(Text3__GetValue);
            Text3.VertAlignment = StiVertAlignment.Center;
            Text3.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text3.Brush = new StiSolidBrush(Color.Transparent);
            Text3.Font = new Font("BPG Glaho Arial", 10F);
            Text3.Interaction = null;
            Text3.Margins = new StiMargins(0, 0, 0, 0);
            Text3.TextBrush = new StiSolidBrush(Color.Black);
            Text3.TextFormat = new StiDateFormatService("d", " ");
            Text3.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text4
            // 
            Text4 = new StiText();
            Text4.ClientRectangle = new RectangleD(15, 0, 4, 0.6);
            Text4.Name = "Text4";
            Text4.GetValue += new StiGetValueEventHandler(Text4__GetValue);
            Text4.VertAlignment = StiVertAlignment.Center;
            Text4.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text4.Brush = new StiSolidBrush(Color.Transparent);
            Text4.Font = new Font("BPG Glaho Arial", 10F);
            Text4.Guid = null;
            Text4.Interaction = null;
            Text4.Margins = new StiMargins(0, 0, 0, 0);
            Text4.TextBrush = new StiSolidBrush(Color.Black);
            Text4.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text5
            // 
            Text5 = new StiText();
            Text5.ClientRectangle = new RectangleD(7.8, 0, 2.4, 0.6);
            Text5.HorAlignment = StiTextHorAlignment.Right;
            Text5.Name = "Text5";
            // 
            // Text5_Sum
            // 
            Text5.GetValue += new StiGetValueEventHandler(Text5__GetValue);
            Text5.VertAlignment = StiVertAlignment.Center;
            Text5.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text5.Brush = new StiSolidBrush(Color.Transparent);
            Text5.Font = new Font("BPG Glaho Arial", 10F);
            Text5.Guid = null;
            Text5.Interaction = null;
            Text5.Margins = new StiMargins(0, 0, 0, 0);
            Text5.TextBrush = new StiSolidBrush(Color.Black);
            Text5.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, true, " ");
            Text5.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text6
            // 
            Text6 = new StiText();
            Text6.ClientRectangle = new RectangleD(10.2, 0, 2.4, 0.6);
            Text6.Guid = "1f0c8f611f96466a9776c640bd6c1ba7";
            Text6.HorAlignment = StiTextHorAlignment.Right;
            Text6.Name = "Text6";
            // 
            // Text6_Sum
            // 
            Text6.GetValue += new StiGetValueEventHandler(Text6__GetValue);
            Text6.VertAlignment = StiVertAlignment.Center;
            Text6.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text6.Brush = new StiSolidBrush(Color.Transparent);
            Text6.Font = new Font("BPG Glaho Arial", 10F);
            Text6.Interaction = null;
            Text6.Margins = new StiMargins(0, 0, 0, 0);
            Text6.TextBrush = new StiSolidBrush(Color.Black);
            Text6.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, true, " ");
            Text6.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text7
            // 
            Text7 = new StiText();
            Text7.ClientRectangle = new RectangleD(12.6, 0, 2.4, 0.6);
            Text7.Guid = "e1d414bc48834ba0ae5c02772f452d98";
            Text7.HorAlignment = StiTextHorAlignment.Right;
            Text7.Name = "Text7";
            // 
            // Text7_Sum1
            // 
            // 
            // Text7_Sum2
            // 
            Text7.GetValue += new StiGetValueEventHandler(Text7__GetValue);
            Text7.VertAlignment = StiVertAlignment.Center;
            Text7.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text7.Brush = new StiSolidBrush(Color.Transparent);
            Text7.Font = new Font("BPG Glaho Arial", 10F);
            Text7.Interaction = null;
            Text7.Margins = new StiMargins(0, 0, 0, 0);
            Text7.TextBrush = new StiSolidBrush(Color.Black);
            Text7.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, true, " ");
            Text7.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            GroupHeaderBand2.Interaction = null;
            // 
            // DataFN_GetSalesOrderHeaderPurchaseTotal
            // 
            DataFN_GetSalesOrderHeaderPurchaseTotal = new StiDataBand();
            DataFN_GetSalesOrderHeaderPurchaseTotal.CalcInvisible = true;
            DataFN_GetSalesOrderHeaderPurchaseTotal.ClientRectangle = new RectangleD(0, 4.8, 19, 0.8);
            DataFN_GetSalesOrderHeaderPurchaseTotal.DataSourceName = "FN_GetSalesOrderHeaderPurchaseTotal";
            DataFN_GetSalesOrderHeaderPurchaseTotal.Enabled = false;
            DataFN_GetSalesOrderHeaderPurchaseTotal.Name = "DataFN_GetSalesOrderHeaderPurchaseTotal";
            DataFN_GetSalesOrderHeaderPurchaseTotal.Sort = new[] {
                    "ASC",
                    "OrderDate",
                    "ASC",
                    "BranchName",
                    "ASC",
                    "PaymentMethodName"};
            DataFN_GetSalesOrderHeaderPurchaseTotal.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataFN_GetSalesOrderHeaderPurchaseTotal.Brush = new StiSolidBrush(Color.Transparent);
            DataFN_GetSalesOrderHeaderPurchaseTotal.DataRelationName = null;
            DataFN_GetSalesOrderHeaderPurchaseTotal.Guid = null;
            DataFN_GetSalesOrderHeaderPurchaseTotal.Interaction = null;
            DataFN_GetSalesOrderHeaderPurchaseTotal.MasterComponent = null;
            // 
            // FooterBand1
            // 
            FooterBand1 = new StiFooterBand();
            FooterBand1.ClientRectangle = new RectangleD(0, 6.4, 19, 0.6);
            FooterBand1.Name = "FooterBand1";
            FooterBand1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            FooterBand1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text16
            // 
            Text16 = new StiText();
            Text16.ClientRectangle = new RectangleD(7.8, 0, 2.4, 0.6);
            Text16.HorAlignment = StiTextHorAlignment.Right;
            Text16.Name = "Text16";
            // 
            // Text16_Sum
            // 
            Text16.GetValue += new StiGetValueEventHandler(Text16__GetValue);
            Text16.VertAlignment = StiVertAlignment.Center;
            Text16.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text16.Brush = new StiSolidBrush(Color.Transparent);
            Text16.Font = new Font("BPG Glaho Arial", 10F);
            Text16.Guid = null;
            Text16.Interaction = null;
            Text16.Margins = new StiMargins(0, 0, 0, 0);
            Text16.TextBrush = new StiSolidBrush(Color.Black);
            Text16.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, true, " ");
            Text16.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text17
            // 
            Text17 = new StiText();
            Text17.ClientRectangle = new RectangleD(10.2, 0, 2.4, 0.6);
            Text17.Guid = "f2dd3d749ca7442996cf2f1d37916060";
            Text17.HorAlignment = StiTextHorAlignment.Right;
            Text17.Name = "Text17";
            // 
            // Text17_Sum
            // 
            Text17.GetValue += new StiGetValueEventHandler(Text17__GetValue);
            Text17.VertAlignment = StiVertAlignment.Center;
            Text17.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text17.Brush = new StiSolidBrush(Color.Transparent);
            Text17.Font = new Font("BPG Glaho Arial", 10F);
            Text17.Interaction = null;
            Text17.Margins = new StiMargins(0, 0, 0, 0);
            Text17.TextBrush = new StiSolidBrush(Color.Black);
            Text17.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, true, " ");
            Text17.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text18
            // 
            Text18 = new StiText();
            Text18.ClientRectangle = new RectangleD(12.6, 0, 2.4, 0.6);
            Text18.Guid = "5c8ac7b53c0e4fb8a58a0269915321bf";
            Text18.HorAlignment = StiTextHorAlignment.Right;
            Text18.Name = "Text18";
            // 
            // Text18_Sum1
            // 
            // 
            // Text18_Sum2
            // 
            Text18.GetValue += new StiGetValueEventHandler(Text18__GetValue);
            Text18.VertAlignment = StiVertAlignment.Center;
            Text18.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text18.Brush = new StiSolidBrush(Color.Transparent);
            Text18.Font = new Font("BPG Glaho Arial", 10F);
            Text18.Interaction = null;
            Text18.Margins = new StiMargins(0, 0, 0, 0);
            Text18.TextBrush = new StiSolidBrush(Color.Black);
            Text18.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, true, " ");
            Text18.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            FooterBand1.Guid = null;
            FooterBand1.Interaction = null;
            Page1.ExcelSheetValue = null;
            Page1.Interaction = null;
            Page1.Margins = new StiMargins(1, 1, 1, 1);
            Page1_Watermark = new StiWatermark();
            Page1_Watermark.Font = new Font("Arial", 100F);
            Page1_Watermark.Image = null;
            Page1_Watermark.TextBrush = new StiSolidBrush(Color.FromArgb(50, 0, 0, 0));
            RptSalesOrderHeaderPurchaseTotal_PrinterSettings = new StiPrinterSettings();
            PrinterSettings = RptSalesOrderHeaderPurchaseTotal_PrinterSettings;
            Page1.Page = Page1;
            Page1.Report = this;
            Page1.Watermark = Page1_Watermark;
            ReportTitleBand1.Page = Page1;
            ReportTitleBand1.Parent = Page1;
            Text1.Page = Page1;
            Text1.Parent = ReportTitleBand1;
            HeaderBand1.Page = Page1;
            HeaderBand1.Parent = Page1;
            Text8.Page = Page1;
            Text8.Parent = HeaderBand1;
            Text9.Page = Page1;
            Text9.Parent = HeaderBand1;
            Text10.Page = Page1;
            Text10.Parent = HeaderBand1;
            Text11.Page = Page1;
            Text11.Parent = HeaderBand1;
            Text12.Page = Page1;
            Text12.Parent = HeaderBand1;
            Text13.Page = Page1;
            Text13.Parent = HeaderBand1;
            Text14.Page = Page1;
            Text14.Parent = HeaderBand1;
            Text15.Page = Page1;
            Text15.Parent = HeaderBand1;
            GroupHeaderBand2.Page = Page1;
            GroupHeaderBand2.Parent = Page1;
            Text2.Page = Page1;
            Text2.Parent = GroupHeaderBand2;
            Text3.Page = Page1;
            Text3.Parent = GroupHeaderBand2;
            Text4.Page = Page1;
            Text4.Parent = GroupHeaderBand2;
            Text5.Page = Page1;
            Text5.Parent = GroupHeaderBand2;
            Text6.Page = Page1;
            Text6.Parent = GroupHeaderBand2;
            Text7.Page = Page1;
            Text7.Parent = GroupHeaderBand2;
            DataFN_GetSalesOrderHeaderPurchaseTotal.Page = Page1;
            DataFN_GetSalesOrderHeaderPurchaseTotal.Parent = Page1;
            FooterBand1.Page = Page1;
            FooterBand1.Parent = Page1;
            Text16.Page = Page1;
            Text16.Parent = FooterBand1;
            Text17.Page = Page1;
            Text17.Parent = FooterBand1;
            Text18.Page = Page1;
            Text18.Parent = FooterBand1;
            GroupHeaderBand2.BeginRender += new EventHandler(GroupHeaderBand2__BeginRender);
            GroupHeaderBand2.EndRender += new EventHandler(GroupHeaderBand2__EndRender);
            DataFN_GetSalesOrderHeaderPurchaseTotal.BeginRender += new EventHandler(DataFN_GetSalesOrderHeaderPurchaseTotal__BeginRender);
            DataFN_GetSalesOrderHeaderPurchaseTotal.EndRender += new EventHandler(DataFN_GetSalesOrderHeaderPurchaseTotal__EndRender);
            GroupHeaderBand2.Rendering += new EventHandler(GroupHeaderBand2__Rendering);
            DataFN_GetSalesOrderHeaderPurchaseTotal.Rendering += new EventHandler(DataFN_GetSalesOrderHeaderPurchaseTotal__Rendering);
            AggregateFunctions = new object[] {
                    Text5_Sum,
                    Text6_Sum,
                    Text7_Sum1,
                    Text7_Sum2,
                    Text16_Sum,
                    Text17_Sum,
                    Text18_Sum1,
                    Text18_Sum2};
            // 
            // Add to ReportTitleBand1.Components
            // 
            ReportTitleBand1.Components.Clear();
            ReportTitleBand1.Components.AddRange(new StiComponent[] {
                        Text1});
            // 
            // Add to HeaderBand1.Components
            // 
            HeaderBand1.Components.Clear();
            HeaderBand1.Components.AddRange(new StiComponent[] {
                        Text8,
                        Text9,
                        Text10,
                        Text11,
                        Text12,
                        Text13,
                        Text14,
                        Text15});
            // 
            // Add to GroupHeaderBand2.Components
            // 
            GroupHeaderBand2.Components.Clear();
            GroupHeaderBand2.Components.AddRange(new StiComponent[] {
                        Text2,
                        Text3,
                        Text4,
                        Text5,
                        Text6,
                        Text7});
            // 
            // Add to FooterBand1.Components
            // 
            FooterBand1.Components.Clear();
            FooterBand1.Components.AddRange(new StiComponent[] {
                        Text16,
                        Text17,
                        Text18});
            // 
            // Add to Page1.Components
            // 
            Page1.Components.Clear();
            Page1.Components.AddRange(new StiComponent[] {
                        ReportTitleBand1,
                        HeaderBand1,
                        GroupHeaderBand2,
                        DataFN_GetSalesOrderHeaderPurchaseTotal,
                        FooterBand1});
            // 
            // Add to Pages
            // 
            Pages.Clear();
            Pages.AddRange(new[] {
                        Page1});
            FN_GetSalesOrderHeaderPurchaseTotal.Columns.AddRange(new[] {
                        new StiDataColumn("SalesOrderID", "SalesOrderID", "SalesOrderID", typeof(int)),
                        new StiDataColumn("BranchID", "BranchID", "BranchID", typeof(int)),
                        new StiDataColumn("BranchName", "BranchName", "BranchName", typeof(string)),
                        new StiDataColumn("OrderDate", "OrderDate", "OrderDate", typeof(DateTime)),
                        new StiDataColumn("SalesSubTotal", "SalesSubTotal", "SalesSubTotal", typeof(decimal)),
                        new StiDataColumn("SalesTaxAmt", "SalesTaxAmt", "SalesTaxAmt", typeof(decimal)),
                        new StiDataColumn("SalesFreight", "SalesFreight", "SalesFreight", typeof(decimal)),
                        new StiDataColumn("SalesTotalDue", "SalesTotalDue", "SalesTotalDue", typeof(decimal)),
                        new StiDataColumn("PurchaseSubTotal", "PurchaseSubTotal", "PurchaseSubTotal", typeof(decimal)),
                        new StiDataColumn("PurchaseTaxAmt", "PurchaseTaxAmt", "PurchaseTaxAmt", typeof(decimal)),
                        new StiDataColumn("CurrencyCode", "CurrencyCode", "CurrencyCode", typeof(string)),
                        new StiDataColumn("PaymentMethodName", "PaymentMethodName", "PaymentMethodName", typeof(string)),
                        new StiDataColumn("Status", "Status", "Status", typeof(byte))});
            DataSources.Add(FN_GetSalesOrderHeaderPurchaseTotal);
        }

        #region DataSource FN_GetSalesOrderHeaderPurchaseTotal
        public class FN_GetSalesOrderHeaderPurchaseTotalDataSource : StiDataTableSource
        {

            public FN_GetSalesOrderHeaderPurchaseTotalDataSource() :
                base("DS_SalesOrderHeaderPurchaseTotal.FN_GetSalesOrderHeaderPurchaseTotal", "FN_GetSalesOrderHeaderPurchaseTotal")
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

            public virtual decimal SalesSubTotal
            {
                get
                {
                    return ((decimal)(ChangeType(this["SalesSubTotal"], typeof(decimal), true)));
                }
            }

            public virtual decimal SalesTaxAmt
            {
                get
                {
                    return ((decimal)(ChangeType(this["SalesTaxAmt"], typeof(decimal), true)));
                }
            }

            public virtual decimal SalesFreight
            {
                get
                {
                    return ((decimal)(ChangeType(this["SalesFreight"], typeof(decimal), true)));
                }
            }

            public virtual decimal SalesTotalDue
            {
                get
                {
                    return ((decimal)(ChangeType(this["SalesTotalDue"], typeof(decimal), true)));
                }
            }

            public virtual decimal PurchaseSubTotal
            {
                get
                {
                    return ((decimal)(ChangeType(this["PurchaseSubTotal"], typeof(decimal), true)));
                }
            }

            public virtual decimal PurchaseTaxAmt
            {
                get
                {
                    return ((decimal)(ChangeType(this["PurchaseTaxAmt"], typeof(decimal), true)));
                }
            }

            public virtual string CurrencyCode
            {
                get
                {
                    return ((string)(ChangeType(this["CurrencyCode"], typeof(string), true)));
                }
            }

            public virtual string PaymentMethodName
            {
                get
                {
                    return ((string)(ChangeType(this["PaymentMethodName"], typeof(string), true)));
                }
            }

            public virtual byte Status
            {
                get
                {
                    return ((byte)(ChangeType(this["Status"], typeof(byte), true)));
                }
            }
        }
        #endregion DataSource FN_GetSalesOrderHeaderPurchaseTotal
        #endregion StiReport Designer generated code - do not modify
    }
}
