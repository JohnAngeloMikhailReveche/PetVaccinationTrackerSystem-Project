using PetVaccinationTrackerSystem_Project.Data;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using PetVaccinationTrackerSystem_Project.Data.ViewModels;
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

    public partial class VetInfo : Form
    {

        private VeterinarianViewModel _currentVet;

        private bool VerifyTextFields()
        {
            // Check if any of the text fields are empty
            if (string.IsNullOrWhiteSpace(txtboxFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtboxLicenseNo.Text) ||
                string.IsNullOrEmpty(txtboxLastName.Text) ||
                string.IsNullOrEmpty(txtboxAccountEmail.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            // Check if the values are still the same
            if (_currentVet.FirstName == txtboxFirstName.Text.Trim() &&
                _currentVet.LicenseNumber == txtboxLicenseNo.Text.Trim() &&
                _currentVet.LastName == txtboxLastName.Text.Trim() &&
                _currentVet.UserEmail == txtboxAccountEmail.Text.Trim() && _currentVet.ClinicID == (int)cmbboxClinic.SelectedValue)
            {
                MessageBox.Show("No changes detected.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return false;
            }

            return true;
        }

        public VetInfo(VeterinarianViewModel inVetObj)
        {
            InitializeComponent();

            _currentVet = inVetObj;
            LoadData();
        }

        private void LoadData()
        {
            txtboxFirstName.Text = _currentVet.FirstName;
            txtboxLastName.Text = _currentVet.LastName;
            txtboxLicenseNo.Text = _currentVet.LicenseNumber;
            txtboxAccountEmail.Text = _currentVet.UserEmail;
            // Clinic ID Combo Box is located at VetInfo_Load event to set the proper data.
        }

        private void VetInfo_Load(object sender, EventArgs e)
        {
            // For Combo Box Clinic
            using (var context = new ModelContext())
            {
                var clinics = context.ClinicList
                                     .Select(c => new { c.ClinicID, c.ClinicName })
                                     .ToList();

                cmbboxClinic.DisplayMember = "ClinicName";
                cmbboxClinic.ValueMember = "ClinicID";
                cmbboxClinic.DataSource = clinics;

                // Set the selected value to the current veterinarian's clinic ID
                cmbboxClinic.SelectedValue = _currentVet.ClinicID;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!VerifyTextFields()) return;

            using (var context = new ModelContext())
            {
                // Find the veterinarian by ID
                var vetToUpdate = context.VeterinarianList.Find(_currentVet.VetID);
                var userToUpdate = context.UserList.Find(_currentVet.UserID);

                if (userToUpdate != null)
                {
                    // Update the user's properties
                    userToUpdate.FirstName = txtboxFirstName.Text.Trim();
                    userToUpdate.LastName = txtboxLastName.Text.Trim();
                    userToUpdate.UserEmail = txtboxAccountEmail.Text.Trim();

                    // Update changes to context
                    context.UserList.Update(userToUpdate);

                    // Save changes to the database
                    context.SaveChanges();

                    if (vetToUpdate != null)
                    {
                        // Update the veterinarian's properties
                        vetToUpdate.LicenseNumber = txtboxLicenseNo.Text;
                        vetToUpdate.ClinicID = (int)cmbboxClinic.SelectedValue;

                        // Update changes to context
                        context.VeterinarianList.Update(vetToUpdate);

                        // Save changes to the database
                        context.SaveChanges();

                        MessageBox.Show("Veterinarian information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Veterinarian not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete the Veterinarian from the Database
            DialogResult result = MessageBox.Show("Are you sure you want to delete this veterinarian data?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (var context = new ModelContext())
                {
                    // Find the veterinarian by ID
                    var vetToDelete = context.VeterinarianList.Find(_currentVet.VetID);
                    var userToDelete = context.UserList.Find(_currentVet.UserID);

                    // If Vet is Found
                    if (vetToDelete != null && userToDelete != null)
                    {
                        // Remove the veterinarian from the context
                        context.VeterinarianList.Remove(vetToDelete);

                        // Save changes to the database
                        context.SaveChanges();

                        // Remove the user from the context
                        context.UserList.Remove(userToDelete);

                        // Save changes to the database
                        context.SaveChanges();

                        MessageBox.Show("Veterinarian Data deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Veterinarian Data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void mainFormVButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
