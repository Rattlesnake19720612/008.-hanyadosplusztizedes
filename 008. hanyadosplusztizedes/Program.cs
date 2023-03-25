using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008.hanyadosplusztizedes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot!");
            double szam1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kérek még egy számot!");
            double szam2 = Convert.ToDouble(Console.ReadLine());

            double osztas = szam1 / szam2;
            Console.WriteLine("A két szám hányadosa: " + osztas + "." + "\n");

            Console.ReadKey();
        }
    }
}
