using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Data.Entities
{
    public class UserContact
    {

        [Key]
        public int ContactID { get; set; }

        [StringLength(50)]
        public required string ContactType { get; set; }

        [StringLength(50)]
        public required string ContactValue { get; set; }

        // Foreign key to User entity
        [ForeignKey("User")]
        public int UserID { get; set; }

        // Navigation property to User entity
        public User User { get; set; }

    }
}
