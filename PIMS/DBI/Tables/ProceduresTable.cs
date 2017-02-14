using DBI.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DBI
{
    class ProceduresTable
    {
        public const string theTable = "procedures";

        public List<Procedures> ItemList { get; set; } = new List<Procedures>();

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
        /// <param name="procId"></param>
        public void ClearTableById(int procId) {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection()) {
                string myQuery = "DELETE FROM " + theTable +
                    " WHERE " +
                    "procId = @procId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@procId", procId);

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
                    int procId = Convert.ToInt32(dr["procId"]);
                    string procType = dr["procType"].ToString();
                    int caseId = Convert.ToInt32(dr["caseId"]);
                    int patientId = Convert.ToInt32(dr["patientId"]);
                    DateTime startTime = Convert.ToDateTime(dr["startTime"]);
                    int doctorId = Convert.ToInt32(dr["doctorId"]);
                    string procNotes = dr["procNotes"].ToString();
                    int durationHrs = Convert.ToInt32(dr["durationHrs"]);
                    int durationMins = Convert.ToInt32(dr["durationMins"]);

                    // fill the ItemList
                    Procedures procedure = new Procedures();
                    procedure.procId = procId;
                    procedure.procType = procType;
                    procedure.caseId = caseId;
                    procedure.patientId = patientId;
                    procedure.startTime = startTime;
                    procedure.doctorId = doctorId;
                    procedure.procNotes = procNotes;
                    procedure.durationHrs = durationHrs;
                    procedure.durationMins = durationMins;

                    ItemList.Add(procedure);
                } // for
            } // if
        } // ReadList

        /// <summary>
        /// Read a sinlge record from the table and save the record in the
        /// ItemList as an admission object.
        /// </summary>
        public void ReadListById(int inputProcId) {
            ItemList.Clear();   // ensure that the itemlist is empty so we don't get duplicates

            string myQuery = "SELECT * FROM " + theTable + " WHERE procId = " + "'" + inputProcId + "'";

            DataSet dsObject = QueryExecutor.ExecuteSqlQuery(myQuery);

            if (dsObject != null && dsObject.Tables[0].Rows.Count > 0) {
                DataTable dtObject = dsObject.Tables[0];    // get the DataTable reference once

                foreach (DataRow dr in dtObject.Rows) {
                    // extract all fields of the current row
                    int procId = Convert.ToInt32(dr["procId"]);
                    string procType = dr["procType"].ToString();
                    int caseId = Convert.ToInt32(dr["caseId"]);
                    int patientId = Convert.ToInt32(dr["patientId"]);
                    DateTime startTime = Convert.ToDateTime(dr["startTime"]);
                    DateTime dateDue = Convert.ToDateTime(dr["dateDue"]);
                    int doctorId = Convert.ToInt32(dr["doctorId"]);
                    string procNotes = dr["procNotes"].ToString();
                    int durationHrs = Convert.ToInt32(dr["durationHrs"]);
                    int durationMins = Convert.ToInt32(dr["durationMins"]);


                    // fill the ItemList
                    Procedures procedure = new Procedures();
                    procedure.procId = procId;
                    procedure.procType = procType;
                    procedure.caseId = caseId;
                    procedure.patientId = patientId;
                    procedure.startTime = startTime;
                    procedure.doctorId = doctorId;
                    procedure.procNotes = procNotes;
                    procedure.durationHrs = durationHrs;
                    procedure.durationMins = durationMins;

                    ItemList.Add(procedure);
                } // for
            } // if
        } // ReadList

        /// <summary>
        /// Given a single admission object, update the record correspnoding
        /// to the object's admission id with any discrepancies in the admission
        /// object.
        /// </summary>
        /// <param name="updatedProc"></param>
        public void UpdateItem(Procedures updatedProc) {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection()) {
                string myQuery = "UPDATE " + theTable +
                    " SET " +
                    "procType = @procType, " +
                    "caseId = @caseId, " +
                    "patientId = @patientId, " +
                    "startTime = @startTime, " +
                    "doctorId = @doctorId, " +
                    "durationHrs = @durationHrs, " +
                    "durationMins = @durationMins, " +
                    "procNotes = @procNotes, " +
                    "WHERE " +
                    "procId = @procId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@procType", updatedProc.procType);
                myCommand.Parameters.AddWithValue("@caseId", updatedProc.caseId);
                myCommand.Parameters.AddWithValue("@patientId", updatedProc.patientId);
                myCommand.Parameters.AddWithValue("@startTime", updatedProc.startTime);
                myCommand.Parameters.AddWithValue("@doctorId", updatedProc.doctorId);
                myCommand.Parameters.AddWithValue("@procNotes", updatedProc.procNotes);
                myCommand.Parameters.AddWithValue("@procId", updatedProc.procId);
                myCommand.Parameters.AddWithValue("@procId", updatedProc.procId);
                myCommand.Parameters.AddWithValue("@durationHrs", updatedProc.durationHrs);
                myCommand.Parameters.AddWithValue("@durationMins", updatedProc.durationMins);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // UpdateItem

        /// <summary>
        /// Given a list of admission objects, update their properties to the database
        /// by admission id.
        /// </summary>
        public void UpdateList() {
            foreach (var procedure in ItemList) {
                UpdateItem(procedure);
            }
        }

        /// <summary>
        /// Insert a single admission record into the database.
        /// </summary>
        public void WriteItem(Procedures newProc) {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection()) {
                string myQuery = "INSERT INTO " + theTable +
                    " (procId, procType, caseId, patientId, startTime, " +
                    "doctorId, durationHrs, durationMins, procNotes)" +
                    "VALUES (@procId, @procType, @caseId, @patientId, @startTime, " +
                    "@doctorId, @durationHrs, @durationMins, @procNotes)";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@procId", newProc.procId);
                myCommand.Parameters.AddWithValue("@procType", newProc.procType);
                myCommand.Parameters.AddWithValue("@caseId", newProc.caseId);
                myCommand.Parameters.AddWithValue("@patientId", newProc.patientId);
                myCommand.Parameters.AddWithValue("@startTime", newProc.startTime);
                myCommand.Parameters.AddWithValue("@doctorId", newProc.doctorId);
                myCommand.Parameters.AddWithValue("@procNotes", newProc.procNotes);
                myCommand.Parameters.AddWithValue("@durationHrs", newProc.durationHrs);
                myCommand.Parameters.AddWithValue("@durationMins", newProc.durationMins);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // WriteItem

        /// <summary>
        /// Insert a list of admission records into the database.
        /// </summary>
        public void WriteList() {
            foreach (var procedure in ItemList) {
                WriteItem(procedure);
            } // foreach
        } // writelist
    }
}
