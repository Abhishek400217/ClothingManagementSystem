using System.Configuration;
using System.Data.SqlClient;

namespace ClotheManagementSystem.DAL
{
    public class DBHelper
    {
        public SqlConnection GetConnection()
        {
            return new SqlConnection(
                ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString
            );
        }
    }
}