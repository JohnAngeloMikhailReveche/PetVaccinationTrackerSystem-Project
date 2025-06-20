using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Data.Entities
{
    public class Vaccination
    {

        [Key, StringLength(15)]
        public required string VaccinationID { get; set; }

        [StringLength(60)]
        public string VaccineName { get; set; }

        [StringLength(255)]
        public string VaccineDesc { get; set; }

        public float Frequency { get; set; }

        // Navigation property list
        public List<PetHealthRecords>? PetHealthRecords { get; set; }
    }
}
