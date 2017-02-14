using System;
using System.Collections.Generic;
using System.Text;

namespace DBI
{
    class Procedures
    {
        private const int _unassigned = -1;

        public int procId { get; set; }
        public string procType { get; set; }
        public int caseId { get; set; }
        public int patientId { get; set; }
        public int doctorId { get; set; }
        public DateTime startTime { get; set; }
        public int durationHrs { get; set; }
        public int durationMins { get; set; }
        public string procNotes { get; set; }

        public Procedures() {
            procId = _unassigned;
            procType = string.Empty;
            caseId = _unassigned;
            patientId = _unassigned;
            doctorId = _unassigned;
            startTime = DateTime.Now;
            durationHrs = _unassigned;
            durationMins = _unassigned;
            procNotes = string.Empty;
        }

        public Procedures(int procId, string procType, int caseId, int patientId, int doctorId, DateTime startTime, int durationHrs, int durationMins, string procNotes) {
            this.procId = procId;
            this.procType = procType;
            this.caseId = caseId;
            this.patientId = patientId;
            this.doctorId = doctorId;
            this.startTime = startTime;
            this.durationHrs = durationHrs;
            this.durationMins = durationMins;
            this.procNotes = procNotes;
        }
    }
}
