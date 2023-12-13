using System;

namespace PrimeiroMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int nr;
            //int n1;
            //int n2;

            //Console.WriteLine("Escreva o numero ");
            //nr = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(Fibonacci(8));
            /*Conta();
            Console.WriteLine("Escreva um numero ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escreve "); 
            n2 = Convert.ToInt32(Console.ReadLine()); 
            ContarAteN(n1,n2);
            ContarAteN(nr);*/
        
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

        private static void ContarAteN(int n1,int n2){
            for(int i = n1; i<= n2; i++){
                    Console.Write($"{i},");
            }
            Console.WriteLine(" ");
        }
        
        private static int Fibonacci(int n){
            int nr2;

            if(n <= 2){
                nr2 = 1;
            }else{
                nr2 = Fibonacci(n- 1) + Fibonacci(n - 2)  ;
            }

            return nr2; 
        } 
  }
}
