

using Manbet.Application.ViewModels;
using Manbet.Core.Entities;
using Manbet.Core.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manbet.Application.Services
{
    public class SaqueService : ISaqueService
    {
        private readonly ISaqueRepository _saqueRepository;
        public SaqueService(ISaqueRepository saqueRepository)
        {
             _saqueRepository = saqueRepository;
        }
        public async Task<int> CriarSaque (ISaque saque)
        {
            var novoSaque = new Saque (saque.Valor, saque.Data, saque.Destino);

            var id = await _saqueRepository.CriarSaque(novoSaque);

            return id;
        }

        public async Task<List<SaqueModel>> ObterTodos()
        {
            var saque = await _saqueRepository.ObterTodos();


            var saqueModel = saque.Select(u => new SaqueModel(u.Id, u.Valor, u.Data, u.Destino)).ToList();

            return saqueModel;
        }
    }
}