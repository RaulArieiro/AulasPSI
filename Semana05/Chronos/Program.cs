using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch cron1 = new Stopwatch();
            Stopwatch cron2 = new Stopwatch();

            Console.WriteLine("Começou. ");
            cron1.Start();
            Thread.Sleep(1000);
            Console.WriteLine($"{cron1.ElapsedMilliseconds}");

            Console.WriteLine("Acabou! ");
            Console.WriteLine("Vamos de novo.");
            cron2.Start();
            Thread.Sleep(1000);
            Console.WriteLine($"{cron2.ElapsedMilliseconds}");
            Console.WriteLine("Termina.");

            cron1.Stop();
            cron2.Stop();

        }
    }
}
