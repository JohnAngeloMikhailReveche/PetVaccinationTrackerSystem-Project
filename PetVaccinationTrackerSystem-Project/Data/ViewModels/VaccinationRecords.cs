using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Data.ViewModels
{
    public class VaccinationRecords
    {
        public int RecordID { get; set; }
        public int PetID { get; set; }
        public string PetName { get; set; }
        public string Gender { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public string VaccineName { get; set; }
        public string AdministeredBy { get; set; }
        public string DateAdministered { get; set; }
        public string NextDueDate { get; set; }
        public string BatchNo { get; set; }
    }
}
