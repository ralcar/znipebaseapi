using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ZnipeBaseApi.Controllers
{
    [EnableCors("AllowAll")]
    [Route("api/[controller]")]
    public class TournamentController
    {
        private readonly ZnipeBaseDbContext _context;

        public TournamentController(ZnipeBaseDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Tournament> Get()
        {
            return _context.Tournament;
        }

        [HttpGet("{id}")]
        public Tournament Get(int id)
        {
            return _context
                .Tournament
                .FirstOrDefault(tournament => tournament.Id == id);
        }

        [HttpPost]
        public async Task<HttpResponseMessage> Post([FromBody]Tournament tournament)
        {
            _context.Tournament.Add(tournament);
            await _context.SaveChangesAsync();

            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        [HttpPut]
        public async void Put([FromBody]Tournament tournament)
        {
            _context.Tournament.Update(tournament);
            await _context.SaveChangesAsync();
        }

        [HttpDelete("{id}")]
        public async Task<HttpResponseMessage> Delete(int id)
        {
            var selectedTournament = _context.Tournament.FirstOrDefault(tournament => tournament.Id == id);

            if (selectedTournament == null) return new HttpResponseMessage(HttpStatusCode.NotFound);

            _context.Tournament.Remove(selectedTournament);
            await _context.SaveChangesAsync();

            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }
    }
}
