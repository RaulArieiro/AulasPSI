using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Intrinsics.X86;

namespace NomeDoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktop, "File.txt");
            List<string> sr = new List<string>(); 
            int indice = 0;
            string guarda;

           Console.WriteLine("Escreve");
        
        do{
            guarda = Console.ReadLine();   
            sr.Add(guarda);
            
            indice++;
        }while(guarda != "");
        File.WriteAllLines(filePath,sr);
        


        }
    }
       
}
