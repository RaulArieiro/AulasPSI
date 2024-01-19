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

        TextReader fte = File.OpenText("edrferfer.txt");

       for(int i = 0; i < 3; i++){
        Console.WriteLine(fte.ReadLine());
         
       }

  fte.Close();   
  }          



    }
}