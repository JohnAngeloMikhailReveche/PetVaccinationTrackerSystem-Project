using PetVaccinationTrackerSystem_Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes.Interfaces
{
    public interface IAuthServices
    {
        // Returns the User Model if the login is successful, otherwise returns null
        User Login(string username, string password);
    }
}
