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
			nomes.Inserir(1, "picanha assada");
            Console.WriteLine();
            Console.WriteLine();
			Console.WriteLine("////////////////////Imrpimindo:...");
            nomes.Imprimir();

            Console.WriteLine("////////////////////Imprimindo:...");
            nomes.Inserir(2, "churrasco");
            nomes.Imprimir();

            Console.WriteLine("////////////////////Imprimindo:...");
            nomes.Inserir(4, "churrasco");
            nomes.Imprimir();

            nomes.Inserir(8, "churrasco");
            Console.WriteLine("////////////////////Imprimindo:...");
            nomes.Imprimir();

            Console.ReadKey();

		}
	}
}
