using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg az elért pontodat: ");
            int pontszam = int.Parse(Console.ReadLine());

            switch (pontszam)
            {
                case int x when x>0 && x<=39:
                    Console.WriteLine("1 - elégtelen");
                    break;
                case int x when x >= 40 && x <= 54:
                    Console.WriteLine("2 - elégséges");
                    break;
                case int x when x >= 55 && x <= 69:
                    Console.WriteLine("3 - közepes");
                    break;
                case int x when x >= 70 && x <= 84:
                    Console.WriteLine("4 - jó");
                    break;
                case int x when x >= 85 && x <= 100:
                    Console.WriteLine("5 - kitűnő");
                    break;

                default:
                    Console.WriteLine("Rossz pontszámot adtál!");
                    break ;
            }
            Console.ReadKey();
        }
    }
}
