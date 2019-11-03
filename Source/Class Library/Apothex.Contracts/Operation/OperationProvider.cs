using Apothex.DataType;

namespace Apothex.Contracts.Operation
{
    public abstract class OperationProvider : IOperation
    {
        public abstract DS_Operation.T_OperationDataTable Get(string objectName, int? id);
        public abstract int Save(string objectName, int? id, byte[] b);
    }
}
