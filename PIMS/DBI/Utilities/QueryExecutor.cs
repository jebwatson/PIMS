using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DBI.Utilities
{
    public class QueryExecutor
    {
        /// <summary>
        /// Executes a standard query that returns a result from the database.
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns></returns>
        public static DataSet ExecuteSqlQuery(string strSQL)
        {
            string strConn = ConnectionsManager.SQLServerConnectionString;

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                // Call the overload that takes a connection in place of a connection string
                return ExecuteSqlQuery(strSQL, conn);
            }
        }

        /// <summary>
        /// Executes a standard query that returns a result from the database.
        /// </summary>
        /// <param name="strSQL"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        public static DataSet ExecuteSqlQuery(string strSQL, SqlConnection conn)
        {
            DataSet dsObject = new DataSet();
            using (SqlDataAdapter daObject = new SqlDataAdapter(strSQL, conn))
            {
                try
                {
                    daObject.Fill(dsObject);
                }
                catch (Exception ex)
                {
                    dsObject = null;
                    //LogManager.writeLog("DBUtils.ExecuteSqlQuery: Exception > [{0}]", ex.Message);
                }
            }
            return dsObject;
        }

        /// <summary>
        /// Executes a non-query that changes tables, but returns no resulting data from the database.
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public static object ExecuteSqlNonQuery(string strSql)
        {
            string strConn = ConnectionsManager.SQLServerConnectionString;

            // pass through the call providing the default for the database to query (default database connection string is pulled from the app config file)
            return ExecuteSqlNonQuery(strSql, strConn);
        }

        /// <summary>
        /// Executes a non-query that changes tables, but returns no resulting data from the database.
        /// </summary>
        /// <param name="strSQL"></param>
        /// <param name="strConn"></param>
        /// <returns></returns>
        public static object ExecuteSqlNonQuery(string strSQL, string strConn)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                // Call the overload that takes a connection in place of a connection string
                return ExecuteSqlNonQuery(strSQL, conn);
            }
        }

        /// <summary>
        /// Executes a non-query that changes tables, but returns no resulting data from the database.
        /// </summary>
        /// <param name="strSQL"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        public static object ExecuteSqlNonQuery(string strSQL, SqlConnection conn)
        {
            object status = null;
            using (SqlCommand cmd = new SqlCommand(strSQL, conn))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    status = ex;
                    //LogManager.writeLog("DBUtils.ExecuteSqlQuery: Exception > [{0}]", ex.Message);
                }
            }
            return status;
        }

        /// <summary>
        /// Executes a stored procedure that does return data from the database.
        /// </summary>
        /// <param name="strProcedure"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static DataSet ExecuteStoredProcedureQuery(string strProcedure, params string[] args)
        {
            DataSet dsObject = new DataSet();
            try
            {
                dsObject = ExecuteStoredProcedureQuery(strProcedure + argsToString(args));
            }
            catch (Exception ex)
            {
                dsObject = null;
                Console.WriteLine(ex.ToString());
                //LogManager.writeLog("DBUtils.ExecuteStoredProcedure: Exception > [{0}] > strProcedure [{1}]", ex.Message, strProcedure);
            }
            return dsObject;
        }

        /// <summary>
        /// Executes a stored procedure that does return data from the database.
        /// </summary>
        /// <param name="strProcedure"></param>
        /// <returns></returns>
        public static DataSet ExecuteStoredProcedureQuery(string strProcedure)
        {
            string strConn = ConnectionsManager.SQLServerConnectionString;
            DataSet dsObject = new DataSet();
            SqlDataAdapter daObject = new SqlDataAdapter(strProcedure, strConn);

            try
            {
                daObject.Fill(dsObject);
            }
            catch (Exception ex)
            {
                dsObject = null;
                Console.WriteLine(ex.ToString());
                //LogManager.writeLog("DBUtils.ExecuteStoredProcedureQuery: Exception > [{0}]", ex.Message);
            }
            finally { daObject.Dispose(); }
            return dsObject;
        }

        /// <summary>
        /// Executes a stored procedure that does not return data from the database.
        /// </summary>
        /// <param name="strProcedure"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static bool ExecuteStoredProcedureNonQuery(string strProcedure, params string[] args)
        {
            bool status = false;
            try
            {
                status = ExecuteStoredProcedureNonQuery(strProcedure + argsToString(args));
            }
            catch (Exception ex)
            {
                status = false;
                Console.WriteLine(ex.ToString());
                //LogManager.writeLog("DBUtils.ExecuteStoredProcedureNonQuery: Exception [{0}] strProcedure [{1}]", ex.Message, strProcedure);
            }
            return status;
        }

        /// <summary>
        /// Executes a stored procedure that does not return data from the database.
        /// </summary>
        /// <param name="strProcedure"></param>
        /// <returns></returns>
        public static bool ExecuteStoredProcedureNonQuery(string strProcedure)
        {
            string strConn = ConnectionsManager.SQLServerConnectionString;
            bool status = false;
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand(strProcedure, conn);
            try
            {
                cmd.Connection.Open();
                status = (cmd.ExecuteNonQuery() > 0);
            }
            catch (Exception ex)
            {
                status = false;
                Console.WriteLine(ex.ToString());
                //LogManager.writeLog("DBUtils.ExecuteStoredProcedureNonQuery: Exception > [{0}]", ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }
            return status;
        }

        /// <summary>
        /// Executes a query scalar that returns a scalar from the database.
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns></returns>
        public static int ExecuteSqlQueryScalar(string strSQL)
        {
            string strConn = ConnectionsManager.SQLServerConnectionString;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                return ExecuteSqlQueryScalar(strSQL, conn);
            }
        }

        /// <summary>
        /// Executes a query scalar that returns a scalar from the database.
        /// </summary>
        /// <param name="strSQL"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        public static int ExecuteSqlQueryScalar(string strSQL, SqlConnection conn)
        {
            int retValue = 0;

            using (SqlCommand cmd = new SqlCommand(strSQL, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    try
                    {
                        reader.Read();
                        retValue = Convert.ToInt32(reader[0]);
                    }
                    catch (Exception ex)
                    {
                        retValue = -1;
                        Console.WriteLine(ex.ToString());
                        //LogManager.writeLog("DBUtils.ExecuteSqlQueryScalar: Exception > [{0}]", ex.Message);
                        return 0;
                    }
                } // using reader
            } // using cmd
            return retValue;
        }

        /// <summary>
        /// Converts sting[] params to a string proper.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        private static string argsToString(params string[] args)
        {
            StringBuilder query = new StringBuilder();
            string strFormatter;

            for (int i = 0; i < args.Length; i++)
            {
                if (i > 0) strFormatter = ",";
                else strFormatter = " ";

                if (args[i].Length > 0) strFormatter += "'{0}'";
                else strFormatter += "NULL";

                query.AppendFormat(strFormatter, args[i].Replace("'", "''"));
            }
            return query.ToString();
        }
    }
}
