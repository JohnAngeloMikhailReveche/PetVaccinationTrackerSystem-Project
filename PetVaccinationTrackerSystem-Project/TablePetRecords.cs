using Microsoft.EntityFrameworkCore;
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

namespace PetVaccinationTrackerSystem_Project
{
    public partial class TablePetRecords : UserControl
    {

        private User _currentUser;

        private void LoadComboBox()
        {
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add("Pet Name");
            cmbFilter.Items.Add("Gender");
            cmbFilter.Items.Add("Species");
            cmbFilter.Items.Add("Breed");
            cmbFilter.Items.Add("Vaccine");
            cmbFilter.Items.Add("Administered By");
            cmbFilter.Items.Add("Date Administered");
            cmbFilter.Items.Add("Next Due Date");
            cmbFilter.Items.Add("Batch No.");
            cmbFilter.Items.Add("Pet ID");
            cmbFilter.SelectedIndex = 0;
        }

        public TablePetRecords()
        {
            InitializeComponent();
        }

        public void LoadData()
        {

            if (_currentUser == null)
            {
                return;
            }

            using (var context = new ModelContext())
            {
                var petRecords = context.PetHealthRecordsList
                    .Include(p => p.Vet)
                    .Where(p => p.Vet != null && p.Vet.ClinicID == _currentUser.Veterinarian.ClinicID)
                    .Select(p => new
                    {
                        p.RecordID,
                        p.PetID,
                        p.PetName,
                        p.Gender,
                        p.Species,
                        p.Breed,
                        p.VaccineName,
                        p.AdministeredBy,
                        DateAdministered = p.DateAdministered.ToString("MM-dd-yyyy"),
                        NextDueDate = p.NextDueDate.ToString("MM-dd-yyyy"),
                        p.BatchNo
                    })
                    .ToList();

                dgvPetRecords.DataSource = petRecords;

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

                LoadComboBox();
            }
        }

        public void RefreshCurrentUser(User inUserRef)
        {
            _currentUser = inUserRef;
        }

        private void TablePetRecords_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearchPetRecord_Click(object sender, EventArgs e)
        {
            string[] formats = { "MM-dd-yyyy", "MM/dd/yyyy" };

            using (var context = new ModelContext())
            {
                string selectedFilter = cmbFilter.Text;
                string search = txtSearch.Text.Trim().ToLower();

                var query = context.PetHealthRecordsList
                    .Include(p => p.Vet)
                    .Where(p => p.Vet != null && p.Vet.ClinicID == _currentUser.Veterinarian.ClinicID)
                    .AsQueryable();


                if (!string.IsNullOrWhiteSpace(search))
                {
                    
                    switch (selectedFilter)
                    {
                        case "Pet Name":
                            query = query.Where(q => q.PetName != null && q.PetName.ToLower().Contains(search));
                            break;
                        case "Gender":
                            query = query.Where(q => q.Gender != null && q.Gender.ToLower().Contains(search));
                            break;
                        case "Species":
                            query = query.Where(q => q.Species != null && q.Species.ToLower().Contains(search));
                            break;
                        case "Breed":
                            query = query.Where(q => q.Breed != null && q.Breed.ToLower().Contains(search));
                            break;
                        case "Vaccine":
                            query = query.Where(q => q.VaccineName != null && q.VaccineName.ToLower().Contains(search));
                            break;
                        case "Administered By":
                            query = query.Where(q => q.AdministeredBy != null && q.AdministeredBy.ToLower().Contains(search));
                            break;
                        case "Date Administered":
                            if (DateTime.TryParseExact(search, formats, null, System.Globalization.DateTimeStyles.None, out DateTime searchAdminDate))
                            {
                                query = query.Where(q => q.DateAdministered.Date == searchAdminDate.Date);
                            }
                            break;

                        case "Next Due Date":
                            if (DateTime.TryParseExact(search, formats, null, System.Globalization.DateTimeStyles.None, out DateTime searchDueDate))
                            {
                                query = query.Where(q => q.NextDueDate.Date == searchDueDate.Date);
                            }
                            break;
                        case "Batch No.":
                            query = query.Where(q => q.BatchNo != null && q.BatchNo.ToLower().Contains(search));
                            break;
                        case "Pet ID":
                            query = query.Where(q => q.PetID.ToString().ToLower().Contains(search));
                            break;
                    }
                }

                var results = query
                    .Select(p => new
                    {
                        p.RecordID,
                        p.PetID,
                        p.PetName,
                        p.Gender,
                        p.Species,
                        p.Breed,
                        p.VaccineName,
                        p.AdministeredBy,
                        DateAdministered = p.DateAdministered.ToString("MM-dd-yyyy"),
                        NextDueDate = p.NextDueDate.ToString("MM-dd-yyyy"),
                        p.BatchNo
                    })
                    .ToList();
                dgvPetRecords.DataSource = results;

            }
        }
















    }
}
