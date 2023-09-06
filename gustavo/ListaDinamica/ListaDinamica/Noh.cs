using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDinamica
{
	class Noh
	{
		string valores;
		Noh anterior;
		Noh proximo;

		public string Valores
		{
			get { return valores; }
			set { valores = value; }
		}
		public Noh Anterior
		{
			get { return anterior; }
			set { anterior = value; }
		}
		public Noh Proximo
		{
			get { return proximo; }
			set { proximo = value; }
		}

	}
}
