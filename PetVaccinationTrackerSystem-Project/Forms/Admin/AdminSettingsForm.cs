using PetVaccinationTrackerSystem_Project.Classes;
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
    public partial class AdminSettingsForm : Form
    {

        private AdminConfigService _adminConfig;

        public AdminSettingsForm()
        {
            InitializeComponent();

            _adminConfig = new AdminConfigService();
        }

        private void AdminSettingsForm_Load(object sender, EventArgs e)
        {
            string[] credentials = _adminConfig.LoadCredentials();

            if(credentials.Length != 0)
            {
                txtboxUsername.Text = credentials[0];
                txtboxPassword.Text = credentials[1];
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            _adminConfig.SaveCredentials(txtboxUsername.Text.Trim(), txtboxPassword.Text.Trim());
        }

        private void mainFormVButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
