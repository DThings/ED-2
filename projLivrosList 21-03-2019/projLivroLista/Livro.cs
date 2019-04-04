using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivroLista
{
    class Livro
    {
        private int isbn;
        private string titulo;
        private string autor;
        private string editora;
        private List<Exemplar> exemplares;

        public Livro()
        {
            this.isbn = 0;
            this.titulo = "";
            this.autor = "";
            this.editora = "";
            this.exemplares = new List<Exemplar>();
        }
		public Livro(Livro livro)
		{
			this.isbn = livro.isbn;
			this.titulo = livro.titulo;
			this.autor = livro.autor;
			this.editora = livro.editora;
			this.exemplares =livro.exemplares;
		}

        public int Isbn
        {
            get { return this.isbn; }
            set { this.isbn = value; }
        }

        public string Titulo
        {
            get { return this.titulo; }
            set { this.titulo = value; }
        }

        public string Autor
        {
            get { return this.autor; }
            set { this.autor = value; }
        }
        public string Editora
        {
            get { return this.editora; }
            set { this.editora = value; }
        }
		public Exemplar Exemplares
		{
			get;
			set;
		}

        public void adicionarExemplar(Exemplar exemplar)
        {
            this.exemplares.Add(exemplar);
        }

        public int qtdeExemplares()
        {
            return this.exemplares.Count;
        }

        public int qtdeDisponiveis()
        {
            int qtde = 0;
            foreach(var exemplar in exemplares)
            {
                qtde += exemplar.disponivel() ? 1 : 0;
            }
            return qtde;
        }

        public int qtdeEmprestimos()
        {
            int qtde = 0;
            foreach (var exemplar in exemplares)
            {
                qtde += exemplar.qtdeEmprestimos();
            }
            return qtde;
        }

        public double percDisponibilidade()
        {
            // não sei implementar
            return 1.0;
        }

    }
}
