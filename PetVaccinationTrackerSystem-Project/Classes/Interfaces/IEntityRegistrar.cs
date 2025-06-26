using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes.Interfaces
{
    public interface IEntityRegistrar
    {
        public bool ValidateFields();
        public void Register();
        public int GetID();
    }
}
