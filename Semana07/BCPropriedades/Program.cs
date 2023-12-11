using System;

namespace BCPropriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar várias cores
            Cor c1 = new Cor(200, 0, 255);
            Cor c2 = new Cor(147, 55, 0);
            Cor c3 = new Cor(0, 120, 150);

            // Criar várias bolas
            Bola b1 = new Bola(c1, 10.5);
            Bola b2 = new Bola(c2, 5.7);
            Bola b3 = new Bola(c3, 19.1);

            // Guardar cor associada a cada bola 
            // em novas variáveis
            Cor b1Cor = b1.Cor;
            Cor b2Cor = b2.Cor;
            Cor b3Cor = b3.Cor;

            // Atirar cada bola algumas vezes
            b1.Atirar();
            b2.Atirar();
            b3.Atirar();
            b2.Atirar();
            b1.Atirar();
            b1.Atirar();

            // Rebentar algumas bolas
            b2.Pop();
            b1.Pop();

            // Tentar atirar as bolas outra vez
            b1.Atirar();
            b2.Atirar();
            b3.Atirar();

            // Imprimir estado de cada bola
            Console.WriteLine("Bola 1");
            Console.WriteLine("- Cor");
            Console.WriteLine($"-- R: {b1Cor.Red}");
            Console.WriteLine($"-- G: {b1Cor.Green}");
            Console.WriteLine($"-- B: {b1Cor.Blue}");
            Console.WriteLine($"- Vezes atirada: {b1.VezesAtirada}");

            Console.WriteLine();

            Console.WriteLine("Bola 2");
            Console.WriteLine("- Cor");
            Console.WriteLine($"-- R: {b2Cor.Red}");
            Console.WriteLine($"-- G: {b2Cor.Green}");
            Console.WriteLine($"-- B: {b2Cor.Blue}");
            Console.WriteLine($"- Vezes atirada: {b2.VezesAtirada}");

            Console.WriteLine();

            Console.WriteLine("Bola 3");
            Console.WriteLine("- Cor");
            Console.WriteLine($"-- R: {b3Cor.Red}");
            Console.WriteLine($"-- G: {b3Cor.Green}");
            Console.WriteLine($"-- B: {b3Cor.Blue}");
            Console.WriteLine($"- Vezes atirada: {b3.VezesAtirada}");
        

        }
    }
}
