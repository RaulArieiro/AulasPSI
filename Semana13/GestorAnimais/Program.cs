using System;

namespace GestorAnimais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Animais aleatorios");
            Random random = new Random();
            Animal[] zoo = new Animal[4];
            zoo[0] = new Abelha();
            zoo[1] = new Cao();
            zoo[2] = new Gato();
            zoo[3] = new Morcego();
            Animal[] ZOO = new Animal[10];


            for(int i = 0; i < 10; i++){
                ZOO[i] = zoo[random.Next(0, 4)]; 
                Console.WriteLine($"\n{ZOO[i].Som()}");

                if(ZOO[i] is IMamifero){
                    Console.WriteLine($"Numero de mamilos {((IMamifero)ZOO[i]).NumeroDeMamilos}");
                }
                if(ZOO[i] is IVoador){
                    Console.WriteLine($"Numero de asas {((IVoador)ZOO[i]).NumeroDeAsas}\n");
                }              
            }   
        }
    }
}
