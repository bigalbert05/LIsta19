using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Agenda
    {
        private List<contato> cs = new List<contato>();

        public void Inserir(contato c)
        {
            cs.Add(c);
        }
        public List<contato> Listar()
        {
            return cs;
        }
        public List<contato> Pesquisar(string inicio)
        {
            List<contato> r = new List<contato>();
            foreach (contato i in cs)
            {
                for (int j = 0; j < inicio.Length; j++)
                {
                    if (inicio[j] != i.nome[j]) break;
                }
                r.Add(i);
            }
            return r;
        }
        //public void Salvar(string arquivo){
        //XmlSerializer x = new XmlSerializer(typeof (List<contato>));
        //StreamWriter f = new  StreamWriter(arquivo,false,Encoding.Defaut);
        //x.Serialize(f,contato);
        //f.Close();
        //}
        public void Abrir()
        {

        }
    }
}
