using System;
using System.Collections.Generic;
using System.Text;

namespace Manbet.Core.Entities
{
    public class Saque
    {
        public int Id { get; set; }
        public float Valor { get; set; }
        public DateTime Data { get; set; }
        public string Destino { get; set; } 
    }
}
