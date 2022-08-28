using Manbet.Core.Entities;
using Manbet.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manbet.Infrastructure.Persistence.Repositories
{
    public class SaqueRepository : ISaqueRepository
    {
        private readonly ManbetDBContext _context;
        public SaqueRepository(ManbetDBContext context)
        {
            _context = context;
        }
        
        public async Task<int> CriarSaque(Saque saque)
        {
            var saques =  _context.Saques.Add(saque).Entity;
            await _context.SaveChangesAsync();
            
            return saques.Id;
        }

        public Task<List<Saque>> ObterTodos()
        {
            var saques = _context.Saques.ToListAsync();

            return saques;
        }
    }
}
