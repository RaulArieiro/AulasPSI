using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorAnimais
{
    public class Gato : Animal, IMamifero
    {
        public override string Som(){
        return base.Som() + "Miau";
        }
        public int NumeroDeMamilos{get{return 8;}}
    }
}