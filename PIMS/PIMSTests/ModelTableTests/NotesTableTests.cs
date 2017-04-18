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
    class NotesTableTests
    {
        NotesTable myTable;
        List<Notes> myList;
        ICompare<Notes> Comparer;

        [SetUp]
        public void SetupTest()
        {
            // NOTE: This occurs before each and every test case.

            myTable = new NotesTable();
            myList = new List<Notes>()
            {
                new Notes("note1", true, false, 1, 1),
                new Notes("note2", false, true, 2, 2),
                new Notes("note3", true, false, 3, 3)
            };

            Comparer = new NotesComparer();

            // Establish the connection string
            ConnectionsManager.SQLServerConnectionString = "Data Source=ALEX\\SQLEXPRESS;Initial Catalog=" +
                "PIMSTest;Integrated Security=False;User Id=jwatson;Password=test;MultipleActiveResultSets=True;";

            // Establish a connection and close at the end of using

            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                // Clear the table before any tests occur
                string clearQuery = "DELETE FROM notesDoctor";
                QueryExecutor.ExecuteSqlNonQuery(clearQuery, myConnection);

                // Populate the table with known values before tests occur
                string populationQuery1 = "INSERT INTO notesDoctor (notes, doctor, nurse, doctorId, patientId) " +
                    "VALUES ('note1', 'true', 'false', 1, 1)";
                string populationQuery2 = "INSERT INTO notesDoctor (notes, doctor, nurse, doctorId, patientId) " +
                    "VALUES ('note2', 'false', 'true', 2, 2)";
                string populationQuery3 = "INSERT INTO notesDoctor (notes, doctor, nurse, doctorId, patientId) " +
                    "VALUES ('note3', 'true', 'false', 3, 3)";

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
            Notes updated1 = new Notes("note", false, true, 1, 1);
            Notes updated2 = new Notes("this note now gets to be a longer note", true, false, 2, 2);
            Notes updated3 = new Notes("longish note", false, true, 3, 3);

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
            Notes updatedNotesDoctor = new Notes("omg this dork made a matrix reference lol", false, true, 1, 1);

            // Update the table with the updated admission (id = 1)
            myTable.UpdateItem(updatedNotesDoctor);

            // Now read the admission back out and compare it to the updatedAdmission above.
            myTable.ReadListById(1);
            Comparer.Compare(myTable.ItemList[0], updatedNotesDoctor);
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

