using OpenTK.Graphics.OpenGL;
using PetVaccinationTrackerSystem_Project.Data;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes
{
    public class UserSessionManager
    {
        public static User RefreshUser(User user)
        {
            using (var context = new ModelContext())
            {
                return context.UserList.FirstOrDefault(u => u.UserID == user.UserID);
            }
        }

        public static string GetFullName(User user)
        {
            return $"{user.FirstName} {user.LastName}";
        }
    }
}
