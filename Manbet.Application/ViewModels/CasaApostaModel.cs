using System;
using System.Collections.Generic;
using System.Text;

namespace Manbet.Application.ViewModels
{
    public class CasaApostaModel
    {
        public CasaApostaModel(int id, string nome)
        {
            Id = id;
            Nome = nome;    
        }

        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
