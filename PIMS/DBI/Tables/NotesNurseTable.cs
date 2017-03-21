using DBI.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DBI
{
    public class NotesNurseTable
    {
        public const string theTable = "notesNurse";

        public List<NotesNurse> ItemList { get; set; } = new List<NotesNurse>();

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
        /// Delete any records with the NotesNurse specified.
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
        /// as NotesNurse objects.
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
                    int nurseId = Convert.ToInt32(dr["nurseId"]);
                    int patientId = Convert.ToInt32(dr["patientId"]);
                    int caseId = Convert.ToInt32(dr["caseId"]);

                    // fill the ItemList
                    NotesNurse newNotesNurse = new NotesNurse();
                    newNotesNurse.notesId = notesId;
                    newNotesNurse.notes = notes;
                    newNotesNurse.nurseId = nurseId;
                    newNotesNurse.patientId = patientId;
                    newNotesNurse.caseId = caseId;

                    ItemList.Add(newNotesNurse);
                } // for
            } // if
        } // ReadList

        /// <summary>
        /// Read a sinlge record from the table and save the record in the
        /// ItemList as a NotesNurse object.
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
                    int nurseId = Convert.ToInt32(dr["nurseId"]);
                    int patientId = Convert.ToInt32(dr["patientId"]);
                    int caseId = Convert.ToInt32(dr["caseId"]);

                    // fill the ItemList
                    NotesNurse newNotesNurse = new NotesNurse();
                    newNotesNurse.notesId = notesId;
                    newNotesNurse.notes = notes;
                    newNotesNurse.nurseId = nurseId;
                    newNotesNurse.patientId = patientId;
                    newNotesNurse.caseId = caseId;

                    ItemList.Add(newNotesNurse);
                } // for
            } // if
        } // ReadList

        /// <summary>
        /// Given a single NotesNurse object, update the record corresponding
        /// to the object's NotesNurse id with any discrepancies in the NotesNurse
        /// object.
        /// </summary>
        /// <param name="updatedNotesNurse"></param>
        public void UpdateItem(NotesNurse updatedNotesNurse)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "UPDATE " + theTable +
                    " SET " +
                    "notes = @notes, " +
                    "nurseId = @nurseId, " +
                    "patientId = @patientId, " +
                    "caseId = @caseId, " +
                    "WHERE " +
                    "notesId = @notesId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@notes", updatedNotesNurse.notes);
                myCommand.Parameters.AddWithValue("@nurseId", updatedNotesNurse.nurseId);
                myCommand.Parameters.AddWithValue("@patientId", updatedNotesNurse.patientId);
                myCommand.Parameters.AddWithValue("@caseId", updatedNotesNurse.caseId);
                myCommand.Parameters.AddWithValue("@notesId", updatedNotesNurse.notesId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // UpdateItem

        /// <summary>
        /// Given a list of NotesNurse objects, update their properties to the database
        /// by NotesNurse id.
        /// </summary>
        public void UpdateList()
        {
            foreach (var NotesNurse in ItemList)
            {
                UpdateItem(NotesNurse);
            }
        }

        /// <summary>
        /// Insert a single NotesNurse record into the database.
        /// </summary>
        public void WriteItem(NotesNurse newNotesNurse)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "INSERT INTO " + theTable +
                    "(notesId, notes, nurseId, patientId, caseId) " +
                    "VALUES (@notesId, @notes, @nurseId, @patientId, @caseId)";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@notes", newNotesNurse.notes);
                myCommand.Parameters.AddWithValue("@nurseId", newNotesNurse.nurseId);
                myCommand.Parameters.AddWithValue("@patientId", newNotesNurse.patientId);
                myCommand.Parameters.AddWithValue("@caseId", newNotesNurse.caseId);
                myCommand.Parameters.AddWithValue("@notesId", newNotesNurse.notesId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // WriteItem

        /// <summary>
        /// Insert a list of NotesNurse records into the database.
        /// </summary>
        public void WriteList()
        {
            foreach (var NotesNurse in ItemList)
            {
                WriteItem(NotesNurse);
            } // foreach
        } // writelist
    }
}
