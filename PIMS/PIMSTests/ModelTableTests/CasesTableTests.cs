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
    class CasesTableTests
    {
        CasesTable myTable;
        List<Cases> myList;

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

            // Establish the connection string
            ConnectionsManager.SQLServerConnectionString = "Data Source=JEBSDESKTOP\\SQLEXPRESS;Initial Catalog=" +
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
            // Read from a pre-populated test database and compare results.
            myTable.ReadList();

            int i = 0;

            foreach (var cases in myTable.ItemList)
            {
                Assert.That(cases.caseId, Is.EqualTo(myList[i].caseId));
                Assert.That(cases.supervisingDoctorId, Is.EqualTo(myList[i].supervisingDoctorId));
                Assert.That(cases.approvedVisitorCount, Is.EqualTo(myList[i].approvedVisitorCount));
                Assert.That(cases.patientId, Is.EqualTo(myList[i].patientId));
                i++;
            }
        }

        [Test]
        public void ShouldReadListById()
        {
            // Read from a pre-populated test database and compare results.
            myTable.ReadListById(1);

            foreach (var cases in myTable.ItemList)
            {
                Assert.That(cases.caseId, Is.EqualTo(myList[0].caseId));
                Assert.That(cases.supervisingDoctorId, Is.EqualTo(myList[0].supervisingDoctorId));
                Assert.That(cases.approvedVisitorCount, Is.EqualTo(myList[0].approvedVisitorCount));
                Assert.That(cases.patientId, Is.EqualTo(myList[0].patientId));
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

            foreach (var cases in myTable.ItemList)
            {
                Assert.That(cases.caseId, Is.EqualTo(myList[i].caseId));
                Assert.That(cases.supervisingDoctorId, Is.EqualTo(myList[i].supervisingDoctorId));
                Assert.That(cases.approvedVisitorCount, Is.EqualTo(myList[i].approvedVisitorCount));
                Assert.That(cases.patientId, Is.EqualTo(myList[i].patientId));
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
            myTable.ReadList();

            foreach (var cases in myTable.ItemList)
            {
                Assert.That(cases.caseId, Is.EqualTo(myList[1].caseId));
                Assert.That(cases.supervisingDoctorId, Is.EqualTo(myList[1].supervisingDoctorId));
                Assert.That(cases.approvedVisitorCount, Is.EqualTo(myList[1].approvedVisitorCount));
                Assert.That(cases.patientId, Is.EqualTo(myList[1].patientId));
            }
        }

        [Test]
        public void ShouldUpdateList()
        {
            // Need some updated data
            Cases updated1 = new Cases(4, 2, 2, 4);
            Cases updated2 = new Cases(5, 2, 2, 5);
            Cases updated3 = new Cases(6, 2, 2, 6);

            myList.Clear();

            myList.Add(updated1);
            myList.Add(updated2);
            myList.Add(updated3);

            myTable.ItemList = myList;
            myTable.UpdateList();

            // Now read the table back out and compare to myList
            myTable.ReadList();

            int i = 0;

            foreach (var admission in myTable.ItemList)
            {
                Assert.That(admission.caseId, Is.EqualTo(myList[i].caseId));
                Assert.That(admission.supervisingDoctorId, Is.EqualTo(myList[i].supervisingDoctorId));
                Assert.That(admission.approvedVisitorCount, Is.EqualTo(myList[i].approvedVisitorCount));
                Assert.That(admission.patientId, Is.EqualTo(myList[i].patientId));
                i++;
            }

        }

        [Test]
        public void ShouldUpdateItem()
        {
            // Need some updated data
            Cases updatedCase = new Cases(7, 3, 3, 7);

            // Update the table with the updated admission (id = 1)
            myTable.UpdateItem(updatedCase);

            // Now read the admission back out and compare it to the updatedAdmission above.
            myTable.ReadListById(1);

            foreach (var cases in myTable.ItemList)
            {
                Assert.That(cases.caseId, Is.EqualTo(updatedCase.caseId));
                Assert.That(cases.supervisingDoctorId, Is.EqualTo(updatedCase.supervisingDoctorId));
                Assert.That(cases.approvedVisitorCount, Is.EqualTo(updatedCase.approvedVisitorCount));
                Assert.That(cases.patientId, Is.EqualTo(updatedCase.patientId));
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
