using System;
using System.Collections.Generic;
using System.Text;

namespace DBI
{
    class Admittances
    {
        private const int _unassigned = -1;

        public int admittanceId { get; set; }
        public DateTime admittanceDate { get; set; }
        public DateTime dischargeDate { get; set; }
        public string admittanceReason { get; set; }
        public string dischargeReason { get; set; }
        public string facility { get; set; }
        public string floor { get; set; }
        public string roomNumber { get; set; }
        public string bedNumber { get; set; }
        public int patientId { get; set; }
        public int caseId { get; set; }

        public Admittances()
        {
            admittanceId = _unassigned;
            admittanceDate = DateTime.Now;
            dischargeDate = DateTime.Now;
            admittanceReason = string.Empty;
            dischargeReason = string.Empty;
            facility = string.Empty;
            floor = string.Empty;
            roomNumber = string.Empty;
            bedNumber = string.Empty;
            patientId = _unassigned;
            caseId = _unassigned;
        }

        public Admittances(int valAdmittanceId, DateTime valAdmittanceDate, DateTime valDischargeDate, string valAdmittanceReason, string valDischargeReason,
            string valFacility, string valFloor, string valRoomNumber, string valBedNumber, int valPatientId, int valCaseId)
        {
            admittanceId = valAdmittanceId;
            admittanceDate = valAdmittanceDate;
            dischargeDate = valDischargeDate;
            admittanceReason = valAdmittanceReason;
            dischargeReason = valDischargeReason;
            facility = valFacility;
            floor = valFloor;
            roomNumber = valRoomNumber;
            bedNumber = valBedNumber;
            patientId = valPatientId;
            caseId = valCaseId;
        }
    }
}
