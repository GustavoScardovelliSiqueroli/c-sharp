using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDinamica
{
	class Program
	{
		static void Main(string[] args)
		{
			Lista nomes = new Lista();

			nomes.Inserir("teste1");
			nomes.Inserir("teste2");
			nomes.Inserir("teste3");
			nomes.Inserir("teste4");

			nomes.Imprimir();

			Console.WriteLine();
			nomes.testecu(3, "penis");
			Console.WriteLine("buceta");

			Console.ReadKey();

		}
	}
}
