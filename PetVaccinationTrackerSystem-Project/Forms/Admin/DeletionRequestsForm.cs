using PetVaccinationTrackerSystem_Project.Classes;
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

namespace PetVaccinationTrackerSystem_Project.Forms.Admin
{
    public partial class DeletionRequestsForm : UserControl
    {

        public void LoadData()
        {
            using (var context = new ModelContext())
            {
                var userData = context.UserList
                    .Where(u => u.SentAccountDeletion == true)
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

        public DeletionRequestsForm()
        {
            InitializeComponent();
        }

        private void dgvUserList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvUserList.CurrentRow?.DataBoundItem is User selectedUser)
            {
                var diagResult = MessageBox.Show(
                    $"Are you sure you want to delete the account for {selectedUser.FirstName} {selectedUser.LastName}?",
                    "Account Delete Confirmation",
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

                            // If the User is a PetOwner
                            if(user.UserRole == "PetOwner")
                            {
                                var userPets = context.PetList
                                    .Where(p => p.UserID == user.UserID)
                                    .ToList();

                                if(userPets.Any())
                                {
                                    context.PetList.RemoveRange(userPets);
                                    context.SaveChanges();
                                }

                            }

                            // If the User is a Veterinarian
                            if(user.VetID != null)
                            {
                                var vet = context.VeterinarianList
                                    .Where(v => v.VetID == user.VetID)
                                    .ToList();

                                if(vet.Any())
                                {
                                    context.VeterinarianList.RemoveRange(vet);
                                    context.SaveChanges();
                                }
                            }

                            // Remove User from Database
                            context.UserList.Remove(user);
                            context.SaveChanges();

                            MessageBox.Show("Account has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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




    }
}
