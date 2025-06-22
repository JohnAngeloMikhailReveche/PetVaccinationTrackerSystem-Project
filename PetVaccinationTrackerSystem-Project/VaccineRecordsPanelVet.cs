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

            dgvPetInfo.DataSource = petTable;

            // ComboBox for Gender
            DataGridViewComboBoxCell genderCombo = new DataGridViewComboBoxCell();
            genderCombo.Items.AddRange("Male", "Female", "Other");
            dgvPetInfo.Rows[3].Cells[1] = genderCombo;

            // DatePicker for Date of Birth
            DateTimePicker dtp = new DateTimePicker();
            dtp.Format = DateTimePickerFormat.Short;
            dtp.Visible = false;
            dgvPetInfo.Controls.Add(dtp);

            dgvPetInfo.CellClick += (s, e) =>
            {
                if (e.RowIndex == 4 && e.ColumnIndex == 1)
                {
                    Rectangle rect = dgvPetInfo.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    dtp.Location = new Point(rect.X, rect.Y);
                    dtp.Size = new Size(rect.Width, rect.Height);
                    dtp.Visible = true;

                    dtp.ValueChanged += (sender2, ev) =>
                    {
                        dgvPetInfo.Rows[4].Cells[1].Value = dtp.Value.ToShortDateString();
                    };
                }
                else
                {
                    dtp.Visible = false;
                }
            };
        }
    }
}



