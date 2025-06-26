using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PetVaccinationTrackerSystem_Project.Classes;
using PetVaccinationTrackerSystem_Project.Classes.Abstract;
using PetVaccinationTrackerSystem_Project.Classes.ActionHandlers;
using PetVaccinationTrackerSystem_Project.Classes.Interfaces;
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
    public partial class PasswordRequestsForm : UserControl, IRequestForm
    {

        private readonly UserActionHandler _handler;
        private readonly UserListPanelHelper _listPanel;
        public void LoadData()
        {
            using (var context = new ModelContext())
            {
                var userData = context.UserList
                    .Where(u => u.SentPasswordRequest == true)
                    .ToList();
                
                _listPanel.SetupDataGridView(userData);
            }
        }

        public PasswordRequestsForm()
        {
            InitializeComponent();

            _handler = new ResetPasswordHandler();
            _listPanel = new UserListPanelHelper(dgvUserList);
        }

        private void DgvUserList_DoubleClick(object sender, EventArgs e)
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
                            _handler.HandleAction(user, context);

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

        private void dgvVetList_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void PasswordRequestsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
