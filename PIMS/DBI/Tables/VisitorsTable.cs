using DBI.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DBI
{
    class VisitorsTable
    {
        public const string theTable = "visitors";

        public List<Visitors> ItemList { get; set; } = new List<Visitors>();

        /// <summary>
        /// Delete all records from the table.
        /// </summary>
        public void ClearTable() {
            if (CountRows() == 0)
                return;

            string myCommand = "DELETE FROM " + theTable;
            QueryExecutor.ExecuteSqlNonQuery(myCommand);
        }

        /// <summary>
        /// Delete any records with the admissionId specified.
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        public void ClearTableById(string lastName, string firstName) {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection()) {
                string myQuery = "DELETE FROM " + theTable +
                    " WHERE " +
                    "lastName = @lastName" + 
                    "AND firstName = @firstName";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@lastName", lastName);
                myCommand.Parameters.AddWithValue("@firstName", firstName);

                myCommand.ExecuteNonQuery();
                myConnection.Close();
            }
        }

        /// <summary>
        /// Get a count of all records in the table.
        /// </summary>
        /// <returns></returns>
        public int CountRows() {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection()) {
                string myQuery = "SELECT COUNT(*) FROM " + theTable;
                return QueryExecutor.ExecuteSqlQueryScalar(myQuery, myConnection);
            } // using
        } // CountRows

        /// <summary>
        /// Read all records from the table and save them in the ItemList
        /// as Admission objects.
        /// </summary>
        public void ReadList() {
            ItemList.Clear();   // ensure that the itemlist is empty so we don't get duplicates

            string myQuery = "SELECT * FROM " + theTable;
            DataSet dsObject = QueryExecutor.ExecuteSqlQuery(myQuery);

            if (dsObject != null && dsObject.Tables[0].Rows.Count > 0) {
                DataTable dtObject = dsObject.Tables[0];    // get the DataTable reference once

                foreach (DataRow dr in dtObject.Rows) {
                    // extract all fields of the current row
                    string lastName = dr["lastName"].ToString();
                    string firstName = dr["firstName"].ToString();
                    int caseId = Convert.ToInt32(dr["caseId"]);
                    int patientId = Convert.ToInt32(dr["patientId"]);
                    DateTime lastVisit = Convert.ToDateTime(dr["lastVisit"]);
                    string relation = dr["relation"].ToString();

                    // fill the ItemList
                    Visitors visitor = new Visitors();
                    visitor.lastName = lastName;
                    visitor.firstName = firstName;
                    visitor.caseId = caseId;
                    visitor.patientId = patientId;
                    visitor.lastVisit = lastVisit;
                    visitor.relation = relation;

                    ItemList.Add(visitor);
                } // for
            } // if
        } // ReadList

        /// <summary>
        /// Read a sinlge record from the table and save the record in the
        /// ItemList as an admission object.
        /// </summary>
        public void ReadListById(int inputLastName, int inputFirstName) {
            ItemList.Clear();   // ensure that the itemlist is empty so we don't get duplicates

            string myQuery = "SELECT * FROM " + theTable + " WHERE lastName = " + "'" + inputLastName + "'" + " AND firstName = " + "'" + inputFirstName + "'";

            DataSet dsObject = QueryExecutor.ExecuteSqlQuery(myQuery);

            if (dsObject != null && dsObject.Tables[0].Rows.Count > 0) {
                DataTable dtObject = dsObject.Tables[0];    // get the DataTable reference once

                foreach (DataRow dr in dtObject.Rows) {
                    // extract all fields of the current row
                    string lastName = dr["lastName"].ToString();
                    string firstName = dr["firstName"].ToString();
                    int caseId = Convert.ToInt32(dr["caseId"]);
                    int patientId = Convert.ToInt32(dr["patientId"]);
                    DateTime lastVisit = Convert.ToDateTime(dr["lastVisit"]);
                    string relation = dr["relation"].ToString();

                    // fill the ItemList
                    Visitors visitor = new Visitors();
                    visitor.lastName = lastName;
                    visitor.firstName = firstName;
                    visitor.caseId = caseId;
                    visitor.patientId = patientId;
                    visitor.lastVisit = lastVisit;
                    visitor.relation = relation;

                    ItemList.Add(visitor);
                } // for
            } // if
        } // ReadList

        /// <summary>
        /// Given a single admission object, update the record correspnoding
        /// to the object's admission id with any discrepancies in the admission
        /// object.
        /// </summary>
        /// <param name="updatedVisitor"></param>
        public void UpdateItem(Visitors updatedVisitor) {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection()) {
                string myQuery = "UPDATE " + theTable +
                    " SET " +
                    "caseId = @caseId, " +
                    "patientId = @patientId, " +
                    "lastVisit = @lastVisit, " +
                    "duration = @duration, " +
                    "relation = @relation, " +
                    "WHERE " +
                    "lastName = @lastName" +
                    "AND firstName = @firstName";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@firstName", updatedVisitor.firstName);
                myCommand.Parameters.AddWithValue("@caseId", updatedVisitor.caseId);
                myCommand.Parameters.AddWithValue("@patientId", updatedVisitor.patientId);
                myCommand.Parameters.AddWithValue("@lastVisit", updatedVisitor.lastVisit);
                myCommand.Parameters.AddWithValue("@relation", updatedVisitor.relation);
                myCommand.Parameters.AddWithValue("@lastName", updatedVisitor.lastName);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // UpdateItem

        /// <summary>
        /// Given a list of admission objects, update their properties to the database
        /// by admission id.
        /// </summary>
        public void UpdateList() {
            foreach (var visitor in ItemList) {
                UpdateItem(visitor);
            }
        }

        /// <summary>
        /// Insert a single admission record into the database.
        /// </summary>
        public void WriteItem(Visitors newVisitor) {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection()) {
                string myQuery = "INSERT INTO " + theTable +
                    " (lastName, firstName, caseId, patientId, lastVisit, " +
                    "relation)" +
                    "VALUES (@lastName, @firstName, @caseId, @patientId, @lastVisit, " +
                    "@relation)";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@lastName", newVisitor.lastName);
                myCommand.Parameters.AddWithValue("@firstName", newVisitor.firstName);
                myCommand.Parameters.AddWithValue("@caseId", newVisitor.caseId);
                myCommand.Parameters.AddWithValue("@patientId", newVisitor.patientId);
                myCommand.Parameters.AddWithValue("@lastVisit", newVisitor.lastVisit);
                myCommand.Parameters.AddWithValue("@relation", newVisitor.relation);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // WriteItem

        /// <summary>
        /// Insert a list of admission records into the database.
        /// </summary>
        public void WriteList() {
            foreach (var visitor in ItemList) {
                WriteItem(visitor);
            } // foreach
        } // writelist
    }
}
