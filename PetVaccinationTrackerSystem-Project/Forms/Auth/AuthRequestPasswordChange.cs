using PetVaccinationTrackerSystem_Project.Classes;
using PetVaccinationTrackerSystem_Project.Classes.Enums;
using PetVaccinationTrackerSystem_Project.Data;
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

namespace PetVaccinationTrackerSystem_Project.Forms.Auth
{
    public partial class AuthRequestPasswordChange : Form
    {

        private PasswordRequestChange _passwordRequestChange;

        public AuthRequestPasswordChange()
        {
            InitializeComponent();

            _passwordRequestChange = new PasswordRequestChange();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            string storedEmail = txtboxEmail.Text.Trim();
            var result = _passwordRequestChange.RequestPasswordReset(storedEmail);

            switch(result)
            {
                case PasswordRequestResult.Success:
                    MessageBox.Show("Password reset requested successfully. Please wait for any emails from the admin.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case PasswordRequestResult.AlreadyRequested:
                    MessageBox.Show("You've already sent a password request. Please wait for admin response.", "Already Sent", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case PasswordRequestResult.UserNotFound:
                    MessageBox.Show("No user found with this email. Please check and try again.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case PasswordRequestResult.InvalidEmail:
                    MessageBox.Show("Only emails ending in @vetclinic.com or @petownerclinic.com are accepted.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }       
        }

        private void mainFormVButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
