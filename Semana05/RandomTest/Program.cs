using System;

namespace RandomTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int dado;
            int guar = 0;
            int soma = 0;

            Random rnd = new Random();           
            Console.WriteLine("Escreva o numero de vezes que o dado vai ser lancado ");
            dado = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i<dado; i++){
                guar = rnd.Next(1,7);
                Console.WriteLine($"Valor do dado {i}: {guar}");
                soma += guar;
            }
                Console.Write($"O numero da soma de todos os valores calhados no dado e {soma}");
        }

    }
}
