﻿using DBI.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DBI
{
    public class NotesTable
    {
        public const string theTable = "notes";

        public List<Notes> ItemList { get; set; } = new List<Notes>();

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
                    bool doctor = Convert.ToBoolean(dr["doctor"]);
                    bool nurse = Convert.ToBoolean(dr["nurse"]);
                    int doctorId = Convert.ToInt32(dr["doctorId"]);
                    int patientId = Convert.ToInt32(dr["patientId"]);

                    // fill the ItemList
                    Notes newNotes = new Notes();
                    newNotes.notesId = notesId;
                    newNotes.notes = notes;
                    newNotes.doctor = doctor;
                    newNotes.nurse = nurse;
                    newNotes.userId = doctorId;
                    newNotes.patientId = patientId;

                    ItemList.Add(newNotes);
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
                    bool doctor = Convert.ToBoolean(dr["doctor"]);
                    bool nurse = Convert.ToBoolean(dr["nurse"]);
                    int doctorId = Convert.ToInt32(dr["doctorId"]);
                    int patientId = Convert.ToInt32(dr["patientId"]);

                    // fill the ItemList
                    Notes newNotes = new Notes();
                    newNotes.notesId = notesId;
                    newNotes.notes = notes;
                    newNotes.doctor = doctor;
                    newNotes.nurse = nurse;
                    newNotes.userId = doctorId;
                    newNotes.patientId = patientId;

                    ItemList.Add(newNotes);
                } // for
            } // if
        } // ReadList

        /// <summary>
        /// Given a single NotesDoctor object, update the record corresponding
        /// to the object's NotesDoctor id with any discrepancies in the NotesDoctor
        /// object.
        /// </summary>
        /// <param name="updatedNotes"></param>
        public void UpdateItem(Notes updatedNotes)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "UPDATE " + theTable +
                    " SET " +
                    "notes = @notes, " +
                    "doctor = @doctor, " +
                    "nurse = @nurse, " +
                    "doctorId = @doctorId, " +
                    "patientId = @patientId " +
                    "WHERE " +
                    "notesId = @notesId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@notes", updatedNotes.notes);
                myCommand.Parameters.AddWithValue("@doctor", updatedNotes.doctor);
                myCommand.Parameters.AddWithValue("@nurse", updatedNotes.nurse);
                myCommand.Parameters.AddWithValue("@doctorId", updatedNotes.userId);
                myCommand.Parameters.AddWithValue("@patientId", updatedNotes.patientId);
                myCommand.Parameters.AddWithValue("@notesId", updatedNotes.notesId);

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
        public void WriteItem(Notes newNotesDoctor)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "INSERT INTO " + theTable +
                    "(notes, doctor, nurse, doctorId, patientId) " +
                    "VALUES (@notes, @doctor, @nurse, @doctorId, @patientId)";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@notes", newNotesDoctor.notes);
                myCommand.Parameters.AddWithValue("@doctor", newNotesDoctor.doctor);
                myCommand.Parameters.AddWithValue("@nurse", newNotesDoctor.nurse);
                myCommand.Parameters.AddWithValue("@doctorId", newNotesDoctor.userId);
                myCommand.Parameters.AddWithValue("@patientId", newNotesDoctor.patientId);
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