using System;
using System.Collections.Generic;
using NUnit.Framework;
using DBI;
using DBI.Utilities;
using System.Data.SqlClient;
using PIMSTests.Helpers;

namespace PIMSTests.ModelTableTests
{
    [TestFixture]
    class PrescriptionsTableTests
    {
        PrescriptionsTable myTable;
        List<Prescriptions> myList;
        ICompare<Prescriptions> comparer;

        [SetUp]
        public void SetupTest()
        {
            // NOTE: This occurs before each and every test case.

            myTable = new PrescriptionsTable();
            myList = new List<Prescriptions>()
            {
                new Prescriptions("test1", "1mg", DateTime.Parse("01/01/2017"), 1, 1, 1),
                new Prescriptions("test2", "2mg", DateTime.Parse("01/02/2017"), 2, 2, 2),
                new Prescriptions("test3", "3mg", DateTime.Parse("01/03/2017"), 3, 3, 3)
            };
            comparer = new PrescriptionsComparer();

            // Establish the connection string
            ConnectionsManager.SQLServerConnectionString = "Data Source=CSSA-JEB\\SQLEXPRESS;Initial Catalog=" +
                "PIMSTest;Integrated Security=False;User Id=jwatson;Password=test;MultipleActiveResultSets=True;";

            // Establish a connection and close at the end of using

            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                // Clear the table before any tests occur
                string clearQuery = "DELETE FROM prescriptions DBCC CHECKIDENT('prescriptions', RESEED, 0)";
                QueryExecutor.ExecuteSqlNonQuery(clearQuery, myConnection);

                // Populate the table with known values before tests occur
                string populationQuery1 = "INSERT INTO prescriptions (prescName, amount, prescDate, " +
                    "duration, patientId) " +
                    "VALUES ('test1', '1mg', '01 / 01 / 2017', 1, 1)";
                string populationQuery2 = "INSERT INTO prescriptions (prescName, amount, prescDate, " +
                    "duration, patientId) " +
                    "VALUES ('test2', '2mg', '01 / 02 / 2017', 2, 2)";
                string populationQuery3 = "INSERT INTO prescriptions (prescName, amount, prescDate, " +
                    "duration, patientId) " +
                    "VALUES ('test3', '3mg', '01 / 03 / 2017', 3, 3)";

                QueryExecutor.ExecuteSqlNonQuery(populationQuery1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery3, myConnection);
            }
        }

        [Test]
        public void ShouldReadList()
        {
            List<Prescriptions> prescs = new List<Prescriptions>();

            // Read from a pre-populated test database and compare results.
            prescs = myTable.ReadList();

            int i = 0;

            foreach (var prescription in prescs)
            {
                comparer.Compare(prescription, myList[i]);
                i++;
            }
        }

        [Test]
        public void ShouldReadListById()
        {
            List<Prescriptions> prescs = new List<Prescriptions>();

            // Read from a pre-populated test database and compare results.
            prescs = myTable.ReadListById(1);

            foreach (var prescription in prescs)
            {
                comparer.Compare(prescription, myList[0]);
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
            List<Prescriptions> prescs = new List<Prescriptions>();
            myTable.ClearTableById(1);
            int recordCount = myTable.CountRows();
            prescs = myTable.ReadListById(1);
            int missingRecordCount = prescs.Count;
            Assert.That(recordCount, Is.EqualTo(2));
            Assert.That(missingRecordCount, Is.EqualTo(0));
        }

        [Test]
        public void ShouldWriteList()
        {
            List<Prescriptions> prescs = new List<Prescriptions>();

            // Need to clear the table first
            myTable.ClearTable();

            // Write some records to the table then retrieve them using previously tested
            // read methods. Compare with original records.
            myTable.WriteList(myList);
            prescs = myTable.ReadList();

            int i = 0;

            foreach (var prescription in prescs)
            {
                comparer.Compare(prescription, myList[i]);
                i++;
            }
        }

        [Test]
        public void ShouldWriteItem()
        {
            List<Prescriptions> prescs = new List<Prescriptions>();

            // Need to clear the table first
            myTable.ClearTable();

            // Write a record to the table then retrieve it using previously tested
            // read methods. Compare with original record.
            myTable.WriteItem(myList[0]);
            prescs = myTable.ReadList();

            foreach (var prescription in prescs)
            {
                comparer.Compare(prescription, myList[0]);
            }
        }

        [Test]
        public void ShouldUpdateList()
        {
            List<Prescriptions> prescs = new List<Prescriptions>();

            // Need some updated data
            Prescriptions updated1 = new Prescriptions("test4", "4mg", DateTime.Parse("01/04/2017"), 4, 4, 1);
            Prescriptions updated2 = new Prescriptions("test5", "5mg", DateTime.Parse("01/05/2017"), 5, 5, 2);
            Prescriptions updated3 = new Prescriptions("test6", "6mg", DateTime.Parse("01/06/2017"), 6, 6, 3);

            myList.Clear();

            myList.Add(updated1);
            myList.Add(updated2);
            myList.Add(updated3);

            myTable.UpdateList(myList);

            // Now read the table back out and compare to myList
            prescs = myTable.ReadList();

            int i = 0;

            foreach (var prescription in prescs)
            {
                comparer.Compare(prescription, myList[i]);
                i++;
            }

        }

        [Test]
        public void ShouldUpdateItem()
        {
            List<Prescriptions> prescs = new List<Prescriptions>();

            // Need some updated data
            Prescriptions updatedPrescription = new Prescriptions("test4", "4mg", DateTime.Parse("01/04/2017"), 4, 4, 1);

            // Update the table with the updated admission (id = 1)
            myTable.UpdateItem(updatedPrescription);

            // Now read the admission back out and compare it to the updatedAdmission above.
            prescs = myTable.ReadListById(4);

            foreach (var prescription in prescs)
            {
                comparer.Compare(prescription, updatedPrescription);
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
