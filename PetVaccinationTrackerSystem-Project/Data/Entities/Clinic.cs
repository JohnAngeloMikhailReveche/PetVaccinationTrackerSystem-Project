using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Data.Entities
{
    public class Clinic
    {

        [Key, StringLength(15)]
        public required string ClinicID { get; set; }

        [StringLength(50)]
        public string ClinicName { get; set; }

        [StringLength(70)]
        public string Street { get; set; }

        [StringLength(70)]
        public string City { get; set; }

        [StringLength(70)]
        public string State { get; set; }

        [StringLength(50)]
        public string ZipCode { get; set; }


        // Navigation property list
        public List<Veterinarian>? Veterinarians { get; set; }
    }
}
