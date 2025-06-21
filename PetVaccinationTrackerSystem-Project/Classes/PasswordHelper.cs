using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes
{
    public class PasswordHelper
    {
        private readonly PasswordHasher<string> _hasher = new();

        public string HashPassword(string plainPassword)
        {
            // Check if the plain password is null or empty.
            return _hasher.HashPassword(null, plainPassword);
        }

        public bool VerifyPassword(string hashedPassword, string inputPassword)
        {
            var result = _hasher.VerifyHashedPassword(null, hashedPassword, inputPassword);

            return result == PasswordVerificationResult.Success;
        }
    }
}
