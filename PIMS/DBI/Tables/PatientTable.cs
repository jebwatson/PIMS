using DBI.Tables;
using DBI.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DBI
{
    public class PatientTable
    {
        public const string theTable = "patients";

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
        /// Delete any records with the patientId specified.
        /// </summary>
        /// <param name="patientId"></param>
        public void ClearTableById(int patientId)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "DELETE FROM " + theTable +
                    " WHERE " +
                    "patientId = @patientId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@patientId", patientId);

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
        /// as Patient objects.
        /// </summary>
        public List<Patient> ReadList()
        {
            List<Patient> patients = new List<Patient>();

            string myQuery = "SELECT * FROM " + theTable;
            DataSet dsObject = QueryExecutor.ExecuteSqlQuery(myQuery);

            if (dsObject != null && dsObject.Tables[0].Rows.Count > 0)
            {
                DataTable dtObject = dsObject.Tables[0];    // get the DataTable reference once

                foreach (DataRow dr in dtObject.Rows)
                {
                    // extract all fields of the current row
                    int patientId = Convert.ToInt32(dr["patientId"]);
                    string nameLast = dr["nameLast"].ToString();
                    string nameFirst = dr["nameFirst"].ToString();
                    string nameMiddle = dr["nameMiddle"].ToString();
                    string street = dr["street"].ToString();
                    string city = dr["city"].ToString();
                    string state = dr["state"].ToString();
                    string zip = dr["zip"].ToString();
                    string phoneHome = dr["phoneHome"].ToString();
                    string areaCodeHome = dr["areaCodeHome"].ToString();
                    string phoneWork = dr["phoneWork"].ToString();
                    string areaCodeWork = dr["areaCodeWork"].ToString();
                    string phoneMobile = dr["phoneMobile"].ToString();
                    string areaCodeMobile = dr["areaCodeMobile"].ToString();
                    string familyDoctor = dr["familyDoctor"].ToString();

                    // fill the ItemList
                    Patient newPatient = new Patient();
                    newPatient.patientId = patientId;
                    newPatient.nameLast = nameLast;
                    newPatient.nameFirst = nameFirst;
                    newPatient.nameMiddle = nameMiddle;
                    newPatient.street = street;
                    newPatient.city = city;
                    newPatient.state = state;
                    newPatient.zip = zip;
                    newPatient.phoneHome = phoneHome;
                    newPatient.areaCodeHome = areaCodeHome;
                    newPatient.phoneWork = phoneWork;
                    newPatient.areaCodeWork = areaCodeWork;
                    newPatient.phoneMobile = phoneMobile;
                    newPatient.areaCodeMobile = areaCodeMobile;
                    newPatient.familyDoctor = familyDoctor;

                    patients.Add(newPatient);
                } // for
            } // if

            return patients;
        } // ReadList

        /// <summary>
        /// Read a sinlge record from the table and save the record in the
        /// ItemList as an Patient object.
        /// </summary>
        public List<Patient> ReadListById(int inputPatientId)
        {
            List<Patient> patients = new List<Patient>();

            string myQuery = "SELECT * FROM " + theTable + " WHERE patientId = " + "'" + inputPatientId + "'";

            DataSet dsObject = QueryExecutor.ExecuteSqlQuery(myQuery);

            if (dsObject != null && dsObject.Tables[0].Rows.Count > 0)
            {
                DataTable dtObject = dsObject.Tables[0];    // get the DataTable reference once

                foreach (DataRow dr in dtObject.Rows)
                {
                    // extract all fields of the current row
                    int patientId = Convert.ToInt32(dr["patientId"]);
                    string nameLast = dr["nameLast"].ToString();
                    string nameFirst = dr["nameFirst"].ToString();
                    string nameMiddle = dr["nameMiddle"].ToString();
                    string street = dr["street"].ToString();
                    string city = dr["city"].ToString();
                    string state = dr["state"].ToString();
                    string zip = dr["zip"].ToString();
                    string phoneHome = dr["phoneHome"].ToString();
                    string areaCodeHome = dr["areaCodeHome"].ToString();
                    string phoneWork = dr["phoneWork"].ToString();
                    string areaCodeWork = dr["areaCodeWork"].ToString();
                    string phoneMobile = dr["phoneMobile"].ToString();
                    string areaCodeMobile = dr["areaCodeMobile"].ToString();
                    string familyDoctor = dr["familyDoctor"].ToString();

                    // fill the ItemList
                    Patient newPatient = new Patient();
                    newPatient.patientId = patientId;
                    newPatient.nameLast = nameLast;
                    newPatient.nameFirst = nameFirst;
                    newPatient.nameMiddle = nameMiddle;
                    newPatient.street = street;
                    newPatient.city = city;
                    newPatient.state = state;
                    newPatient.zip = zip;
                    newPatient.phoneHome = phoneHome;
                    newPatient.areaCodeHome = areaCodeHome;
                    newPatient.phoneWork = phoneWork;
                    newPatient.areaCodeWork = areaCodeWork;
                    newPatient.phoneMobile = phoneMobile;
                    newPatient.areaCodeMobile = areaCodeMobile;
                    newPatient.familyDoctor = familyDoctor;

                    patients.Add(newPatient);
                } // for
            } // if

            return patients;
        } // ReadList

        /// <summary>
        /// Given a single Patient object, update the record correspnoding
        /// to the object's Patient id with any discrepancies in the Patient
        /// object.
        /// </summary>
        /// <param name="updatedPatient"></param>
        public void UpdateItem(Patient updatedPatient)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "UPDATE " + theTable +
                    " SET " +
                    "nameLast = @nameLast, " +
                    "nameFirst = @nameFirst, " +
                    "nameMiddle = @nameMiddle, " +
                    "street = @street, " +
                    "city = @city, " +
                    "state = @state, " +
                    "zip = @zip, " +
                    "phoneHome = @phoneHome, " +
                    "areaCodeHome = @areaCodeHome, " +
                    "phoneWork = @phoneWork, " +
                    "areaCodeWork = @areaCodeWork, " +
                    "phoneMobile = @phoneMobile, " +
                    "areaCodeMobile = @areaCodeMobile, " +
                    "familyDoctor = @familyDoctor " +
                    "WHERE " +
                    "patientId = @patientId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@nameLast", updatedPatient.nameLast);
                myCommand.Parameters.AddWithValue("@nameFirst", updatedPatient.nameFirst);
                myCommand.Parameters.AddWithValue("@nameMiddle", updatedPatient.nameMiddle);
                myCommand.Parameters.AddWithValue("@street", updatedPatient.street);
                myCommand.Parameters.AddWithValue("@city", updatedPatient.city);
                myCommand.Parameters.AddWithValue("@state", updatedPatient.state);
                myCommand.Parameters.AddWithValue("@zip", updatedPatient.zip);
                myCommand.Parameters.AddWithValue("@phoneHome", updatedPatient.phoneHome);
                myCommand.Parameters.AddWithValue("@areaCodeHome", updatedPatient.areaCodeHome);
                myCommand.Parameters.AddWithValue("@phoneWork", updatedPatient.phoneWork);
                myCommand.Parameters.AddWithValue("@areaCodeWork", updatedPatient.areaCodeWork);
                myCommand.Parameters.AddWithValue("@phoneMobile", updatedPatient.phoneMobile);
                myCommand.Parameters.AddWithValue("@areaCodeMobile", updatedPatient.areaCodeMobile);
                myCommand.Parameters.AddWithValue("@familyDoctor", updatedPatient.familyDoctor);
                myCommand.Parameters.AddWithValue("@patientId", updatedPatient.patientId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // UpdateItem

        /// <summary>
        /// Given a list of Patient objects, update their properties to the database
        /// by Patient id.
        /// </summary>
        public void UpdateList(List<Patient> patients)
        {
            foreach (var Patient in patients)
            {
                UpdateItem(Patient);
            }
        }

        /// <summary>
        /// Insert a single Patient record into the database.
        /// </summary>
        public void WriteItem(Patient newPatient)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "INSERT INTO patients (patientId, nameLast, nameFirst, nameMiddle, street, city, state, zip, " +
                    "phoneHome, areaCodeHome, phoneWork, areaCodeWork, phoneMobile, areaCodeMobile, familyDoctor) " +
                    "VALUES (@patientId, @nameLast, @nameFirst, @nameMiddle, @street, @city, @state, @zip, " +
                    "@phoneHome, @areaCodeHome, @phoneWork, @areaCodeWork, @phoneMobile, @areaCodeMobile, @familyDoctor)";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@nameLast", newPatient.nameLast);
                myCommand.Parameters.AddWithValue("@nameFirst", newPatient.nameFirst);
                myCommand.Parameters.AddWithValue("@nameMiddle", newPatient.nameMiddle);
                myCommand.Parameters.AddWithValue("@street", newPatient.street);
                myCommand.Parameters.AddWithValue("@city", newPatient.city);
                myCommand.Parameters.AddWithValue("@state", newPatient.state);
                myCommand.Parameters.AddWithValue("@zip", newPatient.zip);
                myCommand.Parameters.AddWithValue("@phoneHome", newPatient.phoneHome);
                myCommand.Parameters.AddWithValue("@areaCodeHome", newPatient.areaCodeHome);
                myCommand.Parameters.AddWithValue("@phoneWork", newPatient.phoneWork);
                myCommand.Parameters.AddWithValue("@areaCodeWork", newPatient.areaCodeWork);
                myCommand.Parameters.AddWithValue("@phoneMobile", newPatient.phoneMobile);
                myCommand.Parameters.AddWithValue("@areaCodeMobile", newPatient.areaCodeMobile);
                myCommand.Parameters.AddWithValue("@familyDoctor", newPatient.familyDoctor);
                myCommand.Parameters.AddWithValue("@patientId", newPatient.patientId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // WriteItem

        /// <summary>
        /// Insert a list of Patient records into the database.
        /// </summary>
        public void WriteList(List<Patient> patients)
        {
            foreach (var Patient in patients)
            {
                WriteItem(Patient);
            } // foreach
        } // writelist
    }
}
