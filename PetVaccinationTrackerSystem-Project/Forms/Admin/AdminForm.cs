using Microsoft.EntityFrameworkCore;
using PetVaccinationTrackerSystem_Project.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetVaccinationTrackerSystem_Project.Forms.Admin
{
    public partial class AdminForm : Form
    {


        public AdminForm()
        {
            InitializeComponent();
            mainFormVSideBHighlight.Height = mainFormVButtonHome.Height;
            mainFormVSideBHighlight.Top = mainFormVButtonHome.Top;
            homePanel1.BringToFront();
        }

        private void btnRegisterClinic_Click(object sender, EventArgs e)
        {
            mainFormVSideBHighlight.Height = btnRegisterClinic.Height;
            mainFormVSideBHighlight.Top = btnRegisterClinic.Top;
            adminRegisterClinicUsCo1V.BringToFront();
        }

        private void mainFormVButtonRegister_Click(object sender, EventArgs e)
        {
            mainFormVSideBHighlight.Height = btnRegisterVet.Height;
            mainFormVSideBHighlight.Top = btnRegisterVet.Top;
            adminRegisterVetUsCo1V.RefreshData();
            adminRegisterVetUsCo1V.BringToFront();
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

        private void mainFormVButtonHome_Click(object sender, EventArgs e)
        {
            mainFormVSideBHighlight.Height = mainFormVButtonHome.Height;
            mainFormVSideBHighlight.Top = mainFormVButtonHome.Top;

            homePanel1.BringToFront();
        }

        private void mainFormVButtonSettings_Click(object sender, EventArgs e)
        {
            AdminSettingsForm adminSettingsForm = new AdminSettingsForm();

            adminSettingsForm.ShowDialog();
        }

        private void adminRegisterVetUsCo1V_Load(object sender, EventArgs e)
        {

        }

        private void btnClinicList_Click(object sender, EventArgs e)
        {
            mainFormVSideBHighlight.Height = btnClinicList.Height;
            mainFormVSideBHighlight.Top = btnClinicList.Top;

            // Load data for the home user control
            registeredClinicPanel1V.LoadClinicData();

            registeredClinicPanel1V.BringToFront();
        }

        private void btnVeterinarianList_Click(object sender, EventArgs e)
        {
            mainFormVSideBHighlight.Height = btnVeterinarianList.Height;
            mainFormVSideBHighlight.Top = btnVeterinarianList.Top;

            // Load data for the home user control
            registeredVetPanel1V.LoadVeterinarianData();

            registeredVetPanel1V.BringToFront();
        }

        private void btnPasswordRequest_Click(object sender, EventArgs e)
        {
            mainFormVSideBHighlight.Height = btnPasswordRequest.Height;
            mainFormVSideBHighlight.Top = btnPasswordRequest.Top;

            // Load data
            passwordRequestsForm1V.LoadData();

            passwordRequestsForm1V.BringToFront();
        }

        private void btnDeleteRequest_Click(object sender, EventArgs e)
        {
            mainFormVSideBHighlight.Height = btnDeleteRequest.Height;
            mainFormVSideBHighlight.Top = btnDeleteRequest.Top;

            // Load data
            deletionRequestsForm1V.LoadData();

            deletionRequestsForm1V.BringToFront();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            mainFormVSideBHighlight.Height = btnAboutUs.Height;
            mainFormVSideBHighlight.Top = btnAboutUs.Top;
            petOwner_AboutUs1.BringToFront();
        }
    }
}
