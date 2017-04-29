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
    class BillsTableTests
    {
        BillsTable myTable;
        List<Bills> myList;
        ICompare<Bills> comparer;

        [SetUp]
        public void SetupTests()
        {
            myTable = new BillsTable();
            myList = new List<Bills>()
            {
                new Bills("1.99", "2.99", "3.99", "4.99", DateTime.Parse("01/01/2017"), DateTime.Parse("12/01/2017"), 1, 1),
                new Bills("1.99", "2.99", "3.99", "4.99", DateTime.Parse("01/02/2017"), DateTime.Parse("12/02/2017"), 2, 2),
                new Bills("1.99", "2.99", "3.99", "4.99", DateTime.Parse("01/03/2017"), DateTime.Parse("12/03/2017"), 3, 3)
            };
            comparer = new BillsComparer();

            // Establish Connection String
            ConnectionsManager.SQLServerConnectionString = "Data Source=CSSA-JEB\\SQLEXPRESS;Initial Catalog=" +
                "PIMSTest;Integrated Security=False;User Id=jwatson;Password=test;MultipleActiveResultSets=True;";

            // Establish connection and close at the end of using
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                // Clear the table before and tests occur
                string clearQuery = "DELETE FROM bills DBCC CHECKIDENT('bills', RESEED, 0)";
                QueryExecutor.ExecuteSqlNonQuery(clearQuery, myConnection);

                // Populate the table with known values before tests occur
                string populationQuery1 = "INSERT INTO bills (amountTotal, amountPaidByPatient, amountPaidByInsurance, amountOwed, dateCharged, " +
                    "dateDue, patientId) VALUES ('1.99', '2.99', '3.99', '4.99', '01/01/2017', '12/01/2017', 1)";
                string populationQuery2 = "INSERT INTO bills (amountTotal, amountPaidByPatient, amountPaidByInsurance, amountOwed, dateCharged, " +
                    "dateDue, patientId) VALUES ('1.99', '2.99', '3.99', '4.99', '01/02/2017', '12/02/2017', 2)";
                string populationQuery3 = "INSERT INTO bills (amountTotal, amountPaidByPatient, amountPaidByInsurance, amountOwed, dateCharged, " +
                    "dateDue, patientId) VALUES ('1.99', '2.99', '3.99', '4.99', '01/03/2017', '12/03/2017', 3)";

                QueryExecutor.ExecuteSqlNonQuery(populationQuery1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery3, myConnection);
            }
        }

        [Test]
        /// <summary>
        /// Read the known values from the database and compare to the knowns in memory.
        /// </summary>
        public void ShouldReadList()
        {
            List<Bills> bills = new List<Bills>();

            bills = myTable.ReadList();

            int i = 0;

            foreach (var bill in bills)
            {
                comparer.Compare(bill, myList[i]);
                i++;
            }
        }

        [Test]
        /// <summary>
        /// Read a known value from the database by its billId and compare to the known value in memory.
        /// </summary>
        public void ShouldReadListById()
        {
            List<Bills> bills = new List<Bills>();

            bills = myTable.ReadListById(myList[0].billId);

            foreach (var bill in bills)
            {
                comparer.Compare(bill, myList[0]);
            }
        }

        [Test]
        /// <summary>
        /// Write known values to the table, retrieve them, compare.
        /// </summary>
        public void ShouldWriteList()
        {
            List<Bills> bills = new List<Bills>();

            myTable.ClearTable();
            myTable.WriteList(myList);
            bills = myTable.ReadList();

            int i = 0;

            foreach (var bill in bills)
            {
                comparer.Compare(bill, myList[i]);
                i++;
            }
        }

        [Test]
        /// <summary>
        /// Write known item to the table, retreive it by billId, compare.
        /// </summary>
        public void ShouldWriteItem()
        {
            List<Bills> bills = new List<Bills>();

            myTable.ClearTable();
            myTable.WriteItem(myList[0]);
            bills = myTable.ReadListById(myList[0].billId);

            foreach (var bill in bills)
            {
                comparer.Compare(bill, myList[0]);
            }
        }

        [Test]
        /// <summary>
        /// Write known values to the table
        /// Call the clear method
        /// Call the count method
        /// Count should be zero
        /// </summary>
        public void ShouldClearTable()
        {
            myTable.ClearTable();
            int recordCount = myTable.CountRows();
            Assert.That(recordCount, Is.EqualTo(0));
        }

        [Test]
        /// <summary>
        /// Write a known value to the table.
        /// Call clear by id method, passing in known id.
        /// Count records in table and compare with zero.
        /// </summary>
        public void ShouldClearTableById()
        {
            myTable.ClearTable();
            myTable.WriteItem(myList[0]);
            myTable.ClearTableById(myList[0].billId);
            int recordCount = myTable.CountRows();
            Assert.That(recordCount, Is.EqualTo(0));
        }

        [Test]
        /// <summary>
        /// Write 3 values to the table.
        /// Call the count rows method.
        /// Result should be 3.
        /// </summary>
        public void ShouldCountRows()
        {
            int recordCount = myTable.CountRows();
            Assert.That(recordCount, Is.EqualTo(3));
        }

        [Test]
        /// <summary>
        /// Write a list of values to the database.
        /// Create a list of known updated values.
        /// Call the updates list method, passing in the known values as the itemlist.
        /// Read the table, comparing item list with known updated values.
        /// </summary>
        public void ShouldUpdateList()
        {
            List<Bills> bills = new List<Bills>();

            // Add updated bills
            Bills newBill1 = new Bills("1.99", "2.99", "3.99", "4.99", DateTime.Parse("01/04/2017"), DateTime.Parse("12/04/2017"), 4, 1);
            Bills newBill2 = new Bills("1.99", "2.99", "3.99", "4.99", DateTime.Parse("01/05/2017"), DateTime.Parse("12/05/2017"), 5, 2);
            Bills newBill3 = new Bills("1.99", "2.99", "3.99", "4.99", DateTime.Parse("01/06/2017"), DateTime.Parse("12/06/2017"), 6, 3);

            myList.Clear();

            myList.Add(newBill1);
            myList.Add(newBill2);
            myList.Add(newBill3);

            myTable.UpdateList(myList);
            bills = myTable.ReadList();

            int i = 0;

            foreach (var bill in bills)
            {
                comparer.Compare(bill, myList[i]);
                i++;
            }
        }

        [Test]
        /// <summary>
        /// Write a value to the database.
        /// Create a known updated bill.
        /// Call the updated item method, passing the known bill as the updated value.
        /// Read the table by the known bill's billId, compare the itemlist with the known updated bill.
        /// </summary>
        public void ShouldUpdateItem()
        {
            List<Bills> bills = new List<Bills>();

            // Add updated bill
            Bills updatedBill = new Bills("1.99", "2.99", "3.99", "4.99", DateTime.Parse("01/04/2017"), DateTime.Parse("12/04/2017"), 4, 1);

            myTable.UpdateItem(updatedBill);
            bills = myTable.ReadListById(updatedBill.billId);

            foreach (var bill in bills)
            {
                comparer.Compare(bill, updatedBill);
            }
        }

        [TearDown]
        public void TearDownTests()
        {
            myTable = null;
            myList = null;
        }
    }
}
