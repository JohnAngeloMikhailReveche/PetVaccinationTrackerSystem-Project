using Microsoft.EntityFrameworkCore;
using PetVaccinationTrackerSystem_Project.Data;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes
{
    public class EmailService
    {

        private ModelContext _context;

        public EmailService()
        {
            _context = new ModelContext();
        }

        public List<Email> GetInboxEmails(User user)
        {
            return _context.EmailList
                .Include(e => e.User)
                .Where(e => (e.UserID == user.UserID && !e.IsDeleted) || e.WrittenByUserID == user.UserID)
                .OrderByDescending(e => e.DateAndTimeEmailSent)
                .ToList();
        }

        public void ToggleReadStatus(Email email, bool isRead)
        {
            email.IsRead = isRead;
            _context.EmailList.Update(email);
            _context.SaveChanges();
        }

        public void DeleteEmail(Email email, bool isVeterinarian)
        {
            if (isVeterinarian)
            {
                _context.EmailList.Remove(email);
            }
            else
            {
                email.IsDeleted = true;
                _context.EmailList.Update(email);
            }

            _context.SaveChanges();
        }

        public List<Email> SearchEmails(User user, string keyword, string filter)
        {
            var query = _context.EmailList
                .Include(e => e.User)
                .Where(e => (e.UserID == user.UserID && !e.IsDeleted) || e.WrittenByUserID == user.UserID)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(e =>
                    e.Title.Contains(keyword) ||
                    e.FromUser.Contains(keyword));
            }

            if (filter == "Read")
                query = query.Where(e => e.IsRead);
            else if (filter == "Not Read")
                query = query.Where(e => !e.IsRead);

            return query
                .OrderByDescending(e => e.DateAndTimeEmailSent)
                .ToList();
        }

        
        public bool SendEmail(User fromUser, int recipientID, string subject, string body, DateTime dateTimeSent, out string error)
        {

            var toUser = _context.UserList
                .FirstOrDefault(u => u.UserID == recipientID);

            if (toUser == null)
            {
                error = "Recipient is not found or invalid.";
                return false;
            }

            var emailToSend = new Email
            {
                Title = subject, 
                DateAndTimeEmailSent = dateTimeSent,
                Body = body,
                FromUser = fromUser.UserEmail,
                IsRead = false,
                IsDeleted = false,
                UserID = recipientID,
                WrittenByUserID = fromUser.UserID
            };

            _context.EmailList.Add(emailToSend);
            _context.SaveChanges();
            error = string.Empty;
            return true;
        }

    }
}
