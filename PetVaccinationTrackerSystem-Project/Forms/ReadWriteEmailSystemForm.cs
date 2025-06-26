using PetVaccinationTrackerSystem_Project.Classes;
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
            if (int.TryParse(txtToUser.Text.Trim(), out int toUserID))
            {
                var emailService = new EmailService();

                bool emailResult = emailService.SendEmail(

                    _currentUser,
                    toUserID,
                    txtTitle.Text.Trim(),
                    richtxtContent.Text.Trim(),
                    datetimeDateSent.Value,
                    out string error
                    );

                if(!emailResult)
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var fieldHelper = new TextFieldHelper();
                fieldHelper.ClearFields(new List<TextBox>
                {
                    txtTitle,
                    txtToUser,
                });

                richtxtContent.Clear();
                datetimeDateSent.Value = DateTime.Now;
                this.Close();
            } else
            {
                MessageBox.Show("Invalid User ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mainFormVButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
