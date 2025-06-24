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
                    .Where(v => v.Veterinarian != null && v.Veterinarian.Clinic != null) // Prevent null references filter respective users
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

        public void LoadClinicData()
        {
            using (var context = new ModelContext())
            {

                dgvClinicList.DataSource = context.ClinicList.ToList();

                // If we want to hide a column then:
                // dgvClinicList.Columns["ClinicID"].Visible = false;


                // Adjust DataGridView Properties
                dgvClinicList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvClinicList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                dgvClinicList.Columns["ClinicID"].HeaderText = "Clinic ID";
                dgvClinicList.Columns["ClinicName"].HeaderText = "Clinic Name";
                dgvClinicList.Columns["ZipCode"].HeaderText = "Zip Code";

            }
        }


        public void LoadComboBoxWithData()
        {
            // For Filter Vet Combo Box
            cmbboxFilterVet.Items.Add("All");
            cmbboxFilterVet.Items.Add("First Name");
            cmbboxFilterVet.Items.Add("Last Name");
            cmbboxFilterVet.Items.Add("License Number");
            cmbboxFilterVet.Items.Add("Assigned Clinic");
            cmbboxFilterVet.SelectedIndex = 0;

            // For Filter Clinic Combo Box
            cmbboxFilterClinic.Items.Add("All");
            cmbboxFilterClinic.Items.Add("Street");
            cmbboxFilterClinic.Items.Add("City");
            cmbboxFilterClinic.Items.Add("State");
            cmbboxFilterClinic.SelectedIndex = 0;
        }



        public HomeUserControl()
        {
            InitializeComponent();

            // Load the data when the UserControl is initialized
            LoadVeterinarianData();
            LoadClinicData();
            LoadComboBoxWithData();
            dgvVetList.ScrollBars = ScrollBars.Both;

        }

        private void HomeUserControl_Load(object sender, EventArgs e)
        {
        }

        private void dgvVetList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvVetList.CurrentRow?.DataBoundItem is VeterinarianViewModel selectedVet)
            {
                VetInfo vetInfoForm = new VetInfo(selectedVet);

                // Refresh the data after closing the form
                vetInfoForm.FormClosed += (s, args) =>
                {
                    LoadVeterinarianData();
                };

                vetInfoForm.ShowDialog();
            }
        }

        private void btnSearchVet_Click(object sender, EventArgs e)
        {
            using (var context = new ModelContext())
            {
                // Read and Store in the values
                string selectedFilterOpt = cmbboxFilterVet.SelectedItem?.ToString();
                string txtboxSearchText = txtboxSearchVet.Text.Trim();

                // Query
                var query = context.UserList
                    .Include(v => v.Veterinarian)
                    .ThenInclude(c => c.Clinic)
                    .Where(v => v.Veterinarian != null && v.Veterinarian.Clinic != null) // Prevent null references and filter respective users
                    .AsQueryable();


                if (!string.IsNullOrWhiteSpace(txtboxSearchText))
                {
                    switch (selectedFilterOpt)
                    {
                        case "First Name":
                            query = query.Where(v => v.FirstName.Contains(txtboxSearchText));
                            break;
                        case "Last Name":
                            query = query.Where(v => v.LastName.Contains(txtboxSearchText));
                            break;
                        case "License Number":
                            query = query.Where(v => v.Veterinarian.LicenseNumber.Contains(txtboxSearchText));
                            break;
                        case "Assigned Clinic":
                            query = query.Where(v => v.Veterinarian.Clinic.ClinicName.Contains(txtboxSearchText));
                            break;
                        case "All":
                            query = query.Where(
                                v => v.FirstName.Contains(txtboxSearchText) ||
                                     v.LastName.Contains(txtboxSearchText) ||
                                     v.Veterinarian.LicenseNumber.Contains(txtboxSearchText) ||
                                     v.Veterinarian.Clinic.ClinicName.Contains(txtboxSearchText)
                                     );
                            break;

                        default:
                            MessageBox.Show("Please select a valid filter option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                }

                // Select the data to display in the DataGridView
                var results = query
                        .Select(v => new VeterinarianViewModel
                        {
                            VetID = v.Veterinarian.VetID,
                            UserID = v.UserID,
                            FirstName = v.FirstName,
                            LastName = v.LastName,
                            UserEmail = v.UserEmail,
                            LicenseNumber = v.Veterinarian.LicenseNumber,
                            ClinicID = v.Veterinarian.ClinicID,
                            ClinicName = v.Veterinarian.Clinic.ClinicName
                        })
                        .ToList();

                dgvVetList.DataSource = results;
            }

        }

        private void btnSearchClinic_Click(object sender, EventArgs e)
        {
            using (var context = new ModelContext())
            {
                // Read and Store in the values
                string selectedFilterClinicOpt = cmbboxFilterClinic.SelectedItem?.ToString();
                string txtboxSearchClinicText = txtboxSearchClinic.Text.Trim();

                // Query
                var query = context.ClinicList.AsQueryable();


                if (!string.IsNullOrWhiteSpace(txtboxSearchClinicText))
                {
                    switch (selectedFilterClinicOpt)
                    {
                        case "Street":
                            query = query.Where(v => v.Street.Contains(txtboxSearchClinicText));
                            break;
                        case "City":
                            query = query.Where(v => v.City.Contains(txtboxSearchClinicText));
                            break;
                        case "State":
                            query = query.Where(v => v.State.Contains(txtboxSearchClinicText));
                            break;
                        case "All":
                            query = query.Where(
                                v => v.Street.Contains(txtboxSearchClinicText) ||
                                     v.City.Contains(txtboxSearchClinicText) ||
                                     v.State.Contains(txtboxSearchClinicText)
                                     );
                            break;

                        default:
                            MessageBox.Show("Please select a valid filter option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                }

                // Select the data to display in the DataGridView
                var results = query.ToList();
                dgvClinicList.DataSource = results;
            }
        }

        private void dgvClinicList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvClinicList.CurrentRow?.DataBoundItem is Clinic selectedClinic)
            {
                
                // Pass the reference to the Form
                ClinicInfo clinicInfoForm = new ClinicInfo(selectedClinic);

                // Refresh the data after closing the form
                clinicInfoForm.FormClosed += (s, args) =>
                {
                    LoadClinicData();
                };

                clinicInfoForm.ShowDialog();
            }
        }
    }
}
