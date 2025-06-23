using Microsoft.EntityFrameworkCore;
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

        private bool IsVetClinicEmail(string email)
        {
            // Check if the email ends with "@vetclinic.com"
            if (email.EndsWith("@vetclinic.com", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            return false;
        }

        // Constructor that takes a ModelContext to interact with the database
        public UserRepository(ModelContext context)
        {
            _context = context;
        }


        // Returns the User Model if the username and password match, otherwise returns null
        public User GetByEmail(string email)
        {

            if (IsVetClinicEmail(email))
            {
                var match = _context.UserList
                .Include(vet => vet.Veterinarian)
                .ThenInclude(clinic => clinic.Clinic)
                .FirstOrDefault(user => user.UserEmail == email);

                if (match == null)
                    throw new Exception("User not found.");

                if (match.Veterinarian == null)
                    throw new Exception("Veterinarian relation is null.");

                if (match.Veterinarian.Clinic == null)
                    throw new Exception("Clinic relation is null.");

                return match;

            } else
            {
                var match = _context.UserList.FirstOrDefault(u => u.UserEmail == email);

                return match;
            }

        }
    }
}
