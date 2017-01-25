using System;
using System.Collections.Generic;
using System.Text;

namespace DBI
{
    class Admission
    {
        private const int _unassigned = -1;

        public int admissionId { get; set; }
        public DateTime admissionTime { get; set; }
        public DateTime dischargeTime { get; set; }
        public string admissionReason { get; set; }
        public string dischargeReason { get; set; }
        public string facilityNumber { get; set; }
        public string floorNumber { get; set; }
        public string roomNumber { get; set; }
        public string bedNumber { get; set; }
        public int patientId { get; set; }
        public int caseId { get; set; }

        public Admission()
        {
            admissionId = _unassigned;
            admissionTime = DateTime.Now;
            dischargeTime = DateTime.Now;
            admissionReason = string.Empty;
            dischargeReason = string.Empty;
            facilityNumber = string.Empty;
            floorNumber = string.Empty;
            roomNumber = string.Empty;
            bedNumber = string.Empty;
            patientId = _unassigned;
            caseId = _unassigned;
        }

        public Admission(int valAdmittanceId, DateTime valAdmittanceTime, DateTime valDischargeTime, string valAdmittanceReason, string valDischargeReason,
            string valFacility, string valFloor, string valRoomNumber, string valBedNumber, int valPatientId, int valCaseId)
        {
            admissionId = valAdmittanceId;
            admissionTime = valAdmittanceTime;
            dischargeTime = valDischargeTime;
            admissionReason = valAdmittanceReason;
            dischargeReason = valDischargeReason;
            facilityNumber = valFacility;
            floorNumber = valFloor;
            roomNumber = valRoomNumber;
            bedNumber = valBedNumber;
            patientId = valPatientId;
            caseId = valCaseId;
        }
    }
}
