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
    public class VetService : IVetService
    {

        private ModelContext _context;

        public VetService() 
        {
            _context = new ModelContext();
        }

        public void Delete(Veterinarian vet)
        {
            if (vet != null)
            {
                _context.VeterinarianList.Remove(vet);
                _context.SaveChanges();
            }
        }

        public List<Veterinarian> GetAll()
        {
            return _context.VeterinarianList.ToList();
        }

        public void Register(Veterinarian vet)
        {
            _context.VeterinarianList.Add(vet);
            _context.SaveChanges();

        }

        public void Update(Veterinarian vet)
        {
            _context.VeterinarianList.Update(vet);
            _context.SaveChanges();
        }
    }
}
