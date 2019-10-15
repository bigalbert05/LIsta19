using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtora
{
    class Construtora
    {
        private List<Funcionario> funcs = new List<Funcionario>();

        public void Inserir(Funcionario c)
        {
            funcs.Add(c);
        }
        public List<Funcionario> Funcionario()
        {
            return funcs;
        }
        public List<Engenheiro> Engenheiro()
        {
            List<Engenheiro> Emg = new List<Engenheiro>();
            foreach (Funcionario i in funcs)
            {
                if (i is Engenheiro) Emg.Add(i as Engenheiro);
            }
            return Emg;
        }
        public List<Motorista> Motorista()
        {
            List<Motorista> mot = new List<Motorista>();
            foreach (Funcionario y in funcs)
            {
                if (y is Motorista) mot.Add(y as Motorista);
            }
            return mot;
        }
    }
}
