using System;
using Microsoft.EntityFrameworkCore;
using PetVaccinationTrackerSystem_Project.Data;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace PetVaccinationTrackerSystem_Project
{
    public partial class TablePetProfile : UserControl
    {

        
        public TablePetProfile()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadComboBox()
        {
            cmbFilterSpecies.Items.Clear();
            cmbFilterSpecies.Items.AddRange(new object[]
            {
                "Pet Name",
                "Gender",
                "Species",
                "Breed",
                "Owner Name",
                "Owner Phone Number",
                "Pet ID",
                "User ID"
            });

            cmbFilterSpecies.SelectedIndex = 0;
        }

        public void LoadData()
        {
           

            using (var context = new ModelContext())
            {
                var petProfiles = context.PetList
                    .Select(p => new
                    {
                        p.UserID,
                        p.PetID,
                        p.PetName,
                        p.Gender,
                        p.Species,
                        p.Breed,
                        p.OwnerName,
                        p.OwnerPhoneNumber
                    })
                    .ToList();

                dgvPetProfile.DataSource = petProfiles;

                LoadComboBox();
            }
        }

        


        private void btnSearchPetProfile_Click(object sender, EventArgs e)
        {
            string[] formats = { "MM-dd-yyyy", "MM/dd/yyyy" };

            using (var context = new ModelContext())
            {
                string selectedFilter = cmbFilterSpecies.Text;
                string search = txtboxSearchPet.Text.Trim().ToLower();

                var query = context.PetList
                    .AsQueryable();


                if (!string.IsNullOrWhiteSpace(search))
                {

                    switch (selectedFilter)
                    {
                        case "Pet Name":
                            query = query.Where(q => q.PetName != null && q.PetName.ToLower().Contains(search));
                            break;
                        case "Gender":
                            query = query.Where(q => q.Gender != null && q.Gender.ToLower().Contains(search));
                            break;
                        case "Species":
                            query = query.Where(q => q.Species != null && q.Species.ToLower().Contains(search));
                            break;
                        case "Breed":
                            query = query.Where(q => q.Breed != null && q.Breed.ToLower().Contains(search));
                            break;
                        case "Owner Name":
                            query = query.Where(q => q.OwnerName != null && q.OwnerName.ToLower().Contains(search));
                            break;
                        case "Owner Phone Number":
                            if (long.TryParse(search, out long phoneNumber))
                            {
                                query = query.Where(q => q.OwnerPhoneNumber.ToString().Contains(phoneNumber.ToString()));
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid phone number.");
                            }
                            break;
                        case "Pet ID":
                            if (int.TryParse(search, out int petId))
                            {
                                query = query.Where(q => q.PetID.ToString().Contains(petId.ToString()));
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid Pet ID.");
                            }
                            break;
                        case "User ID":
                            if (int.TryParse(search, out int userId))
                            {
                                query = query.Where(q => q.UserID.ToString().Contains(userId.ToString()));
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid User ID.");
                            }
                            break;
                    }
                }

                var results = query
                    .Select(p => new
                    {
                        p.UserID,
                        p.PetID,
                        p.PetName,
                        p.Gender,
                        p.Species,
                        p.Breed,
                        p.OwnerName,
                        p.OwnerPhoneNumber
                    })
                    .ToList();
                dgvPetProfile.DataSource = results;

            }
        }

    }
}