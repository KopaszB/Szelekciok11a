using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mennyi a víz hőmérséklete: ");
            int homerseklet = int.Parse(Console.ReadLine());

            if (homerseklet < 0)
            {
                Console.WriteLine("Jég");
            }
            else if (homerseklet>=100)
            {
                Console.WriteLine("Gőz");
            }
            else
            {
                Console.WriteLine("Folyadék");
            }
            
            Console.ReadKey();
        }
    }
}
