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
    public partial class RegisteredClinicPanel : UserControl, ILoadData
    {
        public void LoadData()
        {

            if(!string.IsNullOrEmpty(txtboxSearchClinic.Text))
            {
                txtboxSearchClinic.Text = "";
            }

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
            // For Filter Clinic Combo Box
            cmbboxFilterClinic.Items.Add("All");
            cmbboxFilterClinic.Items.Add("Street");
            cmbboxFilterClinic.Items.Add("City");
            cmbboxFilterClinic.Items.Add("State");
            cmbboxFilterClinic.SelectedIndex = 0;
        }

        public RegisteredClinicPanel()
        {
            InitializeComponent();

            LoadData();
            LoadComboBoxWithData();
            dgvClinicList.ScrollBars = ScrollBars.Both;
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
                    LoadData();
                };

                clinicInfoForm.ShowDialog();
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
    }
}
