using System;
using System.Text;
using System.Data.SqlClient;

namespace DBI.Utilities
{
    public class ConnectionsManager
    {
        public static string SQLServerConnectionString { get; set; }

        /// <summary>
        /// Create a new SQL Connection. Note that whenever this is used,
        /// the connection string should also be set in that scope. This
        /// method should be reserved for testing methods and used sparingly.
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetNewConnection()
        {
            SqlConnection Connection = new SqlConnection(SQLServerConnectionString);
            try
            {
                Connection.Open();
            }
            catch (Exception)
            {
                Connection = null;  // Opening connection failed; return null
            }
            return Connection;
        }
    }
}
