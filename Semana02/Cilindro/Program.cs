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

            Console.WriteLine("Introduza a altura do cilindro ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduza o raio do cilindro");
            raio = Convert.ToDouble(Console.ReadLine());

            volume =  Math.PI * Math.Pow(raio,2) * altura;
            Console.Write("O valor do volume do cilindro e: ");
            Console.WriteLine(volume);
            Console.Write("O volar da superficie e: ");
            s = 2 * Math.PI * raio * (raio * altura);
            Console.WriteLine(s);

        }
    }
}
