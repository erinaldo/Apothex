using System;
using Apothex.DataType;


namespace Apothex.Contracts.Hedgehog
{
    interface IHedgehog
    {
        DS_Hedgehog.SP_GetSalesHedgehogDataTable GetSalesHedgehog(int salesOrderID);
        void AddOrEditHedgehog(int salesOrderID, decimal totalDue, DateTime orderDate, int action);
        void DeleteHedgehog(int salesOrderID);
    }
}
