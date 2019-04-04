using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivroLista
{
    class Exemplar
    {
        private int tombo;
        private List<Emprestimo> emprestimos;

        public Exemplar()
        {
            this.tombo = 0;
            this.emprestimos = new List<Emprestimo>();
        }

        public Exemplar(int tombo, List<Emprestimo> emprestimos)
        {
            this.tombo = tombo;
            this.emprestimos = emprestimos;
        }


        public bool emprestar()
        {
            this.emprestimos.Add(new Emprestimo(DateTime.Today));
            return true;
        }

        public bool devolver()
        {
            this.emprestimos[emprestimos.Count - 1].DtDevolucao = DateTime.Today;
            return true;
        }

        public bool disponivel()
        {
            if(this.emprestimos[emprestimos.Count - 1].DtDevolucao ==  null)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public int qtdeEmprestimos()
        {
            return emprestimos.Count;
        }

    }
}
