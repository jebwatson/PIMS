using DBI.Tables;
using DBI.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DBI
{
    public class BillsTable
    {
        public const string theTable = "bills";

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
        /// Clear the table of any bills matching the specified billId.
        /// </summary>
        /// <param name="billId"></param>
        public void ClearTableById(int billId)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "DELETE FROM " + theTable +
                " WHERE" +
                " billId = @billId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@billId", billId);

                myCommand.ExecuteNonQuery();
                myConnection.Close();
            }
        }

        /// <summary>
        /// Get a count of all the records in the table.
        /// </summary>
        /// <returns></returns>
        public int CountRows()
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "SELECT COUNT(*) FROM " + theTable;
                return QueryExecutor.ExecuteSqlQueryScalar(myQuery, myConnection);
            } // using
        } // count rows

        public List<Bills> ReadList()
        {
            List<Bills> bills = new List<Bills>();

            string myQuery = "SELECT * FROM " + theTable;
            DataSet dsObject = QueryExecutor.ExecuteSqlQuery(myQuery);

            if (dsObject != null && dsObject.Tables[0].Rows.Count > 0)
            {
                DataTable dtObject = dsObject.Tables[0];    // get the DataTable reference once

                foreach (DataRow dr in dtObject.Rows)
                {
                    // extract all fields of the current row
                    int billId = Convert.ToInt32(dr["billId"]);
                    int amountTotalDollars = Convert.ToInt32(dr["amountTotalDollars"]);
                    int amountTotalCents = Convert.ToInt32(dr["amountTotalCents"]);
                    int amountPaidByPatientDollars = Convert.ToInt32(dr["amountPaidByPatientDollars"]);
                    int amountPaidByPatientCents = Convert.ToInt32(dr["amountPaidByPatientCents"]);
                    int amountPaidByInsuranceDollars = Convert.ToInt32(dr["amountPaidByInsuranceDollars"]);
                    int amountPaidByInsuranceCents = Convert.ToInt32(dr["amountPaidByInsuranceCents"]);
                    int amountOwedDollars = Convert.ToInt32(dr["amountOwedDollars"]);
                    int amountOwedCents = Convert.ToInt32(dr["amountOwedCents"]);
                    DateTime dateCharged = Convert.ToDateTime(dr["dateCharged"]);
                    DateTime dateDue = Convert.ToDateTime(dr["dateDue"]);
                    int patientId = Convert.ToInt32(dr["patientId"]);
                    int caseId = Convert.ToInt32(dr["caseId"]);

                    // fill the ItemList
                    Bills newBill = new Bills();
                    newBill.billId = billId;
                    newBill.amountTotalDollars= amountTotalDollars;
                    newBill.amountTotalCents = amountTotalCents;
                    newBill.amountPaidByPatientDollars = amountPaidByPatientDollars;
                    newBill.amountPaidByPatientCents = amountPaidByPatientCents;
                    newBill.amountPaidByInsuranceDollars = amountPaidByInsuranceDollars;
                    newBill.amountPaidByInsuranceCents = amountPaidByInsuranceCents;
                    newBill.amountOwedDollars = amountOwedDollars;
                    newBill.amountOwedCents = amountOwedCents;
                    newBill.dateCharged = dateCharged;
                    newBill.dateDue = dateDue;
                    newBill.patientId = patientId;
                    newBill.caseId = caseId;

                    bills.Add(newBill);
                } // for
            } // if

            return bills;
        }

        public List<Bills> ReadListById(int inputBillId)
        {
            List<Bills> bills = new List<Bills>();

            string myQuery = "SELECT * FROM " + theTable + "WHERE billId = " + "'" + inputBillId + "'";
            DataSet dsObject = QueryExecutor.ExecuteSqlQuery(myQuery);

            if (dsObject != null && dsObject.Tables[0].Rows.Count > 0)
            {
                DataTable dtObject = dsObject.Tables[0];    // get the DataTable reference once

                foreach (DataRow dr in dtObject.Rows)
                {
                    // extract all fields of the current row
                    int billId = Convert.ToInt32(dr["billId"]);
                    int amountTotalDollars = Convert.ToInt32(dr["amountTotalDollars"]);
                    int amountTotalCents = Convert.ToInt32(dr["amountTotalCents"]);
                    int amountPaidByPatientDollars = Convert.ToInt32(dr["amountPaidByPatientDollars"]);
                    int amountPaidByPatientCents = Convert.ToInt32(dr["amountPaidByPatientCents"]);
                    int amountPaidByInsuranceDollars = Convert.ToInt32(dr["amountPaidByInsuranceDollars"]);
                    int amountPaidByInsuranceCents = Convert.ToInt32(dr["amountPaidByInsuranceCents"]);
                    int amountOwedDollars = Convert.ToInt32(dr["amountOwedDollars"]);
                    int amountOwedCents = Convert.ToInt32(dr["amountOwedCents"]);
                    DateTime dateCharged = Convert.ToDateTime(dr["dateCharged"]);
                    DateTime dateDue = Convert.ToDateTime(dr["dateDue"]);
                    int patientId = Convert.ToInt32(dr["patientId"]);
                    int caseId = Convert.ToInt32(dr["caseId"]);

                    // fill the ItemList
                    Bills newBill = new Bills();
                    newBill.billId = inputBillId;
                    newBill.amountTotalDollars = amountTotalDollars;
                    newBill.amountTotalCents = amountTotalCents;
                    newBill.amountPaidByPatientDollars = amountPaidByPatientDollars;
                    newBill.amountPaidByPatientCents = amountPaidByPatientCents;
                    newBill.amountPaidByInsuranceDollars = amountPaidByInsuranceDollars;
                    newBill.amountPaidByInsuranceCents = amountPaidByInsuranceCents;
                    newBill.amountOwedDollars = amountOwedDollars;
                    newBill.amountOwedCents = amountOwedCents;
                    newBill.dateCharged = dateCharged;
                    newBill.dateDue = dateDue;
                    newBill.patientId = patientId;
                    newBill.caseId = caseId;

                    bills.Add(newBill);
                } // for
            } // if

            return bills;
        }

        /// <summary>
        /// Given a single bill object, update the record corresponding to the object's bill id
        /// with and discrepancies in the bill object.
        /// </summary>
        /// <param name="bill"></param>
        public void UpdateItem(Bills bill)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "UPDATE " + theTable +
                    " SET " +
                    "amountTotalDollars = @amountTotalDollars, " +
                    "amountTotalCents = @amountTotalCents, " +
                    "amountPaidByPatientDollars = @amountPaidByPatientDollars, " +
                    "amountPaidByPatientCents = @amountPaidByPatientCents, " +
                    "amountPaidByInsuranceDollars = @amountPaidByInsuranceDollars, " +
                    "amountPaidByInsuranceCents = @amountPaidByInsuranceCents, " +
                    "amountOwedDollars = @amountOwedDollars, " +
                    "amountOwedCents = @amountOwedCents, " +
                    "dateCharged = @dateCharged, " +
                    "dateDue = @dateDue, " +
                    "patientId = @patientId, " +
                    "caseId = @caseId " +
                    "WHERE " +
                    "billId = @billId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@billId", bill.billId);
                myCommand.Parameters.AddWithValue("@amountTotalDollars", bill.amountTotalDollars);
                myCommand.Parameters.AddWithValue("@amountTotalCents", bill.amountTotalCents);
                myCommand.Parameters.AddWithValue("@amountPaidByPatientDollars", bill.amountPaidByPatientDollars);
                myCommand.Parameters.AddWithValue("@amountPaidByPatientCents", bill.amountPaidByPatientCents);
                myCommand.Parameters.AddWithValue("@amountPaidByInsuranceDollars", bill.amountPaidByInsuranceDollars);
                myCommand.Parameters.AddWithValue("@amountPaidByInsuranceCents", bill.amountPaidByInsuranceCents);
                myCommand.Parameters.AddWithValue("@amountOwedDollars", bill.amountOwedDollars);
                myCommand.Parameters.AddWithValue("@amountOwedCents", bill.amountOwedCents);
                myCommand.Parameters.AddWithValue("@dateCharged", bill.dateCharged);
                myCommand.Parameters.AddWithValue("@dateDue", bill.dateDue);
                myCommand.Parameters.AddWithValue("@patientId", bill.patientId);
                myCommand.Parameters.AddWithValue("@caseId", bill.caseId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // Update Item

        /// <summary>
        /// Given a list of bill objects, update their properties to the database by bill id.
        /// </summary>
        public void UpdateList(List<Bills> bills)
        {
            foreach (var bill in bills)
            {
                UpdateItem(bill);
            }
        }

        public void WriteItem(Bills bill)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "INSERT INTO " + theTable +
                    " (billId, amountTotalDollars, amountTotalCents, amountPaidByPatientDollars, amountPaidByPatientCents, " +
                    "amountPaidByInsuranceDollars, amountPaidByInsuranceCents, amountOwedDollars, amountOwedCents, dateCharged, dateDue, " +
                    "patientId, caseId) " +
                    "VALUES (@billId, @amountTotalDollars, @amountTotalCents, @amountPaidByPatientDollars, @amountPaidByPatientCents, " +
                    "@amountPaidByInsuranceDollars, @amountPaidByInsuranceCents, @amountOwedDollars, @amountOwedCents, @dateCharged, @dateDue, " +
                    "@patientId, @caseId)";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@billId", bill.billId);
                myCommand.Parameters.AddWithValue("@amountTotalDollars", bill.amountTotalDollars);
                myCommand.Parameters.AddWithValue("@amountTotalCents", bill.amountTotalCents);
                myCommand.Parameters.AddWithValue("@amountPaidByPatientDollars", bill.amountPaidByPatientDollars);
                myCommand.Parameters.AddWithValue("@amountPaidByPatientCents", bill.amountPaidByPatientCents);
                myCommand.Parameters.AddWithValue("@amountPaidByInsuranceDollars", bill.amountPaidByInsuranceDollars);
                myCommand.Parameters.AddWithValue("@amountPaidByInsuranceCents", bill.amountPaidByInsuranceCents);
                myCommand.Parameters.AddWithValue("@amountOwedDollars", bill.amountOwedDollars);
                myCommand.Parameters.AddWithValue("@amountOwedCents", bill.amountOwedCents);
                myCommand.Parameters.AddWithValue("@dateCharged", bill.dateCharged);
                myCommand.Parameters.AddWithValue("@dateDue", bill.dateDue);
                myCommand.Parameters.AddWithValue("@patientId", bill.patientId);
                myCommand.Parameters.AddWithValue("@caseId", bill.caseId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        }

        public void WriteList(List<Bills> bills)
        {
            foreach (var bill in bills)
            {
                WriteItem(bill);
            }
        }
    }
}
