using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstatica
{
    class Program
    {

        static void Main(string[] args)
        {

            Lista nomes = new Lista(5);

            string resp1, resp2;
            resp1 = "";
            while (resp1 != "0")
            {
                pergunta();
            }
            void pergunta()
            {
                Console.WriteLine();
                Console.Clear();
                Console.WriteLine("O que você deseja fazer?");
                Console.WriteLine("0- Parar codigo '-'");
                Console.WriteLine("1- imprimir lista");
                Console.WriteLine("2- Inserir valor");
                Console.WriteLine("3- Excluir valor");
                Console.WriteLine("4- Ordenar valores");
                Console.WriteLine("5- Localizar");
                Console.Write("Resposta:  ");
                resp1 = Console.ReadLine();
                Console.WriteLine();
                if (resp1 == "1")
                {

                    resposta1();


                }
                if (resp1 == "2")
                {
                    resposta2();
                }
                if (resp1 == "3")
                {
                    resposta3();
                }
                if (resp1 == "4")
                {
                    resposta4();
                }
                if (resp1 == "5")
                {
                    resposta5();
                }

            }


            void resposta1()
            {
                string nresp1, nresp2;
                Console.WriteLine("Deseja imprimir a lista toda?");
                Console.WriteLine("1- SIM");
                Console.WriteLine("2- NAO");
                Console.Write("Resposta:  ");
                nresp1 = Console.ReadLine();
                if ((nresp1 == "SIM") || (nresp1 == "sim") || (nresp1 == "s") || (nresp1 == "ss") || (nresp1 == "S") || (nresp1 == "Sim") || (nresp1 == "1"))
                {
                    Console.WriteLine();
                    Console.WriteLine("---------------Impressão da lista:---------------");
                    nomes.Imprimir();
                    Console.WriteLine();
                    Console.WriteLine("Aperte qualquer coisa para continuar...");
                    Console.ReadKey();
                    nresp1 = "";
                    nresp2 = "";
                    resp1 = "";
                    resp2 = "";

                }
                else
                {
                    string valor1, valor2;
                    Console.WriteLine("Qual posição deseja começar?");
                    Console.Write("Reposta:  ");
                    valor1 = Console.ReadLine();
                    Console.WriteLine("Qual posição deseja terminar?");
                    Console.Write("Resposta:  ");
                    valor2 = Console.ReadLine();

                    Console.WriteLine("---------------Impressão da lista:---------------");
                    nomes.Imprimir(Convert.ToInt32(valor1), Convert.ToInt32(valor2));
                    Console.WriteLine();
                    Console.WriteLine("Aperte qualquer coisa para continuar...");
                    Console.ReadKey();
                    resp1 = "";
                    resp2 = "";
                }


            }
            void resposta2()
            {
                string nresp1, nresp2;
                nresp2 = "";
                nresp1 = "";
                Console.WriteLine("Voce deseja inserir em alguma posição específica?");
                Console.WriteLine("1- SIM");
                Console.WriteLine("2- NAO");
                Console.WriteLine();
                Console.Write("Resposta:  ");
                nresp2 = Console.ReadLine();
                if ((nresp2 == "NAO") || (nresp2 == "nao") || (nresp2 == "não") || (nresp2 == "NÃO") || (nresp2 == "n") || (nresp2 == "N") || (nresp2 == "2"))
                {
                    Console.Write("O que você deseja inserir? ");
                    nresp1 = Console.ReadLine();
                    Console.WriteLine();
                    nomes.Inserir(nresp1);
                    nresp2 = "";
                    nresp1 = "";
                }
                else
                {
                    nresp1 = "";
                    nresp2 = "";
                    Console.Write("O que você deseja inserir? ");
                    nresp1 = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Em qual posição deseja inserir?  ");
                    nresp2 = Console.ReadLine();
                    Console.WriteLine();
                    nomes.Inserir(nresp1, Convert.ToInt32(nresp2)-1);

                    resp1 = "";
                    resp2 = "";
                    nresp2 = "";
                    nresp1 = "";

                }
            }

            void resposta3()
            {
                string nresp1, nresp2;
                nresp2 = "";
                nresp1 = "";
                resp1 = "";
                Console.WriteLine("Deseja excluir o ultimo valor conforme o padrão?");
                Console.WriteLine("1- SIM");
                Console.WriteLine("2- NAO");
                Console.WriteLine();
                Console.Write("Resposta:  ");
                nresp1 = Console.ReadLine();
                if (nresp1 == "1")
                {
                    nomes.Excluir();
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("A contagem das posições começa em 1");
                    Console.WriteLine("Qual posição deseja excluir?");
                    Console.Write("Resposta:  ");
                    nresp1 = Console.ReadLine();
                    nomes.Excluir(Convert.ToInt32(nresp1 ));

                }
            }
            
            void resposta4() 
            {
                string nresp1;
                Console.WriteLine("1- Crescente");
                Console.WriteLine("2- Decrescente");
                nresp1 = Console.ReadLine();
                if (nresp1 == "1")
                {
                    nomes.Ordenar(0);
                    Console.WriteLine("Lista ordenada com sucesso");
                    Console.ReadKey();
                }
                else
                {
                    nomes.Ordenar(1);
                    Console.WriteLine("Lista ordenada com sucesso");
                    Console.ReadKey();
                }
            }

            void resposta5() 
            {
                string nresp1;
                nresp1 = "";
                Console.WriteLine("Qual valor deseja localizar?");
                Console.WriteLine();
                Console.Write("Resposta:  ");
                nresp1 = Console.ReadLine();
                Console.WriteLine();
                Console.Write("O valor "+ nresp1 + " se encontra na posição ");
                Console.WriteLine(nomes.Localizar(nresp1));
                Console.ReadKey();

            }

        }
    }
}
