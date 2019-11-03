using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Zek.Net;
using Zek.Core;
using Zek.Validation;

namespace Apothex
{
    public partial class frmFeedback : XtraForm
    {
        public frmFeedback()
        {
            InitializeComponent();
        }

        #region Validations
        private bool IsValidName()
        {
            if (txtName.Text.Length == 0)
            {
                dxErrorProvider.SetError(txtName, "გთხოვთ შეიყვანოთ სახელი");
                return false;
            }

            return true;
        }
        private bool IsValidEmail()
        {
            if (txtEmail.Text.Length == 0)
            {
                dxErrorProvider.SetError(txtEmail, "გთხოვთ შეიყვანოთ ელ. ფოსტა");
                return false;
            }
            else if (!ValidationHelper.IsValidEmail(txtEmail.Text))
            {
                dxErrorProvider.SetError(txtEmail, "გთხოვთ შეიყვანოთ სწორი ელ. ფოსტა");
                return false;
            }

            return true;
        }
        private bool IsValidSubject()
        {
            if (txtSubject.Text.Length == 0)
            {
                dxErrorProvider.SetError(txtSubject, "გთხოვთ შეიყვანოთ სათაური");
                return false;
            }

            return true;
        }
        private bool IsValidMessage()
        {
            if (memoMessage.Text.Length == 0)
            {
                dxErrorProvider.SetError(memoMessage, "გთხოვთ შეიყვანოთ მესიჯი");
                return false;
            }

            return true;
        }
        private bool IsValidForm()
        {
            var ok = true;
            if (!IsValidName()) ok = false;
            if (!IsValidEmail()) ok = false;
            if (!IsValidSubject()) ok = false;
            if (!IsValidMessage()) ok = false;

            return ok;
        }
        #endregion

        private void btnOk_Click(object sender, EventArgs e)
        {
            var ok = IsValidForm();
            if (ok)
            {
                try
                {
                    Application.DoEvents();
                    Cursor = Cursors.WaitCursor;

                    var postData = new Dictionary<string, string>();

                    var msg = string.Empty;
                    msg += "Application Name: " + AssemblyHelper.AssemblyTitle + " " + AssemblyHelper.ApplicationVersion;
                    msg += "\r\nAssembly Guid: " + AssemblyHelper.AssemblyGuid;
                    msg += "\r\nLocal IP: " + DnsHelper.GetIPAddress();
                    msg += "\r\n---\r\n" + memoMessage.Text + "\r\n---";

                    postData.Add("name", txtName.Text);
                    postData.Add("email", txtEmail.Text);
                    postData.Add("subject", txtSubject.Text);
                    postData.Add("message", msg);

                    if (WebRequestHelper.SendData("http://www.programmer.ge/feedback/", "POST", postData) == "OK")
                        DialogResult = DialogResult.OK;
                    else
                        XtraMessageBox.Show(this, "გაგზავნა ვერ მოხერხდა.", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(this, "გაგზავნა ვერ მოხერხდა.\n" + ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
            }
        }

        private void txtName_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtName, string.Empty);
        }

        private void txtEmail_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtEmail, string.Empty);
        }

        private void txtSubject_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtSubject, string.Empty);
        }

        private void memoMessage_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(memoMessage, string.Empty);
        }
    }
}