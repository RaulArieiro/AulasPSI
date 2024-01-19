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

                    FileStream fs = new FileStream("ficheiro.txt.gz", FileMode.Create, FileAccess.Write);

                    GZipStream gzs = new GZipStream(fs, CompressionLevel.Optimal);

                    StreamWriter sw = new StreamWriter(gzs);

while ((line = Console.ReadLine()).Length > 0)
{
    sw.WriteLine(line);
}

sw.Close();


        }
        static void Descomprime(){
            string line;
            FileStream aceder = new FileStream("ficheiro.txt.gz", FileMode.Open, FileAccess.Read);
            GZipStream des = new GZipStream(aceder, CompressionMode.Decompress);
            StreamReader re = new StreamReader(des);
            StreamWriter le = new StreamWriter("ficheiro.txt");

            while((line = re.ReadLine()) != null){
                Console.WriteLine(line);
                le.WriteLine(line); 
            } 
            re.Close();
            le.Close();
        }
    }
}
