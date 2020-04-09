using MailKit.Net.Smtp;
using SuiviCompresseur.Notification.Data.Context;
using SuiviCompresseur.Notification.Domain.Interfaces;
using SuiviCompresseur.Notification.Domain.Models;
using SuiviCompresseur.Notification.Domain.Services;
using MimeKit;
using MimeKit.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SuiviCompresseur.Notification.Data.Repositories
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly Notification_context _context;
        private readonly IEmailConfiguration _emailConfiguration;
        public NotificationRepository(Notification_context notification_Context, IEmailConfiguration emailConfiguration)
        {
            _context = notification_Context;
            _emailConfiguration = emailConfiguration;
        }
        public IEnumerable<EmailFrom> GetNotifications(string address)
        {
            var Notification = _context.EmailTos.Where(t => t.ToAddresses == address && t.Seen == false).Select(v => v.IdMail).ToList();

            List<EmailFrom> Notification1 = new List<EmailFrom>();

            foreach (var to in Notification)
            {
                Notification1.Add(_context.EmailFroms.Find(to));
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////


            return Notification1;
        }

        public string NotificationSeen(Guid Id)
        {
            var Notification = _context.EmailTos.Find(Id);
            if (Notification != null)
            {
                Notification.Seen = true;

                _context.SaveChanges();
                return "Update Done";
            }
            return "Notification not exist";
        }

        public string Send(EmailMessage emailMessage)
        {
            //try
            //{
            //    _notification_Context.EmailFroms.Add(emailFrom);
            //    _notification_Context.EmailTos.AddRange(emailTo);
            //    _notification_Context.SaveChanges();

            //    return "Email send done";
            //}
            //catch (Exception ex)
            //{
            //    return ex.Message;
            //}
            var message = new MimeMessage();

            try
            {




                //message.From.Add(new MailboxAddress(emailMessage.FromAddresses.Address));


                foreach (var addto in emailMessage.ToAddresses)
                {
                    message.To.Add(new MailboxAddress(addto.Address));
                }

                foreach (var addcc in emailMessage.CcAddresses)
                {
                    message.Cc.Add(new MailboxAddress(addcc.Address));
                }

                foreach (var addccc in emailMessage.CccAddresses)
                {
                    message.Bcc.Add(new MailboxAddress(addccc.Address));
                }

                //message.To.Add(new MailboxAddress("\"Rached Trabelsi/SIEGE/POULINA\""));
                //message.To.AddRange(emailMessage1.ToAddresses.Select(x => new MailboxAddress(x.Address)));
                //message.To.AddRange(emailMessage1.ToAddresses.Select(x => new MailboxAddress(x.Name, x.Address)));
                //message.From.AddRange(emailMessage1.FromAddresses.Select(x => new MailboxAddress(x.Name, x.Address)));


                //message.From.Add(new MailboxAddress("\"Rached Trabelsi/SIEGE/POULINA\""));
                //message.From.Add(new MailboxAddress("\"Rached Trabelsi/SIEGE/POULINA@POULINA\""));

                message.Subject = emailMessage.Subject;
                //We will say we are sending HTML. But there are options for plaintext etc. 

                ///////////////////////////////////////////////////////////////////////////////
                ///
                /*
                message.Body = new TextPart(TextFormat.Html)
                {
                    Text = emailMessage1.Content
                };
                */
                ///////////////////////////////////////////////////////////////////////////html
                var bodyBuilder1 = new BodyBuilder();
                ////////////////////////////////////////////////////////////////////////////var bodyBuilder = new BodyBuilder();
                bodyBuilder1.HtmlBody = emailMessage.Content;
                ////////////////////////////////////////////////////////////////////////////var body = new TextPart("plain")
                ////////////////////////////////////////////////////////////////////////////{
                ////////////////////////////////////////////////////////////////////////////    Text = @"Hey"
                ////////////////////////////////////////////////////////////////////////////};

                ////////////////////////////////////////////////////////////////////////////bodyBuilder.TextBody = "This is some plain text";
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                ///

                var builder = new BodyBuilder();
                var image = builder.LinkedResources.Add(@"./poulinalogo.png");
                image.ContentId = MimeUtils.GenerateMessageId();

                // Set the html version of the message text

                builder.HtmlBody = string.Format(@"<br><br><br>

<table>
  <thead>
    <tr>
    <td>
      Rached Trabelsi
      </td>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>E-Mail : {0}</td>
    </tr>
    <tr>
      <td>Service : Informatique Operationnelle</td>
    </tr>
    <tr>
      <td>Poste : 801249</td>
    </tr>
    <tr>
      <td>GSM : 58278855</td>
    </tr>
</tbody>
<tfoot> 
<center><img src=""cid:{1}""></center>
</tfoot>
</table>", message.From.ToString(), image.ContentId);



                var multipart = new Multipart("mixed");
                multipart.Add(bodyBuilder1.ToMessageBody());
                multipart.Add(builder.ToMessageBody());


                var multipart1 = new Multipart("Attachements");

                // create an image attachment for the file located at path                
                ///

                foreach (var path in emailMessage.Files)
                {
                    var attachment = new MimePart()
                    {
                        Content = new MimeContent(File.OpenRead(path)),
                        ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                        ContentTransferEncoding = ContentEncoding.Base64,
                        FileName = Path.GetFileName(path)
                    };
                    multipart1.Add(attachment);
                }

                multipart.Add(multipart1);

                // now set the multipart/mixed as the message body
                message.Body = multipart;


                //Be careful that the SmtpClient class is the one from Mailkit not the framework!
                using (var emailClient = new SmtpClient())
                {
                    //The last parameter here is to use SSL (Which you should!)

                    emailClient.Connect(_emailConfiguration.SmtpServer, _emailConfiguration.SmtpPort, false);
                    //emailClient.Connect("192.168.1.4",25, false);

                    emailClient.Send(message);
                    emailClient.Disconnect(true);


                    EmailFrom emailFrom = new EmailFrom();

                    emailFrom.FromAddresses = emailMessage.FromAddresses.Address;
                    emailFrom.FromName = emailMessage.FromAddresses.Name;
                    emailFrom.Subject = emailMessage.Subject;
                    emailFrom.Content = emailMessage.Content;
                    emailFrom.SendDate = DateTime.Now;
                    emailFrom.MessageType = "info";
                    emailFrom.ExceptionMessage = "0";

                    _context.EmailFroms.Add(emailFrom);

                    foreach (var toemail in emailMessage.ToAddresses)
                    {
                        EmailTo emailTo = new EmailTo();

                        emailTo.IdMail = emailFrom.IdMail;
                        emailTo.Seen = false;
                        emailTo.ToAddresses = toemail.Address;
                        emailTo.ToName = toemail.Name;
                        emailTo.ReceiveType = "A";

                        _context.EmailTos.Add(emailTo);
                    }
                    foreach (var toemail in emailMessage.CcAddresses)
                    {
                        EmailTo emailTo = new EmailTo();

                        emailTo.IdMail = emailFrom.IdMail;
                        emailTo.Seen = false;
                        emailTo.ToAddresses = toemail.Address;
                        emailTo.ToName = toemail.Name;
                        emailTo.ReceiveType = "Cc";

                        _context.EmailTos.Add(emailTo);
                    }
                    foreach (var toemail in emailMessage.CccAddresses)
                    {
                        EmailTo emailTo = new EmailTo();

                        emailTo.IdMail = emailFrom.IdMail;
                        emailTo.Seen = false;
                        emailTo.ToAddresses = toemail.Address;
                        emailTo.ToName = toemail.Name;
                        emailTo.ReceiveType = "Ccc";

                        _context.EmailTos.Add(emailTo);
                    }
                    _context.SaveChanges();
                    return "Mail success";
                }
            }
            catch (Exception ex)
            {

                EmailFrom emailFrom = new EmailFrom();

                emailFrom.FromAddresses = emailMessage.FromAddresses.Address;
                emailFrom.FromName = emailMessage.FromAddresses.Name;
                emailFrom.Subject = emailMessage.Subject;
                emailFrom.Content = emailMessage.Content;
                emailFrom.SendDate = DateTime.Now;
                emailFrom.MessageType = "info";
                emailFrom.ExceptionMessage = ex.Message;

                _context.EmailFroms.Add(emailFrom);


                foreach (var toemail in emailMessage.ToAddresses)
                {
                    EmailTo emailTo = new EmailTo();

                    emailTo.IdMail = emailFrom.IdMail;
                    emailTo.Seen = false;
                    emailTo.ToAddresses = toemail.Address;
                    emailTo.ToName = toemail.Name;
                    emailTo.ReceiveType = "A";
                    _context.EmailTos.Add(emailTo);
                }
                foreach (var toemail in emailMessage.CcAddresses)
                {
                    EmailTo emailTo = new EmailTo();

                    emailTo.IdMail = emailFrom.IdMail;
                    emailTo.Seen = false;
                    emailTo.ToAddresses = toemail.Address;
                    emailTo.ToName = toemail.Name;
                    emailTo.ReceiveType = "Cc";
                    _context.EmailTos.Add(emailTo);
                }
                foreach (var toemail in emailMessage.CccAddresses)
                {
                    EmailTo emailTo = new EmailTo();

                    emailTo.IdMail = emailFrom.IdMail;
                    emailTo.Seen = false;
                    emailTo.ToAddresses = toemail.Address;
                    emailTo.ToName = toemail.Name;
                    emailTo.ReceiveType = "Ccc";
                    _context.EmailTos.Add(emailTo);
                }
                _context.SaveChanges();
                return ex.Message;
                //throw;
            }
        }





    }
}
