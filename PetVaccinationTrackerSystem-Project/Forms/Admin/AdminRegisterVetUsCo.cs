using PetVaccinationTrackerSystem_Project.Classes;
using PetVaccinationTrackerSystem_Project.Data;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetVaccinationTrackerSystem_Project.Forms.Admin
{
    public partial class AdminRegisterVetUsCo : UserControl
    {

        private ModelContext _context;


        public void RefreshData()
        {
            using (var context = new ModelContext())
            {
                var clinics = context.ClinicList
                                     .Select(c => new { c.ClinicID, c.ClinicName })
                                     .ToList();

                cmbboxClinic.DisplayMember = "ClinicName";
                cmbboxClinic.ValueMember = "ClinicID";
                cmbboxClinic.DataSource = clinics;
            }
        }

        private bool VerifyTextFields()
        {
            // Check if any of the text fields are empty
            if (string.IsNullOrWhiteSpace(txtboxName.Text) ||
                string.IsNullOrWhiteSpace(txtboxLastName.Text) ||
                string.IsNullOrWhiteSpace(txtboxLicenseNo.Text) ||
                string.IsNullOrWhiteSpace(txtboxAccountUsername.Text) ||
                string.IsNullOrWhiteSpace(txtboxAccountPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public AdminRegisterVetUsCo()
        {
            InitializeComponent();

            _context = new ModelContext();
        }

        private void AdminRegisterVetUsCo_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnRegisterVet_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (!VerifyTextFields()) return;

            // If Combo Box is none selected, show error message
            if (cmbboxClinic.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a clinic.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Fetch the selected clinic ID
            int selectedClinic = Convert.ToInt32(cmbboxClinic.SelectedValue.ToString());

            // Password Helper
            PasswordHelper passwordHelper = new PasswordHelper();
            string hashedPassword = passwordHelper.HashPassword(txtboxAccountPassword.Text.Trim());


            // Create a new Veterinarian object and populate it with data from the form
            Veterinarian veterinarian = new Veterinarian
            {
                LicenseNumber = txtboxLicenseNo.Text.Trim(),
                ClinicID = selectedClinic
            };

            _context.VeterinarianList.Add(veterinarian);
            _context.SaveChanges();

            // Create a new User object for the veterinarian's account
            User user = new User
            {
                FirstName = txtboxName.Text.Trim(),
                LastName = txtboxLastName.Text.Trim(),
                UserEmail = $"{txtboxAccountUsername.Text.Trim().ToLower()}@vetclinic.com",
                UserPassword = hashedPassword,
                UserRole = "Veterinarian",
                SentPasswordRequest = false,
                SentAccountDeletion = false,

                VetID = veterinarian.VetID // Associate the user with the veterinarian
            };

            _context.UserList.Add(user);
            _context.SaveChanges();

            MessageBox.Show($"Veterinarian {txtboxName.Text.Trim()} registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the input fields after successful registration
            txtboxName.Clear();
            txtboxLicenseNo.Clear();
            txtboxLastName.Clear();
            txtboxAccountUsername.Clear();
            txtboxAccountPassword.Clear();
            cmbboxClinic.SelectedIndex = -1;
        }
    }
}
