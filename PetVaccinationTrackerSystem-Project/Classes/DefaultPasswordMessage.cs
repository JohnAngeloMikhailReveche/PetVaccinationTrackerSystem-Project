using PetVaccinationTrackerSystem_Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes
{
    public class DefaultPasswordMessage
    {

        public static void CheckIfUserPasswordIsDefault(User inUserRef)
        {
            if(inUserRef != null)
            {
                PasswordHelper passwordHelper = new PasswordHelper();
                if(passwordHelper.VerifyPassword(inUserRef.UserPassword, "default"))
                {
                    ShowMessage();
                }
            }
        }

        private static void ShowMessage()
        {
            string message = "Your pasword have been changed to 'default' due to your Request of Password Change. Please change it immediately after closing this dialog.";
            string caption = "Default Password Information";

            MessageBox.Show(message, caption, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }
    }
}
