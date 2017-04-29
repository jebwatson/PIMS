using System;
using System.Collections.Generic;
using System.Text;

namespace DBI
{
    public class Bills
    {
        private const int _unassigned = -1;

        public int billId { get; set; }
        public string amountTotal { get; set; }
        public string amountPaidByPatient { get; set; }
        public string amountPaidByInsurance { get; set; }
        public string amountOwed { get; set; }
        public DateTime dateCharged { get; set; }
        public DateTime dateDue { get; set; }
        public int patientId { get; set; }
        public string name { get; set; }

        public Bills()
        {
            billId = _unassigned;
            amountTotal = string.Empty;
            amountPaidByPatient = string.Empty;
            amountPaidByInsurance = string.Empty;
            amountOwed = string.Empty;
            dateCharged = DateTime.Now;
            dateDue = DateTime.Now;
            patientId = _unassigned;
        }

        public Bills(string valAmountTotal, string valAmountPaidByPatient,
            string valAmountPaidByInsurance, string valAmountOwed, DateTime valDateCharged,
            DateTime valDateDue, int valPatientId, int billId)
        {
            amountTotal = valAmountTotal;
            amountPaidByPatient = valAmountPaidByPatient;
            amountPaidByInsurance = valAmountPaidByInsurance;
            amountOwed = valAmountOwed;
            dateCharged = valDateCharged;
            dateDue = valDateDue;
            patientId = valPatientId;
            this.billId = billId;
        }
    }
}
