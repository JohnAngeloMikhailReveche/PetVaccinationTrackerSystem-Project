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

        [Key, StringLength(15)]
        public required string PetID { get; set; }

        [StringLength(50)]
        public string PetName { get; set; }

        [StringLength(50)]
        public string OwnerFirstName { get; set; }

        [StringLength(50)]
        public string OwnerLastName { get; set; }

        [StringLength(50)]
        public string Species { get; set; }

        [StringLength(50)]
        public string Breed { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        public int Year { get; set; }

        [StringLength(30)]
        public string? Gender { get; set; }

        // Foreign Key
        [ForeignKey("User")]
        public string UserID { get; set; }

        // Navigation property to User entity
        public User User { get; set; }


        // Navigation property for Appointment
        public List<Appointment>? Appointments { get; set; }

        public List<PetHealthRecords>? PetHealthRecords { get; set; }
    }
}
