using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int pole;
            Console.WriteLine("Bok a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bok b:");
            b = Convert.ToInt32(Console.ReadLine());
            pole = a * b;
            Console.WriteLine("Pole:" + pole);
            Console.ReadKey(true);
        }
    }
}

