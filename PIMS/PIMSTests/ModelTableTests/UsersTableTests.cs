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
    class UsersTableTests
    {
        UsersTable myTable;
        List<Users> myList;
        ICompare<Users> comparer;

        [SetUp]
        public void SetupTest()
        {
            // NOTE: This occurs before each and every test case.

            // Establish the connection string
            ConnectionsManager.SQLServerConnectionString = "Data Source=CSSA-JEB\\SQLEXPRESS;Initial Catalog=" +
                "PIMSTest;Integrated Security=False;User Id=jwatson;Password=test;MultipleActiveResultSets=True;";

            myTable = new UsersTable();
            myList = new List<Users>()
            {
                new Users("Moore", "John", "doctor", 4, "JohnMoore", 1),
                new Users("John", "Jimmy", "volunteer", 1, "JimmyJohn", 2),
                new Users("Sanders", "Bernie", "nurse", 3, "BernieSanders", 3)
            };
            comparer = new UsersComparer();

            // Establish a connection and close at the end of using

            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                // Clear the table before any tests occur
                string clearQuery = "DELETE FROM users DBCC CHECKIDENT('users', RESEED, 0)";
                QueryExecutor.ExecuteSqlNonQuery(clearQuery, myConnection);

                // Populate the table with known values before tests occur
                string populationQuery1 = "INSERT INTO users (nameLast, nameFirst, title, " +
                    "accessLevel, username) " +
                    "VALUES ('Moore', 'John', 'doctor', 4, 'JohnMoore')";
                string populationQuery2 = "INSERT INTO users (nameLast, nameFirst, title, " +
                    "accessLevel, username) " +
                    "VALUES ('John', 'Jimmy', 'volunteer', '1', 'JimmyJohn')";
                string populationQuery3 = "INSERT INTO users (nameLast, nameFirst, title, " +
                    "accessLevel, username) " +
                    "VALUES ('Sanders', 'Bernie', 'nurse', '3', 'BernieSanders')";

                QueryExecutor.ExecuteSqlNonQuery(populationQuery1, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery2, myConnection);
                QueryExecutor.ExecuteSqlNonQuery(populationQuery3, myConnection);
            }
        }

        [Test]
        public void ShouldReadList()
        {
            List<Users> users = new List<Users>();

            // Read from a pre-populated test database and compare results.
            users = myTable.ReadList();

            int i = 0;

            foreach (var user in users)
            {
                comparer.Compare(user, myList[i]);
                i++;
            }
        }

        [Test]
        public void ShouldReadListById()
        {
            List<Users> users = new List<Users>();

            // Read from a pre-populated test database and compare results.
            users = myTable.ReadListById(1);

            foreach (var user in users)
            {
                comparer.Compare(user, myList[0]);
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
            List<Users> users = new List<Users>();
            myTable.ClearTableById(1);
            int recordCount = myTable.CountRows();
            users = myTable.ReadListById(1);
            int missingRecordCount = users.Count;
            Assert.That(recordCount, Is.EqualTo(2));
            Assert.That(missingRecordCount, Is.EqualTo(0));
        }

        [Test]
        public void ShouldWriteList()
        {
            List<Users> users = new List<Users>();

            // Need to clear the table first
            myTable.ClearTable();

            // Write some records to the table then retrieve them using previously tested
            // read methods. Compare with original records.
            myTable.WriteList(myList);
            users = myTable.ReadList();

            int i = 0;

            foreach (var user in users)
            {
                comparer.Compare(user, myList[i]);
                i++;
            }
        }

        [Test]
        public void ShouldWriteItem()
        {
            List<Users> users = new List<Users>();

            // Need to clear the table first
            myTable.ClearTable();

            // Write a record to the table then retrieve it using previously tested
            // read methods. Compare with original record.
            myTable.WriteItem(myList[0]);
            users = myTable.ReadList();

            foreach (var user in users)
            {
                comparer.Compare(user, myList[0]);
            }
        }

        [Test]
        public void ShouldUpdateList()
        {
            List<Users> users = new List<Users>();

            // Need some updated data
            Users updated1 = new Users("test4", "test4", "test4", 4, "test4", 1);
            Users updated2 = new Users("test5", "test5", "test5", 5, "test5", 2);
            Users updated3 = new Users("test6", "test6", "test6", 6, "test6", 3);

            myList.Clear();

            myList.Add(updated1);
            myList.Add(updated2);
            myList.Add(updated3);

            myTable.UpdateList(myList);

            // Now read the table back out and compare to myList
            users = myTable.ReadList();

            int i = 0;

            foreach (var user in users)
            {
                comparer.Compare(user, myList[i]);
                i++;
            }

        }

        [Test]
        public void ShouldUpdateItem()
        {
            List<Users> users = new List<Users>();

            // Need some updated data
            Users updatedUser = new Users("test4", "test4", "test4", 4, "test4", 1);

            // Update the table with the updated admission (id = 1)
            myTable.UpdateItem(updatedUser);

            // Now read the admission back out and compare it to the updatedAdmission above.
            users = myTable.ReadListById(4);

            foreach (var user in users)
            {
                comparer.Compare(user, updatedUser);
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