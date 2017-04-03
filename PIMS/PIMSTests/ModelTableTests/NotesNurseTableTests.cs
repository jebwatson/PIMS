using DBI;
using DBI.Utilities;
using NUnit.Framework;
using PIMSTests.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSTests.ModelTableTests
{
    [TestFixture]
    class NotesNurseTableTests
    {
        NotesNurseTable myTable;
        List<NotesNurse> myList;
        ICompare<NotesNurse> Comparer;

        [SetUp]
        public void SetupTest()
        {
            // NOTE: This occurs before each and every test case.

            myTable = new NotesNurseTable();
            myList = new List<NotesNurse>()
            {
                new NotesNurse(4, "this is a note", 4, 4, 4),
                new NotesNurse(5, "", 5, 5, 5),
                new NotesNurse(6, "this is a much longer note, which is opposite of the last, null note", 6, 6, 6)
            };

            Comparer = new NotesNurseComparer();

            // Establish the connection string
            ConnectionsManager.SQLServerConnectionString = "Data Source=JEBSDESKTOP\\SQLEXPRESS;Initial Catalog=" +
                "PIMSTest;Integrated Security=False;User Id=jwatson;Password=test;MultipleActiveResultSets=True;";

            // Establish a connection and close at the end of using

            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                // Clear the table before any tests occur
                string clearQuery = "DELETE FROM notesNurse";
                QueryExecutor.ExecuteSqlNonQuery(clearQuery, myConnection);

                // Populate the table with known values before tests occur
                string populationQuery1 = "INSERT INTO notesNurse (notesId, notes, nurseId, patientId, caseId) " +
                    "VALUES (4, 'this is a note', 4, 4, 4)";
                string populationQuery2 = "INSERT INTO notesNurse (notesId, notes, nurseId, patientId, caseId) " +
                    "VALUES (5, '', 5, 5, 5)";
                string populationQuery3 = "INSERT INTO notesNurse (notesId, notes, nurseId, patientId, caseId) " +
                    "VALUES (6, 'this is a much longer note, which is opposite of the last, null note', 6, 6, 6)";

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

            foreach (var ec in myTable.ItemList)
            {
                Comparer.Compare(ec, myTable.ItemList[i]);
                i++;
            }
        }

        [Test]
        public void ShouldReadListById()
        {
            // Read from a pre-populated test database and compare results.
            myTable.ReadListById(1);
            Comparer.Compare(myTable.ItemList[0], myList[0]);
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
                Comparer.Compare(admission, myTable.ItemList[i]);
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
            Comparer.Compare(myTable.ItemList[0], myList[0]);
        }

        [Test]
        public void ShouldUpdateList()
        {
            // Need some updated data
            NotesNurse updated1 = new NotesNurse(4, "note", 4, 4, 4);
            NotesNurse updated2 = new NotesNurse(5, "this note now gets to be a longer note for probably not a lot of reason while the next one will be null", 5, 5, 5);
            NotesNurse updated3 = new NotesNurse(6, "", 6, 6, 6);

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
                Comparer.Compare(admission, myList[i]);
                i++;
            }

        }

        [Test]
        public void ShouldUpdateItem()
        {
            // Need some updated data
            NotesNurse updatedNotesNurse = new NotesNurse(4, "omg this dork made a matrix reference lol", 4, 4, 4);

            // Update the table with the updated admission (id = 1)
            myTable.UpdateItem(updatedNotesNurse);

            // Now read the admission back out and compare it to the updatedAdmission above.
            myTable.ReadListById(1);
            Comparer.Compare(myTable.ItemList[0], updatedNotesNurse);
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
