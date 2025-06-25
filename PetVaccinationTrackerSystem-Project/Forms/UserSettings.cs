using PetVaccinationTrackerSystem_Project.Classes;
using PetVaccinationTrackerSystem_Project.Data;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using PetVaccinationTrackerSystem_Project.Forms.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetVaccinationTrackerSystem_Project.Forms
{
    public partial class UserSettings : Form
    {

        private User _userRef;

        private void LoadData()
        {
            // Load user data into the form controls
            if (_userRef != null)
            {
                txtFirstName.Text = _userRef.FirstName;
                txtLastName.Text = _userRef.LastName;
            }
            else
            {
                MessageBox.Show("User reference is null. Cannot load data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ClearPasswordFields()
        {
            // Clear the password fields
            txtCurrPassword.Clear();
            txtNewPassword.Clear();
        }

        private void ChangePassword()
        {
            if (_userRef != null)
            {

                // Confirm Current Password
                if (string.IsNullOrWhiteSpace(txtCurrPassword.Text))
                {
                    MessageBox.Show("Please enter your current password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    PasswordHelper passwordHelper = new PasswordHelper();

                    if (passwordHelper.VerifyPassword(_userRef.UserPassword, txtCurrPassword.Text))
                    {
                        // If the current password is correct, proceed to change the password
                        if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
                        {
                            MessageBox.Show("Please enter a new password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // If the new password is the same as the current password, show an error message
                        if (txtCurrPassword.Text == txtNewPassword.Text)
                        {
                            MessageBox.Show("The new password cannot be the same as the current password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Change password
                        _userRef.UserPassword = passwordHelper.HashPassword(txtNewPassword.Text);

                        // Update the Database
                        using (var context = new ModelContext())
                        {
                            context.UserList.Update(_userRef);
                            context.SaveChanges();
                        }

                        // Prompt success message
                        MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearPasswordFields();

                        return;

                    }
                    else
                    {
                        // If the current password is incorrect, show an error message
                        MessageBox.Show("The current password is incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }




        }

        public UserSettings(User inUserRef)
        {
            InitializeComponent();

            _userRef = inUserRef;
            LoadData();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }

        private void btnRequestAccDelete_Click(object sender, EventArgs e)
        {
            // Send an email to the vetclinic requesting account deletion

            // Testing
            if (_userRef.VetID != null)
            {
                MessageBox.Show($"{_userRef.VetID} referred");
            }
            else
            {
                MessageBox.Show("You are a Pet Owner");
            }

        }
        private void UserSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
