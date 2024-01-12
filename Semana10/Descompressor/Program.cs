using System;
using System.IO;
using System.IO.Compression;


namespace Descompressor
{
    class Program
    {
        static void Main(string[] args)
        {
            string escreve;
            Console.WriteLine("Qureres comprimir ou descomprimir");
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
            
            FileStream aceder = new FileStream("ficheiro.txt.gz", FileMode.Open, FileAccess.Read);
            FileStream aceder = new FileStream("ficheiro.txt.gz", FileMode.Open, FileAccess.Read);
            GZipStream des = new GZipStream(aceder, CompressionMode.Decompress);
            StreamWriter le = new StreamWriter();

        }
    }
}
