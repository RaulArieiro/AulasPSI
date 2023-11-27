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
                Console.Write("Escreva o nome do teu adversario ");
                po = Console.ReadLine();
                Inimigo pa = new Inimigo(po);
                ini[i] = pa;
            }
            Console.WriteLine(" ");

            for(int i = 0; i<npc; i++){
                Console.WriteLine($"O nome do inimigo é {ini[i].GetNome()}");
            }
                for(int i = 0; i<npc; i++){
                int dano ;
            
                Console.Write("Escolha o valor de dano ");
                dano = Convert.ToInt32(Console.ReadLine());
                ini[i].Danificar(dano);
                if(ini[i].GetVida() <= 0){
                    Console.WriteLine($"{ini[i].GetNome()} Inimigo morreu");
                } 
                Console.WriteLine($"O dano é {dano}");
            }
             for(int i = 0; i<npc; i++){
                Console.Write($"{ini[i].GetNome()} tem ");
                Console.WriteLine($"{ini[i].GetVida()} de vida restante");

                Console.WriteLine($"O inimigo tem {ini[i].GetEscudo()} de escudo \n");
            }
            for(int i = 0; i<npc; i++){
                int abastece;

                Console.Write("Escreva quanto quer curar do escudo ");
                abastece = Convert.ToInt32(Console.ReadLine());
                ini[i].Abastecer(abastece, Abastecimento.Escudo);

                Console.Write("Escreva quanto quer curar da vida ");
                abastece = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                ini[i].Abastecer(abastece, Abastecimento.Vida);

            }
            for(int i = 0; i<npc; i++){
                Console.WriteLine($"O {ini[i].GetNome()} tem {ini[i].GetVida()} de hp e de escudo {ini[i].GetEscudo()}");

            }
        }
    }
}
