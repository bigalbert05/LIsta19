using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    class Curso
    {
        private string descrição;
        private List<Turma> turmas = new List<Turma>();

        public Curso(string d)
        {
            descrição = d;
        }
        public void AdicionarTurma(Turma t)
        {
            turmas.Add(t);
        }
        public List<Turma> ListarTurma()
        {
            Turma[] lis = new Turma[turmas.Count];
            int y = 0;
            foreach (Turma k in turmas)
            {
                lis[y++] = k;
            }
            Array.Sort(lis);
            return lis;
        }
    }
}
