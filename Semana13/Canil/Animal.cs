using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Canil
{
    public class Animal : IComparable<Animal>
    {
        public virtual string Som(){
	        return "Animal faz o som: ";
        }
        public string Nome{get;}
        public double Peso{get; set;}
       public Animal(string name, double massa){
            Nome = name;
            Peso = massa;
        }
        public int CompareTo(Animal outro){
            if(outro == null)return 1;
            
            return (int)Peso - (int)outro.Peso; 
        }

    }
}