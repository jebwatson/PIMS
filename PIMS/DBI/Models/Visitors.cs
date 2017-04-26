using System;
using System.Collections.Generic;
using System.Text;

namespace DBI
{
    public class Visitors
    {
        private const int _unassigned = -1;

        public int visitorId { get; set; }
        public string nameLast { get; set; }
        public string nameFirst { get; set; }
        public string relation { get; set; }
        public DateTime lastVisit { get; set; }
        public int patientId { get; set; }
        public string patientName { get; set; }

        public Visitors() {
            nameLast = string.Empty;
            nameFirst = string.Empty;
            relation = string.Empty;
            patientId = _unassigned;
            lastVisit = DateTime.Now;
            visitorId = _unassigned;
        }

        public Visitors(string lastName, string firstName, string relation, DateTime lastVisit, int patientId) {
            this.nameLast = lastName;
            this.nameFirst = firstName;
            this.relation = relation;
            this.patientId = patientId;
            this.lastVisit = lastVisit;
            this.visitorId = visitorId;
        }
    }
}
