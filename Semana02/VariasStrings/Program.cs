using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string ju = "Judeus amam churraco";
            Console.WriteLine(ju);
            string jut = "\t Judeus amam churracosssss";
            Console.WriteLine(jut);
            string jub = "\t Hitler \\Kills -1\\Assistencias 100M \\Death 1 \\\u5350";
            Console.WriteLine(jub);
            int x;
            int y;
            string s = $"{x = 999} mais {y =6} é igual a {x + y}";
            Console.WriteLine(s);
        }
    }
}
