using DBI.Tables;
using DBI.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DBI
{
    public class VisitorsTable
    {
        public const string theTable = "visitors";

        /// <summary>
        /// Delete all records from the table.
        /// </summary>
        public void ClearTable() {
            if (CountRows() == 0)
                return;

            string myCommand = "DELETE FROM " + theTable;
            QueryExecutor.ExecuteSqlNonQuery(myCommand);

            myCommand = "DBCC CHECKIDENT('" + theTable + "', RESEED, 0)";
            QueryExecutor.ExecuteSqlNonQuery(myCommand);
        }

        /// <summary>
        /// Delete any records with the admissionId specified.
        /// </summary>
        /// <param name="nameLast"></param>
        /// <param name="nameFirst"></param>
        public void ClearTableById(int visitorId) {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection()) {
                string myQuery = "DELETE FROM " + theTable +
                    " WHERE " +
                    "visitorId = @visitorId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@visitorId", visitorId);

                myCommand.ExecuteNonQuery();
                myConnection.Close();
            }
        }

        /// <summary>
        /// Delete any records with the admissionId specified.
        /// </summary>
        /// <param name="nameLast"></param>
        /// <param name="nameFirst"></param>
        public void ClearTableByVisitor(int patientId, DateTime lastVisit)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "DELETE FROM " + theTable +
                    " WHERE " +
                    "patientId = @patientId AND lastVisit = @lastVisit";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@patientId", patientId);
                myCommand.Parameters.AddWithValue("@lastVisit", lastVisit);

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
        public List<Visitors> ReadList() {
            List<Visitors> visitors = new List<Visitors>();

            string myQuery = "SELECT * FROM " + theTable;
            DataSet dsObject = QueryExecutor.ExecuteSqlQuery(myQuery);

            if (dsObject != null && dsObject.Tables[0].Rows.Count > 0) {
                DataTable dtObject = dsObject.Tables[0];    // get the DataTable reference once

                foreach (DataRow dr in dtObject.Rows) {
                    // extract all fields of the current row
                    int visitorId = Convert.ToInt32(dr["visitorId"]);
                    string nameLast = dr["nameLast"].ToString();
                    string nameFirst = dr["nameFirst"].ToString();
                    int patientId = Convert.ToInt32(dr["patientId"]);
                    DateTime lastVisit = Convert.ToDateTime(dr["lastVisit"]);
                    string relation = dr["relation"].ToString();

                    // fill the ItemList
                    Visitors visitor = new Visitors();
                    visitor.visitorId = visitorId;
                    visitor.nameLast = nameLast;
                    visitor.nameFirst = nameFirst;
                    visitor.patientId = patientId;
                    visitor.lastVisit = lastVisit;
                    visitor.relation = relation;

                    // Need to add the patient name to the object
                    AddPatientName(visitor);

                    visitors.Add(visitor);
                } // for
            } // if

            return visitors;
        } // ReadList

        /// <summary>
        /// Read a sinlge record from the table and save the record in the
        /// ItemList as an admission object.
        /// </summary>
        public List<Visitors> ReadListById(int inputVisitorId) {
            List<Visitors> visitors = new List<Visitors>();

            string myQuery = "SELECT * FROM " + theTable + " WHERE visitorId = " + "'" + inputVisitorId + "'";

            DataSet dsObject = QueryExecutor.ExecuteSqlQuery(myQuery);

            if (dsObject != null && dsObject.Tables[0].Rows.Count > 0) {
                DataTable dtObject = dsObject.Tables[0];    // get the DataTable reference once

                foreach (DataRow dr in dtObject.Rows) {
                    // extract all fields of the current row
                    int visitorId = Convert.ToInt32(dr["visitorId"]);
                    string nameLast = dr["nameLast"].ToString();
                    string nameFirst = dr["nameFirst"].ToString();
                    int patientId = Convert.ToInt32(dr["patientId"]);
                    DateTime lastVisit = Convert.ToDateTime(dr["lastVisit"]);
                    string relation = dr["relation"].ToString();

                    // fill the ItemList
                    Visitors visitor = new Visitors();
                    visitor.visitorId = visitorId;
                    visitor.nameLast = nameLast;
                    visitor.nameFirst = nameFirst;
                    visitor.patientId = patientId;
                    visitor.lastVisit = lastVisit;
                    visitor.relation = relation;

                    // Need to add the patient name to the object
                    AddPatientName(visitor);

                    visitors.Add(visitor);
                } // for
            } // if

            return visitors;
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
                    "nameLast = @nameLast," +
                    "nameFirst = @nameFirst," +
                    "patientId = @patientId, " +
                    "lastVisit = @lastVisit, " +
                    "relation = @relation " +
                    "WHERE " +
                    "visitorId = @visitorId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@nameFirst", updatedVisitor.nameFirst);
                myCommand.Parameters.AddWithValue("@patientId", updatedVisitor.patientId);
                myCommand.Parameters.AddWithValue("@lastVisit", updatedVisitor.lastVisit);
                myCommand.Parameters.AddWithValue("@relation", updatedVisitor.relation);
                myCommand.Parameters.AddWithValue("@nameLast", updatedVisitor.nameLast);
                myCommand.Parameters.AddWithValue("@visitorId", updatedVisitor.visitorId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // UpdateItem

        /// <summary>
        /// Given a list of admission objects, update their properties to the database
        /// by admission id.
        /// </summary>
        public void UpdateList(List<Visitors> visitors) {
            foreach (var visitor in visitors) {
                UpdateItem(visitor);
            }
        }

        /// <summary>
        /// Insert a single admission record into the database.
        /// </summary>
        public void WriteItem(Visitors newVisitor) {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection()) {
                string myQuery = "INSERT INTO " + theTable +
                    " (nameLast, nameFirst, patientId, lastVisit, " +
                    "relation)" +
                    "VALUES (@nameLast, @nameFirst, @patientId, @lastVisit, " +
                    "@relation)";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@visitorId", newVisitor.visitorId);
                myCommand.Parameters.AddWithValue("@nameLast", newVisitor.nameLast);
                myCommand.Parameters.AddWithValue("@nameFirst", newVisitor.nameFirst);
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
        public void WriteList(List<Visitors> visitors) {
            foreach (var visitor in visitors) {
                WriteItem(visitor);
            } // foreach
        } // writelist

        /// <summary>
        /// Need to add the patient name to the object.
        /// </summary>
        /// <param name="newObject"></param>
        private void AddPatientName(dynamic newObject)
        {
            PatientTable MyPatientTable = new PatientTable();
            List<Patient> MyPatientsList = MyPatientTable.ReadListById(newObject.patientId);

            if (MyPatientsList.Count > 0)
            {
                newObject.patientName = MyPatientsList[0].nameFirst + " " + MyPatientsList[0].nameLast;
            }
        }
    }
}
