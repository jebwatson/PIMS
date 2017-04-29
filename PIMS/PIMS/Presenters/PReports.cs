using DBI;
using DBI.Utilities;
using PIMS.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS.Presenters
{
    class PReports
    {
        // Locals
        Views.Reports View;
       
        public PReports(Views.Reports view)
        {
            View = view;
        }

        /// <summary>
        /// Populate the patients table for the first time after it is created.
        /// If there are no patients in the database, add a default case.
        /// </summary>
        public void PopulatePatientsList()
        {
            PatientTable MyPatientsTable = new PatientTable();

            View.ReportsList.SetObjects(MyPatientsTable.ReadList());
        }

        /// <summary>
        /// Read the database by the user specified string and populate the table with 
        /// the new list of patients.
        /// </summary>
        public void SearchPatients()
        {
            PatientTable MyPatientsTable = new PatientTable();
            List<Patient> MyPatientsList = MyPatientsTable.ReadListByName(View.PatientSearch);
            int i = 0;

            foreach (Patient p in MyPatientsList)
            {
                if (i == 0)
                    View.ReportsList.SetObjects(MyPatientsTable.ReadListById(MyPatientsList[i].patientId));
                else
                    View.ReportsList.UpdateObjects(MyPatientsTable.ReadListById(MyPatientsList[i].patientId));

                i++;
            }
        }

        public void GenerateChargesReport()
        {
            PatientTable MyPatientTable = new PatientTable();
            ChargesTable MyChargesTable = new ChargesTable();
            List<Patient> MyPatientsList = new List<Patient>();
            List<DBI.Charges> MyChargesList = MyChargesTable.ReadList();
            List<DBI.Charges> NewChargesList = new List<DBI.Charges>();

            foreach(var o in View.ReportsList.SelectedObjects)
            {
                MyPatientsList.Add((Patient)o);
            }

            foreach(Patient p in MyPatientsList)
            {
                foreach(DBI.Charges c in MyChargesList)
                {
                    if (p.patientId == c.patientId)
                        NewChargesList.Add(c);
                }
            }

            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            object missVal = System.Reflection.Missing.Value;

            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Charges Report";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                for (int i = 0; i < NewChargesList.Count; i++)
                {
                    if (cellRowIndex == 1)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = "Patient ID";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 1] = "Name";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 2] = "Description";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 3] = "Amount Total";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 4] = "Date Charged";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 5] = "Date Due";
                        worksheet.Cells[cellRowIndex, cellColumnIndex].EntireRow.Font.Bold = true;

                        cellColumnIndex = 1;
                        cellRowIndex++;
                    }

                    worksheet.Cells[cellRowIndex, cellColumnIndex] = MyChargesList[i].patientId;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 1] = NewChargesList[i].name;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 2] = NewChargesList[i].description;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 3] = NewChargesList[i].amountTotal;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 4] = NewChargesList[i].dateCharged;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 5] = NewChargesList[i].dateDue;
                    
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                worksheet.Columns.AutoFit();

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 1;
                saveDialog.FileName = null;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook.Close(SaveChanges: false);
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        public void GenerateBillsReport()
        {
            PatientTable MyPatientTable = new PatientTable();
            BillsTable MyBillsTable = new BillsTable();
            List<Patient> MyPatientsList = new List<Patient>();
            List<DBI.Bills> MyBillsList = MyBillsTable.ReadList();
            List<DBI.Bills> NewBillsList = new List<DBI.Bills>();

            foreach (var o in View.ReportsList.SelectedObjects)
            {
                MyPatientsList.Add((Patient)o);
            }

            foreach (Patient p in MyPatientsList)
            {
                foreach (DBI.Bills c in MyBillsList)
                {
                    if (p.patientId == c.patientId)
                        NewBillsList.Add(c);
                }
            }

            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            object missVal = System.Reflection.Missing.Value;

            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Bills Report";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                for (int i = 0; i < NewBillsList.Count; i++)
                {
                    if (cellRowIndex == 1)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = "Patient ID";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 1] = "Name";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 2] = "Amount Total";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 3] = "Amount Paid by Patient";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 4] = "Amount Paid By Insurance";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 5] = "Amount Owed";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 6] = "Date Charged";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 7] = "Date Due";
                        worksheet.Cells[cellRowIndex, cellColumnIndex].EntireRow.Font.Bold = true;

                        cellColumnIndex = 1;
                        cellRowIndex++;
                    }

                    worksheet.Cells[cellRowIndex, cellColumnIndex] = MyBillsList[i].patientId;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 1] = NewBillsList[i].name;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 2] = NewBillsList[i].amountTotal;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 3] = NewBillsList[i].amountPaidByPatient;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 4] = NewBillsList[i].amountPaidByInsurance;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 5] = NewBillsList[i].amountOwed;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 6] = NewBillsList[i].dateCharged;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 7] = NewBillsList[i].dateDue;

                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                worksheet.Columns.AutoFit();

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 1;
                saveDialog.FileName = null;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook.Close(SaveChanges: false);
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        public void GenerateEmergencyContactsReport()
        {
            PatientTable MyPatientTable = new PatientTable();
            EmergencyContactTable MyEmergencyContactsTable = new EmergencyContactTable();
            List<Patient> MyPatientsList = new List<Patient>();
            List<DBI.EmergencyContact> MyEmergencyContactsList = MyEmergencyContactsTable.ReadList();
            List<DBI.EmergencyContact> NewEmergencyContactsList = new List<DBI.EmergencyContact>();

            foreach (var o in View.ReportsList.SelectedObjects)
            {
                MyPatientsList.Add((Patient)o);
            }

            foreach (Patient p in MyPatientsList)
            {
                foreach (DBI.EmergencyContact c in MyEmergencyContactsList)
                {
                    if (p.patientId == c.patientId)
                        NewEmergencyContactsList.Add(c);
                }
            }

            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            object missVal = System.Reflection.Missing.Value;

            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "EmergencyContacts Report";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                for (int i = 0; i < NewEmergencyContactsList.Count; i++)
                {
                    if (cellRowIndex == 1)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = "Patient ID";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 1] = "Name";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 2] = "Phone";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 3] = "Area Code";
                        worksheet.Cells[cellRowIndex, cellColumnIndex].EntireRow.Font.Bold = true;

                        cellColumnIndex = 1;
                        cellRowIndex++;
                    }

                    worksheet.Cells[cellRowIndex, cellColumnIndex] = MyEmergencyContactsList[i].patientId;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 1] = NewEmergencyContactsList[i].name;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 2] = NewEmergencyContactsList[i].phone;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 3] = NewEmergencyContactsList[i].areaCode;

                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                worksheet.Columns.AutoFit();

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 1;
                saveDialog.FileName = null;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook.Close(SaveChanges: false);
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        public void GenerateInsuranceReport()
        {
            PatientTable MyPatientTable = new PatientTable();
            InsuranceTable MyInsuranceTable = new InsuranceTable();
            List<Patient> MyPatientsList = new List<Patient>();
            List<DBI.Insurance> MyInsuranceList = MyInsuranceTable.ReadList();
            List<DBI.Insurance> NewInsuranceList = new List<DBI.Insurance>();

            foreach (var o in View.ReportsList.SelectedObjects)
            {
                MyPatientsList.Add((Patient)o);
            }

            foreach (Patient p in MyPatientsList)
            {
                foreach (DBI.Insurance c in MyInsuranceList)
                {
                    if (p.patientId == c.patientId)
                        NewInsuranceList.Add(c);
                }
            }

            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            object missVal = System.Reflection.Missing.Value;

            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Insurance Report";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                for (int i = 0; i < NewInsuranceList.Count; i++)
                {
                    if (cellRowIndex == 1)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = "Patient ID";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 1] = "Name";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 2] = "Phone";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 3] = "Area Code";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 4] = "Group Number";
                        worksheet.Cells[cellRowIndex, cellColumnIndex].EntireRow.Font.Bold = true;

                        cellColumnIndex = 1;
                        cellRowIndex++;
                    }

                    worksheet.Cells[cellRowIndex, cellColumnIndex] = MyInsuranceList[i].patientId;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 1] = NewInsuranceList[i].name;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 2] = NewInsuranceList[i].insuranceCarrier;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 3] = NewInsuranceList[i].accountNumber;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 4] = NewInsuranceList[i].groupNumber;

                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                worksheet.Columns.AutoFit();

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 1;
                saveDialog.FileName = null;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook.Close(SaveChanges: false);
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        public void GenerateNotesReport()
        {
            PatientTable MyPatientTable = new PatientTable();
            NotesTable MyNotesTable = new NotesTable();
            List<Patient> MyPatientsList = new List<Patient>();
            List<DBI.Notes> MyNotesList = MyNotesTable.ReadList();
            List<DBI.Notes> NewNotesList = new List<DBI.Notes>();

            foreach (var o in View.ReportsList.SelectedObjects)
            {
                MyPatientsList.Add((Patient)o);
            }

            foreach (Patient p in MyPatientsList)
            {
                foreach (DBI.Notes c in MyNotesList)
                {
                    if (p.patientId == c.patientId)
                        NewNotesList.Add(c);
                }
            }

            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            object missVal = System.Reflection.Missing.Value;

            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Notes Report";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                for (int i = 0; i < NewNotesList.Count; i++)
                {
                    if (cellRowIndex == 1)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = "Patient ID";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 1] = "Name";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 2] = "Notes";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 3] = "Supervising Doctor";
                        worksheet.Cells[cellRowIndex, cellColumnIndex].EntireRow.Font.Bold = true;

                        cellColumnIndex = 1;
                        cellRowIndex++;
                    }

                    worksheet.Cells[cellRowIndex, cellColumnIndex] = MyNotesList[i].patientId;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 1] = NewNotesList[i].name;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 2] = NewNotesList[i].notes;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 3] = NewNotesList[i].userId;

                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                worksheet.Columns.AutoFit();

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 1;
                saveDialog.FileName = null;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook.Close(SaveChanges: false);
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        public void GeneratePrescriptionsReport()
        {
            PatientTable MyPatientTable = new PatientTable();
            PrescriptionsTable MyPrescriptionsTable = new PrescriptionsTable();
            List<Patient> MyPatientsList = new List<Patient>();
            List<DBI.Prescriptions> MyPrescriptionsList = MyPrescriptionsTable.ReadList();
            List<DBI.Prescriptions> NewPrescriptionsList = new List<DBI.Prescriptions>();

            foreach (var o in View.ReportsList.SelectedObjects)
            {
                MyPatientsList.Add((Patient)o);
            }

            foreach (Patient p in MyPatientsList)
            {
                foreach (DBI.Prescriptions c in MyPrescriptionsList)
                {
                    if (p.patientId == c.patientId)
                        NewPrescriptionsList.Add(c);
                }
            }

            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            object missVal = System.Reflection.Missing.Value;

            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Prescriptions Report";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                for (int i = 0; i < NewPrescriptionsList.Count; i++)
                {
                    if (cellRowIndex == 1)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = "Patient ID";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 1] = "Name";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 2] = "Prescription";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 3] = "Amount";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 4] = "Date Prescribed";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 5] = "Duration";
                        worksheet.Cells[cellRowIndex, cellColumnIndex].EntireRow.Font.Bold = true;

                        cellColumnIndex = 1;
                        cellRowIndex++;
                    }

                    worksheet.Cells[cellRowIndex, cellColumnIndex] = MyPrescriptionsList[i].patientId;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 1] = NewPrescriptionsList[i].name;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 2] = NewPrescriptionsList[i].prescName;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 3] = NewPrescriptionsList[i].amount;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 4] = NewPrescriptionsList[i].prescDate;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 5] = NewPrescriptionsList[i].duration;

                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                worksheet.Columns.AutoFit();

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 1;
                saveDialog.FileName = null;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook.Close(SaveChanges: false);
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        public void GenerateProceduresReport()
        {
            PatientTable MyPatientTable = new PatientTable();
            ProceduresTable MyProceduresTable = new ProceduresTable();
            List<Patient> MyPatientsList = new List<Patient>();
            List<DBI.Procedures> MyProceduresList = MyProceduresTable.ReadList();
            List<DBI.Procedures> NewProceduresList = new List<DBI.Procedures>();

            foreach (var o in View.ReportsList.SelectedObjects)
            {
                MyPatientsList.Add((Patient)o);
            }

            foreach (Patient p in MyPatientsList)
            {
                foreach (DBI.Procedures c in MyProceduresList)
                {
                    if (p.patientId == c.patientId)
                        NewProceduresList.Add(c);
                }
            }

            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            object missVal = System.Reflection.Missing.Value;

            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Procedures Report";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                for (int i = 0; i < NewProceduresList.Count; i++)
                {
                    if (cellRowIndex == 1)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = "Patient ID";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 1] = "Name";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 2] = "Start Time";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 3] = "Stop Time";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 4] = "Procedure Type";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 5] = "Duration Hours";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 6] = "Duration Minutes";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 7] = "Notes";
                        worksheet.Cells[cellRowIndex, cellColumnIndex].EntireRow.Font.Bold = true;

                        cellColumnIndex = 1;
                        cellRowIndex++;
                    }

                    worksheet.Cells[cellRowIndex, cellColumnIndex] = MyProceduresList[i].patientId;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 1] = NewProceduresList[i].name;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 2] = NewProceduresList[i].startTime;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 3] = NewProceduresList[i].stopTime;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 4] = NewProceduresList[i].procType;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 5] = NewProceduresList[i].durationHrs;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 6] = NewProceduresList[i].durationMins;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 7] = NewProceduresList[i].procNotes;

                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                worksheet.Columns.AutoFit();

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 1;
                saveDialog.FileName = null;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook.Close(SaveChanges: false);
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        public void GenerateAdmissionsReport()
        {
            PatientTable MyPatientTable = new PatientTable();
            AdmissionsTable MyAdmissionsTable = new AdmissionsTable();
            List<Patient> MyPatientsList = new List<Patient>();
            List<DBI.Admission> MyAdmissionsList = MyAdmissionsTable.ReadList();
            List<DBI.Admission> NewAdmissionsList = new List<DBI.Admission>();

            foreach (var o in View.ReportsList.SelectedObjects)
            {
                MyPatientsList.Add((Patient)o);
            }

            foreach (Patient p in MyPatientsList)
            {
                foreach (DBI.Admission c in MyAdmissionsList)
                {
                    if (p.patientId == c.patientId)
                        NewAdmissionsList.Add(c);
                }
            }

            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            object missVal = System.Reflection.Missing.Value;

            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Admissions Report";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                for (int i = 0; i < NewAdmissionsList.Count; i++)
                {
                    if (cellRowIndex == 1)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = "Patient ID";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 1] = "Name";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 2] = "Admission Time";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 3] = "Discharge Time";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 4] = "Admission Reason";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 5] = "Facility";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 6] = "Floor";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 7] = "Room";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 8] = "Bed";
                        worksheet.Cells[cellRowIndex, cellColumnIndex].EntireRow.Font.Bold = true;

                        cellColumnIndex = 1;
                        cellRowIndex++;
                    }

                    worksheet.Cells[cellRowIndex, cellColumnIndex] = MyAdmissionsList[i].patientId;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 1] = NewAdmissionsList[i].name;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 2] = NewAdmissionsList[i].admissionTime;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 3] = NewAdmissionsList[i].dischargeTime;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 4] = NewAdmissionsList[i].admissionReason;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 5] = NewAdmissionsList[i].facility;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 6] = NewAdmissionsList[i].floor;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 7] = NewAdmissionsList[i].roomNumber;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 8] = NewAdmissionsList[i].bedNumber;

                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                worksheet.Columns.AutoFit();

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 1;
                saveDialog.FileName = null;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook.Close(SaveChanges: false);
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        public void GenerateVisitorsReport()
        {
            PatientTable MyPatientTable = new PatientTable();
            VisitorsTable MyVisitorsTable = new VisitorsTable();
            List<Patient> MyPatientsList = new List<Patient>();
            List<DBI.Visitors> MyVisitorsList = MyVisitorsTable.ReadList();
            List<DBI.Visitors> NewVisitorsList = new List<DBI.Visitors>();

            foreach (var o in View.ReportsList.SelectedObjects)
            {
                MyPatientsList.Add((Patient)o);
            }

            foreach (Patient p in MyPatientsList)
            {
                foreach (DBI.Visitors c in MyVisitorsList)
                {
                    if (p.patientId == c.patientId)
                        NewVisitorsList.Add(c);
                }
            }

            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            object missVal = System.Reflection.Missing.Value;

            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Visitors Report";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                for (int i = 0; i < NewVisitorsList.Count; i++)
                {
                    if (cellRowIndex == 1)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = "Patient ID";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 1] = "Name";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 2] = "Relation";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 3] = "Last Visit";
                        worksheet.Cells[cellRowIndex, cellColumnIndex].EntireRow.Font.Bold = true;

                        cellColumnIndex = 1;
                        cellRowIndex++;
                    }

                    worksheet.Cells[cellRowIndex, cellColumnIndex] = MyVisitorsList[i].patientId;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 1] = NewVisitorsList[i].patientName;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 2] = NewVisitorsList[i].relation;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 3] = NewVisitorsList[i].lastVisit;

                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                worksheet.Columns.AutoFit();

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 1;
                saveDialog.FileName = null;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook.Close(SaveChanges: false);
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        public void GeneratePatientReport()
        {
            PatientTable MyPatientsTable = new PatientTable();
            List<Patient> MyPatientsList = new List<Patient>();

            foreach (var o in View.ReportsList.SelectedObjects)
            {
                MyPatientsList.Add((Patient)o);
            }

            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            object missVal = System.Reflection.Missing.Value;

            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Patient Report";


                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                for (int i = 0; i < MyPatientsList.Count; i++)
                {
                    if (cellRowIndex == 1)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = "Patient ID";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 1] = "Last Name";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 2] = "First Name";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 3] = "Middle Name";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 4] = "Street";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 5] = "City";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 6] = "State";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 7] = "Zip";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 8] = "Home Phone";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 9] = "Home Area Code";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 10] = "Work Phone";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 11] = "Work Area Code";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 12] = "Cell Phone";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 13] = "Cell Area Code";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 14] = "Family Doctor";
                        worksheet.Cells[cellRowIndex, cellColumnIndex].EntireRow.Font.Bold = true;

                        cellColumnIndex = 1;
                        cellRowIndex++;
                    }

                    worksheet.Cells[cellRowIndex, cellColumnIndex] = MyPatientsList[i].patientId;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 1] = MyPatientsList[i].nameLast;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 2] = MyPatientsList[i].nameFirst;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 3] = MyPatientsList[i].nameMiddle;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 4] = MyPatientsList[i].street;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 5] = MyPatientsList[i].city;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 6] = MyPatientsList[i].state;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 7] = MyPatientsList[i].zip;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 8] = MyPatientsList[i].phoneHome;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 9] = MyPatientsList[i].areaCodeHome;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 10] = MyPatientsList[i].phoneWork;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 11] = MyPatientsList[i].areaCodeWork;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 12] = MyPatientsList[i].phoneMobile;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 13] = MyPatientsList[i].areaCodeMobile;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 14] = MyPatientsList[i].familyDoctor;

                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                worksheet.Columns.AutoFit();

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 1;
                saveDialog.FileName = null;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook.Close(SaveChanges: false);
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }
    }
}