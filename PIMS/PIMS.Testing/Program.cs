using System;
using System.Collections.Generic;
using DBI;
using DBI.Utilities;
using System.Data.SqlClient;
using DBI.Tables;

namespace PIMS.Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Establish the connection string
            ConnectionsManager.SQLServerConnectionString = "Data Source=ALEX\\SQLEXPRESS;Initial Catalog=" +
                "PIMSTest;Integrated Security=False;User Id=jwatson;Password=test;MultipleActiveResultSets=True;";

            // Establish a connection and close at the end of using
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                // Populate the table with known values before tests occur
                string populationQuery1 = "INSERT INTO admissions (admissionTime, dischargeTime, admissionReason, dischargeReason, " +
                    "facilityNumber, floorNumber, roomNumber, bedNumber, patientId, caseId) " +
                    "VALUES ('01/01/2017', '12/01/2017', 'A', 'A', '1', '1', '1', '1', 1, 1)";
                string populationQuery2 = "INSERT INTO admissions (admissionTime, dischargeTime, admissionReason, dischargeReason, " +
                    "facilityNumber, floorNumber, roomNumber, bedNumber, patientId, caseId) " +
                    "VALUES ('01/02/2017', '12/02/2017', 'B', 'B', '2', '2', '2', '2', 2, 2)";
                string populationQuery3 = "INSERT INTO admissions (admissionTime, dischargeTime, admissionReason, dischargeReason, " +
                    "facilityNumber, floorNumber, roomNumber, bedNumber, patientId, caseId) " +
                    "VALUES ('01/03/2017', '12/03/2017', 'C', 'C', '3', '3', '3', '3', 3, 3)";

                QueryExecutor.ExecuteSqlNonQuery(populationQuery1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery3, myConnection);
            }
        }
    }
}
