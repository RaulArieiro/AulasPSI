using System;

namespace Skynet
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            double nr;
            double n;
            string ex = " ";

            while (ex != "EXIT" && ex != "Exit")
            {

                Console.WriteLine("Se quiser acabar o programa escreva Exit ");
                ex = Console.ReadLine();

                if (ex != "Exit" && ex != "EXIT")
                {
                    Console.WriteLine("Faça uma pergunta ");
                    str = Console.ReadLine();
                    switch (str)
                    {
                        case "A capital da Alemanha ":
                            Console.WriteLine("Berlim");
                            break;

                        default:
                            Console.WriteLine("Sem resposta");
                            break;
                    }
                    Console.WriteLine("Adicione dois numeros ");

                    nr = Convert.ToDouble(Console.ReadLine());
                    n = Convert.ToDouble(Console.ReadLine());
                    if (nr * n > 0)
                    {
                        Console.WriteLine("O resultado e possitivo ");
                    }

                }

            }
        }
    }
}
