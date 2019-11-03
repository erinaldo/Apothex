using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Engine;
using Stimulsoft.Report.Events;
using Stimulsoft.Report.Print;

namespace Reports
{

    public class RptCountry : StiReport
    {

        public RptCountry()
        {
            InitializeComponent();
        }
        #region StiReport Designer generated code - do not modify
        public StiPage Page1;
        public StiReportTitleBand ReportTitle;
        public StiText ReportTitleText;
        public StiHeaderBand Header;
        public StiText HeaderText1;
        public StiText HeaderText2;
        public StiDataBand DataVW_Country;
        public StiText DataText1;
        public StiText DataText2;
        public StiFooterBand Footer;
        public StiWatermark Page1_Watermark;
        public StiPrinterSettings RptCountry_PrinterSettings;
        public VW_CountryDataSource VW_Country;

        public void ReportTitleText__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ქვეყნების სია";
        }

        public void HeaderText1__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "კოდი";
        }

        public void HeaderText2__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "ქვეყანა";
        }

        public void DataText1__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, VW_Country.CountryCode, true);
        }

        public void DataText2__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, VW_Country.Name, true);
        }

        private void InitializeComponent()
        {
            VW_Country = new VW_CountryDataSource();
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
            ReportAlias = "Rpt Country";
            // 
            // ReportChanged
            // 
            ReportChanged = new DateTime(2009, 2, 7, 14, 30, 56, 0);
            // 
            // ReportCreated
            // 
            ReportCreated = new DateTime(2008, 9, 2, 21, 7, 22, 0);
            ReportFile = "D:\\User\\Documents\\Projects\\Apothex\\Source\\Class Library\\Apothex.Reporting\\Dictionary\\RptCountry.mrt";
            ReportGuid = "af5c1e936cdf4e129cbdeae2455e3cea";
            ReportName = "RptCountry";
            ReportUnit = StiReportUnitType.Centimeters;
            ReportVersion = "2008.2.300";
            ScriptLanguage = StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            Page1 = new StiPage();
            Page1.ColumnGaps = 1;
            Page1.Columns = 2;
            Page1.ColumnWidth = 9;
            Page1.Guid = "cace94e76442472aa8acc7b42034809c";
            Page1.Name = "Page1";
            Page1.PageHeight = 29.7;
            Page1.PageWidth = 21;
            Page1.PaperSize = PaperKind.A4;
            Page1.Border = new StiBorder(StiBorderSides.None, Color.Black, 2, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
            Page1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // ReportTitle
            // 
            ReportTitle = new StiReportTitleBand();
            ReportTitle.ClientRectangle = new RectangleD(0, 0.4, 9, 0.8);
            ReportTitle.Name = "ReportTitle";
            ReportTitle.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
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
            ReportTitleText.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
            ReportTitleText.Brush = new StiSolidBrush(Color.Transparent);
            ReportTitleText.Font = new Font("BPG Glaho Arial", 12F, FontStyle.Bold);
            ReportTitleText.Guid = null;
            ReportTitleText.Indicator = null;
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
            Header.ClientRectangle = new RectangleD(0, 2, 9, 0.8);
            Header.Name = "Header";
            Header.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
            Header.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // HeaderText1
            // 
            HeaderText1 = new StiText();
            HeaderText1.ClientRectangle = new RectangleD(0, 0, 2, 0.8);
            HeaderText1.Name = "HeaderText1";
            HeaderText1.GetValue += new StiGetValueEventHandler(HeaderText1__GetValue);
            HeaderText1.Type = StiSystemTextType.Expression;
            HeaderText1.VertAlignment = StiVertAlignment.Center;
            HeaderText1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
            HeaderText1.Brush = new StiSolidBrush(Color.Transparent);
            HeaderText1.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderText1.Guid = null;
            HeaderText1.Indicator = null;
            HeaderText1.Interaction = null;
            HeaderText1.Margins = new StiMargins(0, 0, 0, 0);
            HeaderText1.TextBrush = new StiSolidBrush(Color.Black);
            HeaderText1.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // HeaderText2
            // 
            HeaderText2 = new StiText();
            HeaderText2.ClientRectangle = new RectangleD(2, 0, 7, 0.8);
            HeaderText2.Name = "HeaderText2";
            HeaderText2.GetValue += new StiGetValueEventHandler(HeaderText2__GetValue);
            HeaderText2.Type = StiSystemTextType.Expression;
            HeaderText2.VertAlignment = StiVertAlignment.Center;
            HeaderText2.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
            HeaderText2.Brush = new StiSolidBrush(Color.Transparent);
            HeaderText2.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderText2.Guid = null;
            HeaderText2.Indicator = null;
            HeaderText2.Interaction = null;
            HeaderText2.Margins = new StiMargins(0, 0, 0, 0);
            HeaderText2.TextBrush = new StiSolidBrush(Color.Black);
            HeaderText2.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            Header.Guid = null;
            Header.Interaction = null;
            // 
            // DataVW_Country
            // 
            DataVW_Country = new StiDataBand();
            DataVW_Country.ClientRectangle = new RectangleD(0, 3.6, 9, 0.6);
            DataVW_Country.DataSourceName = "VW_Country";
            DataVW_Country.Name = "DataVW_Country";
            DataVW_Country.Sort = new[] {
                    "ASC",
                    "CountryCode"};
            DataVW_Country.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
            DataVW_Country.Brush = new StiSolidBrush(Color.Transparent);
            DataVW_Country.BusinessObjectGuid = null;
            // 
            // DataText1
            // 
            DataText1 = new StiText();
            DataText1.ClientRectangle = new RectangleD(0, 0, 2, 0.6);
            DataText1.GrowToHeight = true;
            DataText1.Name = "DataText1";
            DataText1.GetValue += new StiGetValueEventHandler(DataText1__GetValue);
            DataText1.Type = StiSystemTextType.Expression;
            DataText1.VertAlignment = StiVertAlignment.Center;
            DataText1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
            DataText1.Brush = new StiSolidBrush(Color.Transparent);
            DataText1.Font = new Font("BPG Glaho Arial", 10F);
            DataText1.Guid = null;
            DataText1.Indicator = null;
            DataText1.Interaction = null;
            DataText1.Margins = new StiMargins(0, 0, 0, 0);
            DataText1.TextBrush = new StiSolidBrush(Color.Black);
            DataText1.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // DataText2
            // 
            DataText2 = new StiText();
            DataText2.CanGrow = true;
            DataText2.ClientRectangle = new RectangleD(2, 0, 7, 0.6);
            DataText2.Name = "DataText2";
            DataText2.GetValue += new StiGetValueEventHandler(DataText2__GetValue);
            DataText2.Type = StiSystemTextType.Expression;
            DataText2.VertAlignment = StiVertAlignment.Center;
            DataText2.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
            DataText2.Brush = new StiSolidBrush(Color.Transparent);
            DataText2.Font = new Font("BPG Glaho Arial", 10F);
            DataText2.Guid = null;
            DataText2.Indicator = null;
            DataText2.Interaction = null;
            DataText2.Margins = new StiMargins(0, 0, 0, 0);
            DataText2.TextBrush = new StiSolidBrush(Color.Black);
            DataText2.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            DataVW_Country.Guid = null;
            DataVW_Country.Interaction = null;
            DataVW_Country.MasterComponent = null;
            // 
            // Footer
            // 
            Footer = new StiFooterBand();
            Footer.ClientRectangle = new RectangleD(0, 5, 9, 0.6);
            Footer.Name = "Footer";
            Footer.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
            Footer.Brush = new StiSolidBrush(Color.Transparent);
            Footer.Guid = null;
            Footer.Interaction = null;
            Page1.ExcelSheetValue = null;
            Page1.Interaction = null;
            Page1.Margins = new StiMargins(1, 1, 1, 1);
            Page1_Watermark = new StiWatermark();
            Page1_Watermark.Font = new Font("Arial", 100F);
            Page1_Watermark.Image = null;
            Page1_Watermark.TextBrush = new StiSolidBrush(Color.FromArgb(50, 0, 0, 0));
            RptCountry_PrinterSettings = new StiPrinterSettings();
            PrinterSettings = RptCountry_PrinterSettings;
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
            DataVW_Country.Page = Page1;
            DataVW_Country.Parent = Page1;
            DataText1.Page = Page1;
            DataText1.Parent = DataVW_Country;
            DataText2.Page = Page1;
            DataText2.Parent = DataVW_Country;
            Footer.Page = Page1;
            Footer.Parent = Page1;
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
                        HeaderText2});
            // 
            // Add to DataVW_Country.Components
            // 
            DataVW_Country.Components.Clear();
            DataVW_Country.Components.AddRange(new StiComponent[] {
                        DataText1,
                        DataText2});
            // 
            // Add to Page1.Components
            // 
            Page1.Components.Clear();
            Page1.Components.AddRange(new StiComponent[] {
                        ReportTitle,
                        Header,
                        DataVW_Country,
                        Footer});
            // 
            // Add to Pages
            // 
            Pages.Clear();
            Pages.AddRange(new[] {
                        Page1});
            VW_Country.Columns.AddRange(new[] {
                        new StiDataColumn("Approver", "Approver", "Approver", typeof(string)),
                        new StiDataColumn("ApproverUserID", "ApproverUserID", "ApproverUserID", typeof(int)),
                        new StiDataColumn("CountryCode", "CountryCode", "CountryCode", typeof(string)),
                        new StiDataColumn("ModifiedDate", "ModifiedDate", "ModifiedDate", typeof(DateTime)),
                        new StiDataColumn("ModifiedUserID", "ModifiedUserID", "ModifiedUserID", typeof(int)),
                        new StiDataColumn("Modifier", "Modifier", "Modifier", typeof(string)),
                        new StiDataColumn("Name", "Name", "Name", typeof(string)),
                        new StiDataColumn("Status", "Status", "Status", typeof(byte))});
            DataSources.Add(VW_Country);
        }

        #region DataSource VW_Country
        public class VW_CountryDataSource : StiDataTableSource
        {

            public VW_CountryDataSource() :
                base("DS_Dictionary.VW_Country", "VW_Country")
            {
            }

            public virtual string Approver
            {
                get
                {
                    return ((string)(ChangeType(this["Approver"], typeof(string), true)));
                }
            }

            public virtual int ApproverUserID
            {
                get
                {
                    return ((int)(ChangeType(this["ApproverUserID"], typeof(int), true)));
                }
            }

            public virtual string CountryCode
            {
                get
                {
                    return ((string)(ChangeType(this["CountryCode"], typeof(string), true)));
                }
            }

            public virtual DateTime ModifiedDate
            {
                get
                {
                    return ((DateTime)(ChangeType(this["ModifiedDate"], typeof(DateTime), true)));
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

            public new virtual string Name
            {
                get
                {
                    return ((string)(ChangeType(this["Name"], typeof(string), true)));
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
        #endregion DataSource VW_Country
        #endregion StiReport Designer generated code - do not modify
    }
}