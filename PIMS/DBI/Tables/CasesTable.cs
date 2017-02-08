using DBI.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DBI
{
    class CasesTable
    {
        public const string theTable = "cases";

        public List<Cases> ItemList { get; set; } = new List<Cases>();

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
        /// <param name="caseId"></param>
        public void ClearTableById(int caseId)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "DELETE FROM " + theTable +
                " WHERE" +
                " caseId = @caseId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@caseId", caseId);

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
                    int caseId = Convert.ToInt32(dr["caseId"]);
                    int supervisingDoctorId = Convert.ToInt32(dr["supervisingDoctorId"]);
                    int approvedVisitorCount = Convert.ToInt32(dr["approvedVisitorCount"]);
                    int patientId = Convert.ToInt32(dr["patientId"]);

                    // fill the ItemList
                    Cases cases = new Cases();
                    cases.caseId = caseId;
                    cases.supervisingDoctorId = supervisingDoctorId;
                    cases.approvedVisitorCount = approvedVisitorCount;
                    cases.patientId = patientId;

                    ItemList.Add(cases);
                } // for
            } // if
        }

        public void ReadListById(int inputCaseId)
        {
            ItemList.Clear();   // ensure that the itemlist is empty so we don't get duplicates

            string myQuery = "SELECT * FROM " + theTable + "WHERE caseId = " + "'" + inputCaseId + "'";
            DataSet dsObject = QueryExecutor.ExecuteSqlQuery(myQuery);

            if (dsObject != null && dsObject.Tables[0].Rows.Count > 0)
            {
                DataTable dtObject = dsObject.Tables[0];    // get the DataTable reference once

                foreach (DataRow dr in dtObject.Rows)
                {
                    // extract all fields of the current row
                    int caseId = Convert.ToInt32(dr["caseId"]);
                    int supervisingDoctorId = Convert.ToInt32(dr["supervisingDoctorId"]);
                    int approvedVisitorCount = Convert.ToInt32(dr["approvedVisitorCount"]);
                    int patientId = Convert.ToInt32(dr["patientId"]);

                    // fill the ItemList
                    Cases newCase = new Cases();
                    newCase.caseId = inputCaseId;
                    newCase.supervisingDoctorId = supervisingDoctorId;
                    newCase.approvedVisitorCount = approvedVisitorCount;
                    newCase.patientId = patientId;

                    ItemList.Add(newCase);
                } // for
            } // if
        }

        /// <summary>
        /// Given a single bill object, update the record corresponding to the object's bill id
        /// with and discrepancies in the bill object.
        /// </summary>
        /// <param name="cases"></param>
        public void UpdateItem(Cases cases)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "UPDATE " + theTable +
                    " SET " +
                    "supervisingDoctorId = @supervisingDoctorId, " +
                    "approvedVisitorCount = @approvedVisitorCount, " +
                    "patientId = @patientId " +
                    "WHERE " +
                    "caseId = @caseId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@caseId", cases.caseId);
                myCommand.Parameters.AddWithValue("@supervisingDoctorId", cases.supervisingDoctorId);
                myCommand.Parameters.AddWithValue("@approvedVisitorCount", cases.approvedVisitorCount);
                myCommand.Parameters.AddWithValue("@patientId", cases.patientId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // Update Item

        /// <summary>
        /// Given a list of bill objects, update their properties to the database by bill id.
        /// </summary>
        public void UpdateList()
        {
            foreach (var bill in ItemList)
            {
                UpdateItem(bill);
            }
        }

        public void WriteItem(Cases cases)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "INSERT INTO " + theTable +
                    " (caseId, supervisingDoctorId, approvedVisitorCount, patientId) " +
                    "VALUES (@caseId, @supervisingDoctorId, @approvedVisitorCount, @patientId)";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@caseId", cases.caseId);
                myCommand.Parameters.AddWithValue("@supervisingDoctorId", cases.supervisingDoctorId);
                myCommand.Parameters.AddWithValue("@approvedVisitorCount", cases.approvedVisitorCount);
                myCommand.Parameters.AddWithValue("@patientId", cases.patientId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        }

        public void WriteList()
        {
            foreach (var cases in ItemList)
            {
                WriteItem(cases);
            }
        }
    }
}
