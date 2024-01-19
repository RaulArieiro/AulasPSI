using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.IO.Compression;


namespace EscreverTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string li;
            double real;
            int n;

            li = "Adeus judeu";
            real = 2.1231;
            n = 213;
            BinaryWriter dd = new BinaryWriter(File.Create("edrferferbi.bin"));
            dd.Write(li);
            dd.Write(n);
            dd.Write(real);
            
dd.Close();

        }
    }
}
