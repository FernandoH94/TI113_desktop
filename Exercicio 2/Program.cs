﻿namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string textoMenu = @"
____________________________________________________________________________________
            Escolha um número de 1 a 7, e descubra o dia da semana.

____________________________________________________________________________________
";
            Console.WriteLine(textoMenu);
            string opcao = Console.ReadLine()!;

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Domingo");
                    break
                        ;
                case "2":
                    Console.WriteLine("Sábado");
                    break;
                case "3":
                    Console.WriteLine("Segunda-feira");
                    break;
                case "4":
                    Console.WriteLine("Terça-feira");
                    break;
                case "5":
                    Console.WriteLine("Quarta-feira");
                    break;
                case "6":
                    Console.WriteLine("Quinta-feira");
                    break;
                case "7":
                    Console.WriteLine("Sexta-feira");
                    break;
                default:
                    Console.WriteLine("Dia inválido");
                    break;
            }


        }
    }
}
