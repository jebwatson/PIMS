using System;
using System.Collections.Generic;
using System.Text;

namespace DBI
{
    public class Admission
    {
        private const int _unassigned = -1;

        public int admissionId { get; set; }
        public DateTime admissionTime { get; set; }
        public DateTime dischargeTime { get; set; }
        public string admissionReason { get; set; }
        public string facility { get; set; }
        public string floor { get; set; }
        public string roomNumber { get; set; }
        public string bedNumber { get; set; }
        public int patientId { get; set; }

        public Admission()
        {
            admissionId = _unassigned;
            admissionTime = DateTime.Now;
            dischargeTime = DateTime.Now;
            admissionReason = string.Empty;
            facility = string.Empty;
            floor = string.Empty;
            roomNumber = string.Empty;
            bedNumber = string.Empty;
            patientId = _unassigned;
        }

        public Admission(DateTime valAdmittanceTime, DateTime valDischargeTime, string valAdmittanceReason,
            string valFacility, string valFloor, string valRoomNumber, string valBedNumber, int valPatientId)
        {
            admissionTime = valAdmittanceTime;
            dischargeTime = valDischargeTime;
            admissionReason = valAdmittanceReason;
            facility = valFacility;
            floor = valFloor;
            roomNumber = valRoomNumber;
            bedNumber = valBedNumber;
            patientId = valPatientId;
        }
    }
}
