using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
	class Program
	{
		static string[] cartasDoJogo = new string[104];
		static string[,] cartasDaMao = new string[5,11];
		static void Main(string[] args)
		{
			Random randNum = new Random();
			int caso = 1;
			while (caso != 0)
			{
				Console.Write("\n0. Finalizar\n1. Gerar Cartas\n2. Distribuir Cartas\n3. Organizar Mãos\n4. Mostrar Mãos\nInforme sua opção: ");
				caso = int.Parse(Console.ReadLine());
				Console.WriteLine();
				switch (caso)
				{
					case 0:
						break;
					case 1:
						gerarCartas();
						break;
					case 2:
						distribuirCartas();
						break;
					case 3:
						organizarMaos();
						break;
					case 4:
						mostrarMaos();
						break;
				}
				Console.ReadLine(); Console.Clear();
			}
		}
		static void gerarCartas()
		{
			int cont = 0;
			Console.WriteLine("Cartas do baralho:");
			for (int c = 1; c < 14; c++)
			{
				for (int b = 1; b < 3; b++)
				{
					for (int n = 1; n < 5; n++)
					{
						cartasDoJogo[cont] = n + "" + c.ToString("D2") + "" + b;
						Console.Write("   "+cartasDoJogo[cont]+"   ");
						cont++;
					}
				}
				Console.Write("\n");
			}
		}
		static void distribuirCartas()
		{
			Random rd = new Random();
			string aux;
			int sort = 0;
			for (int c = 0; c < 11; c++)
			{
				for (int j = 0; j < 4; j++)
				{
					sort++;
					aux = cartasDoJogo[rd.Next(104)];
					while (cartaInedita(aux) == false)
					{
                        sort++;
                        aux = cartasDoJogo[rd.Next(104)];
					}
					cartasDaMao[j, c] = aux;
					Console.WriteLine("Distribuicao: "+(c+1)+" - Jogador: "+(j+1)+" - Carta: "+cartasDaMao[j, c]);
				}
			}
			Console.WriteLine("Qtde de sorteios realizados: " + sort);
		}
		static bool cartaInedita(string carta)
		{
			for(int j=0;j<4;j++)
			{
				for(int c=0;c<11;c++)
				{
					if(carta == cartasDaMao[j,c])
					{
						return false;
					}
				}
			}
			return true;
		}
		static void organizarMaos()
		{
			int v1, v2;
			string aux;
			for (int j = 0; j < 4; j++)
			{
				for (int c1 = 0; c1 < 11; c1++)
				{
					for (int c2 = 0; c2 < c1; c2++)
					{
						v1 = Convert.ToInt32(cartasDaMao[j, c1]);
						v2 = Convert.ToInt32(cartasDaMao[j, c2]);
						if (v1 < v2)
						{
							aux = cartasDaMao[j, c1];
							cartasDaMao[j, c1] = cartasDaMao[j, c2];
							cartasDaMao[j, c2] = aux;
						}
					}
				}
			}
		}
		static void mostrarMaos()
		{
			Console.WriteLine("   Jog: 1    Jog: 2    Jog: 3    Jog: 4");
			Console.Write("\n");
			for (int c = 0; c < 11; c++)
			{
				for (int j = 0; j < 4; j++)
				{
					Console.Write("   " + cartasDaMao[j, c] + "   ");
				}
				Console.Write("\n");
			}
		}
	}
}
