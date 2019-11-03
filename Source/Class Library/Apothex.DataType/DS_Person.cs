using Zek.Data;

namespace Apothex.DataType
{
}
namespace Apothex.DataType
{
}
namespace Apothex.DataType
{
}
namespace Apothex.DataType
{
}
namespace Apothex.DataType
{
}
namespace Apothex.DataType
{
}
namespace Apothex.DataType
{
}
namespace Apothex.DataType.DS_PersonTableAdapters
{
    public partial class SP_GetMyCompanyTableAdapter
    {
        public static SP_GetMyCompanyTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetMyCompanyTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    public partial class SP_GetCompanyTableAdapter
    {
        public static SP_GetCompanyTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetCompanyTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    public partial class PersonQueriesAdapter
    {
        public static PersonQueriesAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new PersonQueriesAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }



    public partial class T_PersonTableAdapter
    {
        public static T_PersonTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new T_PersonTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    public partial class SP_GetPersonCategoryTableAdapter
    {
        public static SP_GetPersonCategoryTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetPersonCategoryTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }
}
namespace Apothex.DataType {
    
    
    public partial class DS_Person {
    }
}
