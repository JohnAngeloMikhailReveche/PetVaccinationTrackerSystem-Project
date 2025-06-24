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

        private void InitializeUserControls()
        {
            PetOwner_PetProfile petOwnerPetProfile = new PetOwner_PetProfile(_currentUser);
            petOwnerPetProfile.Visible = true;
            mainPanel.Controls.Add(petOwnerPetProfile);
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
            //adminRegisterClinicUsCo1V.BringToFront();
        }

        private void PetOwnerForm_Load(object sender, EventArgs e)
        {
            InitializeUserControls();
        }
    }
}
