using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Models
{
    [Table("T_CORRIDA")]
    public class Corrida
    {
        [Key]
        [Column("cd_corrida")]
        public int CorridaId { get; set; }
        [Column("nm_corrida")]
        public string Nome { get; set; }
        [Column("vl_distancia")]
        public float Distancia { get; set; }
        [Column("ds_premiacao")]
        public bool Premiacao { get; set; }
        [Column("ds_categoria")]
        public Categoria Categoria { get; set; }
        
    }

}
