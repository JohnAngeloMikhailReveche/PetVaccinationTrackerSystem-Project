using Microsoft.EntityFrameworkCore;
using PetVaccinationTrackerSystem_Project.Data;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using PetVaccinationTrackerSystem_Project.Forms.Admin;
using PetVaccinationTrackerSystem_Project.Forms.PetOwner.InnerRecords;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetVaccinationTrackerSystem_Project.Forms.PetOwner
{
    public partial class PetOwner_PetProfile : UserControl
    {
        private User? _currentUser;

        public void LoadData()
        {
            using (var context = new ModelContext())
            {
                var petList = context.PetList
                     .Include(u => u.User)
                     .Where(u => u.User.UserID == _currentUser.UserID)
                     .ToList();

                dgvRegisteredPet.DataSource = petList;

                // Adjust DataGridView Properties
                dgvRegisteredPet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvRegisteredPet.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }

        public PetOwner_PetProfile(User inUserReference)
        {
            InitializeComponent();

            _currentUser = inUserReference;

        }

        private void dgvRegisteredPet_DoubleClick(object sender, EventArgs e)
        {
            if (dgvRegisteredPet.CurrentRow?.DataBoundItem is Pet selectedPet)
            {
                PetOwner_PetProfileInstance petProfileInstance = new PetOwner_PetProfileInstance(selectedPet, _currentUser);
                petProfileInstance.ShowDialog(this);
            }
        }

        private void PetOwner_PetProfile_Load(object sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                LoadData();
            }
            else
            {
                MessageBox.Show("User reference is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





    }
}
