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
    class ProceduresTableTests
    {
        ProceduresTable myTable;
        List<Procedures> myList;
        ICompare<Procedures> comparer;

        [SetUp]
        public void SetupTest()
        {
            // NOTE: This occurs before each and every test case.

            myTable = new ProceduresTable();
            myList = new List<Procedures>()
            {
                new Procedures(1, DateTime.Parse("01/01/2017"), DateTime.Parse("12/01/2017"), "test1", 1, 1, 1, "test1", 1, 1),
                new Procedures(2, DateTime.Parse("01/02/2017"), DateTime.Parse("12/02/2017"), "test2", 2, 2, 2, "test2", 2, 2),
                new Procedures(3, DateTime.Parse("01/03/2017"), DateTime.Parse("12/03/2017"), "test3", 3, 3, 3, "test3", 3, 3)
            };
            comparer = new ProceduresComparer();

            // Establish the connection string
            ConnectionsManager.SQLServerConnectionString = "Data Source=CSSA-JEB\\SQLEXPRESS;Initial Catalog=" +
                "PIMSTest;Integrated Security=False;User Id=jwatson;Password=test;MultipleActiveResultSets=True;";

            // Establish a connection and close at the end of using

            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                // Clear the table before any tests occur
                string clearQuery = "DELETE FROM procedures";
                QueryExecutor.ExecuteSqlNonQuery(clearQuery, myConnection);

                // Populate the table with known values before tests occur
                string populationQuery1 = "INSERT INTO procedures (procId, startTime, stopTime, procType, durationHrs, " +
                    "durationMins, doctorId, procNotes, patientId, caseId) " +
                    "VALUES (1, '01 / 01 / 2017', '12 / 01 / 2017', 'test1', 1, 1, 1, 'test1', 1, 1)";
                string populationQuery2 = "INSERT INTO procedures (procId, startTime, stopTime, procType, durationHrs, " +
                    "durationMins, doctorId, procNotes, patientId, caseId) " +
                    "VALUES (2, '01 / 02 / 2017', '12 / 02 / 2017', 'test2', 2, 2, 2, 'test2', 2, 2)";
                string populationQuery3 = "INSERT INTO procedures (procId, startTime, stopTime, procType, durationHrs, " +
                    "durationMins, doctorId, procNotes, patientId, caseId) " +
                    "VALUES (3, '01 / 03 / 2017', '12 / 03 / 2017', 'test3', 3, 3, 3, 'test3', 3, 3)";

                QueryExecutor.ExecuteSqlNonQuery(populationQuery1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery3, myConnection);
            }
        }

        [Test]
        public void ShouldReadList()
        {
            List<Procedures> procs = new List<Procedures>();

            // Read from a pre-populated test database and compare results.
            procs = myTable.ReadList();

            int i = 0;

            foreach (var procedure in procs)
            {
                comparer.Compare(procedure, myList[i]);
                i++;
            }
        }

        [Test]
        public void ShouldReadListById()
        {
            List<Procedures> procs = new List<Procedures>();

            // Read from a pre-populated test database and compare results.
            procs = myTable.ReadListById(1);

            foreach (var procedure in procs)
            {
                comparer.Compare(procedure, myList[0]);
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
            List<Procedures> procs = new List<Procedures>();
            myTable.ClearTableById(1);
            int recordCount = myTable.CountRows();
            procs = myTable.ReadListById(1);
            int missingRecordCount = procs.Count;
            Assert.That(recordCount, Is.EqualTo(2));
            Assert.That(missingRecordCount, Is.EqualTo(0));
        }

        [Test]
        public void ShouldWriteList()
        {
            List<Procedures> procs = new List<Procedures>();

            // Need to clear the table first
            myTable.ClearTable();

            // Write some records to the table then retrieve them using previously tested
            // read methods. Compare with original records.
            myTable.WriteList(myList);
            procs = myTable.ReadList();

            int i = 0;

            foreach (var procedure in procs)
            {
                comparer.Compare(procedure, myList[i]);
                i++;
            }
        }

        [Test]
        public void ShouldWriteItem()
        {
            List<Procedures> procs = new List<Procedures>();

            // Need to clear the table first
            myTable.ClearTable();

            // Write a record to the table then retrieve it using previously tested
            // read methods. Compare with original record.
            myTable.WriteItem(myList[0]);
            procs = myTable.ReadList();

            foreach (var procedure in procs)
            {
                comparer.Compare(procedure, myList[0]);
            }
        }

        [Test]
        public void ShouldUpdateList()
        {
            List<Procedures> procs = new List<Procedures>();

            // Need some updated data
            Procedures updated1 = new Procedures(1, DateTime.Parse("01/04/2017"), DateTime.Parse("12/04/2017"), "test4", 4, 4, 4, "test4", 4, 4);
            Procedures updated2 = new Procedures(2, DateTime.Parse("01/05/2017"), DateTime.Parse("12/05/2017"), "test5", 5, 5, 5, "test5", 5, 5);
            Procedures updated3 = new Procedures(3, DateTime.Parse("01/06/2017"), DateTime.Parse("12/06/2017"), "test6", 6, 6, 6, "test6", 6, 6);

            myList.Clear();

            myList.Add(updated1);
            myList.Add(updated2);
            myList.Add(updated3);

            myTable.UpdateList(myList);

            // Now read the table back out and compare to myList
            procs = myTable.ReadList();

            int i = 0;

            foreach (var procedure in procs)
            {
                comparer.Compare(procedure, myList[i]);
                i++;
            }

        }

        [Test]
        public void ShouldUpdateItem()
        {
            List<Procedures> procs = new List<Procedures>();

            // Need some updated data
            Procedures updatedProcedure = new Procedures(4, DateTime.Parse("01/04/2017"), DateTime.Parse("12/04/2017"), "test4", 4, 4, 4, "test4", 4, 4);

            // Update the table with the updated admission (id = 1)
            myTable.UpdateItem(updatedProcedure);

            // Now read the admission back out and compare it to the updatedAdmission above.
            procs = myTable.ReadListById(4);

            foreach (var procedure in procs)
            {
                comparer.Compare(procedure, updatedProcedure);
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
