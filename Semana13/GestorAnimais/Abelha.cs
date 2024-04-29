using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorAnimais
{
    public class Abelha : Animal, IVoador
    {
        public override string Som(){
        return base.Som() + "Bizzz";
        }
        public int NumeroDeAsas{get{return 2;}}
    }
}