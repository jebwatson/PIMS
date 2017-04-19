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
                    string amountTotal = dr["amountTotal"].ToString();
                    string amountPaidByPatient = dr["amountPaidByPatient"].ToString();
                    string amountPaidByInsurance = dr["amountPaidByInsurance"].ToString();
                    string amountOwed = dr["amountOwed"].ToString();
                    DateTime dateCharged = Convert.ToDateTime(dr["dateCharged"]);
                    DateTime dateDue = Convert.ToDateTime(dr["dateDue"]);
                    int patientId = Convert.ToInt32(dr["patientId"]);

                    // fill the ItemList
                    Bills newBill = new Bills();
                    newBill.billId = billId;
                    newBill.amountTotal = amountTotal;
                    newBill.amountPaidByPatient = amountPaidByPatient;
                    newBill.amountPaidByInsurance = amountPaidByInsurance;
                    newBill.amountOwed = amountOwed;
                    newBill.dateCharged = dateCharged;
                    newBill.dateDue = dateDue;
                    newBill.patientId = patientId;

                    bills.Add(newBill);
                } // for
            } // if

            return bills;
        }

        public List<Bills> ReadListById(int inputBillId)
        {
            List<Bills> bills = new List<Bills>();

            string myQuery = "SELECT * FROM " + theTable + " WHERE billId = " + "'" + inputBillId + "'";
            DataSet dsObject = QueryExecutor.ExecuteSqlQuery(myQuery);

            if (dsObject != null && dsObject.Tables[0].Rows.Count > 0)
            {
                DataTable dtObject = dsObject.Tables[0];    // get the DataTable reference once

                foreach (DataRow dr in dtObject.Rows)
                {
                    // extract all fields of the current row
                    int billId = Convert.ToInt32(dr["billId"]);
                    string amountTotal = dr["amountTotal"].ToString();
                    string amountPaidByPatient = dr["amountPaidByPatient"].ToString();
                    string amountPaidByInsurance = dr["amountPaidByInsurance"].ToString();
                    string amountOwed = dr["amountOwed"].ToString();
                    DateTime dateCharged = Convert.ToDateTime(dr["dateCharged"]);
                    DateTime dateDue = Convert.ToDateTime(dr["dateDue"]);
                    int patientId = Convert.ToInt32(dr["patientId"]);

                    // fill the ItemList
                    Bills newBill = new Bills();
                    newBill.billId = inputBillId;
                    newBill.amountTotal = amountTotal;
                    newBill.amountPaidByPatient = amountPaidByPatient;
                    newBill.amountPaidByInsurance = amountPaidByInsurance;
                    newBill.amountOwed = amountOwed;
                    newBill.dateCharged = dateCharged;
                    newBill.dateDue = dateDue;
                    newBill.patientId = patientId;

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
                    "amountTotal = @amountTotal, " +
                    "amountPaidByPatient = @amountPaidByPatient, " +
                    "amountPaidByInsurance = @amountPaidByInsurance, " +
                    "amountOwed = @amountOwed, " +
                    "dateCharged = @dateCharged, " +
                    "dateDue = @dateDue, " +
                    "patientId = @patientId " +
                    "WHERE " +
                    "billId = @billId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@billId", bill.billId);
                myCommand.Parameters.AddWithValue("@amountTotal", bill.amountTotal);
                myCommand.Parameters.AddWithValue("@amountPaidByPatient", bill.amountPaidByPatient);
                myCommand.Parameters.AddWithValue("@amountPaidByInsurance", bill.amountPaidByInsurance);
                myCommand.Parameters.AddWithValue("@amountOwed", bill.amountOwed);
                myCommand.Parameters.AddWithValue("@dateCharged", bill.dateCharged);
                myCommand.Parameters.AddWithValue("@dateDue", bill.dateDue);
                myCommand.Parameters.AddWithValue("@patientId", bill.patientId);

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
                    " (amountTotal, amountPaidByPatient, " +
                    "amountPaidByInsurance, amountOwed, dateCharged, dateDue, " +
                    "patientId) " +
                    "VALUES (@amountTotal, @amountPaidByPatient, " +
                    "@amountPaidByInsurance, @amountOwed, @dateCharged, @dateDue, " +
                    "@patientId)";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@billId", bill.billId);
                myCommand.Parameters.AddWithValue("@amountTotal", bill.amountTotal);
                myCommand.Parameters.AddWithValue("@amountPaidByPatient", bill.amountPaidByPatient);
                myCommand.Parameters.AddWithValue("@amountPaidByInsurance", bill.amountPaidByInsurance);
                myCommand.Parameters.AddWithValue("@amountOwed", bill.amountOwed);
                myCommand.Parameters.AddWithValue("@dateCharged", bill.dateCharged);
                myCommand.Parameters.AddWithValue("@dateDue", bill.dateDue);
                myCommand.Parameters.AddWithValue("@patientId", bill.patientId);

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
