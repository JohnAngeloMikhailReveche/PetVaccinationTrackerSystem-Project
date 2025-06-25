using PetVaccinationTrackerSystem_Project.Classes;
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
    public partial class MainFormVet : Form
    {
        // The User object representing the current veterinarian user
        private User _currentUser;

        private void InitializeLabels()
        {

            lblClinic.Text = _currentUser?.Veterinarian?.Clinic?.ClinicName ?? "No Clinic Assigned | ERROR DATA READING FROM USERDATA";
            lblVetName.Text = _currentUser.FirstName + " " + _currentUser.LastName;
        }

        public MainFormVet(User inUserReference)
        {
            InitializeComponent();

            // Used Dependency Injection for passing the current user reference
            _currentUser = inUserReference;
            mainFormVSideBHighlight.Height = btnHome.Height;
            mainFormVSideBHighlight.Top = btnHome.Top;
            homePanel1.BringToFront();

        }

        private void MainFormVet_Load(object sender, EventArgs e)
        {
            InitializeLabels();
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

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            mainFormVSideBHighlight.Height = btnAboutUs.Height;
            mainFormVSideBHighlight.Top = btnAboutUs.Top;
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

   
    }
}
