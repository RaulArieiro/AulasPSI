using System;

namespace Unidades4X 
{
    public class UnidadeColonizadora :Unidade
    {
        private int movimento
        public int Vida{get; set;}
        public override Valor float{get;set;}

        Valor = 5;
    
        public override string Mover(){
            return "Andou 300 metros ";
        }
        public void Colonizar(){
            Console.WriteLine("Colozou o novo territorio ");
        }

    }
}
