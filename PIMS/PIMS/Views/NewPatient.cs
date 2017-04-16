using PIMS.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS.Views
{
    public partial class frmNewPatient : Form
    {
        // Locals
        PNewPatient Presenter;

        // Ctor
        public frmNewPatient()
        {
            InitializeComponent();
            Presenter = new PNewPatient(this);
        }

        #region Properties
        // Personal Details
        public string NameFirst { get { return txtFirstName.Text; } set { txtFirstName.Text = value; } }
        public string NameMiddle { get { return txtMiddleName.Text; } set { txtMiddleName.Text = value; } }
        public string NameLast { get { return txtLastName.Text; } set { txtLastName.Text = value; } }
        public string StreetAddress { get { return txtStreetAddress.Text; } set { txtStreetAddress.Text = value; } }
        public string City { get { return txtCity.Text; } set { txtCity.Text = value; } }
        public string State { get { return txtState.Text; } set { txtState.Text = value; } }
        public string Zip { get { return txtZipCode.Text; } set { txtZipCode.Text = value; } }
        public string AreaCodeHome { get { return txtAreaCodeHome.Text; } set { txtAreaCodeHome.Text = value; } }
        public string PhoneHome { get { return txtHomePhone.Text; } set { txtHomePhone.Text = value; } }
        public string AreaCodeWork { get { return txtAreaCodeWork.Text; } set { txtAreaCodeWork.Text = value; } }
        public string PhoneWork { get { return txtWorkPhone.Text; } set { txtWorkPhone.Text = value; } }
        public string AreaCodeCell { get { return txtAreaCodeCell.Text; } set { txtAreaCodeCell.Text = value; } }
        public string PhoneCell { get { return txtCellPhone.Text; } set { txtCellPhone.Text = value; } }
        public string FamilyDoctor { get { return txtFamilyDoctor.Text; } set { txtFamilyDoctor.Text = value; } }

        // Emergency Contact
        public string NameFirstEC { get { return txtFirstNameIce.Text; } set { txtFirstNameIce.Text = value; } }
        public string NameLastEC { get { return txtLastNameIce.Text; } set { txtLastNameIce.Text = value; } }
        public string AreaCodeEC { get { return txtAreaCodeIce.Text; } set { txtAreaCodeIce.Text = value; } }
        public string PhoneEC { get { return txtPhoneNumberIce.Text; } set { txtPhoneNumberIce.Text = value; } }

        // Insurance
        public string Carrier { get { return txtCarrier.Text; } set { txtCarrier.Text = value; } }
        public string AccountNumber { get { return txtAccountNumber.Text; } set { txtCarrier.Text = value; } }
        public string GroupNumber { get { return txtGroupNumber.Text; } set { txtGroupNumber.Text = value; } }

        // Admission
        public string DateOfAdmission { get { return dtpAdmissionTime.Value.Date.ToString(); } }
        public string TimeOfAdmission { get { return dtpAdmissionTime.Value.TimeOfDay.ToString(); } }
        public string AdmissionReason { get { return txtAdmissionReason.Text; } set { txtAdmissionReason.Text = value; } }
        public string Facility { get { return txtFacility.Text; } set { txtFacility.Text = value; } }
        public string FloorNumber { get { return txtFloorNumber.Text; } set { txtFloorNumber.Text = value; } }
        public string RoomNumber { get { return txtRoomNumber.Text; } set { txtRoomNumber.Text = value; } }
        public string BedNumber { get { return txtBedNumber.Text; } set { txtBedNumber.Text = value; } }

        // Form
        public int CurrentTab { get { return wizardPages1.SelectedIndex; } set { wizardPages1.SelectedIndex = value; } }
        #endregion

        #region Events
        private void btnCancel1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            Presenter.AdvanceTabs();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnPrevious1_Click(object sender, EventArgs e)
        {
            Presenter.RetreatTabs();
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            Presenter.AdvanceTabs();
        }

        private void btnCancel3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnPrevious2_Click(object sender, EventArgs e)
        {
            Presenter.RetreatTabs();
        }

        private void btnNext3_Click(object sender, EventArgs e)
        {
            Presenter.AdvanceTabs();
        }

        private void btnCancel4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnPrevious3_Click(object sender, EventArgs e)
        {
            Presenter.RetreatTabs();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Presenter.AdvanceTabs();
        }

        private void wizardPages1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
