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

        // Private fields to store the admin credentials
        private string _fullPathToAdminConfigFile;
        private string _adminUsername;
        private string _adminPassword;

        private string GetAdminConfigFile()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory; // Gets the base directory of the application
            string projectRoot = Path.GetFullPath(Path.Combine(baseDir, "..", "..", "..")); // Navigate to the project root directory
            string relativePath = Path.Combine(projectRoot, "admin", "admin_config.txt"); // Combine with the relative path to the admin config file
            string fullPath = Path.GetFullPath(relativePath);

            return fullPath;
        }
        private void LoadAdminConfigFile()
        {
            if (File.Exists(_fullPathToAdminConfigFile))
            {
                string[] lines = File.ReadAllLines(_fullPathToAdminConfigFile);

                if (lines.Length >= 2)
                {
                    string username = lines[0].Trim();
                    string password = lines[1].Trim();

                    // Store the admin credentials in private fields
                    _adminUsername = username;
                    _adminPassword = password;
                }
            }
        }

        private bool CheckIfAdminLogin(string email, string password)
        {

            if(string.IsNullOrEmpty(_fullPathToAdminConfigFile))
            {
                _fullPathToAdminConfigFile = GetAdminConfigFile(); // Get the full path to the admin config file
            }
            
            LoadAdminConfigFile(); // Load the admin config file to get the admin credentials

            if (email == _adminUsername && password == _adminPassword)
            {
                return true;
            }

            return false;
        }

        private void ShowSystemPasswordChar(bool show)
        {
            txtboxPassword.UseSystemPasswordChar = !show;
        }

        private void ClearTextBoxes()
        {
            txtboxEmail.Clear();
            txtboxPassword.Clear();
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

            // Check if the Admin is logging in
            if (CheckIfAdminLogin(email, password))
            {
                // If the user is an admin, switch to the Admin Dashboard.
                AdminLogin();
                return;
            }

            // Using the AuthService to login the user
            var user = _authServices.Login(email, password);

            // If the user non-null value that means the user exists and the password matches.
            if (user != null)
            {

                MessageBox.Show($"Welcome {user.FirstName} {user.LastName}! You are logged in as {user.UserRole}.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if(user.UserRole == "Veterinarian")
                {
                    FormManager.SwitchForm(this, new MainFormVet(user));
                } else
                {
                    FormManager.SwitchForm(this, new PetOwnerForm(user));
                }

                    ClearTextBoxes();
                
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
