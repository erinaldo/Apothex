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

    public class RptSalesOrderHeader : StiReport
    {

        public RptSalesOrderHeader()
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
        public StiPage Page1;
        public StiReportTitleBand ReportTitle;
        public StiText ReportTitleText;
        public StiHeaderBand Header;
        public StiText HeaderText1;
        public StiText HeaderText2;
        public StiText HeaderText3;
        public StiText HeaderText4;
        public StiText HeaderText5;
        public StiText HeaderText6;
        public StiGroupHeaderBand GroupHeader0;
        public StiText GroupHeaderText0;
        public StiDataBand Data;
        public StiText DataText1;
        public StiText DataText2;
        public StiText DataText3;
        public StiText DataText4;
        public StiText DataText5;
        public StiText DataText6;
        public StiGroupFooterBand GroupFooter0;
        public StiFooterBand Footer;
        public StiText FooterText1;
        public StiCountFunctionService FooterText1_Count;
        public StiText Text1;
        public StiSumDecimalFunctionService Text1_Sum;
        public StiWatermark Page1_Watermark;
        public StiPrinterSettings RptSalesOrderHeader_PrinterSettings;
        public VW_SalesOrderHeaderDataSource VW_SalesOrderHeader;

        public void ReportTitleText__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "გაყიდვები";
        }

        public void HeaderText1__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "№";
        }

        public void HeaderText2__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "თარიღი";
        }

        public void HeaderText3__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "კომპანია";
        }

        public void HeaderText4__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ჯამი";
        }

        public void HeaderText5__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ვალუტა";
        }

        public void HeaderText6__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "გადახდ. მეთ.";
        }

        public void GroupHeader0__GetValue(object sender, StiValueEventArgs e)
        {
            e.Value = VW_SalesOrderHeader.BranchName;
        }

        public void GroupHeaderText0__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, VW_SalesOrderHeader.BranchName, true);
        }

        public void DataText1__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, VW_SalesOrderHeader.SalesOrderID, true);
        }

        public void DataText2__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = String.Format("{0:G}", VW_SalesOrderHeader.OrderDate);
        }

        public void DataText3__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, VW_SalesOrderHeader.CustomerName, true);
        }

        public void DataText4__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = DataText4.TextFormat.Format(CheckExcelValue(sender, VW_SalesOrderHeader.TotalDue));
        }

        public void DataText5__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, VW_SalesOrderHeader.CurrencyCode, true);
        }

        public void DataText6__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, VW_SalesOrderHeader.PaymentMethodName, true);
        }

        public void FooterText1__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Count()}";
            e.StoreToPrinted = true;
        }

        public String FooterText1_GetValue_End(StiComponent sender)
        {
            return ToString(sender, ((long)(ChangeType(FooterText1_Count.GetValue(), typeof(long), true))), true);
        }

        public void Text1__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(Data,VW_SalesOrderHeader.TotalDue)}";
            e.StoreToPrinted = true;
        }

        public String Text1_GetValue_End(StiComponent sender)
        {
            return Text1.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text1_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void Data__BeginRender(object sender, EventArgs e)
        {
            FooterText1_Count.Init();
            FooterText1.TextValue = "";
            Text1_Sum.Init();
            Text1.TextValue = "";
        }

        public void Data__EndRender(object sender, EventArgs e)
        {
            FooterText1.SetText(new StiGetValue(FooterText1_GetValue_End));
            Text1.SetText(new StiGetValue(Text1_GetValue_End));
        }

        public void Data__Rendering(object sender, EventArgs e)
        {
            FooterText1_Count.CalcItem(null);
            Text1_Sum.CalcItem(VW_SalesOrderHeader.TotalDue);
        }

        private void InitializeComponent()
        {
            VW_SalesOrderHeader = new VW_SalesOrderHeaderDataSource();
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
            NeedsCompiling = false;
            Text1_Sum = new StiSumDecimalFunctionService();
            FooterText1_Count = new StiCountFunctionService();
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
            ReportAlias = "Rpt Sales Order Header";
            ReportAuthor = "Programmer.GE";
            // 
            // ReportChanged
            // 
            ReportChanged = new DateTime(2009, 6, 17, 11, 6, 30, 0);
            // 
            // ReportCreated
            // 
            ReportCreated = new DateTime(2009, 2, 8, 17, 26, 28, 0);
            ReportDescription = "გაყიდვების რეპორტი";
            ReportGuid = "2f64cd76b33a4817bb677636d7597eee";
            ReportName = "RptSalesOrderHeader";
            ReportUnit = StiReportUnitType.Centimeters;
            ScriptLanguage = StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            Page1 = new StiPage();
            Page1.Guid = "08a406f7186b4a67b5f7a96a78aa664a";
            Page1.Name = "Page1";
            Page1.PageHeight = 29.7;
            Page1.PageWidth = 21;
            Page1.Border = new StiBorder(StiBorderSides.None, Color.Black, 2, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Page1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // ReportTitle
            // 
            ReportTitle = new StiReportTitleBand();
            ReportTitle.ClientRectangle = new RectangleD(0, 0.4, 19, 0.8);
            ReportTitle.Name = "ReportTitle";
            ReportTitle.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            ReportTitle.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // ReportTitleText
            // 
            ReportTitleText = new StiText();
            ReportTitleText.ClientRectangle = new RectangleD(0, 0, 19, 0.8);
            ReportTitleText.HorAlignment = StiTextHorAlignment.Center;
            ReportTitleText.Name = "ReportTitleText";
            ReportTitleText.GetValue += new StiGetValueEventHandler(ReportTitleText__GetValue);
            ReportTitleText.Type = StiSystemTextType.Expression;
            ReportTitleText.VertAlignment = StiVertAlignment.Center;
            ReportTitleText.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            ReportTitleText.Brush = new StiSolidBrush(Color.Transparent);
            ReportTitleText.Font = new Font("BPG Glaho Arial", 12F, FontStyle.Bold);
            ReportTitleText.Guid = null;
            ReportTitleText.Interaction = null;
            ReportTitleText.Margins = new StiMargins(0, 0, 0, 0);
            ReportTitleText.TextBrush = new StiSolidBrush(Color.Black);
            ReportTitleText.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            ReportTitle.Guid = null;
            ReportTitle.Interaction = null;
            // 
            // Header
            // 
            Header = new StiHeaderBand();
            Header.ClientRectangle = new RectangleD(0, 2, 19, 0.8);
            Header.Name = "Header";
            Header.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Header.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // HeaderText1
            // 
            HeaderText1 = new StiText();
            HeaderText1.CanGrow = true;
            HeaderText1.ClientRectangle = new RectangleD(0, 0, 2.8, 0.8);
            HeaderText1.HorAlignment = StiTextHorAlignment.Center;
            HeaderText1.Name = "HeaderText1";
            HeaderText1.GetValue += new StiGetValueEventHandler(HeaderText1__GetValue);
            HeaderText1.Type = StiSystemTextType.Expression;
            HeaderText1.VertAlignment = StiVertAlignment.Center;
            HeaderText1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderText1.Brush = new StiSolidBrush(Color.Transparent);
            HeaderText1.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderText1.Guid = null;
            HeaderText1.Interaction = null;
            HeaderText1.Margins = new StiMargins(0, 0, 0, 0);
            HeaderText1.TextBrush = new StiSolidBrush(Color.Black);
            HeaderText1.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderText2
            // 
            HeaderText2 = new StiText();
            HeaderText2.CanGrow = true;
            HeaderText2.ClientRectangle = new RectangleD(2.8, 0, 2, 0.8);
            HeaderText2.HorAlignment = StiTextHorAlignment.Center;
            HeaderText2.Name = "HeaderText2";
            HeaderText2.GetValue += new StiGetValueEventHandler(HeaderText2__GetValue);
            HeaderText2.Type = StiSystemTextType.Expression;
            HeaderText2.VertAlignment = StiVertAlignment.Center;
            HeaderText2.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderText2.Brush = new StiSolidBrush(Color.Transparent);
            HeaderText2.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderText2.Guid = null;
            HeaderText2.Interaction = null;
            HeaderText2.Margins = new StiMargins(0, 0, 0, 0);
            HeaderText2.TextBrush = new StiSolidBrush(Color.Black);
            HeaderText2.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderText3
            // 
            HeaderText3 = new StiText();
            HeaderText3.CanGrow = true;
            HeaderText3.ClientRectangle = new RectangleD(4.8, 0, 6.4, 0.8);
            HeaderText3.HorAlignment = StiTextHorAlignment.Center;
            HeaderText3.Name = "HeaderText3";
            HeaderText3.GetValue += new StiGetValueEventHandler(HeaderText3__GetValue);
            HeaderText3.Type = StiSystemTextType.Expression;
            HeaderText3.VertAlignment = StiVertAlignment.Center;
            HeaderText3.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderText3.Brush = new StiSolidBrush(Color.Transparent);
            HeaderText3.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderText3.Guid = null;
            HeaderText3.Interaction = null;
            HeaderText3.Margins = new StiMargins(0, 0, 0, 0);
            HeaderText3.TextBrush = new StiSolidBrush(Color.Black);
            HeaderText3.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderText4
            // 
            HeaderText4 = new StiText();
            HeaderText4.CanGrow = true;
            HeaderText4.ClientRectangle = new RectangleD(11.2, 0, 2.8, 0.8);
            HeaderText4.HorAlignment = StiTextHorAlignment.Center;
            HeaderText4.Name = "HeaderText4";
            HeaderText4.GetValue += new StiGetValueEventHandler(HeaderText4__GetValue);
            HeaderText4.Type = StiSystemTextType.Expression;
            HeaderText4.VertAlignment = StiVertAlignment.Center;
            HeaderText4.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderText4.Brush = new StiSolidBrush(Color.Transparent);
            HeaderText4.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderText4.Guid = null;
            HeaderText4.Interaction = null;
            HeaderText4.Margins = new StiMargins(0, 0, 0, 0);
            HeaderText4.TextBrush = new StiSolidBrush(Color.Black);
            HeaderText4.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderText5
            // 
            HeaderText5 = new StiText();
            HeaderText5.CanGrow = true;
            HeaderText5.ClientRectangle = new RectangleD(14, 0, 1.6, 0.8);
            HeaderText5.HorAlignment = StiTextHorAlignment.Center;
            HeaderText5.Name = "HeaderText5";
            HeaderText5.GetValue += new StiGetValueEventHandler(HeaderText5__GetValue);
            HeaderText5.Type = StiSystemTextType.Expression;
            HeaderText5.VertAlignment = StiVertAlignment.Center;
            HeaderText5.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderText5.Brush = new StiSolidBrush(Color.Transparent);
            HeaderText5.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderText5.Guid = null;
            HeaderText5.Interaction = null;
            HeaderText5.Margins = new StiMargins(0, 0, 0, 0);
            HeaderText5.TextBrush = new StiSolidBrush(Color.Black);
            HeaderText5.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderText6
            // 
            HeaderText6 = new StiText();
            HeaderText6.CanGrow = true;
            HeaderText6.ClientRectangle = new RectangleD(15.6, 0, 3.4, 0.8);
            HeaderText6.HorAlignment = StiTextHorAlignment.Center;
            HeaderText6.Name = "HeaderText6";
            HeaderText6.GetValue += new StiGetValueEventHandler(HeaderText6__GetValue);
            HeaderText6.Type = StiSystemTextType.Expression;
            HeaderText6.VertAlignment = StiVertAlignment.Center;
            HeaderText6.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderText6.Brush = new StiSolidBrush(Color.Transparent);
            HeaderText6.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderText6.Guid = null;
            HeaderText6.Interaction = null;
            HeaderText6.Margins = new StiMargins(0, 0, 0, 0);
            HeaderText6.TextBrush = new StiSolidBrush(Color.Black);
            HeaderText6.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            Header.Guid = null;
            Header.Interaction = null;
            // 
            // GroupHeader0
            // 
            GroupHeader0 = new StiGroupHeaderBand();
            GroupHeader0.ClientRectangle = new RectangleD(0, 3.6, 19, 0.8);
            GroupHeader0.GetValue += new StiValueEventHandler(GroupHeader0__GetValue);
            GroupHeader0.Name = "GroupHeader0";
            GroupHeader0.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            GroupHeader0.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // GroupHeaderText0
            // 
            GroupHeaderText0 = new StiText();
            GroupHeaderText0.CanGrow = true;
            GroupHeaderText0.ClientRectangle = new RectangleD(0, 0, 19, 0.8);
            GroupHeaderText0.Name = "GroupHeaderText0";
            GroupHeaderText0.GetValue += new StiGetValueEventHandler(GroupHeaderText0__GetValue);
            GroupHeaderText0.VertAlignment = StiVertAlignment.Center;
            GroupHeaderText0.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            GroupHeaderText0.Brush = new StiSolidBrush(Color.Transparent);
            GroupHeaderText0.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            GroupHeaderText0.Guid = null;
            GroupHeaderText0.Interaction = null;
            GroupHeaderText0.Margins = new StiMargins(0, 0, 0, 0);
            GroupHeaderText0.TextBrush = new StiSolidBrush(Color.Black);
            GroupHeaderText0.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            GroupHeader0.Guid = null;
            GroupHeader0.Interaction = null;
            // 
            // Data
            // 
            Data = new StiDataBand();
            Data.ClientRectangle = new RectangleD(0, 5.2, 19, 0.6);
            Data.DataSourceName = "VW_SalesOrderHeader";
            Data.Name = "Data";
            Data.Sort = new[] {
                    "ASC",
                    "BranchName",
                    "ASC",
                    "OrderDate"};
            Data.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Data.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // DataText1
            // 
            DataText1 = new StiText();
            DataText1.ClientRectangle = new RectangleD(0, 0, 2.2, 0.6);
            DataText1.Name = "DataText1";
            DataText1.GetValue += new StiGetValueEventHandler(DataText1__GetValue);
            DataText1.VertAlignment = StiVertAlignment.Center;
            DataText1.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataText1.Brush = new StiSolidBrush(Color.Transparent);
            DataText1.Font = new Font("BPG Glaho Arial", 10F);
            DataText1.Guid = null;
            DataText1.Interaction = null;
            DataText1.Margins = new StiMargins(0, 0, 0, 0);
            DataText1.TextBrush = new StiSolidBrush(Color.Black);
            DataText1.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataText2
            // 
            DataText2 = new StiText();
            DataText2.ClientRectangle = new RectangleD(2.2, 0, 3.2, 0.6);
            DataText2.Name = "DataText2";
            DataText2.GetValue += new StiGetValueEventHandler(DataText2__GetValue);
            DataText2.VertAlignment = StiVertAlignment.Center;
            DataText2.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataText2.Brush = new StiSolidBrush(Color.Transparent);
            DataText2.Font = new Font("BPG Glaho Arial", 10F);
            DataText2.Guid = null;
            DataText2.Interaction = null;
            DataText2.Margins = new StiMargins(0, 0, 0, 0);
            DataText2.TextBrush = new StiSolidBrush(Color.Black);
            DataText2.TextFormat = new StiCustomFormatService("G");
            DataText2.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataText3
            // 
            DataText3 = new StiText();
            DataText3.ClientRectangle = new RectangleD(5.4, 0, 5.8, 0.6);
            DataText3.Name = "DataText3";
            DataText3.GetValue += new StiGetValueEventHandler(DataText3__GetValue);
            DataText3.Type = StiSystemTextType.Expression;
            DataText3.VertAlignment = StiVertAlignment.Center;
            DataText3.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataText3.Brush = new StiSolidBrush(Color.Transparent);
            DataText3.Font = new Font("BPG Glaho Arial", 10F);
            DataText3.Guid = null;
            DataText3.Interaction = null;
            DataText3.Margins = new StiMargins(0, 0, 0, 0);
            DataText3.TextBrush = new StiSolidBrush(Color.Black);
            DataText3.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataText4
            // 
            DataText4 = new StiText();
            DataText4.ClientRectangle = new RectangleD(11.2, 0, 2.8, 0.6);
            DataText4.HorAlignment = StiTextHorAlignment.Right;
            DataText4.Name = "DataText4";
            DataText4.GetValue += new StiGetValueEventHandler(DataText4__GetValue);
            DataText4.VertAlignment = StiVertAlignment.Center;
            DataText4.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataText4.Brush = new StiSolidBrush(Color.Transparent);
            DataText4.Font = new Font("BPG Glaho Arial", 10F);
            DataText4.Guid = null;
            DataText4.Interaction = null;
            DataText4.Margins = new StiMargins(0, 0, 0, 0);
            DataText4.TextBrush = new StiSolidBrush(Color.Black);
            DataText4.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, true, " ");
            DataText4.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataText5
            // 
            DataText5 = new StiText();
            DataText5.ClientRectangle = new RectangleD(14, 0, 1.6, 0.6);
            DataText5.HorAlignment = StiTextHorAlignment.Center;
            DataText5.Name = "DataText5";
            DataText5.GetValue += new StiGetValueEventHandler(DataText5__GetValue);
            DataText5.VertAlignment = StiVertAlignment.Center;
            DataText5.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataText5.Brush = new StiSolidBrush(Color.Transparent);
            DataText5.Font = new Font("BPG Glaho Arial", 10F);
            DataText5.Guid = null;
            DataText5.Interaction = null;
            DataText5.Margins = new StiMargins(0, 0, 0, 0);
            DataText5.TextBrush = new StiSolidBrush(Color.Black);
            DataText5.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataText6
            // 
            DataText6 = new StiText();
            DataText6.ClientRectangle = new RectangleD(15.6, 0, 3.4, 0.6);
            DataText6.Name = "DataText6";
            DataText6.GetValue += new StiGetValueEventHandler(DataText6__GetValue);
            DataText6.VertAlignment = StiVertAlignment.Center;
            DataText6.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataText6.Brush = new StiSolidBrush(Color.Transparent);
            DataText6.Font = new Font("BPG Glaho Arial", 10F);
            DataText6.Guid = null;
            DataText6.Interaction = null;
            DataText6.Margins = new StiMargins(0, 0, 0, 0);
            DataText6.TextBrush = new StiSolidBrush(Color.Black);
            DataText6.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            Data.Guid = null;
            Data.Interaction = null;
            Data.MasterComponent = null;
            // 
            // GroupFooter0
            // 
            GroupFooter0 = new StiGroupFooterBand();
            GroupFooter0.ClientRectangle = new RectangleD(0, 6.6, 19, 0.4);
            GroupFooter0.Name = "GroupFooter0";
            GroupFooter0.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            GroupFooter0.Brush = new StiSolidBrush(Color.Transparent);
            GroupFooter0.Guid = null;
            GroupFooter0.Interaction = null;
            // 
            // Footer
            // 
            Footer = new StiFooterBand();
            Footer.ClientRectangle = new RectangleD(0, 7.8, 19, 0.6);
            Footer.Name = "Footer";
            Footer.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Footer.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // FooterText1
            // 
            FooterText1 = new StiText();
            FooterText1.CanGrow = true;
            FooterText1.ClientRectangle = new RectangleD(0, 0, 2.2, 0.6);
            FooterText1.HorAlignment = StiTextHorAlignment.Center;
            FooterText1.Name = "FooterText1";
            // 
            // FooterText1_Count
            // 
            FooterText1.GetValue += new StiGetValueEventHandler(FooterText1__GetValue);
            FooterText1.Type = StiSystemTextType.Expression;
            FooterText1.VertAlignment = StiVertAlignment.Center;
            FooterText1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            FooterText1.Brush = new StiSolidBrush(Color.Transparent);
            FooterText1.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            FooterText1.Guid = null;
            FooterText1.Interaction = null;
            FooterText1.Margins = new StiMargins(0, 0, 0, 0);
            FooterText1.TextBrush = new StiSolidBrush(Color.Black);
            FooterText1.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text1
            // 
            Text1 = new StiText();
            Text1.ClientRectangle = new RectangleD(11.2, 0, 2.8, 0.6);
            Text1.HorAlignment = StiTextHorAlignment.Right;
            Text1.Name = "Text1";
            // 
            // Text1_Sum
            // 
            Text1.GetValue += new StiGetValueEventHandler(Text1__GetValue);
            Text1.Type = StiSystemTextType.Totals;
            Text1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text1.Brush = new StiSolidBrush(Color.Transparent);
            Text1.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            Text1.Guid = null;
            Text1.Interaction = null;
            Text1.Margins = new StiMargins(0, 0, 0, 0);
            Text1.TextBrush = new StiSolidBrush(Color.Black);
            Text1.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, true, " ");
            Text1.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            Footer.Guid = null;
            Footer.Interaction = null;
            Page1.ExcelSheetValue = null;
            Page1.Interaction = null;
            Page1.Margins = new StiMargins(1, 1, 1, 1);
            Page1_Watermark = new StiWatermark();
            Page1_Watermark.Font = new Font("Arial", 100F);
            Page1_Watermark.Image = null;
            Page1_Watermark.TextBrush = new StiSolidBrush(Color.FromArgb(50, 0, 0, 0));
            RptSalesOrderHeader_PrinterSettings = new StiPrinterSettings();
            PrinterSettings = RptSalesOrderHeader_PrinterSettings;
            Page1.Page = Page1;
            Page1.Report = this;
            Page1.Watermark = Page1_Watermark;
            ReportTitle.Page = Page1;
            ReportTitle.Parent = Page1;
            ReportTitleText.Page = Page1;
            ReportTitleText.Parent = ReportTitle;
            Header.Page = Page1;
            Header.Parent = Page1;
            HeaderText1.Page = Page1;
            HeaderText1.Parent = Header;
            HeaderText2.Page = Page1;
            HeaderText2.Parent = Header;
            HeaderText3.Page = Page1;
            HeaderText3.Parent = Header;
            HeaderText4.Page = Page1;
            HeaderText4.Parent = Header;
            HeaderText5.Page = Page1;
            HeaderText5.Parent = Header;
            HeaderText6.Page = Page1;
            HeaderText6.Parent = Header;
            GroupHeader0.Page = Page1;
            GroupHeader0.Parent = Page1;
            GroupHeaderText0.Page = Page1;
            GroupHeaderText0.Parent = GroupHeader0;
            Data.Page = Page1;
            Data.Parent = Page1;
            DataText1.Page = Page1;
            DataText1.Parent = Data;
            DataText2.Page = Page1;
            DataText2.Parent = Data;
            DataText3.Page = Page1;
            DataText3.Parent = Data;
            DataText4.Page = Page1;
            DataText4.Parent = Data;
            DataText5.Page = Page1;
            DataText5.Parent = Data;
            DataText6.Page = Page1;
            DataText6.Parent = Data;
            GroupFooter0.Page = Page1;
            GroupFooter0.Parent = Page1;
            Footer.Page = Page1;
            Footer.Parent = Page1;
            FooterText1.Page = Page1;
            FooterText1.Parent = Footer;
            Text1.Page = Page1;
            Text1.Parent = Footer;
            Data.BeginRender += new EventHandler(Data__BeginRender);
            Data.EndRender += new EventHandler(Data__EndRender);
            Data.Rendering += new EventHandler(Data__Rendering);
            AggregateFunctions = new object[] {
                    FooterText1_Count,
                    Text1_Sum};
            // 
            // Add to ReportTitle.Components
            // 
            ReportTitle.Components.Clear();
            ReportTitle.Components.AddRange(new StiComponent[] {
                        ReportTitleText});
            // 
            // Add to Header.Components
            // 
            Header.Components.Clear();
            Header.Components.AddRange(new StiComponent[] {
                        HeaderText1,
                        HeaderText2,
                        HeaderText3,
                        HeaderText4,
                        HeaderText5,
                        HeaderText6});
            // 
            // Add to GroupHeader0.Components
            // 
            GroupHeader0.Components.Clear();
            GroupHeader0.Components.AddRange(new StiComponent[] {
                        GroupHeaderText0});
            // 
            // Add to Data.Components
            // 
            Data.Components.Clear();
            Data.Components.AddRange(new StiComponent[] {
                        DataText1,
                        DataText2,
                        DataText3,
                        DataText4,
                        DataText5,
                        DataText6});
            // 
            // Add to Footer.Components
            // 
            Footer.Components.Clear();
            Footer.Components.AddRange(new StiComponent[] {
                        FooterText1,
                        Text1});
            // 
            // Add to Page1.Components
            // 
            Page1.Components.Clear();
            Page1.Components.AddRange(new StiComponent[] {
                        ReportTitle,
                        Header,
                        GroupHeader0,
                        Data,
                        GroupFooter0,
                        Footer});
            // 
            // Add to Pages
            // 
            Pages.Clear();
            Pages.AddRange(new[] {
                        Page1});
            VW_SalesOrderHeader.Columns.AddRange(new[] {
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
            DataSources.Add(VW_SalesOrderHeader);
        }

        #region DataSource VW_SalesOrderHeader
        public class VW_SalesOrderHeaderDataSource : StiDataTableSource
        {

            public VW_SalesOrderHeaderDataSource() :
                base("DS_Sales.VW_SalesOrderHeader", "VW_SalesOrderHeader")
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
        #endregion DataSource VW_SalesOrderHeader
        #endregion StiReport Designer generated code - do not modify
    }
}
