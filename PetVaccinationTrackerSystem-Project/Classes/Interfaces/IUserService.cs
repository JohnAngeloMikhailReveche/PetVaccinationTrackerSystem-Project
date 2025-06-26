using PetVaccinationTrackerSystem_Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes.Interfaces
{
    public interface IUserService
    {
        void RegisterUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
        List<User> GetAllUser();
    }
}
