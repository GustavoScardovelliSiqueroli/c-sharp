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

		public void Inserir(int Resp, string Valor)
		{
            if (Resp <= Quantidade && Resp >0)
            {
                Noh n1 = primeiro;
                Noh na = primeiro; //noh anterior

                if (Resp == 1)
                {
                    primeiro.Valores = Valor;
                }
                else
                {
                    for (int i = 1; i < Resp - 1; i++)
                    {
                        na = na.Proximo;
                    }
                    for (int i = 1; i < Resp; i++)
                    {
                        primeiro = primeiro.Proximo;
                    }
                    primeiro.Proximo = na.Proximo.Proximo;
                    primeiro.Anterior = na;
                    primeiro.Valores = Valor;
                    primeiro = n1;
                }



            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Posição fora da lista!!");
                Console.WriteLine();
            }

		}

		public void Imprimir()
		{
			Noh ni = primeiro;
			for (int i = 1; i <= Quantidade ; i++)
			{
				Console.WriteLine(ni.Valores);
				ni = ni.Proximo;
			}
            Console.WriteLine();

		}








		////////////////////////////////////////////////////////////////////////////////
	}
}
