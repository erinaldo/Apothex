namespace Apothex.DataType
{
    /// <summary>
    /// ოპერაციის ტიპები.
    /// </summary>
    public enum OperationType
    {
        None = 0,
        /// <summary>
        /// ნაღდი.
        /// </summary>
        Cash = 1,
        /// <summary>
        /// უნაღდო ტერმინალი.
        /// </summary>
        ClearingTerminal = 2,
        /// <summary>
        /// უნაღდო ჩარიცხვა.
        /// </summary>
        ClearingTransfer = 3,
        /// <summary>
        /// უნაღდო კონსიგნაცია.
        /// </summary>
        ClearingConsignation = 4,
        /// <summary>
        /// დაგრ. ბარათ. ჩამოჭრა.
        /// </summary>
        Gift = 5,
    }
}
