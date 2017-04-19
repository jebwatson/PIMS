using DBI.Tables;
using DBI.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DBI
{
    public class ChargesTable
    {
        public const string theTable = "charges";

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
        /// Delete any records with the admissionId specified.
        /// </summary>
        /// <param name="chargeId"></param>
        public void ClearTableById(int chargeId)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "DELETE FROM " + theTable +
                    " WHERE " +
                    "chargeId = @chargeId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@chargeId", chargeId);

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
        /// as Admission objects.
        /// </summary>
        public List<Charges> ReadList()
        {
            List<Charges> charges = new List<Charges>();

            string myQuery = "SELECT * FROM " + theTable;
            DataSet dsObject = QueryExecutor.ExecuteSqlQuery(myQuery);

            if (dsObject != null && dsObject.Tables[0].Rows.Count > 0)
            {
                DataTable dtObject = dsObject.Tables[0];    // get the DataTable reference once

                foreach (DataRow dr in dtObject.Rows)
                {
                    // extract all fields of the current row
                    int chargeId = Convert.ToInt32(dr["chargeId"]);
                    string description = dr["description"].ToString();
                    string amountTotal = dr["amountTotal"].ToString();
                    DateTime dateCharged = Convert.ToDateTime(dr["dateCharged"]);
                    DateTime dateDue = Convert.ToDateTime(dr["dateDue"]);
                    int procedureId = Convert.ToInt32(dr["procedureId"]);
                    int officeStaffId = Convert.ToInt32(dr["officeStaffId"]);
                    int patientId = Convert.ToInt32(dr["patientId"]);

                    // fill the ItemList
                    Charges charge = new Charges();
                    charge.chargeId = chargeId;
                    charge.description = description;
                    charge.amountTotal = amountTotal;
                    charge.dateCharged = dateCharged;
                    charge.dateDue = dateDue;
                    charge.procedureId = procedureId;
                    charge.officeStaffId = officeStaffId;
                    charge.patientId = patientId;

                    charges.Add(charge);
                } // for
            } // if

            return charges;
        } // ReadList

        /// <summary>
        /// Read a sinlge record from the table and save the record in the
        /// ItemList as an admission object.
        /// </summary>
        public List<Charges> ReadListById(int inputChargeId)
        {
            List<Charges> charges = new List<Charges>();

            string myQuery = "SELECT * FROM " + theTable + " WHERE chargeId = " + "'" + inputChargeId + "'";

            DataSet dsObject = QueryExecutor.ExecuteSqlQuery(myQuery);

            if (dsObject != null && dsObject.Tables[0].Rows.Count > 0)
            {
                DataTable dtObject = dsObject.Tables[0];    // get the DataTable reference once

                foreach (DataRow dr in dtObject.Rows)
                {
                    // extract all fields of the current row
                    int chargeId = Convert.ToInt32(dr["chargeId"]);
                    string description = dr["description"].ToString();
                    string amountTotal = dr["amountTotal"].ToString();
                    DateTime dateCharged = Convert.ToDateTime(dr["dateCharged"]);
                    DateTime dateDue = Convert.ToDateTime(dr["dateDue"]);
                    int procedureId = Convert.ToInt32(dr["procedureId"]);
                    int officeStaffId = Convert.ToInt32(dr["officeStaffId"]);
                    int patientId = Convert.ToInt32(dr["patientId"]);

                    // fill the ItemList
                    Charges charge = new Charges();
                    charge.chargeId = chargeId;
                    charge.description = description;
                    charge.amountTotal = amountTotal;
                    charge.dateCharged = dateCharged;
                    charge.dateDue = dateDue;
                    charge.procedureId = procedureId;
                    charge.officeStaffId = officeStaffId;
                    charge.patientId = patientId;

                    charges.Add(charge);
                } // for
            } // if

            return charges;
        } // ReadList

        /// <summary>
        /// Given a single admission object, update the record correspnoding
        /// to the object's admission id with any discrepancies in the admission
        /// object.
        /// </summary>
        /// <param name="updatedCharge"></param>
        public void UpdateItem(Charges updatedCharge)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "UPDATE " + theTable +
                    " SET " +
                    "description = @description, " +
                    "amountTotal = @amountTotal, " +
                    "dateCharged = @dateCharged, " +
                    "dateDue = @dateDue, " +
                    "procedureId = @procedureId, " +
                    "officeStaffId = @officeStaffId, " +
                    "patientId = @patientId " +
                    "WHERE " +
                    "chargeId = @chargeId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@description", updatedCharge.description);
                myCommand.Parameters.AddWithValue("@amountTotal", updatedCharge.amountTotal);
                myCommand.Parameters.AddWithValue("@dateCharged", updatedCharge.dateCharged);
                myCommand.Parameters.AddWithValue("@dateDue", updatedCharge.dateDue);
                myCommand.Parameters.AddWithValue("@procedureId", updatedCharge.procedureId);
                myCommand.Parameters.AddWithValue("@officeStaffId", updatedCharge.officeStaffId);
                myCommand.Parameters.AddWithValue("@patientId", updatedCharge.patientId);
                myCommand.Parameters.AddWithValue("@chargeId", updatedCharge.chargeId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // UpdateItem

        /// <summary>
        /// Given a list of admission objects, update their properties to the database
        /// by admission id.
        /// </summary>
        public void UpdateList(List<Charges> charges)
        {
            foreach (var charge in charges)
            {
                UpdateItem(charge);
            }
        }

        /// <summary>
        /// Insert a single admission record into the database.
        /// </summary>
        public void WriteItem(Charges newCharge)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "INSERT INTO " + theTable +
                    " (description, amountTotal, dateCharged, " +
                    "dateDue, procedureId, officeStaffId, patientId)" +
                    "VALUES (@description, @amountTotal, @dateCharged, " +
                    "@dateDue, @procedureId, @officeStaffId, @patientId)";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@chargeId", newCharge.chargeId);
                myCommand.Parameters.AddWithValue("@description", newCharge.description);
                myCommand.Parameters.AddWithValue("@amountTotal", newCharge.amountTotal);
                myCommand.Parameters.AddWithValue("@dateCharged", newCharge.dateCharged);
                myCommand.Parameters.AddWithValue("@dateDue", newCharge.dateDue);
                myCommand.Parameters.AddWithValue("@procedureId", newCharge.procedureId);
                myCommand.Parameters.AddWithValue("@officeStaffId", newCharge.officeStaffId);
                myCommand.Parameters.AddWithValue("@patientId", newCharge.patientId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // WriteItem

        /// <summary>
        /// Insert a list of admission records into the database.
        /// </summary>
        public void WriteList(List<Charges> charges)
        {
            foreach (var charge in charges)
            {
                WriteItem(charge);
            } // foreach
        } // writelist
    }
}
