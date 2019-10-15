using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    class Turma:IComparable
    {
        private string semestre, disciplina;
        private List<Aluno> alunos = new List<Aluno>();
        public Turma(string s, string d)
        {
            semestre = s;
            disciplina = d;
        }

        public int NumAlunos()
        {
            return alunos.Count;
        }

        public void AdicionarAluno(Aluno a)
        {
            alunos.Add(a);
        }
        public List<Aluno> ListarAluno()
        {
            Aluno[] lis1 = new Aluno[alunos.Count];
            int s = 0;
            foreach (Aluno w in alunos)
            {
                lis1[s++] = w;
            }
            Array.Sort(lis1);
            return lis1;
        }
        public int CompareTo(object obj)
        {
            Turma g = obj as Turma;
            if (this.semestre != g.semestre) return this.semestre.CompareTo(g.semestre);
            else return this.disciplina.CompareTo(g.disciplina);
        }
    }
}
