using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorAnimais
{
    public class Morcego : Animal, IMamifero, IVoador
    {
        public override string Som(){
        return base.Som() + "Ziqqq";
        }
        public int NumeroDeMamilos{get{return 4;}}
        public int NumeroDeAsas{get{return 2;}}
    }
}