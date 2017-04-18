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
                "PIMSTest;Integrated Security=False;User Id=ami0001;Password=poop;MultipleActiveResultSets=True;";

            // Establish a connection and close at the end of using
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string query1 = "INSERT INTO admissions (admissionTime, dischargeTime, admissionReason, dischargeReason, " +
                    "facilityNumber, floorNumber, roomNumber, bedNumber, patientId, caseId) " +
                    "VALUES ('01/01/2017', '12/01/2017', 'A', 'A', '1', '1', '1', '1', 1)";
                string query2 = "INSERT INTO admissions (admissionTime, dischargeTime, admissionReason, dischargeReason, " +
                    "facilityNumber, floorNumber, roomNumber, bedNumber, patientId, caseId) " +
                    "VALUES ('01/02/2017', '12/02/2017', 'B', 'B', '2', '2', '2', '2', 2)";
                string query3 = "INSERT INTO admissions (admissionTime, dischargeTime, admissionReason, dischargeReason, " +
                    "facilityNumber, floorNumber, roomNumber, bedNumber, patientId, caseId) " +
                    "VALUES ('01/03/2017', '12/03/2017', 'C', 'C', '3', '3', '3', '3', 3)";
                string query4 = "INSERT INTO admissions (admissionTime, dischargeTime, admissionReason, dischargeReason, " +
                    "facilityNumber, floorNumber, roomNumber, bedNumber, patientId, caseId) " +
                    "VALUES ('01/03/2017', '12/03/2017', 'C', 'D', '4', '4', '4', '4', 4)";
                string query5 = "INSERT INTO admissions (admissionTime, dischargeTime, admissionReason, dischargeReason, " +
                    "facilityNumber, floorNumber, roomNumber, bedNumber, patientId, caseId) " +
                    "VALUES ('01/04/2017', '12/04/2017', 'C', 'E', '5', '5', '5', '5', 5)";

                QueryExecutor.ExecuteSqlNonQuery(query1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query3, myConnection);

                /*
                query1 = "INSERT INTO bills (amountTotalDollars, amountTotalCents, amountPaidByPatientDollars, " +
                    "amountPaidByPatientCents, amountPaidByInsuranceDollars, amountPaidByInsuranceCents, amountOwedDollars, amountOwedCents, " +
                    "dateCharged, dateDue, patientId, caseId) VALUES (1, 1, 0, 0, 1, 1, 0, 0, '01/01/2017', '12/01/2017', 1)";
                query2 = "INSERT INTO bills (amountTotalDollars, amountTotalCents, amountPaidByPatientDollars, " +
                    "amountPaidByPatientCents, amountPaidByInsuranceDollars, amountPaidByInsuranceCents, amountOwedDollars, amountOwedCents, " +
                    "dateCharged, dateDue, patientId, caseId) VALUES (2, 2, 0, 0, 2, 2, 0, 0, '01/02/2017', '12/02/2017', 2)";
                query3 = "INSERT INTO bills (amountTotalDollars, amountTotalCents, amountPaidByPatientDollars, " +
                    "amountPaidByPatientCents, amountPaidByInsuranceDollars, amountPaidByInsuranceCents, amountOwedDollars, amountOwedCents, " +
                    "dateCharged, dateDue, patientId, caseId) VALUES (3, 3, 0, 0, 3, 3, 0, 0, '01/03/2017', '12/03/2017', 3)";
                query4 = "INSERT INTO bills (amountTotalDollars, amountTotalCents, amountPaidByPatientDollars, " +
                    "amountPaidByPatientCents, amountPaidByInsuranceDollars, amountPaidByInsuranceCents, amountOwedDollars, amountOwedCents, " +
                    "dateCharged, dateDue, patientId, caseId) VALUES (3, 3, 0, 0, 3, 3, 0, 0, '01/03/2017', '12/03/2017', 3)";
                query5 = "INSERT INTO bills (amountTotalDollars, amountTotalCents, amountPaidByPatientDollars, " +
                    "amountPaidByPatientCents, amountPaidByInsuranceDollars, amountPaidByInsuranceCents, amountOwedDollars, amountOwedCents, " +
                    "dateCharged, dateDue, patientId, caseId) VALUES (3, 3, 0, 0, 3, 3, 0, 0, '01/03/2017', '12/03/2017', 3)";

                QueryExecutor.ExecuteSqlNonQuery(query1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query3, myConnection);

                query1 = "INSERT INTO charges (description, amountDollars, amountCents, dateCharged, " +
                    "dateDue, procedureId, officeStaffId, patientId, caseId) " +
                    "VALUES ('test1', 1, 1, '01/01/2017', '12/01/2017', 1, 1, 1)";
                query2 = "INSERT INTO charges (description, amountDollars, amountCents, dateCharged, " +
                    "dateDue, procedureId, officeStaffId, patientId, caseId) " +
                    "VALUES ('test2', 2, 2, '01/02/2017', '12/02/2017', 2, 2, 2)";
                query3 = "INSERT INTO charges (description, amountDollars, amountCents, dateCharged, " +
                    "dateDue, procedureId, officeStaffId, patientId, caseId) " +
                    "VALUES ('test3', 3, 3, '01/03/2017', '12/03/2017', 3, 3, 3)";

                QueryExecutor.ExecuteSqlNonQuery(query1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query3, myConnection);
                */

                query1 = "INSERT INTO emergencyContact (nameLast, nameFirst, nameMiddle, phone, areaCode, patientId) " +
                    "VALUES ('Watson', 'Jeb', 'W', '8076874', '205', 1)";
                query2 = "INSERT INTO emergencyContact (nameLast, nameFirst, nameMiddle, phone, areaCode, patientId) " +
                    "VALUES ('Burcham', 'David', 'A', '1111111', '256', 1)";
                query3 = "INSERT INTO emergencyContact (nameLast, nameFirst, nameMiddle, phone, areaCode, patientId) " +
                    "VALUES ('Morrow', 'Jasper', 'A', '2222222', '256', 1)";

                QueryExecutor.ExecuteSqlNonQuery(query1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query3, myConnection);

                query1 = "INSERT INTO insurance (insuranceCarrier, accountNumber, groupNumber, patientId) " +
                    "VALUES ('A', '1', '1', 1)";
                query2 = "INSERT INTO insurance (insuranceCarrier, accountNumber, groupNumber, patientId) " +
                    "VALUES ('B', '2', '2', 2)";
                query3 = "INSERT INTO insurance (insuranceCarrier, accountNumber, groupNumber, patientId) " +
                    "VALUES ('C', '3', '3', 3)";

                QueryExecutor.ExecuteSqlNonQuery(query1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query3, myConnection);

                // Populate the table with known values before tests occur
                query1 = "INSERT INTO notesDoctor (notes, doctorId, patientId, caseId) " +
                    "VALUES ('this is a note', 1, 1)";
                query2 = "INSERT INTO notesDoctor (notes, doctorId, patientId, caseId) " +
                    "VALUES ('', 2, 2)";
                query3 = "INSERT INTO notesDoctor (notes, doctorId, patientId, caseId) " +
                    "VALUES ('this is a much longer note, which is opposite of the last, null note', 3, 3)";

                QueryExecutor.ExecuteSqlNonQuery(query1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query3, myConnection);

                query1 = "INSERT INTO notesNurse (notes, nurseId, patientId, caseId) " +
                    "VALUES ('this is a note', 4, 4)";
                query2 = "INSERT INTO notesNurse (notes, nurseId, patientId, caseId) " +
                    "VALUES ('', 5, 5)";
                query3 = "INSERT INTO notesNurse (notes, nurseId, patientId, caseId) " +
                    "VALUES ('this is a much longer note, which is opposite of the last, null note', 6, 6)";

                QueryExecutor.ExecuteSqlNonQuery(query1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query3, myConnection);

                query1 = "INSERT INTO patients (nameLast, nameFirst, nameMiddle, street, city, state, zip, " +
                    "phoneHome, areaCodeHome, phoneWork, areaCodeWork, phoneMobile, areaCodeMobile, familyDoctor) " +
                    "VALUES ('Watson', 'Jeb', 'W', 'A', 'A', 'A', '11111', '1111111', '256', '1111111', '256', '1111111', '256', 'A')";
                query2 = "INSERT INTO patients (nameLast, nameFirst, nameMiddle, street, city, state, zip, " +
                    "phoneHome, areaCodeHome, phoneWork, areaCodeWork, phoneMobile, areaCodeMobile, familyDoctor) " +
                    "VALUES ('Burcham', 'David', 'A', 'B', 'B', 'B', '22222', '2222222', '256', '2222222', '256', '2222222', '256', 'B')";
                query3 = "INSERT INTO patients (nameLast, nameFirst, nameMiddle, street, city, state, zip, " +
                    "phoneHome, areaCodeHome, phoneWork, areaCodeWork, phoneMobile, areaCodeMobile, familyDoctor) " +
                    "VALUES ('Morrow', 'Jasper', 'A', 'C', 'C', 'C', '33333', '3333333', '256', '3333333', '256', '3333333', '256', 'C')";

                QueryExecutor.ExecuteSqlNonQuery(query1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query3, myConnection);

                query1 = "INSERT INTO prescriptions (prescName, amount, prescDate, " +
                    "duration, patientId, caseId) " +
                    "VALUES ('test1', '1mg', '01 / 01 / 2017', 1, 1)";
                query2 = "INSERT INTO prescriptions (prescName, amount, prescDate, " +
                    "duration, patientId, caseId) " +
                    "VALUES ('test2', '2mg', '01 / 02 / 2017', 2, 2)";
                query3 = "INSERT INTO prescriptions (prescName, amount, prescDate, " +
                    "duration, patientId, caseId) " +
                    "VALUES ('test3', '3mg', '01 / 03 / 2017', 3, 3)";

                QueryExecutor.ExecuteSqlNonQuery(query1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query3, myConnection);

                query1 = "INSERT INTO procedures (startTime, stopTime, procType, durationHrs, " +
                    "durationMins, doctorId, procNotes, patientId, caseId) " +
                    "VALUES ('01 / 01 / 2017', '12 / 01 / 2017', 'test1', 1, 1, 1, 'test1', 1)";
                query2 = "INSERT INTO procedures (startTime, stopTime, procType, durationHrs, " +
                    "durationMins, doctorId, procNotes, patientId, caseId) " +
                    "VALUES ('01 / 02 / 2017', '12 / 02 / 2017', 'test2', 2, 2, 2, 'test2', 2)";
                query3 = "INSERT INTO procedures (startTime, stopTime, procType, durationHrs, " +
                    "durationMins, doctorId, procNotes, patientId, caseId) " +
                    "VALUES ('01 / 03 / 2017', '12 / 03 / 2017', 'test3', 3, 3, 3, 'test3', 3)";

                QueryExecutor.ExecuteSqlNonQuery(query1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query3, myConnection);

                query1 = "INSERT INTO users (nameLast, nameFirst, title, " +
                    "accessLevel, username) " +
                    "VALUES ('test1', 'test1', 'test1', 1, 'test1')";
                query2 = "INSERT INTO users (nameLast, nameFirst, title, " +
                    "accessLevel, username) " +
                    "VALUES ('test2', 'test2', 'test2', '2', 'test2')";
                query3 = "INSERT INTO users (nameLast, nameFirst, title, " +
                    "accessLevel, username) " +
                    "VALUES ('test3', 'test3', 'test3', '3', 'test3')";

                QueryExecutor.ExecuteSqlNonQuery(query1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query3, myConnection);

                query1 = "INSERT INTO visitors (nameLast, nameFirst, relation, " +
                    "lastVisit, patientId, caseId) " +
                    "VALUES ('test1', 'test1', 'test1', '01 / 01 / 2017', 1, 1)";
                query2 = "INSERT INTO visitors (nameLast, nameFirst, relation, " +
                    "lastVisit, patientId, caseId) " +
                    "VALUES ('test2', 'test2', 'test2', '01 / 02 / 2017', 2, 2)";
                query3 = "INSERT INTO visitors (nameLast, nameFirst, relation, " +
                    "lastVisit, patientId, caseId) " +
                    "VALUES ('test3', 'test3', 'test3', '01 / 03 / 2017', 3, 3)";

                QueryExecutor.ExecuteSqlNonQuery(query1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query3, myConnection);
            }
        }
    }
}
