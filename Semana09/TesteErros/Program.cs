using System;

namespace TesteErros
{
    class Program
    {
        static void Main(string[] args)
        {
            try{

            Console.WriteLine("Insere um numero interio: ");
            int i= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Numero inteiro: {i}");

            }catch(FormatException){    
                //Numero diferente de inteiro
                Console.WriteLine("Numero diferente de int");
            }catch(OverflowException){
                //Numero muito grande
                Console.WriteLine("Numero grante");
            }catch(Exception){
                Console.WriteLine("Alguma coisa ");
            }finally{
                Console.WriteLine("Acabou ");
            }
            
        }

    }
}
