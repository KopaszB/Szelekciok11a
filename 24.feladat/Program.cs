using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérek egy hónapot(1 - 12-ig): ");
            int honap = int.Parse(Console.ReadLine());

            if (honap == 12 || honap == 1 || honap == 2)
            {
                Console.WriteLine("Tél");
            }
            else if (honap == 3 || honap == 4 || honap == 5) 
            {
                Console.WriteLine("Tavasz");
            }
            else if (honap == 6 || honap == 7 || honap == 8)
            {
                Console.WriteLine("Nyár");
            }
            else if (honap == 9 || honap == 10 || honap == 11)
            {
                Console.WriteLine("Ősz");
            }
            else
            {
                Console.WriteLine("Nincs ilyen hónap!");
            }

            Console.ReadKey();
        }
    }
}
