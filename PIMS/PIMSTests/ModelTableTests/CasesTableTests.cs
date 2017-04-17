using System.Collections.Generic;
using NUnit.Framework;
using DBI;
using DBI.Utilities;
using System.Data.SqlClient;
using PIMSTests.Helpers;

namespace PIMSTests.ModelTableTests
{
    [TestFixture]
    class CasesTableTests
    {
        CasesTable myTable;
        List<Cases> myList;
        ICompare<Cases> comparer;

        [SetUp]
        public void SetupTest()
        {
            // NOTE: This occurs before each and every test case.

            myTable = new CasesTable();
            myList = new List<Cases>()
            {
                new Cases(1, 1, 1, 1),
                new Cases(2, 1, 1, 2),
                new Cases(3, 1, 1, 3)
            };
            comparer = new CasesComparer();

            // Establish the connection string
            ConnectionsManager.SQLServerConnectionString = "Data Source=CSSA-JEB\\SQLEXPRESS;Initial Catalog=" +
                "PIMSTest;Integrated Security=False;User Id=jwatson;Password=test;MultipleActiveResultSets=True;";

            // Establish a connection and close at the end of using

            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                // Clear the table before any tests occur
                string clearQuery = "DELETE FROM cases";
                QueryExecutor.ExecuteSqlNonQuery(clearQuery, myConnection);

                // Populate the table with known values before tests occur
                string populationQuery1 = "INSERT INTO cases (caseId, supervisingDoctorId, approvedVisitorCount, patientId) " +
                    "VALUES (1, 1, 1, 1)";
                string populationQuery2 = "INSERT INTO cases (caseId, supervisingDoctorId, approvedVisitorCount, patientId) " +
                    "VALUES (2, 1, 1, 2)";
                string populationQuery3 = "INSERT INTO cases (caseId, supervisingDoctorId, approvedVisitorCount, patientId) " +
                    "VALUES (3, 1, 1, 3)";

                QueryExecutor.ExecuteSqlNonQuery(populationQuery1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery3, myConnection);
            }
        }

        [Test]
        public void ShouldReadList()
        {
            List<Cases> cases = new List<Cases>();

            // Read from a pre-populated test database and compare results.
            cases = myTable.ReadList();

            int i = 0;

            foreach (var @case in cases)
            {
                comparer.Compare(@case, myList[i]);
                i++;
            }
        }

        [Test]
        public void ShouldReadListById()
        {
            List<Cases> cases = new List<Cases>();

            // Read from a pre-populated test database and compare results.
            cases = myTable.ReadListById(1);

            foreach (var @case in cases)
            {
                comparer.Compare(@case, myList[0]);
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
            List<Cases> cases = new List<Cases>();

            myTable.ClearTableById(1);
            int recordCount = myTable.CountRows();
            cases = myTable.ReadListById(1);
            int missingRecordCount = cases.Count;
            Assert.That(recordCount, Is.EqualTo(2));
            Assert.That(missingRecordCount, Is.EqualTo(0));
        }

        [Test]
        public void ShouldWriteList()
        {
            List<Cases> cases = new List<Cases>();

            myTable.ClearTable();
            myTable.WriteList(myList);
            cases = myTable.ReadList();

            int i = 0;

            foreach (var @case in cases)
            {
                comparer.Compare(@case, myList[i]);
                i++;
            }
        }

        [Test]
        public void ShouldWriteItem()
        {
            List<Cases> cases = new List<Cases>();

            myTable.ClearTable();
            myTable.WriteItem(myList[1]);
            cases = myTable.ReadList();

            foreach (var @case in cases)
            {
                comparer.Compare(@case, myList[1]);
            }
        }

        [Test]
        public void ShouldUpdateList()
        {
            List<Cases> cases = new List<Cases>();

            // Need some updated data
            Cases updated1 = new Cases(1, 2, 2, 4);
            Cases updated2 = new Cases(2, 2, 2, 5);
            Cases updated3 = new Cases(3, 2, 2, 6);

            myList.Clear();

            myList.Add(updated1);
            myList.Add(updated2);
            myList.Add(updated3);

            myTable.UpdateList(myList);
            cases = myTable.ReadList();

            int i = 0;

            foreach (var @case in cases)
            {
                comparer.Compare(@case, myList[i]);
                i++;
            }

        }

        [Test]
        public void ShouldUpdateItem()
        {
            List<Cases> cases = new List<Cases>();

            // Need some updated data
            Cases updatedCase = new Cases(7, 3, 3, 7);

            // Update the table with the updated admission (id = 1)
            myTable.UpdateItem(updatedCase);

            // Now read the admission back out and compare it to the updatedAdmission above.
            cases = myTable.ReadListById(1);

            foreach (var @case in cases)
            {
                comparer.Compare(@case, updatedCase);
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
