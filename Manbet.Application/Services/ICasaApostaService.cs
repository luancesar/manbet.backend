using Manbet.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manbet.Application.Services
{
    public interface ICasaApostaService
    {
        Task<List<CasaApostaModel>> ObterTodos();
        Task<int> CriarCasaAposta(ICasaAposta casaAposta);
    }
}
