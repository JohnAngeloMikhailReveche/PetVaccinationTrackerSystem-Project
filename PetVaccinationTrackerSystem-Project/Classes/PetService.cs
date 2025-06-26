using Microsoft.EntityFrameworkCore;
using PetVaccinationTrackerSystem_Project.Data;
using PetVaccinationTrackerSystem_Project.Data.Entities;
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

        public List<object> GetVaccinationRecords(int petId)
        {
            using (var context = new ModelContext())
            {
                return context.PetHealthRecordsList
                    .Where(p => p.PetID == petId)
                    .Select(p => new
                    {
                        p.RecordID,
                        p.PetID,
                        p.PetName,
                        p.Gender,
                        p.Species,
                        p.Breed,
                        p.VaccineName,
                        p.AdministeredBy,
                        DateAdministered = p.DateAdministered.ToString("MM-dd-yyyy"),
                        NextDueDate = p.NextDueDate.ToString("MM-dd-yyyy"),
                        p.BatchNo
                    }).ToList<object>();
            }
                
        }
    }
}
