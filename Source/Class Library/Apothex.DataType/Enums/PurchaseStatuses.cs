using System;

namespace Apothex.DataType
{
    /// <summary>
    /// გაყიდვის სტატუსესბი
    /// </summary>
    [Flags()]
    public enum PurchaseStatuses
    {
        /// <summary>
        /// დ.ღ.გ.
        /// </summary>
        Vat = 1,

    }
}
