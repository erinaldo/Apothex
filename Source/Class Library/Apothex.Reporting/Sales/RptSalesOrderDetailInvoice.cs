
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Controls;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Dialogs;
using Stimulsoft.Report.Components;

namespace Reports
{

    public class RptSalesOrderDetailInvoice : Stimulsoft.Report.StiReport
    {

        public RptSalesOrderDetailInvoice()
        {
            this.InitializeComponent();
        }
        #region StiReport Designer generated code - do not modify
        public Stimulsoft.Report.Dictionary.StiDataRelation ParentSP_GetRptSalesOrderHeader;
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
        public Stimulsoft.Report.Components.StiPage Page1;
        public Stimulsoft.Report.Components.StiDataBand DataSP_GetRptSalesOrderHeader;
        public Stimulsoft.Report.Components.StiText DataSP_GetRptSalesOrderHeader_SalesOrderID;
        public Stimulsoft.Report.Components.StiPanel Panel2;
        public Stimulsoft.Report.Components.StiText Text8;
        public Stimulsoft.Report.Components.StiText Text10;
        public Stimulsoft.Report.Components.StiText Text11;
        public Stimulsoft.Report.Components.StiText Text12;
        public Stimulsoft.Report.Components.StiText Text13;
        public Stimulsoft.Report.Components.StiText Text14;
        public Stimulsoft.Report.Components.StiText Text15;
        public Stimulsoft.Report.Components.StiPanel Panel1;
        public Stimulsoft.Report.Components.StiText Text9;
        public Stimulsoft.Report.Components.StiText Text2;
        public Stimulsoft.Report.Components.StiPanel Panel3;
        public Stimulsoft.Report.Components.StiText Text16;
        public Stimulsoft.Report.Components.StiText Text17;
        public Stimulsoft.Report.Components.StiText Text18;
        public Stimulsoft.Report.Components.StiPanel Panel4;
        public Stimulsoft.Report.Components.StiTextInCells TextInCells1;
        public Stimulsoft.Report.Components.StiText Text19;
        public Stimulsoft.Report.Components.StiText Text20;
        public Stimulsoft.Report.Components.StiPanel Panel6;
        public Stimulsoft.Report.Components.StiTextInCells TextInCells2;
        public Stimulsoft.Report.Components.StiText Text25;
        public Stimulsoft.Report.Components.StiText Text24;
        public Stimulsoft.Report.Components.StiPanel Panel5;
        public Stimulsoft.Report.Components.StiText Text23;
        public Stimulsoft.Report.Components.StiText Text22;
        public Stimulsoft.Report.Components.StiText Text21;
        public Stimulsoft.Report.Components.StiPanel Panel7;
        public Stimulsoft.Report.Components.StiText Text26;
        public Stimulsoft.Report.Components.StiText Text27;
        public Stimulsoft.Report.Components.StiPanel Panel8;
        public Stimulsoft.Report.Components.StiText Text28;
        public Stimulsoft.Report.Components.StiText Text29;
        public Stimulsoft.Report.Components.StiPanel Panel9;
        public Stimulsoft.Report.Components.StiText Text1;
        public Stimulsoft.Report.Components.StiText Text30;
        public Stimulsoft.Report.Components.StiText Text31;
        public Stimulsoft.Report.Components.StiPanel Panel10;
        public Stimulsoft.Report.Components.StiTextInCells TextInCells3;
        public Stimulsoft.Report.Components.StiText Text32;
        public Stimulsoft.Report.Components.StiText Text33;
        public Stimulsoft.Report.Components.StiPanel Panel11;
        public Stimulsoft.Report.Components.StiText Text34;
        public Stimulsoft.Report.Components.StiText Text35;
        public Stimulsoft.Report.Components.StiPanel Panel12;
        public Stimulsoft.Report.Components.StiTextInCells TextInCells4;
        public Stimulsoft.Report.Components.StiText Text36;
        public Stimulsoft.Report.Components.StiText Text37;
        public Stimulsoft.Report.Components.StiPanel Panel13;
        public Stimulsoft.Report.Components.StiText Text38;
        public Stimulsoft.Report.Components.StiText Text39;
        public Stimulsoft.Report.Components.StiText Text40;
        public Stimulsoft.Report.Components.StiPanel Panel14;
        public Stimulsoft.Report.Components.StiText Text41;
        public Stimulsoft.Report.Components.StiText Text42;
        public Stimulsoft.Report.Components.StiPanel Panel15;
        public Stimulsoft.Report.Components.StiText Text43;
        public Stimulsoft.Report.Components.StiText Text44;
        public Stimulsoft.Report.Components.StiText Text45;
        public Stimulsoft.Report.Components.StiPanel Panel16;
        public Stimulsoft.Report.Components.StiTextInCells TextInCells5;
        public Stimulsoft.Report.Components.StiText Text46;
        public Stimulsoft.Report.Components.StiText Text47;
        public Stimulsoft.Report.Components.StiPanel Panel17;
        public Stimulsoft.Report.Components.StiText Text48;
        public Stimulsoft.Report.Components.StiText Text49;
        public Stimulsoft.Report.Components.StiText Text50;
        public Stimulsoft.Report.Components.StiPanel Panel18;
        public Stimulsoft.Report.Components.StiText Text51;
        public Stimulsoft.Report.Components.StiText Text52;
        public Stimulsoft.Report.Components.StiText Text53;
        public Stimulsoft.Report.Components.StiText Text54;
        public Stimulsoft.Report.Components.StiText Text55;
        public Stimulsoft.Report.Components.StiText Text56;
        public Stimulsoft.Report.Components.StiPanel Panel19;
        public Stimulsoft.Report.Components.StiText Text57;
        public Stimulsoft.Report.Components.StiText Text59;
        public Stimulsoft.Report.Components.StiPanel Panel20;
        public Stimulsoft.Report.Components.StiTextInCells TextInCells6;
        public Stimulsoft.Report.Components.StiText Text58;
        public Stimulsoft.Report.Components.StiText Text60;
        public Stimulsoft.Report.Components.StiPanel Panel21;
        public Stimulsoft.Report.Components.StiText Text61;
        public Stimulsoft.Report.Components.StiText Text62;
        public Stimulsoft.Report.Components.StiText Text63;
        public Stimulsoft.Report.Components.StiText Text64;
        public Stimulsoft.Report.Components.StiPanel Panel22;
        public Stimulsoft.Report.Components.StiTextInCells TextInCells7;
        public Stimulsoft.Report.Components.StiText Text65;
        public Stimulsoft.Report.Components.StiText Text66;
        public Stimulsoft.Report.Components.StiHeaderBand HeaderSP_GetSalesOrderDetail;
        public Stimulsoft.Report.Components.StiText Text67;
        public Stimulsoft.Report.Components.StiText Text68;
        public Stimulsoft.Report.Components.StiText Text69;
        public Stimulsoft.Report.Components.StiText Text70;
        public Stimulsoft.Report.Components.StiText Text71;
        public Stimulsoft.Report.Components.StiText Text72;
        public Stimulsoft.Report.Components.StiText Text73;
        public Stimulsoft.Report.Components.StiText Text74;
        public Stimulsoft.Report.Components.StiText Text75;
        public Stimulsoft.Report.Components.StiText Text76;
        public Stimulsoft.Report.Components.StiText Text77;
        public Stimulsoft.Report.Components.StiText Text78;
        public Stimulsoft.Report.Components.StiText Text79;
        public Stimulsoft.Report.Components.StiText Text80;
        public Stimulsoft.Report.Components.StiText Text81;
        public Stimulsoft.Report.Components.StiText Text82;
        public Stimulsoft.Report.Components.StiText Text83;
        public Stimulsoft.Report.Components.StiText Text84;
        public Stimulsoft.Report.Components.StiText Text85;
        public Stimulsoft.Report.Components.StiText Text86;
        public Stimulsoft.Report.Components.StiDataBand DataSP_GetSalesOrderDetail;
        public Stimulsoft.Report.Components.StiText Text87;
        public Stimulsoft.Report.Components.StiText Text88;
        public Stimulsoft.Report.Components.StiText Text89;
        public Stimulsoft.Report.Components.StiText Text90;
        public Stimulsoft.Report.Components.StiText Text91;
        public Stimulsoft.Report.Components.StiText Text92;
        public Stimulsoft.Report.Components.StiText Text93;
        public Stimulsoft.Report.Components.StiText Text94;
        public Stimulsoft.Report.Components.StiText Text95;
        public Stimulsoft.Report.Components.StiText Text96;
        public Stimulsoft.Report.Components.StiHeaderBand HeaderEnclosureText;
        public Stimulsoft.Report.Components.StiText Text180;
        public Stimulsoft.Report.Components.StiText Text181;
        public Stimulsoft.Report.Components.StiText Text182;
        public Stimulsoft.Report.Components.StiText Text183;
        public Stimulsoft.Report.Components.StiText Text184;
        public Stimulsoft.Report.Components.StiText Text185;
        public Stimulsoft.Report.Components.StiText Text186;
        public Stimulsoft.Report.Components.StiText Text187;
        public Stimulsoft.Report.Components.StiText Text188;
        public Stimulsoft.Report.Components.StiText Text189;
        public Stimulsoft.Report.Components.StiText Text190;
        public Stimulsoft.Report.Components.StiText Text191;
        public Stimulsoft.Report.Components.StiText Text192;
        public Stimulsoft.Report.Components.StiText Text193;
        public Stimulsoft.Report.Components.StiText Text194;
        public Stimulsoft.Report.Components.StiText Text195;
        public Stimulsoft.Report.Components.StiText Text196;
        public Stimulsoft.Report.Components.StiText Text197;
        public Stimulsoft.Report.Components.StiText Text198;
        public Stimulsoft.Report.Components.StiText Text199;
        public Stimulsoft.Report.Components.StiText Text200;
        public Stimulsoft.Report.Components.StiText Text201;
        public Stimulsoft.Report.Components.StiText Text202;
        public Stimulsoft.Report.Components.StiText Text203;
        public Stimulsoft.Report.Components.StiText Text204;
        public Stimulsoft.Report.Components.StiText Text205;
        public Stimulsoft.Report.Components.StiText Text206;
        public Stimulsoft.Report.Components.StiText Text207;
        public Stimulsoft.Report.Components.StiText Text208;
        public Stimulsoft.Report.Components.StiText Text209;
        public Stimulsoft.Report.Components.StiDataBand DataEmptyRow;
        public Stimulsoft.Report.Components.StiText Text210;
        public Stimulsoft.Report.Components.StiText Text211;
        public Stimulsoft.Report.Components.StiText Text212;
        public Stimulsoft.Report.Components.StiText Text213;
        public Stimulsoft.Report.Components.StiText Text214;
        public Stimulsoft.Report.Components.StiText Text215;
        public Stimulsoft.Report.Components.StiText Text216;
        public Stimulsoft.Report.Components.StiText Text217;
        public Stimulsoft.Report.Components.StiText Text218;
        public Stimulsoft.Report.Components.StiText Text219;
        public Stimulsoft.Report.Components.StiFooterBand FooterSP_GetSalesOrderDetail;
        public Stimulsoft.Report.Components.StiText Text3;
        public Stimulsoft.Report.Components.StiText Text4;
        public Stimulsoft.Report.Components.StiText Text97;
        public Stimulsoft.Report.Components.StiText Text98;
        public Stimulsoft.Report.Components.StiText Text99;
        public Stimulsoft.Report.Components.StiText Text100;
        public Stimulsoft.Report.Components.StiText Text101;
        public Stimulsoft.Report.Components.StiText Text102;
        public Stimulsoft.Report.Components.StiPanel Panel23;
        public Stimulsoft.Report.Components.StiText Text103;
        public Stimulsoft.Report.Components.StiText Text104;
        public Stimulsoft.Report.Components.StiText Text5;
        public Stimulsoft.Report.Components.StiPanel Panel24;
        public Stimulsoft.Report.Components.StiText Text6;
        public Stimulsoft.Report.Components.StiText Text7;
        public Stimulsoft.Report.Components.StiPanel Panel25;
        public Stimulsoft.Report.Components.StiText Text105;
        public Stimulsoft.Report.Components.StiText Text106;
        public Stimulsoft.Report.Components.StiText Text107;
        public Stimulsoft.Report.Components.StiPanel Panel26;
        public Stimulsoft.Report.Components.StiText Text108;
        public Stimulsoft.Report.Components.StiText Text109;
        public Stimulsoft.Report.Components.StiText Text110;
        public Stimulsoft.Report.Components.StiPanel Panel27;
        public Stimulsoft.Report.Components.StiText Text111;
        public Stimulsoft.Report.Components.StiText Text112;
        public Stimulsoft.Report.Components.StiText Text113;
        public Stimulsoft.Report.Components.StiPanel Panel28;
        public Stimulsoft.Report.Components.StiText Text114;
        public Stimulsoft.Report.Components.StiText Text115;
        public Stimulsoft.Report.Components.StiText Text116;
        public Stimulsoft.Report.Components.StiPanel Panel29;
        public Stimulsoft.Report.Components.StiText Text117;
        public Stimulsoft.Report.Components.StiText Text118;
        public Stimulsoft.Report.Components.StiText Text119;
        public Stimulsoft.Report.Components.StiPanel Panel30;
        public Stimulsoft.Report.Components.StiText Text120;
        public Stimulsoft.Report.Components.StiText Text121;
        public Stimulsoft.Report.Components.StiText Text122;
        public Stimulsoft.Report.Components.StiPanel Panel33;
        public Stimulsoft.Report.Components.StiText Text129;
        public Stimulsoft.Report.Components.StiText Text130;
        public Stimulsoft.Report.Components.StiText Text131;
        public Stimulsoft.Report.Components.StiPanel Panel31;
        public Stimulsoft.Report.Components.StiPanel Panel32;
        public Stimulsoft.Report.Components.StiText Text126;
        public Stimulsoft.Report.Components.StiText Text127;
        public Stimulsoft.Report.Components.StiText Text124;
        public Stimulsoft.Report.Components.StiText Text125;
        public Stimulsoft.Report.Components.StiText Text128;
        public Stimulsoft.Report.Components.StiWatermark Page1_Watermark;
        public Stimulsoft.Report.Components.StiPage Page2;
        public Stimulsoft.Report.Components.StiDataBand Data1;
        public Stimulsoft.Report.Components.StiText Text123;
        public Stimulsoft.Report.Components.StiText Text132;
        public Stimulsoft.Report.Components.StiPanel Panel34;
        public Stimulsoft.Report.Components.StiText Text133;
        public Stimulsoft.Report.Components.StiText Text134;
        public Stimulsoft.Report.Components.StiText Text135;
        public Stimulsoft.Report.Components.StiText Text136;
        public Stimulsoft.Report.Components.StiText Text137;
        public Stimulsoft.Report.Components.StiText Text138;
        public Stimulsoft.Report.Components.StiText Text139;
        public Stimulsoft.Report.Components.StiHeaderBand Header1;
        public Stimulsoft.Report.Components.StiText Text140;
        public Stimulsoft.Report.Components.StiText Text141;
        public Stimulsoft.Report.Components.StiText Text142;
        public Stimulsoft.Report.Components.StiText Text143;
        public Stimulsoft.Report.Components.StiText Text144;
        public Stimulsoft.Report.Components.StiText Text145;
        public Stimulsoft.Report.Components.StiText Text146;
        public Stimulsoft.Report.Components.StiText Text147;
        public Stimulsoft.Report.Components.StiText Text148;
        public Stimulsoft.Report.Components.StiText Text149;
        public Stimulsoft.Report.Components.StiText Text150;
        public Stimulsoft.Report.Components.StiText Text151;
        public Stimulsoft.Report.Components.StiText Text152;
        public Stimulsoft.Report.Components.StiText Text153;
        public Stimulsoft.Report.Components.StiText Text154;
        public Stimulsoft.Report.Components.StiText Text155;
        public Stimulsoft.Report.Components.StiText Text156;
        public Stimulsoft.Report.Components.StiText Text157;
        public Stimulsoft.Report.Components.StiText Text158;
        public Stimulsoft.Report.Components.StiText Text159;
        public Stimulsoft.Report.Components.StiDataBand DataEnclosure;
        public Stimulsoft.Report.Components.StiText Text160;
        public Stimulsoft.Report.Components.StiText Text161;
        public Stimulsoft.Report.Components.StiText Text162;
        public Stimulsoft.Report.Components.StiText Text163;
        public Stimulsoft.Report.Components.StiText Text164;
        public Stimulsoft.Report.Components.StiText Text165;
        public Stimulsoft.Report.Components.StiText Text166;
        public Stimulsoft.Report.Components.StiText Text167;
        public Stimulsoft.Report.Components.StiText Text168;
        public Stimulsoft.Report.Components.StiText Text169;
        public Stimulsoft.Report.Components.StiFooterBand Footer1;
        public Stimulsoft.Report.Components.StiText Text170;
        public Stimulsoft.Report.Components.StiText Text171;
        public Stimulsoft.Report.Components.StiText Text172;
        public Stimulsoft.Report.Components.StiText Text173;
        public Stimulsoft.Report.Components.StiPanel Panel35;
        public Stimulsoft.Report.Components.StiText Text174;
        public Stimulsoft.Report.Components.StiText Text175;
        public Stimulsoft.Report.Components.StiText Text176;
        public Stimulsoft.Report.Components.StiPanel Panel36;
        public Stimulsoft.Report.Components.StiText Text177;
        public Stimulsoft.Report.Components.StiText Text178;
        public Stimulsoft.Report.Components.StiText Text179;
        public Stimulsoft.Report.Components.StiWatermark Page2_Watermark;
        public Stimulsoft.Report.Print.StiPrinterSettings RptSalesOrderDetailInvoice_PrinterSettings;
        public SP_GetRptSalesOrderHeaderDataSource SP_GetRptSalesOrderHeader;
        public SP_GetSalesOrderDetailDataSource SP_GetSalesOrderDetail;

        public void DataSP_GetRptSalesOrderHeader_SalesOrderID__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "სასაქონლო ზედნადები № " + ToString(sender, SP_GetRptSalesOrderHeader.SalesOrderID, true);
        }

        public void Text8__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "2";
        }

        public void Text10__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Stimulsoft.Report.Dictionary.StiFunctionsDate.Day(SP_GetRptSalesOrderHeader.OrderDate), true);
        }

        public void Text11__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Zek.Core.DateTimeHelper.DateToMonth(SP_GetRptSalesOrderHeader.OrderDate), true);
        }

        public void Text12__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Stimulsoft.Report.Dictionary.StiFunctionsDate.Year(SP_GetRptSalesOrderHeader.OrderDate), true);
        }

        public void Text13__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "რიცხვი";
        }

        public void Text14__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "თვე (სიტყვიერად)";
        }

        public void Text15__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "წელი";
        }

        public void Text9__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "ეგზემპლარი";
        }

        public void Text2__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1";
        }

        public void Text16__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, MyCompanyName, true);
        }

        public void Text17__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "გამყიდველის";
        }

        public void Text18__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "დასახელება ან სახელი\r\nდა გვარი\r\n                  ";
        }

        public void TextInCells1__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, MyCompanyTaxCode, true);
        }

        public void Text19__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "3";
        }

        public void Text20__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "საიდენტიფიკაციო ნომერი";
        }

        public void TextInCells2__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetRptSalesOrderHeader.CustomerTaxCode, true);
        }

        public void Text25__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "საიდენტიფიკაციო ნომერი";
        }

        public void Text24__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "4";
        }

        public void Text23__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "დასახელება ან სახელი\r\nდა გვარი\r\n                  ";
        }

        public void Text22__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "მყიდველის";
        }

        public void Text21__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetRptSalesOrderHeader.CustomerName, true);
        }

        public void Text26__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, MyCompanyCity, true) + " " + ToString(sender, MyCompanyAddress, true) + " " + ToString(sender, MyCompanyPhone, true);
        }

        public void Text27__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "მისამართი, ტელეფონი";
        }

        public void Text28__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetRptSalesOrderHeader.CustomerAddress, true) + " " + ToString(sender, SP_GetRptSalesOrderHeader.CustomerPhone, true);
        }

        public void Text29__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "მისამართი, ტელეფონი";
        }

        public void Text1__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, MyCompanyName, true);
        }

        public void Text30__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "ტვირთის გამგზავნის";
        }

        public void Text31__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "დასახელება ან სახელი";
        }

        public void TextInCells3__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, MyCompanyTaxCode, true);
        }

        public void Text32__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "5";
        }

        public void Text33__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "საიდენტიფიკაციო ნომერი";
        }

        public void Text34__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetRptSalesOrderHeader.BranchAddress, true) + " " + ToString(sender, SP_GetRptSalesOrderHeader.BranchPhone, true);
        }

        public void Text35__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "ტრანსპორტირების დაწყების ადგილი (მისამართი)";
        }

        public void TextInCells4__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetRptSalesOrderHeader.CustomerTaxCode, true);
        }

        public void Text36__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "საიდენტიფიკაციო ნომერი";
        }

        public void Text37__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "6";
        }

        public void Text38__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "დასახელება ან სახელი";
        }

        public void Text39__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "ტვირთის მიმღების";
        }

        public void Text40__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetRptSalesOrderHeader.CustomerName, true);
        }

        public void Text41__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetRptSalesOrderHeader.CustomerAddress, true) + " " + ToString(sender, SP_GetRptSalesOrderHeader.CustomerPhone, true);
        }

        public void Text42__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "ტრანსპორტირების დამთავრების ადგილი (მისამართი)";
        }

        public void Text44__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "გადამზიდველის";
        }

        public void Text45__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "დასახელება ან სახელი\r\nდა გვარი\r\n                  ";
        }

        public void Text46__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "7";
        }

        public void Text47__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "საიდენტიფიკაციო ან პირადი ნომერი";
        }

        public void Text48__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "დასახელება ან სახელი";
        }

        public void Text49__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "გამყიდველისაგან\r\nტვირთის მიღებაში\r\nდა გადაზიდვაში\r\nნდობით\r\nაღჭურვილი პირის";
        }

        public void Text52__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "მინდობილობის\r\nნომერი\r\n                  ";
        }

        public void Text53__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "8";
        }

        public void Text55__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "რიცხვი, თვე\r\nდა წელი\r\n                  ";
        }

        public void Text56__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "9";
        }

        public void Text57__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "ტრანსპორტირების სახე";
        }

        public void Text59__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "(აღნიშნეთ X ნიშნით)";
        }

        public void Text58__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10";
        }

        public void Text60__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "   საავტომობილო    სარკინიგზო         სხვა";
        }

        public void Text61__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "11";
        }

        public void Text62__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "სატრანსპორტო საშუალების მარკა და ნომერი";
        }

        public void Text65__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "მძღოლის მოწმობის სერია და ნომერი";
        }

        public void Text66__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "12";
        }

        public void Text67__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "№";
        }

        public void Text68__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "საქონლის (ტვირთის) დასახელება ან\r\nკონტეინერის\r\nნომერი, მ.შ. დანართის მიხედვით";
        }

        public void Text69__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "ზომის\r\nერთეული";
        }

        public void Text70__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "რაოდე -\r\nნობა";
        }

        public void Text71__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "ერთეულის ფასი\r\nდღგ-ს და აქციზის\r\nჩათვლით";
        }

        public void Text72__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetSalesOrderDetail.SP_GetRptSalesOrderHeader.CurrencyName, true);
        }

        public void Text73__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetSalesOrderDetail.SP_GetRptSalesOrderHeader.CurrencyCoin, true);
        }

        public void Text74__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "თანხა";
        }

        public void Text75__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetSalesOrderDetail.SP_GetRptSalesOrderHeader.CurrencyName, true);
        }

        public void Text76__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetSalesOrderDetail.SP_GetRptSalesOrderHeader.CurrencyCoin, true);
        }

        public void Text77__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "შეფუთვის\r\nსახე";
        }

        public void Text78__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "მასა\r\nბრუტო\r\nტონა";
        }

        public void Text79__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1";
        }

        public void Text80__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "2";
        }

        public void Text81__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "3";
        }

        public void Text82__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "4";
        }

        public void Text83__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "5";
        }

        public void Text84__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "6";
        }

        public void Text85__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "7";
        }

        public void Text86__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "8";
        }

        public void Text87__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Line, true);
        }

        public void Text88__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetSalesOrderDetail.MedicamentName, true) + " " + ToString(sender, SP_GetSalesOrderDetail.Serie, true);
        }

        public void Text89__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "ცალი";
        }

        public void Text90__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Text90.TextFormat.Format(CheckExcelValue(sender, SP_GetSalesOrderDetail.SaleQty));
        }

        public void Text91__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, (long)SP_GetSalesOrderDetail.LinePriceDiscount, true);
        }

        public void Text92__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = System.String.Format("{0:0000}", Zek.Core.MathHelper.FracToInt32(System.Math.Round(SP_GetSalesOrderDetail.LinePriceDiscount, 4)));
        }

        public void Text93__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, (long)SP_GetSalesOrderDetail.LineTotal, true);
        }

        public void Text94__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = System.String.Format("{0:0000}", Zek.Core.MathHelper.FracToInt32(System.Math.Round(SP_GetSalesOrderDetail.LineTotal, 4)));
        }

        public void Text181__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "ამ ზედნადების შესაბამისად";
        }

        public void Text191__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "მიეწოდება " + ToString(sender, SP_GetSalesOrderDetail.Count, true);
        }

        public void Text201__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "დასახელების საქონელი დანართის მიხედვით.";
        }

        public void Text3__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "13";
        }

        public void Text4__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Text4.TextFormat.Format(CheckExcelValue(sender, SP_GetSalesOrderDetail.SP_GetRptSalesOrderHeader.TotalDue));
        }

        public void Text97__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "14";
        }

        public void Text99__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "ტრანსპორტირება:";
        }

        public void Text100__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, IIF(SP_GetSalesOrderDetail.SP_GetRptSalesOrderHeader.Freight != 0m, Format("{0:N2}", SP_GetSalesOrderDetail.SP_GetRptSalesOrderHeader.Freight), string.Empty), true);
        }

        public void Text101__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "საგადასახადო:";
        }

        public void Text102__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, IIF(SP_GetSalesOrderDetail.SP_GetRptSalesOrderHeader.TaxAmt != 0m, Format("{0:N2}", SP_GetSalesOrderDetail.SP_GetRptSalesOrderHeader.TaxAmt), string.Empty), true);
        }

        public void Text103__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "თანხა სულ:";
        }

        public void Text104__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Zek.Core.NumToStrHelper.CurrToStr(SP_GetSalesOrderDetail.SP_GetRptSalesOrderHeader.TotalDue, SP_GetSalesOrderDetail.SP_GetRptSalesOrderHeader.CurrencyName, SP_GetSalesOrderDetail.SP_GetRptSalesOrderHeader.CurrencyCoin, true), true);
        }

        public void Text5__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "სიტყვიერად";
        }

        public void Text7__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "გაშვების ნება დართო (თანამდებობა, ხელმოწერა)";
        }

        public void Text105__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "აღნიშნული ტვირთი გადასატანად\r\nტარით და შეფუთვით, მასით\r\nბრუტო-ტონა  ";
        }

        public void Text107__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "სიტყვიერად";
        }

        public void Text108__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "აღნიშნული ტვირთი მყიდველს\r\n(ტვირთის მიმღებს)\r\nტარით და შეფუთვით, მასით\r\nბრუტო-ტონ" +
"ა";
        }

        public void Text110__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "სიტყვიერად";
        }

        public void Text111__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "ჩააბარა\r\nგამყიდველმა\r\n(ტვირთის\r\nგამგზავნმა)";
        }

        public void Text113__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "თანამდებობა, სახელი\r\nდა გვარი,\r\nშტამპი (ბეჭედი)\r\n                  ";
        }

        public void Text114__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "მიიღო ნდობით\r\nაღჭურვილმა\r\nპირმა ან\r\nგადამზიდველმა";
        }

        public void Text116__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "სახელი და გვარი,\r\nხელმოწერა,\r\nგადამზიდველის\r\nშტამპი (ბეჭედი)\r\n                  ";
        }

        public void Text117__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "ჩააბარა\r\nნდობით\r\nაღჭურვილმა\r\nპირმა ან\r\nგადამზიდველმა";
        }

        public void Text119__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "სახელი და გვარი,\r\nხელმოწერა\r\n                  ";
        }

        public void Text120__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "მიიღო\r\nმყიდველმა\r\n(ტვირთის\r\nმიმღებმა)";
        }

        public void Text122__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "თანამდებობა,\r\nსახელი და გვარი,\r\nშტამპი (ბეჭედი)\r\n                  ";
        }

        public void Text130__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "თარიღი";
        }

        public void Text131__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Stimulsoft.Report.Dictionary.StiFunctionsDate.Year(DateTime.Now) / 10, true) + "        წ.";
        }

        public void Text127__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "თარიღი";
        }

        public void Text125__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "თარიღი";
        }

        public void Text128__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Stimulsoft.Report.Dictionary.StiFunctionsDate.Year(DateTime.Now) / 10, true) + "        წ.";
        }

        public void Text123__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "დანართი №3";
        }

        public void Text132__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "№ " + ToString(sender, SP_GetRptSalesOrderHeader.SalesOrderID, true) + "  სასაქონლო ზედნადების დანართი";
        }

        public void Text133__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "2";
        }

        public void Text134__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Stimulsoft.Report.Dictionary.StiFunctionsDate.Day(SP_GetRptSalesOrderHeader.OrderDate), true);
        }

        public void Text135__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Zek.Core.DateTimeHelper.DateToMonth(SP_GetRptSalesOrderHeader.OrderDate), true);
        }

        public void Text136__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Stimulsoft.Report.Dictionary.StiFunctionsDate.Year(SP_GetRptSalesOrderHeader.OrderDate), true);
        }

        public void Text137__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "რიცხვი";
        }

        public void Text138__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "თვე (სიტყვიერად)";
        }

        public void Text139__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "წელი";
        }

        public void Text140__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "№";
        }

        public void Text141__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "საქონლის (ტვირთის)\r\nდასახელება ან კონ\r\nტეინერის ნომერი";
        }

        public void Text142__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "ზომის\r\nერთეული";
        }

        public void Text143__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "რაოდე -\r\nნობა";
        }

        public void Text144__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "ერთეულის ფასი\r\nდღგ-ს და აქციზის\r\nჩათვლით";
        }

        public void Text145__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetSalesOrderDetail.SP_GetRptSalesOrderHeader.CurrencyName, true);
        }

        public void Text146__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetSalesOrderDetail.SP_GetRptSalesOrderHeader.CurrencyCoin, true);
        }

        public void Text147__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "თანხა";
        }

        public void Text148__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetSalesOrderDetail.SP_GetRptSalesOrderHeader.CurrencyName, true);
        }

        public void Text149__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetSalesOrderDetail.SP_GetRptSalesOrderHeader.CurrencyCoin, true);
        }

        public void Text150__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "შეფუთვის\r\nსახე";
        }

        public void Text151__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "მასა\r\nბრუტო\r\nტონა";
        }

        public void Text152__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1";
        }

        public void Text153__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "2";
        }

        public void Text154__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "3";
        }

        public void Text155__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "4";
        }

        public void Text156__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "5";
        }

        public void Text157__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "6";
        }

        public void Text158__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "7";
        }

        public void Text159__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "8";
        }

        public void Text160__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Line, true);
        }

        public void Text161__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, SP_GetSalesOrderDetail.MedicamentName, true) + " " + ToString(sender, SP_GetSalesOrderDetail.Serie, true);
        }

        public void Text162__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "ცალი";
        }

        public void Text163__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Text163.TextFormat.Format(CheckExcelValue(sender, SP_GetSalesOrderDetail.SaleQty));
        }

        public void Text164__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, (long)SP_GetSalesOrderDetail.LinePriceDiscount, true);
        }

        public void Text165__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = System.String.Format("{0:0000}", Zek.Core.MathHelper.FracToInt32(System.Math.Round(SP_GetSalesOrderDetail.LinePriceDiscount, 4)));
        }

        public void Text166__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, (long)SP_GetSalesOrderDetail.LineTotal, true);
        }

        public void Text167__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = System.String.Format("{0:0000}", Zek.Core.MathHelper.FracToInt32(System.Math.Round(SP_GetSalesOrderDetail.LineTotal, 4)));
        }

        public void Text170__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "2";
        }

        public void Text171__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Text171.TextFormat.Format(CheckExcelValue(sender, SP_GetSalesOrderDetail.SP_GetRptSalesOrderHeader.TotalDue));
        }

        public void Text172__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "3";
        }

        public void Text174__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "ჩააბარა";
        }

        public void Text176__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "ხელმოწერა, შტამპი ან ბეჭედი";
        }

        public void Text177__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "მიიღო";
        }

        public void Text179__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "ხელმოწერა, შტამპი ან ბეჭედი";
        }

        public void RptSalesOrderDetailInvoice_Rendering(object sender, System.EventArgs e)
        {
            int maxRowCount = 7;

            if (SP_GetSalesOrderDetail.Count <= maxRowCount)
            {
                HeaderEnclosureText.Enabled = false;
                Page2.Enabled = false;
                DataEmptyRow.CountData = maxRowCount - SP_GetSalesOrderDetail.Count;
                DataEmptyRow.Enabled = (maxRowCount - SP_GetSalesOrderDetail.Count != 0);
            }
            else
            {
                DataSP_GetSalesOrderDetail.Enabled = false;
                DataEmptyRow.CountData = maxRowCount - 3;//ვაკლებთ სტატიკური ტექსტი რო მიწერია "ამ ზედნადების შესაბამისად..."
            };
        }

        private void InitializeComponent()
        {
            this.SP_GetSalesOrderDetail = new SP_GetSalesOrderDetailDataSource();
            this.SP_GetRptSalesOrderHeader = new SP_GetRptSalesOrderHeaderDataSource();
            this.ParentSP_GetRptSalesOrderHeader = new Stimulsoft.Report.Dictionary.StiDataRelation("SP_GetRptSalesOrderHeader_SP_GetSalesOrderDetail", "SP_GetRptSalesOrderHeader", "SP_GetRptSalesOrderHeader", this.SP_GetRptSalesOrderHeader, this.SP_GetSalesOrderDetail, new System.String[] {
                        "SalesOrderID"}, new System.String[] {
                        "SalesOrderID"});
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "MyCompanyName", "MyCompanyName", "", typeof(string), "", false, false, false));
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "MyCompanyTaxCode", "MyCompanyTaxCode", "", typeof(string), "", false, false, false));
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "MyCompanyDirectorName", "MyCompanyDirectorName", "", typeof(string), "", false, false, false));
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "MyCompanyCountryCode", "MyCompanyCountryCode", "", typeof(string), "", false, false, false));
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "MyCompanyCountryName", "MyCompanyCountryName", "", typeof(string), "", false, false, false));
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "MyCompanyCity", "MyCompanyCity", "", typeof(string), "", false, false, false));
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "MyCompanyPostalCode", "MyCompanyPostalCode", "", typeof(string), "", false, false, false));
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "MyCompanyAddress", "MyCompanyAddress", "", typeof(string), "", false, false, false));
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "MyCompanyPhone", "MyCompanyPhone", "", typeof(string), "", false, false, false));
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "MyCompanyFax", "MyCompanyFax", "", typeof(string), "", false, false, false));
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "MyCompanyBankName", "MyCompanyBankName", "", typeof(string), "", false, false, false));
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "MyCompanyBankCode", "MyCompanyBankCode", "", typeof(string), "", false, false, false));
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "MyCompanyBankAccountNumber", "MyCompanyBankAccountNumber", "", typeof(string), "", false, false, false));
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "MyCompanyVATPayerFlag", "MyCompanyVATPayerFlag", "", typeof(bool), "", false, false, false));
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "MyCompanyConditionalUnitCurrencyCode", "MyCompanyConditionalUnitCurrencyCode", "", typeof(string), "", false, false, false));
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "MyCompanyDefaultTradingCurrencyCode", "MyCompanyDefaultTradingCurrencyCode", "", typeof(string), "", false, false, false));
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "MyCompanyConditionalUnitCurrencyRate", "MyCompanyConditionalUnitCurrencyRate", "", typeof(decimal), "", false, false, false));
            this.NeedsCompiling = false;
            // Variables init
            // Variables init
            this.MyCompanyName = "";
            this.MyCompanyTaxCode = "";
            this.MyCompanyDirectorName = "";
            this.MyCompanyCountryCode = "";
            this.MyCompanyCountryName = "";
            this.MyCompanyCity = "";
            this.MyCompanyPostalCode = "";
            this.MyCompanyAddress = "";
            this.MyCompanyPhone = "";
            this.MyCompanyFax = "";
            this.MyCompanyBankName = "";
            this.MyCompanyBankCode = "";
            this.MyCompanyBankAccountNumber = "";
            this.MyCompanyVATPayerFlag = false;
            this.MyCompanyConditionalUnitCurrencyCode = "";
            this.MyCompanyDefaultTradingCurrencyCode = "";
            this.MyCompanyConditionalUnitCurrencyRate = 0m;
            this.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.ReferencedAssemblies = new System.String[] {
                    "System.Dll",
                    "System.Drawing.Dll",
                    "System.Windows.Forms.Dll",
                    "System.Data.Dll",
                    "System.Xml.Dll",
                    "Stimulsoft.Controls.Dll",
                    "Stimulsoft.Base.Dll",
                    "Stimulsoft.Report.Dll"};
            this.ReportAlias = "Rpt Sales Order Detail Invoice";
            this.ReportAuthor = "Programmer.GE";
            // 
            // ReportChanged
            // 
            this.ReportChanged = new DateTime(2011, 5, 15, 0, 36, 10, 849);
            // 
            // ReportCreated
            // 
            this.ReportCreated = new DateTime(2009, 2, 11, 22, 7, 37, 0);
            this.ReportDescription = "გაყიდვის ანგარიშ ფაქტურის რეპორტი.";
            this.ReportFile = "D:\\User\\Documents\\Projects\\Apothex\\Source\\Class Library\\Apothex.Reporting\\Sales\\R" +
"ptSalesOrderDetailInvoice.mrt";
            this.ReportGuid = "2fe49b0e7d4a4ea0aa577d11585955a9";
            this.ReportName = "RptSalesOrderDetailInvoice";
            this.ReportUnit = Stimulsoft.Report.StiReportUnitType.Millimeters;
            this.ReportVersion = "2010.3.900";
            this.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            this.Page1 = new Stimulsoft.Report.Components.StiPage();
            this.Page1.Guid = "92ecb1451ebd45bd9476a3f60f57bcb1";
            this.Page1.Name = "Page1";
            this.Page1.PageHeight = 397;
            this.Page1.PageWidth = 210;
            this.Page1.PaperSize = System.Drawing.Printing.PaperKind.A4;
            this.Page1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Page1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // DataSP_GetRptSalesOrderHeader
            // 
            this.DataSP_GetRptSalesOrderHeader = new Stimulsoft.Report.Components.StiDataBand();
            this.DataSP_GetRptSalesOrderHeader.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4, 196, 116);
            this.DataSP_GetRptSalesOrderHeader.DataSourceName = "SP_GetRptSalesOrderHeader";
            this.DataSP_GetRptSalesOrderHeader.Name = "DataSP_GetRptSalesOrderHeader";
            this.DataSP_GetRptSalesOrderHeader.PrintIfDetailEmpty = true;
            this.DataSP_GetRptSalesOrderHeader.Sort = new System.String[0];
            this.DataSP_GetRptSalesOrderHeader.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataSP_GetRptSalesOrderHeader.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.DataSP_GetRptSalesOrderHeader.BusinessObjectGuid = null;
            // 
            // DataSP_GetRptSalesOrderHeader_SalesOrderID
            // 
            this.DataSP_GetRptSalesOrderHeader_SalesOrderID = new Stimulsoft.Report.Components.StiText();
            this.DataSP_GetRptSalesOrderHeader_SalesOrderID.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10.03, 0, 175.95, 6.1);
            this.DataSP_GetRptSalesOrderHeader_SalesOrderID.Editable = true;
            this.DataSP_GetRptSalesOrderHeader_SalesOrderID.Guid = "b81a3cea473147d7a268424c9cadc278";
            this.DataSP_GetRptSalesOrderHeader_SalesOrderID.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.DataSP_GetRptSalesOrderHeader_SalesOrderID.Name = "DataSP_GetRptSalesOrderHeader_SalesOrderID";
            this.DataSP_GetRptSalesOrderHeader_SalesOrderID.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.DataSP_GetRptSalesOrderHeader_SalesOrderID__GetValue);
            this.DataSP_GetRptSalesOrderHeader_SalesOrderID.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.DataSP_GetRptSalesOrderHeader_SalesOrderID.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataSP_GetRptSalesOrderHeader_SalesOrderID.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.DataSP_GetRptSalesOrderHeader_SalesOrderID.Font = new System.Drawing.Font("BPG Glaho Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.DataSP_GetRptSalesOrderHeader_SalesOrderID.Interaction = null;
            this.DataSP_GetRptSalesOrderHeader_SalesOrderID.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.DataSP_GetRptSalesOrderHeader_SalesOrderID.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.DataSP_GetRptSalesOrderHeader_SalesOrderID.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Panel2
            // 
            this.Panel2 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(71.96, 15.91, 52.07, 8.13);
            this.Panel2.Name = "Panel2";
            this.Panel2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text8
            // 
            this.Text8 = new Stimulsoft.Report.Components.StiText();
            this.Text8.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4.06, 4.06);
            this.Text8.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text8.Name = "Text8";
            this.Text8.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text8__GetValue);
            this.Text8.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text8.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text8.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text8.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text8.Guid = null;
            this.Text8.Interaction = null;
            this.Text8.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text8.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text8.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text10
            // 
            this.Text10 = new Stimulsoft.Report.Components.StiText();
            this.Text10.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4.06, 0, 8.13, 4.06);
            this.Text10.Editable = true;
            this.Text10.Guid = "baab44edc7604be79928cecdbf5bb870";
            this.Text10.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text10.Name = "Text10";
            this.Text10.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text10__GetValue);
            this.Text10.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text10.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text10.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text10.Font = new System.Drawing.Font("BPG Glaho Arial", 8F);
            this.Text10.Interaction = null;
            this.Text10.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text10.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text10.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text11
            // 
            this.Text11 = new Stimulsoft.Report.Components.StiText();
            this.Text11.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(11.94, 0, 29.97, 4.06);
            this.Text11.Editable = true;
            this.Text11.Guid = "ac2b96dc6bb240488032cece4567814b";
            this.Text11.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text11.Name = "Text11";
            this.Text11.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text11__GetValue);
            this.Text11.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text11.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text11.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top)
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right)
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text11.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text11.Font = new System.Drawing.Font("BPG Glaho Arial", 8F);
            this.Text11.Interaction = null;
            this.Text11.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text11.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text11.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text12
            // 
            this.Text12 = new Stimulsoft.Report.Components.StiText();
            this.Text12.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(41.91, 0, 9.91, 4.06);
            this.Text12.Editable = true;
            this.Text12.Guid = "9a70e4b183874c7694734609ed689c69";
            this.Text12.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text12.Name = "Text12";
            this.Text12.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text12__GetValue);
            this.Text12.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text12.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top)
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right)
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text12.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text12.Font = new System.Drawing.Font("BPG Glaho Arial", 8F);
            this.Text12.Interaction = null;
            this.Text12.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text12.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text12.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text13
            // 
            this.Text13 = new Stimulsoft.Report.Components.StiText();
            this.Text13.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4.06, 4.06, 8.13, 4.06);
            this.Text13.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text13.Name = "Text13";
            this.Text13.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text13__GetValue);
            this.Text13.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text13.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text13.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text13.Guid = null;
            this.Text13.Interaction = null;
            this.Text13.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text13.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text13.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text14
            // 
            this.Text14 = new Stimulsoft.Report.Components.StiText();
            this.Text14.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(11.94, 4.06, 29.97, 4.06);
            this.Text14.Guid = "1172e2c2800444c18a0531a61c101c9a";
            this.Text14.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text14.Name = "Text14";
            this.Text14.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text14__GetValue);
            this.Text14.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text14.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text14.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text14.Interaction = null;
            this.Text14.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text14.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text14.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text15
            // 
            this.Text15 = new Stimulsoft.Report.Components.StiText();
            this.Text15.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(41.91, 4.06, 9.91, 4.06);
            this.Text15.Guid = "94ed2e2cafd54c359385b9302e0ad7ea";
            this.Text15.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text15.Name = "Text15";
            this.Text15.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text15__GetValue);
            this.Text15.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text15.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text15.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text15.Interaction = null;
            this.Text15.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text15.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text15.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel2.Guid = null;
            this.Panel2.Interaction = null;
            // 
            // Panel1
            // 
            this.Panel1 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(188.12, 2.03, 8.13, 25.91);
            this.Panel1.Name = "Panel1";
            this.Panel1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text9
            // 
            this.Text9 = new Stimulsoft.Report.Components.StiText();
            this.Text9.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4.06, 4.06, 4.06, 20.07);
            this.Text9.Guid = "e60e6945183b4b2f80fddd53fcc3a83a";
            this.Text9.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text9.Name = "Text9";
            this.Text9.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text9__GetValue);
            this.Text9.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text9.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text9.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text9.Font = new System.Drawing.Font("BPG Glaho Arial", 7F);
            this.Text9.Interaction = null;
            this.Text9.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text9.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text9.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 270F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text2
            // 
            this.Text2 = new Stimulsoft.Report.Components.StiText();
            this.Text2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4.06, 0, 4.06, 4.06);
            this.Text2.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text2.Name = "Text2";
            this.Text2.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text2__GetValue);
            this.Text2.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text2.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text2.Guid = null;
            this.Text2.Interaction = null;
            this.Text2.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text2.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel1.Guid = null;
            this.Panel1.Interaction = null;
            // 
            // Panel3
            // 
            this.Panel3 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 34, 45, 10);
            this.Panel3.Name = "Panel3";
            this.Panel3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text16
            // 
            this.Text16 = new Stimulsoft.Report.Components.StiText();
            this.Text16.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 45, 4);
            this.Text16.Editable = true;
            this.Text16.Name = "Text16";
            this.Text16.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text16__GetValue);
            this.Text16.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text16.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text16.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text16.Font = new System.Drawing.Font("BPG Glaho Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text16.Guid = null;
            this.Text16.Interaction = null;
            this.Text16.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text16.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text16.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text17
            // 
            this.Text17 = new Stimulsoft.Report.Components.StiText();
            this.Text17.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4, 18, 4);
            this.Text17.Name = "Text17";
            this.Text17.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text17__GetValue);
            this.Text17.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text17.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text17.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.Text17.Guid = null;
            this.Text17.Interaction = null;
            this.Text17.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text17.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text17.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text18
            // 
            this.Text18 = new Stimulsoft.Report.Components.StiText();
            this.Text18.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(20, 4, 25, 6);
            this.Text18.Name = "Text18";
            this.Text18.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text18__GetValue);
            this.Text18.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text18.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text18.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text18.Guid = null;
            this.Text18.Interaction = null;
            this.Text18.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text18.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text18.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel3.Guid = null;
            this.Panel3.Interaction = null;
            // 
            // Panel4
            // 
            this.Panel4 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(47, 34, 50, 10);
            this.Panel4.Name = "Panel4";
            this.Panel4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // TextInCells1
            // 
            this.TextInCells1 = new Stimulsoft.Report.Components.StiTextInCells();
            this.TextInCells1.CellHeight = 4F;
            this.TextInCells1.CellWidth = 4F;
            this.TextInCells1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 46, 6);
            this.TextInCells1.Editable = true;
            this.TextInCells1.Name = "TextInCells1";
            this.TextInCells1.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.TextInCells1__GetValue);
            this.TextInCells1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.TextInCells1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.TextInCells1.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.TextInCells1.Guid = null;
            this.TextInCells1.Interaction = null;
            this.TextInCells1.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.TextInCells1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.TextInCells1.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text19
            // 
            this.Text19 = new Stimulsoft.Report.Components.StiText();
            this.Text19.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4.06, 4.06);
            this.Text19.Guid = "e03e615d88ba4ac884dbee9dbf26eec6";
            this.Text19.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text19.Name = "Text19";
            this.Text19.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text19__GetValue);
            this.Text19.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text19.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text19.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text19.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text19.Interaction = null;
            this.Text19.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text19.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text19.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text20
            // 
            this.Text20 = new Stimulsoft.Report.Components.StiText();
            this.Text20.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4.06, 4.06, 43.94, 4.1);
            this.Text20.Guid = "092f83b0678046e787c730b14ac69649";
            this.Text20.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text20.Name = "Text20";
            this.Text20.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text20__GetValue);
            this.Text20.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text20.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text20.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text20.Interaction = null;
            this.Text20.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text20.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text20.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel4.Guid = null;
            this.Panel4.Interaction = null;
            // 
            // Panel6
            // 
            this.Panel6 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(146, 34, 50, 10);
            this.Panel6.Guid = "261d668757cd4588a15cb88753a6cbb4";
            this.Panel6.Name = "Panel6";
            this.Panel6.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel6.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // TextInCells2
            // 
            this.TextInCells2 = new Stimulsoft.Report.Components.StiTextInCells();
            this.TextInCells2.CellHeight = 4F;
            this.TextInCells2.CellWidth = 4F;
            this.TextInCells2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4.06, 0, 45.97, 6.1);
            this.TextInCells2.Editable = true;
            this.TextInCells2.Guid = "cd928f505faa498f93320f98b2c34315";
            this.TextInCells2.Name = "TextInCells2";
            this.TextInCells2.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.TextInCells2__GetValue);
            this.TextInCells2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.TextInCells2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.TextInCells2.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.TextInCells2.Interaction = null;
            this.TextInCells2.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.TextInCells2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.TextInCells2.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text25
            // 
            this.Text25 = new Stimulsoft.Report.Components.StiText();
            this.Text25.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4.06, 4.06, 43.94, 4.1);
            this.Text25.Guid = "066c91dad9404d3a95f7a19f76f20221";
            this.Text25.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text25.Name = "Text25";
            this.Text25.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text25__GetValue);
            this.Text25.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text25.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text25.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text25.Interaction = null;
            this.Text25.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text25.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text25.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text24
            // 
            this.Text24 = new Stimulsoft.Report.Components.StiText();
            this.Text24.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4.06, 4.06);
            this.Text24.Guid = "ee32dd586680439e9abf6c6bb7e736d1";
            this.Text24.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text24.Name = "Text24";
            this.Text24.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text24__GetValue);
            this.Text24.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text24.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text24.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text24.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text24.Interaction = null;
            this.Text24.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text24.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text24.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel6.Interaction = null;
            // 
            // Panel5
            // 
            this.Panel5 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(99, 34, 45, 10);
            this.Panel5.Guid = "bc24c79db4b7416ba237b459bf993f76";
            this.Panel5.Name = "Panel5";
            this.Panel5.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text23
            // 
            this.Text23 = new Stimulsoft.Report.Components.StiText();
            this.Text23.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(20, 4, 25, 6);
            this.Text23.Guid = "9b8a51b12abd40e0b3660a292596c6ff";
            this.Text23.Name = "Text23";
            this.Text23.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text23__GetValue);
            this.Text23.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text23.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text23.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text23.Interaction = null;
            this.Text23.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text23.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text23.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text22
            // 
            this.Text22 = new Stimulsoft.Report.Components.StiText();
            this.Text22.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4, 18, 4);
            this.Text22.Guid = "0b50ca01a5ee4496a6df5f4b854f35a9";
            this.Text22.Name = "Text22";
            this.Text22.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text22__GetValue);
            this.Text22.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text22.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text22.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.Text22.Interaction = null;
            this.Text22.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text22.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text22.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text21
            // 
            this.Text21 = new Stimulsoft.Report.Components.StiText();
            this.Text21.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 45, 4);
            this.Text21.Editable = true;
            this.Text21.Guid = "f53631290e424e848acb9243a1049420";
            this.Text21.Name = "Text21";
            this.Text21.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text21__GetValue);
            this.Text21.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text21.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text21.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text21.Font = new System.Drawing.Font("BPG Glaho Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text21.Interaction = null;
            this.Text21.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text21.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text21.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel5.Interaction = null;
            // 
            // Panel7
            // 
            this.Panel7 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel7.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 46, 92, 10);
            this.Panel7.Name = "Panel7";
            this.Panel7.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel7.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text26
            // 
            this.Text26 = new Stimulsoft.Report.Components.StiText();
            this.Text26.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 92, 4);
            this.Text26.Editable = true;
            this.Text26.Name = "Text26";
            this.Text26.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text26__GetValue);
            this.Text26.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text26.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text26.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text26.Font = new System.Drawing.Font("BPG Glaho Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text26.Guid = null;
            this.Text26.Interaction = null;
            this.Text26.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text26.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text26.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text27
            // 
            this.Text27 = new Stimulsoft.Report.Components.StiText();
            this.Text27.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4, 92, 4);
            this.Text27.Guid = "c6a41be534ec41f39cb7b2ba3639236e";
            this.Text27.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text27.Name = "Text27";
            this.Text27.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text27__GetValue);
            this.Text27.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text27.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text27.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text27.Interaction = null;
            this.Text27.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text27.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text27.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel7.Guid = null;
            this.Panel7.Interaction = null;
            // 
            // Panel8
            // 
            this.Panel8 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel8.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(99, 46, 92, 10);
            this.Panel8.Guid = "0f2ca3159a5246e88b21797bb6c4640d";
            this.Panel8.Name = "Panel8";
            this.Panel8.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel8.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text28
            // 
            this.Text28 = new Stimulsoft.Report.Components.StiText();
            this.Text28.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 92, 4);
            this.Text28.Editable = true;
            this.Text28.Guid = "df940aa4d6df426897077035177fc2f8";
            this.Text28.Name = "Text28";
            this.Text28.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text28__GetValue);
            this.Text28.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text28.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text28.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text28.Font = new System.Drawing.Font("BPG Glaho Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text28.Interaction = null;
            this.Text28.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text28.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text28.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text29
            // 
            this.Text29 = new Stimulsoft.Report.Components.StiText();
            this.Text29.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4, 92, 4);
            this.Text29.Guid = "7efc5d4e235d40149f8677182931e926";
            this.Text29.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text29.Name = "Text29";
            this.Text29.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text29__GetValue);
            this.Text29.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text29.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text29.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text29.Interaction = null;
            this.Text29.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text29.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text29.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel8.Interaction = null;
            // 
            // Panel9
            // 
            this.Panel9 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel9.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 60, 45, 10);
            this.Panel9.Guid = "9cccc5a51b4b435e8211754dd1e70f19";
            this.Panel9.Name = "Panel9";
            this.Panel9.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel9.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text1
            // 
            this.Text1 = new Stimulsoft.Report.Components.StiText();
            this.Text1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 45, 4);
            this.Text1.Editable = true;
            this.Text1.Guid = "e0064db7a98e49f9b444ccf9e718f21a";
            this.Text1.Name = "Text1";
            this.Text1.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text1__GetValue);
            this.Text1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text1.Font = new System.Drawing.Font("BPG Glaho Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text1.Interaction = null;
            this.Text1.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text1.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text30
            // 
            this.Text30 = new Stimulsoft.Report.Components.StiText();
            this.Text30.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4, 22, 4);
            this.Text30.Guid = "f004c16de68443d2852f001f26ec8b7c";
            this.Text30.Name = "Text30";
            this.Text30.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text30__GetValue);
            this.Text30.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text30.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text30.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Bold);
            this.Text30.Interaction = null;
            this.Text30.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text30.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text30.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text31
            // 
            this.Text31 = new Stimulsoft.Report.Components.StiText();
            this.Text31.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(21, 4, 24, 6);
            this.Text31.Guid = "3043cfa6fa1b4f8e90ab5b99ee63a9ba";
            this.Text31.Name = "Text31";
            this.Text31.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text31__GetValue);
            this.Text31.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text31.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text31.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text31.Interaction = null;
            this.Text31.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text31.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text31.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel9.Interaction = null;
            // 
            // Panel10
            // 
            this.Panel10 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel10.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(47, 60, 50, 10);
            this.Panel10.Guid = "7a472564d6564fa294291b04032be946";
            this.Panel10.Name = "Panel10";
            this.Panel10.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel10.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // TextInCells3
            // 
            this.TextInCells3 = new Stimulsoft.Report.Components.StiTextInCells();
            this.TextInCells3.CellHeight = 4F;
            this.TextInCells3.CellWidth = 4F;
            this.TextInCells3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 46, 6);
            this.TextInCells3.Editable = true;
            this.TextInCells3.Guid = "781e9cab0226424a8bdcd45538ef5016";
            this.TextInCells3.Name = "TextInCells3";
            this.TextInCells3.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.TextInCells3__GetValue);
            this.TextInCells3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.TextInCells3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.TextInCells3.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.TextInCells3.Interaction = null;
            this.TextInCells3.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.TextInCells3.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.TextInCells3.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text32
            // 
            this.Text32 = new Stimulsoft.Report.Components.StiText();
            this.Text32.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4.06, 4.06);
            this.Text32.Guid = "8578d27f5fa94e089992e3ef0feb59ca";
            this.Text32.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text32.Name = "Text32";
            this.Text32.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text32__GetValue);
            this.Text32.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text32.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text32.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text32.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text32.Interaction = null;
            this.Text32.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text32.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text32.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text33
            // 
            this.Text33 = new Stimulsoft.Report.Components.StiText();
            this.Text33.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4.06, 4.06, 43.94, 4.1);
            this.Text33.Guid = "b39c1c502a6f4c7480a93bad0f3c661c";
            this.Text33.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text33.Name = "Text33";
            this.Text33.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text33__GetValue);
            this.Text33.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text33.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text33.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text33.Interaction = null;
            this.Text33.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text33.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text33.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel10.Interaction = null;
            // 
            // Panel11
            // 
            this.Panel11 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel11.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 72, 92, 10);
            this.Panel11.Guid = "8b7eb16e334e4dc7a1300f926a736120";
            this.Panel11.Name = "Panel11";
            this.Panel11.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel11.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text34
            // 
            this.Text34 = new Stimulsoft.Report.Components.StiText();
            this.Text34.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 92, 4);
            this.Text34.Editable = true;
            this.Text34.Guid = "cfece86b25f8420a9796f3fbd745ee72";
            this.Text34.Name = "Text34";
            this.Text34.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text34__GetValue);
            this.Text34.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text34.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text34.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text34.Font = new System.Drawing.Font("BPG Glaho Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text34.Interaction = null;
            this.Text34.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text34.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text34.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text35
            // 
            this.Text35 = new Stimulsoft.Report.Components.StiText();
            this.Text35.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4, 92, 4);
            this.Text35.Guid = "d43ddb5102dd4243af23f1248381b74c";
            this.Text35.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text35.Name = "Text35";
            this.Text35.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text35__GetValue);
            this.Text35.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text35.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text35.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text35.Interaction = null;
            this.Text35.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text35.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text35.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel11.Interaction = null;
            // 
            // Panel12
            // 
            this.Panel12 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel12.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(146, 60, 50, 10);
            this.Panel12.Guid = "e5a33e2790ea4daa92148b0b2ad0033d";
            this.Panel12.Name = "Panel12";
            this.Panel12.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel12.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // TextInCells4
            // 
            this.TextInCells4 = new Stimulsoft.Report.Components.StiTextInCells();
            this.TextInCells4.CellHeight = 4F;
            this.TextInCells4.CellWidth = 4F;
            this.TextInCells4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 46, 6.1);
            this.TextInCells4.Editable = true;
            this.TextInCells4.Guid = "c2b74839403444d6aff96b1e8f18a55f";
            this.TextInCells4.Name = "TextInCells4";
            this.TextInCells4.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.TextInCells4__GetValue);
            this.TextInCells4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.TextInCells4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.TextInCells4.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.TextInCells4.Interaction = null;
            this.TextInCells4.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.TextInCells4.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.TextInCells4.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text36
            // 
            this.Text36 = new Stimulsoft.Report.Components.StiText();
            this.Text36.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 4, 44, 4.1);
            this.Text36.Guid = "ca45b7d6c7834e72bd393e585c83b54f";
            this.Text36.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text36.Name = "Text36";
            this.Text36.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text36__GetValue);
            this.Text36.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text36.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text36.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text36.Interaction = null;
            this.Text36.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text36.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text36.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text37
            // 
            this.Text37 = new Stimulsoft.Report.Components.StiText();
            this.Text37.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 4);
            this.Text37.Guid = "b0c944c885c04a6094983d1629a3420b";
            this.Text37.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text37.Name = "Text37";
            this.Text37.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text37__GetValue);
            this.Text37.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text37.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text37.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text37.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text37.Interaction = null;
            this.Text37.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text37.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text37.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel12.Interaction = null;
            // 
            // Panel13
            // 
            this.Panel13 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel13.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(99, 60, 45, 10);
            this.Panel13.Guid = "c45da4adfa184cee9d4a78a0d0a576ba";
            this.Panel13.Name = "Panel13";
            this.Panel13.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel13.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text38
            // 
            this.Text38 = new Stimulsoft.Report.Components.StiText();
            this.Text38.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(20, 4, 25, 6);
            this.Text38.Guid = "b45407f1b7ad4b0ca4f9d3c3af564d91";
            this.Text38.Name = "Text38";
            this.Text38.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text38__GetValue);
            this.Text38.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text38.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text38.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text38.Interaction = null;
            this.Text38.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text38.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text38.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text39
            // 
            this.Text39 = new Stimulsoft.Report.Components.StiText();
            this.Text39.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4, 20, 4);
            this.Text39.Guid = "64f57aea61404beda175ac9864a20931";
            this.Text39.Name = "Text39";
            this.Text39.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text39__GetValue);
            this.Text39.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text39.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text39.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Bold);
            this.Text39.Interaction = null;
            this.Text39.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text39.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text39.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text40
            // 
            this.Text40 = new Stimulsoft.Report.Components.StiText();
            this.Text40.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 45, 4);
            this.Text40.Editable = true;
            this.Text40.Guid = "96f12355a1dd4444b4a2d4be3d223183";
            this.Text40.Name = "Text40";
            this.Text40.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text40__GetValue);
            this.Text40.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text40.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text40.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text40.Font = new System.Drawing.Font("BPG Glaho Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text40.Interaction = null;
            this.Text40.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text40.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text40.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel13.Interaction = null;
            // 
            // Panel14
            // 
            this.Panel14 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel14.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(99, 72, 92, 10);
            this.Panel14.Guid = "62e04ba9bd7f4f58ae00632e1adc825d";
            this.Panel14.Name = "Panel14";
            this.Panel14.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel14.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text41
            // 
            this.Text41 = new Stimulsoft.Report.Components.StiText();
            this.Text41.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 92, 4);
            this.Text41.Editable = true;
            this.Text41.Guid = "96868c91f0a7451c970633b96dca67c3";
            this.Text41.Name = "Text41";
            this.Text41.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text41__GetValue);
            this.Text41.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text41.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text41.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text41.Font = new System.Drawing.Font("BPG Glaho Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text41.Interaction = null;
            this.Text41.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text41.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text41.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text42
            // 
            this.Text42 = new Stimulsoft.Report.Components.StiText();
            this.Text42.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4, 92, 4);
            this.Text42.Guid = "d1f5687a3db14279b9203ac86d45dabf";
            this.Text42.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text42.Name = "Text42";
            this.Text42.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text42__GetValue);
            this.Text42.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text42.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text42.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text42.Interaction = null;
            this.Text42.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text42.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text42.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel14.Interaction = null;
            // 
            // Panel15
            // 
            this.Panel15 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel15.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 86, 43, 10);
            this.Panel15.Guid = "fad739a188694903a73a9e7a8985f2af";
            this.Panel15.Name = "Panel15";
            this.Panel15.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel15.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text43
            // 
            this.Text43 = new Stimulsoft.Report.Components.StiText();
            this.Text43.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 43, 4);
            this.Text43.Editable = true;
            this.Text43.Guid = "aa799b7858a644ef9150e847b3fde43b";
            this.Text43.Name = "Text43";
            this.Text43.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text43.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text43.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text43.Font = new System.Drawing.Font("BPG Glaho Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text43.Interaction = null;
            this.Text43.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text43.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text43.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text44
            // 
            this.Text44 = new Stimulsoft.Report.Components.StiText();
            this.Text44.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4, 18, 4);
            this.Text44.Guid = "f0cb61769253440297144c82e9e41fa3";
            this.Text44.Name = "Text44";
            this.Text44.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text44__GetValue);
            this.Text44.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text44.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text44.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Bold);
            this.Text44.Interaction = null;
            this.Text44.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text44.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text44.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text45
            // 
            this.Text45 = new Stimulsoft.Report.Components.StiText();
            this.Text45.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(20, 4, 23, 6);
            this.Text45.Guid = "2b2991b360484b83a482645188fcbec4";
            this.Text45.Name = "Text45";
            this.Text45.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text45__GetValue);
            this.Text45.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text45.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text45.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text45.Interaction = null;
            this.Text45.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text45.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text45.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel15.Interaction = null;
            // 
            // Panel16
            // 
            this.Panel16 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel16.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(45, 86, 50, 10);
            this.Panel16.Guid = "6e8e124c99cb4b78a815dbdda72cbeea";
            this.Panel16.Name = "Panel16";
            this.Panel16.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel16.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // TextInCells5
            // 
            this.TextInCells5 = new Stimulsoft.Report.Components.StiTextInCells();
            this.TextInCells5.CellHeight = 4F;
            this.TextInCells5.CellWidth = 4F;
            this.TextInCells5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 46, 6);
            this.TextInCells5.Editable = true;
            this.TextInCells5.Guid = "d0f4f23a5a4740adb717a561fcb99fba";
            this.TextInCells5.Name = "TextInCells5";
            this.TextInCells5.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.TextInCells5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.TextInCells5.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.TextInCells5.Interaction = null;
            this.TextInCells5.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.TextInCells5.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.TextInCells5.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.InitializeComponent2();
        }

        public void InitializeComponent2()
        {
            // 
            // Text46
            // 
            this.Text46 = new Stimulsoft.Report.Components.StiText();
            this.Text46.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 4);
            this.Text46.Guid = "9b5fce5e0e2249859aaa23c0edee48e4";
            this.Text46.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text46.Name = "Text46";
            this.Text46.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text46__GetValue);
            this.Text46.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text46.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text46.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text46.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text46.Interaction = null;
            this.Text46.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text46.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text46.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text47
            // 
            this.Text47 = new Stimulsoft.Report.Components.StiText();
            this.Text47.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 4, 44, 4);
            this.Text47.Guid = "4e2bdd9a9add4a92b4434a4094155894";
            this.Text47.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text47.Name = "Text47";
            this.Text47.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text47__GetValue);
            this.Text47.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text47.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text47.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text47.Interaction = null;
            this.Text47.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text47.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text47.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel16.Interaction = null;
            // 
            // Panel17
            // 
            this.Panel17 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel17.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(97, 86, 53, 14);
            this.Panel17.Guid = "8c67b68bcd2b416599b0bf1d04b8a26d";
            this.Panel17.Name = "Panel17";
            this.Panel17.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel17.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text48
            // 
            this.Text48 = new Stimulsoft.Report.Components.StiText();
            this.Text48.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(22, 4, 31, 6);
            this.Text48.Guid = "3f2f1b7c5df44a49935777f6bb798b3a";
            this.Text48.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text48.Name = "Text48";
            this.Text48.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text48__GetValue);
            this.Text48.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text48.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text48.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text48.Interaction = null;
            this.Text48.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text48.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text48.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text49
            // 
            this.Text49 = new Stimulsoft.Report.Components.StiText();
            this.Text49.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 20, 14);
            this.Text49.Guid = "34233a9a7d11482ca1ee759da28c4272";
            this.Text49.Name = "Text49";
            this.Text49.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text49__GetValue);
            this.Text49.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text49.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text49.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text49.Interaction = null;
            this.Text49.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text49.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text49.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text50
            // 
            this.Text50 = new Stimulsoft.Report.Components.StiText();
            this.Text50.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(22, 0, 31, 4);
            this.Text50.Editable = true;
            this.Text50.Guid = "de2ff9d6d0a3473099073a0e4f5a6434";
            this.Text50.Name = "Text50";
            this.Text50.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text50.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text50.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text50.Font = new System.Drawing.Font("BPG Glaho Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text50.Interaction = null;
            this.Text50.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text50.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text50.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel17.Interaction = null;
            // 
            // Panel18
            // 
            this.Panel18 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel18.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(153, 86, 43, 14);
            this.Panel18.Guid = "a3002a4d00c94842b09a7f3598e2e73a";
            this.Panel18.Name = "Panel18";
            this.Panel18.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel18.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text51
            // 
            this.Text51 = new Stimulsoft.Report.Components.StiText();
            this.Text51.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 17, 4);
            this.Text51.Editable = true;
            this.Text51.Guid = "b8d1847e8b394c46b2ddb03a2384976c";
            this.Text51.Name = "Text51";
            this.Text51.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text51.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text51.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text51.Font = new System.Drawing.Font("Arial", 8F);
            this.Text51.Interaction = null;
            this.Text51.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text51.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text51.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text52
            // 
            this.Text52 = new Stimulsoft.Report.Components.StiText();
            this.Text52.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 4, 17, 6);
            this.Text52.Guid = "a150f56eb367426486543b3716eb80cf";
            this.Text52.Name = "Text52";
            this.Text52.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text52__GetValue);
            this.Text52.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text52.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text52.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text52.Interaction = null;
            this.Text52.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text52.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text52.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text53
            // 
            this.Text53 = new Stimulsoft.Report.Components.StiText();
            this.Text53.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 4);
            this.Text53.Guid = "d9e3cfc7ea47471e81d4c35fd490447b";
            this.Text53.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text53.Name = "Text53";
            this.Text53.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text53__GetValue);
            this.Text53.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text53.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text53.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text53.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text53.Interaction = null;
            this.Text53.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text53.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text53.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text54
            // 
            this.Text54 = new Stimulsoft.Report.Components.StiText();
            this.Text54.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(26, 0, 17, 4);
            this.Text54.Editable = true;
            this.Text54.Guid = "162dea3b7cb54e8591908d0eb2ab2236";
            this.Text54.Name = "Text54";
            this.Text54.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text54.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text54.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text54.Font = new System.Drawing.Font("Arial", 8F);
            this.Text54.Interaction = null;
            this.Text54.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text54.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text54.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text55
            // 
            this.Text55 = new Stimulsoft.Report.Components.StiText();
            this.Text55.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(26, 4, 17, 6);
            this.Text55.Guid = "5e6bae82e49b4c25b5d90632487c34bf";
            this.Text55.Name = "Text55";
            this.Text55.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text55__GetValue);
            this.Text55.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text55.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text55.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text55.Interaction = null;
            this.Text55.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text55.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text55.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text56
            // 
            this.Text56 = new Stimulsoft.Report.Components.StiText();
            this.Text56.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(22, 0, 4, 4);
            this.Text56.Guid = "04a5d739be214cb095dc0c9c2e059efb";
            this.Text56.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text56.Name = "Text56";
            this.Text56.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text56__GetValue);
            this.Text56.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text56.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text56.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text56.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text56.Interaction = null;
            this.Text56.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text56.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text56.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel18.Interaction = null;
            // 
            // Panel19
            // 
            this.Panel19 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel19.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 104, 43, 10);
            this.Panel19.Guid = "8f654cde3b6644069a98333b73b73f95";
            this.Panel19.Name = "Panel19";
            this.Panel19.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel19.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text57
            // 
            this.Text57 = new Stimulsoft.Report.Components.StiText();
            this.Text57.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 43, 4);
            this.Text57.Guid = "edff8e889e0547e78123053661100bb9";
            this.Text57.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text57.Name = "Text57";
            this.Text57.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text57__GetValue);
            this.Text57.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text57.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text57.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text57.Font = new System.Drawing.Font("BPG Glaho Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text57.Interaction = null;
            this.Text57.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text57.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text57.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text59
            // 
            this.Text59 = new Stimulsoft.Report.Components.StiText();
            this.Text59.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4, 43, 4);
            this.Text59.Guid = "16e55f44e72e41349ff7ce30234d80e4";
            this.Text59.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text59.Name = "Text59";
            this.Text59.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text59__GetValue);
            this.Text59.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text59.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text59.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text59.Interaction = null;
            this.Text59.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text59.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text59.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel19.Interaction = null;
            // 
            // Panel20
            // 
            this.Panel20 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel20.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(45, 104, 48, 10);
            this.Panel20.Guid = "d13aea08a0fa4a7e9e9fb3b534c5eaf9";
            this.Panel20.Name = "Panel20";
            this.Panel20.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel20.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // TextInCells6
            // 
            this.TextInCells6 = new Stimulsoft.Report.Components.StiTextInCells();
            this.TextInCells6.CellHeight = 4F;
            this.TextInCells6.CellWidth = 13F;
            this.TextInCells6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 42, 6);
            this.TextInCells6.Editable = true;
            this.TextInCells6.Guid = "de48f3faf78a48baa65545d400b46cee";
            this.TextInCells6.Name = "TextInCells6";
            this.TextInCells6.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.TextInCells6.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.TextInCells6.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.TextInCells6.Interaction = null;
            this.TextInCells6.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.TextInCells6.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.TextInCells6.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text58
            // 
            this.Text58 = new Stimulsoft.Report.Components.StiText();
            this.Text58.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 4);
            this.Text58.Guid = "cbdfce0e51eb49afbfbf50b9420ee91f";
            this.Text58.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text58.Name = "Text58";
            this.Text58.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text58__GetValue);
            this.Text58.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text58.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text58.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text58.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text58.Interaction = null;
            this.Text58.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text58.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text58.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text60
            // 
            this.Text60 = new Stimulsoft.Report.Components.StiText();
            this.Text60.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4, 48, 4);
            this.Text60.Guid = "a1939a61b2bf4122ba9ec6775a1324d1";
            this.Text60.Name = "Text60";
            this.Text60.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text60__GetValue);
            this.Text60.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text60.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text60.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text60.Interaction = null;
            this.Text60.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text60.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text60.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel20.Interaction = null;
            // 
            // Panel21
            // 
            this.Panel21 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel21.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(97, 104, 50, 10);
            this.Panel21.Guid = "f80f3f5d8da844ed9e1a3fddbde586ed";
            this.Panel21.Name = "Panel21";
            this.Panel21.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel21.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text61
            // 
            this.Text61 = new Stimulsoft.Report.Components.StiText();
            this.Text61.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 4);
            this.Text61.Guid = "dacef9190e0c48628ad3fc419c853e90";
            this.Text61.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text61.Name = "Text61";
            this.Text61.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text61__GetValue);
            this.Text61.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text61.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text61.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text61.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text61.Interaction = null;
            this.Text61.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text61.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text61.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text62
            // 
            this.Text62 = new Stimulsoft.Report.Components.StiText();
            this.Text62.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4, 50, 4);
            this.Text62.Guid = "98fe332a704d400e84cca2ee361cdc5f";
            this.Text62.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text62.Name = "Text62";
            this.Text62.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text62__GetValue);
            this.Text62.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text62.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text62.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text62.Interaction = null;
            this.Text62.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text62.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text62.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text63
            // 
            this.Text63 = new Stimulsoft.Report.Components.StiText();
            this.Text63.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 23, 4);
            this.Text63.Editable = true;
            this.Text63.Guid = "fa2d9eb991db47c5a307d00b3ef1442f";
            this.Text63.Name = "Text63";
            this.Text63.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text63.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text63.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text63.Font = new System.Drawing.Font("Arial", 8F);
            this.Text63.Interaction = null;
            this.Text63.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text63.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text63.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text64
            // 
            this.Text64 = new Stimulsoft.Report.Components.StiText();
            this.Text64.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(27, 0, 23, 4);
            this.Text64.Editable = true;
            this.Text64.Guid = "4b7cac5d1fb9470c88af989aefe1f0c8";
            this.Text64.Name = "Text64";
            this.Text64.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text64.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text64.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text64.Font = new System.Drawing.Font("Arial", 8F);
            this.Text64.Interaction = null;
            this.Text64.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text64.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text64.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel21.Interaction = null;
            // 
            // Panel22
            // 
            this.Panel22 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel22.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(152, 104, 42, 10);
            this.Panel22.Guid = "3c7b671c34e648279c75c761fd58ae55";
            this.Panel22.Name = "Panel22";
            this.Panel22.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel22.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // TextInCells7
            // 
            this.TextInCells7 = new Stimulsoft.Report.Components.StiTextInCells();
            this.TextInCells7.CellHeight = 4F;
            this.TextInCells7.CellWidth = 4F;
            this.TextInCells7.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 38, 6.1);
            this.TextInCells7.Editable = true;
            this.TextInCells7.Guid = "3f669adbfc464777886c817c45146e7a";
            this.TextInCells7.Name = "TextInCells7";
            this.TextInCells7.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.TextInCells7.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.TextInCells7.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.TextInCells7.Interaction = null;
            this.TextInCells7.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.TextInCells7.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.TextInCells7.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text65
            // 
            this.Text65 = new Stimulsoft.Report.Components.StiText();
            this.Text65.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4, 42, 4.1);
            this.Text65.Guid = "926d67a29d274aba99652e176a908094";
            this.Text65.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text65.Name = "Text65";
            this.Text65.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text65__GetValue);
            this.Text65.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text65.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text65.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text65.Interaction = null;
            this.Text65.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text65.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text65.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text66
            // 
            this.Text66 = new Stimulsoft.Report.Components.StiText();
            this.Text66.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 4);
            this.Text66.Guid = "a08790ca05eb45b2b4b2b64d3c834b96";
            this.Text66.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text66.Name = "Text66";
            this.Text66.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text66__GetValue);
            this.Text66.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text66.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text66.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text66.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text66.Interaction = null;
            this.Text66.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text66.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text66.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel22.Interaction = null;
            this.DataSP_GetRptSalesOrderHeader.Guid = null;
            this.DataSP_GetRptSalesOrderHeader.Interaction = null;
            this.DataSP_GetRptSalesOrderHeader.MasterComponent = null;
            // 
            // HeaderSP_GetSalesOrderDetail
            // 
            this.HeaderSP_GetSalesOrderDetail = new Stimulsoft.Report.Components.StiHeaderBand();
            this.HeaderSP_GetSalesOrderDetail.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 128, 196, 25);
            this.HeaderSP_GetSalesOrderDetail.Name = "HeaderSP_GetSalesOrderDetail";
            this.HeaderSP_GetSalesOrderDetail.PrintIfEmpty = true;
            this.HeaderSP_GetSalesOrderDetail.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.HeaderSP_GetSalesOrderDetail.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text67
            // 
            this.Text67 = new Stimulsoft.Report.Components.StiText();
            this.Text67.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 5, 9, 15);
            this.Text67.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text67.Name = "Text67";
            this.Text67.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text67__GetValue);
            this.Text67.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text67.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text67.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text67.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text67.Guid = null;
            this.Text67.Interaction = null;
            this.Text67.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text67.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text67.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text68
            // 
            this.Text68 = new Stimulsoft.Report.Components.StiText();
            this.Text68.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9, 5, 70, 15);
            this.Text68.Guid = "a20b254ff6cd42d58eddda5758f2cb79";
            this.Text68.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text68.Name = "Text68";
            this.Text68.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text68__GetValue);
            this.Text68.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text68.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text68.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text68.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text68.Interaction = null;
            this.Text68.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text68.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text68.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text69
            // 
            this.Text69 = new Stimulsoft.Report.Components.StiText();
            this.Text69.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(79, 5, 13, 15);
            this.Text69.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text69.Name = "Text69";
            this.Text69.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text69__GetValue);
            this.Text69.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text69.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text69.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text69.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text69.Guid = null;
            this.Text69.Interaction = null;
            this.Text69.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text69.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text69.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text70
            // 
            this.Text70 = new Stimulsoft.Report.Components.StiText();
            this.Text70.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(92, 5, 14, 15);
            this.Text70.Guid = "3374f27b50a3457bb81dc1f4396b163a";
            this.Text70.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text70.Name = "Text70";
            this.Text70.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text70__GetValue);
            this.Text70.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text70.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text70.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text70.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text70.Interaction = null;
            this.Text70.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text70.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text70.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text71
            // 
            this.Text71 = new Stimulsoft.Report.Components.StiText();
            this.Text71.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(106, 5, 28, 9);
            this.Text71.Guid = "acb2e204fc054bef8250a26b37ce4d51";
            this.Text71.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text71.Name = "Text71";
            this.Text71.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text71__GetValue);
            this.Text71.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text71.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text71.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text71.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text71.Interaction = null;
            this.Text71.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text71.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text71.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text72
            // 
            this.Text72 = new Stimulsoft.Report.Components.StiText();
            this.Text72.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(106, 14, 17, 6);
            this.Text72.Guid = "c87b8ead6f7b4c5ca6826c604811b062";
            this.Text72.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text72.Name = "Text72";
            this.Text72.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text72__GetValue);
            this.Text72.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text72.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text72.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text72.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text72.Interaction = null;
            this.Text72.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text72.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text72.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text73
            // 
            this.Text73 = new Stimulsoft.Report.Components.StiText();
            this.Text73.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(123, 14, 11, 6);
            this.Text73.Guid = "9fef83585cb546fb926813a25d57053b";
            this.Text73.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text73.Name = "Text73";
            this.Text73.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text73__GetValue);
            this.Text73.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text73.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text73.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text73.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text73.Interaction = null;
            this.Text73.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text73.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text73.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text74
            // 
            this.Text74 = new Stimulsoft.Report.Components.StiText();
            this.Text74.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(134, 5, 33, 9);
            this.Text74.Guid = "6ee5f8030ab54c849615e333b37c80e0";
            this.Text74.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text74.Name = "Text74";
            this.Text74.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text74__GetValue);
            this.Text74.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text74.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text74.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text74.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text74.Interaction = null;
            this.Text74.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text74.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text74.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text75
            // 
            this.Text75 = new Stimulsoft.Report.Components.StiText();
            this.Text75.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(134, 14, 19, 6);
            this.Text75.Guid = "256ec0d203ef416ebc32df9361f1e689";
            this.Text75.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text75.Name = "Text75";
            this.Text75.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text75__GetValue);
            this.Text75.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text75.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text75.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text75.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text75.Interaction = null;
            this.Text75.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text75.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text75.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text76
            // 
            this.Text76 = new Stimulsoft.Report.Components.StiText();
            this.Text76.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(153, 14, 14, 6);
            this.Text76.Guid = "674fd8e159a54799b9cc3c29e532d2ca";
            this.Text76.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text76.Name = "Text76";
            this.Text76.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text76__GetValue);
            this.Text76.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text76.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text76.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text76.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text76.Interaction = null;
            this.Text76.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text76.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text76.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text77
            // 
            this.Text77 = new Stimulsoft.Report.Components.StiText();
            this.Text77.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(167, 5, 13, 15);
            this.Text77.Guid = "ac0071c9c731443bb0242e3c20d533fc";
            this.Text77.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text77.Name = "Text77";
            this.Text77.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text77__GetValue);
            this.Text77.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text77.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text77.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text77.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text77.Interaction = null;
            this.Text77.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text77.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text77.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text78
            // 
            this.Text78 = new Stimulsoft.Report.Components.StiText();
            this.Text78.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(180, 5, 16, 15);
            this.Text78.Guid = "d0502296d870444b81b0f2ff60fa0064";
            this.Text78.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text78.Name = "Text78";
            this.Text78.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text78__GetValue);
            this.Text78.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text78.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text78.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text78.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text78.Interaction = null;
            this.Text78.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text78.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text78.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text79
            // 
            this.Text79 = new Stimulsoft.Report.Components.StiText();
            this.Text79.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 20, 9, 5);
            this.Text79.Guid = "bdf4b59b81184f408e4174945e5d83be";
            this.Text79.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text79.Name = "Text79";
            this.Text79.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text79__GetValue);
            this.Text79.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text79.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text79.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text79.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text79.Interaction = null;
            this.Text79.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text79.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text79.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text80
            // 
            this.Text80 = new Stimulsoft.Report.Components.StiText();
            this.Text80.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9, 20, 70, 5);
            this.Text80.Guid = "13fea860fcc94e4e90fe54843f32ef97";
            this.Text80.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text80.Name = "Text80";
            this.Text80.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text80__GetValue);
            this.Text80.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text80.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text80.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text80.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text80.Interaction = null;
            this.Text80.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text80.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text80.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text81
            // 
            this.Text81 = new Stimulsoft.Report.Components.StiText();
            this.Text81.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(79, 20, 13, 5);
            this.Text81.Guid = "fc1165c782ae4778891789e193dbd50e";
            this.Text81.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text81.Name = "Text81";
            this.Text81.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text81__GetValue);
            this.Text81.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text81.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text81.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text81.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text81.Interaction = null;
            this.Text81.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text81.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text81.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text82
            // 
            this.Text82 = new Stimulsoft.Report.Components.StiText();
            this.Text82.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(92, 20, 14, 5);
            this.Text82.Guid = "cd0f420408644412b561912269ea4ce9";
            this.Text82.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text82.Name = "Text82";
            this.Text82.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text82__GetValue);
            this.Text82.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text82.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text82.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text82.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text82.Interaction = null;
            this.Text82.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text82.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text82.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text83
            // 
            this.Text83 = new Stimulsoft.Report.Components.StiText();
            this.Text83.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(106, 20, 28, 5);
            this.Text83.Guid = "81a2178ee7744a13be6a29c59801ea8d";
            this.Text83.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text83.Name = "Text83";
            this.Text83.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text83__GetValue);
            this.Text83.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text83.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text83.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text83.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text83.Interaction = null;
            this.Text83.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text83.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text83.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text84
            // 
            this.Text84 = new Stimulsoft.Report.Components.StiText();
            this.Text84.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(134, 20, 33, 5);
            this.Text84.Guid = "0dca2824d5a34d31ada1e461ec21e8aa";
            this.Text84.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text84.Name = "Text84";
            this.Text84.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text84__GetValue);
            this.Text84.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text84.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text84.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text84.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text84.Interaction = null;
            this.Text84.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text84.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text84.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text85
            // 
            this.Text85 = new Stimulsoft.Report.Components.StiText();
            this.Text85.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(167, 20, 13, 5);
            this.Text85.Guid = "b0f8d3c5d27a44f3ba6dea678c0a895e";
            this.Text85.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text85.Name = "Text85";
            this.Text85.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text85__GetValue);
            this.Text85.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text85.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text85.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text85.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text85.Interaction = null;
            this.Text85.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text85.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text85.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text86
            // 
            this.Text86 = new Stimulsoft.Report.Components.StiText();
            this.Text86.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(180, 20, 16, 5);
            this.Text86.Guid = "1ae2be908d7749db8d9b9d28a7d56dc8";
            this.Text86.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text86.Name = "Text86";
            this.Text86.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text86__GetValue);
            this.Text86.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text86.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text86.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text86.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text86.Interaction = null;
            this.Text86.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text86.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text86.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.HeaderSP_GetSalesOrderDetail.Guid = null;
            this.HeaderSP_GetSalesOrderDetail.Interaction = null;
            // 
            // DataSP_GetSalesOrderDetail
            // 
            this.DataSP_GetSalesOrderDetail = new Stimulsoft.Report.Components.StiDataBand();
            this.DataSP_GetSalesOrderDetail.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 161, 196, 6);
            this.DataSP_GetSalesOrderDetail.DataRelationName = "SP_GetRptSalesOrderHeader_SP_GetSalesOrderDetail";
            this.DataSP_GetSalesOrderDetail.DataSourceName = "SP_GetSalesOrderDetail";
            this.DataSP_GetSalesOrderDetail.Name = "DataSP_GetSalesOrderDetail";
            this.DataSP_GetSalesOrderDetail.Sort = new System.String[] {
                    "ASC",
                    "OrdinalNumber"};
            this.DataSP_GetSalesOrderDetail.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataSP_GetSalesOrderDetail.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.DataSP_GetSalesOrderDetail.BusinessObjectGuid = null;
            // 
            // Text87
            // 
            this.Text87 = new Stimulsoft.Report.Components.StiText();
            this.Text87.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 9, 6);
            this.Text87.Guid = "529374f859b04e6db998dc4dfe42eec7";
            this.Text87.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text87.Name = "Text87";
            this.Text87.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text87__GetValue);
            this.Text87.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text87.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text87.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text87.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text87.Interaction = null;
            this.Text87.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text87.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text87.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text88
            // 
            this.Text88 = new Stimulsoft.Report.Components.StiText();
            this.Text88.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9, 0, 70, 6);
            this.Text88.Guid = "c9a1a78d18a940b880913677fd46852a";
            this.Text88.Name = "Text88";
            this.Text88.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text88__GetValue);
            this.Text88.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text88.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text88.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text88.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text88.Interaction = null;
            this.Text88.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text88.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text88.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.EllipsisCharacter);
            // 
            // Text89
            // 
            this.Text89 = new Stimulsoft.Report.Components.StiText();
            this.Text89.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(79, 0, 13, 6);
            this.Text89.Guid = "27a0330b78ad45b6859f8ed012f1e006";
            this.Text89.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text89.Name = "Text89";
            this.Text89.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text89__GetValue);
            this.Text89.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text89.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text89.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text89.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text89.Interaction = null;
            this.Text89.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text89.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text89.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text90
            // 
            this.Text90 = new Stimulsoft.Report.Components.StiText();
            this.Text90.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(92, 0, 14, 6);
            this.Text90.Guid = "08d12f5993a740c69052dcc102da8d4b";
            this.Text90.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text90.Name = "Text90";
            this.Text90.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text90__GetValue);
            this.Text90.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text90.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text90.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text90.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text90.Interaction = null;
            this.Text90.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text90.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text90.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            this.Text90.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text91
            // 
            this.Text91 = new Stimulsoft.Report.Components.StiText();
            this.Text91.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(106, 0, 17, 6);
            this.Text91.Guid = "9b68388061a94419bd24a98575d80d86";
            this.Text91.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text91.Name = "Text91";
            this.Text91.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text91__GetValue);
            this.Text91.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text91.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text91.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text91.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text91.Interaction = null;
            this.Text91.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text91.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text91.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text92
            // 
            this.Text92 = new Stimulsoft.Report.Components.StiText();
            this.Text92.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(123, 0, 11, 6);
            this.Text92.Guid = "666790d524c841dea0fb4197c5850fc5";
            this.Text92.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text92.Name = "Text92";
            this.Text92.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text92__GetValue);
            this.Text92.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text92.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text92.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text92.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text92.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text92.Interaction = null;
            this.Text92.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text92.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text92.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiCustomFormatService("0000");
            this.Text92.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text93
            // 
            this.Text93 = new Stimulsoft.Report.Components.StiText();
            this.Text93.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(134, 0, 19, 6);
            this.Text93.Guid = "cb7a8423c7f348eaa377e2e99212e57f";
            this.Text93.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text93.Name = "Text93";
            this.Text93.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text93__GetValue);
            this.Text93.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text93.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text93.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text93.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text93.Interaction = null;
            this.Text93.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text93.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text93.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text94
            // 
            this.Text94 = new Stimulsoft.Report.Components.StiText();
            this.Text94.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(153, 0, 14, 6);
            this.Text94.Guid = "b554d40b15ed47c6aa9b3be93fd109ae";
            this.Text94.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text94.Name = "Text94";
            this.Text94.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text94__GetValue);
            this.Text94.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text94.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text94.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text94.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text94.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text94.Interaction = null;
            this.Text94.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text94.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text94.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiCustomFormatService("0000");
            this.Text94.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text95
            // 
            this.Text95 = new Stimulsoft.Report.Components.StiText();
            this.Text95.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(167, 0, 13, 6);
            this.Text95.Guid = "498a9fc9862943b9aead8d540cf65842";
            this.Text95.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text95.Name = "Text95";
            this.Text95.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text95.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text95.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text95.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text95.Interaction = null;
            this.Text95.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text95.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text95.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text96
            // 
            this.Text96 = new Stimulsoft.Report.Components.StiText();
            this.Text96.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(180, 0, 16, 6);
            this.Text96.Guid = "40532c8b890647199f8302428c7e33bf";
            this.Text96.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text96.Name = "Text96";
            this.Text96.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text96.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text96.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text96.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text96.Interaction = null;
            this.Text96.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text96.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text96.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            this.Text96.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.DataSP_GetSalesOrderDetail.Guid = null;
            this.DataSP_GetSalesOrderDetail.Interaction = null;
            // 
            // HeaderEnclosureText
            // 
            this.HeaderEnclosureText = new Stimulsoft.Report.Components.StiHeaderBand();
            this.HeaderEnclosureText.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 175, 196, 18);
            this.HeaderEnclosureText.Name = "HeaderEnclosureText";
            this.HeaderEnclosureText.PrintIfEmpty = true;
            this.HeaderEnclosureText.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.HeaderEnclosureText.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text180
            // 
            this.Text180 = new Stimulsoft.Report.Components.StiText();
            this.Text180.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 9, 6);
            this.Text180.Guid = "ac0493482574416e9cbdf65f49682388";
            this.Text180.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text180.Name = "Text180";
            this.Text180.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text180.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text180.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text180.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text180.Interaction = null;
            this.Text180.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text180.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text180.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.InitializeComponent3();
        }

        public void InitializeComponent3()
        {
            // 
            // Text181
            // 
            this.Text181 = new Stimulsoft.Report.Components.StiText();
            this.Text181.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9, 0, 70, 6);
            this.Text181.Guid = "8d7f7adc6f794adc9f8acb540434f4a9";
            this.Text181.Name = "Text181";
            this.Text181.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text181__GetValue);
            this.Text181.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text181.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text181.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text181.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text181.Interaction = null;
            this.Text181.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text181.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text181.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text182
            // 
            this.Text182 = new Stimulsoft.Report.Components.StiText();
            this.Text182.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(79, 0, 13, 6);
            this.Text182.Guid = "05f34b3a4f654acc8c3879037e85667a";
            this.Text182.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text182.Name = "Text182";
            this.Text182.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text182.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text182.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text182.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text182.Interaction = null;
            this.Text182.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text182.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text182.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text183
            // 
            this.Text183 = new Stimulsoft.Report.Components.StiText();
            this.Text183.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(92, 0, 14, 6);
            this.Text183.Guid = "79a5072e9e954f499590f5a79f8ffa2a";
            this.Text183.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text183.Name = "Text183";
            this.Text183.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text183.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text183.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text183.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text183.Interaction = null;
            this.Text183.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text183.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text183.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            this.Text183.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text184
            // 
            this.Text184 = new Stimulsoft.Report.Components.StiText();
            this.Text184.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(106, 0, 17, 6);
            this.Text184.Guid = "d4520c5775ef414899a11b9f18255d67";
            this.Text184.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text184.Name = "Text184";
            this.Text184.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text184.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text184.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text184.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text184.Interaction = null;
            this.Text184.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text184.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text184.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text185
            // 
            this.Text185 = new Stimulsoft.Report.Components.StiText();
            this.Text185.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(123, 0, 11, 6);
            this.Text185.Guid = "7d748c1234f64353afc41076a4d67307";
            this.Text185.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text185.Name = "Text185";
            this.Text185.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text185.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text185.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text185.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text185.Interaction = null;
            this.Text185.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text185.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text185.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text186
            // 
            this.Text186 = new Stimulsoft.Report.Components.StiText();
            this.Text186.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(134, 0, 19, 6);
            this.Text186.Guid = "cb46101dda3d440f93065c251b115231";
            this.Text186.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text186.Name = "Text186";
            this.Text186.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text186.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text186.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text186.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text186.Interaction = null;
            this.Text186.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text186.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text186.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text187
            // 
            this.Text187 = new Stimulsoft.Report.Components.StiText();
            this.Text187.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(153, 0, 14, 6);
            this.Text187.Guid = "d05c99e116344a34b4c9e28f903fdd61";
            this.Text187.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text187.Name = "Text187";
            this.Text187.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text187.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text187.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text187.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text187.Interaction = null;
            this.Text187.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text187.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text187.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text188
            // 
            this.Text188 = new Stimulsoft.Report.Components.StiText();
            this.Text188.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(167, 0, 13, 6);
            this.Text188.Guid = "bcd15930d87a41c4a29a59bc5be55dc9";
            this.Text188.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text188.Name = "Text188";
            this.Text188.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text188.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text188.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text188.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text188.Interaction = null;
            this.Text188.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text188.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text188.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text189
            // 
            this.Text189 = new Stimulsoft.Report.Components.StiText();
            this.Text189.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(180, 0, 16, 6);
            this.Text189.Guid = "304b3ae47c084706a8706b7965113a42";
            this.Text189.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text189.Name = "Text189";
            this.Text189.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text189.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text189.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text189.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text189.Interaction = null;
            this.Text189.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text189.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text189.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            this.Text189.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text190
            // 
            this.Text190 = new Stimulsoft.Report.Components.StiText();
            this.Text190.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 6, 9, 6);
            this.Text190.Guid = "5a370fe3956a47b4a94354c404d49b34";
            this.Text190.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text190.Name = "Text190";
            this.Text190.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text190.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text190.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text190.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text190.Interaction = null;
            this.Text190.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text190.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text190.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text191
            // 
            this.Text191 = new Stimulsoft.Report.Components.StiText();
            this.Text191.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9, 6, 70, 6);
            this.Text191.Guid = "5a4ace346265473eb5a18ffffc40bbbd";
            this.Text191.Name = "Text191";
            this.Text191.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text191__GetValue);
            this.Text191.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text191.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text191.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text191.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text191.Interaction = null;
            this.Text191.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text191.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text191.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text192
            // 
            this.Text192 = new Stimulsoft.Report.Components.StiText();
            this.Text192.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(79, 6, 13, 6);
            this.Text192.Guid = "8be3430996d34629acf54f3d4e4afd65";
            this.Text192.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text192.Name = "Text192";
            this.Text192.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text192.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text192.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text192.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text192.Interaction = null;
            this.Text192.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text192.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text192.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text193
            // 
            this.Text193 = new Stimulsoft.Report.Components.StiText();
            this.Text193.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(92, 6, 14, 6);
            this.Text193.Guid = "0406d0d09a034eaab93ccc143ae11ff8";
            this.Text193.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text193.Name = "Text193";
            this.Text193.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text193.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text193.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text193.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text193.Interaction = null;
            this.Text193.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text193.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text193.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            this.Text193.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text194
            // 
            this.Text194 = new Stimulsoft.Report.Components.StiText();
            this.Text194.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(106, 6, 17, 6);
            this.Text194.Guid = "f0429772f335435893fb5831fee13c95";
            this.Text194.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text194.Name = "Text194";
            this.Text194.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text194.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text194.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text194.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text194.Interaction = null;
            this.Text194.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text194.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text194.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text195
            // 
            this.Text195 = new Stimulsoft.Report.Components.StiText();
            this.Text195.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(123, 6, 11, 6);
            this.Text195.Guid = "1412580d5de04e9a8da7dac19fed8f55";
            this.Text195.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text195.Name = "Text195";
            this.Text195.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text195.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text195.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text195.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text195.Interaction = null;
            this.Text195.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text195.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text195.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text196
            // 
            this.Text196 = new Stimulsoft.Report.Components.StiText();
            this.Text196.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(134, 6, 19, 6);
            this.Text196.Guid = "4ab3ad91516d44d4b4c9c7e47be8c789";
            this.Text196.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text196.Name = "Text196";
            this.Text196.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text196.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text196.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text196.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text196.Interaction = null;
            this.Text196.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text196.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text196.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text197
            // 
            this.Text197 = new Stimulsoft.Report.Components.StiText();
            this.Text197.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(153, 6, 14, 6);
            this.Text197.Guid = "b42d5e4823094b49a5c414d9d9cccf29";
            this.Text197.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text197.Name = "Text197";
            this.Text197.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text197.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text197.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text197.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text197.Interaction = null;
            this.Text197.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text197.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text197.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text198
            // 
            this.Text198 = new Stimulsoft.Report.Components.StiText();
            this.Text198.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(167, 6, 13, 6);
            this.Text198.Guid = "794a7615eea54b3a8be06765b3d66e22";
            this.Text198.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text198.Name = "Text198";
            this.Text198.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text198.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text198.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text198.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text198.Interaction = null;
            this.Text198.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text198.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text198.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text199
            // 
            this.Text199 = new Stimulsoft.Report.Components.StiText();
            this.Text199.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(180, 6, 16, 6);
            this.Text199.Guid = "a192ef5ac6014abab4761c7f290f526f";
            this.Text199.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text199.Name = "Text199";
            this.Text199.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text199.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text199.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text199.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text199.Interaction = null;
            this.Text199.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text199.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text199.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            this.Text199.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text200
            // 
            this.Text200 = new Stimulsoft.Report.Components.StiText();
            this.Text200.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 12, 9, 6);
            this.Text200.Guid = "ef91256c881b44d99ac3166493061855";
            this.Text200.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text200.Name = "Text200";
            this.Text200.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text200.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text200.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text200.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text200.Interaction = null;
            this.Text200.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text200.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text200.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text201
            // 
            this.Text201 = new Stimulsoft.Report.Components.StiText();
            this.Text201.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9, 12, 70, 6);
            this.Text201.Guid = "5ca5296e90d0472da8032b4c7060f39e";
            this.Text201.Name = "Text201";
            this.Text201.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text201__GetValue);
            this.Text201.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text201.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text201.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text201.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text201.Interaction = null;
            this.Text201.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text201.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text201.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text202
            // 
            this.Text202 = new Stimulsoft.Report.Components.StiText();
            this.Text202.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(79, 12, 13, 6);
            this.Text202.Guid = "49fd2dc4b5274463a4a8d12f9b28e7f5";
            this.Text202.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text202.Name = "Text202";
            this.Text202.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text202.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text202.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text202.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text202.Interaction = null;
            this.Text202.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text202.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text202.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text203
            // 
            this.Text203 = new Stimulsoft.Report.Components.StiText();
            this.Text203.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(92, 12, 14, 6);
            this.Text203.Guid = "b8997aefe258479ebeac25d69a71d987";
            this.Text203.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text203.Name = "Text203";
            this.Text203.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text203.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text203.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text203.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text203.Interaction = null;
            this.Text203.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text203.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text203.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            this.Text203.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text204
            // 
            this.Text204 = new Stimulsoft.Report.Components.StiText();
            this.Text204.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(106, 12, 17, 6);
            this.Text204.Guid = "2193d9ca8a214c54900874002ba3638c";
            this.Text204.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text204.Name = "Text204";
            this.Text204.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text204.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text204.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text204.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text204.Interaction = null;
            this.Text204.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text204.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text204.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text205
            // 
            this.Text205 = new Stimulsoft.Report.Components.StiText();
            this.Text205.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(123, 12, 11, 6);
            this.Text205.Guid = "de204119256c4295b0deefac0c0662fb";
            this.Text205.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text205.Name = "Text205";
            this.Text205.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text205.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text205.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text205.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text205.Interaction = null;
            this.Text205.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text205.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text205.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text206
            // 
            this.Text206 = new Stimulsoft.Report.Components.StiText();
            this.Text206.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(134, 12, 19, 6);
            this.Text206.Guid = "2cf7ce082df549368cf03f746f061791";
            this.Text206.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text206.Name = "Text206";
            this.Text206.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text206.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text206.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text206.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text206.Interaction = null;
            this.Text206.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text206.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text206.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text207
            // 
            this.Text207 = new Stimulsoft.Report.Components.StiText();
            this.Text207.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(153, 12, 14, 6);
            this.Text207.Guid = "0b0c31478c4342fbbb52713494b1b4b6";
            this.Text207.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text207.Name = "Text207";
            this.Text207.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text207.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text207.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text207.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text207.Interaction = null;
            this.Text207.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text207.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text207.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text208
            // 
            this.Text208 = new Stimulsoft.Report.Components.StiText();
            this.Text208.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(167, 12, 13, 6);
            this.Text208.Guid = "9bf65299dc5941b39b83c2017e4efece";
            this.Text208.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text208.Name = "Text208";
            this.Text208.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text208.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text208.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text208.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text208.Interaction = null;
            this.Text208.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text208.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text208.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text209
            // 
            this.Text209 = new Stimulsoft.Report.Components.StiText();
            this.Text209.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(180, 12, 16, 6);
            this.Text209.Guid = "d5b415445f2a4a8b9ebaeec7df7182ab";
            this.Text209.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text209.Name = "Text209";
            this.Text209.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text209.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text209.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text209.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text209.Interaction = null;
            this.Text209.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text209.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text209.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            this.Text209.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.HeaderEnclosureText.Guid = null;
            this.HeaderEnclosureText.Interaction = null;
            // 
            // DataEmptyRow
            // 
            this.DataEmptyRow = new Stimulsoft.Report.Components.StiDataBand();
            this.DataEmptyRow.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 201, 196, 6);
            this.DataEmptyRow.Name = "DataEmptyRow";
            this.DataEmptyRow.Sort = new System.String[0];
            this.DataEmptyRow.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataEmptyRow.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text210
            // 
            this.Text210 = new Stimulsoft.Report.Components.StiText();
            this.Text210.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 9, 6);
            this.Text210.Guid = "0c820d421d504acfacc5fa379dbf4ef1";
            this.Text210.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text210.Name = "Text210";
            this.Text210.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text210.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text210.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text210.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text210.Interaction = null;
            this.Text210.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text210.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text210.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text211
            // 
            this.Text211 = new Stimulsoft.Report.Components.StiText();
            this.Text211.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9, 0, 70, 6);
            this.Text211.Guid = "aa1af142832b4d88b4afad775a878b73";
            this.Text211.Name = "Text211";
            this.Text211.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text211.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text211.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text211.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text211.Interaction = null;
            this.Text211.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text211.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text211.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text212
            // 
            this.Text212 = new Stimulsoft.Report.Components.StiText();
            this.Text212.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(79, 0, 13, 6);
            this.Text212.Guid = "543cc717b6f049cbbffdbe74f0d5e48f";
            this.Text212.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text212.Name = "Text212";
            this.Text212.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text212.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text212.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text212.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text212.Interaction = null;
            this.Text212.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text212.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text212.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text213
            // 
            this.Text213 = new Stimulsoft.Report.Components.StiText();
            this.Text213.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(92, 0, 14, 6);
            this.Text213.Guid = "8c367c2a1e7b4d61a2fc40e702809404";
            this.Text213.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text213.Name = "Text213";
            this.Text213.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text213.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text213.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text213.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text213.Interaction = null;
            this.Text213.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text213.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text213.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            this.Text213.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text214
            // 
            this.Text214 = new Stimulsoft.Report.Components.StiText();
            this.Text214.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(106, 0, 17, 6);
            this.Text214.Guid = "b63b8d0ca2ca4098b0ff2a7f8779bdd8";
            this.Text214.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text214.Name = "Text214";
            this.Text214.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text214.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text214.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text214.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text214.Interaction = null;
            this.Text214.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text214.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text214.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text215
            // 
            this.Text215 = new Stimulsoft.Report.Components.StiText();
            this.Text215.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(123, 0, 11, 6);
            this.Text215.Guid = "a8a9f1479f7f43cc81555be57ae00f00";
            this.Text215.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text215.Name = "Text215";
            this.Text215.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text215.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text215.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text215.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text215.Interaction = null;
            this.Text215.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text215.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text215.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text216
            // 
            this.Text216 = new Stimulsoft.Report.Components.StiText();
            this.Text216.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(134, 0, 19, 6);
            this.Text216.Guid = "9502a548eae64725b63aa8bbebee0c7c";
            this.Text216.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text216.Name = "Text216";
            this.Text216.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text216.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text216.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text216.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text216.Interaction = null;
            this.Text216.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text216.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text216.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text217
            // 
            this.Text217 = new Stimulsoft.Report.Components.StiText();
            this.Text217.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(153, 0, 14, 6);
            this.Text217.Guid = "9d945226c8df4dbe96bdf8d5cfe36027";
            this.Text217.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text217.Name = "Text217";
            this.Text217.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text217.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text217.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text217.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text217.Interaction = null;
            this.Text217.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text217.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text217.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text218
            // 
            this.Text218 = new Stimulsoft.Report.Components.StiText();
            this.Text218.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(167, 0, 13, 6);
            this.Text218.Guid = "e44963f99514475483d49e819fce0dfa";
            this.Text218.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text218.Name = "Text218";
            this.Text218.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text218.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text218.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text218.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text218.Interaction = null;
            this.Text218.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text218.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text218.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text219
            // 
            this.Text219 = new Stimulsoft.Report.Components.StiText();
            this.Text219.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(180, 0, 16, 6);
            this.Text219.Guid = "9ca4d1b2234042a6b4386f27483e4536";
            this.Text219.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text219.Name = "Text219";
            this.Text219.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text219.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text219.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text219.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text219.Interaction = null;
            this.Text219.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text219.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text219.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            this.Text219.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.DataEmptyRow.Guid = null;
            this.DataEmptyRow.Interaction = null;
            this.DataEmptyRow.MasterComponent = null;
            // 
            // FooterSP_GetSalesOrderDetail
            // 
            this.FooterSP_GetSalesOrderDetail = new Stimulsoft.Report.Components.StiFooterBand();
            this.FooterSP_GetSalesOrderDetail.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 215, 196, 90);
            this.FooterSP_GetSalesOrderDetail.Name = "FooterSP_GetSalesOrderDetail";
            this.FooterSP_GetSalesOrderDetail.PrintIfEmpty = true;
            this.FooterSP_GetSalesOrderDetail.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Top, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.FooterSP_GetSalesOrderDetail.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text3
            // 
            this.Text3 = new Stimulsoft.Report.Components.StiText();
            this.Text3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(130, 0, 4, 4);
            this.Text3.Guid = "16e71c256c1a4505bf85b24dc98b6942";
            this.Text3.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text3.Name = "Text3";
            this.Text3.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text3__GetValue);
            this.Text3.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text3.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text3.Interaction = null;
            this.Text3.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text3.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text3.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text4
            // 
            this.Text4 = new Stimulsoft.Report.Components.StiText();
            this.Text4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(134, 0, 33, 4);
            this.Text4.Editable = true;
            this.Text4.Guid = "3642888e50cc4120b9d6ab9c6129960c";
            this.Text4.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text4.Name = "Text4";
            this.Text4.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text4__GetValue);
            this.Text4.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text4.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text4.Interaction = null;
            this.Text4.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text4.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text4.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            this.Text4.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text97
            // 
            this.Text97 = new Stimulsoft.Report.Components.StiText();
            this.Text97.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(176, 0, 4, 4);
            this.Text97.Guid = "af754e5845f043df8e33e6f6ceac7582";
            this.Text97.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text97.Name = "Text97";
            this.Text97.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text97__GetValue);
            this.Text97.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text97.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text97.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text97.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text97.Interaction = null;
            this.Text97.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text97.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text97.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text98
            // 
            this.Text98 = new Stimulsoft.Report.Components.StiText();
            this.Text98.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(180, 0, 16, 4);
            this.Text98.Editable = true;
            this.Text98.Guid = "5f5f821438f6494eb3a0aee07597e661";
            this.Text98.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text98.Name = "Text98";
            this.Text98.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text98.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text98.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text98.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text98.Interaction = null;
            this.Text98.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text98.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text98.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            this.Text98.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text99
            // 
            this.Text99 = new Stimulsoft.Report.Components.StiText();
            this.Text99.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 9, 22, 4);
            this.Text99.Name = "Text99";
            this.Text99.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text99__GetValue);
            this.Text99.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text99.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text99.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text99.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text99.Guid = null;
            this.Text99.Interaction = null;
            this.Text99.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text99.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text99.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text100
            // 
            this.Text100 = new Stimulsoft.Report.Components.StiText();
            this.Text100.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(22, 9, 34, 4);
            this.Text100.Editable = true;
            this.Text100.Name = "Text100";
            this.Text100.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text100__GetValue);
            this.Text100.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text100.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text100.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text100.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text100.Guid = null;
            this.Text100.Interaction = null;
            this.Text100.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text100.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text100.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text101
            // 
            this.Text101 = new Stimulsoft.Report.Components.StiText();
            this.Text101.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 15, 22, 4);
            this.Text101.Guid = "434b48c54fb7437fb18c2a4c5a7fa2c4";
            this.Text101.Name = "Text101";
            this.Text101.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text101__GetValue);
            this.Text101.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text101.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text101.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text101.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text101.Interaction = null;
            this.Text101.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text101.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text101.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text102
            // 
            this.Text102 = new Stimulsoft.Report.Components.StiText();
            this.Text102.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(22, 15, 34, 4);
            this.Text102.Editable = true;
            this.Text102.Guid = "422a33720b1e4c3986c7814d2fe219af";
            this.Text102.Name = "Text102";
            this.Text102.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text102__GetValue);
            this.Text102.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text102.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text102.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text102.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text102.Interaction = null;
            this.Text102.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text102.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text102.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Panel23
            // 
            this.Panel23 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel23.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 25, 134, 8);
            this.Panel23.Name = "Panel23";
            this.Panel23.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel23.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text103
            // 
            this.Text103 = new Stimulsoft.Report.Components.StiText();
            this.Text103.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 22, 4);
            this.Text103.Guid = "45c71a80768e4199ad1fc77d2bfde021";
            this.Text103.Name = "Text103";
            this.Text103.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text103__GetValue);
            this.Text103.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text103.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text103.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text103.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text103.Interaction = null;
            this.Text103.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text103.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text103.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text104
            // 
            this.Text104 = new Stimulsoft.Report.Components.StiText();
            this.Text104.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(22, 0, 112, 4);
            this.Text104.Editable = true;
            this.Text104.Guid = "68179a43cc4046cdbc7f9e42557850b3";
            this.Text104.Name = "Text104";
            this.Text104.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text104__GetValue);
            this.Text104.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text104.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text104.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text104.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text104.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Bold);
            this.Text104.Interaction = null;
            this.Text104.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text104.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text104.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text5
            // 
            this.Text5 = new Stimulsoft.Report.Components.StiText();
            this.Text5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(22, 4, 112, 4);
            this.Text5.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text5.Name = "Text5";
            this.Text5.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text5__GetValue);
            this.Text5.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text5.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text5.Guid = null;
            this.Text5.Interaction = null;
            this.Text5.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text5.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text5.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel23.Guid = null;
            this.Panel23.Interaction = null;
            // 
            // Panel24
            // 
            this.Panel24 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel24.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 35, 130, 8);
            this.Panel24.Name = "Panel24";
            this.Panel24.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel24.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text6
            // 
            this.Text6 = new Stimulsoft.Report.Components.StiText();
            this.Text6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 130, 4);
            this.Text6.Editable = true;
            this.Text6.Name = "Text6";
            this.Text6.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text6.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text6.Font = new System.Drawing.Font("Arial", 8F);
            this.Text6.Guid = null;
            this.Text6.Interaction = null;
            this.Text6.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text6.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text6.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text7
            // 
            this.Text7 = new Stimulsoft.Report.Components.StiText();
            this.Text7.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4, 128, 4);
            this.Text7.Guid = "dbe183d9eeee4fcaace7a9fa68de1d6d";
            this.Text7.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text7.Name = "Text7";
            this.Text7.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text7__GetValue);
            this.Text7.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text7.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text7.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text7.Interaction = null;
            this.Text7.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text7.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text7.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel24.Guid = null;
            this.Panel24.Interaction = null;
            // 
            // Panel25
            // 
            this.Panel25 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel25.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 45, 96, 12);
            this.Panel25.Guid = "975268051e7d45b881e3fd5368da6237";
            this.Panel25.Name = "Panel25";
            this.Panel25.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel25.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text105
            // 
            this.Text105 = new Stimulsoft.Report.Components.StiText();
            this.Text105.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 42, 10);
            this.Text105.Guid = "e7bf92d198244faaab10e8625747adf4";
            this.Text105.Name = "Text105";
            this.Text105.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text105__GetValue);
            this.Text105.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text105.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text105.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text105.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text105.Interaction = null;
            this.Text105.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text105.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text105.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text106
            // 
            this.Text106 = new Stimulsoft.Report.Components.StiText();
            this.Text106.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(44, 0, 51, 6);
            this.Text106.Editable = true;
            this.Text106.Guid = "bad50f2572c746c0bc5a62a5b2bcbfcf";
            this.Text106.Name = "Text106";
            this.Text106.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text106.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text106.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text106.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text106.Interaction = null;
            this.Text106.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text106.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text106.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text107
            // 
            this.Text107 = new Stimulsoft.Report.Components.StiText();
            this.Text107.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(44, 6, 51, 4);
            this.Text107.Guid = "1a34c97371dc4383b429eb783c838dc0";
            this.Text107.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text107.Name = "Text107";
            this.Text107.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text107__GetValue);
            this.Text107.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text107.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text107.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text107.Interaction = null;
            this.Text107.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text107.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text107.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel25.Interaction = null;
            // 
            // Panel26
            // 
            this.Panel26 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel26.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(100, 45, 96, 12);
            this.Panel26.Guid = "5feac82b9f334103bf6f260bca7ed6d2";
            this.Panel26.Name = "Panel26";
            this.Panel26.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel26.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text108
            // 
            this.Text108 = new Stimulsoft.Report.Components.StiText();
            this.Text108.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 42, 12);
            this.Text108.Guid = "d4dfc0830bbf4982a4a2c472db1998a2";
            this.Text108.Name = "Text108";
            this.Text108.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text108__GetValue);
            this.Text108.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text108.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text108.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text108.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text108.Interaction = null;
            this.Text108.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text108.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text108.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text109
            // 
            this.Text109 = new Stimulsoft.Report.Components.StiText();
            this.Text109.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(44, 0, 51, 6);
            this.Text109.Editable = true;
            this.Text109.Guid = "329e6f1f9cfb4ed29a78578920cb96a1";
            this.Text109.Name = "Text109";
            this.Text109.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text109.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text109.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text109.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text109.Interaction = null;
            this.Text109.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text109.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text109.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text110
            // 
            this.Text110 = new Stimulsoft.Report.Components.StiText();
            this.Text110.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(44, 6, 51, 4);
            this.Text110.Guid = "e4166dd1440c4522a9fa59858590812f";
            this.Text110.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text110.Name = "Text110";
            this.Text110.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text110__GetValue);
            this.InitializeComponent4();
        }

        public void InitializeComponent4()
        {
            this.Text110.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text110.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text110.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text110.Interaction = null;
            this.Text110.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text110.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text110.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel26.Interaction = null;
            // 
            // Panel27
            // 
            this.Panel27 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel27.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 59, 46, 18);
            this.Panel27.Guid = "be576177d5664af5af2ce6cec3991d0e";
            this.Panel27.Name = "Panel27";
            this.Panel27.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel27.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text111
            // 
            this.Text111 = new Stimulsoft.Report.Components.StiText();
            this.Text111.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 18, 14);
            this.Text111.Guid = "ac7b296f37ed4ac688c8cd9aa31ad1ef";
            this.Text111.Name = "Text111";
            this.Text111.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text111__GetValue);
            this.Text111.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text111.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text111.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text111.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text111.Interaction = null;
            this.Text111.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text111.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text111.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text112
            // 
            this.Text112 = new Stimulsoft.Report.Components.StiText();
            this.Text112.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(18, 0, 27, 6);
            this.Text112.Editable = true;
            this.Text112.Guid = "c98bdd9343154bd68e41c3f6314b673c";
            this.Text112.Name = "Text112";
            this.Text112.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text112.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text112.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text112.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text112.Interaction = null;
            this.Text112.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text112.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text112.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text113
            // 
            this.Text113 = new Stimulsoft.Report.Components.StiText();
            this.Text113.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(18, 6, 27, 8);
            this.Text113.Guid = "efd051d0d048411fa97353c64bbe2015";
            this.Text113.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text113.Name = "Text113";
            this.Text113.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text113__GetValue);
            this.Text113.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text113.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text113.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text113.Interaction = null;
            this.Text113.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text113.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text113.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel27.Interaction = null;
            // 
            // Panel28
            // 
            this.Panel28 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel28.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(48, 59, 48, 18);
            this.Panel28.Guid = "3a202391fedf472891a24957ce671b51";
            this.Panel28.Name = "Panel28";
            this.Panel28.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel28.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text114
            // 
            this.Text114 = new Stimulsoft.Report.Components.StiText();
            this.Text114.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 20, 14);
            this.Text114.Guid = "9932ade04b76468088c9ed8034c56a2d";
            this.Text114.Name = "Text114";
            this.Text114.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text114__GetValue);
            this.Text114.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text114.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text114.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text114.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text114.Interaction = null;
            this.Text114.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text114.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text114.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text115
            // 
            this.Text115 = new Stimulsoft.Report.Components.StiText();
            this.Text115.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(20, 0, 27, 6);
            this.Text115.Editable = true;
            this.Text115.Guid = "9aa7e28fb0934022bf66cafd69de6f5a";
            this.Text115.Name = "Text115";
            this.Text115.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text115.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text115.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text115.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text115.Interaction = null;
            this.Text115.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text115.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text115.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text116
            // 
            this.Text116 = new Stimulsoft.Report.Components.StiText();
            this.Text116.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(20, 6, 27, 12);
            this.Text116.Guid = "91c0e3db6c114f388b4524125742c79a";
            this.Text116.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text116.Name = "Text116";
            this.Text116.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text116__GetValue);
            this.Text116.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text116.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text116.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text116.Interaction = null;
            this.Text116.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text116.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text116.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel28.Interaction = null;
            // 
            // Panel29
            // 
            this.Panel29 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel29.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(100, 59, 46, 18);
            this.Panel29.Guid = "f3bde5f049fe4325b78fdf927b136e37";
            this.Panel29.Name = "Panel29";
            this.Panel29.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel29.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text117
            // 
            this.Text117 = new Stimulsoft.Report.Components.StiText();
            this.Text117.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 18, 16);
            this.Text117.Guid = "4853f968d9ff47cb8bd65eb05bad0337";
            this.Text117.Name = "Text117";
            this.Text117.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text117__GetValue);
            this.Text117.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text117.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text117.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text117.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text117.Interaction = null;
            this.Text117.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text117.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text117.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text118
            // 
            this.Text118 = new Stimulsoft.Report.Components.StiText();
            this.Text118.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(18, 0, 27, 6);
            this.Text118.Guid = "39e104d800244dcbab1b577326a0f9a3";
            this.Text118.Name = "Text118";
            this.Text118.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text118.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text118.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text118.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text118.Interaction = null;
            this.Text118.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text118.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text118.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text119
            // 
            this.Text119 = new Stimulsoft.Report.Components.StiText();
            this.Text119.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(18, 6, 27, 8);
            this.Text119.Guid = "3a041d001feb4d1c80b08531a055b977";
            this.Text119.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text119.Name = "Text119";
            this.Text119.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text119__GetValue);
            this.Text119.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text119.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text119.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text119.Interaction = null;
            this.Text119.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text119.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text119.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel29.Interaction = null;
            // 
            // Panel30
            // 
            this.Panel30 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel30.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(148, 59, 48, 18);
            this.Panel30.Guid = "3c11dee23af6476497cacd3bc3b15581";
            this.Panel30.Name = "Panel30";
            this.Panel30.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel30.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text120
            // 
            this.Text120 = new Stimulsoft.Report.Components.StiText();
            this.Text120.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 20, 14);
            this.Text120.Guid = "7c0fb8a19ccc415db0ab84a02f4bcf01";
            this.Text120.Name = "Text120";
            this.Text120.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text120__GetValue);
            this.Text120.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text120.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text120.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text120.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text120.Interaction = null;
            this.Text120.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text120.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text120.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text121
            // 
            this.Text121 = new Stimulsoft.Report.Components.StiText();
            this.Text121.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(20, 0, 27, 6);
            this.Text121.Editable = true;
            this.Text121.Guid = "1679332cc5334d128449f10b114e9a50";
            this.Text121.Name = "Text121";
            this.Text121.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text121.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text121.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text121.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text121.Interaction = null;
            this.Text121.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text121.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text121.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text122
            // 
            this.Text122 = new Stimulsoft.Report.Components.StiText();
            this.Text122.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(20, 6, 27, 8);
            this.Text122.Guid = "dce79e67eb6f4b2195ae9b41117b79ef";
            this.Text122.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text122.Name = "Text122";
            this.Text122.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text122__GetValue);
            this.Text122.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text122.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text122.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text122.Interaction = null;
            this.Text122.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text122.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text122.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel30.Interaction = null;
            // 
            // Panel33
            // 
            this.Panel33 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel33.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(100, 79, 46, 10);
            this.Panel33.Guid = "13e54d3e8c984a2d9addae70129d7531";
            this.Panel33.Name = "Panel33";
            this.Panel33.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel33.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text129
            // 
            this.Text129 = new Stimulsoft.Report.Components.StiText();
            this.Text129.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 31, 6);
            this.Text129.Editable = true;
            this.Text129.Guid = "7aa5df0d8b644813bb0e04ffe1b02201";
            this.Text129.Name = "Text129";
            this.Text129.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text129.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text129.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text129.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text129.Interaction = null;
            this.Text129.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text129.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text129.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text130
            // 
            this.Text130 = new Stimulsoft.Report.Components.StiText();
            this.Text130.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 6, 31, 4);
            this.Text130.Guid = "b3af992fca244110a00fa247d5b72135";
            this.Text130.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text130.Name = "Text130";
            this.Text130.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text130__GetValue);
            this.Text130.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text130.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text130.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text130.Interaction = null;
            this.Text130.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text130.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text130.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text131
            // 
            this.Text131 = new Stimulsoft.Report.Components.StiText();
            this.Text131.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(31, 0, 13, 6);
            this.Text131.Editable = true;
            this.Text131.Guid = "62c2d09e4dc24961b25033ed27e50ce5";
            this.Text131.Name = "Text131";
            this.Text131.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text131__GetValue);
            this.Text131.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text131.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text131.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text131.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text131.Interaction = null;
            this.Text131.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text131.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text131.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel33.Interaction = null;
            // 
            // Panel31
            // 
            this.Panel31 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel31.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 79, 46, 10);
            this.Panel31.Guid = "c63ef31a5f55472cb905c83e81b991f7";
            this.Panel31.Name = "Panel31";
            this.Panel31.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel31.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Panel32
            // 
            this.Panel32 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel32.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 46, 10);
            this.Panel32.Guid = "70b9e8fe4e05450cba1684ad1eec4b7d";
            this.Panel32.Name = "Panel32";
            this.Panel32.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel32.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text126
            // 
            this.Text126 = new Stimulsoft.Report.Components.StiText();
            this.Text126.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 31, 6);
            this.Text126.Guid = "fbbc133b3b4a4aca99e8f23f70d833a6";
            this.Text126.Name = "Text126";
            this.Text126.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text126.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text126.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text126.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text126.Interaction = null;
            this.Text126.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text126.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text126.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text127
            // 
            this.Text127 = new Stimulsoft.Report.Components.StiText();
            this.Text127.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 6, 31, 4);
            this.Text127.Guid = "9f60d0da67f843bfb17de3d65bbe0b2d";
            this.Text127.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text127.Name = "Text127";
            this.Text127.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text127__GetValue);
            this.Text127.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text127.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text127.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text127.Interaction = null;
            this.Text127.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text127.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text127.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text124
            // 
            this.Text124 = new Stimulsoft.Report.Components.StiText();
            this.Text124.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 31, 6);
            this.Text124.Editable = true;
            this.Text124.Guid = "8e38cf429fd24032b72e32510d938037";
            this.Text124.Name = "Text124";
            this.Text124.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text124.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text124.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text124.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text124.Interaction = null;
            this.Text124.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text124.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text124.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text125
            // 
            this.Text125 = new Stimulsoft.Report.Components.StiText();
            this.Text125.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 6, 31, 4);
            this.Text125.Guid = "66c86fb71e3945bc9a907622fb99a46d";
            this.Text125.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text125.Name = "Text125";
            this.Text125.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text125__GetValue);
            this.Text125.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text125.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text125.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text125.Interaction = null;
            this.Text125.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text125.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text125.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text128
            // 
            this.Text128 = new Stimulsoft.Report.Components.StiText();
            this.Text128.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(31, 0, 13, 6);
            this.Text128.Editable = true;
            this.Text128.Guid = "734cf51aef124fad8b74352a3b26f021";
            this.Text128.Name = "Text128";
            this.Text128.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text128__GetValue);
            this.Text128.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text128.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text128.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text128.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text128.Interaction = null;
            this.Text128.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text128.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text128.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel32.Interaction = null;
            this.Panel31.Interaction = null;
            this.FooterSP_GetSalesOrderDetail.Guid = null;
            this.FooterSP_GetSalesOrderDetail.Interaction = null;
            this.Page1.ExcelSheetValue = null;
            this.Page1.Interaction = null;
            this.Page1.Margins = new Stimulsoft.Report.Components.StiMargins(7, 7, 10, 10);
            this.Page1_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page1_Watermark.Angle = 0F;
            this.Page1_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Page1_Watermark.Image = null;
            this.Page1_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(50, 0, 0, 0));
            // 
            // Page2
            // 
            this.Page2 = new Stimulsoft.Report.Components.StiPage();
            this.Page2.Guid = "c0b557c88c2742509cd75b2f10ffe766";
            this.Page2.Name = "Page2";
            this.Page2.PageHeight = 297;
            this.Page2.PageWidth = 210;
            this.Page2.PaperSize = System.Drawing.Printing.PaperKind.A4;
            this.Page2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Page2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Data1
            // 
            this.Data1 = new Stimulsoft.Report.Components.StiDataBand();
            this.Data1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4, 196, 24);
            this.Data1.DataSourceName = "SP_GetRptSalesOrderHeader";
            this.Data1.Guid = "79c8d61be8cd431f9df969ad1d362973";
            this.Data1.Name = "Data1";
            this.Data1.Sort = new System.String[0];
            this.Data1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Data1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Data1.BusinessObjectGuid = null;
            // 
            // Text123
            // 
            this.Text123 = new Stimulsoft.Report.Components.StiText();
            this.Text123.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(170, 0, 26, 6);
            this.Text123.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text123.Name = "Text123";
            this.Text123.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text123__GetValue);
            this.Text123.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text123.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text123.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text123.Font = new System.Drawing.Font("BPG Glaho Arial", 10F);
            this.Text123.Guid = null;
            this.Text123.Interaction = null;
            this.Text123.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text123.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text123.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text132
            // 
            this.Text132 = new Stimulsoft.Report.Components.StiText();
            this.Text132.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 6, 176, 6);
            this.Text132.Editable = true;
            this.Text132.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text132.Name = "Text132";
            this.Text132.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text132__GetValue);
            this.Text132.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text132.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text132.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text132.Font = new System.Drawing.Font("BPG Glaho Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Text132.Guid = null;
            this.Text132.Interaction = null;
            this.Text132.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text132.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text132.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Panel34
            // 
            this.Panel34 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel34.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(71.96, 14, 52.07, 8.13);
            this.Panel34.Guid = "4b71af7b1de34a3abf267b8a99077940";
            this.Panel34.Name = "Panel34";
            this.Panel34.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel34.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text133
            // 
            this.Text133 = new Stimulsoft.Report.Components.StiText();
            this.Text133.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4.06, 4.06);
            this.Text133.Guid = "635a5416107249f297d7c747623ded6e";
            this.Text133.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text133.Name = "Text133";
            this.Text133.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text133__GetValue);
            this.Text133.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text133.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text133.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text133.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text133.Interaction = null;
            this.Text133.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text133.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text133.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text134
            // 
            this.Text134 = new Stimulsoft.Report.Components.StiText();
            this.Text134.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4.06, 0, 8.13, 4.06);
            this.Text134.Editable = true;
            this.Text134.Guid = "68264efec7d042f88648ff1741dbd95a";
            this.Text134.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text134.Name = "Text134";
            this.Text134.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text134__GetValue);
            this.Text134.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text134.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text134.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text134.Font = new System.Drawing.Font("BPG Glaho Arial", 8F);
            this.Text134.Interaction = null;
            this.Text134.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text134.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text134.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text135
            // 
            this.Text135 = new Stimulsoft.Report.Components.StiText();
            this.Text135.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(11.94, 0, 29.97, 4.06);
            this.Text135.Editable = true;
            this.Text135.Guid = "c09b92b2589a4080876275107b20cc88";
            this.Text135.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text135.Name = "Text135";
            this.Text135.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text135__GetValue);
            this.Text135.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text135.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text135.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top)
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right)
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text135.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text135.Font = new System.Drawing.Font("BPG Glaho Arial", 8F);
            this.Text135.Interaction = null;
            this.Text135.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text135.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text135.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text136
            // 
            this.Text136 = new Stimulsoft.Report.Components.StiText();
            this.Text136.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(41.91, 0, 9.91, 4.06);
            this.Text136.Editable = true;
            this.Text136.Guid = "c56eda044e5d48a39711cf0c532a4a54";
            this.Text136.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text136.Name = "Text136";
            this.Text136.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text136__GetValue);
            this.Text136.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text136.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top)
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right)
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text136.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text136.Font = new System.Drawing.Font("BPG Glaho Arial", 8F);
            this.Text136.Interaction = null;
            this.Text136.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text136.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text136.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text137
            // 
            this.Text137 = new Stimulsoft.Report.Components.StiText();
            this.Text137.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4.06, 4.06, 8.13, 4.06);
            this.Text137.Guid = "10efce14420a40a08750fecf581edd20";
            this.Text137.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text137.Name = "Text137";
            this.Text137.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text137__GetValue);
            this.Text137.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text137.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text137.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text137.Interaction = null;
            this.Text137.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text137.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text137.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text138
            // 
            this.Text138 = new Stimulsoft.Report.Components.StiText();
            this.Text138.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(11.94, 4.06, 29.97, 4.06);
            this.Text138.Guid = "13f595c2fbfd4d4a9b72836a26f9a7a1";
            this.Text138.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text138.Name = "Text138";
            this.Text138.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text138__GetValue);
            this.Text138.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text138.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text138.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text138.Interaction = null;
            this.Text138.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text138.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text138.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text139
            // 
            this.Text139 = new Stimulsoft.Report.Components.StiText();
            this.Text139.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(41.91, 4.06, 9.91, 4.06);
            this.Text139.Guid = "8db2da37b1f547c6b01fbf1bae8c02c1";
            this.Text139.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text139.Name = "Text139";
            this.Text139.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text139__GetValue);
            this.Text139.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text139.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text139.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text139.Interaction = null;
            this.Text139.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text139.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text139.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel34.Interaction = null;
            this.Data1.Interaction = null;
            this.Data1.MasterComponent = null;
            // 
            // Header1
            // 
            this.Header1 = new Stimulsoft.Report.Components.StiHeaderBand();
            this.Header1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 36, 196, 25);
            this.Header1.Guid = "5c70df2ef6224395899719b6607ae981";
            this.Header1.Name = "Header1";
            this.Header1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Header1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text140
            // 
            this.Text140 = new Stimulsoft.Report.Components.StiText();
            this.Text140.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 5, 9, 15);
            this.Text140.Guid = "00afc65b556543c5b519fd266019c8d6";
            this.Text140.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text140.Name = "Text140";
            this.Text140.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text140__GetValue);
            this.Text140.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text140.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text140.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text140.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text140.Interaction = null;
            this.Text140.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text140.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text140.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text141
            // 
            this.Text141 = new Stimulsoft.Report.Components.StiText();
            this.Text141.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9, 5, 70, 15);
            this.Text141.Guid = "90d8002dd6a94d37bdf9df4a333350f0";
            this.Text141.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text141.Name = "Text141";
            this.Text141.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text141__GetValue);
            this.Text141.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text141.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text141.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text141.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text141.Interaction = null;
            this.Text141.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text141.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text141.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text142
            // 
            this.Text142 = new Stimulsoft.Report.Components.StiText();
            this.Text142.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(79, 5, 13, 15);
            this.Text142.Guid = "92eaf9ad42ae4180aef23ea8dc6cffff";
            this.Text142.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text142.Name = "Text142";
            this.Text142.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text142__GetValue);
            this.Text142.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text142.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text142.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text142.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text142.Interaction = null;
            this.Text142.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text142.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text142.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text143
            // 
            this.Text143 = new Stimulsoft.Report.Components.StiText();
            this.Text143.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(92, 5, 14, 15);
            this.Text143.Guid = "68b4ec8a4d7245c8961591e8a441c488";
            this.Text143.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text143.Name = "Text143";
            this.Text143.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text143__GetValue);
            this.Text143.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text143.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text143.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text143.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text143.Interaction = null;
            this.Text143.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text143.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text143.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text144
            // 
            this.Text144 = new Stimulsoft.Report.Components.StiText();
            this.Text144.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(106, 5, 28, 9);
            this.Text144.Guid = "224f60714e9642d982bf638975f4398a";
            this.Text144.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text144.Name = "Text144";
            this.Text144.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text144__GetValue);
            this.Text144.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text144.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text144.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text144.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text144.Interaction = null;
            this.Text144.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text144.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text144.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text145
            // 
            this.Text145 = new Stimulsoft.Report.Components.StiText();
            this.Text145.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(106, 14, 17, 6);
            this.Text145.Guid = "42686091fe7142dfbb79f52e38e29f6c";
            this.Text145.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text145.Name = "Text145";
            this.Text145.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text145__GetValue);
            this.Text145.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text145.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text145.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text145.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text145.Interaction = null;
            this.Text145.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text145.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text145.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text146
            // 
            this.Text146 = new Stimulsoft.Report.Components.StiText();
            this.Text146.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(123, 14, 11, 6);
            this.Text146.Guid = "b0757dfa21824c4f97f8e9ec593d9dd6";
            this.Text146.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text146.Name = "Text146";
            this.Text146.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text146__GetValue);
            this.Text146.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text146.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text146.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text146.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text146.Interaction = null;
            this.Text146.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text146.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text146.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text147
            // 
            this.Text147 = new Stimulsoft.Report.Components.StiText();
            this.Text147.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(134, 5, 33, 9);
            this.Text147.Guid = "b9af07ab544944e9a5d40219601c05e6";
            this.Text147.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text147.Name = "Text147";
            this.Text147.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text147__GetValue);
            this.Text147.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text147.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text147.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text147.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text147.Interaction = null;
            this.Text147.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text147.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text147.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text148
            // 
            this.Text148 = new Stimulsoft.Report.Components.StiText();
            this.Text148.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(134, 14, 19, 6);
            this.Text148.Guid = "2ef4ee22093a4bf497bdf811d678dbfa";
            this.Text148.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text148.Name = "Text148";
            this.Text148.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text148__GetValue);
            this.Text148.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text148.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text148.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text148.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text148.Interaction = null;
            this.Text148.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text148.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text148.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text149
            // 
            this.Text149 = new Stimulsoft.Report.Components.StiText();
            this.Text149.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(153, 14, 14, 6);
            this.Text149.Guid = "aff5fa64f5e342868962bb8a61c642f1";
            this.Text149.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text149.Name = "Text149";
            this.Text149.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text149__GetValue);
            this.Text149.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text149.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text149.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text149.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text149.Interaction = null;
            this.Text149.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text149.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text149.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text150
            // 
            this.Text150 = new Stimulsoft.Report.Components.StiText();
            this.Text150.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(167, 5, 13, 15);
            this.Text150.Guid = "0ad42f90dc0d41e9bf8647ceb8faee6b";
            this.Text150.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text150.Name = "Text150";
            this.Text150.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text150__GetValue);
            this.Text150.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text150.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text150.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text150.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text150.Interaction = null;
            this.Text150.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text150.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text150.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text151
            // 
            this.Text151 = new Stimulsoft.Report.Components.StiText();
            this.Text151.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(180, 5, 16, 15);
            this.Text151.Guid = "6ee50680a8614d39b7a7383f5f025da8";
            this.Text151.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text151.Name = "Text151";
            this.Text151.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text151__GetValue);
            this.Text151.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text151.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text151.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text151.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text151.Interaction = null;
            this.Text151.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text151.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text151.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text152
            // 
            this.Text152 = new Stimulsoft.Report.Components.StiText();
            this.Text152.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 20, 9, 5);
            this.Text152.Guid = "079cb64e6ed84ec8a657caeb8476b840";
            this.Text152.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text152.Name = "Text152";
            this.Text152.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text152__GetValue);
            this.Text152.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text152.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text152.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text152.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text152.Interaction = null;
            this.Text152.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text152.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text152.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text153
            // 
            this.Text153 = new Stimulsoft.Report.Components.StiText();
            this.Text153.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9, 20, 70, 5);
            this.Text153.Guid = "787d3f885b0341bdb5f70ff9cc77642a";
            this.Text153.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text153.Name = "Text153";
            this.Text153.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text153__GetValue);
            this.Text153.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text153.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text153.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text153.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text153.Interaction = null;
            this.Text153.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text153.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text153.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text154
            // 
            this.Text154 = new Stimulsoft.Report.Components.StiText();
            this.Text154.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(79, 20, 13, 5);
            this.Text154.Guid = "3fbad6f82b7740768cb7e2f97d16a7dd";
            this.Text154.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text154.Name = "Text154";
            this.Text154.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text154__GetValue);
            this.Text154.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text154.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text154.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text154.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text154.Interaction = null;
            this.Text154.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text154.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text154.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text155
            // 
            this.Text155 = new Stimulsoft.Report.Components.StiText();
            this.Text155.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(92, 20, 14, 5);
            this.Text155.Guid = "de67d51b9d4b49db9b03181eba29f80b";
            this.Text155.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text155.Name = "Text155";
            this.Text155.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text155__GetValue);
            this.Text155.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text155.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text155.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text155.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text155.Interaction = null;
            this.Text155.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text155.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text155.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text156
            // 
            this.Text156 = new Stimulsoft.Report.Components.StiText();
            this.Text156.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(106, 20, 28, 5);
            this.Text156.Guid = "e0c169945150486d9f22023207b0df37";
            this.Text156.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text156.Name = "Text156";
            this.Text156.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text156__GetValue);
            this.Text156.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text156.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text156.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text156.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text156.Interaction = null;
            this.Text156.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text156.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text156.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text157
            // 
            this.Text157 = new Stimulsoft.Report.Components.StiText();
            this.Text157.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(134, 20, 33, 5);
            this.Text157.Guid = "831ed7593daf4ad0bba599f246cdb57d";
            this.Text157.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text157.Name = "Text157";
            this.Text157.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text157__GetValue);
            this.Text157.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text157.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text157.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text157.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text157.Interaction = null;
            this.Text157.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text157.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text157.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text158
            // 
            this.Text158 = new Stimulsoft.Report.Components.StiText();
            this.Text158.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(167, 20, 13, 5);
            this.Text158.Guid = "4971d292db614199a25349f351a97e54";
            this.Text158.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text158.Name = "Text158";
            this.Text158.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text158__GetValue);
            this.Text158.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text158.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text158.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text158.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text158.Interaction = null;
            this.Text158.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text158.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text158.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text159
            // 
            this.Text159 = new Stimulsoft.Report.Components.StiText();
            this.Text159.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(180, 20, 16, 5);
            this.Text159.Guid = "27a7803ea1d84d91a23c60cc911f9809";
            this.Text159.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text159.Name = "Text159";
            this.Text159.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text159__GetValue);
            this.Text159.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text159.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text159.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text159.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text159.Interaction = null;
            this.Text159.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text159.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text159.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Header1.Interaction = null;
            // 
            // DataEnclosure
            // 
            this.DataEnclosure = new Stimulsoft.Report.Components.StiDataBand();
            this.DataEnclosure.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 69, 196, 6);
            this.DataEnclosure.DataRelationName = "SP_GetRptSalesOrderHeader_SP_GetSalesOrderDetail";
            this.DataEnclosure.DataSourceName = "SP_GetSalesOrderDetail";
            this.DataEnclosure.Guid = "779bc2d7d0cb46be8b09b44eeb84361b";
            this.DataEnclosure.Name = "DataEnclosure";
            this.DataEnclosure.Sort = new System.String[] {
                    "ASC",
                    "OrdinalNumber"};
            this.DataEnclosure.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataEnclosure.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.DataEnclosure.BusinessObjectGuid = null;
            // 
            // Text160
            // 
            this.Text160 = new Stimulsoft.Report.Components.StiText();
            this.Text160.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 9, 6);
            this.Text160.Guid = "afea6eaf23bc4038b9d2cb448a66a599";
            this.Text160.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text160.Name = "Text160";
            this.Text160.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text160__GetValue);
            this.Text160.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text160.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text160.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text160.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text160.Interaction = null;
            this.Text160.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text160.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text160.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text161
            // 
            this.Text161 = new Stimulsoft.Report.Components.StiText();
            this.Text161.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9, 0, 70, 6);
            this.Text161.Guid = "3b23d599a0a74ec7ad9ba186895fa727";
            this.Text161.Name = "Text161";
            this.Text161.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text161__GetValue);
            this.Text161.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text161.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text161.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text161.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text161.Interaction = null;
            this.Text161.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text161.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text161.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.EllipsisCharacter);
            // 
            // Text162
            // 
            this.Text162 = new Stimulsoft.Report.Components.StiText();
            this.Text162.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(79, 0, 13, 6);
            this.Text162.Guid = "4b14265e4ab94b58bd11e5a80d3d800a";
            this.InitializeComponent5();
        }

        public void InitializeComponent5()
        {
            this.Text162.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text162.Name = "Text162";
            this.Text162.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text162__GetValue);
            this.Text162.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text162.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text162.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text162.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text162.Interaction = null;
            this.Text162.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text162.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text162.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text163
            // 
            this.Text163 = new Stimulsoft.Report.Components.StiText();
            this.Text163.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(92, 0, 14, 6);
            this.Text163.Guid = "f8e8444cb2154ec7b6a6a9b3e94241e0";
            this.Text163.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text163.Name = "Text163";
            this.Text163.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text163__GetValue);
            this.Text163.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text163.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text163.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text163.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text163.Interaction = null;
            this.Text163.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text163.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text163.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            this.Text163.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text164
            // 
            this.Text164 = new Stimulsoft.Report.Components.StiText();
            this.Text164.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(106, 0, 17, 6);
            this.Text164.Guid = "a6de88699f6f4693b303fad852b286b0";
            this.Text164.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text164.Name = "Text164";
            this.Text164.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text164__GetValue);
            this.Text164.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text164.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text164.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text164.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text164.Interaction = null;
            this.Text164.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text164.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text164.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text165
            // 
            this.Text165 = new Stimulsoft.Report.Components.StiText();
            this.Text165.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(123, 0, 11, 6);
            this.Text165.Guid = "325d107269cc48ac94dc5ef782906031";
            this.Text165.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text165.Name = "Text165";
            this.Text165.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text165__GetValue);
            this.Text165.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text165.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text165.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text165.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text165.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text165.Interaction = null;
            this.Text165.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text165.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text165.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiCustomFormatService("0000");
            this.Text165.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text166
            // 
            this.Text166 = new Stimulsoft.Report.Components.StiText();
            this.Text166.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(134, 0, 19, 6);
            this.Text166.Guid = "cf6f3c60f7904cffa161a9919233da8c";
            this.Text166.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text166.Name = "Text166";
            this.Text166.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text166__GetValue);
            this.Text166.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text166.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text166.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text166.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text166.Interaction = null;
            this.Text166.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text166.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text166.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text167
            // 
            this.Text167 = new Stimulsoft.Report.Components.StiText();
            this.Text167.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(153, 0, 14, 6);
            this.Text167.Guid = "2b6e41d31aed45e7a8846ba3b9275b62";
            this.Text167.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text167.Name = "Text167";
            this.Text167.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text167__GetValue);
            this.Text167.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text167.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text167.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text167.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text167.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text167.Interaction = null;
            this.Text167.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text167.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text167.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiCustomFormatService("0000");
            this.Text167.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text168
            // 
            this.Text168 = new Stimulsoft.Report.Components.StiText();
            this.Text168.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(167, 0, 13, 6);
            this.Text168.Guid = "d601ded07067449194db033fbbe2f1db";
            this.Text168.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text168.Name = "Text168";
            this.Text168.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text168.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text168.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text168.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text168.Interaction = null;
            this.Text168.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text168.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text168.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text169
            // 
            this.Text169 = new Stimulsoft.Report.Components.StiText();
            this.Text169.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(180, 0, 16, 6);
            this.Text169.Guid = "5fcddbd361da45dba6d2e793809bc460";
            this.Text169.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text169.Name = "Text169";
            this.Text169.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text169.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text169.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text169.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text169.Interaction = null;
            this.Text169.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text169.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text169.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiNumberFormatService(1, ",", 4, " ", 3, true, false, " ");
            this.Text169.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.DataEnclosure.Interaction = null;
            // 
            // Footer1
            // 
            this.Footer1 = new Stimulsoft.Report.Components.StiFooterBand();
            this.Footer1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 83, 196, 33.94);
            this.Footer1.Guid = "6d0f9b79651d45d4b9bb26580eb1de94";
            this.Footer1.Name = "Footer1";
            this.Footer1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Top, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Footer1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text170
            // 
            this.Text170 = new Stimulsoft.Report.Components.StiText();
            this.Text170.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(130, 0, 4, 4);
            this.Text170.Guid = "d3cc467fa9c245079ada7d991227f7f3";
            this.Text170.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text170.Name = "Text170";
            this.Text170.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text170__GetValue);
            this.Text170.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text170.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text170.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text170.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text170.Interaction = null;
            this.Text170.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text170.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text170.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text171
            // 
            this.Text171 = new Stimulsoft.Report.Components.StiText();
            this.Text171.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(134, 0, 33, 4);
            this.Text171.Editable = true;
            this.Text171.Guid = "6065bf16a31940aca69610fbfb05096b";
            this.Text171.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text171.Name = "Text171";
            this.Text171.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text171__GetValue);
            this.Text171.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text171.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text171.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text171.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text171.Interaction = null;
            this.Text171.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text171.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text171.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            this.Text171.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text172
            // 
            this.Text172 = new Stimulsoft.Report.Components.StiText();
            this.Text172.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(176, 0, 4, 4);
            this.Text172.Guid = "8503795da2654241b1d290e6043c2b9c";
            this.Text172.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text172.Name = "Text172";
            this.Text172.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text172__GetValue);
            this.Text172.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text172.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text172.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text172.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text172.Interaction = null;
            this.Text172.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text172.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text172.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text173
            // 
            this.Text173 = new Stimulsoft.Report.Components.StiText();
            this.Text173.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(180, 0, 16, 4);
            this.Text173.Editable = true;
            this.Text173.Guid = "312bf89e858b42568906615d055329e4";
            this.Text173.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text173.Name = "Text173";
            this.Text173.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text173.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text173.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text173.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text173.Interaction = null;
            this.Text173.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text173.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text173.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiNumberFormatService(1, ",", 2, " ", 3, true, false, " ");
            this.Text173.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Panel35
            // 
            this.Panel35 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel35.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(8, 5, 58, 10);
            this.Panel35.Guid = "20bc52d1ee8347e5b5843391128696b5";
            this.Panel35.Name = "Panel35";
            this.Panel35.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel35.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text174
            // 
            this.Text174 = new Stimulsoft.Report.Components.StiText();
            this.Text174.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 10, 10);
            this.Text174.Guid = "8981afcbe6b44d2cb79d5350c59df249";
            this.Text174.Name = "Text174";
            this.Text174.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text174__GetValue);
            this.Text174.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text174.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text174.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text174.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text174.Interaction = null;
            this.Text174.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text174.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text174.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text175
            // 
            this.Text175 = new Stimulsoft.Report.Components.StiText();
            this.Text175.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 45, 6);
            this.Text175.Editable = true;
            this.Text175.Guid = "4fa0fd76c6c243f6935ccb5c00ecc05b";
            this.Text175.Name = "Text175";
            this.Text175.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text175.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text175.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text175.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text175.Interaction = null;
            this.Text175.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text175.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text175.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text176
            // 
            this.Text176 = new Stimulsoft.Report.Components.StiText();
            this.Text176.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 6, 45, 4);
            this.Text176.Guid = "50ff87a46c784952ad8f5df5f36dbf62";
            this.Text176.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text176.Name = "Text176";
            this.Text176.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text176__GetValue);
            this.Text176.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text176.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text176.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text176.Interaction = null;
            this.Text176.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text176.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text176.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel35.Interaction = null;
            // 
            // Panel36
            // 
            this.Panel36 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel36.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(8, 19, 58, 10);
            this.Panel36.Guid = "90656c0441b04854aae49d79c7787ff2";
            this.Panel36.Name = "Panel36";
            this.Panel36.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel36.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text177
            // 
            this.Text177 = new Stimulsoft.Report.Components.StiText();
            this.Text177.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 10, 10);
            this.Text177.Guid = "d5e4444f9ccd439489c2959f68cec8b2";
            this.Text177.Name = "Text177";
            this.Text177.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text177__GetValue);
            this.Text177.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text177.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text177.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text177.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text177.Interaction = null;
            this.Text177.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text177.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text177.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text178
            // 
            this.Text178 = new Stimulsoft.Report.Components.StiText();
            this.Text178.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 45, 6);
            this.Text178.Editable = true;
            this.Text178.Guid = "464bf5eb90da49b3be1f6869bc9e79b9";
            this.Text178.Name = "Text178";
            this.Text178.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text178.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text178.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text178.Font = new System.Drawing.Font("BPG Glaho Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text178.Interaction = null;
            this.Text178.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text178.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text178.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text179
            // 
            this.Text179 = new Stimulsoft.Report.Components.StiText();
            this.Text179.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 6, 45, 4);
            this.Text179.Guid = "1679ff14cfd240a4afee8baf0523a94a";
            this.Text179.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text179.Name = "Text179";
            this.Text179.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text179__GetValue);
            this.Text179.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text179.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text179.Font = new System.Drawing.Font("BPG Glaho Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Text179.Interaction = null;
            this.Text179.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text179.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text179.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel36.Interaction = null;
            this.Footer1.Interaction = null;
            this.Page2.ExcelSheetValue = null;
            this.Page2.Interaction = null;
            this.Page2.Margins = new Stimulsoft.Report.Components.StiMargins(7, 7, 10, 10);
            this.Page2_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page2_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Page2_Watermark.Image = null;
            this.Page2_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(50, 0, 0, 0));
            this.RptSalesOrderDetailInvoice_PrinterSettings = new Stimulsoft.Report.Print.StiPrinterSettings();
            this.Rendering += new System.EventHandler(this.RptSalesOrderDetailInvoice_Rendering);
            this.PrinterSettings = this.RptSalesOrderDetailInvoice_PrinterSettings;
            this.Page1.Report = this;
            this.Page1.Watermark = this.Page1_Watermark;
            this.DataSP_GetRptSalesOrderHeader.Page = this.Page1;
            this.DataSP_GetRptSalesOrderHeader.Parent = this.Page1;
            this.DataSP_GetRptSalesOrderHeader_SalesOrderID.Page = this.Page1;
            this.DataSP_GetRptSalesOrderHeader_SalesOrderID.Parent = this.DataSP_GetRptSalesOrderHeader;
            this.Panel2.Page = this.Page1;
            this.Panel2.Parent = this.DataSP_GetRptSalesOrderHeader;
            this.Text8.Page = this.Page1;
            this.Text8.Parent = this.Panel2;
            this.Text10.Page = this.Page1;
            this.Text10.Parent = this.Panel2;
            this.Text11.Page = this.Page1;
            this.Text11.Parent = this.Panel2;
            this.Text12.Page = this.Page1;
            this.Text12.Parent = this.Panel2;
            this.Text13.Page = this.Page1;
            this.Text13.Parent = this.Panel2;
            this.Text14.Page = this.Page1;
            this.Text14.Parent = this.Panel2;
            this.Text15.Page = this.Page1;
            this.Text15.Parent = this.Panel2;
            this.Panel1.Page = this.Page1;
            this.Panel1.Parent = this.DataSP_GetRptSalesOrderHeader;
            this.Text9.Page = this.Page1;
            this.Text9.Parent = this.Panel1;
            this.Text2.Page = this.Page1;
            this.Text2.Parent = this.Panel1;
            this.Panel3.Page = this.Page1;
            this.Panel3.Parent = this.DataSP_GetRptSalesOrderHeader;
            this.Text16.Page = this.Page1;
            this.Text16.Parent = this.Panel3;
            this.Text17.Page = this.Page1;
            this.Text17.Parent = this.Panel3;
            this.Text18.Page = this.Page1;
            this.Text18.Parent = this.Panel3;
            this.Panel4.Page = this.Page1;
            this.Panel4.Parent = this.DataSP_GetRptSalesOrderHeader;
            this.TextInCells1.Page = this.Page1;
            this.TextInCells1.Parent = this.Panel4;
            this.Text19.Page = this.Page1;
            this.Text19.Parent = this.Panel4;
            this.Text20.Page = this.Page1;
            this.Text20.Parent = this.Panel4;
            this.Panel6.Page = this.Page1;
            this.Panel6.Parent = this.DataSP_GetRptSalesOrderHeader;
            this.TextInCells2.Page = this.Page1;
            this.TextInCells2.Parent = this.Panel6;
            this.Text25.Page = this.Page1;
            this.Text25.Parent = this.Panel6;
            this.Text24.Page = this.Page1;
            this.Text24.Parent = this.Panel6;
            this.Panel5.Page = this.Page1;
            this.Panel5.Parent = this.DataSP_GetRptSalesOrderHeader;
            this.Text23.Page = this.Page1;
            this.Text23.Parent = this.Panel5;
            this.Text22.Page = this.Page1;
            this.Text22.Parent = this.Panel5;
            this.Text21.Page = this.Page1;
            this.Text21.Parent = this.Panel5;
            this.Panel7.Page = this.Page1;
            this.Panel7.Parent = this.DataSP_GetRptSalesOrderHeader;
            this.Text26.Page = this.Page1;
            this.Text26.Parent = this.Panel7;
            this.Text27.Page = this.Page1;
            this.Text27.Parent = this.Panel7;
            this.Panel8.Page = this.Page1;
            this.Panel8.Parent = this.DataSP_GetRptSalesOrderHeader;
            this.Text28.Page = this.Page1;
            this.Text28.Parent = this.Panel8;
            this.Text29.Page = this.Page1;
            this.Text29.Parent = this.Panel8;
            this.Panel9.Page = this.Page1;
            this.Panel9.Parent = this.DataSP_GetRptSalesOrderHeader;
            this.Text1.Page = this.Page1;
            this.Text1.Parent = this.Panel9;
            this.Text30.Page = this.Page1;
            this.Text30.Parent = this.Panel9;
            this.Text31.Page = this.Page1;
            this.Text31.Parent = this.Panel9;
            this.Panel10.Page = this.Page1;
            this.Panel10.Parent = this.DataSP_GetRptSalesOrderHeader;
            this.TextInCells3.Page = this.Page1;
            this.TextInCells3.Parent = this.Panel10;
            this.Text32.Page = this.Page1;
            this.Text32.Parent = this.Panel10;
            this.Text33.Page = this.Page1;
            this.Text33.Parent = this.Panel10;
            this.Panel11.Page = this.Page1;
            this.Panel11.Parent = this.DataSP_GetRptSalesOrderHeader;
            this.Text34.Page = this.Page1;
            this.Text34.Parent = this.Panel11;
            this.Text35.Page = this.Page1;
            this.Text35.Parent = this.Panel11;
            this.Panel12.Page = this.Page1;
            this.Panel12.Parent = this.DataSP_GetRptSalesOrderHeader;
            this.TextInCells4.Page = this.Page1;
            this.TextInCells4.Parent = this.Panel12;
            this.Text36.Page = this.Page1;
            this.Text36.Parent = this.Panel12;
            this.Text37.Page = this.Page1;
            this.Text37.Parent = this.Panel12;
            this.Panel13.Page = this.Page1;
            this.Panel13.Parent = this.DataSP_GetRptSalesOrderHeader;
            this.Text38.Page = this.Page1;
            this.Text38.Parent = this.Panel13;
            this.Text39.Page = this.Page1;
            this.Text39.Parent = this.Panel13;
            this.Text40.Page = this.Page1;
            this.Text40.Parent = this.Panel13;
            this.Panel14.Page = this.Page1;
            this.Panel14.Parent = this.DataSP_GetRptSalesOrderHeader;
            this.Text41.Page = this.Page1;
            this.Text41.Parent = this.Panel14;
            this.Text42.Page = this.Page1;
            this.Text42.Parent = this.Panel14;
            this.Panel15.Page = this.Page1;
            this.Panel15.Parent = this.DataSP_GetRptSalesOrderHeader;
            this.Text43.Page = this.Page1;
            this.Text43.Parent = this.Panel15;
            this.Text44.Page = this.Page1;
            this.Text44.Parent = this.Panel15;
            this.Text45.Page = this.Page1;
            this.Text45.Parent = this.Panel15;
            this.Panel16.Page = this.Page1;
            this.Panel16.Parent = this.DataSP_GetRptSalesOrderHeader;
            this.TextInCells5.Page = this.Page1;
            this.TextInCells5.Parent = this.Panel16;
            this.Text46.Page = this.Page1;
            this.Text46.Parent = this.Panel16;
            this.Text47.Page = this.Page1;
            this.Text47.Parent = this.Panel16;
            this.Panel17.Page = this.Page1;
            this.Panel17.Parent = this.DataSP_GetRptSalesOrderHeader;
            this.Text48.Page = this.Page1;
            this.Text48.Parent = this.Panel17;
            this.Text49.Page = this.Page1;
            this.Text49.Parent = this.Panel17;
            this.Text50.Page = this.Page1;
            this.Text50.Parent = this.Panel17;
            this.Panel18.Page = this.Page1;
            this.Panel18.Parent = this.DataSP_GetRptSalesOrderHeader;
            this.Text51.Page = this.Page1;
            this.Text51.Parent = this.Panel18;
            this.Text52.Page = this.Page1;
            this.Text52.Parent = this.Panel18;
            this.Text53.Page = this.Page1;
            this.Text53.Parent = this.Panel18;
            this.Text54.Page = this.Page1;
            this.Text54.Parent = this.Panel18;
            this.Text55.Page = this.Page1;
            this.Text55.Parent = this.Panel18;
            this.Text56.Page = this.Page1;
            this.Text56.Parent = this.Panel18;
            this.Panel19.Page = this.Page1;
            this.Panel19.Parent = this.DataSP_GetRptSalesOrderHeader;
            this.Text57.Page = this.Page1;
            this.Text57.Parent = this.Panel19;
            this.Text59.Page = this.Page1;
            this.Text59.Parent = this.Panel19;
            this.Panel20.Page = this.Page1;
            this.Panel20.Parent = this.DataSP_GetRptSalesOrderHeader;
            this.TextInCells6.Page = this.Page1;
            this.TextInCells6.Parent = this.Panel20;
            this.Text58.Page = this.Page1;
            this.Text58.Parent = this.Panel20;
            this.Text60.Page = this.Page1;
            this.Text60.Parent = this.Panel20;
            this.Panel21.Page = this.Page1;
            this.Panel21.Parent = this.DataSP_GetRptSalesOrderHeader;
            this.Text61.Page = this.Page1;
            this.Text61.Parent = this.Panel21;
            this.Text62.Page = this.Page1;
            this.Text62.Parent = this.Panel21;
            this.Text63.Page = this.Page1;
            this.Text63.Parent = this.Panel21;
            this.Text64.Page = this.Page1;
            this.Text64.Parent = this.Panel21;
            this.Panel22.Page = this.Page1;
            this.Panel22.Parent = this.DataSP_GetRptSalesOrderHeader;
            this.TextInCells7.Page = this.Page1;
            this.TextInCells7.Parent = this.Panel22;
            this.Text65.Page = this.Page1;
            this.Text65.Parent = this.Panel22;
            this.Text66.Page = this.Page1;
            this.Text66.Parent = this.Panel22;
            this.HeaderSP_GetSalesOrderDetail.Page = this.Page1;
            this.HeaderSP_GetSalesOrderDetail.Parent = this.Page1;
            this.Text67.Page = this.Page1;
            this.Text67.Parent = this.HeaderSP_GetSalesOrderDetail;
            this.Text68.Page = this.Page1;
            this.Text68.Parent = this.HeaderSP_GetSalesOrderDetail;
            this.Text69.Page = this.Page1;
            this.Text69.Parent = this.HeaderSP_GetSalesOrderDetail;
            this.Text70.Page = this.Page1;
            this.Text70.Parent = this.HeaderSP_GetSalesOrderDetail;
            this.Text71.Page = this.Page1;
            this.Text71.Parent = this.HeaderSP_GetSalesOrderDetail;
            this.Text72.Page = this.Page1;
            this.Text72.Parent = this.HeaderSP_GetSalesOrderDetail;
            this.Text73.Page = this.Page1;
            this.Text73.Parent = this.HeaderSP_GetSalesOrderDetail;
            this.Text74.Page = this.Page1;
            this.Text74.Parent = this.HeaderSP_GetSalesOrderDetail;
            this.Text75.Page = this.Page1;
            this.Text75.Parent = this.HeaderSP_GetSalesOrderDetail;
            this.Text76.Page = this.Page1;
            this.Text76.Parent = this.HeaderSP_GetSalesOrderDetail;
            this.Text77.Page = this.Page1;
            this.Text77.Parent = this.HeaderSP_GetSalesOrderDetail;
            this.Text78.Page = this.Page1;
            this.Text78.Parent = this.HeaderSP_GetSalesOrderDetail;
            this.Text79.Page = this.Page1;
            this.Text79.Parent = this.HeaderSP_GetSalesOrderDetail;
            this.Text80.Page = this.Page1;
            this.Text80.Parent = this.HeaderSP_GetSalesOrderDetail;
            this.Text81.Page = this.Page1;
            this.Text81.Parent = this.HeaderSP_GetSalesOrderDetail;
            this.Text82.Page = this.Page1;
            this.Text82.Parent = this.HeaderSP_GetSalesOrderDetail;
            this.Text83.Page = this.Page1;
            this.Text83.Parent = this.HeaderSP_GetSalesOrderDetail;
            this.Text84.Page = this.Page1;
            this.Text84.Parent = this.HeaderSP_GetSalesOrderDetail;
            this.Text85.Page = this.Page1;
            this.Text85.Parent = this.HeaderSP_GetSalesOrderDetail;
            this.Text86.Page = this.Page1;
            this.Text86.Parent = this.HeaderSP_GetSalesOrderDetail;
            this.DataSP_GetSalesOrderDetail.MasterComponent = this.DataSP_GetRptSalesOrderHeader;
            this.DataSP_GetSalesOrderDetail.Page = this.Page1;
            this.DataSP_GetSalesOrderDetail.Parent = this.Page1;
            this.Text87.Page = this.Page1;
            this.Text87.Parent = this.DataSP_GetSalesOrderDetail;
            this.Text88.Page = this.Page1;
            this.Text88.Parent = this.DataSP_GetSalesOrderDetail;
            this.Text89.Page = this.Page1;
            this.Text89.Parent = this.DataSP_GetSalesOrderDetail;
            this.Text90.Page = this.Page1;
            this.Text90.Parent = this.DataSP_GetSalesOrderDetail;
            this.Text91.Page = this.Page1;
            this.Text91.Parent = this.DataSP_GetSalesOrderDetail;
            this.Text92.Page = this.Page1;
            this.Text92.Parent = this.DataSP_GetSalesOrderDetail;
            this.Text93.Page = this.Page1;
            this.Text93.Parent = this.DataSP_GetSalesOrderDetail;
            this.Text94.Page = this.Page1;
            this.Text94.Parent = this.DataSP_GetSalesOrderDetail;
            this.Text95.Page = this.Page1;
            this.Text95.Parent = this.DataSP_GetSalesOrderDetail;
            this.Text96.Page = this.Page1;
            this.Text96.Parent = this.DataSP_GetSalesOrderDetail;
            this.HeaderEnclosureText.Page = this.Page1;
            this.HeaderEnclosureText.Parent = this.Page1;
            this.Text180.Page = this.Page1;
            this.Text180.Parent = this.HeaderEnclosureText;
            this.Text181.Page = this.Page1;
            this.Text181.Parent = this.HeaderEnclosureText;
            this.Text182.Page = this.Page1;
            this.Text182.Parent = this.HeaderEnclosureText;
            this.Text183.Page = this.Page1;
            this.Text183.Parent = this.HeaderEnclosureText;
            this.Text184.Page = this.Page1;
            this.Text184.Parent = this.HeaderEnclosureText;
            this.Text185.Page = this.Page1;
            this.Text185.Parent = this.HeaderEnclosureText;
            this.Text186.Page = this.Page1;
            this.Text186.Parent = this.HeaderEnclosureText;
            this.Text187.Page = this.Page1;
            this.Text187.Parent = this.HeaderEnclosureText;
            this.Text188.Page = this.Page1;
            this.Text188.Parent = this.HeaderEnclosureText;
            this.Text189.Page = this.Page1;
            this.Text189.Parent = this.HeaderEnclosureText;
            this.Text190.Page = this.Page1;
            this.Text190.Parent = this.HeaderEnclosureText;
            this.Text191.Page = this.Page1;
            this.Text191.Parent = this.HeaderEnclosureText;
            this.Text192.Page = this.Page1;
            this.Text192.Parent = this.HeaderEnclosureText;
            this.Text193.Page = this.Page1;
            this.Text193.Parent = this.HeaderEnclosureText;
            this.Text194.Page = this.Page1;
            this.Text194.Parent = this.HeaderEnclosureText;
            this.Text195.Page = this.Page1;
            this.Text195.Parent = this.HeaderEnclosureText;
            this.Text196.Page = this.Page1;
            this.Text196.Parent = this.HeaderEnclosureText;
            this.Text197.Page = this.Page1;
            this.Text197.Parent = this.HeaderEnclosureText;
            this.Text198.Page = this.Page1;
            this.Text198.Parent = this.HeaderEnclosureText;
            this.Text199.Page = this.Page1;
            this.Text199.Parent = this.HeaderEnclosureText;
            this.Text200.Page = this.Page1;
            this.Text200.Parent = this.HeaderEnclosureText;
            this.Text201.Page = this.Page1;
            this.Text201.Parent = this.HeaderEnclosureText;
            this.Text202.Page = this.Page1;
            this.Text202.Parent = this.HeaderEnclosureText;
            this.Text203.Page = this.Page1;
            this.Text203.Parent = this.HeaderEnclosureText;
            this.Text204.Page = this.Page1;
            this.Text204.Parent = this.HeaderEnclosureText;
            this.Text205.Page = this.Page1;
            this.Text205.Parent = this.HeaderEnclosureText;
            this.Text206.Page = this.Page1;
            this.Text206.Parent = this.HeaderEnclosureText;
            this.Text207.Page = this.Page1;
            this.Text207.Parent = this.HeaderEnclosureText;
            this.Text208.Page = this.Page1;
            this.Text208.Parent = this.HeaderEnclosureText;
            this.Text209.Page = this.Page1;
            this.Text209.Parent = this.HeaderEnclosureText;
            this.DataEmptyRow.Page = this.Page1;
            this.DataEmptyRow.Parent = this.Page1;
            this.Text210.Page = this.Page1;
            this.Text210.Parent = this.DataEmptyRow;
            this.Text211.Page = this.Page1;
            this.Text211.Parent = this.DataEmptyRow;
            this.Text212.Page = this.Page1;
            this.Text212.Parent = this.DataEmptyRow;
            this.Text213.Page = this.Page1;
            this.Text213.Parent = this.DataEmptyRow;
            this.Text214.Page = this.Page1;
            this.Text214.Parent = this.DataEmptyRow;
            this.Text215.Page = this.Page1;
            this.Text215.Parent = this.DataEmptyRow;
            this.Text216.Page = this.Page1;
            this.Text216.Parent = this.DataEmptyRow;
            this.Text217.Page = this.Page1;
            this.Text217.Parent = this.DataEmptyRow;
            this.Text218.Page = this.Page1;
            this.Text218.Parent = this.DataEmptyRow;
            this.Text219.Page = this.Page1;
            this.Text219.Parent = this.DataEmptyRow;
            this.FooterSP_GetSalesOrderDetail.Page = this.Page1;
            this.FooterSP_GetSalesOrderDetail.Parent = this.Page1;
            this.Text3.Page = this.Page1;
            this.Text3.Parent = this.FooterSP_GetSalesOrderDetail;
            this.Text4.Page = this.Page1;
            this.Text4.Parent = this.FooterSP_GetSalesOrderDetail;
            this.Text97.Page = this.Page1;
            this.Text97.Parent = this.FooterSP_GetSalesOrderDetail;
            this.Text98.Page = this.Page1;
            this.Text98.Parent = this.FooterSP_GetSalesOrderDetail;
            this.Text99.Page = this.Page1;
            this.Text99.Parent = this.FooterSP_GetSalesOrderDetail;
            this.Text100.Page = this.Page1;
            this.Text100.Parent = this.FooterSP_GetSalesOrderDetail;
            this.Text101.Page = this.Page1;
            this.Text101.Parent = this.FooterSP_GetSalesOrderDetail;
            this.Text102.Page = this.Page1;
            this.Text102.Parent = this.FooterSP_GetSalesOrderDetail;
            this.Panel23.Page = this.Page1;
            this.Panel23.Parent = this.FooterSP_GetSalesOrderDetail;
            this.Text103.Page = this.Page1;
            this.Text103.Parent = this.Panel23;
            this.Text104.Page = this.Page1;
            this.Text104.Parent = this.Panel23;
            this.Text5.Page = this.Page1;
            this.Text5.Parent = this.Panel23;
            this.Panel24.Page = this.Page1;
            this.Panel24.Parent = this.FooterSP_GetSalesOrderDetail;
            this.Text6.Page = this.Page1;
            this.Text6.Parent = this.Panel24;
            this.Text7.Page = this.Page1;
            this.Text7.Parent = this.Panel24;
            this.Panel25.Page = this.Page1;
            this.Panel25.Parent = this.FooterSP_GetSalesOrderDetail;
            this.Text105.Page = this.Page1;
            this.Text105.Parent = this.Panel25;
            this.Text106.Page = this.Page1;
            this.Text106.Parent = this.Panel25;
            this.Text107.Page = this.Page1;
            this.Text107.Parent = this.Panel25;
            this.Panel26.Page = this.Page1;
            this.Panel26.Parent = this.FooterSP_GetSalesOrderDetail;
            this.Text108.Page = this.Page1;
            this.Text108.Parent = this.Panel26;
            this.Text109.Page = this.Page1;
            this.Text109.Parent = this.Panel26;
            this.Text110.Page = this.Page1;
            this.Text110.Parent = this.Panel26;
            this.Panel27.Page = this.Page1;
            this.Panel27.Parent = this.FooterSP_GetSalesOrderDetail;
            this.Text111.Page = this.Page1;
            this.Text111.Parent = this.Panel27;
            this.Text112.Page = this.Page1;
            this.Text112.Parent = this.Panel27;
            this.Text113.Page = this.Page1;
            this.Text113.Parent = this.Panel27;
            this.Panel28.Page = this.Page1;
            this.Panel28.Parent = this.FooterSP_GetSalesOrderDetail;
            this.Text114.Page = this.Page1;
            this.Text114.Parent = this.Panel28;
            this.Text115.Page = this.Page1;
            this.Text115.Parent = this.Panel28;
            this.Text116.Page = this.Page1;
            this.Text116.Parent = this.Panel28;
            this.Panel29.Page = this.Page1;
            this.Panel29.Parent = this.FooterSP_GetSalesOrderDetail;
            this.Text117.Page = this.Page1;
            this.Text117.Parent = this.Panel29;
            this.Text118.Page = this.Page1;
            this.Text118.Parent = this.Panel29;
            this.Text119.Page = this.Page1;
            this.Text119.Parent = this.Panel29;
            this.Panel30.Page = this.Page1;
            this.Panel30.Parent = this.FooterSP_GetSalesOrderDetail;
            this.Text120.Page = this.Page1;
            this.Text120.Parent = this.Panel30;
            this.Text121.Page = this.Page1;
            this.Text121.Parent = this.Panel30;
            this.Text122.Page = this.Page1;
            this.Text122.Parent = this.Panel30;
            this.Panel33.Page = this.Page1;
            this.Panel33.Parent = this.FooterSP_GetSalesOrderDetail;
            this.Text129.Page = this.Page1;
            this.Text129.Parent = this.Panel33;
            this.Text130.Page = this.Page1;
            this.Text130.Parent = this.Panel33;
            this.Text131.Page = this.Page1;
            this.Text131.Parent = this.Panel33;
            this.Panel31.Page = this.Page1;
            this.Panel31.Parent = this.FooterSP_GetSalesOrderDetail;
            this.Panel32.Page = this.Page1;
            this.Panel32.Parent = this.Panel31;
            this.Text126.Page = this.Page1;
            this.Text126.Parent = this.Panel32;
            this.Text127.Page = this.Page1;
            this.Text127.Parent = this.Panel32;
            this.Text124.Page = this.Page1;
            this.Text124.Parent = this.Panel32;
            this.Text125.Page = this.Page1;
            this.Text125.Parent = this.Panel32;
            this.Text128.Page = this.Page1;
            this.Text128.Parent = this.Panel32;
            this.Page2.Report = this;
            this.Page2.Watermark = this.Page2_Watermark;
            this.Data1.Page = this.Page2;
            this.Data1.Parent = this.Page2;
            this.Text123.Page = this.Page2;
            this.Text123.Parent = this.Data1;
            this.Text132.Page = this.Page2;
            this.Text132.Parent = this.Data1;
            this.Panel34.Page = this.Page2;
            this.Panel34.Parent = this.Data1;
            this.Text133.Page = this.Page2;
            this.Text133.Parent = this.Panel34;
            this.Text134.Page = this.Page2;
            this.Text134.Parent = this.Panel34;
            this.Text135.Page = this.Page2;
            this.Text135.Parent = this.Panel34;
            this.Text136.Page = this.Page2;
            this.Text136.Parent = this.Panel34;
            this.Text137.Page = this.Page2;
            this.Text137.Parent = this.Panel34;
            this.Text138.Page = this.Page2;
            this.Text138.Parent = this.Panel34;
            this.Text139.Page = this.Page2;
            this.Text139.Parent = this.Panel34;
            this.Header1.Page = this.Page2;
            this.Header1.Parent = this.Page2;
            this.Text140.Page = this.Page2;
            this.Text140.Parent = this.Header1;
            this.Text141.Page = this.Page2;
            this.Text141.Parent = this.Header1;
            this.Text142.Page = this.Page2;
            this.Text142.Parent = this.Header1;
            this.Text143.Page = this.Page2;
            this.Text143.Parent = this.Header1;
            this.Text144.Page = this.Page2;
            this.Text144.Parent = this.Header1;
            this.Text145.Page = this.Page2;
            this.Text145.Parent = this.Header1;
            this.Text146.Page = this.Page2;
            this.Text146.Parent = this.Header1;
            this.Text147.Page = this.Page2;
            this.Text147.Parent = this.Header1;
            this.Text148.Page = this.Page2;
            this.Text148.Parent = this.Header1;
            this.Text149.Page = this.Page2;
            this.Text149.Parent = this.Header1;
            this.Text150.Page = this.Page2;
            this.Text150.Parent = this.Header1;
            this.Text151.Page = this.Page2;
            this.Text151.Parent = this.Header1;
            this.Text152.Page = this.Page2;
            this.Text152.Parent = this.Header1;
            this.Text153.Page = this.Page2;
            this.Text153.Parent = this.Header1;
            this.Text154.Page = this.Page2;
            this.Text154.Parent = this.Header1;
            this.Text155.Page = this.Page2;
            this.Text155.Parent = this.Header1;
            this.Text156.Page = this.Page2;
            this.Text156.Parent = this.Header1;
            this.Text157.Page = this.Page2;
            this.Text157.Parent = this.Header1;
            this.Text158.Page = this.Page2;
            this.Text158.Parent = this.Header1;
            this.Text159.Page = this.Page2;
            this.Text159.Parent = this.Header1;
            this.DataEnclosure.MasterComponent = this.Data1;
            this.DataEnclosure.Page = this.Page2;
            this.DataEnclosure.Parent = this.Page2;
            this.Text160.Page = this.Page2;
            this.Text160.Parent = this.DataEnclosure;
            this.Text161.Page = this.Page2;
            this.Text161.Parent = this.DataEnclosure;
            this.Text162.Page = this.Page2;
            this.Text162.Parent = this.DataEnclosure;
            this.Text163.Page = this.Page2;
            this.Text163.Parent = this.DataEnclosure;
            this.Text164.Page = this.Page2;
            this.Text164.Parent = this.DataEnclosure;
            this.Text165.Page = this.Page2;
            this.Text165.Parent = this.DataEnclosure;
            this.Text166.Page = this.Page2;
            this.Text166.Parent = this.DataEnclosure;
            this.Text167.Page = this.Page2;
            this.Text167.Parent = this.DataEnclosure;
            this.Text168.Page = this.Page2;
            this.Text168.Parent = this.DataEnclosure;
            this.Text169.Page = this.Page2;
            this.Text169.Parent = this.DataEnclosure;
            this.Footer1.Page = this.Page2;
            this.Footer1.Parent = this.Page2;
            this.Text170.Page = this.Page2;
            this.Text170.Parent = this.Footer1;
            this.Text171.Page = this.Page2;
            this.Text171.Parent = this.Footer1;
            this.Text172.Page = this.Page2;
            this.Text172.Parent = this.Footer1;
            this.Text173.Page = this.Page2;
            this.Text173.Parent = this.Footer1;
            this.Panel35.Page = this.Page2;
            this.Panel35.Parent = this.Footer1;
            this.Text174.Page = this.Page2;
            this.Text174.Parent = this.Panel35;
            this.Text175.Page = this.Page2;
            this.Text175.Parent = this.Panel35;
            this.Text176.Page = this.Page2;
            this.Text176.Parent = this.Panel35;
            this.Panel36.Page = this.Page2;
            this.Panel36.Parent = this.Footer1;
            this.Text177.Page = this.Page2;
            this.Text177.Parent = this.Panel36;
            this.Text178.Page = this.Page2;
            this.Text178.Parent = this.Panel36;
            this.Text179.Page = this.Page2;
            this.Text179.Parent = this.Panel36;
            // 
            // Add to Panel2.Components
            // 
            this.Panel2.Components.Clear();
            this.Panel2.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text8,
                        this.Text10,
                        this.Text11,
                        this.Text12,
                        this.Text13,
                        this.Text14,
                        this.Text15});
            // 
            // Add to Panel1.Components
            // 
            this.Panel1.Components.Clear();
            this.Panel1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text9,
                        this.Text2});
            // 
            // Add to Panel3.Components
            // 
            this.Panel3.Components.Clear();
            this.Panel3.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text16,
                        this.Text17,
                        this.Text18});
            // 
            // Add to Panel4.Components
            // 
            this.Panel4.Components.Clear();
            this.Panel4.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.TextInCells1,
                        this.Text19,
                        this.Text20});
            // 
            // Add to Panel6.Components
            // 
            this.Panel6.Components.Clear();
            this.Panel6.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.TextInCells2,
                        this.Text25,
                        this.Text24});
            // 
            // Add to Panel5.Components
            // 
            this.Panel5.Components.Clear();
            this.Panel5.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text23,
                        this.Text22,
                        this.Text21});
            // 
            // Add to Panel7.Components
            // 
            this.Panel7.Components.Clear();
            this.Panel7.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text26,
                        this.Text27});
            // 
            // Add to Panel8.Components
            // 
            this.Panel8.Components.Clear();
            this.Panel8.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text28,
                        this.Text29});
            // 
            // Add to Panel9.Components
            // 
            this.Panel9.Components.Clear();
            this.Panel9.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text1,
                        this.Text30,
                        this.Text31});
            // 
            // Add to Panel10.Components
            // 
            this.Panel10.Components.Clear();
            this.Panel10.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.TextInCells3,
                        this.Text32,
                        this.Text33});
            // 
            // Add to Panel11.Components
            // 
            this.Panel11.Components.Clear();
            this.Panel11.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text34,
                        this.Text35});
            // 
            // Add to Panel12.Components
            // 
            this.Panel12.Components.Clear();
            this.Panel12.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.TextInCells4,
                        this.Text36,
                        this.Text37});
            // 
            // Add to Panel13.Components
            // 
            this.Panel13.Components.Clear();
            this.Panel13.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text38,
                        this.Text39,
                        this.Text40});
            // 
            // Add to Panel14.Components
            // 
            this.Panel14.Components.Clear();
            this.Panel14.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text41,
                        this.Text42});
            // 
            // Add to Panel15.Components
            // 
            this.Panel15.Components.Clear();
            this.Panel15.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text43,
                        this.Text44,
                        this.Text45});
            // 
            // Add to Panel16.Components
            // 
            this.Panel16.Components.Clear();
            this.Panel16.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.TextInCells5,
                        this.Text46,
                        this.Text47});
            // 
            // Add to Panel17.Components
            // 
            this.Panel17.Components.Clear();
            this.Panel17.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text48,
                        this.Text49,
                        this.Text50});
            // 
            // Add to Panel18.Components
            // 
            this.Panel18.Components.Clear();
            this.Panel18.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text51,
                        this.Text52,
                        this.Text53,
                        this.Text54,
                        this.Text55,
                        this.Text56});
            // 
            // Add to Panel19.Components
            // 
            this.Panel19.Components.Clear();
            this.Panel19.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text57,
                        this.Text59});
            // 
            // Add to Panel20.Components
            // 
            this.Panel20.Components.Clear();
            this.Panel20.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.TextInCells6,
                        this.Text58,
                        this.Text60});
            // 
            // Add to Panel21.Components
            // 
            this.Panel21.Components.Clear();
            this.Panel21.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text61,
                        this.Text62,
                        this.Text63,
                        this.Text64});
            // 
            this.InitializeComponent6();
        }

        public void InitializeComponent6()
        {
            // Add to Panel22.Components
            // 
            this.Panel22.Components.Clear();
            this.Panel22.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.TextInCells7,
                        this.Text65,
                        this.Text66});
            // 
            // Add to DataSP_GetRptSalesOrderHeader.Components
            // 
            this.DataSP_GetRptSalesOrderHeader.Components.Clear();
            this.DataSP_GetRptSalesOrderHeader.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.DataSP_GetRptSalesOrderHeader_SalesOrderID,
                        this.Panel2,
                        this.Panel1,
                        this.Panel3,
                        this.Panel4,
                        this.Panel6,
                        this.Panel5,
                        this.Panel7,
                        this.Panel8,
                        this.Panel9,
                        this.Panel10,
                        this.Panel11,
                        this.Panel12,
                        this.Panel13,
                        this.Panel14,
                        this.Panel15,
                        this.Panel16,
                        this.Panel17,
                        this.Panel18,
                        this.Panel19,
                        this.Panel20,
                        this.Panel21,
                        this.Panel22});
            // 
            // Add to HeaderSP_GetSalesOrderDetail.Components
            // 
            this.HeaderSP_GetSalesOrderDetail.Components.Clear();
            this.HeaderSP_GetSalesOrderDetail.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text67,
                        this.Text68,
                        this.Text69,
                        this.Text70,
                        this.Text71,
                        this.Text72,
                        this.Text73,
                        this.Text74,
                        this.Text75,
                        this.Text76,
                        this.Text77,
                        this.Text78,
                        this.Text79,
                        this.Text80,
                        this.Text81,
                        this.Text82,
                        this.Text83,
                        this.Text84,
                        this.Text85,
                        this.Text86});
            // 
            // Add to DataSP_GetSalesOrderDetail.Components
            // 
            this.DataSP_GetSalesOrderDetail.Components.Clear();
            this.DataSP_GetSalesOrderDetail.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text87,
                        this.Text88,
                        this.Text89,
                        this.Text90,
                        this.Text91,
                        this.Text92,
                        this.Text93,
                        this.Text94,
                        this.Text95,
                        this.Text96});
            // 
            // Add to HeaderEnclosureText.Components
            // 
            this.HeaderEnclosureText.Components.Clear();
            this.HeaderEnclosureText.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text180,
                        this.Text181,
                        this.Text182,
                        this.Text183,
                        this.Text184,
                        this.Text185,
                        this.Text186,
                        this.Text187,
                        this.Text188,
                        this.Text189,
                        this.Text190,
                        this.Text191,
                        this.Text192,
                        this.Text193,
                        this.Text194,
                        this.Text195,
                        this.Text196,
                        this.Text197,
                        this.Text198,
                        this.Text199,
                        this.Text200,
                        this.Text201,
                        this.Text202,
                        this.Text203,
                        this.Text204,
                        this.Text205,
                        this.Text206,
                        this.Text207,
                        this.Text208,
                        this.Text209});
            // 
            // Add to DataEmptyRow.Components
            // 
            this.DataEmptyRow.Components.Clear();
            this.DataEmptyRow.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text210,
                        this.Text211,
                        this.Text212,
                        this.Text213,
                        this.Text214,
                        this.Text215,
                        this.Text216,
                        this.Text217,
                        this.Text218,
                        this.Text219});
            // 
            // Add to Panel23.Components
            // 
            this.Panel23.Components.Clear();
            this.Panel23.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text103,
                        this.Text104,
                        this.Text5});
            // 
            // Add to Panel24.Components
            // 
            this.Panel24.Components.Clear();
            this.Panel24.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text6,
                        this.Text7});
            // 
            // Add to Panel25.Components
            // 
            this.Panel25.Components.Clear();
            this.Panel25.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text105,
                        this.Text106,
                        this.Text107});
            // 
            // Add to Panel26.Components
            // 
            this.Panel26.Components.Clear();
            this.Panel26.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text108,
                        this.Text109,
                        this.Text110});
            // 
            // Add to Panel27.Components
            // 
            this.Panel27.Components.Clear();
            this.Panel27.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text111,
                        this.Text112,
                        this.Text113});
            // 
            // Add to Panel28.Components
            // 
            this.Panel28.Components.Clear();
            this.Panel28.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text114,
                        this.Text115,
                        this.Text116});
            // 
            // Add to Panel29.Components
            // 
            this.Panel29.Components.Clear();
            this.Panel29.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text117,
                        this.Text118,
                        this.Text119});
            // 
            // Add to Panel30.Components
            // 
            this.Panel30.Components.Clear();
            this.Panel30.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text120,
                        this.Text121,
                        this.Text122});
            // 
            // Add to Panel33.Components
            // 
            this.Panel33.Components.Clear();
            this.Panel33.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text129,
                        this.Text130,
                        this.Text131});
            // 
            // Add to Panel32.Components
            // 
            this.Panel32.Components.Clear();
            this.Panel32.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text126,
                        this.Text127,
                        this.Text124,
                        this.Text125,
                        this.Text128});
            // 
            // Add to Panel31.Components
            // 
            this.Panel31.Components.Clear();
            this.Panel31.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Panel32});
            // 
            // Add to FooterSP_GetSalesOrderDetail.Components
            // 
            this.FooterSP_GetSalesOrderDetail.Components.Clear();
            this.FooterSP_GetSalesOrderDetail.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text3,
                        this.Text4,
                        this.Text97,
                        this.Text98,
                        this.Text99,
                        this.Text100,
                        this.Text101,
                        this.Text102,
                        this.Panel23,
                        this.Panel24,
                        this.Panel25,
                        this.Panel26,
                        this.Panel27,
                        this.Panel28,
                        this.Panel29,
                        this.Panel30,
                        this.Panel33,
                        this.Panel31});
            // 
            // Add to Page1.Components
            // 
            this.Page1.Components.Clear();
            this.Page1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.DataSP_GetRptSalesOrderHeader,
                        this.HeaderSP_GetSalesOrderDetail,
                        this.DataSP_GetSalesOrderDetail,
                        this.HeaderEnclosureText,
                        this.DataEmptyRow,
                        this.FooterSP_GetSalesOrderDetail});
            // 
            // Add to Panel34.Components
            // 
            this.Panel34.Components.Clear();
            this.Panel34.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text133,
                        this.Text134,
                        this.Text135,
                        this.Text136,
                        this.Text137,
                        this.Text138,
                        this.Text139});
            // 
            // Add to Data1.Components
            // 
            this.Data1.Components.Clear();
            this.Data1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text123,
                        this.Text132,
                        this.Panel34});
            // 
            // Add to Header1.Components
            // 
            this.Header1.Components.Clear();
            this.Header1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text140,
                        this.Text141,
                        this.Text142,
                        this.Text143,
                        this.Text144,
                        this.Text145,
                        this.Text146,
                        this.Text147,
                        this.Text148,
                        this.Text149,
                        this.Text150,
                        this.Text151,
                        this.Text152,
                        this.Text153,
                        this.Text154,
                        this.Text155,
                        this.Text156,
                        this.Text157,
                        this.Text158,
                        this.Text159});
            // 
            // Add to DataEnclosure.Components
            // 
            this.DataEnclosure.Components.Clear();
            this.DataEnclosure.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text160,
                        this.Text161,
                        this.Text162,
                        this.Text163,
                        this.Text164,
                        this.Text165,
                        this.Text166,
                        this.Text167,
                        this.Text168,
                        this.Text169});
            // 
            // Add to Panel35.Components
            // 
            this.Panel35.Components.Clear();
            this.Panel35.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text174,
                        this.Text175,
                        this.Text176});
            // 
            // Add to Panel36.Components
            // 
            this.Panel36.Components.Clear();
            this.Panel36.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text177,
                        this.Text178,
                        this.Text179});
            // 
            // Add to Footer1.Components
            // 
            this.Footer1.Components.Clear();
            this.Footer1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text170,
                        this.Text171,
                        this.Text172,
                        this.Text173,
                        this.Panel35,
                        this.Panel36});
            // 
            // Add to Page2.Components
            // 
            this.Page2.Components.Clear();
            this.Page2.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Data1,
                        this.Header1,
                        this.DataEnclosure,
                        this.Footer1});
            // 
            // Add to Pages
            // 
            this.Pages.Clear();
            this.Pages.AddRange(new Stimulsoft.Report.Components.StiPage[] {
                        this.Page1,
                        this.Page2});
            this.Dictionary.Relations.Add(this.ParentSP_GetRptSalesOrderHeader);
            this.SP_GetRptSalesOrderHeader.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("SalesOrderID", "SalesOrderID", "SalesOrderID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("BranchID", "BranchID", "BranchID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("BranchName", "BranchName", "BranchName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("BranchAddress", "BranchAddress", "BranchAddress", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("BranchPhone", "BranchPhone", "BranchPhone", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("BranchFax", "BranchFax", "BranchFax", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("OrderDate", "OrderDate", "OrderDate", typeof(DateTime)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("OverheadNumber", "OverheadNumber", "OverheadNumber", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerID", "CustomerID", "CustomerID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerName", "CustomerName", "CustomerName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerTaxCode", "CustomerTaxCode", "CustomerTaxCode", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerPhone", "CustomerPhone", "CustomerPhone", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerFax", "CustomerFax", "CustomerFax", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerCountryCode", "CustomerCountryCode", "CustomerCountryCode", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerCountryName", "CustomerCountryName", "CustomerCountryName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerAddress", "CustomerAddress", "CustomerAddress", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerBankID", "CustomerBankID", "CustomerBankID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerBankName", "CustomerBankName", "CustomerBankName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerBankCode", "CustomerBankCode", "CustomerBankCode", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerBankAccountNumber", "CustomerBankAccountNumber", "CustomerBankAccountNumber", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("SubTotal", "SubTotal", "SubTotal", typeof(decimal)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("TaxAmt", "TaxAmt", "TaxAmt", typeof(decimal)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Freight", "Freight", "Freight", typeof(decimal)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("TotalDue", "TotalDue", "TotalDue", typeof(decimal)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CurrencyCode", "CurrencyCode", "CurrencyCode", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CurrencyName", "CurrencyName", "CurrencyName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CurrencyCoin", "CurrencyCoin", "CurrencyCoin", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CurrencyRateID", "CurrencyRateID", "CurrencyRateID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PaymentMethodID", "PaymentMethodID", "PaymentMethodID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PaymentMethodName", "PaymentMethodName", "PaymentMethodName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("RevisionNumber", "RevisionNumber", "RevisionNumber", typeof(byte)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Comment", "Comment", "Comment", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Status", "Status", "Status", typeof(byte)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ModifiedUserID", "ModifiedUserID", "ModifiedUserID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Modifier", "Modifier", "Modifier", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ModifiedDate", "ModifiedDate", "ModifiedDate", typeof(DateTime)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ApproverUserID", "ApproverUserID", "ApproverUserID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Approver", "Approver", "Approver", typeof(string))});
            this.DataSources.Add(this.SP_GetRptSalesOrderHeader);
            this.SP_GetSalesOrderDetail.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("SalesOrderDetailID", "SalesOrderDetailID", "SalesOrderDetailID", typeof(System.Guid)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("SalesOrderID", "SalesOrderID", "SalesOrderID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ProductLocationID", "ProductLocationID", "ProductLocationID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("SaleQty", "SaleQty", "SaleQty", typeof(decimal)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("UnitPrice", "UnitPrice", "UnitPrice", typeof(decimal)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("UnitPriceDiscount", "UnitPriceDiscount", "UnitPriceDiscount", typeof(decimal)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("LineTotal", "LineTotal", "LineTotal", typeof(decimal)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("OrdinalNumber", "OrdinalNumber", "OrdinalNumber", typeof(short)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ProductID", "ProductID", "ProductID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("BranchID", "BranchID", "BranchID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PurchaseOrderDetailID", "PurchaseOrderDetailID", "PurchaseOrderDetailID", typeof(System.Guid)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("MedicamentID", "MedicamentID", "MedicamentID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ProductNumber", "ProductNumber", "ProductNumber", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("MedicamentName", "MedicamentName", "MedicamentName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Quantity", "Quantity", "Quantity", typeof(decimal)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("StandardCost", "StandardCost", "StandardCost", typeof(decimal)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ListPrice", "ListPrice", "ListPrice", typeof(decimal)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("DealerPrice", "DealerPrice", "DealerPrice", typeof(decimal)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("DiscountPct", "DiscountPct", "DiscountPct", typeof(decimal)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ValidDate", "ValidDate", "ValidDate", typeof(DateTime)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CountryCode", "CountryCode", "CountryCode", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CountryName", "CountryName", "CountryName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("BrandID", "BrandID", "BrandID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("BrandName", "BrandName", "BrandName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Serie", "Serie", "Serie", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("UnitsInStock", "UnitsInStock", "UnitsInStock", typeof(short)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("_ResidualQty", "_ResidualQty", "_ResidualQty", typeof(decimal)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("_SaleUnitQty", "_SaleUnitQty", "_SaleUnitQty", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Action", "Action", "Action", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiCalcDataColumn("LinePriceDiscount", "LinePriceDiscount", typeof(decimal))});
            this.DataSources.Add(this.SP_GetSalesOrderDetail);
        }

        public decimal GetSP_GetSalesOrderDetail_LinePriceDiscount()
        {
            return SP_GetSalesOrderDetail.UnitPrice * (1m - SP_GetSalesOrderDetail.UnitPriceDiscount);
        }

        #region Relation ParentSP_GetRptSalesOrderHeader
        public class ParentSP_GetRptSalesOrderHeaderRelation : Stimulsoft.Report.Dictionary.StiDataRow
        {

            public ParentSP_GetRptSalesOrderHeaderRelation(Stimulsoft.Report.Dictionary.StiDataRow dataRow) :
                base(dataRow)
            {
            }

            public virtual int SalesOrderID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["SalesOrderID"], typeof(int), true)));
                }
            }

            public virtual int BranchID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["BranchID"], typeof(int), true)));
                }
            }

            public virtual string BranchName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["BranchName"], typeof(string), true)));
                }
            }

            public virtual string BranchAddress
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["BranchAddress"], typeof(string), true)));
                }
            }

            public virtual string BranchPhone
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["BranchPhone"], typeof(string), true)));
                }
            }

            public virtual string BranchFax
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["BranchFax"], typeof(string), true)));
                }
            }

            public virtual DateTime OrderDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["OrderDate"], typeof(DateTime), true)));
                }
            }

            public virtual string OverheadNumber
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["OverheadNumber"], typeof(string), true)));
                }
            }

            public virtual int CustomerID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["CustomerID"], typeof(int), true)));
                }
            }

            public virtual string CustomerName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerName"], typeof(string), true)));
                }
            }

            public virtual string CustomerTaxCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerTaxCode"], typeof(string), true)));
                }
            }

            public virtual string CustomerPhone
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerPhone"], typeof(string), true)));
                }
            }

            public virtual string CustomerFax
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerFax"], typeof(string), true)));
                }
            }

            public virtual string CustomerCountryCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerCountryCode"], typeof(string), true)));
                }
            }

            public virtual string CustomerCountryName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerCountryName"], typeof(string), true)));
                }
            }

            public virtual string CustomerAddress
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerAddress"], typeof(string), true)));
                }
            }

            public virtual int CustomerBankID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["CustomerBankID"], typeof(int), true)));
                }
            }

            public virtual string CustomerBankName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerBankName"], typeof(string), true)));
                }
            }

            public virtual string CustomerBankCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerBankCode"], typeof(string), true)));
                }
            }

            public virtual string CustomerBankAccountNumber
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerBankAccountNumber"], typeof(string), true)));
                }
            }

            public virtual decimal SubTotal
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["SubTotal"], typeof(decimal), true)));
                }
            }

            public virtual decimal TaxAmt
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["TaxAmt"], typeof(decimal), true)));
                }
            }

            public virtual decimal Freight
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["Freight"], typeof(decimal), true)));
                }
            }

            public virtual decimal TotalDue
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["TotalDue"], typeof(decimal), true)));
                }
            }

            public virtual string CurrencyCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CurrencyCode"], typeof(string), true)));
                }
            }

            public virtual string CurrencyName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CurrencyName"], typeof(string), true)));
                }
            }

            public virtual string CurrencyCoin
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CurrencyCoin"], typeof(string), true)));
                }
            }

            public virtual int CurrencyRateID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["CurrencyRateID"], typeof(int), true)));
                }
            }

            public virtual int PaymentMethodID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["PaymentMethodID"], typeof(int), true)));
                }
            }

            public virtual string PaymentMethodName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["PaymentMethodName"], typeof(string), true)));
                }
            }

            public virtual byte RevisionNumber
            {
                get
                {
                    return ((byte)(StiReport.ChangeType(this["RevisionNumber"], typeof(byte), true)));
                }
            }

            public virtual string Comment
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Comment"], typeof(string), true)));
                }
            }

            public virtual byte Status
            {
                get
                {
                    return ((byte)(StiReport.ChangeType(this["Status"], typeof(byte), true)));
                }
            }

            public virtual int ModifiedUserID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ModifiedUserID"], typeof(int), true)));
                }
            }

            public virtual string Modifier
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Modifier"], typeof(string), true)));
                }
            }

            public virtual DateTime ModifiedDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["ModifiedDate"], typeof(DateTime), true)));
                }
            }

            public virtual int ApproverUserID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ApproverUserID"], typeof(int), true)));
                }
            }

            public virtual string Approver
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Approver"], typeof(string), true)));
                }
            }
        }
        #endregion Relation ParentSP_GetRptSalesOrderHeader

        #region DataSource SP_GetRptSalesOrderHeader
        public class SP_GetRptSalesOrderHeaderDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {

            public SP_GetRptSalesOrderHeaderDataSource() :
                base("DS_Sales.SP_GetRptSalesOrderHeader", "SP_GetRptSalesOrderHeader")
            {
            }

            public virtual int SalesOrderID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["SalesOrderID"], typeof(int), true)));
                }
            }

            public virtual int BranchID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["BranchID"], typeof(int), true)));
                }
            }

            public virtual string BranchName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["BranchName"], typeof(string), true)));
                }
            }

            public virtual string BranchAddress
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["BranchAddress"], typeof(string), true)));
                }
            }

            public virtual string BranchPhone
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["BranchPhone"], typeof(string), true)));
                }
            }

            public virtual string BranchFax
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["BranchFax"], typeof(string), true)));
                }
            }

            public virtual DateTime OrderDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["OrderDate"], typeof(DateTime), true)));
                }
            }

            public virtual string OverheadNumber
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["OverheadNumber"], typeof(string), true)));
                }
            }

            public virtual int CustomerID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["CustomerID"], typeof(int), true)));
                }
            }

            public virtual string CustomerName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerName"], typeof(string), true)));
                }
            }

            public virtual string CustomerTaxCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerTaxCode"], typeof(string), true)));
                }
            }

            public virtual string CustomerPhone
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerPhone"], typeof(string), true)));
                }
            }

            public virtual string CustomerFax
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerFax"], typeof(string), true)));
                }
            }

            public virtual string CustomerCountryCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerCountryCode"], typeof(string), true)));
                }
            }

            public virtual string CustomerCountryName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerCountryName"], typeof(string), true)));
                }
            }

            public virtual string CustomerAddress
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerAddress"], typeof(string), true)));
                }
            }

            public virtual int CustomerBankID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["CustomerBankID"], typeof(int), true)));
                }
            }

            public virtual string CustomerBankName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerBankName"], typeof(string), true)));
                }
            }

            public virtual string CustomerBankCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerBankCode"], typeof(string), true)));
                }
            }

            public virtual string CustomerBankAccountNumber
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerBankAccountNumber"], typeof(string), true)));
                }
            }

            public virtual decimal SubTotal
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["SubTotal"], typeof(decimal), true)));
                }
            }

            public virtual decimal TaxAmt
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["TaxAmt"], typeof(decimal), true)));
                }
            }

            public virtual decimal Freight
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["Freight"], typeof(decimal), true)));
                }
            }

            public virtual decimal TotalDue
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["TotalDue"], typeof(decimal), true)));
                }
            }

            public virtual string CurrencyCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CurrencyCode"], typeof(string), true)));
                }
            }

            public virtual string CurrencyName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CurrencyName"], typeof(string), true)));
                }
            }

            public virtual string CurrencyCoin
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CurrencyCoin"], typeof(string), true)));
                }
            }

            public virtual int CurrencyRateID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["CurrencyRateID"], typeof(int), true)));
                }
            }

            public virtual int PaymentMethodID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["PaymentMethodID"], typeof(int), true)));
                }
            }

            public virtual string PaymentMethodName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["PaymentMethodName"], typeof(string), true)));
                }
            }

            public virtual byte RevisionNumber
            {
                get
                {
                    return ((byte)(StiReport.ChangeType(this["RevisionNumber"], typeof(byte), true)));
                }
            }

            public virtual string Comment
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Comment"], typeof(string), true)));
                }
            }

            public virtual byte Status
            {
                get
                {
                    return ((byte)(StiReport.ChangeType(this["Status"], typeof(byte), true)));
                }
            }

            public virtual int ModifiedUserID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ModifiedUserID"], typeof(int), true)));
                }
            }

            public virtual string Modifier
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Modifier"], typeof(string), true)));
                }
            }

            public virtual DateTime ModifiedDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["ModifiedDate"], typeof(DateTime), true)));
                }
            }

            public virtual int ApproverUserID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ApproverUserID"], typeof(int), true)));
                }
            }

            public virtual string Approver
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Approver"], typeof(string), true)));
                }
            }
        }
        #endregion DataSource SP_GetRptSalesOrderHeader

        #region DataSource SP_GetSalesOrderDetail
        public class SP_GetSalesOrderDetailDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {

            public SP_GetSalesOrderDetailDataSource() :
                base("DS_Sales.SP_GetSalesOrderDetail", "SP_GetSalesOrderDetail")
            {
            }

            public virtual System.Guid SalesOrderDetailID
            {
                get
                {
                    return ((System.Guid)(StiReport.ChangeType(this["SalesOrderDetailID"], typeof(System.Guid), true)));
                }
            }

            public virtual int SalesOrderID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["SalesOrderID"], typeof(int), true)));
                }
            }

            public virtual int ProductLocationID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ProductLocationID"], typeof(int), true)));
                }
            }

            public virtual decimal SaleQty
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["SaleQty"], typeof(decimal), true)));
                }
            }

            public virtual decimal UnitPrice
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["UnitPrice"], typeof(decimal), true)));
                }
            }

            public virtual decimal UnitPriceDiscount
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["UnitPriceDiscount"], typeof(decimal), true)));
                }
            }

            public virtual decimal LineTotal
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["LineTotal"], typeof(decimal), true)));
                }
            }

            public virtual short OrdinalNumber
            {
                get
                {
                    return ((short)(StiReport.ChangeType(this["OrdinalNumber"], typeof(short), true)));
                }
            }

            public virtual int ProductID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ProductID"], typeof(int), true)));
                }
            }

            public virtual int BranchID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["BranchID"], typeof(int), true)));
                }
            }

            public virtual System.Guid PurchaseOrderDetailID
            {
                get
                {
                    return ((System.Guid)(StiReport.ChangeType(this["PurchaseOrderDetailID"], typeof(System.Guid), true)));
                }
            }

            public virtual int MedicamentID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["MedicamentID"], typeof(int), true)));
                }
            }

            public virtual string ProductNumber
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ProductNumber"], typeof(string), true)));
                }
            }

            public virtual string MedicamentName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["MedicamentName"], typeof(string), true)));
                }
            }

            public virtual decimal Quantity
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["Quantity"], typeof(decimal), true)));
                }
            }

            public virtual decimal StandardCost
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["StandardCost"], typeof(decimal), true)));
                }
            }

            public virtual decimal ListPrice
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["ListPrice"], typeof(decimal), true)));
                }
            }

            public virtual decimal DealerPrice
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["DealerPrice"], typeof(decimal), true)));
                }
            }

            public virtual decimal DiscountPct
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["DiscountPct"], typeof(decimal), true)));
                }
            }

            public virtual DateTime ValidDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["ValidDate"], typeof(DateTime), true)));
                }
            }

            public virtual string CountryCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CountryCode"], typeof(string), true)));
                }
            }

            public virtual string CountryName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CountryName"], typeof(string), true)));
                }
            }

            public virtual int BrandID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["BrandID"], typeof(int), true)));
                }
            }

            public virtual string BrandName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["BrandName"], typeof(string), true)));
                }
            }

            public virtual string Serie
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Serie"], typeof(string), true)));
                }
            }

            public virtual short UnitsInStock
            {
                get
                {
                    return ((short)(StiReport.ChangeType(this["UnitsInStock"], typeof(short), true)));
                }
            }

            public virtual decimal _ResidualQty
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["_ResidualQty"], typeof(decimal), true)));
                }
            }

            public virtual int _SaleUnitQty
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["_SaleUnitQty"], typeof(int), true)));
                }
            }

            public virtual int Action
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["Action"], typeof(int), true)));
                }
            }

            public virtual decimal LinePriceDiscount
            {
                get
                {
                    return ((RptSalesOrderDetailInvoice)(this.Dictionary.Report)).GetSP_GetSalesOrderDetail_LinePriceDiscount();
                }
            }

            public virtual ParentSP_GetRptSalesOrderHeaderRelation SP_GetRptSalesOrderHeader
            {
                get
                {
                    return new ParentSP_GetRptSalesOrderHeaderRelation(this.GetParentData("SP_GetRptSalesOrderHeader_SP_GetSalesOrderDetail"));
                }
            }
        }
        #endregion DataSource SP_GetSalesOrderDetail
        #endregion StiReport Designer generated code - do not modify
    }
}
