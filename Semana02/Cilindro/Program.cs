using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {           
            double raio;
            double altura;
            double volume;
            double s;
            double pi = 3.1415926;

            Console.WriteLine("Introduza a altura do cilindro ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduza o raio do cilindro");
            raio = Convert.ToDouble(Console.ReadLine());

            volume =  pi * (raio * raio) * altura;
            Console.WriteLine("O valor do volume do cilindro e: ");
            Console.WriteLine(volume);
            Console.WriteLine("/n O volar da superficie e: ");
            s = 2 * pi * raio * (raio * altura);

        }
    }
}
