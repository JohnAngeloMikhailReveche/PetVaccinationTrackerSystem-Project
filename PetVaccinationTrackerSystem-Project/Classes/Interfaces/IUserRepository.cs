using PetVaccinationTrackerSystem_Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes.Interfaces
{
    // This interface defines the contract for user repository operations
    public interface IUserRepository
    {
        // Returns the User Model if the username and password match, otherwise returns null
        User GetByEmail(string username);
    }
}
