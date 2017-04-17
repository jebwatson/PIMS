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
        public int amountDollars { get; set; }
        public int amountCents { get; set; }
        public DateTime dateCharged { get; set; }
        public DateTime dateDue { get; set; }
        public int procedureId { get; set; }
        public int officeStaffId { get; set; }
        public int patientId { get; set; }
        public int caseId { get; set; }

        public Charges()
        {
            chargeId = _unassigned;
            description = string.Empty;
            amountDollars = _unassigned;
            amountCents = _unassigned;
            dateCharged = DateTime.Now;
            dateDue = DateTime.Now;
            procedureId = _unassigned;
            officeStaffId = _unassigned;
            patientId = _unassigned;
            caseId = _unassigned;
        }

        public Charges(string description, int amountDollars, int amountCents, DateTime dateCharged, DateTime dateDue, int procedureId,
            int officeStaffId, int patientId, int caseId)
        {
            this.description = description;
            this.amountDollars = amountDollars;
            this.amountCents = amountCents;
            this.dateCharged = dateCharged;
            this.dateDue = dateDue;
            this.procedureId = procedureId;
            this.officeStaffId = officeStaffId;
            this.patientId = patientId;
            this.caseId = caseId;
        }
    }
}
