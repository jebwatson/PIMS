using DBI.Tables;
using DBI.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DBI
{
    public class InsuranceTable : IRepository<Insurance, int>
    {
        public const string theTable = "insurance";

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
        /// Delete any records with the insuranceId specified.
        /// </summary>
        /// <param name="insuranceId"></param>
        public void ClearTableById(int insuranceId)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "DELETE FROM " + theTable +
                    " WHERE " +
                    "insuranceId = @insuranceId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@insuranceId", insuranceId);

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
        /// as insurance objects.
        /// </summary>
        public List<Insurance> ReadList()
        {
            List<Insurance> insurances = new List<Insurance>();

            string myQuery = "SELECT * FROM " + theTable;
            DataSet dsObject = QueryExecutor.ExecuteSqlQuery(myQuery);

            if (dsObject != null && dsObject.Tables[0].Rows.Count > 0)
            {
                DataTable dtObject = dsObject.Tables[0];    // get the DataTable reference once

                foreach (DataRow dr in dtObject.Rows)
                {
                    // extract all fields of the current row
                    int insuranceId = Convert.ToInt32(dr["insuranceId"]);
                    string insuranceCarrier = dr["insuranceCarrier"].ToString();
                    string accountNumber = dr["accountNumber"].ToString();
                    string groupNumber = dr["groupNumber"].ToString();
                    int patientId = Convert.ToInt32(dr["patientId"]);

                    // fill the ItemList
                    Insurance newinsurance = new Insurance();
                    newinsurance.insuranceId = insuranceId;
                    newinsurance.insuranceCarrier = insuranceCarrier;
                    newinsurance.accountNumber = accountNumber;
                    newinsurance.groupNumber = groupNumber;
                    newinsurance.patientId = patientId;

                    insurances.Add(newinsurance);
                } // for
            } // if

            return insurances;
        } // ReadList

        /// <summary>
        /// Read a sinlge record from the table and save the record in the
        /// ItemList as an insurance object.
        /// </summary>
        public List<Insurance> ReadListById(int inputinsuranceId)
        {
            List<Insurance> insurances = new List<Insurance>();

            string myQuery = "SELECT * FROM " + theTable + " WHERE insuranceId = " + "'" + inputinsuranceId + "'";

            DataSet dsObject = QueryExecutor.ExecuteSqlQuery(myQuery);

            if (dsObject != null && dsObject.Tables[0].Rows.Count > 0)
            {
                DataTable dtObject = dsObject.Tables[0];    // get the DataTable reference once

                foreach (DataRow dr in dtObject.Rows)
                {
                    // extract all fields of the current row
                    int insuranceId = Convert.ToInt32(dr["insuranceId"]);
                    string insuranceCarrier = dr["insuranceCarrier"].ToString();
                    string accountNumber = dr["accountNumber"].ToString();
                    string groupNumber = dr["groupNumber"].ToString();
                    int patientId = Convert.ToInt32(dr["patientId"]);

                    // fill the ItemList
                    Insurance newinsurance = new Insurance();
                    newinsurance.insuranceId = insuranceId;
                    newinsurance.insuranceCarrier = insuranceCarrier;
                    newinsurance.accountNumber = accountNumber;
                    newinsurance.groupNumber = groupNumber;
                    newinsurance.patientId = patientId;

                    insurances.Add(newinsurance);
                } // for
            } // if

            return insurances;
        } // ReadList

        /// <summary>
        /// Given a single insurance object, update the record correspnoding
        /// to the object's insurance id with any discrepancies in the insurance
        /// object.
        /// </summary>
        /// <param name="updatedinsurance"></param>
        public void UpdateItem(Insurance updatedinsurance)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "UPDATE " + theTable +
                    " SET " +
                    "insuranceCarrier = @insuranceCarrier, " +
                    "accountNumber = @accountNumber, " +
                    "groupNumber = @groupNumber, " +
                    "patientId = @patientId " +
                    "WHERE " +
                    "insuranceId = @insuranceId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@insuranceCarrier", updatedinsurance.insuranceCarrier);
                myCommand.Parameters.AddWithValue("@accountNumber", updatedinsurance.accountNumber);
                myCommand.Parameters.AddWithValue("@groupNumber", updatedinsurance.groupNumber);
                myCommand.Parameters.AddWithValue("@patientId", updatedinsurance.patientId);
                myCommand.Parameters.AddWithValue("@insuranceId", updatedinsurance.insuranceId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // UpdateItem

        /// <summary>
        /// Given a list of insurance objects, update their properties to the database
        /// by insurance id.
        /// </summary>
        public void UpdateList(List<Insurance> insurances)
        {
            foreach (var insurance in insurances)
            {
                UpdateItem(insurance);
            }
        }

        /// <summary>
        /// Insert a single insurance record into the database.
        /// </summary>
        public void WriteItem(Insurance newInsurance)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "INSERT INTO " + theTable +
                    "(insuranceId, insuranceCarrier, accountNumber, groupNumber, patientId) " +
                    "VALUES (@insuranceId, @insuranceCarrier, @accountNumber, @groupNumber, @patientId)";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@insuranceId", newInsurance.insuranceId);
                myCommand.Parameters.AddWithValue("@insuranceCarrier", newInsurance.insuranceCarrier);
                myCommand.Parameters.AddWithValue("@accountNumber", newInsurance.accountNumber);
                myCommand.Parameters.AddWithValue("@groupNumber", newInsurance.groupNumber);
                myCommand.Parameters.AddWithValue("@patientId", newInsurance.patientId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // WriteItem

        /// <summary>
        /// Insert a list of insurance records into the database.
        /// </summary>
        public void WriteList(List<Insurance> insurances)
        {
            foreach (var insurance in insurances)
            {
                WriteItem(insurance);
            } // foreach
        } // writelist
    }
}
