using DBI.Tables;
using DBI.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DBI
{
    public class UsersDoctorTable : IRepository<UsersDoctor, int>
    {
        public const string theTable = "UsersDoctor";

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

        public List<UsersDoctor> ReadList()
        {
            List<UsersDoctor> doctors = new List<UsersDoctor>();

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
                    UsersDoctor Doctors = new UsersDoctor();
                    Doctors.userId = userId;
                    Doctors.nameLast = nameLast;
                    Doctors.nameFirst = nameFirst;
                    Doctors.title = title;
                    Doctors.accessLevel = accessLevel;

                    doctors.Add(Doctors);
                } // for
            } // if
               return doctors;

        } // ReadList


        public List<UsersDoctor> ReadListById(int inputId)
        {
            List<UsersDoctor> doctors = new List<UsersDoctor>();

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
                    UsersDoctor newUsersDoctor = new UsersDoctor();
                    newUsersDoctor.userId = userId;
                    newUsersDoctor.nameLast = nameLast;
                    newUsersDoctor.nameFirst = nameFirst;
                    newUsersDoctor.title = title;
                    newUsersDoctor.accessLevel = accessLevel;
                   

                    doctors.Add(newUsersDoctor);
                } // for
            } // if

            return doctors;
        } // ReadList

        public void UpdateItem(UsersDoctor updatedDoctors)
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

            myCommand.Parameters.AddWithValue("@nameLast", updatedDoctors.nameLast);
            myCommand.Parameters.AddWithValue("@nameFirst", updatedDoctors.nameFirst);
            myCommand.Parameters.AddWithValue("@title", updatedDoctors.title);
            myCommand.Parameters.AddWithValue("@accessLevel", updatedDoctors.accessLevel);
            myCommand.Parameters.AddWithValue("@userId", updatedDoctors.userId);

            myCommand.ExecuteNonQuery();

            myConnection.Close();
        } // using
    } // UpdateItem
    public void UpdateList(List<UsersDoctor> doctors) {
        foreach (var Doctor in doctors) {
            UpdateItem(Doctor);
        }

        }

        /// Insert a single admission record into the database.
        /// </summary>
        public void WriteItem(UsersDoctor newDoctor)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "INSERT INTO " + theTable +
                    " (userId, nameLast, nameFirst, title, accessLevel, " +
                    "duration, amount)" +
                    "VALUES (@userId, @nameLast, @nameFirst, @title, @accessLevel)";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@userId", newDoctor.userId);
                myCommand.Parameters.AddWithValue("@nameLast", newDoctor.nameLast);
                myCommand.Parameters.AddWithValue("@nameFirst", newDoctor.nameFirst);
                myCommand.Parameters.AddWithValue("@title", newDoctor.title);
                myCommand.Parameters.AddWithValue("@accessLevel", newDoctor.accessLevel);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // WriteItem

        public void WriteList(List<UsersDoctor> doctors)
        {
            foreach (var Doctor in doctors)
            {
                WriteItem(Doctor);
            } // foreach
        } // writelist

    }
}
