using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Models
{
    public class Corrida
    {
        [HiddenInput]
        public int CorridaId { get; set; }
        public string Nome { get; set; }
        public float Distancia { get; set; }
        public bool Premiacao { get; set; }
        public Categoria Categoria { get; set; }

        //Relacionamento
        public Trajeto Trajeto { get; set; }
        public int TrajetoId { get; set; }

        public IList<Medalha> Medalhas { get; set; }

        public IList<CorridaAtleta> CorridaAtletas { get; set; }
    }
}
