using System;
using System.Drawing;
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

    public class RptSalesOrderHeaderGroupByDate : StiReport
    {

        public RptSalesOrderHeaderGroupByDate()
        {
            InitializeComponent();
        }
        #region StiReport Designer generated code - do not modify
        public StiPage Page1;
        public StiReportTitleBand ReportTitleBand1;
        public StiText Text1;
        public StiHeaderBand HeaderFN_GetSalesOrderHeaderGroupByDate;
        public StiText Text2;
        public StiText Text4;
        public StiText Text7;
        public StiText Text8;
        public StiText Text10;
        public StiText Text12;
        public StiText Text14;
        public StiText Text15;
        public StiText Text19;
        public StiDataBand DataFN_GetSalesOrderHeaderGroupByDate;
        public StiText Text3;
        public StiText Text5;
        public StiText Text6;
        public StiText Text9;
        public StiText Text11;
        public StiText Text13;
        public StiText Text16;
        public StiText Text17;
        public StiText Text18;
        public StiFooterBand FooterFN_GetSalesOrderHeaderGroupByDate;
        public StiText Text20;
        public StiSumDecimalFunctionService Text20_Sum;
        public StiText Text21;
        public StiSumDecimalFunctionService Text21_Sum;
        public StiText Text22;
        public StiSumDecimalFunctionService Text22_Sum;
        public StiText Text23;
        public StiSumDecimalFunctionService Text23_Sum;
        public StiText Text24;
        public StiSumDecimalFunctionService Text24_Sum;
        public StiText Text25;
        public StiSumDecimalFunctionService Text25_Sum;
        public StiWatermark Page1_Watermark;
        public StiPrinterSettings RptSalesOrderHeaderGroupByDate_PrinterSettings;
        public FN_GetSalesOrderHeaderGroupByDateDataSource FN_GetSalesOrderHeaderGroupByDate;

        public void Text1__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "დღიური რეესტრი";
        }

        public void Text2__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ფილიალი";
        }

        public void Text4__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "თარიღი";
        }

        public void Text7__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ქვე ჯამი / გ.";
        }

        public void Text8__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "დ.ღ.გ. / გ.";
        }

        public void Text10__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ტრანსპ. /გ.";
        }

        public void Text12__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "სულ ჯამი /გ.";
        }

        public void Text14__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ქვე ჯამი / შ.";
        }

        public void Text15__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "დ.ღ.გ. / შ.";
        }

        public void Text19__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ვალუტა";
        }

        public void Text3__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, FN_GetSalesOrderHeaderGroupByDate.BranchName, true);
        }

        public void Text5__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text5.TextFormat.Format(CheckExcelValue(sender, FN_GetSalesOrderHeaderGroupByDate.OrderDate));
        }

        public void Text6__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text6.TextFormat.Format(CheckExcelValue(sender, FN_GetSalesOrderHeaderGroupByDate.SalesSubTotal));
        }

        public void Text9__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text9.TextFormat.Format(CheckExcelValue(sender, FN_GetSalesOrderHeaderGroupByDate.SalesTaxAmt));
        }

        public void Text11__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text11.TextFormat.Format(CheckExcelValue(sender, FN_GetSalesOrderHeaderGroupByDate.SalesFreight));
        }

        public void Text13__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text13.TextFormat.Format(CheckExcelValue(sender, FN_GetSalesOrderHeaderGroupByDate.SalesTotalDue));
        }

        public void Text16__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text16.TextFormat.Format(CheckExcelValue(sender, FN_GetSalesOrderHeaderGroupByDate.PurchaseSubTotal));
        }

        public void Text17__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text17.TextFormat.Format(CheckExcelValue(sender, FN_GetSalesOrderHeaderGroupByDate.PurchaseTaxAmt));
        }

        public void Text18__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, FN_GetSalesOrderHeaderGroupByDate.CurrencyCode, true);
        }

        public void Text20__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(FN_GetSalesOrderHeaderGroupByDate.SalesSubTotal)}";
            e.StoreToPrinted = true;
        }

        public String Text20_GetValue_End(StiComponent sender)
        {
            return Text20.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text20_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void Text21__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(FN_GetSalesOrderHeaderGroupByDate.SalesTaxAmt)}";
            e.StoreToPrinted = true;
        }

        public String Text21_GetValue_End(StiComponent sender)
        {
            return Text21.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text21_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void Text22__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(FN_GetSalesOrderHeaderGroupByDate.SalesFreight)}";
            e.StoreToPrinted = true;
        }

        public String Text22_GetValue_End(StiComponent sender)
        {
            return Text22.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text22_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void Text23__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(FN_GetSalesOrderHeaderGroupByDate.SalesTotalDue)}";
            e.StoreToPrinted = true;
        }

        public String Text23_GetValue_End(StiComponent sender)
        {
            return Text23.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text23_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void Text24__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(FN_GetSalesOrderHeaderGroupByDate.PurchaseSubTotal)}";
            e.StoreToPrinted = true;
        }

        public String Text24_GetValue_End(StiComponent sender)
        {
            return Text24.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text24_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void Text25__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(FN_GetSalesOrderHeaderGroupByDate.PurchaseTaxAmt)}";
            e.StoreToPrinted = true;
        }

        public String Text25_GetValue_End(StiComponent sender)
        {
            return Text25.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text25_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void DataFN_GetSalesOrderHeaderGroupByDate__BeginRender(object sender, EventArgs e)
        {
            Text20_Sum.Init();
            Text20.TextValue = "";
            Text21_Sum.Init();
            Text21.TextValue = "";
            Text22_Sum.Init();
            Text22.TextValue = "";
            Text23_Sum.Init();
            Text23.TextValue = "";
            Text24_Sum.Init();
            Text24.TextValue = "";
            Text25_Sum.Init();
            Text25.TextValue = "";
        }

        public void DataFN_GetSalesOrderHeaderGroupByDate__EndRender(object sender, EventArgs e)
        {
            Text20.SetText(new StiGetValue(Text20_GetValue_End));
            Text21.SetText(new StiGetValue(Text21_GetValue_End));
            Text22.SetText(new StiGetValue(Text22_GetValue_End));
            Text23.SetText(new StiGetValue(Text23_GetValue_End));
            Text24.SetText(new StiGetValue(Text24_GetValue_End));
            Text25.SetText(new StiGetValue(Text25_GetValue_End));
        }

        public void DataFN_GetSalesOrderHeaderGroupByDate__Rendering(object sender, EventArgs e)
        {
            Text20_Sum.CalcItem(FN_GetSalesOrderHeaderGroupByDate.SalesSubTotal);
            Text21_Sum.CalcItem(FN_GetSalesOrderHeaderGroupByDate.SalesTaxAmt);
            Text22_Sum.CalcItem(FN_GetSalesOrderHeaderGroupByDate.SalesFreight);
            Text23_Sum.CalcItem(FN_GetSalesOrderHeaderGroupByDate.SalesTotalDue);
            Text24_Sum.CalcItem(FN_GetSalesOrderHeaderGroupByDate.PurchaseSubTotal);
            Text25_Sum.CalcItem(FN_GetSalesOrderHeaderGroupByDate.PurchaseTaxAmt);
        }

        private void InitializeComponent()
        {
            FN_GetSalesOrderHeaderGroupByDate = new FN_GetSalesOrderHeaderGroupByDateDataSource();
            NeedsCompiling = false;
            Text25_Sum = new StiSumDecimalFunctionService();
            Text24_Sum = new StiSumDecimalFunctionService();
            Text23_Sum = new StiSumDecimalFunctionService();
            Text22_Sum = new StiSumDecimalFunctionService();
            Text21_Sum = new StiSumDecimalFunctionService();
            Text20_Sum = new StiSumDecimalFunctionService();
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
            ReportAlias = "RptSalesOrderHeaderGroupByDate";
            ReportAuthor = "Programmer.GE";
            // 
            // ReportChanged
            // 
            ReportChanged = new DateTime(2010, 3, 14, 14, 55, 38, 468);
            // 
            // ReportCreated
            // 
            ReportCreated = new DateTime(2010, 3, 14, 12, 18, 15, 0);
            ReportDescription = "დღიური რეესტრი";
            ReportFile = "D:\\My Documents\\Projects\\Apothex\\Source\\Class Library\\Apothex.Reporting\\Purchasin" +
"g\\RptSalesOrderHeaderGroupByDate.mrt";
            ReportGuid = "fb755cf0d295459789fad064b3ad43c8";
            ReportName = "RptSalesOrderHeaderGroupByDate";
            ReportUnit = StiReportUnitType.Centimeters;
            ScriptLanguage = StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            Page1 = new StiPage();
            Page1.Guid = "15f8be9e3f0c4ed7840775b8f67f53aa";
            Page1.Name = "Page1";
            Page1.PageHeight = 29.7;
            Page1.PageWidth = 21;
            Page1.Border = new StiBorder(StiBorderSides.None, Color.Black, 2, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Page1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // ReportTitleBand1
            // 
            ReportTitleBand1 = new StiReportTitleBand();
            ReportTitleBand1.ClientRectangle = new RectangleD(0, 0.4, 19, 0.6);
            ReportTitleBand1.Name = "ReportTitleBand1";
            ReportTitleBand1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            ReportTitleBand1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text1
            // 
            Text1 = new StiText();
            Text1.ClientRectangle = new RectangleD(0, 0, 19, 0.6);
            Text1.HorAlignment = StiTextHorAlignment.Center;
            Text1.Name = "Text1";
            Text1.GetValue += new StiGetValueEventHandler(Text1__GetValue);
            Text1.VertAlignment = StiVertAlignment.Center;
            Text1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text1.Brush = new StiSolidBrush(Color.Transparent);
            Text1.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            Text1.Guid = null;
            Text1.Interaction = null;
            Text1.Margins = new StiMargins(0, 0, 0, 0);
            Text1.TextBrush = new StiSolidBrush(Color.Black);
            Text1.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            ReportTitleBand1.Guid = null;
            ReportTitleBand1.Interaction = null;
            // 
            // HeaderFN_GetSalesOrderHeaderGroupByDate
            // 
            HeaderFN_GetSalesOrderHeaderGroupByDate = new StiHeaderBand();
            HeaderFN_GetSalesOrderHeaderGroupByDate.ClientRectangle = new RectangleD(0, 1.8, 19, 0.6);
            HeaderFN_GetSalesOrderHeaderGroupByDate.Name = "HeaderFN_GetSalesOrderHeaderGroupByDate";
            HeaderFN_GetSalesOrderHeaderGroupByDate.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderFN_GetSalesOrderHeaderGroupByDate.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text2
            // 
            Text2 = new StiText();
            Text2.ClientRectangle = new RectangleD(0, 0, 3.8, 0.6);
            Text2.HorAlignment = StiTextHorAlignment.Center;
            Text2.Name = "Text2";
            Text2.GetValue += new StiGetValueEventHandler(Text2__GetValue);
            Text2.VertAlignment = StiVertAlignment.Center;
            Text2.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text2.Brush = new StiSolidBrush(Color.Transparent);
            Text2.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            Text2.Guid = null;
            Text2.Interaction = null;
            Text2.Margins = new StiMargins(0, 0, 0, 0);
            Text2.TextBrush = new StiSolidBrush(Color.Black);
            Text2.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text4
            // 
            Text4 = new StiText();
            Text4.ClientRectangle = new RectangleD(3.8, 0, 1.8, 0.6);
            Text4.Guid = "467c29c5b8ac4d7699113aaca75bbfa0";
            Text4.HorAlignment = StiTextHorAlignment.Center;
            Text4.Name = "Text4";
            Text4.GetValue += new StiGetValueEventHandler(Text4__GetValue);
            Text4.VertAlignment = StiVertAlignment.Center;
            Text4.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text4.Brush = new StiSolidBrush(Color.Transparent);
            Text4.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            Text4.Interaction = null;
            Text4.Margins = new StiMargins(0, 0, 0, 0);
            Text4.TextBrush = new StiSolidBrush(Color.Black);
            Text4.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text7
            // 
            Text7 = new StiText();
            Text7.ClientRectangle = new RectangleD(5.6, 0, 2, 0.6);
            Text7.HorAlignment = StiTextHorAlignment.Center;
            Text7.Name = "Text7";
            Text7.GetValue += new StiGetValueEventHandler(Text7__GetValue);
            Text7.VertAlignment = StiVertAlignment.Center;
            Text7.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text7.Brush = new StiSolidBrush(Color.Transparent);
            Text7.Font = new Font("BPG Glaho Arial", 9F, FontStyle.Bold);
            Text7.Guid = null;
            Text7.Interaction = null;
            Text7.Margins = new StiMargins(0, 0, 0, 0);
            Text7.TextBrush = new StiSolidBrush(Color.Black);
            Text7.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text8
            // 
            Text8 = new StiText();
            Text8.ClientRectangle = new RectangleD(7.6, 0, 2, 0.6);
            Text8.Guid = "eb94c8b3119c45a29867fb034540470c";
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
            Text8.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text10
            // 
            Text10 = new StiText();
            Text10.ClientRectangle = new RectangleD(9.6, 0, 2, 0.6);
            Text10.Guid = "1e109445ebd84314bc07f59667ea1465";
            Text10.HorAlignment = StiTextHorAlignment.Center;
            Text10.Name = "Text10";
            Text10.GetValue += new StiGetValueEventHandler(Text10__GetValue);
            Text10.VertAlignment = StiVertAlignment.Center;
            Text10.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text10.Brush = new StiSolidBrush(Color.Transparent);
            Text10.Font = new Font("BPG Glaho Arial", 9F, FontStyle.Bold);
            Text10.Interaction = null;
            Text10.Margins = new StiMargins(0, 0, 0, 0);
            Text10.TextBrush = new StiSolidBrush(Color.Black);
            Text10.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text12
            // 
            Text12 = new StiText();
            Text12.ClientRectangle = new RectangleD(11.6, 0, 2, 0.6);
            Text12.Guid = "2237f0cc3fa4487da36d59e063d64dcc";
            Text12.HorAlignment = StiTextHorAlignment.Center;
            Text12.Name = "Text12";
            Text12.GetValue += new StiGetValueEventHandler(Text12__GetValue);
            Text12.VertAlignment = StiVertAlignment.Center;
            Text12.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text12.Brush = new StiSolidBrush(Color.Transparent);
            Text12.Font = new Font("BPG Glaho Arial", 9F, FontStyle.Bold);
            Text12.Interaction = null;
            Text12.Margins = new StiMargins(0, 0, 0, 0);
            Text12.TextBrush = new StiSolidBrush(Color.Black);
            Text12.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text14
            // 
            Text14 = new StiText();
            Text14.ClientRectangle = new RectangleD(13.6, 0, 2, 0.6);
            Text14.Guid = "b721060c70fe418786c7fb52e63d1263";
            Text14.HorAlignment = StiTextHorAlignment.Center;
            Text14.Name = "Text14";
            Text14.GetValue += new StiGetValueEventHandler(Text14__GetValue);
            Text14.VertAlignment = StiVertAlignment.Center;
            Text14.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text14.Brush = new StiSolidBrush(Color.Transparent);
            Text14.Font = new Font("BPG Glaho Arial", 9F, FontStyle.Bold);
            Text14.Interaction = null;
            Text14.Margins = new StiMargins(0, 0, 0, 0);
            Text14.TextBrush = new StiSolidBrush(Color.Black);
            Text14.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text15
            // 
            Text15 = new StiText();
            Text15.ClientRectangle = new RectangleD(15.6, 0, 2, 0.6);
            Text15.Guid = "671c027a6242406991e840265262e491";
            Text15.HorAlignment = StiTextHorAlignment.Center;
            Text15.Name = "Text15";
            Text15.GetValue += new StiGetValueEventHandler(Text15__GetValue);
            Text15.VertAlignment = StiVertAlignment.Center;
            Text15.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text15.Brush = new StiSolidBrush(Color.Transparent);
            Text15.Font = new Font("BPG Glaho Arial", 9F, FontStyle.Bold);
            Text15.Interaction = null;
            Text15.Margins = new StiMargins(0, 0, 0, 0);
            Text15.TextBrush = new StiSolidBrush(Color.Black);
            Text15.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text19
            // 
            Text19 = new StiText();
            Text19.ClientRectangle = new RectangleD(17.6, 0, 1.4, 0.6);
            Text19.HorAlignment = StiTextHorAlignment.Center;
            Text19.Name = "Text19";
            Text19.GetValue += new StiGetValueEventHandler(Text19__GetValue);
            Text19.VertAlignment = StiVertAlignment.Center;
            Text19.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text19.Brush = new StiSolidBrush(Color.Transparent);
            Text19.Font = new Font("BPG Glaho Arial", 9F, FontStyle.Bold);
            Text19.Guid = null;
            Text19.Interaction = null;
            Text19.Margins = new StiMargins(0, 0, 0, 0);
            Text19.TextBrush = new StiSolidBrush(Color.Black);
            Text19.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            HeaderFN_GetSalesOrderHeaderGroupByDate.Guid = null;
            HeaderFN_GetSalesOrderHeaderGroupByDate.Interaction = null;
            // 
            // DataFN_GetSalesOrderHeaderGroupByDate
            // 
            DataFN_GetSalesOrderHeaderGroupByDate = new StiDataBand();
            DataFN_GetSalesOrderHeaderGroupByDate.ClientRectangle = new RectangleD(0, 3.2, 19, 0.6);
            DataFN_GetSalesOrderHeaderGroupByDate.DataSourceName = "FN_GetSalesOrderHeaderGroupByDate";
            DataFN_GetSalesOrderHeaderGroupByDate.Name = "DataFN_GetSalesOrderHeaderGroupByDate";
            DataFN_GetSalesOrderHeaderGroupByDate.Sort = new String[0];
            DataFN_GetSalesOrderHeaderGroupByDate.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataFN_GetSalesOrderHeaderGroupByDate.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text3
            // 
            Text3 = new StiText();
            Text3.ClientRectangle = new RectangleD(0, 0, 3.8, 0.6);
            Text3.Name = "Text3";
            Text3.GetValue += new StiGetValueEventHandler(Text3__GetValue);
            Text3.VertAlignment = StiVertAlignment.Center;
            Text3.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text3.Brush = new StiSolidBrush(Color.Transparent);
            Text3.Font = new Font("BPG Glaho Arial", 9F);
            Text3.Guid = null;
            Text3.Interaction = null;
            Text3.Margins = new StiMargins(0, 0, 0, 0);
            Text3.TextBrush = new StiSolidBrush(Color.Black);
            Text3.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text5
            // 
            Text5 = new StiText();
            Text5.ClientRectangle = new RectangleD(3.8, 0, 1.8, 0.6);
            Text5.Guid = "130fdd5ccfa8471eb49edd760d447511";
            Text5.Name = "Text5";
            Text5.GetValue += new StiGetValueEventHandler(Text5__GetValue);
            Text5.VertAlignment = StiVertAlignment.Center;
            Text5.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text5.Brush = new StiSolidBrush(Color.Transparent);
            Text5.Font = new Font("BPG Glaho Arial", 9F);
            Text5.Interaction = null;
            Text5.Margins = new StiMargins(0, 0, 0, 0);
            Text5.TextBrush = new StiSolidBrush(Color.Black);
            Text5.TextFormat = new StiDateFormatService("d", " ");
            Text5.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text6
            // 
            Text6 = new StiText();
            Text6.ClientRectangle = new RectangleD(5.6, 0, 2, 0.6);
            Text6.HorAlignment = StiTextHorAlignment.Right;
            Text6.Name = "Text6";
            Text6.GetValue += new StiGetValueEventHandler(Text6__GetValue);
            Text6.VertAlignment = StiVertAlignment.Center;
            Text6.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text6.Brush = new StiSolidBrush(Color.Transparent);
            Text6.Font = new Font("BPG Glaho Arial", 9F);
            Text6.Guid = null;
            Text6.Interaction = null;
            Text6.Margins = new StiMargins(0, 0, 0, 0);
            Text6.TextBrush = new StiSolidBrush(Color.Black);
            Text6.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, true, " ");
            Text6.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text9
            // 
            Text9 = new StiText();
            Text9.ClientRectangle = new RectangleD(7.6, 0, 2, 0.6);
            Text9.Guid = "b92a308ac1aa4ef8bd804d260bc2948e";
            Text9.HorAlignment = StiTextHorAlignment.Right;
            Text9.Name = "Text9";
            Text9.GetValue += new StiGetValueEventHandler(Text9__GetValue);
            Text9.VertAlignment = StiVertAlignment.Center;
            Text9.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text9.Brush = new StiSolidBrush(Color.Transparent);
            Text9.Font = new Font("BPG Glaho Arial", 9F);
            Text9.Interaction = null;
            Text9.Margins = new StiMargins(0, 0, 0, 0);
            Text9.TextBrush = new StiSolidBrush(Color.Black);
            Text9.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, true, " ");
            Text9.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text11
            // 
            Text11 = new StiText();
            Text11.ClientRectangle = new RectangleD(9.6, 0, 2, 0.6);
            Text11.Guid = "d62684872f6444d3812bf7faebf9e988";
            Text11.HorAlignment = StiTextHorAlignment.Right;
            Text11.Name = "Text11";
            Text11.GetValue += new StiGetValueEventHandler(Text11__GetValue);
            Text11.VertAlignment = StiVertAlignment.Center;
            Text11.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text11.Brush = new StiSolidBrush(Color.Transparent);
            Text11.Font = new Font("BPG Glaho Arial", 9F);
            Text11.Interaction = null;
            Text11.Margins = new StiMargins(0, 0, 0, 0);
            Text11.TextBrush = new StiSolidBrush(Color.Black);
            Text11.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, true, " ");
            Text11.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text13
            // 
            Text13 = new StiText();
            Text13.ClientRectangle = new RectangleD(11.6, 0, 2, 0.6);
            Text13.Guid = "6be8b486efe746809e6f80bcdfb4a434";
            Text13.HorAlignment = StiTextHorAlignment.Right;
            Text13.Name = "Text13";
            Text13.GetValue += new StiGetValueEventHandler(Text13__GetValue);
            Text13.VertAlignment = StiVertAlignment.Center;
            Text13.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text13.Brush = new StiSolidBrush(Color.Transparent);
            Text13.Font = new Font("BPG Glaho Arial", 9F);
            Text13.Interaction = null;
            Text13.Margins = new StiMargins(0, 0, 0, 0);
            Text13.TextBrush = new StiSolidBrush(Color.Black);
            Text13.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, true, " ");
            Text13.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text16
            // 
            Text16 = new StiText();
            Text16.ClientRectangle = new RectangleD(13.6, 0, 2, 0.6);
            Text16.Guid = "7bd48fc60f1c40e58b1e065163638fce";
            Text16.HorAlignment = StiTextHorAlignment.Right;
            Text16.Name = "Text16";
            Text16.GetValue += new StiGetValueEventHandler(Text16__GetValue);
            Text16.VertAlignment = StiVertAlignment.Center;
            Text16.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text16.Brush = new StiSolidBrush(Color.Transparent);
            Text16.Font = new Font("BPG Glaho Arial", 9F);
            Text16.Interaction = null;
            Text16.Margins = new StiMargins(0, 0, 0, 0);
            Text16.TextBrush = new StiSolidBrush(Color.Black);
            Text16.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, true, " ");
            Text16.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text17
            // 
            Text17 = new StiText();
            Text17.ClientRectangle = new RectangleD(15.6, 0, 2, 0.6);
            Text17.Guid = "fa2be89ab3ce40f7880496a2c032b1ce";
            Text17.HorAlignment = StiTextHorAlignment.Right;
            Text17.Name = "Text17";
            Text17.GetValue += new StiGetValueEventHandler(Text17__GetValue);
            Text17.VertAlignment = StiVertAlignment.Center;
            Text17.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text17.Brush = new StiSolidBrush(Color.Transparent);
            Text17.Font = new Font("BPG Glaho Arial", 9F);
            Text17.Interaction = null;
            Text17.Margins = new StiMargins(0, 0, 0, 0);
            Text17.TextBrush = new StiSolidBrush(Color.Black);
            Text17.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, true, " ");
            Text17.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text18
            // 
            Text18 = new StiText();
            Text18.ClientRectangle = new RectangleD(17.6, 0, 1.4, 0.6);
            Text18.Name = "Text18";
            Text18.GetValue += new StiGetValueEventHandler(Text18__GetValue);
            Text18.VertAlignment = StiVertAlignment.Center;
            Text18.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text18.Brush = new StiSolidBrush(Color.Transparent);
            Text18.Font = new Font("BPG Glaho Arial", 9F);
            Text18.Guid = null;
            Text18.Interaction = null;
            Text18.Margins = new StiMargins(0, 0, 0, 0);
            Text18.TextBrush = new StiSolidBrush(Color.Black);
            Text18.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            DataFN_GetSalesOrderHeaderGroupByDate.Guid = null;
            DataFN_GetSalesOrderHeaderGroupByDate.Interaction = null;
            DataFN_GetSalesOrderHeaderGroupByDate.MasterComponent = null;
            // 
            // FooterFN_GetSalesOrderHeaderGroupByDate
            // 
            FooterFN_GetSalesOrderHeaderGroupByDate = new StiFooterBand();
            FooterFN_GetSalesOrderHeaderGroupByDate.ClientRectangle = new RectangleD(0, 4.6, 19, 0.6);
            FooterFN_GetSalesOrderHeaderGroupByDate.Name = "FooterFN_GetSalesOrderHeaderGroupByDate";
            FooterFN_GetSalesOrderHeaderGroupByDate.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            FooterFN_GetSalesOrderHeaderGroupByDate.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text20
            // 
            Text20 = new StiText();
            Text20.ClientRectangle = new RectangleD(5.6, 0, 2, 0.6);
            Text20.Guid = "71e70f488d9147e397d8ed909bc2aaff";
            Text20.HorAlignment = StiTextHorAlignment.Right;
            Text20.Name = "Text20";
            // 
            // Text20_Sum
            // 
            Text20.GetValue += new StiGetValueEventHandler(Text20__GetValue);
            Text20.VertAlignment = StiVertAlignment.Center;
            Text20.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text20.Brush = new StiSolidBrush(Color.Transparent);
            Text20.Font = new Font("BPG Glaho Arial", 9F);
            Text20.Interaction = null;
            Text20.Margins = new StiMargins(0, 0, 0, 0);
            Text20.TextBrush = new StiSolidBrush(Color.Black);
            Text20.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, true, " ");
            Text20.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text21
            // 
            Text21 = new StiText();
            Text21.ClientRectangle = new RectangleD(7.6, 0, 2, 0.6);
            Text21.Guid = "7a5ed6b81a9b4b1da590a71cb1ef66af";
            Text21.HorAlignment = StiTextHorAlignment.Right;
            Text21.Name = "Text21";
            // 
            // Text21_Sum
            // 
            Text21.GetValue += new StiGetValueEventHandler(Text21__GetValue);
            Text21.VertAlignment = StiVertAlignment.Center;
            Text21.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text21.Brush = new StiSolidBrush(Color.Transparent);
            Text21.Font = new Font("BPG Glaho Arial", 9F);
            Text21.Interaction = null;
            Text21.Margins = new StiMargins(0, 0, 0, 0);
            Text21.TextBrush = new StiSolidBrush(Color.Black);
            Text21.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, true, " ");
            Text21.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text22
            // 
            Text22 = new StiText();
            Text22.ClientRectangle = new RectangleD(9.6, 0, 2, 0.6);
            Text22.Guid = "c328d8f5c2774d1d9164e6cf5e28789a";
            Text22.HorAlignment = StiTextHorAlignment.Right;
            Text22.Name = "Text22";
            // 
            // Text22_Sum
            // 
            Text22.GetValue += new StiGetValueEventHandler(Text22__GetValue);
            Text22.VertAlignment = StiVertAlignment.Center;
            Text22.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text22.Brush = new StiSolidBrush(Color.Transparent);
            Text22.Font = new Font("BPG Glaho Arial", 9F);
            Text22.Interaction = null;
            Text22.Margins = new StiMargins(0, 0, 0, 0);
            Text22.TextBrush = new StiSolidBrush(Color.Black);
            Text22.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, true, " ");
            Text22.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text23
            // 
            Text23 = new StiText();
            Text23.ClientRectangle = new RectangleD(11.6, 0, 2, 0.6);
            Text23.Guid = "cadb2e1b066a4c33bc7cfe6b16abf993";
            Text23.HorAlignment = StiTextHorAlignment.Right;
            Text23.Name = "Text23";
            // 
            // Text23_Sum
            // 
            Text23.GetValue += new StiGetValueEventHandler(Text23__GetValue);
            Text23.VertAlignment = StiVertAlignment.Center;
            Text23.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text23.Brush = new StiSolidBrush(Color.Transparent);
            Text23.Font = new Font("BPG Glaho Arial", 9F);
            Text23.Interaction = null;
            Text23.Margins = new StiMargins(0, 0, 0, 0);
            Text23.TextBrush = new StiSolidBrush(Color.Black);
            Text23.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, true, " ");
            Text23.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text24
            // 
            Text24 = new StiText();
            Text24.ClientRectangle = new RectangleD(13.6, 0, 2, 0.6);
            Text24.Guid = "80b0db86098f48dc95958d252345b72f";
            Text24.HorAlignment = StiTextHorAlignment.Right;
            Text24.Name = "Text24";
            // 
            // Text24_Sum
            // 
            Text24.GetValue += new StiGetValueEventHandler(Text24__GetValue);
            Text24.VertAlignment = StiVertAlignment.Center;
            Text24.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text24.Brush = new StiSolidBrush(Color.Transparent);
            Text24.Font = new Font("BPG Glaho Arial", 9F);
            Text24.Interaction = null;
            Text24.Margins = new StiMargins(0, 0, 0, 0);
            Text24.TextBrush = new StiSolidBrush(Color.Black);
            Text24.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, true, " ");
            Text24.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text25
            // 
            Text25 = new StiText();
            Text25.ClientRectangle = new RectangleD(15.6, 0, 2, 0.6);
            Text25.Guid = "05348347d2a34761b9cb0e283d450352";
            Text25.HorAlignment = StiTextHorAlignment.Right;
            Text25.Name = "Text25";
            // 
            // Text25_Sum
            // 
            Text25.GetValue += new StiGetValueEventHandler(Text25__GetValue);
            Text25.VertAlignment = StiVertAlignment.Center;
            Text25.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text25.Brush = new StiSolidBrush(Color.Transparent);
            Text25.Font = new Font("BPG Glaho Arial", 9F);
            Text25.Interaction = null;
            Text25.Margins = new StiMargins(0, 0, 0, 0);
            Text25.TextBrush = new StiSolidBrush(Color.Black);
            Text25.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, true, " ");
            Text25.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            FooterFN_GetSalesOrderHeaderGroupByDate.Guid = null;
            FooterFN_GetSalesOrderHeaderGroupByDate.Interaction = null;
            Page1.ExcelSheetValue = null;
            Page1.Interaction = null;
            Page1.Margins = new StiMargins(1, 1, 1, 1);
            Page1_Watermark = new StiWatermark();
            Page1_Watermark.Font = new Font("Arial", 100F);
            Page1_Watermark.Image = null;
            Page1_Watermark.TextBrush = new StiSolidBrush(Color.FromArgb(50, 0, 0, 0));
            RptSalesOrderHeaderGroupByDate_PrinterSettings = new StiPrinterSettings();
            PrinterSettings = RptSalesOrderHeaderGroupByDate_PrinterSettings;
            Page1.Page = Page1;
            Page1.Report = this;
            Page1.Watermark = Page1_Watermark;
            ReportTitleBand1.Page = Page1;
            ReportTitleBand1.Parent = Page1;
            Text1.Page = Page1;
            Text1.Parent = ReportTitleBand1;
            HeaderFN_GetSalesOrderHeaderGroupByDate.Page = Page1;
            HeaderFN_GetSalesOrderHeaderGroupByDate.Parent = Page1;
            Text2.Page = Page1;
            Text2.Parent = HeaderFN_GetSalesOrderHeaderGroupByDate;
            Text4.Page = Page1;
            Text4.Parent = HeaderFN_GetSalesOrderHeaderGroupByDate;
            Text7.Page = Page1;
            Text7.Parent = HeaderFN_GetSalesOrderHeaderGroupByDate;
            Text8.Page = Page1;
            Text8.Parent = HeaderFN_GetSalesOrderHeaderGroupByDate;
            Text10.Page = Page1;
            Text10.Parent = HeaderFN_GetSalesOrderHeaderGroupByDate;
            Text12.Page = Page1;
            Text12.Parent = HeaderFN_GetSalesOrderHeaderGroupByDate;
            Text14.Page = Page1;
            Text14.Parent = HeaderFN_GetSalesOrderHeaderGroupByDate;
            Text15.Page = Page1;
            Text15.Parent = HeaderFN_GetSalesOrderHeaderGroupByDate;
            Text19.Page = Page1;
            Text19.Parent = HeaderFN_GetSalesOrderHeaderGroupByDate;
            DataFN_GetSalesOrderHeaderGroupByDate.Page = Page1;
            DataFN_GetSalesOrderHeaderGroupByDate.Parent = Page1;
            Text3.Page = Page1;
            Text3.Parent = DataFN_GetSalesOrderHeaderGroupByDate;
            Text5.Page = Page1;
            Text5.Parent = DataFN_GetSalesOrderHeaderGroupByDate;
            Text6.Page = Page1;
            Text6.Parent = DataFN_GetSalesOrderHeaderGroupByDate;
            Text9.Page = Page1;
            Text9.Parent = DataFN_GetSalesOrderHeaderGroupByDate;
            Text11.Page = Page1;
            Text11.Parent = DataFN_GetSalesOrderHeaderGroupByDate;
            Text13.Page = Page1;
            Text13.Parent = DataFN_GetSalesOrderHeaderGroupByDate;
            Text16.Page = Page1;
            Text16.Parent = DataFN_GetSalesOrderHeaderGroupByDate;
            Text17.Page = Page1;
            Text17.Parent = DataFN_GetSalesOrderHeaderGroupByDate;
            Text18.Page = Page1;
            Text18.Parent = DataFN_GetSalesOrderHeaderGroupByDate;
            FooterFN_GetSalesOrderHeaderGroupByDate.Page = Page1;
            FooterFN_GetSalesOrderHeaderGroupByDate.Parent = Page1;
            Text20.Page = Page1;
            Text20.Parent = FooterFN_GetSalesOrderHeaderGroupByDate;
            Text21.Page = Page1;
            Text21.Parent = FooterFN_GetSalesOrderHeaderGroupByDate;
            Text22.Page = Page1;
            Text22.Parent = FooterFN_GetSalesOrderHeaderGroupByDate;
            Text23.Page = Page1;
            Text23.Parent = FooterFN_GetSalesOrderHeaderGroupByDate;
            Text24.Page = Page1;
            Text24.Parent = FooterFN_GetSalesOrderHeaderGroupByDate;
            Text25.Page = Page1;
            Text25.Parent = FooterFN_GetSalesOrderHeaderGroupByDate;
            DataFN_GetSalesOrderHeaderGroupByDate.BeginRender += new EventHandler(DataFN_GetSalesOrderHeaderGroupByDate__BeginRender);
            DataFN_GetSalesOrderHeaderGroupByDate.EndRender += new EventHandler(DataFN_GetSalesOrderHeaderGroupByDate__EndRender);
            DataFN_GetSalesOrderHeaderGroupByDate.Rendering += new EventHandler(DataFN_GetSalesOrderHeaderGroupByDate__Rendering);
            AggregateFunctions = new object[] {
                    Text20_Sum,
                    Text21_Sum,
                    Text22_Sum,
                    Text23_Sum,
                    Text24_Sum,
                    Text25_Sum};
            // 
            // Add to ReportTitleBand1.Components
            // 
            ReportTitleBand1.Components.Clear();
            ReportTitleBand1.Components.AddRange(new StiComponent[] {
                        Text1});
            // 
            // Add to HeaderFN_GetSalesOrderHeaderGroupByDate.Components
            // 
            HeaderFN_GetSalesOrderHeaderGroupByDate.Components.Clear();
            HeaderFN_GetSalesOrderHeaderGroupByDate.Components.AddRange(new StiComponent[] {
                        Text2,
                        Text4,
                        Text7,
                        Text8,
                        Text10,
                        Text12,
                        Text14,
                        Text15,
                        Text19});
            // 
            // Add to DataFN_GetSalesOrderHeaderGroupByDate.Components
            // 
            DataFN_GetSalesOrderHeaderGroupByDate.Components.Clear();
            DataFN_GetSalesOrderHeaderGroupByDate.Components.AddRange(new StiComponent[] {
                        Text3,
                        Text5,
                        Text6,
                        Text9,
                        Text11,
                        Text13,
                        Text16,
                        Text17,
                        Text18});
            // 
            // Add to FooterFN_GetSalesOrderHeaderGroupByDate.Components
            // 
            FooterFN_GetSalesOrderHeaderGroupByDate.Components.Clear();
            FooterFN_GetSalesOrderHeaderGroupByDate.Components.AddRange(new StiComponent[] {
                        Text20,
                        Text21,
                        Text22,
                        Text23,
                        Text24,
                        Text25});
            // 
            // Add to Page1.Components
            // 
            Page1.Components.Clear();
            Page1.Components.AddRange(new StiComponent[] {
                        ReportTitleBand1,
                        HeaderFN_GetSalesOrderHeaderGroupByDate,
                        DataFN_GetSalesOrderHeaderGroupByDate,
                        FooterFN_GetSalesOrderHeaderGroupByDate});
            // 
            // Add to Pages
            // 
            Pages.Clear();
            Pages.AddRange(new[] {
                        Page1});
            FN_GetSalesOrderHeaderGroupByDate.Columns.AddRange(new[] {
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
                        new StiDataColumn("Status", "Status", "Status", typeof(byte))});
            DataSources.Add(FN_GetSalesOrderHeaderGroupByDate);
        }

        #region DataSource FN_GetSalesOrderHeaderGroupByDate
        public class FN_GetSalesOrderHeaderGroupByDateDataSource : StiDataTableSource
        {

            public FN_GetSalesOrderHeaderGroupByDateDataSource() :
                base("DS_SalesOrderHeaderGroupByDate.FN_GetSalesOrderHeaderGroupByDate", "FN_GetSalesOrderHeaderGroupByDate")
            {
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

            public virtual byte Status
            {
                get
                {
                    return ((byte)(ChangeType(this["Status"], typeof(byte), true)));
                }
            }
        }
        #endregion DataSource FN_GetSalesOrderHeaderGroupByDate
        #endregion StiReport Designer generated code - do not modify
    }
}
