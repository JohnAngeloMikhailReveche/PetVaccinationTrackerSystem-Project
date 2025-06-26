using PetVaccinationTrackerSystem_Project.Classes.Interfaces;
using PetVaccinationTrackerSystem_Project.Data;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace PetVaccinationTrackerSystem_Project.Classes
{
    public class ClinicRegistrar : IEntityRegistrar
    {
        private readonly string _name, _street, _city, _state, _zip;
        private readonly ClinicService _clinicService;
        private int _clinicID;

        public ClinicRegistrar(string name, string street, string city, string state, string zip)
        {
            _name = name;
            _street = street;
            _city = city;
            _state = state;
            _zip = zip;

            _clinicService = new ClinicService();
        }

        public bool ValidateFields()
        {
            return !string.IsNullOrWhiteSpace(_name) ||
                !string.IsNullOrWhiteSpace(_street) ||
                !string.IsNullOrEmpty(_city) ||
                !string.IsNullOrEmpty(_state) ||
                !string.IsNullOrEmpty(_zip);
        }

        public void Register()
        {
            using(var context = new ModelContext())
            {
                Clinic clinic = new Clinic
                {
                    ClinicName = _name,
                    Street = _street,
                    City = _city,
                    State = _state,
                    ZipCode = _zip
                };

                _clinicService.RegisterClinic(clinic);

                _clinicID = clinic.ClinicID;
            }
        }

        public int GetID()
        {
            return _clinicID;
        }
    }
}
