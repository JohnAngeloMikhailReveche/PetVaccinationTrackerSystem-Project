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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            mainFormSideBHighlight.Height = mainFormButtonHome.Height;
            mainFormSideBHighlight.Top = mainFormButtonHome.Top;
            homePanel1.BringToFront();
        }

        private void mainFormButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainFormButtonHome_Click(object sender, EventArgs e)
        {
            mainFormSideBHighlight.Height = mainFormButtonHome.Height;
            mainFormSideBHighlight.Top = mainFormButtonHome.Top;
            homePanel1.BringToFront();
        }

        private void mainFormButtonPetP_Click(object sender, EventArgs e)
        {
            mainFormSideBHighlight.Height = mainFormButtonPetP.Height;
            mainFormSideBHighlight.Top = mainFormButtonPetP.Top;
        }

        private void mainFormButtonVRDS_Click(object sender, EventArgs e)
        {
            mainFormSideBHighlight.Height = mainFormButtonVRDS.Height;
            mainFormSideBHighlight.Top = mainFormButtonVRDS.Top;
            vaccineRecordsPanel1.BringToFront();
        }

        private void mainFormButtonVRTS_Click(object sender, EventArgs e)
        {
            mainFormSideBHighlight.Height = mainFormButtonVRTS.Height;
            mainFormSideBHighlight.Top = mainFormButtonVRTS.Top;
            vaccineReportsPanel1.BringToFront();
        }
        private void mainFormButtonAboutUs_Click(object sender, EventArgs e)
        {
            mainFormSideBHighlight.Height = mainFormButtonAboutUs.Height;
            mainFormSideBHighlight.Top = mainFormButtonAboutUs.Top;
            aboutUsPanel1.BringToFront();
        }

    }
}

