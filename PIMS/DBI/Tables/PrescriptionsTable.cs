using DBI.Tables;
using DBI.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DBI
{
    public class PrescriptionsTable : IRepository<Prescriptions, int>
    {
        public const string theTable = "prescriptions";

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
        /// <param name="prescId"></param>
        public void ClearTableById(int prescId) {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection()) {
                string myQuery = "DELETE FROM " + theTable +
                    " WHERE " +
                    "prescId = @prescId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@prescId", prescId);

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
        public List<Prescriptions> ReadList() {
            List<Prescriptions> prescriptions = new List<Prescriptions>();

            string myQuery = "SELECT * FROM " + theTable;
            DataSet dsObject = QueryExecutor.ExecuteSqlQuery(myQuery);

            if (dsObject != null && dsObject.Tables[0].Rows.Count > 0) {
                DataTable dtObject = dsObject.Tables[0];    // get the DataTable reference once

                foreach (DataRow dr in dtObject.Rows) {
                    // extract all fields of the current row
                    int prescId = Convert.ToInt32(dr["prescId"]);
                    string prescName = dr["prescName"].ToString();
                    int caseId = Convert.ToInt32(dr["caseId"]);
                    int patientId = Convert.ToInt32(dr["patientId"]);
                    DateTime prescDate = Convert.ToDateTime(dr["prescDate"]);
                    int duration = Convert.ToInt32(dr["duration"]);
                    string amount = dr["amount"].ToString();

                    // fill the ItemList
                    Prescriptions prescription = new Prescriptions();
                    prescription.prescId = prescId;
                    prescription.prescName = prescName;
                    prescription.caseId = caseId;
                    prescription.patientId = patientId;
                    prescription.prescDate = prescDate;
                    prescription.duration = duration;
                    prescription.amount = amount;

                    prescriptions.Add(prescription);
                } // for
            } // if

            return prescriptions;
        } // ReadList

        /// <summary>
        /// Read a sinlge record from the table and save the record in the
        /// ItemList as an admission object.
        /// </summary>
        public List<Prescriptions> ReadListById(int inputPrescId) {
            List<Prescriptions> prescriptions = new List<Prescriptions>();

            string myQuery = "SELECT * FROM " + theTable + " WHERE prescId = " + "'" + inputPrescId + "'";

            DataSet dsObject = QueryExecutor.ExecuteSqlQuery(myQuery);

            if (dsObject != null && dsObject.Tables[0].Rows.Count > 0) {
                DataTable dtObject = dsObject.Tables[0];    // get the DataTable reference once

                foreach (DataRow dr in dtObject.Rows) {
                    // extract all fields of the current row
                    int prescId = Convert.ToInt32(dr["prescId"]);
                    string prescName = dr["prescName"].ToString();
                    int caseId = Convert.ToInt32(dr["caseId"]);
                    int patientId = Convert.ToInt32(dr["patientId"]);
                    DateTime prescDate = Convert.ToDateTime(dr["prescDate"]);
                    int duration = Convert.ToInt32(dr["duration"]);
                    string amount = dr["amount"].ToString();

                    // fill the ItemList
                    Prescriptions prescription = new Prescriptions();
                    prescription.prescId = prescId;
                    prescription.prescName = prescName;
                    prescription.caseId = caseId;
                    prescription.patientId = patientId;
                    prescription.prescDate = prescDate;
                    prescription.duration = duration;
                    prescription.amount = amount;

                    prescriptions.Add(prescription);
                } // for
            } // if

            return prescriptions;
        } // ReadList

        /// <summary>
        /// Given a single admission object, update the record correspnoding
        /// to the object's admission id with any discrepancies in the admission
        /// object.
        /// </summary>
        /// <param name="updatedPresc"></param>
        public void UpdateItem(Prescriptions updatedPresc) {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection()) {
                string myQuery = "UPDATE " + theTable +
                    " SET " +
                    "prescName = @prescName, " +
                    "caseId = @caseId, " +
                    "patientId = @patientId, " +
                    "prescDate = @prescDate, " +
                    "duration = @duration, " +
                    "amount = @amount " +
                    "WHERE " +
                    "prescId = @prescId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@prescName", updatedPresc.prescName);
                myCommand.Parameters.AddWithValue("@caseId", updatedPresc.caseId);
                myCommand.Parameters.AddWithValue("@patientId", updatedPresc.patientId);
                myCommand.Parameters.AddWithValue("@prescDate", updatedPresc.prescDate);
                myCommand.Parameters.AddWithValue("@duration", updatedPresc.duration);
                myCommand.Parameters.AddWithValue("@amount", updatedPresc.amount);
                myCommand.Parameters.AddWithValue("@prescId", updatedPresc.prescId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // UpdateItem

        /// <summary>
        /// Given a list of admission objects, update their properties to the database
        /// by admission id.
        /// </summary>
        public void UpdateList(List<Prescriptions> prescriptions) {
            foreach (var prescription in prescriptions) {
                UpdateItem(prescription);
            }
        }

        /// <summary>
        /// Insert a single admission record into the database.
        /// </summary>
        public void WriteItem(Prescriptions newPresc) {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection()) {
                string myQuery = "INSERT INTO " + theTable +
                    " (prescId, prescName, caseId, patientId, prescDate, " +
                    "duration, amount)" +
                    "VALUES (@prescId, @prescName, @caseId, @patientId, @prescDate, " +
                    "@duration, @amount)";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@prescId", newPresc.prescId);
                myCommand.Parameters.AddWithValue("@prescName", newPresc.prescName);
                myCommand.Parameters.AddWithValue("@caseId", newPresc.caseId);
                myCommand.Parameters.AddWithValue("@patientId", newPresc.patientId);
                myCommand.Parameters.AddWithValue("@prescDate", newPresc.prescDate);
                myCommand.Parameters.AddWithValue("@duration", newPresc.duration);
                myCommand.Parameters.AddWithValue("@amount", newPresc.amount);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // WriteItem

        /// <summary>
        /// Insert a list of admission records into the database.
        /// </summary>
        public void WriteList(List<Prescriptions> prescriptions) {
            foreach (var prescription in prescriptions) {
                WriteItem(prescription);
            } // foreach
        } // writelist
    }
}
