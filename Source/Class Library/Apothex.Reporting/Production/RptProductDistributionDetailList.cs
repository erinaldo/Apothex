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

    public class RptProductDistributionDetailList : StiReport
    {

        public RptProductDistributionDetailList()
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
        public StiHeaderBand HeaderVW_ProductDistributionHeader;
        public StiText Text1;
        public StiText Text2;
        public StiText Text3;
        public StiText Text4;
        public StiText Text5;
        public StiText HeaderVW_PurchaseOrderHeader_rowguid;
        public StiText HeaderVW_PurchaseOrderHeader_Status;
        public StiText Text7;
        public StiText Text8;
        public StiText Text10;
        public StiText Text12;
        public StiText Text15;
        public StiText Text17;
        public StiText Text19;
        public StiText Text21;
        public StiText Text22;
        public StiGroupHeaderBand GroupHeaderBand1;
        public StiDataBand DataVW_ProductDistributionHeader;
        public StiText DataVW_PurchaseOrderHeader_rowguid;
        public StiCheckBox CheckBox1;
        public StiText Text6;
        public StiText Text9;
        public StiText Text11;
        public StiText Text13;
        public StiText Text14;
        public StiText Text16;
        public StiText Text18;
        public StiText Text20;
        public StiGroupFooterBand GroupFooterBand1;
        public StiText Text24;
        public StiSumDecimalFunctionService Text24_Sum;
        public StiWatermark Page1_Watermark;
        public StiPrinterSettings RptProductDistributionDetailList_PrinterSettings;
        public VW_ProductDistributionDetailListDataSource VW_ProductDistributionDetailList;
        public T_RptHeaderDataSource T_RptHeader;

        public void Text1__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "შიდა გადაცემის რეესტრი";
        }

        public void Text2__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text2.TextFormat.Format(CheckExcelValue(sender, Today));
        }

        public void Text3__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "თარიღი:";
        }

        public void Text4__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Format("{0:d}", T_RptHeader.Date1), true) + " - " + ToString(sender, Format("{0:d}", T_RptHeader.Date2), true);
        }

        public void Text5__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "პერიოდი:";
        }

        public void HeaderVW_PurchaseOrderHeader_rowguid__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "რიგითი №";
        }

        public void HeaderVW_PurchaseOrderHeader_Status__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "სტატუსი";
        }

        public void Text7__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "შიდა გადაცემის ზედდებულის №";
        }

        public void Text8__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "შიდა გადაცემის თარიღი";
        }

        public void Text10__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "გდასცა ფილიალმა";
        }

        public void Text12__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "მიიღო ფილიალმა";
        }

        public void Text15__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "საქონლის დასახელება";
        }

        public void Text17__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "რაოდენობა";
        }

        public void Text19__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ფასი";
        }

        public void Text21__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "თანხა";
        }

        public void Text22__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, MyCompanyName, true);
        }

        public void GroupHeaderBand1__GetValue(object sender, StiValueEventArgs e)
        {
            e.Value = VW_ProductDistributionDetailList.ProductDistributionID;
        }

        public void DataVW_PurchaseOrderHeader_rowguid__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Line, true);
        }

        public void CheckBox1__GetChecked(object sender, StiValueEventArgs e)
        {
            e.Value = VW_ProductDistributionDetailList.Status == 2;
        }

        public void Text6__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, VW_ProductDistributionDetailList.ProductDistributionID, true);
        }

        public void Text9__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text9.TextFormat.Format(CheckExcelValue(sender, VW_ProductDistributionDetailList.StartDate));
        }

        public void Text11__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, VW_ProductDistributionDetailList.FromBranchName, true);
        }

        public void Text13__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, VW_ProductDistributionDetailList.ToBranchName, true);
        }

        public void Text14__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, VW_ProductDistributionDetailList.MedicamentName, true);
        }

        public void Text16__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, VW_ProductDistributionDetailList.DistributeQty, true);
        }

        public void Text18__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, VW_ProductDistributionDetailList.UnitPrice, true);
        }

        public void Text20__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text20.TextFormat.Format(CheckExcelValue(sender, VW_ProductDistributionDetailList.LineTotal));
        }

        public void Text24__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(DataVW_ProductDistributionHeader,VW_ProductDistributionDetailList.LineTot" +
"al)}";
            e.StoreToPrinted = true;
        }

        public String Text24_GetValue_End(StiComponent sender)
        {
            return Text24.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text24_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void GroupHeaderBand1__BeginRender(object sender, EventArgs e)
        {
            Text24_Sum.Init();
            Text24.TextValue = "";
        }

        public void GroupHeaderBand1__EndRender(object sender, EventArgs e)
        {
            Text24.SetText(new StiGetValue(Text24_GetValue_End));
        }

        public void DataVW_ProductDistributionHeader__Rendering(object sender, EventArgs e)
        {
            Text24_Sum.CalcItem(VW_ProductDistributionDetailList.LineTotal);
        }

        private void InitializeComponent()
        {
            T_RptHeader = new T_RptHeaderDataSource();
            VW_ProductDistributionDetailList = new VW_ProductDistributionDetailListDataSource();
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
            Text24_Sum = new StiSumDecimalFunctionService();
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
            ReportAlias = "Rpt Product Distribution Detail List";
            ReportAuthor = "Programmer.GE";
            // 
            // ReportChanged
            // 
            ReportChanged = new DateTime(2010, 6, 2, 17, 43, 57, 0);
            // 
            // ReportCreated
            // 
            ReportCreated = new DateTime(2009, 2, 8, 19, 58, 55, 0);
            ReportDescription = "შიდა გადაცემის რეესტრი";
            ReportFile = "D:\\User\\Documents\\Projects\\Apothex\\Source\\Class Library\\Apothex.Reporting\\Product" +
"ion\\RptProductDistributionDetailList.mrt";
            ReportGuid = "3712d4f533774c9887578cc8a8df65c6";
            ReportName = "RptProductDistributionDetailList";
            ReportUnit = StiReportUnitType.Centimeters;
            ScriptLanguage = StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            Page1 = new StiPage();
            Page1.Guid = "2a54d7263bcd41b99fe3bdaf6ea00af2";
            Page1.Name = "Page1";
            Page1.PageHeight = 29.7;
            Page1.PageWidth = 21;
            Page1.PaperSize = PaperKind.A4;
            Page1.Border = new StiBorder(StiBorderSides.None, Color.Black, 2, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Page1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // HeaderVW_ProductDistributionHeader
            // 
            HeaderVW_ProductDistributionHeader = new StiHeaderBand();
            HeaderVW_ProductDistributionHeader.ClientRectangle = new RectangleD(0, 0.4, 20, 2.8);
            HeaderVW_ProductDistributionHeader.Name = "HeaderVW_ProductDistributionHeader";
            HeaderVW_ProductDistributionHeader.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_ProductDistributionHeader.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text1
            // 
            Text1 = new StiText();
            Text1.ClientRectangle = new RectangleD(0, 0, 19, 0.6);
            Text1.HorAlignment = StiTextHorAlignment.Center;
            Text1.Name = "Text1";
            Text1.GetValue += new StiGetValueEventHandler(Text1__GetValue);
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
            Text2.ClientRectangle = new RectangleD(17, 0.6, 2, 0.6);
            Text2.Guid = "7e2fcff0b637462a9cb9e56be92888ff";
            Text2.Name = "Text2";
            Text2.GetValue += new StiGetValueEventHandler(Text2__GetValue);
            Text2.VertAlignment = StiVertAlignment.Center;
            Text2.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text2.Brush = new StiSolidBrush(Color.Transparent);
            Text2.Font = new Font("BPG Glaho Arial", 10F);
            Text2.Interaction = null;
            Text2.Margins = new StiMargins(0, 0, 0, 0);
            Text2.TextBrush = new StiSolidBrush(Color.Black);
            Text2.TextFormat = new StiDateFormatService("d", " ");
            Text2.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text3
            // 
            Text3 = new StiText();
            Text3.ClientRectangle = new RectangleD(15.2, 0.6, 1.8, 0.6);
            Text3.Guid = "a3a2362b613e48fb82443bdea6f38650";
            Text3.HorAlignment = StiTextHorAlignment.Right;
            Text3.Name = "Text3";
            Text3.GetValue += new StiGetValueEventHandler(Text3__GetValue);
            Text3.VertAlignment = StiVertAlignment.Center;
            Text3.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text3.Brush = new StiSolidBrush(Color.Transparent);
            Text3.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            Text3.Interaction = null;
            Text3.Margins = new StiMargins(0, 0, 0, 0);
            Text3.TextBrush = new StiSolidBrush(Color.Black);
            Text3.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text4
            // 
            Text4 = new StiText();
            Text4.ClientRectangle = new RectangleD(11.2, 0.6, 3.6, 0.6);
            Text4.Guid = "fb50ab6e8be947de9a94438c995472b6";
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
            // Text5
            // 
            Text5 = new StiText();
            Text5.ClientRectangle = new RectangleD(9.4, 0.6, 1.8, 0.6);
            Text5.Guid = "4200f9ba29804b8e8a129378afa2331d";
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
            // HeaderVW_PurchaseOrderHeader_rowguid
            // 
            HeaderVW_PurchaseOrderHeader_rowguid = new StiText();
            HeaderVW_PurchaseOrderHeader_rowguid.ClientRectangle = new RectangleD(0, 1.4, 1, 1.4);
            HeaderVW_PurchaseOrderHeader_rowguid.Guid = "d7ae91b3fad141738b1a8ff8a45b1747";
            HeaderVW_PurchaseOrderHeader_rowguid.HorAlignment = StiTextHorAlignment.Center;
            HeaderVW_PurchaseOrderHeader_rowguid.Name = "HeaderVW_PurchaseOrderHeader_rowguid";
            HeaderVW_PurchaseOrderHeader_rowguid.GetValue += new StiGetValueEventHandler(HeaderVW_PurchaseOrderHeader_rowguid__GetValue);
            HeaderVW_PurchaseOrderHeader_rowguid.VertAlignment = StiVertAlignment.Center;
            HeaderVW_PurchaseOrderHeader_rowguid.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_PurchaseOrderHeader_rowguid.Brush = new StiSolidBrush(Color.Transparent);
            HeaderVW_PurchaseOrderHeader_rowguid.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            HeaderVW_PurchaseOrderHeader_rowguid.Interaction = null;
            HeaderVW_PurchaseOrderHeader_rowguid.Margins = new StiMargins(0, 0, 0, 0);
            HeaderVW_PurchaseOrderHeader_rowguid.TextBrush = new StiSolidBrush(Color.Black);
            HeaderVW_PurchaseOrderHeader_rowguid.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderVW_PurchaseOrderHeader_Status
            // 
            HeaderVW_PurchaseOrderHeader_Status = new StiText();
            HeaderVW_PurchaseOrderHeader_Status.ClientRectangle = new RectangleD(19.4, 1.4, 0.6, 1.4);
            HeaderVW_PurchaseOrderHeader_Status.Guid = "6cef4bdc7ba84124823004cf9cbe6072";
            HeaderVW_PurchaseOrderHeader_Status.HorAlignment = StiTextHorAlignment.Center;
            HeaderVW_PurchaseOrderHeader_Status.Name = "HeaderVW_PurchaseOrderHeader_Status";
            HeaderVW_PurchaseOrderHeader_Status.GetValue += new StiGetValueEventHandler(HeaderVW_PurchaseOrderHeader_Status__GetValue);
            HeaderVW_PurchaseOrderHeader_Status.VertAlignment = StiVertAlignment.Center;
            HeaderVW_PurchaseOrderHeader_Status.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_PurchaseOrderHeader_Status.Brush = new StiSolidBrush(Color.Transparent);
            HeaderVW_PurchaseOrderHeader_Status.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            HeaderVW_PurchaseOrderHeader_Status.Interaction = null;
            HeaderVW_PurchaseOrderHeader_Status.Margins = new StiMargins(0, 0, 0, 0);
            HeaderVW_PurchaseOrderHeader_Status.TextBrush = new StiSolidBrush(Color.Black);
            HeaderVW_PurchaseOrderHeader_Status.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text7
            // 
            Text7 = new StiText();
            Text7.ClientRectangle = new RectangleD(1, 1.4, 1.6, 1.4);
            Text7.Guid = "7497cfff05a0444899c74227fd9f14cd";
            Text7.HorAlignment = StiTextHorAlignment.Center;
            Text7.Name = "Text7";
            Text7.GetValue += new StiGetValueEventHandler(Text7__GetValue);
            Text7.VertAlignment = StiVertAlignment.Center;
            Text7.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text7.Brush = new StiSolidBrush(Color.Transparent);
            Text7.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            Text7.Interaction = null;
            Text7.Margins = new StiMargins(0, 0, 0, 0);
            Text7.TextBrush = new StiSolidBrush(Color.Black);
            Text7.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text8
            // 
            Text8 = new StiText();
            Text8.ClientRectangle = new RectangleD(2.6, 1.4, 1.6, 1.4);
            Text8.Guid = "e1c088a1678e4998ab0a6e4622d93435";
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
            // Text10
            // 
            Text10 = new StiText();
            Text10.ClientRectangle = new RectangleD(4.2, 1.4, 3.4, 1.4);
            Text10.Guid = "d70ddb083d5840f98a89b3de3d8ddead";
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
            // Text12
            // 
            Text12 = new StiText();
            Text12.ClientRectangle = new RectangleD(7.6, 1.4, 3.4, 1.4);
            Text12.Guid = "407fac1f50714e4fba84b0d106c07ef1";
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
            // Text15
            // 
            Text15 = new StiText();
            Text15.ClientRectangle = new RectangleD(11, 1.4, 4.2, 1.4);
            Text15.HorAlignment = StiTextHorAlignment.Center;
            Text15.Name = "Text15";
            Text15.GetValue += new StiGetValueEventHandler(Text15__GetValue);
            Text15.VertAlignment = StiVertAlignment.Center;
            Text15.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text15.Brush = new StiSolidBrush(Color.Transparent);
            Text15.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            Text15.Guid = null;
            Text15.Interaction = null;
            Text15.Margins = new StiMargins(0, 0, 0, 0);
            Text15.TextBrush = new StiSolidBrush(Color.Black);
            Text15.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text17
            // 
            Text17 = new StiText();
            Text17.ClientRectangle = new RectangleD(15.2, 1.4, 1.4, 1.4);
            Text17.HorAlignment = StiTextHorAlignment.Center;
            Text17.Name = "Text17";
            Text17.GetValue += new StiGetValueEventHandler(Text17__GetValue);
            Text17.VertAlignment = StiVertAlignment.Center;
            Text17.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text17.Brush = new StiSolidBrush(Color.Transparent);
            Text17.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            Text17.Guid = null;
            Text17.Interaction = null;
            Text17.Margins = new StiMargins(0, 0, 0, 0);
            Text17.TextBrush = new StiSolidBrush(Color.Black);
            Text17.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text19
            // 
            Text19 = new StiText();
            Text19.ClientRectangle = new RectangleD(16.6, 1.4, 1.4, 1.4);
            Text19.HorAlignment = StiTextHorAlignment.Center;
            Text19.Name = "Text19";
            Text19.GetValue += new StiGetValueEventHandler(Text19__GetValue);
            Text19.VertAlignment = StiVertAlignment.Center;
            Text19.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text19.Brush = new StiSolidBrush(Color.Transparent);
            Text19.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            Text19.Guid = null;
            Text19.Interaction = null;
            Text19.Margins = new StiMargins(0, 0, 0, 0);
            Text19.TextBrush = new StiSolidBrush(Color.Black);
            Text19.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text21
            // 
            Text21 = new StiText();
            Text21.ClientRectangle = new RectangleD(18, 1.4, 1.4, 1.4);
            Text21.HorAlignment = StiTextHorAlignment.Center;
            Text21.Name = "Text21";
            Text21.GetValue += new StiGetValueEventHandler(Text21__GetValue);
            Text21.VertAlignment = StiVertAlignment.Center;
            Text21.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text21.Brush = new StiSolidBrush(Color.Transparent);
            Text21.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            Text21.Guid = null;
            Text21.Interaction = null;
            Text21.Margins = new StiMargins(0, 0, 0, 0);
            Text21.TextBrush = new StiSolidBrush(Color.Black);
            Text21.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text22
            // 
            Text22 = new StiText();
            Text22.ClientRectangle = new RectangleD(0, 0.6, 9.4, 0.6);
            Text22.Guid = "96f9b8a2b3c7430e9a037dcecb6ad99f";
            Text22.Name = "Text22";
            Text22.GetValue += new StiGetValueEventHandler(Text22__GetValue);
            Text22.VertAlignment = StiVertAlignment.Center;
            Text22.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text22.Brush = new StiSolidBrush(Color.Transparent);
            Text22.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            Text22.Interaction = null;
            Text22.Margins = new StiMargins(0, 0, 0, 0);
            Text22.TextBrush = new StiSolidBrush(Color.Black);
            Text22.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            HeaderVW_ProductDistributionHeader.Guid = null;
            HeaderVW_ProductDistributionHeader.Interaction = null;
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
            // DataVW_ProductDistributionHeader
            // 
            DataVW_ProductDistributionHeader = new StiDataBand();
            DataVW_ProductDistributionHeader.ClientRectangle = new RectangleD(0, 5.6, 20, 0.8);
            DataVW_ProductDistributionHeader.DataSourceName = "VW_ProductDistributionDetailList";
            DataVW_ProductDistributionHeader.Name = "DataVW_ProductDistributionHeader";
            DataVW_ProductDistributionHeader.Sort = new[] {
                    "ASC",
                    "ProductDistributionID",
                    "ASC",
                    "FromBranchName",
                    "ASC",
                    "ToBranchName",
                    "ASC",
                    "OrdinalNumber"};
            DataVW_ProductDistributionHeader.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataVW_ProductDistributionHeader.Brush = new StiSolidBrush(Color.Transparent);
            DataVW_ProductDistributionHeader.BusinessObjectGuid = null;
            // 
            // DataVW_PurchaseOrderHeader_rowguid
            // 
            DataVW_PurchaseOrderHeader_rowguid = new StiText();
            DataVW_PurchaseOrderHeader_rowguid.CanGrow = true;
            DataVW_PurchaseOrderHeader_rowguid.ClientRectangle = new RectangleD(0, 0, 1, 0.8);
            DataVW_PurchaseOrderHeader_rowguid.GrowToHeight = true;
            DataVW_PurchaseOrderHeader_rowguid.Guid = "dde9bc0d2eda4077b611438cc58d5551";
            DataVW_PurchaseOrderHeader_rowguid.Name = "DataVW_PurchaseOrderHeader_rowguid";
            DataVW_PurchaseOrderHeader_rowguid.GetValue += new StiGetValueEventHandler(DataVW_PurchaseOrderHeader_rowguid__GetValue);
            DataVW_PurchaseOrderHeader_rowguid.VertAlignment = StiVertAlignment.Center;
            DataVW_PurchaseOrderHeader_rowguid.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataVW_PurchaseOrderHeader_rowguid.Brush = new StiSolidBrush(Color.Transparent);
            DataVW_PurchaseOrderHeader_rowguid.Font = new Font("BPG Glaho Arial", 8F);
            DataVW_PurchaseOrderHeader_rowguid.Interaction = null;
            DataVW_PurchaseOrderHeader_rowguid.Margins = new StiMargins(0, 0, 0, 0);
            DataVW_PurchaseOrderHeader_rowguid.TextBrush = new StiSolidBrush(Color.Black);
            DataVW_PurchaseOrderHeader_rowguid.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // CheckBox1
            // 
            CheckBox1 = new StiCheckBox();
            CheckBox1.GetChecked += new StiValueEventHandler(CheckBox1__GetChecked);
            CheckBox1.ClientRectangle = new RectangleD(19.4, 0, 0.6, 0.8);
            CheckBox1.ContourColor = Color.Black;
            CheckBox1.GrowToHeight = true;
            CheckBox1.Guid = "3c420af9a1a54d288b628eb0ce164a84";
            CheckBox1.Name = "CheckBox1";
            CheckBox1.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            CheckBox1.Brush = new StiSolidBrush(Color.Transparent);
            CheckBox1.Interaction = null;
            CheckBox1.TextBrush = new StiSolidBrush(Color.Black);
            // 
            // Text6
            // 
            Text6 = new StiText();
            Text6.ClientRectangle = new RectangleD(1, 0, 1.6, 0.8);
            Text6.GrowToHeight = true;
            Text6.HorAlignment = StiTextHorAlignment.Center;
            Text6.Name = "Text6";
            Text6.GetValue += new StiGetValueEventHandler(Text6__GetValue);
            Text6.VertAlignment = StiVertAlignment.Center;
            Text6.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text6.Brush = new StiSolidBrush(Color.Transparent);
            Text6.Font = new Font("BPG Glaho Arial", 8F);
            Text6.Guid = null;
            Text6.Interaction = null;
            Text6.Margins = new StiMargins(0, 0, 0, 0);
            Text6.TextBrush = new StiSolidBrush(Color.Black);
            Text6.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text9
            // 
            Text9 = new StiText();
            Text9.ClientRectangle = new RectangleD(2.6, 0, 1.6, 0.8);
            Text9.Name = "Text9";
            Text9.GetValue += new StiGetValueEventHandler(Text9__GetValue);
            Text9.VertAlignment = StiVertAlignment.Center;
            Text9.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text9.Brush = new StiSolidBrush(Color.Transparent);
            Text9.Font = new Font("BPG Glaho Arial", 8F);
            Text9.Guid = null;
            Text9.Interaction = null;
            Text9.Margins = new StiMargins(0, 0, 0, 0);
            Text9.TextBrush = new StiSolidBrush(Color.Black);
            Text9.TextFormat = new StiDateFormatService("d", " ");
            Text9.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text11
            // 
            Text11 = new StiText();
            Text11.ClientRectangle = new RectangleD(4.2, 0, 3.4, 0.8);
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
            Text11.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text13
            // 
            Text13 = new StiText();
            Text13.ClientRectangle = new RectangleD(7.6, 0, 3.4, 0.8);
            Text13.Guid = "cfc687a6bf674381a888bafd19ffccb3";
            Text13.Name = "Text13";
            Text13.GetValue += new StiGetValueEventHandler(Text13__GetValue);
            Text13.VertAlignment = StiVertAlignment.Center;
            Text13.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text13.Brush = new StiSolidBrush(Color.Transparent);
            Text13.Font = new Font("BPG Glaho Arial", 8F);
            Text13.Interaction = null;
            Text13.Margins = new StiMargins(0, 0, 0, 0);
            Text13.TextBrush = new StiSolidBrush(Color.Black);
            Text13.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text14
            // 
            Text14 = new StiText();
            Text14.ClientRectangle = new RectangleD(11, 0, 4.2, 0.8);
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
            Text14.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text16
            // 
            Text16 = new StiText();
            Text16.ClientRectangle = new RectangleD(15.2, 0, 1.4, 0.8);
            Text16.HorAlignment = StiTextHorAlignment.Right;
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
            Text16.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text18
            // 
            Text18 = new StiText();
            Text18.ClientRectangle = new RectangleD(16.6, 0, 1.4, 0.8);
            Text18.HorAlignment = StiTextHorAlignment.Right;
            Text18.Name = "Text18";
            Text18.GetValue += new StiGetValueEventHandler(Text18__GetValue);
            Text18.VertAlignment = StiVertAlignment.Center;
            Text18.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text18.Brush = new StiSolidBrush(Color.Transparent);
            Text18.Font = new Font("BPG Glaho Arial", 8F);
            Text18.Guid = null;
            Text18.Interaction = null;
            Text18.Margins = new StiMargins(0, 0, 0, 0);
            Text18.TextBrush = new StiSolidBrush(Color.Black);
            Text18.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text20
            // 
            Text20 = new StiText();
            Text20.ClientRectangle = new RectangleD(18, 0, 1.4, 0.8);
            Text20.HorAlignment = StiTextHorAlignment.Right;
            Text20.Name = "Text20";
            Text20.GetValue += new StiGetValueEventHandler(Text20__GetValue);
            Text20.VertAlignment = StiVertAlignment.Center;
            Text20.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text20.Brush = new StiSolidBrush(Color.Transparent);
            Text20.Font = new Font("BPG Glaho Arial", 8F);
            Text20.Guid = null;
            Text20.Interaction = null;
            Text20.Margins = new StiMargins(0, 0, 0, 0);
            Text20.TextBrush = new StiSolidBrush(Color.Black);
            Text20.TextFormat = new StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            Text20.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            DataVW_ProductDistributionHeader.DataRelationName = null;
            DataVW_ProductDistributionHeader.Guid = null;
            DataVW_ProductDistributionHeader.Interaction = null;
            DataVW_ProductDistributionHeader.MasterComponent = null;
            // 
            // GroupFooterBand1
            // 
            GroupFooterBand1 = new StiGroupFooterBand();
            GroupFooterBand1.ClientRectangle = new RectangleD(0, 7.2, 20, 0.8);
            GroupFooterBand1.Name = "GroupFooterBand1";
            GroupFooterBand1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            GroupFooterBand1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text24
            // 
            Text24 = new StiText();
            Text24.ClientRectangle = new RectangleD(18, 0, 1.4, 0.6);
            Text24.HorAlignment = StiTextHorAlignment.Right;
            Text24.Name = "Text24";
            // 
            // Text24_Sum
            // 
            Text24.GetValue += new StiGetValueEventHandler(Text24__GetValue);
            Text24.VertAlignment = StiVertAlignment.Center;
            Text24.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text24.Brush = new StiSolidBrush(Color.Transparent);
            Text24.Font = new Font("BPG Glaho Arial", 8F);
            Text24.Guid = null;
            Text24.Interaction = null;
            Text24.Margins = new StiMargins(0, 0, 0, 0);
            Text24.TextBrush = new StiSolidBrush(Color.Black);
            Text24.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            Text24.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            GroupFooterBand1.Guid = null;
            GroupFooterBand1.Interaction = null;
            Page1.ExcelSheetValue = null;
            Page1.Interaction = null;
            Page1.Margins = new StiMargins(0.5, 0.5, 0.5, 0.5);
            Page1_Watermark = new StiWatermark();
            Page1_Watermark.Font = new Font("Arial", 100F);
            Page1_Watermark.Image = null;
            Page1_Watermark.TextBrush = new StiSolidBrush(Color.FromArgb(50, 0, 0, 0));
            RptProductDistributionDetailList_PrinterSettings = new StiPrinterSettings();
            PrinterSettings = RptProductDistributionDetailList_PrinterSettings;
            Page1.Report = this;
            Page1.Watermark = Page1_Watermark;
            HeaderVW_ProductDistributionHeader.Page = Page1;
            HeaderVW_ProductDistributionHeader.Parent = Page1;
            Text1.Page = Page1;
            Text1.Parent = HeaderVW_ProductDistributionHeader;
            Text2.Page = Page1;
            Text2.Parent = HeaderVW_ProductDistributionHeader;
            Text3.Page = Page1;
            Text3.Parent = HeaderVW_ProductDistributionHeader;
            Text4.Page = Page1;
            Text4.Parent = HeaderVW_ProductDistributionHeader;
            Text5.Page = Page1;
            Text5.Parent = HeaderVW_ProductDistributionHeader;
            HeaderVW_PurchaseOrderHeader_rowguid.Page = Page1;
            HeaderVW_PurchaseOrderHeader_rowguid.Parent = HeaderVW_ProductDistributionHeader;
            HeaderVW_PurchaseOrderHeader_Status.Page = Page1;
            HeaderVW_PurchaseOrderHeader_Status.Parent = HeaderVW_ProductDistributionHeader;
            Text7.Page = Page1;
            Text7.Parent = HeaderVW_ProductDistributionHeader;
            Text8.Page = Page1;
            Text8.Parent = HeaderVW_ProductDistributionHeader;
            Text10.Page = Page1;
            Text10.Parent = HeaderVW_ProductDistributionHeader;
            Text12.Page = Page1;
            Text12.Parent = HeaderVW_ProductDistributionHeader;
            Text15.Page = Page1;
            Text15.Parent = HeaderVW_ProductDistributionHeader;
            Text17.Page = Page1;
            Text17.Parent = HeaderVW_ProductDistributionHeader;
            Text19.Page = Page1;
            Text19.Parent = HeaderVW_ProductDistributionHeader;
            Text21.Page = Page1;
            Text21.Parent = HeaderVW_ProductDistributionHeader;
            Text22.Page = Page1;
            Text22.Parent = HeaderVW_ProductDistributionHeader;
            GroupHeaderBand1.Page = Page1;
            GroupHeaderBand1.Parent = Page1;
            DataVW_ProductDistributionHeader.Page = Page1;
            DataVW_ProductDistributionHeader.Parent = Page1;
            DataVW_PurchaseOrderHeader_rowguid.Page = Page1;
            DataVW_PurchaseOrderHeader_rowguid.Parent = DataVW_ProductDistributionHeader;
            CheckBox1.Page = Page1;
            CheckBox1.Parent = DataVW_ProductDistributionHeader;
            Text6.Page = Page1;
            Text6.Parent = DataVW_ProductDistributionHeader;
            Text9.Page = Page1;
            Text9.Parent = DataVW_ProductDistributionHeader;
            Text11.Page = Page1;
            Text11.Parent = DataVW_ProductDistributionHeader;
            Text13.Page = Page1;
            Text13.Parent = DataVW_ProductDistributionHeader;
            Text14.Page = Page1;
            Text14.Parent = DataVW_ProductDistributionHeader;
            Text16.Page = Page1;
            Text16.Parent = DataVW_ProductDistributionHeader;
            Text18.Page = Page1;
            Text18.Parent = DataVW_ProductDistributionHeader;
            Text20.Page = Page1;
            Text20.Parent = DataVW_ProductDistributionHeader;
            GroupFooterBand1.Page = Page1;
            GroupFooterBand1.Parent = Page1;
            Text24.Page = Page1;
            Text24.Parent = GroupFooterBand1;
            GroupHeaderBand1.BeginRender += new EventHandler(GroupHeaderBand1__BeginRender);
            GroupHeaderBand1.EndRender += new EventHandler(GroupHeaderBand1__EndRender);
            DataVW_ProductDistributionHeader.Rendering += new EventHandler(DataVW_ProductDistributionHeader__Rendering);
            AggregateFunctions = new object[] {
                    Text24_Sum};
            // 
            // Add to HeaderVW_ProductDistributionHeader.Components
            // 
            HeaderVW_ProductDistributionHeader.Components.Clear();
            HeaderVW_ProductDistributionHeader.Components.AddRange(new StiComponent[] {
                        Text1,
                        Text2,
                        Text3,
                        Text4,
                        Text5,
                        HeaderVW_PurchaseOrderHeader_rowguid,
                        HeaderVW_PurchaseOrderHeader_Status,
                        Text7,
                        Text8,
                        Text10,
                        Text12,
                        Text15,
                        Text17,
                        Text19,
                        Text21,
                        Text22});
            // 
            // Add to DataVW_ProductDistributionHeader.Components
            // 
            DataVW_ProductDistributionHeader.Components.Clear();
            DataVW_ProductDistributionHeader.Components.AddRange(new StiComponent[] {
                        DataVW_PurchaseOrderHeader_rowguid,
                        CheckBox1,
                        Text6,
                        Text9,
                        Text11,
                        Text13,
                        Text14,
                        Text16,
                        Text18,
                        Text20});
            // 
            // Add to GroupFooterBand1.Components
            // 
            GroupFooterBand1.Components.Clear();
            GroupFooterBand1.Components.AddRange(new StiComponent[] {
                        Text24});
            // 
            // Add to Page1.Components
            // 
            Page1.Components.Clear();
            Page1.Components.AddRange(new StiComponent[] {
                        HeaderVW_ProductDistributionHeader,
                        GroupHeaderBand1,
                        DataVW_ProductDistributionHeader,
                        GroupFooterBand1});
            // 
            // Add to Pages
            // 
            Pages.Clear();
            Pages.AddRange(new[] {
                        Page1});
            VW_ProductDistributionDetailList.Columns.AddRange(new[] {
                        new StiDataColumn("OrdinalNumber", "OrdinalNumber", "OrdinalNumber", typeof(short)),
                        new StiDataColumn("ProductDistributionID", "ProductDistributionID", "ProductDistributionID", typeof(int)),
                        new StiDataColumn("StartDate", "StartDate", "StartDate", typeof(DateTime)),
                        new StiDataColumn("FromBranchName", "FromBranchName", "FromBranchName", typeof(string)),
                        new StiDataColumn("ToBranchName", "ToBranchName", "ToBranchName", typeof(string)),
                        new StiDataColumn("MedicamentName", "MedicamentName", "MedicamentName", typeof(string)),
                        new StiDataColumn("DistributeQty", "DistributeQty", "DistributeQty", typeof(decimal)),
                        new StiDataColumn("UnitPrice", "UnitPrice", "UnitPrice", typeof(decimal)),
                        new StiDataColumn("LineTotal", "LineTotal", "LineTotal", typeof(decimal)),
                        new StiDataColumn("Status", "Status", "Status", typeof(byte))});
            DataSources.Add(VW_ProductDistributionDetailList);
            T_RptHeader.Columns.AddRange(new[] {
                        new StiDataColumn("Date1", "Date1", "Date1", typeof(DateTime)),
                        new StiDataColumn("Date2", "Date2", "Date2", typeof(DateTime))});
            DataSources.Add(T_RptHeader);
        }

        #region DataSource VW_ProductDistributionDetailList
        public class VW_ProductDistributionDetailListDataSource : StiDataTableSource
        {

            public VW_ProductDistributionDetailListDataSource() :
                base("DS_ProductDistributionDetailList.VW_ProductDistributionDetailList", "VW_ProductDistributionDetailList")
            {
            }

            public virtual short OrdinalNumber
            {
                get
                {
                    return ((short)(ChangeType(this["OrdinalNumber"], typeof(short), true)));
                }
            }

            public virtual int ProductDistributionID
            {
                get
                {
                    return ((int)(ChangeType(this["ProductDistributionID"], typeof(int), true)));
                }
            }

            public virtual DateTime StartDate
            {
                get
                {
                    return ((DateTime)(ChangeType(this["StartDate"], typeof(DateTime), true)));
                }
            }

            public virtual string FromBranchName
            {
                get
                {
                    return ((string)(ChangeType(this["FromBranchName"], typeof(string), true)));
                }
            }

            public virtual string ToBranchName
            {
                get
                {
                    return ((string)(ChangeType(this["ToBranchName"], typeof(string), true)));
                }
            }

            public virtual string MedicamentName
            {
                get
                {
                    return ((string)(ChangeType(this["MedicamentName"], typeof(string), true)));
                }
            }

            public virtual decimal DistributeQty
            {
                get
                {
                    return ((decimal)(ChangeType(this["DistributeQty"], typeof(decimal), true)));
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

            public virtual byte Status
            {
                get
                {
                    return ((byte)(ChangeType(this["Status"], typeof(byte), true)));
                }
            }
        }
        #endregion DataSource VW_ProductDistributionDetailList

        #region DataSource T_RptHeader
        public class T_RptHeaderDataSource : StiDataTableSource
        {

            public T_RptHeaderDataSource() :
                base("DS_ProductDistributionDetailList.T_RptHeader", "T_RptHeader")
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
