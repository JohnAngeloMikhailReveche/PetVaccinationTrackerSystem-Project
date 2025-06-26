using PetVaccinationTrackerSystem_Project.Data;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetVaccinationTrackerSystem_Project.Forms.Auth
{
    public partial class AuthRequestPasswordChange : Form
    {
        public AuthRequestPasswordChange()
        {
            InitializeComponent();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            string storedEmail = txtboxEmail.Text.Trim();

            if (storedEmail.EndsWith("@vetclinic.com", StringComparison.OrdinalIgnoreCase) || storedEmail.EndsWith("@petownerclinic.com", StringComparison.OrdinalIgnoreCase))
            {
                using (var context = new ModelContext())
                {
                    // Find the user by email
                    var user = context.UserList.FirstOrDefault(u => u.UserEmail == storedEmail);

                    // If the user exists and has not sent a password request yet, update the flag and save changes
                    if (user != null && user.SentPasswordRequest == false || user.SentPasswordRequest == null)
                    {
                        user.SentPasswordRequest = true;

                        context.UserList.Update(user);
                        context.SaveChanges();

                        MessageBox.Show("You have successfully requested a password change. Please check your contact email for further instructions from the admins.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return;
                    }
                    else if (user.SentPasswordRequest == true) // If the user has already sent a request
                    {
                        MessageBox.Show("You have already requested a password change. Please wait for further instructions from the admins.", "Request Already Sent", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else // If no user is found with the provided email
                    {
                        MessageBox.Show("No user found with this email address. Please check the email associated with this clinic and try again.", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid email address ending with @vetclinic.com (If you are a Veterinarian) or @petownerclinic.com (If you are a Pet Owner).", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void mainFormVButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
