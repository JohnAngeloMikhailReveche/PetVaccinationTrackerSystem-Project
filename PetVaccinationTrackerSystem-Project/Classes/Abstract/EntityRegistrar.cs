using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes.Abstract
{
    public abstract class EntityRegistrar
    {
        public abstract bool ValidateFields();
        public abstract void Register();
        public abstract int GetID();
    }
}
