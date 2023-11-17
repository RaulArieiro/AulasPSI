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
                Console.WriteLine($"O nome do inimigo é {ini[i].GetNome()}");
            }
                for(int i = 0; i<npc; i++){
                int dano ;
            
                Console.Write("Escolha o valor de dano ");
                dano = Convert.ToInt32(Console.ReadLine());
                ini[i].Danificar(dano); 
                Console.WriteLine($"O dano é {dano}");
            }
             for(int i = 0; i<npc; i++){
                Console.WriteLine($"{ini[i].GetNome()}");
                Console.WriteLine($"A vida do inimigo é {ini[i].GetVida()}");
                Console.WriteLine($"O escudo do inimigo é {ini[i].GetEscudo()}");
            }
        }
    }
}
