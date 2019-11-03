using Apothex.DataType;


namespace Apothex.Contracts.Operation
{
    interface IOperation
    {
        DS_Operation.T_OperationDataTable Get(string objectName, int? id);
        int Save(string objectName, int? id, byte[] b);
    }
}
