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

    public class RptPurchaseOrderHeader : StiReport
    {

        public RptPurchaseOrderHeader()
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
        public StiHeaderBand HeaderVW_PurchaseOrderHeader;
        public StiText HeaderVW_PurchaseOrderHeader_rowguid;
        public StiText HeaderVW_PurchaseOrderHeader_PurchaseOrderID;
        public StiText HeaderVW_PurchaseOrderHeader_BranchName;
        public StiText HeaderVW_PurchaseOrderHeader_OrderDate;
        public StiText HeaderVW_PurchaseOrderHeader_SubTotal;
        public StiText HeaderVW_PurchaseOrderHeader_TaxAmt;
        public StiText HeaderVW_PurchaseOrderHeader_TotalDue;
        public StiText HeaderVW_PurchaseOrderHeader_CurrencyCode;
        public StiText HeaderVW_PurchaseOrderHeader_OverheadNumber;
        public StiText HeaderVW_PurchaseOrderHeader_Modifier;
        public StiText HeaderVW_PurchaseOrderHeader_Status;
        public StiText ReportTitleText;
        public StiText Text2;
        public StiText Text3;
        public StiText Text4;
        public StiText Text5;
        public StiText Text1;
        public StiText Text8;
        public StiDataBand DataVW_PurchaseOrderHeader;
        public StiText DataVW_PurchaseOrderHeader_rowguid;
        public StiText DataVW_PurchaseOrderHeader_PurchaseOrderID;
        public StiText DataVW_PurchaseOrderHeader_OrderDate;
        public StiText DataVW_PurchaseOrderHeader_SubTotal;
        public StiText DataVW_PurchaseOrderHeader_TaxAmt;
        public StiText DataVW_PurchaseOrderHeader_TotalDue;
        public StiText DataVW_PurchaseOrderHeader_CurrencyCode;
        public StiText DataVW_PurchaseOrderHeader_OverheadNumber;
        public StiText DataVW_PurchaseOrderHeader_Modifier;
        public StiCheckBox CheckBox1;
        public StiText Text6;
        public StiText Text7;
        public StiFooterBand FooterVW_PurchaseOrderHeader;
        public StiText Text9;
        public StiSumDecimalFunctionService Text9_Sum;
        public StiText Text10;
        public StiSumDecimalFunctionService Text10_Sum;
        public StiText Text11;
        public StiSumDecimalFunctionService Text11_Sum;
        public StiWatermark Page1_Watermark;
        public StiPrinterSettings RptPurchaseOrderHeader_PrinterSettings;
        public VW_PurchaseOrderHeaderDataSource VW_PurchaseOrderHeader;
        public T_PurchaseListDataSource T_PurchaseList;

        public void HeaderVW_PurchaseOrderHeader_rowguid__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "რიგითი №";
        }

        public void HeaderVW_PurchaseOrderHeader_PurchaseOrderID__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "შესყიდვის №";
        }

        public void HeaderVW_PurchaseOrderHeader_BranchName__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ფილიალი";
        }

        public void HeaderVW_PurchaseOrderHeader_OrderDate__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "შესყიდვის თარიღი";
        }

        public void HeaderVW_PurchaseOrderHeader_SubTotal__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ქვეჯამი";
        }

        public void HeaderVW_PurchaseOrderHeader_TaxAmt__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "დღგ";
        }

        public void HeaderVW_PurchaseOrderHeader_TotalDue__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "სულ ჯამი";
        }

        public void HeaderVW_PurchaseOrderHeader_CurrencyCode__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ვალუტა";
        }

        public void HeaderVW_PurchaseOrderHeader_OverheadNumber__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ზედნადების, ა/ფ-ს № და თარიღი";
        }

        public void HeaderVW_PurchaseOrderHeader_Modifier__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ოპერატორი";
        }

        public void HeaderVW_PurchaseOrderHeader_Status__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "სტატუსი";
        }

        public void ReportTitleText__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "შესყიდვის რეესტრი";
        }

        public void Text2__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, MyCompanyName, true);
        }

        public void Text3__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "თარიღი:";
        }

        public void Text4__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Format("{0:d}", T_PurchaseList.Date1), true) + " - " + ToString(sender, Format("{0:d}", T_PurchaseList.Date2), true);
        }

        public void Text5__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "პერიოდი:";
        }

        public void Text1__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text1.TextFormat.Format(CheckExcelValue(sender, Today));
        }

        public void Text8__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "მომწოდებელი";
        }

        public void DataVW_PurchaseOrderHeader_rowguid__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Line, true);
        }

        public void DataVW_PurchaseOrderHeader_PurchaseOrderID__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, VW_PurchaseOrderHeader.PurchaseOrderID, true);
        }

        public void DataVW_PurchaseOrderHeader_OrderDate__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = DataVW_PurchaseOrderHeader_OrderDate.TextFormat.Format(CheckExcelValue(sender, VW_PurchaseOrderHeader.OrderDate));
        }

        public void DataVW_PurchaseOrderHeader_SubTotal__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = DataVW_PurchaseOrderHeader_SubTotal.TextFormat.Format(CheckExcelValue(sender, VW_PurchaseOrderHeader.SubTotal));
        }

        public void DataVW_PurchaseOrderHeader_TaxAmt__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = DataVW_PurchaseOrderHeader_TaxAmt.TextFormat.Format(CheckExcelValue(sender, VW_PurchaseOrderHeader.TaxAmt));
        }

        public void DataVW_PurchaseOrderHeader_TotalDue__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = DataVW_PurchaseOrderHeader_TotalDue.TextFormat.Format(CheckExcelValue(sender, VW_PurchaseOrderHeader.TotalDue));
        }

        public void DataVW_PurchaseOrderHeader_CurrencyCode__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, VW_PurchaseOrderHeader.CurrencyCode, true);
        }

        public void DataVW_PurchaseOrderHeader_OverheadNumber__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, VW_PurchaseOrderHeader.OverheadNumber, true);
        }

        public void DataVW_PurchaseOrderHeader_Modifier__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, VW_PurchaseOrderHeader.Modifier, true);
        }

        public void CheckBox1__GetChecked(object sender, StiValueEventArgs e)
        {
            e.Value = VW_PurchaseOrderHeader.Status == 2;
        }

        public void Text6__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, VW_PurchaseOrderHeader.BranchName, true);
        }

        public void Text7__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, VW_PurchaseOrderHeader.VendorName, true);
        }

        public void Text9__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(DataVW_PurchaseOrderHeader,VW_PurchaseOrderHeader.SubTotal)}";
            e.StoreToPrinted = true;
        }

        public String Text9_GetValue_End(StiComponent sender)
        {
            return Text9.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text9_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void Text10__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(DataVW_PurchaseOrderHeader,VW_PurchaseOrderHeader.TaxAmt)}";
            e.StoreToPrinted = true;
        }

        public String Text10_GetValue_End(StiComponent sender)
        {
            return Text10.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text10_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void Text11__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(DataVW_PurchaseOrderHeader,VW_PurchaseOrderHeader.TotalDue)}";
            e.StoreToPrinted = true;
        }

        public String Text11_GetValue_End(StiComponent sender)
        {
            return Text11.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text11_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void DataVW_PurchaseOrderHeader__BeginRender(object sender, EventArgs e)
        {
            Text9_Sum.Init();
            Text9.TextValue = "";
            Text10_Sum.Init();
            Text10.TextValue = "";
            Text11_Sum.Init();
            Text11.TextValue = "";
        }

        public void DataVW_PurchaseOrderHeader__EndRender(object sender, EventArgs e)
        {
            Text9.SetText(new StiGetValue(Text9_GetValue_End));
            Text10.SetText(new StiGetValue(Text10_GetValue_End));
            Text11.SetText(new StiGetValue(Text11_GetValue_End));
        }

        public void DataVW_PurchaseOrderHeader__Rendering(object sender, EventArgs e)
        {
            Text9_Sum.CalcItem(VW_PurchaseOrderHeader.SubTotal);
            Text10_Sum.CalcItem(VW_PurchaseOrderHeader.TaxAmt);
            Text11_Sum.CalcItem(VW_PurchaseOrderHeader.TotalDue);
        }

        private void InitializeComponent()
        {
            T_PurchaseList = new T_PurchaseListDataSource();
            VW_PurchaseOrderHeader = new VW_PurchaseOrderHeaderDataSource();
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
            Text11_Sum = new StiSumDecimalFunctionService();
            Text10_Sum = new StiSumDecimalFunctionService();
            Text9_Sum = new StiSumDecimalFunctionService();
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
            ReportAlias = "Rpt Purchase Order Header";
            ReportAuthor = "Programmer.GE";
            // 
            // ReportChanged
            // 
            ReportChanged = new DateTime(2010, 6, 2, 17, 24, 59, 0);
            // 
            // ReportCreated
            // 
            ReportCreated = new DateTime(2009, 2, 7, 15, 8, 11, 0);
            ReportDescription = "შესყიდვის რეესტრი";
            ReportFile = "D:\\User\\Documents\\Projects\\Apothex\\Source\\Class Library\\Apothex.Reporting\\Purchas" +
"ing\\RptPurchaseOrderHeader.mrt";
            ReportGuid = "52d10ee37e6348fe828f45711efba394";
            ReportName = "RptPurchaseOrderHeader";
            ReportUnit = StiReportUnitType.Centimeters;
            ScriptLanguage = StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            Page1 = new StiPage();
            Page1.Guid = "c02c4649afca437a8e869c932419fda6";
            Page1.Name = "Page1";
            Page1.PageHeight = 29.7;
            Page1.PageWidth = 21;
            Page1.PaperSize = PaperKind.A4;
            Page1.Border = new StiBorder(StiBorderSides.None, Color.Black, 2, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Page1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // HeaderVW_PurchaseOrderHeader
            // 
            HeaderVW_PurchaseOrderHeader = new StiHeaderBand();
            HeaderVW_PurchaseOrderHeader.ClientRectangle = new RectangleD(0, 0.4, 20, 2.4);
            HeaderVW_PurchaseOrderHeader.Name = "HeaderVW_PurchaseOrderHeader";
            HeaderVW_PurchaseOrderHeader.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_PurchaseOrderHeader.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // HeaderVW_PurchaseOrderHeader_rowguid
            // 
            HeaderVW_PurchaseOrderHeader_rowguid = new StiText();
            HeaderVW_PurchaseOrderHeader_rowguid.ClientRectangle = new RectangleD(0, 1.4, 1, 1);
            HeaderVW_PurchaseOrderHeader_rowguid.HorAlignment = StiTextHorAlignment.Center;
            HeaderVW_PurchaseOrderHeader_rowguid.Name = "HeaderVW_PurchaseOrderHeader_rowguid";
            HeaderVW_PurchaseOrderHeader_rowguid.GetValue += new StiGetValueEventHandler(HeaderVW_PurchaseOrderHeader_rowguid__GetValue);
            HeaderVW_PurchaseOrderHeader_rowguid.VertAlignment = StiVertAlignment.Center;
            HeaderVW_PurchaseOrderHeader_rowguid.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_PurchaseOrderHeader_rowguid.Brush = new StiSolidBrush(Color.Transparent);
            HeaderVW_PurchaseOrderHeader_rowguid.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            HeaderVW_PurchaseOrderHeader_rowguid.Guid = null;
            HeaderVW_PurchaseOrderHeader_rowguid.Interaction = null;
            HeaderVW_PurchaseOrderHeader_rowguid.Margins = new StiMargins(0, 0, 0, 0);
            HeaderVW_PurchaseOrderHeader_rowguid.TextBrush = new StiSolidBrush(Color.Black);
            HeaderVW_PurchaseOrderHeader_rowguid.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderVW_PurchaseOrderHeader_PurchaseOrderID
            // 
            HeaderVW_PurchaseOrderHeader_PurchaseOrderID = new StiText();
            HeaderVW_PurchaseOrderHeader_PurchaseOrderID.ClientRectangle = new RectangleD(1, 1.4, 1.6, 1);
            HeaderVW_PurchaseOrderHeader_PurchaseOrderID.HorAlignment = StiTextHorAlignment.Center;
            HeaderVW_PurchaseOrderHeader_PurchaseOrderID.Name = "HeaderVW_PurchaseOrderHeader_PurchaseOrderID";
            HeaderVW_PurchaseOrderHeader_PurchaseOrderID.GetValue += new StiGetValueEventHandler(HeaderVW_PurchaseOrderHeader_PurchaseOrderID__GetValue);
            HeaderVW_PurchaseOrderHeader_PurchaseOrderID.VertAlignment = StiVertAlignment.Center;
            HeaderVW_PurchaseOrderHeader_PurchaseOrderID.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_PurchaseOrderHeader_PurchaseOrderID.Brush = new StiSolidBrush(Color.Transparent);
            HeaderVW_PurchaseOrderHeader_PurchaseOrderID.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            HeaderVW_PurchaseOrderHeader_PurchaseOrderID.Guid = null;
            HeaderVW_PurchaseOrderHeader_PurchaseOrderID.Interaction = null;
            HeaderVW_PurchaseOrderHeader_PurchaseOrderID.Margins = new StiMargins(0, 0, 0, 0);
            HeaderVW_PurchaseOrderHeader_PurchaseOrderID.TextBrush = new StiSolidBrush(Color.Black);
            HeaderVW_PurchaseOrderHeader_PurchaseOrderID.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderVW_PurchaseOrderHeader_BranchName
            // 
            HeaderVW_PurchaseOrderHeader_BranchName = new StiText();
            HeaderVW_PurchaseOrderHeader_BranchName.ClientRectangle = new RectangleD(2.6, 1.4, 2.6, 1);
            HeaderVW_PurchaseOrderHeader_BranchName.HorAlignment = StiTextHorAlignment.Center;
            HeaderVW_PurchaseOrderHeader_BranchName.Name = "HeaderVW_PurchaseOrderHeader_BranchName";
            HeaderVW_PurchaseOrderHeader_BranchName.GetValue += new StiGetValueEventHandler(HeaderVW_PurchaseOrderHeader_BranchName__GetValue);
            HeaderVW_PurchaseOrderHeader_BranchName.VertAlignment = StiVertAlignment.Center;
            HeaderVW_PurchaseOrderHeader_BranchName.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_PurchaseOrderHeader_BranchName.Brush = new StiSolidBrush(Color.Transparent);
            HeaderVW_PurchaseOrderHeader_BranchName.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            HeaderVW_PurchaseOrderHeader_BranchName.Guid = null;
            HeaderVW_PurchaseOrderHeader_BranchName.Interaction = null;
            HeaderVW_PurchaseOrderHeader_BranchName.Margins = new StiMargins(0, 0, 0, 0);
            HeaderVW_PurchaseOrderHeader_BranchName.TextBrush = new StiSolidBrush(Color.Black);
            HeaderVW_PurchaseOrderHeader_BranchName.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderVW_PurchaseOrderHeader_OrderDate
            // 
            HeaderVW_PurchaseOrderHeader_OrderDate = new StiText();
            HeaderVW_PurchaseOrderHeader_OrderDate.ClientRectangle = new RectangleD(5.2, 1.4, 1.6, 1);
            HeaderVW_PurchaseOrderHeader_OrderDate.HorAlignment = StiTextHorAlignment.Center;
            HeaderVW_PurchaseOrderHeader_OrderDate.Name = "HeaderVW_PurchaseOrderHeader_OrderDate";
            HeaderVW_PurchaseOrderHeader_OrderDate.GetValue += new StiGetValueEventHandler(HeaderVW_PurchaseOrderHeader_OrderDate__GetValue);
            HeaderVW_PurchaseOrderHeader_OrderDate.VertAlignment = StiVertAlignment.Center;
            HeaderVW_PurchaseOrderHeader_OrderDate.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_PurchaseOrderHeader_OrderDate.Brush = new StiSolidBrush(Color.Transparent);
            HeaderVW_PurchaseOrderHeader_OrderDate.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            HeaderVW_PurchaseOrderHeader_OrderDate.Guid = null;
            HeaderVW_PurchaseOrderHeader_OrderDate.Interaction = null;
            HeaderVW_PurchaseOrderHeader_OrderDate.Margins = new StiMargins(0, 0, 0, 0);
            HeaderVW_PurchaseOrderHeader_OrderDate.TextBrush = new StiSolidBrush(Color.Black);
            HeaderVW_PurchaseOrderHeader_OrderDate.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderVW_PurchaseOrderHeader_SubTotal
            // 
            HeaderVW_PurchaseOrderHeader_SubTotal = new StiText();
            HeaderVW_PurchaseOrderHeader_SubTotal.ClientRectangle = new RectangleD(9.8, 1.4, 1.2, 1);
            HeaderVW_PurchaseOrderHeader_SubTotal.HorAlignment = StiTextHorAlignment.Center;
            HeaderVW_PurchaseOrderHeader_SubTotal.Name = "HeaderVW_PurchaseOrderHeader_SubTotal";
            HeaderVW_PurchaseOrderHeader_SubTotal.GetValue += new StiGetValueEventHandler(HeaderVW_PurchaseOrderHeader_SubTotal__GetValue);
            HeaderVW_PurchaseOrderHeader_SubTotal.VertAlignment = StiVertAlignment.Center;
            HeaderVW_PurchaseOrderHeader_SubTotal.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_PurchaseOrderHeader_SubTotal.Brush = new StiSolidBrush(Color.Transparent);
            HeaderVW_PurchaseOrderHeader_SubTotal.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            HeaderVW_PurchaseOrderHeader_SubTotal.Guid = null;
            HeaderVW_PurchaseOrderHeader_SubTotal.Interaction = null;
            HeaderVW_PurchaseOrderHeader_SubTotal.Margins = new StiMargins(0, 0, 0, 0);
            HeaderVW_PurchaseOrderHeader_SubTotal.TextBrush = new StiSolidBrush(Color.Black);
            HeaderVW_PurchaseOrderHeader_SubTotal.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderVW_PurchaseOrderHeader_TaxAmt
            // 
            HeaderVW_PurchaseOrderHeader_TaxAmt = new StiText();
            HeaderVW_PurchaseOrderHeader_TaxAmt.ClientRectangle = new RectangleD(11, 1.4, 1, 1);
            HeaderVW_PurchaseOrderHeader_TaxAmt.HorAlignment = StiTextHorAlignment.Center;
            HeaderVW_PurchaseOrderHeader_TaxAmt.Name = "HeaderVW_PurchaseOrderHeader_TaxAmt";
            HeaderVW_PurchaseOrderHeader_TaxAmt.GetValue += new StiGetValueEventHandler(HeaderVW_PurchaseOrderHeader_TaxAmt__GetValue);
            HeaderVW_PurchaseOrderHeader_TaxAmt.VertAlignment = StiVertAlignment.Center;
            HeaderVW_PurchaseOrderHeader_TaxAmt.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_PurchaseOrderHeader_TaxAmt.Brush = new StiSolidBrush(Color.Transparent);
            HeaderVW_PurchaseOrderHeader_TaxAmt.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            HeaderVW_PurchaseOrderHeader_TaxAmt.Guid = null;
            HeaderVW_PurchaseOrderHeader_TaxAmt.Interaction = null;
            HeaderVW_PurchaseOrderHeader_TaxAmt.Margins = new StiMargins(0, 0, 0, 0);
            HeaderVW_PurchaseOrderHeader_TaxAmt.TextBrush = new StiSolidBrush(Color.Black);
            HeaderVW_PurchaseOrderHeader_TaxAmt.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderVW_PurchaseOrderHeader_TotalDue
            // 
            HeaderVW_PurchaseOrderHeader_TotalDue = new StiText();
            HeaderVW_PurchaseOrderHeader_TotalDue.ClientRectangle = new RectangleD(12, 1.4, 1.4, 1);
            HeaderVW_PurchaseOrderHeader_TotalDue.HorAlignment = StiTextHorAlignment.Center;
            HeaderVW_PurchaseOrderHeader_TotalDue.Name = "HeaderVW_PurchaseOrderHeader_TotalDue";
            HeaderVW_PurchaseOrderHeader_TotalDue.GetValue += new StiGetValueEventHandler(HeaderVW_PurchaseOrderHeader_TotalDue__GetValue);
            HeaderVW_PurchaseOrderHeader_TotalDue.VertAlignment = StiVertAlignment.Center;
            HeaderVW_PurchaseOrderHeader_TotalDue.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_PurchaseOrderHeader_TotalDue.Brush = new StiSolidBrush(Color.Transparent);
            HeaderVW_PurchaseOrderHeader_TotalDue.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            HeaderVW_PurchaseOrderHeader_TotalDue.Guid = null;
            HeaderVW_PurchaseOrderHeader_TotalDue.Interaction = null;
            HeaderVW_PurchaseOrderHeader_TotalDue.Margins = new StiMargins(0, 0, 0, 0);
            HeaderVW_PurchaseOrderHeader_TotalDue.TextBrush = new StiSolidBrush(Color.Black);
            HeaderVW_PurchaseOrderHeader_TotalDue.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderVW_PurchaseOrderHeader_CurrencyCode
            // 
            HeaderVW_PurchaseOrderHeader_CurrencyCode = new StiText();
            HeaderVW_PurchaseOrderHeader_CurrencyCode.ClientRectangle = new RectangleD(13.4, 1.4, 0.8, 1);
            HeaderVW_PurchaseOrderHeader_CurrencyCode.HorAlignment = StiTextHorAlignment.Center;
            HeaderVW_PurchaseOrderHeader_CurrencyCode.Name = "HeaderVW_PurchaseOrderHeader_CurrencyCode";
            HeaderVW_PurchaseOrderHeader_CurrencyCode.GetValue += new StiGetValueEventHandler(HeaderVW_PurchaseOrderHeader_CurrencyCode__GetValue);
            HeaderVW_PurchaseOrderHeader_CurrencyCode.VertAlignment = StiVertAlignment.Center;
            HeaderVW_PurchaseOrderHeader_CurrencyCode.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_PurchaseOrderHeader_CurrencyCode.Brush = new StiSolidBrush(Color.Transparent);
            HeaderVW_PurchaseOrderHeader_CurrencyCode.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            HeaderVW_PurchaseOrderHeader_CurrencyCode.Guid = null;
            HeaderVW_PurchaseOrderHeader_CurrencyCode.Interaction = null;
            HeaderVW_PurchaseOrderHeader_CurrencyCode.Margins = new StiMargins(0, 0, 0, 0);
            HeaderVW_PurchaseOrderHeader_CurrencyCode.TextBrush = new StiSolidBrush(Color.Black);
            HeaderVW_PurchaseOrderHeader_CurrencyCode.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderVW_PurchaseOrderHeader_OverheadNumber
            // 
            HeaderVW_PurchaseOrderHeader_OverheadNumber = new StiText();
            HeaderVW_PurchaseOrderHeader_OverheadNumber.ClientRectangle = new RectangleD(14.2, 1.4, 2.8, 1);
            HeaderVW_PurchaseOrderHeader_OverheadNumber.HorAlignment = StiTextHorAlignment.Center;
            HeaderVW_PurchaseOrderHeader_OverheadNumber.Name = "HeaderVW_PurchaseOrderHeader_OverheadNumber";
            HeaderVW_PurchaseOrderHeader_OverheadNumber.GetValue += new StiGetValueEventHandler(HeaderVW_PurchaseOrderHeader_OverheadNumber__GetValue);
            HeaderVW_PurchaseOrderHeader_OverheadNumber.VertAlignment = StiVertAlignment.Center;
            HeaderVW_PurchaseOrderHeader_OverheadNumber.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_PurchaseOrderHeader_OverheadNumber.Brush = new StiSolidBrush(Color.Transparent);
            HeaderVW_PurchaseOrderHeader_OverheadNumber.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            HeaderVW_PurchaseOrderHeader_OverheadNumber.Guid = null;
            HeaderVW_PurchaseOrderHeader_OverheadNumber.Interaction = null;
            HeaderVW_PurchaseOrderHeader_OverheadNumber.Margins = new StiMargins(0, 0, 0, 0);
            HeaderVW_PurchaseOrderHeader_OverheadNumber.TextBrush = new StiSolidBrush(Color.Black);
            HeaderVW_PurchaseOrderHeader_OverheadNumber.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderVW_PurchaseOrderHeader_Modifier
            // 
            HeaderVW_PurchaseOrderHeader_Modifier = new StiText();
            HeaderVW_PurchaseOrderHeader_Modifier.ClientRectangle = new RectangleD(17, 1.4, 2.4, 1);
            HeaderVW_PurchaseOrderHeader_Modifier.HorAlignment = StiTextHorAlignment.Center;
            HeaderVW_PurchaseOrderHeader_Modifier.Name = "HeaderVW_PurchaseOrderHeader_Modifier";
            HeaderVW_PurchaseOrderHeader_Modifier.GetValue += new StiGetValueEventHandler(HeaderVW_PurchaseOrderHeader_Modifier__GetValue);
            HeaderVW_PurchaseOrderHeader_Modifier.VertAlignment = StiVertAlignment.Center;
            HeaderVW_PurchaseOrderHeader_Modifier.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_PurchaseOrderHeader_Modifier.Brush = new StiSolidBrush(Color.Transparent);
            HeaderVW_PurchaseOrderHeader_Modifier.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            HeaderVW_PurchaseOrderHeader_Modifier.Guid = null;
            HeaderVW_PurchaseOrderHeader_Modifier.Interaction = null;
            HeaderVW_PurchaseOrderHeader_Modifier.Margins = new StiMargins(0, 0, 0, 0);
            HeaderVW_PurchaseOrderHeader_Modifier.TextBrush = new StiSolidBrush(Color.Black);
            HeaderVW_PurchaseOrderHeader_Modifier.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderVW_PurchaseOrderHeader_Status
            // 
            HeaderVW_PurchaseOrderHeader_Status = new StiText();
            HeaderVW_PurchaseOrderHeader_Status.ClientRectangle = new RectangleD(19.4, 1.4, 0.6, 1);
            HeaderVW_PurchaseOrderHeader_Status.HorAlignment = StiTextHorAlignment.Center;
            HeaderVW_PurchaseOrderHeader_Status.Name = "HeaderVW_PurchaseOrderHeader_Status";
            HeaderVW_PurchaseOrderHeader_Status.GetValue += new StiGetValueEventHandler(HeaderVW_PurchaseOrderHeader_Status__GetValue);
            HeaderVW_PurchaseOrderHeader_Status.VertAlignment = StiVertAlignment.Center;
            HeaderVW_PurchaseOrderHeader_Status.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_PurchaseOrderHeader_Status.Brush = new StiSolidBrush(Color.Transparent);
            HeaderVW_PurchaseOrderHeader_Status.Font = new Font("BPG Glaho Arial", 8F, FontStyle.Bold);
            HeaderVW_PurchaseOrderHeader_Status.Guid = null;
            HeaderVW_PurchaseOrderHeader_Status.Interaction = null;
            HeaderVW_PurchaseOrderHeader_Status.Margins = new StiMargins(0, 0, 0, 0);
            HeaderVW_PurchaseOrderHeader_Status.TextBrush = new StiSolidBrush(Color.Black);
            HeaderVW_PurchaseOrderHeader_Status.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // ReportTitleText
            // 
            ReportTitleText = new StiText();
            ReportTitleText.ClientRectangle = new RectangleD(0, 0, 19, 0.6);
            ReportTitleText.HorAlignment = StiTextHorAlignment.Center;
            ReportTitleText.Name = "ReportTitleText";
            ReportTitleText.GetValue += new StiGetValueEventHandler(ReportTitleText__GetValue);
            ReportTitleText.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            ReportTitleText.Brush = new StiSolidBrush(Color.Transparent);
            ReportTitleText.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            ReportTitleText.Guid = null;
            ReportTitleText.Interaction = null;
            ReportTitleText.Margins = new StiMargins(0, 0, 0, 0);
            ReportTitleText.TextBrush = new StiSolidBrush(Color.Black);
            ReportTitleText.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text2
            // 
            Text2 = new StiText();
            Text2.ClientRectangle = new RectangleD(0, 0.6, 8.4, 0.6);
            Text2.Guid = "24c9e8a099d24fb7b350e45d3d00a295";
            Text2.Name = "Text2";
            Text2.GetValue += new StiGetValueEventHandler(Text2__GetValue);
            Text2.VertAlignment = StiVertAlignment.Center;
            Text2.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text2.Brush = new StiSolidBrush(Color.Transparent);
            Text2.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            Text2.Interaction = null;
            Text2.Margins = new StiMargins(0, 0, 0, 0);
            Text2.TextBrush = new StiSolidBrush(Color.Black);
            Text2.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text3
            // 
            Text3 = new StiText();
            Text3.ClientRectangle = new RectangleD(15.2, 0.6, 1.8, 0.6);
            Text3.Guid = "314a0a4ec84543eca394be22bd901bec";
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
            Text4.ClientRectangle = new RectangleD(10.2, 0.6, 3.6, 0.6);
            Text4.Guid = "4a891c6d787a4425b2bdf1b4bd516f16";
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
            Text5.ClientRectangle = new RectangleD(8.4, 0.6, 1.8, 0.6);
            Text5.Guid = "93bda2bddc254e9b8bb58bd1763a7fb2";
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
            // Text1
            // 
            Text1 = new StiText();
            Text1.ClientRectangle = new RectangleD(17, 0.6, 2, 0.6);
            Text1.Guid = "b5f4fee8aa544df08256e6e8758d1ea1";
            Text1.Name = "Text1";
            Text1.GetValue += new StiGetValueEventHandler(Text1__GetValue);
            Text1.VertAlignment = StiVertAlignment.Center;
            Text1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text1.Brush = new StiSolidBrush(Color.Transparent);
            Text1.Font = new Font("BPG Glaho Arial", 10F);
            Text1.Interaction = null;
            Text1.Margins = new StiMargins(0, 0, 0, 0);
            Text1.TextBrush = new StiSolidBrush(Color.Black);
            Text1.TextFormat = new StiDateFormatService("d", " ");
            Text1.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text8
            // 
            Text8 = new StiText();
            Text8.ClientRectangle = new RectangleD(6.8, 1.4, 3, 1);
            Text8.Guid = "f96bc4b8157142b1ba6de144d9b8e995";
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
            HeaderVW_PurchaseOrderHeader.Guid = null;
            HeaderVW_PurchaseOrderHeader.Interaction = null;
            // 
            // DataVW_PurchaseOrderHeader
            // 
            DataVW_PurchaseOrderHeader = new StiDataBand();
            DataVW_PurchaseOrderHeader.ClientRectangle = new RectangleD(0, 3.6, 20, 0.8);
            DataVW_PurchaseOrderHeader.DataSourceName = "VW_PurchaseOrderHeader";
            DataVW_PurchaseOrderHeader.Name = "DataVW_PurchaseOrderHeader";
            DataVW_PurchaseOrderHeader.Sort = new String[0];
            DataVW_PurchaseOrderHeader.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataVW_PurchaseOrderHeader.Brush = new StiSolidBrush(Color.Transparent);
            DataVW_PurchaseOrderHeader.BusinessObjectGuid = null;
            // 
            // DataVW_PurchaseOrderHeader_rowguid
            // 
            DataVW_PurchaseOrderHeader_rowguid = new StiText();
            DataVW_PurchaseOrderHeader_rowguid.CanGrow = true;
            DataVW_PurchaseOrderHeader_rowguid.ClientRectangle = new RectangleD(0, 0, 1, 0.8);
            DataVW_PurchaseOrderHeader_rowguid.GrowToHeight = true;
            DataVW_PurchaseOrderHeader_rowguid.Name = "DataVW_PurchaseOrderHeader_rowguid";
            DataVW_PurchaseOrderHeader_rowguid.GetValue += new StiGetValueEventHandler(DataVW_PurchaseOrderHeader_rowguid__GetValue);
            DataVW_PurchaseOrderHeader_rowguid.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataVW_PurchaseOrderHeader_rowguid.Brush = new StiSolidBrush(Color.Transparent);
            DataVW_PurchaseOrderHeader_rowguid.Font = new Font("BPG Glaho Arial", 8F);
            DataVW_PurchaseOrderHeader_rowguid.Guid = null;
            DataVW_PurchaseOrderHeader_rowguid.Interaction = null;
            DataVW_PurchaseOrderHeader_rowguid.Margins = new StiMargins(0, 0, 0, 0);
            DataVW_PurchaseOrderHeader_rowguid.TextBrush = new StiSolidBrush(Color.Black);
            DataVW_PurchaseOrderHeader_rowguid.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataVW_PurchaseOrderHeader_PurchaseOrderID
            // 
            DataVW_PurchaseOrderHeader_PurchaseOrderID = new StiText();
            DataVW_PurchaseOrderHeader_PurchaseOrderID.CanGrow = true;
            DataVW_PurchaseOrderHeader_PurchaseOrderID.ClientRectangle = new RectangleD(1, 0, 1.6, 0.8);
            DataVW_PurchaseOrderHeader_PurchaseOrderID.GrowToHeight = true;
            DataVW_PurchaseOrderHeader_PurchaseOrderID.Name = "DataVW_PurchaseOrderHeader_PurchaseOrderID";
            DataVW_PurchaseOrderHeader_PurchaseOrderID.GetValue += new StiGetValueEventHandler(DataVW_PurchaseOrderHeader_PurchaseOrderID__GetValue);
            DataVW_PurchaseOrderHeader_PurchaseOrderID.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataVW_PurchaseOrderHeader_PurchaseOrderID.Brush = new StiSolidBrush(Color.Transparent);
            DataVW_PurchaseOrderHeader_PurchaseOrderID.Font = new Font("BPG Glaho Arial", 8F);
            DataVW_PurchaseOrderHeader_PurchaseOrderID.Guid = null;
            DataVW_PurchaseOrderHeader_PurchaseOrderID.Interaction = null;
            DataVW_PurchaseOrderHeader_PurchaseOrderID.Margins = new StiMargins(0, 0, 0, 0);
            DataVW_PurchaseOrderHeader_PurchaseOrderID.TextBrush = new StiSolidBrush(Color.Black);
            DataVW_PurchaseOrderHeader_PurchaseOrderID.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataVW_PurchaseOrderHeader_OrderDate
            // 
            DataVW_PurchaseOrderHeader_OrderDate = new StiText();
            DataVW_PurchaseOrderHeader_OrderDate.CanGrow = true;
            DataVW_PurchaseOrderHeader_OrderDate.ClientRectangle = new RectangleD(5.2, 0, 1.6, 0.8);
            DataVW_PurchaseOrderHeader_OrderDate.GrowToHeight = true;
            DataVW_PurchaseOrderHeader_OrderDate.Name = "DataVW_PurchaseOrderHeader_OrderDate";
            DataVW_PurchaseOrderHeader_OrderDate.GetValue += new StiGetValueEventHandler(DataVW_PurchaseOrderHeader_OrderDate__GetValue);
            DataVW_PurchaseOrderHeader_OrderDate.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataVW_PurchaseOrderHeader_OrderDate.Brush = new StiSolidBrush(Color.Transparent);
            DataVW_PurchaseOrderHeader_OrderDate.Font = new Font("BPG Glaho Arial", 8F);
            DataVW_PurchaseOrderHeader_OrderDate.Guid = null;
            DataVW_PurchaseOrderHeader_OrderDate.Interaction = null;
            DataVW_PurchaseOrderHeader_OrderDate.Margins = new StiMargins(0, 0, 0, 0);
            DataVW_PurchaseOrderHeader_OrderDate.TextBrush = new StiSolidBrush(Color.Black);
            DataVW_PurchaseOrderHeader_OrderDate.TextFormat = new StiDateFormatService("d", " ");
            DataVW_PurchaseOrderHeader_OrderDate.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataVW_PurchaseOrderHeader_SubTotal
            // 
            DataVW_PurchaseOrderHeader_SubTotal = new StiText();
            DataVW_PurchaseOrderHeader_SubTotal.CanGrow = true;
            DataVW_PurchaseOrderHeader_SubTotal.ClientRectangle = new RectangleD(9.8, 0, 1.2, 0.8);
            DataVW_PurchaseOrderHeader_SubTotal.GrowToHeight = true;
            DataVW_PurchaseOrderHeader_SubTotal.HorAlignment = StiTextHorAlignment.Right;
            DataVW_PurchaseOrderHeader_SubTotal.Name = "DataVW_PurchaseOrderHeader_SubTotal";
            DataVW_PurchaseOrderHeader_SubTotal.GetValue += new StiGetValueEventHandler(DataVW_PurchaseOrderHeader_SubTotal__GetValue);
            DataVW_PurchaseOrderHeader_SubTotal.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataVW_PurchaseOrderHeader_SubTotal.Brush = new StiSolidBrush(Color.Transparent);
            DataVW_PurchaseOrderHeader_SubTotal.Font = new Font("BPG Glaho Arial", 8F);
            DataVW_PurchaseOrderHeader_SubTotal.Guid = null;
            DataVW_PurchaseOrderHeader_SubTotal.Interaction = null;
            DataVW_PurchaseOrderHeader_SubTotal.Margins = new StiMargins(0, 0, 0, 0);
            DataVW_PurchaseOrderHeader_SubTotal.TextBrush = new StiSolidBrush(Color.Black);
            DataVW_PurchaseOrderHeader_SubTotal.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            DataVW_PurchaseOrderHeader_SubTotal.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataVW_PurchaseOrderHeader_TaxAmt
            // 
            DataVW_PurchaseOrderHeader_TaxAmt = new StiText();
            DataVW_PurchaseOrderHeader_TaxAmt.CanGrow = true;
            DataVW_PurchaseOrderHeader_TaxAmt.ClientRectangle = new RectangleD(11, 0, 1, 0.8);
            DataVW_PurchaseOrderHeader_TaxAmt.GrowToHeight = true;
            DataVW_PurchaseOrderHeader_TaxAmt.HorAlignment = StiTextHorAlignment.Right;
            DataVW_PurchaseOrderHeader_TaxAmt.Name = "DataVW_PurchaseOrderHeader_TaxAmt";
            DataVW_PurchaseOrderHeader_TaxAmt.GetValue += new StiGetValueEventHandler(DataVW_PurchaseOrderHeader_TaxAmt__GetValue);
            DataVW_PurchaseOrderHeader_TaxAmt.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataVW_PurchaseOrderHeader_TaxAmt.Brush = new StiSolidBrush(Color.Transparent);
            DataVW_PurchaseOrderHeader_TaxAmt.Font = new Font("BPG Glaho Arial", 8F);
            DataVW_PurchaseOrderHeader_TaxAmt.Guid = null;
            DataVW_PurchaseOrderHeader_TaxAmt.Interaction = null;
            DataVW_PurchaseOrderHeader_TaxAmt.Margins = new StiMargins(0, 0, 0, 0);
            DataVW_PurchaseOrderHeader_TaxAmt.TextBrush = new StiSolidBrush(Color.Black);
            DataVW_PurchaseOrderHeader_TaxAmt.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            DataVW_PurchaseOrderHeader_TaxAmt.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataVW_PurchaseOrderHeader_TotalDue
            // 
            DataVW_PurchaseOrderHeader_TotalDue = new StiText();
            DataVW_PurchaseOrderHeader_TotalDue.CanGrow = true;
            DataVW_PurchaseOrderHeader_TotalDue.ClientRectangle = new RectangleD(12, 0, 1.4, 0.8);
            DataVW_PurchaseOrderHeader_TotalDue.GrowToHeight = true;
            DataVW_PurchaseOrderHeader_TotalDue.HorAlignment = StiTextHorAlignment.Right;
            DataVW_PurchaseOrderHeader_TotalDue.Name = "DataVW_PurchaseOrderHeader_TotalDue";
            DataVW_PurchaseOrderHeader_TotalDue.GetValue += new StiGetValueEventHandler(DataVW_PurchaseOrderHeader_TotalDue__GetValue);
            DataVW_PurchaseOrderHeader_TotalDue.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataVW_PurchaseOrderHeader_TotalDue.Brush = new StiSolidBrush(Color.Transparent);
            DataVW_PurchaseOrderHeader_TotalDue.Font = new Font("BPG Glaho Arial", 8F);
            DataVW_PurchaseOrderHeader_TotalDue.Guid = null;
            DataVW_PurchaseOrderHeader_TotalDue.Interaction = null;
            DataVW_PurchaseOrderHeader_TotalDue.Margins = new StiMargins(0, 0, 0, 0);
            DataVW_PurchaseOrderHeader_TotalDue.TextBrush = new StiSolidBrush(Color.Black);
            DataVW_PurchaseOrderHeader_TotalDue.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            DataVW_PurchaseOrderHeader_TotalDue.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataVW_PurchaseOrderHeader_CurrencyCode
            // 
            DataVW_PurchaseOrderHeader_CurrencyCode = new StiText();
            DataVW_PurchaseOrderHeader_CurrencyCode.CanGrow = true;
            DataVW_PurchaseOrderHeader_CurrencyCode.ClientRectangle = new RectangleD(13.4, 0, 0.8, 0.8);
            DataVW_PurchaseOrderHeader_CurrencyCode.GrowToHeight = true;
            DataVW_PurchaseOrderHeader_CurrencyCode.Name = "DataVW_PurchaseOrderHeader_CurrencyCode";
            DataVW_PurchaseOrderHeader_CurrencyCode.GetValue += new StiGetValueEventHandler(DataVW_PurchaseOrderHeader_CurrencyCode__GetValue);
            DataVW_PurchaseOrderHeader_CurrencyCode.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataVW_PurchaseOrderHeader_CurrencyCode.Brush = new StiSolidBrush(Color.Transparent);
            DataVW_PurchaseOrderHeader_CurrencyCode.Font = new Font("BPG Glaho Arial", 8F);
            DataVW_PurchaseOrderHeader_CurrencyCode.Guid = null;
            DataVW_PurchaseOrderHeader_CurrencyCode.Interaction = null;
            DataVW_PurchaseOrderHeader_CurrencyCode.Margins = new StiMargins(0, 0, 0, 0);
            DataVW_PurchaseOrderHeader_CurrencyCode.TextBrush = new StiSolidBrush(Color.Black);
            DataVW_PurchaseOrderHeader_CurrencyCode.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataVW_PurchaseOrderHeader_OverheadNumber
            // 
            DataVW_PurchaseOrderHeader_OverheadNumber = new StiText();
            DataVW_PurchaseOrderHeader_OverheadNumber.CanGrow = true;
            DataVW_PurchaseOrderHeader_OverheadNumber.ClientRectangle = new RectangleD(14.2, 0, 2.8, 0.8);
            DataVW_PurchaseOrderHeader_OverheadNumber.GrowToHeight = true;
            DataVW_PurchaseOrderHeader_OverheadNumber.Name = "DataVW_PurchaseOrderHeader_OverheadNumber";
            DataVW_PurchaseOrderHeader_OverheadNumber.GetValue += new StiGetValueEventHandler(DataVW_PurchaseOrderHeader_OverheadNumber__GetValue);
            DataVW_PurchaseOrderHeader_OverheadNumber.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataVW_PurchaseOrderHeader_OverheadNumber.Brush = new StiSolidBrush(Color.Transparent);
            DataVW_PurchaseOrderHeader_OverheadNumber.Font = new Font("BPG Glaho Arial", 8F);
            DataVW_PurchaseOrderHeader_OverheadNumber.Guid = null;
            DataVW_PurchaseOrderHeader_OverheadNumber.Interaction = null;
            DataVW_PurchaseOrderHeader_OverheadNumber.Margins = new StiMargins(0, 0, 0, 0);
            DataVW_PurchaseOrderHeader_OverheadNumber.TextBrush = new StiSolidBrush(Color.Black);
            DataVW_PurchaseOrderHeader_OverheadNumber.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataVW_PurchaseOrderHeader_Modifier
            // 
            DataVW_PurchaseOrderHeader_Modifier = new StiText();
            DataVW_PurchaseOrderHeader_Modifier.CanGrow = true;
            DataVW_PurchaseOrderHeader_Modifier.ClientRectangle = new RectangleD(17, 0, 2.4, 0.8);
            DataVW_PurchaseOrderHeader_Modifier.GrowToHeight = true;
            DataVW_PurchaseOrderHeader_Modifier.Name = "DataVW_PurchaseOrderHeader_Modifier";
            DataVW_PurchaseOrderHeader_Modifier.GetValue += new StiGetValueEventHandler(DataVW_PurchaseOrderHeader_Modifier__GetValue);
            DataVW_PurchaseOrderHeader_Modifier.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataVW_PurchaseOrderHeader_Modifier.Brush = new StiSolidBrush(Color.Transparent);
            DataVW_PurchaseOrderHeader_Modifier.Font = new Font("BPG Glaho Arial", 8F);
            DataVW_PurchaseOrderHeader_Modifier.Guid = null;
            DataVW_PurchaseOrderHeader_Modifier.Interaction = null;
            DataVW_PurchaseOrderHeader_Modifier.Margins = new StiMargins(0, 0, 0, 0);
            DataVW_PurchaseOrderHeader_Modifier.TextBrush = new StiSolidBrush(Color.Black);
            DataVW_PurchaseOrderHeader_Modifier.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // CheckBox1
            // 
            CheckBox1 = new StiCheckBox();
            CheckBox1.GetChecked += new StiValueEventHandler(CheckBox1__GetChecked);
            CheckBox1.ClientRectangle = new RectangleD(19.4, 0, 0.6, 0.8);
            CheckBox1.ContourColor = Color.Black;
            CheckBox1.GrowToHeight = true;
            CheckBox1.Name = "CheckBox1";
            CheckBox1.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            CheckBox1.Brush = new StiSolidBrush(Color.Transparent);
            CheckBox1.Guid = null;
            CheckBox1.Interaction = null;
            CheckBox1.TextBrush = new StiSolidBrush(Color.Black);
            // 
            // Text6
            // 
            Text6 = new StiText();
            Text6.CanGrow = true;
            Text6.ClientRectangle = new RectangleD(2.6, 0, 2.6, 0.8);
            Text6.GrowToHeight = true;
            Text6.Name = "Text6";
            Text6.GetValue += new StiGetValueEventHandler(Text6__GetValue);
            Text6.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text6.Brush = new StiSolidBrush(Color.Transparent);
            Text6.Font = new Font("BPG Glaho Arial", 8F);
            Text6.Guid = null;
            Text6.Interaction = null;
            Text6.Margins = new StiMargins(0, 0, 0, 0);
            Text6.TextBrush = new StiSolidBrush(Color.Black);
            Text6.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text7
            // 
            Text7 = new StiText();
            Text7.ClientRectangle = new RectangleD(6.8, 0, 3, 0.8);
            Text7.GrowToHeight = true;
            Text7.Name = "Text7";
            Text7.GetValue += new StiGetValueEventHandler(Text7__GetValue);
            Text7.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text7.Brush = new StiSolidBrush(Color.Transparent);
            Text7.Font = new Font("BPG Glaho Arial", 8F);
            Text7.Guid = null;
            Text7.Interaction = null;
            Text7.Margins = new StiMargins(0, 0, 0, 0);
            Text7.TextBrush = new StiSolidBrush(Color.Black);
            Text7.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            DataVW_PurchaseOrderHeader.DataRelationName = null;
            DataVW_PurchaseOrderHeader.Guid = null;
            DataVW_PurchaseOrderHeader.Interaction = null;
            DataVW_PurchaseOrderHeader.MasterComponent = null;
            // 
            // FooterVW_PurchaseOrderHeader
            // 
            FooterVW_PurchaseOrderHeader = new StiFooterBand();
            FooterVW_PurchaseOrderHeader.ClientRectangle = new RectangleD(0, 5.2, 20, 0.8);
            FooterVW_PurchaseOrderHeader.Name = "FooterVW_PurchaseOrderHeader";
            FooterVW_PurchaseOrderHeader.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            FooterVW_PurchaseOrderHeader.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text9
            // 
            Text9 = new StiText();
            Text9.ClientRectangle = new RectangleD(9.8, 0, 1.2, 0.8);
            Text9.HorAlignment = StiTextHorAlignment.Right;
            Text9.Name = "Text9";
            // 
            // Text9_Sum
            // 
            Text9.GetValue += new StiGetValueEventHandler(Text9__GetValue);
            Text9.VertAlignment = StiVertAlignment.Center;
            Text9.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text9.Brush = new StiSolidBrush(Color.Transparent);
            Text9.Font = new Font("BPG Glaho Arial", 8F);
            Text9.Guid = null;
            Text9.Interaction = null;
            Text9.Margins = new StiMargins(0, 0, 0, 0);
            Text9.TextBrush = new StiSolidBrush(Color.Black);
            Text9.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            Text9.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text10
            // 
            Text10 = new StiText();
            Text10.ClientRectangle = new RectangleD(11, 0, 1, 0.8);
            Text10.Guid = "e266d32b669b4a099405ae4538bf7415";
            Text10.HorAlignment = StiTextHorAlignment.Right;
            Text10.Name = "Text10";
            // 
            // Text10_Sum
            // 
            Text10.GetValue += new StiGetValueEventHandler(Text10__GetValue);
            Text10.VertAlignment = StiVertAlignment.Center;
            Text10.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text10.Brush = new StiSolidBrush(Color.Transparent);
            Text10.Font = new Font("BPG Glaho Arial", 8F);
            Text10.Interaction = null;
            Text10.Margins = new StiMargins(0, 0, 0, 0);
            Text10.TextBrush = new StiSolidBrush(Color.Black);
            Text10.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            Text10.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text11
            // 
            Text11 = new StiText();
            Text11.ClientRectangle = new RectangleD(12, 0, 1.4, 0.8);
            Text11.Guid = "677c630a33f8466f9c1b160b9a31da48";
            Text11.HorAlignment = StiTextHorAlignment.Right;
            Text11.Name = "Text11";
            // 
            // Text11_Sum
            // 
            Text11.GetValue += new StiGetValueEventHandler(Text11__GetValue);
            Text11.VertAlignment = StiVertAlignment.Center;
            Text11.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text11.Brush = new StiSolidBrush(Color.Transparent);
            Text11.Font = new Font("BPG Glaho Arial", 8F);
            Text11.Interaction = null;
            Text11.Margins = new StiMargins(0, 0, 0, 0);
            Text11.TextBrush = new StiSolidBrush(Color.Black);
            Text11.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            Text11.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            FooterVW_PurchaseOrderHeader.Guid = null;
            FooterVW_PurchaseOrderHeader.Interaction = null;
            Page1.ExcelSheetValue = null;
            Page1.Interaction = null;
            Page1.Margins = new StiMargins(0.5, 0.5, 0.5, 0.5);
            Page1_Watermark = new StiWatermark();
            Page1_Watermark.Font = new Font("Arial", 100F);
            Page1_Watermark.Image = null;
            Page1_Watermark.TextBrush = new StiSolidBrush(Color.FromArgb(50, 0, 0, 0));
            RptPurchaseOrderHeader_PrinterSettings = new StiPrinterSettings();
            PrinterSettings = RptPurchaseOrderHeader_PrinterSettings;
            Page1.Report = this;
            Page1.Watermark = Page1_Watermark;
            HeaderVW_PurchaseOrderHeader.Page = Page1;
            HeaderVW_PurchaseOrderHeader.Parent = Page1;
            HeaderVW_PurchaseOrderHeader_rowguid.Page = Page1;
            HeaderVW_PurchaseOrderHeader_rowguid.Parent = HeaderVW_PurchaseOrderHeader;
            HeaderVW_PurchaseOrderHeader_PurchaseOrderID.Page = Page1;
            HeaderVW_PurchaseOrderHeader_PurchaseOrderID.Parent = HeaderVW_PurchaseOrderHeader;
            HeaderVW_PurchaseOrderHeader_BranchName.Page = Page1;
            HeaderVW_PurchaseOrderHeader_BranchName.Parent = HeaderVW_PurchaseOrderHeader;
            HeaderVW_PurchaseOrderHeader_OrderDate.Page = Page1;
            HeaderVW_PurchaseOrderHeader_OrderDate.Parent = HeaderVW_PurchaseOrderHeader;
            HeaderVW_PurchaseOrderHeader_SubTotal.Page = Page1;
            HeaderVW_PurchaseOrderHeader_SubTotal.Parent = HeaderVW_PurchaseOrderHeader;
            HeaderVW_PurchaseOrderHeader_TaxAmt.Page = Page1;
            HeaderVW_PurchaseOrderHeader_TaxAmt.Parent = HeaderVW_PurchaseOrderHeader;
            HeaderVW_PurchaseOrderHeader_TotalDue.Page = Page1;
            HeaderVW_PurchaseOrderHeader_TotalDue.Parent = HeaderVW_PurchaseOrderHeader;
            HeaderVW_PurchaseOrderHeader_CurrencyCode.Page = Page1;
            HeaderVW_PurchaseOrderHeader_CurrencyCode.Parent = HeaderVW_PurchaseOrderHeader;
            HeaderVW_PurchaseOrderHeader_OverheadNumber.Page = Page1;
            HeaderVW_PurchaseOrderHeader_OverheadNumber.Parent = HeaderVW_PurchaseOrderHeader;
            HeaderVW_PurchaseOrderHeader_Modifier.Page = Page1;
            HeaderVW_PurchaseOrderHeader_Modifier.Parent = HeaderVW_PurchaseOrderHeader;
            HeaderVW_PurchaseOrderHeader_Status.Page = Page1;
            HeaderVW_PurchaseOrderHeader_Status.Parent = HeaderVW_PurchaseOrderHeader;
            ReportTitleText.Page = Page1;
            ReportTitleText.Parent = HeaderVW_PurchaseOrderHeader;
            Text2.Page = Page1;
            Text2.Parent = HeaderVW_PurchaseOrderHeader;
            Text3.Page = Page1;
            Text3.Parent = HeaderVW_PurchaseOrderHeader;
            Text4.Page = Page1;
            Text4.Parent = HeaderVW_PurchaseOrderHeader;
            Text5.Page = Page1;
            Text5.Parent = HeaderVW_PurchaseOrderHeader;
            Text1.Page = Page1;
            Text1.Parent = HeaderVW_PurchaseOrderHeader;
            Text8.Page = Page1;
            Text8.Parent = HeaderVW_PurchaseOrderHeader;
            DataVW_PurchaseOrderHeader.Page = Page1;
            DataVW_PurchaseOrderHeader.Parent = Page1;
            DataVW_PurchaseOrderHeader_rowguid.Page = Page1;
            DataVW_PurchaseOrderHeader_rowguid.Parent = DataVW_PurchaseOrderHeader;
            DataVW_PurchaseOrderHeader_PurchaseOrderID.Page = Page1;
            DataVW_PurchaseOrderHeader_PurchaseOrderID.Parent = DataVW_PurchaseOrderHeader;
            DataVW_PurchaseOrderHeader_OrderDate.Page = Page1;
            DataVW_PurchaseOrderHeader_OrderDate.Parent = DataVW_PurchaseOrderHeader;
            DataVW_PurchaseOrderHeader_SubTotal.Page = Page1;
            DataVW_PurchaseOrderHeader_SubTotal.Parent = DataVW_PurchaseOrderHeader;
            DataVW_PurchaseOrderHeader_TaxAmt.Page = Page1;
            DataVW_PurchaseOrderHeader_TaxAmt.Parent = DataVW_PurchaseOrderHeader;
            DataVW_PurchaseOrderHeader_TotalDue.Page = Page1;
            DataVW_PurchaseOrderHeader_TotalDue.Parent = DataVW_PurchaseOrderHeader;
            DataVW_PurchaseOrderHeader_CurrencyCode.Page = Page1;
            DataVW_PurchaseOrderHeader_CurrencyCode.Parent = DataVW_PurchaseOrderHeader;
            DataVW_PurchaseOrderHeader_OverheadNumber.Page = Page1;
            DataVW_PurchaseOrderHeader_OverheadNumber.Parent = DataVW_PurchaseOrderHeader;
            DataVW_PurchaseOrderHeader_Modifier.Page = Page1;
            DataVW_PurchaseOrderHeader_Modifier.Parent = DataVW_PurchaseOrderHeader;
            CheckBox1.Page = Page1;
            CheckBox1.Parent = DataVW_PurchaseOrderHeader;
            Text6.Page = Page1;
            Text6.Parent = DataVW_PurchaseOrderHeader;
            Text7.Page = Page1;
            Text7.Parent = DataVW_PurchaseOrderHeader;
            FooterVW_PurchaseOrderHeader.Page = Page1;
            FooterVW_PurchaseOrderHeader.Parent = Page1;
            Text9.Page = Page1;
            Text9.Parent = FooterVW_PurchaseOrderHeader;
            Text10.Page = Page1;
            Text10.Parent = FooterVW_PurchaseOrderHeader;
            Text11.Page = Page1;
            Text11.Parent = FooterVW_PurchaseOrderHeader;
            DataVW_PurchaseOrderHeader.BeginRender += new EventHandler(DataVW_PurchaseOrderHeader__BeginRender);
            DataVW_PurchaseOrderHeader.EndRender += new EventHandler(DataVW_PurchaseOrderHeader__EndRender);
            DataVW_PurchaseOrderHeader.Rendering += new EventHandler(DataVW_PurchaseOrderHeader__Rendering);
            AggregateFunctions = new object[] {
                    Text9_Sum,
                    Text10_Sum,
                    Text11_Sum};
            // 
            // Add to HeaderVW_PurchaseOrderHeader.Components
            // 
            HeaderVW_PurchaseOrderHeader.Components.Clear();
            HeaderVW_PurchaseOrderHeader.Components.AddRange(new StiComponent[] {
                        HeaderVW_PurchaseOrderHeader_rowguid,
                        HeaderVW_PurchaseOrderHeader_PurchaseOrderID,
                        HeaderVW_PurchaseOrderHeader_BranchName,
                        HeaderVW_PurchaseOrderHeader_OrderDate,
                        HeaderVW_PurchaseOrderHeader_SubTotal,
                        HeaderVW_PurchaseOrderHeader_TaxAmt,
                        HeaderVW_PurchaseOrderHeader_TotalDue,
                        HeaderVW_PurchaseOrderHeader_CurrencyCode,
                        HeaderVW_PurchaseOrderHeader_OverheadNumber,
                        HeaderVW_PurchaseOrderHeader_Modifier,
                        HeaderVW_PurchaseOrderHeader_Status,
                        ReportTitleText,
                        Text2,
                        Text3,
                        Text4,
                        Text5,
                        Text1,
                        Text8});
            // 
            // Add to DataVW_PurchaseOrderHeader.Components
            // 
            DataVW_PurchaseOrderHeader.Components.Clear();
            DataVW_PurchaseOrderHeader.Components.AddRange(new StiComponent[] {
                        DataVW_PurchaseOrderHeader_rowguid,
                        DataVW_PurchaseOrderHeader_PurchaseOrderID,
                        DataVW_PurchaseOrderHeader_OrderDate,
                        DataVW_PurchaseOrderHeader_SubTotal,
                        DataVW_PurchaseOrderHeader_TaxAmt,
                        DataVW_PurchaseOrderHeader_TotalDue,
                        DataVW_PurchaseOrderHeader_CurrencyCode,
                        DataVW_PurchaseOrderHeader_OverheadNumber,
                        DataVW_PurchaseOrderHeader_Modifier,
                        CheckBox1,
                        Text6,
                        Text7});
            // 
            // Add to FooterVW_PurchaseOrderHeader.Components
            // 
            FooterVW_PurchaseOrderHeader.Components.Clear();
            FooterVW_PurchaseOrderHeader.Components.AddRange(new StiComponent[] {
                        Text9,
                        Text10,
                        Text11});
            // 
            // Add to Page1.Components
            // 
            Page1.Components.Clear();
            Page1.Components.AddRange(new StiComponent[] {
                        HeaderVW_PurchaseOrderHeader,
                        DataVW_PurchaseOrderHeader,
                        FooterVW_PurchaseOrderHeader});
            // 
            // Add to Pages
            // 
            Pages.Clear();
            Pages.AddRange(new[] {
                        Page1});
            VW_PurchaseOrderHeader.Columns.AddRange(new[] {
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
                        new StiDataColumn("CurrencyRateID", "CurrencyRateID", "CurrencyRateID", typeof(int)),
                        new StiDataColumn("PaymentMethodID", "PaymentMethodID", "PaymentMethodID", typeof(int)),
                        new StiDataColumn("PaymentMethodName", "PaymentMethodName", "PaymentMethodName", typeof(string)),
                        new StiDataColumn("RevisionNumber", "RevisionNumber", "RevisionNumber", typeof(byte)),
                        new StiDataColumn("Status", "Status", "Status", typeof(byte)),
                        new StiDataColumn("ModifiedUserID", "ModifiedUserID", "ModifiedUserID", typeof(int)),
                        new StiDataColumn("Modifier", "Modifier", "Modifier", typeof(string)),
                        new StiDataColumn("ModifiedDate", "ModifiedDate", "ModifiedDate", typeof(DateTime)),
                        new StiDataColumn("ApproverUserID", "ApproverUserID", "ApproverUserID", typeof(int)),
                        new StiDataColumn("Approver", "Approver", "Approver", typeof(string)),
                        new StiDataColumn("rowguid", "rowguid", "rowguid", typeof(Guid))});
            DataSources.Add(VW_PurchaseOrderHeader);
            T_PurchaseList.Columns.AddRange(new[] {
                        new StiDataColumn("Date1", "Date1", "Date1", typeof(DateTime)),
                        new StiDataColumn("Date2", "Date2", "Date2", typeof(DateTime))});
            DataSources.Add(T_PurchaseList);
        }

        #region DataSource VW_PurchaseOrderHeader
        public class VW_PurchaseOrderHeaderDataSource : StiDataTableSource
        {

            public VW_PurchaseOrderHeaderDataSource() :
                base("DS_Purchasing.VW_PurchaseOrderHeader", "VW_PurchaseOrderHeader")
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

            public virtual Guid rowguid
            {
                get
                {
                    return ((Guid)(ChangeType(this["rowguid"], typeof(Guid), true)));
                }
            }
        }
        #endregion DataSource VW_PurchaseOrderHeader

        #region DataSource T_PurchaseList
        public class T_PurchaseListDataSource : StiDataTableSource
        {

            public T_PurchaseListDataSource() :
                base("DS_Purchasing.T_PurchaseList", "T_PurchaseList")
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
        #endregion DataSource T_PurchaseList
        #endregion StiReport Designer generated code - do not modify
    }
}
