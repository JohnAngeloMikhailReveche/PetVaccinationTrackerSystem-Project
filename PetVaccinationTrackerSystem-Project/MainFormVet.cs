using Microsoft.EntityFrameworkCore;
using PetVaccinationTrackerSystem_Project.Classes;
using PetVaccinationTrackerSystem_Project.Data;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using PetVaccinationTrackerSystem_Project.Forms;
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
    public partial class MainFormVet : Form
    {
        // The User object representing the current veterinarian user
        private User? _currentUser;

        private void InitializeLabels()
        {
            lblClinic.Text = _currentUser.Veterinarian.Clinic.ClinicName ?? "No Clinic Assigned | ERROR DATA READING FROM USERDATA";
            lblVetName.Text = _currentUser.FirstName + " " + _currentUser.LastName;
        }

        public MainFormVet(User inUserReference)
        {
            InitializeComponent();

            // Force Loading of the current user from the database to ensure all related entities are loaded
            if (inUserReference != null)
            {
                using (var context = new ModelContext())
                {
                    _currentUser = context.UserList
                        .Include(v => v.Veterinarian)
                        .ThenInclude(c => c.Clinic)
                        .FirstOrDefault(u => u.UserID == inUserReference.UserID);
                }
            }
            else
            {
                MessageBox.Show("No user reference provided. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Close the form if no user reference is provided
                return;
            }


            mainFormVSideBHighlight.Height = btnHome.Height;
            mainFormVSideBHighlight.Top = btnHome.Top;
            homePanel1.BringToFront();

        }

        private void MainFormVet_Load(object sender, EventArgs e)
        {
            InitializeLabels();
            DefaultPasswordMessage.CheckIfUserPasswordIsDefault(_currentUser);
        }
        private void mainFormVButtonExit_Click(object sender, EventArgs e)
        {
            DialogResult diagResult = MessageBox.Show(
                "Are you sure you want to log out?",
                "Log Out Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (diagResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            mainFormVSideBHighlight.Height = btnHome.Height;
            mainFormVSideBHighlight.Top = btnHome.Top;
            homePanel1.BringToFront();
        }

        private void btnPetProfiles_Click(object sender, EventArgs e)
        {
            mainFormVSideBHighlight.Height = btnPetProfiles.Height;
            mainFormVSideBHighlight.Top = btnPetProfiles.Top;
            tablePetProfile1.BringToFront();
        }

        private void btnAddPetProfile_Click(object sender, EventArgs e)
        {
            mainFormVSideBHighlight.Height = btnAddPetProfile.Height;
            mainFormVSideBHighlight.Top = btnAddPetProfile.Top;
            petProfilePanelVet1.BringToFront();
        }

        private void btnVaccineRecords_Click(object sender, EventArgs e)
        {
            mainFormVSideBHighlight.Height = btnVaccineRecords.Height;
            mainFormVSideBHighlight.Top = btnVaccineRecords.Top;
            tablePetRecords1.BringToFront();
        }

        private void btnAddVaccineRecord_Click(object sender, EventArgs e)
        {
            mainFormVSideBHighlight.Height = btnAddVaccineRecord.Height;
            mainFormVSideBHighlight.Top = btnAddVaccineRecord.Top;
            vaccineRecordsPanelVet1.BringToFront();
        }

        private void btnVaccineReports_Click(object sender, EventArgs e)
        {
            mainFormVSideBHighlight.Height = btnVaccineReports.Height;
            mainFormVSideBHighlight.Top = btnVaccineReports.Top;
            pet_Reports1.BringToFront();
        }

        private void btnRegisterPetOwner_Click(object sender, EventArgs e)
        {
            mainFormVSideBHighlight.Height = btnRegisterPetOwner.Height;
            mainFormVSideBHighlight.Top = btnRegisterPetOwner.Top;
            registerPetOwnerPanel1.BringToFront();
        }

        private void mainFormVButtonLO_Click(object sender, EventArgs e)
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

        private void mainFormVButtonSettings_Click(object sender, EventArgs e)
        {
            UserSettings userSettings = new UserSettings(_currentUser);
            userSettings.ShowDialog();
        }

        private void mainFormVButtonAlerts_Click(object sender, EventArgs e)
        {
            InboxForm inboxForm = new InboxForm(_currentUser);
            inboxForm.ShowDialog();
        }
    }
}
