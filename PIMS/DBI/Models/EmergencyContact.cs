using System;
using System.Collections.Generic;
using System.Text;

namespace DBI
{
    public class EmergencyContact
    {
        int _unassigned = -1;

        public int emergencyContactId { get; set; }
        public string nameLast { get; set; }
        public string nameFirst { get; set; }
        public string nameMiddle { get; set; }
        public string phone { get; set; }
        public string areaCode { get; set; }
        public int patientId { get; set; }
        public string name { get; set; }

        public EmergencyContact()
        {
            emergencyContactId = _unassigned;
            nameLast = string.Empty;
            nameFirst = string.Empty;
            nameMiddle = string.Empty;
            phone = string.Empty;
            areaCode = string.Empty;
            patientId = _unassigned;
        }

        public EmergencyContact(string nameLast, string nameFirst, string nameMiddle, string phone,
            string areaCode, int patientId, int emergencyContactId)
        {
            this.nameLast = nameLast;
            this.nameFirst = nameFirst;
            this.nameMiddle = nameMiddle;
            this.phone = phone;
            this.areaCode = areaCode;
            this.patientId = patientId;
            this.emergencyContactId = emergencyContactId;
        }
    }
}
