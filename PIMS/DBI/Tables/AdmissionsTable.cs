using DBI.TableInterfaces;
using DBI.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DBI
{
    class AdmissionsTable : IAdmissionsTable
    {
        public const string theTable = "admissions";

        public List<Admission> ItemList { get; set; } = new List<Admission>();

        public void ClearTable()
        {
            if (CountRows() == 0)
                return;

            string myCommand = "DELETE FROM " + theTable;
            QueryExecutor.ExecuteSqlNonQuery(myCommand);
        }

        public void ClearTableById(int admissionId)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "DELETE FROM " + theTable +
                    " WHERE " +
                    "admissionId = @admissionId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@admissionId", admissionId);

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

        /// <summary>
        /// Read all records from the table and save them in the ItemList
        /// as Admission objects.
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
                    int admissionId = Convert.ToInt32(dr["admissionId"]);
                    DateTime admissionTime = Convert.ToDateTime(dr["admissionTime"]);
                    DateTime dischargeTime = Convert.ToDateTime(dr["dischargeTime"]);
                    string admissionReason = dr["admissionReason"].ToString();
                    string dischargeReason = dr["dischargeReason"].ToString();
                    string facilityNumber = dr["facilityNumber"].ToString();
                    string floorNumber = dr["floorNumber"].ToString();
                    string roomNumber = dr["roomNumber"].ToString();
                    string bedNumber = dr["bedNumber"].ToString();
                    int patientId = Convert.ToInt32(dr["patientId"]);
                    int caseId = Convert.ToInt32(dr["caseId"]);

                    // fill the ItemList
                    Admission newAdmission = new Admission();
                    newAdmission.admissionId = admissionId;
                    newAdmission.admissionTime = admissionTime;
                    newAdmission.dischargeTime = dischargeTime;
                    newAdmission.admissionReason = admissionReason;
                    newAdmission.dischargeReason = dischargeReason;
                    newAdmission.facilityNumber = facilityNumber;
                    newAdmission.floorNumber = floorNumber;
                    newAdmission.roomNumber = roomNumber;
                    newAdmission.bedNumber = bedNumber;
                    newAdmission.patientId = patientId;
                    newAdmission.caseId = caseId;

                    ItemList.Add(newAdmission);
                } // for
            } // if
        } // ReadList

        /// <summary>
        /// Read a sinlge record from the table and save the record in the
        /// ItemList as an admission object.
        /// </summary>
        public void ReadListById(int inputAdmissionId)
        {
            ItemList.Clear();   // ensure that the itemlist is empty so we don't get duplicates

            string myQuery = "SELECT * FROM " + theTable + " WHERE admissionId = " + "'" + inputAdmissionId + "'";

            DataSet dsObject = QueryExecutor.ExecuteSqlQuery(myQuery);

            if (dsObject != null && dsObject.Tables[0].Rows.Count > 0)
            {
                DataTable dtObject = dsObject.Tables[0];    // get the DataTable reference once

                foreach (DataRow dr in dtObject.Rows)
                {
                    // extract all fields of the current row
                    int admissionId = Convert.ToInt32(dr["admissionId"]);
                    DateTime admissionTime = Convert.ToDateTime(dr["admissionTime"]);
                    DateTime dischargeTime = Convert.ToDateTime(dr["dischargeTime"]);
                    string admissionReason = dr["admissionReason"].ToString();
                    string dischargeReason = dr["dischargeReason"].ToString();
                    string facilityNumber = dr["facilityNumber"].ToString();
                    string floorNumber = dr["floorNumber"].ToString();
                    string roomNumber = dr["roomNumber"].ToString();
                    string bedNumber = dr["bedNumber"].ToString();
                    int patientId = Convert.ToInt32(dr["patientId"]);
                    int caseId = Convert.ToInt32(dr["caseId"]);

                    // fill the ItemList
                    Admission newAdmission = new Admission();
                    newAdmission.admissionId = admissionId;
                    newAdmission.admissionTime = admissionTime;
                    newAdmission.dischargeTime = dischargeTime;
                    newAdmission.admissionReason = admissionReason;
                    newAdmission.dischargeReason = dischargeReason;
                    newAdmission.facilityNumber = facilityNumber;
                    newAdmission.floorNumber = floorNumber;
                    newAdmission.roomNumber = roomNumber;
                    newAdmission.bedNumber = bedNumber;
                    newAdmission.patientId = patientId;
                    newAdmission.caseId = caseId;

                    ItemList.Add(newAdmission);
                } // for
            } // if
        } // ReadList

        /// <summary>
        /// Given a single admission object, update the record correspnoding
        /// to the object's admission id with any discrepancies in the admission
        /// object.
        /// </summary>
        /// <param name="updatedAdmission"></param>
        public void UpdateItem(Admission updatedAdmission)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "UPDATE " + theTable +
                    " SET " +
                    "admissionTime = @admissionTime, " +
                    "dischargeTime = @dischargeTime, " +
                    "admissionReason = @admissionReason, " +
                    "dischargeReason = @dischargeReason, " +
                    "facilityNumber = @facilityNumber, " +
                    "floorNumber = @floorNumber, " +
                    "roomNumber = @roomNumber, " +
                    "bedNumber = @bedNumber, " +
                    "patientId = @patientId, " +
                    "caseId = @caseId " +
                    "WHERE " +
                    "admissionId = @admissionId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@admissionTime", updatedAdmission.admissionTime);
                myCommand.Parameters.AddWithValue("@dischargeTime", updatedAdmission.dischargeTime);
                myCommand.Parameters.AddWithValue("@admissionReason", updatedAdmission.admissionReason);
                myCommand.Parameters.AddWithValue("@dischargeReason", updatedAdmission.dischargeReason);
                myCommand.Parameters.AddWithValue("@facilityNumber", updatedAdmission.facilityNumber);
                myCommand.Parameters.AddWithValue("@floorNumber", updatedAdmission.floorNumber);
                myCommand.Parameters.AddWithValue("@roomNumber", updatedAdmission.roomNumber);
                myCommand.Parameters.AddWithValue("@bedNumber", updatedAdmission.bedNumber);
                myCommand.Parameters.AddWithValue("@patientId", updatedAdmission.patientId);
                myCommand.Parameters.AddWithValue("@caseId", updatedAdmission.caseId);
                myCommand.Parameters.AddWithValue("@admissionId", updatedAdmission.admissionId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // UpdateItem

        /// <summary>
        /// Given a list of admission objects, update their properties to the database
        /// by admission id.
        /// </summary>
        public void UpdateList()
        {
            foreach (var admission in ItemList)
            {
                UpdateItem(admission);
            }
        }

        /// <summary>
        /// Insert a single admission record into the database.
        /// </summary>
        public void WriteItem(Admission newAdmission)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "INSERT INTO " + theTable +
                    " (admissionId, admissionTime, dischargeTime, admissionReason, dischargeReason, " +
                    "facilityNumber, floorNumber, roomNumber, bedNumber, patientId, caseId)" +
                    "VALUES (@admissionId, @admissionTime, @dischargeTime, @admissionReason, @dischargeReason, " +
                    "@facilityNumber, @floorNumber, @roomNumber, @bedNumber, @patientId, @caseId)";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@admissionId", newAdmission.admissionId);
                myCommand.Parameters.AddWithValue("@admissionTime", newAdmission.admissionTime);
                myCommand.Parameters.AddWithValue("@dischargeTime", newAdmission.dischargeTime);
                myCommand.Parameters.AddWithValue("@admissionReason", newAdmission.admissionReason);
                myCommand.Parameters.AddWithValue("@dischargeReason", newAdmission.dischargeReason);
                myCommand.Parameters.AddWithValue("@facilityNumber", newAdmission.facilityNumber);
                myCommand.Parameters.AddWithValue("@floorNumber", newAdmission.floorNumber);
                myCommand.Parameters.AddWithValue("@roomNumber", newAdmission.roomNumber);
                myCommand.Parameters.AddWithValue("@bedNumber", newAdmission.bedNumber);
                myCommand.Parameters.AddWithValue("@patientId", newAdmission.patientId);
                myCommand.Parameters.AddWithValue("@caseId", newAdmission.caseId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // WriteItem


        /// <summary>
        /// Insert a list of admission records into the database.
        /// </summary>
        public void WriteList()
        {
            foreach (var admission in ItemList)
            {
                WriteItem(admission);
            } // foreach
        } // writelist
    }
}
