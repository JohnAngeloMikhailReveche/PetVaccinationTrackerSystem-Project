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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetVaccinationTrackerSystem_Project
{
    public partial class registerPetOwnerPanel : UserControl
    {

        private bool IsFieldsEmpty()
        {
            if (string.IsNullOrWhiteSpace(txtboxFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtboxLastName.Text) ||
                string.IsNullOrWhiteSpace(txtboxUsername.Text) ||
                string.IsNullOrWhiteSpace(txtboxPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

        private void ClearFields()
        {
            txtboxFirstName.Clear();
            txtboxLastName.Clear();
            txtboxUsername.Clear();
            txtboxPassword.Clear();
        }

        private void UpdateUsername()
        {
            string firstName = txtboxFirstName.Text.Replace(" ", "").Trim().ToLower();
            string lastName = txtboxLastName.Text.Replace(" ", "").Trim().ToLower();
            string username = firstName + lastName;
            txtboxUsername.Text = username;
        }

        public registerPetOwnerPanel()
        {
            InitializeComponent();

        }

        private void registerPOPanelButton_Click(object sender, EventArgs e)
        {
            if (IsFieldsEmpty()) return;

            IEntityRegistrar userRegistrar = new UserRegistrar(
                txtboxFirstName.Text.Trim(),
                txtboxLastName.Text.Trim(),
                txtboxUsername.Text.Trim(),
                txtboxPassword.Text.Trim(),
                null,
                false
                );
            userRegistrar.Register();

            var userDetails = userRegistrar.GetDetails();

            MessageBox.Show($"Pet Owner {userDetails["FirstName"]} {userDetails["LastName"]} is registered successfully! \n\n Details: \n Account User ID: {userRegistrar.GetID()} \n\n Account Email: {userDetails["Username"]}@petownerclinic.com \n\n Account Password: {userDetails["Password"]}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();

        }

        private void txtboxFirstName_TextChanged(object sender, EventArgs e)
        {
            UpdateUsername();
        }

        private void txtboxLastName_TextChanged(object sender, EventArgs e)
        {
            UpdateUsername();
        }
    }
}
