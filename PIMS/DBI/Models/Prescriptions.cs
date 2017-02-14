using System;
using System.Collections.Generic;
using System.Text;

namespace DBI
{
    class Prescriptions
    {
        private const int _unassigned = -1;

        public string prescName { get; set; }
        public int prescId { get; set; }
        public int caseId { get; set; }
        public int patientId { get; set; }
        public string amount { get; set; }
        public DateTime prescDate { get; set; }
        public int duration { get; set; }

        public Prescriptions() {
            prescName = string.Empty;
            prescId = _unassigned;
            caseId = _unassigned;
            patientId = _unassigned;
            amount = string.Empty;
            prescDate = DateTime.Now;
            duration = _unassigned;
        }

        public Prescriptions(int prescId, string prescName, int caseId, int patientId, string amount, DateTime prescDate, int duration) {
            this.prescName = prescName;
            this.prescId = prescId;
            this.caseId = caseId;
            this.patientId = patientId;
            this.amount = amount;
            this.prescDate = prescDate;
            this.duration = duration;
        }
    }
}
