using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Domain.Entities
{
    public class Aluno
    {
        public int matricula { get; set; }
        public int Idade { get; set; }
        public string Nome { get; set; }
        public string? Peso { get; set; }
        public string? Altura { get; set; }
    }
}
