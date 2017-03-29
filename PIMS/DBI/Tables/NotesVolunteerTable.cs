using DBI.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DBI
{
    public class NotesVolunteerTable
    {
        public const string theTable = "notesVolunteer";

        public List<NotesVolunteer> ItemList { get; set; } = new List<NotesVolunteer>();

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
        /// Delete any records with the NotesVolunteer specified.
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
        /// as NotesVolunteer objects.
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
                    int volunteerId = Convert.ToInt32(dr["volunteerId"]);
                    int patientId = Convert.ToInt32(dr["patientId"]);
                    int caseId = Convert.ToInt32(dr["caseId"]);

                    // fill the ItemList
                    NotesVolunteer newNotesVolunteer = new NotesVolunteer();
                    newNotesVolunteer.notesId = notesId;
                    newNotesVolunteer.notes = notes;
                    newNotesVolunteer.volunteerId = volunteerId;
                    newNotesVolunteer.patientId = patientId;
                    newNotesVolunteer.caseId = caseId;

                    ItemList.Add(newNotesVolunteer);
                } // for
            } // if
        } // ReadList

        /// <summary>
        /// Read a sinlge record from the table and save the record in the
        /// ItemList as a NotesVolunteer object.
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
                    int volunteerId = Convert.ToInt32(dr["volunteerId"]);
                    int patientId = Convert.ToInt32(dr["patientId"]);
                    int caseId = Convert.ToInt32(dr["caseId"]);

                    // fill the ItemList
                    NotesVolunteer newNotesVolunteer = new NotesVolunteer();
                    newNotesVolunteer.notesId = notesId;
                    newNotesVolunteer.notes = notes;
                    newNotesVolunteer.volunteerId = volunteerId;
                    newNotesVolunteer.patientId = patientId;
                    newNotesVolunteer.caseId = caseId;

                    ItemList.Add(newNotesVolunteer);
                } // for
            } // if
        } // ReadList

        /// <summary>
        /// Given a single NotesVolunteer object, update the record corresponding
        /// to the object's NotesVolunteer id with any discrepancies in the NotesVolunteer
        /// object.
        /// </summary>
        /// <param name="updatedNotesVolunteer"></param>
        public void UpdateItem(NotesVolunteer updatedNotesVolunteer)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "UPDATE " + theTable +
                    " SET " +
                    "notes = @notes, " +
                    "volunteerId = @volunteerId, " +
                    "patientId = @patientId, " +
                    "caseId = @caseId, " +
                    "WHERE " +
                    "notesId = @notesId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@notes", updatedNotesVolunteer.notes);
                myCommand.Parameters.AddWithValue("@volunteerId", updatedNotesVolunteer.volunteerId);
                myCommand.Parameters.AddWithValue("@patientId", updatedNotesVolunteer.patientId);
                myCommand.Parameters.AddWithValue("@caseId", updatedNotesVolunteer.caseId);
                myCommand.Parameters.AddWithValue("@notesId", updatedNotesVolunteer.notesId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // UpdateItem

        /// <summary>
        /// Given a list of NotesVolunteer objects, update their properties to the database
        /// by NotesVolunteer id.
        /// </summary>
        public void UpdateList()
        {
            foreach (var NotesVolunteer in ItemList)
            {
                UpdateItem(NotesVolunteer);
            }
        }

        /// <summary>
        /// Insert a single NotesVolunteer record into the database.
        /// </summary>
        public void WriteItem(NotesVolunteer newNotesVolunteer)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "INSERT INTO " + theTable +
                    "(notesId, notes, volunteerId, patientId, caseId) " +
                    "VALUES (@notesId, @notes, @volunteerId, @patientId, @caseId)";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@notes", newNotesVolunteer.notes);
                myCommand.Parameters.AddWithValue("@volunteerId", newNotesVolunteer.volunteerId);
                myCommand.Parameters.AddWithValue("@patientId", newNotesVolunteer.patientId);
                myCommand.Parameters.AddWithValue("@caseId", newNotesVolunteer.caseId);
                myCommand.Parameters.AddWithValue("@notesId", newNotesVolunteer.notesId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // WriteItem

        /// <summary>
        /// Insert a list of NotesVolunteer records into the database.
        /// </summary>
        public void WriteList()
        {
            foreach (var NotesVolunteer in ItemList)
            {
                WriteItem(NotesVolunteer);
            } // foreach
        } // writelist
    }
}
