using System;
using System.Drawing;
using System.Drawing.Text;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.BarCodes;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Engine;
using Stimulsoft.Report.Events;
using Stimulsoft.Report.Print;

namespace Reports
{

    public class RptProductBarCode : StiReport
    {

        public RptProductBarCode()
        {
            InitializeComponent();
        }
        #region StiReport Designer generated code - do not modify
        public StiPage Page1;
        public StiHeaderBand HeaderVW_Product;
        public StiText HeaderVW_Product_MedicamentName;
        public StiText Text1;
        public StiDataBand DataVW_Product;
        public StiText DataVW_Product_ProductID;
        public StiBarCode BarCode1;
        public StiFooterBand FooterVW_Product;
        public StiWatermark Page1_Watermark;
        public StiPrinterSettings RptProductBarCode_PrinterSettings;
        public VW_ProductDataSource VW_Product;

        public void HeaderVW_Product_MedicamentName__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "მედიკამენტი";
        }

        public void Text1__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = "შტრიხ-კოდი";
        }

        public void DataVW_Product_ProductID__GetValue(object sender, StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, VW_Product.ProductID, true) + ". " + ToString(sender, VW_Product.MedicamentName, true);
        }

        public void BarCode1__GetBarCode(object sender, StiValueEventArgs e)
        {
            e.Value = "UPC" + VW_Product.ProductID;
        }

        private void InitializeComponent()
        {
            VW_Product = new VW_ProductDataSource();
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
            ReportAlias = "Rpt Product Bar Code";
            // 
            // ReportChanged
            // 
            ReportChanged = new DateTime(2009, 6, 8, 10, 23, 13, 687);
            // 
            // ReportCreated
            // 
            ReportCreated = new DateTime(2009, 3, 24, 21, 40, 37, 0);
            ReportGuid = "17d6a2b4761540d58d5510314b329565";
            ReportName = "RptProductBarCode";
            ReportUnit = StiReportUnitType.Centimeters;
            ScriptLanguage = StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            Page1 = new StiPage();
            Page1.Columns = 2;
            Page1.Guid = "53d0355db4644f9d9ba6c964bafb28f0";
            Page1.Name = "Page1";
            Page1.Orientation = StiPageOrientation.Landscape;
            Page1.PageHeight = 21;
            Page1.PageWidth = 29.7;
            Page1.Border = new StiBorder(StiBorderSides.None, Color.Black, 2, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Page1.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // HeaderVW_Product
            // 
            HeaderVW_Product = new StiHeaderBand();
            HeaderVW_Product.ClientRectangle = new RectangleD(0, 0.4, 13.85, 0.8);
            HeaderVW_Product.Name = "HeaderVW_Product";
            HeaderVW_Product.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_Product.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // HeaderVW_Product_MedicamentName
            // 
            HeaderVW_Product_MedicamentName = new StiText();
            HeaderVW_Product_MedicamentName.ClientRectangle = new RectangleD(0, 0, 6.8, 0.8);
            HeaderVW_Product_MedicamentName.Name = "HeaderVW_Product_MedicamentName";
            HeaderVW_Product_MedicamentName.GetValue += new StiGetValueEventHandler(HeaderVW_Product_MedicamentName__GetValue);
            HeaderVW_Product_MedicamentName.Type = StiSystemTextType.Expression;
            HeaderVW_Product_MedicamentName.VertAlignment = StiVertAlignment.Center;
            HeaderVW_Product_MedicamentName.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            HeaderVW_Product_MedicamentName.Brush = new StiSolidBrush(Color.Transparent);
            HeaderVW_Product_MedicamentName.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            HeaderVW_Product_MedicamentName.Guid = null;
            HeaderVW_Product_MedicamentName.Interaction = null;
            HeaderVW_Product_MedicamentName.Margins = new StiMargins(0, 0, 0, 0);
            HeaderVW_Product_MedicamentName.TextBrush = new StiSolidBrush(Color.Black);
            HeaderVW_Product_MedicamentName.TextOptions = new StiTextOptions(false, false, true, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // Text1
            // 
            Text1 = new StiText();
            Text1.ClientRectangle = new RectangleD(6.8, 0, 7, 0.8);
            Text1.Name = "Text1";
            Text1.GetValue += new StiGetValueEventHandler(Text1__GetValue);
            Text1.Type = StiSystemTextType.Expression;
            Text1.VertAlignment = StiVertAlignment.Center;
            Text1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            Text1.Brush = new StiSolidBrush(Color.Transparent);
            Text1.Font = new Font("BPG Glaho Arial", 10F, FontStyle.Bold);
            Text1.Guid = null;
            Text1.Interaction = null;
            Text1.Margins = new StiMargins(0, 0, 0, 0);
            Text1.TextBrush = new StiSolidBrush(Color.Black);
            Text1.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            HeaderVW_Product.Guid = null;
            HeaderVW_Product.Interaction = null;
            // 
            // DataVW_Product
            // 
            DataVW_Product = new StiDataBand();
            DataVW_Product.ClientRectangle = new RectangleD(0, 2, 13.85, 2);
            DataVW_Product.DataSourceName = "VW_Product";
            DataVW_Product.Name = "DataVW_Product";
            DataVW_Product.Sort = new String[0];
            DataVW_Product.Border = new StiBorder(StiBorderSides.All, Color.Black, 0.5, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataVW_Product.Brush = new StiSolidBrush(Color.Transparent);
            // 
            // DataVW_Product_ProductID
            // 
            DataVW_Product_ProductID = new StiText();
            DataVW_Product_ProductID.CanGrow = true;
            DataVW_Product_ProductID.ClientRectangle = new RectangleD(0, 0, 6.6, 2);
            DataVW_Product_ProductID.GrowToHeight = true;
            DataVW_Product_ProductID.Name = "DataVW_Product_ProductID";
            DataVW_Product_ProductID.GetValue += new StiGetValueEventHandler(DataVW_Product_ProductID__GetValue);
            DataVW_Product_ProductID.Type = StiSystemTextType.Expression;
            DataVW_Product_ProductID.VertAlignment = StiVertAlignment.Center;
            DataVW_Product_ProductID.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            DataVW_Product_ProductID.Brush = new StiSolidBrush(Color.Transparent);
            DataVW_Product_ProductID.Font = new Font("BPG Glaho Arial", 8F);
            DataVW_Product_ProductID.Guid = null;
            DataVW_Product_ProductID.Interaction = null;
            DataVW_Product_ProductID.Margins = new StiMargins(0, 0, 0, 0);
            DataVW_Product_ProductID.TextBrush = new StiSolidBrush(Color.Black);
            DataVW_Product_ProductID.TextOptions = new StiTextOptions(false, false, false, 0F, HotkeyPrefix.None, StringTrimming.None);
            // 
            // BarCode1
            // 
            BarCode1 = new StiBarCode();
            BarCode1.BackColor = Color.White;
            BarCode1.ClientRectangle = new RectangleD(6.8, 0, 7, 2);
            BarCode1.GetBarCode += new StiValueEventHandler(BarCode1__GetBarCode);
            BarCode1.ForeColor = Color.Black;
            BarCode1.Name = "BarCode1";
            BarCode1.VertAlignment = StiVertAlignment.Center;
            BarCode1.BarCodeType = new StiEAN128aBarCodeType(13F, 1F);
            BarCode1.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Dot, false, 4, new StiSolidBrush(Color.Black));
            BarCode1.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Pixel);
            BarCode1.Guid = null;
            BarCode1.Interaction = null;
            DataVW_Product.Guid = null;
            DataVW_Product.Interaction = null;
            DataVW_Product.MasterComponent = null;
            // 
            // FooterVW_Product
            // 
            FooterVW_Product = new StiFooterBand();
            FooterVW_Product.ClientRectangle = new RectangleD(0, 4.8, 13.85, 0.8);
            FooterVW_Product.Name = "FooterVW_Product";
            FooterVW_Product.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black));
            FooterVW_Product.Brush = new StiSolidBrush(Color.Transparent);
            FooterVW_Product.Guid = null;
            FooterVW_Product.Interaction = null;
            Page1.ExcelSheetValue = null;
            Page1.Interaction = null;
            Page1.Margins = new StiMargins(1, 1, 1, 1);
            Page1_Watermark = new StiWatermark();
            Page1_Watermark.Font = new Font("Arial", 100F);
            Page1_Watermark.Image = null;
            Page1_Watermark.TextBrush = new StiSolidBrush(Color.FromArgb(50, 0, 0, 0));
            RptProductBarCode_PrinterSettings = new StiPrinterSettings();
            PrinterSettings = RptProductBarCode_PrinterSettings;
            Page1.Page = Page1;
            Page1.Report = this;
            Page1.Watermark = Page1_Watermark;
            HeaderVW_Product.Page = Page1;
            HeaderVW_Product.Parent = Page1;
            HeaderVW_Product_MedicamentName.Page = Page1;
            HeaderVW_Product_MedicamentName.Parent = HeaderVW_Product;
            Text1.Page = Page1;
            Text1.Parent = HeaderVW_Product;
            DataVW_Product.Page = Page1;
            DataVW_Product.Parent = Page1;
            DataVW_Product_ProductID.Page = Page1;
            DataVW_Product_ProductID.Parent = DataVW_Product;
            BarCode1.Page = Page1;
            BarCode1.Parent = DataVW_Product;
            FooterVW_Product.Page = Page1;
            FooterVW_Product.Parent = Page1;
            // 
            // Add to HeaderVW_Product.Components
            // 
            HeaderVW_Product.Components.Clear();
            HeaderVW_Product.Components.AddRange(new StiComponent[] {
                        HeaderVW_Product_MedicamentName,
                        Text1});
            // 
            // Add to DataVW_Product.Components
            // 
            DataVW_Product.Components.Clear();
            DataVW_Product.Components.AddRange(new StiComponent[] {
                        DataVW_Product_ProductID,
                        BarCode1});
            // 
            // Add to Page1.Components
            // 
            Page1.Components.Clear();
            Page1.Components.AddRange(new StiComponent[] {
                        HeaderVW_Product,
                        DataVW_Product,
                        FooterVW_Product});
            // 
            // Add to Pages
            // 
            Pages.Clear();
            Pages.AddRange(new[] {
                        Page1});
            VW_Product.Columns.AddRange(new[] {
                        new StiDataColumn("ProductID", "ProductID", "ProductID", typeof(int)),
                        new StiDataColumn("PurchaseOrderDetailID", "PurchaseOrderDetailID", "PurchaseOrderDetailID", typeof(Guid)),
                        new StiDataColumn("MedicamentCategoryID", "MedicamentCategoryID", "MedicamentCategoryID", typeof(int)),
                        new StiDataColumn("MedicamentCategoryName", "MedicamentCategoryName", "MedicamentCategoryName", typeof(string)),
                        new StiDataColumn("MedicamentSubcategoryID", "MedicamentSubcategoryID", "MedicamentSubcategoryID", typeof(int)),
                        new StiDataColumn("MedicamentSubcategoryName", "MedicamentSubcategoryName", "MedicamentSubcategoryName", typeof(string)),
                        new StiDataColumn("MedicamentID", "MedicamentID", "MedicamentID", typeof(int)),
                        new StiDataColumn("MedicamentName", "MedicamentName", "MedicamentName", typeof(string)),
                        new StiDataColumn("Serie", "Serie", "Serie", typeof(string)),
                        new StiDataColumn("PurchaseUnitPriceCU", "PurchaseUnitPriceCU", "PurchaseUnitPriceCU", typeof(decimal)),
                        new StiDataColumn("SaleUnitPriceCU", "SaleUnitPriceCU", "SaleUnitPriceCU", typeof(decimal)),
                        new StiDataColumn("Quantity", "Quantity", "Quantity", typeof(decimal)),
                        new StiDataColumn("UnitsInStock", "UnitsInStock", "UnitsInStock", typeof(decimal)),
                        new StiDataColumn("FinishedGoodsFlag", "FinishedGoodsFlag", "FinishedGoodsFlag", typeof(bool)),
                        new StiDataColumn("SafetyStockLevel", "SafetyStockLevel", "SafetyStockLevel", typeof(short)),
                        new StiDataColumn("ValidDate", "ValidDate", "ValidDate", typeof(DateTime)),
                        new StiDataColumn("Color", "Color", "Color", typeof(string)),
                        new StiDataColumn("CountryCode", "CountryCode", "CountryCode", typeof(string)),
                        new StiDataColumn("CountryName", "CountryName", "CountryName", typeof(string)),
                        new StiDataColumn("Size", "Size", "Size", typeof(string)),
                        new StiDataColumn("SizeUnitMeasureCode", "SizeUnitMeasureCode", "SizeUnitMeasureCode", typeof(string)),
                        new StiDataColumn("Weight", "Weight", "Weight", typeof(decimal)),
                        new StiDataColumn("WeightUnitMeasureCode", "WeightUnitMeasureCode", "WeightUnitMeasureCode", typeof(string)),
                        new StiDataColumn("Class", "Class", "Class", typeof(string)),
                        new StiDataColumn("Style", "Style", "Style", typeof(string)),
                        new StiDataColumn("SellStartDate", "SellStartDate", "SellStartDate", typeof(DateTime)),
                        new StiDataColumn("SellEndDate", "SellEndDate", "SellEndDate", typeof(DateTime)),
                        new StiDataColumn("DiscontinuedDate", "DiscontinuedDate", "DiscontinuedDate", typeof(DateTime)),
                        new StiDataColumn("Status", "Status", "Status", typeof(byte)),
                        new StiDataColumn("ModifiedUserID", "ModifiedUserID", "ModifiedUserID", typeof(int)),
                        new StiDataColumn("Modifier", "Modifier", "Modifier", typeof(string)),
                        new StiDataColumn("ModifiedDate", "ModifiedDate", "ModifiedDate", typeof(DateTime)),
                        new StiDataColumn("PurchaseUnitPrice", "PurchaseUnitPrice", "PurchaseUnitPrice", typeof(decimal)),
                        new StiDataColumn("SaleUnitPrice", "SaleUnitPrice", "SaleUnitPrice", typeof(decimal)),
                        new StiDataColumn("Action", "Action", "Action", typeof(int))});
            DataSources.Add(VW_Product);
        }

        #region DataSource VW_Product
        public class VW_ProductDataSource : StiDataTableSource
        {

            public VW_ProductDataSource() :
                base("DS_Production.VW_Product", "VW_Product")
            {
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

            public virtual string Serie
            {
                get
                {
                    return ((string)(ChangeType(this["Serie"], typeof(string), true)));
                }
            }

            public virtual decimal PurchaseUnitPriceCU
            {
                get
                {
                    return ((decimal)(ChangeType(this["PurchaseUnitPriceCU"], typeof(decimal), true)));
                }
            }

            public virtual decimal SaleUnitPriceCU
            {
                get
                {
                    return ((decimal)(ChangeType(this["SaleUnitPriceCU"], typeof(decimal), true)));
                }
            }

            public virtual decimal Quantity
            {
                get
                {
                    return ((decimal)(ChangeType(this["Quantity"], typeof(decimal), true)));
                }
            }

            public virtual decimal UnitsInStock
            {
                get
                {
                    return ((decimal)(ChangeType(this["UnitsInStock"], typeof(decimal), true)));
                }
            }

            public virtual bool FinishedGoodsFlag
            {
                get
                {
                    return ((bool)(ChangeType(this["FinishedGoodsFlag"], typeof(bool), true)));
                }
            }

            public virtual short SafetyStockLevel
            {
                get
                {
                    return ((short)(ChangeType(this["SafetyStockLevel"], typeof(short), true)));
                }
            }

            public virtual DateTime ValidDate
            {
                get
                {
                    return ((DateTime)(ChangeType(this["ValidDate"], typeof(DateTime), true)));
                }
            }

            public virtual string Color
            {
                get
                {
                    return ((string)(ChangeType(this["Color"], typeof(string), true)));
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

            public virtual string Size
            {
                get
                {
                    return ((string)(ChangeType(this["Size"], typeof(string), true)));
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

            public virtual decimal PurchaseUnitPrice
            {
                get
                {
                    return ((decimal)(ChangeType(this["PurchaseUnitPrice"], typeof(decimal), true)));
                }
            }

            public virtual decimal SaleUnitPrice
            {
                get
                {
                    return ((decimal)(ChangeType(this["SaleUnitPrice"], typeof(decimal), true)));
                }
            }

            public virtual int Action
            {
                get
                {
                    return ((int)(ChangeType(this["Action"], typeof(int), true)));
                }
            }
        }
        #endregion DataSource VW_Product
        #endregion StiReport Designer generated code - do not modify
    }
}
