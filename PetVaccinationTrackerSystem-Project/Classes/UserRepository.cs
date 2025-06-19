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
    // UserRepository class implements IUserRepository to handle user data operations such as getting the list from the database and then returning the User Model that exists.
    public class UserRepository : IUserRepository
    {
        private readonly ModelContext _context;

        // Constructor that takes a ModelContext to interact with the database
        public UserRepository(ModelContext context)
        {
            _context = context;
        }


        // Returns the User Model if the username and password match, otherwise returns null
        public User GetByEmail(string email)
        {
            PasswordHelper passwordHelper = new PasswordHelper();


            // Check if the username and password match any user in the UserList
            var match = _context.UserList.FirstOrDefault(u => u.UserEmail == email);

            return match;
         
        }
    }
}
