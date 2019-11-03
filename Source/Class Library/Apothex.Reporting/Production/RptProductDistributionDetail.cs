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

    public class RptProductDistributionDetail : StiReport
    {

        public RptProductDistributionDetail()
        {
            InitializeComponent();
        }
        #region StiReport Designer generated code - do not modify
        public StiDataRelation ParentSP_GetProductDistributionHeader;
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
        public StiDataBand DataSP_GetProductDistributionHeader;
        public StiPanel Panel1;
        public StiText Text2;
        public StiText Text4;
        public StiText Text1;
        public StiText Text3;
        public StiText Text5;
        public StiPanel Panel5;
        public StiText Text20;
        public StiText Text21;
        public StiText Text22;
        public StiText Text23;
        public StiText Text24;
        public StiHeaderBand HeaderSP_GetProductDistributionDetail;
        public StiPanel Panel2;
        public StiText Text7;
        public StiText Text9;
        public StiText Text11;
        public StiText Text13;
        public StiText Text14;
        public StiPanel Panel6;
        public StiText Text25;
        public StiText Text26;
        public StiText Text27;
        public StiText Text28;
        public StiText Text29;
        public StiDataBand DataSP_GetProductDistributionDetail;
        public StiPanel Panel3;
        public StiText Text6;
        public StiText Text8;
        public StiText Text10;
        public StiText Text12;
        public StiText Text15;
        public StiPanel Panel7;
        public StiText Text30;
        public StiText Text31;
        public StiText Text32;
        public StiText Text33;
        public StiText Text34;
        public StiFooterBand FooterSP_GetProductDistributionDetail;
        public StiPanel Panel4;
        public StiText Text16;
        public StiSumDecimalFunctionService Text16_Sum;
        public StiText Text17;
        public StiText Text18;
        public StiText Text19;
        public StiHorizontalLinePrimitive HorizontalLinePrimitive1;
        public StiHorizontalLinePrimitive HorizontalLinePrimitive2;
        public StiPanel Panel8;
        public StiText Text35;
        public StiSumDecimalFunctionService Text35_Sum;
        public StiText Text36;
        public StiText Text37;
        public StiText Text38;
        public StiHorizontalLinePrimitive HorizontalLinePrimitive3;
        public StiHorizontalLinePrimitive HorizontalLinePrimitive4;
        public StiVerticalLinePrimitive VerticalLinePrimitive1;
        public StiEndPointPrimitive EndPointPrimitive1;
        public StiStartPointPrimitive StartPointPrimitive1;
        public StiWatermark Page1_Watermark;
        public StiPrinterSettings RptProductDistributionDetail_PrinterSettings;
        public SP_GetProductDistributionDetailDataSource SP_GetProductDistributionDetail;
        public SP_GetProductDistributionHeaderDataSource SP_GetProductDistributionHeader;

        public void Text2__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetProductDistributionHeader.FromBranchName, true);
        }

        public void Text4__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetProductDistributionHeader.ToBranchName, true);
        }

        public void Text1__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "შიდა გადაცემის ზედდებული № " + ToString(sender, SP_GetProductDistributionHeader.ProductDistributionID, true) + "     თარიღი: " + ToString(sender, Format("{0:yyyy.MM.dd}", SP_GetProductDistributionHeader.StartDate), true);
        }

        public void Text3__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "გასცა ფილიალმა:";
        }

        public void Text5__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "მიიღო ფილიალმა:";
        }

        public void Text20__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetProductDistributionHeader.FromBranchName, true);
        }

        public void Text21__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetProductDistributionHeader.ToBranchName, true);
        }

        public void Text22__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "შიდა გადაცემის ზედდებული № " + ToString(sender, SP_GetProductDistributionHeader.ProductDistributionID, true) + "     თარიღი: " + ToString(sender, Format("{0:yyyy.MM.dd}", SP_GetProductDistributionHeader.StartDate), true);
        }

        public void Text23__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "გასცა ფილიალმა:";
        }

        public void Text24__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "მიიღო ფილიალმა:";
        }

        public void Text7__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "№";
        }

        public void Text9__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "საქონლის დასახელება";
        }

        public void Text11__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "რაოდ.";
        }

        public void Text13__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ფასი";
        }

        public void Text14__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "თანხა";
        }

        public void Text25__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "№";
        }

        public void Text26__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "საქონლის დასახელება";
        }

        public void Text27__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "რაოდ.";
        }

        public void Text28__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ფასი";
        }

        public void Text29__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "თანხა";
        }

        public void Text6__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Line, true);
        }

        public void Text8__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetProductDistributionDetail.MedicamentName, true);
        }

        public void Text10__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text10.TextFormat.Format(CheckExcelValue(sender, SP_GetProductDistributionDetail.DistributeQty));
        }

        public void Text12__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text12.TextFormat.Format(CheckExcelValue(sender, SP_GetProductDistributionDetail.UnitPrice));
        }

        public void Text15__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text15.TextFormat.Format(CheckExcelValue(sender, SP_GetProductDistributionDetail.LineTotal));
        }

        public void Text30__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Line, true);
        }

        public void Text31__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetProductDistributionDetail.MedicamentName, true);
        }

        public void Text32__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text32.TextFormat.Format(CheckExcelValue(sender, SP_GetProductDistributionDetail.DistributeQty));
        }

        public void Text33__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text33.TextFormat.Format(CheckExcelValue(sender, SP_GetProductDistributionDetail.UnitPrice));
        }

        public void Text34__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text34.TextFormat.Format(CheckExcelValue(sender, SP_GetProductDistributionDetail.LineTotal));
        }

        public void Text16__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(SP_GetProductDistributionDetail.LineTotal)}";
            e.StoreToPrinted = true;
        }

        public String Text16_GetValue_End(StiComponent sender)
        {
            return Text16.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text16_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void Text17__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "სულ:";
        }

        public void Text18__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ჩააბარა:";
        }

        public void Text19__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "მიიღო:";
        }

        public void Text35__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(SP_GetProductDistributionDetail.LineTotal)}";
            e.StoreToPrinted = true;
        }

        public String Text35_GetValue_End(StiComponent sender)
        {
            return Text35.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text35_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void Text36__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "სულ:";
        }

        public void Text37__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ჩააბარა:";
        }

        public void Text38__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "მიიღო:";
        }

        public void DataSP_GetProductDistributionDetail__BeginRender(object sender, EventArgs e)
        {
            Text16_Sum.Init();
            Text16.TextValue = "";
            Text35_Sum.Init();
            Text35.TextValue = "";
        }

        public void DataSP_GetProductDistributionDetail__EndRender(object sender, EventArgs e)
        {
            Text16.SetText(new StiGetValue(Text16_GetValue_End));
            Text35.SetText(new StiGetValue(Text35_GetValue_End));
        }

        public void DataSP_GetProductDistributionDetail__Rendering(object sender, EventArgs e)
        {
            Text16_Sum.CalcItem(SP_GetProductDistributionDetail.LineTotal);
            Text35_Sum.CalcItem(SP_GetProductDistributionDetail.LineTotal);
        }

        private void InitializeComponent()
        {
            SP_GetProductDistributionHeader = new SP_GetProductDistributionHeaderDataSource();
            SP_GetProductDistributionDetail = new SP_GetProductDistributionDetailDataSource();
            ParentSP_GetProductDistributionHeader = new StiDataRelation("SP_GetProductDistributionHeader_SP_GetProductDistributionDetail", "SP_GetProductDistributionHeader", "SP_GetProductDistributionHeader", SP_GetProductDistributionHeader, SP_GetProductDistributionDetail, new[] {
                        "ProductDistributionID"}, new[] {
                        "ProductDistributionID"});
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
            Text35_Sum = new StiSumDecimalFunctionService();
            Text16_Sum = new StiSumDecimalFunctionService();
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
            ReportAlias = "Rpt Product Distribution Detail";
            ReportAuthor = "Programmer.GE";
            // 
            // ReportChanged
            // 
            ReportChanged = new DateTime(2010, 4, 13, 20, 41, 6, 36);
            // 
            // ReportCreated
            // 
            ReportCreated = new DateTime(2009, 2, 8, 19, 58, 55, 0);
            ReportDescription = "პროდუქციის დისტრიბუციის დეტალური რეპორტი";
            ReportFile = "D:\\User\\Documents\\Projects\\Apothex\\Source\\Class Library\\Apothex.Reporting\\Product" +
"ion\\RptProductDistributionDetail.mrt";
            ReportGuid = "d79f5ad847a64017be06209aa10fbc2d";
            ReportName = "RptProductDistributionDetail";
            ReportUnit = StiReportUnitType.Centimeters;
            ScriptLanguage = StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            Page1 = new StiPage();
            Page1.Guid = "2a54d7263bcd41b99fe3bdaf6ea00af2";
            Page1.Name = "Page1";
            Page1.Orientation = StiPageOrientation.Landscape;
            Page1.PageHeight = 21;
            Page1.PageWidth = 29.7;
            Page1.PaperSize = PaperKind.A4;
            Page1.Border = new StiBorder(StiBorderSides.None, Color.Black, 2, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Page1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // DataSP_GetProductDistributionHeader
            // 
            DataSP_GetProductDistributionHeader = new StiDataBand();
            DataSP_GetProductDistributionHeader.ClientRectangle = new RectangleD(0, 0.4, 27.7, 3.4);
            DataSP_GetProductDistributionHeader.DataSourceName = "SP_GetProductDistributionHeader";
            DataSP_GetProductDistributionHeader.Name = "DataSP_GetProductDistributionHeader";
            DataSP_GetProductDistributionHeader.Sort = new String[0];
            DataSP_GetProductDistributionHeader.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetProductDistributionHeader.Brush = new StiSolidBrush(Color.Transparent);
            DataSP_GetProductDistributionHeader.BusinessObjectGuid = null;
            // 
            // Panel1
            // 
            Panel1 = new StiPanel();
            Panel1.ClientRectangle = new RectangleD(0, 0, 13.6, 3);
            Panel1.Name = "Panel1";
            Panel1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Panel1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text2
            // 
            Text2 = new StiText();
            Text2.ClientRectangle = new RectangleD(3.4, 1, 10.2, 0.6);
            Text2.Name = "Text2";
            Text2.GetValue += new StiGetValueEventHandler(Text2__GetValue);
            Text2.VertAlignment = StiVertAlignment.Center;
            Text2.Border = new StiBorder(StiBorderSides.Bottom, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text2.Brush = new StiSolidBrush(Color.Transparent);
            Text2.Font = new Font("BPG Glaho Arial", 10F);
            Text2.Guid = null;
            Text2.Interaction = null;
            Text2.Margins = new StiMargins(0, 0, 0, 0);
            Text2.TextBrush = new StiSolidBrush(Color.Black);
            Text2.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text4
            // 
            Text4 = new StiText();
            Text4.ClientRectangle = new RectangleD(3.4, 2.2, 10.2, 0.6);
            Text4.Name = "Text4";
            Text4.GetValue += new StiGetValueEventHandler(Text4__GetValue);
            Text4.VertAlignment = StiVertAlignment.Center;
            Text4.Border = new StiBorder(StiBorderSides.Bottom, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text4.Brush = new StiSolidBrush(Color.Transparent);
            Text4.Font = new Font("BPG Glaho Arial", 10F);
            Text4.Guid = null;
            Text4.Interaction = null;
            Text4.Margins = new StiMargins(0, 0, 0, 0);
            Text4.TextBrush = new StiSolidBrush(Color.Black);
            Text4.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text1
            // 
            Text1 = new StiText();
            Text1.ClientRectangle = new RectangleD(0, 0, 13.6, 0.6);
            Text1.HorAlignment = StiTextHorAlignment.Center;
            Text1.Name = "Text1";
            Text1.GetValue += new StiGetValueEventHandler(Text1__GetValue);
            Text1.VertAlignment = StiVertAlignment.Center;
            Text1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text1.Brush = new StiSolidBrush(Color.Transparent);
            Text1.Font = new Font("BPG Glaho Arial", 10F);
            Text1.Guid = null;
            Text1.Interaction = null;
            Text1.Margins = new StiMargins(0, 0, 0, 0);
            Text1.TextBrush = new StiSolidBrush(Color.Black);
            Text1.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text3
            // 
            Text3 = new StiText();
            Text3.ClientRectangle = new RectangleD(0, 1, 3.4, 0.6);
            Text3.HorAlignment = StiTextHorAlignment.Right;
            Text3.Name = "Text3";
            Text3.GetValue += new StiGetValueEventHandler(Text3__GetValue);
            Text3.VertAlignment = StiVertAlignment.Center;
            Text3.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text3.Brush = new StiSolidBrush(Color.Transparent);
            Text3.Font = new Font("BPG Glaho Arial", 10F);
            Text3.Guid = null;
            Text3.Interaction = null;
            Text3.Margins = new StiMargins(0, 0, 0, 0);
            Text3.TextBrush = new StiSolidBrush(Color.Black);
            Text3.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text5
            // 
            Text5 = new StiText();
            Text5.ClientRectangle = new RectangleD(0, 2.2, 3.4, 0.6);
            Text5.HorAlignment = StiTextHorAlignment.Right;
            Text5.Name = "Text5";
            Text5.GetValue += new StiGetValueEventHandler(Text5__GetValue);
            Text5.VertAlignment = StiVertAlignment.Center;
            Text5.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text5.Brush = new StiSolidBrush(Color.Transparent);
            Text5.Font = new Font("BPG Glaho Arial", 10F);
            Text5.Guid = null;
            Text5.Interaction = null;
            Text5.Margins = new StiMargins(0, 0, 0, 0);
            Text5.TextBrush = new StiSolidBrush(Color.Black);
            Text5.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            Panel1.Guid = null;
            Panel1.Interaction = null;
            // 
            // Panel5
            // 
            Panel5 = new StiPanel();
            Panel5.ClientRectangle = new RectangleD(14, 0, 13.6, 3);
            Panel5.Guid = "bae586ad5dcd4e5fbcc0e528a1fa91c3";
            Panel5.Name = "Panel5";
            Panel5.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Panel5.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text20
            // 
            Text20 = new StiText();
            Text20.ClientRectangle = new RectangleD(3.4, 1, 10.2, 0.6);
            Text20.Guid = "954c8196b9d64417a1be31743baec7bb";
            Text20.Name = "Text20";
            Text20.GetValue += new StiGetValueEventHandler(Text20__GetValue);
            Text20.VertAlignment = StiVertAlignment.Center;
            Text20.Border = new StiBorder(StiBorderSides.Bottom, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text20.Brush = new StiSolidBrush(Color.Transparent);
            Text20.Font = new Font("BPG Glaho Arial", 10F);
            Text20.Interaction = null;
            Text20.Margins = new StiMargins(0, 0, 0, 0);
            Text20.TextBrush = new StiSolidBrush(Color.Black);
            Text20.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text21
            // 
            Text21 = new StiText();
            Text21.ClientRectangle = new RectangleD(3.4, 2.2, 10.2, 0.6);
            Text21.Guid = "c7c48dba850b4a5d855a58a9bee28269";
            Text21.Name = "Text21";
            Text21.GetValue += new StiGetValueEventHandler(Text21__GetValue);
            Text21.VertAlignment = StiVertAlignment.Center;
            Text21.Border = new StiBorder(StiBorderSides.Bottom, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text21.Brush = new StiSolidBrush(Color.Transparent);
            Text21.Font = new Font("BPG Glaho Arial", 10F);
            Text21.Interaction = null;
            Text21.Margins = new StiMargins(0, 0, 0, 0);
            Text21.TextBrush = new StiSolidBrush(Color.Black);
            Text21.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text22
            // 
            Text22 = new StiText();
            Text22.ClientRectangle = new RectangleD(0, 0, 13.6, 0.6);
            Text22.Guid = "12efe353e0494870bea24106fa313bfe";
            Text22.HorAlignment = StiTextHorAlignment.Center;
            Text22.Name = "Text22";
            Text22.GetValue += new StiGetValueEventHandler(Text22__GetValue);
            Text22.VertAlignment = StiVertAlignment.Center;
            Text22.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text22.Brush = new StiSolidBrush(Color.Transparent);
            Text22.Font = new Font("BPG Glaho Arial", 10F);
            Text22.Interaction = null;
            Text22.Margins = new StiMargins(0, 0, 0, 0);
            Text22.TextBrush = new StiSolidBrush(Color.Black);
            Text22.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text23
            // 
            Text23 = new StiText();
            Text23.ClientRectangle = new RectangleD(0, 1, 3.4, 0.6);
            Text23.Guid = "aa420c347f864a20ac67dd64d3eacfcc";
            Text23.HorAlignment = StiTextHorAlignment.Right;
            Text23.Name = "Text23";
            Text23.GetValue += new StiGetValueEventHandler(Text23__GetValue);
            Text23.VertAlignment = StiVertAlignment.Center;
            Text23.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text23.Brush = new StiSolidBrush(Color.Transparent);
            Text23.Font = new Font("BPG Glaho Arial", 10F);
            Text23.Interaction = null;
            Text23.Margins = new StiMargins(0, 0, 0, 0);
            Text23.TextBrush = new StiSolidBrush(Color.Black);
            Text23.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text24
            // 
            Text24 = new StiText();
            Text24.ClientRectangle = new RectangleD(0, 2.2, 3.4, 0.6);
            Text24.Guid = "0b1fd64e89584af4b035d3ce152e7a24";
            Text24.HorAlignment = StiTextHorAlignment.Right;
            Text24.Name = "Text24";
            Text24.GetValue += new StiGetValueEventHandler(Text24__GetValue);
            Text24.VertAlignment = StiVertAlignment.Center;
            Text24.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text24.Brush = new StiSolidBrush(Color.Transparent);
            Text24.Font = new Font("BPG Glaho Arial", 10F);
            Text24.Interaction = null;
            Text24.Margins = new StiMargins(0, 0, 0, 0);
            Text24.TextBrush = new StiSolidBrush(Color.Black);
            Text24.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            Panel5.Interaction = null;
            DataSP_GetProductDistributionHeader.Guid = null;
            DataSP_GetProductDistributionHeader.Interaction = null;
            DataSP_GetProductDistributionHeader.MasterComponent = null;
            // 
            // HeaderSP_GetProductDistributionDetail
            // 
            HeaderSP_GetProductDistributionDetail = new StiHeaderBand();
            HeaderSP_GetProductDistributionDetail.ClientRectangle = new RectangleD(0, 4.6, 27.7, 0.8);
            HeaderSP_GetProductDistributionDetail.Name = "HeaderSP_GetProductDistributionDetail";
            HeaderSP_GetProductDistributionDetail.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderSP_GetProductDistributionDetail.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Panel2
            // 
            Panel2 = new StiPanel();
            Panel2.ClientRectangle = new RectangleD(0, 0, 13.6, 0.8);
            Panel2.Name = "Panel2";
            Panel2.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Panel2.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text7
            // 
            Text7 = new StiText();
            Text7.ClientRectangle = new RectangleD(0, 0, 1.2, 0.8);
            Text7.HorAlignment = StiTextHorAlignment.Center;
            Text7.Name = "Text7";
            Text7.GetValue += new StiGetValueEventHandler(Text7__GetValue);
            Text7.VertAlignment = StiVertAlignment.Center;
            Text7.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text7.Brush = new StiSolidBrush(Color.Transparent);
            Text7.Font = new Font("BPG Glaho Arial", 10F);
            Text7.Guid = null;
            Text7.Interaction = null;
            Text7.Margins = new StiMargins(0, 0, 0, 0);
            Text7.TextBrush = new StiSolidBrush(Color.Black);
            Text7.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text9
            // 
            Text9 = new StiText();
            Text9.ClientRectangle = new RectangleD(1.2, 0, 6.6, 0.8);
            Text9.HorAlignment = StiTextHorAlignment.Center;
            Text9.Name = "Text9";
            Text9.GetValue += new StiGetValueEventHandler(Text9__GetValue);
            Text9.VertAlignment = StiVertAlignment.Center;
            Text9.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text9.Brush = new StiSolidBrush(Color.Transparent);
            Text9.Font = new Font("BPG Glaho Arial", 10F);
            Text9.Guid = null;
            Text9.Interaction = null;
            Text9.Margins = new StiMargins(0, 0, 0, 0);
            Text9.TextBrush = new StiSolidBrush(Color.Black);
            Text9.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text11
            // 
            Text11 = new StiText();
            Text11.ClientRectangle = new RectangleD(7.8, 0, 1.8, 0.8);
            Text11.HorAlignment = StiTextHorAlignment.Center;
            Text11.Name = "Text11";
            Text11.GetValue += new StiGetValueEventHandler(Text11__GetValue);
            Text11.VertAlignment = StiVertAlignment.Center;
            Text11.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text11.Brush = new StiSolidBrush(Color.Transparent);
            Text11.Font = new Font("BPG Glaho Arial", 10F);
            Text11.Guid = null;
            Text11.Interaction = null;
            Text11.Margins = new StiMargins(0, 0, 0, 0);
            Text11.TextBrush = new StiSolidBrush(Color.Black);
            Text11.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text13
            // 
            Text13 = new StiText();
            Text13.ClientRectangle = new RectangleD(9.6, 0, 1.8, 0.8);
            Text13.HorAlignment = StiTextHorAlignment.Center;
            Text13.Name = "Text13";
            Text13.GetValue += new StiGetValueEventHandler(Text13__GetValue);
            Text13.VertAlignment = StiVertAlignment.Center;
            Text13.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text13.Brush = new StiSolidBrush(Color.Transparent);
            Text13.Font = new Font("BPG Glaho Arial", 10F);
            Text13.Guid = null;
            Text13.Interaction = null;
            Text13.Margins = new StiMargins(0, 0, 0, 0);
            Text13.TextBrush = new StiSolidBrush(Color.Black);
            Text13.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text14
            // 
            Text14 = new StiText();
            Text14.ClientRectangle = new RectangleD(11.4, 0, 2.2, 0.8);
            Text14.Guid = "a843d7bd377e47d685b2e796215a4b10";
            Text14.HorAlignment = StiTextHorAlignment.Center;
            Text14.Name = "Text14";
            Text14.GetValue += new StiGetValueEventHandler(Text14__GetValue);
            Text14.VertAlignment = StiVertAlignment.Center;
            Text14.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text14.Brush = new StiSolidBrush(Color.Transparent);
            Text14.Font = new Font("BPG Glaho Arial", 10F);
            Text14.Interaction = null;
            Text14.Margins = new StiMargins(0, 0, 0, 0);
            Text14.TextBrush = new StiSolidBrush(Color.Black);
            Text14.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            Panel2.Guid = null;
            Panel2.Interaction = null;
            // 
            // Panel6
            // 
            Panel6 = new StiPanel();
            Panel6.ClientRectangle = new RectangleD(14, 0, 13.6, 0.8);
            Panel6.Guid = "25039859a1f04f41836be0131663978f";
            Panel6.Name = "Panel6";
            Panel6.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Panel6.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text25
            // 
            Text25 = new StiText();
            Text25.ClientRectangle = new RectangleD(0, 0, 1.2, 0.8);
            Text25.Guid = "257247c9d7774d879de02fe85199441a";
            Text25.HorAlignment = StiTextHorAlignment.Center;
            Text25.Name = "Text25";
            Text25.GetValue += new StiGetValueEventHandler(Text25__GetValue);
            Text25.VertAlignment = StiVertAlignment.Center;
            Text25.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text25.Brush = new StiSolidBrush(Color.Transparent);
            Text25.Font = new Font("BPG Glaho Arial", 10F);
            Text25.Interaction = null;
            Text25.Margins = new StiMargins(0, 0, 0, 0);
            Text25.TextBrush = new StiSolidBrush(Color.Black);
            Text25.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text26
            // 
            Text26 = new StiText();
            Text26.ClientRectangle = new RectangleD(1.2, 0, 6.6, 0.8);
            Text26.Guid = "182ee1f37b09460c8cea568a0b93e23a";
            Text26.HorAlignment = StiTextHorAlignment.Center;
            Text26.Name = "Text26";
            Text26.GetValue += new StiGetValueEventHandler(Text26__GetValue);
            Text26.VertAlignment = StiVertAlignment.Center;
            Text26.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text26.Brush = new StiSolidBrush(Color.Transparent);
            Text26.Font = new Font("BPG Glaho Arial", 10F);
            Text26.Interaction = null;
            Text26.Margins = new StiMargins(0, 0, 0, 0);
            Text26.TextBrush = new StiSolidBrush(Color.Black);
            Text26.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text27
            // 
            Text27 = new StiText();
            Text27.ClientRectangle = new RectangleD(7.8, 0, 1.8, 0.8);
            Text27.Guid = "fc256a4248a04dbd988db200683b3dcb";
            Text27.HorAlignment = StiTextHorAlignment.Center;
            Text27.Name = "Text27";
            Text27.GetValue += new StiGetValueEventHandler(Text27__GetValue);
            Text27.VertAlignment = StiVertAlignment.Center;
            Text27.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text27.Brush = new StiSolidBrush(Color.Transparent);
            Text27.Font = new Font("BPG Glaho Arial", 10F);
            Text27.Interaction = null;
            Text27.Margins = new StiMargins(0, 0, 0, 0);
            Text27.TextBrush = new StiSolidBrush(Color.Black);
            Text27.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text28
            // 
            Text28 = new StiText();
            Text28.ClientRectangle = new RectangleD(9.6, 0, 1.8, 0.8);
            Text28.Guid = "565da9f4823b4dec9ef1ba21814858eb";
            Text28.HorAlignment = StiTextHorAlignment.Center;
            Text28.Name = "Text28";
            Text28.GetValue += new StiGetValueEventHandler(Text28__GetValue);
            Text28.VertAlignment = StiVertAlignment.Center;
            Text28.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text28.Brush = new StiSolidBrush(Color.Transparent);
            Text28.Font = new Font("BPG Glaho Arial", 10F);
            Text28.Interaction = null;
            Text28.Margins = new StiMargins(0, 0, 0, 0);
            Text28.TextBrush = new StiSolidBrush(Color.Black);
            Text28.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text29
            // 
            Text29 = new StiText();
            Text29.ClientRectangle = new RectangleD(11.4, 0, 2.2, 0.8);
            Text29.Guid = "272567b812504c40937e0bcc11ae8de2";
            Text29.HorAlignment = StiTextHorAlignment.Center;
            Text29.Name = "Text29";
            Text29.GetValue += new StiGetValueEventHandler(Text29__GetValue);
            Text29.VertAlignment = StiVertAlignment.Center;
            Text29.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text29.Brush = new StiSolidBrush(Color.Transparent);
            Text29.Font = new Font("BPG Glaho Arial", 10F);
            Text29.Interaction = null;
            Text29.Margins = new StiMargins(0, 0, 0, 0);
            Text29.TextBrush = new StiSolidBrush(Color.Black);
            Text29.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            Panel6.Interaction = null;
            HeaderSP_GetProductDistributionDetail.Guid = null;
            HeaderSP_GetProductDistributionDetail.Interaction = null;
            // 
            // DataSP_GetProductDistributionDetail
            // 
            DataSP_GetProductDistributionDetail = new StiDataBand();
            DataSP_GetProductDistributionDetail.ClientRectangle = new RectangleD(0, 6.2, 27.7, 0.6);
            DataSP_GetProductDistributionDetail.DataRelationName = "SP_GetProductDistributionHeader_SP_GetProductDistributionDetail";
            DataSP_GetProductDistributionDetail.DataSourceName = "SP_GetProductDistributionDetail";
            DataSP_GetProductDistributionDetail.Name = "DataSP_GetProductDistributionDetail";
            DataSP_GetProductDistributionDetail.Sort = new[] {
                    "ASC",
                    "OrdinalNumber"};
            DataSP_GetProductDistributionDetail.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetProductDistributionDetail.Brush = new StiSolidBrush(Color.Transparent);
            DataSP_GetProductDistributionDetail.BusinessObjectGuid = null;
            // 
            // Panel3
            // 
            Panel3 = new StiPanel();
            Panel3.ClientRectangle = new RectangleD(0, 0, 13.6, 0.6);
            Panel3.Name = "Panel3";
            Panel3.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Panel3.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text6
            // 
            Text6 = new StiText();
            Text6.ClientRectangle = new RectangleD(0, 0, 1.2, 0.6);
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
            Text6.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text8
            // 
            Text8 = new StiText();
            Text8.ClientRectangle = new RectangleD(1.2, 0, 6.6, 0.6);
            Text8.Name = "Text8";
            Text8.GetValue += new StiGetValueEventHandler(Text8__GetValue);
            Text8.VertAlignment = StiVertAlignment.Center;
            Text8.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text8.Brush = new StiSolidBrush(Color.Transparent);
            Text8.Font = new Font("BPG Glaho Arial", 9F);
            Text8.Guid = null;
            Text8.Interaction = null;
            Text8.Margins = new StiMargins(0, 0, 0, 0);
            Text8.TextBrush = new StiSolidBrush(Color.Black);
            Text8.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text10
            // 
            Text10 = new StiText();
            Text10.ClientRectangle = new RectangleD(7.8, 0, 1.8, 0.6);
            Text10.HorAlignment = StiTextHorAlignment.Right;
            Text10.Name = "Text10";
            Text10.GetValue += new StiGetValueEventHandler(Text10__GetValue);
            Text10.VertAlignment = StiVertAlignment.Center;
            Text10.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text10.Brush = new StiSolidBrush(Color.Transparent);
            Text10.Font = new Font("BPG Glaho Arial", 9F);
            Text10.Guid = null;
            Text10.Interaction = null;
            Text10.Margins = new StiMargins(0, 0, 0, 0);
            Text10.TextBrush = new StiSolidBrush(Color.Black);
            Text10.TextFormat = new StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            Text10.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text12
            // 
            Text12 = new StiText();
            Text12.ClientRectangle = new RectangleD(9.6, 0, 1.8, 0.6);
            Text12.HorAlignment = StiTextHorAlignment.Right;
            Text12.Name = "Text12";
            Text12.GetValue += new StiGetValueEventHandler(Text12__GetValue);
            Text12.VertAlignment = StiVertAlignment.Center;
            Text12.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text12.Brush = new StiSolidBrush(Color.Transparent);
            Text12.Font = new Font("BPG Glaho Arial", 9F);
            Text12.Guid = null;
            Text12.Interaction = null;
            Text12.Margins = new StiMargins(0, 0, 0, 0);
            Text12.TextBrush = new StiSolidBrush(Color.Black);
            Text12.TextFormat = new StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            Text12.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text15
            // 
            Text15 = new StiText();
            Text15.ClientRectangle = new RectangleD(11.4, 0, 2.2, 0.6);
            Text15.HorAlignment = StiTextHorAlignment.Right;
            Text15.Name = "Text15";
            Text15.GetValue += new StiGetValueEventHandler(Text15__GetValue);
            Text15.VertAlignment = StiVertAlignment.Center;
            Text15.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text15.Brush = new StiSolidBrush(Color.Transparent);
            Text15.Font = new Font("BPG Glaho Arial", 10F);
            Text15.Guid = null;
            Text15.Interaction = null;
            Text15.Margins = new StiMargins(0, 0, 0, 0);
            Text15.TextBrush = new StiSolidBrush(Color.Black);
            Text15.TextFormat = new StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            Text15.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            Panel3.Guid = null;
            Panel3.Interaction = null;
            // 
            // Panel7
            // 
            Panel7 = new StiPanel();
            Panel7.ClientRectangle = new RectangleD(14, 0, 13.6, 0.6);
            Panel7.Guid = "8a5a4146eb0b420996b0e5e128f62965";
            Panel7.Name = "Panel7";
            Panel7.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Panel7.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text30
            // 
            Text30 = new StiText();
            Text30.ClientRectangle = new RectangleD(0, 0, 1.2, 0.6);
            Text30.Guid = "506cd209183e44d6a577b41a351140ce";
            Text30.Name = "Text30";
            Text30.GetValue += new StiGetValueEventHandler(Text30__GetValue);
            Text30.VertAlignment = StiVertAlignment.Center;
            Text30.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text30.Brush = new StiSolidBrush(Color.Transparent);
            Text30.Font = new Font("BPG Glaho Arial", 9F);
            Text30.Interaction = null;
            Text30.Margins = new StiMargins(0, 0, 0, 0);
            Text30.TextBrush = new StiSolidBrush(Color.Black);
            Text30.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text31
            // 
            Text31 = new StiText();
            Text31.ClientRectangle = new RectangleD(1.2, 0, 6.6, 0.6);
            Text31.Guid = "85eb369fe870488d985017dc138a349e";
            Text31.Name = "Text31";
            Text31.GetValue += new StiGetValueEventHandler(Text31__GetValue);
            Text31.VertAlignment = StiVertAlignment.Center;
            Text31.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text31.Brush = new StiSolidBrush(Color.Transparent);
            Text31.Font = new Font("BPG Glaho Arial", 9F);
            Text31.Interaction = null;
            Text31.Margins = new StiMargins(0, 0, 0, 0);
            Text31.TextBrush = new StiSolidBrush(Color.Black);
            Text31.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text32
            // 
            Text32 = new StiText();
            Text32.ClientRectangle = new RectangleD(7.8, 0, 1.8, 0.6);
            Text32.Guid = "bee91c1548274483a33d82988e5f7c7f";
            Text32.HorAlignment = StiTextHorAlignment.Right;
            Text32.Name = "Text32";
            Text32.GetValue += new StiGetValueEventHandler(Text32__GetValue);
            Text32.VertAlignment = StiVertAlignment.Center;
            Text32.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text32.Brush = new StiSolidBrush(Color.Transparent);
            Text32.Font = new Font("BPG Glaho Arial", 9F);
            Text32.Interaction = null;
            Text32.Margins = new StiMargins(0, 0, 0, 0);
            Text32.TextBrush = new StiSolidBrush(Color.Black);
            Text32.TextFormat = new StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            Text32.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text33
            // 
            Text33 = new StiText();
            Text33.ClientRectangle = new RectangleD(9.6, 0, 1.8, 0.6);
            Text33.Guid = "a3c9ebb7894b47fc90925e92e1802ff8";
            Text33.HorAlignment = StiTextHorAlignment.Right;
            Text33.Name = "Text33";
            Text33.GetValue += new StiGetValueEventHandler(Text33__GetValue);
            Text33.VertAlignment = StiVertAlignment.Center;
            Text33.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text33.Brush = new StiSolidBrush(Color.Transparent);
            Text33.Font = new Font("BPG Glaho Arial", 9F);
            Text33.Interaction = null;
            Text33.Margins = new StiMargins(0, 0, 0, 0);
            Text33.TextBrush = new StiSolidBrush(Color.Black);
            Text33.TextFormat = new StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            Text33.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text34
            // 
            Text34 = new StiText();
            Text34.ClientRectangle = new RectangleD(11.4, 0, 2.2, 0.6);
            Text34.Guid = "c3c59cf9cdf74b818f226b672eb7716f";
            Text34.HorAlignment = StiTextHorAlignment.Right;
            Text34.Name = "Text34";
            Text34.GetValue += new StiGetValueEventHandler(Text34__GetValue);
            Text34.VertAlignment = StiVertAlignment.Center;
            Text34.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text34.Brush = new StiSolidBrush(Color.Transparent);
            Text34.Font = new Font("BPG Glaho Arial", 10F);
            Text34.Interaction = null;
            Text34.Margins = new StiMargins(0, 0, 0, 0);
            Text34.TextBrush = new StiSolidBrush(Color.Black);
            Text34.TextFormat = new StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            Text34.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            Panel7.Interaction = null;
            DataSP_GetProductDistributionDetail.Guid = null;
            DataSP_GetProductDistributionDetail.Interaction = null;
            // 
            // FooterSP_GetProductDistributionDetail
            // 
            FooterSP_GetProductDistributionDetail = new StiFooterBand();
            FooterSP_GetProductDistributionDetail.ClientRectangle = new RectangleD(0, 7.6, 27.7, 2.6);
            FooterSP_GetProductDistributionDetail.Name = "FooterSP_GetProductDistributionDetail";
            FooterSP_GetProductDistributionDetail.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            FooterSP_GetProductDistributionDetail.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Panel4
            // 
            Panel4 = new StiPanel();
            Panel4.ClientRectangle = new RectangleD(0, 0, 13.6, 2.4);
            Panel4.Name = "Panel4";
            Panel4.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Panel4.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text16
            // 
            Text16 = new StiText();
            Text16.ClientRectangle = new RectangleD(11.4, 0, 2.2, 0.6);
            Text16.HorAlignment = StiTextHorAlignment.Right;
            Text16.Name = "Text16";
            // 
            // Text16_Sum
            // 
            Text16.GetValue += new StiGetValueEventHandler(Text16__GetValue);
            Text16.VertAlignment = StiVertAlignment.Center;
            Text16.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text16.Brush = new StiSolidBrush(Color.Transparent);
            Text16.Font = new Font("BPG Glaho Arial", 10F);
            Text16.Guid = null;
            Text16.Interaction = null;
            Text16.Margins = new StiMargins(0, 0, 0, 0);
            Text16.TextBrush = new StiSolidBrush(Color.Black);
            Text16.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            Text16.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text17
            // 
            Text17 = new StiText();
            Text17.ClientRectangle = new RectangleD(9.8, 0, 1.6, 0.6);
            Text17.Name = "Text17";
            Text17.GetValue += new StiGetValueEventHandler(Text17__GetValue);
            Text17.VertAlignment = StiVertAlignment.Center;
            Text17.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text17.Brush = new StiSolidBrush(Color.Transparent);
            Text17.Font = new Font("BPG Glaho Arial", 10F);
            Text17.Guid = null;
            Text17.Interaction = null;
            Text17.Margins = new StiMargins(0, 0, 0, 0);
            Text17.TextBrush = new StiSolidBrush(Color.Black);
            Text17.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text18
            // 
            Text18 = new StiText();
            Text18.ClientRectangle = new RectangleD(0, 1.4, 1.6, 0.6);
            Text18.HorAlignment = StiTextHorAlignment.Right;
            Text18.Name = "Text18";
            Text18.GetValue += new StiGetValueEventHandler(Text18__GetValue);
            Text18.VertAlignment = StiVertAlignment.Center;
            Text18.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text18.Brush = new StiSolidBrush(Color.Transparent);
            Text18.Font = new Font("BPG Glaho Arial", 9F);
            Text18.Guid = null;
            Text18.Interaction = null;
            Text18.Margins = new StiMargins(0, 0, 0, 0);
            Text18.TextBrush = new StiSolidBrush(Color.Black);
            Text18.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text19
            // 
            Text19 = new StiText();
            Text19.ClientRectangle = new RectangleD(7, 1.4, 1.6, 0.6);
            Text19.Guid = "7f245341b4c944d5b9e13d5df1211083";
            Text19.HorAlignment = StiTextHorAlignment.Right;
            Text19.Name = "Text19";
            Text19.GetValue += new StiGetValueEventHandler(Text19__GetValue);
            Text19.VertAlignment = StiVertAlignment.Center;
            Text19.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text19.Brush = new StiSolidBrush(Color.Transparent);
            Text19.Font = new Font("BPG Glaho Arial", 9F);
            Text19.Interaction = null;
            Text19.Margins = new StiMargins(0, 0, 0, 0);
            Text19.TextBrush = new StiSolidBrush(Color.Black);
            Text19.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HorizontalLinePrimitive1
            // 
            HorizontalLinePrimitive1 = new StiHorizontalLinePrimitive();
            HorizontalLinePrimitive1.ClientRectangle = new RectangleD(1.8, 2, 4.4, 0.0254);
            HorizontalLinePrimitive1.Color = Color.Black;
            HorizontalLinePrimitive1.Name = "HorizontalLinePrimitive1";
            HorizontalLinePrimitive1.Style = StiPenStyle.Dot;
            HorizontalLinePrimitive1.EndCap = new StiCap(10, StiCapStyle.None, 10, true, Color.Black);
            HorizontalLinePrimitive1.Guid = null;
            HorizontalLinePrimitive1.Interaction = null;
            HorizontalLinePrimitive1.StartCap = new StiCap(10, StiCapStyle.None, 10, true, Color.Black);
            // 
            // HorizontalLinePrimitive2
            // 
            HorizontalLinePrimitive2 = new StiHorizontalLinePrimitive();
            HorizontalLinePrimitive2.ClientRectangle = new RectangleD(8.8, 2, 4.4, 0.0254);
            HorizontalLinePrimitive2.Color = Color.Black;
            HorizontalLinePrimitive2.Guid = "dbf3f15d7e6d412d95aa9451cf7d5a97";
            HorizontalLinePrimitive2.Name = "HorizontalLinePrimitive2";
            HorizontalLinePrimitive2.Style = StiPenStyle.Dot;
            HorizontalLinePrimitive2.EndCap = new StiCap(10, StiCapStyle.None, 10, true, Color.Black);
            HorizontalLinePrimitive2.Interaction = null;
            HorizontalLinePrimitive2.StartCap = new StiCap(10, StiCapStyle.None, 10, true, Color.Black);
            Panel4.Guid = null;
            Panel4.Interaction = null;
            // 
            // Panel8
            // 
            Panel8 = new StiPanel();
            Panel8.ClientRectangle = new RectangleD(14, 0, 13.6, 2.4);
            Panel8.Guid = "bdfb4e1a44b241ce9f29af9c0bd9b5a9";
            Panel8.Name = "Panel8";
            Panel8.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Panel8.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text35
            // 
            Text35 = new StiText();
            Text35.ClientRectangle = new RectangleD(11.4, 0, 2.2, 0.6);
            Text35.Guid = "a129d2f039f2490db98e9ad4eb665b66";
            Text35.HorAlignment = StiTextHorAlignment.Right;
            Text35.Name = "Text35";
            // 
            // Text35_Sum
            // 
            Text35.GetValue += new StiGetValueEventHandler(Text35__GetValue);
            Text35.VertAlignment = StiVertAlignment.Center;
            Text35.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text35.Brush = new StiSolidBrush(Color.Transparent);
            Text35.Font = new Font("BPG Glaho Arial", 10F);
            Text35.Interaction = null;
            Text35.Margins = new StiMargins(0, 0, 0, 0);
            Text35.TextBrush = new StiSolidBrush(Color.Black);
            Text35.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            Text35.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text36
            // 
            Text36 = new StiText();
            Text36.ClientRectangle = new RectangleD(9.8, 0, 1.6, 0.6);
            Text36.Guid = "11898e02422742b2ab3a76cc00fe9c76";
            Text36.Name = "Text36";
            Text36.GetValue += new StiGetValueEventHandler(Text36__GetValue);
            Text36.VertAlignment = StiVertAlignment.Center;
            Text36.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text36.Brush = new StiSolidBrush(Color.Transparent);
            Text36.Font = new Font("BPG Glaho Arial", 10F);
            Text36.Interaction = null;
            Text36.Margins = new StiMargins(0, 0, 0, 0);
            Text36.TextBrush = new StiSolidBrush(Color.Black);
            Text36.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text37
            // 
            Text37 = new StiText();
            Text37.ClientRectangle = new RectangleD(0, 1.4, 1.6, 0.6);
            Text37.Guid = "3a7861a5b2ba44d1aac744b4cc81ef26";
            Text37.HorAlignment = StiTextHorAlignment.Right;
            Text37.Name = "Text37";
            Text37.GetValue += new StiGetValueEventHandler(Text37__GetValue);
            Text37.VertAlignment = StiVertAlignment.Center;
            Text37.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text37.Brush = new StiSolidBrush(Color.Transparent);
            Text37.Font = new Font("BPG Glaho Arial", 9F);
            Text37.Interaction = null;
            Text37.Margins = new StiMargins(0, 0, 0, 0);
            Text37.TextBrush = new StiSolidBrush(Color.Black);
            Text37.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text38
            // 
            Text38 = new StiText();
            Text38.ClientRectangle = new RectangleD(7, 1.4, 1.6, 0.6);
            Text38.Guid = "4069c95d774a4a24b664143a27117bd8";
            Text38.HorAlignment = StiTextHorAlignment.Right;
            Text38.Name = "Text38";
            Text38.GetValue += new StiGetValueEventHandler(Text38__GetValue);
            Text38.VertAlignment = StiVertAlignment.Center;
            Text38.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text38.Brush = new StiSolidBrush(Color.Transparent);
            Text38.Font = new Font("BPG Glaho Arial", 9F);
            Text38.Interaction = null;
            Text38.Margins = new StiMargins(0, 0, 0, 0);
            Text38.TextBrush = new StiSolidBrush(Color.Black);
            Text38.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HorizontalLinePrimitive3
            // 
            HorizontalLinePrimitive3 = new StiHorizontalLinePrimitive();
            HorizontalLinePrimitive3.ClientRectangle = new RectangleD(1.8, 2, 4.4, 0.0254);
            HorizontalLinePrimitive3.Color = Color.Black;
            HorizontalLinePrimitive3.Guid = "b55c45c3ea3e49028d123250605f2a49";
            HorizontalLinePrimitive3.Name = "HorizontalLinePrimitive3";
            HorizontalLinePrimitive3.Style = StiPenStyle.Dot;
            HorizontalLinePrimitive3.EndCap = new StiCap(10, StiCapStyle.None, 10, true, Color.Black);
            HorizontalLinePrimitive3.Interaction = null;
            HorizontalLinePrimitive3.StartCap = new StiCap(10, StiCapStyle.None, 10, true, Color.Black);
            // 
            // HorizontalLinePrimitive4
            // 
            HorizontalLinePrimitive4 = new StiHorizontalLinePrimitive();
            HorizontalLinePrimitive4.ClientRectangle = new RectangleD(8.8, 2, 4.4, 0.0254);
            HorizontalLinePrimitive4.Color = Color.Black;
            HorizontalLinePrimitive4.Guid = "67c6a2fbf95941d2a0f27e69c69dc3be";
            HorizontalLinePrimitive4.Name = "HorizontalLinePrimitive4";
            HorizontalLinePrimitive4.Style = StiPenStyle.Dot;
            HorizontalLinePrimitive4.EndCap = new StiCap(10, StiCapStyle.None, 10, true, Color.Black);
            HorizontalLinePrimitive4.Interaction = null;
            HorizontalLinePrimitive4.StartCap = new StiCap(10, StiCapStyle.None, 10, true, Color.Black);
            Panel8.Interaction = null;
            FooterSP_GetProductDistributionDetail.Guid = null;
            FooterSP_GetProductDistributionDetail.Interaction = null;
            // 
            // VerticalLinePrimitive1
            // 
            VerticalLinePrimitive1 = new StiVerticalLinePrimitive();
            VerticalLinePrimitive1.ClientRectangle = new RectangleD(13.8, 0, 0.0254, 19);
            VerticalLinePrimitive1.Color = Color.Black;
            VerticalLinePrimitive1.Guid = "55f521d5550a40dab3a90e9934072bb4";
            VerticalLinePrimitive1.Locked = true;
            VerticalLinePrimitive1.Name = "VerticalLinePrimitive1";
            VerticalLinePrimitive1.Style = StiPenStyle.Dash;
            VerticalLinePrimitive1.EndCap = new StiCap(10, StiCapStyle.None, 10, true, Color.Black);
            VerticalLinePrimitive1.Interaction = null;
            VerticalLinePrimitive1.StartCap = new StiCap(10, StiCapStyle.None, 10, true, Color.Black);
            // 
            // EndPointPrimitive1
            // 
            EndPointPrimitive1 = new StiEndPointPrimitive();
            EndPointPrimitive1.ClientRectangle = new RectangleD(13.88, 19, 0, 0);
            EndPointPrimitive1.Name = "EndPointPrimitive1";
            EndPointPrimitive1.ReferenceToGuid = "55f521d5550a40dab3a90e9934072bb4";
            EndPointPrimitive1.Guid = null;
            EndPointPrimitive1.Interaction = null;
            // 
            // StartPointPrimitive1
            // 
            StartPointPrimitive1 = new StiStartPointPrimitive();
            StartPointPrimitive1.ClientRectangle = new RectangleD(13.8, 0, 0, 0);
            StartPointPrimitive1.Name = "StartPointPrimitive1";
            StartPointPrimitive1.ReferenceToGuid = "55f521d5550a40dab3a90e9934072bb4";
            StartPointPrimitive1.Guid = null;
            StartPointPrimitive1.Interaction = null;
            Page1.ExcelSheetValue = null;
            Page1.Interaction = null;
            Page1.Margins = new StiMargins(1, 1, 1, 1);
            Page1_Watermark = new StiWatermark();
            Page1_Watermark.Font = new Font("Arial", 100F);
            Page1_Watermark.Image = null;
            Page1_Watermark.TextBrush = new StiSolidBrush(Color.FromArgb(50, 0, 0, 0));
            RptProductDistributionDetail_PrinterSettings = new StiPrinterSettings();
            PrinterSettings = RptProductDistributionDetail_PrinterSettings;
            Page1.Report = this;
            Page1.Watermark = Page1_Watermark;
            DataSP_GetProductDistributionHeader.Page = Page1;
            DataSP_GetProductDistributionHeader.Parent = Page1;
            Panel1.Page = Page1;
            Panel1.Parent = DataSP_GetProductDistributionHeader;
            Text2.Page = Page1;
            Text2.Parent = Panel1;
            Text4.Page = Page1;
            Text4.Parent = Panel1;
            Text1.Page = Page1;
            Text1.Parent = Panel1;
            Text3.Page = Page1;
            Text3.Parent = Panel1;
            Text5.Page = Page1;
            Text5.Parent = Panel1;
            Panel5.Page = Page1;
            Panel5.Parent = DataSP_GetProductDistributionHeader;
            Text20.Page = Page1;
            Text20.Parent = Panel5;
            Text21.Page = Page1;
            Text21.Parent = Panel5;
            Text22.Page = Page1;
            Text22.Parent = Panel5;
            Text23.Page = Page1;
            Text23.Parent = Panel5;
            Text24.Page = Page1;
            Text24.Parent = Panel5;
            HeaderSP_GetProductDistributionDetail.Page = Page1;
            HeaderSP_GetProductDistributionDetail.Parent = Page1;
            Panel2.Page = Page1;
            Panel2.Parent = HeaderSP_GetProductDistributionDetail;
            Text7.Page = Page1;
            Text7.Parent = Panel2;
            Text9.Page = Page1;
            Text9.Parent = Panel2;
            Text11.Page = Page1;
            Text11.Parent = Panel2;
            Text13.Page = Page1;
            Text13.Parent = Panel2;
            Text14.Page = Page1;
            Text14.Parent = Panel2;
            Panel6.Page = Page1;
            Panel6.Parent = HeaderSP_GetProductDistributionDetail;
            Text25.Page = Page1;
            Text25.Parent = Panel6;
            Text26.Page = Page1;
            Text26.Parent = Panel6;
            Text27.Page = Page1;
            Text27.Parent = Panel6;
            Text28.Page = Page1;
            Text28.Parent = Panel6;
            Text29.Page = Page1;
            Text29.Parent = Panel6;
            DataSP_GetProductDistributionDetail.MasterComponent = DataSP_GetProductDistributionHeader;
            DataSP_GetProductDistributionDetail.Page = Page1;
            DataSP_GetProductDistributionDetail.Parent = Page1;
            Panel3.Page = Page1;
            Panel3.Parent = DataSP_GetProductDistributionDetail;
            Text6.Page = Page1;
            Text6.Parent = Panel3;
            Text8.Page = Page1;
            InitializeComponent2();
        }

        public void InitializeComponent2()
        {
            Text8.Parent = Panel3;
            Text10.Page = Page1;
            Text10.Parent = Panel3;
            Text12.Page = Page1;
            Text12.Parent = Panel3;
            Text15.Page = Page1;
            Text15.Parent = Panel3;
            Panel7.Page = Page1;
            Panel7.Parent = DataSP_GetProductDistributionDetail;
            Text30.Page = Page1;
            Text30.Parent = Panel7;
            Text31.Page = Page1;
            Text31.Parent = Panel7;
            Text32.Page = Page1;
            Text32.Parent = Panel7;
            Text33.Page = Page1;
            Text33.Parent = Panel7;
            Text34.Page = Page1;
            Text34.Parent = Panel7;
            FooterSP_GetProductDistributionDetail.Page = Page1;
            FooterSP_GetProductDistributionDetail.Parent = Page1;
            Panel4.Page = Page1;
            Panel4.Parent = FooterSP_GetProductDistributionDetail;
            Text16.Page = Page1;
            Text16.Parent = Panel4;
            Text17.Page = Page1;
            Text17.Parent = Panel4;
            Text18.Page = Page1;
            Text18.Parent = Panel4;
            Text19.Page = Page1;
            Text19.Parent = Panel4;
            HorizontalLinePrimitive1.Page = Page1;
            HorizontalLinePrimitive1.Parent = Panel4;
            HorizontalLinePrimitive2.Page = Page1;
            HorizontalLinePrimitive2.Parent = Panel4;
            Panel8.Page = Page1;
            Panel8.Parent = FooterSP_GetProductDistributionDetail;
            Text35.Page = Page1;
            Text35.Parent = Panel8;
            Text36.Page = Page1;
            Text36.Parent = Panel8;
            Text37.Page = Page1;
            Text37.Parent = Panel8;
            Text38.Page = Page1;
            Text38.Parent = Panel8;
            HorizontalLinePrimitive3.Page = Page1;
            HorizontalLinePrimitive3.Parent = Panel8;
            HorizontalLinePrimitive4.Page = Page1;
            HorizontalLinePrimitive4.Parent = Panel8;
            VerticalLinePrimitive1.Page = Page1;
            VerticalLinePrimitive1.Parent = Page1;
            EndPointPrimitive1.Page = Page1;
            EndPointPrimitive1.Parent = Page1;
            StartPointPrimitive1.Page = Page1;
            StartPointPrimitive1.Parent = Page1;
            DataSP_GetProductDistributionDetail.BeginRender += new EventHandler(DataSP_GetProductDistributionDetail__BeginRender);
            DataSP_GetProductDistributionDetail.EndRender += new EventHandler(DataSP_GetProductDistributionDetail__EndRender);
            DataSP_GetProductDistributionDetail.Rendering += new EventHandler(DataSP_GetProductDistributionDetail__Rendering);
            AggregateFunctions = new object[] {
                    Text16_Sum,
                    Text35_Sum};
            // 
            // Add to Panel1.Components
            // 
            Panel1.Components.Clear();
            Panel1.Components.AddRange(new StiComponent[] {
                        Text2,
                        Text4,
                        Text1,
                        Text3,
                        Text5});
            // 
            // Add to Panel5.Components
            // 
            Panel5.Components.Clear();
            Panel5.Components.AddRange(new StiComponent[] {
                        Text20,
                        Text21,
                        Text22,
                        Text23,
                        Text24});
            // 
            // Add to DataSP_GetProductDistributionHeader.Components
            // 
            DataSP_GetProductDistributionHeader.Components.Clear();
            DataSP_GetProductDistributionHeader.Components.AddRange(new StiComponent[] {
                        Panel1,
                        Panel5});
            // 
            // Add to Panel2.Components
            // 
            Panel2.Components.Clear();
            Panel2.Components.AddRange(new StiComponent[] {
                        Text7,
                        Text9,
                        Text11,
                        Text13,
                        Text14});
            // 
            // Add to Panel6.Components
            // 
            Panel6.Components.Clear();
            Panel6.Components.AddRange(new StiComponent[] {
                        Text25,
                        Text26,
                        Text27,
                        Text28,
                        Text29});
            // 
            // Add to HeaderSP_GetProductDistributionDetail.Components
            // 
            HeaderSP_GetProductDistributionDetail.Components.Clear();
            HeaderSP_GetProductDistributionDetail.Components.AddRange(new StiComponent[] {
                        Panel2,
                        Panel6});
            // 
            // Add to Panel3.Components
            // 
            Panel3.Components.Clear();
            Panel3.Components.AddRange(new StiComponent[] {
                        Text6,
                        Text8,
                        Text10,
                        Text12,
                        Text15});
            // 
            // Add to Panel7.Components
            // 
            Panel7.Components.Clear();
            Panel7.Components.AddRange(new StiComponent[] {
                        Text30,
                        Text31,
                        Text32,
                        Text33,
                        Text34});
            // 
            // Add to DataSP_GetProductDistributionDetail.Components
            // 
            DataSP_GetProductDistributionDetail.Components.Clear();
            DataSP_GetProductDistributionDetail.Components.AddRange(new StiComponent[] {
                        Panel3,
                        Panel7});
            // 
            // Add to Panel4.Components
            // 
            Panel4.Components.Clear();
            Panel4.Components.AddRange(new StiComponent[] {
                        Text16,
                        Text17,
                        Text18,
                        Text19,
                        HorizontalLinePrimitive1,
                        HorizontalLinePrimitive2});
            // 
            // Add to Panel8.Components
            // 
            Panel8.Components.Clear();
            Panel8.Components.AddRange(new StiComponent[] {
                        Text35,
                        Text36,
                        Text37,
                        Text38,
                        HorizontalLinePrimitive3,
                        HorizontalLinePrimitive4});
            // 
            // Add to FooterSP_GetProductDistributionDetail.Components
            // 
            FooterSP_GetProductDistributionDetail.Components.Clear();
            FooterSP_GetProductDistributionDetail.Components.AddRange(new StiComponent[] {
                        Panel4,
                        Panel8});
            // 
            // Add to Page1.Components
            // 
            Page1.Components.Clear();
            Page1.Components.AddRange(new StiComponent[] {
                        DataSP_GetProductDistributionHeader,
                        HeaderSP_GetProductDistributionDetail,
                        DataSP_GetProductDistributionDetail,
                        FooterSP_GetProductDistributionDetail,
                        VerticalLinePrimitive1,
                        EndPointPrimitive1,
                        StartPointPrimitive1});
            // 
            // Add to Pages
            // 
            Pages.Clear();
            Pages.AddRange(new[] {
                        Page1});
            Dictionary.Relations.Add(ParentSP_GetProductDistributionHeader);
            SP_GetProductDistributionDetail.Columns.AddRange(new[] {
                        new StiDataColumn("ProductDistributionDetailID", "ProductDistributionDetailID", "ProductDistributionDetailID", typeof(Guid)),
                        new StiDataColumn("ProductDistributionID", "ProductDistributionID", "ProductDistributionID", typeof(int)),
                        new StiDataColumn("ProductLocationID", "ProductLocationID", "ProductLocationID", typeof(int)),
                        new StiDataColumn("DistributeQty", "DistributeQty", "DistributeQty", typeof(decimal)),
                        new StiDataColumn("UnitPrice", "UnitPrice", "UnitPrice", typeof(decimal)),
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
                        new StiDataColumn("TaxRate", "TaxRate", "TaxRate", typeof(decimal)),
                        new StiDataColumn("ValidDate", "ValidDate", "ValidDate", typeof(DateTime)),
                        new StiDataColumn("CountryCode", "CountryCode", "CountryCode", typeof(string)),
                        new StiDataColumn("CountryName", "CountryName", "CountryName", typeof(string)),
                        new StiDataColumn("BrandID", "BrandID", "BrandID", typeof(int)),
                        new StiDataColumn("BrandName", "BrandName", "BrandName", typeof(string)),
                        new StiDataColumn("Serie", "Serie", "Serie", typeof(string)),
                        new StiDataColumn("UnitsInStock", "UnitsInStock", "UnitsInStock", typeof(short)),
                        new StiDataColumn("_ResidualQty", "_ResidualQty", "_ResidualQty", typeof(decimal)),
                        new StiDataColumn("_DistributeUnitQty", "_DistributeUnitQty", "_DistributeUnitQty", typeof(int)),
                        new StiDataColumn("Action", "Action", "Action", typeof(int))});
            DataSources.Add(SP_GetProductDistributionDetail);
            SP_GetProductDistributionHeader.Columns.AddRange(new[] {
                        new StiDataColumn("ProductDistributionID", "ProductDistributionID", "ProductDistributionID", typeof(int)),
                        new StiDataColumn("FromBranchID", "FromBranchID", "FromBranchID", typeof(int)),
                        new StiDataColumn("FromBranchName", "FromBranchName", "FromBranchName", typeof(string)),
                        new StiDataColumn("ToBranchID", "ToBranchID", "ToBranchID", typeof(int)),
                        new StiDataColumn("ToBranchName", "ToBranchName", "ToBranchName", typeof(string)),
                        new StiDataColumn("StartDate", "StartDate", "StartDate", typeof(DateTime)),
                        new StiDataColumn("EndDate", "EndDate", "EndDate", typeof(DateTime)),
                        new StiDataColumn("SubTotal", "SubTotal", "SubTotal", typeof(decimal)),
                        new StiDataColumn("TaxAmt", "TaxAmt", "TaxAmt", typeof(decimal)),
                        new StiDataColumn("Freight", "Freight", "Freight", typeof(decimal)),
                        new StiDataColumn("TotalDue", "TotalDue", "TotalDue", typeof(decimal)),
                        new StiDataColumn("CurrencyCode", "CurrencyCode", "CurrencyCode", typeof(string)),
                        new StiDataColumn("CurrencyRateID", "CurrencyRateID", "CurrencyRateID", typeof(int)),
                        new StiDataColumn("RevisionNumber", "RevisionNumber", "RevisionNumber", typeof(byte)),
                        new StiDataColumn("Status", "Status", "Status", typeof(byte)),
                        new StiDataColumn("ModifiedUserID", "ModifiedUserID", "ModifiedUserID", typeof(int)),
                        new StiDataColumn("Modifier", "Modifier", "Modifier", typeof(string)),
                        new StiDataColumn("ModifiedDate", "ModifiedDate", "ModifiedDate", typeof(DateTime)),
                        new StiDataColumn("ApproverUserID", "ApproverUserID", "ApproverUserID", typeof(int)),
                        new StiDataColumn("Approver", "Approver", "Approver", typeof(string))});
            DataSources.Add(SP_GetProductDistributionHeader);
        }

        #region Relation ParentSP_GetProductDistributionHeader
        public class ParentSP_GetProductDistributionHeaderRelation : StiDataRow
        {

            public ParentSP_GetProductDistributionHeaderRelation(StiDataRow dataRow) :
                base(dataRow)
            {
            }

            public virtual int ProductDistributionID
            {
                get
                {
                    return ((int)(ChangeType(this["ProductDistributionID"], typeof(int), true)));
                }
            }

            public virtual int FromBranchID
            {
                get
                {
                    return ((int)(ChangeType(this["FromBranchID"], typeof(int), true)));
                }
            }

            public virtual string FromBranchName
            {
                get
                {
                    return ((string)(ChangeType(this["FromBranchName"], typeof(string), true)));
                }
            }

            public virtual int ToBranchID
            {
                get
                {
                    return ((int)(ChangeType(this["ToBranchID"], typeof(int), true)));
                }
            }

            public virtual string ToBranchName
            {
                get
                {
                    return ((string)(ChangeType(this["ToBranchName"], typeof(string), true)));
                }
            }

            public virtual DateTime StartDate
            {
                get
                {
                    return ((DateTime)(ChangeType(this["StartDate"], typeof(DateTime), true)));
                }
            }

            public virtual DateTime EndDate
            {
                get
                {
                    return ((DateTime)(ChangeType(this["EndDate"], typeof(DateTime), true)));
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
        #endregion Relation ParentSP_GetProductDistributionHeader

        #region DataSource SP_GetProductDistributionDetail
        public class SP_GetProductDistributionDetailDataSource : StiDataTableSource
        {

            public SP_GetProductDistributionDetailDataSource() :
                base("DS_ProductDistribution.SP_GetProductDistributionDetail", "SP_GetProductDistributionDetail")
            {
            }

            public virtual Guid ProductDistributionDetailID
            {
                get
                {
                    return ((Guid)(ChangeType(this["ProductDistributionDetailID"], typeof(Guid), true)));
                }
            }

            public virtual int ProductDistributionID
            {
                get
                {
                    return ((int)(ChangeType(this["ProductDistributionID"], typeof(int), true)));
                }
            }

            public virtual int ProductLocationID
            {
                get
                {
                    return ((int)(ChangeType(this["ProductLocationID"], typeof(int), true)));
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

            public virtual decimal TaxRate
            {
                get
                {
                    return ((decimal)(ChangeType(this["TaxRate"], typeof(decimal), true)));
                }
            }

            public virtual DateTime ValidDate
            {
                get
                {
                    return ((DateTime)(ChangeType(this["ValidDate"], typeof(DateTime), true)));
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

            public virtual int _DistributeUnitQty
            {
                get
                {
                    return ((int)(ChangeType(this["_DistributeUnitQty"], typeof(int), true)));
                }
            }

            public virtual int Action
            {
                get
                {
                    return ((int)(ChangeType(this["Action"], typeof(int), true)));
                }
            }

            public virtual ParentSP_GetProductDistributionHeaderRelation SP_GetProductDistributionHeader
            {
                get
                {
                    return new ParentSP_GetProductDistributionHeaderRelation(GetParentData("SP_GetProductDistributionHeader_SP_GetProductDistributionDetail"));
                }
            }
        }
        #endregion DataSource SP_GetProductDistributionDetail

        #region DataSource SP_GetProductDistributionHeader
        public class SP_GetProductDistributionHeaderDataSource : StiDataTableSource
        {

            public SP_GetProductDistributionHeaderDataSource() :
                base("DS_ProductDistribution.SP_GetProductDistributionHeader", "SP_GetProductDistributionHeader")
            {
            }

            public virtual int ProductDistributionID
            {
                get
                {
                    return ((int)(ChangeType(this["ProductDistributionID"], typeof(int), true)));
                }
            }

            public virtual int FromBranchID
            {
                get
                {
                    return ((int)(ChangeType(this["FromBranchID"], typeof(int), true)));
                }
            }

            public virtual string FromBranchName
            {
                get
                {
                    return ((string)(ChangeType(this["FromBranchName"], typeof(string), true)));
                }
            }

            public virtual int ToBranchID
            {
                get
                {
                    return ((int)(ChangeType(this["ToBranchID"], typeof(int), true)));
                }
            }

            public virtual string ToBranchName
            {
                get
                {
                    return ((string)(ChangeType(this["ToBranchName"], typeof(string), true)));
                }
            }

            public virtual DateTime StartDate
            {
                get
                {
                    return ((DateTime)(ChangeType(this["StartDate"], typeof(DateTime), true)));
                }
            }

            public virtual DateTime EndDate
            {
                get
                {
                    return ((DateTime)(ChangeType(this["EndDate"], typeof(DateTime), true)));
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
        #endregion DataSource SP_GetProductDistributionHeader
        #endregion StiReport Designer generated code - do not modify
    }
}
