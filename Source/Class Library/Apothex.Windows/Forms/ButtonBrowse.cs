using System;

using System.ComponentModel;
using Apothex.DataManagment.Dictionary;
using Apothex.DataType;
using Zek.Core;
using Zek.Extensions;

namespace Apothex.Windows.Forms
{
    [ToolboxItem(true)]
    public class ButtonBrowse : Zek.Windows.Forms.DevEx.ButtonBrowse
    {
        [Category("Zek"), DefaultValue(ObjectNames.None)]
        public ObjectNames TableName
        {
            get { return (ObjectNames)FormEnum; }
            set { FormEnum = value; }
        }

        private bool _isOnline = true;
        [Browsable(false)]
        public bool IsOnline
        {
            get { return _isOnline; }
            set { _isOnline = value; }
        }

        protected override void BindData()
        {
            base.BindData();

            var table = DictionaryManager.GetButtonBrowse(TableName,
                (PrimaryKey is int ? ConvertHelper.ToInt32(PrimaryKey) : 0),
                (PrimaryKey is string ? ConvertHelper.ToString(PrimaryKey) : string.Empty),
                (PrimaryKey is Guid ? ConvertHelper.ToGuid(PrimaryKey) : Guid.Empty),
                (PrimaryKey is DateTime ? ConvertHelper.ToDateTime(PrimaryKey) : DateTimeExtensions.MinDate),
                _isOnline);
            
            SetText(table.Count > 0 ? table[0].Caption : string.Empty);
        }

        //protected override void OnBindingData(object sender, BindingDataEventArgs e)
        //{
        //    var table = DictionaryManager.GetButtonBrowse(TableName, e.ParamInt, e.ParamString, e.ParamGuid, e.ParamDateTime, _IsOnline);
        //    if (table.Count > 0)
        //        e.Text = table[0].Caption;
        //}
    }
}
