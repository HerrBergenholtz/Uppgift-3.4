using System;

namespace Uppgift_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång är låten som du vill spela (skriv in det såhär \"3 30\" ");
            string längd = Console.ReadLine();
            int mellanslagsindex = längd.IndexOf(" ");
            int minut = int.Parse(längd[..mellanslagsindex]);
            int sekund = int.Parse(längd[(mellanslagsindex + 1)..]);

            int summaSekund = (minut*60 + sekund);

            if (summaSekund >165 && summaSekund< 260)
            {
                Console.WriteLine("Den får spelas");
            }
            else
            {
                Console.WriteLine("Den får inte spelas");
            }

            Console.ReadKey();
        }
    }
}