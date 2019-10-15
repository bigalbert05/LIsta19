using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    class Aluno : IComparable
    {
        public string nome { get; set; }
        public string matricula { get; set; }

        public int CompareTo(object obg)
        {
            Aluno f = obg as Aluno;
            return this.nome.CompareTo(f.nome);
        }
    }
}
