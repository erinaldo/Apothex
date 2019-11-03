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

    public class RptSalesOrderDetailList : StiReport
    {

        public RptSalesOrderDetailList()
        {
            InitializeComponent();
        }
        #region StiReport Designer generated code - do not modify
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
        public StiHeaderBand HeaderVW_SalesOrderDetailList;
        public StiText Text1;
        public StiText Text2;
        public StiText Text3;
        public StiText Text5;
        public StiText Text4;
        public StiText Text6;
        public StiText Text7;
        public StiText Text8;
        public StiText Text9;
        public StiText Text10;
        public StiText Text11;
        public StiText Text12;
        public StiText Text13;
        public StiText Text14;
        public StiGroupHeaderBand GroupHeaderBand1;
        public StiDataBand DataVW_SalesOrderDetailList;
        public StiText Text15;
        public StiText Text16;
        public StiText Text17;
        public StiText Text18;
        public StiText Text19;
        public StiText Text20;
        public StiText Text21;
        public StiText Text22;
        public StiGroupFooterBand GroupFooterBand1;
        public StiText Text23;
        public StiSumDecimalFunctionService Text23_Sum;
        public StiWatermark Page1_Watermark;
        public StiPrinterSettings RptSalesOrderDetailList_PrinterSettings;
        public VW_SalesOrderDetailListDataSource VW_SalesOrderDetailList;
        public T_RptHeaderDataSource T_RptHeader;

        public void Text1__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "მედიკამენტების უკან დაბრუნების რეესტრი";
        }

        public void Text2__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, MyCompanyName, true);
        }

        public void Text3__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text3.TextFormat.Format(CheckExcelValue(sender, Today));
        }

        public void Text5__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "პერიოდი:";
        }

        public void Text4__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Format("{0:d}", T_RptHeader.Date1), true) + " - " + ToString(sender, Format("{0:d}", T_RptHeader.Date2), true);
        }

        public void Text6__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "თარიღი:";
        }

        public void Text7__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "რიგითი №";
        }

        public void Text8__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "სასაქონლო ზედნადების №";
        }

        public void Text9__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ზედნადების თარიღი";
        }

        public void Text10__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "კომპანია";
        }

        public void Text11__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "საქონლის დასახელება";
        }

        public void Text12__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "რაოდენობა";
        }

        public void Text13__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ფასი";
        }

        public void Text14__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "თანხა";
        }

        public void GroupHeaderBand1__GetValue(object sender, StiValueEventArgs e)
        {
            e.Value = VW_SalesOrderDetailList.SalesOrderID;
        }

        public void Text15__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Line, true);
        }

        public void Text16__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, VW_SalesOrderDetailList.SalesOrderID, true);
        }

        public void Text17__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text17.TextFormat.Format(CheckExcelValue(sender, VW_SalesOrderDetailList.OrderDate));
        }

        public void Text18__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, VW_SalesOrderDetailList.CustomerName, true);
        }

        public void Text19__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, VW_SalesOrderDetailList.MedicamentName, true);
        }

        public void Text20__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text20.TextFormat.Format(CheckExcelValue(sender, VW_SalesOrderDetailList.SaleQty));
        }

        public void Text21__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text21.TextFormat.Format(CheckExcelValue(sender, VW_SalesOrderDetailList._RealUnitPrice));
        }

        public void Text22__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text22.TextFormat.Format(CheckExcelValue(sender, VW_SalesOrderDetailList.LineTotal));
        }

        public void Text23__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(DataVW_SalesOrderDetailList,VW_SalesOrderDetailList.LineTotal)}";
            e.StoreToPrinted = true;
        }

        public String Text23_GetValue_End(StiComponent sender)
        {
            return Text23.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text23_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void GroupHeaderBand1__BeginRender(object sender, EventArgs e)
        {
            Text23_Sum.Init();
            Text23.TextValue = "";
        }

        public void GroupHeaderBand1__EndRender(object sender, EventArgs e)
        {
            Text23.SetText(new StiGetValue(Text23_GetValue_End));
        }

        public void DataVW_SalesOrderDetailList__Rendering(object sender, EventArgs e)
        {
            Text23_Sum.CalcItem(VW_SalesOrderDetailList.LineTotal);
        }

        private void InitializeComponent()
        {
            T_RptHeader = new T_RptHeaderDataSource();
            VW_SalesOrderDetailList = new VW_SalesOrderDetailListDataSource();
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
            Text23_Sum = new StiSumDecimalFunctionService();
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
            ReportAlias = "Rpt Sales Order Detail List";
            ReportAuthor = "Programmer.GE";
            // 
            // ReportChanged
            // 
            ReportChanged = new DateTime(2010, 6, 2, 21, 36, 41, 248);
            // 
            // ReportCreated
            // 
            ReportCreated = new DateTime(2010, 5, 25, 20, 19, 59, 0);
            ReportDescription = "მედიკამენტების უკან დაბრუნების რეესტრი";
            ReportFile = "D:\\User\\Documents\\Projects\\Apothex\\Source\\Class Library\\Apothex.Reporting\\Sales\\R" +
"ptSalesOrderDetailList.mrt";
            ReportGuid = "420d259867a9421392711831be1d3519";
            ReportName = "RptSalesOrderDetailList";
            ReportUnit = StiReportUnitType.Centimeters;
            ScriptLanguage = StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            Page1 = new StiPage();
            Page1.Guid = "0c32c32053b64074a86473eb39f8b804";
            Page1.Name = "Page1";
            Page1.PageHeight = 29.7;
            Page1.PageWidth = 21;
            Page1.Border = new StiBorder(StiBorderSides.None, Color.Black, 2, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Page1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // HeaderVW_SalesOrderDetailList
            // 
            HeaderVW_SalesOrderDetailList = new StiHeaderBand();
            HeaderVW_SalesOrderDetailList.ClientRectangle = new RectangleD(0, 0.4, 20, 2.8);
            HeaderVW_SalesOrderDetailList.Name = "HeaderVW_SalesOrderDetailList";
            HeaderVW_SalesOrderDetailList.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_SalesOrderDetailList.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text1
            // 
            Text1 = new StiText();
            Text1.ClientRectangle = new RectangleD(0, 0, 20, 0.6);
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
            // 
            // Text2
            // 
            Text2 = new StiText();
            Text2.ClientRectangle = new RectangleD(0, 0.6, 9.4, 0.6);
            Text2.Name = "Text2";
            Text2.GetValue += new StiGetValueEventHandler(Text2__GetValue);
            Text2.VertAlignment = StiVertAlignment.Center;
            Text2.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text2.Brush = new StiSolidBrush(Color.Transparent);
            Text2.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            Text2.Guid = null;
            Text2.Interaction = null;
            Text2.Margins = new StiMargins(0, 0, 0, 0);
            Text2.TextBrush = new StiSolidBrush(Color.Black);
            Text2.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text3
            // 
            Text3 = new StiText();
            Text3.ClientRectangle = new RectangleD(17, 0.6, 2, 0.6);
            Text3.Guid = "af4118ad09514379a646488901dff396";
            Text3.Name = "Text3";
            Text3.GetValue += new StiGetValueEventHandler(Text3__GetValue);
            Text3.VertAlignment = StiVertAlignment.Center;
            Text3.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text3.Brush = new StiSolidBrush(Color.Transparent);
            Text3.Font = new Font("BPG Glaho Arial", 10F);
            Text3.Interaction = null;
            Text3.Margins = new StiMargins(0, 0, 0, 0);
            Text3.TextBrush = new StiSolidBrush(Color.Black);
            Text3.TextFormat = new StiDateFormatService("d", " ");
            Text3.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text5
            // 
            Text5 = new StiText();
            Text5.ClientRectangle = new RectangleD(9.4, 0.6, 1.8, 0.6);
            Text5.Guid = "a19a50a03d984195a54b953c4c9f4817";
            Text5.HorAlignment = StiTextHorAlignment.Right;
            Text5.Name = "Text5";
            Text5.GetValue += new StiGetValueEventHandler(Text5__GetValue);
            Text5.VertAlignment = StiVertAlignment.Center;
            Text5.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text5.Brush = new StiSolidBrush(Color.Transparent);
            Text5.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            Text5.Interaction = null;
            Text5.Margins = new StiMargins(0, 0, 0, 0);
            Text5.TextBrush = new StiSolidBrush(Color.Black);
            Text5.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text4
            // 
            Text4 = new StiText();
            Text4.ClientRectangle = new RectangleD(11.2, 0.6, 3.6, 0.6);
            Text4.Guid = "7e3ea809ec9c44169058d7b5d6f7fb36";
            Text4.Name = "Text4";
            Text4.GetValue += new StiGetValueEventHandler(Text4__GetValue);
            Text4.VertAlignment = StiVertAlignment.Center;
            Text4.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text4.Brush = new StiSolidBrush(Color.Transparent);
            Text4.Font = new Font("BPG Glaho Arial", 10F);
            Text4.Interaction = null;
            Text4.Margins = new StiMargins(0, 0, 0, 0);
            Text4.TextBrush = new StiSolidBrush(Color.Black);
            Text4.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text6
            // 
            Text6 = new StiText();
            Text6.ClientRectangle = new RectangleD(15.2, 0.6, 1.8, 0.6);
            Text6.Guid = "b4c5379c3712489cb2e25ea983c6292a";
            Text6.HorAlignment = StiTextHorAlignment.Right;
            Text6.Name = "Text6";
            Text6.GetValue += new StiGetValueEventHandler(Text6__GetValue);
            Text6.VertAlignment = StiVertAlignment.Center;
            Text6.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text6.Brush = new StiSolidBrush(Color.Transparent);
            Text6.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            Text6.Interaction = null;
            Text6.Margins = new StiMargins(0, 0, 0, 0);
            Text6.TextBrush = new StiSolidBrush(Color.Black);
            Text6.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text7
            // 
            Text7 = new StiText();
            Text7.ClientRectangle = new RectangleD(0, 1.6, 1, 1.2);
            Text7.HorAlignment = StiTextHorAlignment.Center;
            Text7.Name = "Text7";
            Text7.GetValue += new StiGetValueEventHandler(Text7__GetValue);
            Text7.VertAlignment = StiVertAlignment.Center;
            Text7.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text7.Brush = new StiSolidBrush(Color.Transparent);
            Text7.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            Text7.Guid = null;
            Text7.Interaction = null;
            Text7.Margins = new StiMargins(0, 0, 0, 0);
            Text7.TextBrush = new StiSolidBrush(Color.Black);
            Text7.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text8
            // 
            Text8 = new StiText();
            Text8.ClientRectangle = new RectangleD(1, 1.6, 1.8, 1.2);
            Text8.Guid = "ab0f7b4833104d73a1ae010fff91c7f3";
            Text8.HorAlignment = StiTextHorAlignment.Center;
            Text8.Name = "Text8";
            Text8.GetValue += new StiGetValueEventHandler(Text8__GetValue);
            Text8.VertAlignment = StiVertAlignment.Center;
            Text8.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text8.Brush = new StiSolidBrush(Color.Transparent);
            Text8.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            Text8.Interaction = null;
            Text8.Margins = new StiMargins(0, 0, 0, 0);
            Text8.TextBrush = new StiSolidBrush(Color.Black);
            Text8.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text9
            // 
            Text9 = new StiText();
            Text9.ClientRectangle = new RectangleD(2.8, 1.6, 1.6, 1.2);
            Text9.Guid = "4dd95e1edcb64275b96f8b1dc84afc5c";
            Text9.HorAlignment = StiTextHorAlignment.Center;
            Text9.Name = "Text9";
            Text9.GetValue += new StiGetValueEventHandler(Text9__GetValue);
            Text9.VertAlignment = StiVertAlignment.Center;
            Text9.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text9.Brush = new StiSolidBrush(Color.Transparent);
            Text9.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            Text9.Interaction = null;
            Text9.Margins = new StiMargins(0, 0, 0, 0);
            Text9.TextBrush = new StiSolidBrush(Color.Black);
            Text9.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text10
            // 
            Text10 = new StiText();
            Text10.ClientRectangle = new RectangleD(4.4, 1.6, 5, 1.2);
            Text10.Guid = "6745a9469a8c4f2b9c9bfed40cdc5322";
            Text10.HorAlignment = StiTextHorAlignment.Center;
            Text10.Name = "Text10";
            Text10.GetValue += new StiGetValueEventHandler(Text10__GetValue);
            Text10.VertAlignment = StiVertAlignment.Center;
            Text10.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text10.Brush = new StiSolidBrush(Color.Transparent);
            Text10.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            Text10.Interaction = null;
            Text10.Margins = new StiMargins(0, 0, 0, 0);
            Text10.TextBrush = new StiSolidBrush(Color.Black);
            Text10.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text11
            // 
            Text11 = new StiText();
            Text11.ClientRectangle = new RectangleD(9.4, 1.6, 5, 1.2);
            Text11.Guid = "07e8d1cc546b4bf9b6e64cb0c387787a";
            Text11.HorAlignment = StiTextHorAlignment.Center;
            Text11.Name = "Text11";
            Text11.GetValue += new StiGetValueEventHandler(Text11__GetValue);
            Text11.VertAlignment = StiVertAlignment.Center;
            Text11.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text11.Brush = new StiSolidBrush(Color.Transparent);
            Text11.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            Text11.Interaction = null;
            Text11.Margins = new StiMargins(0, 0, 0, 0);
            Text11.TextBrush = new StiSolidBrush(Color.Black);
            Text11.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text12
            // 
            Text12 = new StiText();
            Text12.ClientRectangle = new RectangleD(14.4, 1.6, 1.8, 1.2);
            Text12.Guid = "4b4bd03a2279499e87fd59eaf5e1995c";
            Text12.HorAlignment = StiTextHorAlignment.Center;
            Text12.Name = "Text12";
            Text12.GetValue += new StiGetValueEventHandler(Text12__GetValue);
            Text12.VertAlignment = StiVertAlignment.Center;
            Text12.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text12.Brush = new StiSolidBrush(Color.Transparent);
            Text12.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            Text12.Interaction = null;
            Text12.Margins = new StiMargins(0, 0, 0, 0);
            Text12.TextBrush = new StiSolidBrush(Color.Black);
            Text12.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text13
            // 
            Text13 = new StiText();
            Text13.ClientRectangle = new RectangleD(16.2, 1.6, 1.8, 1.2);
            Text13.Guid = "e2530fee2cd242b3b342e158ab2d97a9";
            Text13.HorAlignment = StiTextHorAlignment.Center;
            Text13.Name = "Text13";
            Text13.GetValue += new StiGetValueEventHandler(Text13__GetValue);
            Text13.VertAlignment = StiVertAlignment.Center;
            Text13.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text13.Brush = new StiSolidBrush(Color.Transparent);
            Text13.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            Text13.Interaction = null;
            Text13.Margins = new StiMargins(0, 0, 0, 0);
            Text13.TextBrush = new StiSolidBrush(Color.Black);
            Text13.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text14
            // 
            Text14 = new StiText();
            Text14.ClientRectangle = new RectangleD(18, 1.6, 2, 1.2);
            Text14.Guid = "35d72c270066488e8abfa18851fae3a9";
            Text14.HorAlignment = StiTextHorAlignment.Center;
            Text14.Name = "Text14";
            Text14.GetValue += new StiGetValueEventHandler(Text14__GetValue);
            Text14.VertAlignment = StiVertAlignment.Center;
            Text14.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text14.Brush = new StiSolidBrush(Color.Transparent);
            Text14.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            Text14.Interaction = null;
            Text14.Margins = new StiMargins(0, 0, 0, 0);
            Text14.TextBrush = new StiSolidBrush(Color.Black);
            Text14.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            HeaderVW_SalesOrderDetailList.Guid = null;
            HeaderVW_SalesOrderDetailList.Interaction = null;
            // 
            // GroupHeaderBand1
            // 
            GroupHeaderBand1 = new StiGroupHeaderBand();
            GroupHeaderBand1.ClientRectangle = new RectangleD(0, 4, 20, 0.8);
            GroupHeaderBand1.GetValue += new StiValueEventHandler(GroupHeaderBand1__GetValue);
            GroupHeaderBand1.Enabled = false;
            GroupHeaderBand1.Name = "GroupHeaderBand1";
            GroupHeaderBand1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            GroupHeaderBand1.Brush = new StiSolidBrush(Color.Transparent);
            GroupHeaderBand1.Guid = null;
            GroupHeaderBand1.Interaction = null;
            // 
            // DataVW_SalesOrderDetailList
            // 
            DataVW_SalesOrderDetailList = new StiDataBand();
            DataVW_SalesOrderDetailList.ClientRectangle = new RectangleD(0, 5.6, 20, 0.8);
            DataVW_SalesOrderDetailList.DataSourceName = "VW_SalesOrderDetailList";
            DataVW_SalesOrderDetailList.Name = "DataVW_SalesOrderDetailList";
            DataVW_SalesOrderDetailList.Sort = new[] {
                    "ASC",
                    "OrderDate",
                    "ASC",
                    "SalesOrderID"};
            DataVW_SalesOrderDetailList.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataVW_SalesOrderDetailList.Brush = new StiSolidBrush(Color.Transparent);
            DataVW_SalesOrderDetailList.BusinessObjectGuid = null;
            // 
            // Text15
            // 
            Text15 = new StiText();
            Text15.ClientRectangle = new RectangleD(0, 0, 1, 0.8);
            Text15.GrowToHeight = true;
            Text15.Name = "Text15";
            Text15.GetValue += new StiGetValueEventHandler(Text15__GetValue);
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
            Text16.ClientRectangle = new RectangleD(1, 0, 1.8, 0.8);
            Text16.GrowToHeight = true;
            Text16.Name = "Text16";
            Text16.GetValue += new StiGetValueEventHandler(Text16__GetValue);
            Text16.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text16.Brush = new StiSolidBrush(Color.Transparent);
            Text16.Font = new Font("BPG Glaho Arial", 8F);
            Text16.Guid = null;
            Text16.Interaction = null;
            Text16.Margins = new StiMargins(0, 0, 0, 0);
            Text16.TextBrush = new StiSolidBrush(Color.Black);
            Text16.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text17
            // 
            Text17 = new StiText();
            Text17.ClientRectangle = new RectangleD(2.8, 0, 1.6, 0.8);
            Text17.GrowToHeight = true;
            Text17.Name = "Text17";
            Text17.GetValue += new StiGetValueEventHandler(Text17__GetValue);
            Text17.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text17.Brush = new StiSolidBrush(Color.Transparent);
            Text17.Font = new Font("BPG Glaho Arial", 8F);
            Text17.Guid = null;
            Text17.Interaction = null;
            Text17.Margins = new StiMargins(0, 0, 0, 0);
            Text17.TextBrush = new StiSolidBrush(Color.Black);
            Text17.TextFormat = new StiDateFormatService("d", " ");
            Text17.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text18
            // 
            Text18 = new StiText();
            Text18.CanGrow = true;
            Text18.ClientRectangle = new RectangleD(4.4, 0, 5, 0.8);
            Text18.GrowToHeight = true;
            Text18.Name = "Text18";
            Text18.GetValue += new StiGetValueEventHandler(Text18__GetValue);
            Text18.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text18.Brush = new StiSolidBrush(Color.Transparent);
            Text18.Font = new Font("BPG Glaho Arial", 8F);
            Text18.Guid = null;
            Text18.Interaction = null;
            Text18.Margins = new StiMargins(0, 0, 0, 0);
            Text18.TextBrush = new StiSolidBrush(Color.Black);
            Text18.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text19
            // 
            Text19 = new StiText();
            Text19.CanGrow = true;
            Text19.ClientRectangle = new RectangleD(9.4, 0, 5, 0.8);
            Text19.GrowToHeight = true;
            Text19.Name = "Text19";
            Text19.GetValue += new StiGetValueEventHandler(Text19__GetValue);
            Text19.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text19.Brush = new StiSolidBrush(Color.Transparent);
            Text19.Font = new Font("BPG Glaho Arial", 8F);
            Text19.Guid = null;
            Text19.Interaction = null;
            Text19.Margins = new StiMargins(0, 0, 0, 0);
            Text19.TextBrush = new StiSolidBrush(Color.Black);
            Text19.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text20
            // 
            Text20 = new StiText();
            Text20.ClientRectangle = new RectangleD(14.4, 0, 1.8, 0.8);
            Text20.GrowToHeight = true;
            Text20.HorAlignment = StiTextHorAlignment.Right;
            Text20.Name = "Text20";
            Text20.GetValue += new StiGetValueEventHandler(Text20__GetValue);
            Text20.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text20.Brush = new StiSolidBrush(Color.Transparent);
            Text20.Font = new Font("BPG Glaho Arial", 8F);
            Text20.Guid = null;
            Text20.Interaction = null;
            Text20.Margins = new StiMargins(0, 0, 0, 0);
            Text20.TextBrush = new StiSolidBrush(Color.Black);
            Text20.TextFormat = new StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            Text20.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text21
            // 
            Text21 = new StiText();
            Text21.ClientRectangle = new RectangleD(16.2, 0, 1.8, 0.8);
            Text21.GrowToHeight = true;
            Text21.HorAlignment = StiTextHorAlignment.Right;
            Text21.Name = "Text21";
            Text21.GetValue += new StiGetValueEventHandler(Text21__GetValue);
            Text21.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text21.Brush = new StiSolidBrush(Color.Transparent);
            Text21.Font = new Font("BPG Glaho Arial", 8F);
            Text21.Guid = null;
            Text21.Interaction = null;
            Text21.Margins = new StiMargins(0, 0, 0, 0);
            Text21.TextBrush = new StiSolidBrush(Color.Black);
            Text21.TextFormat = new StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            Text21.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text22
            // 
            Text22 = new StiText();
            Text22.ClientRectangle = new RectangleD(18, 0, 2, 0.8);
            Text22.GrowToHeight = true;
            Text22.HorAlignment = StiTextHorAlignment.Right;
            Text22.Name = "Text22";
            Text22.GetValue += new StiGetValueEventHandler(Text22__GetValue);
            Text22.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text22.Brush = new StiSolidBrush(Color.Transparent);
            Text22.Font = new Font("BPG Glaho Arial", 8F);
            Text22.Guid = null;
            Text22.Interaction = null;
            Text22.Margins = new StiMargins(0, 0, 0, 0);
            Text22.TextBrush = new StiSolidBrush(Color.Black);
            Text22.TextFormat = new StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            Text22.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            DataVW_SalesOrderDetailList.DataRelationName = null;
            DataVW_SalesOrderDetailList.Guid = null;
            DataVW_SalesOrderDetailList.Interaction = null;
            DataVW_SalesOrderDetailList.MasterComponent = null;
            // 
            // GroupFooterBand1
            // 
            GroupFooterBand1 = new StiGroupFooterBand();
            GroupFooterBand1.ClientRectangle = new RectangleD(0, 7.2, 20, 0.8);
            GroupFooterBand1.Name = "GroupFooterBand1";
            GroupFooterBand1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            GroupFooterBand1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text23
            // 
            Text23 = new StiText();
            Text23.ClientRectangle = new RectangleD(18, 0, 2, 0.6);
            Text23.HorAlignment = StiTextHorAlignment.Right;
            Text23.Name = "Text23";
            // 
            // Text23_Sum
            // 
            Text23.GetValue += new StiGetValueEventHandler(Text23__GetValue);
            Text23.VertAlignment = StiVertAlignment.Center;
            Text23.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text23.Brush = new StiSolidBrush(Color.Transparent);
            Text23.Font = new Font("BPG Glaho Arial", 8F);
            Text23.Guid = null;
            Text23.Interaction = null;
            Text23.Margins = new StiMargins(0, 0, 0, 0);
            Text23.TextBrush = new StiSolidBrush(Color.Black);
            Text23.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            Text23.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            GroupFooterBand1.Guid = null;
            GroupFooterBand1.Interaction = null;
            Page1.ExcelSheetValue = null;
            Page1.Interaction = null;
            Page1.Margins = new StiMargins(0.5, 0.5, 0.5, 0.5);
            Page1_Watermark = new StiWatermark();
            Page1_Watermark.Font = new Font("Arial", 100F);
            Page1_Watermark.Image = null;
            Page1_Watermark.TextBrush = new StiSolidBrush(Color.FromArgb(50, 0, 0, 0));
            RptSalesOrderDetailList_PrinterSettings = new StiPrinterSettings();
            PrinterSettings = RptSalesOrderDetailList_PrinterSettings;
            Page1.Report = this;
            Page1.Watermark = Page1_Watermark;
            HeaderVW_SalesOrderDetailList.Page = Page1;
            HeaderVW_SalesOrderDetailList.Parent = Page1;
            Text1.Page = Page1;
            Text1.Parent = HeaderVW_SalesOrderDetailList;
            Text2.Page = Page1;
            Text2.Parent = HeaderVW_SalesOrderDetailList;
            Text3.Page = Page1;
            Text3.Parent = HeaderVW_SalesOrderDetailList;
            Text5.Page = Page1;
            Text5.Parent = HeaderVW_SalesOrderDetailList;
            Text4.Page = Page1;
            Text4.Parent = HeaderVW_SalesOrderDetailList;
            Text6.Page = Page1;
            Text6.Parent = HeaderVW_SalesOrderDetailList;
            Text7.Page = Page1;
            Text7.Parent = HeaderVW_SalesOrderDetailList;
            Text8.Page = Page1;
            Text8.Parent = HeaderVW_SalesOrderDetailList;
            Text9.Page = Page1;
            Text9.Parent = HeaderVW_SalesOrderDetailList;
            Text10.Page = Page1;
            Text10.Parent = HeaderVW_SalesOrderDetailList;
            Text11.Page = Page1;
            Text11.Parent = HeaderVW_SalesOrderDetailList;
            Text12.Page = Page1;
            Text12.Parent = HeaderVW_SalesOrderDetailList;
            Text13.Page = Page1;
            Text13.Parent = HeaderVW_SalesOrderDetailList;
            Text14.Page = Page1;
            Text14.Parent = HeaderVW_SalesOrderDetailList;
            GroupHeaderBand1.Page = Page1;
            GroupHeaderBand1.Parent = Page1;
            DataVW_SalesOrderDetailList.Page = Page1;
            DataVW_SalesOrderDetailList.Parent = Page1;
            Text15.Page = Page1;
            Text15.Parent = DataVW_SalesOrderDetailList;
            Text16.Page = Page1;
            Text16.Parent = DataVW_SalesOrderDetailList;
            Text17.Page = Page1;
            Text17.Parent = DataVW_SalesOrderDetailList;
            Text18.Page = Page1;
            Text18.Parent = DataVW_SalesOrderDetailList;
            Text19.Page = Page1;
            Text19.Parent = DataVW_SalesOrderDetailList;
            Text20.Page = Page1;
            Text20.Parent = DataVW_SalesOrderDetailList;
            Text21.Page = Page1;
            Text21.Parent = DataVW_SalesOrderDetailList;
            Text22.Page = Page1;
            Text22.Parent = DataVW_SalesOrderDetailList;
            GroupFooterBand1.Page = Page1;
            GroupFooterBand1.Parent = Page1;
            Text23.Page = Page1;
            Text23.Parent = GroupFooterBand1;
            GroupHeaderBand1.BeginRender += new EventHandler(GroupHeaderBand1__BeginRender);
            GroupHeaderBand1.EndRender += new EventHandler(GroupHeaderBand1__EndRender);
            DataVW_SalesOrderDetailList.Rendering += new EventHandler(DataVW_SalesOrderDetailList__Rendering);
            AggregateFunctions = new object[] {
                    Text23_Sum};
            // 
            // Add to HeaderVW_SalesOrderDetailList.Components
            // 
            HeaderVW_SalesOrderDetailList.Components.Clear();
            HeaderVW_SalesOrderDetailList.Components.AddRange(new StiComponent[] {
                        Text1,
                        Text2,
                        Text3,
                        Text5,
                        Text4,
                        Text6,
                        Text7,
                        Text8,
                        Text9,
                        Text10,
                        Text11,
                        Text12,
                        Text13,
                        Text14});
            // 
            // Add to DataVW_SalesOrderDetailList.Components
            // 
            DataVW_SalesOrderDetailList.Components.Clear();
            DataVW_SalesOrderDetailList.Components.AddRange(new StiComponent[] {
                        Text15,
                        Text16,
                        Text17,
                        Text18,
                        Text19,
                        Text20,
                        Text21,
                        Text22});
            // 
            // Add to GroupFooterBand1.Components
            // 
            GroupFooterBand1.Components.Clear();
            GroupFooterBand1.Components.AddRange(new StiComponent[] {
                        Text23});
            // 
            // Add to Page1.Components
            // 
            Page1.Components.Clear();
            Page1.Components.AddRange(new StiComponent[] {
                        HeaderVW_SalesOrderDetailList,
                        GroupHeaderBand1,
                        DataVW_SalesOrderDetailList,
                        GroupFooterBand1});
            // 
            // Add to Pages
            // 
            Pages.Clear();
            Pages.AddRange(new[] {
                        Page1});
            VW_SalesOrderDetailList.Columns.AddRange(new[] {
                        new StiDataColumn("SalesOrderID", "SalesOrderID", "SalesOrderID", typeof(int)),
                        new StiDataColumn("OrderDate", "OrderDate", "OrderDate", typeof(DateTime)),
                        new StiDataColumn("CustomerName", "CustomerName", "CustomerName", typeof(string)),
                        new StiDataColumn("MedicamentName", "MedicamentName", "MedicamentName", typeof(string)),
                        new StiDataColumn("SaleQty", "SaleQty", "SaleQty", typeof(decimal)),
                        new StiDataColumn("UnitPrice", "UnitPrice", "UnitPrice", typeof(decimal)),
                        new StiDataColumn("UnitPriceDiscount", "UnitPriceDiscount", "UnitPriceDiscount", typeof(decimal)),
                        new StiDataColumn("LineTotal", "LineTotal", "LineTotal", typeof(decimal)),
                        new StiCalcDataColumn("_RealUnitPrice", "_RealUnitPrice", typeof(decimal))});
            DataSources.Add(VW_SalesOrderDetailList);
            T_RptHeader.Columns.AddRange(new[] {
                        new StiDataColumn("Date1", "Date1", "Date1", typeof(DateTime)),
                        new StiDataColumn("Date2", "Date2", "Date2", typeof(DateTime))});
            DataSources.Add(T_RptHeader);
        }

        public decimal GetVW_SalesOrderDetailList__RealUnitPrice()
        {
            return VW_SalesOrderDetailList.UnitPrice * VW_SalesOrderDetailList.UnitPriceDiscount;
        }

        #region DataSource VW_SalesOrderDetailList
        public class VW_SalesOrderDetailListDataSource : StiDataTableSource
        {

            public VW_SalesOrderDetailListDataSource() :
                base("DS_SalesOrderDetailList.VW_SalesOrderDetailList", "VW_SalesOrderDetailList")
            {
            }

            public virtual int SalesOrderID
            {
                get
                {
                    return ((int)(ChangeType(this["SalesOrderID"], typeof(int), true)));
                }
            }

            public virtual DateTime OrderDate
            {
                get
                {
                    return ((DateTime)(ChangeType(this["OrderDate"], typeof(DateTime), true)));
                }
            }

            public virtual string CustomerName
            {
                get
                {
                    return ((string)(ChangeType(this["CustomerName"], typeof(string), true)));
                }
            }

            public virtual string MedicamentName
            {
                get
                {
                    return ((string)(ChangeType(this["MedicamentName"], typeof(string), true)));
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

            public virtual decimal _RealUnitPrice
            {
                get
                {
                    return ((RptSalesOrderDetailList)(Dictionary.Report)).GetVW_SalesOrderDetailList__RealUnitPrice();
                }
            }
        }
        #endregion DataSource VW_SalesOrderDetailList

        #region DataSource T_RptHeader
        public class T_RptHeaderDataSource : StiDataTableSource
        {

            public T_RptHeaderDataSource() :
                base("DS_SalesOrderDetailList.T_RptHeader", "T_RptHeader")
            {
            }

            public virtual DateTime Date1
            {
                get
                {
                    return ((DateTime)(ChangeType(this["Date1"], typeof(DateTime), true)));
                }
            }

            public virtual DateTime Date2
            {
                get
                {
                    return ((DateTime)(ChangeType(this["Date2"], typeof(DateTime), true)));
                }
            }
        }
        #endregion DataSource T_RptHeader
        #endregion StiReport Designer generated code - do not modify
    }
}
