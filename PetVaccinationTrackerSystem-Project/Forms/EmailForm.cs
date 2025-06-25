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
        private User _currentUser;

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
            if (read == false)
            {
                btnRead.Text = "Unread"; // Change button text to "Mark as Unread"
            }
            else
            {
                btnRead.Text = "Read"; // Change button text to "Mark as Read"
            }
        }

        private void CheckIfVeterinarian()
        {
            if (_currentUser == null) return;

            btnRead.Enabled = false;
            btnRead.Visible = false;
        }

        public EmailForm(Email inEmailRef, User inUserRef)
        {
            InitializeComponent();

            _currentEmail = inEmailRef;
            _currentUser = inUserRef;

            if (_currentEmail == null)
            {
                MessageBox.Show("Email data is not available. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Close the form if email data is not available
                return;
            }

            LoadData();
            CheckIfVeterinarian(); // Disable Read Button if the viewer is the Veterinarian (Sender)
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

            if (_currentEmail.IsRead == false)
            {
                _currentEmail.IsRead = true; // Mark the email as read

                using (var context = new ModelContext())
                {
                    context.EmailList.Update(_currentEmail); // Update the email in the database
                    context.SaveChanges(); // Save changes to the database
                }

                MessageBox.Show("Email marked as read.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetReadButton(false);
            }
            else
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var diagResult = MessageBox.Show("Are you sure you want to delete this email?\n\n You will not see the email once you accept its deletion.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(_currentUser.VetID != null)
            {
                if (diagResult == DialogResult.Yes)
                {
                    using (var context = new ModelContext())
                    {
                        context.EmailList.Remove(_currentEmail);
                        context.SaveChanges();

                        MessageBox.Show("The Email is deleted Successfully!", "Email Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            } else
            {
                if (diagResult == DialogResult.Yes)
                {
                    using (var context = new ModelContext())
                    {
                        _currentEmail.IsDeleted = true;

                        context.EmailList.Update(_currentEmail);
                        context.SaveChanges();

                        MessageBox.Show("The Email is deleted Successfully!", "Email Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            
        }


    }
}
