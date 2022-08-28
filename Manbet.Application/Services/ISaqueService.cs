using Manbet.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manbet.Application.Services
{
    public interface ISaqueService
    {
        Task<List<SaqueModel>> ObterTodos();
        Task<int> CriarSaque(ISaque saque);
    }
}