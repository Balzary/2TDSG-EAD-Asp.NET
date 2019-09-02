using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Fiap.Web.AspNet.Models
{
    [Table("TblZoo")]
    public class Zoo
    {
        [Column("Id")]
        public int ZooId { get; set; }

        public int Jaulas { get; set; }

        [Required, DataType(DataType.Date), Display(Name = "Data de Lançamento")]
        public DateTime DataAbertura { get; set; }

        [Required, MaxLength(50)]
        public string Nome { get; set; }        

        [Display(Name ="Tipo")]
        public Tipo EntidadeAdministradora { get; set; }



    }
}
