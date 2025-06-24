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

        public PetOwner_PetProfileInstance(Pet selectedPet, User? currentUser)
        {
            InitializeComponent();
            _selectedPet = selectedPet;
            _currentUser = currentUser;
        }
    }
}
