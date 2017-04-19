using DBI;
using NUnit.Framework;

namespace PIMSTests.Helpers
{
    class PrescriptionsComparer : ICompare<Prescriptions>
    {
        public void Compare(Prescriptions presc1, Prescriptions presc2)
        {
            Assert.That(presc1.prescId, Is.EqualTo(presc2.prescId));
            Assert.That(presc1.prescName, Is.EqualTo(presc2.prescName));
            Assert.That(presc1.amount, Is.EqualTo(presc2.amount));
            Assert.That(presc1.prescDate, Is.EqualTo(presc2.prescDate));
            Assert.That(presc1.duration, Is.EqualTo(presc2.duration));
            Assert.That(presc1.patientId, Is.EqualTo(presc2.patientId));
        }
    }
}
