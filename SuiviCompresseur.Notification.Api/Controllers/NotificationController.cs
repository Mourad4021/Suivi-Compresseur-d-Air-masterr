using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using SuiviCompresseur.Notification.Data.Context;
using SuiviCompresseur.Notification.Domain.Commands;
using SuiviCompresseur.Notification.Domain.Models;
using SuiviCompresseur.Notification.Domain.Queries;
using Microsoft.AspNetCore.Mvc;

namespace SuiviCompresseur.Notification.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {

        private readonly Notification_context _context;
        private readonly IMediator mediator;
        public NotificationController(Notification_context context, IMediator mediator)
        {
            this.mediator = mediator;
            _context = context;
        }


        // GET api/values
        //[HttpGet("{Address}")]
        [HttpGet]

        public async Task<IEnumerable<EmailFrom>> GetNotification(string address)
        {
            string s1 = "Rached Trabelsi/SIEGE";
            return await mediator.Send(new GetNotificationsQuery(address));
        }

        // POST api/values
        [HttpPost]
        public async Task<string> SendEmail([FromBody] EmailMessage emailMessage)
        {

            //////////////////////////////////////data from frontend//////////////
            ///fromaddress
            ///
            //string to = "Rached Trabelsi/SIEGE/POULINA";
            //emailMessage.FromAddresses.Address = to;
            //li1.Address = "\"Rached Trabelsi/SIEGE/POULINA\"";
            emailMessage.FromAddresses.Address = "\"Rached Trabelsi/SIEGE/POULINA@POULINA\"";
            emailMessage.FromAddresses.Name = "Rached Trabelsi/SIEGE/POULINA";


            ////toaddress
            ///
            //emailMessage.ToAddresses.Add(new EmailAddress { Address = "\"Rached Trabelsi\"@poulina", Name = "Rached Trabelsi" });
            emailMessage.ToAddresses.Add(new EmailAddress { Address = "\"Hajer Ben Salem\"@poulina", Name = "Hajer" });
            emailMessage.ToAddresses.Add(new EmailAddress { Address = "\"Wael Hosni\"@poulina", Name = "Wael" });
            //emailMessage.ToAddresses.Add(new EmailAddress { Address = "\"Mourad Ben Hlayem\"@poulina", Name = "Mourad" });


            //////////////ccaddress
            ///
            emailMessage.CcAddresses.Add(new EmailAddress { Address = "\"Rached Trabelsi\"@poulina", Name = "Rached Trabelsi" });

            //////////////cccaddress
            ///
            emailMessage.CccAddresses.Add(new EmailAddress { Address = "\"Mourad Ben Hlayem\"@poulina", Name = "Mourad" });
            //emailMessage.CccAddresses.Add(new EmailAddress { Address = "\"Athil Belhadj/SIEGE/POULINA@POULINA\"", Name = "Athil Belhadj" });

            ////////////////////////////////Subject and context
            ///

            emailMessage.Content = "<b>Content</b>";

            emailMessage.Subject = "Test Notification Subject";

            ////////////////////////////////Attachements
            ///         

            emailMessage.Files.Add("./1.txt");
            emailMessage.Files.Add("./Calendrier 2019.xls");

            return await mediator.Send(new SendEmailCommand(emailMessage));
        }


        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<string> Seen(Guid id)
        {
            return await mediator.Send(new NotificationSeenCommand(id));
        }


    }
}
