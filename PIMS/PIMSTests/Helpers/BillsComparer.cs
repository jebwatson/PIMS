using DBI;
using NUnit.Framework;

namespace PIMSTests.Helpers
{
    class BillsComparer : ICompare<Bills>
    {
        public void Compare(Bills bill1, Bills bill2)
        {
            Assert.That(bill1.billId, Is.EqualTo(bill2.billId));
            Assert.That(bill1.amountTotal, Is.EqualTo(bill2.amountTotal));
            Assert.That(bill1.amountPaidByPatient, Is.EqualTo(bill2.amountPaidByPatient));
            Assert.That(bill1.amountPaidByInsurance, Is.EqualTo(bill2.amountPaidByInsurance));
            Assert.That(bill1.amountOwed, Is.EqualTo(bill2.amountOwed));
            Assert.That(bill1.dateCharged, Is.EqualTo(bill2.dateCharged));
            Assert.That(bill1.dateDue, Is.EqualTo(bill2.dateDue));
            Assert.That(bill1.patientId, Is.EqualTo(bill2.patientId));
        }
    }
}
