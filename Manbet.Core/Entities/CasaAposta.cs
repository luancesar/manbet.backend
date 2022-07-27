using System;
using System.Collections.Generic;
using System.Text;

namespace Manbet.Core.Entities
{
    public class CasaAposta
    {
        protected CasaAposta() { }
        public CasaAposta( string nome)
        {
            Nome = nome;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public void SetId(int id)
        {
            Id = id;
        }
    }
}
