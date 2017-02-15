using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DBI;
using DBI.Utilities;
using System.Data.SqlClient;

namespace PIMSTests.ModelTableTests
{
    [TestFixture]
    class VisitorsTableTests
    {
        VisitorsTable myTable;
        List<Visitors> myList;

        [SetUp]
        public void SetupTest()
        {
            // NOTE: This occurs before each and every test case.

            myTable = new VisitorsTable();
            myList = new List<Visitors>()
            {
                new Visitors(1, "test1", "test1", "test1", DateTime.Parse("01/01/2017"), 1, 1),
                new Visitors(2, "test2", "test2", "test2", DateTime.Parse("01/02/2017"), 2, 2),
                new Visitors(3, "test3", "test3", "test3", DateTime.Parse("01/03/2017"), 3, 3)
            };

            // Establish the connection string
            ConnectionsManager.SQLServerConnectionString = "Data Source=JEBSDESKTOP\\SQLEXPRESS;Initial Catalog=" +
                "PIMSTest;Integrated Security=False;User Id=jwatson;Password=test;MultipleActiveResultSets=True;";

            // Establish a connection and close at the end of using

            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                // Clear the table before any tests occur
                string clearQuery = "DELETE FROM visitors";
                QueryExecutor.ExecuteSqlNonQuery(clearQuery, myConnection);

                // Populate the table with known values before tests occur
                string populationQuery1 = "INSERT INTO visitors (visitorId, lastName, firstName, firstNameCents, relation, " +
                    "dateDue, lastVisit, officeStaffId, patientId, caseId) " +
                    "VALUES (1, 'test1', 'test1', 'test1', '01 / 01 / 2017', 1, 1)";
                string populationQuery2 = "INSERT INTO visitors (visitorId, lastName, firstName, firstNameCents, relation, " +
                    "dateDue, lastVisit, officeStaffId, patientId, caseId) " +
                    "VALUES (2, 'test2', 'test2', 'test2', '01 / 02 / 2017', 2, 2)";
                string populationQuery3 = "INSERT INTO visitors (visitorId, lastName, firstName, firstNameCents, relation, " +
                    "dateDue, lastVisit, officeStaffId, patientId, caseId) " +
                    "VALUES (3, 'test3', 'test3', 'test3', '01 / 03 / 2017', 3, 3)";

                QueryExecutor.ExecuteSqlNonQuery(populationQuery1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery3, myConnection);
            }
        }

        [Test]
        public void ShouldReadList()
        {
            // Read from a pre-populated test database and compare results.
            myTable.ReadList();

            int i = 0;

            foreach (var visitor in myTable.ItemList)
            {
                Assert.That(visitor.visitorId, Is.EqualTo(myList[i].visitorId));
                Assert.That(visitor.lastName, Is.EqualTo(myList[i].lastName));
                Assert.That(visitor.firstName, Is.EqualTo(myList[i].firstName));
                Assert.That(visitor.relation, Is.EqualTo(myList[i].relation));
                Assert.That(visitor.lastVisit, Is.EqualTo(myList[i].lastVisit));
                Assert.That(visitor.patientId, Is.EqualTo(myList[i].patientId));
                Assert.That(visitor.caseId, Is.EqualTo(myList[i].caseId));
                i++;
            }
        }

        [Test]
        public void ShouldReadListById()
        {
            // Read from a pre-populated test database and compare results.
            myTable.ReadListById(1);

            foreach (var visitor in myTable.ItemList)
            {
                Assert.That(visitor.visitorId, Is.EqualTo(myList[0].visitorId));
                Assert.That(visitor.lastName, Is.EqualTo(myList[0].lastName));
                Assert.That(visitor.firstName, Is.EqualTo(myList[0].firstName));
                Assert.That(visitor.relation, Is.EqualTo(myList[0].relation));
                Assert.That(visitor.lastVisit, Is.EqualTo(myList[0].lastVisit));
                Assert.That(visitor.patientId, Is.EqualTo(myList[0].patientId));
                Assert.That(visitor.caseId, Is.EqualTo(myList[0].caseId));
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
            myTable.ReadListById(1);
            int missingRecordCount = myTable.ItemList.Count;
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
            myTable.ItemList = myList;
            myTable.WriteList();
            myTable.ReadList();

            int i = 0;

            foreach (var visitor in myTable.ItemList)
            {
                Assert.That(visitor.visitorId, Is.EqualTo(myList[i].visitorId));
                Assert.That(visitor.lastName, Is.EqualTo(myList[i].lastName));
                Assert.That(visitor.firstName, Is.EqualTo(myList[i].firstName));
                Assert.That(visitor.relation, Is.EqualTo(myList[i].relation));
                Assert.That(visitor.lastVisit, Is.EqualTo(myList[i].lastVisit));
                Assert.That(visitor.patientId, Is.EqualTo(myList[i].patientId));
                Assert.That(visitor.caseId, Is.EqualTo(myList[i].caseId));
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
            myTable.WriteItem(myList[0]);
            myTable.ReadList();

            foreach (var visitor in myTable.ItemList)
            {
                Assert.That(visitor.visitorId, Is.EqualTo(myList[0].visitorId));
                Assert.That(visitor.lastName, Is.EqualTo(myList[0].lastName));
                Assert.That(visitor.firstName, Is.EqualTo(myList[0].firstName));
                Assert.That(visitor.relation, Is.EqualTo(myList[0].relation));
                Assert.That(visitor.lastVisit, Is.EqualTo(myList[0].lastVisit));
                Assert.That(visitor.patientId, Is.EqualTo(myList[0].patientId));
                Assert.That(visitor.caseId, Is.EqualTo(myList[0].caseId));
            }
        }

        [Test]
        public void ShouldUpdateList()
        {
            // Need some updated data
            Visitors updated1 = new Visitors(4, "test4", "test4", "test4", DateTime.Parse("01/04/2017"), 4, 4);
            Visitors updated2 = new Visitors(5, "test5", "test5", "test5", DateTime.Parse("01/05/2017"), 5, 5);
            Visitors updated3 = new Visitors(6, "test6", "test6", "test6", DateTime.Parse("01/06/2017"), 6, 6);

            myList.Clear();

            myList.Add(updated1);
            myList.Add(updated2);
            myList.Add(updated3);

            myTable.ItemList = myList;
            myTable.UpdateList();

            // Now read the table back out and compare to myList
            myTable.ReadList();

            int i = 0;

            foreach (var visitor in myTable.ItemList)
            {
                Assert.That(visitor.visitorId, Is.EqualTo(myList[i].visitorId));
                Assert.That(visitor.lastName, Is.EqualTo(myList[i].lastName));
                Assert.That(visitor.firstName, Is.EqualTo(myList[i].firstName));
                Assert.That(visitor.relation, Is.EqualTo(myList[i].relation));
                Assert.That(visitor.lastVisit, Is.EqualTo(myList[i].lastVisit));
                Assert.That(visitor.patientId, Is.EqualTo(myList[i].patientId));
                Assert.That(visitor.caseId, Is.EqualTo(myList[i].caseId));
                i++;
            }

        }

        [Test]
        public void ShouldUpdateItem()
        {
            // Need some updated data
            Visitors updatedVisitor = new Visitors(4, "test4", "test4", "test4", DateTime.Parse("01/04/2017"), 4, 4);

            // Update the table with the updated admission (id = 1)
            myTable.UpdateItem(updatedVisitor);

            // Now read the admission back out and compare it to the updatedAdmission above.
            myTable.ReadListById(4);

            foreach (var visitor in myTable.ItemList)
            {
                Assert.That(visitor.visitorId, Is.EqualTo(updatedVisitor.visitorId));
                Assert.That(visitor.lastName, Is.EqualTo(updatedVisitor.lastName));
                Assert.That(visitor.firstName, Is.EqualTo(updatedVisitor.firstName));
                Assert.That(visitor.relation, Is.EqualTo(updatedVisitor.relation));
                Assert.That(visitor.lastVisit, Is.EqualTo(updatedVisitor.lastVisit));
                Assert.That(visitor.patientId, Is.EqualTo(updatedVisitor.patientId));
                Assert.That(visitor.caseId, Is.EqualTo(updatedVisitor.caseId));
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
