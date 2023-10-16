using System;

namespace Omissor
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            char l;
    
            Console.WriteLine("Escreva uma frase ");
            s = Console.ReadLine();
            Console.WriteLine("Escreva uma letra para desaparecer");
            l = Convert.ToChar (Console.ReadLine());

            foreach(char c in s){
                if(c != l )
                Console.Write(c);
            }
        }
    }
}
