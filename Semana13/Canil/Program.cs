using System;
using System.Collections.Generic;

namespace Canil
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Animal> lista = new List<Animal>();
            
            bool encerrar = false;
            
            while(!encerrar){     
                Console.WriteLine("Escreva o nome do seu animal");
                string Name = Console.ReadLine();
                Console.WriteLine("Escreva o peso do animal");
                double peso = Convert.ToDouble(Console.ReadLine());
                lista.Add(new Animal(Name, peso));

                Console.WriteLine("Deseja continuar nao escreva (Y)");
                if(Console.ReadLine() == "Y"){
                encerrar = true;
                }
                lista.Sort();
            }

            Console.WriteLine("Diga o peso minimo");
            double le = Convert.ToDouble(Console.ReadLine());  
            
            IEnumerable<Animal> nova = GetAnimaisComPesoMaiorQue(le, lista);
        
              foreach(Animal Roni in nova){
                Console.WriteLine($"O nome {Roni.Nome}");
                Console.WriteLine($"O peso {Roni.Peso}");

              }
        }
        
        static IEnumerable<Animal> GetAnimaisComPesoMaiorQue(double a, List<Animal> b){
                    
            foreach(Animal Guilherme in b){
                if(Guilherme.Peso > a){
                   yield return Guilherme; 
                }
            }          
        }
    }
}
