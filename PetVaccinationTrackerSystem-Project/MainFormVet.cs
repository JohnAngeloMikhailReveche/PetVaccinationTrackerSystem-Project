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
            mainFormVSideBHighlight.Height = mainFormVButtonHome.Height;
            mainFormVSideBHighlight.Top = mainFormVButtonHome.Top;
            homePanel1V.BringToFront();

            // Used Dependency Injection for passing the current user reference
            _currentUser = inUserReference;
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

        private void mainFormVButtonHome_Click(object sender, EventArgs e)
        {
            mainFormVSideBHighlight.Height = mainFormVButtonHome.Height;
            mainFormVSideBHighlight.Top = mainFormVButtonHome.Top;
            homePanel1V.BringToFront();
        }

        private void mainFormVButtonRegister_Click(object sender, EventArgs e)
        {
            mainFormVSideBHighlight.Height = mainFormVButtonRegister.Height;
            mainFormVSideBHighlight.Top = mainFormVButtonRegister.Top;
            registerPetOwnerPanel1V.BringToFront();
        }

        private void mainFormVButtonVRDS_Click(object sender, EventArgs e)
        {
            mainFormVSideBHighlight.Height = mainFormVButtonVRDS.Height;
            mainFormVSideBHighlight.Top = mainFormVButtonVRDS.Top;
            vaccineRecordsPanel1V.BringToFront();
        }

        private void mainFormVButtonPetP_Click(object sender, EventArgs e)
        {
            mainFormVSideBHighlight.Height = mainFormVButtonPetP.Height;
            mainFormVSideBHighlight.Top = mainFormVButtonPetP.Top;
            petProfilePanel1V.BringToFront();
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

        private void mainFormVButtonVH_Click(object sender, EventArgs e)
        {
            mainFormVSideBHighlight.Height = mainFormVButtonVH.Height;
            mainFormVSideBHighlight.Top = mainFormVButtonVH.Top;
            vaccinationHistory1.BringToFront();
        }

        private void mainFormVButtonVRTS_Click(object sender, EventArgs e)
        {
            mainFormVSideBHighlight.Height = mainFormVButtonVRTS.Height;
            mainFormVSideBHighlight.Top = mainFormVButtonVRTS.Top;
            pet_Reports1.BringToFront();
        }

    }
}
