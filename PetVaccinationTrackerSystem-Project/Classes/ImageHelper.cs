using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes
{
    public static class ImageHelper
    {
        public static Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var memoryStream = new MemoryStream(imageBytes))
            {
                return Image.FromStream(memoryStream);
            }
            
        }
    }
}
