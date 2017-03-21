using DBI;
using System.Collections.Generic;
using NUnit.Framework;
using PIMSTests.Helpers;
using DBI.Utilities;
using System.Data.SqlClient;

namespace PIMSTests.ModelTableTests
{
    class PatientTableTests
    {
        PatientTable myTable;
        List<Patient> myList;
        List<Patient> myList2;
        ICompare<Patient> comparer;

        [SetUp]
        public void SetupTest()
        {
            // NOTE: This occurs before each and every test case.

            myTable = new PatientTable();
            myList = new List<Patient>()
            {
                new Patient(1, "Watson", "Jeb", "W", "A", "A", "A", "11111", "1111111", "256", "1111111", "256", "1111111", "256", "A"),
                new Patient(2, "Burcham", "David", "A", "B", "B", "B", "22222", "2222222", "256", "2222222", "256", "2222222", "256", "B"),
                new Patient(3, "Morrow", "Jasper", "A", "C", "C", "C", "33333", "3333333", "256", "3333333", "256", "3333333", "256", "C")
            };

            myList2 = new List<Patient>
            {
                new Patient(1, "Indihar", "Alex", "B", "D", "D", "D", "44444", "4444444", "256", "4444444", "256", "4444444", "256", "D"),
                new Patient(2, "Norris", "Chuck", "B", "E", "E", "E", "55555", "5555555", "256", "5555555", "256", "5555555", "256", "E"),
                new Patient(3, "Dempsey", "Jack", "B", "F", "F", "F", "66666", "6666666", "256", "6666666", "256", "6666666", "256", "F")
            };

            comparer = new PatientComparer();

            // Establish the connection string
            ConnectionsManager.SQLServerConnectionString = "Data Source=JEBSDESKTOP\\SQLEXPRESS;Initial Catalog=" +
                "PIMSTest;Integrated Security=False;User Id=jwatson;Password=test;MultipleActiveResultSets=True;";

            // Establish a connection and close at the end of using

            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                // Clear the table before any tests occur
                string clearQuery = "DELETE FROM patients";
                QueryExecutor.ExecuteSqlNonQuery(clearQuery, myConnection);

                // Populate the table with known values before tests occur
                string populationQuery1 = "INSERT INTO patients (patientId, nameLast, nameFirst, nameMiddle, street, city, state, zip, " +
                    "phoneHome, areaCodeHome, phoneWork, areaCodeWork, phoneMobile, areaCodeMobile, familyDoctor) " +
                    "VALUES (1, 'Watson', 'Jeb', 'W', 'A', 'A', 'A', '11111', '1111111', '256', '1111111', '256', '1111111', '256', 'A')";
                string populationQuery2 = "INSERT INTO patients (patientId, nameLast, nameFirst, nameMiddle, street, city, state, zip, " +
                    "phoneHome, areaCodeHome, phoneWork, areaCodeWork, phoneMobile, areaCodeMobile, familyDoctor) " +
                    "VALUES (2, 'Burcham', 'David', 'A', 'B', 'B', 'B', '22222', '2222222', '256', '2222222', '256', '2222222', '256', 'B')";
                string populationQuery3 = "INSERT INTO patients (patientId, nameLast, nameFirst, nameMiddle, street, city, state, zip, " +
                    "phoneHome, areaCodeHome, phoneWork, areaCodeWork, phoneMobile, areaCodeMobile, familyDoctor) " +
                    "VALUES (3, 'Morrow', 'Jasper', 'A', 'C', 'C', 'C', '33333', '3333333', '256', '3333333', '256', '3333333', '256', 'C')";

                QueryExecutor.ExecuteSqlNonQuery(populationQuery1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery3, myConnection);
            }
        }

        [Test]
        public void ShouldReadList()
        {
            List<Patient> patients = new List<Patient>();

            // Read from a pre-populated test database and compare results.
            patients = myTable.ReadList();

            int i = 0;

            foreach (var item in patients)
            {
                comparer.Compare(item, myList[i]);
                i++;
            }
        }

        [Test]
        public void ShouldReadListById()
        {
            List<Patient> patients = new List<Patient>();

            // Read from a pre-populated test database and compare results.
            patients = myTable.ReadListById(1);
            comparer.Compare(patients[0], myList[0]);
        }

        [Test]
        public void ShouldClearTable()
        {
            // clear the table and then get a count. compare count to zero.
            myTable.ClearTable();
            int recordCount = myTable.CountRows();
            Assert.That(recordCount, Is.EqualTo(0));
        }

        [Test]
        public void ShouldClearTableById()
        {
            // clear the table by id = 1. Now check for count = 2 and read
            // by id = 1 and check for itemlist.count = 0.
            List<Patient> patients = new List<Patient>();
            myTable.ClearTableById(1);
            int recordCount = myTable.CountRows();
            patients = myTable.ReadListById(1);
            int missingRecordCount = patients.Count;
            Assert.That(recordCount, Is.EqualTo(2));
            Assert.That(missingRecordCount, Is.EqualTo(0));
        }

        [Test]
        public void ShouldWriteList()
        {
            List<Patient> patients = new List<Patient>();

            // Need to clear the table first
            myTable.ClearTable();

            // Write some records to the table then retrieve them using previously tested
            // read methods. Compare with original records.
            myTable.WriteList(myList);
            patients = myTable.ReadList();

            int i = 0;

            foreach (var item in patients)
            {
                comparer.Compare(item, myList[i]);
                i++;
            }
        }

        [Test]
        public void ShouldWriteItem()
        {
            List<Patient> patients = new List<Patient>();

            // Need to clear the table first
            myTable.ClearTable();

            // Write a record to the table then retrieve it using previously tested
            // read methods. Compare with original record.
            myTable.WriteItem(myList[0]);
            patients = myTable.ReadList();
            comparer.Compare(patients[0], myList[0]);
        }

        [Test]
        public void ShouldUpdateList()
        {
            List<Patient> patients = new List<Patient>();

            myList.Clear();

            myTable.UpdateList(myList2);

            // Now read the table back out and compare to myList
            patients = myTable.ReadList();

            int i = 0;

            foreach (var item in patients)
            {
                comparer.Compare(item, myList2[i]);
                i++;
            }

        }

        [Test]
        public void ShouldUpdateItem()
        {
            List<Patient> patients = new List<Patient>();

            myTable.UpdateItem(myList2[0]);
            patients = myTable.ReadListById(1);
            comparer.Compare(patients[0], myList2[0]);
        }

        [Test]
        public void ShouldCountRows()
        {
            // get a count of the records in the table and compare to known value (3)
            int recordCount = myTable.CountRows();
            Assert.That(recordCount, Is.EqualTo(3));
        }

        [TearDown]
        public void TearDownTests()
        {
            myTable = null;
            myList = null;
        }
    }
}
