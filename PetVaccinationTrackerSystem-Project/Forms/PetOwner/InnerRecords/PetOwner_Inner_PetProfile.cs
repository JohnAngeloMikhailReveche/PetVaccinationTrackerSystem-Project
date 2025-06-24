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
    public partial class PetOwner_Inner_PetProfile : UserControl
    {
        private Pet? _currentPet;

        public void UnloadData()
        {
            if (_currentPet != null)
            {
                _currentPet = null;
            }

        }

        public void LoadInData(Pet inPetReference)
        {
            _currentPet = inPetReference;
            LoadData();
        }

        public void LoadData()
        {
            if (_currentPet != null)
            {
                // Assuming you have labels or textboxes to display pet details
                txtPetName.Text = _currentPet.PetName;
                txtOwnerName.Text = _currentPet.OwnerName;
                txtboxSpecies.Text = _currentPet.Species;
                txtBreed.Text = _currentPet.Breed;
                txtboxDOB.Text = _currentPet.DateOfBirth.ToShortDateString();
                txtColorMarkings.Text = _currentPet.ColorsAndMarkings;
                txtcontact.Text = _currentPet.OwnerPhoneNumber.ToString();
                txtNotes.Text = _currentPet.Notes;
                // Load image if available
                if (!string.IsNullOrEmpty(_currentPet.ImageRL))
                {
                    petpicture.ImageLocation = _currentPet.ImageRL;
                }
            }
            else
            {
                MessageBox.Show("No pet data available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public PetOwner_Inner_PetProfile()
        {
            InitializeComponent();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UnloadData();
            this.Hide();
            this.SendToBack();
        }
    }
}
