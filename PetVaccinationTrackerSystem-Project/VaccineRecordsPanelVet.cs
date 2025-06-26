using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
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
using static PetVaccinationTrackerSystem_Project.Forms.Auth.AuthForm;

namespace PetVaccinationTrackerSystem_Project
{
    public partial class VaccineRecordsPanelVet : UserControl
    {
        public VaccineRecordsPanelVet()
        {
            InitializeComponent();
        }

        private void dgvPetInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Create DataTable
            DataTable petTable = new DataTable();
            petTable.Columns.Add("Field");
            petTable.Columns.Add("Value");

            petTable.Rows.Add("Pet Name", "");
            petTable.Rows.Add("Species", "");
            petTable.Rows.Add("Breed", "");
            petTable.Rows.Add("Gender", "");
            petTable.Rows.Add("Date of Birth", "");

            // ComboBox for Gender
            DataGridViewComboBoxCell genderCombo = new DataGridViewComboBoxCell();
            genderCombo.Items.AddRange("Male", "Female", "Other");

            // DatePicker for Date of Birth
            DateTimePicker dtp = new DateTimePicker();
            dtp.Format = DateTimePickerFormat.Short;
            dtp.Visible = false;
            panel1.Controls.Add(dtp);

            {
                if (e.RowIndex == 4 && e.ColumnIndex == 1)
                {
                    dtp.Visible = true;

                    dtp.ValueChanged += (sender2, ev) =>
                    {
                    };
                }
                else
                {
                    dtp.Visible = false;
                }
            }
            ;
        }





        private void btnAddRecord_Click_1(object sender, EventArgs e)
        {
            // Validate inputs before savingAdd commentMore actions
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(cmbVaccineName.Text))
                errorMessage += "Vaccine Name is required.\n";

            DateTime today = DateTime.Today;

            if (dtpDateGiven.Value.Date < today)
                errorMessage += "Date Administered cannot be earlier than today.\n";

            if (dtpNextDue.Value.Date < today)
                errorMessage += "Next Due Date cannot be earlier than today.\n";

            if (string.IsNullOrWhiteSpace(txtBatchNo.Text))
                errorMessage += "Batch Number is required.\n";

            if (string.IsNullOrWhiteSpace(txtAdministeredBy.Text))
                errorMessage += "Administered By is required.\n";

            if (string.IsNullOrWhiteSpace(txtPetName.Text))
                errorMessage += "Pet Name is required.\n";

            if (string.IsNullOrWhiteSpace(txtSpecies.Text))
                errorMessage += "Species is required.\n";

            if (string.IsNullOrWhiteSpace(txtBreed.Text))
                errorMessage += "Breed is required.\n";

            if (string.IsNullOrWhiteSpace(txtGender.Text))
                errorMessage += "Gender is required.\n";

            if (string.IsNullOrWhiteSpace(txtPetID.Text))
                errorMessage += "Pet ID is required.\n";

            else if (!int.TryParse(txtPetID.Text, out _))
            {
                errorMessage += "Pet ID must be a valid number.\n";
            }

            bool petIdExists = false;
            using (SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=PetVaccinationTrackerSystemDB;Trusted_Connection=True;Encrypt=False;"))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM PetList WHERE PetID = @PetID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PetID", txtPetID.Text.Trim());

                    int count = (int)cmd.ExecuteScalar();
                    petIdExists = count > 0;
                }
            }

            if (!petIdExists)
            {
                errorMessage += "Entered Pet ID does not exist in the system.\n";
            }



            // Stop execution if there are missing fields
            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new ModelContext())
            {

                var PethealthRecord = new PetHealthRecords
                {

                    PetID = int.Parse(txtPetID.Text),
                    VetID = SessionData.CurrentVetID.Value,
                    PetName = txtPetName.Text,
                    Gender = txtGender.Text,
                    Species = txtSpecies.Text,
                    Breed = txtBreed.Text,
                    VaccineName = cmbVaccineName.Text,
                    DateAdministered = dtpDateGiven.Value,
                    NextDueDate = dtpNextDue.Value,
                    Notes = txtNotes.Text,
                    BatchNo = txtBatchNo.Text,
                    AdministeredBy = txtAdministeredBy.Text

                };

                context.PetHealthRecordsList.Add(PethealthRecord);
                context.SaveChanges();

                MessageBox.Show("Vaccination record and Pet Health Records saved successfully!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Reset all textboxesAdd commentMore actions

            cmbVaccineName.SelectedIndex = -1; // Clears selection in ComboBox
            txtBatchNo.Text = string.Empty;
            txtAdministeredBy.Text = string.Empty;
            txtNotes.Text = string.Empty;
            txtPetName.Text = string.Empty;
            txtSpecies.Text = string.Empty;
            txtBreed.Text = string.Empty;
            txtGender.Text = string.Empty;
            txtPetID.Text = string.Empty;


            // Reset date pickers to today's date
            dtpDateGiven.Value = DateTime.Now;
            dtpNextDue.Value = DateTime.Now;

            MessageBox.Show("All fields have been cleared.", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}


