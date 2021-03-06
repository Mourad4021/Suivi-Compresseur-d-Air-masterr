﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuiviCompresseur.GestionCompresseur.Data.Context;
using SuiviCompresseur.GestionCompresseur.Domain.Models;
using MediatR;
using SuiviCompresseur.GestionCompresseur.Domain.Commands;
using SuiviCompresseur.GestionCompresseur.Domain.Queries;

namespace SuiviCompresseur.GestionCompresseur.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsommablesController : ControllerBase
    {
        private readonly CompresseurDbContext _context;
        private readonly IMediator mediator;

        public ConsommablesController(CompresseurDbContext context, IMediator mediator)
        {
            this.mediator = mediator;
            _context = context;
        }

        // GET: api/Consommables
        [HttpGet]
        public async Task<IEnumerable<Consommable>> GetConsommables() =>
             await mediator.Send(new GetAllGenericQuery<Consommable>());


        // GET: api/Consommable/5
        [HttpGet("{id}")]
        public async Task<Consommable> GetConsommable(Guid id) =>
            await mediator.Send(new GetGenericQuery<Consommable>(id));


        // POST: api/Consommable
        [HttpPost]
        public async Task<string> PostConsommable([FromBody] Consommable consommable) =>
            await mediator.Send(new CreateGenericCommand<Consommable>(consommable));

        // PUT: api/Consommable/5
        [HttpPut("{id}")]
        public async Task<string> PutConsommable([FromRoute] Guid id, [FromBody] Consommable consommable) =>
            await mediator.Send(new PutGenericCommand<Consommable>(id, consommable));

        // DELETE: api/Consommable/5
        [HttpDelete("{id}")]
        public async Task<string> DeleteConsommable(Guid id) =>
            await mediator.Send(new RemoveGenericCommand<Consommable>(id));

    }
}