using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
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

    public class RptProducLocationPrice : StiReport
    {

        public RptProducLocationPrice()
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
        public StiPageHeaderBand PageHeaderBand1;
        public StiText Text4;
        public StiImage Image1;
        public StiPageFooterBand PageFooterBand1;
        public StiText Text3;
        public StiHeaderBand HeaderVW_ProductLocation;
        public StiText HeaderVW_ProductLocation_MedicamentName;
        public StiText HeaderVW_ProductLocation_CountryName;
        public StiText HeaderVW_ProductLocation_ListPrice;
        public StiText Text2;
        public StiDataBand DataVW_ProductLocation;
        public StiText DataVW_ProductLocation_MedicamentName;
        public StiText DataVW_ProductLocation_CountryName;
        public StiText DataVW_ProductLocation_ListPrice;
        public StiText Text1;
        public StiWatermark Page1_Watermark;
        public StiPrinterSettings RptProducLocationPrice_PrinterSettings;
        public T_DetailDataSource T_Detail;

        public void Text4__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, MyCompanyName, true);
        }

        public void Text3__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{PageNofM}";
            e.StoreToPrinted = true;
        }

        public String Text3_GetValue_End(StiComponent sender)
        {
            return ToString(sender, PageNofM, true);
        }

        public void HeaderVW_ProductLocation_MedicamentName__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "დასახელება";
        }

        public void HeaderVW_ProductLocation_CountryName__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ქვეყანა";
        }

        public void HeaderVW_ProductLocation_ListPrice__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ფასი (ლარი)";
        }

        public void Text2__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ფასდაკლება";
        }

        public void DataVW_ProductLocation_MedicamentName__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, T_Detail.ProductName, true);
        }

        public void DataVW_ProductLocation_CountryName__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = DataVW_ProductLocation_CountryName.TextFormat.Format(CheckExcelValue(sender, T_Detail.CountryName));
        }

        public void DataVW_ProductLocation_ListPrice__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = DataVW_ProductLocation_ListPrice.TextFormat.Format(CheckExcelValue(sender, T_Detail.UnitPrice));
        }

        public void Text1__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text1.TextFormat.Format(CheckExcelValue(sender, T_Detail.Discount));
        }

        public void Page1_Rendering(object sender, EventArgs e)
        {
            var file = Path.Combine(Application.StartupPath, "logo.jpg");
            if (File.Exists(file))
            {
                Image1.File = file;
                return;
            }
            file = Path.Combine(Application.StartupPath, "logo.png");
            if (File.Exists(file))
            {
                Image1.File = file;
                return;
            };
        }

        public void RptProducLocationPriceWordsToEnd__EndRender(object sender, EventArgs e)
        {
            Text3.SetText(new StiGetValue(Text3_GetValue_End));
        }

        private void InitializeComponent()
        {
            T_Detail = new T_DetailDataSource();
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
            ReportAlias = "Rpt Produc Location Price";
            ReportAuthor = "Programmer.GE";
            // 
            // ReportChanged
            // 
            ReportChanged = new DateTime(2011, 6, 12, 21, 55, 48, 0);
            // 
            // ReportCreated
            // 
            ReportCreated = new DateTime(2009, 6, 28, 22, 3, 23, 0);
            ReportDescription = "პრაისი";
            ReportFile = "D:\\User\\Documents\\Projects\\Apothex\\Source\\Class Library\\Apothex.Reporting\\Product" +
"ion\\RptProducLocationPrice.mrt";
            ReportGuid = "e242476ffaeb44b39344532841ed84f0";
            ReportName = "RptProducLocationPrice";
            ReportUnit = StiReportUnitType.Centimeters;
            ReportVersion = "2010.3.900";
            ScriptLanguage = StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            Page1 = new StiPage();
            Page1.Columns = 2;
            Page1.Guid = "0edad2017ef5402da56612e0faa7a32a";
            Page1.Name = "Page1";
            Page1.PageHeight = 29.7;
            Page1.PageWidth = 21;
            Page1.PaperSize = PaperKind.A4;
            Page1.Border = new StiBorder(StiBorderSides.None, Color.Black, 2, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Page1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // PageHeaderBand1
            // 
            PageHeaderBand1 = new StiPageHeaderBand();
            PageHeaderBand1.ClientRectangle = new RectangleD(0, 0.4, 20, 2.2);
            PageHeaderBand1.Name = "PageHeaderBand1";
            PageHeaderBand1.PrintOn = StiPrintOnType.OnlyFirstPage;
            PageHeaderBand1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            PageHeaderBand1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text4
            // 
            Text4 = new StiText();
            Text4.ClientRectangle = new RectangleD(2.4, 0, 7.6, 2);
            Text4.Name = "Text4";
            Text4.GetValue += new StiGetValueEventHandler(Text4__GetValue);
            Text4.VertAlignment = StiVertAlignment.Center;
            Text4.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text4.Brush = new StiSolidBrush(Color.Transparent);
            Text4.Font = new Font("BPG Glaho Arial", 7F, FontStyle.Bold);
            Text4.Guid = null;
            Text4.Interaction = null;
            Text4.Margins = new StiMargins(0, 0, 0, 0);
            Text4.TextBrush = new StiSolidBrush(Color.Black);
            Text4.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Image1
            // 
            Image1 = new StiImage();
            Image1.AspectRatio = true;
            Image1.ClientRectangle = new RectangleD(0, 0, 2, 2);
            Image1.Guid = "b4725dd4d92a41f5a0f373916b5b430e";
            Image1.HorAlignment = StiHorAlignment.Center;
            Image1.Name = "Image1";
            Image1.Stretch = true;
            Image1.VertAlignment = StiVertAlignment.Center;
            Image1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Image1.Brush = new StiSolidBrush(Color.Transparent);
            Image1.Image = null;
            Image1.Interaction = null;
            PageHeaderBand1.Guid = null;
            PageHeaderBand1.Interaction = null;
            // 
            // PageFooterBand1
            // 
            PageFooterBand1 = new StiPageFooterBand();
            PageFooterBand1.ClientRectangle = new RectangleD(0, 28.1, 20, 0.6);
            PageFooterBand1.Name = "PageFooterBand1";
            PageFooterBand1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            PageFooterBand1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text3
            // 
            Text3 = new StiText();
            Text3.ClientRectangle = new RectangleD(0, 0, 19, 0.6);
            Text3.HorAlignment = StiTextHorAlignment.Center;
            Text3.Name = "Text3";
            Text3.GetValue += new StiGetValueEventHandler(Text3__GetValue);
            Text3.VertAlignment = StiVertAlignment.Center;
            Text3.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text3.Brush = new StiSolidBrush(Color.Transparent);
            Text3.Font = new Font("Arial", 8F);
            Text3.Guid = null;
            Text3.Interaction = null;
            Text3.Margins = new StiMargins(0, 0, 0, 0);
            Text3.TextBrush = new StiSolidBrush(Color.Black);
            Text3.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            PageFooterBand1.Guid = null;
            PageFooterBand1.Interaction = null;
            // 
            // HeaderVW_ProductLocation
            // 
            HeaderVW_ProductLocation = new StiHeaderBand();
            HeaderVW_ProductLocation.ClientRectangle = new RectangleD(0, 3.4, 10, 0.6);
            HeaderVW_ProductLocation.Name = "HeaderVW_ProductLocation";
            HeaderVW_ProductLocation.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_ProductLocation.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // HeaderVW_ProductLocation_MedicamentName
            // 
            HeaderVW_ProductLocation_MedicamentName = new StiText();
            HeaderVW_ProductLocation_MedicamentName.ClientRectangle = new RectangleD(0, 0, 5.2, 0.6);
            HeaderVW_ProductLocation_MedicamentName.HorAlignment = StiTextHorAlignment.Center;
            HeaderVW_ProductLocation_MedicamentName.Name = "HeaderVW_ProductLocation_MedicamentName";
            HeaderVW_ProductLocation_MedicamentName.GetValue += new StiGetValueEventHandler(HeaderVW_ProductLocation_MedicamentName__GetValue);
            HeaderVW_ProductLocation_MedicamentName.VertAlignment = StiVertAlignment.Center;
            HeaderVW_ProductLocation_MedicamentName.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_ProductLocation_MedicamentName.Brush = new StiSolidBrush(Color.Gainsboro);
            HeaderVW_ProductLocation_MedicamentName.Font = new Font("BPG Glaho Arial", 7F, FontStyle.Bold);
            HeaderVW_ProductLocation_MedicamentName.Guid = null;
            HeaderVW_ProductLocation_MedicamentName.Interaction = null;
            HeaderVW_ProductLocation_MedicamentName.Margins = new StiMargins(0, 0, 0, 0);
            HeaderVW_ProductLocation_MedicamentName.TextBrush = new StiSolidBrush(Color.Black);
            HeaderVW_ProductLocation_MedicamentName.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderVW_ProductLocation_CountryName
            // 
            HeaderVW_ProductLocation_CountryName = new StiText();
            HeaderVW_ProductLocation_CountryName.ClientRectangle = new RectangleD(5.2, 0, 2.2, 0.6);
            HeaderVW_ProductLocation_CountryName.HorAlignment = StiTextHorAlignment.Center;
            HeaderVW_ProductLocation_CountryName.Name = "HeaderVW_ProductLocation_CountryName";
            HeaderVW_ProductLocation_CountryName.GetValue += new StiGetValueEventHandler(HeaderVW_ProductLocation_CountryName__GetValue);
            HeaderVW_ProductLocation_CountryName.VertAlignment = StiVertAlignment.Center;
            HeaderVW_ProductLocation_CountryName.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_ProductLocation_CountryName.Brush = new StiSolidBrush(Color.Gainsboro);
            HeaderVW_ProductLocation_CountryName.Font = new Font("BPG Glaho Arial", 7F, FontStyle.Bold);
            HeaderVW_ProductLocation_CountryName.Guid = null;
            HeaderVW_ProductLocation_CountryName.Interaction = null;
            HeaderVW_ProductLocation_CountryName.Margins = new StiMargins(0, 0, 0, 0);
            HeaderVW_ProductLocation_CountryName.TextBrush = new StiSolidBrush(Color.Black);
            HeaderVW_ProductLocation_CountryName.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderVW_ProductLocation_ListPrice
            // 
            HeaderVW_ProductLocation_ListPrice = new StiText();
            HeaderVW_ProductLocation_ListPrice.ClientRectangle = new RectangleD(9, 0, 1, 0.6);
            HeaderVW_ProductLocation_ListPrice.HorAlignment = StiTextHorAlignment.Center;
            HeaderVW_ProductLocation_ListPrice.Name = "HeaderVW_ProductLocation_ListPrice";
            HeaderVW_ProductLocation_ListPrice.GetValue += new StiGetValueEventHandler(HeaderVW_ProductLocation_ListPrice__GetValue);
            HeaderVW_ProductLocation_ListPrice.VertAlignment = StiVertAlignment.Center;
            HeaderVW_ProductLocation_ListPrice.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_ProductLocation_ListPrice.Brush = new StiSolidBrush(Color.Gainsboro);
            HeaderVW_ProductLocation_ListPrice.Font = new Font("BPG Glaho Arial", 7F, FontStyle.Bold);
            HeaderVW_ProductLocation_ListPrice.Guid = null;
            HeaderVW_ProductLocation_ListPrice.Interaction = null;
            HeaderVW_ProductLocation_ListPrice.Margins = new StiMargins(0, 0, 0, 0);
            HeaderVW_ProductLocation_ListPrice.TextBrush = new StiSolidBrush(Color.Black);
            HeaderVW_ProductLocation_ListPrice.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text2
            // 
            Text2 = new StiText();
            Text2.ClientRectangle = new RectangleD(7.4, 0, 1.6, 0.6);
            Text2.Guid = "b2ee6a7204874db4bc1e2bae90edc3a9";
            Text2.HorAlignment = StiTextHorAlignment.Center;
            Text2.Name = "Text2";
            Text2.GetValue += new StiGetValueEventHandler(Text2__GetValue);
            Text2.Type = StiSystemTextType.Expression;
            Text2.VertAlignment = StiVertAlignment.Center;
            Text2.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text2.Brush = new StiSolidBrush(Color.Gainsboro);
            Text2.Font = new Font("BPG Glaho Arial", 7F, FontStyle.Bold);
            Text2.Interaction = null;
            Text2.Margins = new StiMargins(0, 0, 0, 0);
            Text2.TextBrush = new StiSolidBrush(Color.Black);
            Text2.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            HeaderVW_ProductLocation.Guid = null;
            HeaderVW_ProductLocation.Interaction = null;
            // 
            // DataVW_ProductLocation
            // 
            DataVW_ProductLocation = new StiDataBand();
            DataVW_ProductLocation.ClientRectangle = new RectangleD(0, 4.8, 10, 0.6);
            DataVW_ProductLocation.DataSourceName = "T_Detail";
            DataVW_ProductLocation.Name = "DataVW_ProductLocation";
            DataVW_ProductLocation.Sort = new[] {
                    "ASC",
                    "ProductName"};
            DataVW_ProductLocation.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataVW_ProductLocation.Brush = new StiSolidBrush(Color.Transparent);
            DataVW_ProductLocation.BusinessObjectGuid = null;
            // 
            // DataVW_ProductLocation_MedicamentName
            // 
            DataVW_ProductLocation_MedicamentName = new StiText();
            DataVW_ProductLocation_MedicamentName.CanGrow = true;
            DataVW_ProductLocation_MedicamentName.ClientRectangle = new RectangleD(0, 0, 5.2, 0.6);
            DataVW_ProductLocation_MedicamentName.Name = "DataVW_ProductLocation_MedicamentName";
            DataVW_ProductLocation_MedicamentName.GetValue += new StiGetValueEventHandler(DataVW_ProductLocation_MedicamentName__GetValue);
            DataVW_ProductLocation_MedicamentName.VertAlignment = StiVertAlignment.Center;
            DataVW_ProductLocation_MedicamentName.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataVW_ProductLocation_MedicamentName.Brush = new StiSolidBrush(Color.Transparent);
            DataVW_ProductLocation_MedicamentName.Font = new Font("BPG Glaho Arial", 6F);
            DataVW_ProductLocation_MedicamentName.Guid = null;
            DataVW_ProductLocation_MedicamentName.Interaction = null;
            DataVW_ProductLocation_MedicamentName.Margins = new StiMargins(0, 0, 0, 0);
            DataVW_ProductLocation_MedicamentName.TextBrush = new StiSolidBrush(Color.Black);
            DataVW_ProductLocation_MedicamentName.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataVW_ProductLocation_CountryName
            // 
            DataVW_ProductLocation_CountryName = new StiText();
            DataVW_ProductLocation_CountryName.CanGrow = true;
            DataVW_ProductLocation_CountryName.ClientRectangle = new RectangleD(5.2, 0, 2.2, 0.6);
            DataVW_ProductLocation_CountryName.HorAlignment = StiTextHorAlignment.Right;
            DataVW_ProductLocation_CountryName.Name = "DataVW_ProductLocation_CountryName";
            DataVW_ProductLocation_CountryName.GetValue += new StiGetValueEventHandler(DataVW_ProductLocation_CountryName__GetValue);
            DataVW_ProductLocation_CountryName.VertAlignment = StiVertAlignment.Center;
            DataVW_ProductLocation_CountryName.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataVW_ProductLocation_CountryName.Brush = new StiSolidBrush(Color.Transparent);
            DataVW_ProductLocation_CountryName.Font = new Font("BPG Glaho Arial", 6F);
            DataVW_ProductLocation_CountryName.Guid = null;
            DataVW_ProductLocation_CountryName.Interaction = null;
            DataVW_ProductLocation_CountryName.Margins = new StiMargins(0, 0, 0, 0);
            DataVW_ProductLocation_CountryName.TextBrush = new StiSolidBrush(Color.Black);
            DataVW_ProductLocation_CountryName.TextFormat = new StiPercentageFormatService(0, 0, ",", 4, " ", 3, "%", true, false, " ");
            DataVW_ProductLocation_CountryName.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataVW_ProductLocation_ListPrice
            // 
            DataVW_ProductLocation_ListPrice = new StiText();
            DataVW_ProductLocation_ListPrice.CanGrow = true;
            DataVW_ProductLocation_ListPrice.ClientRectangle = new RectangleD(9, 0, 1, 0.6);
            DataVW_ProductLocation_ListPrice.HorAlignment = StiTextHorAlignment.Right;
            DataVW_ProductLocation_ListPrice.Name = "DataVW_ProductLocation_ListPrice";
            DataVW_ProductLocation_ListPrice.GetValue += new StiGetValueEventHandler(DataVW_ProductLocation_ListPrice__GetValue);
            DataVW_ProductLocation_ListPrice.VertAlignment = StiVertAlignment.Center;
            DataVW_ProductLocation_ListPrice.Border = new StiBorder(StiBorderSides.Right, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataVW_ProductLocation_ListPrice.Brush = new StiSolidBrush(Color.Transparent);
            DataVW_ProductLocation_ListPrice.Font = new Font("BPG Glaho Arial", 6F);
            DataVW_ProductLocation_ListPrice.Guid = null;
            DataVW_ProductLocation_ListPrice.Interaction = null;
            DataVW_ProductLocation_ListPrice.Margins = new StiMargins(0, 0, 0, 0);
            DataVW_ProductLocation_ListPrice.TextBrush = new StiSolidBrush(Color.Black);
            DataVW_ProductLocation_ListPrice.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            DataVW_ProductLocation_ListPrice.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text1
            // 
            Text1 = new StiText();
            Text1.CanGrow = true;
            Text1.ClientRectangle = new RectangleD(7.4, 0, 1.6, 0.6);
            Text1.Guid = "5cfcbb441d534f4ba95c949ddd2c6da5";
            Text1.HorAlignment = StiTextHorAlignment.Right;
            Text1.Name = "Text1";
            Text1.GetValue += new StiGetValueEventHandler(Text1__GetValue);
            Text1.Type = StiSystemTextType.DataColumn;
            Text1.VertAlignment = StiVertAlignment.Center;
            Text1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text1.Brush = new StiSolidBrush(Color.Transparent);
            Text1.Font = new Font("BPG Glaho Arial", 6F);
            Text1.Interaction = null;
            Text1.Margins = new StiMargins(0, 0, 0, 0);
            Text1.TextBrush = new StiSolidBrush(Color.Black);
            Text1.TextFormat = new StiPercentageFormatService(0, 0, ",", 2, " ", 3, "%", true, true, " ");
            Text1.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            DataVW_ProductLocation.DataRelationName = null;
            DataVW_ProductLocation.Guid = null;
            DataVW_ProductLocation.Interaction = null;
            DataVW_ProductLocation.MasterComponent = null;
            Page1.ExcelSheetValue = null;
            Page1.Interaction = null;
            Page1.Margins = new StiMargins(0.5, 0.5, 0.5, 0.5);
            Page1_Watermark = new StiWatermark();
            Page1_Watermark.Font = new Font("Arial", 100F);
            Page1_Watermark.Image = null;
            Page1_Watermark.TextBrush = new StiSolidBrush(Color.FromArgb(50, 0, 0, 0));
            Page1.Rendering += new EventHandler(Page1_Rendering);
            RptProducLocationPrice_PrinterSettings = new StiPrinterSettings();
            PrinterSettings = RptProducLocationPrice_PrinterSettings;
            Page1.Report = this;
            Page1.Watermark = Page1_Watermark;
            PageHeaderBand1.Page = Page1;
            PageHeaderBand1.Parent = Page1;
            Text4.Page = Page1;
            Text4.Parent = PageHeaderBand1;
            Image1.Page = Page1;
            Image1.Parent = PageHeaderBand1;
            PageFooterBand1.Page = Page1;
            PageFooterBand1.Parent = Page1;
            Text3.Page = Page1;
            Text3.Parent = PageFooterBand1;
            HeaderVW_ProductLocation.Page = Page1;
            HeaderVW_ProductLocation.Parent = Page1;
            HeaderVW_ProductLocation_MedicamentName.Page = Page1;
            HeaderVW_ProductLocation_MedicamentName.Parent = HeaderVW_ProductLocation;
            HeaderVW_ProductLocation_CountryName.Page = Page1;
            HeaderVW_ProductLocation_CountryName.Parent = HeaderVW_ProductLocation;
            HeaderVW_ProductLocation_ListPrice.Page = Page1;
            HeaderVW_ProductLocation_ListPrice.Parent = HeaderVW_ProductLocation;
            Text2.Page = Page1;
            Text2.Parent = HeaderVW_ProductLocation;
            DataVW_ProductLocation.Page = Page1;
            DataVW_ProductLocation.Parent = Page1;
            DataVW_ProductLocation_MedicamentName.Page = Page1;
            DataVW_ProductLocation_MedicamentName.Parent = DataVW_ProductLocation;
            DataVW_ProductLocation_CountryName.Page = Page1;
            DataVW_ProductLocation_CountryName.Parent = DataVW_ProductLocation;
            DataVW_ProductLocation_ListPrice.Page = Page1;
            DataVW_ProductLocation_ListPrice.Parent = DataVW_ProductLocation;
            Text1.Page = Page1;
            Text1.Parent = DataVW_ProductLocation;
            EndRender += new EventHandler(RptProducLocationPriceWordsToEnd__EndRender);
            // 
            // Add to PageHeaderBand1.Components
            // 
            PageHeaderBand1.Components.Clear();
            PageHeaderBand1.Components.AddRange(new StiComponent[] {
                        Text4,
                        Image1});
            // 
            // Add to PageFooterBand1.Components
            // 
            PageFooterBand1.Components.Clear();
            PageFooterBand1.Components.AddRange(new StiComponent[] {
                        Text3});
            // 
            // Add to HeaderVW_ProductLocation.Components
            // 
            HeaderVW_ProductLocation.Components.Clear();
            HeaderVW_ProductLocation.Components.AddRange(new StiComponent[] {
                        HeaderVW_ProductLocation_MedicamentName,
                        HeaderVW_ProductLocation_CountryName,
                        HeaderVW_ProductLocation_ListPrice,
                        Text2});
            // 
            // Add to DataVW_ProductLocation.Components
            // 
            DataVW_ProductLocation.Components.Clear();
            DataVW_ProductLocation.Components.AddRange(new StiComponent[] {
                        DataVW_ProductLocation_MedicamentName,
                        DataVW_ProductLocation_CountryName,
                        DataVW_ProductLocation_ListPrice,
                        Text1});
            // 
            // Add to Page1.Components
            // 
            Page1.Components.Clear();
            Page1.Components.AddRange(new StiComponent[] {
                        PageHeaderBand1,
                        PageFooterBand1,
                        HeaderVW_ProductLocation,
                        DataVW_ProductLocation});
            // 
            // Add to Pages
            // 
            Pages.Clear();
            Pages.AddRange(new[] {
                        Page1});
            T_Detail.Columns.AddRange(new[] {
                        new StiDataColumn("ProductID", "ProductID", "ProductID", typeof(int)),
                        new StiDataColumn("ProductName", "ProductName", "ProductName", typeof(string)),
                        new StiDataColumn("CountryName", "CountryName", "CountryName", typeof(string)),
                        new StiDataColumn("Serie", "Serie", "Serie", typeof(string)),
                        new StiDataColumn("UnitPrice", "UnitPrice", "UnitPrice", typeof(decimal)),
                        new StiDataColumn("Discount", "Discount", "Discount", typeof(decimal))});
            DataSources.Add(T_Detail);
        }

        #region DataSource T_Detail
        public class T_DetailDataSource : StiDataTableSource
        {

            public T_DetailDataSource() :
                base("DS_ProductLocationPrice.T_Detail", "T_Detail")
            {
            }

            public virtual int ProductID
            {
                get
                {
                    return ((int)(ChangeType(this["ProductID"], typeof(int), true)));
                }
            }

            public virtual string ProductName
            {
                get
                {
                    return ((string)(ChangeType(this["ProductName"], typeof(string), true)));
                }
            }

            public virtual string CountryName
            {
                get
                {
                    return ((string)(ChangeType(this["CountryName"], typeof(string), true)));
                }
            }

            public virtual string Serie
            {
                get
                {
                    return ((string)(ChangeType(this["Serie"], typeof(string), true)));
                }
            }

            public virtual decimal UnitPrice
            {
                get
                {
                    return ((decimal)(ChangeType(this["UnitPrice"], typeof(decimal), true)));
                }
            }

            public virtual decimal Discount
            {
                get
                {
                    return ((decimal)(ChangeType(this["Discount"], typeof(decimal), true)));
                }
            }
        }
        #endregion DataSource T_Detail
        #endregion StiReport Designer generated code - do not modify
    }
}
