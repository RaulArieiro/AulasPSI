using System;

namespace Unidades4X
{
    public class UnidadeMilitar :Unidade
    {
        private int movimento;
        public override int Vida{get;set;} = base.Vida + XP; 
        public int PoderAtaque{get;set;}
        public int XP{get;set;}
        public override Valor float{get;set;} = PoderAtaque + XP;

        Vida = base.Vida + XP;
        Valor = PoderAtaque + XP;

        public override string Mover(){
            return "Moveu - se 1 Km ";
       }
       public void Atacar(UnidadeMilitar tr){
                Console.WriteLine("Atacou a unidade tr ");
       }

    }
}
