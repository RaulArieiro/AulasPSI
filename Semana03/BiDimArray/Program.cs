using System;

namespace BiDimArray
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int hor;
            int ver;
            float[,] matriz;
            float[] array;
            float soma = 0; 

            Console.WriteLine("Escreva o valor de filas horizontais ");
            hor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escreva o volar de colunas verticais ");
            ver = Convert.ToInt32(Console.ReadLine());
            matriz = new float[ver,hor];
            array = new float[hor];

            for(int i =0; i< matriz.GetLength(0); i++){
                for(int j = 0; j < matriz.GetLength(1); j++){
                    for(int y = 0; y <matriz.GetLength(0); y++){
                        for(int q = 0; q< matriz.GetLength(1); q++ ){
                            Console.Write($"{matriz [y,q]} ");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("Incira um valor ");
                    float no = Convert.ToSingle(Console.ReadLine());
                    matriz[i,j] = no;
                    array [i]+= no;
                    
                }
                Console.WriteLine($"A media e {array[i] /hor }");
                Console.WriteLine();
            }for(int i =0;i <array.Length ; i++){
                 soma += array [i];

            }
            Console.WriteLine(soma)
        }
    }
}
