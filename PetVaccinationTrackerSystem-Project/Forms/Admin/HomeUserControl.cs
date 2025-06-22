using PetVaccinationTrackerSystem_Project.Data.ViewModels;
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

namespace PetVaccinationTrackerSystem_Project.Forms.Admin
{
    public partial class HomeUserControl : UserControl
    {

        public void LoadVeterinarianData()
        {
            using (var context = new ModelContext())
            {

                var vetData = context.UserList
                    .Include(v => v.Veterinarian) // Join the Veterinarian Table
                    .ThenInclude(c => c.Clinic) // Join the Clinic Table
                    .Select(v => new VeterinarianViewModel // Use a ViewModel to simplify the data binding
                    {
                        VetID = v.Veterinarian.VetID,
                        UserID = v.UserID,
                        FirstName = v.FirstName,
                        LastName = v.LastName,
                        UserEmail = v.UserEmail,
                        LicenseNumber = v.Veterinarian.LicenseNumber,
                        ClinicID = v.Veterinarian.ClinicID,
                        ClinicName = v.Veterinarian.Clinic.ClinicName // Include Clinic Name for display
                    })
                    .ToList();

                // Bind the data to the DataGridView
                dgvVetList.DataSource = vetData;


                // Adjust DataGridView Properties
                dgvVetList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvVetList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


                // Hide Unnecessary ID Columns
                dgvVetList.Columns["ClinicID"].Visible = false;
                dgvVetList.Columns["UserPassword"].Visible = false;

                // Altered the name of the column for readability
                dgvVetList.Columns["ClinicName"].HeaderText = "Clinic Assigned";
                dgvVetList.Columns["UserID"].HeaderText = "User ID";
                dgvVetList.Columns["VetID"].HeaderText = "Veterinarian ID";
                dgvVetList.Columns["LicenseNumber"].HeaderText = "License Number";
                dgvVetList.Columns["FirstName"].HeaderText = "First Name";
                dgvVetList.Columns["LastName"].HeaderText = "Last Name";
                dgvVetList.Columns["UserEmail"].HeaderText = "Email";

            }
        }

        public HomeUserControl()
        {
            InitializeComponent();

            LoadVeterinarianData();
            dgvVetList.ScrollBars = ScrollBars.Both;
        }

        private void dgvVetList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvVetList.CurrentRow?.DataBoundItem is VeterinarianViewModel selectedVet)
            {
                VetInfo vetInfoForm = new VetInfo(selectedVet);

                // Refresh the data after closing the form
                vetInfoForm.FormClosed += (s, args) => LoadVeterinarianData(); 

                vetInfoForm.ShowDialog();
            }
        }
    }
}
