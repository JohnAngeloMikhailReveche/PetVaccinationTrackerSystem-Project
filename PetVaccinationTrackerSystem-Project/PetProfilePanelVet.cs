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
    public partial class petProfilePanelVet : UserControl
    {
        public petProfilePanelVet()
        {
            InitializeComponent();
        }

        private void PetProfilePanelVButtonSave_Click(object sender, EventArgs e)
        {

        }

        private void PetProfilePanelVButtonSave_Click_1(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(txtPetName.Text))
                errorMessage += "Pet name is required.\n";

            if (string.IsNullOrWhiteSpace(cmbSpecies.Text))
                errorMessage += "Species must be selected.\n";

            if (string.IsNullOrWhiteSpace(txtBreed.Text))
                errorMessage += "Breed is required.\n";

            if (string.IsNullOrWhiteSpace(cmbGender.Text))
                errorMessage += "Please select a gender.\n";

            if (cmbDOB.Value.Date > DateTime.Today)
                errorMessage += "Date of Birth cannot be in the future.\n";

            if (string.IsNullOrWhiteSpace(txtColorMarkings.Text))
                errorMessage += "Color and markings are required.\n";

            if (string.IsNullOrWhiteSpace(txtOwnerName.Text))
                errorMessage += "Owner's name is required.\n";

            if (!int.TryParse(txtcontact.Text, out int phone))
                errorMessage += "Owner phone number must be numeric.\n";

            if (petpicture.Image == null)
                errorMessage += "A pet image is required.\n";

            // Stop if any errors were found
            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pet = new Pet
            {
                PetName = txtPetName.Text,
                Species = cmbSpecies.Text,
                Breed = txtBreed.Text,
                Gender = cmbGender.Text,
                DateOfBirth = cmbDOB.Value,
                ColorsAndMarkings = txtColorMarkings.Text,
                OwnerName = txtOwnerName.Text,
                OwnerPhoneNumber = int.Parse(txtcontact.Text),
                Notes = txtNotes.Text,
                ImageRL = petpicture.Image != null ? Convert.ToBase64String((byte[])new ImageConverter().ConvertTo(petpicture.Image, typeof(byte[]))) : null,
                UserID = 2
                // UserID = 2 (ito yung papalitan ng userID if ever na di pa nakakapagreate ng user)

            };

            using (var context = new ModelContext())
            {
                context.PetList.Add(pet);
                context.SaveChanges();

                int newPetID = pet.PetID;
                MessageBox.Show("Pet saved successfully with ID: " + newPetID);

            }

        }

        private void PetProfilePanelVButtonUpdatePB_Click(object sender, EventArgs e)
        {

            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                petpicture.Image = Image.FromFile(opf.FileName);
                petpicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("No image selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
