using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SuiviCompresseur.Notification.Domain.Models
{
    public class EmailAddress
    {
        [Key]
        public Guid IdEmailAddress { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

    }
}
