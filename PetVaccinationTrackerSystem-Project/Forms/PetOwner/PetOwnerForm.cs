using PetVaccinationTrackerSystem_Project.Classes;
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

        private void InitializeLabels()
        {
            lblPetOwnerName.Text = _currentUser.FirstName + " " + _currentUser.LastName;
        }

        public PetOwnerForm(User inUserReference)
        {
            InitializeComponent();

            _currentUser = inUserReference;
        }

        private void btnPetProfiles_Click(object sender, EventArgs e)
        {
            mainFormVSideBHighlight.Height = btnPetProfiles.Height;
            mainFormVSideBHighlight.Top = btnPetProfiles.Top;

            mainPanel.Controls.Clear(); // Clear the current controls in the main panel
            PetOwner_PetProfile petOwnerPetProfile = new PetOwner_PetProfile(_currentUser);
            petOwnerPetProfile.Visible = true;
            mainPanel.Controls.Add(petOwnerPetProfile);
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
            mainFormVSideBHighlight.Height = btnHome.Height;
            mainFormVSideBHighlight.Top = btnHome.Top;

            mainPanel.Controls.Clear(); // Clear the current controls in the main panel

            // Add the Home Dashboard here and make the logic as follows:
            // PetOwner_PetProfile petOwnerPetProfile = new PetOwner_PetProfile(_currentUser);
            // petOwnerPetProfile.Visible = true;
            // mainPanel.Controls.Add(petOwnerPetProfile);
        }
        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            mainFormVSideBHighlight.Height = btnAboutUs.Height;
            mainFormVSideBHighlight.Top = btnAboutUs.Top;

            mainPanel.Controls.Clear(); // Clear the current controls in the main panel

            // Add the About Us Dashboard here and make the logic as follows:
            PetOwner_AboutUs petOwnerAboutUs = new PetOwner_AboutUs();
            petOwnerAboutUs.Visible = true;
            mainPanel.Controls.Add(petOwnerAboutUs);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            UserSettings userSettings = new UserSettings(_currentUser);
            userSettings.ShowDialog();
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            InboxForm inboxForm = new InboxForm(_currentUser);
            inboxForm.ShowDialog();
        }
    }
}
