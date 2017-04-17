using DBI;
using NUnit.Framework;

namespace PIMSTests.Helpers
{
    class PatientComparer : ICompare<Patient>
    {
        public void Compare(Patient object1, Patient object2)
        {
            Assert.That(object1.patientId, Is.EqualTo(object2.patientId));
            Assert.That(object1.nameLast, Is.EqualTo(object2.nameLast));
            Assert.That(object1.nameFirst, Is.EqualTo(object2.nameFirst));
            Assert.That(object1.nameMiddle, Is.EqualTo(object2.nameMiddle));
            Assert.That(object1.street, Is.EqualTo(object2.street));
            Assert.That(object1.city, Is.EqualTo(object2.city));
            Assert.That(object1.state, Is.EqualTo(object2.state));
            Assert.That(object1.zip, Is.EqualTo(object2.zip));
            Assert.That(object1.phoneHome, Is.EqualTo(object2.phoneHome));
            Assert.That(object1.areaCodeHome, Is.EqualTo(object2.areaCodeHome));
            Assert.That(object1.phoneWork, Is.EqualTo(object2.phoneWork));
            Assert.That(object1.areaCodeWork, Is.EqualTo(object2.areaCodeWork));
            Assert.That(object1.phoneMobile, Is.EqualTo(object2.phoneMobile));
            Assert.That(object1.areaCodeMobile, Is.EqualTo(object2.areaCodeMobile));
            Assert.That(object1.familyDoctor, Is.EqualTo(object2.familyDoctor));

        }
    }
}
