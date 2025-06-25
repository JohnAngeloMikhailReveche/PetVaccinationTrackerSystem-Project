using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Data.Entities
{
    public class Email
    {

        [Key]
        public int EmailID { get; set; }

        public string Title { get; set; }

        public DateTime DateAndTimeEmailSent { get; set; }

        public string Body { get; set; }

        public string FromUser { get; set; }

        public bool IsRead { get; set; }

        public bool IsDeleted { get; set; }

        // The user to whom the email is sent
        [ForeignKey("User")]
        public int UserID { get; set; }

        // Navigation property to User entity
        public User User { get; set; }
    }
}
