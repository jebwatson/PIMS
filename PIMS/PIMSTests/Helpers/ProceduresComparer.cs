using DBI;
using NUnit.Framework;

namespace PIMSTests.Helpers
{
    class ProceduresComparer : ICompare<Procedures>
    {
        public void Compare(Procedures proc1, Procedures proc2)
        {
            Assert.That(proc1.procId, Is.EqualTo(proc2.procId));
            Assert.That(proc1.startTime, Is.EqualTo(proc2.startTime));
            Assert.That(proc1.stopTime, Is.EqualTo(proc2.stopTime));
            Assert.That(proc1.procType, Is.EqualTo(proc2.procType));
            Assert.That(proc1.durationHrs, Is.EqualTo(proc2.durationHrs));
            Assert.That(proc1.durationMins, Is.EqualTo(proc2.durationMins));
            Assert.That(proc1.doctorId, Is.EqualTo(proc2.doctorId));
            Assert.That(proc1.procNotes, Is.EqualTo(proc2.procNotes));
            Assert.That(proc1.patientId, Is.EqualTo(proc2.patientId));
        }
    }
}
