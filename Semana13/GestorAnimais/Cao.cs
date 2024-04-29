using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorAnimais
{
    public class Cao : Animal, IMamifero
    {
        public override string Som(){
        return base.Som() + "Au";
        }
        public int NumeroDeMamilos{get{return 7;}}
        
    }
}