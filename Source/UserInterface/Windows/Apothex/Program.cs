using System;
using System.Drawing;
using System.Windows.Forms;

using System.Threading;
using Zek.Win32;
using Zek.Windows.Forms;
using Zek.Windows.Forms.DevEx;
using Zek.CryptoLicensing;
using LogicNP.CryptoLicensing;

namespace Apothex
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (!Win32Native.IsAlreadyRunning(true, true, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                ExceptionHelper.HandleAllExceptions();
                ExceptionHelper.CustomExceptionFormType = Zek.Windows.Forms.CustomExceptionFormTypes.XtraMessageBox;




                InitLicense();
                #region args
                var doSplash = true;

                foreach (var arg in args)
                {
                    switch (arg)
                    {
                        case "-nosplash":
                            doSplash = false;
                            break;
                    }
                }

                if (doSplash)
                {
                    SplashScreen.ShowSplashScreen();
                    Application.DoEvents();
                }
                #endregion

                InputLanguageHelper.InitCultureInfo();
                XtraControlHelper.InitDevExpress(new Font("BPG Glaho Arial", 9.75F));

                Thread.Sleep(1000);
                Application.Run(new frmMain());
            }
            else
            {
                MessageBox.Show("You can only run one copy of this application at a time", "Apothex", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Win32Native.SwitchToCurrentInstance();
            }
        }


        private static void InitLicense()
        {
            CryptoLicenseEx.Instance.ValidationKey = "AAACgAC1gZoB/dERmxCn0Snbza4iV2Rc85bYGEqgRa67V8Q7RuJGxVFTh4FpYAJ16eRo8tg79BXaM/2Yjad8JcMFm8Yh8C82DwFQIOvOX5gWjG92/AtPgf9gyhzTBFmm0pUYAbSwT6599/d/ev2GN4ilIM1PtYuYfFIY1mnL2v/9e0oR/QMAAQAB";
            //CryptoLicenseEx.Instance.LicenseServiceURL = "http://www.bizguide.ge/LicenseService/Service.asmx";
            CryptoLicenseEx.Instance.LicenseURL = "http://bizguide.ge/LicenseService/LicenseService.asmx";
            //CryptoLicenseEx.Instance.LicenseServiceSettingsFilePath = @"%AppDomainAppPath%App_Data\ApothexSettings.xml";


            if (!CryptoLicenseEx.Instance.Load() || CryptoLicenseEx.Instance.Status != LicenseStatus.Valid)//თუ ვერ ჩატვირთა ან ჩატვირთული ლიცენზია არასწორია მაშინ გამოიტანოს დიალოგური ფანჯარა.
            {
                CryptoLicenseEx.ShowDialog();
            }
        }
//        private static void InitLicenseFromSerial()
//        {
//            string[] serials = new string[] {
//"SNFAP-4RWPK-S45UP-XJKHD-6HVS1-56R8A-V",
//"T3A0P-4RWPK-S45UU-LF0R5-3PKSD-5T0QY-U",
//"JHNSP-4RWPK-S45U1-UVJCY-94A9F-M6S2P-W",
//"Y0KRP-4RWPK-S45U3-LPM9H-TGUR2-9DK0E-W",
//"5FDRP-4RWPK-S45UP-CEK5X-2SF2T-29KSK-9",
//"X8P7P-4RWPK-S45UM-PG5EA-ESHDG-4K0AU-9",
//"ASU7P-4RWPK-S45UM-E466M-8WRKF-UPQXR-W",
//"F5GQP-4RWPK-S45U3-2XC8S-3HL8V-AUK39-U",
//"DPJ3P-4RWPK-S45U3-V5RX9-Y794A-6JC3F-W",
//"QRW3P-4RWPK-S45UP-PQL9T-TF6RW-VLJ07-9",
//"9L7GP-4RWPK-S45U1-T0JQV-9QE54-M7KWG-9",
//"P1EFP-4RWPK-S45U3-4UNGF-QEGVR-T31MP-9",
//"T7FFP-4RWPK-S45UU-WXARP-JRLJD-1WYCF-U",
//"4402P-4RWPK-S45UU-WL7TQ-1HKMY-L5CW5-9",
//"GX92P-4RWPK-S45UM-FTE0D-43ATA-JT9LQ-V",
//"53QTP-4RWPK-S45UT-954KT-DU32M-M1XGG-V",
//"6J1WP-4RWPK-S45U1-G4S2X-LLGNT-R8T9X-V",
//"WNTWP-4RWPK-S45UU-3HQ7K-J8KCU-E0LXN-9",
//"HGSVP-4RWPK-S45U1-CRQNG-7GNRP-LU2N5-U",
//"EHY9P-4RWPK-S45U1-D2RWV-4GAA5-UQSAL-U",
//"LYG9P-4RWPK-S45UP-LJ031-76N65-WS09D-U",
//"NFCUP-4RWPK-S45US-1G9R2-TAL4M-F47UD-V",
//"08X56-4RWPK-S45U1-1ATU7-ALLUF-F7E8K-9",
//"8E756-4RWPK-S45UM-V4RD0-R0KR0-NAVK3-U",
//"12EL6-4RWPK-S45UM-VYSNY-X56T0-AL6MW-W",
//"3P8K6-4RWPK-S45U3-MXFMA-32FG3-V47X6-9",
//"MD0K6-4RWPK-S45U3-SAMY4-DRGAG-0JH89-U",
//"RTN46-4RWPK-S45US-TYPLW-1TH54-GU3L2-W",
//"W64J6-4RWPK-S45U4-PXU9L-56DQL-FYM68-U",
//"C11J6-4RWPK-S45U4-5RK0A-N9HE0-12RX5-9",
//"FWPH6-4RWPK-S45UP-CJGF9-S7QTW-LA0UT-U",
//"LN586-4RWPK-S45U4-8T3PS-JHRKU-SDDS4-U",
//"7CY86-4RWPK-S45U4-4705T-86DM1-4GHQ9-W",
//"9VJP6-4RWPK-S45U3-6FXAM-RQH4C-MF59T-U",
//"0JAP6-4RWPK-S45UM-7E1M8-6A8FY-F7DP9-V",
//"2AX66-4RWPK-S45U3-ERLY5-SVK93-NMJ99-9",
//"4ULX6-4RWPK-S45UM-7PL9E-CATX6-D25GK-U",
//"3HDX6-4RWPK-S45U3-K89S3-5YF0F-ACA08-9",
//"U08N6-4RWPK-S45U1-LX4GG-1QPTP-T0GEQ-V",
//"SF0N6-4RWPK-S45UP-JQ80D-MTQ78-KU99T-W",
//"W8MM6-4RWPK-S45U3-WP7QH-T3333-3KYMN-V",
//"CE3M6-4RWPK-S45UP-FA5TF-RH4SU-F7JAT-9",
//"G21Y6-4RWPK-S45U3-2QCS7-L7E7R-C4V10-V",
//"L66E6-4RWPK-S45UP-GUJKD-9CN0F-VPPV0-9",
//"7DRE6-4RWPK-S45U1-LFNTK-PL9X1-ER7YJ-9",
//"VTYD6-4RWPK-S45UM-SE9LF-FFHCH-5E0DR-9",
//"8XH16-4RWPK-S45UP-7VAN0-M8MEC-EN5UP-9",
//"21A16-4RWPK-S45U3-UM2AH-HAHQN-0TQKL-U",
//"KVXC6-4RWPK-S45U4-DX7NY-GSE6C-JS9NK-9",
//"Q4QC6-4RWPK-S45UU-E24HS-YRFC9-LVXGM-V"
//            };



//            foreach (string licOrSerial in serials)
//            {
//                // Try to validate serial and retrieve license against the serial 
//                SerialValidationResult result = CryptoLicenseEx.Instance.GetLicenseFromSerial(licOrSerial);
//                if (result == SerialValidationResult.Failed)
//                {
//                    // 'licOrSerial' is in serial form but validation of serial failed 
//                    continue;
//                }
//                else if (result == SerialValidationResult.NotASerial)
//                {
//                    // 'licOrSerial' is not a serial but may be a license, set lic.LicenseCode and validate it 
//                    CryptoLicenseEx.Instance.LicenseCode = licOrSerial;
//                }
//                else if (result == SerialValidationResult.Success)
//                {
//                    break;
//                    // CryptoLicense.GetLicenseFromSerial set the lic.LicenseCode with the retrieved license code 
//                    // validate it 
//                }
//            }
//        }
    }
}
