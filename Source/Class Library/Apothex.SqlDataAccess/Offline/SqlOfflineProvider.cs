using Apothex.Contracts.Offline;
using System.Data.SqlClient;

namespace Apothex.SqlDataAccess.Offline
{
    public sealed class SqlOfflineProvider : OfflineProvider
    {
        public override void SyncBranch()
        {
            using(var cmd = new SqlCommand())
	        {
                cmd.CommandText = @"
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DD_Branch]') AND type IN (N'U'))
DROP TABLE [dbo].[DD_Branch]
GO
CREATE TABLE dbo.DD_Branch(
	ID INT NOT NULL,
	Code NVARCHAR(10) NULL,
	Name NVARCHAR(100) NULL,
	Address NVARCHAR(120) NULL,
	Phone NVARCHAR(50) NULL,
	Fax NVARCHAR(50) NULL,
	ActFormat NVARCHAR(100) NULL,
	CompanyID INT NULL,
	StatusID TINYINT NULL,
	CreateDate DATETIME NULL,
	CreatorID INT NULL,
	ModifiedDate DATETIME NULL,
	ModifierID INT NULL,
	ApproveDate DATETIME NULL,
	ApproverID INT NULL,
 CONSTRAINT PK_DD_Branch_ID PRIMARY KEY CLUSTERED 
(
	ID ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO";
	        }
        }
        //public override int Synchronize(int objectID, int modifiedUserID, DateTime modifiedDate, int action, bool isOnline, byte[] b)
        //{
        //    string connectionString = (isOnline ? ConfigurationManagerEx.ConnectionString : ConfigurationManagerEx.OfflineConnectionString);
        //    int commandTimeout = (isOnline ? ConfigurationManagerEx.CommandTimeout : ConfigurationManagerEx.OfflineCommandTimeout);

        //    using (var adapter = SynchronizationQueriesAdapter.CreateInstance(connectionString, commandTimeout))
        //    {
        //        return (int)adapter.SP_Synchronize(objectID, modifiedUserID, modifiedDate, action, DataSetHelper.InnerXmlData(b));
        //    }
        //}
    }
}
