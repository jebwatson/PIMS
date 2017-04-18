using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DBI.Utilities;

namespace PIMSTests.UtilitiesTests
{
    [TestFixture]
    class ConnectionManagerTests
    {
        [Test]
        public void ShouldGetNewConnection()
        {
            ConnectionsManager.SQLServerConnectionString = "Data Source=ALEX\\SQLEXPRESS;Initial Catalog=" +
                "PIMSTest;Integrated Security=False;User Id=jwatson;Password=test;MultipleActiveResultSets=True;";
            Assert.That(ConnectionsManager.GetNewConnection(), Is.Not.Null);
        }

        
    }
}
