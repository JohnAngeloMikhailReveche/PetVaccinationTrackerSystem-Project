using PetVaccinationTrackerSystem_Project.Classes;
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
    public partial class AdminRegisterClinicUsCo : UserControl
    {

        private ModelContext _context;

        private bool VerifyTextFields()
        {
            // Check if any of the text fields are empty
            if (string.IsNullOrWhiteSpace(txtboxClinicName.Text) ||
                string.IsNullOrWhiteSpace(txtboxStreet.Text) ||
                string.IsNullOrWhiteSpace(txtboxCity.Text) ||
                string.IsNullOrWhiteSpace(txtboxState.Text) ||
                string.IsNullOrWhiteSpace(txtboxZipCode.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        public AdminRegisterClinicUsCo()
        {
            InitializeComponent();

            _context = new ModelContext();
        }

        private void btnRegisterClinic_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (!VerifyTextFields()) return;

            // Validate input fields
            Clinic clinic = new Clinic
            {
                ClinicName = txtboxClinicName.Text.Trim(),
                Street = txtboxStreet.Text.Trim(),
                City = txtboxCity.Text.Trim(),
                State = txtboxState.Text.Trim(),
                ZipCode = txtboxZipCode.Text.Trim()
            };

            _context.ClinicList.Add(clinic);
            _context.SaveChanges();

            MessageBox.Show("Clinic registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the input fields after successful registration
            txtboxClinicName.Clear();
            txtboxCity.Clear();
            txtboxState.Clear();
            txtboxStreet.Clear();
            txtboxZipCode.Clear();
        }
    }
}
