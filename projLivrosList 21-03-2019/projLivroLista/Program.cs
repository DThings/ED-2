using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivroLista
{
    class Program
    {
        static void Main(string[] args)
        {
			Livro livro = new Livro();
			Livros livros = new Livros();
			int cont;
			int c = -1;
			while (c != 0)
			{
				Console.WriteLine("| 0. Sair |\n1.Adicionar livro\n2.Pesquisar livro(sintético)\n3.Pesquisar livro(analítico)\n4.Adicionar exemplar\n5.Registrar empréstimo\n6.Registrar devolução ");
				c = int.Parse(Console.ReadLine());
				switch (c) {
					case 0:
						break;
					case 1:
						Console.WriteLine("ISBN: ");
						livro.Isbn = int.Parse(Console.ReadLine());
						Console.WriteLine("Titulo: ");
						livro.Titulo = Console.ReadLine();
						Console.WriteLine("Autor: ");
						livro.Autor = Console.ReadLine();
						Console.WriteLine("Editora: ");
						livro.Editora = Console.ReadLine();
						Console.WriteLine("exeplares: ");
						cont = int.Parse(Console.ReadLine());
						for(int x = 0; x < cont; x++)
						{
							livro.adicionarExemplar(livro.Exemplares);
						}
						livros.adicionar(livro);
						break;
					case 2:
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						break;
					case 6:
						break;
				}
				Console.ReadKey();

			}
        }
    }
}
