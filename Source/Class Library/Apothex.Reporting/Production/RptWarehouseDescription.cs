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

    public class RptWarehouseDescription : StiReport
    {

        public RptWarehouseDescription()
        {
            InitializeComponent();
        }
        #region StiReport Designer generated code - do not modify
        public StiDataRelation ParentSP_GetWarehouseDescriptionHeader;
        public StiPage Page1;
        public StiDataBand DataSP_GetWarehouseDescriptionHeader;
        public StiText Text1;
        public StiHeaderBand HeaderSP_GetWarehouseDescriptionDetail;
        public StiText Text2;
        public StiText Text3;
        public StiText Text4;
        public StiText Text5;
        public StiText Text6;
        public StiText Text7;
        public StiText Text8;
        public StiText Text9;
        public StiText Text10;
        public StiDataBand DataSP_GetWarehouseDescriptionDetail;
        public StiText Text11;
        public StiText Text12;
        public StiText Text13;
        public StiText Text14;
        public StiText Text15;
        public StiText Text16;
        public StiText Text17;
        public StiFooterBand FooterSP_GetWarehouseDescriptionDetail;
        public StiText Text18;
        public StiSumDecimalFunctionService Text18_Sum;
        public StiText Text19;
        public StiSumDecimalFunctionService Text19_Sum;
        public StiText Text20;
        public StiSumDecimalFunctionService Text20_Sum;
        public StiText Text21;
        public StiSumDecimalFunctionService Text21_Sum;
        public StiWatermark Page1_Watermark;
        public StiPrinterSettings RptWarehouseDescription_PrinterSettings;
        public SP_GetWarehouseDescriptionHeaderDataSource SP_GetWarehouseDescriptionHeader;
        public SP_GetWarehouseDescriptionDetailDataSource SP_GetWarehouseDescriptionDetail;

        public void Text1__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "საწყობის აღწერა: " + ToString(sender, Format("{0:d}", SP_GetWarehouseDescriptionHeader.Date), true);
        }

        public void Text2__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "№";
        }

        public void Text3__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "მედიკამენტის დასახელება";
        }

        public void Text4__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ფასი";
        }

        public void Text5__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "რაოდენობა";
        }

        public void Text6__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "დოკუმ.";
        }

        public void Text7__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ფაქტ.";
        }

        public void Text8__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ღირებულება";
        }

        public void Text9__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "დოკუმ.";
        }

        public void Text10__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ფაქტ.";
        }

        public void Text11__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Line, true);
        }

        public void Text12__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetWarehouseDescriptionDetail.MedicamentName, true);
        }

        public void Text13__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text13.TextFormat.Format(CheckExcelValue(sender, SP_GetWarehouseDescriptionDetail.UnitPrice));
        }

        public void Text14__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text14.TextFormat.Format(CheckExcelValue(sender, SP_GetWarehouseDescriptionDetail.Quantity));
        }

        public void Text15__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text15.TextFormat.Format(CheckExcelValue(sender, SP_GetWarehouseDescriptionDetail.DescrQty));
        }

        public void Text16__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text16.TextFormat.Format(CheckExcelValue(sender, SP_GetWarehouseDescriptionDetail.UnitPrice * SP_GetWarehouseDescriptionDetail.Quantity));
        }

        public void Text17__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = Text17.TextFormat.Format(CheckExcelValue(sender, SP_GetWarehouseDescriptionDetail.UnitPrice * SP_GetWarehouseDescriptionDetail.DescrQty));
        }

        public void Text18__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(DataSP_GetWarehouseDescriptionDetail,SP_GetWarehouseDescriptionDetail.Qua" +
"ntity)}";
            e.StoreToPrinted = true;
        }

        public String Text18_GetValue_End(StiComponent sender)
        {
            return Text18.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text18_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void Text19__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(DataSP_GetWarehouseDescriptionDetail,SP_GetWarehouseDescriptionDetail.Des" +
"crQty)}";
            e.StoreToPrinted = true;
        }

        public String Text19_GetValue_End(StiComponent sender)
        {
            return Text19.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text19_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void Text20__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(DataSP_GetWarehouseDescriptionDetail,SP_GetWarehouseDescriptionDetail.Uni" +
"tPrice * SP_GetWarehouseDescriptionDetail.Quantity)}";
            e.StoreToPrinted = true;
        }

        public String Text20_GetValue_End(StiComponent sender)
        {
            return Text20.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text20_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void Text21__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(DataSP_GetWarehouseDescriptionDetail,SP_GetWarehouseDescriptionDetail.Uni" +
"tPrice *SP_GetWarehouseDescriptionDetail.DescrQty)}";
            e.StoreToPrinted = true;
        }

        public String Text21_GetValue_End(StiComponent sender)
        {
            return Text21.TextFormat.Format(CheckExcelValue(sender, ((decimal)(ChangeType(Text21_Sum.GetValue(), typeof(decimal), true)))));
        }

        public void DataSP_GetWarehouseDescriptionDetail__BeginRender(object sender, EventArgs e)
        {
            Text18_Sum.Init();
            Text18.TextValue = "";
            Text19_Sum.Init();
            Text19.TextValue = "";
            Text20_Sum.Init();
            Text20.TextValue = "";
            Text21_Sum.Init();
            Text21.TextValue = "";
        }

        public void DataSP_GetWarehouseDescriptionDetail__EndRender(object sender, EventArgs e)
        {
            Text18.SetText(new StiGetValue(Text18_GetValue_End));
            Text19.SetText(new StiGetValue(Text19_GetValue_End));
            Text20.SetText(new StiGetValue(Text20_GetValue_End));
            Text21.SetText(new StiGetValue(Text21_GetValue_End));
        }

        public void DataSP_GetWarehouseDescriptionDetail__Rendering(object sender, EventArgs e)
        {
            Text18_Sum.CalcItem(SP_GetWarehouseDescriptionDetail.Quantity);
            Text19_Sum.CalcItem(SP_GetWarehouseDescriptionDetail.DescrQty);
            Text20_Sum.CalcItem(SP_GetWarehouseDescriptionDetail.UnitPrice * SP_GetWarehouseDescriptionDetail.Quantity);
            Text21_Sum.CalcItem(SP_GetWarehouseDescriptionDetail.UnitPrice * SP_GetWarehouseDescriptionDetail.DescrQty);
        }

        private void InitializeComponent()
        {
            SP_GetWarehouseDescriptionDetail = new SP_GetWarehouseDescriptionDetailDataSource();
            SP_GetWarehouseDescriptionHeader = new SP_GetWarehouseDescriptionHeaderDataSource();
            ParentSP_GetWarehouseDescriptionHeader = new StiDataRelation("SP_GetWarehouseDescriptionHeader_SP_GetWarehouseDescriptionDetail", "SP_GetWarehouseDescriptionHeader", "SP_GetWarehouseDescriptionHeader", SP_GetWarehouseDescriptionHeader, SP_GetWarehouseDescriptionDetail, new[] {
                        "WarehouseDescriptionID"}, new[] {
                        "WarehouseDescriptionID"});
            NeedsCompiling = false;
            Text21_Sum = new StiSumDecimalFunctionService();
            Text20_Sum = new StiSumDecimalFunctionService();
            Text19_Sum = new StiSumDecimalFunctionService();
            Text18_Sum = new StiSumDecimalFunctionService();
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
            ReportAlias = "Rpt Warehouse Description";
            ReportAuthor = "Programmer.GE";
            // 
            // ReportChanged
            // 
            ReportChanged = new DateTime(2010, 10, 29, 22, 36, 32, 218);
            // 
            // ReportCreated
            // 
            ReportCreated = new DateTime(2010, 5, 27, 23, 6, 16, 0);
            ReportDescription = "საწყობის აღწერის რეპორტი";
            ReportFile = "D:\\User\\Documents\\Projects\\Apothex\\Source\\Class Library\\Apothex.Reporting\\Product" +
"ion\\RptWarehouseDescription.mrt";
            ReportGuid = "57f746a778f1499eb08878bcaff63314";
            ReportName = "RptWarehouseDescription";
            ReportUnit = StiReportUnitType.Centimeters;
            ScriptLanguage = StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            Page1 = new StiPage();
            Page1.Guid = "da69d43d785e4ef8af8227c5bd6632f4";
            Page1.Name = "Page1";
            Page1.PageHeight = 29.7;
            Page1.PageWidth = 21;
            Page1.Border = new StiBorder(StiBorderSides.None, Color.Black, 2, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Page1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // DataSP_GetWarehouseDescriptionHeader
            // 
            DataSP_GetWarehouseDescriptionHeader = new StiDataBand();
            DataSP_GetWarehouseDescriptionHeader.ClientRectangle = new RectangleD(0, 0.4, 19, 0.6);
            DataSP_GetWarehouseDescriptionHeader.DataSourceName = "SP_GetWarehouseDescriptionHeader";
            DataSP_GetWarehouseDescriptionHeader.Name = "DataSP_GetWarehouseDescriptionHeader";
            DataSP_GetWarehouseDescriptionHeader.Sort = new String[0];
            DataSP_GetWarehouseDescriptionHeader.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetWarehouseDescriptionHeader.Brush = new StiSolidBrush(Color.Transparent);
            DataSP_GetWarehouseDescriptionHeader.BusinessObjectGuid = null;
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
            DataSP_GetWarehouseDescriptionHeader.Guid = null;
            DataSP_GetWarehouseDescriptionHeader.Interaction = null;
            DataSP_GetWarehouseDescriptionHeader.MasterComponent = null;
            // 
            // HeaderSP_GetWarehouseDescriptionDetail
            // 
            HeaderSP_GetWarehouseDescriptionDetail = new StiHeaderBand();
            HeaderSP_GetWarehouseDescriptionDetail.ClientRectangle = new RectangleD(0, 1.8, 19, 1.2);
            HeaderSP_GetWarehouseDescriptionDetail.Name = "HeaderSP_GetWarehouseDescriptionDetail";
            HeaderSP_GetWarehouseDescriptionDetail.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderSP_GetWarehouseDescriptionDetail.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text2
            // 
            Text2 = new StiText();
            Text2.ClientRectangle = new RectangleD(0, 0, 1.6, 1.2);
            Text2.HorAlignment = StiTextHorAlignment.Center;
            Text2.Name = "Text2";
            Text2.GetValue += new StiGetValueEventHandler(Text2__GetValue);
            Text2.VertAlignment = StiVertAlignment.Center;
            Text2.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text2.Brush = new StiSolidBrush(Color.Transparent);
            Text2.Font = new Font("BPG Glaho Arial", 9F, FontStyle.Bold);
            Text2.Guid = null;
            Text2.Interaction = null;
            Text2.Margins = new StiMargins(0, 0, 0, 0);
            Text2.TextBrush = new StiSolidBrush(Color.Black);
            Text2.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text3
            // 
            Text3 = new StiText();
            Text3.ClientRectangle = new RectangleD(1.6, 0, 7.4, 1.2);
            Text3.Guid = "5a6b47dcb6cf4f61a943622ba61f8572";
            Text3.HorAlignment = StiTextHorAlignment.Center;
            Text3.Name = "Text3";
            Text3.GetValue += new StiGetValueEventHandler(Text3__GetValue);
            Text3.VertAlignment = StiVertAlignment.Center;
            Text3.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text3.Brush = new StiSolidBrush(Color.Transparent);
            Text3.Font = new Font("BPG Glaho Arial", 9F, FontStyle.Bold);
            Text3.Interaction = null;
            Text3.Margins = new StiMargins(0, 0, 0, 0);
            Text3.TextBrush = new StiSolidBrush(Color.Black);
            Text3.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text4
            // 
            Text4 = new StiText();
            Text4.ClientRectangle = new RectangleD(9, 0, 2, 1.2);
            Text4.Guid = "ce123cbf777944a2a420692967f37c02";
            Text4.HorAlignment = StiTextHorAlignment.Center;
            Text4.Name = "Text4";
            Text4.GetValue += new StiGetValueEventHandler(Text4__GetValue);
            Text4.VertAlignment = StiVertAlignment.Center;
            Text4.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text4.Brush = new StiSolidBrush(Color.Transparent);
            Text4.Font = new Font("BPG Glaho Arial", 9F, FontStyle.Bold);
            Text4.Interaction = null;
            Text4.Margins = new StiMargins(0, 0, 0, 0);
            Text4.TextBrush = new StiSolidBrush(Color.Black);
            Text4.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text5
            // 
            Text5 = new StiText();
            Text5.ClientRectangle = new RectangleD(11, 0, 4, 0.6);
            Text5.Guid = "ff7b89e6cfe14eb9a3dc0dd1efc9dcbc";
            Text5.HorAlignment = StiTextHorAlignment.Center;
            Text5.Name = "Text5";
            Text5.GetValue += new StiGetValueEventHandler(Text5__GetValue);
            Text5.VertAlignment = StiVertAlignment.Center;
            Text5.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text5.Brush = new StiSolidBrush(Color.Transparent);
            Text5.Font = new Font("BPG Glaho Arial", 9F, FontStyle.Bold);
            Text5.Interaction = null;
            Text5.Margins = new StiMargins(0, 0, 0, 0);
            Text5.TextBrush = new StiSolidBrush(Color.Black);
            Text5.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text6
            // 
            Text6 = new StiText();
            Text6.ClientRectangle = new RectangleD(11, 0.6, 2, 0.6);
            Text6.Guid = "ee1dab82d6ce41ce9fc99333f0dcc70c";
            Text6.HorAlignment = StiTextHorAlignment.Center;
            Text6.Name = "Text6";
            Text6.GetValue += new StiGetValueEventHandler(Text6__GetValue);
            Text6.VertAlignment = StiVertAlignment.Center;
            Text6.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text6.Brush = new StiSolidBrush(Color.Transparent);
            Text6.Font = new Font("BPG Glaho Arial", 9F, FontStyle.Bold);
            Text6.Interaction = null;
            Text6.Margins = new StiMargins(0, 0, 0, 0);
            Text6.TextBrush = new StiSolidBrush(Color.Black);
            Text6.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text7
            // 
            Text7 = new StiText();
            Text7.ClientRectangle = new RectangleD(13, 0.6, 2, 0.6);
            Text7.Guid = "8a37ea1e76ca41448f4468273c954a8e";
            Text7.HorAlignment = StiTextHorAlignment.Center;
            Text7.Name = "Text7";
            Text7.GetValue += new StiGetValueEventHandler(Text7__GetValue);
            Text7.VertAlignment = StiVertAlignment.Center;
            Text7.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text7.Brush = new StiSolidBrush(Color.Transparent);
            Text7.Font = new Font("BPG Glaho Arial", 9F, FontStyle.Bold);
            Text7.Interaction = null;
            Text7.Margins = new StiMargins(0, 0, 0, 0);
            Text7.TextBrush = new StiSolidBrush(Color.Black);
            Text7.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text8
            // 
            Text8 = new StiText();
            Text8.ClientRectangle = new RectangleD(15, 0, 4, 0.6);
            Text8.Guid = "9b54052d3c9d403c98fd9a62a5878b29";
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
            Text8.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text9
            // 
            Text9 = new StiText();
            Text9.ClientRectangle = new RectangleD(15, 0.6, 2, 0.6);
            Text9.Guid = "56bfa03076924c5eb87f6a683a1465d5";
            Text9.HorAlignment = StiTextHorAlignment.Center;
            Text9.Name = "Text9";
            Text9.GetValue += new StiGetValueEventHandler(Text9__GetValue);
            Text9.VertAlignment = StiVertAlignment.Center;
            Text9.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text9.Brush = new StiSolidBrush(Color.Transparent);
            Text9.Font = new Font("BPG Glaho Arial", 9F, FontStyle.Bold);
            Text9.Interaction = null;
            Text9.Margins = new StiMargins(0, 0, 0, 0);
            Text9.TextBrush = new StiSolidBrush(Color.Black);
            Text9.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text10
            // 
            Text10 = new StiText();
            Text10.ClientRectangle = new RectangleD(17, 0.6, 2, 0.6);
            Text10.Guid = "75bc4afb412448edbacd4855704c11fe";
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
            Text10.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            HeaderSP_GetWarehouseDescriptionDetail.Guid = null;
            HeaderSP_GetWarehouseDescriptionDetail.Interaction = null;
            // 
            // DataSP_GetWarehouseDescriptionDetail
            // 
            DataSP_GetWarehouseDescriptionDetail = new StiDataBand();
            DataSP_GetWarehouseDescriptionDetail.ClientRectangle = new RectangleD(0, 3.8, 19, 0.8);
            DataSP_GetWarehouseDescriptionDetail.DataRelationName = "SP_GetWarehouseDescriptionHeader_SP_GetWarehouseDescriptionDetail";
            DataSP_GetWarehouseDescriptionDetail.DataSourceName = "SP_GetWarehouseDescriptionDetail";
            DataSP_GetWarehouseDescriptionDetail.Name = "DataSP_GetWarehouseDescriptionDetail";
            DataSP_GetWarehouseDescriptionDetail.Sort = new String[0];
            DataSP_GetWarehouseDescriptionDetail.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataSP_GetWarehouseDescriptionDetail.Brush = new StiSolidBrush(Color.Transparent);
            DataSP_GetWarehouseDescriptionDetail.BusinessObjectGuid = null;
            // 
            // Text11
            // 
            Text11 = new StiText();
            Text11.ClientRectangle = new RectangleD(0, 0, 1.6, 0.8);
            Text11.GrowToHeight = true;
            Text11.Guid = "b9657e546925434aa2448e801d745e8b";
            Text11.HorAlignment = StiTextHorAlignment.Center;
            Text11.Name = "Text11";
            Text11.GetValue += new StiGetValueEventHandler(Text11__GetValue);
            Text11.VertAlignment = StiVertAlignment.Center;
            Text11.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text11.Brush = new StiSolidBrush(Color.Transparent);
            Text11.Font = new Font("BPG Glaho Arial", 8F);
            Text11.Interaction = null;
            Text11.Margins = new StiMargins(0, 0, 0, 0);
            Text11.TextBrush = new StiSolidBrush(Color.Black);
            Text11.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text12
            // 
            Text12 = new StiText();
            Text12.CanGrow = true;
            Text12.ClientRectangle = new RectangleD(1.6, 0, 7.4, 0.8);
            Text12.GrowToHeight = true;
            Text12.Guid = "4fceb39f82cc4a43a9a276938e0c7f11";
            Text12.Name = "Text12";
            Text12.GetValue += new StiGetValueEventHandler(Text12__GetValue);
            Text12.VertAlignment = StiVertAlignment.Center;
            Text12.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text12.Brush = new StiSolidBrush(Color.Transparent);
            Text12.Font = new Font("BPG Glaho Arial", 8F);
            Text12.Interaction = null;
            Text12.Margins = new StiMargins(0, 0, 0, 0);
            Text12.TextBrush = new StiSolidBrush(Color.Black);
            Text12.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text13
            // 
            Text13 = new StiText();
            Text13.ClientRectangle = new RectangleD(9, 0, 2, 0.8);
            Text13.GrowToHeight = true;
            Text13.Guid = "0d56d33a69f04e9fb19872cf90d0986a";
            Text13.HorAlignment = StiTextHorAlignment.Right;
            Text13.Name = "Text13";
            Text13.GetValue += new StiGetValueEventHandler(Text13__GetValue);
            Text13.VertAlignment = StiVertAlignment.Center;
            Text13.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text13.Brush = new StiSolidBrush(Color.Transparent);
            Text13.Font = new Font("BPG Glaho Arial", 8F);
            Text13.Interaction = null;
            Text13.Margins = new StiMargins(0, 0, 0, 0);
            Text13.TextBrush = new StiSolidBrush(Color.Black);
            Text13.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            Text13.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text14
            // 
            Text14 = new StiText();
            Text14.ClientRectangle = new RectangleD(11, 0, 2, 0.8);
            Text14.GrowToHeight = true;
            Text14.Guid = "9ed92c61d4a64c888285ea23c640acc2";
            Text14.HorAlignment = StiTextHorAlignment.Right;
            Text14.Name = "Text14";
            Text14.GetValue += new StiGetValueEventHandler(Text14__GetValue);
            Text14.VertAlignment = StiVertAlignment.Center;
            Text14.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text14.Brush = new StiSolidBrush(Color.Transparent);
            Text14.Font = new Font("BPG Glaho Arial", 8F);
            Text14.Interaction = null;
            Text14.Margins = new StiMargins(0, 0, 0, 0);
            Text14.TextBrush = new StiSolidBrush(Color.Black);
            Text14.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            Text14.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text15
            // 
            Text15 = new StiText();
            Text15.ClientRectangle = new RectangleD(13, 0, 2, 0.8);
            Text15.GrowToHeight = true;
            Text15.Guid = "ee21c48fbcdb442bb36067f07e757107";
            Text15.HorAlignment = StiTextHorAlignment.Right;
            Text15.Name = "Text15";
            Text15.GetValue += new StiGetValueEventHandler(Text15__GetValue);
            Text15.VertAlignment = StiVertAlignment.Center;
            Text15.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text15.Brush = new StiSolidBrush(Color.Transparent);
            Text15.Font = new Font("BPG Glaho Arial", 8F);
            Text15.Interaction = null;
            Text15.Margins = new StiMargins(0, 0, 0, 0);
            Text15.TextBrush = new StiSolidBrush(Color.Black);
            Text15.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            Text15.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text16
            // 
            Text16 = new StiText();
            Text16.ClientRectangle = new RectangleD(15, 0, 2, 0.8);
            Text16.GrowToHeight = true;
            Text16.Guid = "e617193b8e6742559111283651c9ab19";
            Text16.HorAlignment = StiTextHorAlignment.Right;
            Text16.Name = "Text16";
            Text16.GetValue += new StiGetValueEventHandler(Text16__GetValue);
            Text16.VertAlignment = StiVertAlignment.Center;
            Text16.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text16.Brush = new StiSolidBrush(Color.Transparent);
            Text16.Font = new Font("BPG Glaho Arial", 8F);
            Text16.Interaction = null;
            Text16.Margins = new StiMargins(0, 0, 0, 0);
            Text16.TextBrush = new StiSolidBrush(Color.Black);
            Text16.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            Text16.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text17
            // 
            Text17 = new StiText();
            Text17.ClientRectangle = new RectangleD(17, 0, 2, 0.8);
            Text17.GrowToHeight = true;
            Text17.Guid = "1bea953a667c432c945d56fad9c689b8";
            Text17.HorAlignment = StiTextHorAlignment.Right;
            Text17.Name = "Text17";
            Text17.GetValue += new StiGetValueEventHandler(Text17__GetValue);
            Text17.VertAlignment = StiVertAlignment.Center;
            Text17.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text17.Brush = new StiSolidBrush(Color.Transparent);
            Text17.Font = new Font("BPG Glaho Arial", 8F);
            Text17.Interaction = null;
            Text17.Margins = new StiMargins(0, 0, 0, 0);
            Text17.TextBrush = new StiSolidBrush(Color.Black);
            Text17.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            Text17.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            DataSP_GetWarehouseDescriptionDetail.Guid = null;
            DataSP_GetWarehouseDescriptionDetail.Interaction = null;
            // 
            // FooterSP_GetWarehouseDescriptionDetail
            // 
            FooterSP_GetWarehouseDescriptionDetail = new StiFooterBand();
            FooterSP_GetWarehouseDescriptionDetail.ClientRectangle = new RectangleD(0, 5.4, 19, 0.8);
            FooterSP_GetWarehouseDescriptionDetail.Name = "FooterSP_GetWarehouseDescriptionDetail";
            FooterSP_GetWarehouseDescriptionDetail.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            FooterSP_GetWarehouseDescriptionDetail.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // Text18
            // 
            Text18 = new StiText();
            Text18.ClientRectangle = new RectangleD(11, 0, 2, 0.8);
            Text18.GrowToHeight = true;
            Text18.Guid = "de7a563c918d45d1b4fabf57e698ca30";
            Text18.HorAlignment = StiTextHorAlignment.Right;
            Text18.Name = "Text18";
            // 
            // Text18_Sum
            // 
            Text18.GetValue += new StiGetValueEventHandler(Text18__GetValue);
            Text18.VertAlignment = StiVertAlignment.Center;
            Text18.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text18.Brush = new StiSolidBrush(Color.Transparent);
            Text18.Font = new Font("BPG Glaho Arial", 8F);
            Text18.Interaction = null;
            Text18.Margins = new StiMargins(0, 0, 0, 0);
            Text18.TextBrush = new StiSolidBrush(Color.Black);
            Text18.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            Text18.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text19
            // 
            Text19 = new StiText();
            Text19.ClientRectangle = new RectangleD(13, 0, 2, 0.8);
            Text19.GrowToHeight = true;
            Text19.Guid = "4724f0d2511e41bb82bf5025e1c68356";
            Text19.HorAlignment = StiTextHorAlignment.Right;
            Text19.Name = "Text19";
            // 
            // Text19_Sum
            // 
            Text19.GetValue += new StiGetValueEventHandler(Text19__GetValue);
            Text19.VertAlignment = StiVertAlignment.Center;
            Text19.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text19.Brush = new StiSolidBrush(Color.Transparent);
            Text19.Font = new Font("BPG Glaho Arial", 8F);
            Text19.Interaction = null;
            Text19.Margins = new StiMargins(0, 0, 0, 0);
            Text19.TextBrush = new StiSolidBrush(Color.Black);
            Text19.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            Text19.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text20
            // 
            Text20 = new StiText();
            Text20.ClientRectangle = new RectangleD(15, 0, 2, 0.8);
            Text20.GrowToHeight = true;
            Text20.Guid = "2aca64091c784e6696c54201bf90a074";
            Text20.HorAlignment = StiTextHorAlignment.Right;
            Text20.Name = "Text20";
            // 
            // Text20_Sum
            // 
            Text20.GetValue += new StiGetValueEventHandler(Text20__GetValue);
            Text20.VertAlignment = StiVertAlignment.Center;
            Text20.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text20.Brush = new StiSolidBrush(Color.Transparent);
            Text20.Font = new Font("BPG Glaho Arial", 8F);
            Text20.Interaction = null;
            Text20.Margins = new StiMargins(0, 0, 0, 0);
            Text20.TextBrush = new StiSolidBrush(Color.Black);
            Text20.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            Text20.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text21
            // 
            Text21 = new StiText();
            Text21.ClientRectangle = new RectangleD(17, 0, 2, 0.8);
            Text21.GrowToHeight = true;
            Text21.Guid = "36c99ccd1b634b83abf8b00d60f69195";
            Text21.HorAlignment = StiTextHorAlignment.Right;
            Text21.Name = "Text21";
            // 
            // Text21_Sum
            // 
            Text21.GetValue += new StiGetValueEventHandler(Text21__GetValue);
            Text21.VertAlignment = StiVertAlignment.Center;
            Text21.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text21.Brush = new StiSolidBrush(Color.Transparent);
            Text21.Font = new Font("BPG Glaho Arial", 8F);
            Text21.Interaction = null;
            Text21.Margins = new StiMargins(0, 0, 0, 0);
            Text21.TextBrush = new StiSolidBrush(Color.Black);
            Text21.TextFormat = new StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            Text21.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            FooterSP_GetWarehouseDescriptionDetail.Guid = null;
            FooterSP_GetWarehouseDescriptionDetail.Interaction = null;
            Page1.ExcelSheetValue = null;
            Page1.Interaction = null;
            Page1.Margins = new StiMargins(1, 1, 1, 1);
            Page1_Watermark = new StiWatermark();
            Page1_Watermark.Font = new Font("Arial", 100F);
            Page1_Watermark.Image = null;
            Page1_Watermark.TextBrush = new StiSolidBrush(Color.FromArgb(50, 0, 0, 0));
            RptWarehouseDescription_PrinterSettings = new StiPrinterSettings();
            PrinterSettings = RptWarehouseDescription_PrinterSettings;
            Page1.Report = this;
            Page1.Watermark = Page1_Watermark;
            DataSP_GetWarehouseDescriptionHeader.Page = Page1;
            DataSP_GetWarehouseDescriptionHeader.Parent = Page1;
            Text1.Page = Page1;
            Text1.Parent = DataSP_GetWarehouseDescriptionHeader;
            HeaderSP_GetWarehouseDescriptionDetail.Page = Page1;
            HeaderSP_GetWarehouseDescriptionDetail.Parent = Page1;
            Text2.Page = Page1;
            Text2.Parent = HeaderSP_GetWarehouseDescriptionDetail;
            Text3.Page = Page1;
            Text3.Parent = HeaderSP_GetWarehouseDescriptionDetail;
            Text4.Page = Page1;
            Text4.Parent = HeaderSP_GetWarehouseDescriptionDetail;
            Text5.Page = Page1;
            Text5.Parent = HeaderSP_GetWarehouseDescriptionDetail;
            Text6.Page = Page1;
            Text6.Parent = HeaderSP_GetWarehouseDescriptionDetail;
            Text7.Page = Page1;
            Text7.Parent = HeaderSP_GetWarehouseDescriptionDetail;
            Text8.Page = Page1;
            Text8.Parent = HeaderSP_GetWarehouseDescriptionDetail;
            Text9.Page = Page1;
            Text9.Parent = HeaderSP_GetWarehouseDescriptionDetail;
            Text10.Page = Page1;
            Text10.Parent = HeaderSP_GetWarehouseDescriptionDetail;
            DataSP_GetWarehouseDescriptionDetail.MasterComponent = DataSP_GetWarehouseDescriptionHeader;
            DataSP_GetWarehouseDescriptionDetail.Page = Page1;
            DataSP_GetWarehouseDescriptionDetail.Parent = Page1;
            Text11.Page = Page1;
            Text11.Parent = DataSP_GetWarehouseDescriptionDetail;
            Text12.Page = Page1;
            Text12.Parent = DataSP_GetWarehouseDescriptionDetail;
            Text13.Page = Page1;
            Text13.Parent = DataSP_GetWarehouseDescriptionDetail;
            Text14.Page = Page1;
            Text14.Parent = DataSP_GetWarehouseDescriptionDetail;
            Text15.Page = Page1;
            Text15.Parent = DataSP_GetWarehouseDescriptionDetail;
            Text16.Page = Page1;
            Text16.Parent = DataSP_GetWarehouseDescriptionDetail;
            Text17.Page = Page1;
            Text17.Parent = DataSP_GetWarehouseDescriptionDetail;
            FooterSP_GetWarehouseDescriptionDetail.Page = Page1;
            FooterSP_GetWarehouseDescriptionDetail.Parent = Page1;
            Text18.Page = Page1;
            Text18.Parent = FooterSP_GetWarehouseDescriptionDetail;
            Text19.Page = Page1;
            Text19.Parent = FooterSP_GetWarehouseDescriptionDetail;
            Text20.Page = Page1;
            Text20.Parent = FooterSP_GetWarehouseDescriptionDetail;
            Text21.Page = Page1;
            Text21.Parent = FooterSP_GetWarehouseDescriptionDetail;
            DataSP_GetWarehouseDescriptionDetail.BeginRender += new EventHandler(DataSP_GetWarehouseDescriptionDetail__BeginRender);
            DataSP_GetWarehouseDescriptionDetail.EndRender += new EventHandler(DataSP_GetWarehouseDescriptionDetail__EndRender);
            DataSP_GetWarehouseDescriptionDetail.Rendering += new EventHandler(DataSP_GetWarehouseDescriptionDetail__Rendering);
            AggregateFunctions = new object[] {
                    Text18_Sum,
                    Text19_Sum,
                    Text20_Sum,
                    Text21_Sum};
            // 
            // Add to DataSP_GetWarehouseDescriptionHeader.Components
            // 
            DataSP_GetWarehouseDescriptionHeader.Components.Clear();
            DataSP_GetWarehouseDescriptionHeader.Components.AddRange(new StiComponent[] {
                        Text1});
            // 
            // Add to HeaderSP_GetWarehouseDescriptionDetail.Components
            // 
            HeaderSP_GetWarehouseDescriptionDetail.Components.Clear();
            HeaderSP_GetWarehouseDescriptionDetail.Components.AddRange(new StiComponent[] {
                        Text2,
                        Text3,
                        Text4,
                        Text5,
                        Text6,
                        Text7,
                        Text8,
                        Text9,
                        Text10});
            // 
            // Add to DataSP_GetWarehouseDescriptionDetail.Components
            // 
            DataSP_GetWarehouseDescriptionDetail.Components.Clear();
            DataSP_GetWarehouseDescriptionDetail.Components.AddRange(new StiComponent[] {
                        Text11,
                        Text12,
                        Text13,
                        Text14,
                        Text15,
                        Text16,
                        Text17});
            // 
            // Add to FooterSP_GetWarehouseDescriptionDetail.Components
            // 
            FooterSP_GetWarehouseDescriptionDetail.Components.Clear();
            FooterSP_GetWarehouseDescriptionDetail.Components.AddRange(new StiComponent[] {
                        Text18,
                        Text19,
                        Text20,
                        Text21});
            // 
            // Add to Page1.Components
            // 
            Page1.Components.Clear();
            Page1.Components.AddRange(new StiComponent[] {
                        DataSP_GetWarehouseDescriptionHeader,
                        HeaderSP_GetWarehouseDescriptionDetail,
                        DataSP_GetWarehouseDescriptionDetail,
                        FooterSP_GetWarehouseDescriptionDetail});
            // 
            // Add to Pages
            // 
            Pages.Clear();
            Pages.AddRange(new[] {
                        Page1});
            Dictionary.Relations.Add(ParentSP_GetWarehouseDescriptionHeader);
            SP_GetWarehouseDescriptionHeader.Columns.AddRange(new[] {
                        new StiDataColumn("WarehouseDescriptionID", "WarehouseDescriptionID", "WarehouseDescriptionID", typeof(int)),
                        new StiDataColumn("BranchID", "BranchID", "BranchID", typeof(int)),
                        new StiDataColumn("Date", "Date", "Date", typeof(DateTime)),
                        new StiDataColumn("ProductCount", "ProductCount", "ProductCount", typeof(int)),
                        new StiDataColumn("ProductQty", "ProductQty", "ProductQty", typeof(decimal)),
                        new StiDataColumn("DescrQty", "DescrQty", "DescrQty", typeof(decimal)),
                        new StiDataColumn("CurrencyCode", "CurrencyCode", "CurrencyCode", typeof(string)),
                        new StiDataColumn("Status", "Status", "Status", typeof(byte)),
                        new StiDataColumn("CreateDate", "CreateDate", "CreateDate", typeof(DateTime)),
                        new StiDataColumn("CreatorID", "CreatorID", "CreatorID", typeof(int)),
                        new StiDataColumn("ModifiedDate", "ModifiedDate", "ModifiedDate", typeof(DateTime)),
                        new StiDataColumn("ModifierID", "ModifierID", "ModifierID", typeof(int)),
                        new StiDataColumn("ApproverID", "ApproverID", "ApproverID", typeof(int))});
            DataSources.Add(SP_GetWarehouseDescriptionHeader);
            SP_GetWarehouseDescriptionDetail.Columns.AddRange(new[] {
                        new StiDataColumn("WarehouseDescriptionDetailID", "WarehouseDescriptionDetailID", "WarehouseDescriptionDetailID", typeof(int)),
                        new StiDataColumn("WarehouseDescriptionID", "WarehouseDescriptionID", "WarehouseDescriptionID", typeof(int)),
                        new StiDataColumn("OrdinalNumber", "OrdinalNumber", "OrdinalNumber", typeof(short)),
                        new StiDataColumn("PurchaseOrderID", "PurchaseOrderID", "PurchaseOrderID", typeof(int)),
                        new StiDataColumn("OrderDate", "OrderDate", "OrderDate", typeof(DateTime)),
                        new StiDataColumn("ProductID", "ProductID", "ProductID", typeof(int)),
                        new StiDataColumn("MedicamentID", "MedicamentID", "MedicamentID", typeof(int)),
                        new StiDataColumn("MedicamentName", "MedicamentName", "MedicamentName", typeof(string)),
                        new StiDataColumn("UnitsInStock", "UnitsInStock", "UnitsInStock", typeof(short)),
                        new StiDataColumn("CountryCode", "CountryCode", "CountryCode", typeof(string)),
                        new StiDataColumn("BrandID", "BrandID", "BrandID", typeof(int)),
                        new StiDataColumn("UnitPrice", "UnitPrice", "UnitPrice", typeof(decimal)),
                        new StiDataColumn("Quantity", "Quantity", "Quantity", typeof(decimal)),
                        new StiDataColumn("DescrQty", "DescrQty", "DescrQty", typeof(decimal)),
                        new StiDataColumn("Comment", "Comment", "Comment", typeof(string)),
                        new StiDataColumn("_DescrQtyString", "_DescrQtyString", "_DescrQtyString", typeof(decimal)),
                        new StiDataColumn("Action", "Action", "Action", typeof(int))});
            DataSources.Add(SP_GetWarehouseDescriptionDetail);
        }

        #region Relation ParentSP_GetWarehouseDescriptionHeader
        public class ParentSP_GetWarehouseDescriptionHeaderRelation : StiDataRow
        {

            public ParentSP_GetWarehouseDescriptionHeaderRelation(StiDataRow dataRow) :
                base(dataRow)
            {
            }

            public virtual int WarehouseDescriptionID
            {
                get
                {
                    return ((int)(ChangeType(this["WarehouseDescriptionID"], typeof(int), true)));
                }
            }

            public virtual int BranchID
            {
                get
                {
                    return ((int)(ChangeType(this["BranchID"], typeof(int), true)));
                }
            }

            public virtual DateTime Date
            {
                get
                {
                    return ((DateTime)(ChangeType(this["Date"], typeof(DateTime), true)));
                }
            }

            public virtual int ProductCount
            {
                get
                {
                    return ((int)(ChangeType(this["ProductCount"], typeof(int), true)));
                }
            }

            public virtual decimal ProductQty
            {
                get
                {
                    return ((decimal)(ChangeType(this["ProductQty"], typeof(decimal), true)));
                }
            }

            public virtual decimal DescrQty
            {
                get
                {
                    return ((decimal)(ChangeType(this["DescrQty"], typeof(decimal), true)));
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

            public virtual DateTime CreateDate
            {
                get
                {
                    return ((DateTime)(ChangeType(this["CreateDate"], typeof(DateTime), true)));
                }
            }

            public virtual int CreatorID
            {
                get
                {
                    return ((int)(ChangeType(this["CreatorID"], typeof(int), true)));
                }
            }

            public virtual DateTime ModifiedDate
            {
                get
                {
                    return ((DateTime)(ChangeType(this["ModifiedDate"], typeof(DateTime), true)));
                }
            }

            public virtual int ModifierID
            {
                get
                {
                    return ((int)(ChangeType(this["ModifierID"], typeof(int), true)));
                }
            }

            public virtual int ApproverID
            {
                get
                {
                    return ((int)(ChangeType(this["ApproverID"], typeof(int), true)));
                }
            }
        }
        #endregion Relation ParentSP_GetWarehouseDescriptionHeader

        #region DataSource SP_GetWarehouseDescriptionHeader
        public class SP_GetWarehouseDescriptionHeaderDataSource : StiDataTableSource
        {

            public SP_GetWarehouseDescriptionHeaderDataSource() :
                base("DS_WarehouseDescription.SP_GetWarehouseDescriptionHeader", "SP_GetWarehouseDescriptionHeader")
            {
            }

            public virtual int WarehouseDescriptionID
            {
                get
                {
                    return ((int)(ChangeType(this["WarehouseDescriptionID"], typeof(int), true)));
                }
            }

            public virtual int BranchID
            {
                get
                {
                    return ((int)(ChangeType(this["BranchID"], typeof(int), true)));
                }
            }

            public virtual DateTime Date
            {
                get
                {
                    return ((DateTime)(ChangeType(this["Date"], typeof(DateTime), true)));
                }
            }

            public virtual int ProductCount
            {
                get
                {
                    return ((int)(ChangeType(this["ProductCount"], typeof(int), true)));
                }
            }

            public virtual decimal ProductQty
            {
                get
                {
                    return ((decimal)(ChangeType(this["ProductQty"], typeof(decimal), true)));
                }
            }

            public virtual decimal DescrQty
            {
                get
                {
                    return ((decimal)(ChangeType(this["DescrQty"], typeof(decimal), true)));
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

            public virtual DateTime CreateDate
            {
                get
                {
                    return ((DateTime)(ChangeType(this["CreateDate"], typeof(DateTime), true)));
                }
            }

            public virtual int CreatorID
            {
                get
                {
                    return ((int)(ChangeType(this["CreatorID"], typeof(int), true)));
                }
            }

            public virtual DateTime ModifiedDate
            {
                get
                {
                    return ((DateTime)(ChangeType(this["ModifiedDate"], typeof(DateTime), true)));
                }
            }

            public virtual int ModifierID
            {
                get
                {
                    return ((int)(ChangeType(this["ModifierID"], typeof(int), true)));
                }
            }

            public virtual int ApproverID
            {
                get
                {
                    return ((int)(ChangeType(this["ApproverID"], typeof(int), true)));
                }
            }
        }
        #endregion DataSource SP_GetWarehouseDescriptionHeader

        #region DataSource SP_GetWarehouseDescriptionDetail
        public class SP_GetWarehouseDescriptionDetailDataSource : StiDataTableSource
        {

            public SP_GetWarehouseDescriptionDetailDataSource() :
                base("DS_WarehouseDescription.SP_GetWarehouseDescriptionDetail", "SP_GetWarehouseDescriptionDetail")
            {
            }

            public virtual int WarehouseDescriptionDetailID
            {
                get
                {
                    return ((int)(ChangeType(this["WarehouseDescriptionDetailID"], typeof(int), true)));
                }
            }

            public virtual int WarehouseDescriptionID
            {
                get
                {
                    return ((int)(ChangeType(this["WarehouseDescriptionID"], typeof(int), true)));
                }
            }

            public virtual short OrdinalNumber
            {
                get
                {
                    return ((short)(ChangeType(this["OrdinalNumber"], typeof(short), true)));
                }
            }

            public virtual int PurchaseOrderID
            {
                get
                {
                    return ((int)(ChangeType(this["PurchaseOrderID"], typeof(int), true)));
                }
            }

            public virtual DateTime OrderDate
            {
                get
                {
                    return ((DateTime)(ChangeType(this["OrderDate"], typeof(DateTime), true)));
                }
            }

            public virtual int ProductID
            {
                get
                {
                    return ((int)(ChangeType(this["ProductID"], typeof(int), true)));
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

            public virtual short UnitsInStock
            {
                get
                {
                    return ((short)(ChangeType(this["UnitsInStock"], typeof(short), true)));
                }
            }

            public virtual string CountryCode
            {
                get
                {
                    return ((string)(ChangeType(this["CountryCode"], typeof(string), true)));
                }
            }

            public virtual int BrandID
            {
                get
                {
                    return ((int)(ChangeType(this["BrandID"], typeof(int), true)));
                }
            }

            public virtual decimal UnitPrice
            {
                get
                {
                    return ((decimal)(ChangeType(this["UnitPrice"], typeof(decimal), true)));
                }
            }

            public virtual decimal Quantity
            {
                get
                {
                    return ((decimal)(ChangeType(this["Quantity"], typeof(decimal), true)));
                }
            }

            public virtual decimal DescrQty
            {
                get
                {
                    return ((decimal)(ChangeType(this["DescrQty"], typeof(decimal), true)));
                }
            }

            public virtual string Comment
            {
                get
                {
                    return ((string)(ChangeType(this["Comment"], typeof(string), true)));
                }
            }

            public virtual decimal _DescrQtyString
            {
                get
                {
                    return ((decimal)(ChangeType(this["_DescrQtyString"], typeof(decimal), true)));
                }
            }

            public virtual int Action
            {
                get
                {
                    return ((int)(ChangeType(this["Action"], typeof(int), true)));
                }
            }

            public virtual ParentSP_GetWarehouseDescriptionHeaderRelation SP_GetWarehouseDescriptionHeader
            {
                get
                {
                    return new ParentSP_GetWarehouseDescriptionHeaderRelation(GetParentData("SP_GetWarehouseDescriptionHeader_SP_GetWarehouseDescriptionDetail"));
                }
            }
        }
        #endregion DataSource SP_GetWarehouseDescriptionDetail
        #endregion StiReport Designer generated code - do not modify
    }
}
