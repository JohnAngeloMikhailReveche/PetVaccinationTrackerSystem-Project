using Microsoft.EntityFrameworkCore;
using PetVaccinationTrackerSystem_Project.Classes.Interfaces;
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

        private void ShowRequestForm(IRequestForm requestForm)
        {
            requestForm.LoadData(); // Polymorphic Function (Password/Deletion)
            
            var control = requestForm as UserControl;
            if (control != null)
            {
                control.BringToFront();
            }
        }

        private void ShowListForm(ILoadData loadDataForm)
        {
            loadDataForm.LoadData(); // Polymorphic Function (Vet/Clinic)

            var control = loadDataForm as UserControl;
            if (control != null)
            {
                control.BringToFront();
            }
        }

        protected void HighlightButton(Button target, Panel highlightPanel)
        {
            highlightPanel.Height = target.Height;
            highlightPanel.Top = target.Top;
        }

        public AdminForm()
        {
            InitializeComponent();
            HighlightButton(mainFormVButtonHome, mainFormVSideBHighlight);
            homePanelAdmin1.BringToFront();
        }

        private void btnRegisterClinic_Click(object sender, EventArgs e)
        {
            HighlightButton(btnRegisterClinic, mainFormVSideBHighlight);
            adminRegisterClinicUsCo1V.BringToFront();
        }

        private void mainFormVButtonRegister_Click(object sender, EventArgs e)
        {
            HighlightButton(btnRegisterVet, mainFormVSideBHighlight);
            adminRegisterVetUsCo1V.RefreshData();
            adminRegisterVetUsCo1V.BringToFront();
        }

        private void mainFormVButtonExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(
                "Are you sure you want to log out?",
                "Log Out Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mainFormVButtonLO_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure you want to log out?",
                "Log Out Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) == DialogResult.Yes )
            {
                this.Close();
            }
        }

        private void mainFormVButtonHome_Click(object sender, EventArgs e)
        {
            HighlightButton(mainFormVButtonHome, mainFormVSideBHighlight);
            homePanelAdmin1.BringToFront();
        }

        private void mainFormVButtonSettings_Click(object sender, EventArgs e)
        {
            AdminSettingsForm adminSettingsForm = new AdminSettingsForm();
            adminSettingsForm.ShowDialog();
        }

        private void btnClinicList_Click(object sender, EventArgs e)
        {
            HighlightButton(btnClinicList, mainFormVSideBHighlight);
            ShowListForm(registeredClinicPanel1V);
        }

        private void btnVeterinarianList_Click(object sender, EventArgs e)
        {
            HighlightButton(btnVeterinarianList, mainFormVSideBHighlight);
            ShowListForm(registeredVetPanel1V);
        }

        private void btnPasswordRequest_Click(object sender, EventArgs e)
        {
            HighlightButton(btnPasswordRequest, mainFormVSideBHighlight);
            ShowRequestForm(passwordRequestsForm1V);
        }

        private void btnDeleteRequest_Click(object sender, EventArgs e)
        {
            HighlightButton(btnDeleteRequest, mainFormVSideBHighlight);
            ShowRequestForm(deletionRequestsForm1V);
        }

        private void adminRegisterVetUsCo1V_Load(object sender, EventArgs e)
        {
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            mainFormVSideBHighlight.Height = btnAboutUs.Height;
            mainFormVSideBHighlight.Top = btnAboutUs.Top;
            petOwner_AboutUs1.BringToFront();
        }
    }
}
