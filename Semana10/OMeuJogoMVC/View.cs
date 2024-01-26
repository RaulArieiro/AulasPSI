using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace OMeuJogoMVC
{
    public class View
    {
        InimigoController controla;
        public View (InimigoController con){
            controla = con; 
        }
        public int Inimostra(){
            Console.Write("Escreva o numero de inimigos ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public string Nome(){
            Console.Write("Escreva o nome do teu adversario ");
            return Console.ReadLine();
        }
        public void MostraNome(Inimigo[] ini, int i){

            Console.WriteLine($"O nome do inimigo é {ini[i].GetNome()}");        
        }
        public int Dano(){
            Console.WriteLine("Escolha o valor de dano ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public void Daniicar(Inimigo[] ini, int dano, int i){
             if(ini[i].GetVida() <= 0){
                    Console.WriteLine($"{ini[i].GetNome()} Inimigo morreu");
                } 
                Console.WriteLine($"O dano é {dano}");
        }
        public void ResVida(Inimigo[] ini, int i){
                Console.Write($"{ini[i].GetNome()} tem ");
                Console.WriteLine($"{ini[i].GetVida()} de vida restante");

                Console.WriteLine($"O inimigo tem {ini[i].GetEscudo()} de escudo \n");            
        }
        public int CuraVida(){
            Console.WriteLine("Escreve quanto queres curar da vida");
            return Convert.ToInt32(Console.ReadLine());
        }
        public int CuraEscudo(){
            Console.WriteLine("Escreve quanto queres curar de shield ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public void MostraALL(Inimigo[] ini, int i ){
            Console.WriteLine($"O {ini[i].GetNome()} tem {ini[i].GetVida()} de hp e de escudo {ini[i].GetEscudo()}");
        }
    }
}