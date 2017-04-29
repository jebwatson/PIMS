 using System;
using System.Collections.Generic;
using System.Text;

namespace DBI
{
    public class Charges
    {
        private const int _unassigned = -1;

        public int chargeId { get; set; }
        public string description { get; set; }
        public string amountTotal { get; set; }
        public DateTime dateCharged { get; set; }
        public DateTime dateDue { get; set; }
        public int procedureId { get; set; }
        public int officeStaffId { get; set; }
        public int patientId { get; set; }
        public string name { get; set; }

        public Charges()
        {
            chargeId = _unassigned;
            description = string.Empty;
            amountTotal = string.Empty;
            dateCharged = DateTime.Now;
            dateDue = DateTime.Now;
            procedureId = _unassigned;
            officeStaffId = _unassigned;
            patientId = _unassigned;
        }

        public Charges(string description, string amountTotal, DateTime dateCharged, DateTime dateDue, int procedureId,
            int officeStaffId, int patientId, int chargeId)
        {
            this.description = description;
            this.amountTotal = amountTotal;
            this.dateCharged = dateCharged;
            this.dateDue = dateDue;
            this.procedureId = procedureId;
            this.officeStaffId = officeStaffId;
            this.patientId = patientId;
            this.chargeId = chargeId;
        }
    }
}
