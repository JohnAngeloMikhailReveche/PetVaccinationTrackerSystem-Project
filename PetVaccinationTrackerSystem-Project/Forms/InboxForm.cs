using Microsoft.EntityFrameworkCore;
using PetVaccinationTrackerSystem_Project.Data;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using PetVaccinationTrackerSystem_Project.Data.ViewModels;
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
    public partial class InboxForm : Form
    {

        private ModelContext _context;
        private User _currentUser;

        private void LoadData()
        {
            var emails = _context.EmailList
                .Include(e => e.User)
                .Where(e => e.UserID == _currentUser.UserID)
                .ToList();

            dgvEmails.DataSource = emails;

            dgvEmails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEmails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvEmails.Columns["Body"].Visible = false;
            dgvEmails.Columns["IsDeleted"].Visible = false;
            dgvEmails.Columns["UserID"].Visible = false;
            dgvEmails.Columns["User"].Visible = false;

            dgvEmails.Columns["EmailID"].HeaderText = "ID";
            dgvEmails.Columns["Title"].HeaderText = "Email Subject";
            dgvEmails.Columns["DateAndTimeEmailSent"].HeaderText = "Date and Time Sent";
            dgvEmails.Columns["FromUser"].HeaderText = "From";
            dgvEmails.Columns["IsRead"].HeaderText = "Is Read";
        }

        private void LoadFilterBox()
        {
            cmbFilters.Items.Add("All Emails");
            cmbFilters.Items.Add("Read");
            cmbFilters.Items.Add("Not Read");
            cmbFilters.SelectedIndex = 0; // Default to "All Emails"
        }

        public InboxForm(User inUserRef)
        {
            InitializeComponent();

            // Initialize the database context
            _context = new ModelContext();

            // Set the current user
            _currentUser = inUserRef;

            // Load the emails for the current user
            LoadData();
            LoadFilterBox();
        }

        private void dgvEmails_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEmails.CurrentRow?.DataBoundItem is Email selectedEmail)
            {
                EmailForm emailForm = new EmailForm(selectedEmail);

                // Subscribe to the FormClosed event to reload data when the email form is closed
                emailForm.FormClosed += (s, args) =>
                {
                    // Reload the data after the email form is closed
                    LoadData();
                };

                // Always make this last since this freezes the current window.
                emailForm.ShowDialog();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Read and Store in the values
            string selectedFilterOption = cmbFilters.SelectedItem?.ToString();
            string keywordQuery = txtSearchBox.Text.Trim();

            // Query
            var query = _context.EmailList
                .Include(e => e.User)
                .Where(e => e.UserID == _currentUser.UserID)
                .AsQueryable();

                switch(selectedFilterOption)
                {
                    case "All Emails":
                        query = query.Where(
                            e => e.Title.Contains(keywordQuery) 
                            || e.Body.Contains(keywordQuery) 
                            || e.FromUser.Contains(keywordQuery)
                            );
                        break;

                    case "Read":
                        query = query.Where(e => e.IsRead);
                        break;

                    case "Not Read":
                        query = query.Where(e => !e.IsRead);
                        break;

                    default:
                        MessageBox.Show("Please select a valid filter option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

            // Select the data to display in the DataGridView
            var results = query
                .Select(e => new Email
                {
                    EmailID = e.EmailID,
                    Title = e.Title,
                    DateAndTimeEmailSent = e.DateAndTimeEmailSent,
                    FromUser = e.FromUser,
                    IsRead = e.IsRead,
                    Body = e.Body,
                    UserID = e.UserID
                })
                .ToList();

            // Reload the DataGridView with the filtered results
            dgvEmails.DataSource = results;
        }
    }
}
