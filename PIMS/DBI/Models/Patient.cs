using System;
using System.Collections.Generic;
using System.Text;

namespace DBI
{
    public class Patient
    {
        private int _unassigned = -1;

        public int patientId { get; set; }
        public string nameLast { get; set; }
        public string nameFirst { get; set; }
        public string nameMiddle { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phoneHome { get; set; }
        public string areaCodeHome { get; set; }
        public string phoneWork { get; set; }
        public string areaCodeWork { get; set; }
        public string phoneMobile { get; set; }
        public string areaCodeMobile { get; set; }
        public string familyDoctor { get; set; }
        public int NotesCount { get; set; }

        public Patient()
        {
            patientId = _unassigned;
            nameLast = string.Empty;
            nameFirst = string.Empty;
            nameMiddle = string.Empty;
            street = string.Empty;
            city = string.Empty;
            state = string.Empty;
            zip = string.Empty;
            phoneHome = string.Empty;
            areaCodeHome = string.Empty;
            phoneWork = string.Empty;
            areaCodeWork = string.Empty;
            phoneMobile = string.Empty;
            areaCodeMobile = string.Empty;
            familyDoctor = string.Empty;
            NotesCount = 0;
        }

        public Patient(string nameLast, string nameFirst, string nameMiddle, string street,
            string city, string state, string zip, string phoneHome, string areaCodeHome, string phoneWork,
            string areaCodeWork, string phoneMobile, string areaCodeMobile, string familyDoctor, int patientId)
        {
            this.nameLast = nameLast;
            this.nameFirst = nameFirst;
            this.nameMiddle = nameMiddle;
            this.street = street;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneHome = phoneHome;
            this.areaCodeHome = areaCodeHome;
            this.phoneWork = phoneWork;
            this.areaCodeWork = areaCodeWork;
            this.phoneMobile = phoneMobile;
            this.areaCodeMobile = areaCodeMobile;
            this.familyDoctor = familyDoctor;
            this.patientId = patientId;
            this.NotesCount = 0;
        }
    }
}
