

using Manbet.Application.ViewModels;
using Manbet.Core.Entities;
using Manbet.Core.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manbet.Application.Services
{
    public class CasaApostaService : ICasaApostaService
    {
        private readonly ICasaApostaRepository _casaApostaRepository;
        public CasaApostaService(ICasaApostaRepository casaApostaRepository)
        {
             _casaApostaRepository = casaApostaRepository;
        }
        public async Task<int> CriarCasaAposta(ICasaAposta casaAposta)
        {
            var novaCasaAposta = new CasaAposta(casaAposta.Nome);

            var id = await _casaApostaRepository.CriarCasaAposta(novaCasaAposta);

            return id;
        }

        public async Task<List<CasaApostaModel>> ObterTodos()
        {
            var casasAposta = await _casaApostaRepository.ObterTodos();


            var casaApostaModel = casasAposta.Select(u => new CasaApostaModel(u.Id, u.Nome)).ToList();

            return casaApostaModel;
        }
    }
}
