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

        public UserSettings(User inUserRef)
        {
            InitializeComponent();

            _userRef = inUserRef;
            LoadData();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            // Cache the Password Texts
            string currentPass = txtCurrPassword.Text.Trim();
            string newPass = txtNewPassword.Text.Trim();

            // Change the Password through User Settings Service
            var userSetService = new UserSettingService();
            bool passwordChanged = userSetService.ChangePassword(_userRef, currentPass, newPass, out string error);

            // Check if the Password is Changed
            if (!passwordChanged)
            {
                MessageBox.Show(error, "Password Change Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Message
            MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear Fields
            var fieldHelper = new TextFieldHelper();
            fieldHelper.ClearFields(new List<TextBox>{
                txtCurrPassword,
                txtNewPassword
            });
        }

        private void btnRequestAccDelete_Click(object sender, EventArgs e)
        {
            // Send a Notification for Account Deletion

            bool requestAccDelete = (bool)!_userRef.SentAccountDeletion;

            if(requestAccDelete)
            {
                var diag = MessageBox.Show(
                        "Are you sure you want to request account deletion?\n\nYou can cancel this within 24 hours.",
                        "Confirm Deletion Request",
                         MessageBoxButtons.OKCancel,
                         MessageBoxIcon.Warning
                         );

                if (diag != DialogResult.OK) return;
            }
            else
            {
                MessageBox.Show("You cancelled the deletion for your account.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            var userSetService = new UserSettingService();
            userSetService.ToggleAccountDeletionReq(_userRef, requestAccDelete);
           
            btnRequestAccDelete.Text = requestAccDelete ? "Cancel Request" : "Request Deletion";

        }
        private void UserSettings_Load(object sender, EventArgs e)
        {
            btnRequestAccDelete.Text = (bool)_userRef.SentAccountDeletion ? "Cancel Request" : "Request Deletion";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var userSetService = new UserSettingService();
            userSetService.UpdateName(_userRef, txtFirstName.Text.Trim(), txtLastName.Text.Trim());

            MessageBox.Show("Your account has been updated!", "Account Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mainFormVButtonExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form to return to the previous one
        }
    }
}
