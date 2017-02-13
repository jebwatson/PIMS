using DBI.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DBI
{
    class NotesOfficeStaffTable
    {
        public const string theTable = "notesOfficeStaff";

        public List<NotesOfficeStaff> ItemList { get; set; } = new List<NotesOfficeStaff>();

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
        /// Delete any records with the NotesOfficeStaff specified.
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
        /// as NotesOfficeStaff objects.
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
                    int officeStaffId = Convert.ToInt32(dr["officeStaffId"]);
                    int patientId = Convert.ToInt32(dr["patientId"]);
                    int caseId = Convert.ToInt32(dr["caseId"]);

                    // fill the ItemList
                    NotesOfficeStaff newNotesOfficeStaff = new NotesOfficeStaff();
                    newNotesOfficeStaff.notesId = notesId;
                    newNotesOfficeStaff.notes = notes;
                    newNotesOfficeStaff.officeStaffId = officeStaffId;
                    newNotesOfficeStaff.patientId = patientId;
                    newNotesOfficeStaff.caseId = caseId;

                    ItemList.Add(newNotesOfficeStaff);
                } // for
            } // if
        } // ReadList

        /// <summary>
        /// Read a sinlge record from the table and save the record in the
        /// ItemList as a NotesOfficeStaff object.
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
                    int officeStaffId = Convert.ToInt32(dr["officeStaffId"]);
                    int patientId = Convert.ToInt32(dr["patientId"]);
                    int caseId = Convert.ToInt32(dr["caseId"]);

                    // fill the ItemList
                    NotesOfficeStaff newNotesOfficeStaff = new NotesOfficeStaff();
                    newNotesOfficeStaff.notesId = notesId;
                    newNotesOfficeStaff.notes = notes;
                    newNotesOfficeStaff.officeStaffId = officeStaffId;
                    newNotesOfficeStaff.patientId = patientId;
                    newNotesOfficeStaff.caseId = caseId;

                    ItemList.Add(newNotesOfficeStaff);
                } // for
            } // if
        } // ReadList

        /// <summary>
        /// Given a single NotesOfficeStaff object, update the record corresponding
        /// to the object's NotesOfficeStaff id with any discrepancies in the NotesOfficeStaff
        /// object.
        /// </summary>
        /// <param name="updatedNotesOfficeStaff"></param>
        public void UpdateItem(NotesOfficeStaff updatedNotesOfficeStaff)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "UPDATE " + theTable +
                    " SET " +
                    "notes = @notes, " +
                    "officeStaffId = @officeStaffId, " +
                    "patientId = @patientId, " +
                    "caseId = @caseId, " +
                    "WHERE " +
                    "notesId = @notesId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@notes", updatedNotesOfficeStaff.notes);
                myCommand.Parameters.AddWithValue("@officeStaffId", updatedNotesOfficeStaff.officeStaffId);
                myCommand.Parameters.AddWithValue("@patientId", updatedNotesOfficeStaff.patientId);
                myCommand.Parameters.AddWithValue("@caseId", updatedNotesOfficeStaff.caseId);
                myCommand.Parameters.AddWithValue("@notesId", updatedNotesOfficeStaff.notesId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // UpdateItem

        /// <summary>
        /// Given a list of NotesOfficeStaff objects, update their properties to the database
        /// by NotesOfficeStaf id.
        /// </summary>
        public void UpdateList()
        {
            foreach (var NotesOfficeStaff in ItemList)
            {
                UpdateItem(NotesOfficeStaff);
            }
        }

        /// <summary>
        /// Insert a single NotesOfficeStaff record into the database.
        /// </summary>
        public void WriteItem(NotesOfficeStaff newNotesOfficeStaff)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "INSERT INTO " + theTable +
                    "(notesId, notes, officeStaffId, patientId, caseId) " +
                    "VALUES (@notesId, @notes, @officeStaffId, @patientId, @caseId)";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@notes", newNotesOfficeStaff.notes);
                myCommand.Parameters.AddWithValue("@officeStaffId", newNotesOfficeStaff.officeStaffId);
                myCommand.Parameters.AddWithValue("@patientId", newNotesOfficeStaff.patientId);
                myCommand.Parameters.AddWithValue("@caseId", newNotesOfficeStaff.caseId);
                myCommand.Parameters.AddWithValue("@notesId", newNotesOfficeStaff.notesId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // WriteItem

        /// <summary>
        /// Insert a list of NotesOfficeStaff records into the database.
        /// </summary>
        public void WriteList()
        {
            foreach (var NotesOfficeStaff in ItemList)
            {
                WriteItem(NotesOfficeStaff);
            } // foreach
        } // writelist
    }
}
