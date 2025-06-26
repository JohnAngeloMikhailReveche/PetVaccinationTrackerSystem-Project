using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PetVaccinationTrackerSystem_Project.Data.Entities
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public string UserEmail { get; set; }

        public string UserPassword { get; set; }

        [StringLength(50)]
        public string UserRole { get; set; }

        public bool? SentPasswordRequest { get; set; }

        public bool? SentAccountDeletion { get; set; }



        // Foregn Key
        [ForeignKey("Veterinarian")]
        public int? VetID { get; set; }

        // Navigation property to User entity
        public Veterinarian Veterinarian { get; set; }



        // Navigation properties for related entities
       
        public List<Pet>? Pets { get; set; }
        public List<Email>? Emails { get; set; }
    }
}
