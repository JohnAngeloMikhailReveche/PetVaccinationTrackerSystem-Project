using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PetVaccinationTrackerSystem_Project.Classes;
using PetVaccinationTrackerSystem_Project.Data;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using PetVaccinationTrackerSystem_Project.Data.ViewModels;
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
    public partial class PasswordRequestsForm : UserControl
    {

        public void LoadData()
        {
            using (var context = new ModelContext())
            {
                var userData = context.UserList
                    .Where(u => u.SentPasswordRequest == true)
                    .ToList();

                // Bind the data to the DataGridView
                dgvUserList.DataSource = userData;


                // Adjust DataGridView Properties
                dgvUserList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvUserList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


                // Hide Unnecessary ID Columns
                dgvUserList.Columns["UserPassword"].Visible = false;
                dgvUserList.Columns["SentPasswordRequest"].Visible = false;
                dgvUserList.Columns["VetID"].Visible = false;
                dgvUserList.Columns["Veterinarian"].Visible = false;


                // Altered the name of the column for readability
                dgvUserList.Columns["UserID"].HeaderText = "User ID";
                dgvUserList.Columns["FirstName"].HeaderText = "First Name";
                dgvUserList.Columns["LastName"].HeaderText = "Last Name";
                dgvUserList.Columns["UserEmail"].HeaderText = "Email";
                dgvUserList.Columns["UserRole"].HeaderText = "Role";
            }
        }


        public PasswordRequestsForm()
        {
            InitializeComponent();
        }

        private void dgvVetList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvUserList.CurrentRow?.DataBoundItem is User selectedUser)
            {
                var diagResult = MessageBox.Show(
                    $"Are you sure you want to reset the password for {selectedUser.FirstName} {selectedUser.LastName}?",
                    "Reset Password Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (diagResult == DialogResult.Yes)
                {
                    using (var context = new ModelContext())
                    {
                        // Find the user by UserID
                        var user = context.UserList.FirstOrDefault(u => u.UserID == selectedUser.UserID);
                        if (user != null)
                        {
                            // Reset the password to a default value or generate a new one
                            PasswordHelper passwordHelper = new PasswordHelper();
                            string newPassword = passwordHelper.HashPassword("default");

                            user.UserPassword = newPassword;

                            // Update the SentPasswordRequest flag
                            user.SentPasswordRequest = false;

                            // Update
                            context.UserList.Update(user);

                            // Save changes to the database
                            context.SaveChanges();

                            MessageBox.Show("Password has been reset successfully.\n\n Details:\n New Password: default", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Refresh the data grid
                        }
                        else
                        {
                            MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void PasswordRequestsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
