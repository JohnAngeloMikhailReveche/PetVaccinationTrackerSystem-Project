using PetVaccinationTrackerSystem_Project.Classes;
using PetVaccinationTrackerSystem_Project.Classes.Abstract;
using PetVaccinationTrackerSystem_Project.Classes.ActionHandlers;
using PetVaccinationTrackerSystem_Project.Classes.Interfaces;
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
    public partial class DeletionRequestsForm : UserControl, IRequestForm
    {

        private readonly UserActionHandler _handler;
        private readonly UserListPanelHelper _listPanel;

        public void LoadData()
        {
            using (var context = new ModelContext())
            {
                var userData = context.UserList
                    .Where(u => u.SentAccountDeletion == true)
                    .ToList();

                _listPanel.SetupDataGridView(userData);
            }
        }

        public DeletionRequestsForm()
        {
            InitializeComponent();

            _handler = new DeleteAccountHandler();
            _listPanel = new UserListPanelHelper(dgvUserList);
        }

        private void DgvUserList_DoubleClick(object sender, EventArgs e)
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
                        var user = context.UserList.FirstOrDefault(u => u.UserID == selectedUser.UserID);
                        if (user != null)
                        {
                            _handler.HandleAction(user, context);
                            MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                    }
                }
            }
        }
    }
}
