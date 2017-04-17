using DBI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PIMSTests.Helpers
{
    class NotesDoctorComparer : ICompare<NotesDoctor>
    {
        public void Compare(NotesDoctor ec1, NotesDoctor ec2)
        {
            Assert.That(ec1.notesId, Is.EqualTo(ec2.notesId));
            Assert.That(ec1.notes, Is.EqualTo(ec2.notes));
            Assert.That(ec1.doctorId, Is.EqualTo(ec2.doctorId));
            Assert.That(ec1.patientId, Is.EqualTo(ec2.patientId));
            Assert.That(ec1.caseId, Is.EqualTo(ec2.caseId));
        }
    }
}
