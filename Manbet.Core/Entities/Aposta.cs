using Manbet.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manbet.Core.Entities
{
    public class Aposta
    {
        public int Id { get; set; }
        public float ValorAposta  { get; set; }
        public float ODD { get; set; }
        public StatusApostaEnum Status { get; set; }
        public CasaAposta CasaAposta { get; set; }
            
    }
}
