namespace Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digitar a primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digitar a primeira nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            Console.WriteLine($"A média é: {media:F2}");

            if(media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else if (media >= 5)
            {
                Console.WriteLine("Recuperação");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }

        }
    }
}
