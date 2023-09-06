using System;

namespace restodasoma
{
    class Program
    {
        static void Main(string[] args)
        {
            int resposta1 = 0, resposta2 = 0;   //Variaveis para deixar o usuario decidir qual numero irá dividir 

            void pergunta() 
            {
            Console.WriteLine("Divir:  ");                            //Recolhendo a resposta 
            resposta1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por:  ");
            resposta2 = Convert.ToInt32(Console.ReadLine());
            }
            pergunta();

            while (resposta1 < resposta2)
            {
                Console.Clear();
                Console.WriteLine("Valores inválidos. Por favor, monte uma divisão inteira...");
                Console.WriteLine();
                pergunta();
            }

            if (resposta1 == resposta2)
            {
                Console.WriteLine();
                Console.WriteLine("Resto 0");
            }
            else
            {

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("////////////// Retornando valores ////////////////");
                Console.WriteLine();


                Console.Write("Valor da função recursiva:  ");
                Console.WriteLine(recursiva(resposta1, resposta2));   //chamando a função recursiva com os parametros definidos pelo usuario

                Console.Write("Valor da função tradicional:  ");
                Console.WriteLine(tradicional(resposta1, resposta2));
            }


            int recursiva(int valor1, int valor2) 
            {
                int resto;

                if (valor1 < valor2) //Cso base 1
                {
                    resto = valor1;
                }
                else
                {
                    resto =  recursiva(valor1 - valor2, valor2);
                }
                return resto;
            }

            int tradicional(int valor1, int valor2)
            {
 
                    while (valor1 >= valor2)
                    {
                        valor1 = valor1 - valor2;
                    }

                return valor1;
            }

        }
    }
}
