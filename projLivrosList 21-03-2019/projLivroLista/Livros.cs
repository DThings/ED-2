using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivroLista
{
    class Livros
    {
        private List<Livro> acervo;


        public void adicionar(Livro livro)
        {
            acervo.Add(new Livro(livro));
        }

        public Livro pesquisar(Livro livro)
        {
            foreach(var livroOriginal in this.acervo)
            {
                if (livro.Isbn.Equals(livro.Isbn))
                {
                    return livroOriginal;
                }
            }
            return new Livro();
        }
    }
}
