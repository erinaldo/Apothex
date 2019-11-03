using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Timers;
using System.Windows.Forms;
using Apothex.Card;
using Apothex.Cashbox;
using Apothex.Configuration;
using Apothex.DataType;
using Apothex.Dictionary;
using Apothex.Import;
using Apothex.Person;
using Apothex.Pivot;
using Apothex.Production;
using Apothex.Purchasing;
using Apothex.Request;
using Apothex.Sales;
using Apothex.Synchronization;
using Apothex.Users;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

using Apothex.Common;
using Zek.Core;
using Zek.Data;
using Zek.Win32;
using Zek.Windows.Forms;
using Apothex.Windows;
using Zek.CryptoLicensing;

namespace Apothex
{
    public partial class frmMain : XtraForm
    {
        public frmMain()
        {
            InitializeComponent();

            Text += string.Format(" - {0}", AssemblyHelper.ApplicationVersion);

            InitSettings();
            InitLicence();//es da InitSettings() უნდა გადავანაცვლო

            ips_Init();
            InitSkins();

            InitTabbedMDI();
            RegisterForms();
        }

        #region Properties
        //private bool IsExpired
        //{
        //    get { return TrialMakerHelper.IsExpired; }
        //}
        private bool IsExpired
        {
            get { return !CryptoLicenseEx.IsValid; }
        }

        private bool IsTabbedMdi { get { return miTabbedMDI.Checked; } }
        #endregion

        #region Licence
        //private void InitLicence()
        //{
        //    switch (Zek.Licensing.Client.TrialMakerHelper.RunType)
        //    {
        //        case Zek.Licensing.Client.RunTypes.Full:
        //            miLicence.Caption = "სრული";
        //            timerLicence.Stop();
        //            break;
        //        case Zek.Licensing.Client.RunTypes.Trial:
        //            miLicence.Caption = "დროებითი (დარჩა " + Zek.Licensing.Client.TrialMakerHelper.DefDays + " დღე)";
        //            break;
        //        case Zek.Licensing.Client.RunTypes.Expired:
        //            miLicence.Caption = "არალიცენზირებული";
        //            timerLicence.Stop();
        //            break;
        //        default:
        //            miLicence.Caption = "დაუდგენელი";
        //            break;
        //    }
        //}
        private void InitLicence()
        {
            if (CryptoLicenseEx.IsValid)
            {
                if (CryptoLicenseEx.Instance.IsEvaluationLicense())
                {
                    miLicence.Caption = "დროებითი (დარჩა " + CryptoLicenseEx.Instance.RemainingDays + " დღე)";
                }
                else
                {
                    timerLicence.Stop();
                    miLicence.Caption = "სრული";
                }
            }
            else
            {
                miLicence.Caption = string.Format(" არალიცენზირებული ({0})", CryptoLicenseEx.Instance.Status);
            }
        }
        #endregion

        #region Skins
        private string skinMask = "თემა: ";
        private void InitSkins()
        {
            barManager.ForceInitialize();
            for (var i = 0; i < SkinManager.Default.Skins.Count; i++)
            {
                var item = new BarButtonItem(barManager, skinMask + SkinManager.Default.Skins[i].SkinName);
                miPaintStyle.AddItem(item);
                item.ItemClick += new ItemClickEventHandler(OnSkinClick);

                if (ConfigurationManagerEx.SkinName == SkinManager.Default.Skins[i].SkinName && ConfigurationManagerEx.SkinName != UserLookAndFeel.Default.ActiveSkinName)
                    OnSkinClick(this, new ItemClickEventArgs(item, (item.Links.Count > 0 ? item.Links[0] : null)));
            }


            if (SkinManager.AllowFormSkins)
                SkinManager.DisableFormSkins();

            if (ConfigurationManagerEx.AllowFormSkins)
                OnSwitchFormSkinStyle_Click(this, new ItemClickEventArgs(miAllowFormSkins, (miAllowFormSkins.Links.Count > 0 ? miAllowFormSkins.Links[0] : null)));
        }
        private void OnSkinClick(object sender, ItemClickEventArgs e)
        {
            var skinName = e.Item.Caption.Replace(skinMask, string.Empty);
            UserLookAndFeel.Default.SetSkinStyle(skinName);
            barManager.GetController().PaintStyleName = "Skin";
            miPaintStyle.Caption = e.Item.Caption;
            miPaintStyle.Hint = miPaintStyle.Caption;
            miPaintStyle.ImageIndex = -1;

            if (sender is frmMain)
                return;

            try
            {
                ConfigurationManagerEx.SkinName = skinName;
                ConfigurationManagerEx.Save();
            }
            catch (Exception ex)
            {
                ExceptionHelper.Show(this, ex, "შეცდომა თემის შენახვისას", MessageBoxIcon.Error);
            }
        }
        private void OnSwitchFormSkinStyle_Click(object sender, ItemClickEventArgs e)
        {
            if (SkinManager.AllowFormSkins)
            {
                SkinManager.DisableFormSkins();
                miAllowFormSkins.Checked = false;
            }
            else
            {
                SkinManager.EnableFormSkins();
                miAllowFormSkins.Checked = true;
            }
            LookAndFeelHelper.ForceDefaultLookAndFeelChanged();


            if (sender is frmMain)
                return;
            try
            {
                ConfigurationManagerEx.AllowFormSkins = SkinManager.AllowFormSkins;
                ConfigurationManagerEx.Save();
            }
            catch (Exception ex)
            {
                ExceptionHelper.Show(this, ex, "შეცდომა თემის ჩართვის შენახვისას", MessageBoxIcon.Error);
            }
        }
        private void InitPaintStyle(BarItem item)
        {
            if (item == null) return;
            miPaintStyle.ImageIndex = item.ImageIndex;
            miPaintStyle.Caption = item.Caption;
            miPaintStyle.Hint = item.Description;
        }
        private void ips_ItemClick(object sender, ItemClickEventArgs e)
        {
            barManager.GetController().PaintStyleName = e.Item.Description;
            InitPaintStyle(e.Item);
            barManager.GetController().ResetStyleDefaults();
            UserLookAndFeel.Default.SetDefaultStyle();
        }
        private void ips_Init()
        {
            BarItem item = null;
            for (var i = 0; i < barManager.Items.Count; i++)
                if (barManager.Items[i].Description == barManager.GetController().PaintStyleName)
                    item = barManager.Items[i];
            InitPaintStyle(item);
        }
        #endregion

        #region Methods
        private void InitSettings()
        {
            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                ConfigurationManagerEx.Load();

                miOnline.Visibility = (ConfigurationManagerEx.OfflineMode ? BarItemVisibility.Always : BarItemVisibility.Never);
                //new Thread(delegate()
                //{
                //    if (InvokeRequired)
                //    {
                //        BeginInvoke((ThreadStart)delegate()
                //        {
                //code here
                //});
                //    }
                //}).Start();
            }
            catch (Exception ex)
            {
                ExceptionHelper.Show(this, ex, "კონფიგურაციის ჩატვირთვა ვერ მოხერხდა", MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private bool IsLogged
        {
            get { return GlobalVariable.IsLogged; }
        }
        private bool IsPermitted(ObjectNames objectName)
        {
            return IsPermitted(objectName, DatabaseAction.View);
        }
        private bool IsPermitted(ObjectNames objectName, DatabaseAction action)
        {
            return PermissionHelper.IsPermitted(objectName, action);
        }
        private void EnableDisableMenuItems()
        {
            miBackupRestore.Enabled = (IsPermitted(ObjectNames.BackupDatabase, DatabaseAction.Add) || IsPermitted(ObjectNames.RestoreDatabase, DatabaseAction.Add)) && !IsExpired;


            miPurchaseOrders.Enabled = IsPermitted(ObjectNames.PurchaseOrderHeader);
            miSalesOrders.Enabled = IsPermitted(ObjectNames.SalesOrderHeader);
            miCloseDays.Enabled = IsPermitted(ObjectNames.CloseDay);
            miProductDistribution.Enabled = IsPermitted(ObjectNames.ProductDistributionHeader);
            miRequest.Enabled = IsPermitted(ObjectNames.Request);
            miWarehouseDescriptions.Enabled = IsPermitted(ObjectNames.WarehouseDescriprion);
            miProductLocation.Enabled = IsPermitted(ObjectNames.ProductLocation);
            miProduct.Enabled = IsPermitted(ObjectNames.Product);
            miSynchronization.Enabled = IsPermitted(ObjectNames.Synchronize, DatabaseAction.Add);


            miPurchaseOrderDetailBalance.Enabled = IsPermitted(ObjectNames.PurchaseOrderDetailInfo);
            miSalesOrderDetailBalance.Enabled = IsPermitted(ObjectNames.SalesOrderDetailInfo);
            miProductLocationinfoBrowse.Enabled = IsPermitted(ObjectNames.ProductDistributionDetailInfo);
            miSalesOrderHeaderPurchaseTotal.Enabled = IsPermitted(ObjectNames.SalesOrderHeaderPurchaseTotal);
            miSalesOrderHeaderGroupByDate.Enabled = IsPermitted(ObjectNames.SalesOrderHeaderGroupByDate);
            miSalesOrderDetailInfoVendor.Enabled = IsPermitted(ObjectNames.SalesOrderDetailInfoVendor);
            miSalesOrderDetailDefecture.Enabled = IsPermitted(ObjectNames.SalesOrderDetailDefecture);
            miChangePriceAct.Enabled = IsPermitted(ObjectNames.ProductListPriceHistory);
            miRealIncomeExpence.Enabled = IsPermitted(ObjectNames.RealIncomeExpence);
            miSalesOrderDetailPivot.Enabled = IsPermitted(ObjectNames.SalesOrderDetailPivot);

            miPurchaseList.Enabled = IsPermitted(ObjectNames.PurchaseOrderHeader, DatabaseAction.Print);
            miProductDistributionDetailList.Enabled = IsPermitted(ObjectNames.ProductDistributionHeader, DatabaseAction.Print);
            miSalesOrderDetailList.Enabled = IsPermitted(ObjectNames.SalesOrderHeader, DatabaseAction.Print);
            miProductLocationMIS.Enabled = IsPermitted(ObjectNames.ProductLocationMIS);
            miNominations.Enabled = IsPermitted(ObjectNames.Nomination);


            miMedicaments.Enabled = IsPermitted(ObjectNames.Medicament);
            miMergeMedicaments.Enabled = IsPermitted(ObjectNames.MergeMedicament);
            miGenerics.Enabled = IsPermitted(ObjectNames.Generic);
            miMedicamentCategories.Enabled = IsPermitted(ObjectNames.MedicamentCategory);
            miMedicamentSubcategories.Enabled = IsPermitted(ObjectNames.MedicamentSubcategory);
            miUnitMeashures.Enabled = IsPermitted(ObjectNames.UnitMeasure);
            miCountries.Enabled = IsPermitted(ObjectNames.Country);
            miBanks.Enabled = IsPermitted(ObjectNames.Bank);
            miBrands.Enabled = IsPermitted(ObjectNames.Brand);
            miPerson.Enabled = IsPermitted(ObjectNames.Person);
            miPersonCategories.Enabled = IsPermitted(ObjectNames.PersonCategory);
            miCompanies.Enabled = IsPermitted(ObjectNames.Company);
            miPaymentMethods.Enabled = IsPermitted(ObjectNames.PaymentMethod);
            miCurrencies.Enabled = IsPermitted(ObjectNames.Medicament);
            miCurrencyRates.Enabled = IsPermitted(ObjectNames.CurrencyRate);

            miCard.Enabled = IsPermitted(ObjectNames.Card);
            miCardPointTransfer.Enabled = IsPermitted(ObjectNames.PointTransfer);
            miCardType.Enabled = IsPermitted(ObjectNames.CardType);
            miCardDiscountSchema.Enabled = IsPermitted(ObjectNames.CardDiscountSchema);
            miCardUnitRate.Enabled = IsPermitted(ObjectNames.CardUnitRate);
            iCardHandle.Enabled = IsPermitted(ObjectNames.CardHandle);
            iBonusAccumulation.Enabled = IsPermitted(ObjectNames.BonusAccumulation);

            miCashbox.Enabled = IsPermitted(ObjectNames.Cashbox);

            miMyCompany.Enabled = !IsExpired && IsPermitted(ObjectNames.MyCompany, DatabaseAction.Add);
            miBranchs.Enabled = IsPermitted(ObjectNames.Branch);
            miUsers.Enabled = IsPermitted(ObjectNames.User);
            miGroups.Enabled = IsPermitted(ObjectNames.UserGroup);

            miInfo10.Enabled = IsPermitted(ObjectNames.Info10, DatabaseAction.Add);


            miOptions.Enabled = (BaseGlobalVariable.UserID == 0);
        }
        private void CloseChildren()
        {
            foreach (var frm in MdiChildren)
                frm.Close();
        }
        private void LogIn()
        {
            if (new frmLogIn().ShowDialog(this) == DialogResult.OK)
            {
                miLogIn.Enabled = false;
                miLogOut.Enabled = true;

                miServerName.Caption = ConfigurationManagerEx.ServerName;
                miDatabaseName.Caption = ConfigurationManagerEx.DatabaseName;
                miUser.Caption = GlobalVariable.Username;

                miServerDateTime.Caption = BaseGlobalVariable.ServerDateTime.ToString();
                timerServer.Start();
            }

            EnableDisableMenuItems();
        }
        private void LogOut()
        {
            CloseChildren();

            if (MdiChildren.Length > 0)
            {
                XtraMessageBox.Show(this, "გთხოვთ დახუროთ შიდა ფანჯრები და შემდეგ გამოხვდეთ სისტემიდან", "ინფორმაცია", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            GlobalVariable.InitGlobalVariable();

            miLogIn.Enabled = true;
            miLogOut.Enabled = false;

            miServerName.Caption =
            miDatabaseName.Caption =
            miUser.Caption = string.Empty;

            EnableDisableMenuItems();
        }
        private void InitTabbedMDI()
        {
            xtraTabbedMdiManager.MdiParent = IsTabbedMdi ? this : null;
            miCascade.Visibility = miTileHorizontal.Visibility = miTileVertical.Visibility = IsTabbedMdi ? BarItemVisibility.Never : BarItemVisibility.Always;
        }
        private void RegisterForms()
        {
            try
            {
                FormHelper.MdiParent = this;



                FormHelper.RegisterForm((int)ObjectNames.PurchaseOrderHeader, typeof(frmPurchaseOrderBrowse), typeof(frmPurchaseOrderEdit));
                FormHelper.RegisterForm((int)ObjectNames.SalesOrderHeader, typeof(frmSalesOrderBrowse), typeof(frmSalesOrderEdit));
                FormHelper.RegisterForm((int)ObjectNames.CloseDay, typeof(frmCloseDayBrowse), typeof(frmCloseDayEdit));
                FormHelper.RegisterForm((int)ObjectNames.ProductDistributionHeader, typeof(frmProductDistributionBrowse), typeof(frmProductDistributionEdit));
                FormHelper.RegisterForm((int)ObjectNames.Request, typeof(frmRequestBrowse), typeof(frmRequestEdit));
                FormHelper.RegisterForm((int)ObjectNames.WarehouseDescriprion, typeof(frmWarehouseDescriptionBrowse), typeof(frmWarehouseDescriptionEdit));
                FormHelper.RegisterForm((int)ObjectNames.ProductLocation, FormStyle.Browse, typeof(frmProductLocationBrowse));
                FormHelper.RegisterForm((int)ObjectNames.Product, typeof(frmProductBrowse), typeof(frmProductEdit));


                FormHelper.RegisterForm((int)ObjectNames.PurchaseOrderDetailInfo, typeof(frmPurchaseOrderDetailInfoBrowse), typeof(frmPurchaseOrderEdit));
                FormHelper.RegisterForm((int)ObjectNames.SalesOrderDetailInfo, typeof(frmSalesOrderDetailInfoBrowse), typeof(frmSalesOrderEdit));
                FormHelper.RegisterForm((int)ObjectNames.ProductDistributionDetailInfo, typeof(frmProductDistributionDetailInfoBrowse), typeof(frmProductDistributionEdit));
                FormHelper.RegisterForm((int)ObjectNames.SalesOrderHeaderPurchaseTotal, typeof(frmSalesOrderHeaderPurchaseTotal), typeof(frmSalesOrderEdit));
                FormHelper.RegisterForm((int)ObjectNames.SalesOrderHeaderGroupByDate, FormStyle.Browse, typeof(frmSalesOrderHeaderGroupByDateBrowse));
                FormHelper.RegisterForm((int)ObjectNames.SalesOrderDetailInfoVendor, typeof(frmSalesOrderDetailInfoVendorBrowse), typeof(frmSalesOrderEdit));
                FormHelper.RegisterForm((int)ObjectNames.SalesOrderDetailDefecture, FormStyle.Browse, typeof(frmSalesOrderDetailInfoVendorBrowse));
                FormHelper.RegisterForm((int)ObjectNames.RealIncomeExpence, FormStyle.Browse, typeof(frmProductDistributionDetailInfoBrowse));

                FormHelper.RegisterForm((int)ObjectNames.ProductLocationMIS, FormStyle.Browse, typeof(frmProductLocationMISBrowse));


                FormHelper.RegisterForm((int)ObjectNames.Medicament, typeof(frmMedicamentBrowse), typeof(frmMedicamentEdit));
                FormHelper.RegisterForm((int)ObjectNames.MergeMedicament, typeof(frmMergeMedicamentBrowse), typeof(frmMergeMedicamentEdit));
                FormHelper.RegisterForm((int)ObjectNames.Generic, typeof(frmGenericBrowse), typeof(frmGenericEdit));
                FormHelper.RegisterForm((int)ObjectNames.MedicamentCategory, typeof(frmMedicamentCategoryBrowse), typeof(frmMedicamentCategoryEdit));
                FormHelper.RegisterForm((int)ObjectNames.MedicamentSubcategory, typeof(frmMedicamentSubcategoryBrowse), typeof(frmMedicamentSubcategoryEdit));
                FormHelper.RegisterForm((int)ObjectNames.UnitMeasure, typeof(frmUnitMeasureBrowse), typeof(frmUnitMeasureEdit));
                FormHelper.RegisterForm((int)ObjectNames.Country, typeof(frmCountryBrowse), typeof(frmCountryEdit));
                FormHelper.RegisterForm((int)ObjectNames.Bank, typeof(frmBankBrowse), typeof(frmBankEdit));
                FormHelper.RegisterForm((int)ObjectNames.Brand, typeof(frmBrandBrowse), typeof(frmBrandEdit));

                FormHelper.RegisterForm((int)ObjectNames.Person, typeof(frmPersonBrowse), typeof(frmPersonEdit));
                FormHelper.RegisterForm((int)ObjectNames.PersonCategory, typeof(frmPersonCategoryBrowse), typeof(frmPersonCategoryEdit));
                FormHelper.RegisterForm((int)ObjectNames.Company, typeof(frmCompanyBrowse), typeof(frmCompanyEdit));

                FormHelper.RegisterForm((int)ObjectNames.PaymentMethod, typeof(frmPaymentMethodBrowse), typeof(frmPaymentMethodEdit));
                FormHelper.RegisterForm((int)ObjectNames.Currency, typeof(frmCurrencyBrowse), typeof(frmCurrencyEdit));
                FormHelper.RegisterForm((int)ObjectNames.CurrencyRate, typeof(frmCurrencyRateBrowse), typeof(frmCurrencyRateEdit));



                FormHelper.RegisterForm((int)ObjectNames.MyCompany, FormStyle.Edit, typeof(frmMyCompanyEdit));
                FormHelper.RegisterForm((int)ObjectNames.Branch, typeof(frmBranchBrowse), typeof(frmBranchEdit));
                FormHelper.RegisterForm((int)ObjectNames.UserGroup, typeof(frmUserGroupBrowse), typeof(frmUserGroupEdit));
                FormHelper.RegisterForm((int)ObjectNames.User, typeof(frmUserBrowse), typeof(frmUserEdit));



                FormHelper.RegisterForm((int)ObjectNames.Card, typeof(frmCardBrowse), typeof(frmCardEdit));
                FormHelper.RegisterForm((int)ObjectNames.CardAndHolderByCardNumber, typeof(frmCardBrowse), typeof(frmCardEdit));
                FormHelper.RegisterForm((int)ObjectNames.PointTransfer, typeof(frmPointTransferBrowse), typeof(frmPointTransferEdit));
                FormHelper.RegisterForm((int)ObjectNames.CardType, typeof(frmCardTypeBrowse), typeof(frmCardTypeEdit));
                FormHelper.RegisterForm((int)ObjectNames.CardDiscountSchema, typeof(frmCardDiscountSchemaBrowse), typeof(frmCardDiscountSchemaEdit));
                FormHelper.RegisterForm((int)ObjectNames.CardUnitRate, typeof(frmCardUnitRateBrowse), typeof(frmCardUnitRateEdit));
                FormHelper.RegisterForm((int)ObjectNames.CardHandle, typeof(frmCardHandleBrowse), typeof(frmSalesOrderEdit));
                FormHelper.RegisterForm((int)ObjectNames.BonusAccumulation, FormStyle.Browse, typeof(frmBonusAccumulationBrowse));

                FormHelper.RegisterForm((int)ObjectNames.Cashbox, typeof(frmCashboxOrderBrowse), typeof(frmCashboxOrderEdit));
                
                //FormHelper.RegisterForm((int)Apothex.DataType.ObjectNames.PersonRead, FormStyles.Browse, typeof(Apothex.Sales.frmPersonReadBrowse));
                //FormHelper.RegisterForm((int)Apothex.DataType.ObjectNames.PersonReadAllBranch, FormStyles.Browse, typeof(Apothex.Sales.frmPersonReadBrowse));

                FormHelper.RegisterForm((int)ObjectNames.Info10, FormStyle.Edit, typeof(frmImportInfo10Edit));


            }
            catch (Exception ex)
            {
                ExceptionHelper.Show(this, ex, "შეცდომა ფორმების ინიციალიზაციის დროს", MessageBoxIcon.Error);
            }
        }
        #endregion

        private void frmMain_Shown(object sender, EventArgs e)
        {
            Win32Native.ActivateWindow(Handle, (int)Win32Native.ShowWindowCommand.SW_SHOWMAXIMIZED);

            LogIn();

            //FormHelper.Show(typeof(Sales.frmSalesOrderEdit), this, IntPtr.Zero, 339612);
            //FormHelper.Show(typeof(Sales.frmSalesOrderEdit), this, IntPtr.Zero, 379121);
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            miServerDateTime.Caption = BaseGlobalVariable.ServerDateTime.ToString();
            BaseGlobalVariable.ServerDateTime = BaseGlobalVariable.ServerDateTime.AddMilliseconds(timerServer.Interval);
            //TrialMakerHelper.CurrentDateTime = GlobalVariable.ServerDateTime;
        }

        private void timerLicence_Elapsed(object sender, ElapsedEventArgs e)
        {
            InitLicence();
        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void iCountries_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmCountryBrowse), this);
        }

        private void iLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            LogIn();
        }

        private void iLogOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            LogOut();
        }

        private void iUnitMeashures_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmUnitMeasureBrowse), this);
        }

        private void iMedicamentCategories_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmMedicamentCategoryBrowse), this);
        }

        private void iMedicaments_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmMedicamentBrowse), this);
        }

        private void iPaymentMethods_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmPaymentMethodBrowse), this);
        }

        private void iPurchaseOrders_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmPurchaseOrderBrowse), this);
        }

        private void iSalesOrders_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmSalesOrderBrowse), this);
        }

        private void iMyCompany_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsExpired)
                return;

            FormHelper.Show(typeof(frmMyCompanyEdit), this);
        }

        private void iBranchs_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmBranchBrowse), this);
        }

        private void iGroups_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmUserGroupBrowse), this);
        }

        private void iUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmUserBrowse), this);
        }

        private void iOptions_ItemClick(object sender, ItemClickEventArgs e)
        {
            new frmOptions().ShowDialog(this);
        }

        private void iAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            new frmAbout().ShowDialog(this);
        }

        private void iFeedback_ItemClick(object sender, ItemClickEventArgs e)
        {
            new frmFeedback().ShowDialog(this);
        }

        private void iCompanies_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmCompanyBrowse), this);
        }

        private void iCurrencies_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmCurrencyBrowse), this);
        }

        private void iCurrencyRates_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmCurrencyRateBrowse), this);
        }

        private void iTabbedMDI_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            InitTabbedMDI();
        }

        private void iCascade_ItemClick(object sender, ItemClickEventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void iTileHorizontal_ItemClick(object sender, ItemClickEventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void iTileVertical_ItemClick(object sender, ItemClickEventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void iCloseWindows_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseChildren();
        }

        private void iHowDoI_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var path = Path.Combine(Directory.GetParent(Application.StartupPath).FullName, @"Docs\UserManual.chm");
                if (!File.Exists(path))
                    throw new FileNotFoundException(string.Format("ფაილი '{0}' ვერ მოიძებნა.", path));

                Process.Start(path);
            }
            catch (Exception ex)
            {
                ExceptionHelper.Show(this, ex, "შეცდომა", MessageBoxIcon.Error);
            }
        }

        private void iBanks_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmBankBrowse), this);
        }

        private void iCloseDays_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmCloseDayBrowse), this);
        }

        private void iMedicamentSubcategories_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmMedicamentSubcategoryBrowse), this);
        }

        private void xtraTabbedMdiManager_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle && xtraTabbedMdiManager.SelectedPage != null)
            {
                xtraTabbedMdiManager.SelectedPage.MdiChild.Close();
            }
        }

        private void iProductLocation_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmProductLocationBrowse), this);
        }


        private void iBackupRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            throw new NotImplementedException();
            //bool isAllowedBackup = PermissionHelper.IsPermitted(Apothex.DataType.ObjectNames.BackupDatabase, (int)Zek.Data.DatabaseAction.Add);
            //bool isAllowedRestore = PermissionHelper.IsPermitted(Apothex.DataType.ObjectNames.RestoreDatabase, (int)Zek.Data.DatabaseAction.Add);

            //if (GlobalVariable.IsLogged && (isAllowedBackup || isAllowedRestore) && !IsExpired)
            //{
            //    using (Apothex.Configuration.frmBackupRestore frm = new Apothex.Configuration.frmBackupRestore(isAllowedBackup, isAllowedRestore))
            //    {
            //        frm.ShowDialog(this);
            //    }
            //}
        }

        private void iProductDistribution_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmProductDistributionBrowse), this);
        }

        private void iPurchaseOrderDetailBalance_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmPurchaseOrderDetailInfoBrowse), this);
        }

        private void iSalesOrderDetailBalance_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmSalesOrderDetailInfoBrowse), this);
        }

        private void iProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmProductBrowse), this);
        }

        private void iBrands_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmBrandBrowse), this);
        }

        private void i1024x768_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            Size = new Size(1024, 768);
        }

        private void miSynchronization_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsExpired) return;

            FormHelper.Show(typeof(frmSynchronizeEdit), this);
        }

        private void miOnline_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            ConfigurationManagerEx.IsOnline = miOnline.Checked;
        }

        private void miMergeMedicaments_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmMergeMedicamentBrowse), this);
        }

        private void miSalesOrderHeaderPurchaseTotal_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmSalesOrderHeaderPurchaseTotal), this);
        }

        private void miSalesOrderDetailInfoVendor_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmSalesOrderDetailInfoVendorBrowse), this);
        }

        private void miSalesOrderDetailDefecture_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmSalesOrderDetailDefectureBrowse), this);
        }

        private void miInfo10_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsExpired)
                return;

            FormHelper.Show(typeof(frmImportInfo10Edit), this);
        }

        private void miGenerics_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmGenericBrowse), this);
        }

        private void miSalesOrderHeaderGroupByDate_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmSalesOrderHeaderGroupByDateBrowse), this);
        }

        private void miProductLocationinfoBrowse_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmProductDistributionDetailInfoBrowse), this);
        }

        private void miRealIncomeExpence_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmRptRealIncomeExpenceBrowse), this);
        }

        private void miRequest_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmRequestBrowse), this);
        }

        private void miPurchaseList_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.ShowDialog(typeof(frmPurchaseList), this);
        }

        private void miChangePriceAct_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmProductListPriceHistoryBrowse), this);
        }

        private void miProductDistributionDetailList_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.ShowDialog(typeof(frmProductDistributionDetailList), this);
        }

        private void miSalesOrderDetailList_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.ShowDialog(typeof(frmSalesOrderDetailList), this);
        }

        private void miWarehouseDescriptions_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmWarehouseDescriptionBrowse), this);
        }

        private void miProductLocationMIS_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmProductLocationMISBrowse), this);
        }

        private void miPersonType_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmCardTypeBrowse), this);
        }

        private void miPersonDiscountSchema_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmCardDiscountSchemaBrowse), this);
        }

        private void miPersonUnitRate_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmCardUnitRateBrowse), this);
        }

        private void miCard_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmCardBrowse), this);
        }

        private void miCardType_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmCardTypeBrowse), this);
        }

        private void miCardDiscountSchema_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmCardDiscountSchemaBrowse), this);
        }

        private void miCardUnitRate_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmCardUnitRateBrowse), this);
        }

        private void miPerson_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmPersonBrowse), this);
        }

        private void miPersonCategories_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmPersonCategoryBrowse), this);
        }

        private void miSalesOrderDetailPivot_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmSalesOrderDetail), this);
        }

        private void iCardHandle_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmCardHandleBrowse), this);
        }

        private void iBonusAccumulation_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmBonusAccumulationBrowse), this);
        }

        private void miCashbox_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmCashboxOrderBrowse), this);
        }

        private void miCardPointTransfer_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmPointTransferBrowse), this);
        }

        private void miLicense_ItemClick(object sender, ItemClickEventArgs e)
        {
            CryptoLicenseEx.ShowDialog();
            InitLicence();
        }

        private void miRemoveLicense_ItemClick(object sender, ItemClickEventArgs e)
        {
            CryptoLicenseEx.Instance.LicenseCode = string.Empty;
            CryptoLicenseEx.Instance.Remove();
            CryptoLicenseEx.Instance.Save();
            InitLicence();
        }

        private void miLicenseWebService_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                if (CryptoLicenseEx.Instance.GetLicenseFromWebService())
                {
                    CryptoLicenseEx.Instance.Remove();
                    CryptoLicenseEx.Instance.Save();
                    InitLicence();
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                    ExceptionHelper.Show(ex.InnerException);
                else ExceptionHelper.Show(ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void miNominations_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!IsPermitted(ObjectNames.Nomination)) return;
            FormHelper.Show(typeof(frmNomination), this);
        }

        private void btnFixNewPrice_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.Show(typeof(frmFixNewPrices), this);
        }
    }
}