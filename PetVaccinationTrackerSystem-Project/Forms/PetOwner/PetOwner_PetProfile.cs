using Microsoft.EntityFrameworkCore;
using PetVaccinationTrackerSystem_Project.Classes;
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
            PetService petService = new PetService();

            var petList = petService.GetPetsForUser(_currentUser.UserID);

            dgvRegisteredPet.DataSource = petList;

            // Cell Format
            dgvRegisteredPet.CellFormatting += (s, e) =>
            {
                if (dgvRegisteredPet.Columns[e.ColumnIndex].Name == "DateOfBirth" && e.Value is DateTime dt)
                {
                    e.Value = dt.ToString("MM-dd-yyyy");
                    e.FormattingApplied = true;
                }
            };

            // Adjust DataGridView Properties
            dgvRegisteredPet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRegisteredPet.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Hide Unnecessary ID Columns
            dgvRegisteredPet.Columns["ImageRL"].Visible = false;
            dgvRegisteredPet.Columns["User"].Visible = false;
            dgvRegisteredPet.Columns["Notes"].Visible = false;
            dgvRegisteredPet.Columns["OwnerPhoneNumber"].Visible = false;
            dgvRegisteredPet.Columns["OwnerName"].Visible = false;
            dgvRegisteredPet.Columns["UserID"].Visible = false;

            // Rename columns for better readability
            dgvRegisteredPet.Columns["PetID"].HeaderText = "ID";
            dgvRegisteredPet.Columns["PetName"].HeaderText = "Pet Name";
            dgvRegisteredPet.Columns["DateOfBirth"].HeaderText = "Date of Birth";
            dgvRegisteredPet.Columns["ColorsAndMarkings"].HeaderText = "Colors and Markings";

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
                petProfileInstance.ShowDialog();
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
