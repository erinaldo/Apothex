using System;
using System.Windows.Forms;
using Apothex.Windows.Forms;
using DevExpress.XtraEditors;

using Apothex.DataManagment.Dictionary;
using Apothex.DataType;
using DevExpress.XtraEditors.Controls;
using Zek.Core;
using Zek.Data;
using Apothex.Common;
using Zek.Security;
using Zek.Windows.Forms.DevEx;

namespace Apothex.Dictionary
{
    public partial class frmMedicamentEdit : frmEditBrowse
    {
        public frmMedicamentEdit()
        {
            InitializeComponent();
        }

        #region Fields
        public int ProductID
        {
            get { return ConvertHelper.ToInt32(PrimaryKey); }
            set { PrimaryKey = value; txtID.Text = value.ToString(); }
        }
        public string _ProductName
        {
            get { return txtProductName.Text.Trim(); }
            set { txtProductName.Text = value; }
        }
        public int ProductSubcategoryID
        {
            get { return ConvertHelper.ToInt32(lookProductSubcategory.EditValue); }
            set { lookProductSubcategory.EditValue = value.ToString(); }
        }
        public string ProductNumber
        {
            get { return beProductNumber.Text.Trim(); }
            set { beProductNumber.Text = value; }
        }
        public bool MakeFlag
        {
            get { return chkMakeFlag.Checked; }
            set { chkMakeFlag.Checked = value; }
        }
        public bool FinishedGoodsFlag
        {
            get { return chkFinishedGoodsFlag.Checked; }
            set { chkFinishedGoodsFlag.Checked = value; }
        }
        public string Color
        {
            get { return txtColor.Text.Trim(); }
            set { txtColor.Text = value; }
        }
        public short SafetyStockLevel
        {
            get { return (short)spinSafetyStockLevel.Value; }
            set { spinSafetyStockLevel.Value = value; }
        }
        public short ReorderPoint
        {
            get { return (short)spinReorderPoint.Value; }
            set { spinReorderPoint.Value = value; }
        }

        private decimal _StandardCost;
        public decimal StandardCost
        {
            get { return spinStandardCost.Value / CrossRate; }
            set { spinStandardCost.Value = value * CrossRate; }
        }
        private decimal _ListPrice;
        public decimal ListPrice
        {
            get { return spinListPrice.Value / CrossRate; }
            set { spinListPrice.Value = value * CrossRate; }
        }
        private decimal _DealerPrice;
        public decimal DealerPrice
        {
            get { return spinDealerPrice.Value / CrossRate; }
            set { spinDealerPrice.Value = value * CrossRate; }
        }

        public string CurrencyCode
        {
            get { return ConvertHelper.ToString(lookCurrency.EditValue); }
            set { lookCurrency.EditValue = value; }
        }
        public decimal CurrencyRate
        {
            get { return Convert.ToDecimal(lookCurrency.GetColumnValue("Code")); }
        }
        public string ProductCurrencyCode
        {
            get { return ConvertHelper.ToString(lookProductCurrency.EditValue); }
            set { lookProductCurrency.EditValue = value; }
        }
        public decimal ProductCurrencyRate
        {
            get { return Convert.ToDecimal(lookProductCurrency.GetColumnValue("Code")); }
        }
        public decimal CrossRate
        {
            get { return ProductCurrencyRate / CurrencyRate; }
        }

        public decimal DiscountPct
        {
            get { return spinDiscountPct.Value; }
            set { spinDiscountPct.Value = value; }
        }
        public decimal TaxRate
        {
            get { return spinTaxRate.Value; }
            set { spinTaxRate.Value = value; }
        }
        public string _Size
        {
            get { return txtSize.Text.Trim(); }
            set { txtSize.Text = value; }
        }
        public string SizeRange
        {
            get { return txtSizeRange.Text.Trim(); }
            set { txtSizeRange.Text = value; }
        }
        public string SizeUnitMeasureCode
        {
            get { return ConvertHelper.ToString(lookSizeUnitMeasure.EditValue); }
            set { lookSizeUnitMeasure.EditValue = value; }
        }
        public decimal Weight
        {
            get { return spinWeight.Value; }
            set { spinWeight.Value = value; }
        }
        public string WeightUnitMeasureCode
        {
            get { return ConvertHelper.ToString(lookWeightUnitMeasure.EditValue); }
            set { lookWeightUnitMeasure.EditValue = value; }
        }
        public int DaysToManufacture
        {
            get { return (int)spinDaysToManufacture.Value; }
            set { spinDaysToManufacture.Value = value; }
        }
        public string ProductLine
        {
            get { return ConvertHelper.ToString(lookProductLine.EditValue); }
            set { lookProductLine.EditValue = value; }
        }
        public string Class
        {
            get { return ConvertHelper.ToString(lookClass.EditValue); }
            set { lookClass.EditValue = value; }
        }
        public string Style
        {
            get { return ConvertHelper.ToString(lookStyle.EditValue); }
            set { lookStyle.EditValue = value; }
        }
        public int ProductModelID
        {
            get { return ConvertHelper.ToInt32(bbProductModel.RecordValue); }
            set { bbProductModel.RecordValue = value; }
        }
        public DateTime SellStartDate
        {
            get { return ConvertHelper.ToDateTime(dateSellStartDate.EditValue); }
            set { dateSellStartDate.EditValue = value; }
        }
        public DateTime SellEndDate
        {
            get { return ConvertHelper.ToDateTime(dateSellEndDate.EditValue); }
            set { dateSellEndDate.EditValue = value; }
        }
        public DateTime DiscontinuedDate
        {
            get { return ConvertHelper.ToDateTime(dateDiscontinuedDate.EditValue); }
            set { dateDiscontinuedDate.EditValue = value; }
        }

        public short UnitsInStock
        {
            get { return (short)spinUnitsInStock.Value; }
            set { spinUnitsInStock.Value = value; }
        }
        public DateTime ValidDate
        {
            get { return DateTimeHelper.GetStartOfMonth(dateValidDate.EditValue); }
            set { dateValidDate.EditValue = value; }
        }
        public int GenericID
        {
            get { return ConvertHelper.ToInt32(bbGeneric.RecordValue); }
            set { bbGeneric.RecordValue = value; }
        }
        public string CountryCode
        {
            get { return ConvertHelper.ToString(lookCountry.EditValue); }
            set { lookCountry.EditValue = value; }
        }
        public int BrandID
        {
            get { return ConvertHelper.ToInt32(lookBrand.EditValue); }
            set { lookBrand.EditValue = value.ToString(); }
        }
        public string Serie
        {
            get { return txtSerie.Text.Trim(); }
            set { txtSerie.Text = value; }
        }
        public bool AutoUpdateProducts
        {
            get { return chkAutoUpdateProducts.Checked; }
            set { chkAutoUpdateProducts.Checked = value; }
        }


        public DateTime ModifiedDate
        {
            get { return ConvertHelper.ToDateTime(dateModifiedDate.EditValue); }
            set { dateModifiedDate.EditValue = value; }
        }
        public int ModifierID
        {
            get { return ConvertHelper.ToInt32(bbModifier.RecordValue); }
            set { bbModifier.RecordValue = value; }
        }
        public int ApproverID
        {
            get { return ConvertHelper.ToInt32(bbApprover.RecordValue); }
            set { bbApprover.RecordValue = value; }
        }
        #endregion

        #region Bindings
        protected override void BindControls()
        {
            bsSubcategory.DataSource = DictionaryManager.GetDictionary(ObjectNames.MedicamentSubcategoryWithMedicamentCategoryName);

            var table = DictionaryManager.GetDictionary(ObjectNames.CurrencyWithLastRate);
            bsProductCurrency.DataSource = table.Copy();
            bsCurrency.DataSource = table.Copy();
            CurrencyCode = GlobalVariable.MyCompanyDefaultTradingCurrencyCode;

            table = DictionaryManager.GetDictionary(ObjectNames.UnitMeasure);
            bsSizeUnitMeasure.DataSource = table.Copy();
            bsWeightUnitMeasure.DataSource = table.Copy();
            bsProductLine.DataSource = DictionaryManager.GetProductLine();
            bsClass.DataSource = DictionaryManager.GetClass();
            bsStyle.DataSource = DictionaryManager.GetStyle();
            bsCountry.DataSource = DictionaryManager.GetDictionary(ObjectNames.Country);
            bsBrand.DataSource = DictionaryManager.GetDictionary(ObjectNames.Brand);


        }
        protected override void BindData()
        {
            if (Action == DatabaseAction.Edit)
            {
                var table = DictionaryManager.GetMedicament(ProductID);
                if (table.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.");

                ProductID = table[0].MedicamentID;
                ProductSubcategoryID = table[0].MedicamentSubcategoryID;
                _ProductName = table[0].Name;
                ProductNumber = table[0].ProductNumber;
                MakeFlag = table[0].MakeFlag;
                FinishedGoodsFlag = table[0].FinishedGoodsFlag;
                Color = table[0].Color;
                SafetyStockLevel = table[0].SafetyStockLevel;
                ReorderPoint = table[0].ReorderPoint;

                StandardCost = table[0].StandardCost;
                ListPrice = table[0].ListPrice;
                DealerPrice = table[0].DealerPrice;

                ProductCurrencyCode = table[0].ProductCurrencyCode;
                _StandardCost = table[0].StandardCost;
                StandardCost = table[0].StandardCost;
                _ListPrice = table[0].ListPrice;
                ListPrice = table[0].ListPrice;
                _DealerPrice = table[0].DealerPrice;
                DealerPrice = table[0].DealerPrice;


                DiscountPct = table[0].DiscountPct;
                TaxRate = table[0].TaxRate;
                _Size = table[0].Size;
                SizeRange = table[0].SizeRange;
                SizeUnitMeasureCode = table[0].SizeUnitMeasureCode;
                Weight = table[0].Weight;
                WeightUnitMeasureCode = table[0].WeightUnitMeasureCode;
                DaysToManufacture = table[0].DaysToManufacture;
                ProductLine = table[0].ProductLine;
                Class = table[0].Class;
                Style = table[0].Style;
                ProductModelID = table[0].ProductModelID;
                SellStartDate = table[0].SellStartDate;
                dateSellEndDate.EditValue = ConvertHelper.Parse(table[0][table.SellEndDateColumn]);
                dateDiscontinuedDate.EditValue = ConvertHelper.Parse(table[0][table.DiscontinuedDateColumn]);


                UnitsInStock = table[0].UnitsInStock;
                dateValidDate.EditValue = ConvertHelper.Parse(table[0][table.ValidDateColumn]);
                GenericID = table[0].GenericID;
                CountryCode = table[0].CountryCode;
                BrandID = table[0].BrandID;
                Serie = table[0].Serie;

                Status = (DatabaseStatus)table[0].Status;
                ModifiedDate = table[0].ModifiedDate;
                ModifierID = table[0].ModifiedUserID;
                ApproverID = table[0].ApproverUserID;
            }
            else
            {
                ProductCurrencyCode = GlobalVariable.MyCompanyConditionalUnitCurrencyCode;
                DoGenerateProductNumber();
                SellStartDate = BaseGlobalVariable.ServerDateTime.Date;

                ModifierID = BaseGlobalVariable.UserID;
                ModifiedDate = BaseGlobalVariable.ServerDateTime;
            }
        }
        #endregion

        #region Validations
        public bool IsValidProductName()
        {
            if (_ProductName.Length == 0)
            {
                dxErrorProvider.SetError(txtProductName, "გთხოვთ შეიყვანოთ პროდუქტის დასახელება.");
                return false;
            }

            if (!DictionaryManager.IsValidMedicamentName(ProductID, _ProductName))
            {
                dxErrorProvider.SetError(txtProductName, "ესეთი პროდუქტის სახელით უკვე არსებობს ჩანაწერი.");
                return false;
            }

            return true;
        }
        public bool IsValidProductNumber()
        {
            if (ProductNumber.Length == 0)
            {
                dxErrorProvider.SetError(beProductNumber, "გთხოვთ შეიყვანოთ პროდუქტის ნომერი.");
                return false;
            }

            if (!DictionaryManager.IsValidProductNumber(ProductID, ProductNumber))
            {
                dxErrorProvider.SetError(beProductNumber, "ესეთი პროდუქტის ნომრით უკვე არსებობს ჩანაწერი.");
                return false;
            }

            return true;
        }
        public bool IsValidProductCurrencyCode()
        {
            if (ProductCurrencyCode.Length == 0)
            {
                SetError(lookProductCurrency, "პ/ე ვალუტა არ შეიძლება იყოს ცარიელი.");
                return false;
            }

            return true;
        }
        private bool IsValidSafetyStockLevel()
        {
            if (SafetyStockLevel < 0)
            {
                dxErrorProvider.SetError(spinSafetyStockLevel, "მნიშვნელობა არ შეიძლება იყოს უარყოფითი.");
                return false;
            }

            return true;
        }
        private bool IsValidReorderPoint()
        {
            if (ReorderPoint < 0)
            {
                dxErrorProvider.SetError(spinReorderPoint, "მნიშვნელობა არ შეიძლება იყოს უარყოფითი.");
                return false;
            }

            return true;
        }
        private bool IsValidStandardCost()
        {
            if (StandardCost < 0m)
            {
                dxErrorProvider.SetError(spinStandardCost, "მნიშვნელობა არ შეიძლება იყოს უარყოფითი.");
                return false;
            }

            return true;
        }
        private bool IsValidListPrice()
        {
            if (ListPrice < 0m)
            {
                dxErrorProvider.SetError(spinListPrice, "მნიშვნელობა არ შეიძლება იყოს უარყოფითი.");
                return false;
            }

            return true;
        }
        private bool IsValidWeight()
        {
            if (Weight < 0m)
            {
                dxErrorProvider.SetError(spinWeight, "მნიშვნელობა არ შეიძლება იყოს უარყოფითი.");
                return false;
            }

            return true;
        }
        private bool IsValidDaysToManufacture()
        {
            if (DaysToManufacture < 0)
            {
                dxErrorProvider.SetError(spinDaysToManufacture, "მნიშვნელობა არ შეიძლება იყოს უარყოფითი.");
                return false;
            }

            return true;
        }
        private bool IsValidSellStartDate()
        {
            if (dateSellStartDate.EditValue == null)
            {
                dxErrorProvider.SetError(dateSellStartDate, "გთხოვთ შეიყვანოთ მნიშვნელობა.");
                return false;
            }

            return true;
        }
        public bool IsValidSellEndDate()
        {
            if (dateSellStartDate.EditValue != null && dateSellEndDate.EditValue != null && SellStartDate > SellEndDate)
            {
                dxErrorProvider.SetError(dateSellEndDate, "დასრულების თარიღი უნდა აღემატებოდეს დაწყებისას.");
                return false;
            }

            return true;
        }
        public bool IsValidUnitsInStock()
        {
            if (UnitsInStock <= 0)
            {
                dxErrorProvider.SetError(spinUnitsInStock, "!");
                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var ok = true;
            if (!IsValidProductName()) ok = false;
            if (!IsValidProductNumber()) ok = false;
            if (!IsValidProductCurrencyCode()) ok = false;
            if (!IsValidSafetyStockLevel()) ok = false;
            if (!IsValidReorderPoint()) ok = false;
            if (!IsValidStandardCost()) ok = false;
            if (!IsValidListPrice()) ok = false;
            if (!IsValidWeight()) ok = false;
            if (!IsValidDaysToManufacture()) ok = false;
            if (!IsValidSellStartDate()) ok = false;
            if (!IsValidSellEndDate()) ok = false;
            if (!IsValidUnitsInStock()) ok = false;

            return ok;
        }
        #endregion

        #region Methods
        public void DoGenerateProductNumber()
        {
            if (OptionsBaseForm.ReadOnly) return;
            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                GenerateProductNumber();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, string.Format("შეცდომა პროდუქტის ნომრის გენერაციისას.\n{0}", ex.Message), "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        public virtual void GenerateProductNumber()
        {
            string number = UniqueKeyHelper.GenerateKey(AlgorithmTypes.Random, 15, 25);
            while (!DictionaryManager.IsValidProductNumber(ProductID, number))
            {
                number = UniqueKeyHelper.GenerateKey(AlgorithmTypes.Random, 15, 25);
            }
            ProductNumber = number;
        }
        protected override void Init()
        {
            base.Init();

            XtraControlHelper.SetChildrenReadOnly(tabMain, OptionsBaseForm.ReadOnly);
        }
        protected override bool SaveData()
        {
            var id = DictionaryManager.AddOrEditMedicament(ProductID, ProductSubcategoryID, _ProductName, ProductNumber, MakeFlag, FinishedGoodsFlag, Color, SafetyStockLevel, ReorderPoint, StandardCost, ListPrice, DealerPrice, ProductCurrencyCode, DiscountPct, TaxRate, _Size, SizeRange, SizeUnitMeasureCode, Weight, WeightUnitMeasureCode, DaysToManufacture, ProductLine, Class, Style, ProductModelID, SellStartDate, SellEndDate, DiscontinuedDate, UnitsInStock, ValidDate, GenericID, CountryCode, BrandID, Serie, AutoUpdateProducts, Status, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, ApproverID, Action);
            if (id > 0) ProductID = id;

            return (id > 0);
        }
        #endregion

        private void txtProductName_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(txtProductName);
        }

        private void beProductNumber_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(beProductNumber);
        }

        private void beProductNumber_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            DoGenerateProductNumber();
        }

        private void txtColor_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtProductName, string.Empty);
        }

        private void spinReorderPoint_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(spinReorderPoint, string.Empty);
        }

        private void spinStandardCost_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(spinStandardCost, string.Empty);
        }

        private void spinListPrice_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(spinListPrice, string.Empty);
        }

        private void spinWeight_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(spinWeight, string.Empty);
        }

        private void spinDaysToManufacture_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(spinDaysToManufacture, string.Empty);
        }

        private void dateSellStartDate_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(dateSellStartDate, string.Empty);
            dxErrorProvider.SetError(dateSellEndDate, string.Empty);
        }

        private void spinSafetyStockLevel_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(spinSafetyStockLevel, string.Empty);
        }

        private void spinUnitsInStock_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(spinUnitsInStock, string.Empty);
        }

        private void lookCurrency_EditValueChanged(object sender, EventArgs e)
        {
            if (OptionsBaseForm.IsLoading) return;
            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;
                OptionsBaseForm.IsLoading = true;

                StandardCost = _StandardCost;
                ListPrice = _ListPrice;
                DealerPrice = _DealerPrice;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, string.Format("შეცდომა თანხის ცვლილებისას.\n{0}", ex.Message), "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                OptionsBaseForm.IsLoading = false;
                Cursor = Cursors.Default;
            }
        }

    }
}