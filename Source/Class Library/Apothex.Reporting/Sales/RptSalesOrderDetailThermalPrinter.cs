using System;
using System.Drawing;
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

    public class RptSalesOrderDetailThermalPrinter : StiReport
    {

        public RptSalesOrderDetailThermalPrinter()
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
        public StiText Text1;
        public StiText Text2;
        public StiImage Image1;
        public StiText Text11;
        public StiHeaderBand HeaderSP_GetSalesOrderDetail;
        public StiText Text3;
        public StiText Text4;
        public StiText Text5;
        public StiText Text6;
        public StiDataBand DataSP_GetSalesOrderDetail;
        public StiText Text7;
        public StiText Text8;
        public StiText Text9;
        public StiText Text10;
        public StiFooterBand FooterSP_GetSalesOrderDetail;
        public StiText Text12;
        public StiCountFunctionService Text12_Count;
        public StiText Text14;
        public StiSumDecimalFunctionService Text14_Sum;
        public StiText Text16;
        public StiText Text17;
        public StiSumDecimalFunctionService Text17_Sum;
        public StiText Text18;
        public StiText Text19;
        public StiWatermark Page1_Watermark;
        public StiPrinterSettings RptSalesOrderDetailThermalPrinter_PrinterSettings;
        public SP_GetSalesOrderHeaderDataSource SP_GetSalesOrderHeader;
        public SP_GetSalesOrderDetailDataSource SP_GetSalesOrderDetail;

        public void Text1__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#" + ToString(sender, SP_GetSalesOrderHeader.SalesOrderID, true);
        }

        public void Text2__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text2.TextFormat.Format(CheckExcelValue(sender, SP_GetSalesOrderHeader.OrderDate));
        }

        public void Text11__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, MyCompanyName, true);
        }

        public void Text3__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "დასახელება/მწარმოებელი";
        }

        public void Text4__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "რაოდენობა";
        }

        public void Text5__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ფასი";
        }

        public void Text6__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "თანხა";
        }

        public void Text7__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Line, true) + ". " + ToString(sender, SP_GetSalesOrderDetail.MedicamentName, true) + " / " + ToString(sender, SP_GetSalesOrderDetail.CountryName, true) + " " + ToString(sender, SP_GetSalesOrderDetail.BrandName, true);
        }

        public void Text8__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Format("{0:N00}", (int)SP_GetSalesOrderDetail.SaleQty), true) + "/" + ToString(sender, Format("{0:N00}", SP_GetSalesOrderDetail._SaleUnitQty - ((int)SP_GetSalesOrderDetail.SaleQty * SP_GetSalesOrderDetail.UnitsInStock)), true);
        }

        public void Text9__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text9.TextFormat.Format(CheckExcelValue(sender, SP_GetSalesOrderDetail.UnitPrice));
        }

        public void Text10__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text10.TextFormat.Format(CheckExcelValue(sender, SP_GetSalesOrderDetail.LineTotalWithoutDiscount));
        }

        public void Text12__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#სულ {Count()} პრეპარატი";
            e.StoreToPrinted = true;
        }

        public String Text12_GetValue_End(StiComponent sender)
        {
            return "სულ " + ToString(sender, ((long)(ChangeType(Text12_Count.GetValue(), typeof(long), true))), true) + " პრეპარატი";
        }

        public void Text14__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#ჯამი: {Format(\"{0:N2}\", Sum(SP_GetSalesOrderDetail.LineTotalWithoutDiscount))}" +
" {SP_GetSalesOrderDetail.SP_GetSalesOrderHeader.CurrencyCode}";
            e.StoreToPrinted = true;
        }

        public String Text14_GetValue_End(StiComponent sender)
        {
            return "ჯამი: " + ToString(sender, Format("{0:N2}", ((decimal)(ChangeType(Text14_Sum.GetValue(), typeof(decimal), true)))), true) + " " + ToString(sender, SP_GetSalesOrderDetail.SP_GetSalesOrderHeader.CurrencyCode, true);
        }

        public void Text17__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#ფასდაკლება: {Format(\"{0:N2}\", Sum(SP_GetSalesOrderDetail.DiscountAmount))} {SP" +
"_GetSalesOrderDetail.SP_GetSalesOrderHeader.CurrencyCode}";
            e.StoreToPrinted = true;
        }

        public String Text17_GetValue_End(StiComponent sender)
        {
            return "ფასდაკლება: " + ToString(sender, Format("{0:N2}", ((decimal)(ChangeType(Text17_Sum.GetValue(), typeof(decimal), true)))), true) + " " + ToString(sender, SP_GetSalesOrderDetail.SP_GetSalesOrderHeader.CurrencyCode, true);
        }

        public void Text18__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "სულ გადასახდელია:      " + ToString(sender, Format("{0:N2}", SP_GetSalesOrderDetail.SP_GetSalesOrderHeader.TotalDue), true) + " " + ToString(sender, SP_GetSalesOrderDetail.SP_GetSalesOrderHeader.CurrencyCode, true);
        }

        public void Text19__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "გაყიდული მედიკამენტები უკან არ მიიღება\r\nგმადლობთ, რომ ენდობით " + ToString(sender,
IIF(MyCompanyName.EndsWith("ი"),
    MyCompanyName.Substring(0, MyCompanyName.Length - 1),
    IIF(MyCompanyName.EndsWith("ი\""), MyCompanyName.Substring(0, MyCompanyName.Length - 2) + "ს\"", MyCompanyName + "ს")), true);
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

        public void DataSP_GetSalesOrderDetail__BeginRender(object sender, EventArgs e)
        {
            Text12_Count.Init();
            Text12.TextValue = "";
            Text14_Sum.Init();
            Text14.TextValue = "";
            Text17_Sum.Init();
            Text17.TextValue = "";
        }

        public void DataSP_GetSalesOrderDetail__EndRender(object sender, EventArgs e)
        {
            Text12.SetText(new StiGetValue(Text12_GetValue_End));
            Text14.SetText(new StiGetValue(Text14_GetValue_End));
            Text17.SetText(new StiGetValue(Text17_GetValue_End));
        }

        public void DataSP_GetSalesOrderDetail__Rendering(object sender, EventArgs e)
        {
            Text12_Count.CalcItem(null);
            Text14_Sum.CalcItem(SP_GetSalesOrderDetail.LineTotalWithoutDiscount);
            Text17_Sum.CalcItem(SP_GetSalesOrderDetail.DiscountAmount);
        }

        private void InitializeComponent()
        {
            SP_GetSalesOrderDetail = new SP_GetSalesOrderDetailDataSource();
            SP_GetSalesOrderHeader = new SP_GetSalesOrderHeaderDataSource();
            ParentSP_GetSalesOrderHeader = new StiDataRelation("SP_GetSalesOrderHeader_SP_GetSalesOrderDetail", "SP_GetSalesOrderHeader", "SP_GetSalesOrderHeader", SP_GetSalesOrderHeader, SP_GetSalesOrderDetail, new[] {
                        "SalesOrderID"}, new[] {
                        "SalesOrderID"});
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
            Text17_Sum = new StiSumDecimalFunctionService();
            Text14_Sum = new StiSumDecimalFunctionService();
            Text12_Count = new StiCountFunctionService();
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
            PreviewMode = StiPreviewMode.StandardAndDotMatrix;
            ReferencedAssemblies = new[] {
                    "System.Dll",
                    "System.Drawing.Dll",
                    "System.Windows.Forms.Dll",
                    "System.Data.Dll",
                    "System.Xml.Dll",
                    "Stimulsoft.Controls.Dll",
                    "Stimulsoft.Base.Dll",
                    "Stimulsoft.Report.Dll"};
            ReportAlias = "Rpt Sales Order Detail Thermal Printer";
            ReportAuthor = "Programmer.GE";
            // 
            // ReportChanged
            // 
            ReportChanged = new DateTime(2010, 10, 7, 21, 52, 20, 924);
            // 
            // ReportCreated
            // 
            ReportCreated = new DateTime(2009, 6, 15, 17, 34, 53, 0);
            ReportDescription = "გაყიდვის დეტალური რეპორტი თერმულ პრინტერისთვის";
            ReportFile = "D:\\User\\Documents\\Projects\\Apothex\\Source\\Class Library\\Apothex.Reporting\\Sales\\R" +
"ptSalesOrderDetailThermalPrinter.mrt";
            ReportGuid = "14bad523f7ab42a0b19b4829450346da";
            ReportName = "RptSalesOrderDetailThermalPrinter";
            ReportUnit = StiReportUnitType.Millimeters;
            ScriptLanguage = StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            Page1 = new StiPage();
            Page1.Guid = "d9ff15bdd540408f9fb1f8142dac7fa4";
            Page1.Name = "Page1";
            Page1.PageHeight = 90;
            Page1.PageWidth = 79.5;
            Page1.UnlimitedHeight = true;
            Page1.Border = new StiBorder(StiBorderSides.None, Color.Black, 2, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Page1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // DataSP_GetSalesOrderHeader
            // 
            DataSP_GetSalesOrderHeader = new StiDataBand();
            DataSP_GetSalesOrderHeader.ClientRectangle = new RectangleD(0, 4, 74.5, 25);
            DataSP_GetSalesOrderHeader.DataSourceName = "SP_GetSalesOrderHeader";
            DataSP_GetSalesOrderHeader.Name = "DataSP_GetSalesOrderHeader";
            DataSP_GetSalesOrderHeader.Sort = new String[0];
            DataSP_GetSalesOrderHeader.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetSalesOrderHeader.Brush = new StiSolidBrush(Color.Transparent);
            DataSP_GetSalesOrderHeader.BusinessObjectGuid = null;
            // 
            // Text1
            // 
            Text1 = new StiText();
            Text1.ClientRectangle = new RectangleD(24, 10, 46, 6);
            Text1.HorAlignment = StiTextHorAlignment.Center;
            Text1.Name = "Text1";
            Text1.GetValue += new StiGetValueEventHandler(Text1__GetValue);
            Text1.VertAlignment = StiVertAlignment.Center;
            Text1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text1.Brush = new StiSolidBrush(Color.Transparent);
            Text1.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            Text1.Guid = null;
            Text1.Interaction = null;
            Text1.Margins = new StiMargins(0, 0, 0, 0);
            Text1.TextBrush = new StiSolidBrush(Color.Black);
            Text1.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text2
            // 
            Text2 = new StiText();
            Text2.ClientRectangle = new RectangleD(24, 18, 46, 6);
            Text2.HorAlignment = StiTextHorAlignment.Center;
            Text2.Name = "Text2";
            Text2.GetValue += new StiGetValueEventHandler(Text2__GetValue);
            Text2.VertAlignment = StiVertAlignment.Center;
            Text2.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text2.Brush = new StiSolidBrush(Color.Transparent);
            Text2.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            Text2.Guid = null;
            Text2.Interaction = null;
            Text2.Margins = new StiMargins(0, 0, 0, 0);
            Text2.TextBrush = new StiSolidBrush(Color.Black);
            Text2.TextFormat = new StiDateFormatService("d", " ");
            Text2.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Image1
            // 
            Image1 = new StiImage();
            Image1.AspectRatio = true;
            Image1.ClientRectangle = new RectangleD(0, 2, 20, 20);
            Image1.HorAlignment = StiHorAlignment.Center;
            Image1.Name = "Image1";
            Image1.Stretch = true;
            Image1.VertAlignment = StiVertAlignment.Center;
            Image1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Image1.Brush = new StiSolidBrush(Color.Transparent);
            Image1.Guid = null;
            Image1.Image = null;
            Image1.Interaction = null;
            // 
            // Text11
            // 
            Text11 = new StiText();
            Text11.ClientRectangle = new RectangleD(24, 0, 46, 10);
            Text11.HorAlignment = StiTextHorAlignment.Center;
            Text11.Name = "Text11";
            Text11.GetValue += new StiGetValueEventHandler(Text11__GetValue);
            Text11.VertAlignment = StiVertAlignment.Center;
            Text11.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text11.Brush = new StiSolidBrush(Color.Transparent);
            Text11.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            Text11.Guid = null;
            Text11.Interaction = null;
            Text11.Margins = new StiMargins(0, 0, 0, 0);
            Text11.TextBrush = new StiSolidBrush(Color.Black);
            Text11.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            DataSP_GetSalesOrderHeader.DataRelationName = null;
            DataSP_GetSalesOrderHeader.Guid = null;
            DataSP_GetSalesOrderHeader.Interaction = null;
            DataSP_GetSalesOrderHeader.MasterComponent = null;
            // 
            // HeaderSP_GetSalesOrderDetail
            // 
            HeaderSP_GetSalesOrderDetail = new StiHeaderBand();
            HeaderSP_GetSalesOrderDetail.ClientRectangle = new RectangleD(0, 37, 74.5, 5);
            HeaderSP_GetSalesOrderDetail.Name = "HeaderSP_GetSalesOrderDetail";
            HeaderSP_GetSalesOrderDetail.Border = new StiBorder(((StiBorderSides.None | StiBorderSides.Top)
                            | StiBorderSides.Bottom), Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderSP_GetSalesOrderDetail.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text3
            // 
            Text3 = new StiText();
            Text3.ClientRectangle = new RectangleD(0, 0, 26, 5);
            Text3.Name = "Text3";
            Text3.GetValue += new StiGetValueEventHandler(Text3__GetValue);
            Text3.VertAlignment = StiVertAlignment.Center;
            Text3.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text3.Brush = new StiSolidBrush(Color.Transparent);
            Text3.Font = new Font("BPG Glaho Arial", 7F);
            Text3.Guid = null;
            Text3.Interaction = null;
            Text3.Margins = new StiMargins(0, 0, 0, 0);
            Text3.TextBrush = new StiSolidBrush(Color.Black);
            Text3.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text4
            // 
            Text4 = new StiText();
            Text4.ClientRectangle = new RectangleD(26, 0, 16, 5);
            Text4.Guid = "98ac7422a5e441b6850cd1e79431531e";
            Text4.HorAlignment = StiTextHorAlignment.Right;
            Text4.Name = "Text4";
            Text4.GetValue += new StiGetValueEventHandler(Text4__GetValue);
            Text4.VertAlignment = StiVertAlignment.Center;
            Text4.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text4.Brush = new StiSolidBrush(Color.Transparent);
            Text4.Font = new Font("BPG Glaho Arial", 7F);
            Text4.Interaction = null;
            Text4.Margins = new StiMargins(0, 0, 0, 0);
            Text4.TextBrush = new StiSolidBrush(Color.Black);
            Text4.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text5
            // 
            Text5 = new StiText();
            Text5.ClientRectangle = new RectangleD(42, 0, 12, 5);
            Text5.Guid = "5e2544c726784a76896552bd1f762cfa";
            Text5.HorAlignment = StiTextHorAlignment.Right;
            Text5.Name = "Text5";
            Text5.GetValue += new StiGetValueEventHandler(Text5__GetValue);
            Text5.VertAlignment = StiVertAlignment.Center;
            Text5.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text5.Brush = new StiSolidBrush(Color.Transparent);
            Text5.Font = new Font("BPG Glaho Arial", 7F);
            Text5.Interaction = null;
            Text5.Margins = new StiMargins(0, 0, 0, 0);
            Text5.TextBrush = new StiSolidBrush(Color.Black);
            Text5.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text6
            // 
            Text6 = new StiText();
            Text6.ClientRectangle = new RectangleD(54, 0, 14, 5);
            Text6.Guid = "04d6be7f43ab43e8878750485d15704a";
            Text6.HorAlignment = StiTextHorAlignment.Right;
            Text6.Name = "Text6";
            Text6.GetValue += new StiGetValueEventHandler(Text6__GetValue);
            Text6.VertAlignment = StiVertAlignment.Center;
            Text6.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text6.Brush = new StiSolidBrush(Color.Transparent);
            Text6.Font = new Font("BPG Glaho Arial", 7F);
            Text6.Interaction = null;
            Text6.Margins = new StiMargins(0, 0, 0, 0);
            Text6.TextBrush = new StiSolidBrush(Color.Black);
            Text6.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            HeaderSP_GetSalesOrderDetail.Guid = null;
            HeaderSP_GetSalesOrderDetail.Interaction = null;
            // 
            // DataSP_GetSalesOrderDetail
            // 
            DataSP_GetSalesOrderDetail = new StiDataBand();
            DataSP_GetSalesOrderDetail.ClientRectangle = new RectangleD(0, 50, 74.5, 12);
            DataSP_GetSalesOrderDetail.DataRelationName = "SP_GetSalesOrderHeader_SP_GetSalesOrderDetail";
            DataSP_GetSalesOrderDetail.DataSourceName = "SP_GetSalesOrderDetail";
            DataSP_GetSalesOrderDetail.Name = "DataSP_GetSalesOrderDetail";
            DataSP_GetSalesOrderDetail.Sort = new String[0];
            DataSP_GetSalesOrderDetail.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetSalesOrderDetail.Brush = new StiSolidBrush(Color.Transparent);
            DataSP_GetSalesOrderDetail.BusinessObjectGuid = null;
            // 
            // Text7
            // 
            Text7 = new StiText();
            Text7.ClientRectangle = new RectangleD(0, 0, 72, 8);
            Text7.Name = "Text7";
            Text7.GetValue += new StiGetValueEventHandler(Text7__GetValue);
            Text7.VertAlignment = StiVertAlignment.Center;
            Text7.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text7.Brush = new StiSolidBrush(Color.Transparent);
            Text7.Font = new Font("BPG Glaho Arial", 8F);
            Text7.Guid = null;
            Text7.Interaction = null;
            Text7.Margins = new StiMargins(0, 0, 0, 0);
            Text7.TextBrush = new StiSolidBrush(Color.Black);
            Text7.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text8
            // 
            Text8 = new StiText();
            Text8.ClientRectangle = new RectangleD(26, 8, 16, 4);
            Text8.HorAlignment = StiTextHorAlignment.Right;
            Text8.Name = "Text8";
            Text8.GetValue += new StiGetValueEventHandler(Text8__GetValue);
            Text8.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text8.Brush = new StiSolidBrush(Color.Transparent);
            Text8.Font = new Font("BPG Glaho Arial", 8F);
            Text8.Guid = null;
            Text8.Interaction = null;
            Text8.Margins = new StiMargins(0, 0, 0, 0);
            Text8.TextBrush = new StiSolidBrush(Color.Black);
            Text8.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text9
            // 
            Text9 = new StiText();
            Text9.ClientRectangle = new RectangleD(42, 8, 12, 4);
            Text9.HorAlignment = StiTextHorAlignment.Right;
            Text9.Name = "Text9";
            Text9.GetValue += new StiGetValueEventHandler(Text9__GetValue);
            Text9.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text9.Brush = new StiSolidBrush(Color.Transparent);
            Text9.Font = new Font("BPG Glaho Arial", 8F);
            Text9.Guid = null;
            Text9.Interaction = null;
            Text9.Margins = new StiMargins(0, 0, 0, 0);
            Text9.TextBrush = new StiSolidBrush(Color.Black);
            Text9.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            Text9.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text10
            // 
            Text10 = new StiText();
            Text10.ClientRectangle = new RectangleD(54, 8, 14, 4);
            Text10.HorAlignment = StiTextHorAlignment.Right;
            Text10.Name = "Text10";
            Text10.GetValue += new StiGetValueEventHandler(Text10__GetValue);
            Text10.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text10.Brush = new StiSolidBrush(Color.Transparent);
            Text10.Font = new Font("BPG Glaho Arial", 8F);
            Text10.Guid = null;
            Text10.Interaction = null;
            Text10.Margins = new StiMargins(0, 0, 0, 0);
            Text10.TextBrush = new StiSolidBrush(Color.Black);
            Text10.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            Text10.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            DataSP_GetSalesOrderDetail.Guid = null;
            DataSP_GetSalesOrderDetail.Interaction = null;
            // 
            // FooterSP_GetSalesOrderDetail
            // 
            FooterSP_GetSalesOrderDetail = new StiFooterBand();
            FooterSP_GetSalesOrderDetail.ClientRectangle = new RectangleD(0, 70, 74.5, 22);
            FooterSP_GetSalesOrderDetail.Name = "FooterSP_GetSalesOrderDetail";
            FooterSP_GetSalesOrderDetail.Border = new StiBorder(StiBorderSides.Top, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            FooterSP_GetSalesOrderDetail.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text12
            // 
            Text12 = new StiText();
            Text12.ClientRectangle = new RectangleD(0, 0, 40, 4);
            Text12.Name = "Text12";
            // 
            // Text12_Count
            // 
            Text12.GetValue += new StiGetValueEventHandler(Text12__GetValue);
            Text12.VertAlignment = StiVertAlignment.Center;
            Text12.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text12.Brush = new StiSolidBrush(Color.Transparent);
            Text12.Font = new Font("BPG Glaho Arial", 7F);
            Text12.Guid = null;
            Text12.Interaction = null;
            Text12.Margins = new StiMargins(0, 0, 0, 0);
            Text12.TextBrush = new StiSolidBrush(Color.Black);
            Text12.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text14
            // 
            Text14 = new StiText();
            Text14.ClientRectangle = new RectangleD(40, 0, 30, 4);
            Text14.Guid = "05a9f0fb1b1646ecb9a1294290d6a7ac";
            Text14.HorAlignment = StiTextHorAlignment.Right;
            Text14.Name = "Text14";
            // 
            // Text14_Sum
            // 
            Text14.GetValue += new StiGetValueEventHandler(Text14__GetValue);
            Text14.VertAlignment = StiVertAlignment.Center;
            Text14.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text14.Brush = new StiSolidBrush(Color.Transparent);
            Text14.Font = new Font("BPG Glaho Arial", 7F);
            Text14.Interaction = null;
            Text14.Margins = new StiMargins(0, 0, 0, 0);
            Text14.TextBrush = new StiSolidBrush(Color.Black);
            Text14.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text16
            // 
            Text16 = new StiText();
            Text16.ClientRectangle = new RectangleD(0, 4, 42, 4);
            Text16.Guid = "97028daa9e2a4d31b389eb695d354656";
            Text16.Name = "Text16";
            Text16.VertAlignment = StiVertAlignment.Center;
            Text16.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text16.Brush = new StiSolidBrush(Color.Transparent);
            Text16.Font = new Font("BPG Glaho Arial", 7F);
            Text16.Interaction = null;
            Text16.Margins = new StiMargins(0, 0, 0, 0);
            Text16.TextBrush = new StiSolidBrush(Color.Black);
            Text16.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text17
            // 
            Text17 = new StiText();
            Text17.ClientRectangle = new RectangleD(40, 4, 30, 4);
            Text17.Guid = "55f5ddd6919141fcb58e9cd966d6b9b2";
            Text17.HorAlignment = StiTextHorAlignment.Right;
            Text17.Name = "Text17";
            // 
            // Text17_Sum
            // 
            Text17.GetValue += new StiGetValueEventHandler(Text17__GetValue);
            Text17.VertAlignment = StiVertAlignment.Center;
            Text17.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text17.Brush = new StiSolidBrush(Color.Transparent);
            Text17.Font = new Font("BPG Glaho Arial", 7F);
            Text17.Interaction = null;
            Text17.Margins = new StiMargins(0, 0, 0, 0);
            Text17.TextBrush = new StiSolidBrush(Color.Black);
            Text17.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text18
            // 
            Text18 = new StiText();
            Text18.ClientRectangle = new RectangleD(0, 8, 70, 4);
            Text18.HorAlignment = StiTextHorAlignment.Center;
            Text18.Name = "Text18";
            Text18.GetValue += new StiGetValueEventHandler(Text18__GetValue);
            Text18.VertAlignment = StiVertAlignment.Center;
            Text18.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text18.Brush = new StiSolidBrush(Color.Transparent);
            Text18.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            Text18.Guid = null;
            Text18.Interaction = null;
            Text18.Margins = new StiMargins(0, 0, 0, 0);
            Text18.TextBrush = new StiSolidBrush(Color.Black);
            Text18.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text19
            // 
            Text19 = new StiText();
            Text19.ClientRectangle = new RectangleD(0, 14, 70, 8);
            Text19.Name = "Text19";
            Text19.GetValue += new StiGetValueEventHandler(Text19__GetValue);
            Text19.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text19.Brush = new StiSolidBrush(Color.Transparent);
            Text19.Font = new Font("BPG Glaho Arial", 7F);
            Text19.Guid = null;
            Text19.Interaction = null;
            Text19.Margins = new StiMargins(0, 0, 0, 0);
            Text19.TextBrush = new StiSolidBrush(Color.Black);
            Text19.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            FooterSP_GetSalesOrderDetail.Guid = null;
            FooterSP_GetSalesOrderDetail.Interaction = null;
            Page1.ExcelSheetValue = null;
            Page1.Interaction = null;
            Page1.Margins = new StiMargins(3, 2, 0, 0);
            Page1_Watermark = new StiWatermark();
            Page1_Watermark.Font = new Font("Arial", 100F);
            Page1_Watermark.Image = null;
            Page1_Watermark.TextBrush = new StiSolidBrush(Color.FromArgb(50, 0, 0, 0));
            Page1.Rendering += new EventHandler(Page1_Rendering);
            RptSalesOrderDetailThermalPrinter_PrinterSettings = new StiPrinterSettings();
            PrinterSettings = RptSalesOrderDetailThermalPrinter_PrinterSettings;
            Page1.Report = this;
            Page1.Watermark = Page1_Watermark;
            DataSP_GetSalesOrderHeader.Page = Page1;
            DataSP_GetSalesOrderHeader.Parent = Page1;
            Text1.Page = Page1;
            Text1.Parent = DataSP_GetSalesOrderHeader;
            Text2.Page = Page1;
            Text2.Parent = DataSP_GetSalesOrderHeader;
            Image1.Page = Page1;
            Image1.Parent = DataSP_GetSalesOrderHeader;
            Text11.Page = Page1;
            Text11.Parent = DataSP_GetSalesOrderHeader;
            HeaderSP_GetSalesOrderDetail.Page = Page1;
            HeaderSP_GetSalesOrderDetail.Parent = Page1;
            Text3.Page = Page1;
            Text3.Parent = HeaderSP_GetSalesOrderDetail;
            Text4.Page = Page1;
            Text4.Parent = HeaderSP_GetSalesOrderDetail;
            Text5.Page = Page1;
            Text5.Parent = HeaderSP_GetSalesOrderDetail;
            Text6.Page = Page1;
            Text6.Parent = HeaderSP_GetSalesOrderDetail;
            DataSP_GetSalesOrderDetail.MasterComponent = DataSP_GetSalesOrderHeader;
            DataSP_GetSalesOrderDetail.Page = Page1;
            DataSP_GetSalesOrderDetail.Parent = Page1;
            Text7.Page = Page1;
            Text7.Parent = DataSP_GetSalesOrderDetail;
            Text8.Page = Page1;
            Text8.Parent = DataSP_GetSalesOrderDetail;
            Text9.Page = Page1;
            Text9.Parent = DataSP_GetSalesOrderDetail;
            Text10.Page = Page1;
            Text10.Parent = DataSP_GetSalesOrderDetail;
            FooterSP_GetSalesOrderDetail.Page = Page1;
            FooterSP_GetSalesOrderDetail.Parent = Page1;
            Text12.Page = Page1;
            Text12.Parent = FooterSP_GetSalesOrderDetail;
            Text14.Page = Page1;
            Text14.Parent = FooterSP_GetSalesOrderDetail;
            Text16.Page = Page1;
            Text16.Parent = FooterSP_GetSalesOrderDetail;
            Text17.Page = Page1;
            Text17.Parent = FooterSP_GetSalesOrderDetail;
            Text18.Page = Page1;
            Text18.Parent = FooterSP_GetSalesOrderDetail;
            Text19.Page = Page1;
            Text19.Parent = FooterSP_GetSalesOrderDetail;
            DataSP_GetSalesOrderDetail.BeginRender += new EventHandler(DataSP_GetSalesOrderDetail__BeginRender);
            DataSP_GetSalesOrderDetail.EndRender += new EventHandler(DataSP_GetSalesOrderDetail__EndRender);
            DataSP_GetSalesOrderDetail.Rendering += new EventHandler(DataSP_GetSalesOrderDetail__Rendering);
            AggregateFunctions = new object[] {
                    Text12_Count,
                    Text14_Sum,
                    Text17_Sum};
            // 
            // Add to DataSP_GetSalesOrderHeader.Components
            // 
            DataSP_GetSalesOrderHeader.Components.Clear();
            DataSP_GetSalesOrderHeader.Components.AddRange(new StiComponent[] {
                        Text1,
                        Text2,
                        Image1,
                        Text11});
            // 
            // Add to HeaderSP_GetSalesOrderDetail.Components
            // 
            HeaderSP_GetSalesOrderDetail.Components.Clear();
            HeaderSP_GetSalesOrderDetail.Components.AddRange(new StiComponent[] {
                        Text3,
                        Text4,
                        Text5,
                        Text6});
            // 
            // Add to DataSP_GetSalesOrderDetail.Components
            // 
            DataSP_GetSalesOrderDetail.Components.Clear();
            DataSP_GetSalesOrderDetail.Components.AddRange(new StiComponent[] {
                        Text7,
                        Text8,
                        Text9,
                        Text10});
            // 
            // Add to FooterSP_GetSalesOrderDetail.Components
            // 
            FooterSP_GetSalesOrderDetail.Components.Clear();
            FooterSP_GetSalesOrderDetail.Components.AddRange(new StiComponent[] {
                        Text12,
                        Text14,
                        Text16,
                        Text17,
                        Text18,
                        Text19});
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
                        new StiDataColumn("ValidDate", "ValidDate", "ValidDate", typeof(DateTime)),
                        new StiDataColumn("CountryCode", "CountryCode", "CountryCode", typeof(string)),
                        new StiDataColumn("CountryName", "CountryName", "CountryName", typeof(string)),
                        new StiDataColumn("BrandID", "BrandID", "BrandID", typeof(int)),
                        new StiDataColumn("BrandName", "BrandName", "BrandName", typeof(string)),
                        new StiDataColumn("Serie", "Serie", "Serie", typeof(string)),
                        new StiDataColumn("UnitsInStock", "UnitsInStock", "UnitsInStock", typeof(short)),
                        new StiDataColumn("_ResidualQty", "_ResidualQty", "_ResidualQty", typeof(decimal)),
                        new StiDataColumn("_SaleUnitQty", "_SaleUnitQty", "_SaleUnitQty", typeof(int)),
                        new StiDataColumn("Action", "Action", "Action", typeof(int)),
                        new StiCalcDataColumn("LinePrice", "LinePrice", typeof(decimal)),
                        new StiCalcDataColumn("LineTotalWithoutDiscount", "LineTotalWithoutDiscount", typeof(decimal)),
                        new StiCalcDataColumn("DiscountAmount", "DiscountAmount", typeof(decimal))});
            DataSources.Add(SP_GetSalesOrderDetail);
        }

        public decimal GetSP_GetSalesOrderDetail_LinePrice()
        {
            return SP_GetSalesOrderDetail.UnitPrice * (1m - SP_GetSalesOrderDetail.UnitPriceDiscount);
        }

        public decimal GetSP_GetSalesOrderDetail_LineTotalWithoutDiscount()
        {
            return SP_GetSalesOrderDetail.UnitPrice * SP_GetSalesOrderDetail.SaleQty;
        }

        public decimal GetSP_GetSalesOrderDetail_DiscountAmount()
        {
            return SP_GetSalesOrderDetail.LineTotalWithoutDiscount - SP_GetSalesOrderDetail.LineTotal;
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

            public virtual decimal LinePrice
            {
                get
                {
                    return ((RptSalesOrderDetailThermalPrinter)(Dictionary.Report)).GetSP_GetSalesOrderDetail_LinePrice();
                }
            }

            public virtual decimal LineTotalWithoutDiscount
            {
                get
                {
                    return ((RptSalesOrderDetailThermalPrinter)(Dictionary.Report)).GetSP_GetSalesOrderDetail_LineTotalWithoutDiscount();
                }
            }

            public virtual decimal DiscountAmount
            {
                get
                {
                    return ((RptSalesOrderDetailThermalPrinter)(Dictionary.Report)).GetSP_GetSalesOrderDetail_DiscountAmount();
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