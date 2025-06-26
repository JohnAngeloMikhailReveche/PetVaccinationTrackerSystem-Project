using PetVaccinationTrackerSystem_Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes
{
    public class UserListPanelHelper
    {
        private readonly DataGridView _dgv;

        public UserListPanelHelper(DataGridView inDataGridView)
        {
            _dgv = inDataGridView;
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            _dgv.ReadOnly = true;
            _dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgv.MultiSelect = false;
        }

        public void SetupDataGridView(List<User> users)
        {
            _dgv.DataSource = users;

            _dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            _dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            void SafeHide(string name)
            {
                if (_dgv.Columns.Contains(name)) _dgv.Columns[name].Visible = false;
            }

            void SafeRename(string name, string header)
            {
                if (_dgv.Columns.Contains(name)) _dgv.Columns[name].HeaderText = header;
            }

            SafeHide("UserPassword");
            SafeHide("SentPasswordRequest");
            SafeHide("VetID");
            SafeHide("Veterinarian");

            SafeRename("UserID", "User ID");
            SafeRename("FirstName", "First Name");
            SafeRename("LastName", "Last Name");
            SafeRename("UserEmail", "Email");
            SafeRename("UserRole", "Role");
        }
    }
}
