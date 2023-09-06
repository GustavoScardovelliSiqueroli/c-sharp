using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDinamica
{
	class Lista
	{
		Noh primeiro = null;
		Noh ultimo = null;
		int quantidade = 0;

		public int Quantidade
		{
			get { return quantidade; }
			set { quantidade = value; }
		}

		/// <summary>
		/// //////////////////////////////////////////
		/// </summary>

		public void Inserir(string Valor)
		{
			Noh nn = new Noh();
			Quantidade++;
			nn.Valores = Valor;

			if (Quantidade == 1)
			{
				primeiro = nn;
				ultimo = nn;
			}
			else
			{
				nn.Anterior = ultimo;
				ultimo.Proximo = nn;
				ultimo = nn;

			}

		}

		public void testecu(int Resp, string Valor)
		{
			Noh nn = new Noh();
			nn.Valores = Valor;
			Noh na = primeiro; //noh anterior
			Noh np = primeiro;  //noh proximo
			Quantidade++;

			for (int i = 1; i < Resp -1; i++)
			{
				na = na.Proximo;
			}
			for (int i = 1; i < Resp + 1; i++)
			{
				np = np.Proximo;
			}


			Console.WriteLine(na.Valores);
			

		}

		public void Imprimir()
		{
			Noh ni = primeiro;
			for (int i = 1; i <= Quantidade; i++)
			{
				Console.WriteLine(ni.Valores);
				ni = ni.Proximo;
			}

			Console.WriteLine(Quantidade);
		}








		////////////////////////////////////////////////////////////////////////////////
	}
}
