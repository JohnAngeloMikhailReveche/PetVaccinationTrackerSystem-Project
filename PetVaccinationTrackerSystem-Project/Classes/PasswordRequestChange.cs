using PetVaccinationTrackerSystem_Project.Classes.Enums;
using PetVaccinationTrackerSystem_Project.Classes.Interfaces;
using PetVaccinationTrackerSystem_Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes
{

    public class PasswordRequestChange
    {

        private ModelContext _context;

        public PasswordRequestChange()
        {
            _context = new ModelContext();
        }

        public PasswordRequestResult RequestPasswordReset(string email)
        {
            if (!email.EndsWith("@vetclinic.com", StringComparison.OrdinalIgnoreCase) &&
                !email.EndsWith("@petownerclinic.com", StringComparison.OrdinalIgnoreCase))
            {
                return PasswordRequestResult.InvalidEmail;
            }

            var user = _context.UserList.FirstOrDefault(u => u.UserEmail == email);

            if (user == null)
                return PasswordRequestResult.UserNotFound;

            if (user.SentPasswordRequest == true)
                return PasswordRequestResult.AlreadyRequested;

            user.SentPasswordRequest = true;

            IUserService userService = new UserService();
            userService.UpdateUser(user);

            return PasswordRequestResult.Success;
        }

    }
}
