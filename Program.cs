using System;

namespace tabuada_auto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada 1-10");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"Tabuada do {i}");
                for (var cont = 0; cont < 11; cont++)
                {
                    int resu = i * cont;
                    Console.WriteLine($"{i} x {cont} = {resu}");
                }
                Console.WriteLine("----------------");
            }
        }
    }
}
