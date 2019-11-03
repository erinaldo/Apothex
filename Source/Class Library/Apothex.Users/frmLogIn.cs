using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Apothex.Common;
using Apothex.DataType;
using Zek.Core;
using Zek.Data;
using Apothex.Configuration;
using Zek.Security;
using Zek.Windows.Forms;
using Apothex.DataManagment.User;
using Apothex.DataManagment.Person;

namespace Apothex.Users
{
    public partial class frmLogIn : XtraForm
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        #region Validations
        private bool IsValidUsername()
        {
            if (Username.Length == 0)
            {
                dxErrorProvider.SetError(txtUsername, "გთხოვთ შეიყვანოთ მომხმარებლის სახელი.");
                return false;
            }

            return true;
        }
        private bool IsValidForm()
        {
            var ok = true;

            if (!IsValidUsername()) ok = false;

            return ok;
        }
        #endregion

        #region Properties
        public string Username
        {
            get { return txtUsername.Text.Trim(); }
            set { txtUsername.Text = value; }
        }

        private string _PasswordHash1 = string.Empty;
        public string Password
        {
            get { return txtPassword.Text; }
            set
            {
                //არ დაგავიწყდეს მიმდევრობის დაცვა
                if (value.Length != 0)
                {
                    txtPassword.Text = "********************************";
                    chkSave.Checked = true;
                }
                _PasswordHash1 = value;
            }
        }
        #endregion

        #region Methods
        private void LogIn()
        {
            if (IsValidForm())
            {
                try
                {
                    Application.DoEvents();
                    Cursor = Cursors.WaitCursor;

                    string passwordHash1 = (_PasswordHash1.Length == 0 ? CryptoHelper.Encrypt(Password, ConfigurationManagerEx.Salt, HashAlgorithmType.SHA1) : _PasswordHash1);
                    string passwordHash2 = CryptoHelper.Encrypt(passwordHash1, ConfigurationManagerEx.Salt, HashAlgorithmType.SHA1);

                    var table = UserManager.LogIn(Username, passwordHash2);

                    if (table.Count > 0)
                    {
                        if (table[0].UserStatus == (byte)DatabaseStatus.Blocked)
                            throw new Exception("მომხმარებელი დაბლოკილია.");

                        if (table[0].UserStatus == (byte)DatabaseStatus.Pending)
                            throw new Exception("მომხმარებელი არ არის დადასტურებული.");

                        if (table[0].BranchStatus == (byte)DatabaseStatus.Blocked)
                            throw new Exception("ოფისი, რომელშიც იმყოფება მომხმარებელი დაბლოკილია.");

                        var loginUserName = chkSave.Checked ? Username : string.Empty;
                        var loginPassword = chkSave.Checked ? passwordHash1 : string.Empty;
                        if (ConfigurationManagerEx.LoginUserName != loginUserName || ConfigurationManagerEx.LoginPassword != loginPassword)
                        {
                            ConfigurationManagerEx.LoginUserName = loginUserName;
                            ConfigurationManagerEx.LoginPassword = loginPassword;
                            ConfigurationManagerEx.Save();
                        }

                        var permission = UserManager.GetUserPermission(table[0].UserID);
                        var userPermission = new Dictionary<string, int>();
                        foreach (DS_User.SP_GetUserPermissionRow row in permission.Rows)
                        {
                            if (!userPermission.ContainsKey(row.ObjectID.ToString()))
                                userPermission.Add(row.ObjectID.ToString(), row.Logical);
                            else
                                userPermission[row.ObjectID.ToString()] |= row.Logical;
                        }


                        GlobalVariable.IsLogged = true;
                        BaseGlobalVariable.UserID = table[0].UserID;
                        GlobalVariable.Username = Username;
                        BaseGlobalVariable.Password = Password;
                        GlobalVariable.BranchID = table[0].BranchID;
                        BaseGlobalVariable.ServerDateTime = table[0].ServerDateTime.AddMilliseconds(-table[0].ServerDateTime.Millisecond);
                        BaseGlobalVariable.Permissions = userPermission;

                        //GlobalVariable.PersonID = PersonManager.FindPersonID(GlobalVariable.UserID);
                        //if (GlobalVariable.PersonID != 0)
                        //{
                        //    DS_Person.T_PersonDataTable person = PersonManager.GetPerson(GlobalVariable.PersonID);
                        //    if (person.Count > 0)
                        //    {
                        //        GlobalVariable.FullName = person[0].FullName;
                        //        GlobalVariable.JobTitle = person[0].JobTitle;
                        //    }
                        //}


                        var myCompany = PersonManager.GetMyCompany(0, !ConfigurationManagerEx.OfflineMode);
                        if (myCompany.Count > 0)
                        {
                            GlobalVariable.MyCompanyName = myCompany[0].MyCompanyName;
                            GlobalVariable.MyCompanyTaxCode = myCompany[0].TaxCode;
                            GlobalVariable.MyCompanyDirectorName = myCompany[0].DirectorName;
                            GlobalVariable.MyCompanyCountryCode = myCompany[0].CountryCode;
                            GlobalVariable.MyCompanyCountryName = myCompany[0].CountryName;
                            GlobalVariable.MyCompanyCity = myCompany[0].City;
                            GlobalVariable.MyCompanyPostalCode = myCompany[0].PostalCode;
                            GlobalVariable.MyCompanyAddress = myCompany[0].Address;
                            GlobalVariable.MyCompanyPhone = myCompany[0].Phone;
                            GlobalVariable.MyCompanyFax = myCompany[0].Fax;
                            GlobalVariable.MyCompanyBankName = myCompany[0].BankName;
                            GlobalVariable.MyCompanyBankCode = myCompany[0].BankCode;
                            GlobalVariable.MyCompanyBankAccountNumber = myCompany[0].BankAccountNumber;
                            GlobalVariable.VATPayerFlag = myCompany[0].VATPayerFlag;
                            GlobalVariable.MyCompanyConditionalUnitCurrencyCode = myCompany[0].ConditionalUnitCurrencyCode;
                            GlobalVariable.MyCompanyDefaultTradingCurrencyCode = myCompany[0].DefaultTradingCurrencyCode;
                        }

                        DialogResult = DialogResult.OK;
                    }
                    else if (GlobalVariable.AdminLogIn(Username, Password))
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        lblStatus.Text = "სახელი ან პაროლი არასწორია";
                        txtPassword.SelectAll();
                    }
                }
                catch (Exception ex)
                {
                    ExceptionHelper.Show(this, ex, "სისტემაში შესვლა ვერ მოხერხდა", MessageBoxIcon.Error);
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
            }
        }
        #endregion

        private void btnOk_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void txtUsername_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtUsername, string.Empty);
            lblStatus.Text = string.Empty;
            _PasswordHash1 = string.Empty;
        }

        private void txtPassword_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider.SetError(txtPassword, string.Empty);            
            lblStatus.Text = string.Empty;
            _PasswordHash1 = string.Empty;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                LogIn();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            Username = ConfigurationManagerEx.LoginUserName;
            Password = ConfigurationManagerEx.LoginPassword;
        }
    }
}