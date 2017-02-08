using System;
using System.Collections.Generic;
using System.Text;

namespace DBI
{
    public class Bills
    {
        private const int _unassigned = -1;

        public int billId { get; set; }
        public int amountTotalDollars { get; set; }
        public int amountTotalCents { get; set; }
        public int amountPaidByPatientDollars { get; set; }
        public int amountPaidByPatientCents { get; set; }
        public int amountPaidByInsuranceDollars { get; set; }
        public int amountPaidByInsuranceCents { get; set; }
        public int amountOwedDollars { get; set; }
        public int amountOwedCents { get; set; }
        public DateTime dateCharged { get; set; }
        public DateTime dateDue { get; set; }
        public int patientId { get; set; }
        public int caseId { get; set; }

        public Bills()
        {
            billId = _unassigned;
            amountTotalDollars = _unassigned;
            amountTotalCents = _unassigned;
            amountPaidByPatientDollars = _unassigned;
            amountPaidByPatientCents = _unassigned;
            amountPaidByInsuranceDollars = _unassigned;
            amountPaidByInsuranceCents = _unassigned;
            amountOwedDollars = _unassigned;
            amountOwedCents = _unassigned;
            dateCharged = DateTime.Now;
            dateDue = DateTime.Now;
            patientId = _unassigned;
            caseId = _unassigned;
        }

        public Bills(int valBillId, int valAmountTotalDollars, int valAmountTotalCents, int valAmountPaidByPatientDollars, int valAmountPaidByPatientCents,
            int valAmountPaidByInsuranceDollars, int valAmountPaidByInsuranceCents, int valAmountOwedDollars, int valAmountOwedCents, DateTime valDateCharged,
            DateTime valDateDue, int valPatientId, int valCaseId)
        {
            billId = valBillId;
            amountTotalDollars = valAmountTotalDollars;
            amountTotalCents = valAmountTotalCents;
            amountPaidByPatientDollars = valAmountPaidByPatientDollars;
            amountPaidByPatientCents = valAmountPaidByPatientCents;
            amountPaidByInsuranceDollars = valAmountPaidByInsuranceDollars;
            amountPaidByInsuranceCents = valAmountPaidByInsuranceCents;
            amountOwedDollars = valAmountOwedDollars;
            amountOwedCents = valAmountOwedCents;
            dateCharged = valDateCharged;
            dateDue = valDateDue;
            patientId = valPatientId;
            caseId = valCaseId;
        }
    }
}
