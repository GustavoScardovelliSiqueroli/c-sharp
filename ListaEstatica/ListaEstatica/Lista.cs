using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//DESENVOLVER OS MÉTODOS ABAIXO
/*
 * 
 * Inserir no Final da Lista            --------> OK!
 * Inserir na posição desejada          --------> OK!
 * 
 * Excluir do final da Lista            --------> OK!
 * Excluir da posição desejada          --------> OK!
 * 
 * Imprimir todos da lista              --------> OK!
 * Imprimir intervalo                   --------> OK!
 * 
 * Ordenação Crescente / Decrescente    --------> OK!
 * 
 * Localizar valor na lista             --------> OK!
 * 
*/
namespace ListaEstatica
{
    class Lista
    {
        string[] valores;
        int limite;
        int final, inicio;

        /// <summary>
        /// O construtor deve ter o mesmo nome da classe 
        /// </summary>
        /// <param name="Tamanho"></param>
        public Lista(int Tamanho)
        {
            // Definindo o tamanho do vetor
            valores = new string[Tamanho];
            // Guardando o tamanho definido pelo usuário na var limite
            limite = Tamanho - 1;
            // Definindo os valores iniciais para Inicio e Final
            inicio = -1;
            final = -1;
        }

        public void Inserir(string valor)
        {
            // verificar se a lista está cheia
            if (final < limite)
            {
                final++;
                valores[final] = valor;
            }
            else
            {
                Console.WriteLine("Lista cheia!");
            }
        }

        public void Inserir(string valor, int posicao)
        {
            if (final < limite) // Verificando se há espaço na lista
            {
                if ((posicao >= 0) && (posicao <= limite)) // posicao válida 
                {
                    final++;
                    for (int i = 0; i < (final - posicao); i++)
                    {
                        valores[final - i] = valores[(final - 1) - i];
                    }
                    valores[posicao] = valor;
                }
                else
                {
                    Console.WriteLine("Posição fora da lista!");
                }
            }
            else
            {
                Console.WriteLine("A Lista está cheia!");
            }



        }

        // Imprime todos os valores da Lista
        public void Imprimir()
        {
            if (final >= 0)
            {
                for (int i = 0; i <= final; i++)
                {
                    Console.WriteLine(valores[i]);
                }
            }
            else
            {
                Console.WriteLine("Lista vazia!");
            }
        }

        public void Imprimir(int comeco, int fim)
        {
            if (final > fim)
            {
                for (int i = comeco; i <= fim; i++)
                {
                    Console.WriteLine(valores[i - 1]);
                }
            }
        }

        // Exclusão do último elemento da lista
        public void Excluir()
        {
            if (final >= 0)
            {
                valores[final] = "";
                final--;
            }
        }

        public void Excluir(int posicao)
        {
            if (final >= 0)
            {
                for (int i = posicao; i <= final; i++)
                {
                    valores[posicao - 1] = valores[posicao];
                    posicao++;
                }
                //valores[final] = "";
                final--;
            }

        }

        public void Ordenar(int ordem)
        {
            string aux = "";

            if (ordem == 0) //crescente
            {
                for (int i = 0; i < final; i++)
                {
                    for (int j = i + 1; j <= final; j++)
                    {
                        if (valores[i].CompareTo(valores[j]) == 1)
                        {
                            aux = valores[i];
                            valores[i] = valores[j];
                            valores[j] = aux;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < final; i++)
                {
                    for (int j = i + 1; j <= final; j++)
                    {
                        if (valores[i].CompareTo(valores[j]) == -1)
                        {
                            aux = valores[i];
                            valores[i] = valores[j];
                            valores[j] = aux;
                        }
                    }
                }
            }
        }

        public int Localizar(string valor)
        {
            int i = 0;

            int achei = 0;

            while (i <= final)
            {
                if (valores[i].CompareTo(valor) == 0)
                {
                    achei = i + 1;
                }
                i++;
            }

            return achei;
        }
    }
}
