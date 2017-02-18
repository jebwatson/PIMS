using DBI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PIMSTests.Helpers
{
    class NotesNurseComparer : ICompare<NotesNurse>
    {
        public void Compare(NotesNurse ec1, NotesNurse ec2)
        {
            Assert.That(ec1.notesId, Is.EqualTo(ec2.notesId));
            Assert.That(ec1.notes, Is.EqualTo(ec2.notes));
            Assert.That(ec1.nurseId, Is.EqualTo(ec2.nurseId));
            Assert.That(ec1.patientId, Is.EqualTo(ec2.patientId));
            Assert.That(ec1.caseId, Is.EqualTo(ec2.caseId));
        }
    }
}
