using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Exo.WebApi.Models
{
    public class Projeto
    {
        internal object NomeDoProjeto;

        public int Id { get; set; }
        public string Projeto { get; set; }
        public string Area { get; set; }
        public object Status { get; internal set; }
    }
}