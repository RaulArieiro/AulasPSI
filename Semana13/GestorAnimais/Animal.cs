using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorAnimais
{
    public class Animal
    {
        public virtual string Som(){
	        return "Animal faz o som: ";
        }
    }
}