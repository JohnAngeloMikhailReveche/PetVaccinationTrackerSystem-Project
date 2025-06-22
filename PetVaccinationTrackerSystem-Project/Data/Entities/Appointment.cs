using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Data.Entities
{
    public class Appointment
    {

        [Key]
        public int AppointmentID { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        public int Year { get; set; }

        public TimeOnly TimeOfAppointment { get; set; }

        [StringLength(255)]
        public string? Reason { get; set; }

        // Foreign Keys
        [ForeignKey("Pet")]
        public int PetID { get; set; }

        [ForeignKey("Vet")]
        public int VetID { get; set; }


        // Navigation property to Pet entity
        public Pet Pet { get; set; }

        public Veterinarian Vet { get; set; }

    }
}
