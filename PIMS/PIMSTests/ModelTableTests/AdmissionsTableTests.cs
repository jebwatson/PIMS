using System;
using System.Collections.Generic;
using NUnit.Framework;
using DBI;
using DBI.Utilities;
using System.Data.SqlClient;
using DBI.Tables;
using PIMSTests.Helpers;

namespace PIMSTests.ModelTableTests
{
    [TestFixture]
    class AdmissionsTableTests
    {
        AdmissionsTable myTable;
        List<Admission> myList;
        List<Admission> admissions;
        ICompare<Admission> comparer;

        [SetUp]
        public void SetupTest()
        {
            myTable = new AdmissionsTable();
            myList = new List<Admission>();
            admissions = new List<Admission>();
            comparer = new AdmissionsComparer();

            // NOTE: This occurs before each and every test case.
            myList.Clear();
            myList.Add(new Admission(DateTime.Parse("01/01/2017"), DateTime.Parse("12/01/2017"), "A", "1", "1", "1", "1", 1));
            myList.Add(new Admission(DateTime.Parse("01/02/2017"), DateTime.Parse("12/02/2017"), "B", "2", "2", "2", "2", 2));
            myList.Add(new Admission(DateTime.Parse("01/03/2017"), DateTime.Parse("12/03/2017"), "C", "3", "3", "3", "3", 3));

            // Establish the connection string
            ConnectionsManager.SQLServerConnectionString = "Data Source=CSSA-JEB\\SQLEXPRESS;Initial Catalog=" +
                "PIMSTest;Integrated Security=False;User Id=jwatson;Password=test;MultipleActiveResultSets=True;";

            // Establish a connection and close at the end of using
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                // Clear the table before any tests occur
                string clearQuery = "DELETE FROM admissions";
                QueryExecutor.ExecuteSqlNonQuery(clearQuery, myConnection);

                // Populate the table with known values before tests occur
                string populationQuery1 = "INSERT INTO admissions (admissionTime, dischargeTime, admissionReason, " +
                    "facility, floor, roomNumber, bedNumber, patientId) " +
                    "VALUES ('01/01/2017', '12/01/2017', 'A', '1', '1', '1', '1', 1)";
                string populationQuery2 = "INSERT INTO admissions (admissionTime, dischargeTime, admissionReason, " +
                    "facility, floor, roomNumber, bedNumber, patientId) " +
                    "VALUES ('01/02/2017', '12/02/2017', 'B', '2', '2', '2', '2', 2)";
                string populationQuery3 = "INSERT INTO admissions (admissionTime, dischargeTime, admissionReason, " +
                    "facility, floor, roomNumber, bedNumber, patientId) " +
                    "VALUES ('01/03/2017', '12/03/2017', 'C', '3', '3', '3', '3', 3)";

                QueryExecutor.ExecuteSqlNonQuery(populationQuery1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery3, myConnection);
            }
        }

        [Test]
        public void ShouldReadList()
        {
            // Read from a pre-populated test database and compare results.
            List<Admission> Admissions;

            Admissions = myTable.ReadList();

            int i = 0;

            foreach (var admission in Admissions)
            {
                comparer.Compare(admission, myList[i]);
                i++;
            }
        }

        [Test]
        public void ShouldReadListById()
        {
            // Read from a pre-populated test database and compare results.
            List<Admission> Admissions;

            Admissions = myTable.ReadListById(1);

            foreach (var admission in Admissions)
            {
                comparer.Compare(admission, myList[0]);
            }
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
            myTable.ClearTableById(1);
            int recordCount = myTable.CountRows();
            admissions = myTable.ReadListById(1);
            int missingRecordCount = admissions.Count;
            Assert.That(recordCount, Is.EqualTo(2));
            Assert.That(missingRecordCount, Is.EqualTo(0));
        }

        [Test]
        public void ShouldWriteList()
        {
            // Need to clear the table first
            myTable.ClearTable();

            // Write some records to the table then retrieve them using previously tested
            // read methods. Compare with original records.
            myTable.WriteList(myList);
            admissions = myTable.ReadList();

            int i = 0;

            foreach (var admission in admissions)
            {
                comparer.Compare(admission, myList[i]);
                i++;
            }
        }

        [Test]
        public void ShouldWriteItem()
        {
            // Need to clear the table first
            myTable.ClearTable();

            // Write a record to the table then retrieve it using previously tested
            // read methods. Compare with original record.
            myTable.WriteItem(myList[1]);
            admissions = myTable.ReadList();

            foreach (var admission in admissions)
            {
                comparer.Compare(admission, myList[1]);
            }
        }

        [Test]
        public void ShouldUpdateList()
        {
            // Need some updated data
            Admission updated1 = new Admission(DateTime.Parse("01/01/2017"), DateTime.Parse("12/01/2017"), "D", "1", "1", "1", "1", 1);
            Admission updated2 = new Admission(DateTime.Parse("01/02/2017"), DateTime.Parse("12/02/2017"), "E", "2", "2", "2", "2", 2);
            Admission updated3 = new Admission(DateTime.Parse("01/03/2017"), DateTime.Parse("12/03/2017"), "F", "3", "3", "3", "3", 3);

            myList.Clear();

            myList.Add(updated1);
            myList.Add(updated2);
            myList.Add(updated3);

            myTable.UpdateList(myList);

            // Now read the table back out and compare to myList
            admissions = myTable.ReadList();

            int i = 0;

            foreach (var admission in admissions)
            {
                comparer.Compare(admission, myList[i]);
                i++;
            }

        }

        [Test]
        public void ShouldUpdateItem()
        {
            // Need some updated data
            Admission updatedAdmission = new Admission(DateTime.Parse("01/01/2017"), DateTime.Parse("12/01/2017"), 
                "Z", "1", "1", "1", "1", 1);
            
            // Update the table with the updated admission (id = 1)
            myTable.UpdateItem(updatedAdmission);

            // Now read the admission back out and compare it to the updatedAdmission above.
            admissions = myTable.ReadListById(1);

            foreach (var admission in admissions)
            {
                comparer.Compare(admission, updatedAdmission);
            }
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
