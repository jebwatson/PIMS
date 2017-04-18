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
    class ChargesTableTests
    {
        ChargesTable myTable;
        List<Charges> myList;
        ICompare<Charges> comparer;

        [SetUp]
        public void SetupTest()
        {
            // NOTE: This occurs before each and every test case.

            myTable = new ChargesTable();
            myList = new List<Charges>()
            {
                new Charges("test1", "1.99", DateTime.Parse("01/01/2017"), DateTime.Parse("12/01/2017"), 1, 1, 1),
                new Charges("test2", "1.99", DateTime.Parse("01/02/2017"), DateTime.Parse("12/02/2017"), 2, 2, 2),
                new Charges("test3", "1.99", DateTime.Parse("01/03/2017"), DateTime.Parse("12/03/2017"), 3, 3, 3)
            };
            comparer = new ChargesComparer();

            // Establish the connection string
            ConnectionsManager.SQLServerConnectionString = "Data Source=ALEX\\SQLEXPRESS;Initial Catalog=" +
                "PIMSTest;Integrated Security=False;User Id=jwatson;Password=test;MultipleActiveResultSets=True;";

            // Establish a connection and close at the end of using

            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                // Clear the table before any tests occur
                string clearQuery = "DELETE FROM charges";
                QueryExecutor.ExecuteSqlNonQuery(clearQuery, myConnection);

                // Populate the table with known values before tests occur
                string populationQuery1 = "INSERT INTO charges (description, amountTotal, dateCharged, " +
                    "dateDue, procedureId, officeStaffId, patientId) " +
                    "VALUES ('test1', '1.99', '01/01/2017', '12/01/2017', 1, 1, 1)";
                string populationQuery2 = "INSERT INTO charges (description, amountTotal, dateCharged, " +
                    "dateDue, procedureId, officeStaffId, patientId) " +
                    "VALUES ('test2', '1.99', '01/02/2017', '12/02/2017', 2, 2, 2)";
                string populationQuery3 = "INSERT INTO charges (description, amountTotal, dateCharged, " +
                    "dateDue, procedureId, officeStaffId, patientId) " +
                    "VALUES ('test3', '1.99', '01/03/2017', '12/03/2017', 3, 3, 3)";

                QueryExecutor.ExecuteSqlNonQuery(populationQuery1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery3, myConnection);
            }
        }

        [Test]
        public void ShouldReadList()
        {
            List<Charges> charges = new List<Charges>();

            // Read from a pre-populated test database and compare results.
            charges = myTable.ReadList();

            int i = 0;

            foreach (var charge in charges)
            {
                comparer.Compare(charge, myList[i]);
                i++;
            }
        }

        [Test]
        public void ShouldReadListById()
        {
            List<Charges> charges = new List<Charges>();

            // Read from a pre-populated test database and compare results.
            charges = myTable.ReadListById(1);

            foreach (var charge in charges)
            {
                comparer.Compare(charge, myList[0]);
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
            List<Charges> charges = new List<Charges>();
            myTable.ClearTableById(1);
            int recordCount = myTable.CountRows();
            charges = myTable.ReadListById(1);
            int missingRecordCount = charges.Count;
            Assert.That(recordCount, Is.EqualTo(2));
            Assert.That(missingRecordCount, Is.EqualTo(0));
        }

        [Test]
        public void ShouldWriteList()
        {
            List<Charges> charges = new List<Charges>();

            // Need to clear the table first
            myTable.ClearTable();

            // Write some records to the table then retrieve them using previously tested
            // read methods. Compare with original records.
            myTable.WriteList(myList);
            charges = myTable.ReadList();

            int i = 0;

            foreach (var charge in charges)
            {
                comparer.Compare(charge, myList[i]);
                i++;
            }
        }

        [Test]
        public void ShouldWriteItem()
        {
            List<Charges> charges = new List<Charges>();

            // Need to clear the table first
            myTable.ClearTable();

            // Write a record to the table then retrieve it using previously tested
            // read methods. Compare with original record.
            myTable.WriteItem(myList[0]);
            charges = myTable.ReadList();

            foreach (var charge in charges)
            {
                comparer.Compare(charge, myList[0]);
            }
        }

        [Test]
        public void ShouldUpdateList()
        {
            List<Charges> charges = new List<Charges>();

            // Need some updated data
            Charges updated1 = new Charges("test4", "1.99", DateTime.Parse("01/04/2017"), DateTime.Parse("12/04/2017"), 4, 4, 4);
            Charges updated2 = new Charges("test5", "1.99", DateTime.Parse("01/05/2017"), DateTime.Parse("12/05/2017"), 5, 5, 5);
            Charges updated3 = new Charges("test6", "1.99", DateTime.Parse("01/06/2017"), DateTime.Parse("12/06/2017"), 6, 6, 6);

            myList.Clear();

            myList.Add(updated1);
            myList.Add(updated2);
            myList.Add(updated3);

            myTable.UpdateList(myList);

            // Now read the table back out and compare to myList
            charges = myTable.ReadList();

            int i = 0;

            foreach (var charge in charges)
            {
                comparer.Compare(charge, myList[i]);
                i++;
            }

        }

        [Test]
        public void ShouldUpdateItem()
        {
            List<Charges> charges = new List<Charges>();

            // Need some updated data
            Charges updatedCharge = new Charges("test4", "1.99", DateTime.Parse("01/04/2017"), DateTime.Parse("12/04/2017"), 4, 4, 4);

            // Update the table with the updated admission (id = 1)
            myTable.UpdateItem(updatedCharge);

            // Now read the admission back out and compare it to the updatedAdmission above.
            charges = myTable.ReadListById(4);

            foreach (var charge in charges)
            {
                comparer.Compare(charge, updatedCharge);
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
