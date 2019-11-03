using System;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Zek.Core;

namespace Apothex
{
    public partial class frmAbout : XtraForm
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            Text = string.Format("{0} პროგრამის შესახებ", AssemblyHelper.AssemblyTitle);
            lblProductName.Text += " " + AssemblyHelper.AssemblyProduct;
            lblVersion.Text += " " + AssemblyHelper.ApplicationVersion;
            lblCopyright.Text += " " + AssemblyHelper.AssemblyCopyright;
            lblCompanyName.Text += " " + AssemblyHelper.AssemblyCompany;
            memoDescription.Text = AssemblyHelper.AssemblyDescription;
        }

        private void lnkVisitSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(lnkVisitSite.Text);
            }
            catch { }
        }
    }
}