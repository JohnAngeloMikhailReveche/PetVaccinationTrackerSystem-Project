using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Data.Entities
{
    public class PetHealthRecords
    {

        [Key]
        public int RecordID { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        public int Year { get; set; }

        // Foreign Keys
        [ForeignKey("Vaccination")]
        public int VaccinationID { get; set; }

        [ForeignKey("Vet")]
        public int VetID { get; set; }

        [ForeignKey("Pet")]
        public int PetID { get; set; }

        // Navigation properties
        public Vaccination Vaccination { get; set; }

        public Veterinarian Vet { get; set; }

        public Pet Pet { get; set; }
    }
}
