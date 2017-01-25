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
    class AdmissionsTableTests
    {
        AdmissionsTable myTable;
        List<Admission> myList;

        [SetUp]
        public void SetupTest()
        {
            // NOTE: This occurs before each and every test case.

            myTable = new AdmissionsTable();
            myList = new List<Admission>()
            {
                new Admission(1, DateTime.Parse("01/01/2017"), DateTime.Parse("12/01/2017"), "A", "A", "1", "1", "1", "1", 1, 1),
                new Admission(2, DateTime.Parse("01/02/2017"), DateTime.Parse("12/02/2017"), "B", "B", "2", "2", "2", "2", 2, 2),
                new Admission(3, DateTime.Parse("01/03/2017"), DateTime.Parse("12/03/2017"), "C", "C", "3", "3", "3", "3", 3, 3)
            };

            // Establish the connection string
            ConnectionsManager.SQLServerConnectionString = "Data Source=JEBSDESKTOP\\SQLEXPRESS;Initial Catalog=" +
                "PIMSTest;Integrated Security=False;User Id=jwatson;Password=test;MultipleActiveResultSets=True;";

            // Establish a connection and close at the end of using

            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                // Clear the table before any tests occur
                string clearQuery = "DELETE FROM admissions";
                QueryExecutor.ExecuteSqlNonQuery(clearQuery, myConnection);

                // Populate the table with known values before tests occur
                string populationQuery1 = "INSERT INTO admissions (admissionId, admissionTime, dischargeTime, admissionReason, dischargeReason, " +
                    "facilityNumber, floorNumber, roomNumber, bedNumber, patientId, caseId) " +
                    "VALUES (1, '01/01/2017', '12/01/2017', 'A', 'A', '1', '1', '1', '1', 1, 1)";
                string populationQuery2 = "INSERT INTO admissions (admissionId, admissionTime, dischargeTime, admissionReason, dischargeReason, " +
                    "facilityNumber, floorNumber, roomNumber, bedNumber, patientId, caseId) " +
                    "VALUES (2, '01/02/2017', '12/02/2017', 'B', 'B', '2', '2', '2', '2', 2, 2)";
                string populationQuery3 = "INSERT INTO admissions (admissionId, admissionTime, dischargeTime, admissionReason, dischargeReason, " +
                    "facilityNumber, floorNumber, roomNumber, bedNumber, patientId, caseId) " +
                    "VALUES (3, '01/03/2017', '12/03/2017', 'C', 'C', '3', '3', '3', '3', 3, 3)";

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

            foreach (var admission in myTable.ItemList)
            {
                Assert.That(admission.admissionId, Is.EqualTo(myList[i].admissionId));
                Assert.That(admission.admissionTime, Is.EqualTo(myList[i].admissionTime));
                Assert.That(admission.dischargeTime, Is.EqualTo(myList[i].dischargeTime));
                Assert.That(admission.admissionReason, Is.EqualTo(myList[i].admissionReason));
                Assert.That(admission.dischargeReason, Is.EqualTo(myList[i].dischargeReason));
                Assert.That(admission.facilityNumber, Is.EqualTo(myList[i].facilityNumber));
                Assert.That(admission.floorNumber, Is.EqualTo(myList[i].floorNumber));
                Assert.That(admission.roomNumber, Is.EqualTo(myList[i].roomNumber));
                Assert.That(admission.bedNumber, Is.EqualTo(myList[i].bedNumber));
                Assert.That(admission.patientId, Is.EqualTo(myList[i].patientId));
                Assert.That(admission.caseId, Is.EqualTo(myList[i].caseId));
                i++;
            }
        }

        [Test]
        public void ShouldReadListById()
        {
            // Read from a pre-populated test database and compare results.
            myTable.ReadListById(1);

            foreach (var admission in myTable.ItemList)
            {
                Assert.That(admission.admissionId, Is.EqualTo(myList[0].admissionId));
                Assert.That(admission.admissionTime, Is.EqualTo(myList[0].admissionTime));
                Assert.That(admission.dischargeTime, Is.EqualTo(myList[0].dischargeTime));
                Assert.That(admission.admissionReason, Is.EqualTo(myList[0].admissionReason));
                Assert.That(admission.dischargeReason, Is.EqualTo(myList[0].dischargeReason));
                Assert.That(admission.facilityNumber, Is.EqualTo(myList[0].facilityNumber));
                Assert.That(admission.floorNumber, Is.EqualTo(myList[0].floorNumber));
                Assert.That(admission.roomNumber, Is.EqualTo(myList[0].roomNumber));
                Assert.That(admission.bedNumber, Is.EqualTo(myList[0].bedNumber));
                Assert.That(admission.patientId, Is.EqualTo(myList[0].patientId));
                Assert.That(admission.caseId, Is.EqualTo(myList[0].caseId));
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

            foreach (var admission in myTable.ItemList)
            {
                Assert.That(admission.admissionId, Is.EqualTo(myList[i].admissionId));
                Assert.That(admission.admissionTime, Is.EqualTo(myList[i].admissionTime));
                Assert.That(admission.dischargeTime, Is.EqualTo(myList[i].dischargeTime));
                Assert.That(admission.admissionReason, Is.EqualTo(myList[i].admissionReason));
                Assert.That(admission.dischargeReason, Is.EqualTo(myList[i].dischargeReason));
                Assert.That(admission.facilityNumber, Is.EqualTo(myList[i].facilityNumber));
                Assert.That(admission.floorNumber, Is.EqualTo(myList[i].floorNumber));
                Assert.That(admission.roomNumber, Is.EqualTo(myList[i].roomNumber));
                Assert.That(admission.bedNumber, Is.EqualTo(myList[i].bedNumber));
                Assert.That(admission.patientId, Is.EqualTo(myList[i].patientId));
                Assert.That(admission.caseId, Is.EqualTo(myList[i].caseId));
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

            foreach (var admission in myTable.ItemList)
            {
                Assert.That(admission.admissionId, Is.EqualTo(myList[1].admissionId));
                Assert.That(admission.admissionTime, Is.EqualTo(myList[1].admissionTime));
                Assert.That(admission.dischargeTime, Is.EqualTo(myList[1].dischargeTime));
                Assert.That(admission.admissionReason, Is.EqualTo(myList[1].admissionReason));
                Assert.That(admission.dischargeReason, Is.EqualTo(myList[1].dischargeReason));
                Assert.That(admission.facilityNumber, Is.EqualTo(myList[1].facilityNumber));
                Assert.That(admission.floorNumber, Is.EqualTo(myList[1].floorNumber));
                Assert.That(admission.roomNumber, Is.EqualTo(myList[1].roomNumber));
                Assert.That(admission.bedNumber, Is.EqualTo(myList[1].bedNumber));
                Assert.That(admission.patientId, Is.EqualTo(myList[1].patientId));
                Assert.That(admission.caseId, Is.EqualTo(myList[1].caseId));
            }
        }

        [Test]
        public void ShouldUpdateList()
        {
            // Need some updated data
            Admission updated1 = new Admission(1, DateTime.Parse("01/01/2017"), DateTime.Parse("12/01/2017"), "D", "D", "1", "1", "1", "1", 1, 1);
            Admission updated2 = new Admission(2, DateTime.Parse("01/02/2017"), DateTime.Parse("12/02/2017"), "E", "E", "2", "2", "2", "2", 2, 2);
            Admission updated3 = new Admission(3, DateTime.Parse("01/03/2017"), DateTime.Parse("12/03/2017"), "F", "F", "3", "3", "3", "3", 3, 3);

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
                Assert.That(admission.admissionId, Is.EqualTo(myList[i].admissionId));
                Assert.That(admission.admissionTime, Is.EqualTo(myList[i].admissionTime));
                Assert.That(admission.dischargeTime, Is.EqualTo(myList[i].dischargeTime));
                Assert.That(admission.admissionReason, Is.EqualTo(myList[i].admissionReason));
                Assert.That(admission.dischargeReason, Is.EqualTo(myList[i].dischargeReason));
                Assert.That(admission.facilityNumber, Is.EqualTo(myList[i].facilityNumber));
                Assert.That(admission.floorNumber, Is.EqualTo(myList[i].floorNumber));
                Assert.That(admission.roomNumber, Is.EqualTo(myList[i].roomNumber));
                Assert.That(admission.bedNumber, Is.EqualTo(myList[i].bedNumber));
                Assert.That(admission.patientId, Is.EqualTo(myList[i].patientId));
                Assert.That(admission.caseId, Is.EqualTo(myList[i].caseId));
                i++;
            }

        }

        [Test]
        public void ShouldUpdateItem()
        {
            // Need some updated data
            Admission updatedAdmission = new Admission(1, DateTime.Parse("01/01/2017"), DateTime.Parse("12/01/2017"), 
                "Z", "Z", "1", "1", "1", "1", 1, 1);
            
            // Update the table with the updated admission (id = 1)
            myTable.UpdateItem(updatedAdmission);

            // Now read the admission back out and compare it to the updatedAdmission above.
            myTable.ReadListById(1);

            foreach (var admission in myTable.ItemList)
            {
                Assert.That(admission.admissionId, Is.EqualTo(updatedAdmission.admissionId));
                Assert.That(admission.admissionTime, Is.EqualTo(updatedAdmission.admissionTime));
                Assert.That(admission.dischargeTime, Is.EqualTo(updatedAdmission.dischargeTime));
                Assert.That(admission.admissionReason, Is.EqualTo(updatedAdmission.admissionReason));
                Assert.That(admission.dischargeReason, Is.EqualTo(updatedAdmission.dischargeReason));
                Assert.That(admission.facilityNumber, Is.EqualTo(updatedAdmission.facilityNumber));
                Assert.That(admission.floorNumber, Is.EqualTo(updatedAdmission.floorNumber));
                Assert.That(admission.roomNumber, Is.EqualTo(updatedAdmission.roomNumber));
                Assert.That(admission.bedNumber, Is.EqualTo(updatedAdmission.bedNumber));
                Assert.That(admission.patientId, Is.EqualTo(updatedAdmission.patientId));
                Assert.That(admission.caseId, Is.EqualTo(updatedAdmission.caseId));
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
