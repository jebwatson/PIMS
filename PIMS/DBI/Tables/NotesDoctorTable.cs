using DBI.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DBI
{
    public class NotesDoctorTable
    {
        public const string theTable = "notesDoctor";

        public List<NotesDoctor> ItemList { get; set; } = new List<NotesDoctor>();

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

        /// <summary>
        /// Delete any records with the NotesDoctor specified.
        /// </summary>
        /// <param name="NotesId"></param>
        public void ClearTableById(int NotesId)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "DELETE FROM " + theTable +
                    " WHERE " +
                    "notesId = @notesId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@notesId", NotesId);

                myCommand.ExecuteNonQuery();
                myConnection.Close();
            }
        }

        /// <summary>
        /// Get a count of all records in the table.
        /// </summary>
        /// <returns></returns>
        public int CountRows()
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "SELECT COUNT(*) FROM " + theTable;
                return QueryExecutor.ExecuteSqlQueryScalar(myQuery, myConnection);
            } // using
        } // CountRows

        /// <summary>
        /// Read all records from the table and save them in the ItemList
        /// as NotesDoctor objects.
        /// </summary>
        public void ReadList()
        {
            ItemList.Clear();   // ensure that the itemlist is empty so we don't get duplicates

            string myQuery = "SELECT * FROM " + theTable;
            DataSet dsObject = QueryExecutor.ExecuteSqlQuery(myQuery);

            if (dsObject != null && dsObject.Tables[0].Rows.Count > 0)
            {
                DataTable dtObject = dsObject.Tables[0];    // get the DataTable reference once

                foreach (DataRow dr in dtObject.Rows)
                {
                    // extract all fields of the current row
                    int notesId = Convert.ToInt32(dr["notesId"]);
                    string notes = dr["notes"].ToString();
                    int doctorId = Convert.ToInt32(dr["doctorId"]);
                    int patientId = Convert.ToInt32(dr["patientId"]);
                    int caseId = Convert.ToInt32(dr["caseId"]);

                    // fill the ItemList
                    NotesDoctor newNotesDoctor = new NotesDoctor();
                    newNotesDoctor.notesId = notesId;
                    newNotesDoctor.notes = notes;
                    newNotesDoctor.doctorId = doctorId;
                    newNotesDoctor.patientId = patientId;
                    newNotesDoctor.caseId = caseId;

                    ItemList.Add(newNotesDoctor);
                } // for
            } // if
        } // ReadList

        /// <summary>
        /// Read a sinlge record from the table and save the record in the
        /// ItemList as a NotesDoctor object.
        /// </summary>
        public void ReadListById(int inputNotesId)
        {
            ItemList.Clear();   // ensure that the itemlist is empty so we don't get duplicates

            string myQuery = "SELECT * FROM " + theTable + " WHERE notesId = " + "'" + inputNotesId + "'";

            DataSet dsObject = QueryExecutor.ExecuteSqlQuery(myQuery);

            if (dsObject != null && dsObject.Tables[0].Rows.Count > 0)
            {
                DataTable dtObject = dsObject.Tables[0];    // get the DataTable reference once

                foreach (DataRow dr in dtObject.Rows)
                {
                    // extract all fields of the current row
                    int notesId = Convert.ToInt32(dr["notesId"]);
                    string notes = dr["notes"].ToString();
                    int doctorId = Convert.ToInt32(dr["doctorId"]);
                    int patientId = Convert.ToInt32(dr["patientId"]);
                    int caseId = Convert.ToInt32(dr["caseId"]);

                    // fill the ItemList
                    NotesDoctor newNotesDoctor = new NotesDoctor();
                    newNotesDoctor.notesId = notesId;
                    newNotesDoctor.notes = notes;
                    newNotesDoctor.doctorId = doctorId;
                    newNotesDoctor.patientId = patientId;
                    newNotesDoctor.caseId = caseId;

                    ItemList.Add(newNotesDoctor);
                } // for
            } // if
        } // ReadList

        /// <summary>
        /// Given a single NotesDoctor object, update the record corresponding
        /// to the object's NotesDoctor id with any discrepancies in the NotesDoctor
        /// object.
        /// </summary>
        /// <param name="updatedNotesDoctor"></param>
        public void UpdateItem(NotesDoctor updatedNotesDoctor)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "UPDATE " + theTable +
                    " SET " +
                    "notes = @notes, " +
                    "doctorId = @doctorId, " +
                    "patientId = @patientId, " +
                    "caseId = @caseId, " +
                    "WHERE " +
                    "notesId = @notesId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@notes", updatedNotesDoctor.notes);
                myCommand.Parameters.AddWithValue("@doctorId", updatedNotesDoctor.doctorId);
                myCommand.Parameters.AddWithValue("@patientId", updatedNotesDoctor.patientId);
                myCommand.Parameters.AddWithValue("@caseId", updatedNotesDoctor.caseId);
                myCommand.Parameters.AddWithValue("@notesId", updatedNotesDoctor.notesId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // UpdateItem

        /// <summary>
        /// Given a list of NotesDoctor objects, update their properties to the database
        /// by NotesDoctor id.
        /// </summary>
        public void UpdateList()
        {
            foreach (var NotesDoctor in ItemList)
            {
                UpdateItem(NotesDoctor);
            }
        }

        /// <summary>
        /// Insert a single NotesDoctor record into the database.
        /// </summary>
        public void WriteItem(NotesDoctor newNotesDoctor)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "INSERT INTO " + theTable +
                    "(notesId, notes, doctorId, patientId, caseId) " +
                    "VALUES (@notesId, @notes, @doctorId, @patientId, @caseId)";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@notes", newNotesDoctor.notes);
                myCommand.Parameters.AddWithValue("@doctorId", newNotesDoctor.doctorId);
                myCommand.Parameters.AddWithValue("@patientId", newNotesDoctor.patientId);
                myCommand.Parameters.AddWithValue("@caseId", newNotesDoctor.caseId);
                myCommand.Parameters.AddWithValue("@notesId", newNotesDoctor.notesId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // WriteItem

        /// <summary>
        /// Insert a list of NotesDoctor records into the database.
        /// </summary>
        public void WriteList()
        {
            foreach (var NotesDoctor in ItemList)
            {
                WriteItem(NotesDoctor);
            } // foreach
        } // writelist
    }
}
