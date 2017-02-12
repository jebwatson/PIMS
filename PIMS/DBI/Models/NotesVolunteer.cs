using System;
using System.Collections.Generic;
using System.Text;

namespace DBI
{
    class NotesVolunteer
    {
        const int _unassigned = -1;

        public int notesId { get; set; }
        public string notes { get; set; }
        public int volunteerId { get; set; }
        public int patientId { get; set; }
        public int caseId { get; set; }

        public NotesVolunteer()
        {
            notesId = _unassigned;
            notes = string.Empty;
            volunteerId = _unassigned;
            patientId = _unassigned;
            caseId = _unassigned;
        }

        public NotesVolunteer(int notesId, string notes, int volunteerId, int patientId, int caseId)
        {
            this.notesId = notesId;
            this.notes = notes;
            this.volunteerId = volunteerId;
            this.patientId = patientId;
            this.caseId = caseId;
        }
    }
}
