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

    public class RptSalesOrderDetailInfo : StiReport
    {

        public RptSalesOrderDetailInfo()
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
        public StiPageFooterBand PageFooterBand1;
        public StiText Text3;
        public StiHeaderBand HeaderVW_SalesOrderDetailInfo;
        public StiText HeaderVW_SalesOrderDetailInfo_MedicamentName;
        public StiText HeaderVW_SalesOrderDetailInfo_CountryName;
        public StiText HeaderVW_SalesOrderDetailInfo_SaleQty;
        public StiText HeaderVW_SalesOrderDetailInfo_Quantity;
        public StiDataBand DataVW_SalesOrderDetailInfo;
        public StiText DataVW_SalesOrderDetailInfo_MedicamentName;
        public StiText DataVW_SalesOrderDetailInfo_CountryName;
        public StiText DataVW_SalesOrderDetailInfo_SaleQty;
        public StiText DataVW_SalesOrderDetailInfo_Quantity;
        public StiFooterBand FooterVW_SalesOrderDetailInfo;
        public StiText FooterVW_SalesOrderDetailInfo_MedicamentName;
        public StiText FooterVW_SalesOrderDetailInfo_CountryName;
        public StiText FooterVW_SalesOrderDetailInfo_SaleQty;
        public StiText FooterVW_SalesOrderDetailInfo_Quantity;
        public StiWatermark Page1_Watermark;
        public StiPrinterSettings RptSalesOrderDetailInfo_PrinterSettings;
        public VW_SalesOrderDetailInfoDataSource VW_SalesOrderDetailInfo;

        public void Text3__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{PageNofM}";
            e.StoreToPrinted = true;
        }

        public String Text3_GetValue_End(StiComponent sender)
        {
            return ToString(sender, PageNofM, true);
        }

        public void HeaderVW_SalesOrderDetailInfo_MedicamentName__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "მედიკამენტი";
        }

        public void HeaderVW_SalesOrderDetailInfo_CountryName__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ქვეყანა";
        }

        public void HeaderVW_SalesOrderDetailInfo_SaleQty__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "გაყიდული\r\nრაოდ.";
        }

        public void HeaderVW_SalesOrderDetailInfo_Quantity__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ნაშთი";
        }

        public void DataVW_SalesOrderDetailInfo_MedicamentName__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, VW_SalesOrderDetailInfo.MedicamentName, true);
        }

        public void DataVW_SalesOrderDetailInfo_CountryName__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, VW_SalesOrderDetailInfo.CountryName, true);
        }

        public void DataVW_SalesOrderDetailInfo_SaleQty__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = DataVW_SalesOrderDetailInfo_SaleQty.TextFormat.Format(CheckExcelValue(sender, VW_SalesOrderDetailInfo.SaleQty));
        }

        public void DataVW_SalesOrderDetailInfo_Quantity__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = DataVW_SalesOrderDetailInfo_Quantity.TextFormat.Format(CheckExcelValue(sender, VW_SalesOrderDetailInfo.Quantity));
        }

        public void RptSalesOrderDetailInfoWordsToEnd__EndRender(object sender, EventArgs e)
        {
            Text3.SetText(new StiGetValue(Text3_GetValue_End));
        }

        private void InitializeComponent()
        {
            VW_SalesOrderDetailInfo = new VW_SalesOrderDetailInfoDataSource();
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
            ReportAlias = "Rpt Sales Order Detail Info";
            ReportAuthor = "Programmer.GE";
            // 
            // ReportChanged
            // 
            ReportChanged = new DateTime(2009, 6, 29, 23, 0, 32, 703);
            // 
            // ReportCreated
            // 
            ReportCreated = new DateTime(2009, 6, 29, 22, 4, 53, 0);
            ReportDescription = "გაყიდვების დეტალური ინფორმაცია";
            ReportGuid = "994aab3125de4ed8b1e5512fa21b244b";
            ReportName = "RptSalesOrderDetailInfo";
            ReportUnit = StiReportUnitType.Centimeters;
            ScriptLanguage = StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            Page1 = new StiPage();
            Page1.Guid = "fe7a8278e9664c07ba291423149a5d7d";
            Page1.Name = "Page1";
            Page1.PageHeight = 29.7;
            Page1.PageWidth = 21;
            Page1.PaperSize = PaperKind.A4;
            Page1.Border = new StiBorder(StiBorderSides.None, Color.Black, 2, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Page1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // PageFooterBand1
            // 
            PageFooterBand1 = new StiPageFooterBand();
            PageFooterBand1.ClientRectangle = new RectangleD(0, 27.1, 19, 0.6);
            PageFooterBand1.Guid = "aaa8ae54769b4b049f5c531048b975aa";
            PageFooterBand1.Name = "PageFooterBand1";
            PageFooterBand1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            PageFooterBand1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text3
            // 
            Text3 = new StiText();
            Text3.ClientRectangle = new RectangleD(0, 0, 19, 0.6);
            Text3.Guid = "98d564088e19468b8a13fb930b209780";
            Text3.HorAlignment = StiTextHorAlignment.Center;
            Text3.Name = "Text3";
            Text3.GetValue += new StiGetValueEventHandler(Text3__GetValue);
            Text3.Type = StiSystemTextType.Expression;
            Text3.VertAlignment = StiVertAlignment.Center;
            Text3.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text3.Brush = new StiSolidBrush(Color.Transparent);
            Text3.Font = new Font("Arial", 8F);
            Text3.Interaction = null;
            Text3.Margins = new StiMargins(0, 0, 0, 0);
            Text3.TextBrush = new StiSolidBrush(Color.Black);
            Text3.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            PageFooterBand1.Interaction = null;
            // 
            // HeaderVW_SalesOrderDetailInfo
            // 
            HeaderVW_SalesOrderDetailInfo = new StiHeaderBand();
            HeaderVW_SalesOrderDetailInfo.ClientRectangle = new RectangleD(0, 0.4, 19, 0.8);
            HeaderVW_SalesOrderDetailInfo.Name = "HeaderVW_SalesOrderDetailInfo";
            HeaderVW_SalesOrderDetailInfo.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_SalesOrderDetailInfo.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // HeaderVW_SalesOrderDetailInfo_MedicamentName
            // 
            HeaderVW_SalesOrderDetailInfo_MedicamentName = new StiText();
            HeaderVW_SalesOrderDetailInfo_MedicamentName.ClientRectangle = new RectangleD(0, 0, 9.8, 0.8);
            HeaderVW_SalesOrderDetailInfo_MedicamentName.HorAlignment = StiTextHorAlignment.Center;
            HeaderVW_SalesOrderDetailInfo_MedicamentName.Name = "HeaderVW_SalesOrderDetailInfo_MedicamentName";
            HeaderVW_SalesOrderDetailInfo_MedicamentName.GetValue += new StiGetValueEventHandler(HeaderVW_SalesOrderDetailInfo_MedicamentName__GetValue);
            HeaderVW_SalesOrderDetailInfo_MedicamentName.Type = StiSystemTextType.Expression;
            HeaderVW_SalesOrderDetailInfo_MedicamentName.VertAlignment = StiVertAlignment.Center;
            HeaderVW_SalesOrderDetailInfo_MedicamentName.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_SalesOrderDetailInfo_MedicamentName.Brush = new StiSolidBrush(Color.Transparent);
            HeaderVW_SalesOrderDetailInfo_MedicamentName.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderVW_SalesOrderDetailInfo_MedicamentName.Guid = null;
            HeaderVW_SalesOrderDetailInfo_MedicamentName.Interaction = null;
            HeaderVW_SalesOrderDetailInfo_MedicamentName.Margins = new StiMargins(0, 0, 0, 0);
            HeaderVW_SalesOrderDetailInfo_MedicamentName.TextBrush = new StiSolidBrush(Color.Black);
            HeaderVW_SalesOrderDetailInfo_MedicamentName.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderVW_SalesOrderDetailInfo_CountryName
            // 
            HeaderVW_SalesOrderDetailInfo_CountryName = new StiText();
            HeaderVW_SalesOrderDetailInfo_CountryName.ClientRectangle = new RectangleD(9.8, 0, 4, 0.8);
            HeaderVW_SalesOrderDetailInfo_CountryName.HorAlignment = StiTextHorAlignment.Center;
            HeaderVW_SalesOrderDetailInfo_CountryName.Name = "HeaderVW_SalesOrderDetailInfo_CountryName";
            HeaderVW_SalesOrderDetailInfo_CountryName.GetValue += new StiGetValueEventHandler(HeaderVW_SalesOrderDetailInfo_CountryName__GetValue);
            HeaderVW_SalesOrderDetailInfo_CountryName.Type = StiSystemTextType.Expression;
            HeaderVW_SalesOrderDetailInfo_CountryName.VertAlignment = StiVertAlignment.Center;
            HeaderVW_SalesOrderDetailInfo_CountryName.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_SalesOrderDetailInfo_CountryName.Brush = new StiSolidBrush(Color.Transparent);
            HeaderVW_SalesOrderDetailInfo_CountryName.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderVW_SalesOrderDetailInfo_CountryName.Guid = null;
            HeaderVW_SalesOrderDetailInfo_CountryName.Interaction = null;
            HeaderVW_SalesOrderDetailInfo_CountryName.Margins = new StiMargins(0, 0, 0, 0);
            HeaderVW_SalesOrderDetailInfo_CountryName.TextBrush = new StiSolidBrush(Color.Black);
            HeaderVW_SalesOrderDetailInfo_CountryName.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderVW_SalesOrderDetailInfo_SaleQty
            // 
            HeaderVW_SalesOrderDetailInfo_SaleQty = new StiText();
            HeaderVW_SalesOrderDetailInfo_SaleQty.ClientRectangle = new RectangleD(13.8, 0, 2.6, 0.8);
            HeaderVW_SalesOrderDetailInfo_SaleQty.HorAlignment = StiTextHorAlignment.Center;
            HeaderVW_SalesOrderDetailInfo_SaleQty.Name = "HeaderVW_SalesOrderDetailInfo_SaleQty";
            HeaderVW_SalesOrderDetailInfo_SaleQty.GetValue += new StiGetValueEventHandler(HeaderVW_SalesOrderDetailInfo_SaleQty__GetValue);
            HeaderVW_SalesOrderDetailInfo_SaleQty.Type = StiSystemTextType.Expression;
            HeaderVW_SalesOrderDetailInfo_SaleQty.VertAlignment = StiVertAlignment.Center;
            HeaderVW_SalesOrderDetailInfo_SaleQty.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_SalesOrderDetailInfo_SaleQty.Brush = new StiSolidBrush(Color.Transparent);
            HeaderVW_SalesOrderDetailInfo_SaleQty.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderVW_SalesOrderDetailInfo_SaleQty.Guid = null;
            HeaderVW_SalesOrderDetailInfo_SaleQty.Interaction = null;
            HeaderVW_SalesOrderDetailInfo_SaleQty.Margins = new StiMargins(0, 0, 0, 0);
            HeaderVW_SalesOrderDetailInfo_SaleQty.TextBrush = new StiSolidBrush(Color.Black);
            HeaderVW_SalesOrderDetailInfo_SaleQty.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderVW_SalesOrderDetailInfo_Quantity
            // 
            HeaderVW_SalesOrderDetailInfo_Quantity = new StiText();
            HeaderVW_SalesOrderDetailInfo_Quantity.ClientRectangle = new RectangleD(16.4, 0, 2.6, 0.8);
            HeaderVW_SalesOrderDetailInfo_Quantity.HorAlignment = StiTextHorAlignment.Center;
            HeaderVW_SalesOrderDetailInfo_Quantity.Name = "HeaderVW_SalesOrderDetailInfo_Quantity";
            HeaderVW_SalesOrderDetailInfo_Quantity.GetValue += new StiGetValueEventHandler(HeaderVW_SalesOrderDetailInfo_Quantity__GetValue);
            HeaderVW_SalesOrderDetailInfo_Quantity.Type = StiSystemTextType.Expression;
            HeaderVW_SalesOrderDetailInfo_Quantity.VertAlignment = StiVertAlignment.Center;
            HeaderVW_SalesOrderDetailInfo_Quantity.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_SalesOrderDetailInfo_Quantity.Brush = new StiSolidBrush(Color.Transparent);
            HeaderVW_SalesOrderDetailInfo_Quantity.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderVW_SalesOrderDetailInfo_Quantity.Guid = null;
            HeaderVW_SalesOrderDetailInfo_Quantity.Interaction = null;
            HeaderVW_SalesOrderDetailInfo_Quantity.Margins = new StiMargins(0, 0, 0, 0);
            HeaderVW_SalesOrderDetailInfo_Quantity.TextBrush = new StiSolidBrush(Color.Black);
            HeaderVW_SalesOrderDetailInfo_Quantity.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            HeaderVW_SalesOrderDetailInfo.Guid = null;
            HeaderVW_SalesOrderDetailInfo.Interaction = null;
            // 
            // DataVW_SalesOrderDetailInfo
            // 
            DataVW_SalesOrderDetailInfo = new StiDataBand();
            DataVW_SalesOrderDetailInfo.ClientRectangle = new RectangleD(0, 2, 19, 0.6);
            DataVW_SalesOrderDetailInfo.DataSourceName = "VW_SalesOrderDetailInfo";
            DataVW_SalesOrderDetailInfo.Name = "DataVW_SalesOrderDetailInfo";
            DataVW_SalesOrderDetailInfo.Sort = new String[0];
            DataVW_SalesOrderDetailInfo.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataVW_SalesOrderDetailInfo.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // DataVW_SalesOrderDetailInfo_MedicamentName
            // 
            DataVW_SalesOrderDetailInfo_MedicamentName = new StiText();
            DataVW_SalesOrderDetailInfo_MedicamentName.CanGrow = true;
            DataVW_SalesOrderDetailInfo_MedicamentName.ClientRectangle = new RectangleD(0, 0, 9.8, 0.6);
            DataVW_SalesOrderDetailInfo_MedicamentName.Name = "DataVW_SalesOrderDetailInfo_MedicamentName";
            DataVW_SalesOrderDetailInfo_MedicamentName.GetValue += new StiGetValueEventHandler(DataVW_SalesOrderDetailInfo_MedicamentName__GetValue);
            DataVW_SalesOrderDetailInfo_MedicamentName.VertAlignment = StiVertAlignment.Center;
            DataVW_SalesOrderDetailInfo_MedicamentName.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataVW_SalesOrderDetailInfo_MedicamentName.Brush = new StiSolidBrush(Color.Transparent);
            DataVW_SalesOrderDetailInfo_MedicamentName.Font = new Font("BPG Glaho Arial", 8F);
            DataVW_SalesOrderDetailInfo_MedicamentName.Guid = null;
            DataVW_SalesOrderDetailInfo_MedicamentName.Interaction = null;
            DataVW_SalesOrderDetailInfo_MedicamentName.Margins = new StiMargins(0, 0, 0, 0);
            DataVW_SalesOrderDetailInfo_MedicamentName.TextBrush = new StiSolidBrush(Color.Black);
            DataVW_SalesOrderDetailInfo_MedicamentName.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataVW_SalesOrderDetailInfo_CountryName
            // 
            DataVW_SalesOrderDetailInfo_CountryName = new StiText();
            DataVW_SalesOrderDetailInfo_CountryName.CanGrow = true;
            DataVW_SalesOrderDetailInfo_CountryName.ClientRectangle = new RectangleD(9.8, 0, 4, 0.6);
            DataVW_SalesOrderDetailInfo_CountryName.Name = "DataVW_SalesOrderDetailInfo_CountryName";
            DataVW_SalesOrderDetailInfo_CountryName.GetValue += new StiGetValueEventHandler(DataVW_SalesOrderDetailInfo_CountryName__GetValue);
            DataVW_SalesOrderDetailInfo_CountryName.VertAlignment = StiVertAlignment.Center;
            DataVW_SalesOrderDetailInfo_CountryName.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataVW_SalesOrderDetailInfo_CountryName.Brush = new StiSolidBrush(Color.Transparent);
            DataVW_SalesOrderDetailInfo_CountryName.Font = new Font("BPG Glaho Arial", 8F);
            DataVW_SalesOrderDetailInfo_CountryName.Guid = null;
            DataVW_SalesOrderDetailInfo_CountryName.Interaction = null;
            DataVW_SalesOrderDetailInfo_CountryName.Margins = new StiMargins(0, 0, 0, 0);
            DataVW_SalesOrderDetailInfo_CountryName.TextBrush = new StiSolidBrush(Color.Black);
            DataVW_SalesOrderDetailInfo_CountryName.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataVW_SalesOrderDetailInfo_SaleQty
            // 
            DataVW_SalesOrderDetailInfo_SaleQty = new StiText();
            DataVW_SalesOrderDetailInfo_SaleQty.CanGrow = true;
            DataVW_SalesOrderDetailInfo_SaleQty.ClientRectangle = new RectangleD(13.8, 0, 2.6, 0.6);
            DataVW_SalesOrderDetailInfo_SaleQty.HorAlignment = StiTextHorAlignment.Right;
            DataVW_SalesOrderDetailInfo_SaleQty.Name = "DataVW_SalesOrderDetailInfo_SaleQty";
            DataVW_SalesOrderDetailInfo_SaleQty.GetValue += new StiGetValueEventHandler(DataVW_SalesOrderDetailInfo_SaleQty__GetValue);
            DataVW_SalesOrderDetailInfo_SaleQty.VertAlignment = StiVertAlignment.Center;
            DataVW_SalesOrderDetailInfo_SaleQty.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataVW_SalesOrderDetailInfo_SaleQty.Brush = new StiSolidBrush(Color.Transparent);
            DataVW_SalesOrderDetailInfo_SaleQty.Font = new Font("BPG Glaho Arial", 8F);
            DataVW_SalesOrderDetailInfo_SaleQty.Guid = null;
            DataVW_SalesOrderDetailInfo_SaleQty.Interaction = null;
            DataVW_SalesOrderDetailInfo_SaleQty.Margins = new StiMargins(0, 0, 0, 0);
            DataVW_SalesOrderDetailInfo_SaleQty.TextBrush = new StiSolidBrush(Color.Black);
            DataVW_SalesOrderDetailInfo_SaleQty.TextFormat = new StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            DataVW_SalesOrderDetailInfo_SaleQty.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataVW_SalesOrderDetailInfo_Quantity
            // 
            DataVW_SalesOrderDetailInfo_Quantity = new StiText();
            DataVW_SalesOrderDetailInfo_Quantity.CanGrow = true;
            DataVW_SalesOrderDetailInfo_Quantity.ClientRectangle = new RectangleD(16.4, 0, 2.6, 0.6);
            DataVW_SalesOrderDetailInfo_Quantity.HorAlignment = StiTextHorAlignment.Right;
            DataVW_SalesOrderDetailInfo_Quantity.Name = "DataVW_SalesOrderDetailInfo_Quantity";
            DataVW_SalesOrderDetailInfo_Quantity.GetValue += new StiGetValueEventHandler(DataVW_SalesOrderDetailInfo_Quantity__GetValue);
            DataVW_SalesOrderDetailInfo_Quantity.VertAlignment = StiVertAlignment.Center;
            DataVW_SalesOrderDetailInfo_Quantity.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataVW_SalesOrderDetailInfo_Quantity.Brush = new StiSolidBrush(Color.Transparent);
            DataVW_SalesOrderDetailInfo_Quantity.Font = new Font("BPG Glaho Arial", 8F);
            DataVW_SalesOrderDetailInfo_Quantity.Guid = null;
            DataVW_SalesOrderDetailInfo_Quantity.Interaction = null;
            DataVW_SalesOrderDetailInfo_Quantity.Margins = new StiMargins(0, 0, 0, 0);
            DataVW_SalesOrderDetailInfo_Quantity.TextBrush = new StiSolidBrush(Color.Black);
            DataVW_SalesOrderDetailInfo_Quantity.TextFormat = new StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            DataVW_SalesOrderDetailInfo_Quantity.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            DataVW_SalesOrderDetailInfo.Guid = null;
            DataVW_SalesOrderDetailInfo.Interaction = null;
            DataVW_SalesOrderDetailInfo.MasterComponent = null;
            // 
            // FooterVW_SalesOrderDetailInfo
            // 
            FooterVW_SalesOrderDetailInfo = new StiFooterBand();
            FooterVW_SalesOrderDetailInfo.ClientRectangle = new RectangleD(0, 3.4, 19, 0.8);
            FooterVW_SalesOrderDetailInfo.Name = "FooterVW_SalesOrderDetailInfo";
            FooterVW_SalesOrderDetailInfo.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            FooterVW_SalesOrderDetailInfo.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // FooterVW_SalesOrderDetailInfo_MedicamentName
            // 
            FooterVW_SalesOrderDetailInfo_MedicamentName = new StiText();
            FooterVW_SalesOrderDetailInfo_MedicamentName.ClientRectangle = new RectangleD(0, 0, 4.8, 0.8);
            FooterVW_SalesOrderDetailInfo_MedicamentName.HorAlignment = StiTextHorAlignment.Right;
            FooterVW_SalesOrderDetailInfo_MedicamentName.Name = "FooterVW_SalesOrderDetailInfo_MedicamentName";
            FooterVW_SalesOrderDetailInfo_MedicamentName.VertAlignment = StiVertAlignment.Center;
            FooterVW_SalesOrderDetailInfo_MedicamentName.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            FooterVW_SalesOrderDetailInfo_MedicamentName.Brush = new StiSolidBrush(Color.Transparent);
            FooterVW_SalesOrderDetailInfo_MedicamentName.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            FooterVW_SalesOrderDetailInfo_MedicamentName.Guid = null;
            FooterVW_SalesOrderDetailInfo_MedicamentName.Interaction = null;
            FooterVW_SalesOrderDetailInfo_MedicamentName.Margins = new StiMargins(0, 0, 0, 0);
            FooterVW_SalesOrderDetailInfo_MedicamentName.TextBrush = new StiSolidBrush(Color.Black);
            FooterVW_SalesOrderDetailInfo_MedicamentName.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // FooterVW_SalesOrderDetailInfo_CountryName
            // 
            FooterVW_SalesOrderDetailInfo_CountryName = new StiText();
            FooterVW_SalesOrderDetailInfo_CountryName.ClientRectangle = new RectangleD(4.8, 0, 4.8, 0.8);
            FooterVW_SalesOrderDetailInfo_CountryName.HorAlignment = StiTextHorAlignment.Right;
            FooterVW_SalesOrderDetailInfo_CountryName.Name = "FooterVW_SalesOrderDetailInfo_CountryName";
            FooterVW_SalesOrderDetailInfo_CountryName.VertAlignment = StiVertAlignment.Center;
            FooterVW_SalesOrderDetailInfo_CountryName.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            FooterVW_SalesOrderDetailInfo_CountryName.Brush = new StiSolidBrush(Color.Transparent);
            FooterVW_SalesOrderDetailInfo_CountryName.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            FooterVW_SalesOrderDetailInfo_CountryName.Guid = null;
            FooterVW_SalesOrderDetailInfo_CountryName.Interaction = null;
            FooterVW_SalesOrderDetailInfo_CountryName.Margins = new StiMargins(0, 0, 0, 0);
            FooterVW_SalesOrderDetailInfo_CountryName.TextBrush = new StiSolidBrush(Color.Black);
            FooterVW_SalesOrderDetailInfo_CountryName.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // FooterVW_SalesOrderDetailInfo_SaleQty
            // 
            FooterVW_SalesOrderDetailInfo_SaleQty = new StiText();
            FooterVW_SalesOrderDetailInfo_SaleQty.ClientRectangle = new RectangleD(9.6, 0, 4.8, 0.8);
            FooterVW_SalesOrderDetailInfo_SaleQty.HorAlignment = StiTextHorAlignment.Right;
            FooterVW_SalesOrderDetailInfo_SaleQty.Name = "FooterVW_SalesOrderDetailInfo_SaleQty";
            FooterVW_SalesOrderDetailInfo_SaleQty.VertAlignment = StiVertAlignment.Center;
            FooterVW_SalesOrderDetailInfo_SaleQty.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            FooterVW_SalesOrderDetailInfo_SaleQty.Brush = new StiSolidBrush(Color.Transparent);
            FooterVW_SalesOrderDetailInfo_SaleQty.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            FooterVW_SalesOrderDetailInfo_SaleQty.Guid = null;
            FooterVW_SalesOrderDetailInfo_SaleQty.Interaction = null;
            FooterVW_SalesOrderDetailInfo_SaleQty.Margins = new StiMargins(0, 0, 0, 0);
            FooterVW_SalesOrderDetailInfo_SaleQty.TextBrush = new StiSolidBrush(Color.Black);
            FooterVW_SalesOrderDetailInfo_SaleQty.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // FooterVW_SalesOrderDetailInfo_Quantity
            // 
            FooterVW_SalesOrderDetailInfo_Quantity = new StiText();
            FooterVW_SalesOrderDetailInfo_Quantity.ClientRectangle = new RectangleD(14.4, 0, 4.6, 0.8);
            FooterVW_SalesOrderDetailInfo_Quantity.HorAlignment = StiTextHorAlignment.Right;
            FooterVW_SalesOrderDetailInfo_Quantity.Name = "FooterVW_SalesOrderDetailInfo_Quantity";
            FooterVW_SalesOrderDetailInfo_Quantity.VertAlignment = StiVertAlignment.Center;
            FooterVW_SalesOrderDetailInfo_Quantity.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            FooterVW_SalesOrderDetailInfo_Quantity.Brush = new StiSolidBrush(Color.Transparent);
            FooterVW_SalesOrderDetailInfo_Quantity.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            FooterVW_SalesOrderDetailInfo_Quantity.Guid = null;
            FooterVW_SalesOrderDetailInfo_Quantity.Interaction = null;
            FooterVW_SalesOrderDetailInfo_Quantity.Margins = new StiMargins(0, 0, 0, 0);
            FooterVW_SalesOrderDetailInfo_Quantity.TextBrush = new StiSolidBrush(Color.Black);
            FooterVW_SalesOrderDetailInfo_Quantity.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            FooterVW_SalesOrderDetailInfo.Guid = null;
            FooterVW_SalesOrderDetailInfo.Interaction = null;
            Page1.ExcelSheetValue = null;
            Page1.Interaction = null;
            Page1.Margins = new StiMargins(1, 1, 1, 1);
            Page1_Watermark = new StiWatermark();
            Page1_Watermark.Font = new Font("Arial", 100F);
            Page1_Watermark.Image = null;
            Page1_Watermark.TextBrush = new StiSolidBrush(Color.FromArgb(50, 0, 0, 0));
            RptSalesOrderDetailInfo_PrinterSettings = new StiPrinterSettings();
            PrinterSettings = RptSalesOrderDetailInfo_PrinterSettings;
            Page1.Page = Page1;
            Page1.Report = this;
            Page1.Watermark = Page1_Watermark;
            PageFooterBand1.Page = Page1;
            PageFooterBand1.Parent = Page1;
            Text3.Page = Page1;
            Text3.Parent = PageFooterBand1;
            HeaderVW_SalesOrderDetailInfo.Page = Page1;
            HeaderVW_SalesOrderDetailInfo.Parent = Page1;
            HeaderVW_SalesOrderDetailInfo_MedicamentName.Page = Page1;
            HeaderVW_SalesOrderDetailInfo_MedicamentName.Parent = HeaderVW_SalesOrderDetailInfo;
            HeaderVW_SalesOrderDetailInfo_CountryName.Page = Page1;
            HeaderVW_SalesOrderDetailInfo_CountryName.Parent = HeaderVW_SalesOrderDetailInfo;
            HeaderVW_SalesOrderDetailInfo_SaleQty.Page = Page1;
            HeaderVW_SalesOrderDetailInfo_SaleQty.Parent = HeaderVW_SalesOrderDetailInfo;
            HeaderVW_SalesOrderDetailInfo_Quantity.Page = Page1;
            HeaderVW_SalesOrderDetailInfo_Quantity.Parent = HeaderVW_SalesOrderDetailInfo;
            DataVW_SalesOrderDetailInfo.Page = Page1;
            DataVW_SalesOrderDetailInfo.Parent = Page1;
            DataVW_SalesOrderDetailInfo_MedicamentName.Page = Page1;
            DataVW_SalesOrderDetailInfo_MedicamentName.Parent = DataVW_SalesOrderDetailInfo;
            DataVW_SalesOrderDetailInfo_CountryName.Page = Page1;
            DataVW_SalesOrderDetailInfo_CountryName.Parent = DataVW_SalesOrderDetailInfo;
            DataVW_SalesOrderDetailInfo_SaleQty.Page = Page1;
            DataVW_SalesOrderDetailInfo_SaleQty.Parent = DataVW_SalesOrderDetailInfo;
            DataVW_SalesOrderDetailInfo_Quantity.Page = Page1;
            DataVW_SalesOrderDetailInfo_Quantity.Parent = DataVW_SalesOrderDetailInfo;
            FooterVW_SalesOrderDetailInfo.Page = Page1;
            FooterVW_SalesOrderDetailInfo.Parent = Page1;
            FooterVW_SalesOrderDetailInfo_MedicamentName.Page = Page1;
            FooterVW_SalesOrderDetailInfo_MedicamentName.Parent = FooterVW_SalesOrderDetailInfo;
            FooterVW_SalesOrderDetailInfo_CountryName.Page = Page1;
            FooterVW_SalesOrderDetailInfo_CountryName.Parent = FooterVW_SalesOrderDetailInfo;
            FooterVW_SalesOrderDetailInfo_SaleQty.Page = Page1;
            FooterVW_SalesOrderDetailInfo_SaleQty.Parent = FooterVW_SalesOrderDetailInfo;
            FooterVW_SalesOrderDetailInfo_Quantity.Page = Page1;
            FooterVW_SalesOrderDetailInfo_Quantity.Parent = FooterVW_SalesOrderDetailInfo;
            EndRender += new EventHandler(RptSalesOrderDetailInfoWordsToEnd__EndRender);
            // 
            // Add to PageFooterBand1.Components
            // 
            PageFooterBand1.Components.Clear();
            PageFooterBand1.Components.AddRange(new StiComponent[] {
                        Text3});
            // 
            // Add to HeaderVW_SalesOrderDetailInfo.Components
            // 
            HeaderVW_SalesOrderDetailInfo.Components.Clear();
            HeaderVW_SalesOrderDetailInfo.Components.AddRange(new StiComponent[] {
                        HeaderVW_SalesOrderDetailInfo_MedicamentName,
                        HeaderVW_SalesOrderDetailInfo_CountryName,
                        HeaderVW_SalesOrderDetailInfo_SaleQty,
                        HeaderVW_SalesOrderDetailInfo_Quantity});
            // 
            // Add to DataVW_SalesOrderDetailInfo.Components
            // 
            DataVW_SalesOrderDetailInfo.Components.Clear();
            DataVW_SalesOrderDetailInfo.Components.AddRange(new StiComponent[] {
                        DataVW_SalesOrderDetailInfo_MedicamentName,
                        DataVW_SalesOrderDetailInfo_CountryName,
                        DataVW_SalesOrderDetailInfo_SaleQty,
                        DataVW_SalesOrderDetailInfo_Quantity});
            // 
            // Add to FooterVW_SalesOrderDetailInfo.Components
            // 
            FooterVW_SalesOrderDetailInfo.Components.Clear();
            FooterVW_SalesOrderDetailInfo.Components.AddRange(new StiComponent[] {
                        FooterVW_SalesOrderDetailInfo_MedicamentName,
                        FooterVW_SalesOrderDetailInfo_CountryName,
                        FooterVW_SalesOrderDetailInfo_SaleQty,
                        FooterVW_SalesOrderDetailInfo_Quantity});
            // 
            // Add to Page1.Components
            // 
            Page1.Components.Clear();
            Page1.Components.AddRange(new StiComponent[] {
                        PageFooterBand1,
                        HeaderVW_SalesOrderDetailInfo,
                        DataVW_SalesOrderDetailInfo,
                        FooterVW_SalesOrderDetailInfo});
            // 
            // Add to Pages
            // 
            Pages.Clear();
            Pages.AddRange(new[] {
                        Page1});
            VW_SalesOrderDetailInfo.Columns.AddRange(new[] {
                        new StiDataColumn("SalesOrderDetailID", "SalesOrderDetailID", "SalesOrderDetailID", typeof(Guid)),
                        new StiDataColumn("SalesOrderID", "SalesOrderID", "SalesOrderID", typeof(int)),
                        new StiDataColumn("ProductLocationID", "ProductLocationID", "ProductLocationID", typeof(int)),
                        new StiDataColumn("BranchID", "BranchID", "BranchID", typeof(int)),
                        new StiDataColumn("BranchName", "BranchName", "BranchName", typeof(string)),
                        new StiDataColumn("OrderDate", "OrderDate", "OrderDate", typeof(DateTime)),
                        new StiDataColumn("CustomerID", "CustomerID", "CustomerID", typeof(int)),
                        new StiDataColumn("CustomerName", "CustomerName", "CustomerName", typeof(string)),
                        new StiDataColumn("SaleQty", "SaleQty", "SaleQty", typeof(decimal)),
                        new StiDataColumn("UnitPrice", "UnitPrice", "UnitPrice", typeof(decimal)),
                        new StiDataColumn("UnitPriceDiscount", "UnitPriceDiscount", "UnitPriceDiscount", typeof(decimal)),
                        new StiDataColumn("LineTotal", "LineTotal", "LineTotal", typeof(decimal)),
                        new StiDataColumn("OrdinalNumber", "OrdinalNumber", "OrdinalNumber", typeof(short)),
                        new StiDataColumn("Status", "Status", "Status", typeof(byte)),
                        new StiDataColumn("ModifiedUserID", "ModifiedUserID", "ModifiedUserID", typeof(int)),
                        new StiDataColumn("Modifier", "Modifier", "Modifier", typeof(string)),
                        new StiDataColumn("ModifiedDate", "ModifiedDate", "ModifiedDate", typeof(DateTime)),
                        new StiDataColumn("ProductID", "ProductID", "ProductID", typeof(int)),
                        new StiDataColumn("PurchaseOrderDetailID", "PurchaseOrderDetailID", "PurchaseOrderDetailID", typeof(Guid)),
                        new StiDataColumn("MedicamentID", "MedicamentID", "MedicamentID", typeof(int)),
                        new StiDataColumn("ProductNumber", "ProductNumber", "ProductNumber", typeof(string)),
                        new StiDataColumn("MedicamentName", "MedicamentName", "MedicamentName", typeof(string)),
                        new StiDataColumn("MedicamentCategoryID", "MedicamentCategoryID", "MedicamentCategoryID", typeof(int)),
                        new StiDataColumn("MedicamentCategoryName", "MedicamentCategoryName", "MedicamentCategoryName", typeof(string)),
                        new StiDataColumn("MedicamentSubcategoryID", "MedicamentSubcategoryID", "MedicamentSubcategoryID", typeof(int)),
                        new StiDataColumn("MedicamentSubcategoryName", "MedicamentSubcategoryName", "MedicamentSubcategoryName", typeof(string)),
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
                        new StiDataColumn("MakeFlag", "MakeFlag", "MakeFlag", typeof(bool)),
                        new StiDataColumn("FinishedGoodsFlag", "FinishedGoodsFlag", "FinishedGoodsFlag", typeof(bool)),
                        new StiDataColumn("Color", "Color", "Color", typeof(string)),
                        new StiDataColumn("SafetyStockLevel", "SafetyStockLevel", "SafetyStockLevel", typeof(short)),
                        new StiDataColumn("ReorderPoint", "ReorderPoint", "ReorderPoint", typeof(short)),
                        new StiDataColumn("Size", "Size", "Size", typeof(string)),
                        new StiDataColumn("SizeRange", "SizeRange", "SizeRange", typeof(string)),
                        new StiDataColumn("SizeUnitMeasureCode", "SizeUnitMeasureCode", "SizeUnitMeasureCode", typeof(string)),
                        new StiDataColumn("Weight", "Weight", "Weight", typeof(decimal)),
                        new StiDataColumn("WeightUnitMeasureCode", "WeightUnitMeasureCode", "WeightUnitMeasureCode", typeof(string)),
                        new StiDataColumn("DaysToManufacture", "DaysToManufacture", "DaysToManufacture", typeof(int)),
                        new StiDataColumn("ProductLine", "ProductLine", "ProductLine", typeof(string)),
                        new StiDataColumn("Class", "Class", "Class", typeof(string)),
                        new StiDataColumn("Style", "Style", "Style", typeof(string)),
                        new StiDataColumn("ProductModelID", "ProductModelID", "ProductModelID", typeof(int)),
                        new StiDataColumn("SellStartDate", "SellStartDate", "SellStartDate", typeof(DateTime)),
                        new StiDataColumn("SellEndDate", "SellEndDate", "SellEndDate", typeof(DateTime)),
                        new StiDataColumn("DiscontinuedDate", "DiscontinuedDate", "DiscontinuedDate", typeof(DateTime)),
                        new StiDataColumn("UnitsInStock", "UnitsInStock", "UnitsInStock", typeof(short))});
            DataSources.Add(VW_SalesOrderDetailInfo);
        }

        #region DataSource VW_SalesOrderDetailInfo
        public class VW_SalesOrderDetailInfoDataSource : StiDataTableSource
        {

            public VW_SalesOrderDetailInfoDataSource() :
                base("DS_Sales.VW_SalesOrderDetailInfo", "VW_SalesOrderDetailInfo")
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

            public virtual int ProductID
            {
                get
                {
                    return ((int)(ChangeType(this["ProductID"], typeof(int), true)));
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

            public virtual int MedicamentCategoryID
            {
                get
                {
                    return ((int)(ChangeType(this["MedicamentCategoryID"], typeof(int), true)));
                }
            }

            public virtual string MedicamentCategoryName
            {
                get
                {
                    return ((string)(ChangeType(this["MedicamentCategoryName"], typeof(string), true)));
                }
            }

            public virtual int MedicamentSubcategoryID
            {
                get
                {
                    return ((int)(ChangeType(this["MedicamentSubcategoryID"], typeof(int), true)));
                }
            }

            public virtual string MedicamentSubcategoryName
            {
                get
                {
                    return ((string)(ChangeType(this["MedicamentSubcategoryName"], typeof(string), true)));
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

            public virtual bool MakeFlag
            {
                get
                {
                    return ((bool)(ChangeType(this["MakeFlag"], typeof(bool), true)));
                }
            }

            public virtual bool FinishedGoodsFlag
            {
                get
                {
                    return ((bool)(ChangeType(this["FinishedGoodsFlag"], typeof(bool), true)));
                }
            }

            public virtual string Color
            {
                get
                {
                    return ((string)(ChangeType(this["Color"], typeof(string), true)));
                }
            }

            public virtual short SafetyStockLevel
            {
                get
                {
                    return ((short)(ChangeType(this["SafetyStockLevel"], typeof(short), true)));
                }
            }

            public virtual short ReorderPoint
            {
                get
                {
                    return ((short)(ChangeType(this["ReorderPoint"], typeof(short), true)));
                }
            }

            public virtual string Size
            {
                get
                {
                    return ((string)(ChangeType(this["Size"], typeof(string), true)));
                }
            }

            public virtual string SizeRange
            {
                get
                {
                    return ((string)(ChangeType(this["SizeRange"], typeof(string), true)));
                }
            }

            public virtual string SizeUnitMeasureCode
            {
                get
                {
                    return ((string)(ChangeType(this["SizeUnitMeasureCode"], typeof(string), true)));
                }
            }

            public virtual decimal Weight
            {
                get
                {
                    return ((decimal)(ChangeType(this["Weight"], typeof(decimal), true)));
                }
            }

            public virtual string WeightUnitMeasureCode
            {
                get
                {
                    return ((string)(ChangeType(this["WeightUnitMeasureCode"], typeof(string), true)));
                }
            }

            public virtual int DaysToManufacture
            {
                get
                {
                    return ((int)(ChangeType(this["DaysToManufacture"], typeof(int), true)));
                }
            }

            public virtual string ProductLine
            {
                get
                {
                    return ((string)(ChangeType(this["ProductLine"], typeof(string), true)));
                }
            }

            public virtual string Class
            {
                get
                {
                    return ((string)(ChangeType(this["Class"], typeof(string), true)));
                }
            }

            public virtual string Style
            {
                get
                {
                    return ((string)(ChangeType(this["Style"], typeof(string), true)));
                }
            }

            public virtual int ProductModelID
            {
                get
                {
                    return ((int)(ChangeType(this["ProductModelID"], typeof(int), true)));
                }
            }

            public virtual DateTime SellStartDate
            {
                get
                {
                    return ((DateTime)(ChangeType(this["SellStartDate"], typeof(DateTime), true)));
                }
            }

            public virtual DateTime SellEndDate
            {
                get
                {
                    return ((DateTime)(ChangeType(this["SellEndDate"], typeof(DateTime), true)));
                }
            }

            public virtual DateTime DiscontinuedDate
            {
                get
                {
                    return ((DateTime)(ChangeType(this["DiscontinuedDate"], typeof(DateTime), true)));
                }
            }

            public virtual short UnitsInStock
            {
                get
                {
                    return ((short)(ChangeType(this["UnitsInStock"], typeof(short), true)));
                }
            }
        }
        #endregion DataSource VW_SalesOrderDetailInfo
        #endregion StiReport Designer generated code - do not modify
    }
}
