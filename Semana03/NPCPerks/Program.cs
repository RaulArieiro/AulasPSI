using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
           Raca[] tiporaca;
           Classes[] tipoclass; 
           Comportamento[] tipocompor;
           int escolher;
           int npc;

           Console.WriteLine("Escolha o numero de NPC");
           escolher =Convert.ToInt32(Console.ReadLine());

           tiporaca = new Raca[escolher];
           tipoclass = new Classes[escolher];
           tipocompor = new Comportamento[escolher];

           Console.WriteLine("Aqui estao todas as raca possiveis escolha uma "); 

            for(int j = 0; j<escolher; j++)
            {
                for(int i = 0; i< Enum.GetNames(typeof(Raca)).Length; i++){
                    Console.WriteLine($"{(Raca) i}");
                } 
            npc = Convert.ToInt32 (Console.ReadLine());
            npc -=1;
            tiporaca[j] = (Raca)npc; 
            }
            
            Console.WriteLine("Agora aqui estao as informacoes de classes disponiveis ");

            for(int j = 0; j<escolher; j++)
            {
                for(int i = 0; i< Enum.GetNames(typeof(Classes)).Length; i++){
                    Console.WriteLine($"{(Classes) i}");
                } 
            npc = Convert.ToInt32 (Console.ReadLine());
            npc -=1;
            tipoclass[j] = (Classes)npc; 
            }
        
            Console.WriteLine("Agora o comportamento e personaliade ");

            for(int j = 0; j<escolher; j++)
            {
                for(int i = 0; i< Enum.GetNames(typeof(Comportamento)).Length; i++){
                    Console.WriteLine($"{(Comportamento) i}");
                } 
            npc = Convert.ToInt32 (Console.ReadLine());
            npc -=1;
            tipocompor[j] = (Comportamento)npc;
            }  
            for(int i = 0; i <escolher; i++){
                Console.WriteLine($"NPC {i+ 1} : ");
                Console.WriteLine($"\t Raca: {tiporaca[i]} ");
                Console.WriteLine($"\t Classes: {tipoclass[i]} ");
                Console.WriteLine($"\t Comportamento: {tipocompor[i]} ");
            }
        }
    }
}