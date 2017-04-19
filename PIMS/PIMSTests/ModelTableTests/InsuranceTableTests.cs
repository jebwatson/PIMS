using System.Collections.Generic;
using NUnit.Framework;
using DBI;
using PIMSTests.Helpers;
using DBI.Utilities;
using System.Data.SqlClient;

namespace PIMSTests.ModelTableTests
{
    [TestFixture]
    class InsuranceTableTests
    {
        InsuranceTable myTable;
        List<Insurance> myList;
        List<Insurance> myList2;
        ICompare<Insurance> comparer;

        [SetUp]
        public void SetupTest()
        {
            // NOTE: This occurs before each and every test case.

            myTable = new InsuranceTable();
            myList = new List<Insurance>()
            {
                new Insurance("A", "1", "1", 1),
                new Insurance("B", "2", "2", 2),
                new Insurance("C", "3", "3", 3)
            };

            myList2 = new List<Insurance>
            {
                new Insurance("D", "4", "4", 4),
                new Insurance("E", "5", "5", 5),
                new Insurance("F", "6", "6", 6)
            };

            comparer = new InsuranceComparer();

            // Establish the connection string
            ConnectionsManager.SQLServerConnectionString = "Data Source=CSSA-JEB\\SQLEXPRESS;Initial Catalog=" +
                "PIMSTest;Integrated Security=False;User Id=jwatson;Password=test;MultipleActiveResultSets=True;";

            // Establish a connection and close at the end of using

            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                // Clear the table before any tests occur
                string clearQuery = "DELETE FROM insurance";
                QueryExecutor.ExecuteSqlNonQuery(clearQuery, myConnection);

                // Populate the table with known values before tests occur
                string populationQuery1 = "INSERT INTO insurance (insuranceCarrier, accountNumber, groupNumber, patientId) " +
                    "VALUES ('A', '1', '1', 1)";
                string populationQuery2 = "INSERT INTO insurance (insuranceCarrier, accountNumber, groupNumber, patientId) " +
                    "VALUES ('B', '2', '2', 2)";
                string populationQuery3 = "INSERT INTO insurance (insuranceCarrier, accountNumber, groupNumber, patientId) " +
                    "VALUES ('C', '3', '3', 3)";

                QueryExecutor.ExecuteSqlNonQuery(populationQuery1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery3, myConnection);
            }
        }

        [Test]
        public void ShouldReadList()
        {
            List<Insurance> insurances = new List<Insurance>();

            // Read from a pre-populated test database and compare results.
            insurances = myTable.ReadList();

            int i = 0;

            foreach (var item in insurances)
            {
                comparer.Compare(item, myList[i]);
                i++;
            }
        }

        [Test]
        public void ShouldReadListById()
        {
            List<Insurance> insurances = new List<Insurance>();

            // Read from a pre-populated test database and compare results.
            insurances = myTable.ReadListById(1);
            comparer.Compare(insurances[0], myList[0]);
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
            List<Insurance> insurances = new List<Insurance>();
            myTable.ClearTableById(1);
            int recordCount = myTable.CountRows();
            insurances = myTable.ReadListById(1);
            int missingRecordCount = insurances.Count;
            Assert.That(recordCount, Is.EqualTo(2));
            Assert.That(missingRecordCount, Is.EqualTo(0));
        }

        [Test]
        public void ShouldWriteList()
        {
            List<Insurance> insurances = new List<Insurance>();

            // Need to clear the table first
            myTable.ClearTable();

            // Write some records to the table then retrieve them using previously tested
            // read methods. Compare with original records.
            myTable.WriteList(myList);
            insurances = myTable.ReadList();

            int i = 0;

            foreach (var item in insurances)
            {
                comparer.Compare(item, myList[i]);
                i++;
            }
        }

        [Test]
        public void ShouldWriteItem()
        {
            List<Insurance> insurances = new List<Insurance>();

            // Need to clear the table first
            myTable.ClearTable();

            // Write a record to the table then retrieve it using previously tested
            // read methods. Compare with original record.
            myTable.WriteItem(myList[0]);
            insurances = myTable.ReadList();
            comparer.Compare(insurances[0], myList[0]);
        }

        [Test]
        public void ShouldUpdateList()
        {
            List<Insurance> insurances = new List<Insurance>();

            myList.Clear();

            myTable.UpdateList(myList2);

            // Now read the table back out and compare to myList
            insurances = myTable.ReadList();

            int i = 0;

            foreach (var item in insurances)
            {
                comparer.Compare(item, myList2[i]);
                i++;
            }

        }

        [Test]
        public void ShouldUpdateItem()
        {
            List<Insurance> insurances = new List<Insurance>();

            // Update the table with the updated admission (id = 1)
            myTable.UpdateItem(myList2[0]);

            // Now read the admission back out and compare it to the updatedAdmission above.
            insurances = myTable.ReadListById(1);
            comparer.Compare(insurances[0], myList2[0]);
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
