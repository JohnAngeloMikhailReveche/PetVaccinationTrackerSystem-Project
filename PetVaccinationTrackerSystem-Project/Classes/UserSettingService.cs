using PetVaccinationTrackerSystem_Project.Classes.Interfaces;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes
{
    public class UserSettingService
    {

        private IUserService _userService;

        public UserSettingService()
        {
            _userService = new UserService();
        }

        public bool ChangePassword(User user, string currentPassword, string newPassword, out string errorMessage)
        {
            var passHelper = new PasswordHelper();

            if(!passHelper.VerifyPassword(user.UserPassword, currentPassword))
            {
                errorMessage = "The current password is incorrect.";
                return false;
            }

            if (currentPassword == newPassword)
            {
                errorMessage = "The new password cannot be the same as the current password";
                return false;
            }

            string hashedPassword = passHelper.HashPassword(newPassword);
            user.UserPassword = hashedPassword;

            _userService.UpdateUser(user);

            errorMessage = string.Empty;
            return true;
        }

        public void UpdateName(User user, string fName, string lName)
        {
            user.FirstName = fName.Trim();
            user.LastName = lName.Trim();

            _userService.UpdateUser(user);
        }

        public void ToggleAccountDeletionReq(User user, bool requestDelete)
        {
            user.SentAccountDeletion = requestDelete;

            _userService.UpdateUser(user);
        }


    }
}
