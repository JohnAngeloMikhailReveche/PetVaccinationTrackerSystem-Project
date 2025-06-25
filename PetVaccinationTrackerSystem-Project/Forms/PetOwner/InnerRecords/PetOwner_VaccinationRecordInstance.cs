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

        public PetOwner_VaccinationRecordInstance(Pet inPetRef)
        {
            InitializeComponent();

            _selectedPet = inPetRef;

            // Renames the Window title to include the pet's name
            this.Text = _selectedPet.PetName + " - Vaccination History";
        }

        // Loading the PetHealthRecords data into the DataGridView
    }
}
