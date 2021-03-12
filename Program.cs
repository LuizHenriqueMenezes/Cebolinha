using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma frase, para simular a dislalia do Cebolinha: ")
            string cebola = Console.ReadLine();
            
            string novaCebola = cebola.Replace("r","l").Replace("rr","l").Replace("rR","l").Replace("R","L").Replace("RR","L").Replace("Rr","L");

            Console.WriteLine(novaCebola);
        }
    }
}
