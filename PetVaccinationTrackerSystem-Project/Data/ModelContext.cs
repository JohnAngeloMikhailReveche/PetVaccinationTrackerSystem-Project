using Microsoft.EntityFrameworkCore;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Data
{
    public class ModelContext : DbContext
    {

        // Lists of the Models
        public DbSet<Appointment> AppointmentList { get; set; }
        public DbSet<Clinic> ClinicList { get; set; }
        public DbSet<Pet> PetList { get; set; }
        public DbSet<PetHealthRecords> PetHealthRecordsList { get; set; }
        public DbSet<User> UserList { get; set; }
        public DbSet<UserContact> UserContactList { get; set; }
        public DbSet<Vaccination> VaccinationList { get; set; }
        public DbSet<Veterinarian> VeterinarianList { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the database connection string here
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=PetVaccinationTrackerSystemDB;Trusted_Connection=True;Encrypt=False");
        }
    }
}
