using System;

namespace PrimeiroMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            int nr;
            Console.WriteLine("Escreva o numero ");
            nr = Convert.ToInt32(Console.ReadLine());

            Conta(); 
            Conta();  
            ContarAteN(nr);
            ContarAteN(nr); 
        
        }
        private static void Conta(){
                ContarAteN(10);
        }
        private static void ContarAteN(int conta){
            for(int i = 1; i<= conta; i++){
                    Console.Write($"{i},");
            }
            Console.WriteLine(" ");
        }
    }
}
