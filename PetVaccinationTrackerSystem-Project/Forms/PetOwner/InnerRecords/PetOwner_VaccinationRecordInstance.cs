using Microsoft.EntityFrameworkCore;
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

namespace PetVaccinationTrackerSystem_Project.Forms.PetOwner.InnerRecords
{
    public partial class PetOwner_VaccinationRecordInstance : Form
    {

        private Pet _selectedPet;

        private void LoadData()
        {
            // Data Loading
            PetService petService = new PetService();

            var petList = petService.GetVaccinationRecords(_selectedPet.PetID);

            dgvPetRecords.DataSource = petList;

            // DataGridView Formatting
            dgvPetRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPetRecords.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvPetRecords.Columns["PetID"].HeaderText = "Pet ID";
            dgvPetRecords.Columns["NextDueDate"].HeaderText = "Next Due Date";
            dgvPetRecords.Columns["DateAdministered"].HeaderText = "Date Administered";
            dgvPetRecords.Columns["AdministeredBy"].HeaderText = "Administered By";
            dgvPetRecords.Columns["VaccineName"].HeaderText = "Vaccine";
            dgvPetRecords.Columns["PetName"].HeaderText = "Pet Name";
            dgvPetRecords.Columns["RecordID"].HeaderText = "ID";
            dgvPetRecords.Columns["BatchNo"].HeaderText = "Batch No.";


        }

        public PetOwner_VaccinationRecordInstance(Pet inPetRef)
        {
            InitializeComponent();

            _selectedPet = inPetRef;

            // Renames the Window title to include the pet's name
            this.Text = _selectedPet.PetName + " - Vaccination History";
        }

        private void PetOwner_VaccinationRecordInstance_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void mainFormVButtonExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form to return to the previous one
        }

        // Loading the PetHealthRecords data into the DataGridView
    }
}
