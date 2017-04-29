using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIMS.Views;
using DBI;
using System.Windows.Forms;

namespace PIMS.Presenters
{
    class PNewPatient
    {
        // Locals
        frmNewPatient View;

        public PNewPatient(frmNewPatient view)
        {
            View = view;
        }

        /// <summary>
        /// Advance the tabs in the view.
        /// </summary>
        public void AdvanceTabs()
        {
            switch (View.CurrentTab)
            {
                case 0:
                    if (CheckData())
                    {
                        View.CurrentTab = 1;
                    }
                    break;
                case 1:
                    if (CheckData())
                    {
                        View.CurrentTab = 2;
                    }
                    break;
                case 2:
                    if (CheckData())
                    {
                        View.CurrentTab = 3;
                    }
                    break;
                case 3:
                    if (CheckData())
                    {
                        // Submit and create patient
                        Patient MyPatient = new Patient(View.NameFirst, View.NameMiddle, View.NameLast,
                            View.StreetAddress, View.City, View.State, View.Zip, View.PhoneHome, View.AreaCodeHome,
                            View.PhoneWork, View.AreaCodeWork, View.PhoneCell, View.AreaCodeCell, View.FamilyDoctor, 1);

                        PatientTable MyPatientTable = new PatientTable();
                        MyPatientTable.WriteItem(MyPatient);
                        List<Patient> MyPatientList = MyPatientTable.ReadListByName(View.NameLast);

                        EmergencyContact MyEmergencyContact = new EmergencyContact(View.NameFirstEC, View.NameLastEC,
                            "", View.PhoneEC, View.AreaCodeEC, MyPatientList[0].patientId, 1);
                        DBI.Insurance MyInsurance = new DBI.Insurance(View.Carrier, View.AccountNumber, View.GroupNumber,
                            MyPatientList[0].patientId, 1);
                        Admission MyAdmission = new Admission(View.TimeOfAdmission.ToString(), "", View.AdmissionReason, View.Facility,
                            View.FloorNumber, View.RoomNumber, View.BedNumber, MyPatientList[0].patientId, 1);

                        EmergencyContactTable MyEmergencyContactTable = new EmergencyContactTable();
                        InsuranceTable MyInsuranceTable = new InsuranceTable();
                        AdmissionsTable MyAdmissionsTable = new AdmissionsTable();

                        MyEmergencyContactTable.WriteItem(MyEmergencyContact);
                        MyInsuranceTable.WriteItem(MyInsurance);
                        MyAdmissionsTable.WriteItem(MyAdmission);

                        View.DialogResult = DialogResult.OK;
                        View.Close();
                    }
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Go back one tab.
        /// </summary>
        public void RetreatTabs()
        {
            switch (View.CurrentTab)
            {
                case 0:
                    break;
                case 1:
                    View.CurrentTab = 0;
                    break;
                case 2:
                    View.CurrentTab = 1;
                    break;
                case 3:
                    View.CurrentTab = 2;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Check the users data for the current tab and make sure that it is valid.
        /// </summary>
        /// <returns></returns>
        private bool CheckData()
        {
            bool sufficientData = true;

            switch (View.CurrentTab)
            {
                case 0:
                    if (View.NameFirst.Length == 0 || View.NameFirst.Length > 128 
                        || View.NameLast.Length == 0 || View.NameLast.Length > 128 || View.NameMiddle.Length > 128)
                    {
                        View.NameFirst = string.Empty;
                        View.NameMiddle = string.Empty;
                        View.NameLast = string.Empty;
                        System.Windows.Forms.MessageBox.Show("Invalid patient name. Enter a valid name to continue.");
                        sufficientData = false;
                    }

                    if (View.StreetAddress.Length == 0 || View.StreetAddress.Length > 128 ||
                        View.City.Length == 0 || View.City.Length > 128 ||
                        View.State.Length == 0 || View.State.Length > 128||
                        View.Zip.Length != 5)
                    {
                        View.StreetAddress = string.Empty;
                        View.City = string.Empty;
                        View.State = string.Empty;
                        View.Zip = string.Empty;
                        System.Windows.Forms.MessageBox.Show("Invalid address information. Enter valid address values to continue.");
                        sufficientData = false;
                    }

                    if (View.AreaCodeHome.Length != 3 || View.PhoneHome.Length != 7 || View.PhoneHome.Length != 0 ||
                        View.AreaCodeWork.Length != 3 || View.PhoneWork.Length != 7 || View.PhoneWork.Length != 0 ||
                        View.AreaCodeCell.Length != 3 || View.PhoneCell.Length != 7 || View.PhoneCell.Length != 0)
                    {
                        View.AreaCodeHome = string.Empty;
                        View.PhoneHome = string.Empty;
                        View.AreaCodeWork = string.Empty;
                        View.PhoneWork = string.Empty;
                        View.AreaCodeCell = string.Empty;
                        View.PhoneCell = string.Empty;
                        System.Windows.Forms.MessageBox.Show("Invalid number. Please enter valid area codes and phone numbers to continue.");
                        sufficientData = false;
                    }

                    if (View.FamilyDoctor.Length > 128)
                    {
                        View.FamilyDoctor = string.Empty;
                        System.Windows.Forms.MessageBox.Show("Invalid string. Please enter a valid string for family doctor to continue.");
                        sufficientData = false;
                    }
                    break;
                case 1:
                    if (View.NameFirstEC.Length > 128 || View.NameLastEC.Length > 128)
                    {
                        View.NameFirstEC = string.Empty;
                        View.NameLastEC = string.Empty;
                        System.Windows.Forms.MessageBox.Show("Invalid name string(s). Enter a valid string to continue.");
                        sufficientData = false;
                    }

                    if (View.AreaCodeEC.Length != 3 || View.PhoneEC.Length != 7 || View.PhoneEC.Length != 0)
                    {
                        View.AreaCodeEC = string.Empty;
                        View.PhoneEC = string.Empty;
                        System.Windows.Forms.MessageBox.Show("Invalid phone number. Please enter a valid phone number to continue.");
                        sufficientData = false;
                    }
                    break;
                case 2:
                    if (View.Carrier.Length > 128)
                    {
                        View.Carrier = string.Empty;
                        System.Windows.Forms.MessageBox.Show("Invalid carrier string. Enter a valid string to continue.");
                        sufficientData = false;
                    }

                    if (View.AccountNumber.Length != 9 || View.AccountNumber.Length != 0)
                    {
                        View.AccountNumber = string.Empty;
                        System.Windows.Forms.MessageBox.Show("Invalid account number string. Please enter a valid string to continue.");
                        sufficientData = false;
                    }

                    if (View.GroupNumber.Length != 6 || View.GroupNumber.Length != 0)
                    {
                        View.GroupNumber = string.Empty;
                        System.Windows.Forms.MessageBox.Show("Invalid group number string. Please enter a valid string to continue.");
                        sufficientData = false;
                    }
                    break;
                case 3:
                    // Disabled these checks to relax the add patient process.
                    //if (View.AdmissionReason.Length == 0)
                    //{
                    //    System.Windows.Forms.MessageBox.Show("Please enter a reason for admission to continue.");
                    //    sufficientData = false;
                    //}
                    if (View.Facility.Length > 128 ||
                        View.FloorNumber.Length > 32 ||
                        View.RoomNumber.Length > 32 ||
                        View.BedNumber.Length > 32)
                    {
                        View.Facility = string.Empty;
                        View.FloorNumber = string.Empty;
                        View.RoomNumber = string.Empty;
                        View.BedNumber = string.Empty;
                        System.Windows.Forms.MessageBox.Show("Invalid patient location. Please enter a valid location to continue.");
                        sufficientData = false;
                    }
                    break;
                default:
                    break;
            }

            return sufficientData;
        }
    }
}
