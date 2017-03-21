using DBI;
using NUnit.Framework;

namespace PIMSTests.Helpers
{
    class BillsComparer : ICompare<Bills>
    {
        public void Compare(Bills bill1, Bills bill2)
        {
            Assert.That(bill1.billId, Is.EqualTo(bill2.billId));
            Assert.That(bill1.amountTotalDollars, Is.EqualTo(bill2.amountTotalDollars));
            Assert.That(bill1.amountTotalCents, Is.EqualTo(bill2.amountTotalCents));
            Assert.That(bill1.amountPaidByPatientDollars, Is.EqualTo(bill2.amountPaidByPatientDollars));
            Assert.That(bill1.amountPaidByPatientCents, Is.EqualTo(bill2.amountPaidByPatientCents));
            Assert.That(bill1.amountPaidByInsuranceDollars, Is.EqualTo(bill2.amountPaidByInsuranceDollars));
            Assert.That(bill1.amountPaidByInsuranceCents, Is.EqualTo(bill2.amountPaidByInsuranceCents));
            Assert.That(bill1.amountOwedDollars, Is.EqualTo(bill2.amountOwedDollars));
            Assert.That(bill1.amountOwedCents, Is.EqualTo(bill2.amountOwedCents));
            Assert.That(bill1.dateCharged, Is.EqualTo(bill2.dateCharged));
            Assert.That(bill1.dateDue, Is.EqualTo(bill2.dateDue));
            Assert.That(bill1.patientId, Is.EqualTo(bill2.patientId));
            Assert.That(bill1.caseId, Is.EqualTo(bill2.caseId));
        }
    }
}
