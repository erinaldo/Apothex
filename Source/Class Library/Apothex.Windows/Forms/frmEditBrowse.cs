using System;

using System.Windows.Forms;
using System.ComponentModel;
using Apothex.Common;
using Zek.Data;
using Zek.Extensions;
using Zek.Windows.Forms;
using Apothex.DataType;
using Zek.Windows.Forms.DevEx;

namespace Apothex.Windows.Forms
{
    public class frmEditBrowse : EditForm
    {

        [Category("Zek"), DefaultValue(ObjectNames.None)]
        public ObjectNames ObjectName
        {
            get { return (ObjectNames)FormEnum; }
            set { FormEnum = value; }
        }

        [Browsable(false)]
        public bool IsOnline
        {
            get;
            set;
        }

        public bool IsPermitted(int permission, DatabaseAction action)
        {
            return IsPermitted(permission, (int)action);
        }
        protected bool IsPermitted(int permission, int permissionToCheck)
        {
            return PermissionHelper.IsPermitted(permission, permissionToCheck);
        }
        protected bool IsPermitted(ObjectNames objectName, DatabaseAction action)
        {
            return PermissionHelper.IsPermitted(objectName, (int)action);
        }

        private int _permission;
        protected override void InitPermission()
        {
            if (ObjectName == ObjectNames.None) return;
            try
            {
                _permission = GlobalVariable.GetPermission(FormEnum.ToInt32());
            }
            catch (Exception ex)
            {
                ExceptionHelper.Show(this, ex, "უფლებების ინიციალიზაცია ვერ მოხერხდა მონაცემთა ბაზიდან", MessageBoxIcon.Error);
            }
        }
    }
}
