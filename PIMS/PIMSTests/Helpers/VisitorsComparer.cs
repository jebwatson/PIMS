using DBI;
using NUnit.Framework;

namespace PIMSTests.Helpers
{
    class VisitorsComparer : ICompare<Visitors>
    {
        public void Compare(Visitors visitor1, Visitors visitor2)
        {
            Assert.That(visitor1.visitorId, Is.EqualTo(visitor2.visitorId));
            Assert.That(visitor1.nameLast, Is.EqualTo(visitor2.nameLast));
            Assert.That(visitor1.nameFirst, Is.EqualTo(visitor2.nameFirst));
            Assert.That(visitor1.relation, Is.EqualTo(visitor2.relation));
            Assert.That(visitor1.lastVisit, Is.EqualTo(visitor2.lastVisit));
            Assert.That(visitor1.patientId, Is.EqualTo(visitor2.patientId));
            Assert.That(visitor1.caseId, Is.EqualTo(visitor2.caseId));
        }
    }
}
