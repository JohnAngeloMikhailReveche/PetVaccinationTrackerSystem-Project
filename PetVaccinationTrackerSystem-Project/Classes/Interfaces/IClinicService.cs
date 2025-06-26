using PetVaccinationTrackerSystem_Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes.Interfaces
{
    public interface IClinicService
    {
        void RegisterClinic(Clinic clinic);
        void UpdateClinic(Clinic clinic);
        void DeleteClinic(Clinic clinic);
        List<Clinic> GetAllClinics();
    }
}
