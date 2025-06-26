using PetVaccinationTrackerSystem_Project.Classes;
using PetVaccinationTrackerSystem_Project.Classes.Interfaces;
using PetVaccinationTrackerSystem_Project.Data;
using PetVaccinationTrackerSystem_Project.Forms.Admin;
using PetVaccinationTrackerSystem_Project.Forms.PetOwner;
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

        public static class SessionData
        {
            public static int? CurrentVetID { get; set; } // Refactored for Veterinarian ID session management
        }

        private bool CheckIfAdminLogin(string email, string password)
        {

            var adminConfig = new AdminConfigService();

            string[] adminCred = adminConfig.LoadCredentials();

            if(adminCred.Length > 0)
            {
                if (email == adminCred[0] && password == adminCred[1])
                {
                    return true;
                }
            }

            return false;
        }

        private void ShowSystemPasswordChar(bool show)
        {
            txtboxPassword.UseSystemPasswordChar = !show;
        }

        private void ClearTextBoxes()
        {
            var fieldHelper = new TextFieldHelper();
            fieldHelper.ClearFields(
                new List<TextBox>
                {
                    txtboxEmail,
                    txtboxPassword
                });    
        }

        private void AdminLogin()
        {
            MessageBox.Show($"Welcome! You are logged in as Admin.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Switch to the Dashboard/Main Winform.
            ClearTextBoxes();
            FormManager.SwitchForm(this, new AdminForm());
        }

        public AuthForm()
        {
            InitializeComponent();

        }

        private void AuthForm_Shown(object sender, EventArgs e)
        {
            txtboxEmail.Focus(); // Set focus to the email textbox on form shown
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtboxEmail.Text.Trim();
            var password = txtboxPassword.Text.Trim();

            // Check if the Admin is logging in
            if (CheckIfAdminLogin(email, password))
            {
                // If the user is an admin, switch to the Admin Dashboard.
                AdminLogin();
                return;
            }

            // Forceload the Context to ensure the database is updated
            using (var context = new ModelContext())
            {
                var userRepository = new UserRepository(context);
                _authServices = new AuthService(userRepository);

                // Using the AuthService to login the user
                var user = _authServices.Login(email, password);

                // If the user non-null value that means the user exists and the password matches.
                if (user != null)
                {
                    // Message
                    MessageBox.Show($"Welcome {user.FirstName} {user.LastName}! You are logged in as {user.UserRole}.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Switch between Forms (Polymorphic Function)
                    if (user.UserRole == "Veterinarian")
                    {
                        SessionData.CurrentVetID = user.Veterinarian.VetID; // Refactored to use the SessionData class
                        FormManager.SwitchForm(this, new MainFormVet(user));
                    }
                    else
                    {
                        FormManager.SwitchForm(this, new PetOwnerForm(user));
                    }

                    // Clear TextFields
                    ClearTextBoxes();

                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void linklblResetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthRequestPasswordChange authRequestPasswordChange = new AuthRequestPasswordChange();
            authRequestPasswordChange.ShowDialog(); // Show the password change request form as a dialog
        }

    }
}
