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
    public partial class ReadWriteEmailSystemForm : Form
    {

        private User _currentUser;

        public ReadWriteEmailSystemForm(User inUserRef)
        {
            InitializeComponent();

            _currentUser = inUserRef;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            using(var context = new ModelContext())
            {
                if(int.TryParse(txtToUser.Text.Trim(), out int toSendUserID))
                {
                    // Fetch the User Recipient
                    var userRecipient = context.UserList
                                    .Where(u => u.UserID == toSendUserID)
                                    .FirstOrDefault();

                    // Check if the Recipient is Valid
                    if (userRecipient == null)
                    {
                        MessageBox.Show("The User is either not existing or invalid!", "Error", MessageBoxButtons.OK,  MessageBoxIcon.Error);
                        return;
                    }

                    // Make the email system
                    var emailToSend = new Email
                    {
                        Title = txtTitle.Text.Trim(),
                        DateAndTimeEmailSent = datetimeDateSent.Value,
                        Body = richtxtContent.Text.Trim(),
                        FromUser = _currentUser.UserEmail,
                        IsRead = false,
                        IsDeleted = false,
                        UserID = toSendUserID,
                        WrittenByUserID = _currentUser.UserID
                    };

                    // Add the Email
                    context.EmailList.Add(emailToSend);
                    context.SaveChanges();

                    MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear Input Fields
                    txtTitle.Clear();
                    richtxtContent.Clear();
                    txtToUser.Clear();
                    datetimeDateSent.Value = DateTime.Now;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric User ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }



    }
}
