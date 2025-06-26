using PetVaccinationTrackerSystem_Project.Classes.Abstract;
using PetVaccinationTrackerSystem_Project.Data;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes.ActionHandlers
{
    public class DeleteAccountHandler : UserActionHandler
    {
        public override void HandleAction(User user, ModelContext context)
        {
            // If the user is a Pet Owner Role
            if(user.UserRole == "PetOwner")
            {
                // Remove all pets
                var userPets = context.PetList
                                  .Where(p => p.UserID == user.UserID)
                                  .ToList();
                if(userPets.Any())
                {
                    context.PetList.RemoveRange(userPets);
                }
            }

            // If the User is a Vet Role
            if(user.VetID != null)
            {
                var vet = context.VeterinarianList
                    .Where(v => v.VetID == user.VetID)
                    .ToList();
                if(vet.Any())
                {
                    context.VeterinarianList.RemoveRange(vet);
                }
            }

            // Remove the User and Save Changes to DB
            context.UserList.Remove(user);
            context.SaveChanges();
        }
    }
}
