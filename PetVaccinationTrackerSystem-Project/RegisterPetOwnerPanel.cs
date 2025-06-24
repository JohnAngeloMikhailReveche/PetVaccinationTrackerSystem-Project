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

            using (var context = new ModelContext())
            {

                var passwordHelper = new PasswordHelper();
                string hashedPassword = passwordHelper.HashPassword(txtboxPassword.Text);

                var user = new User
                {
                    FirstName = txtboxFirstName.Text,
                    LastName = txtboxLastName.Text,
                    UserEmail = $"{txtboxUsername.Text.Trim().ToLower()}@petownerclinic.com",
                    UserPassword = hashedPassword,
                    UserRole = "PetOwner"
                };
                context.UserList.Add(user);
                context.SaveChanges();

                MessageBox.Show($"Pet Owner {user.FirstName} {user.LastName} is registered successfully! \n\n Details: \n Account User ID: {user.UserID} \n\n Account Email: {user.UserEmail} \n\n Account Password: {txtboxPassword.Text}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();

            }
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
