using Manbet.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manbet.Core.Interfaces.Repositories
{
    public interface ICasaApostaRepository
    {

        Task<List<CasaAposta>> ObterTodos();
        Task<int> CriarCasaAposta(CasaAposta casaAposta);
    }
}
