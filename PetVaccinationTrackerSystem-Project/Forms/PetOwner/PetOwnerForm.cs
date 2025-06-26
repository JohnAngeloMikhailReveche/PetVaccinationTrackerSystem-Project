using PetVaccinationTrackerSystem_Project.Classes;
using PetVaccinationTrackerSystem_Project.Data;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using PetVaccinationTrackerSystem_Project.Forms.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetVaccinationTrackerSystem_Project.Forms.PetOwner
{
    public partial class PetOwnerForm : Form
    {

        private User _currentUser;

        private void HighlightButtons(Button btn)
        {
            mainFormVSideBHighlight.Height = btn.Height;
            mainFormVSideBHighlight.Top = btn.Top;
        }

        private void SwitchForms(Control control)
        {
            mainPanel.Controls.Clear(); // Clear the current controls in the main panel
            mainPanel.Controls.Add(control);
        }

        private void RefreshCurrentUser()
        {
            var updatedUser = UserSessionManager.RefreshUser(_currentUser);

            // If the updated user is valid and has a value
            if (updatedUser != null)
            {
                _currentUser = updatedUser;
                InitializeLabels();
            }
        }

        private void InitializeLabels()
        {
            lblPetOwnerName.Text = _currentUser.FirstName + " " + _currentUser.LastName;
        }

        public PetOwnerForm(User inUserReference)
        {
            InitializeComponent();

            _currentUser = inUserReference;
            homePanelPetOwner1.BringToFront();
        }

        private void btnPetProfiles_Click(object sender, EventArgs e)
        {
            HighlightButtons(btnPetProfiles);

            PetOwner_PetProfile petOwnerPetProfile = new PetOwner_PetProfile(_currentUser);
            petOwnerPetProfile.Visible = true;
            SwitchForms(petOwnerPetProfile);

        }

        private void PetOwnerForm_Load(object sender, EventArgs e)
        {
            InitializeLabels();
            DefaultPasswordMessage.CheckIfUserPasswordIsDefault(_currentUser);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult diagResult = MessageBox.Show(
               "Are you sure you want to exit?",
               "Log Out Confirmation",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
               );

            if (diagResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult diagResult = MessageBox.Show(
             "Are you sure you want to log out?",
             "Log Out Confirmation",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
             );

            if (diagResult == DialogResult.Yes)
            {
                this.Close(); // Triggers the FormClosed event to switch back to the AuthForm.
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HighlightButtons(btnHome);

            SwitchForms(homePanelPetOwner1);
            homePanelPetOwner1.BringToFront(); // Bring the home panel to the front

        }
        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            HighlightButtons(btnAboutUs);

            // Add the About Us Dashboard here and make the logic as follows:
            PetOwner_AboutUs petOwnerAboutUs = new PetOwner_AboutUs();
            petOwnerAboutUs.Visible = true;
            SwitchForms(petOwnerAboutUs);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            UserSettings userSettings = new UserSettings(_currentUser);

            userSettings.FormClosed += (s, args) =>
            {
                RefreshCurrentUser();
            };
            
            userSettings.ShowDialog();
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            InboxForm inboxForm = new InboxForm(_currentUser);
            inboxForm.ShowDialog();
        }
    }
}
