using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaccinationForm;

namespace PetVaccinationTrackerSystem_Project
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }
     

        private void buttonHome_Click(object sender, EventArgs e)
        {
            sidePanelHighlight.Height = buttonHome.Height;
            sidePanelHighlight.Top = buttonHome.Top;
        }

        private void buttonPetProfile_Click(object sender, EventArgs e)
        {
            sidePanelHighlight.Height = buttonPetProfile.Height;
            sidePanelHighlight.Top = buttonPetProfile.Top;
        }

        private void buttonVaccinationRecords_Click(object sender, EventArgs e)
        {
            sidePanelHighlight.Height = buttonVaccinationRecords.Height;
            sidePanelHighlight.Top = buttonVaccinationRecords.Top;
        }

        private void buttonVaccinationReports_Click(object sender, EventArgs e)
        {
            sidePanelHighlight.Height = buttonVaccinationReports.Height;
            sidePanelHighlight.Top = buttonVaccinationReports.Top;
        }

        private void buttonAlerts_Click(object sender, EventArgs e)
        {
            sidePanelHighlight.Height = buttonAlerts.Height;
            sidePanelHighlight.Top = buttonAlerts.Top;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            sidePanelHighlight.Height = buttonSettings.Height;
            sidePanelHighlight.Top = buttonSettings.Top;
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {

        }

    }
}
