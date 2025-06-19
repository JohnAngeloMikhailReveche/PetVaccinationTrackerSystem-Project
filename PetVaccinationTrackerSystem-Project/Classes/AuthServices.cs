using PetVaccinationTrackerSystem_Project.Classes.Interfaces;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes
{
    // This class implements the IAuthService interface to handle user authentication whether if that user exists.
    public class AuthService : IAuthServices
    {
        private readonly IUserRepository _userRepository;

        // Constructor that takes an IUserRepository to interact with the user data
        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Login(string email, string password)
        {
            // Use the user repository to get the user by username and password
            var user = _userRepository.GetByEmail(email);

            if (user == null)
            {
                // If no user is found, throw an UnauthorizedAccessException
                //throw new UnauthorizedAccessException("Invalid username or password.");

                return null;
            }

            var passwordHelper = new PasswordHelper();

            bool isValidPassword = passwordHelper.VerifyPassword(user.UserPassword, password);

            // If it has a comparison then,
            if (isValidPassword)
            {
                // If a match is found, return the User model
                return user.UserRole switch
                {
                    "Vet" => new User
                    {
                        UserID = user.UserID,
                        UserEmail = user.UserEmail,
                        UserPassword = user.UserPassword,
                        UserRole = "Vet"
                    },
                    "PetOwner" => new User
                    {
                        UserID = user.UserID,
                        UserEmail = user.UserEmail,
                        UserPassword = user.UserPassword,
                        UserRole = "PetOwner"
                    }
                };
            }
            else
            {
                // If the password does not match, return null
                return null;
            }
        }
    }
}
