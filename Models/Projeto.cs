using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Exo.WebApi.Models
{
    public class Projeto
    {
        public int Id { get; set; }
        public string Projeto_Senai_FullStack { get; set; }
        public string Tecnologia { get; set; }
        public bool Cursando { get; set; }
    }
}