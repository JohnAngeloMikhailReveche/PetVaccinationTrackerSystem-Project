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

namespace PetVaccinationTrackerSystem_Project.Forms.Admin
{
    public partial class ClinicInfo : Form
    {

        private Clinic _currentClinic;

        private bool VerifyTextFields()
        {
            // Check if any of the text fields are empty
            if (string.IsNullOrWhiteSpace(txtboxClinicName.Text) ||
                string.IsNullOrWhiteSpace(txtboxStreet.Text) ||
                string.IsNullOrEmpty(txtboxCity.Text) ||
                string.IsNullOrEmpty(txtboxState.Text) ||
                string.IsNullOrEmpty(txtboxZipCode.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Check if the values are still the same
            if (_currentClinic.ClinicName == txtboxClinicName.Text.Trim() &&
                _currentClinic.Street == txtboxStreet.Text.Trim() &&
                _currentClinic.City == txtboxCity.Text.Trim() &&
                _currentClinic.State == txtboxState.Text.Trim() &&
                _currentClinic.ZipCode == txtboxZipCode.Text.Trim())
            {
                MessageBox.Show("No changes detected.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void LoadData()
        {
            txtboxClinicName.Text = _currentClinic.ClinicName;
            txtboxStreet.Text = _currentClinic.Street;
            txtboxCity.Text = _currentClinic.City;
            txtboxState.Text = _currentClinic.State;
            txtboxZipCode.Text = _currentClinic.ZipCode;
        }

        public ClinicInfo(Clinic inClinicRef)
        {
            InitializeComponent();
            _currentClinic = inClinicRef;
            LoadData();
        }

        private void ClinicInfo_Load(object sender, EventArgs e)
        {

        }

        private void txtboxAccountEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!VerifyTextFields()) return;

            using (var context = new ModelContext())
            {
                // Find the clinic to update
                var clinicToUpdate = context.ClinicList.Find(_currentClinic.ClinicID);

                // If the clinicToUpdate is not invalid then update its properties
                if (clinicToUpdate != null)
                {
                    // Update the Clinic Properties
                    clinicToUpdate.ClinicName = txtboxClinicName.Text.Trim();
                    clinicToUpdate.Street = txtboxStreet.Text.Trim();
                    clinicToUpdate.City = txtboxCity.Text.Trim();
                    clinicToUpdate.State = txtboxState.Text.Trim();
                    clinicToUpdate.ZipCode = txtboxZipCode.Text.Trim();

                    context.ClinicList.Update(clinicToUpdate);
                    context.SaveChanges();

                    MessageBox.Show("Clinic information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Clinic not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this clinic data?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (var context = new ModelContext())
                {
                    // Get the Clinic ID from the reference
                    var clinicToDelete = context.ClinicList.Find(_currentClinic.ClinicID);

                    // If Clinic Data is found in Database
                    if (clinicToDelete != null)
                    {
                        context.ClinicList.Remove(clinicToDelete);
                        context.SaveChanges();

                        MessageBox.Show("Clinic Data deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Clinic Data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }










    }
}
