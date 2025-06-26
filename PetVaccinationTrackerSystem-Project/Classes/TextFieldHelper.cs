using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes
{
    public class TextFieldHelper
    {

        public void ClearFields(List<TextBox> textFields)
        {
            foreach(TextBox field in textFields)
            {
                field.Clear();
            }

        }

    }
}
