using DBI;
using NUnit.Framework;

namespace PIMSTests.Helpers
{
    class CasesComparer : ICompare<Cases>
    {
        public void Compare(Cases case1, Cases case2)
        {
            Assert.That(case1.caseId, Is.EqualTo(case2.caseId));
            Assert.That(case1.supervisingDoctorId, Is.EqualTo(case2.supervisingDoctorId));
            Assert.That(case1.approvedVisitorCount, Is.EqualTo(case2.approvedVisitorCount));
            Assert.That(case1.patientId, Is.EqualTo(case2.patientId));
        }
    }
}
