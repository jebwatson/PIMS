using System;
using System.Collections.Generic;
using System.Text;

namespace DBI
{
    public class Cases
    {
        private const int _unassigned = -1;

        public int caseId { get; set; }
        public int supervisingDoctorId { get; set; }
        public int approvedVisitorCount { get; set; }
        public int patientId { get; set; }

        public Cases()
        {
            caseId = _unassigned;
            supervisingDoctorId = _unassigned;
            approvedVisitorCount = _unassigned;
            patientId = _unassigned;
        }

        public Cases(int valCaseId, int valSupervisingDoctorId, int valApprovedVisitorCount, int valPatientId)
        {
            caseId = valCaseId;
            supervisingDoctorId = valSupervisingDoctorId;
            approvedVisitorCount = valApprovedVisitorCount;
            patientId = valPatientId;
        }
    }
}
