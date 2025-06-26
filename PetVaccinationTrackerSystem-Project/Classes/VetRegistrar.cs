using PetVaccinationTrackerSystem_Project.Classes.Abstract;
using PetVaccinationTrackerSystem_Project.Data;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes
{
    public class VetRegistrar : EntityRegistrar
    {
        private readonly string _licenseNumber;
        private readonly int _clinicID;
        private readonly VetService _vet;
        private int _registeredVetID;

        public VetRegistrar(string licenseNumber, int clinicID)
        {
            
            _licenseNumber = licenseNumber; 
            _clinicID = clinicID;

            _vet = new VetService();
        }

        public override bool ValidateFields()
        {
            return !string.IsNullOrEmpty(_licenseNumber);
        }

        public override void Register()
        {
            using (var context = new ModelContext())
            {
                Veterinarian vet = new Veterinarian
                {
                    LicenseNumber = _licenseNumber,
                    ClinicID = _clinicID
                };

                _vet.Register(vet);

                _registeredVetID = vet.VetID;
            }
        }

        public override int GetID()
        {
            return _registeredVetID;
        }
    }
}
