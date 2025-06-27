using PetVaccinationTrackerSystem_Project.Classes.Interfaces;
using PetVaccinationTrackerSystem_Project.Data;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes
{
    public class VetRegistrar : IEntityRegistrar
    {
        private readonly string _licenseNumber;
        private readonly int _clinicID;
        private int _registeredVetID;
        private readonly VetService _vet;

        public VetRegistrar(string licenseNumber, int clinicID)
        {
            
            _licenseNumber = licenseNumber; 
            _clinicID = clinicID;

            _vet = new VetService();
        }

        public bool ValidateFields()
        {
            return !string.IsNullOrEmpty(_licenseNumber);
        }

        public void Register()
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

        public int GetID()
        {
            return _registeredVetID;
        }

        public Dictionary<string, string> GetDetails()
        {
            return new Dictionary<string, string>
            {
                {"LicenseNumber", _licenseNumber},
                {"ClinicID", _clinicID.ToString() },
                {"VetID", _registeredVetID.ToString() }
            };

        }
    }
}
