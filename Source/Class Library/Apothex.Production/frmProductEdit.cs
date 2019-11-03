using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Apothex.Windows.Forms;
using DevExpress.XtraEditors;

using Apothex.DataType;
using Apothex.DataManagment.Production;
using DevExpress.XtraEditors.Controls;
using Zek.Core;
using Apothex.DataManagment.Dictionary;
using Apothex.Common;
using Zek.Data;
using Zek.Windows.Forms.DevEx;

namespace Apothex.Production
{
    public partial class frmProductEdit : frmEditBrowse
    {
        public frmProductEdit()
        {
            InitializeComponent();
        }

        #region Fields
        public int ProductID
        {
            get { return ConvertHelper.ToInt32(PrimaryKey); }
            set
            {
                PrimaryKey = value;
                txtID.Text = value.ToString();
                Text = OptionsBaseForm.Text + (value > 0 ? " №" + value.ToString() : string.Empty);
            }
        }
        public int MedicamentID
        {
            get { return ConvertHelper.ToInt32(bbMedicament.RecordValue); }
            set { bbMedicament.RecordValue = value; }
        }
        public decimal Quantity
        {
            get { return spinQuantity.Value; }
            set { spinQuantity.Value = value; }
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
        public DateTime ValidDate
        {
            get { return DateTimeHelper.GetStartOfMonth(dateValidDate.EditValue); }
            set { dateValidDate.EditValue = value; }
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
       

        public int ModifiedUserID
        {
            get { return ConvertHelper.ToInt32(bbModifier.RecordValue); }
            set { bbModifier.RecordValue = value; }
        }
        public DateTime ModifiedDate
        {
            get { return ConvertHelper.ToDateTime(dateModifiedDate.EditValue); }
            set { dateModifiedDate.EditValue = value; }
        }
        public int ApproverUserID
        {
            get { return ConvertHelper.ToInt32(bbApprover.RecordValue); }
            set { bbApprover.RecordValue = value; }
        }

        public string BarCode
        {
            get { return beBarCode.Text.Trim(); }
            set { beBarCode.Text = value; }
        }
        #endregion

        #region Bindings
        protected override void BindControls()
        {
            var table = DictionaryManager.GetDictionary(ObjectNames.CurrencyWithLastRate);
            bsProductCurrency.DataSource = table.Copy();
            bsCurrency.DataSource = table.Copy();
            CurrencyCode = GlobalVariable.MyCompanyDefaultTradingCurrencyCode;

            bsCountry.DataSource = DictionaryManager.GetDictionary(ObjectNames.Country);
            bsBrand.DataSource = DictionaryManager.GetDictionary(ObjectNames.Brand);
        }
        protected override void BindData()
        {
            if (Action == DatabaseAction.Edit)
            {
                ds_Product.SP_GetProduct.Clear();
                ds_Product.SP_GetProduct.Merge(ProductionManager.GetProduct(ProductID));
                if (ds_Product.SP_GetProduct.Count == 0) throw new ArgumentException("მონაცემი არ მოიძებნა.", "RecordID");

                ProductID = ds_Product.SP_GetProduct[0].ProductID;
                MedicamentID = ds_Product.SP_GetProduct[0].MedicamentID;
                Quantity = ds_Product.SP_GetProduct[0].Quantity;

                ProductCurrencyCode = ds_Product.SP_GetProduct[0].ProductCurrencyCode;
                _StandardCost = ds_Product.SP_GetProduct[0].StandardCost;
                StandardCost = ds_Product.SP_GetProduct[0].StandardCost;
                _ListPrice = ds_Product.SP_GetProduct[0].ListPrice;
                ListPrice = ds_Product.SP_GetProduct[0].ListPrice;
                _DealerPrice = ds_Product.SP_GetProduct[0].DealerPrice;
                DealerPrice = ds_Product.SP_GetProduct[0].DealerPrice;


                DiscountPct = ds_Product.SP_GetProduct[0].DiscountPct;
                TaxRate = ds_Product.SP_GetProduct[0].TaxRate;
                dateValidDate.EditValue = ds_Product.SP_GetProduct[0][ds_Product.SP_GetProduct.ValidDateColumn];
                CountryCode = ds_Product.SP_GetProduct[0].CountryCode;
                BrandID = ds_Product.SP_GetProduct[0].BrandID;
                Serie = ds_Product.SP_GetProduct[0].Serie;
                

                ModifiedUserID = ds_Product.SP_GetProduct[0].ModifiedUserID;
                ModifiedDate = ds_Product.SP_GetProduct[0].ModifiedDate;

                ds_Barcode.SP_GetBarcode.Clear();
                ds_Barcode.SP_GetBarcode.Merge(ProductionManager.GetBarcode(string.Empty, ProductID));
            }
            else
            {
                throw new Exception("პროდუქციაში მხოლოდ ცვლილებების შეტანაა ნებადართული.");
            }
        }
        #endregion

        #region Validations
        public bool IsValidProductCurrencyCode()
        {
            if (ProductCurrencyCode.Length == 0)
            {
                SetError(lookProductCurrency, "პ/ე ვალუტა არ შეიძლება იყოს ცარიელი.");
                return false;
            }

            return true;
        }
        public bool IsValidBarCode()
        {
            if (BarCode.Length == 0)
            {
                dxErrorProvider.SetError(beBarCode, "გთხოვთ შეიყვანოთ შტრიხ-კოდი.");
                return false;
            }

            var barcode = BarCode;
            foreach (var row in ds_Barcode.SP_GetBarcode)
            {
                if (row.RowState == DataRowState.Deleted || row.RowState == DataRowState.Detached) continue;

                if (row.Barcode == barcode)
                {
                    beBarCode.SelectAll();
                    dxErrorProvider.SetError(beBarCode, "ესეთი შტრიხ-კოდი ჩაწერილია სიაში.");
                    return false;
                }
            }

            return true;
        }
        public bool IsValidBarCodes()
        {
            DS_Barcode.SP_GetBarcodeDataTable table = DataSetHelper.PackAlternationTypedDataTable<DS_Barcode.SP_GetBarcodeDataTable>(ds_Barcode.SP_GetBarcode, DataRowState.Added);
            table.PrimaryKey = null;
            for (var i = 0; i < table.Columns.Count; i++)
            {
                if (table.Columns[i].ColumnName == table.BarcodeColumn.ColumnName ||
                    table.Columns[i].ColumnName == table.ActionColumn.ColumnName)
                    continue;
                table.Columns.Remove(table.Columns[i]);
                i--;
            }
            var ds = new DataSet("root");
            ds.Tables.Add(table);
            var invalid = ProductionManager.IsValidBarcode(string.Empty, 0, DataSetHelper.InnerBytesData(ds));

            if (invalid.Count > 0)
            {
                var error = new StringBuilder("შტრიხ-კოდები დუბლირებულია:" + Environment.NewLine);
                for (var i = 0; i < invalid.Count; i++)
                {
                    error.AppendLine(invalid[i].Barcode);
                    if (i > 15)
                    {
                        error.Append("...");
                        break;
                    }
                }
                XtraMessageBox.Show(this, error.ToString(), "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }
        protected override bool IsValidForm()
        {
            var ok = true;
            if (!IsValidProductCurrencyCode()) ok = false;
            if (!IsValidBarCodes()) ok = false;
            return ok;
        }
        #endregion

        #region Methods
        protected override void Init()
        {
            base.Init();

            XtraControlHelper.SetReadOnly(tabMain, ReadOnly);
            spinQuantity.Properties.ReadOnly = true;
            spinStandardCost.Properties.ReadOnly = true;
            XtraControlHelper.SetReadOnly(tabBarCode, ReadOnly);
        }
        public void AddBarCode()
        {
            if (OptionsBaseForm.IsLoading || ReadOnly || !IsValidBarCode()) return;

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                var row = ds_Barcode.SP_GetBarcode.NewSP_GetBarcodeRow();
                row.Barcode = BarCode;
                row.ProductID = ProductID;
                row.ModifiedUserID = BaseGlobalVariable.UserID;
                row.ModifiedDate = BaseGlobalVariable.ServerDateTime;
                ds_Barcode.SP_GetBarcode.AddSP_GetBarcodeRow(row);
                BarCode = string.Empty;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, "შეცდომა ბარათის დამატებისას.\n" + ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        public void DeleteBarCode()
        {
            if (OptionsBaseForm.IsLoading || ReadOnly) return;

            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                if (lstBarCode.SelectedItem != null && lstBarCode.SelectedItem is DataRowView)
                {
                    ((DataRowView)lstBarCode.SelectedItem).Delete();
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, "შეცდომა ბარათის წაშლისას.\n" + ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        protected override bool SaveData()
        {
            bsBarCode.EndEdit();
            DS_Barcode.SP_GetBarcodeDataTable table = DataSetHelper.PackAlternationTypedDataTable<DS_Barcode.SP_GetBarcodeDataTable>(ds_Barcode.SP_GetBarcode);
            DataSetHelper.RemoveColumns(table, true, table.BarcodeColumn, table.ActionColumn);

            var ds = new DataSet("root");
            ds.Tables.Add(table);
            var id = ProductionManager.AddOrEditProduct(ProductID, ds_Product.SP_GetProduct[0].PurchaseOrderDetailID, MedicamentID, Quantity, StandardCost, ListPrice, DealerPrice, ProductCurrencyCode, DiscountPct, TaxRate, ValidDate, CountryCode, BrandID, Serie, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, DatabaseAction.Edit, DataSetHelper.InnerBytesData(ds));
            if (id > 0)
            {
                ds_Product.AcceptChanges();
                ds_Barcode.AcceptChanges();
            }
            return (id > 0);
        }
        #endregion

        private void beBarCode_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (OptionsBaseForm.IsLoading) return;

            if (e.Button.Kind == ButtonPredefines.Plus)
            {
                AddBarCode();
            }
        }

        private void btnDeleteBarCode_Click(object sender, EventArgs e)
        {
            DeleteBarCode();
        }

        private void beBarCode_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(beBarCode, string.Empty);
        }

        private void beBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                AddBarCode();
        }

        private void lstBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                DeleteBarCode();
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

        private void spinStandardCost_EditValueChanged(object sender, EventArgs e)
        {
            if (OptionsBaseForm.IsLoading) return;

            _StandardCost = StandardCost;
        }

        private void spinListPrice_EditValueChanged(object sender, EventArgs e)
        {
            if (OptionsBaseForm.IsLoading) return;

            _ListPrice = ListPrice;
        }

        private void spinDealerPrice_EditValueChanged(object sender, EventArgs e)
        {
            if (OptionsBaseForm.IsLoading) return;

            _DealerPrice = DealerPrice;
        }

        private void lookProductCurrency_EditValueChanged(object sender, EventArgs e)
        {
            ClearError(lookProductCurrency);
        }
    }
}