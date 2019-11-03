using System;
using Apothex.Windows.Forms;
using Zek.Core;

namespace Apothex.Dictionary
{
    public partial class frmMergeMedicamentEdit : frmEditBrowse
    {
        public frmMergeMedicamentEdit()
        {
            InitializeComponent();
        }

        #region Properties
        public int OldFromMedicamentID
        {
            get { return ConvertHelper.ToInt32(PrimaryKey); }
            set { PrimaryKey = value; txtID.Text = value.ToString(); }
        }
        //public int NewFromMedicamentID
        //{
        //}

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
        #endregion
    }
}