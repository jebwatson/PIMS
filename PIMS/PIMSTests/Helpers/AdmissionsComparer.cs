using DBI;
using NUnit.Framework;

namespace PIMSTests.Helpers
{
    class AdmissionsComparer : ICompare<Admission>
    {
        public void Compare(Admission adm1, Admission adm2)
        {
            Assert.That(adm1.admissionTime, Is.EqualTo(adm2.admissionTime));
            Assert.That(adm1.dischargeTime, Is.EqualTo(adm2.dischargeTime));
            Assert.That(adm1.admissionReason, Is.EqualTo(adm2.admissionReason));
            Assert.That(adm1.facility, Is.EqualTo(adm2.facility));
            Assert.That(adm1.floor, Is.EqualTo(adm2.floor));
            Assert.That(adm1.roomNumber, Is.EqualTo(adm2.roomNumber));
            Assert.That(adm1.bedNumber, Is.EqualTo(adm2.bedNumber));
            Assert.That(adm1.patientId, Is.EqualTo(adm2.patientId));
        }
    }
}
