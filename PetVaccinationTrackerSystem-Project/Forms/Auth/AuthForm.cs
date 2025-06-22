using PetVaccinationTrackerSystem_Project.Classes;
using PetVaccinationTrackerSystem_Project.Classes.Interfaces;
using PetVaccinationTrackerSystem_Project.Data;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PetVaccinationTrackerSystem_Project.Forms.Auth
{
    public partial class AuthForm : Form
    {

        private IAuthServices _authServices;

        private void ShowSystemPasswordChar(bool show)
        {
            txtboxPassword.UseSystemPasswordChar = !show;
        }

        private void ClearTextBoxes()
        {
            txtboxEmail.Clear();
            txtboxPassword.Clear();
        }

        private void BypassLoginBeta()
        {
            MessageBox.Show($"Welcome User! You are logged in as BETA User.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Switch to the Dashboard/Main Winform.
            ClearTextBoxes();
            FormManager.SwitchForm(this, new MainFormVet());
        }

        private void AdminLoginBeta()
        {
            MessageBox.Show($"Welcome Admin! You are logged in as BETA Admin.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Switch to the Dashboard/Main Winform.
            ClearTextBoxes();
            FormManager.SwitchForm(this, new AdminForm());
        }

        public AuthForm()
        {
            InitializeComponent();

            var context = new ModelContext();
            var userRepository = new UserRepository(context);
            _authServices = new AuthService(userRepository);

        }

        private void AuthForm_Shown(object sender, EventArgs e)
        {
            txtboxEmail.Focus(); // Set focus to the email textbox on form shown
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtboxEmail.Text.Trim();
            var password = txtboxPassword.Text.Trim();

            // Beta Purposes - remove this in production
            if (email == "user" && password == "user123")
            {
                // Bypass login for beta testing purposes
                BypassLoginBeta();
                return;
            }

            // Beta Purposes - remove this in production
            if (email == "admin" && password == "admin123")
            {
                AdminLoginBeta();
                return;
            }

            // Using the AuthService to login the user
            var user = _authServices.Login(email, password);

            // If the user non-null value that means the user exists and the password matches.
            if (user != null)
            {
                MessageBox.Show($"Welcome {user.FirstName}! You are logged in as {user.UserRole}.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Switch to the Dashboard/Main Winform.
                ClearTextBoxes();
                FormManager.SwitchForm(this, new MainFormVet());
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            ShowSystemPasswordChar(true);
        }

        private void btnShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            ShowSystemPasswordChar(false);
        }

        private void mainFormVButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
