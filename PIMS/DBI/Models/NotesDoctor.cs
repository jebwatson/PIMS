using System;
using System.Collections.Generic;
using System.Text;

namespace DBI
{
    class NotesDoctor
    {
        const int _unassigned = -1;

        public int notesId { get; set; }
        public string notes { get; set; }
        public int doctorId { get; set; }
        public int patientId { get; set; }
        public int caseId { get; set; }

        public NotesDoctor()
        {
            notesId = _unassigned;
            notes = string.Empty;
            doctorId = _unassigned;
            patientId = _unassigned;
            caseId = _unassigned;
        }

        public NotesDoctor(int notesId, string notes, int doctorId, int patientId, int caseId)
        {
            this.notesId = notesId;
            this.notes = notes;
            this.doctorId = doctorId;
            this.patientId = patientId;
            this.caseId = caseId;
        }
    }
}
