using DBI.Tables;
using DBI.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
namespace DBI
{
    public class UsersVolunteerTable : IRepository<UsersVolunteer, int>
    {
        public const string theTable = "UsersVolunteer";

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

        public List<UsersVolunteer> ReadList()
        {
            List<UsersVolunteer> volunteer = new List<UsersVolunteer>();

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
                    string accessLevel = dr["accessLevel"].ToString();

                    // fill the ItemList
                    UsersVolunteer Volunteer = new UsersVolunteer();
                    Volunteer.userId = userId;
                    Volunteer.nameLast = nameLast;
                    Volunteer.nameFirst = nameFirst;
                    Volunteer.title = title;
                    Volunteer.accessLevel = accessLevel;

                    volunteer.Add(Volunteer);
                } // for
            } // if
            return volunteer;

        } // ReadList


        public List<UsersVolunteer> ReadListById(int inputId)
        {
            List<UsersVolunteer> volunteer = new List<UsersVolunteer>();

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
                    string accessLevel = dr["accessLevel"].ToString();


                    // fill the ItemList
                    UsersVolunteer newUsersVolunteer = new UsersVolunteer();
                    newUsersVolunteer.userId = userId;
                    newUsersVolunteer.nameLast = nameLast;
                    newUsersVolunteer.nameFirst = nameFirst;
                    newUsersVolunteer.title = title;
                    newUsersVolunteer.accessLevel = accessLevel;


                    volunteer.Add(newUsersVolunteer);
                } // for
            } // if

            return volunteer;
        } // ReadList

        public void UpdateItem(UsersVolunteer updateVolunteer)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "UPDATE " + theTable +
                    " SET " +
                    "nameLast = @nameLast, " +
                    "nameFirst = @nameFirst, " +
                    "title = @title, " +
                    "accessLevel = @accessLevel, " +
                    "WHERE " +
                    "userId = @userId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@nameLast", updateVolunteer.nameLast);
                myCommand.Parameters.AddWithValue("@nameFirst", updateVolunteer.nameFirst);
                myCommand.Parameters.AddWithValue("@title", updateVolunteer.title);
                myCommand.Parameters.AddWithValue("@accessLevel", updateVolunteer.accessLevel);
                myCommand.Parameters.AddWithValue("@userId", updateVolunteer.userId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // UpdateItem
        public void UpdateList(List<UsersVolunteer> volunteer)
        {
            foreach (var Volunteer in volunteer)
            {
                UpdateItem(Volunteer);
            }

        }

        /// Insert a single admission record into the database.
        /// </summary>
        public void WriteItem(UsersVolunteer newVolunteer)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "INSERT INTO " + theTable +
                    " (userId, nameLast, nameFirst, title, accessLevel, " +
                    "duration, amount)" +
                    "VALUES (@userId, @nameLast, @nameFirst, @title, @accessLevel)";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@userId", newVolunteer.userId);
                myCommand.Parameters.AddWithValue("@nameLast", newVolunteer.nameLast);
                myCommand.Parameters.AddWithValue("@nameFirst", newVolunteer.nameFirst);
                myCommand.Parameters.AddWithValue("@title", newVolunteer.title);
                myCommand.Parameters.AddWithValue("@accessLevel", newVolunteer.accessLevel);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // WriteItem

        public void WriteList(List<UsersVolunteer> volunteer)
        {
            foreach (var Volunteer in volunteer)
            {
                WriteItem(Volunteer);
            } // foreach
        } // writelist
    }
}