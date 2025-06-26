using PetVaccinationTrackerSystem_Project.Classes.Abstract;
using PetVaccinationTrackerSystem_Project.Data;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes
{
    public class UserRegistrar : EntityRegistrar
    {
        private string _fName, _lName, _username, _password;
        private int? _vetID;
        private UserService _user;
        private PasswordHelper _passHelper;
        private int _userID;

        public UserRegistrar(string fName, string lName, string username, string password, int? vetID) 
        {
            _fName = fName;
            _lName = lName;
            _username = username;
            _password = password;
            _vetID = vetID;

            _user = new UserService();
            _passHelper = new PasswordHelper();
        }

        public override int GetID()
        {
            return _userID;
        }

        public override void Register()
        {
            // Hash Password
            string hashedPassword = _passHelper.HashPassword(_password);

            using(var context = new ModelContext())
            {
                User user = new User
                {
                    FirstName = _fName,
                    LastName = _lName,
                    UserEmail = $"{_username}@vetclinic.com",
                    UserPassword = hashedPassword,
                    UserRole = "Veterinarian",
                    SentPasswordRequest = false,
                    SentAccountDeletion = false,
                    VetID = _vetID
                };

                _user.RegisterUser(user);

                _userID = user.UserID;
            }
        }

        public override bool ValidateFields()
        {
            return (string.IsNullOrWhiteSpace(_fName) ||
                string.IsNullOrWhiteSpace(_lName) ||
                string.IsNullOrWhiteSpace(_username) ||
                string.IsNullOrWhiteSpace(_password)
                );
        }
    }
}
