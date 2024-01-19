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
            string line;
            string li;
            double real;
            int n;

            li = "Adeus meu";
            real = 2.1231;
            n = 213;
                     
            TextWriter fte = File.CreateText("edrferfer.txt");
            fte.WriteLine(li);
            fte.WriteLine(n);
            fte.WriteLine(real);
            
fte.Close();

        }
    }
}
