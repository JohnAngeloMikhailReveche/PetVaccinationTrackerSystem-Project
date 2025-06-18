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

        [Key]
        public  int VaccinationID { get; set; }

        [StringLength(60)]
        public string VaccineName { get; set; }
        public string AdministeredBy { get; set; }
        [StringLength(60)]

        public DateTime DateAdministered { get; set; }

        public DateTime NextDueDate { get; set; }

        public string Notes { get; set; }
        [StringLength(300)]

        public string BatchNo { get; set; }
        [StringLength(60)]

        // Navigation property list
        public List<PetHealthRecords>? PetHealthRecords { get; set; }
    }
}
