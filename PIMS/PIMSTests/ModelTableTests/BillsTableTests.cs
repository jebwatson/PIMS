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
    class BillsTableTests
    {
        BillsTable myTable;
        List<Bills> myList;

        [SetUp]
        public void SetupTests()
        {
            myTable = new BillsTable();
            myList = new List<Bills>()
            {
                new Bills(1, 1, 1, 0, 0, 1, 1, 0, 0, DateTime.Parse("01/01/2017"), DateTime.Parse("12/01/2017"), 1, 1),
                new Bills(2, 2, 2, 0, 0, 2, 2, 0, 0, DateTime.Parse("01/02/2017"), DateTime.Parse("12/02/2017"), 2, 2),
                new Bills(3, 3, 3, 0, 0, 3, 3, 0, 0, DateTime.Parse("01/03/2017"), DateTime.Parse("12/03/2017"), 3, 3)
            };

            // Establish Connection String
            ConnectionsManager.SQLServerConnectionString = "Data Source=JEBSDESKTOP\\SQLEXPRESS;Initial Catalog=" +
                "PIMSTest;Integrated Security=False;User Id=jwatson;Password=test;MultipleActiveResultSets=True;";

            // Establish connection and close at the end of using
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                // Clear the table before and tests occur
                string clearQuery = "DELETE FROM bills";
                QueryExecutor.ExecuteSqlNonQuery(clearQuery, myConnection);

                // Populate the table with known values before tests occur
                string populationQuery1 = "INSERT INTO bills (billId, amountTotalDollars, amountTotalCents, amountPaidByPatientDollars, " +
                    "amountPaidByPatientCents, amountPaidByInsuranceDollars, amountPaidByInsuranceCents, amountOwedDollars, amountOwedCents, " +
                    "dateCharged, dateDue, patientId, caseId) VALUES (1, 1, 1, 0, 0, 1, 1, 0, 0, '01/01/2017', '12/01/2017', 1, 1)";
                string populationQuery2 = "INSERT INTO bills (billId, amountTotalDollars, amountTotalCents, amountPaidByPatientDollars, " +
                    "amountPaidByPatientCents, amountPaidByInsuranceDollars, amountPaidByInsuranceCents, amountOwedDollars, amountOwedCents, " +
                    "dateCharged, dateDue, patientId, caseId) VALUES (2, 2, 2, 0, 0, 2, 2, 0, 0, '01/02/2017', '12/02/2017', 2, 2)";
                string populationQuery3 = "INSERT INTO bills (billId, amountTotalDollars, amountTotalCents, amountPaidByPatientDollars, " +
                    "amountPaidByPatientCents, amountPaidByInsuranceDollars, amountPaidByInsuranceCents, amountOwedDollars, amountOwedCents, " +
                    "dateCharged, dateDue, patientId, caseId) VALUES (3, 3, 3, 0, 0, 3, 3, 0, 0, '01/03/2017', '12/03/2017', 3, 3)";

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
            myTable.ReadList();

            int i = 0;

            foreach (var bill in myTable.ItemList)
            {
                Assert.That(bill.billId, Is.EqualTo(myList[i].billId));
                Assert.That(bill.amountTotalDollars, Is.EqualTo(myList[i].amountTotalDollars));
                Assert.That(bill.amountTotalCents, Is.EqualTo(myList[i].amountTotalCents));
                Assert.That(bill.amountPaidByPatientDollars, Is.EqualTo(myList[i].amountPaidByPatientDollars));
                Assert.That(bill.amountPaidByPatientCents, Is.EqualTo(myList[i].amountPaidByPatientCents));
                Assert.That(bill.amountPaidByInsuranceDollars, Is.EqualTo(myList[i].amountPaidByInsuranceDollars));
                Assert.That(bill.amountPaidByInsuranceCents, Is.EqualTo(myList[i].amountPaidByInsuranceCents));
                Assert.That(bill.amountOwedDollars, Is.EqualTo(myList[i].amountOwedDollars));
                Assert.That(bill.amountOwedCents, Is.EqualTo(myList[i].amountOwedCents));
                Assert.That(bill.dateCharged, Is.EqualTo(myList[i].dateCharged));
                Assert.That(bill.dateDue, Is.EqualTo(myList[i].dateDue));
                Assert.That(bill.patientId, Is.EqualTo(myList[i].patientId));
                Assert.That(bill.caseId, Is.EqualTo(myList[i].caseId));
                i++;
            }
        }

        [Test]
        /// <summary>
        /// Read a known value from the database by its billId and compare to the known value in memory.
        /// </summary>
        public void ShouldReadListById()
        {
            myTable.ReadListById(myList[0].billId);

            foreach (var bill in myTable.ItemList)
            {
                Assert.That(bill.billId, Is.EqualTo(myList[0].billId));
                Assert.That(bill.amountTotalDollars, Is.EqualTo(myList[0].amountTotalDollars));
                Assert.That(bill.amountTotalCents, Is.EqualTo(myList[0].amountTotalCents));
                Assert.That(bill.amountPaidByPatientDollars, Is.EqualTo(myList[0].amountPaidByPatientDollars));
                Assert.That(bill.amountPaidByPatientCents, Is.EqualTo(myList[0].amountPaidByPatientCents));
                Assert.That(bill.amountPaidByInsuranceDollars, Is.EqualTo(myList[0].amountPaidByInsuranceDollars));
                Assert.That(bill.amountPaidByInsuranceCents, Is.EqualTo(myList[0].amountPaidByInsuranceCents));
                Assert.That(bill.amountOwedDollars, Is.EqualTo(myList[0].amountOwedDollars));
                Assert.That(bill.amountOwedCents, Is.EqualTo(myList[0].amountOwedCents));
                Assert.That(bill.dateCharged, Is.EqualTo(myList[0].dateCharged));
                Assert.That(bill.dateDue, Is.EqualTo(myList[0].dateDue));
                Assert.That(bill.patientId, Is.EqualTo(myList[0].patientId));
                Assert.That(bill.caseId, Is.EqualTo(myList[0].caseId));
            }
        }

        [Test]
        /// <summary>
        /// Write known values to the table, retrieve them, compare.
        /// </summary>
        public void ShouldWriteList()
        {
            myTable.ClearTable();

            myTable.ItemList = myList;
            myTable.WriteList();
            myTable.ReadList();

            int i = 0;

            foreach (var bill in myTable.ItemList)
            {
                Assert.That(bill.billId, Is.EqualTo(myList[i].billId));
                Assert.That(bill.amountTotalDollars, Is.EqualTo(myList[i].amountTotalDollars));
                Assert.That(bill.amountTotalCents, Is.EqualTo(myList[i].amountTotalCents));
                Assert.That(bill.amountPaidByPatientDollars, Is.EqualTo(myList[i].amountPaidByPatientDollars));
                Assert.That(bill.amountPaidByPatientCents, Is.EqualTo(myList[i].amountPaidByPatientCents));
                Assert.That(bill.amountPaidByInsuranceDollars, Is.EqualTo(myList[i].amountPaidByInsuranceDollars));
                Assert.That(bill.amountPaidByInsuranceCents, Is.EqualTo(myList[i].amountPaidByInsuranceCents));
                Assert.That(bill.amountOwedDollars, Is.EqualTo(myList[i].amountOwedDollars));
                Assert.That(bill.amountOwedCents, Is.EqualTo(myList[i].amountOwedCents));
                Assert.That(bill.dateCharged, Is.EqualTo(myList[i].dateCharged));
                Assert.That(bill.dateDue, Is.EqualTo(myList[i].dateDue));
                Assert.That(bill.patientId, Is.EqualTo(myList[i].patientId));
                Assert.That(bill.caseId, Is.EqualTo(myList[i].caseId));
                i++;
            }
        }

        [Test]
        /// <summary>
        /// Write known item to the table, retreive it by billId, compare.
        /// </summary>
        public void ShouldWriteItem()
        {
            myTable.ClearTable();

            myTable.WriteItem(myList[0]);
            myTable.ReadListById(myList[0].billId);

            foreach (var bill in myTable.ItemList)
            {
                Assert.That(bill.billId, Is.EqualTo(myList[0].billId));
                Assert.That(bill.amountTotalDollars, Is.EqualTo(myList[0].amountTotalDollars));
                Assert.That(bill.amountTotalCents, Is.EqualTo(myList[0].amountTotalCents));
                Assert.That(bill.amountPaidByPatientDollars, Is.EqualTo(myList[0].amountPaidByPatientDollars));
                Assert.That(bill.amountPaidByPatientCents, Is.EqualTo(myList[0].amountPaidByPatientCents));
                Assert.That(bill.amountPaidByInsuranceDollars, Is.EqualTo(myList[0].amountPaidByInsuranceDollars));
                Assert.That(bill.amountPaidByInsuranceCents, Is.EqualTo(myList[0].amountPaidByInsuranceCents));
                Assert.That(bill.amountOwedDollars, Is.EqualTo(myList[0].amountOwedDollars));
                Assert.That(bill.amountOwedCents, Is.EqualTo(myList[0].amountOwedCents));
                Assert.That(bill.dateCharged, Is.EqualTo(myList[0].dateCharged));
                Assert.That(bill.dateDue, Is.EqualTo(myList[0].dateDue));
                Assert.That(bill.patientId, Is.EqualTo(myList[0].patientId));
                Assert.That(bill.caseId, Is.EqualTo(myList[0].caseId));
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
            // Add updated bills
            Bills newBill1 = new Bills(4, 25, 25, 25, 25, 0, 0, 0, 0, DateTime.Parse("01/31/2017"), DateTime.Parse("12/31/2017"), 4, 4);
            Bills newBill2 = new Bills(5, 50, 50, 50, 50, 0, 0, 0, 0, DateTime.Parse("01/31/2017"), DateTime.Parse("12/31/2017"), 5, 5);
            Bills newBill3 = new Bills(6, 100, 100, 100, 100, 0, 0, 0, 0, DateTime.Parse("01/31/2017"), DateTime.Parse("12/31/2017"), 6, 6);

            myList.Clear();

            myList.Add(newBill1);
            myList.Add(newBill2);
            myList.Add(newBill3);

            myTable.ItemList = myList;
            myTable.UpdateList();

            myTable.ReadList();

            int i = 0;

            foreach (var bill in myTable.ItemList)
            {
                Assert.That(bill.billId, Is.EqualTo(myList[i].billId));
                Assert.That(bill.amountTotalDollars, Is.EqualTo(myList[i].amountTotalDollars));
                Assert.That(bill.amountTotalCents, Is.EqualTo(myList[i].amountTotalCents));
                Assert.That(bill.amountPaidByPatientDollars, Is.EqualTo(myList[i].amountPaidByPatientDollars));
                Assert.That(bill.amountPaidByPatientCents, Is.EqualTo(myList[i].amountPaidByPatientCents));
                Assert.That(bill.amountPaidByInsuranceDollars, Is.EqualTo(myList[i].amountPaidByInsuranceDollars));
                Assert.That(bill.amountPaidByInsuranceCents, Is.EqualTo(myList[i].amountPaidByInsuranceCents));
                Assert.That(bill.amountOwedDollars, Is.EqualTo(myList[i].amountOwedDollars));
                Assert.That(bill.amountOwedCents, Is.EqualTo(myList[i].amountOwedCents));
                Assert.That(bill.dateCharged, Is.EqualTo(myList[i].dateCharged));
                Assert.That(bill.dateDue, Is.EqualTo(myList[i].dateDue));
                Assert.That(bill.patientId, Is.EqualTo(myList[i].patientId));
                Assert.That(bill.caseId, Is.EqualTo(myList[i].caseId));
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
            // Add updated bill
            Bills newBill = new Bills(4, 25, 25, 25, 25, 0, 0, 0, 0, DateTime.Parse("01/31/2017"), DateTime.Parse("12/31/2017"), 4, 4);

            myTable.UpdateItem(newBill);

            myTable.ReadListById(newBill.billId);

            foreach (var bill in myTable.ItemList)
            {
                Assert.That(bill.billId, Is.EqualTo(newBill.billId));
                Assert.That(bill.amountTotalDollars, Is.EqualTo(newBill.amountTotalDollars));
                Assert.That(bill.amountTotalCents, Is.EqualTo(newBill.amountTotalCents));
                Assert.That(bill.amountPaidByPatientDollars, Is.EqualTo(newBill.amountPaidByPatientDollars));
                Assert.That(bill.amountPaidByPatientCents, Is.EqualTo(newBill.amountPaidByPatientCents));
                Assert.That(bill.amountPaidByInsuranceDollars, Is.EqualTo(newBill.amountPaidByInsuranceDollars));
                Assert.That(bill.amountPaidByInsuranceCents, Is.EqualTo(newBill.amountPaidByInsuranceCents));
                Assert.That(bill.amountOwedDollars, Is.EqualTo(newBill.amountOwedDollars));
                Assert.That(bill.amountOwedCents, Is.EqualTo(newBill.amountOwedCents));
                Assert.That(bill.dateCharged, Is.EqualTo(newBill.dateCharged));
                Assert.That(bill.dateDue, Is.EqualTo(newBill.dateDue));
                Assert.That(bill.patientId, Is.EqualTo(newBill.patientId));
                Assert.That(bill.caseId, Is.EqualTo(newBill.caseId));
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
