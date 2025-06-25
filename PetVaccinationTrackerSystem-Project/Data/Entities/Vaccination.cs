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

        [StringLength(60)]
        public string VaccineDescription { get; set; }

        [StringLength(100)]
        public string Manufacturer { get; set; }

        [StringLength(300)]
        public string Notes { get; set; }

        [StringLength(100)]
        public string ApplicableSpecies { get; set; }

        public DateTime ManufactureDate { get; set; }

        public DateTime ExpiryDate { get; set; }

        [StringLength(300)]
        public int BatchNumber { get; set; }


        // Foreign Keys



        // Navigation property li
    }
}
