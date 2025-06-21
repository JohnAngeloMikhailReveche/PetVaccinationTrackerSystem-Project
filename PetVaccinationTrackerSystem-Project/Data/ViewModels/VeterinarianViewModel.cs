using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Data.ViewModels
{
    public class VeterinarianViewModel
    {
        public int UserID { get; set; }
        public int VetID { get; set; }
        public string LicenseNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public int ClinicID { get; set; }
        public string ClinicName { get; set; }
    }
}
