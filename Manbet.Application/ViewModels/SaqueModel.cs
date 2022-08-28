using System;
using System.Collections.Generic;
using System.Text;

namespace Manbet.Application.ViewModels
{
    public class SaqueModel
    {
        public SaqueModel(int id, float valor, DateTime data, string destino)
        {
            Id = id;
            Valor = valor;
            Data = data;
            Destino = destino;
        }

        public int Id { get; set; }
        public float Valor { get; set; }
         public DateTime Data { get; set; }
        public string Destino { get; set; }
    }
}