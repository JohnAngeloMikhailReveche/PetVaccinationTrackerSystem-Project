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
    public class ClinicService : IClinicService
    {

        private readonly ModelContext _context;

        public ClinicService()
        {
            _context = new ModelContext();
        }

        public void RegisterClinic(Clinic clinic)
        {
            _context.ClinicList.Add(clinic);
            _context.SaveChanges();
        }

        public void UpdateClinic(Clinic clinic)
        {
            _context.ClinicList.Update(clinic);
            _context.SaveChanges();
        }

        public void DeleteClinic(Clinic clinic)
        {
            if (clinic != null)
            {
                _context.ClinicList.Remove(clinic);
                _context.SaveChanges();
            }
        }

        public List<Clinic> GetAllClinics()
        {
            return _context.ClinicList.ToList();
        }


    }
}
