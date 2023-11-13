using System;

namespace OMeuJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            Inimigo soldado = new Inimigo("Soldado "); 
            Inimigo[] ini; 
            int npc = 0;
    

            Console.Write("Escreva o numero de inimigos ");
            npc = Convert.ToInt32(Console.ReadLine());
            ini = new Inimigo[npc];

            for(int i = 0; i<npc; i++){
                string po;
                Console.WriteLine("Escreva o nome do teu adversario ");
                po = Console.ReadLine();
                Inimigo pa = new Inimigo(po);
                ini[i] = pa;
            }

            for(int i = 0; i<npc; i++){
                Console.WriteLine($"{ini[i].GetNome()}");
            }
            /*Console.WriteLine($"Nome do inimigo: {soldado.GetNome()}");
            Console.WriteLine($"Vida do inimigo: {soldado.GetVida()}");
            soldado.Danificar(70);
            Console.WriteLine($"Vida do inimigo danificado: {soldado.GetVida()}");*/
        }
    }
}
