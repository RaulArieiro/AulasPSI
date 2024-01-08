using System;

namespace Unidades4X
{
    public abstract class Unidade
    {
        private int movimento;
        public virtual int Vida{get; set;} 
        public abstract Valor float{get; set;}   

        Console.WriteLine("Escreva quanto vai mover a unidade ");
        movimento  Convert.ToInt32(Console.ReadLine());

        public abstract string Mover();
            

    }
}
