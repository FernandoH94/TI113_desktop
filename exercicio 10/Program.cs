﻿namespace exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Informe o valor da Tabuada: ");
                int num = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                    Console.WriteLine($"{num} X {i} = {num * i}");

                Console.Write("Você deseja sair? S = Sim / N = Não ");
                string op = Console.ReadLine()!;
                sair = (op == "S");

            }
            while (sair == false);



        }
    } 
}

