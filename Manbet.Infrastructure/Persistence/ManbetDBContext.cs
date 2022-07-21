using Manbet.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Manbet.Infrastructure.Persistence
{
    public class ManbetDBContext: DbContext
    {
        public ManbetDBContext(DbContextOptions<ManbetDBContext> options): base(options)
        {
        }

        public DbSet<Aposta> Apostas { get; set; }
        public DbSet<CasaAposta> CasasAposta { get; set; }
        public DbSet<Saque> Saques{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
