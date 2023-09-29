using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte u = 56;
            int i = 777232;

            float f = 666f;
            double dou = 9.99;

            char Letra = 'J';

            bool v = u>i;

            char Grek = '\u03A9';

            Console.WriteLine(u);
            Console.WriteLine(i);
            Console.WriteLine(f);
            Console.WriteLine(dou);
            Console.WriteLine(Letra);
            if(!v)Console.WriteLine(v);
            Console.WriteLine(Grek);
       }
    }
}
