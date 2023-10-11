// See https://aka.ms/new-console-template for more information
using System;
using System.Data.SqlTypes;
using System.Globalization;
using System.Threading.Channels;

namespace DiverseDev
{
    class Prova
    {

        static void Main(string[] args)
        {

            int mult = 0;
            int div = 0;
            int n1;
            int n2;
               

                Console.Write("Digite o primeiro número inteiro:");
                n1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número inteiro:");
                n2 = int.Parse(Console.ReadLine());

                
                for (int i = 0; i < Math.Abs(n2); i++)
                {

                    mult += Math.Abs(n1);

                }

                
                int sinal = Math.Sign(n1) * Math.Sign(n2);


                while (Math.Abs(n1) >= Math.Abs(n2))
                {

                    n1 = n1 - (sinal * n2);
                    div++;

                }

                if ((n1 < 0 && n2 > 0) || (n1 > 0 && n2 < 0))
                {

                    div = -div;

                }

                 Console.WriteLine("Divisão Inteira: " + div);
                 Console.WriteLine("Multiplicação: " + mult);              

        }
    }

}


