using System;
using System.Windows.Forms;
using System.ComponentModel;
using Apothex.Common;
using Apothex.DataManagment.Dictionary;
using Zek.Core;
using Zek.Data;
using Zek.Extensions;
using Zek.Windows.Forms;
using Apothex.DataType;
using Zek.Windows.Forms.DevEx;

namespace Apothex.Windows.Forms
{
    public class frmBrowse : ListForm
    {
        [Category("Zek"), DefaultValue(ObjectNames.None)]
        public ObjectNames ObjectName
        {
            get { return (ObjectNames)FormEnum; }
            set { FormEnum = value; }
        }

        public string TableName { get; set; }
        public bool AutoInitStyleFormat { get; set; }



        private bool _isOnline = true;
        [Browsable(false)]
        public bool IsOnline
        {
            get { return _isOnline; }
            set { _isOnline = value; }
        }

        public bool IsFiltered
        {
            get { return biFilter.Checked; }
            set { biFilter.Checked = value; }
        }

        
        //public bool IsPermitted(int permission, DatabaseAction action)
        //{
        //    return IsPermitted(permission, (int)action);
        //}

        protected  bool IsPermitted(int permission, int permissionToCheck)
        {
            return PermissionHelper.IsPermitted(permission, permissionToCheck);
        }

        protected BindingSource bsGridControl;
    
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
                //OptionsPermission.Permission = GlobalVariable.GetPermission(FormEnum.ToInt32());
                _permission = GlobalVariable.GetPermission(FormEnum.ToInt32());
            }
            catch (Exception ex)
            {
                ExceptionHelper.Show(this, ex, "უფლებების ინიციალიზაცია ვერ მოხერხდა მონაცემთა ბაზიდან", MessageBoxIcon.Error);
            }
        }

        protected override void BlockRecord(int rowHandle)
        {
            ActionRecord(rowHandle, DatabaseAction.Block);
        }
        protected override void UnblockRecord(int rowHandle)
        {
            ActionRecord(rowHandle, DatabaseAction.Unblock);
        }

        private void ActionRecord(int rowHandle, DatabaseAction action)
        {
            var value = OptionsGrid.GridView.GetRowCellValue(rowHandle, OptionsGrid.DataKeyName);

            var paramInt = 0;
            var paramString = string.Empty;
            var paramGuid = Guid.Empty;
            var paramDateTime = DateTime.Now;

            if (value is int)
                paramInt = (int) value;
            else if (value is string)
                paramString = (string) value;
            else if (value is Guid)
                paramGuid = (Guid) value;
            else if (value is DateTime)
                paramDateTime = (DateTime) value;

            var e = new ActionRecordEventArgs(paramInt, paramString, paramGuid, paramDateTime, action);
            DictionaryManager.ActionRecord(ObjectName, e.ParamInt, e.ParamString, e.ParamDateTime, e.ParamGuid, 0, string.Empty, DateTimeHelper.MinDate, Guid.Empty, e.Action, BaseGlobalVariable.UserID, IsOnline);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bsGridControl = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // frmBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "frmBrowse";
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGridControl)).EndInit();
            this.ResumeLayout(false);

        }

        private IContainer components;
    }
}