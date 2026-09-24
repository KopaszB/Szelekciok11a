using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg az első számot:");
            int szam1 = int.Parse(Console.ReadLine());

            Console.Write("Add meg a második számot:");
            int szam2 = int.Parse(Console.ReadLine());

            if (szam1>szam2) 
            {
                Console.WriteLine($"Eredmény: {szam1 - szam2}");
            }
            else if (szam1<szam2)
            {
                Console.WriteLine($"Eredmény: {szam2 - szam1}");
            }
            else
            {
                Console.WriteLine($"{szam1} = {szam2}");
            }

            Console.ReadKey();
        }
    }
}
