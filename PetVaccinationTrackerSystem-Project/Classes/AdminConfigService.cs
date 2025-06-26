using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes
{
    public class AdminConfigService
    {
        private string _configFilePath;

        public AdminConfigService()
        {
            _configFilePath = GetAdminConfigPath();
        }

        private string GetAdminConfigPath()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory; // Gets the base directory of the application
            string projectRoot = Path.GetFullPath(Path.Combine(baseDir, "..", "..", "..")); // Navigate to the project root directory
            string relativePath = Path.Combine(projectRoot, "admin", "admin_config.txt"); // Combine with the relative path to the admin config file
            string fullPath = Path.GetFullPath(relativePath);

            return fullPath;
        }

        public string[] LoadCredentials()
        {
            if (File.Exists(_configFilePath))
            {
                string[] lines = File.ReadAllLines(_configFilePath);

                if (lines.Length >= 2)
                {
                    string username = lines[0].Trim();
                    string password = lines[1].Trim();
                    
                    return [username, password];
                }
                else
                {
                    MessageBox.Show("File format is incorrect. Must have at least two lines.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return [];
                }
            }
            else
            {
                MessageBox.Show("Admin configuration file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return [];
            }
            return [];
        }

        public void SaveCredentials(string inUsername, string inPassword)
        {

            // Replaces 1st line with username and 2nd line with password
            string[] updatedLines = { inUsername, inPassword };

            // Overwrites the file with the new content
            File.WriteAllLines(_configFilePath, updatedLines);

            MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
