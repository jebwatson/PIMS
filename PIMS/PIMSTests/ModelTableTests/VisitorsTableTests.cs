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
    class VisitorsTableTests
    {
        VisitorsTable myTable;
        List<Visitors> myList;
        ICompare<Visitors> comparer;

        [SetUp]
        public void SetupTest()
        {
            // NOTE: This occurs before each and every test case.

            myTable = new VisitorsTable();
            myList = new List<Visitors>()
            {
                new Visitors("test1", "test1", "test1", DateTime.Parse("01/01/2017"), 1, 1),
                new Visitors("test2", "test2", "test2", DateTime.Parse("01/02/2017"), 2, 2),
                new Visitors("test3", "test3", "test3", DateTime.Parse("01/03/2017"), 3, 3)
            };
            comparer = new VisitorsComparer();

            // Establish the connection string
            ConnectionsManager.SQLServerConnectionString = "Data Source=ALEX\\SQLEXPRESS;Initial Catalog=" +
                "PIMSTest;Integrated Security=False;User Id=jwatson;Password=test;MultipleActiveResultSets=True;";

            // Establish a connection and close at the end of using

            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                // Clear the table before any tests occur
                string clearQuery = "DELETE FROM visitors";
                QueryExecutor.ExecuteSqlNonQuery(clearQuery, myConnection);

                // Populate the table with known values before tests occur
                string populationQuery1 = "INSERT INTO visitors (nameLast, nameFirst, relation, " +
                    "lastVisit, patientId, caseId) " +
                    "VALUES ('test1', 'test1', 'test1', '01 / 01 / 2017', 1, 1)";
                string populationQuery2 = "INSERT INTO visitors (nameLast, nameFirst, relation, " +
                    "lastVisit, patientId, caseId) " +
                    "VALUES ('test2', 'test2', 'test2', '01 / 02 / 2017', 2, 2)";
                string populationQuery3 = "INSERT INTO visitors (nameLast, nameFirst, relation, " +
                    "lastVisit, patientId, caseId) " +
                    "VALUES ('test3', 'test3', 'test3', '01 / 03 / 2017', 3, 3)";

                QueryExecutor.ExecuteSqlNonQuery(populationQuery1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery3, myConnection);
            }
        }

        [Test]
        public void ShouldReadList()
        {
            List<Visitors> visitors = new List<Visitors>();

            // Read from a pre-populated test database and compare results.
            visitors = myTable.ReadList();

            int i = 0;

            foreach (var visitor in visitors)
            {
                comparer.Compare(visitor, myList[i]);
                i++;
            }
        }

        [Test]
        public void ShouldReadListById()
        {
            List<Visitors> visitors = new List<Visitors>();

            // Read from a pre-populated test database and compare results.
            visitors = myTable.ReadListById(1);

            foreach (var visitor in visitors)
            {
                comparer.Compare(visitor, myList[0]);
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
            List<Visitors> visitors = new List<Visitors>();
            myTable.ClearTableById(1);
            int recordCount = myTable.CountRows();
            visitors = myTable.ReadListById(1);
            int missingRecordCount = visitors.Count;
            Assert.That(recordCount, Is.EqualTo(2));
            Assert.That(missingRecordCount, Is.EqualTo(0));
        }

        [Test]
        public void ShouldWriteList()
        {
            List<Visitors> visitors = new List<Visitors>();

            // Need to clear the table first
            myTable.ClearTable();

            // Write some records to the table then retrieve them using previously tested
            // read methods. Compare with original records.
            myTable.WriteList(myList);
            visitors = myTable.ReadList();

            int i = 0;

            foreach (var visitor in visitors)
            {
                comparer.Compare(visitor, myList[i]);
                i++;
            }
        }

        [Test]
        public void ShouldWriteItem()
        {
            List<Visitors> visitors = new List<Visitors>();

            // Need to clear the table first
            myTable.ClearTable();

            // Write a record to the table then retrieve it using previously tested
            // read methods. Compare with original record.
            myTable.WriteItem(myList[0]);
            visitors = myTable.ReadList();

            foreach (var visitor in visitors)
            {
                comparer.Compare(visitor, myList[0]);
            }
        }

        [Test]
        public void ShouldUpdateList()
        {
            List<Visitors> visitors = new List<Visitors>();

            // Need some updated data
            Visitors updated1 = new Visitors("test4", "test4", "test4", DateTime.Parse("01/04/2017"), 4, 4);
            Visitors updated2 = new Visitors("test5", "test5", "test5", DateTime.Parse("01/05/2017"), 5, 5);
            Visitors updated3 = new Visitors("test6", "test6", "test6", DateTime.Parse("01/06/2017"), 6, 6);

            myList.Clear();

            myList.Add(updated1);
            myList.Add(updated2);
            myList.Add(updated3);

            myTable.UpdateList(myList);

            // Now read the table back out and compare to myList
            visitors = myTable.ReadList();

            int i = 0;

            foreach (var visitor in visitors)
            {
                comparer.Compare(visitor, myList[i]);
                i++;
            }

        }

        [Test]
        public void ShouldUpdateItem()
        {
            List<Visitors> visitors = new List<Visitors>();

            // Need some updated data
            Visitors updatedVisitor = new Visitors("test4", "test4", "test4", DateTime.Parse("01/04/2017"), 4, 4);

            // Update the table with the updated admission (id = 1)
            myTable.UpdateItem(updatedVisitor);

            // Now read the admission back out and compare it to the updatedAdmission above.
            visitors = myTable.ReadListById(4);

            foreach (var visitor in visitors)
            {
                comparer.Compare(visitor, updatedVisitor);
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
