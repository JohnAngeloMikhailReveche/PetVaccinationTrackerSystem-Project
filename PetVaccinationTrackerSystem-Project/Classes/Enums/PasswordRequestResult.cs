using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes.Enums
{
    public enum PasswordRequestResult
    {
        Success,
        AlreadyRequested,
        InvalidEmail,
        UserNotFound
    }
}
