using PetVaccinationTrackerSystem_Project.Data;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetVaccinationTrackerSystem_Project
{
    public partial class VaccineRecordsPanelVet : UserControl
    {
        public VaccineRecordsPanelVet()
        {
            InitializeComponent();
        }

        private void VRDSButtonClear_Click(object sender, EventArgs e)
        {
            // Reset all textboxes
            cmbVaccineName.SelectedIndex = -1; // Clears selection in ComboBox
            txtBatchNo.Text = string.Empty;
            txtAdministeredBy.Text = string.Empty;
            txtNotes.Text = string.Empty;


            // Reset date pickers to today's date
            dtpDateGiven.Value = DateTime.Now;
            dtpNextDue.Value = DateTime.Now;

            MessageBox.Show("All fields have been cleared.", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void VRDSButtonAddRecord_Click(object sender, EventArgs e)
        {
            // Validate inputs before saving
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(cmbVaccineName.Text))
                errorMessage += "Vaccine Name is required.\n";

            DateTime today = DateTime.Today;

            if (dtpDateGiven.Value.Date < today)
                errorMessage += "Date Administered cannot be earlier than today.\n";

            if (dtpNextDue.Value.Date < today)
                errorMessage += "Next Due Date cannot be earlier than today.\n";

            if (string.IsNullOrWhiteSpace(txtBatchNo.Text))
                errorMessage += "Batch Number is required.\n";

            if (string.IsNullOrWhiteSpace(txtAdministeredBy.Text))
                errorMessage += "Administered By is required.\n";
            // Stop execution if there are missing fields
            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new ModelContext())
            {
                var vaccination = new Vaccination
                {
                    
                    VaccineName = cmbVaccineName.Text,
                    DateAdministered = dtpDateGiven.Value,
                    NextDueDate = dtpNextDue.Value,
                    Notes = txtNotes.Text,
                    BatchNo = txtBatchNo.Text,
                    AdministeredBy = txtAdministeredBy.Text
                }; 

                context.VaccinationList.Add(vaccination);
                context.SaveChanges();

                MessageBox.Show("Vaccination record saved successfully!");


            }
        }
    }
}
