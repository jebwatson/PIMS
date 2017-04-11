using DBI.Tables;
using DBI.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
namespace DBI
{
    public class UsersNurseTable : IRepository<UsersNurse, int>
    {
        public const string theTable = "UsersNurse";

        /// <summary>
        /// Delete all records from the table.
        /// </summary>
        public void ClearTable()
        {
            if (CountRows() == 0)
                return;

            string myCommand = "DELETE FROM " + theTable;
            QueryExecutor.ExecuteSqlNonQuery(myCommand);

        }

        public void ClearTableById(int userId)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "DELETE FROM " + theTable +
                    " WHERE " +
                    "userId = @userId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@userId", userId);

                myCommand.ExecuteNonQuery();
                myConnection.Close();
            }
        }

        public int CountRows()
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "SELECT COUNT(*) FROM " + theTable;
                return QueryExecutor.ExecuteSqlQueryScalar(myQuery, myConnection);
            } // using
        } // CountRows

        public List<UsersNurse> ReadList()
        {
            List<UsersNurse> nurses = new List<UsersNurse>();

            string myQuery = "SELECT * FROM " + theTable;
            DataSet dsObject = QueryExecutor.ExecuteSqlQuery(myQuery);

            if (dsObject != null && dsObject.Tables[0].Rows.Count > 0)
            {
                DataTable dtObject = dsObject.Tables[0];    // get the DataTable reference once

                foreach (DataRow dr in dtObject.Rows)
                {
                    // extract all fields of the current row
                    int userId = Convert.ToInt32(dr["userId"]);
                    string nameLast = dr["nameLast"].ToString();
                    string nameFirst = dr["nameFirst"].ToString();
                    string title = dr["title"].ToString();
                    int accessLevel = Convert.ToInt32(dr["accessLevel"]);
                    string username = dr["username"].ToString();

                    // fill the ItemList
                    UsersNurse Nurses = new UsersNurse();
                    Nurses.userId = userId;
                    Nurses.nameLast = nameLast;
                    Nurses.nameFirst = nameFirst;
                    Nurses.title = title;
                    Nurses.accessLevel = accessLevel;
                    Nurses.username = username;

                    nurses.Add(Nurses);
                } // for
            } // if
            return nurses;

        } // ReadList


        public List<UsersNurse> ReadListById(int inputId)
        {
            List<UsersNurse> nurses = new List<UsersNurse>();

            string myQuery = "SELECT * FROM " + theTable + " WHERE userId = " + "'" + inputId + "'";

            DataSet dsObject = QueryExecutor.ExecuteSqlQuery(myQuery);

            if (dsObject != null && dsObject.Tables[0].Rows.Count > 0)
            {
                DataTable dtObject = dsObject.Tables[0];    // get the DataTable reference once

                foreach (DataRow dr in dtObject.Rows)
                {
                    // extract all fields of the current row
                    int userId = Convert.ToInt32(dr["userId"]);
                    string nameLast = dr["nameLast"].ToString();
                    string nameFirst = dr["nameFirst"].ToString();
                    string title = dr["title"].ToString();
                    int accessLevel = Convert.ToInt32(dr["accessLevel"]);
                    string username = dr["username"].ToString();


                    // fill the ItemList
                    UsersNurse newUsersNurse = new UsersNurse();
                    newUsersNurse.userId = userId;
                    newUsersNurse.nameLast = nameLast;
                    newUsersNurse.nameFirst = nameFirst;
                    newUsersNurse.title = title;
                    newUsersNurse.accessLevel = accessLevel;
                    newUsersNurse.username = username;

                    nurses.Add(newUsersNurse);
                } // for
            } // if

            return nurses;
        } // ReadList

        public void UpdateItem(UsersNurse updatedNurses)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "UPDATE " + theTable +
                    " SET " +
                    "nameLast = @nameLast, " +
                    "nameFirst = @nameFirst, " +
                    "title = @title, " +
                    "accessLevel = @accessLevel, " +
                    "username = @username, " +
                    "WHERE " +
                    "userId = @userId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@nameLast", updatedNurses.nameLast);
                myCommand.Parameters.AddWithValue("@nameFirst", updatedNurses.nameFirst);
                myCommand.Parameters.AddWithValue("@title", updatedNurses.title);
                myCommand.Parameters.AddWithValue("@accessLevel", updatedNurses.accessLevel);
                myCommand.Parameters.AddWithValue("@userId", updatedNurses.userId);
                myCommand.Parameters.AddWithValue("@username", updatedNurses.username);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // UpdateItem
        public void UpdateList(List<UsersNurse> nurses)
        {
            foreach (var Nurse in nurses)
            {
                UpdateItem(Nurse);
            }

        }

        /// Insert a single admission record into the database.
        /// </summary>
        public void WriteItem(UsersNurse newNurse)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "INSERT INTO " + theTable +
                    " (userId, nameLast, nameFirst, title, accessLevel, username) " +
                    "VALUES (@userId, @nameLast, @nameFirst, @title, @accessLevel, @username)";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@userId", newNurse.userId);
                myCommand.Parameters.AddWithValue("@nameLast", newNurse.nameLast);
                myCommand.Parameters.AddWithValue("@nameFirst", newNurse.nameFirst);
                myCommand.Parameters.AddWithValue("@title", newNurse.title);
                myCommand.Parameters.AddWithValue("@accessLevel", newNurse.accessLevel);
                myCommand.Parameters.AddWithValue("@username", newNurse.username);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // WriteItem

        public void WriteList(List<UsersNurse> nurses)
        {
            foreach (var Nurse in nurses)
            {
                WriteItem(Nurse);
            } // foreach
        } // writelist

    }
}
