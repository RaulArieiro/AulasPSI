using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.IO.Compression;
using System.Net;


namespace LerTexto
{
  class Program
  {
    static void Main(string[] args)
      {
        string line;
        TextReader fte = File.OpenText("edrferfer.txt");

       for(int i = 0; i > 3; i++){
        fte.ReadLine();
        Console.WriteLine(fte);
        fte.ReadLine();
        Console.WriteLine(fte);
        fte.ReadLine();
        Console.WriteLine(fte);

         
       }

  fte.Close();   
  }          



    }
}