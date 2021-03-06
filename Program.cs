using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            string cebola = Console.ReadLine();

            string novaCebola = cebola.Replace("r", "l").Replace("R", "L");

            Console.WriteLine(novaCebola);
        }
    }
}
