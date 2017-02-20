using DBI;
using DBI.Utilities;
using NUnit.Framework;
using PIMSTests.Helpers;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PIMSTests.ModelTableTests
{
    [TestFixture]
    class EmergencyContactTableTests
    {
        EmergencyContactTable myTable;
        List<EmergencyContact> myList;
        ICompare<EmergencyContact> comparer;

        [SetUp]
        public void SetupTest()
        {
            // NOTE: This occurs before each and every test case.

            myTable = new EmergencyContactTable();
            myList = new List<EmergencyContact>()
            {
                new EmergencyContact(1, "Watson", "Jeb", "W", "8076874", "205", 1),
                new EmergencyContact(2, "Burcham", "David", "A", "1111111", "256", 1),
                new EmergencyContact(3, "Morrow", "Jasper", "A", "2222222", "256", 1)
            };

            comparer = new EmergencyContactComparer();

            // Establish the connection string
            ConnectionsManager.SQLServerConnectionString = "Data Source=JEBSDESKTOP\\SQLEXPRESS;Initial Catalog=" +
                "PIMSTest;Integrated Security=False;User Id=jwatson;Password=test;MultipleActiveResultSets=True;";

            // Establish a connection and close at the end of using

            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                // Clear the table before any tests occur
                string clearQuery = "DELETE FROM emergencyContact";
                QueryExecutor.ExecuteSqlNonQuery(clearQuery, myConnection);

                // Populate the table with known values before tests occur
                string populationQuery1 = "INSERT INTO emergencyContact (emergencyContactId, nameLast, nameFirst, nameMiddle, phone, areaCode, patientId) " +
                    "VALUES (1, 'Watson', 'Jeb', 'W', '8076874', '205', 1)";
                string populationQuery2 = "INSERT INTO emergencyContact (emergencyContactId, nameLast, nameFirst, nameMiddle, phone, areaCode, patientId) " +
                    "VALUES (2, 'Burcham', 'David', 'A', '1111111', '256', 1)";
                string populationQuery3 = "INSERT INTO emergencyContact (emergencyContactId, nameLast, nameFirst, nameMiddle, phone, areaCode, patientId) " +
                    "VALUES (3, 'Morrow', 'Jasper', 'A', '2222222', '256', 1)";

                QueryExecutor.ExecuteSqlNonQuery(populationQuery1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery3, myConnection);
            }
        }

        [Test]
        public void ShouldReadList()
        {
            List<EmergencyContact> contacts = new List<EmergencyContact>();

            // Read from a pre-populated test database and compare results.
            contacts = myTable.ReadList();

            int i = 0;

            foreach (var ec in contacts)
            {
                comparer.Compare(ec, myList[i]);
                i++;
            }
        }

        [Test]
        public void ShouldReadListById()
        {
            List<EmergencyContact> contacts = new List<EmergencyContact>();

            // Read from a pre-populated test database and compare results.
            contacts = myTable.ReadListById(1);
            comparer.Compare(contacts[0], myList[0]);
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
            List<EmergencyContact> contacts = new List<EmergencyContact>();
            myTable.ClearTableById(1);
            int recordCount = myTable.CountRows();
            contacts = myTable.ReadListById(1);
            int missingRecordCount = contacts.Count;
            Assert.That(recordCount, Is.EqualTo(2));
            Assert.That(missingRecordCount, Is.EqualTo(0));
        }

        [Test]
        public void ShouldWriteList()
        {
            List<EmergencyContact> contacts = new List<EmergencyContact>();

            // Need to clear the table first
            myTable.ClearTable();

            // Write some records to the table then retrieve them using previously tested
            // read methods. Compare with original records.
            myTable.WriteList(myList);
            contacts = myTable.ReadList();

            int i = 0;

            foreach (var contact in contacts)
            {
                comparer.Compare(contact, myList[i]);
                i++;
            }
        }

        [Test]
        public void ShouldWriteItem()
        {
            List<EmergencyContact> contacts = new List<EmergencyContact>();

            // Need to clear the table first
            myTable.ClearTable();

            // Write a record to the table then retrieve it using previously tested
            // read methods. Compare with original record.
            myTable.WriteItem(myList[0]);
            contacts = myTable.ReadList();
            comparer.Compare(contacts[0], myList[0]);
        }

        [Test]
        public void ShouldUpdateList()
        {
            List<EmergencyContact> contacts = new List<EmergencyContact>();

            // Need some updated data
            EmergencyContact updated1 = new EmergencyContact(1, "Majors", "John", "E", "3333333", "205", 1);
            EmergencyContact updated2 = new EmergencyContact(2, "Stevens", "Chris", "A", "4444444", "256", 1);
            EmergencyContact updated3 = new EmergencyContact(3, "Kane", "Alex", "A", "5555555", "256", 1);

            myList.Clear();

            myList.Add(updated1);
            myList.Add(updated2);
            myList.Add(updated3);

            myTable.UpdateList(myList);

            // Now read the table back out and compare to myList
            contacts = myTable.ReadList();

            int i = 0;

            foreach (var contact in contacts)
            {
                comparer.Compare(contact, myList[i]);
                i++;
            }

        }

        [Test]
        public void ShouldUpdateItem()
        {
            List<EmergencyContact> contacts = new List<EmergencyContact>();

            // Need some updated data
            EmergencyContact updatedEmergencyContact = new EmergencyContact(1, "Matrix", "Neo", "M", "1010110", "110", 1);

            // Update the table with the updated admission (id = 1)
            myTable.UpdateItem(updatedEmergencyContact);

            // Now read the admission back out and compare it to the updatedAdmission above.
            contacts = myTable.ReadListById(1);
            comparer.Compare(contacts[0], updatedEmergencyContact);
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
