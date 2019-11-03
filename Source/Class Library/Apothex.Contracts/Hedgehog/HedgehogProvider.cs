using System;
using Apothex.DataType;

namespace Apothex.Contracts.Hedgehog
{
    public abstract class HedgehogProvider : IHedgehog
    {
        public abstract DS_Hedgehog.SP_GetSalesHedgehogDataTable GetSalesHedgehog(int salesOrderID);
        public abstract void AddOrEditHedgehog(int salesOrderID, decimal totalDue, DateTime orderDate, int action);
        public abstract void DeleteHedgehog(int salesOrderID);
    }
}
