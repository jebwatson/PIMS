using DBI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PIMSTests.Helpers
{
    class NotesOfficeStaffComparer : ICompare<NotesOfficeStaff>
    {
        public void Compare(NotesOfficeStaff ec1, NotesOfficeStaff ec2)
        {
            Assert.That(ec1.notesId, Is.EqualTo(ec2.notesId));
            Assert.That(ec1.notes, Is.EqualTo(ec2.notes));
            Assert.That(ec1.officeStaffId, Is.EqualTo(ec2.officeStaffId));
            Assert.That(ec1.patientId, Is.EqualTo(ec2.patientId));
            Assert.That(ec1.caseId, Is.EqualTo(ec2.caseId));
        }
    }
}