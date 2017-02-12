using System;
using System.Collections.Generic;
using System.Text;

namespace DBI
{
    class NotesNurse
    {
        const int _unassigned = -1;

        public int notesId { get; set; }
        public string notes { get; set; }
        public int nurseId { get; set; }
        public int patientId { get; set; }
        public int caseId { get; set; }

        public NotesNurse()
        {
            notesId = _unassigned;
            notes = string.Empty;
            nurseId = _unassigned;
            patientId = _unassigned;
            caseId = _unassigned;
        }

        public NotesNurse(int notesId, string notes, int nurseId, int patientId, int caseId)
        {
            this.notesId = notesId;
            this.notes = notes;
            this.nurseId = nurseId;
            this.patientId = patientId;
            this.caseId = caseId;
        }
    }
}
