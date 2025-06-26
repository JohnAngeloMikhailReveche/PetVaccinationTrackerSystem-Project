using Microsoft.EntityFrameworkCore;
using PetVaccinationTrackerSystem_Project.Data;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using PetVaccinationTrackerSystem_Project.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes
{
    public class PetService
    {
        public List<Pet> GetPetsForUser(int userId)
        {
            using(var context = new ModelContext())
            {
                return context.PetList
                .Include(p => p.User)
                .Where(p => p.User.UserID == userId)
                .ToList();
            }
        }

        public List<VaccinationRecords> GetVaccinationRecords(int petId)
        {
            using (var context = new ModelContext())
            {
                return context.PetHealthRecordsList
                    .Where(p => p.PetID == petId)
                    .Select(p => new VaccinationRecords
                    {
                        RecordID = p.RecordID,
                        PetID = p.PetID,
                        PetName = p.PetName,
                        Gender = p.Gender,
                        Species = p.Species,
                        Breed = p.Breed,
                        VaccineName = p.VaccineName,
                        AdministeredBy = p.AdministeredBy,
                        DateAdministered = p.DateAdministered.ToString("MM-dd-yyyy"),
                        NextDueDate = p.NextDueDate.ToString("MM-dd-yyyy"),
                        BatchNo = p.BatchNo
                    })
                    .ToList();
            }

        }
    }
}
