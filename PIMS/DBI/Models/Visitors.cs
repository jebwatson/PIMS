using System;
using System.Collections.Generic;
using System.Text;

namespace DBI
{
    class Visitors
    {
        private const int _unassigned = -1;

        public int visitorId { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string relation { get; set; }
        public DateTime lastVisit { get; set; }
        public int patientId { get; set; }
        public int caseId { get; set; }

        public Visitors() {
            lastName = string.Empty;
            firstName = string.Empty;
            relation = string.Empty;
            patientId = _unassigned;
            lastVisit = DateTime.Now;
            caseId = _unassigned;
            visitorId = _unassigned;
        }

        public Visitors(int visitorId, string lastName, string firstName, string relation, DateTime lastVisit, int patientId, int caseId) {
            this.lastName = lastName;
            this.firstName = firstName;
            this.relation = relation;
            this.patientId = patientId;
            this.lastVisit = lastVisit;
            this.caseId = caseId;
            this.visitorId = visitorId;
        }
    }
}
