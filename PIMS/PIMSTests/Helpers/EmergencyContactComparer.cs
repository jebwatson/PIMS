using DBI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PIMSTests.Helpers
{
    [TestFixture]
    class EmergencyContactComparer : ICompare<EmergencyContact>
    {
        public void Compare(EmergencyContact ec1, EmergencyContact ec2)
        {
            Assert.That(ec1.emergencyContactId, Is.EqualTo(ec2.emergencyContactId));
            Assert.That(ec1.nameLast, Is.EqualTo(ec2.nameLast));
            Assert.That(ec1.nameFirst, Is.EqualTo(ec2.nameFirst));
            Assert.That(ec1.nameMiddle, Is.EqualTo(ec2.nameMiddle));
            Assert.That(ec1.phone, Is.EqualTo(ec2.phone));
            Assert.That(ec1.areaCode, Is.EqualTo(ec2.areaCode));
            Assert.That(ec1.patientId, Is.EqualTo(ec2.patientId));
        }
    }
}
