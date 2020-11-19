using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            int antal = 0;
            Random slump = new Random();
            int slumpen = slump.Next(0, 101);
            Console.Write("Gissa slumptalet mellan 0 och 100: ");
            int tal = Convert.ToInt32(Console.ReadLine());
            antal++;
            {
                while (tal != slumpen)
                {
                    if (tal < slumpen)
                    {
                        Console.WriteLine("Gissningen är för låg");
                        Console.Write("Gissa igen: ");
                    }
                    else
                    {
                        Console.WriteLine("Gissningen är för hög");
                        Console.Write("Gissa igen: ");
                    }
                    tal = Convert.ToInt32(Console.ReadLine());
                    antal++;
                }
                Console.WriteLine("Rätt svar");
                Console.WriteLine("Antal försök: " + antal);
            }
            Console.ReadKey();
        }
    }
}
