using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Zek.Core;

namespace Apothex.Production
{
    public partial class frmQuantity : XtraForm
    {
        public frmQuantity(short unitsInStock, decimal maxQty, decimal unitPrice)
        {
            InitializeComponent();

            _UnitsInStock = unitsInStock;
            _MaxQty = maxQty;
            _UnitPrice = unitPrice;

            spinAvailability.Value = maxQty;
            //spinUnit.Properties.MaxValue = MathHelper.CeilingUnit(maxQty, unitsInStock);
            spinSaleUnitPrice.Value = unitPrice;

            spinOneSaleUnitPrice.Value = unitPrice * MathHelper.MinQuantity(unitsInStock, 4);
            InitSaleLineTotal();
        }

        private bool IsLoading { get; set; }
        private short _UnitsInStock;
        private decimal _MaxQty;
        private decimal _UnitPrice;

        public decimal MinQty
        {
            get { return 0.0001m; } 
        }
        public decimal OutQty
        {
            get { return calcOutQty.Value; }
        }
        /*public decimal MinQty
        {
            get { return MathHelper.MinQuantity(_UnitsInStock, 4); }
        }*/

        #region Methods
        private void InitQty(bool senderIsOutQty)
        {
            if (IsLoading) return;
            try
            {
                IsLoading = true;

                var value = (senderIsOutQty ? calcOutQty.Value : MathHelper.CeilingQuantity((int)spinUnit.Value, _UnitsInStock, 4, _MaxQty));

                if (value > _MaxQty)
                {
                    value = _MaxQty;
                    calcOutQty.Value = _MaxQty;
                }

                if (!senderIsOutQty)
                    calcOutQty.Value = value;
                spinUnit.Value = MathHelper.RoundUnit(value, _UnitsInStock, 4);
                spinAvailability.Value = _MaxQty - value;
                InitSaleLineTotal();

                IsValidOutQty();
            }
            finally
            {
                IsLoading = false;
            }
        }
        private void InitSaleLineTotal()
        {
            spinSaleLineTotal.Value = calcOutQty.Value * spinSaleUnitPrice.Value;
        }
        #endregion

        #region Validation
        private bool IsValidOutQty()
        {
            if (calcOutQty.Value == 0m)
            {
                dxErrorProvider.SetError(calcOutQty, "უნდა აღემატებოდეს 0-ს.");
                return false;
            }
            if (spinAvailability.Value < 0m)
            {
                dxErrorProvider.SetError(calcOutQty, "რაოდენობა აჭარბებს ნაშთს.");
                return false;
            }



            if (calcOutQty.Value < MinQty && calcOutQty.Value != _MaxQty)
            {
                dxErrorProvider.SetError(calcOutQty, string.Format("მნიშვნელობა უნდა აღემატებოდეს {0}-ს.", MinQty.ToString("n2")));
                return false;
            }

            dxErrorProvider.SetError(calcOutQty, string.Empty);
            return true;
        }
        #endregion

        private void calcOutQty_ValueChanged(object sender, EventArgs e)
        {
            InitQty(true);
        }


        private void spinUnit_EditValueChanged(object sender, EventArgs e)
        {
            InitQty(false);
            //calcOutQty.Value = MathHelper.CeilingQuantity((int)spinUnit.Value, _UnitsInStock, 4, _MaxQty);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!IsValidOutQty()) return;

            DialogResult = DialogResult.OK;
        }
    }
}