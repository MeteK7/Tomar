﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;
using TomarBlogUI.BusinessManagers.Interfaces;
using TomarBlogUI.Models.ContactViewModels;

namespace TomarBlogUI.BusinessManagers
{
    public class ContactBusinessManager:IContactBusinessManager
    {
        public string SendEmail(SendEmailViewModel sendEmailViewModel)
        {
            string ownerEmail = "fake0941@gmail.com";
            string guestFirstName = sendEmailViewModel.GuestFirstName;
            string guestLastName = sendEmailViewModel.GuestLastName;
            string guestPhoneNumber = sendEmailViewModel.GuestPhoneNumber;
            string guestEmail = sendEmailViewModel.GuestEmailAddress;
            string emailSubject = sendEmailViewModel.Subject;
            string emailBody = sendEmailViewModel.Body;
            string emailFullBody = "Guest's\n\nEmail: " + guestEmail + "\nName: " + guestFirstName + "\nSurname: " + guestLastName + "\nPhone Number: " + guestPhoneNumber + "\n\n\n" + emailBody;
            string deliveryStatus;

            MailMessage mailMessage = new MailMessage();

            mailMessage.To.Add(ownerEmail);
            mailMessage.From = new MailAddress(ownerEmail);
            mailMessage.Subject = emailSubject;
            mailMessage.Body = emailFullBody;
            mailMessage.IsBodyHtml = false;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");

            smtpClient.Port = 587;
            smtpClient.UseDefaultCredentials = true;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new System.Net.NetworkCredential("fake0941@gmail.com", "aszx323+776");
            smtpClient.Send(mailMessage);

            deliveryStatus="Mail has been sent successfully.";

            return deliveryStatus;
        }
    }
}
