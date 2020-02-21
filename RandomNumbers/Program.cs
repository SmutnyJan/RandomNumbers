using System;
using System.Diagnostics;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            bool pokracovat = true;
            int cislo = 0;
            while (pokracovat)
            {
                bool uhodnuto = false;
                Game game = new Game(0, 10);
                GuessResult guess; 
                while (uhodnuto == false) { 
                    Console.WriteLine("Zadej číslo: ");
                    sw.Start();
                    cislo = int.Parse(Console.ReadLine());
                    sw.Stop();
                    guess = game.Guess(cislo);
                    if (guess == GuessResult.IsLower) {
                        Console.WriteLine("Zadej větší");
                    }
                    else if (guess == GuessResult.IsGreater) {                 
                        Console.WriteLine("Zadej menší");
                    }
                    else { 
                        Console.WriteLine("Uhodnuto"); 
                        uhodnuto = true;
                    }
                }
                TimeSpan ts = sw.Elapsed;
                Console.WriteLine("Hledané číslo bylo {0}", cislo);
                Console.WriteLine("Počet pokusů: {0}", game.count);
                Console.WriteLine("Čas: {0}", ts.Seconds);
                
            }
        }
    }
}
