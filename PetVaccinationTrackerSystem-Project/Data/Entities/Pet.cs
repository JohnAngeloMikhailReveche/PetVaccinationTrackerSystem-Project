using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ReaLTaiizor.Util.RoundInt;

namespace PetVaccinationTrackerSystem_Project.Data.Entities
{
    public class Pet
    {

        [Key]
        public int PetID { get; set; }

        [StringLength(50)]
        public string PetName { get; set; }

        [StringLength(100)]
        public string OwnerName{ get; set; }

        [StringLength(50)]
        public string Species { get; set; }

        [StringLength(50)]
        public string Breed { get; set; }

        public DateTime DateOfBirth { get; set; }

        [StringLength(100)]
        public string ColorsAndMarkings { get; set; }
        public string OwnerPhoneNumber { get; set; }

        [StringLength(300)]
        public string Notes { get; set; }

        public string? ImageRL { get; set; }

        public string? Gender { get; set; }


        // Foreign Key
        [ForeignKey("User")]
        public int UserID { get; set; }

        [ForeignKey("Record")]
        public int RecordID { get; set; }


        // Navigation property to User entity
        public User User { get; set; }

        // Navigation property for Appointment
        public List<Appointment>? Appointments { get; set; }

        public List<PetHealthRecords>? PetHealthRecords { get; set; }

        
    }
}
