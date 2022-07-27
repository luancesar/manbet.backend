using Manbet.Core.Entities;
using Manbet.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manbet.Infrastructure.Persistence.Repositories
{
    public class CasaApostaRepository : ICasaApostaRepository
    {
        private readonly ManbetDBContext _context;
        public CasaApostaRepository(ManbetDBContext context)
        {
            _context = context;
        }
        
        public async Task<int> CriarCasaAposta(CasaAposta casaAposta)
        {
            var casa =  _context.CasasAposta.Add(casaAposta).Entity;
            await _context.SaveChangesAsync();
            
            return casa.Id;
        }

        public Task<List<CasaAposta>> ObterTodos()
        {
            var casaApostas = _context.CasasAposta.ToListAsync();

            return casaApostas;
        }
    }
}
