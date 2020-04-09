using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using SuiviCompresseur.Gestion.Responsable.Aplication.Interfaces;
using SuiviCompresseur.Gestion.Responsable.Data.Context;
using SuiviCompresseur.Gestion.Responsable.Domain.Commands;
using SuiviCompresseur.Gestion.Responsable.Domain.Models;
using SuiviCompresseur.Gestion.Responsable.Domain.Queries;
using Microsoft.AspNetCore.Mvc;

namespace SuiviCompresseur.GestionResponsable.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        private readonly Gestion_Responsable_DBContext _context;
        private readonly IMediator mediator;

        public UtilisateurController(Gestion_Responsable_DBContext context, IMediator mediator)
        {
            _context = context;
            this.mediator = mediator;
        }

        // GET api/Utilisateur
        [HttpGet]
        public async Task<IEnumerable<Utilisateur>> GetUtilisateurs() =>
            await mediator.Send(new GetAllGenericQueryGR<Utilisateur>());


        // GET api/Utilisateur/5
        [HttpGet("{id}")]
        public async Task<Utilisateur> GetUtilisateur(Guid id) =>
            await mediator.Send(new GetGenericQueryGR<Utilisateur>(id));


        // DELETE: api/Utilisateurs/5
        [HttpDelete("{id}")]
        public async Task<string> DeleteUtilisateur(Guid id) =>
            await mediator.Send(new RemoveGenericCommandGR<Utilisateur>(id));



        // PUT: api/Utilisateurs/5
        [HttpPut("{id}")]
        public async Task<string> PutUtilisateur([FromRoute] Guid id, [FromBody] Utilisateur utilisateur) =>
            await mediator.Send(new PutGenericCommandGR<Utilisateur>( utilisateur,id));

        // POST api/Utilisateur
        [HttpPost]
        public async Task<string> PostUtilisateur([FromBody] Utilisateur utilisateur) =>
            await mediator.Send(new CreateGenericCommandGR<Utilisateur>(utilisateur));

    }
}
