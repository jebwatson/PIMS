using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIMS.Views;

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

                    if (View.AreaCodeHome.Length != 3 || View.PhoneHome.Length != 7 ||
                        View.AreaCodeWork.Length != 3 || View.PhoneWork.Length != 7 ||
                        View.AreaCodeCell.Length != 3 || View.PhoneCell.Length != 7)
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

                    if (View.FamilyDoctor.Length == 0 || View.FamilyDoctor.Length > 128)
                    {
                        View.FamilyDoctor = string.Empty;
                        System.Windows.Forms.MessageBox.Show("Invalid string. Please enter a valid string for family doctor to continue.");
                        sufficientData = false;
                    }
                    break;
                case 1:
                    if (View.NameFirstEC.Length == 0 || View.NameFirstEC.Length > 128 ||
                        View.NameLastEC.Length == 0 || View.NameLastEC.Length > 128)
                    {
                        View.NameFirstEC = string.Empty;
                        View.NameLastEC = string.Empty;
                        System.Windows.Forms.MessageBox.Show("Invalid name string(s). Enter a valid string to continue.");
                        sufficientData = false;
                    }

                    if (View.AreaCodeEC.Length != 3 || View.PhoneEC.Length != 7)
                    {
                        View.AreaCodeEC = string.Empty;
                        View.PhoneEC = string.Empty;
                        System.Windows.Forms.MessageBox.Show("Invalid phone number. Please enter a valid phone number to continue.");
                        sufficientData = false;
                    }
                    break;
                case 2:
                    if (View.Carrier.Length == 0 || View.Carrier.Length > 128)
                    {
                        View.Carrier = string.Empty;
                        System.Windows.Forms.MessageBox.Show("Invalid carrier string. Enter a valid string to continue.");
                        sufficientData = false;
                    }

                    if (View.AccountNumber.Length != 9)
                    {
                        View.AccountNumber = string.Empty;
                        System.Windows.Forms.MessageBox.Show("Invalid account number string. Please enter a valid string to continue.");
                        sufficientData = false;
                    }

                    if (View.GroupNumber.Length != 6)
                    {
                        View.GroupNumber = string.Empty;
                        System.Windows.Forms.MessageBox.Show("Invalid group number string. Please enter a valid string to continue.");
                        sufficientData = false;
                    }
                    break;
                case 3:
                    if (View.AdmissionReason.Length == 0)
                    {
                        System.Windows.Forms.MessageBox.Show("Please enter a reason for admission to continue.");
                        sufficientData = false;
                    }
                    if (View.Facility.Length == 0 || View.Facility.Length > 128 ||
                        View.FloorNumber.Length == 0 || View.FloorNumber.Length > 4 ||
                        View.RoomNumber.Length == 0 || View.RoomNumber.Length > 6 ||
                        View.BedNumber.Length == 0 || View.BedNumber.Length > 4)
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
