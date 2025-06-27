using PetVaccinationTrackerSystem_Project.Classes;
using PetVaccinationTrackerSystem_Project.Classes.Interfaces;
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
        private IUserService _user;
        private IVetService _vet;

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

            // Register Vet
            IEntityRegistrar vetRegistrar = new VetRegistrar(txtboxLicenseNo.Text.Trim(), selectedClinic);
            vetRegistrar.Register();

            // Register User
            IEntityRegistrar userRegistrar = new UserRegistrar(
                txtboxName.Text.Trim(),
                txtboxLastName.Text.Trim(),
                txtboxAccountUsername.Text.Trim(),
                txtboxAccountPassword.Text.Trim(),
                vetRegistrar.GetID(),
                true
                );

            userRegistrar.Register();

            // Message
            MessageBox.Show($"Veterinarian {txtboxName.Text.Trim()} registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear Fields
            var fieldHelper = new TextFieldHelper();
            fieldHelper.ClearFields(new List<TextBox>
            {
                txtboxName,
                txtboxLicenseNo,
                txtboxLastName,
                txtboxAccountUsername,
                txtboxAccountPassword
            });

            cmbboxClinic.SelectedIndex = 0;
        }
    }
}
