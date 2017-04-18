using System;
using System.Collections.Generic;
using System.Text;

namespace DBI
{
    public class Procedures
    {
        private const int _unassigned = -1;

        public int procId { get; set; }
        public string procType { get; set; }
        public int patientId { get; set; }
        public int doctorId { get; set; }
        public DateTime startTime { get; set; }
        public DateTime stopTime { get; set; }
        public int durationHrs { get; set; }
        public int durationMins { get; set; }
        public string procNotes { get; set; }

        public Procedures() {
            procId = _unassigned;
            procType = string.Empty;
            patientId = _unassigned;
            doctorId = _unassigned;
            startTime = DateTime.Now;
            stopTime = DateTime.Now;
            durationHrs = _unassigned;
            durationMins = _unassigned;
            procNotes = string.Empty;
        }

        public Procedures(DateTime startTime, DateTime stopTime, string procType, int durationHrs, int durationMins, int doctorId,  string procNotes, int patientId) {
            this.procType = procType;
            this.patientId = patientId;
            this.doctorId = doctorId;
            this.startTime = startTime;
            this.stopTime = stopTime;
            this.durationHrs = durationHrs;
            this.durationMins = durationMins;
            this.procNotes = procNotes;
        }
    }
}
