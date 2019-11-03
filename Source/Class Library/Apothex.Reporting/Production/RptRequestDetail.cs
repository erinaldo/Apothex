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

    public class RptRequestDetail : StiReport
    {

        public RptRequestDetail()
        {
            InitializeComponent();
        }
        #region StiReport Designer generated code - do not modify
        public StiDataRelation ParentSP_GetRequestHeader;
        public StiPage Page1;
        public StiDataBand DataSP_GetRequestHeader;
        public StiText Text2;
        public StiHeaderBand HeaderSP_GetRequestDetail;
        public StiText HeaderSP_GetRequestDetail_OrdinalNumber;
        public StiText HeaderSP_GetRequestDetail_MedicamentName;
        public StiText HeaderSP_GetRequestDetail_RequestQty;
        public StiText HeaderSP_GetRequestDetail_CountryName1;
        public StiText HeaderSP_GetRequestDetail_CountryName2;
        public StiText HeaderSP_GetRequestDetail_BrandName1;
        public StiText HeaderSP_GetRequestDetail_BrandName2;
        public StiDataBand DataSP_GetRequestDetail;
        public StiText DataSP_GetRequestDetail_MedicamentName;
        public StiText DataSP_GetRequestDetail_OrdinalNumber;
        public StiText DataSP_GetRequestDetail_RequestQty;
        public StiText DataSP_GetRequestDetail_CountryName1;
        public StiText DataSP_GetRequestDetail_CountryName2;
        public StiText DataSP_GetRequestDetail_BrandName1;
        public StiText DataSP_GetRequestDetail_BrandName2;
        public StiWatermark Page1_Watermark;
        public StiPrinterSettings RptRequestDetail_PrinterSettings;
        public SP_GetRequestDetailDataSource SP_GetRequestDetail;
        public SP_GetRequestHeaderDataSource SP_GetRequestHeader;

        public void Text2__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "შეკვეთის №" + ToString(sender, SP_GetRequestHeader.RequestID, true) + "   თარიღი: " + ToString(sender, Format("{0:yyyy.MM.dd}", SP_GetRequestHeader.RequestDate), true) + "   ფილიალი: " + ToString(sender, SP_GetRequestHeader.BranchName, true);
        }

        public void HeaderSP_GetRequestDetail_OrdinalNumber__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "№";
        }

        public void HeaderSP_GetRequestDetail_MedicamentName__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "პროდუქცია";
        }

        public void HeaderSP_GetRequestDetail_RequestQty__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "რაოდ.";
        }

        public void HeaderSP_GetRequestDetail_CountryName1__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ქვეყანა №1";
        }

        public void HeaderSP_GetRequestDetail_CountryName2__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ქვეყანა №2";
        }

        public void HeaderSP_GetRequestDetail_BrandName1__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ბრენდი";
        }

        public void HeaderSP_GetRequestDetail_BrandName2__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "კომენტარი";
        }

        public void DataSP_GetRequestDetail_MedicamentName__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetRequestDetail.MedicamentName, true);
        }

        public void DataSP_GetRequestDetail_OrdinalNumber__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Line, true);
        }

        public void DataSP_GetRequestDetail_RequestQty__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = DataSP_GetRequestDetail_RequestQty.TextFormat.Format(CheckExcelValue(sender, SP_GetRequestDetail.RequestQty));
        }

        public void DataSP_GetRequestDetail_CountryName1__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetRequestDetail.CountryName1, true);
        }

        public void DataSP_GetRequestDetail_CountryName2__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetRequestDetail.CountryName2, true);
        }

        public void DataSP_GetRequestDetail_BrandName1__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetRequestDetail.BrandName, true);
        }

        private void InitializeComponent()
        {
            SP_GetRequestHeader = new SP_GetRequestHeaderDataSource();
            SP_GetRequestDetail = new SP_GetRequestDetailDataSource();
            ParentSP_GetRequestHeader = new StiDataRelation("SP_GetRequestHeader_SP_GetRequestDetail", "SP_GetRequestHeader", "SP_GetRequestHeader", SP_GetRequestHeader, SP_GetRequestDetail, new[] {
                        "RequestID"}, new[] {
                        "RequestID"});
            NeedsCompiling = false;
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
            ReportAlias = "RptRequestDetail";
            ReportAuthor = "Programmer.GE";
            // 
            // ReportChanged
            // 
            ReportChanged = new DateTime(2010, 4, 30, 19, 58, 27, 845);
            // 
            // ReportCreated
            // 
            ReportCreated = new DateTime(2010, 3, 4, 16, 2, 4, 0);
            ReportDescription = "პროდუქციის შეკვეთა";
            ReportFile = "D:\\User\\Documents\\Projects\\Apothex\\Source\\Class Library\\Apothex.Reporting\\Product" +
"ion\\RptRequestDetail.mrt";
            ReportGuid = "39889ce012f240ecbc7962a86ff663a7";
            ReportName = "RptRequestDetail";
            ReportUnit = StiReportUnitType.Centimeters;
            ScriptLanguage = StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            Page1 = new StiPage();
            Page1.Guid = "5d26ae79894e4dcebbc2212ba7686670";
            Page1.Name = "Page1";
            Page1.PageHeight = 29.7;
            Page1.PageWidth = 21;
            Page1.PaperSize = PaperKind.A4;
            Page1.Border = new StiBorder(StiBorderSides.None, Color.Black, 2, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Page1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // DataSP_GetRequestHeader
            // 
            DataSP_GetRequestHeader = new StiDataBand();
            DataSP_GetRequestHeader.ClientRectangle = new RectangleD(0, 0.4, 19, 0.6);
            DataSP_GetRequestHeader.DataSourceName = "SP_GetRequestHeader";
            DataSP_GetRequestHeader.Name = "DataSP_GetRequestHeader";
            DataSP_GetRequestHeader.Sort = new String[0];
            DataSP_GetRequestHeader.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetRequestHeader.Brush = new StiSolidBrush(Color.Transparent);
            DataSP_GetRequestHeader.BusinessObjectGuid = null;
            // 
            // Text2
            // 
            Text2 = new StiText();
            Text2.ClientRectangle = new RectangleD(0, 0, 19, 0.6);
            Text2.HorAlignment = StiTextHorAlignment.Center;
            Text2.Name = "Text2";
            Text2.GetValue += new StiGetValueEventHandler(Text2__GetValue);
            Text2.VertAlignment = StiVertAlignment.Center;
            Text2.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text2.Brush = new StiSolidBrush(Color.Transparent);
            Text2.Font = new Font("BPG Glaho Arial", 10F);
            Text2.Guid = null;
            Text2.Interaction = null;
            Text2.Margins = new StiMargins(0, 0, 0, 0);
            Text2.TextBrush = new StiSolidBrush(Color.Black);
            Text2.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            DataSP_GetRequestHeader.Guid = null;
            DataSP_GetRequestHeader.Interaction = null;
            DataSP_GetRequestHeader.MasterComponent = null;
            // 
            // HeaderSP_GetRequestDetail
            // 
            HeaderSP_GetRequestDetail = new StiHeaderBand();
            HeaderSP_GetRequestDetail.ClientRectangle = new RectangleD(0, 1.8, 19, 0.6);
            HeaderSP_GetRequestDetail.Name = "HeaderSP_GetRequestDetail";
            HeaderSP_GetRequestDetail.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderSP_GetRequestDetail.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // HeaderSP_GetRequestDetail_OrdinalNumber
            // 
            HeaderSP_GetRequestDetail_OrdinalNumber = new StiText();
            HeaderSP_GetRequestDetail_OrdinalNumber.ClientRectangle = new RectangleD(0, 0, 0.8, 0.6);
            HeaderSP_GetRequestDetail_OrdinalNumber.HorAlignment = StiTextHorAlignment.Center;
            HeaderSP_GetRequestDetail_OrdinalNumber.Name = "HeaderSP_GetRequestDetail_OrdinalNumber";
            HeaderSP_GetRequestDetail_OrdinalNumber.GetValue += new StiGetValueEventHandler(HeaderSP_GetRequestDetail_OrdinalNumber__GetValue);
            HeaderSP_GetRequestDetail_OrdinalNumber.VertAlignment = StiVertAlignment.Center;
            HeaderSP_GetRequestDetail_OrdinalNumber.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderSP_GetRequestDetail_OrdinalNumber.Brush = new StiSolidBrush(Color.Transparent);
            HeaderSP_GetRequestDetail_OrdinalNumber.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderSP_GetRequestDetail_OrdinalNumber.Guid = null;
            HeaderSP_GetRequestDetail_OrdinalNumber.Interaction = null;
            HeaderSP_GetRequestDetail_OrdinalNumber.Margins = new StiMargins(0, 0, 0, 0);
            HeaderSP_GetRequestDetail_OrdinalNumber.TextBrush = new StiSolidBrush(Color.Black);
            HeaderSP_GetRequestDetail_OrdinalNumber.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderSP_GetRequestDetail_MedicamentName
            // 
            HeaderSP_GetRequestDetail_MedicamentName = new StiText();
            HeaderSP_GetRequestDetail_MedicamentName.ClientRectangle = new RectangleD(0.8, 0, 6, 0.6);
            HeaderSP_GetRequestDetail_MedicamentName.HorAlignment = StiTextHorAlignment.Center;
            HeaderSP_GetRequestDetail_MedicamentName.Name = "HeaderSP_GetRequestDetail_MedicamentName";
            HeaderSP_GetRequestDetail_MedicamentName.GetValue += new StiGetValueEventHandler(HeaderSP_GetRequestDetail_MedicamentName__GetValue);
            HeaderSP_GetRequestDetail_MedicamentName.VertAlignment = StiVertAlignment.Center;
            HeaderSP_GetRequestDetail_MedicamentName.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderSP_GetRequestDetail_MedicamentName.Brush = new StiSolidBrush(Color.Transparent);
            HeaderSP_GetRequestDetail_MedicamentName.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderSP_GetRequestDetail_MedicamentName.Guid = null;
            HeaderSP_GetRequestDetail_MedicamentName.Interaction = null;
            HeaderSP_GetRequestDetail_MedicamentName.Margins = new StiMargins(0, 0, 0, 0);
            HeaderSP_GetRequestDetail_MedicamentName.TextBrush = new StiSolidBrush(Color.Black);
            HeaderSP_GetRequestDetail_MedicamentName.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderSP_GetRequestDetail_RequestQty
            // 
            HeaderSP_GetRequestDetail_RequestQty = new StiText();
            HeaderSP_GetRequestDetail_RequestQty.ClientRectangle = new RectangleD(6.8, 0, 1.4, 0.6);
            HeaderSP_GetRequestDetail_RequestQty.HorAlignment = StiTextHorAlignment.Center;
            HeaderSP_GetRequestDetail_RequestQty.Name = "HeaderSP_GetRequestDetail_RequestQty";
            HeaderSP_GetRequestDetail_RequestQty.GetValue += new StiGetValueEventHandler(HeaderSP_GetRequestDetail_RequestQty__GetValue);
            HeaderSP_GetRequestDetail_RequestQty.VertAlignment = StiVertAlignment.Center;
            HeaderSP_GetRequestDetail_RequestQty.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderSP_GetRequestDetail_RequestQty.Brush = new StiSolidBrush(Color.Transparent);
            HeaderSP_GetRequestDetail_RequestQty.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderSP_GetRequestDetail_RequestQty.Guid = null;
            HeaderSP_GetRequestDetail_RequestQty.Interaction = null;
            HeaderSP_GetRequestDetail_RequestQty.Margins = new StiMargins(0, 0, 0, 0);
            HeaderSP_GetRequestDetail_RequestQty.TextBrush = new StiSolidBrush(Color.Black);
            HeaderSP_GetRequestDetail_RequestQty.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderSP_GetRequestDetail_CountryName1
            // 
            HeaderSP_GetRequestDetail_CountryName1 = new StiText();
            HeaderSP_GetRequestDetail_CountryName1.ClientRectangle = new RectangleD(8.2, 0, 2.8, 0.6);
            HeaderSP_GetRequestDetail_CountryName1.HorAlignment = StiTextHorAlignment.Center;
            HeaderSP_GetRequestDetail_CountryName1.Name = "HeaderSP_GetRequestDetail_CountryName1";
            HeaderSP_GetRequestDetail_CountryName1.GetValue += new StiGetValueEventHandler(HeaderSP_GetRequestDetail_CountryName1__GetValue);
            HeaderSP_GetRequestDetail_CountryName1.VertAlignment = StiVertAlignment.Center;
            HeaderSP_GetRequestDetail_CountryName1.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderSP_GetRequestDetail_CountryName1.Brush = new StiSolidBrush(Color.Transparent);
            HeaderSP_GetRequestDetail_CountryName1.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderSP_GetRequestDetail_CountryName1.Guid = null;
            HeaderSP_GetRequestDetail_CountryName1.Interaction = null;
            HeaderSP_GetRequestDetail_CountryName1.Margins = new StiMargins(0, 0, 0, 0);
            HeaderSP_GetRequestDetail_CountryName1.TextBrush = new StiSolidBrush(Color.Black);
            HeaderSP_GetRequestDetail_CountryName1.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderSP_GetRequestDetail_CountryName2
            // 
            HeaderSP_GetRequestDetail_CountryName2 = new StiText();
            HeaderSP_GetRequestDetail_CountryName2.ClientRectangle = new RectangleD(11, 0, 2.8, 0.6);
            HeaderSP_GetRequestDetail_CountryName2.HorAlignment = StiTextHorAlignment.Center;
            HeaderSP_GetRequestDetail_CountryName2.Name = "HeaderSP_GetRequestDetail_CountryName2";
            HeaderSP_GetRequestDetail_CountryName2.GetValue += new StiGetValueEventHandler(HeaderSP_GetRequestDetail_CountryName2__GetValue);
            HeaderSP_GetRequestDetail_CountryName2.VertAlignment = StiVertAlignment.Center;
            HeaderSP_GetRequestDetail_CountryName2.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderSP_GetRequestDetail_CountryName2.Brush = new StiSolidBrush(Color.Transparent);
            HeaderSP_GetRequestDetail_CountryName2.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderSP_GetRequestDetail_CountryName2.Guid = null;
            HeaderSP_GetRequestDetail_CountryName2.Interaction = null;
            HeaderSP_GetRequestDetail_CountryName2.Margins = new StiMargins(0, 0, 0, 0);
            HeaderSP_GetRequestDetail_CountryName2.TextBrush = new StiSolidBrush(Color.Black);
            HeaderSP_GetRequestDetail_CountryName2.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderSP_GetRequestDetail_BrandName1
            // 
            HeaderSP_GetRequestDetail_BrandName1 = new StiText();
            HeaderSP_GetRequestDetail_BrandName1.ClientRectangle = new RectangleD(13.8, 0, 2.6, 0.6);
            HeaderSP_GetRequestDetail_BrandName1.HorAlignment = StiTextHorAlignment.Center;
            HeaderSP_GetRequestDetail_BrandName1.Name = "HeaderSP_GetRequestDetail_BrandName1";
            HeaderSP_GetRequestDetail_BrandName1.GetValue += new StiGetValueEventHandler(HeaderSP_GetRequestDetail_BrandName1__GetValue);
            HeaderSP_GetRequestDetail_BrandName1.VertAlignment = StiVertAlignment.Center;
            HeaderSP_GetRequestDetail_BrandName1.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderSP_GetRequestDetail_BrandName1.Brush = new StiSolidBrush(Color.Transparent);
            HeaderSP_GetRequestDetail_BrandName1.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderSP_GetRequestDetail_BrandName1.Guid = null;
            HeaderSP_GetRequestDetail_BrandName1.Interaction = null;
            HeaderSP_GetRequestDetail_BrandName1.Margins = new StiMargins(0, 0, 0, 0);
            HeaderSP_GetRequestDetail_BrandName1.TextBrush = new StiSolidBrush(Color.Black);
            HeaderSP_GetRequestDetail_BrandName1.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderSP_GetRequestDetail_BrandName2
            // 
            HeaderSP_GetRequestDetail_BrandName2 = new StiText();
            HeaderSP_GetRequestDetail_BrandName2.ClientRectangle = new RectangleD(16.4, 0, 2.6, 0.6);
            HeaderSP_GetRequestDetail_BrandName2.HorAlignment = StiTextHorAlignment.Center;
            HeaderSP_GetRequestDetail_BrandName2.Name = "HeaderSP_GetRequestDetail_BrandName2";
            HeaderSP_GetRequestDetail_BrandName2.GetValue += new StiGetValueEventHandler(HeaderSP_GetRequestDetail_BrandName2__GetValue);
            HeaderSP_GetRequestDetail_BrandName2.VertAlignment = StiVertAlignment.Center;
            HeaderSP_GetRequestDetail_BrandName2.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderSP_GetRequestDetail_BrandName2.Brush = new StiSolidBrush(Color.Transparent);
            HeaderSP_GetRequestDetail_BrandName2.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderSP_GetRequestDetail_BrandName2.Guid = null;
            HeaderSP_GetRequestDetail_BrandName2.Interaction = null;
            HeaderSP_GetRequestDetail_BrandName2.Margins = new StiMargins(0, 0, 0, 0);
            HeaderSP_GetRequestDetail_BrandName2.TextBrush = new StiSolidBrush(Color.Black);
            HeaderSP_GetRequestDetail_BrandName2.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            HeaderSP_GetRequestDetail.Guid = null;
            HeaderSP_GetRequestDetail.Interaction = null;
            // 
            // DataSP_GetRequestDetail
            // 
            DataSP_GetRequestDetail = new StiDataBand();
            DataSP_GetRequestDetail.ClientRectangle = new RectangleD(0, 3.2, 19, 0.6);
            DataSP_GetRequestDetail.DataRelationName = "SP_GetRequestHeader_SP_GetRequestDetail";
            DataSP_GetRequestDetail.DataSourceName = "SP_GetRequestDetail";
            DataSP_GetRequestDetail.Name = "DataSP_GetRequestDetail";
            DataSP_GetRequestDetail.Sort = new[] {
                    "ASC",
                    "OrdinalNumber"};
            DataSP_GetRequestDetail.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetRequestDetail.Brush = new StiSolidBrush(Color.Transparent);
            DataSP_GetRequestDetail.BusinessObjectGuid = null;
            // 
            // DataSP_GetRequestDetail_MedicamentName
            // 
            DataSP_GetRequestDetail_MedicamentName = new StiText();
            DataSP_GetRequestDetail_MedicamentName.CanGrow = true;
            DataSP_GetRequestDetail_MedicamentName.ClientRectangle = new RectangleD(0.8, 0, 6, 0.6);
            DataSP_GetRequestDetail_MedicamentName.GrowToHeight = true;
            DataSP_GetRequestDetail_MedicamentName.Name = "DataSP_GetRequestDetail_MedicamentName";
            DataSP_GetRequestDetail_MedicamentName.GetValue += new StiGetValueEventHandler(DataSP_GetRequestDetail_MedicamentName__GetValue);
            DataSP_GetRequestDetail_MedicamentName.VertAlignment = StiVertAlignment.Center;
            DataSP_GetRequestDetail_MedicamentName.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetRequestDetail_MedicamentName.Brush = new StiSolidBrush(Color.Transparent);
            DataSP_GetRequestDetail_MedicamentName.Font = new Font("BPG Glaho Arial", 8F);
            DataSP_GetRequestDetail_MedicamentName.Guid = null;
            DataSP_GetRequestDetail_MedicamentName.Interaction = null;
            DataSP_GetRequestDetail_MedicamentName.Margins = new StiMargins(0, 0, 0, 0);
            DataSP_GetRequestDetail_MedicamentName.TextBrush = new StiSolidBrush(Color.Black);
            DataSP_GetRequestDetail_MedicamentName.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataSP_GetRequestDetail_OrdinalNumber
            // 
            DataSP_GetRequestDetail_OrdinalNumber = new StiText();
            DataSP_GetRequestDetail_OrdinalNumber.CanGrow = true;
            DataSP_GetRequestDetail_OrdinalNumber.ClientRectangle = new RectangleD(0, 0, 0.8, 0.6);
            DataSP_GetRequestDetail_OrdinalNumber.GrowToHeight = true;
            DataSP_GetRequestDetail_OrdinalNumber.Name = "DataSP_GetRequestDetail_OrdinalNumber";
            DataSP_GetRequestDetail_OrdinalNumber.GetValue += new StiGetValueEventHandler(DataSP_GetRequestDetail_OrdinalNumber__GetValue);
            DataSP_GetRequestDetail_OrdinalNumber.VertAlignment = StiVertAlignment.Center;
            DataSP_GetRequestDetail_OrdinalNumber.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetRequestDetail_OrdinalNumber.Brush = new StiSolidBrush(Color.Transparent);
            DataSP_GetRequestDetail_OrdinalNumber.Font = new Font("BPG Glaho Arial", 8F);
            DataSP_GetRequestDetail_OrdinalNumber.Guid = null;
            DataSP_GetRequestDetail_OrdinalNumber.Interaction = null;
            DataSP_GetRequestDetail_OrdinalNumber.Margins = new StiMargins(0, 0, 0, 0);
            DataSP_GetRequestDetail_OrdinalNumber.TextBrush = new StiSolidBrush(Color.Black);
            DataSP_GetRequestDetail_OrdinalNumber.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataSP_GetRequestDetail_RequestQty
            // 
            DataSP_GetRequestDetail_RequestQty = new StiText();
            DataSP_GetRequestDetail_RequestQty.CanGrow = true;
            DataSP_GetRequestDetail_RequestQty.ClientRectangle = new RectangleD(6.8, 0, 1.4, 0.6);
            DataSP_GetRequestDetail_RequestQty.GrowToHeight = true;
            DataSP_GetRequestDetail_RequestQty.HorAlignment = StiTextHorAlignment.Right;
            DataSP_GetRequestDetail_RequestQty.Name = "DataSP_GetRequestDetail_RequestQty";
            DataSP_GetRequestDetail_RequestQty.GetValue += new StiGetValueEventHandler(DataSP_GetRequestDetail_RequestQty__GetValue);
            DataSP_GetRequestDetail_RequestQty.VertAlignment = StiVertAlignment.Center;
            DataSP_GetRequestDetail_RequestQty.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetRequestDetail_RequestQty.Brush = new StiSolidBrush(Color.Transparent);
            DataSP_GetRequestDetail_RequestQty.Font = new Font("BPG Glaho Arial", 8F);
            DataSP_GetRequestDetail_RequestQty.Guid = null;
            DataSP_GetRequestDetail_RequestQty.Interaction = null;
            DataSP_GetRequestDetail_RequestQty.Margins = new StiMargins(0, 0, 0, 0);
            DataSP_GetRequestDetail_RequestQty.TextBrush = new StiSolidBrush(Color.Black);
            DataSP_GetRequestDetail_RequestQty.TextFormat = new StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            DataSP_GetRequestDetail_RequestQty.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataSP_GetRequestDetail_CountryName1
            // 
            DataSP_GetRequestDetail_CountryName1 = new StiText();
            DataSP_GetRequestDetail_CountryName1.CanGrow = true;
            DataSP_GetRequestDetail_CountryName1.ClientRectangle = new RectangleD(8.2, 0, 2.8, 0.6);
            DataSP_GetRequestDetail_CountryName1.GrowToHeight = true;
            DataSP_GetRequestDetail_CountryName1.Name = "DataSP_GetRequestDetail_CountryName1";
            DataSP_GetRequestDetail_CountryName1.GetValue += new StiGetValueEventHandler(DataSP_GetRequestDetail_CountryName1__GetValue);
            DataSP_GetRequestDetail_CountryName1.VertAlignment = StiVertAlignment.Center;
            DataSP_GetRequestDetail_CountryName1.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetRequestDetail_CountryName1.Brush = new StiSolidBrush(Color.Transparent);
            DataSP_GetRequestDetail_CountryName1.Font = new Font("BPG Glaho Arial", 8F);
            DataSP_GetRequestDetail_CountryName1.Guid = null;
            DataSP_GetRequestDetail_CountryName1.Interaction = null;
            DataSP_GetRequestDetail_CountryName1.Margins = new StiMargins(0, 0, 0, 0);
            DataSP_GetRequestDetail_CountryName1.TextBrush = new StiSolidBrush(Color.Black);
            DataSP_GetRequestDetail_CountryName1.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataSP_GetRequestDetail_CountryName2
            // 
            DataSP_GetRequestDetail_CountryName2 = new StiText();
            DataSP_GetRequestDetail_CountryName2.CanGrow = true;
            DataSP_GetRequestDetail_CountryName2.ClientRectangle = new RectangleD(11, 0, 2.8, 0.6);
            DataSP_GetRequestDetail_CountryName2.GrowToHeight = true;
            DataSP_GetRequestDetail_CountryName2.Name = "DataSP_GetRequestDetail_CountryName2";
            DataSP_GetRequestDetail_CountryName2.GetValue += new StiGetValueEventHandler(DataSP_GetRequestDetail_CountryName2__GetValue);
            DataSP_GetRequestDetail_CountryName2.VertAlignment = StiVertAlignment.Center;
            DataSP_GetRequestDetail_CountryName2.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetRequestDetail_CountryName2.Brush = new StiSolidBrush(Color.Transparent);
            DataSP_GetRequestDetail_CountryName2.Font = new Font("BPG Glaho Arial", 8F);
            DataSP_GetRequestDetail_CountryName2.Guid = null;
            DataSP_GetRequestDetail_CountryName2.Interaction = null;
            DataSP_GetRequestDetail_CountryName2.Margins = new StiMargins(0, 0, 0, 0);
            DataSP_GetRequestDetail_CountryName2.TextBrush = new StiSolidBrush(Color.Black);
            DataSP_GetRequestDetail_CountryName2.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataSP_GetRequestDetail_BrandName1
            // 
            DataSP_GetRequestDetail_BrandName1 = new StiText();
            DataSP_GetRequestDetail_BrandName1.CanGrow = true;
            DataSP_GetRequestDetail_BrandName1.ClientRectangle = new RectangleD(13.8, 0, 2.6, 0.6);
            DataSP_GetRequestDetail_BrandName1.Name = "DataSP_GetRequestDetail_BrandName1";
            DataSP_GetRequestDetail_BrandName1.GetValue += new StiGetValueEventHandler(DataSP_GetRequestDetail_BrandName1__GetValue);
            DataSP_GetRequestDetail_BrandName1.VertAlignment = StiVertAlignment.Center;
            DataSP_GetRequestDetail_BrandName1.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetRequestDetail_BrandName1.Brush = new StiSolidBrush(Color.Transparent);
            DataSP_GetRequestDetail_BrandName1.Font = new Font("BPG Glaho Arial", 8F);
            DataSP_GetRequestDetail_BrandName1.Guid = null;
            DataSP_GetRequestDetail_BrandName1.Interaction = null;
            DataSP_GetRequestDetail_BrandName1.Margins = new StiMargins(0, 0, 0, 0);
            DataSP_GetRequestDetail_BrandName1.TextBrush = new StiSolidBrush(Color.Black);
            DataSP_GetRequestDetail_BrandName1.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataSP_GetRequestDetail_BrandName2
            // 
            DataSP_GetRequestDetail_BrandName2 = new StiText();
            DataSP_GetRequestDetail_BrandName2.CanGrow = true;
            DataSP_GetRequestDetail_BrandName2.ClientRectangle = new RectangleD(16.4, 0, 2.6, 0.6);
            DataSP_GetRequestDetail_BrandName2.GrowToHeight = true;
            DataSP_GetRequestDetail_BrandName2.Name = "DataSP_GetRequestDetail_BrandName2";
            DataSP_GetRequestDetail_BrandName2.VertAlignment = StiVertAlignment.Center;
            DataSP_GetRequestDetail_BrandName2.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetRequestDetail_BrandName2.Brush = new StiSolidBrush(Color.Transparent);
            DataSP_GetRequestDetail_BrandName2.Font = new Font("BPG Glaho Arial", 8F);
            DataSP_GetRequestDetail_BrandName2.Guid = null;
            DataSP_GetRequestDetail_BrandName2.Interaction = null;
            DataSP_GetRequestDetail_BrandName2.Margins = new StiMargins(0, 0, 0, 0);
            DataSP_GetRequestDetail_BrandName2.TextBrush = new StiSolidBrush(Color.Black);
            DataSP_GetRequestDetail_BrandName2.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            DataSP_GetRequestDetail.Guid = null;
            DataSP_GetRequestDetail.Interaction = null;
            Page1.ExcelSheetValue = null;
            Page1.Interaction = null;
            Page1.Margins = new StiMargins(1, 1, 1, 1);
            Page1_Watermark = new StiWatermark();
            Page1_Watermark.Font = new Font("Arial", 100F);
            Page1_Watermark.Image = null;
            Page1_Watermark.TextBrush = new StiSolidBrush(Color.FromArgb(50, 0, 0, 0));
            RptRequestDetail_PrinterSettings = new StiPrinterSettings();
            PrinterSettings = RptRequestDetail_PrinterSettings;
            Page1.Report = this;
            Page1.Watermark = Page1_Watermark;
            DataSP_GetRequestHeader.Page = Page1;
            DataSP_GetRequestHeader.Parent = Page1;
            Text2.Page = Page1;
            Text2.Parent = DataSP_GetRequestHeader;
            HeaderSP_GetRequestDetail.Page = Page1;
            HeaderSP_GetRequestDetail.Parent = Page1;
            HeaderSP_GetRequestDetail_OrdinalNumber.Page = Page1;
            HeaderSP_GetRequestDetail_OrdinalNumber.Parent = HeaderSP_GetRequestDetail;
            HeaderSP_GetRequestDetail_MedicamentName.Page = Page1;
            HeaderSP_GetRequestDetail_MedicamentName.Parent = HeaderSP_GetRequestDetail;
            HeaderSP_GetRequestDetail_RequestQty.Page = Page1;
            HeaderSP_GetRequestDetail_RequestQty.Parent = HeaderSP_GetRequestDetail;
            HeaderSP_GetRequestDetail_CountryName1.Page = Page1;
            HeaderSP_GetRequestDetail_CountryName1.Parent = HeaderSP_GetRequestDetail;
            HeaderSP_GetRequestDetail_CountryName2.Page = Page1;
            HeaderSP_GetRequestDetail_CountryName2.Parent = HeaderSP_GetRequestDetail;
            HeaderSP_GetRequestDetail_BrandName1.Page = Page1;
            HeaderSP_GetRequestDetail_BrandName1.Parent = HeaderSP_GetRequestDetail;
            HeaderSP_GetRequestDetail_BrandName2.Page = Page1;
            HeaderSP_GetRequestDetail_BrandName2.Parent = HeaderSP_GetRequestDetail;
            DataSP_GetRequestDetail.MasterComponent = DataSP_GetRequestHeader;
            DataSP_GetRequestDetail.Page = Page1;
            DataSP_GetRequestDetail.Parent = Page1;
            DataSP_GetRequestDetail_MedicamentName.Page = Page1;
            DataSP_GetRequestDetail_MedicamentName.Parent = DataSP_GetRequestDetail;
            DataSP_GetRequestDetail_OrdinalNumber.Page = Page1;
            DataSP_GetRequestDetail_OrdinalNumber.Parent = DataSP_GetRequestDetail;
            DataSP_GetRequestDetail_RequestQty.Page = Page1;
            DataSP_GetRequestDetail_RequestQty.Parent = DataSP_GetRequestDetail;
            DataSP_GetRequestDetail_CountryName1.Page = Page1;
            DataSP_GetRequestDetail_CountryName1.Parent = DataSP_GetRequestDetail;
            DataSP_GetRequestDetail_CountryName2.Page = Page1;
            DataSP_GetRequestDetail_CountryName2.Parent = DataSP_GetRequestDetail;
            DataSP_GetRequestDetail_BrandName1.Page = Page1;
            DataSP_GetRequestDetail_BrandName1.Parent = DataSP_GetRequestDetail;
            DataSP_GetRequestDetail_BrandName2.Page = Page1;
            DataSP_GetRequestDetail_BrandName2.Parent = DataSP_GetRequestDetail;
            // 
            // Add to DataSP_GetRequestHeader.Components
            // 
            DataSP_GetRequestHeader.Components.Clear();
            DataSP_GetRequestHeader.Components.AddRange(new StiComponent[] {
                        Text2});
            // 
            // Add to HeaderSP_GetRequestDetail.Components
            // 
            HeaderSP_GetRequestDetail.Components.Clear();
            HeaderSP_GetRequestDetail.Components.AddRange(new StiComponent[] {
                        HeaderSP_GetRequestDetail_OrdinalNumber,
                        HeaderSP_GetRequestDetail_MedicamentName,
                        HeaderSP_GetRequestDetail_RequestQty,
                        HeaderSP_GetRequestDetail_CountryName1,
                        HeaderSP_GetRequestDetail_CountryName2,
                        HeaderSP_GetRequestDetail_BrandName1,
                        HeaderSP_GetRequestDetail_BrandName2});
            // 
            // Add to DataSP_GetRequestDetail.Components
            // 
            DataSP_GetRequestDetail.Components.Clear();
            DataSP_GetRequestDetail.Components.AddRange(new StiComponent[] {
                        DataSP_GetRequestDetail_MedicamentName,
                        DataSP_GetRequestDetail_OrdinalNumber,
                        DataSP_GetRequestDetail_RequestQty,
                        DataSP_GetRequestDetail_CountryName1,
                        DataSP_GetRequestDetail_CountryName2,
                        DataSP_GetRequestDetail_BrandName1,
                        DataSP_GetRequestDetail_BrandName2});
            // 
            // Add to Page1.Components
            // 
            Page1.Components.Clear();
            Page1.Components.AddRange(new StiComponent[] {
                        DataSP_GetRequestHeader,
                        HeaderSP_GetRequestDetail,
                        DataSP_GetRequestDetail});
            // 
            // Add to Pages
            // 
            Pages.Clear();
            Pages.AddRange(new[] {
                        Page1});
            Dictionary.Relations.Add(ParentSP_GetRequestHeader);
            SP_GetRequestDetail.Columns.AddRange(new[] {
                        new StiDataColumn("RequestID", "RequestID", "RequestID", typeof(int)),
                        new StiDataColumn("RequestDetailID", "RequestDetailID", "RequestDetailID", typeof(int)),
                        new StiDataColumn("MedicamentID", "MedicamentID", "MedicamentID", typeof(int)),
                        new StiDataColumn("MedicamentName", "MedicamentName", "MedicamentName", typeof(string)),
                        new StiDataColumn("RequestQty", "RequestQty", "RequestQty", typeof(decimal)),
                        new StiDataColumn("CountryCode1", "CountryCode1", "CountryCode1", typeof(string)),
                        new StiDataColumn("CountryName1", "CountryName1", "CountryName1", typeof(string)),
                        new StiDataColumn("CountryCode2", "CountryCode2", "CountryCode2", typeof(string)),
                        new StiDataColumn("CountryName2", "CountryName2", "CountryName2", typeof(string)),
                        new StiDataColumn("BrandID", "BrandID", "BrandID", typeof(int)),
                        new StiDataColumn("BrandName", "BrandName", "BrandName", typeof(string)),
                        new StiDataColumn("OrdinalNumber", "OrdinalNumber", "OrdinalNumber", typeof(short)),
                        new StiDataColumn("Action", "Action", "Action", typeof(int))});
            DataSources.Add(SP_GetRequestDetail);
            SP_GetRequestHeader.Columns.AddRange(new[] {
                        new StiDataColumn("RequestID", "RequestID", "RequestID", typeof(int)),
                        new StiDataColumn("BranchID", "BranchID", "BranchID", typeof(int)),
                        new StiDataColumn("BranchName", "BranchName", "BranchName", typeof(string)),
                        new StiDataColumn("RequestDate", "RequestDate", "RequestDate", typeof(DateTime)),
                        new StiDataColumn("Status", "Status", "Status", typeof(byte)),
                        new StiDataColumn("ModifierID", "ModifierID", "ModifierID", typeof(int)),
                        new StiDataColumn("Modifier", "Modifier", "Modifier", typeof(string)),
                        new StiDataColumn("ModifiedDate", "ModifiedDate", "ModifiedDate", typeof(DateTime)),
                        new StiDataColumn("ApproverID", "ApproverID", "ApproverID", typeof(int)),
                        new StiDataColumn("Approver", "Approver", "Approver", typeof(string))});
            DataSources.Add(SP_GetRequestHeader);
        }

        #region Relation ParentSP_GetRequestHeader
        public class ParentSP_GetRequestHeaderRelation : StiDataRow
        {

            public ParentSP_GetRequestHeaderRelation(StiDataRow dataRow) :
                base(dataRow)
            {
            }

            public virtual int RequestID
            {
                get
                {
                    return ((int)(ChangeType(this["RequestID"], typeof(int), true)));
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

            public virtual DateTime RequestDate
            {
                get
                {
                    return ((DateTime)(ChangeType(this["RequestDate"], typeof(DateTime), true)));
                }
            }

            public virtual byte Status
            {
                get
                {
                    return ((byte)(ChangeType(this["Status"], typeof(byte), true)));
                }
            }

            public virtual int ModifierID
            {
                get
                {
                    return ((int)(ChangeType(this["ModifierID"], typeof(int), true)));
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

            public virtual int ApproverID
            {
                get
                {
                    return ((int)(ChangeType(this["ApproverID"], typeof(int), true)));
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
        #endregion Relation ParentSP_GetRequestHeader

        #region DataSource SP_GetRequestDetail
        public class SP_GetRequestDetailDataSource : StiDataTableSource
        {

            public SP_GetRequestDetailDataSource() :
                base("DS_Request.SP_GetRequestDetail", "SP_GetRequestDetail")
            {
            }

            public virtual int RequestID
            {
                get
                {
                    return ((int)(ChangeType(this["RequestID"], typeof(int), true)));
                }
            }

            public virtual int RequestDetailID
            {
                get
                {
                    return ((int)(ChangeType(this["RequestDetailID"], typeof(int), true)));
                }
            }

            public virtual int MedicamentID
            {
                get
                {
                    return ((int)(ChangeType(this["MedicamentID"], typeof(int), true)));
                }
            }

            public virtual string MedicamentName
            {
                get
                {
                    return ((string)(ChangeType(this["MedicamentName"], typeof(string), true)));
                }
            }

            public virtual decimal RequestQty
            {
                get
                {
                    return ((decimal)(ChangeType(this["RequestQty"], typeof(decimal), true)));
                }
            }

            public virtual string CountryCode1
            {
                get
                {
                    return ((string)(ChangeType(this["CountryCode1"], typeof(string), true)));
                }
            }

            public virtual string CountryName1
            {
                get
                {
                    return ((string)(ChangeType(this["CountryName1"], typeof(string), true)));
                }
            }

            public virtual string CountryCode2
            {
                get
                {
                    return ((string)(ChangeType(this["CountryCode2"], typeof(string), true)));
                }
            }

            public virtual string CountryName2
            {
                get
                {
                    return ((string)(ChangeType(this["CountryName2"], typeof(string), true)));
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

            public virtual short OrdinalNumber
            {
                get
                {
                    return ((short)(ChangeType(this["OrdinalNumber"], typeof(short), true)));
                }
            }

            public virtual int Action
            {
                get
                {
                    return ((int)(ChangeType(this["Action"], typeof(int), true)));
                }
            }

            public virtual ParentSP_GetRequestHeaderRelation SP_GetRequestHeader
            {
                get
                {
                    return new ParentSP_GetRequestHeaderRelation(GetParentData("SP_GetRequestHeader_SP_GetRequestDetail"));
                }
            }
        }
        #endregion DataSource SP_GetRequestDetail

        #region DataSource SP_GetRequestHeader
        public class SP_GetRequestHeaderDataSource : StiDataTableSource
        {

            public SP_GetRequestHeaderDataSource() :
                base("DS_Request.SP_GetRequestHeader", "SP_GetRequestHeader")
            {
            }

            public virtual int RequestID
            {
                get
                {
                    return ((int)(ChangeType(this["RequestID"], typeof(int), true)));
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

            public virtual DateTime RequestDate
            {
                get
                {
                    return ((DateTime)(ChangeType(this["RequestDate"], typeof(DateTime), true)));
                }
            }

            public virtual byte Status
            {
                get
                {
                    return ((byte)(ChangeType(this["Status"], typeof(byte), true)));
                }
            }

            public virtual int ModifierID
            {
                get
                {
                    return ((int)(ChangeType(this["ModifierID"], typeof(int), true)));
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

            public virtual int ApproverID
            {
                get
                {
                    return ((int)(ChangeType(this["ApproverID"], typeof(int), true)));
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
        #endregion DataSource SP_GetRequestHeader
        #endregion StiReport Designer generated code - do not modify
    }
}
