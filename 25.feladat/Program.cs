using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kérjen be 2 számot és a nagyobbat ossza el a kisebbel! Az eredményt 2 tizedesjegy
pontossággal írja ki! (Nullával nem lehet osztani!)
*/
            Console.Write("Kérem az első számot: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("Kérem a második számot: ");
            int szam2 = int.Parse(Console.ReadLine());

            if (szam1>szam2) 
            {
                if (szam2==0)
                {
                    Console.WriteLine("Nullosztó!!!");
                }
                else
                {
                    Console.WriteLine($"{szam1} / {szam2} = {Math.Round((double)szam1 / szam2, 2)}");
                }
            }
            else if (szam2>szam1)
            {
                if (szam1==0)
                {
                    Console.WriteLine("Nullosztó!!!");
                }
                else
                {
                    Console.WriteLine($"{szam2} / {szam1} = {(double)szam2 / szam1:F2}");
                }
            }
            else
            {
                Console.WriteLine("A két szám egyenlő!");
            }

            Console.ReadKey();
        }
    }
}
