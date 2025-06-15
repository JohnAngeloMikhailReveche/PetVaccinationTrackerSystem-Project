using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PetVaccinationTrackerSystem_Project.Data.Entities
{
    public class User
    {
        [Key, StringLength(15)]
        public required string UserID { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public required string UserEmail { get; set; }

        [StringLength(50)]
        public required string UserPassword { get; set; }

        [StringLength(50)]
        public required string UserRole { get; set; }


        // Navigation properties for related entities
        public List<UserContact>? UserContacts { get; set; }
        public List<Pet>? Pets { get; set; }
    }
}
