using Apothex.Common;
using Apothex.DataType;
using Zek.Security;
using Zek.Data;
using Zek.CryptoLicensing;

namespace Apothex.Windows
{
    public class PermissionHelper
    {
        public static bool IsPermitted(ObjectNames objectName, DatabaseAction actions)
        {
            return IsPermitted(objectName, (int)actions);
        }
        public static bool IsPermitted(ObjectNames objectName, int permissionToCheck)
        {
            return IsPermitted(GlobalVariable.GetPermission((int)objectName), permissionToCheck);
        }
        public static bool IsPermitted(int permissions, int permissionToCheck)
        {
            return BitwisePermissionHelper.IsPermitted(permissions, permissionToCheck) && IsPermittedWithoutLicense(permissionToCheck);
        }

        private static bool IsPermittedWithoutLicense(int permissionToCheck)
        {
            return (CryptoLicenseEx.IsValid || BitwisePermissionHelper.IsPermitted((int)DatabaseAction.IsPermittedWithoutLicense, permissionToCheck));
            //return (!TrialMakerHelper.IsExpired || BitwisePermissionHelper.IsPermitted((int)DatabaseAction.IsPermittedWithoutLicense, permissionToCheck));
        }
    }
}
