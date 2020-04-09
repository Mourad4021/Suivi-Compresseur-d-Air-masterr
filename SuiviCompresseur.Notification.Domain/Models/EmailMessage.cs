using System;
using System.Collections.Generic;
using System.Text;

namespace SuiviCompresseur.Notification.Domain.Models
{
    public class EmailMessage
    {
        public EmailMessage()
        {
            ToAddresses = new List<EmailAddress>();
            CccAddresses = new List<EmailAddress>();
            CcAddresses = new List<EmailAddress>();
            FromAddresses = new EmailAddress();
            Files = new List<string>();
        }

        public List<EmailAddress> ToAddresses { get; set; }
        public List<EmailAddress> CcAddresses { get; set; }
        public List<EmailAddress> CccAddresses { get; set; }
        public EmailAddress FromAddresses { get; set; }
        public List<string> Files { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
