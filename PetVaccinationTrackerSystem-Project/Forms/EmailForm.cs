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

namespace PetVaccinationTrackerSystem_Project.Forms
{
    public partial class EmailForm : Form
    {

        private Email _currentEmail;

        private void LoadData()
        {
            this.Text = _currentEmail.Title; // Set the form title to the email subject

            txtTitle.Text = _currentEmail.Title;
            txtDate.Text = _currentEmail.DateAndTimeEmailSent.ToString("g"); // General date and time format
            txtFromUser.Text = _currentEmail.FromUser;
            richtxtContent.Text = _currentEmail.Body;

            btnRead.Text = _currentEmail.IsRead ? "Unread" : "Read"; // Set the button text based on read status
        }

        private void SetReadButton(bool read)
        {
            if(read == false)
            {
                btnRead.Text = "Unread"; // Change button text to "Mark as Unread"
            } else
            {
                btnRead.Text = "Read"; // Change button text to "Mark as Read"
            }
        }

        public EmailForm(Email inEmailRef)
        {
            InitializeComponent();

            _currentEmail = inEmailRef;

            if (_currentEmail == null)
            {
                MessageBox.Show("Email data is not available. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Close the form if email data is not available
                return;
            }

            LoadData();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

            if(_currentEmail.IsRead == false)
            {
                _currentEmail.IsRead = true; // Mark the email as read

                using (var context = new ModelContext())
                {
                    context.EmailList.Update(_currentEmail); // Update the email in the database
                    context.SaveChanges(); // Save changes to the database
                }

                MessageBox.Show("Email marked as read.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetReadButton(false);
            } else
            {
                _currentEmail.IsRead = false; // Mark the email as unread

                using (var context = new ModelContext())
                {
                    context.EmailList.Update(_currentEmail); // Update the email in the database
                    context.SaveChanges(); // Save changes to the database
                }

                MessageBox.Show("Email marked as unread.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetReadButton(true);
            }

        }
    }
}
