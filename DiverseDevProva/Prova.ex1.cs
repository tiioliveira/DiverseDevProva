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
                
            int positivo = 0;
            int negativo = 0;
            int par = 0;
            int impar = 0;
            int j = 5;
            int[] num = new int[j];



            for (int i = 0; i < j; i++)
                {
                    Console.Write($"Digite o valor {i + 1}:");
                    num[i] = int.Parse(Console.ReadLine());

                    
                    if (num[i] % 2 == 0)
                    {
                        par++;
                    }
                    else
                    {
                        impar++;
                    }

                    
                    if (num[i] > 0)
                    {
                        positivo++;
                    }
                    else if (num[i] < 0)
                    {
                        negativo++;
                    }
                }


            Console.WriteLine("\nValores positivos: " + positivo);
            Console.WriteLine("\nValores negativos: " + negativo);
            Console.WriteLine("\nValores pares: " + par);
            Console.WriteLine("Valores ímpares: " + impar);

            }
        }










    }
