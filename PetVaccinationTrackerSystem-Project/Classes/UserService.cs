using PetVaccinationTrackerSystem_Project.Classes.Interfaces;
using PetVaccinationTrackerSystem_Project.Data;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes
{
    public class UserService : IUserService
    {

        private ModelContext _context;

        public UserService()
        { 
            _context = new ModelContext();
        }

        public void DeleteUser(User user)
        {
            if (user != null)
            {
                _context.UserList.Remove(user);
                _context.SaveChanges();
            }

        }

        public List<User> GetAllUser()
        {
            return _context.UserList.ToList();
        }

        public void RegisterUser(User user)
        {
            _context.UserList.Add(user);
            _context.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _context.UserList.Update(user);
            _context.SaveChanges();
        }
    }
}
