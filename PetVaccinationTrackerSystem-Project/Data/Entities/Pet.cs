using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Data.Entities
{
    public class Pet
    {

        [Key]
        public int PetID { get; set; }

        [StringLength(50)]
        public string PetName { get; set; }

        [StringLength(50)]
        
        public string ColorAndMarkings { get; set; }
        [StringLength(100)]

        public int OwnerPhoneNumber { get; set; } 

        public string Species { get; set; }

        [StringLength(50)]
        public string Breed { get; set; }
        [StringLength(30)]

        public string? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

        [StringLength(50)]
        public string OwnerName { get; set; }
        public string Image { get; set; } 

        public string Notes { get; set; }
        [StringLength(300)]

        // Foreign Key
        [ForeignKey("User")]
        public int UserID { get; set; }

        // Navigation property to User entity
        public User User { get; set; }


        // Navigation property for Appointment
        public List<Appointment>? Appointments { get; set; }

        public List<PetHealthRecords>? PetHealthRecords { get; set; }
    }
}
