using Manbet.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manbet.Core.Interfaces.Repositories
{
    public interface ISaqueRepository
    {

        Task<List<Saque>> ObterTodos();
        Task<int> CriarSaque(Saque saque);
    }
}