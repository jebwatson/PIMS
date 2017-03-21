using System;
using System.Collections.Generic;
using System.Text;

namespace DBI
{
    public class NotesOfficeStaff
    {
        const int _unassigned = -1;

        public int notesId { get; set; }
        public string notes { get; set; }
        public int officeStaffId { get; set; }
        public int patientId { get; set; }
        public int caseId { get; set; }

        public NotesOfficeStaff()
        {
            notesId = _unassigned;
            notes = string.Empty;
            officeStaffId = _unassigned;
            patientId = _unassigned;
            caseId = _unassigned;
        }

        public NotesOfficeStaff(int notesId, string notes, int officeStaffId, int patientId, int caseId)
        {
            this.notesId = notesId;
            this.notes = notes;
            this.officeStaffId = officeStaffId;
            this.patientId = patientId;
            this.caseId = caseId;
        }
    }
}
