using System;
using System.IO;
using System.Runtime.Intrinsics.X86;

namespace NomeDoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktop, "File.txt");
            string[] sr = new string[1000] ;
            int indice = 0;
            string guarda;

           Console.WriteLine("Escreve");

        do{
            guarda = Console.ReadLine();   
            sr[indice] = guarda;
            
            indice++;
        }while(guarda != "");
        File.WriteAllLines(filePath,sr);
            } 

    
    
        }
    }
       
}
