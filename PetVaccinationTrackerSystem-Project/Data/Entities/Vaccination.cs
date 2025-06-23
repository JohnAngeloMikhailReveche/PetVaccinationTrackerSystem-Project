using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Data.Entities
{
    public class Vaccination
    {

        [Key]
        public int VaccinationID { get; set; }

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
        
        public int PetID { get; set; }          
        public Pet Pet { get; set; }            



        // Navigation property list
        public List<PetHealthRecords>? PetHealthRecords { get; set; }

        public List<Pet>? Pets { get; set; }

    }
}
