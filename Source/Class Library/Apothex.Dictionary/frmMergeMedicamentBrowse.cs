using Apothex.Windows.Forms;

namespace Apothex.Dictionary
{
    public partial class frmMergeMedicamentBrowse : frmBrowse
    {
        public frmMergeMedicamentBrowse()
        {
            InitializeComponent();
        }


        //private DevExpress.Xpo.Session _Session = null;
        //private DevExpress.Xpo.XPServerCollectionSource _XpServerCollectionSource = null;
        public void BindingXpo()
        {
            //if (_Session == null)
            //{
            //    gridControl.ServerMode = true;
            //    gridView.OptionsView.ShowAutoFilterRow = true;//
            //    Apothex.Xpo.XpoHelper.Fill(ref _Session, typeof(Apothex.Xpo.Dictionary_VW_MergeMedicament), ref _XpServerCollectionSource, FilterStatusSql);
            //    gridControl.DataSource = _XpServerCollectionSource;
            //}
            //else
            //    Apothex.Xpo.XpoHelper.Fill(ref _Session, typeof(Apothex.Xpo.Dictionary_VW_MergeMedicament), ref _XpServerCollectionSource, FilterStatusSql);
        }
        protected override void BindGrid()
        {
            BindingXpo();
        }
    }
}