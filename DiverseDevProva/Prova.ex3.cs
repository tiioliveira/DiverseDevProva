// See https://aka.ms/new-console-template for more information
using System;
using System.Data.SqlTypes;
using System.Globalization;
using System.Threading.Channels;

namespace DiverseDev
{
    class Desafios
    {

        static void Main(string[] args)
        {
                string frase;
                int maiusculo = 0;
                int minuscula = 0;
                int inicioMaiusculo = 0;
                int inicioMinuscula = 0;

                Console.Write("Digite uma frase:");
                frase = Console.ReadLine();

                
                string[] palavras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
         

                foreach (string palavra in palavras)
                {
                    if (palavra.Length > 0)
                    {
                        if (char.IsUpper(palavra[0]))
                        {
                            inicioMaiusculo++;
                        }
                        else if (char.IsLower(palavra[0]))
                        {
                            inicioMinuscula++;
                        }

                        if (palavra.All(char.IsUpper))
                        {
                            maiusculo++;
                        }
                        else if (palavra.All(char.IsLower))
                        {
                            minuscula++;
                        }
                    }
                }

                int totalPalavras = palavras.Length;


                Console.WriteLine("Palavras que iniciam com letra maiúscula: " + inicioMaiusculo);
                Console.WriteLine("Palavras que iniciam com letra minúscula: " + inicioMinuscula);
                Console.WriteLine("Palavras maiúsculas: " + maiusculo);
                Console.WriteLine("Palavras minúsculas: " + minuscula);
                Console.WriteLine("Total de palavras: " + totalPalavras);


            }
        }

    }

