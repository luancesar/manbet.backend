using System;
using System.Collections.Generic;
using System.Text;

namespace Manbet.Core.Entities
{
    public class Saque
    {

        protected Saque() { }
        public Saque( float valor, DateTime data, string destino)
        {
            Valor = valor;
            Data = data;
            Destino = destino;
        }
        public int Id { get; set; }
        public float Valor { get; set; }
        public DateTime Data { get; set; }
        public string Destino { get; set; } 

        public void SetId(int id)
        {
            Id = id;
        }
    }
}
