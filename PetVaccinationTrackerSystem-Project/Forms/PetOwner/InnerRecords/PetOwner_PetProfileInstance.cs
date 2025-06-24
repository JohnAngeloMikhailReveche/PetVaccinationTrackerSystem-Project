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
    public partial class PetOwner_PetProfileInstance : Form
    {
        private Pet _selectedPet;
        private User? _currentUser;

        // Converts a Base64 string to an Image object
        private Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var memoryStream = new MemoryStream(imageBytes))
            {
                return Image.FromStream(memoryStream);
            }
        }

        private void SetAllTextboxToReadOnly()
        {
            // Set all textboxes to read-only
            txtPetName.ReadOnly = true;
            txtboxPetID.ReadOnly = true;
            txtboxSpecies.ReadOnly = true;
            txtboxGender.ReadOnly = true;
            txtboxDOB.ReadOnly = true;
            txtBreed.ReadOnly = true;
            txtColorMarkings.ReadOnly = true;
            txtOwnerName.ReadOnly = true;
            txtcontact.ReadOnly = true;
            txtNotes.ReadOnly = true;
        }

        private void LoadDataToForm()
        {

            if (_selectedPet.ImageRL != null)
            {
                string base64Image = _selectedPet.ImageRL;
                Image loadedImage = Base64ToImage(base64Image);
                petpicture.Image = loadedImage;
            }

            // Load the pet's data into the form controls
            txtPetName.Text = _selectedPet.PetName;
            txtboxPetID.Text = _selectedPet.PetID.ToString();
            txtboxSpecies.Text = _selectedPet.Species;
            txtboxGender.Text = _selectedPet.Gender;
            txtboxDOB.Text = _selectedPet.DateOfBirth.ToString("MM-dd-yyyy");
            txtBreed.Text = _selectedPet.Breed;
            txtColorMarkings.Text = _selectedPet.ColorsAndMarkings;
            txtOwnerName.Text = _selectedPet.OwnerName;
            txtcontact.Text = _selectedPet.OwnerPhoneNumber.ToString();
            txtNotes.Text = _selectedPet.Notes;
        }
        public PetOwner_PetProfileInstance(Pet selectedPet, User? currentUser)
        {
            InitializeComponent();
            _selectedPet = selectedPet;
            _currentUser = currentUser;
        }

        private void PetOwner_PetProfileInstance_Load(object sender, EventArgs e)
        {
            // Safety check to ensure that a pet is selected and a user is logged in
            if (_selectedPet == null && _currentUser == null)
            {
                MessageBox.Show("No pet selected or user not logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Load the pet's data into the form controls
            SetAllTextboxToReadOnly();
            LoadDataToForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form to return to the previous one
        }
    }
}
