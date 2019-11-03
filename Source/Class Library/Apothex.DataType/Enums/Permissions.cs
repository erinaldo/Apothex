using System;

namespace Apothex.DataType
{
    /// <summary>
    /// ფილიალის უფლებები.
    /// </summary>
    [Flags()]
    public enum BranchPermissions
    {
        /// <summary>
        /// ყიდვის უფლება.
        /// </summary>
        Purchasing = 1,
        
        /// <summary>
        /// გაყისვის უფლება.
        /// </summary>
        Sales = 2,

        /// <summary>
        /// შეკვეთა.
        /// </summary>
        Request = 4,

        /// <summary>
        /// დისტრიბუცია.
        /// </summary>
        Distribution = 8,
    }
}
