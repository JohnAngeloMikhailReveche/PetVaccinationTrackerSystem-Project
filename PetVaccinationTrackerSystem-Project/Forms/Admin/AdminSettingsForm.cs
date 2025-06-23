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

        private string _fullPathToAdminConfigFile;

        private string GetAdminConfigFile()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory; // Gets the base directory of the application
            string projectRoot = Path.GetFullPath(Path.Combine(baseDir, "..", "..", "..")); // Navigate to the project root directory
            string relativePath = Path.Combine(projectRoot, "admin", "admin_config.txt"); // Combine with the relative path to the admin config file
            string fullPath = Path.GetFullPath(relativePath);

            return fullPath;
        }

        private void LoadConfigFile()
        {
            if (File.Exists(_fullPathToAdminConfigFile))
            {
                string[] lines = File.ReadAllLines(_fullPathToAdminConfigFile);

                if (lines.Length >= 2)
                {
                    string username = lines[0].Trim();
                    string password = lines[1].Trim();

                    txtboxUsername.Text = username;
                    txtboxPassword.Text = password;
                }
                else
                {
                    MessageBox.Show("File format is incorrect. Must have at least two lines.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Admin configuration file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public AdminSettingsForm()
        {
            InitializeComponent();
            _fullPathToAdminConfigFile = GetAdminConfigFile();
        }

        private void AdminSettingsForm_Load(object sender, EventArgs e)
        {
            LoadConfigFile();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string updatedUsername = txtboxUsername.Text.Trim();
            string updatedPassword = txtboxPassword.Text.Trim();

            // Replaces 1st line with username and 2nd line with password
            string[] updatedLines = { updatedUsername, updatedPassword };

            // Overwrites the file with the new content
            File.WriteAllLines(_fullPathToAdminConfigFile, updatedLines);

            MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadConfigFile(); // Reload the config file to reflect changes in the UI
        }

        private void mainFormVButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
