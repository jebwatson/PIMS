using DBI.Tables;
using DBI.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
namespace DBI
{
    public class UsersOfficeStaffTable : IRepository<UsersOfficeStaff, int>
    {
        public const string theTable = "UsersOfficeStaff";

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

        public List<UsersOfficeStaff> ReadList()
        {
            List<UsersOfficeStaff> officestaff = new List<UsersOfficeStaff>();

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
                    UsersOfficeStaff OfficeStaff = new UsersOfficeStaff();
                    OfficeStaff.userId = userId;
                    OfficeStaff.nameLast = nameLast;
                    OfficeStaff.nameFirst = nameFirst;
                    OfficeStaff.title = title;
                    OfficeStaff.accessLevel = accessLevel;

                    officestaff.Add(OfficeStaff);
                } // for
            } // if
            return officestaff;

        } // ReadList


        public List<UsersOfficeStaff> ReadListById(int inputId)
        {
            List<UsersOfficeStaff> officestaff = new List<UsersOfficeStaff>();

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
                    UsersOfficeStaff newUsersOfficeStaff = new UsersOfficeStaff();
                    newUsersOfficeStaff.userId = userId;
                    newUsersOfficeStaff.nameLast = nameLast;
                    newUsersOfficeStaff.nameFirst = nameFirst;
                    newUsersOfficeStaff.title = title;
                    newUsersOfficeStaff.accessLevel = accessLevel;


                    officestaff.Add(newUsersOfficeStaff);
                } // for
            } // if

            return officestaff;
        } // ReadList

        public void UpdateItem(UsersOfficeStaff updatedOfficeStaff)
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

                myCommand.Parameters.AddWithValue("@nameLast", updatedOfficeStaff.nameLast);
                myCommand.Parameters.AddWithValue("@nameFirst", updatedOfficeStaff.nameFirst);
                myCommand.Parameters.AddWithValue("@title", updatedOfficeStaff.title);
                myCommand.Parameters.AddWithValue("@accessLevel", updatedOfficeStaff.accessLevel);
                myCommand.Parameters.AddWithValue("@userId", updatedOfficeStaff.userId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // UpdateItem
        public void UpdateList(List<UsersOfficeStaff> officestaff)
        {
            foreach (var OfficeStaff in officestaff)
            {
                UpdateItem(OfficeStaff);
            }

        }

        /// Insert a single admission record into the database.
        /// </summary>
        public void WriteItem(UsersOfficeStaff newOfficeStaff)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "INSERT INTO " + theTable +
                    " (userId, nameLast, nameFirst, title, accessLevel, " +
                    "duration, amount)" +
                    "VALUES (@userId, @nameLast, @nameFirst, @title, @accessLevel)";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@userId", newOfficeStaff.userId);
                myCommand.Parameters.AddWithValue("@nameLast", newOfficeStaff.nameLast);
                myCommand.Parameters.AddWithValue("@nameFirst", newOfficeStaff.nameFirst);
                myCommand.Parameters.AddWithValue("@title", newOfficeStaff.title);
                myCommand.Parameters.AddWithValue("@accessLevel", newOfficeStaff.accessLevel);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // WriteItem

        public void WriteList(List<UsersOfficeStaff> officestaff)
        {
            foreach (var OfficeStaff in officestaff)
            {
                WriteItem(OfficeStaff);
            } // foreach
        } // writelist
    }
}
