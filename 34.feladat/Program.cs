using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem az x,y koordinátákat vesszővel elválasztva: ");
            string sor = Console.ReadLine();
            string[] darabol = sor.Split(',');
            int x = int.Parse(darabol[0]);
            int y = int.Parse(darabol[1]);

            if (x>0 && y>0)
            {
                Console.WriteLine("A pont az 1. síknegyedben van.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("A pont az 2. síknegyedben van.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("A pont az 3. síknegyedben van.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("A pont az 4. síknegyedben van.");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("A pont az origóban van.");
            }
            else if (x == 0)
            {
                Console.WriteLine("A pont az y-tengelyen van.");
            }
            else if (y == 0)
            {
                Console.WriteLine("A pont az x-tengelyen van.");
            }
            Console.ReadKey();
        }
    }
}
