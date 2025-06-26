using PetVaccinationTrackerSystem_Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes.Interfaces
{
    public interface IVetService
    {
        void Register(Veterinarian vet);
        void Update(Veterinarian vet);
        void Delete(Veterinarian vet);
        List<Veterinarian> GetAll();
    }
}
