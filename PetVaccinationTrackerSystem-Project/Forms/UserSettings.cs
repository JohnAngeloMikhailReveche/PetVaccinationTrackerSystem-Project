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
            // Send a notification to the vetclinic requesting account deletion

            if (_userRef.SentAccountDeletion == false)
            {
                var diagResult = MessageBox.Show("Are you sure that you want to request for account deletion? If your account gets deleted you wont be able to return it. \n\nYou can still cancel the request within 24 hours.", "Request Account Deletion Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if (diagResult == DialogResult.OK)
                {
                    using (var context = new ModelContext())
                    {
                        _userRef.SentAccountDeletion = true;
                        context.UserList.Update(_userRef);
                        context.SaveChanges();
                    }

                    btnRequestAccDelete.Text = "Cancel Request";
                }
            }
            else
            {
                using (var context = new ModelContext())
                {
                    _userRef.SentAccountDeletion = false;
                    context.UserList.Update(_userRef);
                    context.SaveChanges();
                }

                MessageBox.Show("You cancelled the deletion for your account.", "Cancelled Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRequestAccDelete.Text = "Request Deletion";
            }



        }
        private void UserSettings_Load(object sender, EventArgs e)
        {
            if (_userRef.SentAccountDeletion == false)
            {
                btnRequestAccDelete.Text = "Request Deletion";
            }
            else
            {
                btnRequestAccDelete.Text = "Cancel Request";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new ModelContext())
            {
                _userRef.FirstName = txtFirstName.Text.Trim();
                _userRef.LastName = txtLastName.Text.Trim();

                context.UserList.Update(_userRef);
                context.SaveChanges();

                MessageBox.Show("Your account has been updated!", "Account Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mainFormVButtonExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form to return to the previous one
        }
    }
}
