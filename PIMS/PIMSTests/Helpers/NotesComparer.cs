using DBI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PIMSTests.Helpers
{
    class NotesComparer : ICompare<Notes>
    {
        public void Compare(Notes ec1, Notes ec2)
        {
            Assert.That(ec1.notesId, Is.EqualTo(ec2.notesId));
            Assert.That(ec1.notes, Is.EqualTo(ec2.notes));
            Assert.That(ec1.userId, Is.EqualTo(ec2.userId));
            Assert.That(ec1.patientId, Is.EqualTo(ec2.patientId));
        }
    }
}
