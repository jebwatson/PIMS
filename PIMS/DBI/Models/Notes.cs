using System;
using System.Collections.Generic;
using System.Text;

namespace DBI
{
    public class Notes
    {
        const int _unassigned = -1;

        public int noteId { get; set; }
        public string notes { get; set; }
        public bool doctor { get; set; }
        public bool nurse { get; set; }
        public int userId { get; set; }
        public int patientId { get; set; }
        public string name { get; set; }

        public Notes()
        {
            noteId = _unassigned;
            notes = string.Empty;
            doctor = false;
            nurse = false;
            userId = _unassigned;
            patientId = _unassigned;
        }

        public Notes(string notes, bool doctor, bool nurse, int doctorId, int patientId)
        {
            this.notes = notes;
            this.doctor = doctor;
            this.nurse = nurse;
            this.userId = doctorId;
            this.patientId = patientId;
        }
    }
}
