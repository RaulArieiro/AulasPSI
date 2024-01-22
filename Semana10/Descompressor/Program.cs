using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.IO.Compression;


namespace Descompressor
{
    class Program
    {
        static void Main(string[] args)
        {
            string escreve;
            Console.WriteLine("Queres comprimir ou descomprimir");
            escreve = Console.ReadLine();
            if(escreve == "Comprimir " || escreve == "comprimir" ){
                Comprime();
                Console.WriteLine("Comprimida com sucesso ");
            }else if(escreve == "Descomprimir " || escreve == "descomprimir"){
                Descomprime();
                    Console.WriteLine("Descomprimido com sucesso ");
            }else{
                Console.Write("Aconteceu um erro");
            }
        }
        static void Comprime(){
            string line;

                    using (FileStream fs = new FileStream("ficheiro.txt.gz", FileMode.Create, FileAccess.Write)){
                        using (GZipStream gzs = new GZipStream(fs, CompressionLevel.Optimal)){
                        
                        using (StreamWriter sw = new StreamWriter(gzs)){
                        while ((line = Console.ReadLine()).Length > 0)
                                {
                                sw.WriteLine(line);

                                }
                            }
                        }
                    }
        }
        static void Descomprime(){
            string line;
            using (FileStream aceder = new FileStream("ficheiro.txt.gz", FileMode.Open, FileAccess.Read)){
             using (GZipStream des = new GZipStream(aceder, CompressionMode.Decompress)){
                using (StreamReader re = new StreamReader(des))
                using (StreamWriter le = new StreamWriter("ficheiro.txt")){
                    while((line = re.ReadLine()) != null){
                        Console.WriteLine(line);
                        le.WriteLine(line); 
                 }   
              }
            }            
          }             
        }
    }
}
