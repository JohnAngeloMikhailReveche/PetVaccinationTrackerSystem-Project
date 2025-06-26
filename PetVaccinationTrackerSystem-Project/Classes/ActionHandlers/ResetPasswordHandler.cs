using PetVaccinationTrackerSystem_Project.Classes.Interfaces;
using PetVaccinationTrackerSystem_Project.Data;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes.ActionHandlers
{
    public class ResetPasswordHandler : IUserActionHandler
    {
        public void HandleAction(User user, ModelContext context)
        {
            PasswordHelper helper = new PasswordHelper();
            user.UserPassword = helper.HashPassword("default");

            // Update the User to the Database
            user.SentPasswordRequest = false;

            context.UserList.Update(user);
            context.SaveChanges();
        }
    }
}
