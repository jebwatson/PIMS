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
            ConnectionsManager.SQLServerConnectionString = "Data Source=LUFFY\\SQLEXPRESS;Initial Catalog=" +
                "PIMSFeatureTest;Integrated Security=False;User Id=luffy;Password=luffy;MultipleActiveResultSets=True;";

            // Establish a connection and close at the end of using
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string query1 = "INSERT INTO admissions (admissionTime, dischargeTime, admissionReason, " +
                    "facility, floor, roomNumber, bedNumber, patientId) " +
                    "VALUES ('01/01/2017', '12/01/2017', 'A', '1', '1', '1', '1', 1)";
                string query2 = "INSERT INTO admissions (admissionTime, dischargeTime, admissionReason, " +
                    "facility, floor, roomNumber, bedNumber, patientId) " +
                    "VALUES ('01/02/2017', '12/02/2017', 'B', '2', '2', '2', '2', 2)";
                string query3 = "INSERT INTO admissions (admissionTime, dischargeTime, admissionReason, " +
                    "facility, floor, roomNumber, bedNumber, patientId) " +
                    "VALUES ('01/03/2017', '12/03/2017', 'C', '3', '3', '3', '3', 3)";
                string query4 = "INSERT INTO admissions (admissionTime, dischargeTime, admissionReason, " +
                    "facility, floor, roomNumber, bedNumber, patientId) " +
                    "VALUES ('01/03/2017', '12/03/2017', 'C', '4', '4', '4', '4', 4)";
                string query5 = "INSERT INTO admissions (admissionTime, dischargeTime, admissionReason, " +
                    "facility, floor, roomNumber, bedNumber, patientId) " +
                    "VALUES ('01/04/2017', '12/04/2017', 'C', '5', '5', '5', '5', 5)";

                QueryExecutor.ExecuteSqlNonQuery(query1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query3, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query4, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query5, myConnection);

                query1 = "INSERT INTO bills (amountTotal, amountPaidByPatient, amountPaidByInsurance, amountOwed, dateCharged, " +
                    "dateDue, patientId) VALUES ('1.99', '2.99', '3.99', '4.99', '01/01/2017', '12/01/2017', 1)";
                query2 = "INSERT INTO bills (amountTotal, amountPaidByPatient, amountPaidByInsurance, amountOwed, dateCharged, " +
                    "dateDue, patientId) VALUES ('1.99', '2.99', '3.99', '4.99', '01/02/2017', '12/02/2017', 2)";
                query3 = "INSERT INTO bills (amountTotal, amountPaidByPatient, amountPaidByInsurance, amountOwed, dateCharged, " +
                    "dateDue, patientId) VALUES ('5.99', '6.99', '7.99', '8.99', '01/03/2017', '12/03/2017', 3)";
                query4 = "INSERT INTO bills (amountTotal, amountPaidByPatient, amountPaidByInsurance, amountOwed, dateCharged, " +
                    "dateDue, patientId) VALUES ('5.99', '6.99', '7.99', '8.99', '01/03/2017', '12/03/2017', 4)";
                query5 = "INSERT INTO bills (amountTotal, amountPaidByPatient, amountPaidByInsurance, amountOwed, dateCharged, " +
                    "dateDue, patientId) VALUES ('4.99', '4.99', '4.99', '4.99', '01/03/2017', '12/03/2017', 5)";

                QueryExecutor.ExecuteSqlNonQuery(query1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query3, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query4, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query5, myConnection);

                query1 = "INSERT INTO charges (description, amountTotal, dateCharged, " +
                    "dateDue, procedureId, officeStaffId, patientId) " +
                    "VALUES ('test1', '1.99', '01/01/2017', '12/01/2017', 1, 1, 1)";
                query2 = "INSERT INTO charges (description, amountTotal, dateCharged, " +
                    "dateDue, procedureId, officeStaffId, patientId) " +
                    "VALUES ('test2', '2.99', '01/02/2017', '12/02/2017', 2, 2, 2)";
                query3 = "INSERT INTO charges (description, amountTotal, dateCharged, " +
                    "dateDue, procedureId, officeStaffId, patientId) " +
                    "VALUES ('test3', '1.99', '01/03/2017', '12/03/2017', 3, 3, 3)";
                query4 = "INSERT INTO charges (description, amountTotal, dateCharged, " +
                    "dateDue, procedureId, officeStaffId, patientId) " +
                    "VALUES ('test3', '2.99', '01/03/2017', '12/03/2017', 3, 3, 4)";
                query5 = "INSERT INTO charges (description, amountTotal, dateCharged, " +
                    "dateDue, procedureId, officeStaffId, patientId) " +
                    "VALUES ('test3', '4.99', '01/03/2017', '12/03/2017', 3, 3, 5)";

                QueryExecutor.ExecuteSqlNonQuery(query1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query3, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query4, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query5, myConnection);

                query1 = "INSERT INTO emergencyContact (nameLast, nameFirst, nameMiddle, phone, areaCode, patientId) " +
                    "VALUES ('Watson', 'Jeb', 'W', '8076874', '205', 1)";
                query2 = "INSERT INTO emergencyContact (nameLast, nameFirst, nameMiddle, phone, areaCode, patientId) " +
                    "VALUES ('Burcham', 'David', 'A', '1111111', '256', 2)";
                query3 = "INSERT INTO emergencyContact (nameLast, nameFirst, nameMiddle, phone, areaCode, patientId) " +
                    "VALUES ('Morrow', 'Jasper', 'A', '2222222', '256', 3)";
                query4 = "INSERT INTO emergencyContact (nameLast, nameFirst, nameMiddle, phone, areaCode, patientId) " +
                    "VALUES ('Indihar', 'Alex', 'M', '5095561', '256', 4)";
                query5 = "INSERT INTO emergencyContact (nameLast, nameFirst, nameMiddle, phone, areaCode, patientId) " +
                    "VALUES ('Indihar', 'Alexander', 'M', '6907499', '256', 5)";

                QueryExecutor.ExecuteSqlNonQuery(query1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query3, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query4, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query5, myConnection);

                query1 = "INSERT INTO insurance (insuranceCarrier, accountNumber, groupNumber, patientId) " +
                    "VALUES ('A', '1', '1', 1)";
                query2 = "INSERT INTO insurance (insuranceCarrier, accountNumber, groupNumber, patientId) " +
                    "VALUES ('B', '2', '2', 2)";
                query3 = "INSERT INTO insurance (insuranceCarrier, accountNumber, groupNumber, patientId) " +
                    "VALUES ('C', '3', '3', 3)";
                query4 = "INSERT INTO insurance (insuranceCarrier, accountNumber, groupNumber, patientId) " +
                    "VALUES ('C', '4', '3', 4)";
                query5 = "INSERT INTO insurance (insuranceCarrier, accountNumber, groupNumber, patientId) " +
                    "VALUES ('C', '5', '3', 5)";

                QueryExecutor.ExecuteSqlNonQuery(query1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query3, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query4, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query5, myConnection);

                query1 = "INSERT INTO notes (notes, doctor, nurse, userId, patientId) " +
                    "VALUES ('note1', 'true', 'false', 1, 1)";
                query2 = "INSERT INTO notes (notes, doctor, nurse, userId, patientId) " +
                    "VALUES ('note2', 'false', 'true', 2, 2)";
                query3 = "INSERT INTO notes (notes, doctor, nurse, userId, patientId) " +
                    "VALUES ('note3', 'true', 'false', 3, 3)";
                query4 = "INSERT INTO notes (notes, doctor, nurse, userId, patientId) " +
                    "VALUES ('note4', 'false', 'true', 3, 4)";
                query5 = "INSERT INTO notes (notes, doctor, nurse, userId, patientId) " +
                    "VALUES ('note5', 'true', 'false', 3, 5)";

                QueryExecutor.ExecuteSqlNonQuery(query1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query3, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query4, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query5, myConnection);

                query1 = "INSERT INTO patients (nameLast, nameFirst, nameMiddle, street, city, state, zip, " +
                    "phoneHome, areaCodeHome, phoneWork, areaCodeWork, phoneMobile, areaCodeMobile, familyDoctor) " +
                    "VALUES ('Watson', 'Jeb', 'W', '405 Kings Lane', 'Huntsville', 'AL', '11111', '1111111', '256', '1111111', '256', '1111111', '256', 'Brown')";
                query2 = "INSERT INTO patients (nameLast, nameFirst, nameMiddle, street, city, state, zip, " +
                    "phoneHome, areaCodeHome, phoneWork, areaCodeWork, phoneMobile, areaCodeMobile, familyDoctor) " +
                    "VALUES ('Burcham', 'David', 'A', '5654 Walnut Dr', 'Dallas', 'TX', '22222', '2222222', '256', '2222222', '256', '2222222', '256', 'Middleton')";
                query3 = "INSERT INTO patients (nameLast, nameFirst, nameMiddle, street, city, state, zip, " +
                    "phoneHome, areaCodeHome, phoneWork, areaCodeWork, phoneMobile, areaCodeMobile, familyDoctor) " +
                    "VALUES ('Morrow', 'Jasper', 'A', '1234 Frizz St', 'Bismarck', 'ND', '33333', '3333333', '256', '3333333', '256', '3333333', '256', 'Ingram')";
                query4 = "INSERT INTO patients (nameLast, nameFirst, nameMiddle, street, city, state, zip, " +
                    "phoneHome, areaCodeHome, phoneWork, areaCodeWork, phoneMobile, areaCodeMobile, familyDoctor) " +
                    "VALUES ('Indihar', 'Alex', 'M', '4901 Blue Spring Rd', 'Huntsville', 'AL', '44444', '4444444', '256', '4444444', '256', '4444444', '256', 'Ingram')";
                query5 = "INSERT INTO patients (nameLast, nameFirst, nameMiddle, street, city, state, zip, " +
                    "phoneHome, areaCodeHome, phoneWork, areaCodeWork, phoneMobile, areaCodeMobile, familyDoctor) " +
                    "VALUES ('Indihar', 'Alexander', 'M', '2617 Garth Rd', 'Huntsville', 'AL', '55555', '5555555', '256', '5555555', '256', '5555555', '256', 'Ingram')";

                QueryExecutor.ExecuteSqlNonQuery(query1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query3, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query4, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query5, myConnection);

                query1 = "INSERT INTO prescriptions (prescName, amount, prescDate, " +
                    "duration, patientId) " +
                    "VALUES ('Tums', '1mg', '01/01/2017', 1, 1)";
                query2 = "INSERT INTO prescriptions (prescName, amount, prescDate, " +
                    "duration, patientId) " +
                    "VALUES ('Ibuprofen', '2mg', '01/02/2017', 2, 2)";
                query3 = "INSERT INTO prescriptions (prescName, amount, prescDate, " +
                    "duration, patientId) " +
                    "VALUES ('Tylenol', '3mg', '01/03/2017', 3, 3)";
                query4 = "INSERT INTO prescriptions (prescName, amount, prescDate, " +
                    "duration, patientId) " +
                    "VALUES ('Sudafed', '3mg', '01/03/2017', 3, 4)";
                query5 = "INSERT INTO prescriptions (prescName, amount, prescDate, " +
                    "duration, patientId) " +
                    "VALUES ('Protein Powder', '3mg', '01/03/2017', 3, 5)";

                QueryExecutor.ExecuteSqlNonQuery(query1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query3, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query4, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query5, myConnection);

                query1 = "INSERT INTO procedures (startTime, stopTime, procType, durationHrs, " +
                    "durationMins, doctorId, procNotes, patientId) " +
                    "VALUES ('01 / 01 / 2017 1:00pm', '12 / 01 / 2017 2:00pm', 'test1', 1, 1, 1, 'test1', 1)";
                query2 = "INSERT INTO procedures (startTime, stopTime, procType, durationHrs, " +
                    "durationMins, doctorId, procNotes, patientId) " +
                    "VALUES ('01 / 02 / 2017 3:30am', '12 / 02 / 2017 4:40am', 'test2', 2, 2, 2, 'test2', 2)";
                query3 = "INSERT INTO procedures (startTime, stopTime, procType, durationHrs, " +
                    "durationMins, doctorId, procNotes, patientId) " +
                    "VALUES ('01 / 03 / 2017 5:08am', '12 / 03 / 2017 8:56pm', 'test3', 3, 3, 3, 'test3', 3)";
                query4 = "INSERT INTO procedures (startTime, stopTime, procType, durationHrs, " +
                    "durationMins, doctorId, procNotes, patientId) " +
                    "VALUES ('01 / 03 / 2017 4:20pm', '12 / 03 / 2017 4:20am', 'test3', 3, 3, 3, 'test3', 4)";
                query5 = "INSERT INTO procedures (startTime, stopTime, procType, durationHrs, " +
                    "durationMins, doctorId, procNotes, patientId) " +
                    "VALUES ('01 / 03 / 2017 10:10am', '12 / 03 / 2017 12:00pm', 'test3', 3, 3, 3, 'test3', 5)";

                QueryExecutor.ExecuteSqlNonQuery(query1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query3, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query4, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query5, myConnection);

                query1 = "INSERT INTO users (nameLast, nameFirst, title, " +
                    "accessLevel, username) " +
                    "VALUES ('Watson', 'Jeb', 'Doctor', 4, 'watson')";
                query2 = "INSERT INTO users (nameLast, nameFirst, title, " +
                    "accessLevel, username) " +
                    "VALUES ('Burcham', 'David', 'Volunteer', 1, 'burcham')";
                query3 = "INSERT INTO users (nameLast, nameFirst, title, " +
                    "accessLevel, username) " +
                    "VALUES ('Jasper', 'Morrow', 'Nurse', 3, 'jasper')";
                query4 = "INSERT INTO users (nameLast, nameFirst, title, " +
                    "accessLevel, username) " +
                    "VALUES ('Indihar', 'Alex', 'Doctor', 4, 'alex')";
                query5 = "INSERT INTO users (nameLast, nameFirst, title, " +
                    "accessLevel, username) " +
                    "VALUES ('Indihar', 'Alexander', 'Staff', 2, 'indihar')";

                QueryExecutor.ExecuteSqlNonQuery(query1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query3, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query4, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query5, myConnection);

                query1 = "INSERT INTO visitors (lastName, firstName, relation, " +
                    "lastVisit, patientId) " +
                    "VALUES ('Watson', 'Jeb', 'big daddy', '01 / 01 / 2017', 1)";
                query2 = "INSERT INTO visitors (lastName, firstName, relation, " +
                    "lastVisit, patientId) " +
                    "VALUES ('Burcham', 'David', 'dad', '01 / 02 / 2017', 2)";
                query3 = "INSERT INTO visitors (lastName, firstName, relation, " +
                    "lastVisit, patientId) " +
                    "VALUES ('Morrow', 'Jasper', 'mom', '01 / 03 / 2017', 3)";
                query4 = "INSERT INTO visitors (lastName, firstName, relation, " +
                    "lastVisit, patientId) " +
                    "VALUES ('Indihar', 'Alex', 'twin', '01 / 03 / 2017', 4)";
                query5 = "INSERT INTO visitors (lastName, firstName, relation, " +
                    "lastVisit, patientId) " +
                    "VALUES ('Indihar', 'Alexander', 'twin', '01 / 03 / 2017', 5)";

                QueryExecutor.ExecuteSqlNonQuery(query1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query3, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query4, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(query5, myConnection);
            }
        }
    }
}
