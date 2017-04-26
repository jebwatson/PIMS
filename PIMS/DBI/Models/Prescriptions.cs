using System;
using System.Collections.Generic;
using System.Text;

namespace DBI
{
    public class Prescriptions
    {
        private const int _unassigned = -1;

        public string prescName { get; set; }
        public int prescId { get; set; }
        public int patientId { get; set; }
        public string amount { get; set; }
        public DateTime prescDate { get; set; }
        public int duration { get; set; }
        public string name { get; set; }

        public Prescriptions() {
            prescName = string.Empty;
            prescId = _unassigned;
            patientId = _unassigned;
            amount = string.Empty;
            prescDate = DateTime.Now;
            duration = _unassigned;
        }

        public Prescriptions(string prescName, string amount, DateTime prescDate, int duration, int patientId) {
            this.prescName = prescName;
            this.patientId = patientId;
            this.amount = amount;
            this.prescDate = prescDate;
            this.duration = duration;
        }
    }
}
