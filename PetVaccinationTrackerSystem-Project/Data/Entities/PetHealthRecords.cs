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

        [StringLength(100)]
        public string PetName { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        [StringLength(100)]
        public string Species { get; set; }

        [StringLength(100)]
        public string Breed { get; set; }



        // Vaccine details 

        [StringLength(60)]
        public string VaccineName { get; set; }

        [StringLength(255)]
        public string AdministeredBy { get; set; }

        public DateTime DateAdministered { get; set; }
        public DateTime NextDueDate { get; set; }

        [StringLength(300)]
        public string Notes { get; set; }

        [StringLength(200)]
        public string BatchNo { get; set; }

        // Foreign Keys

        [ForeignKey("Vet")]
        public int VetID { get; set; }

        [ForeignKey("Pet")]
        public int PetID { get; set; }

        [ForeignKey("Vaccination")]
        public int? VaccinationID { get; set; }


        // Navigation properties

        public Veterinarian Vet { get; set; }

        public Pet Pet { get; set; }
        public Vaccination Vaccination { get; set; }
    }
}
