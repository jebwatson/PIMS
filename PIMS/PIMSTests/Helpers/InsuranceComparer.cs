using DBI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PIMSTests.Helpers
{
    class InsuranceComparer : ICompare<Insurance>
    {
        public void Compare(Insurance ec1, Insurance ec2)
        {
            Assert.That(ec1.insuranceId, Is.EqualTo(ec2.insuranceId));
            Assert.That(ec1.insuranceCarrier, Is.EqualTo(ec2.insuranceCarrier));
            Assert.That(ec1.accountNumber, Is.EqualTo(ec2.accountNumber));
            Assert.That(ec1.groupNumber, Is.EqualTo(ec2.groupNumber));
            Assert.That(ec1.patientId, Is.EqualTo(ec2.patientId));
        }
    }
}
