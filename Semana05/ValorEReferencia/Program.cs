using System;

namespace ValorEReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int nr = 21;
            int b = nr;
            int[] mr = new int[]{3, 5, 7, 9};
            int[] fl = mr;

            for(int i = 0; i< mr.Length; i++){
                Console.WriteLine($"{mr[i]}");
                b++;   
            }
            Console.WriteLine($"{b}");
            fl[2] = 19;

            for(int j = 0;j  <fl.Length; j++){
                Console.Write($"{fl[j]}, ");
            }

            fl = new int[]{3, 5, 7, 9};

            for(int p = 0; p < mr.Length; p++){
                Console.WriteLine($"{mr[p]}");
            }
        }
    }
}
