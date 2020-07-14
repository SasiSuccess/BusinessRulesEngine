using System;
using System.Net.Mail;

namespace BusinessRulesEngine
{
    /// <summary>
    /// Class for PurchasePhysicalProduct
    /// </summary>
    public class PurchasePhysicalProduct : IPayMode
    {
        /// <summary>
        /// Implementation for the method defined in IPayMode
        /// </summary>
        public void InvoiceGenerator()
        {
            Console.WriteLine("Packing Slip has been generated for your Physical product");
            Console.WriteLine("And comission payment has been Initiated for the agent.");
        }
    }

    /// <summary>
    /// Class for PurchaseBook
    /// </summary>
    public class PurchaseBook : IPayMode
    {
        /// <summary>
        /// Implementation for the method defied in IPayMode
        /// </summary>
        public void InvoiceGenerator()
        {
            Console.WriteLine("Created a duplicate packing slip for the royalty department for the purchase of Book");
            Console.WriteLine("And comission payment has been Initiated for the agent.");
        }
    }

    /// <summary>
    /// Class for MembershipActivation
    /// </summary>
    public class MembershipActivation : EMail, IPayMode
    {

        EMail email = new EMail();

        /// <summary>
        /// Implementation for the method defied in IPayMode
        /// </summary>
        /// 
        public void InvoiceGenerator()
        {
            Console.WriteLine("Membership activated!");
            email.SendEmailMessage("Activation");
        }
    }

    /// <summary>
    /// Class for MembershipUpgrade
    /// </summary>
    public class MembershipUpgrade : EMail, IPayMode
    {
        EMail email = new EMail();
        /// <summary>
        /// Implementation for the method defied in IPayMode
        /// </summary>
        public void InvoiceGenerator()
        {
            Console.WriteLine("Upgradation on the membership done!");
            email.SendEmailMessage("MembershipUpgrade");
        }
    }

    /// <summary>
    /// Class for LearningVideo
    /// </summary>
    public class LearningVideo : IPayMode
    {
        /// <summary>
        /// Implementation for the method defied in IPayMode
        /// </summary>
        public void InvoiceGenerator()
        {
            Console.WriteLine("Added Skining videos and also a First Aid video as a complimentory to your account.");
        }
    }

    /// <summary>
    /// Send Email to the User based on the Membership
    /// </summary>
    public class EMail 
    {
        public void SendEmailMessage(string Membership)
        {

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("your_email_address@gmail.com");
            mail.To.Add("to_address");
            mail.Subject = "Test Mail";
            mail.Body = "This is for testing SMTP mail from GMAIL";

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            Console.WriteLine(Membership + " Email sent successfully.");
        }
    }

}