using System;

namespace uppgift_2._3
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar ska du hyra bilen?");
            byte dagar = byte.Parse(Console.ReadLine());
            Console.WriteLine("Hur långt ska du köra?");
            short distans = short.Parse(Console.ReadLine());
            int pris = 300 + (dagar - 1) * 500 + distans;
            Console.WriteLine("Det kommer kosta " + pris + " kronor att hyra denna bilen");
            Console.Read();
        }
    }
}