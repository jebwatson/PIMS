using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DBI.Utilities;
using System.Data;

namespace PIMSTests.UtilitiesTests
{
    [TestFixture]
    class QueryExecutorTests
    {
        [SetUp]
        public void SetupTests()
        {
            ConnectionsManager.SQLServerConnectionString = "Data Source=JEBSDESKTOP\\SQLEXPRESS;Initial Catalog=" +
                "PIMSTest;Integrated Security=False;User Id=jwatson;Password=test;MultipleActiveResultSets=True;";
        }

        [Test]
        public void ShouldExecuteSQLQuery()
        {
            // Ensure that the method executes and returns a dataset (actually testing the data will occur elsewhere)
            DataSet result = QueryExecutor.ExecuteSqlQuery("SELECT * FROM patients", ConnectionsManager.GetNewConnection());
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void ShouldExecuteSQLNonQuery()
        {
            // Ensure that the method executes and raises no exceptions
            object result = QueryExecutor.ExecuteSqlNonQuery("SELECT * FROM patients");
            Assert.That(result, Is.Not.TypeOf<Exception>());
        }

        // Save this for when/if we actually need it
        //[Test]
        //public void ShouldExecuteSQLQueryScalar()
        //{
        //    int i = 1;
        //    int j = QueryExecutor.ExecuteSqlQueryScalar("SELECT COUNT(*) FROM patients");
        //    Assert.That(i, Is.EqualTo(j));
        //}
    }
}
