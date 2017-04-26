namespace PIMS.Views
{
    partial class frmNewPatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wizardPages1 = new cssa_appraisal_partner_version3.HelperClasses.WizardPages();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtAreaCodeCell = new System.Windows.Forms.TextBox();
            this.txtAreaCodeWork = new System.Windows.Forms.TextBox();
            this.txtAreaCodeHome = new System.Windows.Forms.TextBox();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.lblFamilyDoctor = new System.Windows.Forms.Label();
            this.txtFamilyDoctor = new System.Windows.Forms.TextBox();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.lblWorkPhone = new System.Windows.Forms.Label();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.txtWorkPhone = new System.Windows.Forms.TextBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblNewPatient1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPrevious1 = new System.Windows.Forms.Button();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnNext2 = new System.Windows.Forms.Button();
            this.txtPhoneNumberIce = new System.Windows.Forms.TextBox();
            this.txtAreaCodeIce = new System.Windows.Forms.TextBox();
            this.lblPhoneNumberIce = new System.Windows.Forms.Label();
            this.lblAreaCodeIce = new System.Windows.Forms.Label();
            this.txtLastNameIce = new System.Windows.Forms.TextBox();
            this.txtFirstNameIce = new System.Windows.Forms.TextBox();
            this.lblLastNameIce = new System.Windows.Forms.Label();
            this.lblFirstNameIce = new System.Windows.Forms.Label();
            this.lblNewPatient2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnPrevious2 = new System.Windows.Forms.Button();
            this.btnCancel3 = new System.Windows.Forms.Button();
            this.btnNext3 = new System.Windows.Forms.Button();
            this.txtGroupNumber = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtCarrier = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblGroupNumber = new System.Windows.Forms.Label();
            this.lblCarrier = new System.Windows.Forms.Label();
            this.lblNewPatientInsurance = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblAdmissionReason = new System.Windows.Forms.Label();
            this.txtAdmissionReason = new System.Windows.Forms.TextBox();
            this.btnPrevious3 = new System.Windows.Forms.Button();
            this.btnCancel4 = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtBedNumber = new System.Windows.Forms.TextBox();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.txtFloorNumber = new System.Windows.Forms.TextBox();
            this.txtFacility = new System.Windows.Forms.TextBox();
            this.lblBedNumber = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblFacility = new System.Windows.Forms.Label();
            this.lblAdmissionDate = new System.Windows.Forms.Label();
            this.dtpAdmissionTime = new System.Windows.Forms.DateTimePicker();
            this.lblAdmissionInformation = new System.Windows.Forms.Label();
            this.wizardPages1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizardPages1
            // 
            this.wizardPages1.Controls.Add(this.tabPage1);
            this.wizardPages1.Controls.Add(this.tabPage2);
            this.wizardPages1.Controls.Add(this.tabPage3);
            this.wizardPages1.Controls.Add(this.tabPage4);
            this.wizardPages1.Location = new System.Drawing.Point(12, 12);
            this.wizardPages1.Name = "wizardPages1";
            this.wizardPages1.SelectedIndex = 0;
            this.wizardPages1.Size = new System.Drawing.Size(580, 486);
            this.wizardPages1.TabIndex = 0;
            this.wizardPages1.SelectedIndexChanged += new System.EventHandler(this.wizardPages1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtAreaCodeCell);
            this.tabPage1.Controls.Add(this.txtAreaCodeWork);
            this.tabPage1.Controls.Add(this.txtAreaCodeHome);
            this.tabPage1.Controls.Add(this.btnCancel1);
            this.tabPage1.Controls.Add(this.btnNext1);
            this.tabPage1.Controls.Add(this.lblFamilyDoctor);
            this.tabPage1.Controls.Add(this.txtFamilyDoctor);
            this.tabPage1.Controls.Add(this.lblCellPhone);
            this.tabPage1.Controls.Add(this.lblWorkPhone);
            this.tabPage1.Controls.Add(this.lblHomePhone);
            this.tabPage1.Controls.Add(this.txtCellPhone);
            this.tabPage1.Controls.Add(this.txtWorkPhone);
            this.tabPage1.Controls.Add(this.txtHomePhone);
            this.tabPage1.Controls.Add(this.lblZipCode);
            this.tabPage1.Controls.Add(this.lblState);
            this.tabPage1.Controls.Add(this.lblCity);
            this.tabPage1.Controls.Add(this.lblStreetAddress);
            this.tabPage1.Controls.Add(this.txtZipCode);
            this.tabPage1.Controls.Add(this.txtState);
            this.tabPage1.Controls.Add(this.txtCity);
            this.tabPage1.Controls.Add(this.txtStreetAddress);
            this.tabPage1.Controls.Add(this.lblMiddleName);
            this.tabPage1.Controls.Add(this.lblLastName);
            this.tabPage1.Controls.Add(this.lblFirstName);
            this.tabPage1.Controls.Add(this.txtLastName);
            this.tabPage1.Controls.Add(this.txtMiddleName);
            this.tabPage1.Controls.Add(this.lblNewPatient1);
            this.tabPage1.Controls.Add(this.txtFirstName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";

            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);

            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);

            this.tabPage1.Size = new System.Drawing.Size(572, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtAreaCodeCell
            // 
            this.txtAreaCodeCell.Location = new System.Drawing.Point(374, 284);
            this.txtAreaCodeCell.Multiline = true;
            this.txtAreaCodeCell.Name = "txtAreaCodeCell";
            this.txtAreaCodeCell.Size = new System.Drawing.Size(38, 26);
            this.txtAreaCodeCell.TabIndex = 56;
            // 
            // txtAreaCodeWork
            // 
            this.txtAreaCodeWork.Location = new System.Drawing.Point(209, 284);
            this.txtAreaCodeWork.Multiline = true;
            this.txtAreaCodeWork.Name = "txtAreaCodeWork";
            this.txtAreaCodeWork.Size = new System.Drawing.Size(43, 26);
            this.txtAreaCodeWork.TabIndex = 55;
            // 
            // txtAreaCodeHome
            // 
            this.txtAreaCodeHome.Location = new System.Drawing.Point(55, 284);
            this.txtAreaCodeHome.Multiline = true;
            this.txtAreaCodeHome.Name = "txtAreaCodeHome";
            this.txtAreaCodeHome.Size = new System.Drawing.Size(39, 26);
            this.txtAreaCodeHome.TabIndex = 54;
            // 
            // btnCancel1
            // 
            this.btnCancel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel1.Location = new System.Drawing.Point(133, 418);

            this.btnCancel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);

            this.btnCancel1.Margin = new System.Windows.Forms.Padding(2);

            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(127, 37);
            this.btnCancel1.TabIndex = 53;
            this.btnCancel1.Text = "Cancel";
            this.btnCancel1.UseVisualStyleBackColor = true;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // btnNext1
            // 
            this.btnNext1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext1.Location = new System.Drawing.Point(323, 418);

            this.btnNext1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);

            this.btnNext1.Margin = new System.Windows.Forms.Padding(2);

            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(127, 37);
            this.btnNext1.TabIndex = 52;
            this.btnNext1.Text = "Next";
            this.btnNext1.UseVisualStyleBackColor = true;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 

            // lblPatientId
            // 
            /*this.lblPatientId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPatientId.AutoSize = true;
            this.lblPatientId.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientId.Location = new System.Drawing.Point(414, 382);
            this.lblPatientId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatientId.Name = "lblPatientId";
            this.lblPatientId.Size = new System.Drawing.Size(51, 14);
            this.lblPatientId.TabIndex = 51;
            this.lblPatientId.Text = "Patient ID";*/
            // 


            // lblFamilyDoctor
            // 
            this.lblFamilyDoctor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFamilyDoctor.AutoSize = true;
            this.lblFamilyDoctor.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilyDoctor.Location = new System.Drawing.Point(96, 382);
            this.lblFamilyDoctor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFamilyDoctor.Name = "lblFamilyDoctor";
            this.lblFamilyDoctor.Size = new System.Drawing.Size(72, 14);
            this.lblFamilyDoctor.TabIndex = 50;
            this.lblFamilyDoctor.Text = "Family Doctor";
            // 

            // txtPatientId
            // 
            /*this.txtPatientId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPatientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientId.Location = new System.Drawing.Point(383, 355);
            this.txtPatientId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(108, 26);
            this.txtPatientId.TabIndex = 49;*/
            // 


            // txtFamilyDoctor
            // 
            this.txtFamilyDoctor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFamilyDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFamilyDoctor.Location = new System.Drawing.Point(66, 355);

            this.txtFamilyDoctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);

            this.txtFamilyDoctor.Margin = new System.Windows.Forms.Padding(2);

            this.txtFamilyDoctor.Name = "txtFamilyDoctor";
            this.txtFamilyDoctor.Size = new System.Drawing.Size(134, 26);
            this.txtFamilyDoctor.TabIndex = 48;
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellPhone.Location = new System.Drawing.Point(414, 310);
            this.lblCellPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(57, 14);
            this.lblCellPhone.TabIndex = 47;
            this.lblCellPhone.Text = "Cell Phone";
            // 
            // lblWorkPhone
            // 
            this.lblWorkPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWorkPhone.AutoSize = true;
            this.lblWorkPhone.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkPhone.Location = new System.Drawing.Point(254, 310);
            this.lblWorkPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWorkPhone.Name = "lblWorkPhone";
            this.lblWorkPhone.Size = new System.Drawing.Size(65, 14);
            this.lblWorkPhone.TabIndex = 46;
            this.lblWorkPhone.Text = "Work Phone";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePhone.Location = new System.Drawing.Point(96, 310);
            this.lblHomePhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(67, 14);
            this.lblHomePhone.TabIndex = 45;
            this.lblHomePhone.Text = "Home Phone";
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCellPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCellPhone.Location = new System.Drawing.Point(417, 284);

            this.txtCellPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);

            this.txtCellPhone.Margin = new System.Windows.Forms.Padding(2);

            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(90, 26);
            this.txtCellPhone.TabIndex = 44;
            // 
            // txtWorkPhone
            // 
            this.txtWorkPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWorkPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkPhone.Location = new System.Drawing.Point(257, 284);

            this.txtWorkPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);

            this.txtWorkPhone.Margin = new System.Windows.Forms.Padding(2);

            this.txtWorkPhone.Name = "txtWorkPhone";
            this.txtWorkPhone.Size = new System.Drawing.Size(105, 26);
            this.txtWorkPhone.TabIndex = 43;
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHomePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomePhone.Location = new System.Drawing.Point(99, 284);

            this.txtHomePhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);

            this.txtHomePhone.Margin = new System.Windows.Forms.Padding(2);

            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(105, 26);
            this.txtHomePhone.TabIndex = 42;
            // 
            // lblZipCode
            // 
            this.lblZipCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.Location = new System.Drawing.Point(414, 215);
            this.lblZipCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(50, 14);
            this.lblZipCode.TabIndex = 41;
            this.lblZipCode.Text = "Zip Code";
            // 
            // lblState
            // 
            this.lblState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(371, 215);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(20, 14);
            this.lblState.TabIndex = 40;
            this.lblState.Text = "ST";
            // 
            // lblCity
            // 
            this.lblCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(314, 215);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(25, 14);
            this.lblCity.TabIndex = 39;
            this.lblCity.Text = "City";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAddress.Location = new System.Drawing.Point(130, 215);
            this.lblStreetAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(80, 14);
            this.lblStreetAddress.TabIndex = 38;
            this.lblStreetAddress.Text = "Street Address";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZipCode.Location = new System.Drawing.Point(395, 188);

            this.txtZipCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);

            this.txtZipCode.Margin = new System.Windows.Forms.Padding(2);

            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(88, 26);
            this.txtZipCode.TabIndex = 37;
            // 
            // txtState
            // 
            this.txtState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.Location = new System.Drawing.Point(368, 188);

            this.txtState.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);

            this.txtState.Margin = new System.Windows.Forms.Padding(2);

            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(30, 26);
            this.txtState.TabIndex = 36;
            // 
            // txtCity
            // 
            this.txtCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(282, 188);

            this.txtCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);

            this.txtCity.Margin = new System.Windows.Forms.Padding(2);

            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(88, 26);
            this.txtCity.TabIndex = 35;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStreetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetAddress.Location = new System.Drawing.Point(66, 188);

            this.txtStreetAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);

            this.txtStreetAddress.Margin = new System.Windows.Forms.Padding(2);

            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(219, 26);
            this.txtStreetAddress.TabIndex = 34;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(244, 114);
            this.lblMiddleName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(67, 14);
            this.lblMiddleName.TabIndex = 33;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(392, 114);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 14);
            this.lblLastName.TabIndex = 32;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(96, 114);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(58, 14);
            this.lblFirstName.TabIndex = 31;
            this.lblFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(368, 84);

            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);

            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);

            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(108, 26);
            this.txtLastName.TabIndex = 30;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.Location = new System.Drawing.Point(219, 84);

            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);

            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(2);

            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(108, 26);
            this.txtMiddleName.TabIndex = 29;
            // 
            // lblNewPatient1
            // 
            this.lblNewPatient1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNewPatient1.AutoSize = true;
            this.lblNewPatient1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPatient1.Location = new System.Drawing.Point(163, 17);
            this.lblNewPatient1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewPatient1.Name = "lblNewPatient1";
            this.lblNewPatient1.Size = new System.Drawing.Size(264, 32);
            this.lblNewPatient1.TabIndex = 28;
            this.lblNewPatient1.Text = "Personal Information";
            this.lblNewPatient1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(73, 84);

            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);

            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);

            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(108, 26);
            this.txtFirstName.TabIndex = 27;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnPrevious1);
            this.tabPage2.Controls.Add(this.btnCancel2);
            this.tabPage2.Controls.Add(this.btnNext2);
            this.tabPage2.Controls.Add(this.txtPhoneNumberIce);
            this.tabPage2.Controls.Add(this.txtAreaCodeIce);
            this.tabPage2.Controls.Add(this.lblPhoneNumberIce);
            this.tabPage2.Controls.Add(this.lblAreaCodeIce);
            this.tabPage2.Controls.Add(this.txtLastNameIce);
            this.tabPage2.Controls.Add(this.txtFirstNameIce);
            this.tabPage2.Controls.Add(this.lblLastNameIce);
            this.tabPage2.Controls.Add(this.lblFirstNameIce);
            this.tabPage2.Controls.Add(this.lblNewPatient2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";

            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);

            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);

            this.tabPage2.Size = new System.Drawing.Size(572, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPrevious1
            // 
            this.btnPrevious1.Location = new System.Drawing.Point(236, 382);
            this.btnPrevious1.Name = "btnPrevious1";
            this.btnPrevious1.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious1.TabIndex = 12;
            this.btnPrevious1.Text = "Previous";
            this.btnPrevious1.UseVisualStyleBackColor = true;
            this.btnPrevious1.Click += new System.EventHandler(this.btnPrevious1_Click);
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(103, 382);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(75, 23);
            this.btnCancel2.TabIndex = 11;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnNext2
            // 
            this.btnNext2.Location = new System.Drawing.Point(367, 382);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.Size = new System.Drawing.Size(75, 23);
            this.btnNext2.TabIndex = 10;
            this.btnNext2.Text = "Next";
            this.btnNext2.UseVisualStyleBackColor = true;
            this.btnNext2.Click += new System.EventHandler(this.btnNext2_Click);
            // 
            // txtPhoneNumberIce
            // 
            this.txtPhoneNumberIce.Location = new System.Drawing.Point(166, 193);
            this.txtPhoneNumberIce.Name = "txtPhoneNumberIce";
            this.txtPhoneNumberIce.Size = new System.Drawing.Size(145, 20);
            this.txtPhoneNumberIce.TabIndex = 9;
            // 
            // txtAreaCodeIce
            // 
            this.txtAreaCodeIce.Location = new System.Drawing.Point(96, 193);
            this.txtAreaCodeIce.Name = "txtAreaCodeIce";
            this.txtAreaCodeIce.Size = new System.Drawing.Size(61, 20);
            this.txtAreaCodeIce.TabIndex = 8;
            // 
            // lblPhoneNumberIce
            // 
            this.lblPhoneNumberIce.AutoSize = true;
            this.lblPhoneNumberIce.Location = new System.Drawing.Point(195, 216);
            this.lblPhoneNumberIce.Name = "lblPhoneNumberIce";
            this.lblPhoneNumberIce.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumberIce.TabIndex = 7;
            this.lblPhoneNumberIce.Text = "Phone Number";
            // 
            // lblAreaCodeIce
            // 
            this.lblAreaCodeIce.AutoSize = true;
            this.lblAreaCodeIce.Location = new System.Drawing.Point(100, 216);
            this.lblAreaCodeIce.Name = "lblAreaCodeIce";
            this.lblAreaCodeIce.Size = new System.Drawing.Size(57, 13);
            this.lblAreaCodeIce.TabIndex = 6;
            this.lblAreaCodeIce.Text = "Area Code";
            // 
            // txtLastNameIce
            // 
            this.txtLastNameIce.Location = new System.Drawing.Point(296, 101);
            this.txtLastNameIce.Name = "txtLastNameIce";
            this.txtLastNameIce.Size = new System.Drawing.Size(192, 20);
            this.txtLastNameIce.TabIndex = 5;
            // 
            // txtFirstNameIce
            // 
            this.txtFirstNameIce.Location = new System.Drawing.Point(96, 101);
            this.txtFirstNameIce.Name = "txtFirstNameIce";
            this.txtFirstNameIce.Size = new System.Drawing.Size(194, 20);
            this.txtFirstNameIce.TabIndex = 4;
            // 
            // lblLastNameIce
            // 
            this.lblLastNameIce.AutoSize = true;
            this.lblLastNameIce.Location = new System.Drawing.Point(364, 124);
            this.lblLastNameIce.Name = "lblLastNameIce";
            this.lblLastNameIce.Size = new System.Drawing.Size(58, 13);
            this.lblLastNameIce.TabIndex = 3;
            this.lblLastNameIce.Text = "Last Name";
            // 
            // lblFirstNameIce
            // 
            this.lblFirstNameIce.AutoSize = true;
            this.lblFirstNameIce.Location = new System.Drawing.Point(163, 124);
            this.lblFirstNameIce.Name = "lblFirstNameIce";
            this.lblFirstNameIce.Size = new System.Drawing.Size(57, 13);
            this.lblFirstNameIce.TabIndex = 1;
            this.lblFirstNameIce.Text = "First Name";
            // 
            // lblNewPatient2
            // 
            this.lblNewPatient2.AutoSize = true;
            this.lblNewPatient2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPatient2.Location = new System.Drawing.Point(90, 22);
            this.lblNewPatient2.Name = "lblNewPatient2";
            this.lblNewPatient2.Size = new System.Drawing.Size(398, 32);
            this.lblNewPatient2.TabIndex = 0;
            this.lblNewPatient2.Text = "Emergency Contact Information";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnPrevious2);
            this.tabPage3.Controls.Add(this.btnCancel3);
            this.tabPage3.Controls.Add(this.btnNext3);
            this.tabPage3.Controls.Add(this.txtGroupNumber);
            this.tabPage3.Controls.Add(this.txtAccountNumber);
            this.tabPage3.Controls.Add(this.txtCarrier);
            this.tabPage3.Controls.Add(this.lblAccountNumber);
            this.tabPage3.Controls.Add(this.lblGroupNumber);
            this.tabPage3.Controls.Add(this.lblCarrier);
            this.tabPage3.Controls.Add(this.lblNewPatientInsurance);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";

            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);

            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);

            this.tabPage3.Size = new System.Drawing.Size(572, 460);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnPrevious2
            // 
            this.btnPrevious2.Location = new System.Drawing.Point(293, 363);
            this.btnPrevious2.Name = "btnPrevious2";
            this.btnPrevious2.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious2.TabIndex = 10;
            this.btnPrevious2.Text = "Previous";
            this.btnPrevious2.UseVisualStyleBackColor = true;
            this.btnPrevious2.Click += new System.EventHandler(this.btnPrevious2_Click);
            // 
            // btnCancel3
            // 
            this.btnCancel3.Location = new System.Drawing.Point(151, 363);
            this.btnCancel3.Name = "btnCancel3";
            this.btnCancel3.Size = new System.Drawing.Size(75, 23);
            this.btnCancel3.TabIndex = 9;
            this.btnCancel3.Text = "Cancel";
            this.btnCancel3.UseVisualStyleBackColor = true;
            this.btnCancel3.Click += new System.EventHandler(this.btnCancel3_Click);
            // 
            // btnNext3
            // 
            this.btnNext3.Location = new System.Drawing.Point(434, 363);
            this.btnNext3.Name = "btnNext3";
            this.btnNext3.Size = new System.Drawing.Size(75, 23);
            this.btnNext3.TabIndex = 8;
            this.btnNext3.Text = "Next";
            this.btnNext3.UseVisualStyleBackColor = true;
            this.btnNext3.Click += new System.EventHandler(this.btnNext3_Click);
            // 
            // txtGroupNumber
            // 
            this.txtGroupNumber.Location = new System.Drawing.Point(151, 185);
            this.txtGroupNumber.Name = "txtGroupNumber";
            this.txtGroupNumber.Size = new System.Drawing.Size(358, 20);
            this.txtGroupNumber.TabIndex = 7;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(151, 133);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(358, 20);
            this.txtAccountNumber.TabIndex = 6;
            // 
            // txtCarrier
            // 
            this.txtCarrier.Location = new System.Drawing.Point(151, 84);
            this.txtCarrier.Name = "txtCarrier";
            this.txtCarrier.Size = new System.Drawing.Size(358, 20);
            this.txtCarrier.TabIndex = 5;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(58, 136);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(87, 13);
            this.lblAccountNumber.TabIndex = 4;
            this.lblAccountNumber.Text = "Account Number";
            // 
            // lblGroupNumber
            // 
            this.lblGroupNumber.AutoSize = true;
            this.lblGroupNumber.Location = new System.Drawing.Point(69, 188);
            this.lblGroupNumber.Name = "lblGroupNumber";
            this.lblGroupNumber.Size = new System.Drawing.Size(76, 13);
            this.lblGroupNumber.TabIndex = 3;
            this.lblGroupNumber.Text = "Group Number";
            // 
            // lblCarrier
            // 
            this.lblCarrier.AutoSize = true;
            this.lblCarrier.Location = new System.Drawing.Point(108, 87);
            this.lblCarrier.Name = "lblCarrier";
            this.lblCarrier.Size = new System.Drawing.Size(37, 13);
            this.lblCarrier.TabIndex = 2;
            this.lblCarrier.Text = "Carrier";
            // 
            // lblNewPatientInsurance
            // 
            this.lblNewPatientInsurance.AutoSize = true;
            this.lblNewPatientInsurance.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPatientInsurance.Location = new System.Drawing.Point(146, 32);
            this.lblNewPatientInsurance.Name = "lblNewPatientInsurance";
            this.lblNewPatientInsurance.Size = new System.Drawing.Size(245, 27);
            this.lblNewPatientInsurance.TabIndex = 0;
            this.lblNewPatientInsurance.Text = "Insurance Information";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lblAdmissionReason);
            this.tabPage4.Controls.Add(this.txtAdmissionReason);
            this.tabPage4.Controls.Add(this.btnPrevious3);
            this.tabPage4.Controls.Add(this.btnCancel4);
            this.tabPage4.Controls.Add(this.btnSubmit);
            this.tabPage4.Controls.Add(this.txtBedNumber);
            this.tabPage4.Controls.Add(this.txtRoomNumber);
            this.tabPage4.Controls.Add(this.txtFloorNumber);
            this.tabPage4.Controls.Add(this.txtFacility);
            this.tabPage4.Controls.Add(this.lblBedNumber);
            this.tabPage4.Controls.Add(this.lblRoomNumber);
            this.tabPage4.Controls.Add(this.lblFloor);
            this.tabPage4.Controls.Add(this.lblFacility);
            this.tabPage4.Controls.Add(this.lblAdmissionDate);
            this.tabPage4.Controls.Add(this.dtpAdmissionTime);
            this.tabPage4.Controls.Add(this.lblAdmissionInformation);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";

            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);

            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);

            this.tabPage4.Size = new System.Drawing.Size(572, 460);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblAdmissionReason
            // 
            this.lblAdmissionReason.AutoSize = true;
            this.lblAdmissionReason.Location = new System.Drawing.Point(87, 127);
            this.lblAdmissionReason.Name = "lblAdmissionReason";
            this.lblAdmissionReason.Size = new System.Drawing.Size(109, 13);
            this.lblAdmissionReason.TabIndex = 15;
            this.lblAdmissionReason.Text = "Reason for Admission";
            // 
            // txtAdmissionReason
            // 
            this.txtAdmissionReason.Location = new System.Drawing.Point(213, 124);
            this.txtAdmissionReason.Multiline = true;
            this.txtAdmissionReason.Name = "txtAdmissionReason";
            this.txtAdmissionReason.Size = new System.Drawing.Size(255, 102);
            this.txtAdmissionReason.TabIndex = 14;
            // 
            // btnPrevious3
            // 
            this.btnPrevious3.Location = new System.Drawing.Point(289, 422);
            this.btnPrevious3.Name = "btnPrevious3";
            this.btnPrevious3.Size = new System.Drawing.Size(75, 32);
            this.btnPrevious3.TabIndex = 13;
            this.btnPrevious3.Text = "Previous";
            this.btnPrevious3.UseVisualStyleBackColor = true;
            this.btnPrevious3.Click += new System.EventHandler(this.btnPrevious3_Click);
            // 
            // btnCancel4
            // 
            this.btnCancel4.Location = new System.Drawing.Point(178, 422);
            this.btnCancel4.Name = "btnCancel4";
            this.btnCancel4.Size = new System.Drawing.Size(79, 32);
            this.btnCancel4.TabIndex = 12;
            this.btnCancel4.Text = "Cancel";
            this.btnCancel4.UseVisualStyleBackColor = true;
            this.btnCancel4.Click += new System.EventHandler(this.btnCancel4_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(394, 422);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(74, 32);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtBedNumber
            // 
            this.txtBedNumber.Location = new System.Drawing.Point(213, 384);
            this.txtBedNumber.Name = "txtBedNumber";
            this.txtBedNumber.Size = new System.Drawing.Size(255, 20);
            this.txtBedNumber.TabIndex = 10;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(213, 336);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(255, 20);
            this.txtRoomNumber.TabIndex = 9;
            // 
            // txtFloorNumber
            // 
            this.txtFloorNumber.Location = new System.Drawing.Point(213, 291);
            this.txtFloorNumber.Name = "txtFloorNumber";
            this.txtFloorNumber.Size = new System.Drawing.Size(255, 20);
            this.txtFloorNumber.TabIndex = 8;
            // 
            // txtFacility
            // 
            this.txtFacility.Location = new System.Drawing.Point(213, 249);
            this.txtFacility.Name = "txtFacility";
            this.txtFacility.Size = new System.Drawing.Size(255, 20);
            this.txtFacility.TabIndex = 7;
            // 
            // lblBedNumber
            // 
            this.lblBedNumber.AutoSize = true;
            this.lblBedNumber.Location = new System.Drawing.Point(130, 387);
            this.lblBedNumber.Name = "lblBedNumber";
            this.lblBedNumber.Size = new System.Drawing.Size(66, 13);
            this.lblBedNumber.TabIndex = 6;
            this.lblBedNumber.Text = "Bed Number";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(121, 339);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(75, 13);
            this.lblRoomNumber.TabIndex = 5;
            this.lblRoomNumber.Text = "Room Number";
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Location = new System.Drawing.Point(126, 294);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(70, 13);
            this.lblFloor.TabIndex = 4;
            this.lblFloor.Text = "Floor Number";
            // 
            // lblFacility
            // 
            this.lblFacility.AutoSize = true;
            this.lblFacility.Location = new System.Drawing.Point(157, 252);
            this.lblFacility.Name = "lblFacility";
            this.lblFacility.Size = new System.Drawing.Size(39, 13);
            this.lblFacility.TabIndex = 3;
            this.lblFacility.Text = "Facility";
            // 
            // lblAdmissionDate
            // 
            this.lblAdmissionDate.AutoSize = true;
            this.lblAdmissionDate.Location = new System.Drawing.Point(99, 87);
            this.lblAdmissionDate.Name = "lblAdmissionDate";
            this.lblAdmissionDate.Size = new System.Drawing.Size(97, 13);
            this.lblAdmissionDate.TabIndex = 2;
            this.lblAdmissionDate.Text = "Date of Admisssion";
            // 
            // dtpAdmissionTime
            // 
            this.dtpAdmissionTime.Location = new System.Drawing.Point(213, 81);
            this.dtpAdmissionTime.Name = "dtpAdmissionTime";
            this.dtpAdmissionTime.Size = new System.Drawing.Size(255, 20);
            this.dtpAdmissionTime.TabIndex = 1;
            // 
            // lblAdmissionInformation
            // 
            this.lblAdmissionInformation.AutoSize = true;
            this.lblAdmissionInformation.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmissionInformation.Location = new System.Drawing.Point(164, 25);
            this.lblAdmissionInformation.Name = "lblAdmissionInformation";
            this.lblAdmissionInformation.Size = new System.Drawing.Size(249, 27);
            this.lblAdmissionInformation.TabIndex = 0;
            this.lblAdmissionInformation.Text = "Admission Information";
            // 
            // frmNewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(593, 329);

            this.ClientSize = new System.Drawing.Size(624, 513);

            this.Controls.Add(this.wizardPages1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmNewPatient";
            this.Text = "New Patient";
            this.wizardPages1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private cssa_appraisal_partner_version3.HelperClasses.WizardPages wizardPages1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.Label lblFamilyDoctor;
        private System.Windows.Forms.TextBox txtFamilyDoctor;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.Label lblWorkPhone;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.TextBox txtCellPhone;
        private System.Windows.Forms.TextBox txtWorkPhone;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblNewPatient1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblNewPatient2;
        private System.Windows.Forms.TextBox txtPhoneNumberIce;
        private System.Windows.Forms.TextBox txtAreaCodeIce;
        private System.Windows.Forms.Label lblPhoneNumberIce;
        private System.Windows.Forms.Label lblAreaCodeIce;
        private System.Windows.Forms.TextBox txtLastNameIce;
        private System.Windows.Forms.TextBox txtFirstNameIce;
        private System.Windows.Forms.Label lblLastNameIce;
        private System.Windows.Forms.Label lblFirstNameIce;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblGroupNumber;
        private System.Windows.Forms.Label lblCarrier;
        private System.Windows.Forms.Label lblNewPatientInsurance;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblAdmissionDate;
        private System.Windows.Forms.DateTimePicker dtpAdmissionTime;
        private System.Windows.Forms.Label lblAdmissionInformation;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnNext2;
        private System.Windows.Forms.Button btnCancel3;
        private System.Windows.Forms.Button btnNext3;
        private System.Windows.Forms.TextBox txtGroupNumber;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtCarrier;
        private System.Windows.Forms.Button btnCancel4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtBedNumber;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.TextBox txtFloorNumber;
        private System.Windows.Forms.TextBox txtFacility;
        private System.Windows.Forms.Label lblBedNumber;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.Label lblFacility;
        private System.Windows.Forms.Button btnPrevious1;
        private System.Windows.Forms.Button btnPrevious2;
        private System.Windows.Forms.Button btnPrevious3;
        private System.Windows.Forms.TextBox txtAreaCodeCell;
        private System.Windows.Forms.TextBox txtAreaCodeWork;
        private System.Windows.Forms.TextBox txtAreaCodeHome;
        private System.Windows.Forms.Label lblAdmissionReason;
        private System.Windows.Forms.TextBox txtAdmissionReason;
    }
}